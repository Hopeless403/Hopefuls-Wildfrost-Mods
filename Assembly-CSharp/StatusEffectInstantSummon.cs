// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantSummon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Summon", fileName = "Summon X")]
public class StatusEffectInstantSummon : StatusEffectInstant
{
  [SerializeField]
  private bool canSummonMultiple;
  public StatusEffectSummon targetSummon;
  [SerializeField]
  private bool summonCopy;
  [SerializeField]
  private StatusEffectInstantSummon.Position summonPosition;
  [SerializeField]
  private StatusEffectData[] withEffects;
  [SerializeField]
  private bool queue = true;

  protected override IEnumerator Process()
  {
    StatusEffectInstantSummon effectInstantSummon = this;
    if (effectInstantSummon.canSummonMultiple)
    {
      Routine.Clump clump = new Routine.Clump();
      int amount = effectInstantSummon.GetAmount();
      for (int index = 0; index < amount; ++index)
        clump.Add(effectInstantSummon.TrySummon());
      yield return (object) clump.WaitForEnd();
    }
    else if (effectInstantSummon.queue)
    {
      ActionSequence action = new ActionSequence(effectInstantSummon.TrySummon());
      action.note = "Instant Summon";
      ActionQueue.Stack((PlayAction) action, true);
    }
    else
      yield return (object) effectInstantSummon.TrySummon();
    // ISSUE: reference to a compiler-generated method
    yield return (object) effectInstantSummon.\u003C\u003En__0();
  }

  private IEnumerator TrySummon()
  {
    StatusEffectInstantSummon effectInstantSummon = this;
    CardContainer container;
    Dictionary<Entity, List<CardSlot>> shoveData;
    if (effectInstantSummon.CanSummon(out container, out shoveData))
    {
      if (shoveData != null)
        yield return (object) ShoveSystem.DoShove(shoveData, true);
      int amount = effectInstantSummon.GetAmount();
      yield return effectInstantSummon.summonCopy ? (object) effectInstantSummon.targetSummon.SummonCopy(effectInstantSummon.target, container, effectInstantSummon.applier.display.hover.controller, effectInstantSummon.applier, effectInstantSummon.withEffects, amount) : (object) effectInstantSummon.targetSummon.Summon(container, effectInstantSummon.applier.display.hover.controller, effectInstantSummon.applier, effectInstantSummon.withEffects, amount);
    }
    else if (NoTargetTextSystem.Exists())
      yield return (object) NoTargetTextSystem.Run(effectInstantSummon.target, NoTargetType.NoSpaceToSummon);
    yield return (object) null;
  }

  private static IEnumerator ApplyEffects(
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

  private bool CanSummon(
    out CardContainer container,
    out Dictionary<Entity, List<CardSlot>> shoveData)
  {
    bool flag = false;
    container = (CardContainer) null;
    shoveData = (Dictionary<Entity, List<CardSlot>>) null;
    switch (this.summonPosition)
    {
      case StatusEffectInstantSummon.Position.InFrontOf:
        if (!this.target.alive || !Battle.IsOnBoard(this.target) || ShoveSystem.CanShove(this.target, this.target.owner.entity, out shoveData))
        {
          if (this.target.actualContainers.Count > 0)
          {
            container = this.target.actualContainers.RandomItem<CardContainer>();
            flag = true;
            break;
          }
          if (this.target.preActualContainers.Length != 0)
          {
            container = this.target.preActualContainers.RandomItem<CardContainer>();
            flag = true;
            break;
          }
          break;
        }
        break;
      case StatusEffectInstantSummon.Position.EnemyRow:
        CardContainer[] list = this.target.containers;
        if (list == null || list.Length == 0)
          list = this.target.preContainers;
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
                if ((Object) top == (Object) null || ShoveSystem.CanShove(top, this.target.owner.entity, out shoveData))
                {
                  container = (CardContainer) slot;
                  flag = true;
                  break;
                }
              }
            }
          }
          break;
        }
        break;
      case StatusEffectInstantSummon.Position.Hand:
        container = References.Player.handContainer;
        flag = true;
        break;
    }
    return flag;
  }

  private enum Position
  {
    InFrontOf,
    EnemyRow,
    Hand,
  }
}
