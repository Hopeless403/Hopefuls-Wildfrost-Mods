// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectInstantApplyXCardInDeck
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectInstantApplyXCardInDeck : StatusEffectInstantApplyEffect
  {
    public TargetConstraint[] constraints;

    public override IEnumerator Process()
    {
      CardDataList deck = References.PlayerData.inventory.deck;
      List<CardData> cards = deck.InRandomOrder<CardData>().ToList<CardData>();
      foreach (CardData card in cards)
      {
        Debug.Log((object) ("[Pokefrost] " + card.title));
        if (this.SatisfiesConstraints(card))
        {
          Debug.Log((object) ("[Pokefrost] Upgrading " + card.title));
          card.startWithEffects = CardData.StatusEffectStacks.Stack((IEnumerable<CardData.StatusEffectStacks>) card.startWithEffects, (IEnumerable<CardData.StatusEffectStacks>) new CardData.StatusEffectStacks[1]
          {
            new CardData.StatusEffectStacks(this.effectToApply, this.GetAmount())
          });
          foreach (Entity entity in Battle.GetAllCards())
          {
            if ((long) entity.data.id == (long) card.id)
              yield return (object) StatusEffectSystem.Apply(entity, this.target, this.effectToApply, this.GetAmount());
          }
          break;
        }
      }
      yield return (object) this.Remove();
    }

    public bool SatisfiesConstraints(CardData data)
    {
      foreach (TargetConstraint constraint in this.constraints)
      {
        if (!constraint.Check(data))
          return false;
      }
      return true;
    }
  }
}
