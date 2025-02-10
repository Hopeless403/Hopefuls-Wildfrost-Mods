using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Deadpan.Enums.Engine.Components.Modding;
using UnityEngine;
using UnityEngine.Events;
using static WildfrostHopeMod.ConfigManager;

namespace WildfrostHopeMod.Configs
{
    public partial class ConfigSection
    { 
        public JournalPage section { get; private set; }
        public Dictionary<string, ConfigItem> items = new();

        public event UnityAction<ConfigItem, object> OnConfigChanged;
        public void InvokeConfigChanged(ConfigItem item, object value)
        {
            if (initialised)
                OnConfigChanged?.Invoke(item, value);
        }

        public ConfigSection UpdateInfo()
        {
            this.section = CreateSection(mod);
            CreateTitle(section.transform, title);
            UpdateConfigs();
            FixLayout();
            return this;
        }
        public void UpdateConfigs()
        {
            foreach (var con in mod.GetConfigs())
            {
                ConfigManager.conToMod[con] = mod;
                items.TryGetValue(con.field.Name, out ConfigItem configItem);
                items[con.field.Name] = configItem ??= new ConfigItem(this, con);
            }
        }


        

        /// <summary>
        /// Resets the section scale, position, visibility, and item heights.
        /// WIP! Consider the button positions
        /// </summary>
        internal void FixLayout()
        {
            if (!section)
                return;

            // configSection exists to be fixed
            section.transform.Normalise();
            section.gameObject.SetActive(mod.HasLoaded && items.Any(i => i.Value.visible));
            items.Values.Update(ConfigItem.FixHeight);
        }

        public static ConfigItem? TryGetItem(WildfrostMod mod, string fieldName)
        {
            if (!(ConfigManager.sections.ContainsKey(mod) && ConfigManager.sections[mod].items.ContainsKey(fieldName)))
                return null;
            return ConfigManager.sections[mod].items[fieldName];
        }
    }

}
