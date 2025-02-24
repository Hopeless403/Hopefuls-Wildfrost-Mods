/*using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;
using UnityEngine;
using NaughtyAttributes;

namespace WildfrostHopeMod.Utils
{
    internal class More_Mod_References
    {
        public static string Print<Y>(Y obj, int tabDepth = 0, bool ignoreFirstTab = false)
        {
            Type objType = obj.GetType();

            StringBuilder builder = new StringBuilder().AppendDepth(ignoreFirstTab ? 0 : tabDepth, "");

            if (tabDepth >= 10)
                return builder.ToString();

            if (obj is FMODUnity.EventReference fmodRef)
            {
                if (fmodRef.IsNull)
                    return builder.Append("null").ToString();

                var studio = FMODUnity.RuntimeManager.StudioSystem;
                if (studio.isValid())
                {
                    studio.lookupPath(fmodRef.Guid, out string path);
                    FMODUnity.RuntimeManager.PathToEventReference(path);
                    return builder.Append($"FMODUnity.RuntimeManager.PathToEventReference(\"{path}\")").ToString();
                };

                // continue with check, up to the ValueType check for default
            }

            if (objType == typeof(string))
            {
                var str = obj.ToString();
                if (str.Contains('\n'))
                {
                    builder.AppendLine("\"\"\"");
                    foreach (var line in str.Split('\n'))
                        builder.AppendLineDepth(tabDepth, line);
                    return builder.AppendDepth(tabDepth, "\"\"\"").ToString();
                }
                return builder.Append($"\"{obj}\"").ToString();
            }
            else if (objType == typeof(bool) && obj is bool b)
                return builder.Append(b ? "true" : "false").ToString();
            else if (objType == typeof(int))
                return builder.Append($"{obj}").ToString();
            else if (objType == typeof(float))
                return builder.Append($"{obj}F").ToString();
            else if (objType == typeof(long))
                return builder.Append($"{obj}L").ToString();
            else if (objType.IsEnum)
            {
                return builder.Append($"{objType.FullName.Replace('+', '.')}.{obj}").ToString();
            }

            else if (obj is LocalizedString locStr)
            {
                if (locStr == null || locStr.IsEmpty)
                    return builder.Append("null").ToString();

                string tableEntryKey = LocalizationHelper.GetCollection(locStr.TableReference.TableCollectionName, SystemLanguage.English).GetEntry(locStr.TableEntryReference.KeyId)?.Key
                    ?? locStr.TableEntryReference.Key;
                builder.Append($"Extensions.GetLocalizedString(\"{locStr.TableReference.TableCollectionName}\", \"{tableEntryKey}\")");
                //TableReference(775758c0-ba0d-2a84-984c-7ae6ac6e5feb - Card Text)/TableEntryReference(324785676087296 - Apply X);
            }

            else if (obj is AssetReference assetReference)
            {
                string key = Addressables.LoadResourceLocationsAsync(assetReference).WaitForCompletion().First()?.PrimaryKey;
                builder.Append($"new {assetReference.GetType().FullName}(\"{key}\")");
            }

            else if (obj is DataFile dataFile)
            {
                var sourceType = objType;
                if (obj is not StatusEffectData)
                {
                    while (sourceType.BaseType != typeof(DataFile)) sourceType = sourceType.BaseType;
                }

                builder.Append($"TryGet<{sourceType}>(\"{dataFile.name}\")");
            }

            else if (obj is ScriptableObject scriptable)
            {
                var validFields = FindFields(scriptable.GetType()).Where(field => field is FieldInfo fieldInfo && !(fieldInfo.Name == "not" && fieldInfo.GetValue(scriptable).Equals(false)));
                if (!validFields.Any())
                {
                    return builder.Append($"new Scriptable<{objType.FullDescription().Replace('+', '.')}>()").ToString();
                }
                static string GetInitials(string str)
                {
                    if (str.IsNullOrEmpty()) return "t";
                    char[] uppers = str.Where(c => c >= 'A' && c <= 'Z').ToArray();
                    return new string(uppers);
                }
                var objName = GetInitials(objType.FullDescription().Replace('+', '.')).ToLower();

                builder.AppendLine($"new Scriptable<{objType.FullDescription().Replace('+', '.')}>({objName} =>");
                builder.AppendLineDepth(tabDepth, $"{{");
                tabDepth++;
                foreach (var field in validFields)
                {
                    builder.AppendDepth(tabDepth, $"{objName}.{field.Name} = " + Print((field as FieldInfo).GetValue(scriptable), tabDepth, ignoreFirstTab: true))
                           .AppendLine(";");
                }

                tabDepth--;
                builder.AppendDepth(tabDepth, $"}})");
            }


            else if (obj is IEnumerable<object> enumerable)
            {
                string typename = objType.FullDescription().Replace('+', '.');
                if (objType.Namespace == "System.Collections.Generic")
                    typename = typename.Remove(0, "System.Collections.Generic.".Length);

                if (!enumerable.Any())
                    return builder.Append($"new {typename}{{}}").ToString();

                builder.AppendLine($"new {typename}");
                builder.AppendLineDepth(tabDepth, $"{{");
                tabDepth++;
                foreach (var y in enumerable)
                    builder.AppendDepth(tabDepth, Print(y, tabDepth, ignoreFirstTab: true)).AppendLine(",");
                tabDepth--;
                builder.AppendDepth(tabDepth, $"}}");
            }

            else if (obj is Array array)
            {
                if (array.Length == 0)
                    return builder.Append($"new {objType.FullDescription().Replace('+', '.')}{{}}").ToString();

                builder.AppendLine($"new {objType.FullDescription().Replace('+', '.')}");
                builder.AppendLineDepth(tabDepth, $"{{");
                tabDepth++;
                foreach (var y in array)
                    builder.AppendDepth(tabDepth, Print(y, tabDepth, ignoreFirstTab: true)).AppendLine(",");
                tabDepth--;
                builder.AppendDepth(tabDepth, $"}}");
            }

            else if (obj is IDictionary dict)
            {
                new Dictionary<string, object>
                        {
                            { "owo", null }
                        };

                if (dict.Count == 0)
                    return builder.Append($"new {objType.FullDescription().Replace('+', '.')}{{}}").ToString();

                builder.AppendLine($"new {objType.FullDescription().Replace('+', '.')}");
                builder.AppendLineDepth(tabDepth, $"{{");
                tabDepth++;
                foreach (var y in dict)
                {
                    if (y is System.Collections.DictionaryEntry entry)
                    {
                        builder.AppendDepth(tabDepth, $"{{ {Print(entry.Key, tabDepth, ignoreFirstTab: true)}, {Print(entry.Value, tabDepth, ignoreFirstTab: true)} }}").AppendLine(",");
                    }
                    else builder.AppendDepth(tabDepth, Print(y, tabDepth, ignoreFirstTab: true)).AppendLine(",");
                }

                tabDepth--;
                builder.AppendDepth(tabDepth, $"}}");
            }

            else if (obj is Sprite sprite)
            {
                builder.Append($"{obj} // This requires an external SpriteAtlas which couldn't be found");
                //Sprite.Create(sprite.texture, sprite.rect, sprite.pivot, sprite.pixelsPerUnit, 0, sprite.packingMode, sprite.border);
            }

            else if (obj is CardData.StatusEffectStacks stack)
            {
                builder.Append($"new CardData.StatusEffectStacks(Get<StatusEffectData>(\"{stack.data.name}\"), {stack.count})");
            }

            else if (obj is CardData.TraitStacks trait)
            {
                builder.Append($"new CardData.TraitStacks(Get<TraitData>(\"{trait.data.name}\"), {trait.count})");
            }

            else if (obj is TextAsset textAsset)
            {
                return builder.Append($"new {objType.FullDescription()}({Print(textAsset.text, tabDepth, ignoreFirstTab)})").ToString();
            }

            else if (obj is MonoBehaviour behaviour)
            {
                builder.Append($"{obj} // This requires an external GameObject which couldn't be found");
            }

            else if (obj is Color color)
            {
                return builder.Append($"new Color({color.r}f, {color.g}f, {color.b}f, {color.a}f)").ToString();
            }
            else if (obj is ValueType valueType && objType.IsValueType && !objType.IsPrimitive && (objType.Namespace == null || !objType.Namespace.StartsWith("System.")))
            {
                MemberInfo[] members = objType.GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

                HashSet<string> names = members.Select(m => m.Name).ToHashSet();
                var fields = members
                    .Where(f
                    => !names.Contains("add_" + f.Name) // deal with events
                    && f is FieldInfo field
                    && (field.IsPublic || field.GetCustomAttribute<SerializeField>() != null)
                    && (field.GetCustomAttribute<HideInInspector>() == null)
                    && (field.GetCustomAttribute<ReadOnlyAttribute>() == null) // unstable; use with debug mode probably
                    );
                var validFields = fields.OfType<FieldInfo>().ToArray();

                if (!validFields.Any())
                {
                    return builder.Append($"new {objType.FullDescription().Replace('+', '.')}()").ToString();
                }

                builder.AppendLine($"new {objType.FullDescription().Replace('+', '.')}()");
                builder.AppendLineDepth(tabDepth, $"{{");
                tabDepth++;
                foreach (var field in validFields)
                {
                    builder.AppendDepth(tabDepth, $"{field.Name} = " + Print(field.GetValue(valueType), tabDepth, ignoreFirstTab: true))
                           .AppendLine(",");
                }
                tabDepth--;
                builder.AppendDepth(tabDepth, $"}})");
            }

            else
            {
                builder.Append(obj);
            };
            return builder.ToString();
        }
        class MemberInfoComparer : IEqualityComparer<MemberInfo>
        {
            public bool Equals(MemberInfo x, MemberInfo y)
                => x.ToString() == y.ToString();

            public int GetHashCode(MemberInfo obj)
                => obj.ToString().GetHashCode();

        }

        // memoization pog
        static readonly Dictionary<Type, List<MemberInfo>> typeMembers = [];
        static readonly Dictionary<MemberInfo, object> defaultValues = [];
        internal static List<MemberInfo> FindFields(Type dataType)
        {
            if (!typeof(ScriptableObject).IsAssignableFrom(dataType) || dataType == typeof(ScriptableObject))
                return [];
            if (!typeMembers.ContainsKey(dataType))
            {
                MemberInfo[] members = dataType.GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

                HashSet<string> names = members.Select(m => m.Name).ToHashSet();
                var fields = members
                    .Where(f
                    => !names.Contains("add_" + f.Name) // deal with events
                    && f is FieldInfo field
                    && (field.IsPublic || field.GetCustomAttribute<SerializeField>() != null)
                    && (field.GetCustomAttribute<HideInInspector>() == null)
                    && (field.GetCustomAttribute<ReadOnlyAttribute>() == null) // unstable; use with debug mode probably
                    );

                typeMembers[dataType] = FindFields(dataType.BaseType).Concat(fields).Distinct(new MemberInfoComparer()).ToList();

                try
                {
                    var assemblyResolver = new ICSharpCode.Decompiler.Metadata.UniversalAssemblyResolver(
                                mainAssemblyFileName: dataType.Assembly.Location,
                                throwOnError: false,
                                targetFramework: ".NET Framework,Version=4.7.2");
                    string workshop = Application.dataPath;
                    int i = workshop.IndexOf("Steam/steamapps/");
                    string local = System.IO.Path.Combine(Application.streamingAssetsPath, "Mods");

                    if (i != -1)
                        workshop = workshop.Substring(0, i) + $"Steam/steamapps/workshop/content/{SteamManager.appId}";
                    System.IO.Directory.GetDirectories(workshop).Update(assemblyResolver.AddSearchDirectory);
                    System.IO.Directory.GetDirectories(local).Update(assemblyResolver.AddSearchDirectory);

                    var decompiler = new ICSharpCode.Decompiler.CSharp.CSharpDecompiler(
                        fileName: dataType.Assembly.Location,
                        assemblyResolver: assemblyResolver,
                        settings: new ICSharpCode.Decompiler.DecompilerSettings(ICSharpCode.Decompiler.CSharp.LanguageVersion.Latest)
                        );
                    string decompiled = decompiler.DecompileTypeAsString(new(dataType.FullName));

                    foreach (var field in fields)
                    {
                        // match for parts of the string that go like
                        // field;
                        // field = yadayada;
                        // field = yadayada{
                        //  };
                        Match match = new Regex($@"{field.Name};|{field.Name} = ([^;]*)*;").Match(decompiled);
                        if (match.Success)
                        {
                            defaultValues[field] = match.Captures[0].Value.Replace(field.Name, "");
                        }
                    }
                }
                catch { }
            }

            return typeMembers[dataType];
        }
    }
    internal static class StringBuilderExt
    {
        internal static StringBuilder AppendLineDepth(this StringBuilder builder, int tabDepth, object obj)
            => builder.AppendLine(new string('\t', tabDepth) + obj.ToString());
        internal static StringBuilder AppendDepth(this StringBuilder builder, int tabDepth, object obj)
            => builder.Append(new string('\t', tabDepth) + obj.ToString());
    }
}
*/