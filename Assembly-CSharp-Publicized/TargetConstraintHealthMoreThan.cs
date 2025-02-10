// Decompiled with JetBrains decompiler
// Type: TargetConstraintHealthMoreThan
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Health More Than", menuName = "Target Constraints/Health More Than")]
public class TargetConstraintHealthMoreThan : TargetConstraint
{
  [SerializeField]
  public int value;

  public override bool Check(Entity target) => target.hp.current <= this.value ? this.not : !this.not;

  public override bool Check(CardData targetData) => targetData.hp <= this.value ? this.not : !this.not;
}
