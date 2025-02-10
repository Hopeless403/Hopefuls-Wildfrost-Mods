// Decompiled with JetBrains decompiler
// Type: ActionReveal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

public class ActionReveal : PlayAction
{
  private readonly Entity entity;

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
