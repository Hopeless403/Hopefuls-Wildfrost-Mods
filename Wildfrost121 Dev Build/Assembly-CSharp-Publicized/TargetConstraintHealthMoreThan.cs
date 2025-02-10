// Decompiled with JetBrains decompiler
// Type: TargetConstraintHealthMoreThan
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Health More Than", menuName = "Target Constraints/Health More Than")]
public class TargetConstraintHealthMoreThan : TargetConstraint
{
  [SerializeField]
  public int value;

  public override bool Check(Entity target)
  {
    return target.hp.current <= this.value ? this.not : !this.not;
  }

  public override bool Check(CardData targetData)
  {
    return targetData.hp <= this.value ? this.not : !this.not;
  }
}
