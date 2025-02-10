// Decompiled with JetBrains decompiler
// Type: TargetConstraintDoesDamage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Does Damage", menuName = "Target Constraints/Does Damage")]
public class TargetConstraintDoesDamage : TargetConstraint
{
  public override bool Check(Entity target)
  {
    return !(bool) (Object) target.data || !target.HasAttackIcon() ? this.not : !this.not;
  }

  public override bool Check(CardData targetData)
  {
    return !(bool) (Object) targetData || !targetData.hasAttack ? this.not : !this.not;
  }
}
