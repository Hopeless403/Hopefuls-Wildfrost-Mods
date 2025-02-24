using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using HarmonyLib;
using UnityExplorer;
using UnityExplorer.UI;
using System.Text;
using Deadpan.Enums.Engine.Components.Modding;
using NaughtyAttributes;
using UniverseLib;
using UnityEngine.Localization;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityExplorer.Inspectors;
using UnityExplorer.CacheObject;
using UnityExplorer.CacheObject.Views;
using Unity.Burst.Intrinsics;

namespace WildfrostHopeMod.CommandsConsole;

internal static class StringBuilderExt
{
    internal static StringBuilder AppendLineDepth(this StringBuilder builder, int tabDepth, object obj)
        => builder.AppendLine(new string('\t', tabDepth) + obj.ToString());
    internal static StringBuilder AppendDepth(this StringBuilder builder, int tabDepth, object obj)
        => builder.Append(new string('\t', tabDepth) + obj.ToString());
}
public partial class ConsoleCustom
{
    public static IEnumerator GetDatafileOptions(Console.Command command, string currentArgs)
    {
        string[] strArray = Console.Command.Split(currentArgs.TrimStart());
        command.predictedArgs = [];
        string typeName = strArray[0];
        if (typeName.IsEmpty() || (strArray.Length <= 1 && currentArgs.LastOrDefault() != ' '))
        {
            
            IEnumerable<Type> sourceType = WildfrostMod.AllDataTypes.Where(a => a.Name.ToLower().Contains(typeName.ToLower()));

            if (sourceType.Any())
            {
                command.predictedArgs = sourceType.Select(t => t.Name + " ").ToArray();
            }
        }
        else
        {
            IEnumerable<Type> sourceType = WildfrostMod.AllDataTypes.Where(a => string.Equals(a.Name, strArray[0], StringComparison.CurrentCultureIgnoreCase));
            if (sourceType.Any())
            {
                Type dataType = sourceType.First();
                string assetName = currentArgs.Remove(0, typeName.Length + 1);
                if (!AddressableLoader.IsGroupLoaded(dataType.Name)) yield return AddressableLoader.LoadGroup(dataType.Name);
                IEnumerable<DataFile> source = AddressableLoader.GetGroup<DataFile>(dataType.Name).Where(data =>
                {
                    string title = null;
                    if (dataType.GetProperty("title") != null)
                    {
                        if (dataType != typeof(KeywordData) || (bool)dataType.GetProperty("HasTitle").GetValue(data))
                            title = (string)dataType.GetProperty("title").GetValue(data) ?? "";
                    }
                    return data.name.ToLower().Contains(assetName.ToLower()) || (title?.ToLower().Contains(assetName.ToLower()) ?? false);
                });

                command.predictedArgs = source.Select(data =>
                {
                    string title = null;
                    if (dataType.GetProperty("title") != null)
                    {
                        if (dataType != typeof(KeywordData) || (bool)dataType.GetProperty("HasTitle").GetValue(data))
                            title = (string)dataType.GetProperty("title").GetValue(data) ?? "";
                    }
                    if (!title.IsNullOrEmpty()) return $"{dataType.Name} {data.name} \t// {title}";
                    else return $"{dataType.Name} {data.name}";
                }).ToArray();
            }
        }
    }

    public class CommandDataBuilderInfo : Console.Command
    {
        public override string id => "databuilder info";
        public override string format => "databuilder info <datatype> <name>";
        public override string desc => "(WIP) print a datafile's fields to console";
        public override bool IsRoutine => false;

        private static bool IsValidType(Type a) => a.BaseType == typeof(DataFile);

