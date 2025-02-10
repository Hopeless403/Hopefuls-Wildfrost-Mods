// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenDiscarded
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Discarded", fileName = "Apply X When Discarded")]
public class StatusEffectApplyXWhenDiscarded : StatusEffectApplyX
{
  public override void Init()
  {
    global::Events.OnActionQueued += new UnityAction<PlayAction>(this.ActionQueued);
  }

  public void ActionQueued(PlayAction action)
  {
    if (!(action is ActionMove actionMove) || !((Object) actionMove.entity == (Object) this.target) || !(bool) (Object) this.target.owner || !actionMove.toContainers.Contains<CardContainer>(this.target.owner.discardContainer))
      return;
    ActionQueue.Insert(ActionQueue.IndexOf(action), (PlayAction) new ActionSequence(this.Sequence()));
  }

  public IEnumerator Sequence() => this.Run(this.GetTargets());
}
