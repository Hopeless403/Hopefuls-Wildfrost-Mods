// Decompiled with JetBrains decompiler
// Type: TokenRewardSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
public class TokenRewardSequence : UISequence
{
  [SerializeField]
  private CanvasGroup canvasGroup;
  [SerializeField]
  private RectTransform titleTransform;
  [SerializeField]
  private Vector3 titleToPosition;
  [SerializeField]
  private TweenUI revealTween;
  [SerializeField]
  private TweenUI hideTween;
  [SerializeField]
  private CardContainer cardHolder;
  [SerializeField]
  private Button skipButton;
  [SerializeField]
  private int goldGainFromSkip = 10;
  [SerializeField]
  private CardController cardController;
  [SerializeField]
  private CardCharmDragHandler tokenDragHandler;
  [SerializeField]
  private RectTransform tokenSlotGroup;
  [SerializeField]
  private CardCharmHolder tokenSlotPrefab;
  [SerializeField]
  private CardUpgradeData[] tokenData;
  private List<TokenRewardSequence.Target> targets;

  public override IEnumerator Run()
  {
    TokenRewardSequence tokenRewardSequence1 = this;
    Character player = References.Player;
    List<Entity> cardsOnBoard = Battle.GetCardsOnBoard(player);
    if (tokenRewardSequence1.targets == null)
      tokenRewardSequence1.targets = new List<TokenRewardSequence.Target>();
    foreach (Entity entity in cardsOnBoard)
    {
      if (entity.data?.cardType?.name == "Friendly")
        tokenRewardSequence1.targets.Add(new TokenRewardSequence.Target(entity, tokenRewardSequence1.cardController));
    }
    Debug.Log((object) string.Format("{0} Targets: [{1}]", (object) tokenRewardSequence1, (object) string.Join<TokenRewardSequence.Target>(", ", (IEnumerable<TokenRewardSequence.Target>) tokenRewardSequence1.targets)));
    if (tokenRewardSequence1.targets.Count > 0)
    {
      tokenRewardSequence1.cardController.owner = player;
      LeanTween.moveLocal(tokenRewardSequence1.titleTransform.gameObject, tokenRewardSequence1.titleToPosition, 0.75f).setEase(LeanTweenType.easeOutBack);
      yield return (object) Sequences.Wait(0.33f);
      tokenRewardSequence1.gameObject.SetActive(true);
      tokenRewardSequence1.revealTween.Fire();
      tokenRewardSequence1.tokenDragHandler.gameObject.SetActive(true);
      foreach (CardUpgradeData cardUpgradeData in tokenRewardSequence1.tokenData)
      {
        TokenRewardSequence tokenRewardSequence = tokenRewardSequence1;
        CardCharmHolder cardCharmHolder = UnityEngine.Object.Instantiate<CardCharmHolder>(tokenRewardSequence1.tokenSlotPrefab, (Transform) tokenRewardSequence1.tokenSlotGroup);
        cardCharmHolder.gameObject.SetActive(true);
        CardUpgradeData upgradeData = cardUpgradeData.Clone();
        UpgradeDisplay token = cardCharmHolder.Create(upgradeData);
        CardCharmInteraction component = token.GetComponent<CardCharmInteraction>();
        component.canHover = true;
        component.canDrag = true;
        component.onDrag.AddListener((UnityAction<UpgradeDisplay>) (a => tokenRewardSequence.tokenDragHandler.Drag(token)));
      }
      tokenRewardSequence1.cardHolder.gameObject.SetActive(true);
      tokenRewardSequence1.cardHolder.SetSize(tokenRewardSequence1.targets.Count, tokenRewardSequence1.cardHolder.CardScale);
      foreach (TokenRewardSequence.Target target in tokenRewardSequence1.targets)
      {
        target.MoveTo(tokenRewardSequence1.cardHolder);
        target.entity.wobbler?.WobbleRandom();
        tokenRewardSequence1.cardHolder.TweenChildPositions();
        target.entity.DrawOrder = 0;
        yield return (object) Sequences.Wait(0.2f);
      }
      yield return (object) Sequences.Wait(0.15f);
      int i;
      for (i = tokenRewardSequence1.targets.Count - 1; i >= 0; --i)
      {
        TokenRewardSequence.Target target = tokenRewardSequence1.targets[i];
        double num = (double) target.entity.curveAnimator.Ping();
        CoroutineManager.Start(target.entity.Reset());
        yield return (object) Sequences.Wait(0.2f);
      }
      tokenRewardSequence1.skipButton.gameObject.SetActive(true);
      // ISSUE: reference to a compiler-generated method
      yield return (object) new WaitUntil(new Func<bool>(tokenRewardSequence1.\u003CRun\u003Eb__14_0));
      tokenRewardSequence1.skipButton.gameObject.SetActive(false);
      for (i = tokenRewardSequence1.targets.Count - 1; i >= 0; --i)
      {
        tokenRewardSequence1.targets[i].Return();
        yield return (object) Sequences.Wait(0.167f);
      }
      tokenRewardSequence1.targets = (List<TokenRewardSequence.Target>) null;
      tokenRewardSequence1.cardHolder.gameObject.SetActive(false);
      tokenRewardSequence1.tokenDragHandler.gameObject.SetActive(false);
      tokenRewardSequence1.hideTween.Fire();
      yield return (object) Sequences.Wait(tokenRewardSequence1.hideTween.GetDuration());
      tokenRewardSequence1.gameObject.SetActive(false);
    }
  }

  public void TokenAssigned() => this.StartCoroutine(this.TokenAssignedRoutine());

  private IEnumerator TokenAssignedRoutine()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    TokenRewardSequence tokenRewardSequence = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      tokenRewardSequence.End();
      tokenRewardSequence.skipButton.interactable = false;
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) Sequences.Wait(0.1f);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  public void Skip()
  {
    References.Player.GainGold(this.goldGainFromSkip);
    this.End();
    this.skipButton.interactable = false;
  }

  public class Target
  {
    public Entity entity;
    private CardContainer[] previousActualContainers;
    private CardController previousController;

    public Target(Entity entity, CardController controller)
    {
      this.entity = entity;
      this.previousActualContainers = new CardContainer[1]
      {
        entity.owner.drawContainer
      };
      Card component = entity.GetComponent<Card>();
      this.previousController = component.hover.controller;
      component.hover.controller = controller;
    }

    public void MoveTo(params CardContainer[] containers)
    {
      this.entity.RemoveFromContainers();
      foreach (CardContainer container in containers)
        container.Add(this.entity);
    }

    public void Return()
    {
      this.MoveTo(this.previousActualContainers);
      foreach (CardContainer previousActualContainer in this.previousActualContainers)
        previousActualContainer.TweenChildPositions();
      this.entity.GetComponent<Card>().hover.controller = this.previousController;
    }

    public override string ToString()
    {
      return !((UnityEngine.Object) this.entity == (UnityEngine.Object) null) ? this.entity.name : "NULL";
    }
  }
}
