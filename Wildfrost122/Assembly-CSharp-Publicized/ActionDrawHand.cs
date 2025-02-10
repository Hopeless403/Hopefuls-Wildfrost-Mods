// Decompiled with JetBrains decompiler
// Type: ActionDrawHand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

#nullable disable
public class ActionDrawHand : PlayAction
{
  public readonly Character character;
  public readonly float pauseBetween;

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
