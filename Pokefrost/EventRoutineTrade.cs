// Decompiled with JetBrains decompiler
// Type: Pokefrost.EventRoutineTrade
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;
using UnityEngine.UI;

#nullable disable
namespace Pokefrost
{
  internal class EventRoutineTrade : EventRoutine, IRerollable
  {
    public static readonly string Seq1Key = "websiteofsites.wildfrost.pokefrost.trade_text1";
    public static readonly string Seq2Key = "websiteofsites.wildfrost.pokefrost.trade_text2";
    public static readonly string TradeConfirm = "websiteofsites.wildfrost.pokefrost.trade_confirm";
    public static readonly string TradeCancel = "websiteofsites.wildfrost.pokefrost.trade_cancel";
    private StringTable stringTable;
    public CardControllerSelectCard cc;
    public CardSelector cs;
    public CardLane topRow;
    public CardLane bottomRow;
    public GameObject backButton;
    public GameObject TradeLines;
    public List<Image> TradeLinesList = new List<Image>();
    public Vector2 linesScale = new Vector2(2.5f, 8.25f);
    public Color offColor = new Color(0.0f, 0.0f, 0.0f, 0.0f);
    public Color onColor = new Color(0.3f, 0.8f, 0.5f, 0.7f);
    public GameObject selectionBackground;
    public GameObject cancelObject;
    public GameObject confirmObject;
    public TextMeshProUGUI title;
    public int swapped = -1;
    public bool selected = false;
    public float selectTime = 0.5f;
    public LeanTweenType selectType = LeanTweenType.easeOutQuart;
    private Vector3 left = new Vector3(-2.5f, 1f, 0.0f);
    private Vector3 right = new Vector3(2.5f, 1f, 0.0f);
    public float tradeTime = 1f;
    public bool routineActive = true;
    private bool initialized = false;

