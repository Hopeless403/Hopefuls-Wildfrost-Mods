// Decompiled with JetBrains decompiler
// Type: TargetConstraintDamaged
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Is Damaged", menuName = "Target Constraints/Is Damaged")]
public class TargetConstraintDamaged : TargetConstraint
{
  public override bool Check(Entity target) => target.hp.current >= target.hp.max ? this.not : !this.not;

  public override bool Check(CardData targetData) => this.not;
}
