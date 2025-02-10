// Decompiled with JetBrains decompiler
// Type: CardControllerDeck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
public class CardControllerDeck : CardController
{
  [SerializeField]
  public DeckDisplaySequence deckDisplaySequence;
  public CardContainer deckContainer;
  public CardContainer reserveContainer;
  [SerializeField]
  public DeckSelectSequence selectSequence;
  [SerializeField]
  public ScrollRect scrollRect;
  [SerializeField]
  public ContentSizeFitter contentSizeFitter;

  public override bool AllowDynamicSelectRelease => false;

  public override void Press()
  {
    if (!(bool) (Object) this.pressEntity)
      return;
    this.StartCoroutine(this.OpenMenu(this.pressEntity));
  }

  public IEnumerator OpenMenu(Entity entity)
  {
    CardControllerDeck cardControllerDeck = this;
    cardControllerDeck.Disable();
    cardControllerDeck.selectSequence.SetEntity(entity);
    if (!(bool) (Object) References.Battle)
    {
      if (cardControllerDeck.owner.data.inventory.deck.Contains(entity.data))
      {
        if (entity.data.cardType.canReserve)
          cardControllerDeck.selectSequence.AddMoveDown((UnityAction) (() => this.MoveToReserve(entity)));
      }
      else if (cardControllerDeck.owner.data.inventory.reserve.Contains(entity.data) && cardControllerDeck.owner.GetCompanionCount() < cardControllerDeck.owner.data.companionLimit)
        cardControllerDeck.selectSequence.AddMoveUp((UnityAction) (() => this.MoveToDeck(entity)));
    }
    yield return (object) cardControllerDeck.selectSequence.Run();
    cardControllerDeck.Enable();
  }

  public void MoveToDeck(Entity entity)
  {
    if (!entity.InContainerGroup(this.deckContainer))
    {
      entity.RemoveFromContainers();
      this.deckContainer.Add(entity);
    }
    if (!this.owner.data.inventory.deck.Contains(entity.data))
    {
      this.owner.data.inventory.reserve.Remove(entity.data);
      this.owner.data.inventory.deck.Add(entity.data);
    }
    this.reserveContainer.TweenChildPositions();
    this.deckContainer.TweenChildPositions();
    this.StartCoroutine(this.FixLayoutsRoutine());
  }

  public void MoveToReserve(Entity entity)
  {
    if (!entity.InContainerGroup(this.reserveContainer))
    {
      entity.RemoveFromContainers();
      this.reserveContainer.Add(entity);
    }
    if (!this.owner.data.inventory.reserve.Contains(entity.data))
    {
      this.owner.data.inventory.deck.Remove(entity.data);
      this.owner.data.inventory.reserve.Add(entity.data);
    }
    this.reserveContainer.TweenChildPositions();
    this.deckContainer.TweenChildPositions();
    this.StartCoroutine(this.FixLayoutsRoutine());
  }

  public IEnumerator FixLayoutsRoutine()
  {
    Vector2 scrollPosition = this.scrollRect.normalizedPosition;
    this.contentSizeFitter.enabled = false;
    yield return (object) null;
    this.contentSizeFitter.enabled = true;
    this.scrollRect.normalizedPosition = scrollPosition;
  }
}
