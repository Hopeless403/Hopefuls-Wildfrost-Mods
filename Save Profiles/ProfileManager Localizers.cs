using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.Localization;
using UnityEngine;

namespace WildfrostHopeMod.ProfileManager;
public class Localizers
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
        public Localized(string name, string text) : this(name, text, "UI Text", "hope.profiles") { }
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
            var table = GetCollection(Table.TableCollectionName, language);
            table.SetString(Name, text);
            return table.GetString(Name);
        }
    }

    public static StringTable GetCollection(string name, LocaleIdentifier identifier)
    {
        string code;
        switch (identifier.Code)
        {
            case "zh-hans": code = "zh-Hans"; break;
            case "zh-hant": code = "zh-Hant"; break;
            default: code = identifier.Code; break;
        }
        string text = name + "_" + code;
        StringTable stringTable = Addressables.LoadAssetAsync<StringTable>(text).WaitForCompletion();
        return stringTable ?? LocalizationHelper.GetCollection(name, identifier);
    }
    public static LocalizedString GetString(string tableName, string name, LocaleIdentifier identifier)
        => GetCollection(tableName, identifier).GetString(name);
    public static LocalizedString GetString(string tableName, string name, SystemLanguage language = SystemLanguage.English)
        => GetCollection(tableName, language).GetString(name);

    public static void ShowPanel(string key)
    {
        string[] array = key.Split('|');
        HelpPanelSystem.instance.title.gameObject.SetActive(array.Length != 0);
        HelpPanelSystem.instance.body.gameObject.SetActive(array.Length > 1);
        HelpPanelSystem.instance.note.gameObject.SetActive(array.Length > 2);
        HelpPanelSystem.instance.title.text = ((array.Length != 0) ? array[0] : "");
        HelpPanelSystem.instance.body.text = ((array.Length > 1) ? array[1] : "");
        HelpPanelSystem.instance.note.text = ((array.Length > 2) ? array[2] : "");
        SfxSystem.OneShot(HelpPanelSystem.instance.popUpSfx);
        HelpPanelSystem.instance.gameObject.SetActive(value: true);
    }


    public static Localized Profile = new("Profile", "Profiles: {0}");
    public static Localized Mods = new("Mods", "Last mods: {0}");
    public static Localized Panel_Format = new("Panel_Format", "Are you sure you want\nto delete profile\n[{0}]?");
    public static Localized Buttons_cancel = new("cancel", "Cancel");
}