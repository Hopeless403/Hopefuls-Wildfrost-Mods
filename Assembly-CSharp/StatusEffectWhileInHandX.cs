// Decompiled with JetBrains decompiler
// Type: StatusEffectWhileInHandX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/While In Hand X", fileName = "While In Hand X")]
public class StatusEffectWhileInHandX : StatusEffectWhileActiveX
{
  protected override bool CanActivate() => this.target.InHand();

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
