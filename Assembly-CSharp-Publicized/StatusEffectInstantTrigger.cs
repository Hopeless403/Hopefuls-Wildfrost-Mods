// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Trigger", fileName = "Trigger")]
public class StatusEffectInstantTrigger : StatusEffectInstant
{
  [SerializeField]
  public bool againstRandomEnemy;
  [SerializeField]
  public bool reduceUses;
  [SerializeField]
  public int priority = -1;

  public override IEnumerator Process()
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
    yield return (object) effectInstantTrigger.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
