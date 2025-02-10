// Decompiled with JetBrains decompiler
// Type: PetHutSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class PetHutSequence : BuildingSequenceWithUnlocks<PetHutSequence>
{
  [SerializeField]
  public Transform rowLayout;
  [SerializeField]
  public Transform rowPrefab;
  [SerializeField]
  public int cardsPerRow = 4;
  [SerializeField]
  public CardContainer slotPrefab;
  [SerializeField]
  public ChallengeDisplayCreator challengeDisplayPrefab;
  [SerializeField]
  public ChallengeData[] challenges;
  [SerializeField]
  public Transform challengeDisplayParent;
  [SerializeField]
  public CardController controller;
  [SerializeField]
  public CardUnlockSequence cardUnlockSequence;
  [SerializeField]
  public string firstGreetKey = "petHutFirstGreet";
  public Entity lastUnlockedCard;

  public void Start()
  {
    this._OnStart();
    this.cardSlots = this.cardSlots.RemoveFromArray<CardContainer>((Func<CardContainer, bool>) (container =>
    {
      ChallengeDisplayCreator componentInChildren = container.transform.parent.gameObject.GetComponentInChildren<ChallengeDisplayCreator>();
      if (!(bool) (UnityEngine.Object) componentInChildren || (bool) (UnityEngine.Object) componentInChildren.challenge)
        return true;
      UnityEngine.Object.Destroy((UnityEngine.Object) container.transform.parent.gameObject);
      return false;
    }));
  }

  public override IEnumerator Sequence()
  {
    PetHutSequence petHutSequence = this;
    yield return (object) petHutSequence.CreateCards();
    for (int index = 0; index < petHutSequence.cardSlots.Length; ++index)
    {
      CardContainer cardSlot = petHutSequence.cardSlots[index];
      Transform transform = cardSlot.transform.Find("Lock");
      if (transform != null && (index == 0 || petHutSequence.building.type.unlocks[index - 1].IsActive))
        transform.gameObject.SetActive(false);
      if (petHutSequence.challenges.Length > index)
      {
        ChallengeData challenge = petHutSequence.challenges[index];
        if (challenge != null)
        {
          ChallengeDisplayCreator challengeDisplayCreator = UnityEngine.Object.Instantiate<ChallengeDisplayCreator>(petHutSequence.challengeDisplayPrefab, petHutSequence.challengeDisplayParent);
          challengeDisplayCreator.transform.position = cardSlot.transform.position;
          challengeDisplayCreator.challenge = challenge;
          challengeDisplayCreator.Check();
        }
      }
    }
    if (petHutSequence.building.HasUncheckedUnlocks)
    {
      foreach (string uncheckedUnlock in petHutSequence.building.uncheckedUnlocks)
        yield return (object) petHutSequence.Unlock(uncheckedUnlock);
      if ((bool) (UnityEngine.Object) petHutSequence.lastUnlockedCard)
        petHutSequence.TalkerNewCard(petHutSequence.lastUnlockedCard.data);
    }
    else if (!petHutSequence.firstGreetKey.IsNullOrEmpty() && !SaveSystem.LoadProgressData<bool>(petHutSequence.firstGreetKey, false))
    {
      petHutSequence.TalkerFirstGreet();
      SaveSystem.SaveProgressData<bool>(petHutSequence.firstGreetKey, true);
    }
    else
      petHutSequence.TalkerGreet();
  }

  public IEnumerator Unlock(string unlockDataName)
  {
    PetHutSequence petHutSequence = this;
    int index = 1 + ((IEnumerable<UnlockData>) petHutSequence.building.type.unlocks).Select<UnlockData, string>((Func<UnlockData, string>) (a => a.name)).ToList<string>().IndexOf(unlockDataName);
    string assetName = index >= 0 ? MetaprogressionSystem.GetAllPets()[index] : throw new IndexOutOfRangeException("[" + unlockDataName + "] does not exist in [" + petHutSequence.building.name + "] unlocks list!");
    List<string> stringList = SaveSystem.LoadProgressData<List<string>>(petHutSequence.building.type.unlockedCheckedKey, new List<string>());
    stringList.Add(unlockDataName);
    SaveSystem.SaveProgressData<List<string>>(petHutSequence.building.type.unlockedCheckedKey, stringList);
    Card card = CardManager.Get(AddressableLoader.Get<CardData>("CardData", assetName), petHutSequence.controller, (Character) null, false, true);
    yield return (object) card.UpdateData(false);
    petHutSequence.lastUnlockedCard = card.entity;
    CardContainer finalSlot = ((IEnumerable<CardContainer>) petHutSequence.cardSlots).FirstOrDefault<CardContainer>((Func<CardContainer, bool>) (a => a.Empty));
    yield return (object) petHutSequence.cardUnlockSequence.Run(card.entity, finalSlot);
    if ((bool) (UnityEngine.Object) finalSlot)
    {
      Image component = finalSlot.GetComponent<Image>();
      if (component != null)
        component.enabled = true;
    }
  }

  public IEnumerator CreateCards()
  {
    PetHutSequence petHutSequence = this;
    List<Entity> cards = new List<Entity>();
    Routine.Clump clump = new Routine.Clump();
    Dictionary<string, string> petDict = MetaprogressionSystem.GetPetDict();
    List<string> checkedUnlocks = petHutSequence.building.checkedUnlocks;
    foreach (KeyValuePair<string, string> keyValuePair in petDict)
    {
      string str1;
      string str2;
      keyValuePair.Deconstruct(ref str1, ref str2);
      string assetName = str1;
      string str3 = str2;
      if (str3 == null || checkedUnlocks != null && checkedUnlocks.Contains(str3))
      {
        Card card = CardManager.Get(AddressableLoader.Get<CardData>("CardData", assetName), petHutSequence.controller, (Character) null, false, true);
        cards.Add(card.entity);
        clump.Add(card.UpdateData(false));
      }
      else
        cards.Add((Entity) null);
    }
    yield return (object) clump.WaitForEnd();
    Transform row = petHutSequence.CreateRow();
    int num = 0;
    for (int index = 0; index < cards.Count; ++index)
    {
      CardContainer slot = petHutSequence.CreateSlot(row);
      petHutSequence.cardSlots = petHutSequence.cardSlots.AddToArray<CardContainer>(slot);
      if (++num >= petHutSequence.cardsPerRow)
      {
        row = petHutSequence.CreateRow();
        num = 0;
      }
    }
    yield return (object) null;
    for (int index = 0; index < cards.Count; ++index)
    {
      Entity entity = cards[index];
      if ((bool) (UnityEngine.Object) entity)
      {
        CardContainer cardSlot = petHutSequence.cardSlots[index];
        entity.flipper.FlipUpInstant();
        entity.enabled = true;
        cardSlot.Add(entity);
        cardSlot.SetChildPositions();
        Image component = cardSlot.GetComponent<Image>();
        if (component != null)
          component.enabled = false;
      }
    }
  }

  public CardContainer CreateSlot(Transform parent)
  {
    return UnityEngine.Object.Instantiate<CardContainer>(this.slotPrefab, parent);
  }

  public Transform CreateRow() => UnityEngine.Object.Instantiate<Transform>(this.rowPrefab, this.rowLayout);
}
