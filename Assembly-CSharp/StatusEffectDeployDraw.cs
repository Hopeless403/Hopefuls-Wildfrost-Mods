// Decompiled with JetBrains decompiler
// Type: StatusEffectDeployDraw
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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
