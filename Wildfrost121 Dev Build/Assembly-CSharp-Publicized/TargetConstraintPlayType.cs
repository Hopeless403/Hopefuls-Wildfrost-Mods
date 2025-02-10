// Decompiled with JetBrains decompiler
// Type: TargetConstraintPlayType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Play Type", menuName = "Target Constraints/Play Type")]
public class TargetConstraintPlayType : TargetConstraint
{
  [SerializeField]
  public Card.PlayType targetPlayType;

  public override bool Check(Entity target) => this.Check(target.data);

  public override bool Check(CardData targetData)
  {
    return targetData.playType != this.targetPlayType ? this.not : !this.not;
  }
}
