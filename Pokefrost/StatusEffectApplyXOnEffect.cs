// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectApplyXOnEffect
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectApplyXOnEffect : StatusEffectApplyX
  {
    [SerializeField]
    private bool postHit;
    public StatusEffectData conditionEffect;
    [Header("Modify Damage")]
    [SerializeField]
    private int addDamageFactor;
    [SerializeField]
    private float multiplyDamageFactor = 1f;
    private readonly List<Hit> storedHit = new List<Hit>();

    public override void Init()
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
      if ((bool) (Object) this.effectToApply)
      {
        foreach (StatusEffectData statusEffect in hit.attacker.statusEffects)
        {
          StatusEffectData status = statusEffect;
          if (status.name == this.conditionEffect.name)
          {
            yield return (object) this.Run(this.GetTargets(hit), status.count);
            break;
          }
          status = (StatusEffectData) null;
        }
        yield return (object) null;
      }
      this.storedHit.Remove(hit);
    }
  }
}
