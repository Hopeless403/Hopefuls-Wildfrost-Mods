// Decompiled with JetBrains decompiler
// Type: StatusEffectRecycle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Traits/Recycle", fileName = "Recycle")]
public class StatusEffectRecycle : StatusEffectData
{
  public string cardToRecycle = "Junk";
  private bool running;
  private readonly List<Entity> toDestroy = new List<Entity>();

  protected override void Init()
  {
    Events.OnCheckAction += new Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
    this.PreTrigger += new StatusEffectData.EffectTriggerEventHandler(this.EntityPreTrigger);
  }

  private void OnDestroy()
  {
    Events.OnCheckAction -= new Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
  }

  private void CheckAction(ref PlayAction action, ref bool allow)
  {
    if (this.running || !this.target.enabled || this.target.silenced || !allow || !(action is ActionTrigger actionTrigger) || !((Object) actionTrigger.entity == (Object) this.target))
      return;
    int amount = this.GetAmount();
    Events.CheckRecycleAmount(this.target, ref amount);
    if (amount <= 0 || this.GetTargets(amount))
      return;
    allow = false;
    if (!NoTargetTextSystem.Exists())
      return;
    Routine routine = new Routine(NoTargetTextSystem.Run(this.target, NoTargetType.RequiresJunk, (object) amount));
  }

  public override bool RunPreTriggerEvent(Trigger trigger) => this.toDestroy.Count > 0;

  private IEnumerator EntityPreTrigger(Trigger trigger)
  {
    StatusEffectRecycle statusEffectRecycle = this;
    statusEffectRecycle.running = true;
    foreach (Entity entity in statusEffectRecycle.toDestroy)
    {
      double num = (double) statusEffectRecycle.target.curveAnimator.Ping();
      yield return (object) entity.Kill();
    }
    statusEffectRecycle.toDestroy.Clear();
    statusEffectRecycle.running = false;
  }

  private bool GetTargets(int requiredAmount)
  {
    bool targets = false;
    this.toDestroy.Clear();
    foreach (Entity entity in References.Player.handContainer)
    {
      if (entity.data.name == this.cardToRecycle)
      {
        this.toDestroy.Add(entity);
        if (--requiredAmount <= 0)
        {
          targets = true;
          break;
        }
      }
    }
    if (!targets)
      this.toDestroy.Clear();
    return targets;
  }

  public bool IsEnoughJunkInHand()
  {
    int amount = this.GetAmount();
    foreach (Entity entity in References.Player.handContainer)
    {
      if (entity.data.name == this.cardToRecycle && --amount <= 0)
        return true;
    }
    return false;
  }
}
