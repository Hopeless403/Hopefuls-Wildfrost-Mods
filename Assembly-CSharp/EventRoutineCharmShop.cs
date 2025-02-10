// Decompiled with JetBrains decompiler
// Type: EventRoutineCharmShop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class EventRoutineCharmShop : EventRoutine
{
  [SerializeField]
  private ShopPriceManager priceManager;
  [SerializeField]
  private CardController cardController;
  [SerializeField]
  private CardContainer cardContainer;
  [SerializeField]
  private CardSelector cardSelector;
  [SerializeField]
  private CardCharmHolder[] holders;
  [SerializeField]
  private GainCharmSequence gainCharmSequence;
  [SerializeField]
  private Talker talker;
  private const float speechBubDelay = 1f;
  private float speechBubTimer;
  private ShopItem currentHover;
  private readonly List<ShopItem> items = new List<ShopItem>();
  private bool promptEnd;

  public void PromptEnd() => this.promptEnd = true;

  private void OnEnable()
  {
    global::Events.OnEntityHover += new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover += new UnityAction<Entity>(this.EntityUnHover);
  }

  private void OnDisable()
  {
    global::Events.OnEntityHover -= new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover -= new UnityAction<Entity>(this.EntityUnHover);
  }

  private void EntityHover(Entity entity)
  {
    ShopItem component = entity.GetComponent<ShopItem>();
    if (component == null)
      return;
    this.Hover(component);
  }

  private void EntityUnHover(Entity entity)
  {
    ShopItem component = entity.GetComponent<ShopItem>();
    if (component == null)
      return;
    this.UnHover(component);
  }

  private void Update()
  {
    if ((double) this.speechBubTimer <= 0.0)
      return;
    this.speechBubTimer -= Time.deltaTime;
  }

  public override IEnumerator Populate()
  {
    EventRoutineCharmShop routineCharmShop = this;
    EventRoutineCharmShop.Data shopData = routineCharmShop.data.Get<EventRoutineCharmShop.Data>("data");
    routineCharmShop.cardContainer.SetSize(shopData.cards.Count, 0.8f);
    foreach (EventRoutineCharmShop.UpgradedCard card1 in shopData.cards)
    {
      CardData cardData = AddressableLoader.Get<CardData>("CardData", card1.cardDataName).Clone();
      if (card1.upgradeNames != null)
      {
        foreach (string upgradeName in card1.upgradeNames)
          AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", upgradeName).Clone().Assign(cardData);
      }
      Card card2 = CardManager.Get(cardData, routineCharmShop.cardController, routineCharmShop.player, false, true);
      routineCharmShop.cardContainer.Add(card2.entity);
      ShopItem target = card2.entity.gameObject.AddComponent<ShopItem>();
      routineCharmShop.priceManager.Add(target, ShopPrice.Position.Bottom).SetPrice(card1.price, card1.priceFactor);
      yield return (object) card2.UpdateData(false);
    }
    routineCharmShop.cardContainer.SetChildPositions();
    foreach (EventRoutineCharmShop.CharmShopItemData charmShopItemData in shopData.items)
    {
      CardUpgradeData upgradeDataClone = AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", charmShopItemData.upgradeDataName).Clone();
      routineCharmShop.CreateUpgrade(upgradeDataClone, charmShopItemData.price, charmShopItemData.priceFactor);
    }
    foreach (EventRoutineCharmShop.UpgradedCard card3 in shopData.cards)
    {
      EventRoutineCharmShop.UpgradedCard card = card3;
      if (card.purchased)
      {
        Entity entity = routineCharmShop.cardContainer.First<Entity>((Func<Entity, bool>) (a => a.data.name == card.cardDataName));
        if ((bool) (UnityEngine.Object) entity)
        {
          routineCharmShop.priceManager.Remove(entity.GetComponent<ShopItem>());
          entity.RemoveFromContainers();
          CardManager.ReturnToPool(entity);
        }
      }
    }
    for (int index = 0; index < routineCharmShop.items.Count; ++index)
    {
      if (shopData.items[index].purchased)
        routineCharmShop.items[index].gameObject.Destroy();
    }
  }

  public override IEnumerator Run()
  {
    EventRoutineCharmShop routineCharmShop = this;
    int num = routineCharmShop.data.Get<int>("enterCount", 0) + 1;
    routineCharmShop.data["enterCount"] = (object) num;
    if (num == 1)
    {
      routineCharmShop.talker.Say("greet", PettyRandom.Range(0.5f, 1f));
      foreach (Entity entity in routineCharmShop.cardContainer)
        global::Events.InvokeEntityOffered(entity);
    }
    routineCharmShop.cardController.owner = routineCharmShop.player;
    routineCharmShop.cardContainer.owner = routineCharmShop.player;
    routineCharmShop.cardSelector.character = routineCharmShop.player;
    while (!routineCharmShop.promptEnd)
      yield return (object) null;
    if (routineCharmShop.data.Get<EventRoutineCharmShop.Data>("data").items.Count<EventRoutineCharmShop.CharmShopItemData>((Func<EventRoutineCharmShop.CharmShopItemData, bool>) (i => !i.purchased)) <= 0)
      routineCharmShop.node.SetCleared();
    routineCharmShop.cardController.enabled = false;
    routineCharmShop.cardSelector.enabled = false;
    foreach (ShopItem shopItem in routineCharmShop.items)
    {
      if ((bool) (UnityEngine.Object) shopItem)
      {
        CardCharmInteraction component = shopItem.GetComponent<CardCharmInteraction>();
        if (component != null)
        {
          component.canHover = false;
          component.canDrag = false;
        }
      }
    }
    if (routineCharmShop.player.entity.display is CharacterDisplay display && (bool) (UnityEngine.Object) display.goldDisplay)
      display.goldDisplay.HideChange();
  }

  private void Bub(string speechType, params object[] inserts)
  {
    if ((double) this.speechBubTimer > 0.0)
      return;
    this.talker.Say(speechType, 0.0f, inserts);
    this.speechBubTimer = 1f;
  }

  public void TryBuy(Entity entity)
  {
    ShopItem component = entity.GetComponent<ShopItem>();
    if (component == null)
      return;
    int price = component.GetPrice();
    if (this.player.data.inventory.gold.Value - price >= 0)
    {
      SfxSystem.OneShot("event:/sfx/location/shop/buying");
      this.priceManager.Remove(component);
      this.player.SpendGold(price);
      this.cardSelector.TakeCard(entity);
      this.data.Get<EventRoutineCharmShop.Data>("data").cards.Find((Predicate<EventRoutineCharmShop.UpgradedCard>) (a => a.cardDataName == entity.data.name)).purchased = true;
      global::Events.InvokeShopItemPurchase(component);
      this.talker.Say("thanks", 0.0f);
    }
    else
      this.Bub("no");
  }

  public void TryBuy(ShopItem item)
  {
    int price = item.GetPrice();
    if (this.player.data.inventory.gold.Value - price >= 0)
    {
      int index = this.items.IndexOf(item);
      SfxSystem.OneShot("event:/sfx/location/shop/buying");
      this.player.SpendGold(price);
      this.priceManager.Remove(item);
      UpgradeDisplay componentInChildren = this.holders[index].GetComponentInChildren<UpgradeDisplay>();
      if (componentInChildren == null)
        return;
      componentInChildren.gameObject.Destroy();
      this.data.Get<EventRoutineCharmShop.Data>("data").items[index].purchased = true;
      this.gainCharmSequence.SetCharm(componentInChildren.data);
      this.gainCharmSequence.SetCharacter(this.player);
      this.StartCoroutine(this.gainCharmSequence.Run());
      global::Events.InvokeShopItemPurchase(item);
      this.talker.Say("thanks", 0.0f);
    }
    else
      this.Bub("no");
  }

  public void Hover(ShopItem item)
  {
    if ((bool) (UnityEngine.Object) this.currentHover)
      this.UnHover(this.currentHover);
    this.currentHover = item;
    if (this.player.entity.display is CharacterDisplay display && (bool) (UnityEngine.Object) display.goldDisplay && (bool) (UnityEngine.Object) this.priceManager.Get(item))
    {
      int price = item.GetPrice();
      if (price <= this.player.data.inventory.gold)
        display.goldDisplay.ShowChange(-price);
    }
    global::Events.InvokeShopItemHover(item);
  }

  public void UnHover(ShopItem item)
  {
    if (!((UnityEngine.Object) this.currentHover == (UnityEngine.Object) item))
      return;
    this.currentHover = (ShopItem) null;
    if (this.player.entity.display is CharacterDisplay display && (bool) (UnityEngine.Object) display.goldDisplay)
      display.goldDisplay.HideChange();
    global::Events.InvokeShopItemUnHover(item);
  }

  private void CreateUpgrade(CardUpgradeData upgradeDataClone, int price, float priceFactor)
  {
    CardCharmHolder cardCharmHolder = ((IEnumerable<CardCharmHolder>) this.holders).FirstOrDefault<CardCharmHolder>((Func<CardCharmHolder, bool>) (a => a.transform.childCount == 0));
    if (!(bool) (UnityEngine.Object) cardCharmHolder)
      return;
    UpgradeDisplay upgradeDisplay = cardCharmHolder.Create(upgradeDataClone);
    ShopItem shopItem = upgradeDisplay.gameObject.AddComponent<ShopItem>();
    this.items.Add(shopItem);
    ShopPrice shopPrice = this.priceManager.Add(shopItem, ShopPrice.Position.Bottom);
    shopPrice.SetPrice(price, priceFactor);
    shopPrice.SetOffset(new Vector3(0.0f, -1.5f, 0.0f));
    shopPrice.scaleWithTarget = 0.0f;
    shopPrice.scaleOffsetWithTarget = 0.0f;
    CardCharmInteraction component = upgradeDisplay.GetComponent<CardCharmInteraction>();
    component.popUpOffset = new Vector2(1f, -0.25f);
    component.onHover.AddListener((UnityAction<UpgradeDisplay>) (_ => this.Hover(shopItem)));
    component.onUnHover.AddListener((UnityAction<UpgradeDisplay>) (_ => this.UnHover(shopItem)));
    component.onDrag.AddListener((UnityAction<UpgradeDisplay>) (_ => this.TryBuy(shopItem)));
  }

  [Serializable]
  public class Data
  {
    public List<EventRoutineCharmShop.UpgradedCard> cards;
    public List<EventRoutineCharmShop.CharmShopItemData> items;
  }

  [Serializable]
  public class UpgradedCard
  {
    public string cardDataName;
    public string[] upgradeNames;
    public int price;
    public float priceFactor;
    public bool purchased;
  }

  [Serializable]
  public class CharmShopItemData
  {
    public string upgradeDataName;
    public int price;
    public float priceFactor;
    public bool purchased;

    public CharmShopItemData()
    {
    }

    public CharmShopItemData(string upgradeDataName, int price, float priceFactor = 1f)
    {
      this.upgradeDataName = upgradeDataName;
      this.price = Mathf.RoundToInt((float) price * priceFactor);
      this.priceFactor = priceFactor;
    }
  }
}
