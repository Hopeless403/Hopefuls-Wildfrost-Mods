﻿// Decompiled with JetBrains decompiler
// Type: EventRoutineInjuredCompanion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class EventRoutineInjuredCompanion : EventRoutine
{
  [SerializeField]
  public ChooseNewCardSequence sequence;
  [SerializeField]
  public CardController cardController;
  [SerializeField]
  public CardContainer cardContainer;
  [SerializeField]
  public CardSelector cardSelector;
  [SerializeField]
  public InspectNewUnitSequence inspectSequence;
  [SerializeField]
  public StatusEffectData injuryEffect;
  [SerializeField]
  public SpriteRenderer[] bloodSplats;
  [SerializeField]
  public PromptShower tutorialPrompt;
  [SerializeField]
  public GameObject missingDataDisplay;

  public override IEnumerator Populate()
  {
    EventRoutineInjuredCompanion injuredCompanion = this;
    CardSaveData cardSaveData = injuredCompanion.data.Get<CardSaveData>("cardSaveData");
    if (!MissingCardSystem.IsMissing(cardSaveData))
    {
      CardData cardData = cardSaveData.Load(false);
      injuredCompanion.AddInjuryIfNecessary(cardData);
      cardData.upgrades.RemoveWhere<CardUpgradeData>((Predicate<CardUpgradeData>) (a => a.type == CardUpgradeData.Type.Crown));
      yield return (object) injuredCompanion.CreateCard(cardData);
    }
    else
    {
      injuredCompanion.missingDataDisplay.SetActive(true);
      injuredCompanion.End();
    }
  }

  public void AddInjuryIfNecessary(CardData cardData)
  {
    CardData cardData1 = cardData;
    if (cardData1.injuries == null)
      cardData1.injuries = new List<CardData.StatusEffectStacks>();
    if (cardData.injuries.Count > 0)
      return;
    cardData.injuries.Add(new CardData.StatusEffectStacks(this.injuryEffect, 1));
  }

  public override IEnumerator Run()
  {
    EventRoutineInjuredCompanion injuredCompanion = this;
    CinemaBarSystem.In();
    if (injuredCompanion.cardContainer.Count > 0)
      injuredCompanion.tutorialPrompt.Show((object) injuredCompanion.cardContainer[0].data.title);
    yield return (object) Sequences.Wait(0.1f);
    yield return (object) injuredCompanion.sequence.Run();
    CinemaBarSystem.Clear();
    injuredCompanion.node.SetCleared();
  }

  public IEnumerator CreateCard(CardData cardDataClone)
  {
    EventRoutineInjuredCompanion injuredCompanion = this;
    injuredCompanion.cardSelector.character = injuredCompanion.player;
    injuredCompanion.cardController.owner = injuredCompanion.player;
    injuredCompanion.cardContainer.SetSize(1, 0.8f);
    injuredCompanion.cardContainer.owner = injuredCompanion.player;
    Card card = CardManager.Get(cardDataClone, injuredCompanion.cardController, injuredCompanion.player, false, true);
    card.entity.flipper.FlipDownInstant();
    injuredCompanion.cardContainer.Add(card.entity);
    injuredCompanion.SetBloodSplatColours(card.entity);
    yield return (object) card.UpdateData(false);
    foreach (Entity child in injuredCompanion.cardContainer)
    {
      Transform transform = child.transform;
      transform.localPosition = injuredCompanion.cardContainer.GetChildPosition(child);
      transform.localScale = injuredCompanion.cardContainer.GetChildScale(child);
      transform.localEulerAngles = injuredCompanion.cardContainer.GetChildRotation(child);
    }
  }

  public void SetBloodSplatColours(Entity entity)
  {
    Color bloodColour = UnityEngine.Object.FindObjectOfType<SplatterSystem>().GetBloodColour(entity);
    foreach (SpriteRenderer bloodSplat in this.bloodSplats)
      bloodSplat.color = bloodColour;
  }

  public void TrySelect(Entity entity)
  {
    ActionSelect action = new ActionSelect(entity, (Action<Entity>) (e =>
    {
      this.inspectSequence.SetUnit(entity);
      this.inspectSequence.Begin();
      this.cardController.enabled = false;
      this.cardController.UnHover(entity);
    }));
    if (!Events.CheckAction((PlayAction) action))
      return;
    ActionQueue.Add((PlayAction) action);
  }

  public void CardSelected(Entity entity)
  {
    Events.InvokeEntityChosen(entity);
    this.End();
  }

  public void End()
  {
    this.sequence.End();
    this.cardController.enabled = false;
    this.tutorialPrompt.Hide();
  }
}
