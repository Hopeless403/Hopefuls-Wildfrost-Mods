// Decompiled with JetBrains decompiler
// Type: TargetConstraintDoesAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Does Attack", menuName = "Target Constraints/Does Attack")]
public class TargetConstraintDoesAttack : TargetConstraint
{
  public override bool Check(Entity target) => !(bool) (Object) target.data || !target.data.hasAttack && target.attackEffects.Count <= 0 ? this.not : !this.not;

  public override bool Check(CardData targetData) => !(bool) (Object) targetData || !targetData.hasAttack && targetData.attackEffects.Length == 0 ? this.not : !this.not;
}
