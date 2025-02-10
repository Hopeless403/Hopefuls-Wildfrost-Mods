// Decompiled with JetBrains decompiler
// Type: TargetConstraintIsSpecificCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Is Specific Card", menuName = "Target Constraints/Is Specific Card")]
public class TargetConstraintIsSpecificCard : TargetConstraint
{
  [SerializeField]
  private CardData[] allowedCards;

  public override bool Check(Entity target) => this.Check(target.data);

  public override bool Check(CardData targetData) => !((IEnumerable<CardData>) this.allowedCards).Any<CardData>((Func<CardData, bool>) (a => a.name == targetData.name)) ? this.not : !this.not;
}
