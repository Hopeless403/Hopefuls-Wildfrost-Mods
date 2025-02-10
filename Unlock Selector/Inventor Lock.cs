using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace WildfrostHopeMod
{
    internal class InventorLocks
    {
        public List<string> lockedCards;
        internal static void Lock(Entity unlockable, ref List<string> lockedCards)
        {
            (unlockable.display as Card).mainImage.color = Color.black;
            (unlockable.display as Card).backgroundImage.color = Color.gray;
            lockedCards.Add(unlockable._data.name.ToLower());
            Debug.LogWarning($"Locked [{unlockable._data.name}]!");
        }
        internal static void Unlock(Entity unlockable, ref List<string> lockedCards)
        {
            (unlockable.display as Card).mainImage.color = Color.white;
            (unlockable.display as Card).backgroundImage.color = Color.white;
            lockedCards.Remove(unlockable._data.name.ToLower());
            Debug.LogWarning($"Unlocked [{unlockable._data.name}]!");
        }
        internal static bool ShouldLock(Entity card, List<string> lockedCards)
            => lockedCards.Select(c => c.ToLower()).Contains(card._data.name.ToLower());
        internal static bool CanLock(Entity card, string key = "items")
            => ((List<string>)MetaprogressionSystem.data[key]).Contains(card._data.name);

        [HarmonyPatch(typeof(InventorHutSequence), nameof(InventorHutSequence.CreateCards))]
        internal class PatchDiscover
        {
            class SimpleEnumerator : IEnumerable
            {
                public IEnumerator enumerator;
                public Action prefixAction, postfixAction;
                public Action<object> preItemAction, postItemAction;
                public Func<object, object> itemAction;
                IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
                public IEnumerator GetEnumerator()
                {
                    prefixAction();
                    while (enumerator.MoveNext())
                    {
                        var item = enumerator.Current;
                        preItemAction(item);
                        yield return itemAction(item);
                        postItemAction(item);
                    }
                    postfixAction();
                }
            }

            static void Postfix(ref IEnumerator __result, InventorHutSequence __instance)
            {
                Action prefixAction = () => { };
                Action postfixAction = () => { Tryfix(__instance); };
                Action<object> preItemAction = (item) => { };
                Action<object> postItemAction = (item) => { };
                Func<object, object> itemAction = (item) =>
                {
                    var newItem = item + "+";
                    //Debug.LogWarning($"--> item {item} => {newItem}");
                    return newItem;
                };
                var myEnumerator = new SimpleEnumerator()
                {
                    enumerator = __result,
                    prefixAction = prefixAction,
                    postfixAction = postfixAction,
                    preItemAction = preItemAction,
                    postItemAction = postItemAction,
                    itemAction = itemAction
                };
                __result = myEnumerator.GetEnumerator();
            }
            static void Tryfix(InventorHutSequence __instance)
            {
                Debug.LogWarning("Postfixingcreation");
                foreach (var slot in __instance.cardSlots)
                {
                    var unlockable = slot.entities.FirstOrDefault();
                    if (unlockable != null)
                        if (CanLock(unlockable) && ShouldLock(unlockable, UnlockSelector.lockedItems))
                            Lock(unlockable, ref UnlockSelector.lockedItems);
                }
            }
        }
        [HarmonyPatch(typeof(InventorHutSequence), nameof(InventorHutSequence.Start))]
        internal class PatchStart
        {
            static void Postfix(InventorHutSequence __instance)
            {
                Debug.Log("Started");
                foreach (var slot in __instance.cardSlots)
                {
                    var unlockable = slot.entities.FirstOrDefault();
                    if (unlockable != null)
                        if (CanLock(unlockable) && ShouldLock(unlockable, UnlockSelector.lockedItems))
                            Lock(unlockable, ref UnlockSelector.lockedItems);
                }
            }
        }

        internal static void Listener(InventorHutSequence seq) => UnlockSelector.controller = seq.controller;
    }
}

