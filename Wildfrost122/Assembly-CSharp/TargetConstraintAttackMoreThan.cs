// Decompiled with JetBrains decompiler
// Type: TargetConstraintAttackMoreThan
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Attack More Than", menuName = "Target Constraints/Attack More Than")]
public class TargetConstraintAttackMoreThan : TargetConstraint
{
  [SerializeField]
  private int value;

  public override bool Check(Entity target)
  {
    return target.damage.current + target.tempDamage.Value <= this.value ? this.not : !this.not;
  }

  public override bool Check(CardData targetData)
  {
    return targetData.damage <= this.value ? this.not : !this.not;
  }
}
