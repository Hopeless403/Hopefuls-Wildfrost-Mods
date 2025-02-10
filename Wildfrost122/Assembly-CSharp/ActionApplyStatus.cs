// Decompiled with JetBrains decompiler
// Type: ActionApplyStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;

#nullable disable
public class ActionApplyStatus : PlayAction
{
  private Entity target;
  private Entity applier;
  private StatusEffectData status;
  private int stacks;
  private bool temporary;

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
