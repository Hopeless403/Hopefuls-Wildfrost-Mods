using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using HarmonyLib;
using static Mono.Security.X509.X520;
using UnityExplorer;
using UnityExplorer.UI;
using System.Text;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using NaughtyAttributes;
using JetBrains.Annotations;
using static Rewired.Utils.Classes.Data.TypeWrapper;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleCustom
    {
        public static IEnumerator GetDatafileOptions(Console.Command command, string currentArgs)
        {
            string[] strArray = Console.Command.Split(currentArgs.TrimStart());
            command.predictedArgs = [];
            string typeName = strArray[0];
            if (typeName.IsEmpty() || (strArray.Length <= 1 && currentArgs.LastOrDefault() != ' '))
            {
                IEnumerable<Type> sourceType = Assembly.GetAssembly(typeof(DataFile)).GetTypes().Where(a => (a.BaseType == typeof(DataFile) || a.BaseType == typeof(ScriptableObject)) && AddressableLoader.groups.ContainsKey(a.Name) && a.Name.ToLower().Contains(typeName.ToLower()));

                if (sourceType.Any())
                {
                    command.predictedArgs = sourceType.Select(t => t.Name + " ").ToArray();
                }
            }
            else
            {
                IEnumerable<Type> sourceType = Assembly.GetAssembly(typeof(DataFile)).GetTypes().Where(a => a.BaseType == typeof(DataFile) && AddressableLoader.groups.ContainsKey(a.Name) && string.Equals(a.Name, strArray[0], StringComparison.CurrentCultureIgnoreCase));
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
                        if (!title.IsNullOrEmpty()) return $"{dataType} {data.name} // {title}";
                        else return $"{dataType} {data.name}";
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
                    IEnumerable<Type> sourceType = Assembly.GetAssembly(typeof(DataFile)).GetTypes().Where(a => IsValidType(a) && string.Equals(a.Name, typeName, StringComparison.CurrentCultureIgnoreCase));
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



        public class CommandDataBuilderOf : Console.Command
        {
            public override string id => "databuilder of";
            public override string format => "databuilder of <datatype> <name>";
            public override string desc => "print a possible databuilder to console";
            public override bool IsRoutine => false;
            public override bool hidden => true;

            private static bool IsValidType(Type a) => a.BaseType == typeof(DataFile);

            public override void Run(string args)
            {
                if (args.Trim() == "this")
                {
                    if (Console.hover)
                        Debug.LogWarning(CardDataBuilderInfo(Console.hover.data));
                    else
                        Fail("Please hover over a card to use this command");
                    return;
                }

                if (args.Length > 0)
                {
                    string[] strArray = Split(args);
                    string typeName = strArray[0];
                    IEnumerable<Type> sourceType = Assembly.GetAssembly(typeof(DataFile)).GetTypes().Where(a => IsValidType(a) && string.Equals(a.Name, typeName, StringComparison.CurrentCultureIgnoreCase));
                    if (sourceType.Any())
                    {
                        Type dataType = sourceType.First();
                        if (strArray.Length < 2) Fail("Please provide a name!");
                        else
                        {
                            string assetName = args.Remove(0, typeName.Length + 1);
                            IEnumerable<DataFile> source = AddressableLoader.GetGroup<DataFile>(dataType.Name).Where(a => string.Equals(a.name, assetName, StringComparison.CurrentCultureIgnoreCase));
                            if (source.Any())
                            {
                                DataFile file = source.First();
                                string result = $"new {dataType}Builder(this)";
                                switch (dataType.Name)
                                {
                                    case nameof(CardData):
                                        var data = file as CardData;
                                        Debug.LogWarning(CardDataBuilderInfo(data));
                                        break;
                                    case nameof(CardUpgradeData):
                                    case nameof(UnlockData):
                                    case nameof(ChallengeData):
                                    case nameof(ChallengeListener):
                                        Debug.Log("There is a builder for this guy. Good job"); break;
                                    case nameof(TraitData):
                                    case nameof(ClassData):
                                    case nameof(EyeData):
                                    case nameof(GameMode):
                                    case nameof(GameModifierData):
                                    case nameof(StatusEffectData):
                                    case nameof(BattleData):
                                    case nameof(BuildingPlotType):
                                    case nameof(BuildingType):
                                    case nameof(CardType):
                                        Debug.Log("There is NO builder for this guy. BAD job"); break;
                                    default:
                                        Debug.Log("You shouldn't be seeing this.\nTell me on Discord (@Hopeful) about it"); break;
                                }
                            }
                            else Fail(strArray[0] + " [" + strArray[1] + "] does not exist!");
                        }
                    }
                    else Fail("DataType [" + strArray[0] + "] does not exist!");
                }
                else Fail("Please provide args (for now)");
            }

            public override IEnumerator GetArgOptions(string currentArgs)
            {
                string[] supportedTypes = [nameof(CardData)];
                yield return GetDatafileOptions(this, currentArgs);
                predictedArgs = predictedArgs.Where(arg => supportedTypes.Contains(Split(arg.Trim())[0]))
                    .Select(arg => Split(arg).Length <= 1 ? arg + " // More coming soon" : arg)
                    .ToArray();

                if ("this".ToLower().Contains(currentArgs.Trim().ToLower()))
                    predictedArgs = predictedArgs.With("this");

            }
            public string CardDataBuilderInfo(CardData data)
            {

                var info = new CardDataInfo(data);
                StringBuilder builder = new("new CardDataBuilder(this)\n");
                builder.Append($"\t.Create{(info.IsUnit ? "Unit" : "Item")}(");
                builder.Append($"name:\"{info.name}\", englishTitle:\"{info.englishTitle}\"");

                if (info.IsUnit && info.bloodProfile != default)
                    builder.Append($", bloodProfile:\"{info.bloodProfile}\"");
                if (info.idleAnim != default)
                    builder.Append($", idleAnim:\"{info.idleAnim}\"");
                builder.AppendLine(")");
                if (info.cardType != "Friendly" && info.cardType != "Item")
                    builder.AppendLine($"\t.WithCardType({info.cardType})");


                foreach (var text in info.titles) if (!text.Value.IsNullOrEmpty() && text.Key != SystemLanguage.English)
                        builder.AppendLine($"\t.WithTitle(\"{text.Value}\", SystemLanguage.{text.Key})");
                foreach (var text in info.descriptions) if (!text.Value.IsNullOrEmpty())
                        builder.AppendLine($"\t.WithText(\"{text.Value}\", SystemLanguage.{text.Key})");
                foreach (var text in info.flavours) if (!text.Value.IsNullOrEmpty())
                        builder.AppendLine($"\t.WithFlavour(\"{text.Value}\", SystemLanguage.{text.Key})");

                builder.AppendLine($"\t.SetStats({(info.stats.health.HasValue ? info.stats.health : "null")}, {(info.stats.attack.HasValue ? info.stats.attack : "null")}, {info.stats.counter})");
                builder.AppendLine($"\t.SetSprites(\"{info.name}_mainSprite.png\", \"{info.name}_BG.png\")");
                builder.AppendLine($"\t.WithPools({string.Join(", ", info.pools.Select(p => $"\"{p}\"").DefaultIfEmpty(""))})");
                builder.AppendLine($"\t.WithValue({info.value})");

                if (info.startEffectStacks.Any() || info.attackEffectStacks.Any() || info.traitStacks.Any())
                {
                    builder.AppendLine($"\t.SubscribeToAfterAllBuildEvent(card =>\n\t{{");
                    if (info.attackEffectStacks.Any())
                    {
                        builder.AppendLine($"\t\tcard.attackEffects = new CardData.StatusEffectStacks[]");
                        builder.AppendLine($"\t\t{{");
                        foreach (var stack in info.attackEffectStacks)
                            builder.AppendLine($"\t\t\tnew CardData.StatusEffectStacks(Get<StatusEffectData>(\"{stack.data.name}\"), {stack.count}),");
                        builder.AppendLine($"\t\t}};");
                    }
                    if (info.startEffectStacks.Any())
                    {
                        builder.AppendLine($"\t\tcard.startWithEffects = new CardData.StatusEffectStacks[]");
                        builder.AppendLine($"\t\t{{");
                        foreach (var stack in info.startEffectStacks)
                            builder.AppendLine($"\t\t\tnew CardData.StatusEffectStacks(Get<StatusEffectData>(\"{stack.data.name}\"), {stack.count}),");
                        builder.AppendLine($"\t\t}};");
                    }
                    if (info.traitStacks.Any())
                    {
                        builder.AppendLine($"\t\tcard.traits = new CardData.StatusEffectStacks[]");
                        builder.AppendLine($"\t\t{{");
                        foreach (var stack in info.traitStacks)
                            builder.AppendLine($"\t\t\tnew CardData.StatusEffectStacks(Get<StatusEffectData>(\"{stack.data.name}\"), {stack.count}),");
                        builder.AppendLine($"\t\t}};");
                    }
                    builder.AppendLine($"\t}})");
                }
                return builder.ToString();
            }

            public struct CardDataInfo
            {
                public string cardType = "Friendly";

                public string name;
                public string englishTitle;
                public Dictionary<SystemLanguage, string> titles = [];
                public Dictionary<SystemLanguage, string> descriptions = [];
                public Dictionary<SystemLanguage, string> flavours = [];
                public string bloodProfile = "BloodProfileNormal";
                public string idleAnim = "SwayAnimationProfile";
                public (int? health, int? attack, int counter) stats;
                public CardData.StatusEffectStacks[] attackEffectStacks = [];
                public CardData.StatusEffectStacks[] startEffectStacks = [];
                public CardData.TraitStacks[] traitStacks = [];
                public List<string> pools = [];
                public int value = 50;

                public bool IsUnit;
                [HideIf("IsUnit")]
                public bool IsPlayableItem;

                public CardDataInfo(CardData data)
                {
                    this.cardType = data.cardType.name;
                    this.IsUnit = data.cardType.unit;
                    this.IsPlayableItem = !this.IsUnit && data.playType.HasFlag(Card.PlayType.Play);

                    this.name = data.name;

                    Locale[] originalLocaleOverrides = [
                        data.titleKey.LocaleOverride, 
                        data.textKey.LocaleOverride, 
                        data.flavourKey.LocaleOverride];
                    Locale englishLocale = LocalizationSettings.ProjectLocale;
                    foreach (var locale in LocalizationSettings.Instance.GetAvailableLocales().Locales)
                    {
                        SystemLanguage lang = typeof(SystemLanguage).GetEnumValues().Cast<int>().Select(i => (i, (SystemLanguage)i))
                            .FirstOrDefault(pair => locale.Identifier == new LocaleIdentifier(pair.Item2)).Item2;
                        if (lang == default) continue;
                        if (!data.titleKey.IsEmpty)
                        {
                            data.titleKey.LocaleOverride = locale;
                            titles[lang] = data.titleKey.GetLocalizedString();
                            data.titleKey.LocaleOverride = originalLocaleOverrides[0];
                        }
                        else titles[lang] = "";
                        if (!data.textKey.IsEmpty)
                        {
                            data.textKey.LocaleOverride = locale;
                            descriptions[lang] = data.textKey.GetLocalizedString();
                            data.textKey.LocaleOverride = originalLocaleOverrides[1];
                        }
                        else descriptions[lang] = "";
                        if (!data.flavourKey.IsEmpty)
                        {
                            data.flavourKey.LocaleOverride = locale;
                            flavours[lang] = data.flavourKey.GetLocalizedString();
                            data.flavourKey.LocaleOverride = originalLocaleOverrides[2];
                        }
                        else flavours[lang] = "";
                    }
                    this.englishTitle = titles[SystemLanguage.English];

                    this.bloodProfile = data.bloodProfile?.name;
                    this.idleAnim = data.idleAnimationProfile?.name;
                    this.stats = (data.hasHealth ? data.hp : null, data.hasAttack ? data.damage : null, data.counter);
                    this.attackEffectStacks = data.attackEffects;
                    this.startEffectStacks = data.startWithEffects;
                    this.traitStacks = data.traits?.ToArray();
                    this.value = data.value;

                    var allPools = AddressableLoader.GetGroup<ClassData>("ClassData").SelectMany(c => c.rewardPools).Distinct();
                    foreach (var pool in allPools) if (pool.list?.ToArrayOfNames().Contains(data.name) ?? false)
                            this.pools.Add(pool.name);
                    this.pools.RemoveDuplicates();


                }
            }
        }




        public class CommandInspect : Console.Command
        {
            public override string id => "inspect";
            public override string format => "inspect <datatype> <name?> OR inspect this";
            public override string desc => "Inspects the corresponding/hovered DataFile";
            public override bool IsRoutine => false;

            private static bool IsValidType(Type a) => a.BaseType == typeof(DataFile) && AddressableLoader.groups.ContainsKey(a.Name);

            public override void Run(string args)
            {
                if (UnityExplorer.ExplorerStandalone.Instance == null)
                {
                    Fail("Unity Explorer by Miya/Kopie must be loaded to use this command");
                    return;
                }
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
                    return;
                }

                if (args.Length > 0)
                {
                    string[] strArray = Split(args);
                    string typeName = strArray[0];
                    IEnumerable<Type> sourceType = Assembly.GetAssembly(typeof(DataFile)).GetTypes().Where(a => IsValidType(a) && string.Equals(a.Name, typeName, StringComparison.CurrentCultureIgnoreCase));
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
}