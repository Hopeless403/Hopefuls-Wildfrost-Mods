// Decompiled with JetBrains decompiler
// Type: TargetConstraintPlayOnSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Plays On", menuName = "Target Constraints/Plays On")]
public class TargetConstraintPlayOnSlot : TargetConstraint
{
  [SerializeField]
  private bool slot;
  [SerializeField]
  private bool board;
  [SerializeField]
  private bool hand;
  [SerializeField]
  private bool enemy;
  [SerializeField]
  private bool friendly;

  public override bool Check(Entity target) => this.Check(target.data);

  public override bool Check(CardData targetData)
  {
    return this.slot && !targetData.playOnSlot || this.board && !targetData.canPlayOnBoard || this.hand && !targetData.canPlayOnHand || this.enemy && !targetData.canPlayOnEnemy || this.friendly && !targetData.canPlayOnFriendly ? this.not : !this.not;
  }
}
