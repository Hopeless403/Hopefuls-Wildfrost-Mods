// Decompiled with JetBrains decompiler
// Type: StatusEffectBonusDamageEqualToX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Bonus Damage Equal To X", fileName = "Bonus Damage Equal To X")]
public class StatusEffectBonusDamageEqualToX : StatusEffectData
{
  [SerializeField]
  public StatusEffectBonusDamageEqualToX.On on;
  [SerializeField]
  [ShowIf("useScriptableAmount")]
  public ScriptableAmount scriptableAmount;
  [SerializeField]
  public bool add = true;
  [SerializeField]
  [HideIf("useScriptableAmount")]
  public bool health;
  [HideIf("health")]
  public string effectType = "shell";
  [SerializeField]
  public bool ping = true;
  public int currentAmount;
  public bool toReset;

  public bool useScriptableAmount => this.on == StatusEffectBonusDamageEqualToX.On.ScriptableAmount;

  public override void Init()
  {
    this.PreCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.Gain);
  }

  public override bool RunPreCardPlayedEvent(Entity entity, Entity[] targets)
  {
    return (UnityEngine.Object) entity == (UnityEngine.Object) this.target && this.CanTrigger();
  }

  public IEnumerator Gain(Entity entity, Entity[] targets)
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

  public IEnumerator GainAmount(int amount)
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

  public void LoseCurrentAmount()
  {
    this.toReset = false;
    if (this.currentAmount == 0)
      return;
    this.target.tempDamage -= this.currentAmount;
    this.currentAmount = 0;
    this.target.PromptUpdate();
  }

  public int Find()
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

  public int FindOnSelf()
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

  public int FindOnBoard()
  {
    int num = 0;
    return !this.health ? num + Battle.GetCardsOnBoard().Select<Entity, StatusEffectData>((Func<Entity, StatusEffectData>) (entity => entity.FindStatus(this.effectType))).Where<StatusEffectData>((Func<StatusEffectData, bool>) (effect => (bool) (UnityEngine.Object) effect && effect.count > 0)).Sum<StatusEffectData>((Func<StatusEffectData, int>) (effect => effect.count)) : num + Battle.GetCardsOnBoard().Sum<Entity>((Func<Entity, int>) (e => this.target.hp.current));
  }

  [CompilerGenerated]
  public int \u003CFindOnBoard\u003Eb__19_0(Entity e) => this.target.hp.current;

  [CompilerGenerated]
  public StatusEffectData \u003CFindOnBoard\u003Eb__19_1(Entity entity)
  {
    return entity.FindStatus(this.effectType);
  }

  public enum On
  {
    Self,
    Board,
    ScriptableAmount,
  }
}
