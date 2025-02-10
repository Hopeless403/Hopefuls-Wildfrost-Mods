// Decompiled with JetBrains decompiler
// Type: TargetConstraintNeedsTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Needs Target", menuName = "Target Constraints/Needs Target")]
public class TargetConstraintNeedsTarget : TargetConstraint
{
  public override bool Check(Entity target) => !target.NeedsTarget ? this.not : !this.not;

  public override bool Check(CardData targetData) => !targetData.needsTarget ? this.not : !this.not;
}
