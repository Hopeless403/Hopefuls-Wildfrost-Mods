// Decompiled with JetBrains decompiler
// Type: CompanionRecoverSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CompanionRecoverSequence : UISequence
{
  public Character owner;
  [SerializeField]
  public TweenUI revealTween;
  [SerializeField]
  public TweenUI hideTween;
  [SerializeField]
  public CardContainer container;
  [SerializeField]
  public CardController controller;
  [SerializeField]
  public Button continueButton;
  [SerializeField]
  [Range(0.0f, 1f)]
  public float cardScale = 0.75f;

  public void OnEnable()
  {
    this.continueButton.interactable = true;
    this.controller.Enable();
  }

  public void OnDisable() => this.Clear();

  public IEnumerator CreateCards(IEnumerable<CardData> cards)
  {
    Routine.Clump clump = new Routine.Clump();
    foreach (CardData card in cards)
      clump.Add(this.CreateCard(card));
    yield return (object) clump.WaitForEnd();
  }

  public IEnumerator CreateCard(CardData data)
  {
    Card card = CardManager.Get(data, this.controller, this.owner, false, true);
    this.container.Add(card.entity);
    this.container.max = this.container.Count;
    yield return (object) card.UpdateData(false);
  }

  public void Clear()
  {
    foreach (Entity entity in this.container)
      CardManager.ReturnToPool(entity);
    this.container.Clear();
  }

  public CardData[] FindRecoveries()
  {
    List<CardData> cardDataList = new List<CardData>();
    foreach (CardData cardData in this.owner.data.inventory.deck.Where<CardData>(new Func<CardData, bool>(CompanionRecoverSequence.IsInjured)))
      cardDataList.Add(cardData);
    foreach (CardData cardData in this.owner.data.inventory.reserve.Where<CardData>(new Func<CardData, bool>(CompanionRecoverSequence.IsInjured)))
      cardDataList.Add(cardData);
    Debug.Log((object) ("Injured companions: [" + string.Join<CardData>(", ", (IEnumerable<CardData>) cardDataList) + "]"));
    CardData[] injuriesThisBattle = InjurySystem.GetInjuriesThisBattle();
    if (injuriesThisBattle.Length != 0)
    {
      cardDataList.RemoveMany<CardData>((ICollection<CardData>) injuriesThisBattle);
      Debug.Log((object) ("[" + string.Join(", ", (object[]) injuriesThisBattle) + "] cannot recover since they died last battle!"));
    }
    return cardDataList.ToArray();
  }

  public static bool IsInjured(CardData card) => card.injuries != null && card.injuries.Count > 0;

  public override IEnumerator Run()
  {
    CompanionRecoverSequence companionRecoverSequence = this;
    CardData[] recoveries = companionRecoverSequence.FindRecoveries();
    if (recoveries.Length != 0)
    {
      companionRecoverSequence.Clear();
      CompanionRecoverSequence.RemoveInjuries((IEnumerable<CardData>) recoveries);
      Routine.Clump clump = new Routine.Clump();
      yield return (object) companionRecoverSequence.CreateCards((IEnumerable<CardData>) recoveries);
      clump.Add(Sequences.Wait(companionRecoverSequence.startDelay));
      yield return (object) clump.WaitForEnd();
      companionRecoverSequence.container.SetChildPositions();
      companionRecoverSequence.gameObject.SetActive(true);
      yield return (object) Sequences.Wait(companionRecoverSequence.revealTween.GetDuration());
      yield return (object) new WaitUntil(new Func<bool>(companionRecoverSequence.\u003CRun\u003Eb__14_0));
      companionRecoverSequence.hideTween.Fire();
      companionRecoverSequence.promptEnd = false;
    }
  }

  public static void RemoveInjuries(IEnumerable<CardData> targets)
  {
    foreach (CardData target in targets)
      target.injuries.Clear();
  }

  [CompilerGenerated]
  public bool \u003CRun\u003Eb__14_0() => this.promptEnd;
}
