using Deadpan.Enums.Engine.Components.Modding;
using FMOD.Studio;
using FMODUnity;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using WildfrostHopeMod.SFX;

namespace WildfrostHopeMod.VFX
{
    [HarmonyPatch]
    public static partial class Patches
    {
        [HarmonyPatch(typeof(VfxStatusSystem), nameof(VfxStatusSystem.CreateEffect))]
        public static void Postfix(VfxStatusSystem __instance, GameObject prefab, Vector3 position, Vector3 scale)
        {
            GIFLoader.InvokeEffectPlayed(prefab);
        }
    }

    [HarmonyPatch(typeof(RuntimeManager))]
    public static class PatchFMOD
    {
        [HarmonyPrefix]
        [HarmonyPatch(nameof(RuntimeManager.LoadBank), typeof(string), typeof(bool))]
        public static void RemoveOriginalBank(RuntimeManager ___instance, string bankName,
        out (bool shouldRestore, string bankName, object loadedBank) __state)
        {
            __state = default;
            if (___instance == null) return;
            try
            {
                var dict = (IDictionary)AccessTools.Field(typeof(RuntimeManager), "loadedBanks")
                                      .GetValue(___instance);
                //Debug.LogError($"Now checking for {bankName} in {dict.Keys.Cast<string>().Join()}");
                if (dict.Contains(bankName))
                {
                    __state = (true, bankName, dict[bankName]);
                    Debug.LogError($"[VFX Tools] We'll need to restore: {bankName} to {dict[bankName]}");
                    dict.Remove(bankName);
                }
            }
            catch { }

            Debug.Log($"[VFX Tools] Trying to load bank [{bankName}]");
        }

        [HarmonyPostfix]
        [HarmonyFinalizer]
        [HarmonyPatch(nameof(RuntimeManager.LoadBank), typeof(string), typeof(bool))]
        public static void RestoreBank(RuntimeManager ___instance, (bool shouldRestore, string bankName, object loadedBank) __state)
        {
            if (!__state.shouldRestore) return;

            var dict = (IDictionary)AccessTools.Field(typeof(RuntimeManager), "loadedBanks")
                                  .GetValue(___instance);
            dict[__state.bankName] = __state.loadedBank;

            Debug.LogWarning($"[VFX Tools] Restored bank [{__state.bankName}]");
        }

        [HarmonyPrefix]
        [HarmonyPatch("loadedBankRegister")]
        public static void RedirectBankName(RuntimeManager ___instance, ref string bankName)
        {
            if (___instance == null) return;

            var plat = AccessTools.Field(typeof(RuntimeManager), "currentPlatform")
                                  .GetValue(___instance) as Platform;
            //Debug.LogWarning($"Trying to redirect [{bankName}] of platform {(plat.DisplayName, plat.Identifier, plat.GetType())}");

            if (!plat || plat.DisplayName != "WildfrostMod" || plat.Identifier.IsNullOrEmpty()) return;

            var dict = (IDictionary)AccessTools.Field(typeof(RuntimeManager), "loadedBanks")
                                  .GetValue(___instance);

            if (!bankName.StartsWith(plat.Identifier))
                bankName = $"{plat.Identifier}.{bankName}";
            //Debug.LogError($"NOW BANK IS [{bankName}]");
        }
    }

    [HarmonyPatch]
    public class PatchWhyDoesBattleMusicSystemNotSaveStates
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(BattleMusicSystem), nameof(BattleMusicSystem.IsRunning))]
        public static bool LoadProperly(BattleMusicSystem __instance, ref bool __result)
        {
            //Debug.Log("Checking for running");
            var frames = new System.Diagnostics.StackTrace(fNeedFileInfo: true).GetFrames();
            if (frames.Length >= 3)
            {
                MethodBase method = frames[2].GetMethod();
                //Debug.Log("Got method " + method.FullDescription());
                if (method.DeclaringType == typeof(BattleMusicSystem) && method.GetParameters().All(p => p.ParameterType == typeof(BattleMusicSystem) || p.ParameterType == typeof(BattleMusicSaveData)))
                {
                    //Debug.LogWarning($"[VFX Tools] Patching battle music intensity");
                    return __result = false;
                }
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(WildfrostMod.DebugLoggerTextWriter), nameof(WildfrostMod.DebugLoggerTextWriter.WriteLine))]
    class PatchHarmony
    {
        static bool Prefix() { Postfix(); return false; }
        static void Postfix() => HarmonyLib.Tools.Logger.ChannelFilter = HarmonyLib.Tools.Logger.LogChannel.Warn | HarmonyLib.Tools.Logger.LogChannel.Error;
    }

    [HarmonyPatch]
    class PatchGiveUp
    {
        [HarmonyPatch(typeof(OverallStatsSystem), nameof(OverallStatsSystem.CampaignEnd))]
        [HarmonyPatch(typeof(RunHistorySystem), nameof(RunHistorySystem.CampaignEnd))]
        static Exception Finalizer(Exception __exception)
        {
            return null;
        }
    }
}
