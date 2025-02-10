// Decompiled with JetBrains decompiler
// Type: ActionDrawHand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

#nullable disable
public class ActionDrawHand : PlayAction
{
  public readonly Character character;
  private readonly float pauseBetween;

  public ActionDrawHand(Character character, float pauseBetween = 0.1f)
  {
    this.character = character;
    this.pauseBetween = pauseBetween;
  }

  public override bool IsRoutine => false;

  public override void Process()
  {
    ActionQueue.Stack((PlayAction) new ActionDraw(this.character, this.character.handContainer.max - this.character.handContainer.Count, this.pauseBetween));
  }
}
