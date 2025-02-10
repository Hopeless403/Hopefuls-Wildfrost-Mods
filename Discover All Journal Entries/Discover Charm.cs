using HarmonyLib;
using UnityEngine;

namespace WildfrostHopeMod
{
    public partial class DiscoverAllMod
    {
        /// <summary>
        /// Discover all journal charms
        /// </summary>
        [HarmonyPatch(typeof(JournalCharmManager), nameof(JournalCharmManager.CreateCharms))]
        static void Postfix(JournalCharmManager __instance)
        {
            if (!instance.setDiscovered)
                return;

            Debug.Log($"[{instance.Title}] >>> Discovering journal charms");
            foreach (var icon in __instance.charmIcons)
                icon.SetDiscovered();
        }

        /// <summary>
        /// Regenerate all journal charms
        /// </summary>
        [HarmonyPatch(typeof(JournalCharmManager), nameof(JournalCharmManager.OnEnable))] 
        static void Prefix(JournalCharmManager __instance) => __instance.locale = null;
    }
}
