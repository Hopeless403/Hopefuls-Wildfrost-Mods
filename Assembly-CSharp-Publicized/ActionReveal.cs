// Decompiled with JetBrains decompiler
// Type: ActionReveal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

public class ActionReveal : PlayAction
{
  public readonly Entity entity;

  public ActionReveal(Entity entity, float pauseAfter = 0.0f)
  {
    this.entity = entity;
    this.pauseAfter = pauseAfter;
  }

  public override bool IsRoutine => false;

  public override void Process()
  {
    if (this.entity.flipper.flipped)
      this.entity.flipper.FlipUp();
    this.entity.enabled = true;
  }
}
