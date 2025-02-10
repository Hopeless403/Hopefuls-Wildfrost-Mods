// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenDiscarded
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Discarded", fileName = "Apply X When Discarded")]
public class StatusEffectApplyXWhenDiscarded : StatusEffectApplyX
{
  protected override void Init()
  {
    global::Events.OnActionQueued += new UnityAction<PlayAction>(this.ActionQueued);
  }

  private void ActionQueued(PlayAction action)
  {
    if (!(action is ActionMove actionMove) || !((Object) actionMove.entity == (Object) this.target) || !(bool) (Object) this.target.owner || !actionMove.toContainers.Contains<CardContainer>(this.target.owner.discardContainer))
      return;
    ActionQueue.Insert(ActionQueue.IndexOf(action), (PlayAction) new ActionSequence(this.Sequence()));
  }

  private IEnumerator Sequence() => this.Run(this.GetTargets());
}
