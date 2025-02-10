// Decompiled with JetBrains decompiler
// Type: ShopRoutine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using FMODUnity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Localization;

public class ShopRoutine : EventRoutine
{
  [SerializeField]
  public CardController cardController;
  [SerializeField]
  public CardSelector cardSelector;
  [SerializeField]
  public float cardContainerRandomAngle = 2f;
  [SerializeField]
  public ShopPriceManager priceManager;
  [SerializeField]
  public UnityEngine.Animator animator;
  [SerializeField]
  public LocalizedString enterKey;
  [SerializeField]
  public string brokenVaseCardName = "BrokenVase";
  [Header("Card Containers")]
  [SerializeField]
  public ShopRoutine.Container[] containers;
  [Header("Charms")]
  [SerializeField]
  public CharmMachine charmMachine;
  [SerializeField]
  public OpenCharmBlockSequence openSequence;
  [SerializeField]
  public Transform charmBlock;
  [Header("Crown")]
  [SerializeField]
  public CrownHolderShop crownHolder;
  [SerializeField]
  public GainCrownSequence gainCrownSequence;
  [Header("Speech Bubs")]
  [SerializeField]
  public Talker talker;
  [SerializeField]
  public Vector2 sayDelay = new Vector2(0.8f, 1f);
  [SerializeField]
  public float speechBubDelay = 1f;
  [Header("Music")]
  [SerializeField]
  public EventReference music;
  [SerializeField]
  public SfxLoop ovenCrackleLoop;
  public bool open;
  public bool promptOpen;
  public bool promptClose;
  public bool promptEnd;
  public bool promptBuyCharm;
  public bool promptBuyCrown;
  public bool endWhenClosed = true;
  public List<Entity> entities;
  public ShopItem currentHover;
  public float speechBubTimer;
  public int secretCount;
  public ShopItem secretClick;
  public int secretClickCount;

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

  public void Update()
  {
    if ((double) this.speechBubTimer <= 0.0)
      return;
    this.speechBubTimer -= Time.deltaTime;
  }

  public override IEnumerator Run()
  {
    ShopRoutine shopRoutine = this;
    shopRoutine.secretCount = UnityEngine.Random.Range(7, 10);
    CinemaBarSystem.Top.SetPrompt(shopRoutine.enterKey.GetLocalizedString(), "Select");
    MusicSystem.StopMusic();
    MusicSystem.StartMusic(shopRoutine.music);
    MusicSystem.SetParam("shop_enter", 0.0f);
    shopRoutine.cardController.owner = shopRoutine.player;
    shopRoutine.cardSelector.character = shopRoutine.player;
    while (!shopRoutine.promptEnd)
    {
      if (shopRoutine.promptBuyCharm)
        yield return (object) shopRoutine.BuyCharmRoutine();
      else if (shopRoutine.promptBuyCrown)
        yield return (object) shopRoutine.BuyCrownRoutine();
      else if (!shopRoutine.open && shopRoutine.promptOpen)
      {
        yield return (object) shopRoutine.OpenRoutine();
        shopRoutine.ovenCrackleLoop.Play();
      }
      else if (shopRoutine.open && shopRoutine.promptClose)
      {
        yield return (object) shopRoutine.CloseRoutine();
        if (shopRoutine.endWhenClosed)
          shopRoutine.End();
      }
      else
        yield return (object) null;
    }
    shopRoutine.promptEnd = false;
    shopRoutine.ovenCrackleLoop.Stop();
    shopRoutine.cardController.enabled = false;
    shopRoutine.cardSelector.enabled = false;
    if (shopRoutine.player.entity.display is CharacterDisplay display && (bool) (UnityEngine.Object) display.goldDisplay)
      display.goldDisplay.HideChange();
  }

  public void Bub(string speechType, params object[] inserts)
  {
    if ((double) this.speechBubTimer > 0.0)
      return;
    this.talker.Say(speechType, 0.0f, inserts);
    this.speechBubTimer = this.speechBubDelay;
  }

