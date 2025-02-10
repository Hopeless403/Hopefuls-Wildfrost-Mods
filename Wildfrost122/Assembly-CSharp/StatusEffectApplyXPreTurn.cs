// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXPreTurn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X Pre Turn", fileName = "Apply X Pre Turn")]
public class StatusEffectApplyXPreTurn : StatusEffectApplyX
{
  [SerializeField]
  private bool mustHaveTarget;
  private bool running;
  private List<Entity> runAgainst;

  protected override void Init()
  {
    if (this.queue)
    {
      global::Events.OnPreProcessTrigger += new UnityAction<Entity>(this.PreProcessTrigger);
    }
    else
    {
      global::Events.OnEntityTrigger += new global::Events.UnityActionRef<Trigger>(this.CheckTrigger);
      this.PreCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.CheckPreCardPlay);
    }
  }

  private void OnDestroy()
  {
    if (this.queue)
      global::Events.OnPreProcessTrigger -= new UnityAction<Entity>(this.PreProcessTrigger);
    else
      global::Events.OnEntityTrigger -= new global::Events.UnityActionRef<Trigger>(this.CheckTrigger);
  }

  private void PreProcessTrigger(Entity entity)
  {
    if (!((Object) entity == (Object) this.target) || this.running || !this.target.enabled)
      return;
    ActionQueue.Stack((PlayAction) new ActionSequence(this.Run(this.GetTargets())), true);
  }

  private void CheckTrigger(ref Trigger trigger)
  {
    if (this.running || !this.target.enabled || !((Object) trigger.entity == (Object) this.target))
      return;
    this.runAgainst = this.GetTargets();
    if (!this.mustHaveTarget || this.runAgainst != null && this.runAgainst.Count > 0)
      return;
    trigger.nullified = true;
  }

  public override bool RunPreCardPlayedEvent(Entity entity, Entity[] targets)
  {
    if (!this.running && this.target.enabled)
    {
      List<Entity> runAgainst = this.runAgainst;
      if (runAgainst != null && runAgainst.Count > 0)
        return (Object) entity == (Object) this.target;
    }
    return false;
  }

  private IEnumerator CheckPreCardPlay(Entity entity, Entity[] targets)
  {
    yield return (object) this.RunSequence(this.runAgainst);
  }

  private IEnumerator RunSequence(List<Entity> targets)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectApplyXPreTurn effectApplyXpreTurn = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      effectApplyXpreTurn.runAgainst = (List<Entity>) null;
      effectApplyXpreTurn.running = false;
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    effectApplyXpreTurn.running = true;
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) effectApplyXpreTurn.Run(targets);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }
}
