using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HarmonyLib;
using System.Text;
using System;
using UnityEngine.Localization;
using UnityEngine.AddressableAssets;
using NaughtyAttributes;
using System.Collections;
using UnityEngine.Localization.Tables;
using UnityEngine.Localization.Settings;
using UniverseLib;
using Il2CppInterop.Runtime.InteropTypes;

namespace WildfrostHopeMod.CommandsConsole
{
    public class Scriptable<T> where T : ScriptableObject, new()
    {
        readonly Action<T> modifier;
        public Scriptable() { }
        public Scriptable(Action<T> modifier) { this.modifier = modifier; }
        public static implicit operator T(Scriptable<T> scriptable)
        {
            T result = ScriptableObject.CreateInstance<T>();
            scriptable.modifier?.Invoke(result);
            return result;
        }
    }
    public partial class ConsoleCustom
    {
        public partial class CommandDataBuilderOf
        {
            public abstract class DataHandler<T> where T : DataFile
            {
                public abstract HashSet<string> ManagedFields { get; }
                public List<PropertyInfo> GetUnmanagedFields(T data) 
                    => FindFields(data.GetType())
                    .Where(f => !ManagedFields.Contains(f.Name)).ToList();

                public T InstantiateDefault(T data) => ScriptableObject.CreateInstance<T>() as T;

                public abstract string Info(T data);

                public StringBuilder AppendCodeDependencies(StringBuilder builder, Type actualType, bool recursive = true)
                {
                    
                        return builder;
                    /*builder.AppendLine("");
                    builder.AppendLine("#region Code dependencies");
                    try
                    {
                        var assemblyResolver = new ICSharpCode.Decompiler.Metadata.UniversalAssemblyResolver(
                                    mainAssemblyFileName: actualType.Assembly.Location,
                                    throwOnError: false,
                                    targetFramework: ".NETFramework,Version=4.7.2");
                        string workshop = Application.dataPath;
                        int i = workshop.IndexOf("Steam/steamapps/");
                        string local = System.IO.Path.Combine(Application.streamingAssetsPath, "Mods");

                        if (i != -1)
                            workshop = workshop[..i] + $"Steam/steamapps/workshop/content/{SteamManager.appId}";
                        System.IO.Directory.GetDirectories(workshop).Update(assemblyResolver.AddSearchDirectory);
                        System.IO.Directory.GetDirectories(local).Update(assemblyResolver.AddSearchDirectory);

                        while (actualType.Assembly != typeof(DataFile).Assembly)
                        {
                            Debug.LogError("[AConsole] TRYING TO DECOMPILE " + actualType.FullName);

                            var decompiler = new ICSharpCode.Decompiler.CSharp.CSharpDecompiler(
                                fileName: actualType.Assembly.Location,
                                assemblyResolver: assemblyResolver,
                                settings: new ICSharpCode.Decompiler.DecompilerSettings(ICSharpCode.Decompiler.CSharp.LanguageVersion.Latest)
                                );
                            builder.AppendLine("");

                            builder.AppendLine(decompiler.DecompileTypeAsString(new(actualType.FullName)));
                            actualType = actualType.BaseType;

                            if (!recursive) break;
                        }
                    }
                    catch { }
                    return builder.AppendLine("#endregion");*/
                }
                public static StringTable GetCollection(string name, UnityEngine.Localization.Locale identifier)
                {
                    
                    string key = name + "_" + identifier.Formatter;
                    StringTable collection1 = Addressables.LoadAssetAsync<StringTable>((Il2CppSystem.Object)key).WaitForCompletion();
                    return collection1;
                }
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

                        //nameof(ScriptAddEnemies.Profile);
                        var table = Addressables.LoadAssetAsync<StringTable>(locStr.TableReference.TableCollectionName + "_en").WaitForCompletion();
                        //Debug.Log((locStr.TableReference.TableCollectionName + "_en", table).ToString());
                        string tableEntryKey = table?.GetEntry(locStr.TableEntryReference.KeyId)?.Key ?? locStr.TableEntryReference.KeyId.ToString();
                        builder.AppendLine($"Extensions.GetLocalizedString(\"{locStr.TableReference.TableCollectionName}\", \"{tableEntryKey}\")");
                        builder.AppendLineDepth(tabDepth, "// " + locStr.GetLocalizedString());
                        //TableReference(775758c0-ba0d-2a84-984c-7ae6ac6e5feb - Card Text)/TableEntryReference(324785676087296 - Apply X);
                    }

