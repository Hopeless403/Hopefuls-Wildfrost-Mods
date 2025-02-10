// Decompiled with JetBrains decompiler
// Type: TargetConstraintMaxCounterMoreThan
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Max Counter More Than", menuName = "Target Constraints/Max Counter More Than")]
public class TargetConstraintMaxCounterMoreThan : TargetConstraint
{
  [SerializeField]
  private int moreThan;

  public override bool Check(Entity target)
  {
    return target.counter.max <= this.moreThan ? this.not : !this.not;
  }

  public override bool Check(CardData targetData)
  {
    return targetData.counter <= this.moreThan ? this.not : !this.not;
  }
}
