using HarmonyLib;
using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Collections;
using BepInEx.Unity.IL2CPP;
using BepInEx;
using BepInEx.Unity.IL2CPP.Utils.Collections;
using BepInEx.Configuration;

namespace WildfrostHopeMod.Unlocks
{
    [BepInPlugin("hope.wildfrost.unlocks.bpx", "Unlock Selector BPX", "1.2.0")]
    public class UnlockSelector : BasePlugin
    {
        public static UnlockSelector Mod;
        public static GameObject behaviour;
/*
        [Flags]
        public enum Charms
        {
            None = 0,
            CardUpgradeFury = 1 << 0,
            CardUpgradeSnowImmune = 1 << 1,
            CardUpgradeAttackIncreaseCounter = 1 << 2,
            CardUpgradeAttackRemoveEffects = 1 << 3,
            CardUpgradeShellBecomesSpice = 1 << 4,
            CardUpgradeEffigy = 1 << 5,
            CardUpgradeShroomReduceHealth = 1 << 6,
            CardUpgradeAttackConsume = 1 << 7,
            CardUpgradeBlock = 1 << 8,
            CardUpgradeGreed = 1 << 9,
            CardUpgradeRemoveCharmLimit = 1 << 10,
            CardUpgradeFrenzyReduceAttack = 1 << 11,
            CardUpgradeConsumeAddHealth = 1 << 12,
            CardUpgradeAttackAndHealth = 1 << 13,
            CardUpgradeCritical = 1 << 14,
            CardUpgradeSpark = 1 << 15,
        }
*/
        [ConfigManagerDesc("Since this is hidden anyway, there's no need to update it to use enums and break older versions right?")]
        [ConfigItem("", "Locked Charms")]
        public ConfigEntry<string>? lockedCharmsConfig;
        internal static List<string> lockedCharms = new();

        [ConfigManagerDesc(overridePreprocessing: true, desc: "Keep the first <color=#FF9>N</color> Hot Springs units and remove the rest\r\n<align=\"left\">\r\n1. <color=#FF9>Snobble</color>\r\n2. <color=#FF9>Jumbo</color>\r\n3. <color=#FF9>Tiny Tyko</color>\r\n4. <color=#FF9>Bombom</color>\r\n5. <color=#FF9>Van Jun</color>\r\n6. <color=#FF9>Alloy</color>")]
        [ConfigOptions(0, 1, 2, 3, 4, 5, 6)]
        [ConfigItem(6, "Units to Keep")]
        public ConfigEntry<int>? unlockedUnitsConfig;
        internal static List<string> lockedUnits = new();

        [ConfigManagerDesc(overridePreprocessing: true, desc: "Keep the first <color=#FF9>N</color> Inventor's Hut items and remove the rest\r\n<align=\"left\">\r\n1. <color=#FF9>Slapcrackers</color>\r\n2. <color=#FF9>Kobonker</color>\r\n3. <color=#FF9>Grabber</color>\r\n4. <color=#FF9>Scrap Pile</color>\r\n5. <color=#FF9>Mega Mimik</color>\r\n6. <color=#FF9>Krono</color>")]
        [ConfigOptions(0, 1, 2, 3, 4, 5, 6)]
        [ConfigItem(6, "Items to Keep")]
        public ConfigEntry<int>? unlockedItemsConfig;
        internal static List<string> lockedItems = new();

        [ConfigManagerDesc(overridePreprocessing: true, desc: "Keep the first <color=#FF9>N</color> Icebreaker events and remove the rest\r\n<align=\"left\">\r\n<size=0.23>1. <color=#FF9>Shade Sculptor</color>\r\n2. <color=#FF9>Charm Merchant</color>\r\n3. <color=#FF9>Gnome Traveller</color>")]
        [ConfigOptions(0, 1, 2, 3)]
        [ConfigItem(3, "Events to Keep")]
        public ConfigEntry<int>? unlockedEventsConfig;
        internal static List<string> lockedEvents = new();


        static List<string> allCharms = new();
        static List<string> allUnits = new();
        static List<string> allItems = new();

        public override void Load()
        {
            MetaprogressionSystem.GetLockedCharms(AddressableLoader.GetGroup<UnlockData>("UnlockData")).ForEach(new Action<string>(a => allCharms.Add(a)));
            MetaprogressionSystem.GetLockedCompanions(AddressableLoader.GetGroup<UnlockData>("UnlockData")).ForEach(new Action<string>(a => allCharms.Add(a)));
            MetaprogressionSystem.GetLockedItems(AddressableLoader.GetGroup<UnlockData>("UnlockData")).ForEach(new Action<string>(a => allCharms.Add(a)));

            lockedCharms = ((string)lockedCharmsConfig.BoxedValue).Split(',').ToList();
            lockedUnits = allUnits.GetRange(0, (int)unlockedUnitsConfig.BoxedValue);
            lockedItems = allItems.GetRange(0, (int)unlockedItemsConfig.BoxedValue);

            behaviour = new GameObject("UnlockSelectorBehaviour");
            GameObject.DontDestroyOnLoad(behaviour);
            behaviour.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset |
                                  HideFlags.HideInInspector | HideFlags.NotEditable;
            behaviour.AddComponent<UnlockSelectorBehaviour>();


        }

