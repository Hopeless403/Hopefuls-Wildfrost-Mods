// Decompiled with JetBrains decompiler
// Type: TargetConstraintHasStatusType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Has Status Type", menuName = "Target Constraints/Has Status Type")]
public class TargetConstraintHasStatusType : TargetConstraint
{
  [SerializeField]
  private string statusType;

  public override bool Check(Entity target)
  {
    return !(bool) (Object) target.FindStatus(this.statusType) ? this.not : !this.not;
  }

  public override bool Check(CardData targetData)
  {
    foreach (CardData.StatusEffectStacks startWithEffect in targetData.startWithEffects)
    {
      if (startWithEffect.data.type == this.statusType)
        return !this.not;
    }
    return this.not;
  }
}
