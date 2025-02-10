using System.Collections;
using System.Linq;
using UnityEngine;
using System.Collections.Generic;
using System;
using static EventRoutineCharmShop;
using HarmonyLib;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleCustom
    {
        public class CommandCustomReroll : ConsoleCustom.Command
        {
            public override string id => "reroll";
            public override string desc => "new leaders, or card rewards";
            public override bool IsRoutine => true;

            public override IEnumerator Routine(string args)
            {
                foreach (IRerollable rerollable in Enumerable.OfType<IRerollable>(UnityEngine.Object.FindObjectsOfType<MonoBehaviour>()))
                {
                    Debug.LogWarning($"Rerolling [{rerollable}]");
                    if (rerollable is SelectLeader leader)
                    {
                        yield return leader.GenerateLeaders(false);
                        CardPopUp.Clear();
                        leader.FlipUpLeadersInstant();
                        Debug.LogWarning("Rerolled!");
                        yield break;
                    }
                    else if (rerollable.Reroll())
                    {
                        Debug.LogWarning("Rerolled!");
                        yield break;
                    }
                }
                EventRoutine routine = GameObject.FindObjectOfType<EventRoutine>();
                if (routine)
                {
                    Debug.LogWarning("[AConsole] Found a routine " + routine);
                    yield return RerollRoutine(routine);
                    yield break;
                }

                this.Fail("Nothing to reroll");
            }

            public IEnumerator RerollRoutine(EventRoutine routine)
            {
                switch (routine.GetType().Name)
                {
                    case nameof(EventRoutineCharmShop):
                        yield return RerollCharmShop(routine as EventRoutineCharmShop);
                        yield break;
                    case nameof(EventRoutineCurseItems):
                        yield return RerollCurseItems(routine as EventRoutineCurseItems);
                        yield break;
                    case nameof(EventRoutineInjuredCompanion):
                        yield return RerollInjuredCompanion(routine as EventRoutineInjuredCompanion);
                        yield break;
                    case nameof(ShopRoutine):
                        yield return RerollShop(routine as ShopRoutine);
                        yield break;
                }
                this.Fail("Nothing to reroll");
            }

            public IEnumerator RerollCharmShop(EventRoutineCharmShop routine)
            {
                if (!routine.cardContainer.gameObject.activeInHierarchy || !routine.cardSelector.enabled || InspectSystem.IsActive())
                {
                    FailCannotUse();
                    yield break;
                }
                InspectNewUnitSequence objectOfType = UnityEngine.Object.FindObjectOfType<InspectNewUnitSequence>();
                if (objectOfType != null && objectOfType.gameObject.activeSelf)
                {
                    FailCannotUse();
                    yield break;
                }

                var node = routine.node.type as CampaignNodeTypeCharmShop;
                //node.force = [];
                //node.forceCards = [];
                yield return node.SetUp(routine.node);

                foreach (var shopItem in routine.priceManager.targets)
                {
                    if (shopItem.target && shopItem.target.TryGetComponent<Entity>(out var entity) && routine.cardContainer.Contains(entity))
                        shopItem.gameObject.Destroy();
                }
                routine.cardContainer.entities.ForEach(e => CardManager.ReturnToPool(e));
                routine.cardContainer.Clear();
                foreach (var charmHolder in routine.holders)
                {
                    charmHolder.list.ForEach(u => u.Destroy());
                    charmHolder.Clear();
                }
                routine.items.Clear();

                yield return routine.Populate();
            }
            public IEnumerator RerollCurseItems(EventRoutineCurseItems routine)
            {
                if (!routine.cardContainer.gameObject.activeInHierarchy || !routine.cardSelector.enabled || InspectSystem.IsActive())
                {
                    FailCannotUse();
                    yield break;
                }
                InspectNewUnitSequence objectOfType = UnityEngine.Object.FindObjectOfType<InspectNewUnitSequence>();
                if (objectOfType != null && objectOfType.gameObject.activeSelf)
                {
                    FailCannotUse();
                    yield break;
                }

                var node = routine.node.type as CampaignNodeTypeCurseItems;
                //node.force = [];
                yield return node.SetUp(routine.node);

                routine.curseCardContainer.DestroyAllChildren();
                routine.cardContainer.entities.ForEach(e => CardManager.ReturnToPool(e));
                routine.cardContainer.Clear();
                routine.cards.Clear();
                routine.curses.Clear();
                yield return routine.Populate();
                routine.cardContainer.entities.ForEach(e => e.flipper.FlipUpInstant());
            }
            public IEnumerator RerollInjuredCompanion(EventRoutineInjuredCompanion routine)
            {
                if (!routine.cardContainer.gameObject.activeInHierarchy || !routine.cardSelector.enabled || InspectSystem.IsActive())
                {
                    FailCannotUse();
                    yield break;
                }
                InspectNewUnitSequence objectOfType = UnityEngine.Object.FindObjectOfType<InspectNewUnitSequence>();
                if (objectOfType != null && objectOfType.gameObject.activeSelf)
                {
                    FailCannotUse();
                    yield break;
                }

                var node = routine.node.type as CampaignNodeTypeInjuredCompanion;
                yield return node.SetUp(routine.node);

                routine.cardContainer.entities.ForEach(e => CardManager.ReturnToPool(e));
                routine.cardContainer.Clear();
                yield return routine.Populate();
                routine.cardContainer.entities.ForEach(e => e.flipper.FlipUpInstant());
            }
            public IEnumerator RerollShop(ShopRoutine routine)
            {
                if (!routine.containers.Any(c => c.container.gameObject.activeInHierarchy) || !routine.cardSelector.enabled || InspectSystem.IsActive())
                {
                    FailCannotUse();
                    yield break;
                }
                InspectNewUnitSequence objectOfType = UnityEngine.Object.FindObjectOfType<InspectNewUnitSequence>();
                if (objectOfType != null && objectOfType.gameObject.activeSelf)
                {
                    FailCannotUse();
                    yield break;
                }

                var node = routine.node.type as CampaignNodeTypeShop;
                yield return node.SetUp(routine.node);

                foreach (var shopItem in routine.priceManager.targets)
                {
                    if (shopItem.target)
                        shopItem.gameObject.Destroy();
                }
                routine.containers.Update(c => c.container.entities.ForEach(e => CardManager.ReturnToPool(e)));
                routine.containers.Update(c => c.container.Clear());
                /*routine.crownHolder..list.ForEach(u => u.Destroy());
                routine.crownHolder.Clear();*/
                //routine.items.Clear();

                yield return routine.Populate();
            }
        }
    }
}