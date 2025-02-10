// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenHit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Hit", fileName = "Apply X When Hit")]
public class StatusEffectApplyXWhenHit : StatusEffectApplyX
{
  [SerializeField]
  private TargetConstraint[] attackerConstraints;

  protected override void Init() => this.PostHit += new StatusEffectData.EffectHitEventHandler(this.CheckHit);

  public override bool RunPostHitEvent(Hit hit) => this.target.enabled && (Object) hit.target == (Object) this.target && hit.canRetaliate && (!this.targetMustBeAlive || this.target.alive && Battle.IsOnBoard(this.target)) && hit.Offensive && hit.BasicHit && this.CheckAttackerConstraints(hit.attacker);

  private IEnumerator CheckHit(Hit hit) => this.Run(this.GetTargets(hit, this.GetTargetContainers(), this.GetTargetActualContainers()), hit.damage + hit.damageBlocked);

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
