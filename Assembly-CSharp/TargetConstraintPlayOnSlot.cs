// Decompiled with JetBrains decompiler
// Type: TargetConstraintPlayOnSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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

  public override bool Check(CardData targetData) => this.slot && !targetData.playOnSlot || this.board && !targetData.canPlayOnBoard || this.hand && !targetData.canPlayOnHand || this.enemy && !targetData.canPlayOnEnemy || this.friendly && !targetData.canPlayOnFriendly ? this.not : !this.not;
}
