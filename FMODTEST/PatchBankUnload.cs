using FMOD.Studio;
using HarmonyLib;
using UnityEngine;

namespace FMODTEST
{
    public partial class FMODTESTMod
    {
        [HarmonyPatch(typeof(Bank), nameof(Bank.unload))]
        public static class PatchBankUnload
        {
            [HarmonyPrefix]
            [HarmonyPostfix]
            public static void UnloadEventsToo(Bank __instance)
            {
                Debug.LogError("Huh what");
                __instance.getEventList(out var events);
                foreach (var e in events)
                {
                    e.getPath(out var path);
                    Debug.Log("releasing handle: " + path);
                    e.clearHandle();
                    Debug.LogWarning((e.isValid(), e.hasHandle()));
                }
            }
        }
    }
}