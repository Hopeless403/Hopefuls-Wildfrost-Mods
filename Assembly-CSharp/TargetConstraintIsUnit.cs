// Decompiled with JetBrains decompiler
// Type: TargetConstraintIsUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Is Unit", menuName = "Target Constraints/Is Unit")]
public class TargetConstraintIsUnit : TargetConstraint
{
  [SerializeField]
  private bool mustBeMiniboss;

  public override bool Check(Entity target) => this.Check(target.data);

  public override bool Check(CardData targetData)
  {
    if (!(bool) (Object) targetData)
      return this.not;
    CardType cardType = targetData.cardType;
    return !(bool) (Object) cardType || !cardType.unit || !this.CheckMiniboss(cardType) ? this.not : !this.not;
  }

  private bool CheckMiniboss(CardType cardType) => !this.mustBeMiniboss || cardType.miniboss;
}
