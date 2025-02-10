// Decompiled with JetBrains decompiler
// Type: TargetConstraintOnBoard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Is On Board", menuName = "Target Constraints/Is On Board")]
public class TargetConstraintOnBoard : TargetConstraint
{
  public override bool Check(Entity target) => !Battle.IsOnBoard(target) ? this.not : !this.not;

  public override bool Check(CardData targetData) => this.not;
}
