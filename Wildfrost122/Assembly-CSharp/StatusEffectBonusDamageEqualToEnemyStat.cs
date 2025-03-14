﻿// Decompiled with JetBrains decompiler
// Type: StatusEffectBonusDamageEqualToEnemyStat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Bonus Damage Equal To Enemy Stat", fileName = "Bonus Damage Equal To Enemy Stat")]
public class StatusEffectBonusDamageEqualToEnemyStat : StatusEffectData
{
  [SerializeField]
  private SelectScript<Entity> selectEnemy;
  [SerializeField]
  private ScriptableAmount scriptableAmount;
  [SerializeField]
  private bool add = true;
  [SerializeField]
  private bool ping = true;
  private int currentAmount;
  private bool toReset;

  protected override void Init()
  {
    this.PreCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.Gain);
  }

  public override bool RunPreCardPlayedEvent(Entity entity, Entity[] targets)
  {
    return (Object) entity == (Object) this.target && !this.toReset && this.CanTrigger();
  }

  private IEnumerator Gain(Entity entity, Entity[] targets)
  {
    StatusEffectBonusDamageEqualToEnemyStat equalToEnemyStat = this;
    Entity enemy = equalToEnemyStat.SelectEnemy();
    int amount = equalToEnemyStat.GetAmount(enemy);
    if (amount != 0)
    {
      equalToEnemyStat.toReset = true;
      int num1 = equalToEnemyStat.target.tempDamage.Value;
      if (equalToEnemyStat.add)
        equalToEnemyStat.target.tempDamage += amount;
      else
        equalToEnemyStat.target.tempDamage.Value = amount;
      equalToEnemyStat.currentAmount = equalToEnemyStat.target.tempDamage.Value - num1;
      equalToEnemyStat.target.PromptUpdate();
      if (equalToEnemyStat.ping)
      {
        double num2 = (double) equalToEnemyStat.target.curveAnimator.Ping();
        yield return (object) Sequences.Wait(0.5f);
      }
    }
  }

  public override bool RunTurnEndEvent(Entity entity)
  {
    if ((Object) entity == (Object) this.target.owner.entity && this.toReset)
    {
      this.toReset = false;
      if (this.currentAmount != 0)
      {
        this.target.tempDamage -= this.currentAmount;
        this.currentAmount = 0;
        this.target.PromptUpdate();
      }
    }
    return false;
  }

  private Entity SelectEnemy()
  {
    return this.selectEnemy.Run(this.target.GetEnemies()).FirstOrDefault<Entity>();
  }

  private int GetAmount(Entity enemy)
  {
    if (!(bool) (Object) this.scriptableAmount)
      return this.GetAmount();
    return !(bool) (Object) enemy ? 0 : this.scriptableAmount.Get(enemy);
  }
}
