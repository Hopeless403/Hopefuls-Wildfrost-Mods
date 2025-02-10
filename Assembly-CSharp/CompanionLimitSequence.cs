// Decompiled with JetBrains decompiler
// Type: CompanionLimitSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.UI;

public class CompanionLimitSequence : UISequence
{
  [SerializeField]
  private LocalizedString textKey;
  [SerializeField]
  private string overColourHex = "f66";
  [SerializeField]
  private string underColourHex = "fff";
  [SerializeField]
  private TMP_Text title;
  public Character owner;
  public CardController controller;
  public GameObject background;
  public GameObject container;
  public CardContainer activeContainer;
  public CardContainer reserveContainer;
  public Transform continueButtonHolder;
  public Button continueButton;

  public override IEnumerator Run()
  {
    CompanionLimitSequence companionLimitSequence = this;
    companionLimitSequence.continueButton.interactable = true;
    Routine.Clump clump = new Routine.Clump();
    foreach (CardData data in companionLimitSequence.owner.data.inventory.deck)
    {
      if (data.cardType.name == "Friendly")
        clump.Add(companionLimitSequence.CreateCard(companionLimitSequence.activeContainer, data));
    }
    foreach (CardData data in companionLimitSequence.owner.data.inventory.reserve)
    {
      if (data.cardType.name == "Friendly")
        clump.Add(companionLimitSequence.CreateCard(companionLimitSequence.reserveContainer, data));
    }
    clump.Add(Sequences.Wait(companionLimitSequence.startDelay));
    yield return (object) clump.WaitForEnd();
    companionLimitSequence.SetPositions();
    companionLimitSequence.Resolve();
    companionLimitSequence.background.transform.localScale = new Vector3(0.1f, 0.1f, 1f);
    companionLimitSequence.container.transform.localScale = Vector3.one * 0.5f;
    companionLimitSequence.gameObject.SetActive(true);
    LeanTween.cancel(companionLimitSequence.background);
    LeanTween.scale(companionLimitSequence.background, Vector3.one, companionLimitSequence.tweenInDur).setEase(companionLimitSequence.tweenInEase);
    LeanTween.cancel(companionLimitSequence.container);
    LeanTween.scale(companionLimitSequence.container, Vector3.one, companionLimitSequence.tweenInDur).setEase(companionLimitSequence.tweenInEase);
    yield return (object) Sequences.Wait(companionLimitSequence.tweenInDur);
    // ISSUE: reference to a compiler-generated method
    yield return (object) new WaitUntil(new Func<bool>(companionLimitSequence.\u003CRun\u003Eb__12_0));
    companionLimitSequence.promptEnd = false;
    LeanTween.cancel(companionLimitSequence.background);
    LeanTween.scale(companionLimitSequence.background, Vector3.zero, companionLimitSequence.tweenOutDur).setEase(companionLimitSequence.tweenOutEase);
    LeanTween.cancel(companionLimitSequence.container);
    LeanTween.scale(companionLimitSequence.container, Vector3.zero, companionLimitSequence.tweenOutDur).setEase(companionLimitSequence.tweenOutEase);
    yield return (object) Sequences.Wait(companionLimitSequence.tweenOutDur);
    CompanionLimitSequence.DestroyCards(companionLimitSequence.activeContainer);
    CompanionLimitSequence.DestroyCards(companionLimitSequence.reserveContainer);
    companionLimitSequence.gameObject.SetActive(false);
  }

  private IEnumerator CreateCard(CardContainer container, CardData data)
  {
    Card card = CardManager.Get(data, this.controller, this.owner, false, true);
    container.Add(card.entity);
    container.SetSize(container.Count, 0.67f);
    yield return (object) card.UpdateData(false);
  }

  public void Move(Entity entity)
  {
    if (entity.InContainerGroup(this.activeContainer))
    {
      this.MoveToReserve(entity);
    }
    else
    {
      if (!entity.InContainerGroup(this.reserveContainer))
        return;
      this.MoveToDeck(entity);
    }
  }

  public void MoveToDeck(Entity entity)
  {
    if (!entity.InContainerGroup(this.activeContainer))
    {
      entity.RemoveFromContainers();
      this.activeContainer.Add(entity);
    }
    if (!this.owner.data.inventory.deck.Contains(entity.data))
    {
      this.owner.data.inventory.reserve.Remove(entity.data);
      this.owner.data.inventory.deck.Add(entity.data);
    }
    this.Resolve();
    this.UpdatePositions();
  }

  public void MoveToReserve(Entity entity)
  {
    if (!entity.InContainerGroup(this.reserveContainer))
    {
      entity.RemoveFromContainers();
      this.reserveContainer.Add(entity);
    }
    if (!this.owner.data.inventory.reserve.Contains(entity.data))
    {
      this.owner.data.inventory.deck.Remove(entity.data);
      this.owner.data.inventory.reserve.Add(entity.data);
    }
    this.Resolve();
    this.UpdatePositions();
  }

  public void Toggle()
  {
    if (!this.gameObject.activeSelf)
      this.Begin();
    else
      this.Continue();
  }

  public void Continue()
  {
    this.promptEnd = true;
    this.continueButton.interactable = false;
  }

  private void Resolve()
  {
    int count = this.activeContainer.Count;
    bool flag = count > this.owner.data.companionLimit;
    this.title.text = string.Format(this.textKey.GetLocalizedString(), (object) count, (object) this.owner.data.companionLimit, flag ? (object) this.overColourHex : (object) this.underColourHex);
    this.continueButtonHolder.gameObject.SetActive(!flag);
  }

  private void SetPositions()
  {
    this.activeContainer.SetSize(this.activeContainer.Count, 0.67f);
    this.reserveContainer.SetSize(this.reserveContainer.Count, 0.67f);
    this.activeContainer.SetChildPositions();
    this.reserveContainer.SetChildPositions();
  }

  private void UpdatePositions()
  {
    this.activeContainer.SetSize(this.activeContainer.Count, 0.67f);
    this.reserveContainer.SetSize(this.reserveContainer.Count, 0.67f);
    this.activeContainer.TweenChildPositions();
    this.reserveContainer.TweenChildPositions();
  }

  private static void DestroyCards(CardContainer container)
  {
    foreach (Entity entity in container)
      CardManager.ReturnToPool(entity);
    container.Clear();
  }
}
