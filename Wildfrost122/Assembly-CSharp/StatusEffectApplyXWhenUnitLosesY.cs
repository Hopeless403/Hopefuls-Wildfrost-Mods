// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenUnitLosesY
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Unit Loses Y", fileName = "Apply X When Unit Loses Y")]
public class StatusEffectApplyXWhenUnitLosesY : StatusEffectApplyX
{
  [SerializeField]
  private bool self = true;
  [SerializeField]
  private bool allies;
  [SerializeField]
  private bool enemies;
  [SerializeField]
  private string statusType = "block";
  [SerializeField]
  private bool whenAllLost;
  private readonly Dictionary<ulong, int> currentAmounts = new Dictionary<ulong, int>();

  protected override void Init()
  {
    global::Events.OnEntityDisplayUpdated += new UnityAction<Entity>(this.EntityDisplayUpdated);
  }

  private void OnDestroy()
  {
    global::Events.OnEntityDisplayUpdated -= new UnityAction<Entity>(this.EntityDisplayUpdated);
  }

  public override bool RunEnableEvent(Entity entity)
  {
    if ((Object) entity != (Object) this.target)
      return false;
    if (this.self)
      this.StoreCurrentAmount(this.target);
    if (this.allies)
    {
      foreach (Entity allAlly in this.target.GetAllAllies())
        this.StoreCurrentAmount(allAlly);
    }
    if (this.enemies)
    {
      foreach (Entity allEnemy in this.target.GetAllEnemies())
        this.StoreCurrentAmount(allEnemy);
    }
    return false;
  }

  public override bool RunDisableEvent(Entity entity)
  {
    if ((Object) entity == (Object) this.target)
      this.currentAmounts.Clear();
    return false;
  }

  private void EntityDisplayUpdated(Entity entity)
  {
    if (!entity.enabled || !Battle.IsOnBoard(entity))
      return;
    if ((Object) entity == (Object) this.target)
    {
      if (!this.self)
        return;
      this.CheckEntity(entity);
    }
    else if (entity.owner.team == this.target.owner.team)
    {
      if (!this.allies)
        return;
      this.CheckEntity(entity);
    }
    else
    {
      if (!this.enemies)
        return;
      this.CheckEntity(entity);
    }
  }

  private IEnumerator Lost(int amount)
  {
    StatusEffectApplyXWhenUnitLosesY applyXwhenUnitLosesY = this;
    if ((bool) (Object) applyXwhenUnitLosesY && applyXwhenUnitLosesY.target.IsAliveAndExists())
      yield return (object) applyXwhenUnitLosesY.Run(applyXwhenUnitLosesY.GetTargets(), amount);
  }

  private int GetCurrentAmount(Entity entity)
  {
    StatusEffectData status = entity.FindStatus(this.statusType);
    return status == null ? 0 : status.count;
  }

  private void StoreCurrentAmount(Entity entity)
  {
    this.currentAmounts[entity.data.id] = this.GetCurrentAmount(entity);
  }

  private void CheckEntity(Entity entity)
  {
    int num1;
    this.currentAmounts.TryGetValue(entity.data.id, out num1);
    int currentAmount = this.GetCurrentAmount(entity);
    this.currentAmounts[entity.data.id] = currentAmount;
    int num2 = currentAmount - num1;
    if (num2 >= 0 || this.whenAllLost && num1 != 0 || this.target.silenced || this.targetMustBeAlive && (!this.target.alive || !Battle.IsOnBoard(this.target)))
      return;
    ActionSequence action = new ActionSequence(this.Lost(-num2));
    action.note = this.name;
    action.priority = this.eventPriority;
    ActionQueue.Stack((PlayAction) action, true);
  }
}
