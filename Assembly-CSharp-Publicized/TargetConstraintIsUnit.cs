﻿// Decompiled with JetBrains decompiler
// Type: TargetConstraintIsUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Is Unit", menuName = "Target Constraints/Is Unit")]
public class TargetConstraintIsUnit : TargetConstraint
{
  [SerializeField]
  public bool mustBeMiniboss;

  public override bool Check(Entity target) => this.Check(target.data);

  public override bool Check(CardData targetData)
  {
    if (!(bool) (Object) targetData)
      return this.not;
    CardType cardType = targetData.cardType;
    return !(bool) (Object) cardType || !cardType.unit || !this.CheckMiniboss(cardType) ? this.not : !this.not;
  }

  public bool CheckMiniboss(CardType cardType) => !this.mustBeMiniboss || cardType.miniboss;
}