        public override void Run(string args)
        {
            if (args.Length > 0)
            {
                string[] strArray = Split(args);
                string typeName = strArray[0];
                IEnumerable<Type> sourceType = WildfrostMod.AllDataTypes.Where(a => IsValidType(a) && string.Equals(a.Name, typeName, StringComparison.CurrentCultureIgnoreCase));
                if (sourceType.Any())
                {
                    Type dataType = sourceType.First();
                    if (strArray.Length <= 1) Fail("Please provide a name!");
                    else
                    {
                        string assetName = args.Remove(0, typeName.Length + 1);
                        IEnumerable<DataFile> source = AddressableLoader.GetGroup<DataFile>(dataType.Name).Where(a => string.Equals(a.name, assetName, StringComparison.CurrentCultureIgnoreCase));
                        if (source.Any())
                        {
                            DataFile file = source.First();
                            string typeNameFull = Regex.Match(file.ToString(), @"\(([^)]+)\)$").Groups[1].Value;
                            Type dataTypeFull = Assembly.GetAssembly(dataType).GetType(typeNameFull);
                            Debug.LogWarning("[AConsole mod] Printing all fields of " + file);
                            file.PrintAllFields(dataTypeFull);
                            if (dataType != dataTypeFull) Debug.Log("the type used was " + dataTypeFull);
                        }
                        else Fail(strArray[0] + " [" + strArray[1] + "] does not exist!");
                    }
                }
                else Fail("DataType [" + strArray[0] + "] does not exist!");
            }
            else
            {
                if (Console.hover == null) Fail("Please hover over a card or provide more input to use this command");
                else Console.hover.data.PrintAllFields();
            }
        }

        public override IEnumerator GetArgOptions(string currentArgs) => GetDatafileOptions(this, currentArgs);

        
    }



    public partial class CommandDataBuilderOf : Console.Command
    {
        public override string id => "databuilder of";
        public override string format => "databuilder of <datatype> <name>";
        public override string desc => "print a possible databuilder to console";
        public override bool IsRoutine => true;
        public override bool hidden => true;

        private static bool IsValidType(Type a) => a.BaseType == typeof(DataFile);

        struct DatabuilderOutput
        {
            public string code;
            public object target;
        }

        public override IEnumerator Routine(string args)
        {
            DataFile file = null;
            //GetType().Assembly.GetTypes().Do(t => Debug.LogWarning(t.FullDescription()));
            if (args.Trim() == "this")
            {
                if (Console.hover)
                {
                    //Debug.LogWarning(new CardDataHandler().Info(Console.hover.data));
                    args = $"{nameof(CardData)} {Console.hover.data.name}";
                    file = Console.hover.data;
                }
                else
                {
                    Fail("Please hover over a card to use this command");
                    yield break;
                }
            }

            if (args.Length == 0)
            {
                Fail("Please provide args (for now)");
                yield break;
            }

            string[] strArray = Split(args);
            string typeName = strArray[0];
            IEnumerable<Type> sourceType = WildfrostMod.AllDataTypes.Where(a => IsValidType(a) && string.Equals(a.Name, typeName, StringComparison.CurrentCultureIgnoreCase));
            if (!sourceType.Any())
            {
                Fail($"DataType [{typeName}] does not exist!");
                yield break;
            }

            // based on the vanilla AddressableLoader groups, so modded classes extending them should work?
            Type dataType = sourceType.First();
            if (strArray.Length < 2)
            {
                Fail("Please provide a name!");
                yield break;
            }

            string assetName = args.Remove(0, typeName.Length + 1);
            IEnumerable<DataFile> source = AddressableLoader.GetGroup<DataFile>(dataType.Name).Where(a => string.Equals(a.name, assetName, StringComparison.CurrentCultureIgnoreCase));
            if (!source.Any())
            {
                Fail($"{typeName} [{assetName}] does not exist!");
                yield break;
            }

            file ??= source.First();
            string result = "";
            DatabuilderOutput target = default;
            ReflectionInspector inspector = default;
            switch (dataType.Name)
            {
                case nameof(CardData):
                    result = new CardDataHandler().Info(file as CardData)[2..];
                    break;
                case nameof(StatusEffectData):
                    result = new StatusEffectDataHandler().Info(file as StatusEffectData)[2..];
                    break;
                case nameof(CardUpgradeData):
                case nameof(UnlockData):
                case nameof(ChallengeData):
                case nameof(ChallengeListener):
                case nameof(TraitData):
                case nameof(ClassData):
                case nameof(EyeData):
                case nameof(GameMode):
                case nameof(GameModifierData):
                case nameof(BattleData):
                case nameof(BossRewardData):
                case nameof(BuildingPlotType):
                case nameof(BuildingType):
                case nameof(CardType):
                default:
                    result = new GenericDataHandler().Info(file)[2..];
                    break;
            }
            Debug.LogWarning(result.Replace("\t", "  "));

            if (!result.IsNullOrEmpty())
            {
                if (UnityExplorer.ExplorerStandalone.Instance == null)
                {
                    ExplorerStandalone.CreateInstance();
                    Debug.Log("THIS GUY IS WAITING MAYBE " + UIManager.Initializing);
                    yield return new WaitWhile(() => UIManager.Initializing);
                    yield return null;
                }
                target = new DatabuilderOutput() { code = result, target = file };
                InspectorManager.Inspect(target);
                inspector = InspectorManager.Inspectors?.FirstOrDefault(i => i is ReflectionInspector r && target.Equals(r?.Target)) as ReflectionInspector;
                if (inspector != default)
                {
                    UIManager.ShowMenu = true;
                    inspector.Tab.TabText.text = "Databuilder of " + file.name;
                    inspector.SetFilter("DatabuilderOutput.code", default);
                }
            }
        }

