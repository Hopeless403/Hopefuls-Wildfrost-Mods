// Decompiled with JetBrains decompiler
// Type: TargetConstraintMaxCounterMoreThan
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Max Counter More Than", menuName = "Target Constraints/Max Counter More Than")]
public class TargetConstraintMaxCounterMoreThan : TargetConstraint
{
  [SerializeField]
  private int moreThan;

  public override bool Check(Entity target) => target.counter.max <= this.moreThan ? this.not : !this.not;

  public override bool Check(CardData targetData) => targetData.counter <= this.moreThan ? this.not : !this.not;
}
