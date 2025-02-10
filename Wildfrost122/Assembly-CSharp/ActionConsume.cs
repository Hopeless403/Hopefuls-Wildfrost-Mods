// Decompiled with JetBrains decompiler
// Type: ActionConsume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;

#nullable disable
public class ActionConsume : PlayAction
{
  public readonly Entity target;

  public bool blocked { get; private set; }

  public ActionConsume(Entity target) => this.target = target;

  public override IEnumerator Run()
  {
    if (!this.blocked)
    {
      yield return (object) Sequences.WaitForAnimationEnd(this.target);
      this.target.alive = true;
      yield return (object) this.target.Kill(DeathType.Consume);
    }
  }

  public void Block()
  {
    this.target.alive = true;
    this.blocked = true;
  }
}
