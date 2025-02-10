// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantSummon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

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

  public override IEnumerator Process()
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
    yield return (object) effectInstantSummon.\u003C\u003En__0();
  }

  public IEnumerator TrySummon()
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

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();

  public enum Position
  {
    InFrontOf,
    EnemyRow,
    Hand,
  }
}
