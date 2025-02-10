// Decompiled with JetBrains decompiler
// Type: ActionTriggerByCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;

public class ActionTriggerByCounter : ActionTrigger
{
  public ActionTriggerByCounter(Entity entity, Entity triggeredBy)
    : base(entity, triggeredBy)
  {
  }

  public override bool IsRoutine => false;

  public override void Process()
  {
    if (!this.entity.IsAliveAndExists())
      return;
    Events.InvokePreProcessTrigger(this.entity);
    ActionQueue.Stack((PlayAction) new ActionProcessTrigger(new Func<Trigger>(((ActionTrigger) this).GetTrigger)));
  }
}
