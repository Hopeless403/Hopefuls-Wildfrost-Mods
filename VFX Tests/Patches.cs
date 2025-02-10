using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace WildfrostHopeMod.VFX
{
    [HarmonyPatch]
    class Patches
    {
        [HarmonyPatch(typeof(VfxStatusSystem), nameof(VfxStatusSystem.CreateEffect))]
        public static void Postfix(VfxStatusSystem __instance, GameObject prefab, Vector3 position, Vector3 scale)
        {
            GIFLoader.InvokeEffectPlayed(prefab);
        }
    }
    [HarmonyPatch(typeof(WildfrostMod.DebugLoggerTextWriter), nameof(WildfrostMod.DebugLoggerTextWriter.WriteLine))]
    class PatchHarmony
    {
        static bool Prefix() { Postfix(); return false; }
        static void Postfix() => HarmonyLib.Tools.Logger.ChannelFilter = HarmonyLib.Tools.Logger.LogChannel.Warn | HarmonyLib.Tools.Logger.LogChannel.Error;
    }
}
