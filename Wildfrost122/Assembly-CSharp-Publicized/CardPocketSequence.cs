// Decompiled with JetBrains decompiler
// Type: CardPocketSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class CardPocketSequence : UISequence
{
  [Header("Custom Values")]
  public CardController cardController;
  public Image background;
  public CardContainer container;
  [SerializeField]
  public Vector2 shuffleDelay = new Vector2(0.01f, 0.02f);
  [SerializeField]
  public GameObject backButton;
  [Header("Initial card position/rotation offset")]
  [SerializeField]
  public Vector3 randomOffset;
  [SerializeField]
  public Vector3 randomRotation;
  public readonly List<CardPocketSequence.Card> cards = new List<CardPocketSequence.Card>();

  public void AddCards(CardContainer from)
  {
    foreach (Entity entity in from)
      this.cards.Add(new CardPocketSequence.Card(entity));
    foreach (CardPocketSequence.Card card in (IEnumerable<CardPocketSequence.Card>) this.cards.OrderBy<CardPocketSequence.Card, float>((Func<CardPocketSequence.Card, float>) (_ => PettyRandom.Range(0.0f, 1f))))
    {
      card.Take();
      CardHover hover = card.entity.display?.hover;
      if (hover != null)
        hover.controller = this.cardController;
      this.container.Add(card.entity);
    }
  }

  public IEnumerator ReturnCards()
  {
    foreach (CardPocketSequence.Card card in this.cards)
    {
      card.Return();
      card.ReturnTween();
    }
    this.cards.Clear();
    yield break;
  }

  public override IEnumerator Run()
  {
    CardPocketSequence cardPocketSequence = this;
    cardPocketSequence.cardController.enabled = false;
    cardPocketSequence.gameObject.SetActive(true);
    Routine.Clump clump = new Routine.Clump();
    foreach (Entity entity in (IEnumerable<Entity>) cardPocketSequence.container.OrderBy<Entity, float>((Func<Entity, float>) (_ => PettyRandom.Range(0.0f, 1f))))
    {
      clump.Add(cardPocketSequence.MoveCard(entity));
      yield return (object) Sequences.Wait(cardPocketSequence.shuffleDelay.PettyRandom());
    }
    cardPocketSequence.backButton.SetActive(true);
    yield return (object) clump.WaitForEnd();
    cardPocketSequence.cardController.enabled = true;
    yield return (object) new WaitUntil(new Func<bool>(cardPocketSequence.\u003CRun\u003Eb__10_0));
    cardPocketSequence.promptEnd = false;
    cardPocketSequence.cardController.UnHover();
    cardPocketSequence.backButton.SetActive(false);
    cardPocketSequence.cardController.enabled = false;
    foreach (CardPocketSequence.Card card in cardPocketSequence.cards)
      card.Reset();
    yield return (object) cardPocketSequence.ReturnCards();
    cardPocketSequence.gameObject.SetActive(false);
  }

  public IEnumerator MoveCard(Entity entity)
  {
    this.Move(entity, true);
    yield return (object) Sequences.Wait(PettyRandom.Range(0.01f, 0.3f));
    entity.flipper.FlipUp();
    entity.enabled = true;
  }

  public void FixPosition(Entity entity) => this.Move(entity, false);

  public void Move(Entity entity, bool includeRandomness)
  {
    if (!((UnityEngine.Object) entity.transform.parent == (UnityEngine.Object) this.container.holder))
      return;
    Vector3 childPosition = this.container.GetChildPosition(entity);
    Vector3 childRotation = this.container.GetChildRotation(entity);
    Vector3 childScale = this.container.GetChildScale(entity);
    if (includeRandomness)
    {
      Vector3 a = PettyRandom.Vector3();
      childPosition += Vector3.Scale(a, this.randomOffset);
      childRotation += Vector3.Scale(a, this.randomRotation);
    }
    LeanTween.cancel(entity.gameObject);
    LeanTween.moveLocal(entity.gameObject, childPosition, this.container.movementDurRand.PettyRandom()).setEase(this.container.movementEase);
    LeanTween.rotateLocal(entity.gameObject, childRotation, this.container.movementDurRand.PettyRandom()).setEase(this.container.movementEase);
    LeanTween.scale(entity.gameObject, childScale, this.container.scaleDurRand.PettyRandom()).setEase(this.container.scaleEase);
  }

  public void OpenFrom(Transform transform)
  {
    SfxSystem.OneShot((double) transform.position.x > 0.0 ? "event:/sfx/inventory/deck_opening_right" : "event:/sfx/inventory/deck_opening_left");
  }

  [CompilerGenerated]
  public bool \u003CRun\u003Eb__10_0() => this.promptEnd;

  public class Card
  {
    public readonly Entity entity;
    public CardContainer[] preContainers;
    public CardController preController;
    public bool preInPlay;
    public bool preEnabled;

    public Card(Entity entity) => this.entity = entity;

    public void Reset()
    {
      this.entity.inPlay = this.preInPlay;
      this.entity.enabled = this.preEnabled;
    }

    public void Take()
    {
      this.preContainers = this.entity.containers;
      this.preController = this.entity.display?.hover?.controller;
      this.preInPlay = this.entity.inPlay;
      this.preEnabled = this.entity.enabled;
      this.entity.RemoveFromContainers();
      this.entity.inPlay = false;
    }

    public void Return()
    {
      this.entity.RemoveFromContainers();
      this.entity.enabled = this.preEnabled;
      foreach (CardContainer preContainer in this.preContainers)
        preContainer.Add(this.entity);
      CardHover hover = this.entity.display?.hover;
      if (hover != null)
        hover.controller = this.preController;
      this.entity.inPlay = this.preInPlay;
    }

    public void ReturnTween() => this.entity.TweenToContainer();

    public override string ToString() => this.entity.name;
  }
}
