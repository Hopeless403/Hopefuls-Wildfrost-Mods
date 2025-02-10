// Decompiled with JetBrains decompiler
// Type: StatusEffectBonusDamageEqualToX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Bonus Damage Equal To X", fileName = "Bonus Damage Equal To X")]
public class StatusEffectBonusDamageEqualToX : StatusEffectData
{
  [SerializeField]
  private StatusEffectBonusDamageEqualToX.On on;
  [SerializeField]
  [ShowIf("useScriptableAmount")]
  private ScriptableAmount scriptableAmount;
  [SerializeField]
  private bool add = true;
  [SerializeField]
  [HideIf("useScriptableAmount")]
  private bool health;
  [HideIf("health")]
  public string effectType = "shell";
  [SerializeField]
  private bool ping = true;
  private int currentAmount;
  private bool toReset;

  private bool useScriptableAmount
  {
    get => this.on == StatusEffectBonusDamageEqualToX.On.ScriptableAmount;
  }

  protected override void Init()
  {
    this.PreCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.Gain);
  }

  public override bool RunPreCardPlayedEvent(Entity entity, Entity[] targets)
  {
    return (UnityEngine.Object) entity == (UnityEngine.Object) this.target && this.CanTrigger();
  }

  private IEnumerator Gain(Entity entity, Entity[] targets)
  {
    int amount = this.Find();
    if (!this.toReset || amount != this.currentAmount)
    {
      if (this.toReset)
        this.LoseCurrentAmount();
      if (amount > 0)
        yield return (object) this.GainAmount(amount);
    }
  }

  private IEnumerator GainAmount(int amount)
  {
    StatusEffectBonusDamageEqualToX bonusDamageEqualToX = this;
    bonusDamageEqualToX.toReset = true;
    int num1 = bonusDamageEqualToX.target.tempDamage.Value;
    if (bonusDamageEqualToX.add)
      bonusDamageEqualToX.target.tempDamage += amount;
    else
      bonusDamageEqualToX.target.tempDamage.Value = amount;
    bonusDamageEqualToX.currentAmount = bonusDamageEqualToX.target.tempDamage.Value - num1;
    bonusDamageEqualToX.target.PromptUpdate();
    if (bonusDamageEqualToX.ping)
    {
      double num2 = (double) bonusDamageEqualToX.target.curveAnimator.Ping();
      yield return (object) Sequences.Wait(0.5f);
    }
  }

  public override bool RunTurnEndEvent(Entity entity)
  {
    if ((UnityEngine.Object) entity == (UnityEngine.Object) this.target.owner.entity && this.toReset)
      this.LoseCurrentAmount();
    return false;
  }

  private void LoseCurrentAmount()
  {
    this.toReset = false;
    if (this.currentAmount == 0)
      return;
    this.target.tempDamage -= this.currentAmount;
    this.currentAmount = 0;
    this.target.PromptUpdate();
  }

  private int Find()
  {
    int num;
    switch (this.on)
    {
      case StatusEffectBonusDamageEqualToX.On.Self:
        num = this.FindOnSelf();
        break;
      case StatusEffectBonusDamageEqualToX.On.Board:
        num = this.FindOnBoard();
        break;
      case StatusEffectBonusDamageEqualToX.On.ScriptableAmount:
        num = this.scriptableAmount.Get(this.target);
        break;
      default:
        num = 0;
        break;
    }
    return num;
  }

  private int FindOnSelf()
  {
    int onSelf = 0;
    if (this.health)
    {
      onSelf = this.target.hp.current;
    }
    else
    {
      StatusEffectData status = this.target.FindStatus(this.effectType);
      if ((bool) (UnityEngine.Object) status && status.count > 0)
        onSelf = status.count;
    }
    return onSelf;
  }

  private int FindOnBoard()
  {
    int num = 0;
    return !this.health ? num + Battle.GetCardsOnBoard().Select<Entity, StatusEffectData>((Func<Entity, StatusEffectData>) (entity => entity.FindStatus(this.effectType))).Where<StatusEffectData>((Func<StatusEffectData, bool>) (effect => (bool) (UnityEngine.Object) effect && effect.count > 0)).Sum<StatusEffectData>((Func<StatusEffectData, int>) (effect => effect.count)) : num + Battle.GetCardsOnBoard().Sum<Entity>((Func<Entity, int>) (e => this.target.hp.current));
  }

  private enum On
  {
    Self,
    Board,
    ScriptableAmount,
  }
}
