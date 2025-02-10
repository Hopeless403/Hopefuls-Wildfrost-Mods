// Decompiled with JetBrains decompiler
// Type: StatusEffectBonusDamageEqualToX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

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

  public override void Init() => this.PreCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.Gain);

  public override bool RunPreCardPlayedEvent(Entity entity, Entity[] targets) => (UnityEngine.Object) entity == (UnityEngine.Object) this.target && !this.toReset && this.CanTrigger();

  public IEnumerator Gain(Entity entity, Entity[] targets)
  {
    StatusEffectBonusDamageEqualToX bonusDamageEqualToX = this;
    int num1 = bonusDamageEqualToX.Find();
    if (num1 != 0)
    {
      bonusDamageEqualToX.toReset = true;
      int num2 = bonusDamageEqualToX.target.tempDamage.Value;
      if (bonusDamageEqualToX.add)
        bonusDamageEqualToX.target.tempDamage += num1;
      else
        bonusDamageEqualToX.target.tempDamage.Value = num1;
      bonusDamageEqualToX.currentAmount = bonusDamageEqualToX.target.tempDamage.Value - num2;
      bonusDamageEqualToX.target.PromptUpdate();
      if (bonusDamageEqualToX.ping)
      {
        double num3 = (double) bonusDamageEqualToX.target.curveAnimator.Ping();
        yield return (object) Sequences.Wait(0.5f);
      }
    }
  }

  public override bool RunTurnEndEvent(Entity entity)
  {
    if ((UnityEngine.Object) entity == (UnityEngine.Object) this.target.owner.entity && this.toReset)
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
  public int \u003CFindOnBoard\u003Eb__17_0(Entity e) => this.target.hp.current;

  [CompilerGenerated]
  public StatusEffectData \u003CFindOnBoard\u003Eb__17_1(Entity entity) => entity.FindStatus(this.effectType);

  public enum On
  {
    Self,
    Board,
    ScriptableAmount,
  }
}
