// Decompiled with JetBrains decompiler
// Type: StatusEffectDestroyAfterUse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Status Effects/Traits/Destroy After Use", fileName = "Destroy After Use")]
public class StatusEffectDestroyAfterUse : StatusEffectData
{
  private bool subbed;
  private bool destroy;

  private void OnDestroy() => this.Unsub();

  private void Sub()
  {
    global::Events.OnActionPerform += new UnityAction<PlayAction>(this.CheckAction);
    this.subbed = true;
  }

  private void Unsub()
  {
    if (!this.subbed)
      return;
    global::Events.OnActionPerform -= new UnityAction<PlayAction>(this.CheckAction);
    this.subbed = false;
  }

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
  {
    if (!this.subbed && (Object) entity == (Object) this.target && !this.target.silenced)
    {
      this.Sub();
      if (this.target.uses.current <= 1)
        this.destroy = true;
    }
    return false;
  }

  private void CheckAction(PlayAction action)
  {
    if (!(action is ActionReduceUses actionReduceUses) || !((Object) actionReduceUses.entity == (Object) this.target))
      return;
    this.Unsub();
    if (!this.destroy)
      return;
    this.target.alive = false;
    ActionSequence action1 = new ActionSequence(this.Consume());
    action1.note = "Consume";
    ActionQueue.Stack((PlayAction) action1);
  }

  private IEnumerator Consume()
  {
    StatusEffectDestroyAfterUse effectDestroyAfterUse = this;
    yield return (object) Sequences.WaitForAnimationEnd(effectDestroyAfterUse.target);
    effectDestroyAfterUse.target.alive = true;
    yield return (object) effectDestroyAfterUse.target.Kill(DeathType.Consume);
  }
}
