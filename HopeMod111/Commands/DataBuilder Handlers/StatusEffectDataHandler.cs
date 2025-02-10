using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using NaughtyAttributes;
using System.Reflection;
using System;
using static Rewired.Utils.Classes.Data.TypeWrapper;
using System.Text.RegularExpressions;
using Deadpan.Enums.Engine.Components.Modding;

namespace WildfrostHopeMod.CommandsConsole
{
    
    public partial class ConsoleCustom
    {
        public partial class CommandDataBuilderOf
        {
            public class StatusEffectDataHandler : DataHandler<StatusEffectData>
            {
                public string textInsert;
                public int textOrder;
                public bool isStatus;
                public bool isReaction;
                public bool isKeyword;
                public string keyword;
                public string type;
                public string iconGroupName;
                public bool visible;
                public bool stackable = true;
                public bool offensive;
                public bool makesOffensive;
                public bool doesDamage;
                public bool canBeBoosted;
                public override HashSet<string> ManagedFields => [
                    nameof(StatusEffectData.ModAdded),
                    nameof(StatusEffectData.name),
                    nameof(StatusEffectData.textKey),
                    nameof(StatusEffectData.textInsert),
                    nameof(StatusEffectData.textOrder),
                    nameof(StatusEffectData.stackable),
                    nameof(StatusEffectData.canBeBoosted),
                    nameof(StatusEffectData.offensive),
                    nameof(StatusEffectData.makesOffensive),
                    nameof(StatusEffectData.doesDamage),
                    nameof(StatusEffectData.isStatus),
                    nameof(StatusEffectData.isReaction),
                    nameof(StatusEffectData.isKeyword),
                    nameof(StatusEffectData.keyword),
                    nameof(StatusEffectData.type),
                    nameof(StatusEffectData.iconGroupName),
                    nameof(StatusEffectData.visible),
                    ];




                public override string Info(StatusEffectData data)
                {
                    var info = new StatusEffectDataInfo(data);
                    int tabDepth = 0;

                    Type actualType = data.GetType();

                    StringBuilder builder = new StringBuilder().AppendLine();
                    builder.AppendLineDepth(tabDepth, $"new StatusEffectDataBuilder(this)"); 
                    tabDepth++;
                    builder.AppendLineDepth(tabDepth,$".Create<{actualType.Name}>({Print(info.name)})");

                    foreach (var text in info.texts) if (!text.Value.IsNullOrEmpty())
                            builder.AppendLineDepth(tabDepth, $".WithText(\"{text.Value}\", SystemLanguage.{text.Key})");
                    if (!data.textInsert.IsNullOrEmpty())
                        builder.AppendLineDepth(tabDepth, $".{nameof(StatusEffectDataBuilder.WithTextInsert)}({Print(data.textInsert)})");
                    if (data.textOrder != 0)
                        builder.AppendLineDepth(tabDepth, $".{nameof(StatusEffectDataBuilder.WithOrder)}({Print(data.textOrder)})");


                    builder.AppendLineDepth(tabDepth, $".{nameof(StatusEffectDataBuilder.WithStackable)}({Print(data.stackable)})");
                    builder.AppendLineDepth(tabDepth, $".{nameof(StatusEffectDataBuilder.WithCanBeBoosted)}({Print(data.canBeBoosted)})");
                    builder.AppendLineDepth(tabDepth, $".{nameof(StatusEffectDataBuilder.WithOffensive)}({Print(data.offensive)})" +
                        $"\t \t// As an attack effect, this is treated as a {(data.offensive ? (data.visible && data.isStatus ? "negative status" : "debuff") : "buff")}");
                    builder.AppendLineDepth(tabDepth, $".{nameof(StatusEffectDataBuilder.WithMakesOffensive)}({Print(data.makesOffensive)})" +
                        $" \t// As a starting effect, its entity should target {(data.makesOffensive ? "enemies" : "allies" )}");
                    builder.AppendLineDepth(tabDepth, $".{nameof(StatusEffectDataBuilder.WithDoesDamage)}({Print(data.doesDamage)})" +
                        $"\t \t// Its entity {(data.doesDamage ? "can activate \"On kill\" effects" : "cannot kill")} with this effect, eg for Bling Charm");
                    


