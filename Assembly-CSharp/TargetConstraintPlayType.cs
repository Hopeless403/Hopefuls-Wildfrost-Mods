// Decompiled with JetBrains decompiler
// Type: TargetConstraintPlayType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Play Type", menuName = "Target Constraints/Play Type")]
public class TargetConstraintPlayType : TargetConstraint
{
  [SerializeField]
  private Card.PlayType targetPlayType;

  public override bool Check(Entity target) => this.Check(target.data);

  public override bool Check(CardData targetData) => targetData.playType != this.targetPlayType ? this.not : !this.not;
}