        public static bool listening;
        public static object hover;
        public static CardController controller;

        [HarmonyPatch(typeof(CharacterRewards), nameof(CharacterRewards.Populate))]
        internal class PatchRewards
        {
            static void Postfix(CharacterRewards __instance)
            {
                if (__instance.poolLookup.TryGetValue("Charms", out CharacterRewards.Pool charms))
                {
                    foreach (var charm in allCharms)
                    {
                        if (lockedCharms.Contains(charm))
                            charms.Remove(charm);
                    }
                    lockedCharms = MetaprogressionSystem.GetUnlocked(data => data.type == UnlockData.Type.Charm)
                        .Select(d => MetaprogressionSystem.Get<Dictionary<string, string>>("charms")[d.name])
                        .Where(c => lockedCharms.Select(l => l.ToLower()).Contains(c.ToLower()))
                        .ToList();
                    Debug.LogWarning(("[Unlock Selector] Locked Charms: [" + string.Join(", ", lockedCharms) + "]"));
                    charms.Remove(lockedCharms);
                }
                if (__instance.poolLookup.TryGetValue("Units", out CharacterRewards.Pool units))
                {
                    lockedUnits = MetaprogressionSystem.Get<List<string>>("companions").Reverse<string>().ToList()
                        .GetRange(0, MetaprogressionSystem.Get<List<string>>("companions").Count - Mathf.Min(MetaprogressionSystem.GetUnlocked(data => data.type == UnlockData.Type.Companion).Count(), Mod.unlockedUnitsConfig));
                    Debug.LogWarning(("[Unlock Selector] Locked Companions: [" + string.Join(", ", lockedUnits) + "]"));
                    units.Remove(lockedUnits);
                }
                if (__instance.poolLookup.TryGetValue("Items", out CharacterRewards.Pool items))
                {
                    lockedItems = MetaprogressionSystem.Get<List<string>>("items").Reverse<string>().ToList()
                        .GetRange(0, MetaprogressionSystem.Get<List<string>>("items").Count - Mathf.Min(MetaprogressionSystem.GetUnlocked(data => data.type == UnlockData.Type.Item).Count(), Mod.unlockedItemsConfig));
                    Debug.LogWarning(("[Unlock Selector] Locked Items: [" + string.Join(", ", lockedItems) + "]"));
                    items.Remove(lockedItems);
                }
            }
        }

        [HarmonyPatch(typeof(SpecialEventsSystem), nameof(SpecialEventsSystem.PreCampaignPopulate))]
        internal class PatchEventsPre
        {
            static void Prefix()
            {
                lockedEvents = MetaprogressionSystem.Get<List<string>>("events").Reverse<string>().ToList()
                    .GetRange(0, MetaprogressionSystem.Get<List<string>>("events").Count - Mathf.Min(MetaprogressionSystem.GetUnlocked(data => data.type == UnlockData.Type.Event).Count(), Mod.unlockedEventsConfig));
                Debug.LogWarning(("[Unlock Selector] Locked Events: [" + string.Join(", ", lockedEvents) + "]"));
            }
        }
        [HarmonyPatch(typeof(SpecialEventsSystem), nameof(SpecialEventsSystem.InsertSpecialEvent))]
        internal class PatchEventsInsert
        {
            static bool Prefix(SpecialEventsSystem.Event specialEvent)
            {
                if (lockedEvents.Contains(specialEvent.nodeType.name))
                {
                    Debug.LogWarning(($"[Unlock Selector] Removed instances of [" + specialEvent.nodeType.name + "]"));
                    return false;
                }
                return true;
            }
        }



        public class UnlockSelectorBehaviour : MonoBehaviour
        {
            internal void Update()
            {
                if (controller) hover = controller.hoverEntity;
                if (hover != null && Input.GetMouseButtonDown(0) && hover is JournalCharm charm)
                {
                    if (CharmLocks.ShouldLock(charm)) CharmLocks.Unlock(charm);
                    else CharmLocks.Lock(charm);
                    lockedCharms = lockedCharms.Distinct().ToList();
                    ConfigManager.SaveConfig(Mod, "Locked Charms", lockedCharms.Count == 0 ? "" : string.Join(",", lockedCharms));
                }
            }
        }
    }

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