                    if (data.isStatus)
                        builder.AppendLineDepth(tabDepth, $".{nameof(StatusEffectDataBuilder.WithIsStatus)}({Print(data.isStatus)})");
                    if (data.isKeyword || data is StatusEffectTemporaryTrait)
                        builder.AppendLineDepth(tabDepth, $".{nameof(StatusEffectDataBuilder.WithIsKeyword)}({Print(data.isKeyword)})" +
                            $" \t// This effect adds text to the card. {(!data.isKeyword && data is StatusEffectTemporaryTrait ? "NOTE: This should be true for TemporaryTraits" : "")}");
                    if (!data.type.IsNullOrEmpty())
                        builder.AppendLineDepth(tabDepth, $".{nameof(StatusEffectDataBuilder.WithType)}({Print(data.type)})");
                    if (!data.keyword.IsNullOrEmpty())
                        builder.AppendLineDepth(tabDepth, $".{nameof(StatusEffectDataBuilder.WithKeyword)}({Print(data.keyword)})" +
                            $" \t// Used in \"Apply X\" descriptions");
                    if (data.visible)
                    {
                        builder.AppendLineDepth(tabDepth, $".{nameof(StatusEffectDataBuilder.WithVisible)}({Print(data.visible)})");
                        if (!data.iconGroupName.IsNullOrEmpty())
                            builder.AppendLineDepth(tabDepth, $".{nameof(StatusEffectDataBuilder.WithIconGroupName)}({Print(data.iconGroupName)})" +
                                $" \t// When visible, one of [\"health\", \"damage\", \"counter\", \"crown\"]");
                    }
                    if (data.isReaction)
                    {
                        builder.AppendLineDepth(tabDepth, $".{nameof(StatusEffectDataBuilder.WithIsReaction)}({Print(data.isReaction)})");/*
                        builder.Append();
                        new StatusEffectDataBuilder().FreeModify(data => data.descColorHex = "100000").FreeModify()*/
                    }

                    var unmanagedFields = GetUnmanagedFields(data);
                    bool usesScriptableObjects = false;
                    if (unmanagedFields.Any())
                    {

                        builder.AppendLineDepth(tabDepth, $".SubscribeToAfterAllBuildEvent<{actualType.Name}>(data =>\n\t{{");
                        tabDepth++;
                        StatusEffectData defaultInstance = InstantiateDefault(data);

                        foreach (var field in unmanagedFields)
                        {
                            var defaultFieldValue = (field as FieldInfo)?.GetValue(defaultInstance);
                            var dataFieldValue = (field as FieldInfo)?.GetValue(data);

                            if (Equals(dataFieldValue, defaultFieldValue)
                                || dataFieldValue == null
                                || (dataFieldValue is string str && str.IsNullOrWhitespace())
                                || (dataFieldValue is LocalizedString lstr && lstr.IsEmpty)
                                || (dataFieldValue is IEnumerable<object> ienum && !ienum.Any())
                                )
                                continue;

                            if ((dataFieldValue is ScriptableObject obj && obj is not DataFile)
                              || (dataFieldValue is IEnumerable<ScriptableObject> objEnum && objEnum is not IEnumerable<DataFile>))
                                usesScriptableObjects = true;

                            builder.AppendLineDepth(tabDepth, $"data.{field.Name} = {Print(dataFieldValue, tabDepth, ignoreFirstTab: true)};");
                        }
                        defaultInstance.Destroy();
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

                public struct StatusEffectDataInfo
                {
                    public string name;
                    public string englishText;
                    public Dictionary<SystemLanguage, string> texts = [];
                    public string textInsert;
                    public int textOrder;
                    public bool isStatus;
                    public bool isReaction;
                    public bool isKeyword;
                    public string keyword;
                    public string type;
                    public string iconGroupName;
                    public bool visible;
                    public bool stackable = true;
                    public bool offensive;
                    public bool makesOffensive;
                    public bool doesDamage;
                    public bool canBeBoosted;

                    public StatusEffectDataInfo(StatusEffectData data)
                    {
                        this.name = data.name.Replace(data.ModAdded?.GUID + ".", "");

                        Locale originalLocaleOverride = data.textKey.LocaleOverride;
                        Locale englishLocale = LocalizationSettings.ProjectLocale;
                        foreach (var locale in LocalizationSettings.Instance.GetAvailableLocales().Locales)
                        {
                            SystemLanguage lang = typeof(SystemLanguage).GetEnumValues().Cast<int>().Select(i => (i, (SystemLanguage)i))
                                .FirstOrDefault(pair => locale.Identifier == new LocaleIdentifier(pair.Item2)).Item2;
                            if (lang == default) continue;
                            if (!data.textKey.IsEmpty)
                            {
                                data.textKey.LocaleOverride = locale;
                                texts[lang] = data.textKey.GetLocalizedString();
                                data.textKey.LocaleOverride = originalLocaleOverride;
                            }
                            else texts[lang] = "";
                        }
                        this.englishText = texts[SystemLanguage.English];

                        this.textInsert = data.textInsert;
                        this.textOrder = data.textOrder;
                        this.isStatus = data.isStatus;
                        this.isReaction = data.isReaction;
                        this.isKeyword = data.isKeyword;
                        this.keyword = data.keyword;
                        this.type = data.type;
                        this.iconGroupName = data.iconGroupName;
                        this.visible = data.visible;
                        this.stackable = data.stackable;
                        this.offensive = data.offensive;
                        this.makesOffensive = data.makesOffensive;
                        this.doesDamage = data.doesDamage;
                        this.canBeBoosted = data.canBeBoosted;
                }
                }
            }
        }
    }
}