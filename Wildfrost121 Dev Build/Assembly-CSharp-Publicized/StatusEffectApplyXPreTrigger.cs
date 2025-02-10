// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXPreTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X Pre Trigger", fileName = "Apply X Pre Trigger")]
public class StatusEffectApplyXPreTrigger : StatusEffectApplyX
{
  [SerializeField]
  public bool mustHaveTarget;
  [SerializeField]
  public bool oncePerTurn = true;
  public bool running;
  public bool hasRunThisTurn;
  public List<Entity> runAgainst;

  public override void Init()
  {
    this.PreTrigger += new StatusEffectData.EffectTriggerEventHandler(this.EntityPreTrigger);
  }

  public override bool RunPreTriggerEvent(Trigger trigger) => this.CheckTrigger(trigger);

  public IEnumerator EntityPreTrigger(Trigger trigger)
  {
    StatusEffectApplyXPreTrigger applyXpreTrigger = this;
    if (applyXpreTrigger.oncePerTurn)
      applyXpreTrigger.hasRunThisTurn = true;
    applyXpreTrigger.running = true;
    yield return (object) applyXpreTrigger.Run(applyXpreTrigger.runAgainst);
    applyXpreTrigger.runAgainst = (List<Entity>) null;
    applyXpreTrigger.running = false;
  }

  public bool CheckTrigger(Trigger trigger)
  {
    if (this.hasRunThisTurn || this.running || !this.target.enabled || (Object) trigger.entity != (Object) this.target)
      return false;
    this.runAgainst = this.GetTargets();
    if (!this.mustHaveTarget || this.runAgainst != null && this.runAgainst.Count > 0)
      return true;
    trigger.nullified = true;
    return false;
  }

  public override bool RunTurnEndEvent(Entity entity)
  {
    if (this.hasRunThisTurn && (Object) entity == (Object) this.target)
      this.hasRunThisTurn = false;
    return false;
  }
}
