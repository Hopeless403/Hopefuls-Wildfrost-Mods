// Decompiled with JetBrains decompiler
// Type: ActionConsume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Runtime.CompilerServices;

#nullable disable
public class ActionConsume : PlayAction
{
  public readonly Entity target;
  [CompilerGenerated]
  public bool \u003Cblocked\u003Ek__BackingField;

  public bool blocked
  {
    get => this.\u003Cblocked\u003Ek__BackingField;
    set => this.\u003Cblocked\u003Ek__BackingField = value;
  }

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
