// Decompiled with JetBrains decompiler
// Type: TargetConstraintIsOffensive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Is Offensive", menuName = "Target Constraints/Is Offensive")]
public class TargetConstraintIsOffensive : TargetConstraint
{
  public override bool Check(Entity target) => !target.data.hasAttack && !target.IsOffensive() ? this.not : !this.not;

  public override bool Check(CardData targetData) => !targetData.IsOffensive() ? this.not : !this.not;
}
