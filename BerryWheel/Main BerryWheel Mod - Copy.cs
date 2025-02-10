using Dead;
using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace WildfrostHopeMod.BerryWheel
{
    public class CampaignNodeTypeBerryWheel : CampaignNodeTypeEvent
    {
        public int freeRolls = 1;
        public int maxRolls = 0;
        public int rollPrice = 50;
        public int rollPriceAdd = 50;

        public string[] forceCards;
        public int cardRewards = 1;

        public override IEnumerator SetUp(CampaignNode node)
        {
            yield return null;
            CharacterRewards rewards = References.Player.GetComponent<CharacterRewards>();
            EventRoutineBerryWheel.Data data = new()
            {
                freeRolls = this.freeRolls,
                maxRolls = this.maxRolls,
                rollPrice = this.rollPrice,
                rollPriceAdd = this.rollPriceAdd,
                cards = []
            };

            List<string> cardList = data.cards;
            if (forceCards != null && forceCards.Length > 0)
            {
                foreach (string forceCard in this.forceCards)
                {
                    CardData cardData = AddressableLoader.Get<CardData>("CardData", forceCard);
                    if (cardData == null)
                        continue;
                    cardList.Add(cardData.name);
                    rewards.PullOut("Items", cardData);
                }
            }
            int toAdd = cardRewards - cardList.Count;
            for (int index = 0; index < toAdd; ++index)
            {
                CardData card = rewards.Pull<CardData>(node, "Items");
                cardList.Add(card.name);
            }
            node.data = new(){ { "data", data } };
        }
        public override bool HasMissingData(CampaignNode node)
        {
            List<string> cardList = node.data.Get<List<string>>("cardList");
            return MissingCardSystem.HasMissingData(cardList);
        }
        public override IEnumerator Populate(CampaignNode node)
        {
            EventRoutineBerryWheel eventRoutine = UnityEngine.Object.FindObjectOfType<EventRoutineBerryWheel>();
            eventRoutine.node = node;
            yield return eventRoutine.Populate();
        }
        public override IEnumerator Run(CampaignNode node)
        {
            yield return Transition.To("Event");
            GameObject eventObject = GameObject.Instantiate(EventRoutineBerryWheel.routinePrefab, EventManager.EventRoutineHolder);
            EventRoutine eventRoutine = eventObject.GetComponent<EventRoutine>();
            Events.InvokeEventStart(node, eventRoutine);
            yield return this.Populate(node);
            Events.InvokeEventPopulated(eventRoutine);
            Transition.End();
            yield return eventRoutine.Run();
            yield return Transition.To("MapNew");
            Transition.End();
            yield return MapNew.CheckCompanionLimit();
        }
    }

    public class EventRoutineBerryWheel : EventRoutine, IRerollable
    {
        public static GameObject _routinePrefab;
        public static GameObject routinePrefab => _routinePrefab ?? InitPrefab();

        [SerializeField]
        public CardController cardController;
        [SerializeField]
        public CardContainer cardContainer;
        [SerializeField]
        public CardSelector cardSelector;


        [SerializeField]
        public Talker talker;
        public const float speechBubDelay = 1f;
        public float speechBubTimer;
        bool promptEnd;

        public static GameObject InitPrefab()
        {
            var prefab = AddressableLoader.Get("Event-Muncher");
            Debug.LogWarning("PREFAB FOUND? " + prefab);
            if (prefab)
                Search(prefab.transform, "");
            _routinePrefab = prefab;
            return _routinePrefab;
        }
        static void Search(Transform t, string path)
        {
            string newPath = Path.Combine(path, t.name);
            Debug.LogWarning(newPath);
            if (t.childCount == 0)
                return;
            t.GetAllChildren().Update(tt => Search(tt, newPath));
        }
        public void PromptEnd() => this.promptEnd = true;

        public void OnEnable()
        {
        }

        public void OnDisable()
        {
        }


        public void Update()
        {
            if (speechBubTimer <= 0)
                return;
            this.speechBubTimer -= Time.deltaTime;
        }

        public override IEnumerator Populate()
        {
            yield break;
            /*EventRoutineCharmShop.Data shopData = this.data.Get<EventRoutineCharmShop.Data>("data");
            this.cardContainer.SetSize(shopData.cards.Count, 0.8f);
            foreach (EventRoutineCharmShop.UpgradedCard card1 in shopData.cards)
            {
                CardData cardData = AddressableLoader.Get<CardData>("CardData", card1.cardDataName).Clone();
                if (card1.upgradeNames != null)
                {
                    foreach (string upgradeName in card1.upgradeNames)
                    {
                        CardUpgradeData cardUpgradeData = AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", upgradeName);
                        if ((bool)(UnityEngine.Object)cardUpgradeData)
                            cardUpgradeData.Clone().Assign(cardData);
                    }
                }
                Card card2 = CardManager.Get(cardData, this.cardController, this.player, false, true);
                this.cardContainer.Add(card2.entity);
                ShopItem target = card2.entity.gameObject.AddComponent<ShopItem>();
                this.priceManager.Add(target, ShopPrice.Position.Bottom).SetPrice(card1.price, card1.priceFactor);
                yield return card2.UpdateData(false);
            }
            this.cardContainer.SetChildPositions();
            foreach (EventRoutineCharmShop.CharmShopItemData charmShopItemData in shopData.items)
            {
                CardUpgradeData upgradeDataClone = AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", charmShopItemData.upgradeDataName).Clone();
                this.CreateUpgrade(upgradeDataClone, charmShopItemData.price, charmShopItemData.priceFactor);
            }
            foreach (EventRoutineCharmShop.UpgradedCard card3 in shopData.cards)
            {
                EventRoutineCharmShop.UpgradedCard card = card3;
                if (card.purchased)
                {
                    Entity entity = this.cardContainer.First<Entity>((Func<Entity, bool>)(a => a.data.name == card.cardDataName));
                    if ((bool)(UnityEngine.Object)entity)
                    {
                        this.priceManager.Remove(entity.GetComponent<ShopItem>());
                        entity.RemoveFromContainers();
                        CardManager.ReturnToPool(entity);
                    }
                }
            }
            for (int index = 0; index < this.items.Count; ++index)
            {
                if (shopData.items[index].purchased)
                    this.items[index].gameObject.Destroy();
            }*/
        }

        public override IEnumerator Run()
        {
            int num = this.data.Get<int>("enterCount", 0) + 1;
            this.data["enterCount"] = num;
            if (num == 1)
            {
                this.talker.Say("greet", PettyRandom.Range(0.5f, 1f));
                foreach (Entity entity in this.cardContainer)
                    global::Events.InvokeEntityOffered(entity);
            }
            this.cardController.owner = this.player;
            this.cardContainer.owner = this.player;
            this.cardSelector.character = this.player;
            while (!this.promptEnd)
                yield return null;
            if (this.data.Get<EventRoutineCharmShop.Data>("data").items.Count<EventRoutineCharmShop.CharmShopItemData>((Func<EventRoutineCharmShop.CharmShopItemData, bool>)(i => !i.purchased)) <= 0)
                this.node.SetCleared();
            this.cardController.enabled = false;
            this.cardSelector.enabled = false;
            foreach (ShopItem shopItem in this.items)
            {
                if ((bool)(UnityEngine.Object)shopItem)
                {
                    CardCharmInteraction component = shopItem.GetComponent<CardCharmInteraction>();
                    if (component != null)
                    {
                        component.canHover = false;
                        component.canDrag = false;
                    }
                }
            }
            if (this.player.entity.display is CharacterDisplay display && (bool)(UnityEngine.Object)display.goldDisplay)
                display.goldDisplay.HideChange();
        }

        public void Bub(string speechType, params object[] inserts)
        {
            if ((double)this.speechBubTimer > 0.0)
                return;
            this.talker.Say(speechType, 0.0f, inserts);
            this.speechBubTimer = 1f;
        }

        public void TryBuy(Entity entity)
        {
            if (Deckpack.IsOpen)
                return;
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
                this.data.Get<EventRoutineCharmShop.Data>("data").cards.Find((Predicate<EventRoutineCharmShop.UpgradedCard>)(a => a.cardDataName == entity.data.name)).purchased = true;
                global::Events.InvokeShopItemPurchase(component);
                this.talker.Say("thanks", 0.0f);
            }
            else
                this.Bub("no");
        }

        public void TryBuy(ShopItem item)
        {
            if (Deckpack.IsOpen)
                return;
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
            if ((bool)(UnityEngine.Object)this.currentHover)
                this.UnHover(this.currentHover);
            this.currentHover = item;
            if (this.player.entity.display is CharacterDisplay display && (bool)(UnityEngine.Object)display.goldDisplay && (bool)(UnityEngine.Object)this.priceManager.Get(item))
            {
                int price = item.GetPrice();
                if (price <= this.player.data.inventory.gold)
                    display.goldDisplay.ShowChange(-price);
            }
            global::Events.InvokeShopItemHover(item);
        }

        public void UnHover(ShopItem item)
        {
            if (!((UnityEngine.Object)this.currentHover == (UnityEngine.Object)item))
                return;
            this.currentHover = (ShopItem)null;
            if (this.player.entity.display is CharacterDisplay display && (bool)(UnityEngine.Object)display.goldDisplay)
                display.goldDisplay.HideChange();
            global::Events.InvokeShopItemUnHover(item);
        }

        public void CreateUpgrade(CardUpgradeData upgradeDataClone, int price, float priceFactor)
        {
            CardCharmHolder cardCharmHolder = ((IEnumerable<CardCharmHolder>)this.holders).FirstOrDefault<CardCharmHolder>((Func<CardCharmHolder, bool>)(a => a.transform.childCount == 0));
            if (!(bool)(UnityEngine.Object)cardCharmHolder)
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
            component.onHover.AddListener((UnityAction<UpgradeDisplay>)(_ => this.Hover(shopItem)));
            component.onUnHover.AddListener((UnityAction<UpgradeDisplay>)(_ => this.UnHover(shopItem)));
            component.onDrag.AddListener((UnityAction<UpgradeDisplay>)(_ => this.TryBuy(shopItem)));
        }

        bool IRerollable.Reroll()
        {
            throw new NotImplementedException();
        }


        public struct Data
        {
            public List<string> cards;
            public int freeRolls;
            public int maxRolls;
            public int rollPrice;
            public int rollPriceAdd;
        }
    }
}