// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenUnitIsHit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Unit Is Hit", fileName = "Apply X When Unit Is Hit")]
public class StatusEffectApplyXWhenUnitIsHit : StatusEffectApplyX
{
  [SerializeField]
  private bool ally = true;
  [SerializeField]
  private bool enemy;
  [SerializeField]
  private TargetConstraint[] unitConstraints;
  [SerializeField]
  private TargetConstraint[] attackerConstraints;

  protected override void Init()
  {
    this.PostHit += new StatusEffectData.EffectHitEventHandler(this.Check);
  }

  public override bool RunPostHitEvent(Hit hit)
  {
    return this.target.enabled && this.target.alive && hit.canRetaliate && hit.BasicHit && hit.Offensive && this.CheckTeam(hit.target) && (!this.targetMustBeAlive || hit.target.alive && Battle.IsOnBoard(hit.target)) && Battle.IsOnBoard(this.target) && this.CheckConstraints(hit.target) && this.CheckAttackerConstraints(hit.attacker);
  }

  private IEnumerator Check(Hit hit)
  {
    StatusEffectApplyXWhenUnitIsHit applyXwhenUnitIsHit = this;
    if ((bool) (UnityEngine.Object) applyXwhenUnitIsHit.contextEqualAmount)
    {
      int amount = applyXwhenUnitIsHit.contextEqualAmount.Get(hit.target);
      yield return (object) applyXwhenUnitIsHit.Run(applyXwhenUnitIsHit.GetTargets(hit), amount);
    }
    else
      yield return (object) applyXwhenUnitIsHit.Run(applyXwhenUnitIsHit.GetTargets(hit));
  }

  private bool CheckTeam(Entity entity)
  {
    if ((UnityEngine.Object) this.target.owner == (UnityEngine.Object) entity.owner)
      return this.ally;
    return (UnityEngine.Object) this.target.owner != (UnityEngine.Object) entity.owner && this.enemy;
  }

  private new bool CheckConstraints(Entity entity)
  {
    return this.unitConstraints == null || ((IEnumerable<TargetConstraint>) this.unitConstraints).All<TargetConstraint>((Func<TargetConstraint, bool>) (c => c.Check(entity)));
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
