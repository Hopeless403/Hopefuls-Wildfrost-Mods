// Decompiled with JetBrains decompiler
// Type: TargetConstraintDoesSummon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Does Summon", menuName = "Target Constraints/Does Summon")]
public class TargetConstraintDoesSummon : TargetConstraint
{
  public override bool Check(Entity target) => this.Check(target.data);

  public override bool Check(CardData targetData)
  {
    bool flag = false;
    foreach (CardData.StatusEffectStacks startWithEffect in targetData.startWithEffects)
    {
      if (startWithEffect.data is StatusEffectSummon data1 && data1.summonCard.cardType.unit || startWithEffect.data is StatusEffectApplyX data2 && data2.effectToApply is StatusEffectInstantSummon effectToApply && effectToApply.targetSummon.summonCard.cardType.unit)
      {
        flag = true;
        break;
      }
    }
    if (!flag)
    {
      foreach (CardData.StatusEffectStacks attackEffect in targetData.attackEffects)
      {
        if (attackEffect.data is StatusEffectInstantSummon data && data.targetSummon.summonCard.cardType.unit)
        {
          flag = true;
          break;
        }
      }
    }
    return !flag ? this.not : !this.not;
  }
}
