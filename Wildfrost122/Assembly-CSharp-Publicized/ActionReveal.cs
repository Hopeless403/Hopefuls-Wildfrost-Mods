// Decompiled with JetBrains decompiler
// Type: ActionReveal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

#nullable disable
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
