// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenHealthLost
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Health Lost", fileName = "Apply X When Health Lost")]
public class StatusEffectApplyXWhenHealthLost : StatusEffectApplyX
{
  [SerializeField]
  public bool hasThreshold;
  public bool active;
  public int currentHealth;

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
    this.currentHealth = this.target.hp.current;
    return false;
  }

  public void EntityDisplayUpdated(Entity entity)
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

  public bool CheckThreshold()
  {
    return !this.hasThreshold || this.target.hp.current <= this.target.hp.max - this.GetAmount();
  }

  public IEnumerator HealthLost(int amount)
  {
    StatusEffectApplyXWhenHealthLost applyXwhenHealthLost = this;
    if ((bool) (Object) applyXwhenHealthLost && applyXwhenHealthLost.target.IsAliveAndExists())
      yield return (object) applyXwhenHealthLost.Run(applyXwhenHealthLost.GetTargets(), amount);
  }
}
