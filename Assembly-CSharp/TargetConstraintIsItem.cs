﻿// Decompiled with JetBrains decompiler
// Type: TargetConstraintIsItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Is Item", menuName = "Target Constraints/Is Item")]
public class TargetConstraintIsItem : TargetConstraint
{
  public override bool Check(Entity target) => this.Check(target.data);

  public override bool Check(CardData targetData) => !targetData.cardType.item ? this.not : !this.not;
}
