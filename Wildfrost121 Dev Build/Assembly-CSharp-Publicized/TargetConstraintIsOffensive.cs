// Decompiled with JetBrains decompiler
// Type: TargetConstraintIsOffensive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Is Offensive", menuName = "Target Constraints/Is Offensive")]
public class TargetConstraintIsOffensive : TargetConstraint
{
  public override bool Check(Entity target)
  {
    return !target.HasAttackIcon() && !target.IsOffensive() ? this.not : !this.not;
  }

  public override bool Check(CardData targetData)
  {
    return !targetData.IsOffensive() ? this.not : !this.not;
  }
}
