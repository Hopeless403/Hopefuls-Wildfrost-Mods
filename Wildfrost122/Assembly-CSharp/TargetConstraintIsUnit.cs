// Decompiled with JetBrains decompiler
// Type: TargetConstraintIsUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
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
