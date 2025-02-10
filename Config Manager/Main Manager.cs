using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using WildfrostHopeMod.Configs;

namespace WildfrostHopeMod
{
    public partial class ConfigManager : WildfrostMod
    {
        public static ConfigManager instance;
        public override string GUID => "hope.wildfrost.configs";
        public override string[] Depends => new string[] { };
        public override string Title => "Config Manager";
        public override string Description => "Adds a Journal button to modify configs for all currently ACTIVE mods, and allows modders to customise their appearance and behaviour\r\n\r\n\r\nNOTE: If the configs don't automatically update ingame, first try resubscribing to Config Manager and delete your mod's config.cfg. If all else fails, report to me @Hopeful on Discord\r\n[hr]\r\n[h1][u]Customisation for your mod[/u][/h1]\r\n[h2]Without this mod as a dependency[/h2]\r\nWithout requiring this mod as a dependency, you can still do minimal customisation:\r\n[list]\r\n[*]Set the description through the [i]comment[/i] parameter in your ConfigItem. Make sure new lines use \"\\n//\".\r\n[*]Set predefined options by using bool or an enum type as the value of your ConfigItem\r\n[/list]\r\nYou can use sprites using <sprite name=\"your sprite\"> (or <sprite=..> or even <spr=..> for short) in the desc, but keywords and card popups don't work yet. By default this works with the base game stuff, but you can add your own by adding a sprite asset with my [url=https://steamcommunity.com/sharedfiles/filedetails/?id=3157544232]VFX & SFX Tools[/url]\r\n\r\n[h2]With this mod as a dependency[/h2]\r\nIn general, each mod has its own ConfigSection in the Journal which contains a ConfigItem for each config. If there are no (visible) configs, then this section won't show up.\r\n\r\n[h3]Attributes: The main meat[/h3]\r\nFor modders adding this to your mod, you can add any of these new attributes when you define each config item:\r\n[list]\r\n[*][b]ConfigManagerTitle[/b] : The title to display for this item\r\n[*][b]ConfigManagerDesc[/b] : The description to display when hovered. Use this if you want rich text tags like <align> or <voffset>\r\n[*][b]ConfigInput[/b] : Adds a button to manually input the config. When used with Options, will only choose between the predefined options, or the range if used with Slider.\r\n[*][b]ConfigOptions[/b] : Adds left/right buttons to swap between predefined options. When used with an enum, it will automatically replace _ with spaces\r\n[*][b]ConfigSlider[/b] : Adds a slider with a predefined range. Can use with float or int. This shows the current value under the title\r\n[*][b]HideInConfigManager[/b] : By default, this item won't show up in the Journal unless any ShowIfConfig is defined\r\n[/list]\r\n\r\n[h3]Making manual changes to the config or appearance[/h3]\r\nManually make changes to the config (similar to toggling charms with my [url=steamcommunity.com/sharedfiles/filedetails/?id=3156347308]Unlock Selector mod[/url]).\r\n[list]\r\n[*][b]ConfigManager.SaveConfig()[/b] : This method is missing from the api for some reason so I added it here\r\n[*][b]ConfigManager.ConfigItem[/b] : For each config in your mod:\r\n\t[list]\r\n\t[*][b]configItem.UpdateDesc()[/b] : Change the hover popup, possibly overriding the text preprocessing. Same as doing \"desc = str\"\r\n\t[*][b]configItem.UpdateTitle()[/b] : Change the title displayed. Same as doing \"title = str\"\r\n\t[/list]\r\n[/list]\r\n\r\n[h3]Conditional visibility attributes[/h3]\r\nYou can use any number of these to specify when a config should/shouldn't be visible. Optionally set [i]priority[/i] parameters if using HideIf and ShowIf together\r\n[list]\r\n[*][b]HideIfConfig[/b] : This item won't show up in the Journal if the specified config item (by field name) takes some value\r\n[*][b]ShowIfConfig[/b] : Use to override HideIf or HideInConfigManager if needed\r\n[/list]\r\n\r\n[h3]Events[/h3]\r\nThe main thing here is OnConfigChanged, which is useful for when you need to reload your mod after disabling/enabling any DataFile objects for example (see Miya's blood mod in progress)\r\n[list]\r\n[*][b]ConfigManager.OnModLoaded[/b] : Event after any mod loads\r\n[*][b]ConfigManager.OnModUnloaded[/b] : Event after any mod unloads\r\n[*][b]configSection.OnConfigChanged[/b] : Event after a config's value is saved for each mod\r\n[/list]\r\nI didn't realise the ModLoaded/Unloaded were already part of the api so wtv";

        public static Dictionary<(ConfigItemAttribute atr, System.Reflection.FieldInfo field), WildfrostMod> conToMod = new();

        public static Dictionary<WildfrostMod, ConfigSection> sections = new();
        public static event UnityAction<WildfrostMod> OnModLoaded;
        public static event UnityAction<WildfrostMod> OnModUnloaded;


        internal static GameObject renameSeq;
        internal static GameObject renameButton;

        public static bool initialised = false;

