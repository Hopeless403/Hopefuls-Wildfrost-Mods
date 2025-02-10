// Decompiled with JetBrains decompiler
// Type: TargetConstraintIsSpecificCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Is Specific Card", menuName = "Target Constraints/Is Specific Card")]
public class TargetConstraintIsSpecificCard : TargetConstraint
{
  [SerializeField]
  public CardData[] allowedCards;

  public override bool Check(Entity target) => this.Check(target.data);

  public override bool Check(CardData targetData) => !((IEnumerable<CardData>) this.allowedCards).Any<CardData>((Func<CardData, bool>) (a => a.name == targetData.name)) ? this.not : !this.not;
}
