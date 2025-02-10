// Decompiled with JetBrains decompiler
// Type: ActionRedraw
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

public class ActionRedraw : PlayAction
{
  public readonly Character character;
  public readonly int drawCount;

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

  public void DiscardAll()
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
