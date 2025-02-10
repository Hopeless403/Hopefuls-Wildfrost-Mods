// Decompiled with JetBrains decompiler
// Type: BuildingCardUnlockSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class BuildingCardUnlockSequence : BuildingSequenceWithUnlocks<BuildingCardUnlockSequence>
{
  [SerializeField]
  private CardController controller;
  [SerializeField]
  private Transform owner;
  [SerializeField]
  private CardUnlockSequence cardUnlockSequence;
  [SerializeField]
  private string metaprogressionKey = "companions";
  [SerializeField]
  private string firstGreetKey;

  private void Start() => this._OnStart();

  protected override IEnumerator Sequence()
  {
    BuildingCardUnlockSequence cardUnlockSequence = this;
    int num = Mathf.Min(cardUnlockSequence.locks.Length, cardUnlockSequence.building.type.unlocks.Length);
    for (int index = 0; index < num; ++index)
    {
      if (cardUnlockSequence.building.type.unlocks[index].IsActive)
        cardUnlockSequence.locks[index].SetActive(false);
    }
    yield return (object) cardUnlockSequence.CreateCards();
    if (cardUnlockSequence.building.HasUncheckedUnlocks)
    {
      foreach (string uncheckedUnlock in cardUnlockSequence.building.uncheckedUnlocks)
        yield return (object) cardUnlockSequence.Unlock(uncheckedUnlock);
      Entity top = ((IEnumerable<CardContainer>) cardUnlockSequence.cardSlots).LastOrDefault<CardContainer>((Func<CardContainer, bool>) (a => !a.Empty))?.GetTop();
      if ((bool) (UnityEngine.Object) top)
        cardUnlockSequence.TalkerNewCard(top.data);
    }
    else if (!cardUnlockSequence.firstGreetKey.IsNullOrEmpty() && !SaveSystem.LoadProgressData<bool>(cardUnlockSequence.firstGreetKey, false))
    {
      cardUnlockSequence.TalkerFirstGreet();
      SaveSystem.SaveProgressData<bool>(cardUnlockSequence.firstGreetKey, true);
    }
    else
      cardUnlockSequence.TalkerGreet();
  }

  private IEnumerator Unlock(string unlockDataName)
  {
    BuildingCardUnlockSequence cardUnlockSequence = this;
    int index = ((IEnumerable<UnlockData>) cardUnlockSequence.building.type.unlocks).Select<UnlockData, string>((Func<UnlockData, string>) (a => a.name)).ToList<string>().IndexOf(unlockDataName);
    if (index < 0)
      throw new IndexOutOfRangeException("[" + unlockDataName + "] does not exist in [" + cardUnlockSequence.building.name + "] unlocks list!");
    string assetName = MetaprogressionSystem.Get<List<string>>(cardUnlockSequence.metaprogressionKey)[index];
    List<string> stringList = SaveSystem.LoadProgressData<List<string>>(cardUnlockSequence.building.type.unlockedCheckedKey, new List<string>());
    stringList.Add(unlockDataName);
    SaveSystem.SaveProgressData<List<string>>(cardUnlockSequence.building.type.unlockedCheckedKey, stringList);
    Card card = CardManager.Get(AddressableLoader.Get<CardData>("CardData", assetName), cardUnlockSequence.controller, (Character) null, false, true);
    yield return (object) card.UpdateData(false);
    CardContainer finalSlot = ((IEnumerable<CardContainer>) cardUnlockSequence.cardSlots).FirstOrDefault<CardContainer>((Func<CardContainer, bool>) (a => a.Empty));
    yield return (object) cardUnlockSequence.cardUnlockSequence.Run(card.entity, finalSlot);
    if ((bool) (UnityEngine.Object) finalSlot)
    {
      Image component = finalSlot.GetComponent<Image>();
      if (component != null)
        component.enabled = true;
    }
  }

  private IEnumerator CreateCards()
  {
    BuildingCardUnlockSequence cardUnlockSequence = this;
    List<Entity> cards = new List<Entity>();
    Routine.Clump clump = new Routine.Clump();
    List<string> checkedUnlocks = cardUnlockSequence.building.checkedUnlocks;
    // ISSUE: explicit non-virtual call
    int count = checkedUnlocks != null ? __nonvirtual (checkedUnlocks.Count) : 0;
    List<string> stringList = MetaprogressionSystem.Get<List<string>>(cardUnlockSequence.metaprogressionKey);
    for (int index = 0; index < count && index < stringList.Count; ++index)
    {
      Card card = CardManager.Get(AddressableLoader.Get<CardData>("CardData", stringList[index]), cardUnlockSequence.controller, (Character) null, false, true);
      cards.Add(card.entity);
      clump.Add(card.UpdateData(false));
    }
    yield return (object) clump.WaitForEnd();
    foreach (Entity entity in cards)
    {
      CardContainer cardContainer = ((IEnumerable<CardContainer>) cardUnlockSequence.cardSlots).FirstOrDefault<CardContainer>((Func<CardContainer, bool>) (a => a.Empty));
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
