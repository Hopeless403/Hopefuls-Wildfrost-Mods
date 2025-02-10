// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXOnHit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X On Hit", fileName = "Apply X On Hit")]
public class StatusEffectApplyXOnHit : StatusEffectApplyX
{
  [SerializeField]
  private bool postHit;
  [Header("Modify Damage")]
  [SerializeField]
  private int addDamageFactor;
  [SerializeField]
  private float multiplyDamageFactor = 1f;
  private readonly List<Hit> storedHit = new List<Hit>();

  protected override void Init()
  {
    if (this.postHit)
      this.PostHit += new StatusEffectData.EffectHitEventHandler(this.CheckHit);
    else
      this.OnHit += new StatusEffectData.EffectHitEventHandler(this.CheckHit);
  }

  public override bool RunPreAttackEvent(Hit hit)
  {
    if ((Object) hit.attacker == (Object) this.target && this.target.alive && this.target.enabled && (bool) (Object) hit.target)
    {
      if (this.addDamageFactor != 0 || (double) this.multiplyDamageFactor != 1.0)
      {
        bool flag = true;
        foreach (TargetConstraint applyConstraint in this.applyConstraints)
        {
          if (!applyConstraint.Check(hit.target) && (!(applyConstraint is TargetConstraintHasStatus constraintHasStatus) || !constraintHasStatus.CheckWillApply(hit)))
          {
            flag = false;
            break;
          }
        }
        if (flag)
        {
          int amount = this.GetAmount();
          if (this.addDamageFactor != 0)
            hit.damage += amount * this.addDamageFactor;
          if ((double) this.multiplyDamageFactor != 1.0)
            hit.damage = Mathf.RoundToInt((float) hit.damage * this.multiplyDamageFactor);
        }
      }
      if (!hit.Offensive && (hit.damage > 0 || (bool) (Object) this.effectToApply && this.effectToApply.offensive))
        hit.FlagAsOffensive();
      this.storedHit.Add(hit);
    }
    return false;
  }

  public override bool RunPostHitEvent(Hit hit) => this.storedHit.Contains(hit) && hit.Offensive;

  public override bool RunHitEvent(Hit hit) => this.storedHit.Contains(hit) && hit.Offensive;

  private IEnumerator CheckHit(Hit hit)
  {
    StatusEffectApplyXOnHit effectApplyXonHit = this;
    if ((bool) (Object) effectApplyXonHit.effectToApply)
      yield return (object) effectApplyXonHit.Run(effectApplyXonHit.GetTargets(hit), hit.damage + hit.damageBlocked);
    effectApplyXonHit.storedHit.Remove(hit);
  }
}