  public void Open(BaseEventData eventData)
  {
    if (eventData is PointerEventData pointerEventData && pointerEventData.button != PointerEventData.InputButton.Left || this.open || this.promptOpen)
      return;
    this.promptOpen = true;
  }

  public void Close()
  {
    if (!this.open || this.promptClose)
      return;
    this.promptClose = true;
  }

  public IEnumerator OpenRoutine()
  {
    ShopRoutine shopRoutine = this;
    SfxSystem.OneShot("event:/sfx/location/shop/visit");
    shopRoutine.animator.SetBool("Zoom", true);
    shopRoutine.promptOpen = false;
    shopRoutine.open = true;
    int valueOrDefault = (int) shopRoutine.data.GetValueOrDefault<string, object>("openCount", (object) 0);
    if (valueOrDefault <= 0)
    {
      float delay = shopRoutine.sayDelay.Random() - 0.5f;
      if (shopRoutine.data.Get<ShopRoutine.Data>("shopData").items.Count<ShopRoutine.Item>(new Func<ShopRoutine.Item, bool>(shopRoutine.\u003COpenRoutine\u003Eb__40_0)) > 0)
      {
        shopRoutine.talker.Say("broken vase", delay);
        shopRoutine.talker.Say("broken vase price", delay + 1f);
      }
      else
      {
        shopRoutine.talker.Say("greet1", delay);
        shopRoutine.talker.Say("greet2", delay + 1f);
      }
      shopRoutine.speechBubTimer = shopRoutine.speechBubDelay;
      foreach (ShopRoutine.Container container in shopRoutine.containers)
      {
        foreach (Entity entity in container.container)
          global::Events.InvokeEntityOffered(entity);
      }
    }
    shopRoutine.data["openCount"] = (object) (valueOrDefault + 1);
    yield return (object) new WaitForSeconds(0.5f);
    yield return (object) ShopRoutine.AdjustMusicToInside(0.5f);
  }

  public IEnumerator CloseRoutine()
  {
    this.animator.SetBool("Zoom", false);
    this.promptClose = false;
    this.open = false;
    yield return (object) null;
  }

  public static IEnumerator AdjustMusicToInside(float totalTime)
  {
    float v = 0.0f;
    float add = 1f / totalTime;
    while ((double) v < 1.0)
    {
      v += Time.deltaTime * add;
      MusicSystem.SetParam("shop_enter", v);
      AmbienceSystem.SetParam("shop_enter", v);
      yield return (object) null;
    }
  }

  public void End() => this.promptEnd = true;

  public void TryBuy(Entity entity)
  {
    ShopItem component = entity.GetComponent<ShopItem>();
    if (component == null)
      return;
    int price = component.GetPrice();
    int goldDiff = this.player.data.inventory.gold.Value - price;
    if (goldDiff >= 0)
    {
      this.Bub("thanks");
      SfxSystem.OneShot("event:/sfx/location/shop/buying");
      this.priceManager.Remove(component);
      this.player.SpendGold(price);
      this.cardSelector.TakeCard(entity);
      this.data.Get<ShopRoutine.Data>("shopData").items.Find((Predicate<ShopRoutine.Item>) (a => a.cardDataName == entity.data.name)).purchased = true;
      global::Events.InvokeShopItemPurchase(component);
    }
    else if (this.SecretCheck(goldDiff, component))
      this.TryBuy(entity);
    else
      this.Bub("not enough gold");
  }

  public void TryBuyCharm(BaseEventData eventData)
  {
    if (eventData is PointerEventData pointerEventData && pointerEventData.button != PointerEventData.InputButton.Left)
      return;
    ShopRoutine.Data data = this.data.Get<ShopRoutine.Data>("shopData");
    if (data.charms.Count <= 0)
      return;
    int goldDiff = this.player.data.inventory.gold.Value - data.charmPrice;
    if (goldDiff >= 0)
    {
      if (!this.charmMachine.CanRun())
        return;
      this.Bub("thanks");
      this.promptBuyCharm = true;
    }
    else if (this.SecretCheck(goldDiff, this.charmMachine.GetComponent<ShopItem>()))
      this.TryBuyCharm(eventData);
    else
      this.Bub("not enough gold");
  }

