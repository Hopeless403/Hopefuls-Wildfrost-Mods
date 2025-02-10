// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectIncreaseAttackBasedOnCardsDrawnThisTurn
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectIncreaseAttackBasedOnCardsDrawnThisTurn : StatusEffectData
  {
    [SerializeField]
    public StatusEffectData effectToGain;
    public int currentAmount;
    public int amount;
    public int newAmount;
    public int cardsDrawn;

    public override bool HasTurnEndRoutine => true;

    public override bool HasActionPerformedRoutine => true;

    public override void Init()
    {
      global::Events.OnCardDraw += new UnityAction<int>(this.HowManyCardsDrawn);
      base.Init();
    }

    public void OnDestroy() => global::Events.OnCardDraw -= new UnityAction<int>(this.HowManyCardsDrawn);

    public void HowManyCardsDrawn(int arg)
    {
      this.cardsDrawn = Math.Min(arg, References.Player.drawContainer.Count);
      this.target.StartCoroutine(this.Activate(this.cardsDrawn));
    }

    public override IEnumerator ActionPerformedRoutine(PlayAction action)
    {
      yield break;
    }

    public override IEnumerator TurnEndRoutine(Entity entity)
    {
      if ((UnityEngine.Object) entity == (UnityEngine.Object) this.target)
        yield return (object) this.Deactivate();
    }

    public IEnumerator Activate(int arg)
    {
      Debug.Log((object) "[Sneasel] Activate");
      Debug.Log((object) arg.ToString());
      this.amount = this.GetAmount() * arg;
      this.currentAmount += this.amount;
      this.cardsDrawn = 0;
      Debug.Log((object) ("[Sneasel] Gains " + this.amount.ToString() + " attack"));
      yield return (object) StatusEffectSystem.Apply(this.target, this.target, this.effectToGain, this.amount, true);
    }

    public IEnumerator Deactivate()
    {
      Debug.Log((object) "[Sneasel] Decactivate");
      for (int num = this.target.statusEffects.Count - 1; num >= 0; --num)
      {
        StatusEffectData statusEffectData = this.target.statusEffects[num];
        if ((bool) (UnityEngine.Object) statusEffectData && statusEffectData.name == this.effectToGain.name)
        {
          yield return (object) statusEffectData.RemoveStacks(this.currentAmount, true);
          break;
        }
        statusEffectData = (StatusEffectData) null;
      }
      this.currentAmount = 0;
    }
  }
}
