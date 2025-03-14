﻿// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenHit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Hit", fileName = "Apply X When Hit")]
public class StatusEffectApplyXWhenHit : StatusEffectApplyX
{
  [SerializeField]
  private TargetConstraint[] attackerConstraints;

  protected override void Init()
  {
    this.PostHit += new StatusEffectData.EffectHitEventHandler(this.CheckHit);
  }

  public override bool RunPostHitEvent(Hit hit)
  {
    return this.target.enabled && (Object) hit.target == (Object) this.target && hit.canRetaliate && (!this.targetMustBeAlive || this.target.alive && Battle.IsOnBoard(this.target)) && hit.Offensive && hit.BasicHit && this.CheckAttackerConstraints(hit.attacker);
  }

  private IEnumerator CheckHit(Hit hit)
  {
    return this.Run(this.GetTargets(hit, this.GetTargetContainers(), this.GetTargetActualContainers()), hit.damage + hit.damageBlocked);
  }

  private bool CheckAttackerConstraints(Entity attacker)
  {
    if (this.attackerConstraints != null)
    {
      foreach (TargetConstraint attackerConstraint in this.attackerConstraints)
      {
        if (!attackerConstraint.Check(attacker))
          return false;
      }
    }
    return true;
  }
}
