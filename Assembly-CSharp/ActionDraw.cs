// Decompiled with JetBrains decompiler
// Type: ActionDraw
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

public class ActionDraw : PlayAction
{
  private readonly Character character;
  private int count;
  private float pauseBetween;

  public ActionDraw(Character character, int count = 1, float pauseBetween = 0.1f)
  {
    this.character = character;
    this.count = count;
    this.pauseBetween = pauseBetween;
  }

  public override IEnumerator Run()
  {
    if (this.count > 0 && (bool) (Object) this.character.drawContainer && (bool) (Object) this.character.handContainer && (bool) (Object) this.character.discardContainer)
    {
      Events.InvokeCardDraw(this.count);
      for (; this.count > 0; --this.count)
      {
        yield return (object) Sequences.Wait(this.pauseBetween);
        Entity top = this.character.drawContainer.GetTop();
        if (!(bool) (Object) top)
        {
          Events.InvokeCardDrawEnd();
          yield return (object) Sequences.ShuffleTo(this.character.discardContainer, this.character.drawContainer);
          top = this.character.drawContainer.GetTop();
          Events.InvokeCardDraw(this.count);
        }
        if ((bool) (Object) top)
        {
          yield return (object) Sequences.CardMove(top, new CardContainer[1]
          {
            this.character.handContainer
          });
          this.character.handContainer.TweenChildPositions();
        }
      }
      Events.InvokeCardDrawEnd();
      ActionQueue.Stack((PlayAction) new ActionRevealAll(new CardContainer[1]
      {
        this.character.handContainer
      }));
    }
  }
}
