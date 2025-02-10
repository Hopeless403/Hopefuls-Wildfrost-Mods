// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenDiscarded
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Discarded", fileName = "Apply X When Discarded")]
public class StatusEffectApplyXWhenDiscarded : StatusEffectApplyX
{
  protected override void Init() => global::Events.OnActionQueued += new UnityAction<PlayAction>(this.ActionQueued);

  private void ActionQueued(PlayAction action)
  {
    if (!(action is ActionMove actionMove) || !((Object) actionMove.entity == (Object) this.target) || !(bool) (Object) this.target.owner || !actionMove.toContainers.Contains<CardContainer>(this.target.owner.discardContainer))
      return;
    ActionQueue.Insert(ActionQueue.IndexOf(action), (PlayAction) new ActionSequence(this.Sequence()));
  }

  private IEnumerator Sequence() => this.Run(this.GetTargets());
}
