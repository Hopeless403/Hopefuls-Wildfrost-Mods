// Decompiled with JetBrains decompiler
// Type: ActionDrawHand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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

  public override void Process() => ActionQueue.Stack((PlayAction) new ActionDraw(this.character, this.character.handContainer.max - this.character.handContainer.Count, this.pauseBetween));
}
