// Decompiled with JetBrains decompiler
// Type: CardFramesUnlockedSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;

public class CardFramesUnlockedSequence : MonoBehaviour
{
  [SerializeField]
  public LocalizedString chiseledFrameUnlocked;
  [SerializeField]
  public LocalizedString chiseledFramesUnlocked;
  [SerializeField]
  public LocalizedString goldFrameUnlocked;
  [SerializeField]
  public LocalizedString goldFramesUnlocked;
  [SerializeField]
  public TMP_Text text;
  [SerializeField]
  public CardHand container1;
  [SerializeField]
  public CardHand container2;
  [SerializeField]
  public CardController cardController;
  [SerializeField]
  public GameObject group;
  [Header("Dynamic Positioning Based")]
  [SerializeField]
  public AnimationCurve angleAddBasedOnCount;
  [SerializeField]
  public AnimationCurve zPositionBasedOnCount;
  public const int splitTo2ndContainerThreshold = 3;
  public const float cardScale = 0.67f;

  public IEnumerator Run(int level, string[] cards)
  {
    this.text.text = (level == 1 ? (cards.Length > 1 ? this.chiseledFramesUnlocked : this.chiseledFrameUnlocked) : (cards.Length > 1 ? this.goldFramesUnlocked : this.goldFrameUnlocked)).GetLocalizedString().Format((object) cards.Length);
    yield return (object) this.CreateCards(cards);
  }

  public IEnumerator CreateCards(string[] cards)
  {
    this.SetScaleAndPosition(cards.Length);
    Routine.Clump clump = new Routine.Clump();
    int size = cards.Length > 3 ? Mathf.CeilToInt((float) cards.Length / 2f) : cards.Length;
    this.container1.SetSize(size, 0.67f);
    this.container2.SetSize(cards.Length - size, 0.67f);
    for (int index = 0; index < cards.Length; ++index)
    {
      string card = cards[index];
      CardHand cardHand = index < size ? this.container1 : this.container2;
      CardData cardData = AddressableLoader.Get<CardData>("CardData", card);
      if ((Object) cardData != (Object) null)
        clump.Add(this.CreateCard(cardData, (CardContainer) cardHand, false));
    }
    yield return (object) clump.WaitForEnd();
    this.group.SetActive(true);
    this.container1.SetChildPositions();
    this.container2.SetChildPositions();
  }

  public void SetScaleAndPosition(int numberOfCards)
  {
    float num1 = this.angleAddBasedOnCount.Evaluate((float) numberOfCards);
    float num2 = this.zPositionBasedOnCount.Evaluate((float) numberOfCards);
    this.container1.fanCircleAngleAdd = num1;
    this.container2.fanCircleAngleAdd = num1;
    this.container1.transform.localPosition = this.container1.transform.localPosition.WithZ(num2);
    this.container2.transform.localPosition = this.container2.transform.localPosition.WithZ(num2);
    if (numberOfCards > 3)
      return;
    this.container1.transform.localPosition = this.container1.transform.localPosition.WithY(0.0f);
  }

  public IEnumerator CreateCard(CardData cardData, CardContainer cardContainer, bool startFlipped)
  {
    Card card = CardManager.Get(cardData, this.cardController, (Character) null, false, true);
    if (startFlipped)
      card.entity.flipper.FlipDownInstant();
    cardContainer.Add(card.entity);
    yield return (object) card.UpdateData(false);
    if (startFlipped)
      card.entity.flipper.FlipUp(true);
  }

  public void End()
  {
    this.container1.DestroyAll();
    this.container2.DestroyAll();
    this.gameObject.SetActive(false);
    Routine routine = new Routine(SceneManager.Unload("CardFramesUnlocked"));
  }
}
