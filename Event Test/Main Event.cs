using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.Collections;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using WildfrostHopeMod.Utils;

namespace WildfrostHopeMod.EventTest
{
    public class EventMod : WildfrostMod
    {
        [HarmonyPatch]
        internal class PatchRewardsAsGrid
        {
            [HarmonyPatch(typeof(ItemEventRoutine), nameof(ItemEventRoutine.Populate))]
            static IEnumerator Postfix(IEnumerator __result, ItemEventRoutine __instance)
            {
                ReplaceContainerWithGrid(ref __instance.cardContainer);
                yield return __result;
            }
            [HarmonyPatch(typeof(EventRoutineCompanion), nameof(EventRoutineCompanion.Populate))]
            static IEnumerator Postfix(IEnumerator __result, EventRoutineCompanion __instance)
            {
                ReplaceContainerWithGrid(ref __instance.cardContainer);
                yield return __result;
            }
        }

        public static void ReplaceContainerWithGrid(ref CardContainer containerToReplace, RectTransform bounds = null)
        {
            Transform parent = containerToReplace.transform.parent;
            containerToReplace.gameObject.Destroy();

            var go = new GameObject("CardGrid", typeof(RectTransform), typeof(CardContainerGrid));
            go.transform.SetParent(parent);
            go.transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);

            var grid = go.GetComponent<CardContainerGrid>();
            grid.holder = grid.GetComponent<RectTransform>();
            grid.onAdd = new();
            grid.onAdd.AddListener(entity => entity.flipper.FlipUp());
            grid.onRemove = new();

            /// These values are the defaults. Uncomment to use custom values
            // grid.cellSize = new Vector2(2.25f, 3.375f);
            // grid.columnCount = 5; 

            /// Generic way to make scrollable. No click-and-drag yet
            var scroller = go.GetOrAdd<Scroller>();                 // Scroll with mouse
            go.GetOrAdd<ScrollToNavigation>().scroller = scroller;  // Scroll with controllers
            go.GetOrAdd<TouchScroller>().scroller = scroller;       // Scroll with touchscreen?
                                                                    // No click-and-drag yet. Needs some work
                                                                    // Change scroller.bounds here if it only scrolls partially

            containerToReplace = grid;
        }
        public static Paths Paths;
        public static EventMod Mod;
        public EventMod(string modDirectory) : base(modDirectory)
        {
            Mod = this; Paths = new Paths(ModDirectory);
        }
        public override string GUID => "hope.wildfrost.events";
        public override string[] Depends => new string[] { };
        public override string Title => "Event Test";
        public override string Description => "";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;

        bool init = false;

        public override void Load()
        {
            base.Load();
            if (!init)
            {
                var nodeType = new CampaignNodeTypeTest();
                nodeType.PrintAllFields();
                AddressableLoader.AddToGroup("CampaignNodeType", nodeType);
                //AddressableLoader.GetGroup<CampaignNodeType>("CampaignNodeType").Any(a => a.)
                //EventRoutineTest.Initialise();
                init = true;
            }
            Debug.LogWarning(GameObject.FindObjectOfType<SpecialEventsSystem>());
            TextAsset[] presets = Get<GameMode>("GameModeNormal").generator.presets;
            Get<GameMode>("GameModeNormal").generator.presets = presets.Select(t => { Debug.LogWarning(t.GetInstanceID()); return new TextAsset(t.text.Replace('i', 'က')); }).ToArray();
        }

        public override void Unload()
        {
            base.Unload();
        }
    }
}