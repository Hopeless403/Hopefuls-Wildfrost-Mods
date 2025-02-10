// Decompiled with JetBrains decompiler
// Type: TargetConstraintOr
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Or", menuName = "Target Constraints/Or")]
public class TargetConstraintOr : TargetConstraint
{
  [SerializeField]
  public TargetConstraint[] constraints;

  public override bool Check(Entity target)
  {
    foreach (TargetConstraint constraint in this.constraints)
    {
      if (constraint.Check(target))
        return !this.not;
    }
    return this.not;
  }

  public override bool Check(CardData targetData)
  {
    foreach (TargetConstraint constraint in this.constraints)
    {
      if (constraint.Check(targetData))
        return !this.not;
    }
    return this.not;
  }
}
