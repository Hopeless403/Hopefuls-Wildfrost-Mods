// Decompiled with JetBrains decompiler
// Type: ActionApplyStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;

#nullable disable
public class ActionApplyStatus : PlayAction
{
  public Entity target;
  public Entity applier;
  public StatusEffectData status;
  public int stacks;
  public bool temporary;

  public ActionApplyStatus(
    Entity target,
    Entity applier,
    StatusEffectData status,
    int stacks,
    bool temporary = false)
  {
    this.target = target;
    this.applier = applier;
    this.status = status;
    this.stacks = stacks;
    this.temporary = temporary;
  }

  public override IEnumerator Run()
  {
    yield return (object) StatusEffectSystem.Apply(this.target, this.applier, this.status, this.stacks, this.temporary);
    yield return (object) Sequences.Wait(0.6f);
  }
}
