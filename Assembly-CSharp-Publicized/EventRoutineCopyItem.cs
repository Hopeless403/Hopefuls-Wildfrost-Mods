// Decompiled with JetBrains decompiler
// Type: EventRoutineCopyItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.UI;

public class EventRoutineCopyItem : EventRoutine
{
  public CardContainer cardContainer;
  [SerializeField]
  public CardController cardController;
  [SerializeField]
  public CardSelector cardSelector;
  [SerializeField]
  public CardType[] canCopyCardTypes;
  [SerializeField]
  public LocalizedString promptKey;
  [SerializeField]
  public LocalizedString confirmPromptKey;
  [SerializeField]
  public TweenUI moveToSide;
  [SerializeField]
  public TweenUI moveToCentre;
  [SerializeField]
  public Transform toCopyAnchor;
  [SerializeField]
  public Talker talker;
  public Button backButton;
  public bool cardsCreated;
  public bool promptOpenGrid;
  public bool promptCloseGrid;
  public bool promptCopy;
  public Entity toCopy;
  public int toCopyOriginalIndex;
  public Entity copyEntity;
  public bool promptEnd;
  public bool gridOpen;

  public override IEnumerator Run()
  {
    EventRoutineCopyItem eventRoutineCopyItem = this;
    int num = eventRoutineCopyItem.data.Get<int>("enterCount") + 1;
    eventRoutineCopyItem.data["enterCount"] = (object) num;
    eventRoutineCopyItem.cardController.owner = eventRoutineCopyItem.player;
    eventRoutineCopyItem.cardSelector.character = eventRoutineCopyItem.player;
    eventRoutineCopyItem.cardContainer.owner = eventRoutineCopyItem.player;
    CinemaBarSystem.Top.SetPrompt(eventRoutineCopyItem.promptKey.GetLocalizedString(), "Select");
    eventRoutineCopyItem.promptOpenGrid = true;
    while (!eventRoutineCopyItem.promptEnd || eventRoutineCopyItem.promptCopy)
    {
      if (eventRoutineCopyItem.promptOpenGrid)
      {
        eventRoutineCopyItem.promptOpenGrid = false;
        if (!eventRoutineCopyItem.gridOpen)
          yield return (object) eventRoutineCopyItem.OpenGrid();
      }
      else if (eventRoutineCopyItem.promptCloseGrid)
      {
        eventRoutineCopyItem.promptCloseGrid = false;
        if (eventRoutineCopyItem.gridOpen)
          yield return (object) eventRoutineCopyItem.CloseGrid();
      }
      else if (eventRoutineCopyItem.promptCopy)
      {
        yield return (object) eventRoutineCopyItem.CopyRoutine();
        eventRoutineCopyItem.promptCopy = false;
      }
      yield return (object) null;
    }
    CinemaBarSystem.Clear();
    if (eventRoutineCopyItem.data.Get<int>("canCopy") <= 0)
      eventRoutineCopyItem.node.SetCleared();
  }

  public IEnumerator OpenGrid()
  {
    this.gridOpen = true;
    this.cardController.Enable();
    if (!this.cardsCreated)
    {
      this.cardsCreated = true;
      Routine.Clump clump = new Routine.Clump();
      clump.Add(this.CreateCards());
      clump.Add(Sequences.Wait(0.2f));
      yield return (object) clump.WaitForEnd();
    }
    this.cardContainer.gameObject.SetActive(true);
    this.cardContainer.transform.localScale = Vector3.one * 0.5f;
    LeanTween.scale(this.cardContainer.gameObject, Vector3.one, 1.25f).setEase(LeanTweenType.easeOutElastic);
  }

