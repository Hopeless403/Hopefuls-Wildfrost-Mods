using Deadpan.Enums.Engine.Components.Modding;
using System;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;
using UnityEngine.AddressableAssets;

namespace WildfrostHopeMod.ModUploader;

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
        public Localized(string name, string text) : this(name, text, "UI Text", "hope.moduploader") { }
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


    public static Localized Panel_Format = new Localized("Panel_Format", "Publish mod [{0}]?|{1}|{2}"
        + "\nSet non-public visibility with FriendsOnly, Private, or Unlisted"
        + "\n\"Edit tags\" will create/open the tags.txt in the mod folder");
    public static Localized Body_tags = new("Body_tags", "... with tag(s) [{0}]?");
    public static Localized Body_visibility = new("Body_visibility", "with visibility [{0}]");
    public static Localized Body_addsTags = new("Body_addsTags", "This will add the tags [{0}]");
    public static Localized Body_removesTags = new("Body_removesTags", "This will remove the tags [{0}]");
    public static Localized Note_hasCustomTags = new("Note_hasCustomTags", "Custom tags used: [{0}]");
    public static Localized Note_noCustomTags = new("Note_noCustomTags", "Note: You can use any custom tags too!");

    public static Localized Published_success = new("Published_success", "It'll take a moment to update the mod page");
    public static Localized Published_fail = new("Published_fail", "Uh oh...\nUpdate result: {0}\n{1}");

    public static Localized Result_NoConnection = new("Result_NoConnection", "No/Failed network connection");
    public static Localized Result_FileNotFound = new("Result_FileNotFound", "A file was not found");
    public static Localized Result_LimitExceeded = new("Result_LimitExceeded", "Icon filesize cannot exceed 1MB");
    public static Localized Result_Fail = new("Result_Fail", "A more specific error code couldn't be determined");

    public static Localized Buttons_editTags = new("Buttons_editTags", "Edit tags");
    public static Localized Buttons_cancel = new("cancel", "Cancel");
}