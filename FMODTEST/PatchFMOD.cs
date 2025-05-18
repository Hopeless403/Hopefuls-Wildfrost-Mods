using FMODUnity;
using HarmonyLib;
using System.Collections;
using System.Linq;
using UnityEngine;

namespace FMODTEST
{
    public partial class FMODTESTMod
    {
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
                    Debug.LogError($"Now checking for {bankName} in {dict.Keys.Cast<string>().Join()}");
                    if (dict.Contains(bankName))
                    {
                        __state = (true, bankName, dict[bankName]);
                        Debug.LogError($"We'll need to restore: {bankName} to {dict[bankName]}");
                        dict.Remove(bankName);
                    }
                }
                catch { }

                Debug.Log($"[FMOD Test] Trying to load bank [{bankName}]");
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

                Debug.LogWarning("Restored: ");
                foreach (var kvp in dict.Keys.Cast<string>())
                    Debug.LogWarning(kvp);
                Debug.LogWarning("----");
            }

            [HarmonyPrefix]
            [HarmonyPatch("loadedBankRegister")]
            public static void RedirectBankName(RuntimeManager ___instance, ref string bankName)
            {
                if (___instance == null) return;

                var plat = AccessTools.Field(typeof(RuntimeManager), "currentPlatform")
                                      .GetValue(___instance) as PlatformMod;
                if (!plat || plat.Identifier.IsNullOrEmpty()) return;

                var dict = (IDictionary)AccessTools.Field(typeof(RuntimeManager), "loadedBanks")
                                      .GetValue(___instance);

                if (!bankName.StartsWith(plat.Identifier))
                    bankName = $"{plat.Identifier}.{bankName}";
                Debug.LogError($"NOW BANK IS [{bankName}]");
            }
        }
    }
}