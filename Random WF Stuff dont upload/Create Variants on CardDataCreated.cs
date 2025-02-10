using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.Localization;
using UnityEngine;

namespace WildfrostHopeMod.Randoms
{
    public partial class RandomMod : WildfrostMod
    {
        public static List<LocalizedString> variants = [];
        public void CreateVariants(CardData data, string variantSuffix, Func<string, string> formatter)
        {
            LocalizedString titleKey = data.titleKey;
            LocaleIdentifier english = new(SystemLanguage.English);

            // the specific locale doesn't matter here. Can use instead LocalizationHelper.stringTables["Cards_en"]
            StringTable table = LocalizationHelper.GetCollection("Cards", english);
            string name_pepper_flag = table.GetEntry(titleKey.TableEntryReference.KeyId).Key;
            LocalizedString originalString = table.GetString(name_pepper_flag);

            string name_pepper_flag_variant = name_pepper_flag + variantSuffix;

            foreach (var locale in LocalizationSettings.Instance.GetAvailableLocales().Locales)
            {
                Debug.LogWarning(locale);
                StringTable tableThisLocale = LocalizationHelper.GetCollection("Cards", locale.Identifier);
                originalString.LocaleOverride = locale;
                string titleThisLocale = originalString.GetLocalizedString();
                originalString.LocaleOverride = null;

                string newTitleThisLocale = formatter(titleThisLocale);

                tableThisLocale.SetString(name_pepper_flag_variant, newTitleThisLocale);
            }
            LocalizedString newString = table.GetString(name_pepper_flag_variant);
            Debug.LogError(newString);
            variants.Add(newString);
        }

        public static void OnEntityCreated(Entity entity) => OnCardDataCreated(entity.data);
        public static void OnCardDataCreated(CardData data)
        {
            data.titleKey = variants.RandomItem();
            Debug.LogWarning(data.titleKey);
        }
    }
}