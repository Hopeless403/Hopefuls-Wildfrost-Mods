﻿// Decompiled with JetBrains decompiler
// Type: TargetConstraintHasEffectBasedOn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Has Effect Based On", menuName = "Target Constraints/Has Effect Based On")]
public class TargetConstraintHasEffectBasedOn : TargetConstraint
{
  [SerializeField]
  public string basedOnStatusType;

  public override bool Check(CardData targetData)
  {
    foreach (CardData.StatusEffectStacks attackEffect in targetData.attackEffects)
    {
      if (attackEffect.data is StatusEffectInstantDoubleX data && data.statusToDouble.type == this.basedOnStatusType)
        return !this.not;
      if (attackEffect.data.type == this.basedOnStatusType)
        return !this.not;
    }
    foreach (CardData.StatusEffectStacks startWithEffect in targetData.startWithEffects)
    {
      switch (startWithEffect.data)
      {
        case StatusEffectApplyXWhenYAppliedTo applyXwhenYappliedTo:
          if (applyXwhenYappliedTo.whenAppliedType == this.basedOnStatusType || (bool) (Object) applyXwhenYappliedTo.effectToApply && applyXwhenYappliedTo.effectToApply.type == this.basedOnStatusType)
            return !this.not;
          break;
        case StatusEffectApplyXWhenYAppliedToAlly xwhenYappliedToAlly:
          if (xwhenYappliedToAlly.whenAppliedType == this.basedOnStatusType || (bool) (Object) xwhenYappliedToAlly.effectToApply && xwhenYappliedToAlly.effectToApply.type == this.basedOnStatusType)
            return !this.not;
          break;
        case StatusEffectApplyXWhenYAppliedToSelf xwhenYappliedToSelf:
          if (xwhenYappliedToSelf.whenAppliedType == this.basedOnStatusType || (bool) (Object) xwhenYappliedToSelf.effectToApply && xwhenYappliedToSelf.effectToApply.type == this.basedOnStatusType)
            return !this.not;
          break;
        case StatusEffectApplyX statusEffectApplyX:
          if ((bool) (Object) statusEffectApplyX.effectToApply && statusEffectApplyX.effectToApply.type == this.basedOnStatusType)
            return !this.not;
          break;
        case StatusEffectBonusDamageEqualToX bonusDamageEqualToX:
          if (bonusDamageEqualToX.effectType == this.basedOnStatusType)
            return !this.not;
          break;
      }
    }
    return this.not;
  }

  public override bool Check(Entity target) => this.Check(target.data);
}
