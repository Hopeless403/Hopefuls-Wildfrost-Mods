using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using WildfrostHopeMod.Configs;

namespace WildfrostHopeMod
{
    public partial class ConfigManager
    {
        [HarmonyPatch(typeof(WildfrostMod), nameof(WildfrostMod.SetLastMods))]
        static class PatchLastMods
        {
            public static WildfrostMod[] mods;
            static void Postfix(WildfrostMod[] enabled)
            {
                if (PatchJournal.modSettingsPage)
                {
                    Enable(enabled.Except(mods));
                    Disable(mods.Except(enabled));
                    CoroutineManager.Start(PatchJournal.FixLayout());
                }
                mods = enabled;
            }

            static void Enable(IEnumerable<WildfrostMod> enabled)
            {
                foreach (var mod in enabled)
                {
                    bool flag = PatchJournal.CreateConfigs(mod) && sections[mod].section.gameObject.activeSelf;
                    OnModLoaded?.Invoke(mod);
                    Debug.LogWarning($"Enabled {mod.GUID} config?: {flag}");
                }
            }
            static void Disable(IEnumerable<WildfrostMod> disabled)
            {
                foreach (var mod in disabled)
                {
                    OnModUnloaded?.Invoke(mod);
                    Debug.LogWarning($"Disabled {mod.GUID} config");
                }
            }
        }
    }

}