  public void TryBuyCrown(BaseEventData eventData)
  {
    if (eventData is PointerEventData pointerEventData && pointerEventData.button != PointerEventData.InputButton.Left)
      return;
    ShopRoutine.Data shopData = this.data.Get<ShopRoutine.Data>("shopData");
    if (!shopData.hasCrown)
      return;
    int goldDiff = this.player.data.inventory.gold.Value - ShopRoutine.GetCrownPrice(shopData);
    if (goldDiff >= 0)
    {
      if (!this.crownHolder.CanTake())
        return;
      this.Bub("thanks");
      this.promptBuyCrown = true;
    }
    else if (this.SecretCheck(goldDiff, this.crownHolder.GetComponent<ShopItem>()))
      this.TryBuyCrown(eventData);
    else
      this.Bub("not enough gold");
  }

  public bool SecretCheck(int goldDiff, ShopItem item)
  {
    if (goldDiff == -1)
    {
      if ((UnityEngine.Object) this.secretClick != (UnityEngine.Object) item)
      {
        this.secretClick = item;
        this.secretClickCount = 1;
      }
      else if (++this.secretClickCount >= this.secretCount)
      {
        this.speechBubTimer = 0.0f;
        this.Bub("secret", (object) (item.GetPrice() - 1));
        ++this.player.data.inventory.gold.Value;
        this.secretClick = (ShopItem) null;
        return true;
      }
    }
    return false;
  }

  public IEnumerator BuyCharmRoutine()
  {
    ShopRoutine shopRoutine = this;
    shopRoutine.promptBuyCharm = false;
    SfxSystem.OneShot("event:/sfx/location/shop/buying");
    ShopRoutine.Data shopData = shopRoutine.data.Get<ShopRoutine.Data>("shopData");
    shopRoutine.cardController.enabled = false;
    shopRoutine.crownHolder.enabled = false;
    shopRoutine.charmMachine.enabled = false;
    shopRoutine.player.SpendGold(shopData.charmPrice);
    string c = shopData.charms[0];
    ShopItem item = shopRoutine.charmMachine.GetComponent<ShopItem>();
    shopRoutine.priceManager.Remove(item);
    yield return (object) shopRoutine.charmMachine.Run();
    shopData.charms.RemoveAt(0);
    shopData.charmPrice += shopData.charmPriceAdd;
    CardUpgradeData charmData = AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", c).Clone();
    shopRoutine.openSequence.SetCharm(charmData, shopRoutine.charmBlock);
    shopRoutine.openSequence.SetCharacter(shopRoutine.player);
    yield return (object) shopRoutine.openSequence.Run();
    if (shopData.charms.Count > 0)
    {
      shopRoutine.charmMachine.enabled = true;
      shopRoutine.CreateCharmPrice();
    }
    shopRoutine.cardController.enabled = true;
    shopRoutine.crownHolder.enabled = true;
    global::Events.InvokeShopItemPurchase(item);
  }

