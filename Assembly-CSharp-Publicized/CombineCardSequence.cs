// Decompiled with JetBrains decompiler
// Type: CombineCardSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.UI;

public class CombineCardSequence : MonoBehaviour
{
  [SerializeField]
  public Fader fader;
  [SerializeField]
  public Graphic flash;
  [SerializeField]
  public AnimationCurve flashCurve;
  [SerializeField]
  public AnimationCurve bounceCurve;
  [SerializeField]
  public Transform group;
  [SerializeField]
  public Transform pointPrefab;
  [SerializeField]
  public ParticleSystem ps;
  [SerializeField]
  public LocalizedString titleKey;
  [SerializeField]
  public LocalizedString continueKey;
  [SerializeField]
  public CardSelector cardSelector;
  [SerializeField]
  public ParticleSystem hitPs;
  [SerializeField]
  public GameObject combinedFx;
  [SerializeField]
  public Transform finalEntityParent;
  public readonly List<Transform> points = new List<Transform>();
  public const float cardScale = 0.8f;
  public const float finalCardScale = 1f;

  public IEnumerator Run(string[] cardsToCombine, string resultingCard)
  {
    CardData[] cards = new CardData[cardsToCombine.Length];
    CardData cardDataClone = AddressableLoader.GetCardDataClone(resultingCard);
    for (int index = 0; index < cardsToCombine.Length; ++index)
    {
      string cardName = cardsToCombine[index];
      CardData cardData = References.PlayerData.inventory.deck.FirstOrDefault<CardData>((Func<CardData, bool>) (a => a.name == cardName));
      if ((bool) (UnityEngine.Object) cardData)
        cards[index] = cardData;
    }
    yield return (object) this.Run(cards, cardDataClone);
  }

  public IEnumerator Run(CardData[] cards, CardData finalCard)
  {
    CombineCardSequence combineCardSequence = this;
    CinemaBarSystem.State cinemaBarState = new CinemaBarSystem.State();
    PauseMenu.Block();
    CinemaBarSystem.SetSortingLayer("UI2", 100);
    CinemaBarSystem.In();
    Entity[] entities = combineCardSequence.CreateEntities(cards);
    Entity finalEntity = combineCardSequence.CreateFinalEntity(finalCard);
    Routine.Clump clump = new Routine.Clump();
    foreach (Entity entity in entities)
      clump.Add(entity.display.UpdateData());
    clump.Add(finalEntity.display.UpdateData());
    clump.Add(Sequences.Wait(0.5f));
    yield return (object) clump.WaitForEnd();
    foreach (MonoBehaviourCacheTransform behaviourCacheTransform in entities)
      behaviourCacheTransform.transform.localScale = Vector3.one * 0.8f;
    foreach (Entity entity in entities)
      References.PlayerData.inventory.deck.Remove(entity.data);
    References.PlayerData.inventory.deck.Add(finalEntity.data);
    combineCardSequence.fader.In();
    Vector3 zero = Vector3.zero;
    foreach (Entity entity in entities)
      zero += entity.transform.position;
    Vector3 vector3 = zero / (float) entities.Length;
    combineCardSequence.group.position = vector3;
    foreach (Entity entity in entities)
    {
      Transform p = UnityEngine.Object.Instantiate<Transform>(combineCardSequence.pointPrefab, entity.transform.position, Quaternion.identity, combineCardSequence.group);
      p.gameObject.SetActive(true);
      entity.transform.SetParent(p);
      combineCardSequence.points.Add(p);
      LeanTween.alphaCanvas(((Card) entity.display).canvasGroup, 1f, 0.4f).setEaseInQuad();
    }
    foreach (Transform point in combineCardSequence.points)
      LeanTween.moveLocal(point.gameObject, point.localPosition.normalized, 0.4f).setEaseInQuart();
    yield return (object) new WaitForSeconds(0.4f);
    combineCardSequence.Flash(0.5f);
    Events.InvokeScreenShake();
    foreach (Entity entity in entities)
      entity.wobbler.WobbleRandom();
    combineCardSequence.hitPs.Play();
    foreach (Transform point in combineCardSequence.points)
      LeanTween.moveLocal(point.gameObject, point.localPosition.normalized * 3f, 1f).setEase(combineCardSequence.bounceCurve);
    LeanTween.moveLocal(combineCardSequence.group.gameObject, new Vector3(0.0f, 0.0f, -2f), 1f).setEaseInOutQuad();
    LeanTween.rotateZ(combineCardSequence.group.gameObject, Dead.PettyRandom.Range(160f, 180f), 1f).setOnUpdateVector3(new Action<Vector3>(combineCardSequence.\u003CRun\u003Eb__17_0)).setEaseInOutQuad();
    yield return (object) new WaitForSeconds(1f);
    combineCardSequence.Flash();
    Events.InvokeScreenShake();
    if ((bool) (UnityEngine.Object) combineCardSequence.ps)
      combineCardSequence.ps.Play();
    combineCardSequence.combinedFx.SetActive(true);
    finalEntity.transform.position = Vector3.zero;
    foreach (Entity entity in entities)
      CardManager.ReturnToPool(entity);
    combineCardSequence.group.transform.localRotation = Quaternion.identity;
    double num = (double) finalEntity.curveAnimator.Ping();
    finalEntity.wobbler.WobbleRandom();
    CinemaBarSystem.Top.SetScript(combineCardSequence.titleKey.GetLocalizedString());
    CinemaBarSystem.Bottom.SetPrompt(combineCardSequence.continueKey.GetLocalizedString(), "Select");
    while (!InputSystem.IsButtonPressed("Select"))
      yield return (object) null;
    cinemaBarState.Restore();
    CinemaBarSystem.SetSortingLayer("CinemaBars");
    combineCardSequence.fader.gameObject.Destroy();
    combineCardSequence.cardSelector.character = References.Player;
    combineCardSequence.cardSelector.MoveCardToDeck(finalEntity);
    PauseMenu.Unblock();
  }

