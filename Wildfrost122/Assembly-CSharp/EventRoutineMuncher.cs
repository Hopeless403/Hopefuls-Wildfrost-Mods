// Decompiled with JetBrains decompiler
// Type: EventRoutineMuncher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Localization;
using UnityEngine.UI;

#nullable disable
public class EventRoutineMuncher : EventRoutine
{
  [SerializeField]
  private UnityEngine.Animator muncherAnimator;
  [SerializeField]
  private TweenUI muncherMoveToSide;
  [SerializeField]
  private TweenUI muncherMoveToMid;
  public CardContainer cardContainer;
  [SerializeField]
  private CardController cardController;
  [SerializeField]
  private CardType[] canEatCardTypes;
  [SerializeField]
  private LocalizedString initialPromptKey;
  [SerializeField]
  private LocalizedString feedPromptKey;
  [SerializeField]
  private ParticleSystem munchParticles;
  public Button backButton;
  [Header("Speech Bubs")]
  [SerializeField]
  private Talker talker;
  [SerializeField]
  private Vector2 sayDelay = new Vector2(0.8f, 1f);
  [SerializeField]
  private float greetingChance = 1f;
  [SerializeField]
  private float explainChance = 1f;
  private bool hoveringMuncher;
  private bool promptOpenGrid;
  private bool promptCloseGrid;
  private bool promptEnd;
  private bool gridOpen;

  public override IEnumerator Run()
  {
    EventRoutineMuncher eventRoutineMuncher = this;
    int num = eventRoutineMuncher.data.Get<int>("enterCount") + 1;
    eventRoutineMuncher.data["enterCount"] = (object) num;
    eventRoutineMuncher.cardController.owner = eventRoutineMuncher.player;
    eventRoutineMuncher.cardContainer.owner = eventRoutineMuncher.player;
    eventRoutineMuncher.UpdatePrompt();
    SfxSystem.OneShot("event:/sfx/location/muncher/enter");
    if ((double) UnityEngine.Random.value <= (double) eventRoutineMuncher.greetingChance && num == 1)
      eventRoutineMuncher.StartCoroutine(eventRoutineMuncher.SayGreeting());
    while (!eventRoutineMuncher.promptEnd)
    {
      if (eventRoutineMuncher.promptOpenGrid)
      {
        eventRoutineMuncher.promptOpenGrid = false;
        if (!eventRoutineMuncher.gridOpen && eventRoutineMuncher.data.Get<int>("canEat") > 0)
        {
          eventRoutineMuncher.data["openCount"] = (object) (eventRoutineMuncher.data.Get<int>("openCount") + 1);
          eventRoutineMuncher.gridOpen = true;
          if ((double) UnityEngine.Random.value <= (double) eventRoutineMuncher.greetingChance)
            eventRoutineMuncher.StartCoroutine(eventRoutineMuncher.SayExplain());
          yield return (object) eventRoutineMuncher.OpenGrid();
        }
      }
      else if (eventRoutineMuncher.promptCloseGrid)
      {
        eventRoutineMuncher.promptCloseGrid = false;
        if (eventRoutineMuncher.gridOpen)
        {
          eventRoutineMuncher.gridOpen = false;
          yield return (object) eventRoutineMuncher.CloseGrid();
        }
      }
      yield return (object) null;
    }
    CinemaBarSystem.Clear();
    if (eventRoutineMuncher.data.Get<int>("canEat") <= 0)
      eventRoutineMuncher.node.SetCleared();
  }

  private IEnumerator SayGreeting()
  {
    EventRoutineMuncher eventRoutineMuncher = this;
    yield return (object) new WaitForSeconds(eventRoutineMuncher.sayDelay.Random());
    if (eventRoutineMuncher.data.Get<int>("openCount") <= 0)
      eventRoutineMuncher.talker.Say("greet", 0.0f);
  }

  private IEnumerator SayExplain()
  {
    EventRoutineMuncher eventRoutineMuncher = this;
    yield return (object) new WaitForSeconds(eventRoutineMuncher.sayDelay.Random());
    if (eventRoutineMuncher.data.Get<int>("openCount") == 1)
      eventRoutineMuncher.talker.Say("explain", 0.0f);
  }

  private IEnumerator OpenGrid()
  {
    SfxSystem.OneShot("event:/sfx/location/muncher/slide_right");
    CinemaBarSystem.Clear();
    this.muncherMoveToSide.Fire();
    this.cardController.Enable();
    Routine.Clump clump = new Routine.Clump();
    clump.Add(this.CreateCards());
    clump.Add(Sequences.Wait(0.2f));
    yield return (object) clump.WaitForEnd();
    this.cardContainer.gameObject.SetActive(true);
    this.cardContainer.transform.localScale = Vector3.one * 0.5f;
    LeanTween.scale(this.cardContainer.gameObject, Vector3.one, 1.25f).setEase(LeanTweenType.easeOutElastic);
    this.UpdatePrompt();
  }

