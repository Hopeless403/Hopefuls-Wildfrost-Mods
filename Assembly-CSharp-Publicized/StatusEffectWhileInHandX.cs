// Decompiled with JetBrains decompiler
// Type: StatusEffectWhileInHandX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

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
