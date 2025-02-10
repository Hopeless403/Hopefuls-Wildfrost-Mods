// Decompiled with JetBrains decompiler
// Type: TargetConstraintIsCardType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Is Card Type", menuName = "Target Constraints/Is Card Type")]
public class TargetConstraintIsCardType : TargetConstraint
{
  [SerializeField]
  public CardType[] allowedTypes;

  public override bool Check(Entity target) => this.Check(target.data);

  public override bool Check(CardData targetData)
  {
    return !this.allowedTypes.Contains<CardType>(targetData.cardType) ? this.not : !this.not;
  }
}
