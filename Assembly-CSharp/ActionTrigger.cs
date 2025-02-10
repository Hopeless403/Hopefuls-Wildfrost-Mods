// Decompiled with JetBrains decompiler
// Type: ActionTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;

public class ActionTrigger : PlayAction
{
  public readonly Entity entity;
  public readonly Entity triggeredBy;
  public string triggerType = "basic";

  public ActionTrigger(Entity entity, Entity triggeredBy)
  {
    this.entity = entity;
    this.triggeredBy = triggeredBy;
  }

  public override bool IsRoutine => false;

  public override void Process()
  {
    if (!this.entity.IsAliveAndExists())
      return;
    Events.InvokePreProcessTrigger(this.entity);
    ActionQueue.Stack((PlayAction) new ActionProcessTrigger(new Func<Trigger>(this.GetTrigger)));
  }

  protected virtual Trigger GetTrigger() => new Trigger(this.entity, this.triggeredBy, this.triggerType, (bool) (UnityEngine.Object) this.entity.targetMode ? this.entity.targetMode.GetTargets(this.entity, (Entity) null, (CardContainer) null) : (Entity[]) null);
}
