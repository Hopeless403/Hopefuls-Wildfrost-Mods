// Decompiled with JetBrains decompiler
// Type: ActionApplyStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;

public class ActionApplyStatus : PlayAction
{
  private Entity target;
  private Entity applier;
  private StatusEffectData status;
  private int stacks;

  public ActionApplyStatus(Entity target, Entity applier, StatusEffectData status, int stacks)
  {
    this.target = target;
    this.applier = applier;
    this.status = status;
    this.stacks = stacks;
  }

  public override IEnumerator Run()
  {
    yield return (object) StatusEffectSystem.Apply(this.target, this.applier, this.status, this.stacks);
    yield return (object) Sequences.Wait(0.6f);
  }
}
