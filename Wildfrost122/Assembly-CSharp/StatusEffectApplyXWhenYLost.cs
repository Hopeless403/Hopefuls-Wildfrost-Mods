// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenYLost
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Y Lost", fileName = "Apply X When Y Lost")]
public class StatusEffectApplyXWhenYLost : StatusEffectApplyX
{
  [SerializeField]
  private string statusType = "block";
  [SerializeField]
  private bool whenAllLost;
  private bool active;
  public int currentAmount;

  protected override void Init()
  {
    global::Events.OnEntityDisplayUpdated += new UnityAction<Entity>(this.EntityDisplayUpdated);
  }

  private void OnDestroy()
  {
    global::Events.OnEntityDisplayUpdated -= new UnityAction<Entity>(this.EntityDisplayUpdated);
  }

  public override bool RunBeginEvent()
  {
    this.active = true;
    this.currentAmount = this.GetCurrentAmount();
    return false;
  }

  private void EntityDisplayUpdated(Entity entity)
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

  private IEnumerator Lost(int amount)
  {
    StatusEffectApplyXWhenYLost effectApplyXwhenYlost = this;
    if ((bool) (Object) effectApplyXwhenYlost && effectApplyXwhenYlost.target.IsAliveAndExists())
      yield return (object) effectApplyXwhenYlost.Run(effectApplyXwhenYlost.GetTargets(), amount);
  }

  private int GetCurrentAmount()
  {
    StatusEffectData status = this.target.FindStatus(this.statusType);
    return status == null ? 0 : status.count;
  }
}
