// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectApplyXOnHitOtherwiseY
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectApplyXOnHitOtherwiseY : StatusEffectApplyXOnHit
  {
    public StatusEffectData mainEffect;
    public StatusEffectData otherEffect;
    public TargetConstraint[] applyConstraints2;

    public override bool RunPreAttackEvent(Hit hit)
    {
      if ((Object) hit.attacker == (Object) this.target && this.target.alive && this.target.enabled && (bool) (Object) hit.target)
      {
        bool flag = true;
        foreach (TargetConstraint targetConstraint in this.applyConstraints2)
        {
          if (!targetConstraint.Check(hit.target) && (!(targetConstraint is TargetConstraintHasStatus constraintHasStatus) || !constraintHasStatus.CheckWillApply(hit)) && (!(targetConstraint is TargetConstraintHasNegativeStatus hasNegativeStatus) || !hasNegativeStatus.CheckWillApply(hit)))
          {
            flag = false;
            this.effectToApply = this.otherEffect;
            break;
          }
        }
        if (flag)
        {
          this.effectToApply = this.mainEffect;
          int amount = this.GetAmount();
          if (this.addDamageFactor != 0)
            hit.damage += amount * this.addDamageFactor;
          if ((double) this.multiplyDamageFactor != 1.0 && !this.target.silenced)
            hit.damage = Mathf.RoundToInt((float) hit.damage * this.multiplyDamageFactor);
        }
        if (!hit.Offensive && (hit.damage > 0 || (bool) (Object) this.effectToApply && this.effectToApply.offensive))
          hit.FlagAsOffensive();
        this.storedHit.Add(hit);
      }
      return false;
    }
  }
}
