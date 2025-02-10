using HarmonyLib;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace WildfrostHopeMod.Unlocks
{
    internal class CharmLocks
    {
        internal static void Lock(JournalCharm unlockable)
        {
            unlockable.image.color = Color.gray;
            UnlockSelector.lockedCharms.Add(unlockable.upgradeData.name);
            Debug.LogWarning($"Locked [{unlockable.upgradeData.name}]!");
        }
        internal static void Unlock(JournalCharm unlockable)
        {
            unlockable.image.color = Color.white;
            UnlockSelector.lockedCharms.Remove(unlockable.upgradeData.name);
            Debug.LogWarning($"Unlocked [{unlockable.upgradeData.name}]!");
        }
        internal static bool ShouldLock(JournalCharm charm)
            => UnlockSelector.lockedCharms.Select(c => c.ToLower()).Contains(charm.upgradeData.name.ToLower());
        internal static bool CanLock(JournalCharm charm)
            => ((Dictionary<string, string>)MetaprogressionSystem.data["charms"]).Values.Contains(charm.upgradeData.name);

        
        [HarmonyPatch(typeof(JournalCharmManager), nameof(JournalCharmManager.OnEnable))]
        internal class PatchCharmEnable
        {
            static void Postfix(JournalCharmManager __instance)
            {
                foreach (var charm in __instance.charmIcons)
                    if (CanLock(charm) && ShouldLock(charm)) Lock(charm);
            }
        }

        [HarmonyPatch(typeof(JournalCharmManager), nameof(JournalCharmManager.OnDisable))]
        internal class PatchCharmDisable
        {
            static void Postfix(JournalCharmManager __instance)
            {
                foreach (var charm in __instance.charmIcons)
                    if (charm.discovered) charm.image.color = Color.white;
            }
        }

        [HarmonyPatch(typeof(JournalCharm), nameof(JournalCharm.Hover))]
        internal class PatchCharmHover
        {
            static void Postfix(JournalCharm __instance)
            {
                if (__instance.discovered && CanLock(__instance))
                {
                    UnlockSelector.hover = __instance;
                    CardPopUp.AddPanel("hope.canlock", "", "Can be locked");
                }
            }
        }

        [HarmonyPatch(typeof(JournalCharm), nameof(JournalCharm.UnHover))]
        internal class PatchCharmUnhover
        {
            static void Postfix()
            {
                UnlockSelector.hover = null;
                if (CardPopUp.instance.activePanels.ContainsKey("hope.canlock"))
                    CardPopUp.RemovePanel("hope.canlock");
            }
        }
    }
}