        static IEnumerator Initialise()
        {
            yield return new WaitUntil(() => SceneManager.IsLoaded("PauseScreen"));
            CoroutineManager.Start(PatchRenameButton.InitRenameSeq());

            yield return new WaitUntil(() => PatchRenameButton.initialised);
            GameObject.FindObjectOfType<PauseMenu>(true).settingsTab.Select();

            yield return new WaitUntil(() => initialised);
            Debug.LogWarning("[Config Manager] has initialised! Event listeners can now do stuff");

        }

        public override void Load()
        {
            foreach (var field in typeof(Localizers).GetFields())
                if (field.GetValue(null) is LocalizedString) ;

            foreach (var mod in Bootstrap.Mods)
                sections[mod] = new ConfigSection(mod);
            CoroutineManager.Start(Initialise());

            // Create backups for if mods update (mod author's config overrides player's)
            ConfigManager.OnModLoaded += ModLoaded;
            foreach (var mod in Bootstrap.Mods)
            {
                ModLoaded(mod);
            }

            base.Load(); // Ordered, to handle ConfigManager configs in GetLastMods
            PatchLastMods.mods = GetLastMods();
        }
        internal void ModLoaded(WildfrostMod mod)
        {
            //Debug.LogError("MOD LOADEDEDEDD  " + mod.Title);
            FixMissingConfigs(mod); // Miya still didn't do this >:(
            JSONHandler.SaveConfigsToSettingsJSON(mod);
            if (initialised) PatchJournal.CreateConfigs(mod);
            Debug.LogWarning($"""what happened to the section? {GetConfigSection(mod).section?.gameObject.activeSelf}""");
        }
        public override void Unload()
        {
            ConfigManager.OnModLoaded -= JSONHandler.SaveConfigsToSettingsJSON;
            GameObject.FindObjectOfType<Journal>(true)?.transform.FindRecursive("ModSettingsButton")?.gameObject.SetActive(false);

            base.Unload();
        }

        public static bool SaveConfig(WildfrostMod mod, string forceTitle, object configValue, bool quiet = false, string fieldName = "")
        {
            string path = Path.Combine(mod.ModDirectory, "config.cfg");
            string[] strArray = File.ReadAllLines(path);
            bool flag = false;
            (ConfigItemAttribute atr, System.Reflection.FieldInfo field) con = default;
            for (int i = 0; i < strArray.Length; i++)
                if (!strArray[i].StartsWith("//") && strArray[i].Split(':', '=')[1] == $" {forceTitle} ")
                {
                    strArray[i] = strArray[i].Remove(strArray[i].IndexOf("=")) + $"= {configValue}";
                    File.WriteAllLines(path, strArray);
                    if ((con = mod.GetConfigs().FirstOrDefault(con => con.atr.forceTitle == forceTitle)) != default)
                    {
                        con.field.SetValue(mod, configValue);
                        flag = true;
                    }
                    if (!quiet) Debug.Log($"Setting Saved [{(fieldName.IsNullOrWhitespace() ? con.field.Name : fieldName)} = {configValue}]");
                    break;
                }
            if (!flag) Debug.LogWarning("[Config Manager] If you see this, please delete the config.cfg or change the ConfigItem's forceTitle (Invalid characters include : and =)");
            else if (sections.TryGetValue(mod, out ConfigSection section))
            {
                section.items[con.field.Name].currentValue = configValue;
                section.items[con.field.Name].UpdateLabel();
                section.InvokeConfigChanged(section.items[con.field.Name], configValue);
            }
            return flag;
        }
        public static bool SaveConfig((ConfigItemAttribute atr, System.Reflection.FieldInfo field) con, object configValue)
        {
            conToMod.TryGetValue(con, out WildfrostMod mod);
            return SaveConfig(mod ?? Bootstrap.Mods.First(m => m.GetConfigs().Contains(con)), con.atr.Title, configValue, false);
        }
        public static ConfigSection GetConfigSection(WildfrostMod mod) => sections.TryGetValue(mod, out ConfigSection value) ? value : null;
        public static ConfigItem GetConfigItem(WildfrostMod mod, string fieldName) => (GetConfigSection(mod)?.items.TryGetValue(fieldName, out ConfigItem value) ?? false) ? value : null;


        void FixMissingConfigs(WildfrostMod mod)
        {
            var configsFromCode = mod.GetConfigs();
            string path = Path.Combine(mod.ModDirectory, "config.cfg");
            bool regen = !File.Exists(path);
            if (!regen)
            {
                var lines = File.ReadAllLines(path)
                    .Where(line => !line.StartsWith("//"));

                if (regen = lines.Count() != configsFromCode.Length)
                    File.Delete(path);
            }

            if (regen)
            {
                Debug.LogWarning($"[Config Manager] MISSING CONFIG! Regenerating file at {path}");
                WildfrostMod.ConfigStorage storage = mod.FromConfigs();
                storage.WriteToFile(path);
                storage.ReadFromFile(path);
            }
        }

        const string plan = """
            Config Manager saves when each dll was last updated
            If the last write time > stored time, restore configs
            What if Config Manager wasn't active?
            """;
    }

}