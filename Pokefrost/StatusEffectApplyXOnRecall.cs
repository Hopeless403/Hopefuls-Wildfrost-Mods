// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectApplyXOnRecall
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectApplyXOnRecall : StatusEffectApplyX
  {
    public bool once = false;

    public override void Init()
    {
      global::Events.OnActionQueued += new UnityAction<PlayAction>(this.ActionQueued);
    }

    public void OnDestroy()
    {
      global::Events.OnActionQueued -= new UnityAction<PlayAction>(this.ActionQueued);
    }

    public void ActionQueued(PlayAction action)
    {
      if (!(action is ActionMove actionMove) || !((Object) actionMove.entity == (Object) this.target) || !(bool) (Object) this.target.owner || !actionMove.toContainers.Contains<CardContainer>(this.target.owner.discardContainer) || !Battle.IsOnBoard(actionMove.entity.containers))
        return;
      ActionQueue.Insert(ActionQueue.IndexOf(action), (PlayAction) new ActionSequence(this.Sequence()));
    }

    public IEnumerator Sequence()
    {
      yield return (object) this.Run(this.GetTargets());
      if (this.once)
      {
        yield return (object) this.Remove();
        this.target.display.promptUpdateDescription = true;
        this.target.PromptUpdate();
      }
    }
  }
}