  private IEnumerator CreateCards()
  {
    EventRoutineMuncher eventRoutineMuncher = this;
    Routine.Clump clump = new Routine.Clump();
    List<CardData> cardDataList = new List<CardData>();
    foreach (CardData cardData in eventRoutineMuncher.player.data.inventory.deck)
    {
      if (eventRoutineMuncher.canEatCardTypes.Contains<CardType>(cardData.cardType))
        cardDataList.Add(cardData);
    }
    foreach (CardData cardData in eventRoutineMuncher.player.data.inventory.reserve)
    {
      if (eventRoutineMuncher.canEatCardTypes.Contains<CardType>(cardData.cardType))
        cardDataList.Add(cardData);
    }
    foreach (CardData data in cardDataList)
    {
      Card card = CardManager.Get(data, eventRoutineMuncher.cardController, eventRoutineMuncher.player, false, true);
      eventRoutineMuncher.cardContainer.Add(card.entity);
      clump.Add(card.UpdateData(false));
    }
    yield return (object) clump.WaitForEnd();
    eventRoutineMuncher.cardContainer.SetChildPositions();
  }

  private IEnumerator CloseGrid()
  {
    EventRoutineMuncher eventRoutineMuncher = this;
    eventRoutineMuncher.UpdatePrompt();
    eventRoutineMuncher.cardController.Disable();
    float num = 0.5f;
    // ISSUE: reference to a compiler-generated method
    LeanTween.scale(eventRoutineMuncher.cardContainer.gameObject, Vector3.zero, num).setEase(LeanTweenType.easeInBack).setOnComplete(new System.Action(eventRoutineMuncher.\u003CCloseGrid\u003Eb__24_0));
    yield return (object) new WaitForSeconds(num);
    yield return (object) null;
    SfxSystem.OneShot("event:/sfx/location/muncher/slide_left");
    eventRoutineMuncher.muncherMoveToMid.Fire();
  }

  private void UpdatePrompt()
  {
    if (this.data.Get<int>("canEat") > 0)
    {
      if (this.gridOpen)
        CinemaBarSystem.Top.SetPrompt(this.feedPromptKey.GetLocalizedString(), "Select");
      else
        CinemaBarSystem.Top.SetPrompt(this.initialPromptKey.GetLocalizedString(), "Select");
    }
    else
      CinemaBarSystem.Clear();
  }

  public void PromptOpenGrid(BaseEventData eventData)
  {
    if (eventData is PointerEventData pointerEventData && pointerEventData.button != PointerEventData.InputButton.Left)
      return;
    this.promptOpenGrid = true;
  }

  public void PromptCloseGrid() => this.promptCloseGrid = true;

  public void End() => this.promptEnd = true;

  public void HoverMuncher() => this.hoveringMuncher = true;

  public void UnHoverMuncher() => this.hoveringMuncher = false;

  public void DragCardStart(Entity entity)
  {
    this.muncherAnimator.SetBool("DraggingCard", true);
    Events.InvokeMuncherDrag();
    NavigationState.Start((INavigationState) new NavigationStateMuncher(this));
  }

  public void DragCardEnd(Entity entity)
  {
    this.muncherAnimator.SetBool("DraggingCard", false);
    NavigationState.BackToPreviousState();
    Events.InvokeMuncherDragCancel();
    this.cardController.hoverEntity = (Entity) null;
  }

  public void TryEatIfHovering(Entity entity)
  {
    if (!this.hoveringMuncher || !this.TryEat(entity))
      return;
    Events.InvokeMuncherFeed(entity);
  }

  public bool TryEat(Entity entity)
  {
    if (this.data.Get<int>("canEat") <= 0 || !this.canEatCardTypes.Contains<CardType>(entity.data.cardType))
      return false;
    this.Eat(entity);
    return true;
  }

  public void Eat(Entity entity)
  {
    if (entity.owner.data.inventory.deck.RemoveWhere<CardData>((Predicate<CardData>) (a => (long) entity.data.id == (long) a.id)))
      Debug.Log((object) ("[" + entity.data.name + "] Removed From [" + this.player.name + "] deck"));
    else if (entity.owner.data.inventory.reserve.RemoveWhere<CardData>((Predicate<CardData>) (a => (long) entity.data.id == (long) a.id)))
      Debug.Log((object) ("[" + entity.data.name + "] Removed From [" + this.player.name + "] reserve"));
    int num1 = this.data.Get<int>("canEat") - 1;
    this.data["canEat"] = (object) num1;
    if (num1 <= 0)
    {
      this.PromptCloseGrid();
      this.talker.Say("full", 0.0f);
    }
    else
    {
      int num2 = this.data.Get<int>("thankCount") + 1;
      this.data["thankCount"] = (object) num2;
      if (num2 < 1)
        this.talker.Say("thanks", 0.0f);
    }
    entity.RemoveFromContainers();
    if (num1 > 0)
      this.cardContainer.TweenChildPositions();
    CardManager.ReturnToPool(entity);
    this.muncherAnimator.SetTrigger("Munch");
    Events.InvokeScreenShake(0.5f);
    this.munchParticles.Play();
  }
}
