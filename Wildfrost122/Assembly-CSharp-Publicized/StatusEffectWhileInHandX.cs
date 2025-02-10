// Decompiled with JetBrains decompiler
// Type: StatusEffectWhileInHandX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/While In Hand X", fileName = "While In Hand X")]
public class StatusEffectWhileInHandX : StatusEffectWhileActiveX
{
  public override bool CanActivate() => this.target.InHand();

  public override bool CheckActivateOnMove(
    CardContainer[] fromContainers,
    CardContainer[] toContainers)
  {
    return toContainers.Contains<CardContainer>(this.target.owner.handContainer) && !fromContainers.Contains<CardContainer>(this.target.owner.handContainer);
  }

  public override bool CheckDeactivateOnMove(
    CardContainer[] fromContainers,
    CardContainer[] toContainers)
  {
    return !toContainers.Contains<CardContainer>(this.target.owner.handContainer) && fromContainers.Contains<CardContainer>(this.target.owner.handContainer);
  }
}
