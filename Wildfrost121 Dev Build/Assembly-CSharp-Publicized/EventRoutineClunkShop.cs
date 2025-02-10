// Decompiled with JetBrains decompiler
// Type: EventRoutineClunkShop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class EventRoutineClunkShop : EventRoutine
{
  [SerializeField]
  public CardController cardController;
  [SerializeField]
  public CardSelector cardSelector;
  [SerializeField]
  public ShopPriceManager priceManager;
  [SerializeField]
  public CardContainer[] cardContainers;
  [SerializeField]
  public CardCharmHolder[] charmHolders;
  [SerializeField]
  public GainCharmSequence gainCharmSequence;
  public ShopItem currentHover;
  public bool promptEnd;

  public void OnEnable()
  {
    global::Events.OnEntityHover += new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover += new UnityAction<Entity>(this.EntityUnHover);
  }

  public void OnDisable()
  {
    global::Events.OnEntityHover -= new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover -= new UnityAction<Entity>(this.EntityUnHover);
  }

  public void EntityHover(Entity entity)
  {
    ShopItem component = entity.GetComponent<ShopItem>();
    if (component == null)
      return;
    this.Hover(component);
  }

  public void EntityUnHover(Entity entity)
  {
    ShopItem component = entity.GetComponent<ShopItem>();
    if (component == null)
      return;
    this.UnHover(component);
  }

  public override IEnumerator Run()
  {
    EventRoutineClunkShop routineClunkShop = this;
    routineClunkShop.cardController.owner = routineClunkShop.player;
    routineClunkShop.cardSelector.character = routineClunkShop.player;
    routineClunkShop.cardController.enabled = true;
    routineClunkShop.cardSelector.enabled = true;
    while (!routineClunkShop.promptEnd)
      yield return (object) null;
    routineClunkShop.promptEnd = false;
    routineClunkShop.cardController.enabled = false;
    routineClunkShop.cardSelector.enabled = false;
  }

  public override IEnumerator Populate()
  {
    EventRoutineClunkShop routineClunkShop1 = this;
    CinemaBarSystem.Clear();
    routineClunkShop1.UnPopulate();
    EventRoutineClunkShop.Data shopData = routineClunkShop1.data.Get<EventRoutineClunkShop.Data>("shopData");
    int cardCount = shopData.cards.Count;
    for (int i = 0; i < cardCount; ++i)
    {
      EventRoutineClunkShop.CardItem item = shopData.cards[i];
      if (!item.purchased)
      {
        CardContainer container = routineClunkShop1.cardContainers.Length > i ? routineClunkShop1.cardContainers[i] : (CardContainer) null;
        if ((bool) (UnityEngine.Object) container)
        {
          container.SetSize(1, 0.67f);
          Card card = CardManager.Get(AddressableLoader.Get<CardData>("CardData", item.dataName).Clone(), routineClunkShop1.cardController, routineClunkShop1.player, false, true);
          yield return (object) card.UpdateData(false);
          container.Add(card.entity);
          container.SetChildPositions();
          ShopItem target = card.gameObject.AddComponent<ShopItem>();
          routineClunkShop1.priceManager.Add(target, ShopPrice.Position.Bottom).SetPrice(item.price, item.priceFactor);
          container = (CardContainer) null;
          card = (Card) null;
        }
        else
          break;
      }
      item = (EventRoutineClunkShop.CardItem) null;
    }
    int count = shopData.charms.Count;
    for (int index = 0; index < count; ++index)
    {
      EventRoutineClunkShop.CharmItem charm1 = shopData.charms[index];
      if (!charm1.purchased)
      {
        EventRoutineClunkShop routineClunkShop = routineClunkShop1;
        CardCharmHolder charmHolder = routineClunkShop1.charmHolders.Length > index ? routineClunkShop1.charmHolders[index] : (CardCharmHolder) null;
        if ((UnityEngine.Object) charmHolder == (UnityEngine.Object) null)
          break;
        CardUpgradeData upgradeData = AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", charm1.dataName).Clone();
        UpgradeDisplay charm = charmHolder.Create(upgradeData);
        charmHolder.SetPositions();
        ShopItem shopItem = charm.gameObject.AddComponent<ShopItem>();
        CardCharmInteraction orAdd = charm.gameObject.GetOrAdd<CardCharmInteraction>();
        orAdd.canHover = true;
        orAdd.canDrag = true;
        orAdd.onHover.AddListener((UnityAction<UpgradeDisplay>) (a => routineClunkShop.Hover(shopItem)));
        orAdd.onUnHover.AddListener((UnityAction<UpgradeDisplay>) (a => routineClunkShop.UnHover(shopItem)));
        orAdd.onDrag.AddListener((UnityAction<UpgradeDisplay>) (a => routineClunkShop.TryBuyCharm(charm as CardCharm)));
        orAdd.popUpOffset = new Vector2(0.8f, -0.3f);
        routineClunkShop1.priceManager.Add(shopItem, ShopPrice.Position.Top).SetPrice(charm1.price, charm1.priceFactor);
      }
    }
  }

  public void UnPopulate()
  {
    foreach (CardContainer cardContainer in this.cardContainers)
    {
      cardContainer.DestroyAll();
      cardContainer.Clear();
    }
    foreach (UpgradeHolder charmHolder in this.charmHolders)
      charmHolder.Clear();
    this.priceManager.Clear();
  }

  public bool TryBuy(ShopItem item)
  {
    bool flag = false;
    int price = item.GetPrice();
    if (this.player.data.inventory.gold >= price)
    {
      SfxSystem.OneShot("event:/sfx/location/shop/buying");
      this.priceManager.Remove(item);
      this.player.SpendGold(price);
      global::Events.InvokeShopItemPurchase(item);
      flag = true;
    }
    return flag;
  }

  public void TryBuy(Entity entity)
  {
    ShopItem component = entity.GetComponent<ShopItem>();
    if (component == null || !this.TryBuy(component))
      return;
    this.data.Get<EventRoutineClunkShop.Data>("shopData").cards.Find((Predicate<EventRoutineClunkShop.CardItem>) (a => a.dataName == entity.data.name)).purchased = true;
    this.cardSelector.TakeCard(entity);
  }

  public void TryBuyCharm(CardCharm charm)
  {
    ShopItem component = charm.GetComponent<ShopItem>();
    if (component == null || !this.TryBuy(component))
      return;
    this.data.Get<EventRoutineClunkShop.Data>("shopData").charms.Find((Predicate<EventRoutineClunkShop.CharmItem>) (a => a.dataName == charm.data.name)).purchased = true;
    this.gainCharmSequence.SetCharacter(this.player);
    this.gainCharmSequence.SetCharm(charm.data);
    this.gainCharmSequence.Begin();
    charm.gameObject.Destroy();
  }

  public void Hover(ShopItem item)
  {
    if (this.player.entity.display is CharacterDisplay display && (UnityEngine.Object) display.goldDisplay != (UnityEngine.Object) null && (UnityEngine.Object) this.priceManager.Get(item) != (UnityEngine.Object) null)
    {
      int price = item.GetPrice();
      if (price <= this.player.data.inventory.gold)
      {
        this.currentHover = item;
        display.goldDisplay.ShowChange(-price);
      }
    }
    global::Events.InvokeShopItemHover(item);
  }

  public void UnHover(ShopItem item)
  {
    if (!((UnityEngine.Object) this.currentHover == (UnityEngine.Object) item))
      return;
    if (this.player.entity.display is CharacterDisplay display && (UnityEngine.Object) display.goldDisplay != (UnityEngine.Object) null)
      display.goldDisplay.HideChange();
    this.currentHover = (ShopItem) null;
    global::Events.InvokeShopItemUnHover(item);
  }

  public void End()
  {
    this.promptEnd = true;
    this.cardController.enabled = false;
  }

  [Serializable]
  public class Data
  {
    public List<EventRoutineClunkShop.CardItem> cards = new List<EventRoutineClunkShop.CardItem>();
    public List<EventRoutineClunkShop.CharmItem> charms = new List<EventRoutineClunkShop.CharmItem>();
  }

  [Serializable]
  public abstract class Item
  {
    public int price;
    public float priceFactor = 1f;
    public bool purchased;
  }

  [Serializable]
  public class CardItem : EventRoutineClunkShop.Item
  {
    public string dataName;

    public CardItem()
    {
    }

    public CardItem(CardData cardData, float priceFactor = 1f)
    {
      this.dataName = cardData.name;
      this.price = Mathf.RoundToInt((float) cardData.value * priceFactor);
    }
  }

  [Serializable]
  public class CharmItem : EventRoutineClunkShop.Item
  {
    public string dataName;

    public CharmItem()
    {
    }

    public CharmItem(string upgradeDataName, int price, float priceFactor = 1f)
    {
      this.dataName = upgradeDataName;
      this.price = price;
      price = Mathf.RoundToInt((float) price * priceFactor);
    }
  }
}
