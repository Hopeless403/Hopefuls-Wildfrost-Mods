using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ExtendedUI
{
    //[HarmonyPatch]
    internal class PatchRewardsAsGrid
    {
        readonly string comment = "Unused";
        //[HarmonyPatch(typeof(ItemEventRoutine), nameof(ItemEventRoutine.Populate))]
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
        // Similar HarmonyPatch for EventRoutineCompanion

        static void ReplaceContainerWithGrid(ref CardContainer containerToReplace, RectTransform bounds = null)
        {
            Transform parent = containerToReplace.transform.parent;
            containerToReplace.gameObject.Destroy();

            var go = new GameObject("CardGrid", typeof(RectTransform), typeof(CardContainerGrid));
            go.transform.SetParent(parent);
            go.transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);

            var grid = go.GetComponent<CardContainerGrid>();
            grid.holder = grid.GetComponent<RectTransform>(); // Do its thing when chest active
            grid.onAdd = new(); // Fix null reference
            grid.onAdd.AddListener(entity => entity.flipper.FlipUp()); // Flip up card when it's time (without waiting for others)
            grid.onRemove = new(); // Fix null reference

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
    }

    
}
