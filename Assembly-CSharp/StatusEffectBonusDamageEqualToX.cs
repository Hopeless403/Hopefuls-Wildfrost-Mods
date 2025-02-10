// Decompiled with JetBrains decompiler
// Type: StatusEffectBonusDamageEqualToX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Linq;
using UnityEngine;

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

  private bool useScriptableAmount => this.on == StatusEffectBonusDamageEqualToX.On.ScriptableAmount;

  protected override void Init() => this.PreCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.Gain);

  public override bool RunPreCardPlayedEvent(Entity entity, Entity[] targets) => (UnityEngine.Object) entity == (UnityEngine.Object) this.target && !this.toReset && this.CanTrigger();

  private IEnumerator Gain(Entity entity, Entity[] targets)
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
