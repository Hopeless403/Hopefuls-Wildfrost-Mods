// Decompiled with JetBrains decompiler
// Type: TargetConstraintCanTakeCrown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Can Take Crown", menuName = "Target Constraints/Can Take Crown")]
public class TargetConstraintCanTakeCrown : TargetConstraint
{
  public override bool Check(Entity target) => this.Check(target.data);

  public override bool Check(CardData targetData)
  {
    return !targetData.cardType.canTakeCrown ? this.not : !this.not;
  }
}
