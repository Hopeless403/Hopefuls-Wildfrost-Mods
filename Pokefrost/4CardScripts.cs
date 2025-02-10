// Decompiled with JetBrains decompiler
// Type: Pokefrost.CardScriptCopy
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class CardScriptCopy : CardScript
  {
    public static float waitTime = 1f;

    public override void Run(CardData target)
    {
      CardData data = target.Clone(false);
      data.upgrades.RemoveAll((Predicate<CardUpgradeData>) (a => a.type == CardUpgradeData.Type.Crown));
      References.Player.data.inventory.deck.Add(data);
      MonoBehaviourSingleton<References>.instance.StartCoroutine(this.Animation(CardManager.Get(data, (CardController) UnityEngine.Object.FindObjectOfType<CardControllerDeck>(), References.Player, false, true)));
    }

    public IEnumerator Animation(Card card)
    {
      yield return (object) new WaitForSeconds(CardScriptCopy.waitTime);
      yield return (object) card.UpdateData(false);
      Entity entity = card.entity;
      CardContainerGrid[] cardContainerGridArray = UnityEngine.Object.FindObjectsOfType<CardContainerGrid>();
      for (int index = 0; index < cardContainerGridArray.Length; ++index)
      {
        CardContainerGrid cardGrid = cardContainerGridArray[index];
        if (cardGrid.name == "ItemGrid")
          cardGrid.Add(entity);
        cardGrid = (CardContainerGrid) null;
      }
      cardContainerGridArray = (CardContainerGrid[]) null;
      UnityEngine.Object.FindObjectOfType<DeckDisplaySequence>()?.UpdatePositions();
    }
  }
}