        public override IEnumerator GetArgOptions(string currentArgs)
        {
            string[] baseTypes = WildfrostMod.AllDataTypes.Select(t => t.Name).ToArray();
            string[] supportedTypes = [nameof(CardData), nameof(StatusEffectData)];

            predictedArgs = [];
            yield return GetDatafileOptions(this, currentArgs);
            predictedArgs = predictedArgs.Where(arg => baseTypes.Contains(Split(arg.Trim())[0]))
                .Select(arg => Split(arg).Length <= 1 && supportedTypes.All(type => !type.Contains(Split(arg.Trim())[0])) ? arg + " \t// More coming soon" : arg)
                .ToArray();

            if ("this".ToLower().Contains(currentArgs.Trim().ToLower()))
                predictedArgs = predictedArgs.With("this");
        }
        

        void ShowHelp(string text)
        {
            HelpPanelSystem.instance.title.SetText("");
            HelpPanelSystem.instance.note.SetText("");
            HelpPanelSystem.instance.body.SetText(text);
            SfxSystem.OneShot(HelpPanelSystem.instance.popUpSfx);
            HelpPanelSystem.instance.gameObject.SetActive(value: true);
            /*
            HelpPanelSystem.SetEmote(this.emote);
            HelpPanelSystem.SetImage(2f, 2f, this.helpSprite);*/
            HelpPanelSystem.SetBackButtonActive(true);
            //HelpPanelSystem.AddButton(HelpPanelSystem.ButtonType.Positive, this.buttonKey, "Select", new UnityAction(this.End));
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
                        workshop = workshop[..i] + $"Steam/steamapps/workshop/content/{SteamManager.appId}";
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
        internal static string GetTypeFields(Type dataType)
        {
            StringBuilder builder = new();
            builder.AppendLine(dataType.FullDescription());
            foreach (var field in FindFields(dataType))
            {
                var headerAttr = field.GetCustomAttribute<HeaderAttribute>();
                if (headerAttr != null && !headerAttr.header.IsNullOrWhitespace())
                    builder.AppendLine($"\n// {headerAttr.header}");

                var infoboxAttr = field.GetCustomAttribute<InfoBoxAttribute>();
                if (infoboxAttr != null && !infoboxAttr.Text.IsNullOrWhitespace())
                    builder.AppendLine($"\n// {infoboxAttr.Text}");

                if (defaultValues.TryGetValue(field, out var defaultValue))
                    builder.AppendLine($"{field}{defaultValue}");
                else
                    builder.AppendLine($"{field};");
                //builder.AppendLine($"({field.ReflectedType})\t{field}");
            }
            Debug.LogWarning(builder.ToString());
            return builder.ToString();
        }
    }




