// Decompiled with JetBrains decompiler
// Type: StatusEffectRecycle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Traits/Recycle", fileName = "Recycle")]
public class StatusEffectRecycle : StatusEffectData
{
  [SerializeField]
  public string cardToRecycle = "Junk";
  public bool running;
  public readonly List<Entity> toDestroy = new List<Entity>();

  public override void Init()
  {
    Events.OnCheckAction += new Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
    this.PreTrigger += new StatusEffectData.EffectTriggerEventHandler(this.EntityPreTrigger);
  }

  public void OnDestroy() => Events.OnCheckAction -= new Events.UnityActionRef<PlayAction, bool>(this.CheckAction);

  public void CheckAction(ref PlayAction action, ref bool allow)
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

  public IEnumerator EntityPreTrigger(Trigger trigger)
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

  public bool GetTargets(int requiredAmount)
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
