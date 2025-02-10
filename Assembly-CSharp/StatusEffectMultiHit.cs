// Decompiled with JetBrains decompiler
// Type: StatusEffectMultiHit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Traits/Multi Hit", fileName = "Multi Hit")]
public class StatusEffectMultiHit : StatusEffectData
{
  [SerializeField]
  private bool clearAfter;
  private int attackCount;
  private Trigger originalTrigger;
  private List<ActionTrigger> additionalTriggers;

  protected override void Init() => Events.OnEntityTrigger += new Events.UnityActionRef<Trigger>(this.EntityTrigger);

  private void OnDestroy() => Events.OnEntityTrigger -= new Events.UnityActionRef<Trigger>(this.EntityTrigger);

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
  {
    if ((Object) entity == (Object) this.target && this.target.alive && this.target.enabled)
    {
      --this.attackCount;
      if (entity.IsSnowed)
        this.attackCount = 0;
      if (this.attackCount <= 0)
        this.Cancel();
    }
    return false;
  }

  private void EntityTrigger(ref Trigger trigger)
  {
    if ((Object) trigger.entity != (Object) this.target || !trigger.countsAsTrigger)
      return;
    if (this.originalTrigger != null)
    {
      if (!this.target.IsSnowed)
        return;
      this.Cancel();
    }
    else
    {
      this.attackCount = 1;
      this.originalTrigger = trigger;
      if (trigger.triggerAgainst)
      {
        for (int index = 0; index < this.count; ++index)
        {
          ActionTriggerSubsequent trigger1 = new ActionTriggerSubsequent(this.target, (Entity) null, trigger.triggerAgainstTarget, trigger.triggerAgainstContainer);
          trigger1.note = "[" + this.target.name + "] Frenzy";
          this.AddTrigger((ActionTrigger) trigger1);
        }
      }
      else
      {
        for (int index = 0; index < this.count; ++index)
        {
          ActionTrigger trigger2 = new ActionTrigger(this.target, (Entity) null);
          trigger2.note = "[" + this.target.name + "] Frenzy";
          this.AddTrigger(trigger2);
        }
      }
    }
  }

  private void Cancel()
  {
    this.attackCount = 0;
    this.originalTrigger = (Trigger) null;
    if (this.additionalTriggers != null)
    {
      foreach (PlayAction additionalTrigger in this.additionalTriggers)
        ActionQueue.Remove(additionalTrigger);
    }
    this.additionalTriggers = (List<ActionTrigger>) null;
    if (!this.clearAfter)
      return;
    ActionSequence action = new ActionSequence(this.Clear());
    action.note = "Clear Temporary MultiHit";
    ActionQueue.Stack((PlayAction) action, true);
  }

  private void AddTrigger(ActionTrigger trigger)
  {
    ActionQueue.Stack((PlayAction) trigger);
    if (this.additionalTriggers == null)
      this.additionalTriggers = new List<ActionTrigger>();
    this.additionalTriggers.Add(trigger);
    ++this.attackCount;
  }

  private IEnumerator Clear()
  {
    StatusEffectMultiHit status = this;
    int count = status.count;
    Events.InvokeStatusEffectCountDown((StatusEffectData) status, ref count);
    if (count != 0)
      yield return (object) status.CountDown(status.target, count);
  }
}
