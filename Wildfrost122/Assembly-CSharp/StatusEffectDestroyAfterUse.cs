// Decompiled with JetBrains decompiler
// Type: StatusEffectDestroyAfterUse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
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
    ActionQueue.Stack((PlayAction) new ActionConsume(this.target));
  }
}
