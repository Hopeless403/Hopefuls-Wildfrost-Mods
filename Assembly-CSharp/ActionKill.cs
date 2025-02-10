// Decompiled with JetBrains decompiler
// Type: ActionKill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;

public class ActionKill : PlayAction
{
  public Entity entity;

  public ActionKill(Entity entity) => this.entity = entity;

  public override IEnumerator Run()
  {
    if (this.entity.IsAliveAndExists())
    {
      yield return (object) Sequences.WaitForAnimationEnd(this.entity);
      yield return (object) this.entity.Kill();
    }
  }
}
