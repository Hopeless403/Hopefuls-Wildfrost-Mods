// Decompiled with JetBrains decompiler
// Type: TargetConstraintAnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "And", menuName = "Target Constraints/And")]
public class TargetConstraintAnd : TargetConstraint
{
  [SerializeField]
  public TargetConstraint[] constraints;

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
