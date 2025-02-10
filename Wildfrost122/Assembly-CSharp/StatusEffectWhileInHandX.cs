// Decompiled with JetBrains decompiler
// Type: StatusEffectWhileInHandX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/While In Hand X", fileName = "While In Hand X")]
public class StatusEffectWhileInHandX : StatusEffectWhileActiveX
{
  public override bool CanActivate() => this.target.InHand();

  protected override bool CheckActivateOnMove(
    CardContainer[] fromContainers,
    CardContainer[] toContainers)
  {
    return toContainers.Contains<CardContainer>(this.target.owner.handContainer) && !fromContainers.Contains<CardContainer>(this.target.owner.handContainer);
  }

  protected override bool CheckDeactivateOnMove(
    CardContainer[] fromContainers,
    CardContainer[] toContainers)
  {
    return !toContainers.Contains<CardContainer>(this.target.owner.handContainer) && fromContainers.Contains<CardContainer>(this.target.owner.handContainer);
  }
}