                    else if (obj is AssetReference assetReference)
                    {
                        string key = Addressables.LoadResourceLocationsAsync(assetReference).WaitForCompletion()[0]?.PrimaryKey;
                        builder.Append($"new {assetReference.GetType().FullDescription().Replace('+', '.')}(\"{key}\")");
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
                    else if (obj is ScriptAddEnemies.Profile profile)
                    {
                        var validFields = profile.GetType().GetProperties().Where(field => field is PropertyInfo fieldInfo
                        && fieldInfo.CanWrite
                        && fieldInfo.Name != nameof(ScriptableObject.m_CachedPtr)
                        && fieldInfo.Name != nameof(ScriptableObject.hideFlags)
                        );
                        if (!validFields.Any())
                        {
                            return builder.Append($"new ScriptAddEnemies.Profile()").ToString();
                        }
                        static string GetInitials(string str)
                        {
                            if (str.IsNullOrEmpty()) return "t";
                            char[] uppers = str.Where(c => c >= 'A' && c <= 'Z').ToArray();
                            return new string(uppers);
                        }
                        var objName = GetInitials(objType.FullDescription().Replace('+', '.')).ToLower();

                        builder.AppendLine($"new ScriptAddEnemies.Profile");
                        builder.AppendLineDepth(tabDepth, $"{{");
                        tabDepth++;
                        foreach (var field in validFields)
                        {
                            builder.AppendDepth(tabDepth, $"{objName}.{field.Name} = " + Print((field as PropertyInfo).GetValue(profile), tabDepth, ignoreFirstTab: true))
                                   .AppendLine(";");
                        }

                        tabDepth--;
                        builder.AppendDepth(tabDepth, $"}})");
                    }
                    else if (obj is ScriptableObject scriptable)
                    {
                        //Debug.LogWarning("Testing " + scriptable.name);
                        var possibleTypes = BepInExv.ConsoleMod.allTypes.Where(objType.IsAssignableFrom);
                        System.Type actualType = null;
                        object actualObj = null;
                        foreach (var type in possibleTypes)
                        {
                            //Debug.Log("test type " + type.Name);
                            actualObj = typeof(Il2CppObjectBase)
                                .GetMethod(nameof(Il2CppObjectBase.TryCast))
                                .MakeGenericMethod(type)
                                .Invoke(obj, null);
                            if (actualObj != null)
                            {
                                //Debug.LogError("GOT type " + type.Name);
                                actualType = type;
                                break;
                            }
                        }
                        if (actualType == null) return builder.ToString();
                        //Debug.Log($"OBJ [{actualObj} ({actualObj.GetType()})] IS TYPE " + actualType.FullDescription());

                        var validFields = FindFields(actualType).Where(field => field is PropertyInfo fieldInfo && 
                        !(fieldInfo.Name == "not" && fieldInfo.GetValue(actualObj).Equals(false))
                        && fieldInfo.Name != nameof(ScriptableObject.m_CachedPtr)
                        && fieldInfo.Name != nameof(ScriptableObject.hideFlags)
                        );
                        if (!validFields.Any())
                        {
                            return builder.Append($"new Scriptable<{actualType.FullName.Replace('+', '.')}>()").ToString();
                        }
                        static string GetInitials(string str)
                        {
                            if (str.IsNullOrEmpty()) return "t";
                            char[] uppers = str.Where(c => c >= 'A' && c <= 'Z').ToArray();
                            return new string(uppers);
                        }
                        var objName = GetInitials(objType.FullDescription().Replace('+', '.')).ToLower();

                        builder.AppendLine($"new Scriptable<{actualType.FullName.Replace('+', '.')}>({objName} =>");
                        builder.AppendLineDepth(tabDepth, $"{{");
                        tabDepth++;
                        foreach (var field in validFields)
                        {
                            builder.AppendDepth(tabDepth, $"{objName}.{field.Name} = " + Print((field as PropertyInfo).GetValue(actualObj), tabDepth, ignoreFirstTab: true))
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
                                builder.AppendDepth(tabDepth, $"{{ {Print(entry.Key, tabDepth, ignoreFirstTab:true)}, {Print(entry.Value, tabDepth, ignoreFirstTab: true)} }}").AppendLine(",");
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
                        //AccessTools.IsStruct(objType);
                        MemberInfo[] members = objType.GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

                        HashSet<string> names = members.Select(m => m.Name).ToHashSet();
                        var fields = members
                            .Where(f
                            => !names.Contains("add_" + f.Name) // deal with events
                            && f is FieldInfo field
                            /*&& (field.IsPublic || field.GetCustomAttribute<SerializeField>() != null)
                            && (field.GetCustomAttribute<HideInInspector>() == null)
                            && (field.GetCustomAttribute<ReadOnlyAttribute>() == null) // unstable; use with debug mode probably
                            */);
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
            }
        }
    }
}