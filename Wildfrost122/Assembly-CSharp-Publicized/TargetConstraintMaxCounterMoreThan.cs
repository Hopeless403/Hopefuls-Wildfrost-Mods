// Decompiled with JetBrains decompiler
// Type: TargetConstraintMaxCounterMoreThan
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Max Counter More Than", menuName = "Target Constraints/Max Counter More Than")]
public class TargetConstraintMaxCounterMoreThan : TargetConstraint
{
  [SerializeField]
  public int moreThan;

  public override bool Check(Entity target)
  {
    return target.counter.max <= this.moreThan ? this.not : !this.not;
  }

  public override bool Check(CardData targetData)
  {
    return targetData.counter <= this.moreThan ? this.not : !this.not;
  }
}
