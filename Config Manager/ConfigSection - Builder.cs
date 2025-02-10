using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Deadpan.Enums.Engine.Components.Modding;
using static WildfrostHopeMod.ConfigManager.PatchJournal;

namespace WildfrostHopeMod.Configs
{
    public partial class ConfigSection(WildfrostMod mod)
    {
        public readonly WildfrostMod mod = mod;
        public string title = mod.Title;

        JournalPage CreateSection(WildfrostMod mod)
        {
            if (modSettingsPage.transform.FindRecursive(mod.GUID))
                // Section has been created
                return modSettingsPage.transform.FindRecursive(mod.GUID).GetComponent<JournalPage>();

            // Section has not been created
            return Templates.CreatePage(modContent, mod.GUID);
        }
        public static void CreateTitle(Transform parent, string text)
        {
            if (parent.Find("Title")) return;

            // Title has not been created
            var title = Templates.CreateTitle(parent, text);
            title.transform.SetAsFirstSibling();
        }
    }
}
