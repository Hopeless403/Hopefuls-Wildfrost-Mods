// Decompiled with JetBrains decompiler
// Type: TargetConstraintPlayOnSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Plays On", menuName = "Target Constraints/Plays On")]
public class TargetConstraintPlayOnSlot : TargetConstraint
{
  [SerializeField]
  public bool slot;
  [SerializeField]
  public bool board;
  [SerializeField]
  public bool hand;
  [SerializeField]
  public bool enemy;
  [SerializeField]
  public bool friendly;

  public override bool Check(Entity target) => this.Check(target.data);

  public override bool Check(CardData targetData)
  {
    return this.slot && !targetData.playOnSlot || this.board && !targetData.canPlayOnBoard || this.hand && !targetData.canPlayOnHand || this.enemy && !targetData.canPlayOnEnemy || this.friendly && !targetData.canPlayOnFriendly ? this.not : !this.not;
  }
}
