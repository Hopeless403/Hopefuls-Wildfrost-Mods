// Decompiled with JetBrains decompiler
// Type: StatusEffectDestroyAfterUse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Status Effects/Traits/Destroy After Use", fileName = "Destroy After Use")]
public class StatusEffectDestroyAfterUse : StatusEffectData
{
  public bool subbed;
  public bool destroy;

  public void OnDestroy() => this.Unsub();

  public void Sub()
  {
    global::Events.OnActionPerform += new UnityAction<PlayAction>(this.CheckAction);
    this.subbed = true;
  }

  public void Unsub()
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

  public void CheckAction(PlayAction action)
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

  public IEnumerator Consume()
  {
    StatusEffectDestroyAfterUse effectDestroyAfterUse = this;
    yield return (object) Sequences.WaitForAnimationEnd(effectDestroyAfterUse.target);
    effectDestroyAfterUse.target.alive = true;
    yield return (object) effectDestroyAfterUse.target.Kill(DeathType.Consume);
  }
}