    public override IEnumerator Populate()
    {
      string[] saveCollection = this.data.GetSaveCollection<string>("cards");
      string[] upgradeCollection = this.data.GetSaveCollection<string>("charms");
      int size = saveCollection.Length;
      int amountPer = upgradeCollection.Length / size;
      if (!this.data.ContainsKey("currentcompanions"))
      {
        List<CardData> items = new List<CardData>();
        foreach (CardData cardData in References.PlayerData.inventory.deck)
        {
          if (cardData.cardType.name == "Friendly")
            items.Add(cardData);
        }
        foreach (CardData cardData in References.PlayerData.inventory.reserve)
        {
          if (cardData.cardType.name == "Friendly")
            items.Add(cardData);
        }
        size = Math.Min(size, items.Count<CardData>());
        items = items.InRandomOrder<CardData>().ToList<CardData>().GetRange(0, size);
        this.node.data.Add("currentcompanions", (object) items.ToSaveCollectionOfNames<CardData>());
        items = (List<CardData>) null;
      }
      string[] savedOffers = this.data.GetSaveCollection<string>("currentcompanions");
      size = Math.Min(((IEnumerable<string>) saveCollection).Count<string>(), ((IEnumerable<string>) savedOffers).Count<string>());
      this.topRow.SetSize(saveCollection.Length, 0.7f);
      this.bottomRow.SetSize(saveCollection.Length, 0.7f);
      Routine.Clump clump = new Routine.Clump();
      for (int i = 0; i < size; ++i)
      {
        List<string> upgrades = upgradeCollection.RangeSubset<string>(amountPer * i, amountPer).ToList<string>();
        clump.Add(EventRoutineTrade.CreateCardsFromLoader(saveCollection[i], upgrades, (CardController) this.cc, (CardContainer) this.topRow));
        if (!this.initialized)
          clump.Add(EventRoutineTrade.CreateCardsFromDeck(savedOffers[i], (CardController) this.cc, (CardContainer) this.bottomRow));
        upgrades = (List<string>) null;
      }
      yield return (object) clump.WaitForEnd();
      this.topRow.SetChildPositions();
      this.bottomRow.SetChildPositions();
      if (!this.initialized)
      {
        this.initialized = true;
        this.SetSize();
        this.cc.pressEvent.AddListener(new UnityAction<Entity>(this.Select));
        this.cc.hoverEvent.AddListener(new UnityAction<Entity>(this.Hover));
        this.cc.unHoverEvent.AddListener(new UnityAction<Entity>(this.Unhover));
        this.cs.character = References.Player;
        this.backButton.GetComponentInChildren<Button>().onClick.SetPersistentListenerState(0, UnityEventCallState.Off);
        this.backButton.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(this.Leave));
        this.cancelObject.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(this.Cancel));
        this.cancelObject.GetComponentInChildren<Button>().onClick.SetPersistentListenerState(0, UnityEventCallState.Off);
        this.confirmObject.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(this.Confirm));
        this.confirmObject.GetComponentInChildren<Button>().onClick.SetPersistentListenerState(0, UnityEventCallState.Off);
        this.cancelObject.GetComponentInChildren<ButtonAnimator>().baseColour = new Color(0.9f, 0.3f, 0.3f, 1f);
      }
    }

    public void PrepareButtons()
    {
      this.cancelObject.GetComponentInChildren<ButtonAnimator>().baseColour = new Color(0.9f, 0.3f, 0.3f, 1f);
      this.cancelObject.SetActive(false);
      this.cancelObject.SetActive(true);
      this.cancelObject.GetComponentInChildren<TextMeshProUGUI>().SetText(this.stringTable.GetString(EventRoutineTrade.TradeCancel).GetLocalizedString());
      this.confirmObject.GetComponentInChildren<TextMeshProUGUI>().SetText(this.stringTable.GetString(EventRoutineTrade.TradeConfirm).GetLocalizedString());
    }

    private void SetSize()
    {
      for (int index = 0; index < this.bottomRow.entities.Count; ++index)
      {
        GameObject gameObject = UICollector.PullPrefab("Box", "Box", this.TradeLines);
        gameObject.transform.localPosition = new Vector3(this.bottomRow.GetChildPosition(this.bottomRow.entities[index]).x, 0.0f, 0.0f);
        gameObject.GetComponent<RectTransform>().sizeDelta = this.linesScale;
        this.TradeLinesList.Add(gameObject.GetComponent<Image>());
        this.TradeLinesList[index].color = this.offColor;
      }
    }

    public override IEnumerator Run()
    {
      this.stringTable = LocalizationHelper.GetCollection("UI Text", (LocaleIdentifier) SystemLanguage.English);
      while (this.routineActive)
      {
        if (this.swapped != -1)
        {
          this.title.SetText(this.stringTable.GetString(EventRoutineTrade.Seq1Key).GetLocalizedString());
          this.topRow.entities[this.swapped].transform.SetParent(this.topRow.transform, true);
          this.bottomRow.entities[this.swapped].transform.SetParent(this.bottomRow.transform, true);
          this.topRow.TweenChildPositions();
          this.bottomRow.TweenChildPositions();
          this.swapped = -1;
        }
        this.cc.enabled = true;
        this.selectionBackground.SetActive(false);
        yield return (object) new WaitUntil((Func<bool>) (() => this.selected));
        if (this.swapped == -1)
        {
          yield break;
        }
        else
        {
          string s = this.stringTable.GetString(EventRoutineTrade.Seq2Key).GetLocalizedString();
          this.title.SetText(string.Format(s, (object) this.bottomRow.entities[this.swapped].data.title, (object) this.topRow.entities[this.swapped].data.title));
          this.selectionBackground.SetActive(true);
          this.PrepareButtons();
          this.UnhoverAll();
          this.topRow.entities[this.swapped].transform.SetParent(this.selectionBackground.transform, true);
          this.bottomRow.entities[this.swapped].transform.SetParent(this.selectionBackground.transform, true);
          this.cc.enabled = false;
          LeanTween.moveLocal(this.topRow.entities[this.swapped].gameObject, this.right, this.selectTime).setEase(this.selectType);
          LeanTween.moveLocal(this.bottomRow.entities[this.swapped].gameObject, this.left, this.selectTime).setEase(this.selectType);
          LeanTween.scale(this.topRow.entities[this.swapped].gameObject, Vector3.one, this.selectTime).setEase(this.selectType);
          LeanTween.scale(this.bottomRow.entities[this.swapped].gameObject, Vector3.one, this.selectTime).setEase(this.selectType);
          yield return (object) Sequences.Wait(this.selectTime + 0.1f);
          yield return (object) new WaitUntil((Func<bool>) (() => !this.selected));
          s = (string) null;
        }
      }
      LeanTween.moveLocal(this.topRow.entities[this.swapped].gameObject, this.left, this.tradeTime).setEase(this.selectType);
      LeanTween.moveLocal(this.bottomRow.entities[this.swapped].gameObject, this.right, this.tradeTime).setEase(this.selectType);
      yield return (object) Sequences.Wait(this.tradeTime + 0.1f);
      this.cs.TakeCard(this.topRow.entities[this.swapped]);
      this.node.SetCleared();
      yield return (object) Sequences.Wait(0.2f);
    }

    private static IEnumerator CreateCardsFromDeck(
      string cardName,
      CardController cardController,
      CardContainer cardContainer,
      bool startFlipped = true)
    {
      foreach (CardData cardData in References.PlayerData.inventory.deck)
      {
        if (cardData.name == cardName)
          return EventRoutineTrade.CreateCards(cardData, cardController, cardContainer, startFlipped);
      }
      foreach (CardData cardData in References.PlayerData.inventory.reserve)
      {
        if (cardData.name == cardName)
          return EventRoutineTrade.CreateCards(cardData, cardController, cardContainer, startFlipped);
      }
      return (IEnumerator) null;
    }

    private static IEnumerator CreateCardsFromLoader(
      string cardName,
      List<string> upgrades,
      CardController cardController,
      CardContainer cardContainer,
      bool startFlipped = true)
    {
      CardData cardData = AddressableLoader.Get<CardData>("CardData", cardName).Clone();
      foreach (string upgrade in upgrades)
      {
        CardUpgradeData cardUpgradeData = AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", upgrade);
        if (!((UnityEngine.Object) cardUpgradeData == (UnityEngine.Object) null) && cardUpgradeData.CanAssign(cardData))
          cardUpgradeData.Clone().Assign(cardData);
      }
      return EventRoutineTrade.CreateCards(cardData, cardController, cardContainer, startFlipped);
    }

    private static IEnumerator CreateCards(
      CardData cardData,
      CardController cardController,
      CardContainer cardContainer,
      bool startFlipped = true)
    {
      Card card = CardManager.Get(cardData, cardController, (Character) null, false, true);
      if (startFlipped)
        card.entity.flipper.FlipDownInstant();
      Debug.Log((object) "Trading!");
      Debug.Log((object) ((UnityEngine.Object) cardContainer != (UnityEngine.Object) null));
      cardContainer.Add(card.entity);
      yield return (object) card.UpdateData(false);
      if (startFlipped)
        card.entity.flipper.FlipUp(true);
    }

    public void Hover(Entity entity)
    {
      int index = this.FindIndex(entity);
      if (index == -1)
        return;
      this.TradeLinesList[index].color = this.onColor;
    }

    public void Unhover(Entity entity)
    {
      int index = this.FindIndex(entity);
      if (index == -1)
        return;
      this.TradeLinesList[index].color = this.offColor;
    }

    public void UnhoverAll()
    {
      foreach (Graphic tradeLines in this.TradeLinesList)
        tradeLines.color = this.offColor;
    }

    public int FindIndex(Entity entity)
    {
      int index = this.topRow.entities.IndexOf(entity);
      if (index == -1)
        index = this.bottomRow.entities.IndexOf(entity);
      return index;
    }

    public void Select(Entity entity)
    {
      this.cc.UnHover(entity);
      this.swapped = this.FindIndex(entity);
      if (this.swapped == -1)
        return;
      this.selected = true;
    }

    public void Swap(Entity entity)
    {
      int index = this.topRow.entities.IndexOf(entity);
      if (index == -1)
        index = this.bottomRow.entities.IndexOf(entity);
      if (index == -1)
        return;
      this.Swap(index);
    }

    public void Swap(int index)
    {
      if (index >= Math.Min(this.topRow.entities.Count, this.bottomRow.entities.Count))
      {
        Debug.Log((object) "[Pokeforst] How did that happen?");
      }
      else
      {
        Entity entity1 = this.topRow.entities[index];
        Entity entity2 = this.bottomRow.entities[index];
        this.topRow.RemoveAt(index);
        this.bottomRow.RemoveAt(index);
        this.topRow.Insert(index, entity2);
        this.bottomRow.Insert(index, entity1);
        this.topRow.TweenChildPositions();
        this.bottomRow.TweenChildPositions();
        if (this.swapped == index)
        {
          this.swapped = -1;
          this.TradeLinesList[index].color = this.offColor;
        }
        else
        {
          this.swapped = index;
          this.TradeLinesList[index].color = this.onColor;
        }
        this.selected = true;
      }
    }

    public void Leave() => this.selected = true;

    public void Cancel()
    {
      this.selected = false;
      Debug.Log((object) "[Pokefrost] Cancel");
    }

    public void Confirm()
    {
      int swapped = this.swapped;
      foreach (CardUpgradeData upgrade in this.bottomRow.entities[swapped].data.upgrades)
      {
        if (upgrade.type != CardUpgradeData.Type.Charm && upgrade.canBeRemoved)
          References.PlayerData.inventory.upgrades.Add(AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", upgrade.name).Clone());
      }
      bool flag = false;
      foreach (CardData cardData in References.PlayerData.inventory.deck)
      {
        if (cardData.name == this.bottomRow.entities[swapped].data.name)
        {
          References.PlayerData.inventory.deck.Remove(cardData);
          flag = true;
          break;
        }
      }
      if (!flag)
      {
        foreach (CardData cardData in References.PlayerData.inventory.reserve)
        {
          if (cardData.name == this.bottomRow.entities[swapped].data.name)
          {
            References.PlayerData.inventory.reserve.Remove(cardData);
            break;
          }
        }
      }
      this.routineActive = false;
      this.selected = false;
      Debug.Log((object) "[Pokefrost] Confirm");
    }

    public bool Reroll()
    {
      if (this.selected)
        return false;
      string[] saveCollection1 = this.data.GetSaveCollection<string>("cards");
      string[] saveCollection2 = this.data.GetSaveCollection<string>("charms");
      this.data["cards"] = (object) CampaignNodeTypeTrade.ObtainCards(saveCollection1.Length, 499).ToSaveCollectionOfNames<CardData>();
      this.data["charms"] = (object) CampaignNodeTypeTrade.ObtainCharms(saveCollection2.Length).ToSaveCollectionOfNames<CardUpgradeData>();
      foreach (Entity entity in (CardContainer) this.topRow)
        CardManager.ReturnToPool(entity);
      this.topRow.Clear();
      this.StartCoroutine(this.Populate());
      CardPopUp.Clear();
      return true;
    }
  }
}
