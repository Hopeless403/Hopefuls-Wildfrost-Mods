// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenHealthLost
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Health Lost", fileName = "Apply X When Health Lost")]
public class StatusEffectApplyXWhenHealthLost : StatusEffectApplyX
{
  [SerializeField]
  private bool hasThreshold;
  private bool active;
  public int currentHealth;

  protected override void Init() => global::Events.OnEntityDisplayUpdated += new UnityAction<Entity>(this.EntityDisplayUpdated);

  private void OnDestroy() => global::Events.OnEntityDisplayUpdated -= new UnityAction<Entity>(this.EntityDisplayUpdated);

  public override bool RunBeginEvent()
  {
    this.active = true;
    this.currentHealth = this.target.hp.current;
    return false;
  }

  private void EntityDisplayUpdated(Entity entity)
  {
    if (!this.active || this.target.hp.current == this.currentHealth || !((Object) entity == (Object) this.target))
      return;
    int num = this.target.hp.current - this.currentHealth;
    this.currentHealth = this.target.hp.current;
    if (num >= 0 || !this.target.enabled || this.target.silenced || !this.CheckThreshold() || this.targetMustBeAlive && (!this.target.alive || !Battle.IsOnBoard(this.target)))
      return;
    ActionSequence action = new ActionSequence(this.HealthLost(-num));
    action.note = this.name;
    action.priority = this.eventPriority;
    ActionQueue.Stack((PlayAction) action, true);
  }

  private bool CheckThreshold() => !this.hasThreshold || this.target.hp.current <= this.target.hp.max - this.GetAmount();

  private IEnumerator HealthLost(int amount)
  {
    StatusEffectApplyXWhenHealthLost applyXwhenHealthLost = this;
    if ((bool) (Object) applyXwhenHealthLost && applyXwhenHealthLost.target.IsAliveAndExists())
      yield return (object) applyXwhenHealthLost.Run(applyXwhenHealthLost.GetTargets(), amount);
  }
}
