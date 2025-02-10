// Decompiled with JetBrains decompiler
// Type: GainNegativeCharmSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class GainNegativeCharmSequence : MonoBehaviour
{
  [SerializeField]
  public GameObject holderGroup;
  [SerializeField]
  public CardCharmHolder[] holders;
  [SerializeField]
  public CardCharmHolder activeCharmHolder;
  [SerializeField]
  public GameObject cardGridGroup;
  [SerializeField]
  public DeckDisplayGroup deckDisplayGroup;
  [SerializeField]
  public CardController cardController;
  [SerializeField]
  public CardUpgradeData[] charmOptions;
  [SerializeField]
  public CinemaBarShower cinemaBarShower;
  [SerializeField]
  public Fader backgroundFader;
  public bool charmChosen;
  public bool promptEnd;

  public IEnumerator Run()
  {
    GainNegativeCharmSequence negativeCharmSequence = this;
    CampaignNode characterNode = Campaign.FindCharacterNode(References.Player);
    UnityEngine.Random.State state = UnityEngine.Random.state;
    UnityEngine.Random.InitState(characterNode.seed);
    negativeCharmSequence.CreateUpgrades();
    UnityEngine.Random.state = state;
    yield return (object) new WaitUntil(new Func<bool>(negativeCharmSequence.\u003CRun\u003Eb__11_0));
    negativeCharmSequence.cinemaBarShower.Hide();
    negativeCharmSequence.backgroundFader.Out(0.25f);
    yield return (object) new WaitForSeconds(0.5f);
  }

  public void CreateUpgrades()
  {
    List<CardUpgradeData> list = new List<CardUpgradeData>((IEnumerable<CardUpgradeData>) this.charmOptions);
    list.Shuffle<CardUpgradeData>();
    int length = this.holders.Length;
    foreach (CardUpgradeData upgradeData in list)
    {
      if (this.UpgradeCanBeAssignedToSomethingInDeck(upgradeData))
      {
        this.CreateUpgrade(upgradeData.Clone());
        if (--length <= 0)
          break;
      }
    }
  }

  public bool UpgradeCanBeAssignedToSomethingInDeck(CardUpgradeData upgradeData)
  {
    foreach (CardData cardData in References.PlayerData.inventory.deck)
    {
      if (upgradeData.CanAssign(cardData))
        return true;
    }
    return false;
  }

  public void CreateUpgrade(CardUpgradeData upgradeDataClone)
  {
    CardCharmHolder cardCharmHolder = ((IEnumerable<CardCharmHolder>) this.holders).FirstOrDefault<CardCharmHolder>((Func<CardCharmHolder, bool>) (a => a.transform.childCount == 0));
    if (!(bool) (UnityEngine.Object) cardCharmHolder)
      return;
    UpgradeDisplay upgrade = cardCharmHolder.Create(upgradeDataClone);
    CardCharmInteraction component = upgrade.GetComponent<CardCharmInteraction>();
    component.popUpOffset = new Vector2(0.8f, -0.25f);
    component.onDrag.AddListener((UnityAction<UpgradeDisplay>) (_ => this.Take(upgrade)));
  }

  public void Take(UpgradeDisplay upgrade)
  {
    if (this.charmChosen)
      return;
    this.charmChosen = true;
    this.activeCharmHolder.Create(upgrade.data);
    this.holderGroup.SetActive(false);
    this.StartCoroutine(this.OpenCardGrid(upgrade.data));
  }

  public IEnumerator OpenCardGrid(CardUpgradeData upgradeData)
  {
    this.cardGridGroup.SetActive(true);
    Routine.Clump clump = new Routine.Clump();
    foreach (CardData cardData in References.PlayerData.inventory.deck)
    {
      if (upgradeData.CanAssign(cardData))
        clump.Add(this.CreateCard(cardData));
    }
    yield return (object) clump.WaitForEnd();
    this.deckDisplayGroup.UpdatePositions();
    yield return (object) ((RectTransform) this.deckDisplayGroup.transform.parent).FixLayoutGroup();
    yield return (object) this.FlipCardsUp();
  }

  public void HideCardGrid()
  {
    LeanTween.cancel(this.cardGridGroup);
    LeanTween.scale(this.cardGridGroup, Vector3.zero, 0.33f).setEaseInBack();
  }

  public IEnumerator FlipCardsUp()
  {
    foreach (Entity entity in (CardContainer) this.deckDisplayGroup.grids[0])
    {
      entity.flipper.FlipUp(true);
      yield return (object) new WaitForSeconds(PettyRandom.Range(0.0f, 0.1f));
    }
  }

  public IEnumerator CreateCard(CardData cardData)
  {
    Card card = CardManager.Get(cardData, this.cardController, References.Player, false, true);
    this.deckDisplayGroup.AddCard(card);
    card.entity.flipper.FlipDownInstant();
    yield return (object) card.UpdateData(false);
  }

  public void End() => this.promptEnd = true;

  [CompilerGenerated]
  public bool \u003CRun\u003Eb__11_0() => this.promptEnd;
}
