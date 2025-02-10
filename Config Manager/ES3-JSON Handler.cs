using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace WildfrostHopeMod.Configs
{
    public class JSONHandler
    {
        public static void SaveConfigsToSettingsJSON(ConfigSection section)
        {
            WildfrostMod mod = section.mod;
            if (section == null)
            {
                Debug.LogError($"[Configs] Couldn't find the configs for [{mod.GUID}]");
                return;
            }

            foreach (var item in section.items)
            {
                var info = new ConfigInfo(item.Value);
                SaveToSettingsJson(Extensions.PrefixGUID(item.Key, mod), info);
            }
        }
        public static void SaveConfigsToSettingsJSON(WildfrostMod mod)
        {
            foreach (var stored in mod.FromConfigs().Store)
            {
                var info = new ConfigInfo(stored, mod);
                SaveToSettingsJson(Extensions.PrefixGUID(stored.field.Name, mod), info);
            }
        }
        public static void SaveToSettingsJson<T>(string key, T value)
        {
            ES3Settings settings = new ES3Settings(ES3.Directory.PersistentDataPath)
            {
                path = "configs.json",
                prettyPrint = true,
            };

            {
                try
                {
                    ES3.Save<T>(key, value, settings);
                }
                catch (FormatException ex1)
                {
                    Debug.LogWarning((object)ex1);
                    ES3.DeleteFile(settings);
                    try
                    {
                        ES3.Save<T>(key, value, settings);
                    }
                    catch (Exception ex2)
                    {
                        Debug.LogError((object)string.Format("ES3 Failed to save Settings even after deleting file.\n{0}", (object)ex2));
                    }
                }
                Events.InvokeSettingChanged(key, (object)value);
            }
        }

        internal struct ConfigInfo
        {
            public string Title;
            public string Description;
            public object Value;
            public DateTime LastSaved   = DateTime.Now;

            public ConfigInfo(ConfigItem item)
            {
                Title = item.con.atr.Title;
                Description = item.con.atr.comment;
                Value = item.currentValue;
            }
            public ConfigInfo((WildfrostMod.ConfigItemAttribute atr, FieldInfo field) stored, WildfrostMod mod)
            {
                Title = stored.atr.Title;
                Description = stored.atr.comment;
                Value = stored.field.GetValue(mod);
            }

            public override readonly string ToString()
            {
                return Value?.ToString() ?? "NULL";
            }
        }
    }
}
