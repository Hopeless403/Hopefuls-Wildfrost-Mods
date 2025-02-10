// Decompiled with JetBrains decompiler
// Type: ChooseNewCardSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ChooseNewCardSequence : UISequence
{
  public Character owner;
  public RectTransform background;
  public float cardFlipDelay = 0.5f;
  public float cardFlipPauseBetween = 0.25f;
  [SerializeField]
  public GameObject cardGroupLayout;
  [SerializeField]
  public GameObject skipButtonLayout;
  public CardController cardController;
  public CardContainer cardContainer;
  public CardSelector cardSelector;
  [SerializeField]
  public Button skipButton;
  [SerializeField]
  public bool canSkip;
  [SerializeField]
  public int skipGold = 20;
  [SerializeField]
  public TweenUI endTween;

  public override IEnumerator Run()
  {
    ChooseNewCardSequence chooseNewCardSequence = this;
    chooseNewCardSequence.cardGroupLayout.SetActive(false);
    if ((bool) (Object) chooseNewCardSequence.skipButtonLayout)
      chooseNewCardSequence.skipButtonLayout.SetActive(false);
    if ((bool) (Object) chooseNewCardSequence.background)
      chooseNewCardSequence.background.gameObject.SetActive(false);
    yield return (object) Sequences.Wait(chooseNewCardSequence.startDelay);
    chooseNewCardSequence.gameObject.SetActive(true);
    if ((bool) (Object) chooseNewCardSequence.background)
    {
      chooseNewCardSequence.background.gameObject.SetActive(true);
      chooseNewCardSequence.background.localScale = Vector3.zero;
      yield return (object) null;
      chooseNewCardSequence.background.LeanScale(Vector3.one, 1f).setEase(LeanTweenType.easeOutElastic);
      yield return (object) Sequences.Wait(0.25f);
    }
    chooseNewCardSequence.cardGroupLayout.SetActive(true);
    if (chooseNewCardSequence.canSkip && (bool) (Object) chooseNewCardSequence.skipButtonLayout)
      chooseNewCardSequence.skipButtonLayout.SetActive(true);
    yield return (object) Sequences.Wait(chooseNewCardSequence.cardFlipDelay);
    if ((bool) (Object) chooseNewCardSequence.cardContainer)
    {
      int dir = Dead.Random.Sign();
      int cardCount = chooseNewCardSequence.cardContainer.Count;
      for (int i = 0; i < cardCount; ++i)
      {
        chooseNewCardSequence.cardContainer[dir == 1 ? i : cardCount - 1 - i].flipper.FlipUp();
        yield return (object) Sequences.Wait(chooseNewCardSequence.cardFlipPauseBetween);
      }
    }
    while (!chooseNewCardSequence.promptEnd)
      yield return (object) null;
    chooseNewCardSequence.cardController.Disable();
    if ((bool) (Object) chooseNewCardSequence.skipButton)
      chooseNewCardSequence.skipButton.interactable = false;
    if ((bool) (Object) chooseNewCardSequence.background)
      chooseNewCardSequence.background.LeanScale(Vector3.zero, chooseNewCardSequence.tweenOutDur).setEase(LeanTweenType.easeInBack);
    if ((bool) (Object) chooseNewCardSequence.endTween)
    {
      chooseNewCardSequence.endTween.Fire();
      yield return (object) new WaitForSeconds(chooseNewCardSequence.endTween.GetDuration());
    }
    foreach (Entity entity in chooseNewCardSequence.cardContainer)
    {
      if ((bool) (Object) entity && (bool) (Object) entity.gameObject)
        CardManager.ReturnToPool(entity);
    }
    yield return (object) SceneManager.WaitUntilUnloaded("CardCombine");
    chooseNewCardSequence.gameObject.SetActive(false);
  }

  public void Skip()
  {
    if (this.skipGold > 0 && (bool) (Object) this.owner?.data?.inventory)
      Events.InvokeDropGold(this.skipGold, "SkipReward", this.owner, this.skipButton.transform.position);
    this.cardController.Disable();
    this.End();
    this.skipButton.interactable = false;
  }

  public void TakeFirstCard()
  {
    if (this.promptEnd)
      return;
    this.cardSelector.TakeFirstCard(this.cardContainer);
    this.cardController.Disable();
  }
}
