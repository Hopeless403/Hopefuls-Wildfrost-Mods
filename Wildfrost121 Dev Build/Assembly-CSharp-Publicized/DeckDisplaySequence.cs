// Decompiled with JetBrains decompiler
// Type: DeckDisplaySequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class DeckDisplaySequence : UISequence
{
  public Character owner;
  public Transform background;
  public RectTransform container;
  public DeckDisplayGroup activeCardsGroup;
  public DeckDisplayGroup reserveCardsGroup;
  [SerializeField]
  public CardCharmHolder charmHolder;
  [SerializeField]
  public CrownHolder crownHolder;
  [SerializeField]
  public CardCharmDragHandler charmDragHandler;
  [SerializeField]
  public RectTransform borderLeft;
  [SerializeField]
  public RectTransform borderRight;
  [SerializeField]
  public ScrollRect scrollRect;
  [SerializeField]
  public CardController cardController;

  public override IEnumerator Run()
  {
    DeckDisplaySequence deckDisplaySequence = this;
    yield return (object) Sequences.Wait(deckDisplaySequence.startDelay);
    deckDisplaySequence.container.localScale = Vector3.one;
    StopWatch.Start();
    Routine.Clump clump = new Routine.Clump();
    deckDisplaySequence.activeCardsGroup.Clear();
    foreach (CardData data in deckDisplaySequence.owner.data.inventory.deck)
      clump.Add(deckDisplaySequence.activeCardsGroup.CreateCard(data));
    yield return (object) clump.WaitForEnd();
    deckDisplaySequence.activeCardsGroup.UpdatePositions();
    deckDisplaySequence.reserveCardsGroup.Clear();
    foreach (CardData data in deckDisplaySequence.owner.data.inventory.reserve)
      clump.Add(deckDisplaySequence.reserveCardsGroup.CreateCard(data));
    yield return (object) clump.WaitForEnd();
    deckDisplaySequence.reserveCardsGroup.UpdatePositions();
    deckDisplaySequence.charmHolder.Clear();
    deckDisplaySequence.crownHolder.Clear();
    foreach (CardUpgradeData upgrade in deckDisplaySequence.owner.data.inventory.upgrades)
    {
      switch (upgrade.type)
      {
        case CardUpgradeData.Type.Charm:
          deckDisplaySequence.charmHolder.Create(upgrade);
          continue;
        case CardUpgradeData.Type.Crown:
          deckDisplaySequence.crownHolder.Create(upgrade);
          continue;
        default:
          continue;
      }
    }
    deckDisplaySequence.charmHolder.SetPositions();
    deckDisplaySequence.crownHolder.SetPositions();
    Debug.Log((object) string.Format("DECK CARDS CREATED ({0}ms)", (object) StopWatch.Stop()));
    deckDisplaySequence.background.transform.localScale = Vector3.one;
    deckDisplaySequence.container.transform.localScale = Vector3.one * 0.5f;
    deckDisplaySequence.gameObject.SetActive(true);
    deckDisplaySequence.cardController.Enable();
    yield return (object) deckDisplaySequence.FixLayoutsRoutine();
    LeanTween.cancel(deckDisplaySequence.background.gameObject);
    LeanTween.scale(deckDisplaySequence.background.gameObject, new Vector3(60f, 60f, 1f), 1.5f).setEase(deckDisplaySequence.tweenInEase);
    LeanTween.cancel(deckDisplaySequence.container.gameObject);
    LeanTween.scale(deckDisplaySequence.container.gameObject, Vector3.one, deckDisplaySequence.tweenInDur).setEase(deckDisplaySequence.tweenInEase);
    float time = 0.5f;
    LeanTweenType easeType = LeanTweenType.easeOutBack;
    float delay = 0.1f;
    float borderFrom = 4f;
    LeanTween.cancel(deckDisplaySequence.borderLeft);
    deckDisplaySequence.borderLeft.anchoredPosition3D = new Vector3(-borderFrom, 0.0f, 0.0f);
    LeanTween.move(deckDisplaySequence.borderLeft, new Vector3(-0.7f, 0.0f, 0.0f), time).setEase(easeType).setDelay(delay);
    LeanTween.cancel(deckDisplaySequence.borderRight);
    deckDisplaySequence.borderRight.anchoredPosition3D = new Vector3(borderFrom, 0.0f, 0.0f);
    LeanTween.move(deckDisplaySequence.borderRight, new Vector3(0.7f, 0.0f, 0.0f), time).setEase(easeType).setDelay(delay);
    yield return (object) null;
    deckDisplaySequence.scrollRect.normalizedPosition = new Vector2(0.5f, 1f);
    yield return (object) new WaitUntil(new Func<bool>(deckDisplaySequence.\u003CRun\u003Eb__12_0));
    deckDisplaySequence.promptEnd = false;
    deckDisplaySequence.cardController.Disable();
    if (deckDisplaySequence.charmDragHandler.IsDragging)
      deckDisplaySequence.charmDragHandler.CancelDrag();
    foreach (CardCharmInteraction componentsInChild in deckDisplaySequence.charmHolder.GetComponentsInChildren<CardCharmInteraction>())
    {
      componentsInChild.UnHover();
      componentsInChild.canHover = false;
    }
    foreach (CardCharmInteraction componentsInChild in deckDisplaySequence.crownHolder.GetComponentsInChildren<CardCharmInteraction>())
    {
      componentsInChild.UnHover();
      componentsInChild.canHover = false;
    }
    NavigationState.Start((INavigationState) new NavigationStateWait(true));
    LeanTween.cancel(deckDisplaySequence.background.gameObject);
    LeanTween.scale(deckDisplaySequence.background.gameObject, Vector3.zero, deckDisplaySequence.tweenOutDur).setEase(deckDisplaySequence.tweenOutEase);
    LeanTween.cancel(deckDisplaySequence.container.gameObject);
    LeanTween.scale(deckDisplaySequence.container.gameObject, Vector3.zero, deckDisplaySequence.tweenOutDur).setEase(deckDisplaySequence.tweenOutEase);
    LeanTween.cancel(deckDisplaySequence.borderLeft);
    LeanTween.move(deckDisplaySequence.borderLeft, new Vector3(-borderFrom, 0.0f, 0.0f), deckDisplaySequence.tweenOutDur).setEase(deckDisplaySequence.tweenOutEase);
    LeanTween.cancel(deckDisplaySequence.borderRight);
    LeanTween.move(deckDisplaySequence.borderRight, new Vector3(borderFrom, 0.0f, 0.0f), deckDisplaySequence.tweenOutDur).setEase(deckDisplaySequence.tweenOutEase);
    yield return (object) Sequences.Wait(deckDisplaySequence.tweenOutDur);
    deckDisplaySequence.activeCardsGroup.Clear();
    deckDisplaySequence.reserveCardsGroup.Clear();
    deckDisplaySequence.charmHolder.Clear();
    deckDisplaySequence.crownHolder.Clear();
    NavigationState.BackToPreviousState();
    deckDisplaySequence.gameObject.SetActive(false);
  }

  public IEnumerator FixLayoutsRoutine()
  {
    yield return (object) ((RectTransform) this.activeCardsGroup.transform.parent).FixLayoutGroup();
  }

  public IEnumerator FixLayoutsRoutinePreserveScroll()
  {
    Vector2 scrollPos = this.scrollRect.normalizedPosition;
    yield return (object) this.FixLayoutsRoutine();
    yield return (object) null;
    this.scrollRect.normalizedPosition = scrollPos;
  }

  public void UpdatePositions()
  {
    foreach (CardContainer grid in this.activeCardsGroup.grids)
      grid.TweenChildPositions();
    foreach (CardContainer grid in this.reserveCardsGroup.grids)
      grid.TweenChildPositions();
    this.StartCoroutine(this.FixLayoutsRoutinePreserveScroll());
  }

  [CompilerGenerated]
  public bool \u003CRun\u003Eb__12_0() => this.promptEnd;
}