    public class CommandInspect : Console.Command
    {
        public override string id => "inspect";
        public override string format => "inspect <datatype> <name?> OR inspect this";
        public override string desc => "Inspects the corresponding/hovered DataFile";
        public override bool IsRoutine => true;

        private static bool IsValidType(Type a) => a.BaseType == typeof(DataFile) && AddressableLoader.groups.ContainsKey(a.Name);

        public override IEnumerator Routine(string args)
        {
            if (UnityExplorer.ExplorerStandalone.Instance == null)
            {
                //Debug.LogWarning("AYO WHERE IS THIS FOOL");
                /*WildfrostMod mod;
                if ((mod = Bootstrap.Mods.FirstOrDefault(mod => mod.GUID == "kopie.wildfrost.unityexplorer")) != null)
                    mod.ModLoad();
                else
                    Fail("Unity Explorer by Miya/Kopie must be loaded to use this command");
                return;*/
                ExplorerStandalone.CreateInstance();
                Debug.LogWarning("THIS GUY IS WAITING MAYBE " + UIManager.Initializing);
                yield return new WaitWhile(() => UIManager.Initializing); 
                yield return null;
            }
            Debug.LogWarning("WE GOT EM BOYS");
            if (args.Trim() == "this")
            {
                if (ConsoleMod.hover)
                {
                    UnityExplorer.InspectorManager.Inspect(ConsoleMod.hover);
                    UIManager.ShowMenu = true;
                }
                else if (Console.hover)
                {
                    UnityExplorer.InspectorManager.Inspect(Console.hover);
                    UIManager.ShowMenu = true;
                }
                else if (References.Map != null && References.Map.nodes.Any(node => node.IsHovered))
                {
                    var node = References.Map.nodes.First(node => node.IsHovered);
                    UnityExplorer.InspectorManager.Inspect(node);
                    UIManager.ShowMenu = true;
                }
                else
                    Fail("Please hover over a card/charm/map node to use this command");
                yield break;
            }

            if (args.Length > 0)
            {
                string[] strArray = Split(args);
                string typeName = strArray[0];
                IEnumerable<Type> sourceType = WildfrostMod.AllDataTypes.Where(a => IsValidType(a) && string.Equals(a.Name, typeName, StringComparison.CurrentCultureIgnoreCase));
                if (sourceType.Any())
                {
                    Type dataType = sourceType.First();
                    if (strArray.Length < 2)
                    {
                        UnityExplorer.InspectorManager.Inspect(AddressableLoader.GetGroup<DataFile>(dataType.Name));
                        UIManager.ShowMenu = true;
                    }
                    else
                    {
                        string assetName = args.Remove(0, typeName.Length + 1);
                        IEnumerable<DataFile> source = AddressableLoader.GetGroup<DataFile>(dataType.Name).Where(data => string.Equals(data.name, assetName, StringComparison.CurrentCultureIgnoreCase));
                        if (source.Any())
                        {
                            DataFile file = source.First();
                            UnityExplorer.InspectorManager.Inspect(AddressableLoader.GetGroup<DataFile>(dataType.Name).First(data => string.Equals(data.name, assetName, StringComparison.CurrentCultureIgnoreCase)));
                            UIManager.ShowMenu = true;
                        }
                        else Fail(strArray[0] + " [" + strArray[1] + "] does not exist!");
                    }
                }
                else Fail("DataFile Type [" + strArray[0] + "] does not exist!");
            }
            else Fail("Please provide a DataFile Type (and DataFile object name)");
        }

        public override IEnumerator GetArgOptions(string currentArgs)
        {
            yield return GetDatafileOptions(this, currentArgs);
            if ("this".ToLower().Contains(currentArgs.Trim().ToLower()))
                predictedArgs = predictedArgs.With("this");
        }
    }
}
