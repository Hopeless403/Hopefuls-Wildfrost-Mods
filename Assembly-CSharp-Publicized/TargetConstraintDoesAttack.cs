// Decompiled with JetBrains decompiler
// Type: TargetConstraintDoesAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Does Attack", menuName = "Target Constraints/Does Attack")]
public class TargetConstraintDoesAttack : TargetConstraint
{
  public override bool Check(Entity target) => !(bool) (Object) target.data || !target.data.hasAttack && target.attackEffects.Count <= 0 ? this.not : !this.not;

  public override bool Check(CardData targetData) => !(bool) (Object) targetData || !targetData.hasAttack && targetData.attackEffects.Length == 0 ? this.not : !this.not;
}
