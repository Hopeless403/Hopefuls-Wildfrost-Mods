// Decompiled with JetBrains decompiler
// Type: BalloonSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
  public RectTransform panel;
  [SerializeField]
  public TMP_Text title;
  [SerializeField]
  public TMP_Text date;
  [SerializeField]
  public LocalizedString titleKey;
  [SerializeField]
  public CardController cardController;
  [SerializeField]
  public DeckDisplayGroup deckDisplayGroup;
  [SerializeField]
  public DailyGenerator dailyGenerator;
  [SerializeField]
  public GameMode gameMode;
  [SerializeField]
  public GameObject playButton;
  [SerializeField]
  public GameObject scoresButton;
  [SerializeField]
  public GameObject timer;
  [SerializeField]
  public HelpPanelShower noConnection;
  [SerializeField]
  public ModifierDisplay modifierDisplay;
  [SerializeField]
  public Scroller scroller;
  [SerializeField]
  public GameObject loadingIcon;
  [SerializeField]
  public HelpPanelShower firstTimeHelp;
  public int seed;
  public bool loading;

  public void OnDisable() => DailyFetcher.CancelFetch();

  public override IEnumerator Sequence()
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

  public IEnumerator CreateCards(IEnumerable<CardData> cardsToCreate)
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

  public static IEnumerator UpdateCardData(Card card)
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
