// Decompiled with JetBrains decompiler
// Type: EventRoutineGnomeShop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventRoutineGnomeShop : EventRoutine, IRerollable
{
  [SerializeField]
  private CardController cardController;
  [SerializeField]
  private CardSelector cardSelector;
  [SerializeField]
  private CardContainer cardContainer;
  [SerializeField]
  private ShopPriceManager priceManager;
  [SerializeField]
  private ShopItem bell;
  [SerializeField]
  private float cardScale = 0.8f;
  private Entity currentCard;
  private bool promptReroll;
  private bool promptEnd;

  public override IEnumerator Populate()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    EventRoutineGnomeShop routineGnomeShop = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    EventRoutineGnomeShop.Data shopData = routineGnomeShop.data.Get<EventRoutineGnomeShop.Data>("data");
    routineGnomeShop.priceManager.Add(routineGnomeShop.bell, ShopPrice.Position.Bottom).SetPrice(shopData.price);
    routineGnomeShop.cardContainer.SetSize(1, routineGnomeShop.cardScale);
    string nextCard = routineGnomeShop.GetNextCard(shopData);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) routineGnomeShop.CreateCard(nextCard);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  public override IEnumerator Run()
  {
    EventRoutineGnomeShop routineGnomeShop = this;
    routineGnomeShop.cardController.owner = routineGnomeShop.player;
    routineGnomeShop.cardContainer.owner = routineGnomeShop.player;
    routineGnomeShop.cardSelector.character = routineGnomeShop.player;
    routineGnomeShop.currentCard.flipper.FlipUp();
    while (!routineGnomeShop.promptEnd)
    {
      if (routineGnomeShop.promptReroll)
      {
        yield return (object) routineGnomeShop.RerollRoutine();
        routineGnomeShop.promptReroll = false;
      }
      else
        yield return (object) null;
    }
  }

  public void TakeCard()
  {
    this.cardSelector.TakeCard(this.currentCard);
    this.cardController.Disable();
    Events.InvokeEntityChosen(this.currentCard);
    this.priceManager.Remove(this.bell);
    Button component = this.bell.GetComponent<Button>();
    if (component != null)
      component.interactable = false;
    this.promptEnd = true;
    this.node.SetCleared();
  }

  private string GetNextCard(EventRoutineGnomeShop.Data shopData)
  {
    EventRoutineGnomeShop.Data data = shopData;
    if (data.cards == null)
      data.cards = new List<string>();
    if (shopData.cards.Count <= 0)
    {
      UnityEngine.Random.InitState(this.node.seed);
      for (int index = 0; index < shopData.cyclesThroughPool; ++index)
      {
        double num = (double) UnityEngine.Random.Range(0.0f, 1f);
      }
      foreach (string str in shopData.pool)
        shopData.cards.Insert(UnityEngine.Random.Range(0, shopData.cards.Count), str);
      ++shopData.cyclesThroughPool;
    }
    string card = shopData.cards[0];
    shopData.cards.RemoveAt(0);
    return card;
  }

  private IEnumerator CreateCard(string cardDataName)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    EventRoutineGnomeShop routineGnomeShop = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      routineGnomeShop.cardContainer.SetChildPositions();
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    Card card = CardManager.Get(AddressableLoader.Get<CardData>("CardData", cardDataName).Clone(), routineGnomeShop.cardController, routineGnomeShop.player, false, true);
    routineGnomeShop.currentCard = card.entity;
    card.transform.position = new Vector3(-999f, 0.0f, 0.0f);
    card.entity.flipper.FlipDownInstant();
    routineGnomeShop.cardContainer.Add(card.entity);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) card.UpdateData(false);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  public void HitBell()
  {
    if (this.promptEnd || this.promptReroll)
      return;
    int price = this.bell.GetPrice();
    if (this.player.data.inventory.gold.Value - price < 0)
      return;
    SfxSystem.OneShot("event:/sfx/location/shop/buying");
    this.player.SpendGold(price);
    Events.InvokeShopItemPurchase(this.bell);
    this.Reroll();
    this.priceManager.Remove(this.bell);
  }

  public bool Reroll()
  {
    this.promptReroll = true;
    return true;
  }

  private IEnumerator RerollRoutine()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    EventRoutineGnomeShop routineGnomeShop = this;
    EventRoutineGnomeShop.Data shopData;
    Entity preCard;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      CardManager.ReturnToPool(preCard);
      routineGnomeShop.currentCard.flipper.FlipUp();
      shopData.price += shopData.priceAdd;
      routineGnomeShop.priceManager.Add(routineGnomeShop.bell, ShopPrice.Position.Bottom).SetPrice(shopData.price);
      InputSystem.Enable();
      routineGnomeShop.cardController.Enable();
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    routineGnomeShop.cardController.Disable();
    InputSystem.Disable();
    routineGnomeShop.currentCard.flipper.FlipDown();
    routineGnomeShop.currentCard.RemoveFromContainers();
    shopData = routineGnomeShop.data.Get<EventRoutineGnomeShop.Data>("data");
    string nextCard = routineGnomeShop.GetNextCard(shopData);
    preCard = routineGnomeShop.currentCard;
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) routineGnomeShop.CreateCard(nextCard);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  [Serializable]
  public class Data
  {
    public string[] pool;
    public List<string> cards;
    public int price;
    public int priceAdd;
    public int cyclesThroughPool;
  }
}