  public Entity[] CreateEntities(CardData[] cardDatas)
  {
    Entity[] entities = new Entity[cardDatas.Length];
    float num1 = (double) DeadExtensions.PettyRandom.value > 0.5 ? DeadExtensions.PettyRandom.Range(-45f, 45f) : DeadExtensions.PettyRandom.Range(135f, 225f);
    float num2 = 360f / (float) cardDatas.Length;
    for (int index = 0; index < cardDatas.Length; ++index)
    {
      Card card = CardManager.Get(cardDatas[index], (CardController) null, (Character) null, false, true);
      entities[index] = card.entity;
      Vector2 vector2 = Lengthdir.ToVector2(10f, num1 * ((float) Math.PI / 180f)) + Dead.PettyRandom.Vector2() * 1f;
      card.transform.position = (Vector3) vector2;
      card.transform.localScale = Vector3.zero;
      card.transform.SetParent(this.group);
      card.canvasGroup.alpha = 0.0f;
      num1 += num2;
    }
    return entities;
  }

  public Entity CreateFinalEntity(CardData cardData)
  {
    Card card = CardManager.Get(cardData, (CardController) null, (Character) null, false, true);
    card.transform.localScale = Vector3.one * 1f;
    card.transform.SetParent(this.finalEntityParent);
    return card.entity;
  }

  public void Flash(float intensity = 1f, float duration = 0.15f)
  {
    GameObject gameObject = this.flash.gameObject;
    gameObject.SetActive(true);
    LeanTween.cancel(gameObject);
    LeanTween.value(gameObject, 0.0f, intensity, duration).setEase(this.flashCurve).setOnUpdate((Action<float>) (a => this.flash.color = this.flash.color.With(alpha: a))).setOnComplete((System.Action) (() => this.flash.gameObject.SetActive(false)));
  }

  [CompilerGenerated]
  public void \u003CRun\u003Eb__17_0(Vector3 a)
  {
    foreach (Component point in this.points)
      point.transform.eulerAngles = Vector3.zero;
  }

  [CompilerGenerated]
  public void \u003CFlash\u003Eb__20_0(float a) => this.flash.color = this.flash.color.With(alpha: a);

  [CompilerGenerated]
  public void \u003CFlash\u003Eb__20_1() => this.flash.gameObject.SetActive(false);
}
