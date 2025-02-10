// Decompiled with JetBrains decompiler
// Type: ChooseNewCompanion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class ChooseNewCompanion : UISequence
{
  [SerializeField]
  public UISequence sequence;
  [SerializeField]
  public CardSelector cardSelector;
  [SerializeField]
  public CardController cardController;
  [SerializeField]
  public CardContainer cardContainer;
  [SerializeField]
  public int rewardOptions = 3;
  [Header("Banners")]
  [SerializeField]
  public RectTransform topBanner;
  [SerializeField]
  public RectTransform bottomBanner;
  [SerializeField]
  public RectTransform background;
  [SerializeField]
  public Vector2 bannerTweenDur = new Vector2(0.9f, 1.1f);
  [SerializeField]
  public LeanTweenType bannerTweenEase = LeanTweenType.easeOutBounce;
  [SerializeField]
  public Vector2 bannerTweenOutDur = new Vector2(0.3f, 0.4f);
  [SerializeField]
  public LeanTweenType bannerTweenOutEase = LeanTweenType.easeInBack;
  public CardData[] storedRewards;

  public override IEnumerator Run()
  {
    ChooseNewCompanion chooseNewCompanion = this;
    chooseNewCompanion.Populate();
    chooseNewCompanion.gameObject.SetActive(true);
    if ((Object) chooseNewCompanion.background != (Object) null)
    {
      chooseNewCompanion.background.gameObject.SetActive(true);
      chooseNewCompanion.background.localScale = Vector3.zero;
      yield return (object) null;
      chooseNewCompanion.background.LeanScale(Vector3.one, 1f).setEase(LeanTweenType.easeOutElastic);
      yield return (object) Sequences.Wait(0.25f);
    }
    if ((Object) chooseNewCompanion.topBanner != (Object) null)
    {
      chooseNewCompanion.topBanner.gameObject.SetActive(true);
      Vector3 localPosition = chooseNewCompanion.topBanner.localPosition;
      chooseNewCompanion.topBanner.localPosition = localPosition.WithY(localPosition.y + 5f);
      LeanTween.cancel(chooseNewCompanion.topBanner.gameObject);
      LeanTween.moveLocal(chooseNewCompanion.topBanner.gameObject, localPosition, chooseNewCompanion.bannerTweenDur.PettyRandom()).setEase(chooseNewCompanion.bannerTweenEase);
    }
    if ((Object) chooseNewCompanion.bottomBanner != (Object) null)
    {
      chooseNewCompanion.bottomBanner.gameObject.SetActive(true);
      Vector3 localPosition = chooseNewCompanion.bottomBanner.localPosition;
      chooseNewCompanion.bottomBanner.localPosition = localPosition.WithY(localPosition.y - 5f);
      LeanTween.cancel(chooseNewCompanion.bottomBanner.gameObject);
      LeanTween.moveLocal(chooseNewCompanion.bottomBanner.gameObject, localPosition, chooseNewCompanion.bannerTweenDur.PettyRandom()).setEase(chooseNewCompanion.bannerTweenEase);
    }
    chooseNewCompanion.sequence.gameObject.SetActive(true);
    yield return (object) chooseNewCompanion.sequence.Run();
    if ((Object) chooseNewCompanion.background != (Object) null)
    {
      chooseNewCompanion.background.LeanScale(Vector3.zero, chooseNewCompanion.tweenOutDur).setEase(LeanTweenType.easeInBack);
      yield return (object) Sequences.Wait(chooseNewCompanion.tweenOutDur);
    }
    if ((Object) chooseNewCompanion.topBanner != (Object) null)
    {
      LeanTween.cancel(chooseNewCompanion.topBanner.gameObject);
      LeanTween.moveLocal(chooseNewCompanion.topBanner.gameObject, chooseNewCompanion.topBanner.localPosition.WithY(chooseNewCompanion.topBanner.localPosition.y + 5f), chooseNewCompanion.bannerTweenOutDur.PettyRandom()).setEase(chooseNewCompanion.bannerTweenOutEase);
    }
    if ((Object) chooseNewCompanion.bottomBanner != (Object) null)
    {
      LeanTween.cancel(chooseNewCompanion.bottomBanner.gameObject);
      LeanTween.moveLocal(chooseNewCompanion.bottomBanner.gameObject, chooseNewCompanion.bottomBanner.localPosition.WithY(chooseNewCompanion.bottomBanner.localPosition.y - 5f), chooseNewCompanion.bannerTweenOutDur.PettyRandom()).setEase(chooseNewCompanion.bannerTweenOutEase);
    }
  }

  public void Populate()
  {
    Character player = References.Player;
    this.cardSelector.character = player;
    this.cardController.owner = player;
    if (this.storedRewards == null || this.storedRewards.Length == 0)
    {
      this.storedRewards = player.GetComponent<CharacterRewards>().Pull<CardData>((object) this, "Units", this.rewardOptions);
      Debug.Log((object) ("Unit Reward Options: [" + string.Join<CardData>(", ", (IEnumerable<CardData>) this.storedRewards) + "]"));
    }
    this.cardContainer.SetSize(this.storedRewards.Length, 0.8f);
    this.cardContainer.owner = player;
    Routine.Clump clump = new Routine.Clump();
    foreach (CardData storedReward in this.storedRewards)
    {
      Card card = CardManager.Get(storedReward.Clone(), this.cardController, player, false, true);
      card.entity.flipper.FlipDownInstant();
      this.cardContainer.Add(card.entity);
      clump.Add(card.UpdateData(false));
    }
    foreach (Entity child in this.cardContainer)
    {
      Transform transform = child.transform;
      transform.localPosition = this.cardContainer.GetChildPosition(child);
      transform.localScale = this.cardContainer.GetChildScale(child);
      transform.localEulerAngles = this.cardContainer.GetChildRotation(child);
    }
  }
}
