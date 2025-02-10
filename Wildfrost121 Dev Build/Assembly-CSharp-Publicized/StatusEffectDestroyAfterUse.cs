// Decompiled with JetBrains decompiler
// Type: StatusEffectDestroyAfterUse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
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
    ActionQueue.Stack((PlayAction) new ActionConsume(this.target));
  }
}
