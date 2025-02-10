// Decompiled with JetBrains decompiler
// Type: BalloonSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class BalloonSequence : BuildingSequence
{
  [SerializeField]
  private RectTransform panel;
  [SerializeField]
  private TMP_Text title;
  [SerializeField]
  private TMP_Text date;
  [SerializeField]
  private LocalizedString titleKey;
  [SerializeField]
  private CardController cardController;
  [SerializeField]
  private DeckDisplayGroup deckDisplayGroup;
  [SerializeField]
  private DailyGenerator dailyGenerator;
  [SerializeField]
  private GameMode gameMode;
  [SerializeField]
  private GameObject playButton;
  [SerializeField]
  private GameObject scoresButton;
  [SerializeField]
  private GameObject timer;
  [SerializeField]
  private HelpPanelShower noConnection;
  [SerializeField]
  private ModifierDisplay modifierDisplay;
  [SerializeField]
  private Scroller scroller;
  [SerializeField]
  private GameObject loadingIcon;
  [SerializeField]
  private HelpPanelShower firstTimeHelp;
  private int seed;
  private bool loading;

  private void OnDisable() => DailyFetcher.CancelFetch();

  protected override IEnumerator Sequence()
  {
    BalloonSequence balloonSequence = this;
    balloonSequence.panel.anchoredPosition = new Vector2(-10f, 0.0f);
    balloonSequence.playButton.SetActive(false);
    balloonSequence.scoresButton.SetActive(false);
    balloonSequence.loadingIcon.SetActive(true);
    yield return (object) DailyFetcher.FetchDateTime();
    if (!DailyFetcher.fetched)
    {
      balloonSequence.noConnection.Show();
      balloonSequence.noConnection.AddButton(0, HelpPanelSystem.ButtonType.Positive, new UnityAction(balloonSequence.Close));
    }
    else
    {
      balloonSequence.loadingIcon.SetActive(false);
      balloonSequence.panel.LeanMove(new Vector3(-0.7f, 0.0f), 1.2f).setFrom(new Vector3(-2.5f, 0.0f)).setEaseOutElastic();
      bool flag = DailyFetcher.CanPlay();
      balloonSequence.playButton.SetActive(flag);
      balloonSequence.timer.SetActive(!flag);
      balloonSequence.scoresButton.SetActive(true);
      balloonSequence.seed = DailyFetcher.GetSeed();
      string localizedString = balloonSequence.titleKey.GetLocalizedString();
      balloonSequence.title.text = localizedString;
      DateTime dateTime = DailyFetcher.GetDateTime();
      Debug.Log((object) string.Format("DailyFetcher → Daily Time: {0}", (object) dateTime));
      CultureInfo cultureInfo = LocalizationSettings.SelectedLocale.Identifier.CultureInfo;
      balloonSequence.date.text = dateTime.ToString("D", (IFormatProvider) cultureInfo);
      yield return (object) balloonSequence.dailyGenerator.Run(balloonSequence.seed, balloonSequence.gameMode);
      List<GameModifierData> modifiers = Campaign.Data.Modifiers;
      if (modifiers != null && modifiers.Count > 0)
      {
        foreach (GameModifierData modifier in Campaign.Data.Modifiers)
          balloonSequence.modifierDisplay.CreateIcon(modifier);
      }
      yield return (object) balloonSequence.CreateCards((IEnumerable<CardData>) References.PlayerData.inventory.deck);
      if (!SaveSystem.LoadProgressData<bool>("dailyRunHelpSeen", false))
      {
        balloonSequence.firstTimeHelp.Show();
        SaveSystem.SaveProgressData<bool>("dailyRunHelpSeen", true);
      }
    }
  }

  private IEnumerator CreateCards(IEnumerable<CardData> cardsToCreate)
  {
    List<Card> cardList = new List<Card>();
    Routine.Clump clump = new Routine.Clump();
    foreach (CardData data in cardsToCreate)
    {
      Card card = CardManager.Get(data, this.cardController, (Character) null, false, true);
      cardList.Add(card);
      card.entity.flipper.FlipDownInstant();
      clump.Add(BalloonSequence.UpdateCardData(card));
    }
    foreach (Card card in cardList)
      this.deckDisplayGroup.AddCard(card);
    yield return (object) clump.WaitForEnd();
    yield return (object) null;
    this.deckDisplayGroup.UpdatePositions();
    if ((bool) (UnityEngine.Object) this.scroller)
      this.scroller.ScrollImmediate(10f);
  }

  private static IEnumerator UpdateCardData(Card card)
  {
    yield return (object) card.UpdateData(false);
    card.entity.flipper.FlipUp(true);
  }

  public void Continue()
  {
    if (!this.enabled)
      return;
    this.enabled = false;
    SaveSystem.SaveProgressData<string>("dailyPlayed", DailyFetcher.GetDateTime().ToString());
    Campaign.Begin();
    Routine routine = new Routine(Transition.To("Campaign"));
  }

  public new void Close() => UnityEngine.Object.FindObjectOfType<BuildingDisplay>()?.End();
}
