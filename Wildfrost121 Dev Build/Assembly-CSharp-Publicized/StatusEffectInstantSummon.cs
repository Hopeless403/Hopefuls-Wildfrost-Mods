// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantSummon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Summon", fileName = "Summon X")]
public class StatusEffectInstantSummon : StatusEffectInstant
{
  [SerializeField]
  public bool canSummonMultiple;
  public StatusEffectSummon targetSummon;
  [SerializeField]
  public bool summonCopy;
  [SerializeField]
  public StatusEffectInstantSummon.Position summonPosition;
  [SerializeField]
  public StatusEffectData[] withEffects;
  [SerializeField]
  public bool queue = true;
  public bool buildingToSummon;
  public Entity toSummon;

  public override IEnumerator Process()
  {
    StatusEffectInstantSummon effectInstantSummon = this;
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
      yield return (object) clump.WaitForEnd();
    }
    else if (effectInstantSummon.queue)
    {
      if (effectInstantSummon.summonCopy)
      {
        Routine routine = new Routine(effectInstantSummon.CreateCopy(effectInstantSummon.target, new UnityAction<Entity>(effectInstantSummon.\u003CProcess\u003Eb__9_0)));
      }
      ActionSequence action = new ActionSequence(effectInstantSummon.TrySummon());
      action.note = "Instant Summon";
      ActionQueue.Stack((PlayAction) action, true);
    }
    else
      yield return (object) effectInstantSummon.TrySummon();
    yield return (object) effectInstantSummon.\u003C\u003En__0();
  }

  public IEnumerator CreateCopy(Entity toCopy, UnityAction<Entity> onComplete)
  {
    StatusEffectInstantSummon effectInstantSummon = this;
    effectInstantSummon.buildingToSummon = true;
    Card card = (Card) null;
    CardContainer container;
    if (effectInstantSummon.CanSummon(out container, out Dictionary<Entity, List<CardSlot>> _))
    {
      card = effectInstantSummon.targetSummon.CreateCardCopy(effectInstantSummon.target.data, container, effectInstantSummon.applier.display.hover.controller);
      card.entity.startingEffectsApplied = true;
      yield return (object) card.UpdateData(false);
      yield return (object) effectInstantSummon.targetSummon.CopyStatsAndEffects(card.entity, toCopy);
    }
    effectInstantSummon.buildingToSummon = false;
    UnityAction<Entity> unityAction = onComplete;
    if (unityAction != null)
      unityAction((bool) (UnityEngine.Object) card ? card.entity : (Entity) null);
  }

  public IEnumerator CreateCopyAndTrySummon()
  {
    StatusEffectInstantSummon effectInstantSummon = this;
    yield return (object) effectInstantSummon.CreateCopy(effectInstantSummon.target, new UnityAction<Entity>(effectInstantSummon.\u003CCreateCopyAndTrySummon\u003Eb__11_0));
    if ((bool) (UnityEngine.Object) effectInstantSummon.toSummon)
      yield return (object) effectInstantSummon.TrySummon();
  }

  public IEnumerator TrySummon()
  {
    StatusEffectInstantSummon effectInstantSummon = this;
    if (effectInstantSummon.buildingToSummon)
      yield return (object) new WaitUntil(new Func<bool>(effectInstantSummon.\u003CTrySummon\u003Eb__12_0));
    CardContainer container;
    Dictionary<Entity, List<CardSlot>> shoveData;
    if (effectInstantSummon.CanSummon(out container, out shoveData))
    {
      if (shoveData != null)
        yield return (object) ShoveSystem.DoShove(shoveData, true);
      int amount = effectInstantSummon.GetAmount();
      yield return (bool) (UnityEngine.Object) effectInstantSummon.toSummon ? (object) effectInstantSummon.targetSummon.SummonPreMade(effectInstantSummon.toSummon, container, effectInstantSummon.applier.display.hover.controller, effectInstantSummon.applier, effectInstantSummon.withEffects, amount) : (effectInstantSummon.summonCopy ? (object) effectInstantSummon.targetSummon.SummonCopy(effectInstantSummon.target, container, effectInstantSummon.applier.display.hover.controller, effectInstantSummon.applier, effectInstantSummon.withEffects, amount) : (object) effectInstantSummon.targetSummon.Summon(container, effectInstantSummon.applier.display.hover.controller, effectInstantSummon.applier, effectInstantSummon.withEffects, amount));
    }
    else if (NoTargetTextSystem.Exists())
    {
      if ((bool) (UnityEngine.Object) effectInstantSummon.toSummon)
      {
        effectInstantSummon.toSummon.RemoveFromContainers();
        UnityEngine.Object.Destroy((UnityEngine.Object) effectInstantSummon.toSummon);
      }
      yield return (object) NoTargetTextSystem.Run(effectInstantSummon.target, NoTargetType.NoSpaceToSummon);
    }
    yield return (object) null;
  }

  public static IEnumerator ApplyEffects(
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
    yield return (object) hit.Process();
  }

  public bool CanSummon(
    out CardContainer container,
    out Dictionary<Entity, List<CardSlot>> shoveData)
  {
    bool flag = false;
    container = (CardContainer) null;
    shoveData = (Dictionary<Entity, List<CardSlot>>) null;
    switch (this.summonPosition)
    {
      case StatusEffectInstantSummon.Position.InFrontOf:
        flag = StatusEffectInstantSummon.CanSummonInFrontOf(this.target, out container, out shoveData);
        break;
      case StatusEffectInstantSummon.Position.EnemyRow:
        flag = StatusEffectInstantSummon.CanSummonInEnemyRow(this.target, out container, out shoveData);
        break;
      case StatusEffectInstantSummon.Position.Hand:
        container = References.Player.handContainer;
        flag = true;
        break;
      case StatusEffectInstantSummon.Position.AppliersPosition:
        flag = StatusEffectInstantSummon.CanSummonInFrontOf(this.applier, out container, out shoveData);
        break;
      case StatusEffectInstantSummon.Position.InFrontOfOrOtherRow:
        if (StatusEffectInstantSummon.CanSummonInFrontOf(this.target, out container, out shoveData))
        {
          flag = container.owner.team == this.applier.owner.team || StatusEffectInstantSummon.CanSummonInEnemyRow(this.target, out container, out shoveData);
          break;
        }
        break;
    }
    return flag;
  }

  public static bool CanSummonInFrontOf(
    Entity inFrontOf,
    out CardContainer container,
    out Dictionary<Entity, List<CardSlot>> shoveData)
  {
    bool flag1 = false;
    container = (CardContainer) null;
    shoveData = (Dictionary<Entity, List<CardSlot>>) null;
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
        if (!(bool) (UnityEngine.Object) top || ShoveSystem.CanShove(top, top.owner.entity, out shoveData))
        {
          container = slotToShove;
          flag1 = true;
        }
      }
    }
    return flag1;
  }

  public static CardContainer GetSlotToShove(Entity entity)
  {
    if (entity.actualContainers.Count > 0)
      return entity.actualContainers.RandomItem<CardContainer>();
    return entity.preActualContainers.Length == 0 ? (CardContainer) null : entity.preActualContainers.RandomItem<CardContainer>();
  }

  public static bool CanSummonInEnemyRow(
    Entity target,
    out CardContainer container,
    out Dictionary<Entity, List<CardSlot>> shoveData)
  {
    bool flag = false;
    container = (CardContainer) null;
    shoveData = (Dictionary<Entity, List<CardSlot>>) null;
    CardContainer[] list = target.containers;
    if (list == null || list.Length == 0)
      list = target.preContainers;
    if (list != null && list.Length != 0)
    {
      ((IList<CardContainer>) list).Shuffle<CardContainer>();
      foreach (CardContainer cardContainer in list)
      {
        if (cardContainer is CardSlotLane row)
        {
          CardSlotLane oppositeRow = References.Battle.GetOppositeRow(row);
          if (oppositeRow != null)
          {
            CardSlot slot = oppositeRow.slots[0];
            Entity top = slot.GetTop();
            if ((UnityEngine.Object) top == (UnityEngine.Object) null || ShoveSystem.CanShove(top, target.owner.entity, out shoveData))
            {
              container = (CardContainer) slot;
              flag = true;
              break;
            }
          }
        }
      }
    }
    return flag;
  }

  [CompilerGenerated]
  public void \u003CProcess\u003Eb__9_0(Entity e) => this.toSummon = e;

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();

  [CompilerGenerated]
  public void \u003CCreateCopyAndTrySummon\u003Eb__11_0(Entity e) => this.toSummon = e;

  [CompilerGenerated]
  public bool \u003CTrySummon\u003Eb__12_0() => (bool) (UnityEngine.Object) this.toSummon;

  public enum Position
  {
    InFrontOf,
    EnemyRow,
    Hand,
    AppliersPosition,
    InFrontOfOrOtherRow,
  }
}
