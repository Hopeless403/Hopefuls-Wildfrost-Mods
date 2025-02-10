// Decompiled with JetBrains decompiler
// Type: ActionProcessTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class ActionProcessTrigger : PlayAction
{
  public Trigger trigger;
  public readonly Func<Trigger> GetTriggerMethod;

  public ActionProcessTrigger(Trigger trigger) => this.trigger = trigger;

  public ActionProcessTrigger(Func<Trigger> GetTriggerMethod) => this.GetTriggerMethod = GetTriggerMethod;

  public override IEnumerator Run()
  {
    if (this.trigger == null && this.GetTriggerMethod != null)
      this.trigger = this.GetTriggerMethod();
    Events.InvokeEntityPreTrigger(ref this.trigger);
    yield return (object) StatusEffectSystem.PreTriggerEvent(this.trigger);
    if (!this.trigger.entity.data.hasAttack && this.trigger.entity.attackEffects.Count <= 0)
      this.trigger.targets = (Entity[]) null;
    if (this.trigger.entity.data.hasAttack)
    {
      Entity[] targets = this.trigger.targets;
      if ((targets == null || targets.Length <= 0) && NoTargetTextSystem.Exists())
        yield return (object) NoTargetTextSystem.Run(this.trigger.entity, NoTargetType.NoTargetToAttack);
    }
    if (this.trigger.targets != null)
      this.trigger.targets = ((IEnumerable<Entity>) this.trigger.targets).Where<Entity>((Func<Entity, bool>) (t => t.IsAliveAndExists())).ToArray<Entity>();
    this.trigger.entity.triggeredBy = this.trigger.triggeredBy;
    Events.InvokeEntityTrigger(ref this.trigger);
    if (!this.trigger.nullified && !this.trigger.entity.IsSnowed)
    {
      Entity[] targets = this.trigger.targets;
      if (targets != null && targets.Length > 0)
      {
        yield return (object) this.trigger.Process();
        yield return (object) Sequences.Wait(0.167f);
      }
      else
        yield return (object) this.trigger.Process();
    }
    Events.InvokeEntityTriggered(ref this.trigger);
    this.trigger.entity.triggeredBy = (Entity) null;
  }
}
