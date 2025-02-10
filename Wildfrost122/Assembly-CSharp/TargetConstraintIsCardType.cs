// Decompiled with JetBrains decompiler
// Type: TargetConstraintIsCardType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Is Card Type", menuName = "Target Constraints/Is Card Type")]
public class TargetConstraintIsCardType : TargetConstraint
{
  [SerializeField]
  private CardType[] allowedTypes;

  public override bool Check(Entity target) => this.Check(target.data);

  public override bool Check(CardData targetData)
  {
    return !this.allowedTypes.Contains<CardType>(targetData.cardType) ? this.not : !this.not;
  }
}
