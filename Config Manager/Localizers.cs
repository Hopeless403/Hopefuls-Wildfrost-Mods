using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;

namespace WildfrostHopeMod.Configs
{
    public static class Localizers
    {
        public struct Localized
        {
            public StringTable Table;
            public string Name;
            public string String => Localizer.GetLocalizedString();
            LocalizedString localizer;
            public LocalizedString Localizer
            {
                get
                {
                    if (!localizer.IsEmpty && !localizer.GetLocalizedString().IsNullOrEmpty())
                        return localizer;

                    // Get current game locale and its table
                    Locale locale = LocalizationSettings.Instance.GetSelectedLocale();
                    var table = GetCollection(Table.TableCollectionName, locale.Identifier);

                    // Set the localized string in this language to the one for english
                    localizer.LocaleOverride = LocalizationSettings.Instance.GetAvailableLocales().GetLocale(new(SystemLanguage.English));
                    table.SetString(Name, localizer.GetLocalizedString());
                    Localizer.LocaleOverride = null;

                    // Retrieve the new localized string
                    return table.GetString(Name);
                }
            }
            public Localized(string name, string text, string tableName = "UI Text", string? prefix = "hope")
            {
                Name = prefix != null ? $"{prefix}.{name}" : name;
                Table = GetCollection(tableName, new(SystemLanguage.English));
                Table.SetString(Name, text);
                localizer = Table.GetString(Name);
            }
            public Localized(string name, string text) : this(name, text, "UI Text", "hope.configs") { }
            public override string ToString() => String;
            public static implicit operator string(Localized localized) => localized.String;
            public static implicit operator LocalizedString(Localized localized) => localized.Localizer;
            public string Format(params object[] args) => String.Format(args);


            /// <summary>
            /// If text is null, sets the language's localized string to the English's
            /// </summary>
            /// <returns>the new localized string in the language</returns>
            public LocalizedString SetString(string text = null, SystemLanguage language = SystemLanguage.English)
            {
                if (text == null)
                {
                    Localizer.LocaleOverride = LocalizationSettings.Instance.GetAvailableLocales().GetLocale(new(SystemLanguage.English));
                    text = Localizer.GetLocalizedString();
                    Localizer.LocaleOverride = null;
                }
                return SetString(text, new LocaleIdentifier(language));
            }
            /// <summary>
            /// If text is null, sets the language's localized string to the English's
            /// </summary>
            /// <returns>the new localized string in the language</returns>
            public LocalizedString SetString(string text, LocaleIdentifier identifier)
            {
                var table = GetCollection(Table.TableCollectionName, identifier);
                table.SetString(Name, text);
                return table.GetString(Name);
            }
            public Localized WithStrings(params (LocaleIdentifier identifier, string text)[] strings)
            {
                foreach (var (identifier, text) in strings)
                    SetString(text, identifier);
                return this;
            }

        }
        public static StringTable GetCollection(string name, LocaleIdentifier identifier)
        => Addressables.LoadAssetAsync<StringTable>(name + "_" + identifier.Code switch
        {
            "zh-hans" => "zh-Hans",
            "zh-hant" => "zh-Hant",
            _ => identifier.Code,
        }).WaitForCompletion()
            ?? LocalizationHelper.GetCollection(name, identifier);
        public static LocalizedString GetString(string tableName, string name, LocaleIdentifier identifier)
            => GetCollection(tableName, identifier).GetString(name);
        public static LocalizedString GetString(string tableName, string name, SystemLanguage language = SystemLanguage.English)
            => GetCollection(tableName, language).GetString(name);

        public static Localized ModConfigs = new Localized("mod_configs", "Mod Configs", prefix:null)
            .WithStrings((SystemLanguage.English, "Mod Configs"),
                        (SystemLanguage.ChineseSimplified, "模组设置"),
                        (SystemLanguage.ChineseTraditional, "模組设置"),
                        (SystemLanguage.Korean, "모드 설정"),
                        (SystemLanguage.Japanese, "MOD設定"),
                        (SystemLanguage.French, "Configurer les Mods"),
                        (SystemLanguage.German, "Mod-Einstellungen"),
                        (SystemLanguage.Russian, "Конфиги модов"),
                        (SystemLanguage.Spanish, "Configs. de Mods"), // Credit to @Artemys !!
                        (SystemLanguage.Portuguese, "Configs. de Mods") // Credit to @Artemys !!
            );
    }
}
