// Decompiled with JetBrains decompiler
// Type: StatusEffectBonusDamageEqualToCards
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Bonus Damage Equal To Cards", fileName = "Bonus Damage Equal To Cards")]
public class StatusEffectBonusDamageEqualToCards : StatusEffectData
{
  [SerializeField]
  private string cardName = "Dart";
  [SerializeField]
  private bool inHand = true;
  [SerializeField]
  private bool onBoard;
  [SerializeField]
  private bool includeSelf = true;
  [SerializeField]
  private bool ping = true;
  private int currentAmount;

  protected override void Init() => this.PreCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.Gain);

  public override bool RunPreCardPlayedEvent(Entity entity, Entity[] targets) => (UnityEngine.Object) entity == (UnityEngine.Object) this.target && this.currentAmount == 0 && this.CanTrigger();

  private IEnumerator Gain(Entity entity, Entity[] targets)
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

  private int Count() => 0 + (this.inHand ? this.CountInHand() : 0) + (this.onBoard ? this.CountOnBoard() : 0);

  private int CountInHand()
  {
    int num = 0;
    CardContainer handContainer = this.target.owner.handContainer;
    if ((bool) (UnityEngine.Object) handContainer)
      num += handContainer.Where<Entity>((Func<Entity, bool>) (entity => entity.data.name == this.cardName)).Count<Entity>((Func<Entity, bool>) (entity => this.includeSelf || (UnityEngine.Object) entity != (UnityEngine.Object) this.target));
    return num;
  }

  private int CountOnBoard() => Battle.GetAllUnits().Where<Entity>((Func<Entity, bool>) (entity => entity.data.name == this.cardName)).Count<Entity>((Func<Entity, bool>) (entity => this.includeSelf || (UnityEngine.Object) entity != (UnityEngine.Object) this.target));
}
