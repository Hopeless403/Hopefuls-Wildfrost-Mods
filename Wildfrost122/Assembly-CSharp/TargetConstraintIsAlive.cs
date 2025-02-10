// Decompiled with JetBrains decompiler
// Type: TargetConstraintIsAlive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Is Alive", menuName = "Target Constraints/Is Alive")]
public class TargetConstraintIsAlive : TargetConstraint
{
  public override bool Check(Entity target)
  {
    return !target.alive || target.ReadyToDie() ? this.not : !this.not;
  }

  public override bool Check(CardData targetData) => !this.not;
}
