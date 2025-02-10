using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.Events;
using UnityEngine;

public class StatusEffectInstantSummonInDeck : StatusEffectInstantSummon
    {
        new public StatusEffectInstantSummonInDeck.Position summonPosition;

        public override IEnumerator Process()
        {
            StatusEffectInstantSummonInDeck effectInstantSummon = this;
            if (effectInstantSummon.canSummonMultiple)
            {
                Routine.Clump clump = new Routine.Clump();
                int amount = effectInstantSummon.GetAmount();
                for (int index = 0; index < amount; ++index)
                {
                    if (effectInstantSummon.summonCopy)
                        clump.Add(effectInstantSummon.CreateCopyAndTrySummon());
                    else
                        clump.Add(effectInstantSummon.TrySummon());
                }
                yield return clump.WaitForEnd();
            }
            else if (effectInstantSummon.queue)
            {
                if (effectInstantSummon.summonCopy)
                {
                    new Routine(CreateCopy(target, delegate (Entity e)
                    {
                        toSummon = e;
                    }));
                }
                ActionSequence action = new ActionSequence(effectInstantSummon.TrySummon());
                action.note = "Instant Summon";
                ActionQueue.Stack((PlayAction)action, true);
            }
            else
                yield return effectInstantSummon.TrySummon();
            yield return effectInstantSummon.Remove();
        }

        new private IEnumerator CreateCopy(Entity toCopy, UnityAction<Entity> onComplete)
        {
            StatusEffectInstantSummonInDeck effectInstantSummon = this;
            effectInstantSummon.buildingToSummon = true;
            Card card = (Card)null;
            CardContainer container;
            if (effectInstantSummon.CanSummon(out container, out Dictionary<Entity, List<CardSlot>> _))
            {
                card = effectInstantSummon.targetSummon.CreateCardCopy(effectInstantSummon.target.data, container, effectInstantSummon.applier.display.hover.controller);
                card.entity.startingEffectsApplied = true;
                yield return card.UpdateData(false);
                yield return effectInstantSummon.targetSummon.CopyStatsAndEffects(card.entity, toCopy);
            }
            effectInstantSummon.buildingToSummon = false;
            UnityAction<Entity> unityAction = onComplete;
            if (unityAction != null)
                unityAction((bool)(UnityEngine.Object)card ? card.entity : (Entity)null);
        }

        new private IEnumerator CreateCopyAndTrySummon()
        {
            yield return CreateCopy(target, delegate (Entity e)
            {
                toSummon = e;
            });
            if ((bool)toSummon)
            {
                yield return TrySummon();
            }
        }

        new private IEnumerator TrySummon()
        {
            StatusEffectInstantSummonInDeck effectInstantSummon = this;
            if (effectInstantSummon.buildingToSummon)
            {
                yield return new WaitUntil(() => toSummon);
                Debug.LogWarning("WE GOT DA SUMMON BOSS! " + toSummon);
            }
            CardContainer container;
            Dictionary<Entity, List<CardSlot>> shoveData;
            if (effectInstantSummon.CanSummon(out container, out shoveData))
            {
                Debug.LogWarning("WE GOT DA CONTAINER BOSS! " + container + (shoveData == null));
                if (shoveData != null)
                    yield return ShoveSystem.DoShove(shoveData, true);
                int amount = effectInstantSummon.GetAmount();
                Debug.LogWarning("WE GOT DA PARAMETERS BOSS!\n"
                                 + (
                                 effectInstantSummon.toSummon, 
                                 effectInstantSummon.targetSummon, 
                                 effectInstantSummon.applier, 
                                 effectInstantSummon.applier?.display, 
                                 effectInstantSummon.applier?.display?.hover, 
                                 effectInstantSummon.withEffects
                                 ));

                if (effectInstantSummon.toSummon)
                {
                    yield return effectInstantSummon.targetSummon.SummonPreMade(effectInstantSummon.toSummon,
                                                                                container,
                                                                                effectInstantSummon.applier.display.hover.controller,
                                                                                effectInstantSummon.applier,
                                                                                effectInstantSummon.withEffects,
                                                                                amount);
                }
                else if (effectInstantSummon.summonCopy)
                {
                    yield return effectInstantSummon.targetSummon.SummonCopy(effectInstantSummon.target,
                                                                             container,
                                                                             effectInstantSummon.applier.display.hover.controller,
                                                                             effectInstantSummon.applier,
                                                                             effectInstantSummon.withEffects,
                                                                             amount);
                }
                else
                {
                    yield return effectInstantSummon.targetSummon.Summon(container,
                                                                         effectInstantSummon.applier.display.hover.controller,
                                                                         effectInstantSummon.applier,
                                                                         effectInstantSummon.withEffects,
                                                                         amount);
                }
            }
            else if (NoTargetTextSystem.Exists())
            {
                Debug.LogWarning("AINT THERE SPACE TO SUMMON, BOSS?");
                if ((bool)(UnityEngine.Object)effectInstantSummon.toSummon)
                {
                    effectInstantSummon.toSummon.RemoveFromContainers();
                    UnityEngine.Object.Destroy((UnityEngine.Object)effectInstantSummon.toSummon);
                }
                yield return NoTargetTextSystem.Run(effectInstantSummon.target, NoTargetType.NoSpaceToSummon);
            }
            yield return null;
        }

        new private static IEnumerator ApplyEffects(
          Entity applier,
          Entity entity,
          IEnumerable<StatusEffectData> effects,
          int count)
        {
            Hit hit = new Hit(applier, entity, 0)
            {
                countsAsHit = false,
                canRetaliate = false
            };
            foreach (StatusEffectData effect in effects)
                hit.AddStatusEffect(effect, count);
            yield return hit.Process();
        }

        new private bool CanSummon(
          out CardContainer container,
          out Dictionary<Entity, List<CardSlot>> shoveData)
        {
            bool flag = false;
            container = (CardContainer)null;
            shoveData = (Dictionary<Entity, List<CardSlot>>)null;

            flag = true;
            container = References.Player.discardContainer;
            return flag;

            switch (this.summonPosition)
            {
                case StatusEffectInstantSummonInDeck.Position.InFrontOf:
                    flag = StatusEffectInstantSummon.CanSummonInFrontOf(this.target, out container, out shoveData);
                    break;
                case StatusEffectInstantSummonInDeck.Position.EnemyRow:
                    flag = StatusEffectInstantSummon.CanSummonInEnemyRow(this.target, out container, out shoveData);
                    break;
                case StatusEffectInstantSummonInDeck.Position.Hand:
                    container = References.Player.handContainer;
                    flag = true;
                    break;
                case StatusEffectInstantSummonInDeck.Position.AppliersPosition:
                    flag = StatusEffectInstantSummon.CanSummonInFrontOf(this.applier, out container, out shoveData);
                    break;
                case StatusEffectInstantSummonInDeck.Position.InFrontOfOrOtherRow:
                    if (StatusEffectInstantSummon.CanSummonInFrontOf(this.target, out container, out shoveData))
                    {
                        flag = container.owner.team == this.applier.owner.team || StatusEffectInstantSummon.CanSummonInEnemyRow(this.target, out container, out shoveData);
                        break;
                    }
                    break;
            }
            return flag;
        }

        new private static bool CanSummonInFrontOf(
          Entity inFrontOf,
          out CardContainer container,
          out Dictionary<Entity, List<CardSlot>> shoveData)
        {
            bool flag1 = false;
            container = (CardContainer)null;
            shoveData = (Dictionary<Entity, List<CardSlot>>)null;
            bool flag2 = Battle.IsOnBoard(inFrontOf);
            if (!inFrontOf.alive || !flag2)
            {
                if (inFrontOf.actualContainers.Count > 0)
                {
                    container = inFrontOf.actualContainers.RandomItem<CardContainer>();
                    flag1 = true;
                }
                else if (inFrontOf.preActualContainers.Length != 0)
                {
                    container = inFrontOf.preActualContainers.RandomItem<CardContainer>();
                    flag1 = true;
                }
            }
            if (!flag1 & flag2)
            {
                CardContainer slotToShove = StatusEffectInstantSummon.GetSlotToShove(inFrontOf);
                if (slotToShove != null)
                {
                    Entity top = slotToShove.GetTop();
                    if (!(bool)(UnityEngine.Object)top || ShoveSystem.CanShove(top, top.owner.entity, out shoveData))
                    {
                        container = slotToShove;
                        flag1 = true;
                    }
                }
            }
            return flag1;
        }

        new private static CardContainer GetSlotToShove(Entity entity)
        {
            if (entity.actualContainers.Count > 0)
                return entity.actualContainers.RandomItem<CardContainer>();
            return entity.preActualContainers.Length == 0 ? (CardContainer)null : entity.preActualContainers.RandomItem<CardContainer>();
        }

        new private static bool CanSummonInEnemyRow(
          Entity target,
          out CardContainer container,
          out Dictionary<Entity, List<CardSlot>> shoveData)
        {
            bool flag = false;
            container = (CardContainer)null;
            shoveData = (Dictionary<Entity, List<CardSlot>>)null;
            CardContainer[] list = target.containers;
            if (list == null || list.Length == 0)
                list = target.preContainers;
            if (list != null && list.Length != 0)
            {
                ((IList<CardContainer>)list).Shuffle<CardContainer>();
                foreach (CardContainer cardContainer in list)
                {
                    if (cardContainer is CardSlotLane row)
                    {
                        CardSlotLane oppositeRow = References.Battle.GetOppositeRow(row);
                        if (oppositeRow != null)
                        {
                            CardSlot slot = oppositeRow.slots[0];
                            Entity top = slot.GetTop();
                            if ((UnityEngine.Object)top == (UnityEngine.Object)null || ShoveSystem.CanShove(top, target.owner.entity, out shoveData))
                            {
                                container = (CardContainer)slot;
                                flag = true;
                                break;
                            }
                        }
                    }
                }
            }
            return flag;
        }

        new public enum Position
        {
            InFrontOf,
            EnemyRow,
            Hand,
            AppliersPosition,
            InFrontOfOrOtherRow,
        }
    }
