// Decompiled with JetBrains decompiler
// Type: StatusEffectDeployDraw
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Draw When Deployed", fileName = "Draw When Deployed")]
public class StatusEffectDeployDraw : StatusEffectData
{
  public override bool RunCardMoveEvent(Entity entity)
  {
    CardContainer[] preContainers = entity.preContainers;
    if ((Object) entity == (Object) this.target && (preContainers.Contains<CardContainer>(this.target.owner.handContainer) || preContainers.Contains<CardContainer>(this.target.owner.reserveContainer)) && Battle.IsOnBoard(entity))
      ActionQueue.Stack((PlayAction) new ActionDraw(this.target.owner, this.GetAmount()));
    return false;
  }
}
