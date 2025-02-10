// Decompiled with JetBrains decompiler
// Type: TargetConstraintNeedsTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Needs Target", menuName = "Target Constraints/Needs Target")]
public class TargetConstraintNeedsTarget : TargetConstraint
{
  public override bool Check(Entity target) => !target.NeedsTarget ? this.not : !this.not;

  public override bool Check(CardData targetData) => !targetData.needsTarget ? this.not : !this.not;
}
