﻿// Decompiled with JetBrains decompiler
// Type: TargetConstraintCanBeHit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Can Be Hit", menuName = "Target Constraints/Can Be Hit")]
public class TargetConstraintCanBeHit : TargetConstraint
{
  public override bool Check(Entity target) => !target.canBeHit ? this.not : !this.not;

  public override bool Check(CardData targetData) => !targetData.canBeHit ? this.not : !this.not;
}
