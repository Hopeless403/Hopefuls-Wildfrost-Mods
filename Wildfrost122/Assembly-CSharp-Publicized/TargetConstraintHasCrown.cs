// Decompiled with JetBrains decompiler
// Type: TargetConstraintHasCrown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Has Crown", menuName = "Target Constraints/Has Crown")]
public class TargetConstraintHasCrown : TargetConstraint
{
  public override bool Check(Entity target) => this.Check(target.data);

  public override bool Check(CardData targetData)
  {
    return !((UnityEngine.Object) targetData.upgrades.Find((Predicate<CardUpgradeData>) (a => a.type == CardUpgradeData.Type.Crown)) != (UnityEngine.Object) null) ? this.not : !this.not;
  }
}
