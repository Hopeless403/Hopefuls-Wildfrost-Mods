// Decompiled with JetBrains decompiler
// Type: ActionApplyStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;

public class ActionApplyStatus : PlayAction
{
  public Entity target;
  public Entity applier;
  public StatusEffectData status;
  public int stacks;

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