  public IEnumerator BuyCrownRoutine()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    ShopRoutine shopRoutine = this;
    ShopItem item;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      global::Events.InvokeShopItemPurchase(item);
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    shopRoutine.promptBuyCrown = false;
    ShopRoutine.Data shopData = shopRoutine.data.Get<ShopRoutine.Data>("shopData");
    SfxSystem.OneShot("event:/sfx/location/shop/buying");
    shopRoutine.player.SpendGold(ShopRoutine.GetCrownPrice(shopData));
    shopRoutine.crownHolder.TakeCrown();
    shopData.hasCrown = false;
    item = shopRoutine.crownHolder.GetComponent<ShopItem>();
    shopRoutine.priceManager.Remove(item);
    shopRoutine.gainCrownSequence.SetData(shopRoutine.crownHolder.GetCrownData().Clone());
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) shopRoutine.gainCrownSequence.Run();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
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

  public override IEnumerator Populate()
  {
    ShopRoutine shopRoutine = this;
    yield return (object) shopRoutine.UnPopulate();
    ShopRoutine.Data shopData = shopRoutine.data.Get<ShopRoutine.Data>("shopData");
    shopRoutine.entities = new List<Entity>();
    ShopRoutine.Container[] containerArray = shopRoutine.containers;
    for (int index = 0; index < containerArray.Length; ++index)
    {
      ShopRoutine.Container c = containerArray[index];
      List<ShopRoutine.Item> all = shopData.items.FindAll((Predicate<ShopRoutine.Item>) (a => a.category == c.category));
      c.container.SetSize(all.Count, c.cardScale);
      CardContainer container = c.container;
      container.owner = shopRoutine.player;
      container.transform.localEulerAngles = container.transform.localEulerAngles.WithZ(PettyRandom.Range(-shopRoutine.cardContainerRandomAngle, shopRoutine.cardContainerRandomAngle));
      foreach (ShopRoutine.Item item in all)
      {
        CardData cardDataClone = AddressableLoader.GetCardDataClone(item.cardDataName);
        int index1 = shopData.items.IndexOf(item);
        if (shopData.upgrades.Count > index1)
        {
          string[] upgrade = shopData.upgrades[index1];
          if (upgrade != null)
          {
            foreach (string assetName in upgrade)
              AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", assetName).Clone().Assign(cardDataClone);
          }
        }
        Card card = CardManager.Get(cardDataClone, shopRoutine.cardController, shopRoutine.player, false, true);
        yield return (object) card.UpdateData(false);
        container.Add(card.entity);
        shopRoutine.entities.Add(card.entity);
        ShopItem target = card.entity.gameObject.AddComponent<ShopItem>();
        shopRoutine.priceManager.Add(target, c.pricePosition).SetPrice(item.price, item.priceFactor);
        card = (Card) null;
      }
      foreach (Entity child in container)
      {
        Transform transform = child.transform;
        transform.localPosition = container.GetChildPosition(child);
        transform.localScale = container.GetChildScale(child);
        transform.localEulerAngles = container.GetChildRotation(child);
      }
      container = (CardContainer) null;
    }
    containerArray = (ShopRoutine.Container[]) null;
    foreach (ShopRoutine.Item obj in shopData.items)
    {
      ShopRoutine.Item item = obj;
      if (item.purchased)
      {
        Entity entity = shopRoutine.entities.Find((Predicate<Entity>) (a => a.data.name == item.cardDataName));
        if ((bool) (UnityEngine.Object) entity)
        {
          shopRoutine.priceManager.Remove(entity.GetComponent<ShopItem>());
          entity.RemoveFromContainers();
          CardManager.ReturnToPool(entity);
        }
      }
    }
    if ((bool) (UnityEngine.Object) shopRoutine.charmMachine && shopData.charms.Count <= 0)
      shopRoutine.charmMachine.enabled = false;
    else
      shopRoutine.CreateCharmPrice();
    if ((bool) (UnityEngine.Object) shopRoutine.crownHolder && !shopData.hasCrown)
    {
      shopRoutine.crownHolder.TakeCrown();
    }
    else
    {
      CardUpgradeData crownData = AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", shopData.crownType.IsNullOrWhitespace() ? "Crown" : shopData.crownType);
      if ((bool) (UnityEngine.Object) crownData)
        shopRoutine.crownHolder.SetCrownData(crownData);
      shopRoutine.CreateCrownPrice();
    }
  }

  public void CreateCharmPrice()
  {
    ShopRoutine.Data data = this.data.Get<ShopRoutine.Data>("shopData");
    if (!((UnityEngine.Object) this.charmMachine != (UnityEngine.Object) null) || data.charms.Count <= 0)
      return;
    ShopPrice shopPrice = this.priceManager.Add(this.charmMachine.GetComponent<ShopItem>(), ShopPrice.Position.Bottom);
    shopPrice.SetPrice(data.charmPrice);
    shopPrice.SetOffset(new Vector3(0.0f, -0.33f, 0.0f));
    shopPrice.scaleWithTarget = 0.0f;
    shopPrice.scaleOffsetWithTarget = 0.0f;
  }

  public void CreateCrownPrice()
  {
    ShopRoutine.Data shopData = this.data.Get<ShopRoutine.Data>("shopData");
    if (!((UnityEngine.Object) this.crownHolder != (UnityEngine.Object) null) || !shopData.hasCrown)
      return;
    ShopPrice shopPrice = this.priceManager.Add(this.crownHolder.GetComponent<ShopItem>(), ShopPrice.Position.Bottom);
    shopPrice.SetPrice(ShopRoutine.GetCrownPrice(shopData));
    shopPrice.SetOffset(new Vector3(0.0f, -0.3f, 0.0f));
    shopPrice.scaleWithTarget = 0.0f;
    shopPrice.scaleOffsetWithTarget = 0.0f;
  }

  public static int GetCrownPrice(ShopRoutine.Data shopData) => shopData.crownPrice + shopData.crownPriceAdd * StatsSystem.Get().Get("shopItemsBought", "crown", 0);

  public IEnumerator UnPopulate()
  {
    List<Entity> entityList = new List<Entity>();
    foreach (ShopRoutine.Container container in this.containers)
    {
      foreach (Entity entity in container.container)
        entityList.Add(entity);
      container.container.Clear();
    }
    foreach (Entity entity in entityList)
      CardManager.ReturnToPool(entity);
    this.priceManager.Clear();
    yield return (object) null;
  }

  [CompilerGenerated]
  public bool \u003COpenRoutine\u003Eb__40_0(ShopRoutine.Item a) => a.cardDataName == this.brokenVaseCardName;

  [Serializable]
  public class Data : ICloneable
  {
    public List<ShopRoutine.Item> items = new List<ShopRoutine.Item>();
    public List<string[]> upgrades = new List<string[]>();
    public List<string> charms = new List<string>();
    public int charmPrice = 50;
    public int charmPriceAdd = 20;
    public bool hasCrown = true;
    public string crownType;
    public int crownPrice = 120;
    public int crownPriceAdd = 30;
    public int openCount;

    public object Clone() => (object) new ShopRoutine.Data()
    {
      items = this.items.Select<ShopRoutine.Item, ShopRoutine.Item>((Func<ShopRoutine.Item, ShopRoutine.Item>) (a => (ShopRoutine.Item) a.Clone())).ToList<ShopRoutine.Item>(),
      upgrades = this.upgrades.Clone<string[]>(),
      charms = this.charms.Clone<string>(),
      charmPrice = this.charmPrice,
      charmPriceAdd = this.charmPriceAdd,
      hasCrown = this.hasCrown,
      crownType = this.crownType,
      crownPrice = this.crownPrice,
      crownPriceAdd = this.crownPriceAdd,
      openCount = this.openCount
    };
  }

  [Serializable]
  public class Item : ICloneable
  {
    public string category;
    public string cardDataName;
    public int price;
    public float priceFactor = 1f;
    public bool purchased;

    public Item()
    {
    }

    public Item(string category, CardData cardData, int priceOffset, float priceFactor = 1f)
    {
      this.category = category;
      this.cardDataName = cardData.name;
      this.price = Mathf.RoundToInt((float) cardData.value * priceFactor) + priceOffset;
    }

    public object Clone() => (object) new ShopRoutine.Item()
    {
      category = this.category,
      cardDataName = this.cardDataName,
      price = this.price,
      priceFactor = this.priceFactor,
      purchased = this.purchased
    };
  }

  [Serializable]
  public struct Container
  {
    public string category;
    public CardContainer container;
    public float cardScale;
    public ShopPrice.Position pricePosition;
  }
}
