// Decompiled with JetBrains decompiler
// Type: TargetConstraintIsSpecificCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Is Specific Card", menuName = "Target Constraints/Is Specific Card")]
public class TargetConstraintIsSpecificCard : TargetConstraint
{
  [SerializeField]
  private CardData[] allowedCards;

  public override bool Check(Entity target) => this.Check(target.data);

  public override bool Check(CardData targetData)
  {
    return !((IEnumerable<CardData>) this.allowedCards).Any<CardData>((Func<CardData, bool>) (a => a.name == targetData.name)) ? this.not : !this.not;
  }
}
