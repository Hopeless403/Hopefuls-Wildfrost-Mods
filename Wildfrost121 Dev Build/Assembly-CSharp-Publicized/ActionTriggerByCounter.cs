// Decompiled with JetBrains decompiler
// Type: ActionTriggerByCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;

#nullable disable
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
