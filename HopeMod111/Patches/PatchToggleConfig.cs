using HarmonyLib;
using UnityEngine;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleMod
    {
        [HarmonyPatch(typeof(Console), nameof(Console.CheckToggle))]
        internal class PatchToggleConfig
        {
            static KeyCode previous = KeyCode.None;
            static void Prefix(Console __instance)
            {
                if (Mod.toggleKey != previous)
                {
                    Debug.LogWarning($"[AConsole] Toggle key changed: {previous} → {Mod.toggleKey}");
                    previous = Mod.toggleKey;
                }
                __instance.toggle = [KeyCode.BackQuote, Mod.toggleKey];
            }
        }


    }
}