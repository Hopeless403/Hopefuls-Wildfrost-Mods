// Decompiled with JetBrains decompiler
// Type: TargetConstraintCanTakeCrown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Can Take Crown", menuName = "Target Constraints/Can Take Crown")]
public class TargetConstraintCanTakeCrown : TargetConstraint
{
  public override bool Check(Entity target) => this.Check(target.data);

  public override bool Check(CardData targetData) => !targetData.cardType.canTakeCrown ? this.not : !this.not;
}
