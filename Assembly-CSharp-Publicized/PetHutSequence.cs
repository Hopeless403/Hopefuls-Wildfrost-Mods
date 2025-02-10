// Decompiled with JetBrains decompiler
// Type: PetHutSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PetHutSequence : BuildingSequenceWithUnlocks<PetHutSequence>
{
  [SerializeField]
  public CardController controller;
  [SerializeField]
  public CardUnlockSequence cardUnlockSequence;
  [SerializeField]
  public string firstGreetKey = "petHutFirstGreet";

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
    int num = Mathf.Min(petHutSequence.locks.Length, petHutSequence.building.type.unlocks.Length);
    for (int index = 0; index < num; ++index)
    {
      if (petHutSequence.building.type.unlocks[index].IsActive)
        petHutSequence.locks[index].SetActive(false);
    }
    yield return (object) petHutSequence.CreateCards();
    if (petHutSequence.building.HasUncheckedUnlocks)
    {
      foreach (string uncheckedUnlock in petHutSequence.building.uncheckedUnlocks)
        yield return (object) petHutSequence.Unlock(uncheckedUnlock);
      Entity top = ((IEnumerable<CardContainer>) petHutSequence.cardSlots).LastOrDefault<CardContainer>((Func<CardContainer, bool>) (a => !a.Empty))?.GetTop();
      if ((bool) (UnityEngine.Object) top)
        petHutSequence.TalkerNewCard(top.data);
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
    string assetName = index >= 0 ? MetaprogressionSystem.Get<List<string>>("pets")[index] : throw new IndexOutOfRangeException("[" + unlockDataName + "] does not exist in [" + petHutSequence.building.name + "] unlocks list!");
    List<string> stringList = SaveSystem.LoadProgressData<List<string>>(petHutSequence.building.type.unlockedCheckedKey, new List<string>());
    stringList.Add(unlockDataName);
    SaveSystem.SaveProgressData<List<string>>(petHutSequence.building.type.unlockedCheckedKey, stringList);
    Card card = CardManager.Get(AddressableLoader.Get<CardData>("CardData", assetName), petHutSequence.controller, (Character) null, false, true);
    yield return (object) card.UpdateData(false);
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
    foreach (string unlockedPet in MetaprogressionSystem.GetUnlockedPets())
    {
      Card card = CardManager.Get(AddressableLoader.Get<CardData>("CardData", unlockedPet), petHutSequence.controller, (Character) null, false, true);
      cards.Add(card.entity);
      clump.Add(card.UpdateData(false));
    }
    yield return (object) clump.WaitForEnd();
    foreach (Entity entity in cards)
    {
      CardContainer cardContainer = ((IEnumerable<CardContainer>) petHutSequence.cardSlots).FirstOrDefault<CardContainer>((Func<CardContainer, bool>) (a => a.Empty));
      if (cardContainer == null)
        break;
      entity.flipper.FlipUpInstant();
      entity.enabled = true;
      cardContainer.Add(entity);
      cardContainer.SetChildPositions();
      Image component = cardContainer.GetComponent<Image>();
      if (component != null)
        component.enabled = false;
    }
  }
}
