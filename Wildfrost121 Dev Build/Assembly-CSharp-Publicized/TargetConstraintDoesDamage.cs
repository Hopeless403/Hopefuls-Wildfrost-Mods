// Decompiled with JetBrains decompiler
// Type: TargetConstraintDoesDamage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
