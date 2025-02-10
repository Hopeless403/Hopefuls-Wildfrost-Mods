// Decompiled with JetBrains decompiler
// Type: TargetConstraintHealthMoreThan
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Health More Than", menuName = "Target Constraints/Health More Than")]
public class TargetConstraintHealthMoreThan : TargetConstraint
{
  [SerializeField]
  private int value;

  public override bool Check(Entity target) => target.hp.current <= this.value ? this.not : !this.not;

  public override bool Check(CardData targetData) => targetData.hp <= this.value ? this.not : !this.not;
}
