// Decompiled with JetBrains decompiler
// Type: TargetConstraintHasCrown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Has Crown", menuName = "Target Constraints/Has Crown")]
public class TargetConstraintHasCrown : TargetConstraint
{
  public override bool Check(Entity target) => this.Check(target.data);

  public override bool Check(CardData targetData) => !((UnityEngine.Object) targetData.upgrades.Find((Predicate<CardUpgradeData>) (a => a.type == CardUpgradeData.Type.Crown)) != (UnityEngine.Object) null) ? this.not : !this.not;
}
