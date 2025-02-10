// Decompiled with JetBrains decompiler
// Type: CardControllerDeck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CardControllerDeck : CardController
{
  [SerializeField]
  private DeckDisplaySequence deckDisplaySequence;
  public CardContainer deckContainer;
  public CardContainer reserveContainer;
  [SerializeField]
  private DeckSelectSequence selectSequence;
  [SerializeField]
  private ScrollRect scrollRect;
  [SerializeField]
  private ContentSizeFitter contentSizeFitter;

  protected override bool AllowDynamicSelectRelease => false;

  protected override void Press()
  {
    if (!(bool) (Object) this.pressEntity)
      return;
    this.StartCoroutine(this.OpenMenu(this.pressEntity));
  }

  private IEnumerator OpenMenu(Entity entity)
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

  private IEnumerator FixLayoutsRoutine()
  {
    Vector2 scrollPosition = this.scrollRect.normalizedPosition;
    this.contentSizeFitter.enabled = false;
    yield return (object) null;
    this.contentSizeFitter.enabled = true;
    this.scrollRect.normalizedPosition = scrollPosition;
  }
}
