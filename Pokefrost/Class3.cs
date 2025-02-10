// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenHitFree
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class StatusEffectApplyXWhenHitFree : StatusEffectApplyX
{
  [SerializeField]
  public TargetConstraint[] attackerConstraints;

  public override void Init()
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
