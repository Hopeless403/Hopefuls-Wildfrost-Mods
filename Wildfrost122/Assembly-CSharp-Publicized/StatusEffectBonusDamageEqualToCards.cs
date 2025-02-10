// Decompiled with JetBrains decompiler
// Type: StatusEffectBonusDamageEqualToCards
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Bonus Damage Equal To Cards", fileName = "Bonus Damage Equal To Cards")]
public class StatusEffectBonusDamageEqualToCards : StatusEffectData
{
  [SerializeField]
  public string cardName = "Dart";
  [SerializeField]
  public bool inHand = true;
  [SerializeField]
  public bool onBoard;
  [SerializeField]
  public bool includeSelf = true;
  [SerializeField]
  public bool ping = true;
  public int currentAmount;

  public override void Init()
  {
    this.PreCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.Gain);
  }

  public override bool RunPreCardPlayedEvent(Entity entity, Entity[] targets)
  {
    return (UnityEngine.Object) entity == (UnityEngine.Object) this.target && this.currentAmount == 0 && this.CanTrigger();
  }

  public IEnumerator Gain(Entity entity, Entity[] targets)
  {
    StatusEffectBonusDamageEqualToCards damageEqualToCards = this;
    int num1 = damageEqualToCards.Count();
    if (num1 > 0)
    {
      damageEqualToCards.currentAmount = num1;
      damageEqualToCards.target.tempDamage += damageEqualToCards.currentAmount;
      damageEqualToCards.target.PromptUpdate();
      if (damageEqualToCards.ping)
      {
        CurveAnimator curveAnimator = damageEqualToCards.target.curveAnimator;
        if (curveAnimator != null)
        {
          double num2 = (double) curveAnimator.Ping();
        }
        yield return (object) Sequences.Wait(0.5f);
      }
    }
  }

  public override bool RunTurnEndEvent(Entity entity)
  {
    if (this.currentAmount > 0 && (bool) (UnityEngine.Object) this.target.owner && (bool) (UnityEngine.Object) this.target.owner.entity && (UnityEngine.Object) entity == (UnityEngine.Object) this.target.owner.entity)
    {
      this.target.tempDamage -= this.currentAmount;
      this.currentAmount = 0;
      this.target.PromptUpdate();
    }
    return false;
  }

  public int Count()
  {
    return 0 + (this.inHand ? this.CountInHand() : 0) + (this.onBoard ? this.CountOnBoard() : 0);
  }

  public int CountInHand()
  {
    int num = 0;
    CardContainer handContainer = this.target.owner.handContainer;
    if ((bool) (UnityEngine.Object) handContainer)
      num += handContainer.Where<Entity>((Func<Entity, bool>) (entity => entity.data.name == this.cardName)).Count<Entity>((Func<Entity, bool>) (entity => this.includeSelf || (UnityEngine.Object) entity != (UnityEngine.Object) this.target));
    return num;
  }

  public int CountOnBoard()
  {
    return Battle.GetAllUnits().Where<Entity>((Func<Entity, bool>) (entity => entity.data.name == this.cardName)).Count<Entity>((Func<Entity, bool>) (entity => this.includeSelf || (UnityEngine.Object) entity != (UnityEngine.Object) this.target));
  }

  [CompilerGenerated]
  public bool \u003CCountInHand\u003Eb__11_0(Entity entity) => entity.data.name == this.cardName;

  [CompilerGenerated]
  public bool \u003CCountInHand\u003Eb__11_1(Entity entity)
  {
    return this.includeSelf || (UnityEngine.Object) entity != (UnityEngine.Object) this.target;
  }

  [CompilerGenerated]
  public bool \u003CCountOnBoard\u003Eb__12_0(Entity entity) => entity.data.name == this.cardName;

  [CompilerGenerated]
  public bool \u003CCountOnBoard\u003Eb__12_1(Entity entity)
  {
    return this.includeSelf || (UnityEngine.Object) entity != (UnityEngine.Object) this.target;
  }
}
