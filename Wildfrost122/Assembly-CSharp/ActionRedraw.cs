// Decompiled with JetBrains decompiler
// Type: ActionRedraw
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
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
