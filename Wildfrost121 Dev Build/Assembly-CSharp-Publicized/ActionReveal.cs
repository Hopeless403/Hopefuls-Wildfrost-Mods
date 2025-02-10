// Decompiled with JetBrains decompiler
// Type: ActionReveal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
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
