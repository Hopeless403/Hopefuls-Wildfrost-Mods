// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenYLost
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Y Lost", fileName = "Apply X When Y Lost")]
public class StatusEffectApplyXWhenYLost : StatusEffectApplyX
{
  [SerializeField]
  public string statusType = "block";
  [SerializeField]
  public bool whenAllLost;
  public bool active;
  public int currentAmount;

  public override void Init()
  {
    global::Events.OnEntityDisplayUpdated += new UnityAction<Entity>(this.EntityDisplayUpdated);
  }

  public void OnDestroy()
  {
    global::Events.OnEntityDisplayUpdated -= new UnityAction<Entity>(this.EntityDisplayUpdated);
  }

  public override bool RunBeginEvent()
  {
    this.active = true;
    this.currentAmount = this.GetCurrentAmount();
    return false;
  }

  public void EntityDisplayUpdated(Entity entity)
  {
    int currentAmount = this.GetCurrentAmount();
    if (!this.active || currentAmount == this.currentAmount || !((Object) entity == (Object) this.target))
      return;
    int num = currentAmount - this.currentAmount;
    this.currentAmount = currentAmount;
    if (num >= 0 || this.whenAllLost && this.currentAmount != 0 || !this.target.enabled || this.target.silenced || this.targetMustBeAlive && (!this.target.alive || !Battle.IsOnBoard(this.target)))
      return;
    ActionSequence action = new ActionSequence(this.Lost(-num));
    action.note = this.name;
    action.priority = this.eventPriority;
    ActionQueue.Stack((PlayAction) action, true);
  }

  public IEnumerator Lost(int amount)
  {
    StatusEffectApplyXWhenYLost effectApplyXwhenYlost = this;
    if ((bool) (Object) effectApplyXwhenYlost && effectApplyXwhenYlost.target.IsAliveAndExists())
      yield return (object) effectApplyXwhenYlost.Run(effectApplyXwhenYlost.GetTargets(), amount);
  }

  public int GetCurrentAmount()
  {
    StatusEffectData status = this.target.FindStatus(this.statusType);
    return status == null ? 0 : status.count;
  }
}
