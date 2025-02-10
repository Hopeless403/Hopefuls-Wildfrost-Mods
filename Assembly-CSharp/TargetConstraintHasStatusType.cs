// Decompiled with JetBrains decompiler
// Type: TargetConstraintHasStatusType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Has Status Type", menuName = "Target Constraints/Has Status Type")]
public class TargetConstraintHasStatusType : TargetConstraint
{
  [SerializeField]
  private string statusType;

  public override bool Check(Entity target) => !(bool) (Object) target.FindStatus(this.statusType) ? this.not : !this.not;

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
