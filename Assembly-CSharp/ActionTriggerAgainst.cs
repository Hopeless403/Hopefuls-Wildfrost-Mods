// Decompiled with JetBrains decompiler
// Type: ActionTriggerAgainst
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;

public class ActionTriggerAgainst : ActionTrigger
{
  public Entity target;
  public readonly CardContainer targetContainer;
  public Trigger trigger;
  public bool countsAsTrigger = true;

  public ActionTriggerAgainst(
    Entity entity,
    Entity triggeredBy,
    Entity target,
    CardContainer targetContainer)
    : base(entity, triggeredBy)
  {
    this.target = target;
    this.targetContainer = targetContainer;
  }

  public override bool IsRoutine => false;

  public override void Process()
  {
    if (!this.entity.IsAliveAndExists())
      return;
    Events.InvokePreProcessTrigger(this.entity);
    ActionQueue.Stack((PlayAction) new ActionProcessTrigger(new Func<Trigger>(((ActionTrigger) this).GetTrigger)));
  }

  protected override Trigger GetTrigger()
  {
    Entity[] targets = this.GetTargets();
    if (this.trigger == null)
      this.trigger = new Trigger(this.entity, this.triggeredBy, this.triggerType, targets);
    this.trigger.triggerAgainst = true;
    this.trigger.triggerAgainstTarget = this.target;
    this.trigger.triggerAgainstContainer = this.targetContainer;
    this.trigger.countsAsTrigger = this.countsAsTrigger;
    return this.trigger;
  }

  protected virtual Entity[] GetTargets() => !this.countsAsTrigger ? new Entity[1]
  {
    this.target
  } : (!(bool) (UnityEngine.Object) this.entity.targetMode ? (Entity[]) null : this.entity.targetMode.GetTargets(this.entity, this.target, this.targetContainer));
}
