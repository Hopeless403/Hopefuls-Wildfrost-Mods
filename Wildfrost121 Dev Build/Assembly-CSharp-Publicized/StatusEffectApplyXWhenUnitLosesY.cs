// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenUnitLosesY
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Unit Loses Y", fileName = "Apply X When Unit Loses Y")]
public class StatusEffectApplyXWhenUnitLosesY : StatusEffectApplyX
{
  [SerializeField]
  public bool self = true;
  [SerializeField]
  public bool allies;
  [SerializeField]
  public bool enemies;
  [SerializeField]
  public string statusType = "block";
  [SerializeField]
  public bool whenAllLost;
  public readonly Dictionary<ulong, int> currentAmounts = new Dictionary<ulong, int>();

  public override void Init()
  {
    global::Events.OnEntityDisplayUpdated += new UnityAction<Entity>(this.EntityDisplayUpdated);
  }

  public void OnDestroy()
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

  public void EntityDisplayUpdated(Entity entity)
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

  public IEnumerator Lost(int amount)
  {
    StatusEffectApplyXWhenUnitLosesY applyXwhenUnitLosesY = this;
    if ((bool) (Object) applyXwhenUnitLosesY && applyXwhenUnitLosesY.target.IsAliveAndExists())
      yield return (object) applyXwhenUnitLosesY.Run(applyXwhenUnitLosesY.GetTargets(), amount);
  }

  public int GetCurrentAmount(Entity entity)
  {
    StatusEffectData status = entity.FindStatus(this.statusType);
    return status == null ? 0 : status.count;
  }

  public void StoreCurrentAmount(Entity entity)
  {
    this.currentAmounts[entity.data.id] = this.GetCurrentAmount(entity);
  }

  public void CheckEntity(Entity entity)
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
