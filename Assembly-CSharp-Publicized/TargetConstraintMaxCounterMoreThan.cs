// Decompiled with JetBrains decompiler
// Type: TargetConstraintMaxCounterMoreThan
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Max Counter More Than", menuName = "Target Constraints/Max Counter More Than")]
public class TargetConstraintMaxCounterMoreThan : TargetConstraint
{
  [SerializeField]
  public int moreThan;

  public override bool Check(Entity target) => target.counter.max <= this.moreThan ? this.not : !this.not;

  public override bool Check(CardData targetData) => targetData.counter <= this.moreThan ? this.not : !this.not;
}
