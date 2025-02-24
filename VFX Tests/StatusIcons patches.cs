using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Localization;

namespace WildfrostHopeMod.VFX
{
    [HarmonyPatch]
    public static partial class Patches
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(WildfrostMod), nameof(WildfrostMod.Unload))]
        public static void RemoveeAllStatusIconsFromGroup(WildfrostMod __instance)
        {
            Debug.LogWarning($"[{VFXMod.instance.Title}] Unloaded {__instance.Title}");
            __instance.RemoveeAllTAssetsFromGroup<_StatusIconData>();
        }

        internal static readonly HashSet<string> subbedTypes = [];
        /*[HarmonyPrefix]
        [HarmonyPatch(typeof(EntityDisplay), nameof(EntityDisplay.SetStatusIcon))]
        public static void SetStatusIconStat(EntityDisplay __instance, string type, string iconGroupName, ref Stat value, bool doPing)
        {
            Debug.LogWarning((__instance, type, iconGroupName, value, doPing));
            if (__instance is not Card card) return;
            if (!subbedTypes.Contains(type)) return;
            if (card.entity.startingEffectsApplied && card.init) return;
            if (__instance.FindStatusIcon(type)) return;

            value = new(value.current);
            Debug.LogError("[VFX Tools] Patched icon to use stat: " + value);
        }
        [HarmonyPostfix]
        [HarmonyPatch(typeof(EntityDisplay), nameof(EntityDisplay.SetStatusIcon))]
        public static void SetStatusIconStat2(EntityDisplay __instance, string type, string iconGroupName, ref Stat value, bool doPing)
        {
            //value = new(value.current);
            Debug.LogError("[VFX Tools] Patched icon to use stat????: " + value);
        }*/

    }
    internal static class PatchCardManagerIcons
    {

    }

    //[HarmonyPatch(typeof(BattleLogSystem))]
    internal static class PatchBattleLog
    {
        internal static bool initialized;
        public static readonly Dictionary<string, LocalizedString> typeToString = [];

        /*[HarmonyPatch(nameof(BattleLogSystem.OnEnable))]
        public static void Postfix(BattleLogSystem __instance)
        {
            if (!initialized)
            {
                typeToString["counter down"] =
                typeToString["max counter down"] =
            }
        }

        [HarmonyPatch(nameof(BattleLogSystem.StatusApplied))]
        public static void Postfix(BattleLogSystem __instance, StatusEffectApply apply)
        {

        }*/
    }
}
