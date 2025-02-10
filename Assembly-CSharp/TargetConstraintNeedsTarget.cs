// Decompiled with JetBrains decompiler
// Type: TargetConstraintNeedsTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Needs Target", menuName = "Target Constraints/Needs Target")]
public class TargetConstraintNeedsTarget : TargetConstraint
{
  public override bool Check(Entity target) => !target.NeedsTarget ? this.not : !this.not;

  public override bool Check(CardData targetData) => !targetData.needsTarget ? this.not : !this.not;
}
