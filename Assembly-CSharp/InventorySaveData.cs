// Decompiled with JetBrains decompiler
// Type: InventorySaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using System;
using UnityEngine;

[Serializable]
public class InventorySaveData : ILoadable<Inventory>
{
  public CardSaveData[] deck;
  public CardSaveData[] reserve;
  public CardUpgradeSaveData[] upgrades;
  public int gold;

  public InventorySaveData()
  {
  }

  public InventorySaveData(
    CardSaveData[] deck,
    CardSaveData[] reserve,
    CardUpgradeSaveData[] upgrades,
    int gold)
  {
    this.deck = deck;
    this.reserve = reserve;
    this.upgrades = upgrades;
    this.gold = gold;
  }

  public Inventory Load()
  {
    Inventory instance = ScriptableObject.CreateInstance<Inventory>();
    foreach (CardSaveData cardSaveData in this.deck)
      instance.deck.Add(cardSaveData.Load());
    foreach (CardSaveData cardSaveData in this.reserve)
      instance.reserve.Add(cardSaveData.Load());
    foreach (CardUpgradeSaveData upgrade in this.upgrades)
      instance.upgrades.Add(upgrade.Load());
    instance.gold = new SafeInt(this.gold);
    return instance;
  }
}
