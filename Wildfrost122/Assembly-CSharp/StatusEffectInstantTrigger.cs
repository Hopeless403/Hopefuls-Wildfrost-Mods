// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Trigger", fileName = "Trigger")]
public class StatusEffectInstantTrigger : StatusEffectInstant
{
  [SerializeField]
  private bool againstRandomEnemy;
  [SerializeField]
  private bool reduceUses;
  [SerializeField]
  private int priority = -1;

  protected override IEnumerator Process()
  {
    StatusEffectInstantTrigger effectInstantTrigger = this;
    if (effectInstantTrigger.againstRandomEnemy && effectInstantTrigger.target.NeedsTarget)
    {
      List<Entity> allEnemies = effectInstantTrigger.target.GetAllEnemies();
      if (allEnemies.Count > 0)
      {
        Entity target = allEnemies.RandomItem<Entity>();
        CardContainer targetContainer = target.containers.RandomItem<CardContainer>();
        ActionQueue.Stack((PlayAction) new ActionTriggerAgainst(effectInstantTrigger.target, effectInstantTrigger.applier, target, targetContainer), true);
      }
    }
    else
    {
      ActionTrigger action = new ActionTrigger(effectInstantTrigger.target, effectInstantTrigger.applier);
      action.priority = effectInstantTrigger.priority;
      ActionQueue.Stack((PlayAction) action, true);
    }
    if (effectInstantTrigger.reduceUses)
      ActionQueue.Add((PlayAction) new ActionReduceUses(effectInstantTrigger.target));
    // ISSUE: reference to a compiler-generated method
    yield return (object) effectInstantTrigger.\u003C\u003En__0();
  }
}
