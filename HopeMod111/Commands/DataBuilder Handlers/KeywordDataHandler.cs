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
using Rewired;
using UnityEngine.AddressableAssets;

namespace WildfrostHopeMod.CommandsConsole
{
    
    public partial class ConsoleCustom
    {
        public partial class CommandDataBuilderOf
        {
            public class KeywordDataHandler : DataHandler<KeywordData>
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
                    nameof(DataFile.ModAdded),
                    nameof(KeywordData.titleKey),
                    nameof(KeywordData.descKey),
                    nameof(KeywordData.titleColour),
                    nameof(KeywordData.bodyColour),
                    nameof(KeywordData.noteColour),
                    nameof(KeywordData.panelColor),
                    nameof(KeywordData.show),
                    nameof(KeywordData.showName),
                    nameof(KeywordData.showIcon),
                    nameof(KeywordData.iconName),
                    nameof(KeywordData.iconTintHex),
                ];




                public override string Info(KeywordData data)
                {
                    var info = new KeywordDataInfo(data);
                    int tabDepth = 0;

                    Type actualType = data.GetType();

                    StringBuilder builder = new StringBuilder().AppendLine();
                    builder.AppendLineDepth(tabDepth, $"new KeywordDataBuilder(this)"); 
                    tabDepth++;
                    builder.AppendLineDepth(tabDepth,$".Create({Print(info.name)})");

                    foreach (var text in info.titles) if (!text.Value.IsNullOrEmpty())
                            builder.AppendLineDepth(tabDepth, $".{nameof(KeywordDataBuilder.WithTitle)}(\"{text.Value}\", SystemLanguage.{text.Key})");
                    foreach (var text in info.texts) if (!text.Value.IsNullOrEmpty())
                            builder.AppendLineDepth(tabDepth, $".{nameof(KeywordDataBuilder.WithDescription)}(\"{text.Value}\", SystemLanguage.{text.Key})");
                    
                    builder.AppendLineDepth(tabDepth, $".{nameof(KeywordDataBuilder.WithTitleColour)}({Print(data.titleColour)})");
                    builder.AppendLineDepth(tabDepth, $".{nameof(KeywordDataBuilder.WithBodyColour)}({Print(data.bodyColour)})");
                    builder.AppendLineDepth(tabDepth, $".{nameof(KeywordDataBuilder.WithNoteColour)}({Print(data.noteColour)})");

                    if (data.panelColor.WithAlpha(1) == Color.white)
                        builder.AppendLineDepth(tabDepth, $".{nameof(KeywordDataBuilder.WithPanelColour)}({Print(data.panelColor)})");

                    builder.AppendLineDepth(tabDepth, $".{nameof(KeywordDataBuilder.WithShow)}({Print(data.show)})" +
                        $" \t\t// Will{(data.show ? "" : " not")} popup when used in descriptions");
                    builder.AppendLineDepth(tabDepth, $".{nameof(KeywordDataBuilder.WithShowName)}({Print(data.showName)})" +
                        (data.showName && !data.HasTitle 
                        ? $" \t// This keyword is missing a title and will error when trying to popup!" 
                        : $" \t// Whether to show the title in descriptions"));
                    
                    if (data.showIcon)
                    {
                        builder.AppendLineDepth(tabDepth, $".{nameof(KeywordDataBuilder.WithShowIcon)}({Print(data.showIcon)})");
                        builder.AppendLineDepth(tabDepth, $".{nameof(KeywordDataBuilder.WithIconName)}({Print(data.iconName)})" +
                            data.ModAdded != null ? $" \t // Name of an image added via a SpriteAsset" : "");
                        if (!data.iconTintHex.IsNullOrWhitespace())
                        {
                            var c = System.Drawing.ColorTranslator.FromHtml(data.iconTintHex);
                            Color color = new Color(c.R, c.G, c.B, c.A);
                            builder.AppendLineDepth(tabDepth, $".{nameof(KeywordDataBuilder.WithIconTint)}({Print(color)})");
                        }
                    }

                    //if (data.panelSprite == Addressables.LoadAssetAsync<Sprite>(""))

                    return builder.ToString();
                }

                public struct KeywordDataInfo
                {
                    public string name;
                    public string englishTitle;
                    public Dictionary<SystemLanguage, string> titles = [];
                    public string englishText;
                    public Dictionary<SystemLanguage, string> texts = [];
                    

                    public KeywordDataInfo(KeywordData data)
                    {
                        this.name = data.name.Replace(data.ModAdded?.GUID + ".", "");

                        Locale originalLocaleOverride = data.descKey.LocaleOverride;
                        Locale englishLocale = LocalizationSettings.ProjectLocale;
                        foreach (var locale in LocalizationSettings.Instance.GetAvailableLocales().Locales)
                        {
                            SystemLanguage lang = typeof(SystemLanguage).GetEnumValues().Cast<int>().Select(i => (i, (SystemLanguage)i))
                                .FirstOrDefault(pair => locale.Identifier == new LocaleIdentifier(pair.Item2)).Item2;
                            if (lang == default) continue;
                            if (!data.titleKey.IsEmpty)
                            {
                                data.titleKey.LocaleOverride = locale;
                                titles[lang] = data.descKey.GetLocalizedString();
                                data.titleKey.LocaleOverride = originalLocaleOverride;
                            }
                            else titles[lang] = "";
                        }
                        this.englishText = titles[SystemLanguage.English];

                        originalLocaleOverride = data.descKey.LocaleOverride;
                        foreach (var locale in LocalizationSettings.Instance.GetAvailableLocales().Locales)
                        {
                            SystemLanguage lang = typeof(SystemLanguage).GetEnumValues().Cast<int>().Select(i => (i, (SystemLanguage)i))
                                .FirstOrDefault(pair => locale.Identifier == new LocaleIdentifier(pair.Item2)).Item2;
                            if (lang == default) continue;
                            if (!data.descKey.IsEmpty)
                            {
                                data.descKey.LocaleOverride = locale;
                                texts[lang] = data.descKey.GetLocalizedString();
                                data.descKey.LocaleOverride = originalLocaleOverride;
                            }
                            else texts[lang] = "";
                        }
                        this.englishText = texts[SystemLanguage.English];

                        
                    }
                }
            }
        }
    }
}