  public IEnumerator CreateCards()
  {
    EventRoutineCopyItem eventRoutineCopyItem = this;
    Routine.Clump clump = new Routine.Clump();
    List<CardData> cardDataList = new List<CardData>();
    foreach (CardData cardData in eventRoutineCopyItem.player.data.inventory.deck)
    {
      if (eventRoutineCopyItem.canCopyCardTypes.Contains<CardType>(cardData.cardType))
        cardDataList.Add(cardData);
    }
    foreach (CardData cardData in eventRoutineCopyItem.player.data.inventory.reserve)
    {
      if (eventRoutineCopyItem.canCopyCardTypes.Contains<CardType>(cardData.cardType))
        cardDataList.Add(cardData);
    }
    foreach (CardData data in cardDataList)
    {
      Card card = CardManager.Get(data, eventRoutineCopyItem.cardController, eventRoutineCopyItem.player, false, true);
      eventRoutineCopyItem.cardContainer.Add(card.entity);
      clump.Add(card.UpdateData(false));
    }
    yield return (object) clump.WaitForEnd();
    eventRoutineCopyItem.cardContainer.SetChildPositions();
  }

  public IEnumerator CloseGrid()
  {
    // ISSUE: reference to a compiler-generated field
    int num1 = this.\u003C\u003E1__state;
    EventRoutineCopyItem eventRoutineCopyItem = this;
    if (num1 != 0)
    {
      if (num1 != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    eventRoutineCopyItem.gridOpen = false;
    float num2 = 0.3f;
    LeanTween.scale(eventRoutineCopyItem.cardContainer.gameObject, Vector3.zero, num2).setEase(LeanTweenType.easeInBack).setOnComplete(new System.Action(eventRoutineCopyItem.\u003CCloseGrid\u003Eb__23_0));
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) new WaitForSeconds(num2);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  public void Copy(Entity entity)
  {
    if ((UnityEngine.Object) this.toCopy == (UnityEngine.Object) entity)
    {
      this.promptCopy = true;
      this.copyEntity = entity;
      this.End();
    }
    else
    {
      if ((bool) (UnityEngine.Object) this.toCopy)
        return;
      this.moveToCentre.Fire();
      this.toCopy = entity;
      this.toCopyOriginalIndex = this.cardContainer.IndexOf(entity);
      this.cardContainer.Remove(entity);
      entity.transform.SetParent(this.toCopyAnchor);
      LeanTween.moveLocal(entity.gameObject, Vector3.zero, 0.33f).setEaseOutQuart();
      this.promptCloseGrid = true;
      CinemaBarSystem.Top.SetPrompt(this.confirmPromptKey.GetLocalizedString(), "Select");
    }
  }

  public IEnumerator CopyRoutine()
  {
    EventRoutineCopyItem eventRoutineCopyItem = this;
    eventRoutineCopyItem.backButton.interactable = false;
    int num = eventRoutineCopyItem.data.Get<int>("canCopy") - 1;
    eventRoutineCopyItem.data["canCopy"] = (object) num;
    if (num <= 0)
      eventRoutineCopyItem.PromptCloseGrid();
    CardData data = eventRoutineCopyItem.copyEntity.data.Clone(false);
    data.upgrades.RemoveAll((Predicate<CardUpgradeData>) (a => a.type == CardUpgradeData.Type.Crown));
    Card card = CardManager.Get(data, eventRoutineCopyItem.cardController, eventRoutineCopyItem.player, false, true);
    yield return (object) card.UpdateData(false);
    card.transform.position = eventRoutineCopyItem.copyEntity.transform.position;
    eventRoutineCopyItem.cardSelector.TakeCard(card.entity);
    eventRoutineCopyItem.promptCloseGrid = true;
    yield return (object) new WaitForSeconds(0.5f);
  }

  public void Back()
  {
    if ((bool) (UnityEngine.Object) this.toCopy)
    {
      this.promptOpenGrid = true;
      this.cardContainer.Insert(this.toCopyOriginalIndex, this.toCopy);
      this.toCopy = (Entity) null;
      this.cardContainer.SetChildPositions();
      this.moveToSide.Fire();
      CinemaBarSystem.Top.SetPrompt(this.promptKey.GetLocalizedString(), "Select");
    }
    else
      this.End();
  }

  public void PromptCloseGrid() => this.promptCloseGrid = true;

  public void End()
  {
    this.promptEnd = true;
    this.backButton.interactable = false;
    this.cardController.Disable();
  }

  [CompilerGenerated]
  public void \u003CCloseGrid\u003Eb__23_0() => this.cardContainer.gameObject.SetActive(false);
}
