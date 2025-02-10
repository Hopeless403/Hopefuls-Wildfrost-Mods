// Decompiled with JetBrains decompiler
// Type: TargetConstraintIsSpecificCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Is Specific Card", menuName = "Target Constraints/Is Specific Card")]
public class TargetConstraintIsSpecificCard : TargetConstraint
{
  [SerializeField]
  public CardData[] allowedCards;

  public override bool Check(Entity target) => this.Check(target.data);

  public override bool Check(CardData targetData)
  {
    return !((IEnumerable<CardData>) this.allowedCards).Any<CardData>((Func<CardData, bool>) (a => a.name == targetData.name)) ? this.not : !this.not;
  }
}
