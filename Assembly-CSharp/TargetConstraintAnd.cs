// Decompiled with JetBrains decompiler
// Type: TargetConstraintAnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(fileName = "And", menuName = "Target Constraints/And")]
public class TargetConstraintAnd : TargetConstraint
{
  [SerializeField]
  private TargetConstraint[] constraints;

  public override bool Check(Entity target)
  {
    foreach (TargetConstraint constraint in this.constraints)
    {
      if (!constraint.Check(target))
        return this.not;
    }
    return !this.not;
  }

  public override bool Check(CardData targetData)
  {
    foreach (TargetConstraint constraint in this.constraints)
    {
      if (!constraint.Check(targetData))
        return this.not;
    }
    return !this.not;
  }
}
