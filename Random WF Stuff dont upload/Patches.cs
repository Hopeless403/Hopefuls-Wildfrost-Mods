using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using WildfrostHopeMod.Utils;

namespace WildfrostHopeMod.Randoms
{
    public partial class RandomMod
    {
        [HarmonyPatch(typeof(StatusEffectSummon), nameof(StatusEffectSummon.CardPlayed))]
        internal class PatchTrySummon
        {
            static IEnumerator Postfix(IEnumerator __result, StatusEffectSummon __instance, Entity entity)
            {
                var actio = ActionQueue.GetActions().FirstOrDefault(a => a is ActionSequence && a.note.IsEmpty());
                /*if (action != default)
                {

                    ActionQueue.Remove(action);
                    ActionQueue.Stack(action);
                }*/
                Debug.LogWarning("any movements? " + ActionQueue.GetActions().Any(a => a is ActionMove));
                ActionQueue.GetActions().Update(action => {
                    Debug.LogError(action.GetType().Name);
                    action.PrintAllFields();
                });
                //yield return new WaitUntil(() => !ActionQueue.GetActions().Any(a => a is ActionRunEnableEvent action));
                /*
                if (ActionQueue.GetActions().Any(a => a is ActionRunEnableEvent action && action.entity.data == __instance.summonCard))
                    ActionQueue.GetActions().First(a => a is ActionRunEnableEvent action && action.entity.data == __instance.summonCard)
                        .fixedPosition = false;*/
                //Debug.LogWarning("any movements now? " + ActionQueue.GetActions().Any(a => a is ActionMove));
                yield return __result;
                Debug.LogWarning("successfully summoned");
                ActionQueue.GetActions().Update(action => {
                    Debug.LogError(action.GetType().Name);
                    action.PrintAllFields();
                });

            }
        }
        static void ReplaceContainerWithGrid(ref CardContainer containerToReplace, RectTransform bounds = null)
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









    }
}
