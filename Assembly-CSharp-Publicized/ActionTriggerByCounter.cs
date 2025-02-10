// Decompiled with JetBrains decompiler
// Type: ActionTriggerByCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
