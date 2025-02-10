// Decompiled with JetBrains decompiler
// Type: GainNegativeCharmSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class GainNegativeCharmSequence : MonoBehaviour
{
  [SerializeField]
  private GameObject holderGroup;
  [SerializeField]
  private CardCharmHolder[] holders;
  [SerializeField]
  private CardCharmHolder activeCharmHolder;
  [SerializeField]
  private GameObject cardGridGroup;
  [SerializeField]
  private DeckDisplayGroup deckDisplayGroup;
  [SerializeField]
  private CardController cardController;
  [SerializeField]
  private CardUpgradeData[] charmOptions;
  [SerializeField]
  private CinemaBarShower cinemaBarShower;
  [SerializeField]
  private Fader backgroundFader;
  private bool charmChosen;
  private bool promptEnd;

  public IEnumerator Run()
  {
    GainNegativeCharmSequence negativeCharmSequence = this;
    CampaignNode characterNode = Campaign.FindCharacterNode(References.Player);
    UnityEngine.Random.State state = UnityEngine.Random.state;
    UnityEngine.Random.InitState(characterNode.seed);
    negativeCharmSequence.CreateUpgrades();
    UnityEngine.Random.state = state;
    // ISSUE: reference to a compiler-generated method
    yield return (object) new WaitUntil(new Func<bool>(negativeCharmSequence.\u003CRun\u003Eb__11_0));
    negativeCharmSequence.cinemaBarShower.Hide();
    negativeCharmSequence.backgroundFader.Out(0.25f);
    yield return (object) new WaitForSeconds(0.5f);
  }

  private void CreateUpgrades()
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

  private bool UpgradeCanBeAssignedToSomethingInDeck(CardUpgradeData upgradeData)
  {
    foreach (CardData cardData in References.PlayerData.inventory.deck)
    {
      if (upgradeData.CanAssign(cardData))
        return true;
    }
    return false;
  }

  private void CreateUpgrade(CardUpgradeData upgradeDataClone)
  {
    CardCharmHolder cardCharmHolder = ((IEnumerable<CardCharmHolder>) this.holders).FirstOrDefault<CardCharmHolder>((Func<CardCharmHolder, bool>) (a => a.transform.childCount == 0));
    if (!(bool) (UnityEngine.Object) cardCharmHolder)
      return;
    UpgradeDisplay upgrade = cardCharmHolder.Create(upgradeDataClone);
    CardCharmInteraction component = upgrade.GetComponent<CardCharmInteraction>();
    component.popUpOffset = new Vector2(0.8f, -0.25f);
    component.onDrag.AddListener((UnityAction<UpgradeDisplay>) (_ => this.Take(upgrade)));
  }

  private void Take(UpgradeDisplay upgrade)
  {
    if (this.charmChosen)
      return;
    this.charmChosen = true;
    this.activeCharmHolder.Create(upgrade.data);
    this.holderGroup.SetActive(false);
    this.StartCoroutine(this.OpenCardGrid(upgrade.data));
  }

  private IEnumerator OpenCardGrid(CardUpgradeData upgradeData)
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

  private IEnumerator FlipCardsUp()
  {
    foreach (Entity entity in (CardContainer) this.deckDisplayGroup.grids[0])
    {
      entity.flipper.FlipUp(true);
      yield return (object) new WaitForSeconds(PettyRandom.Range(0.0f, 0.1f));
    }
  }

  private IEnumerator CreateCard(CardData cardData)
  {
    Card card = CardManager.Get(cardData, this.cardController, References.Player, false, true);
    this.deckDisplayGroup.AddCard(card);
    card.entity.flipper.FlipDownInstant();
    yield return (object) card.UpdateData(false);
  }

  public void End() => this.promptEnd = true;
}
