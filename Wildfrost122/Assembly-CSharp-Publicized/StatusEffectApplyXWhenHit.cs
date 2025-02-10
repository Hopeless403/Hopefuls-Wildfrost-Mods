// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenHit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Hit", fileName = "Apply X When Hit")]
public class StatusEffectApplyXWhenHit : StatusEffectApplyX
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

  public IEnumerator CheckHit(Hit hit)
  {
    return this.Run(this.GetTargets(hit, this.GetTargetContainers(), this.GetTargetActualContainers()), hit.damage + hit.damageBlocked);
  }

  public bool CheckAttackerConstraints(Entity attacker)
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
