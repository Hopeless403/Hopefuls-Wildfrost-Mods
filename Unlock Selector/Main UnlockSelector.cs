using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Collections;

namespace WildfrostHopeMod.Unlocks
{
    public class UnlockSelector : WildfrostMod
    {
        public static UnlockSelector Mod;
        public UnlockSelector(string modDirectory) : base(modDirectory)
        {
            Mod = this;
        }
        public override string GUID => "hope.wildfrost.unlocks";
        public override string[] Depends => new string[] { "hope.wildfrost.configs"};
        public override string Title => "Unlock Selector";
        public override string Description => """
            Allows you to choose which unlocked metaprogression items to ignore.
            
            Charms are toggled in the Charm viewer. Items, units, and events are recommended to be configured with my [url=https://steamcommunity.com/sharedfiles/filedetails/?id=3175889529]Config Manager mod[/url] (but otherwise found in the config.cfg file)";
            """;

        public static GameObject behaviour;


        [HideInConfigManager]
        [ConfigManagerDesc("Since this is hidden anyway, there's no need to update it to use enums and break older versions right?")]
        [ConfigItem("", "","Locked Charms")]
        public string lockedCharmsConfig;
        internal static List<string> lockedCharms = new();

        [ConfigManagerDesc(overridePreprocessing:true, desc: "Keep the first <color=#FF9>N</color> Hot Springs units and remove the rest\r\n<align=\"left\">\r\n1. <color=#FF9>Tiny Tyko</color>\r\n2. <color=#FF9>Bombom</color>\r\n3. <color=#FF9>Nova</color>\r\n4. <color=#FF9>Lupa</color>\r\n5. <color=#FF9>The Baker</color>\r\n6. <color=#FF9>Toaster</color>")]
        [ConfigOptions(0, 1, 2, 3, 4, 5, 6)]
        [ConfigItem(6, "","Units to Keep")]
        public int unlockedUnitsConfig;
        internal static List<string> lockedUnits = new();

        [ConfigManagerDesc(overridePreprocessing:true, desc: "Keep the first <color=#FF9>N</color> Inventor's Hut items and remove the rest\r\n<align=\"left\">\r\n1. <color=#FF9>Slapcrackers</color>\r\n2. <color=#FF9>Kobonker</color>\r\n3. <color=#FF9>Grabber</color>\r\n4. <color=#FF9>Scrap Pile</color>\r\n5. <color=#FF9>Mega Mimik</color>\r\n6. <color=#FF9>Krono</color>")]
        [ConfigOptions(0, 1, 2, 3, 4, 5, 6)]
        [ConfigItem(6, "","Items to Keep")]
        public int unlockedItemsConfig;
        internal static List<string> lockedItems = new();

        [ConfigManagerDesc(overridePreprocessing: true, desc: "Keep the first <color=#FF9>N</color> Icebreaker events and remove the rest\r\n<align=\"left\">\r\n<size=0.23>1. <color=#FF9>Shade Sculptor</color>\r\n2. <color=#FF9>Charm Merchant</color>\r\n3. <color=#FF9>Gnome Traveller</color>")]
        [ConfigOptions(0, 1, 2, 3)]
        [ConfigItem(3, "", "Events to Keep")]
        public int unlockedEventsConfig;
        internal static List<string> lockedEvents = new();

        public IEnumerator thing()
        {
            yield return new WaitUntil(() => ConfigManager.initialised);
            //ConfigManager.GetConfigSection(this).OnConfigChanged += (i, v) => { Debug.LogWarning($"pressed {i.title} {v}. now toggling off"); ModToggle(); Debug.LogWarning($"now toggling on"); ModToggle(); Debug.LogWarning($"done"); };

            Debug.LogWarning(ConfigManager.GetConfigSection(this).items.Count);
        }
        public override void Load()
        {
            base.Load();
            CoroutineManager.Start(thing());

            lockedCharms = lockedCharmsConfig.Split(',').ToList();
            lockedUnits = (MetaprogressionSystem.data["companions"] as List<string>).GetRange(0, unlockedUnitsConfig);
            lockedItems = (MetaprogressionSystem.data["items"] as List<string>).GetRange(0, unlockedItemsConfig);

            behaviour = new GameObject("UnlockSelectorBehaviour");
            GameObject.DontDestroyOnLoad(behaviour);
            behaviour.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset |
                                  HideFlags.HideInInspector | HideFlags.NotEditable;
            behaviour.AddComponent<UnlockSelectorBehaviour>();
        }/*
        internal static void Listener(InventorHutSequence seq) => controller = seq.controller;*/

        public override void Unload()
        {
            base.Unload();
            GameObject.Destroy(behaviour);
            behaviour = null;
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
                    HandleCharms(charms);

                if (__instance.poolLookup.TryGetValue("Units", out CharacterRewards.Pool units))
                    HandleUnits(units);

                if (__instance.poolLookup.TryGetValue("Items", out CharacterRewards.Pool items))
                    HandleItems(items);
            }
            static void HandleCharms(CharacterRewards.Pool charms)
            {
                lockedCharms = MetaprogressionSystem.GetUnlocked(data => data.type == UnlockData.Type.Charm)
                    .Select(d => MetaprogressionSystem.Get<Dictionary<string, string>>("charms").GetValueOrDefault(d.name, ""))
                    .Where(c => lockedCharms.Select(l => l.ToLower()).Contains(c.ToLower()))
                    .ToList();
                Debug.LogWarning(("[Unlock Selector] Locked Charms: [" + string.Join(", ", lockedCharms) + "]"));
                charms.Remove(lockedCharms);
            }
            static void HandleUnits(CharacterRewards.Pool units)
            {
                lockedUnits = MetaprogressionSystem.Get<List<string>>("companions").Reverse<string>().ToList()
                    .GetRange(0, MetaprogressionSystem.Get<List<string>>("companions").Count - Mathf.Min(MetaprogressionSystem.GetUnlocked(data => data.type == UnlockData.Type.Companion).Count(), Mod.unlockedUnitsConfig));
                Debug.LogWarning(("[Unlock Selector] Locked Companions: [" + string.Join(", ", lockedUnits) + "]"));
                units.Remove(lockedUnits);
            }
            static void HandleItems(CharacterRewards.Pool items)
            {
                lockedItems = MetaprogressionSystem.Get<List<string>>("items").Reverse<string>().ToList()
                    .GetRange(0, MetaprogressionSystem.Get<List<string>>("items").Count - Mathf.Min(MetaprogressionSystem.GetUnlocked(data => data.type == UnlockData.Type.Item).Count(), Mod.unlockedItemsConfig));
                Debug.LogWarning(("[Unlock Selector] Locked Items: [" + string.Join(", ", lockedItems) + "]"));
                items.Remove(lockedItems);
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
                    lockedCharms.RemoveDuplicates();
                    ConfigManager.SaveConfig(Mod, "Locked Charms", lockedCharms.Count == 0 ? "" : string.Join(",", lockedCharms));
                }
            }
        }
    }
}