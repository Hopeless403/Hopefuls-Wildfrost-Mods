// Decompiled with JetBrains decompiler
// Type: ActionRedraw
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class ActionRedraw : PlayAction
{
  private readonly Character character;
  private readonly int drawCount;

  public ActionRedraw(Character character, int drawCount = -1)
  {
    this.character = character;
    this.drawCount = drawCount;
  }

  public override bool IsRoutine => false;

  public override void Process()
  {
    if (!(bool) (Object) this.character)
      return;
    this.DiscardAll();
    if (this.drawCount < 0)
    {
      ActionQueue.Add((PlayAction) new ActionDrawHand(this.character));
    }
    else
    {
      if (this.drawCount <= 0)
        return;
      ActionQueue.Add((PlayAction) new ActionDraw(this.character, this.drawCount));
    }
  }

  private void DiscardAll()
  {
    foreach (Entity entity in this.character.handContainer)
    {
      entity.display.hover.SetHoverable(false);
      ActionQueue.Stack((PlayAction) new ActionMove(entity, new CardContainer[1]
      {
        this.character.discardContainer
      }));
    }
  }
}
