// Decompiled with JetBrains decompiler
// Type: TargetConstraintAttackMoreThan
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Attack More Than", menuName = "Target Constraints/Attack More Than")]
public class TargetConstraintAttackMoreThan : TargetConstraint
{
  [SerializeField]
  public int value;

  public override bool Check(Entity target) => target.damage.current + target.tempDamage.Value <= this.value ? this.not : !this.not;

  public override bool Check(CardData targetData) => targetData.damage <= this.value ? this.not : !this.not;
}
