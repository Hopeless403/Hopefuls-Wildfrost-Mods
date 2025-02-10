using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using NaughtyAttributes;
using System.Reflection;
using System;

namespace WildfrostHopeMod.CommandsConsole
{
    
    public partial class ConsoleCustom
    {
        public partial class CommandDataBuilderOf
        {
            public class CardDataHandler : DataHandler<CardData>
            {
                public override HashSet<string> ManagedFields => [
                    nameof(CardData.ModAdded),
                    nameof(CardData.name),
                    nameof(CardData.titleKey),
                    nameof(CardData.bloodProfile),
                    nameof(CardData.idleAnimationProfile),
                    nameof(CardData.cardType),
                    nameof(CardData.textKey),
                    nameof(CardData.flavourKey),
                    nameof(CardData.hasHealth),
                    nameof(CardData.hp),
                    nameof(CardData.hasAttack),
                    nameof(CardData.damage),
                    nameof(CardData.counter),
                    nameof(CardData.mainSprite),
                    nameof(CardData.backgroundSprite),
                    nameof(CardData.value),
                    nameof(CardData.startWithEffects),
                    nameof(CardData.attackEffects),
                    nameof(CardData.traits),

                    // these are in CreateUnit and CreateItem
                    nameof(CardData.canBeHit),
                    nameof(CardData.playType),
                    nameof(CardData.cardType),
                    ];




                public override string Info(CardData data)
                {
                    var info = new CardDataInfo(data);
                    int tabDepth = 0;

                    Type actualType = data.GetType();

                    StringBuilder builder = new StringBuilder().AppendLine();
                    builder.AppendLineDepth(tabDepth, $"new CardDataBuilder(this)"); 
                    tabDepth++;
                    builder.AppendDepth(tabDepth,$".Create{(actualType == typeof(CardData) ? (info.IsUnit ? "Unit" : "Item") : $"<{actualType.Name}>")}(");
                    builder.Append($"name:\"{info.name}\", englishTitle:\"{info.englishTitle}\"");

                    if (info.IsUnit && info.bloodProfile != default)
                        builder.Append($", bloodProfile:\"{info.bloodProfile}\"");
                    if (info.idleAnim != default)
                        builder.Append($", idleAnim:\"{info.idleAnim}\"");
                    builder.AppendLine(")");
                    if (info.cardType != "Friendly" && info.cardType != "Item")
                        builder.AppendLineDepth(tabDepth,$".WithCardType(\"{info.cardType}\")");

                    foreach (var text in info.titles) if (!text.Value.IsNullOrEmpty() && text.Key != SystemLanguage.English)
                            builder.AppendLineDepth(tabDepth, $".WithTitle(\"{text.Value}\", SystemLanguage.{text.Key})");
                    foreach (var text in info.descriptions) if (!text.Value.IsNullOrEmpty())
                            builder.AppendLineDepth(tabDepth,$".WithText(\"{text.Value}\", SystemLanguage.{text.Key})");
                    foreach (var text in info.flavours) if (!text.Value.IsNullOrEmpty())
                            builder.AppendLineDepth(tabDepth,$".WithFlavour(\"{text.Value}\", SystemLanguage.{text.Key})");

                    if (info.IsPlayableItem)
                        builder.AppendLineDepth(tabDepth, $".SetDamage({(info.stats.attack.HasValue ? info.stats.attack : "null")})");
                    else
                        builder.AppendLineDepth(tabDepth,$".SetStats({(info.stats.health.HasValue ? info.stats.health : "null")}, {(info.stats.attack.HasValue ? info.stats.attack : "null")}, {info.stats.counter})");
                    builder.AppendLineDepth(tabDepth,$".SetSprites(\"{info.name}_mainSprite.png\", \"{info.name}_BG.png\")");
                    builder.AppendLineDepth(tabDepth,$".WithPools({string.Join(", ", info.pools.Select(p => $"\"{p}\"").DefaultIfEmpty(""))})");
                    builder.AppendLineDepth(tabDepth,$".WithValue({info.value}) \t// {(info.IsUnit ? 
                        $"Base gold as an enemy: {Mathf.RoundToInt(0.0275f * info.value)-1}-{Mathf.RoundToInt(0.0275f * info.value)+1}" : 
                        $"Base price in shop: {Mathf.RoundToInt(0.8f*info.value)-5}-{Mathf.RoundToInt(1.2f*info.value)-5}"
                        )}");

                    var unmanagedFields = GetUnmanagedFields(data);
                    bool usesScriptableObjects = false;
                    if (info.startEffectStacks.Any() || info.attackEffectStacks.Any() || info.traitStacks.Any() || unmanagedFields.Any())
                    {

                        if (actualType == typeof(CardData))
                            builder.AppendLineDepth(tabDepth, $".SubscribeToAfterAllBuildEvent(data =>\n\t{{");
                        else
                            builder.AppendLineDepth(tabDepth, $".SubscribeToAfterAllBuildEvent<{actualType.Name}>(data =>\n\t{{");
                        tabDepth++;
                        if (info.attackEffectStacks.Any())
                        {
                            builder.AppendLineDepth(tabDepth, "data.attackEffects = " + Print(info.attackEffectStacks, tabDepth, ignoreFirstTab:true) + ";");
                        }
                        if (info.startEffectStacks.Any())
                        {
                            builder.AppendLineDepth(tabDepth, "data.startWithEffects = " + Print(info.startEffectStacks, tabDepth, ignoreFirstTab:true) + ";");
                        }
                        if (info.traitStacks.Any())
                        {
                            builder.AppendLineDepth(tabDepth, "data.traits = " + Print(info.traitStacks, tabDepth, ignoreFirstTab:true) + ";");
                        }
                        if (unmanagedFields.Any())
                        {
                            CardData defaultInstance = InstantiateDefault(data);
                            
                            foreach (var field in unmanagedFields)
                            {
                                var defaultFieldValue = (field as FieldInfo)?.GetValue(defaultInstance);
                                var dataFieldValue = (field as FieldInfo)?.GetValue(data);

                                if (Equals(dataFieldValue, defaultFieldValue)
                                    || dataFieldValue == null
                                    || (dataFieldValue is string str && str.IsNullOrWhitespace())
                                    || (dataFieldValue is IEnumerable<object> ienum && !ienum.Any())
                                    )
                                    continue;

                                switch (field.Name)
                                {
                                    case "targetMode": if (new List<Type> {
                                        typeof(TargetModeAll), typeof(TargetModeBack), typeof(TargetModeBasic), typeof(TargetModeCrowns), typeof(TargetModeRandom), typeof(TargetModeRow)
                                    }.Contains((dataFieldValue as TargetMode).GetType())) continue;
                                        break;
                                }

                                if (dataFieldValue is ScriptableObject obj && obj is not DataFile)
                                    usesScriptableObjects = true;
                                builder.AppendLineDepth(tabDepth,$"data.{field.Name} = {Print(dataFieldValue, tabDepth, ignoreFirstTab:true)};");
                            }
                            defaultInstance.Destroy();
                        }
                        tabDepth--;
                        builder.AppendLineDepth(tabDepth,$"}})");
                    }
                    tabDepth--; 
                    builder = AppendCodeDependencies(builder, actualType);
                    if (usesScriptableObjects)
                    {
                        builder.AppendLine("");
                        builder.AppendLine("#region Code dependencies"); 
                        builder.AppendLine("""
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
                            """); 
                        builder.AppendLine("#endregion");
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

                        this.name = data.name.Replace(data.ModAdded?.GUID + ".", "");

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
        }
    }
}