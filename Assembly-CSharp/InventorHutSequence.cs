// Decompiled with JetBrains decompiler
// Type: InventorHutSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class InventorHutSequence : BuildingSequenceWithUnlocks<InventorHutSequence>
{
  [SerializeField]
  private CardController controller;
  [SerializeField]
  private CardUnlockSequence cardUnlockSequence;
  [SerializeField]
  private string firstGreetKey = "inventorFirstGreet";

  private void Start() => this._OnStart();

  protected override IEnumerator Sequence()
  {
    InventorHutSequence inventorHutSequence = this;
    int num = Mathf.Min(inventorHutSequence.locks.Length, inventorHutSequence.building.type.unlocks.Length);
    for (int index = 0; index < num; ++index)
    {
      if (inventorHutSequence.building.type.unlocks[index].IsActive)
        inventorHutSequence.locks[index].SetActive(false);
    }
    yield return (object) inventorHutSequence.CreateCards();
    if (inventorHutSequence.building.HasUncheckedUnlocks)
    {
      foreach (string uncheckedUnlock in inventorHutSequence.building.uncheckedUnlocks)
        yield return (object) inventorHutSequence.Unlock(uncheckedUnlock);
      Entity top = ((IEnumerable<CardContainer>) inventorHutSequence.cardSlots).LastOrDefault<CardContainer>((Func<CardContainer, bool>) (a => !a.Empty))?.GetTop();
      if ((bool) (UnityEngine.Object) top)
        inventorHutSequence.TalkerNewCard(top.data);
    }
    else if (!inventorHutSequence.firstGreetKey.IsNullOrEmpty() && !SaveSystem.LoadProgressData<bool>(inventorHutSequence.firstGreetKey, false))
    {
      inventorHutSequence.TalkerFirstGreet();
      SaveSystem.SaveProgressData<bool>(inventorHutSequence.firstGreetKey, true);
    }
    else
      inventorHutSequence.TalkerGreet();
  }

  private IEnumerator Unlock(string unlockDataName)
  {
    InventorHutSequence inventorHutSequence = this;
    int index = ((IEnumerable<UnlockData>) inventorHutSequence.building.type.unlocks).Select<UnlockData, string>((Func<UnlockData, string>) (a => a.name)).ToList<string>().IndexOf(unlockDataName);
    string assetName = index >= 0 ? MetaprogressionSystem.Get<List<string>>("items")[index] : throw new IndexOutOfRangeException("[" + unlockDataName + "] does not exist in [" + inventorHutSequence.building.name + "] unlocks list!");
    List<string> stringList = SaveSystem.LoadProgressData<List<string>>(inventorHutSequence.building.type.unlockedCheckedKey, new List<string>());
    stringList.Add(unlockDataName);
    SaveSystem.SaveProgressData<List<string>>(inventorHutSequence.building.type.unlockedCheckedKey, stringList);
    Card card = CardManager.Get(AddressableLoader.Get<CardData>("CardData", assetName), inventorHutSequence.controller, (Character) null, false, true);
    yield return (object) card.UpdateData(false);
    CardContainer finalSlot = ((IEnumerable<CardContainer>) inventorHutSequence.cardSlots).FirstOrDefault<CardContainer>((Func<CardContainer, bool>) (a => a.Empty));
    yield return (object) inventorHutSequence.cardUnlockSequence.Run(card.entity, finalSlot);
    if ((bool) (UnityEngine.Object) finalSlot)
    {
      Image component = finalSlot.GetComponent<Image>();
      if (component != null)
        component.enabled = true;
    }
  }

  private IEnumerator CreateCards()
  {
    InventorHutSequence inventorHutSequence = this;
    List<Entity> cards = new List<Entity>();
    Routine.Clump clump = new Routine.Clump();
    List<string> checkedUnlocks = inventorHutSequence.building.checkedUnlocks;
    // ISSUE: explicit non-virtual call
    int count = checkedUnlocks != null ? __nonvirtual (checkedUnlocks.Count) : 0;
    List<string> stringList = MetaprogressionSystem.Get<List<string>>("items");
    for (int index = 0; index < count && index < stringList.Count; ++index)
    {
      Card card = CardManager.Get(AddressableLoader.Get<CardData>("CardData", stringList[index]), inventorHutSequence.controller, (Character) null, false, true);
      cards.Add(card.entity);
      clump.Add(card.UpdateData(false));
    }
    yield return (object) clump.WaitForEnd();
    foreach (Entity entity in cards)
    {
      CardContainer cardContainer = ((IEnumerable<CardContainer>) inventorHutSequence.cardSlots).FirstOrDefault<CardContainer>((Func<CardContainer, bool>) (a => a.Empty));
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
