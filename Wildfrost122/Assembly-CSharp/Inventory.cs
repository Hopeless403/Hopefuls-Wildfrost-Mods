// Decompiled with JetBrains decompiler
// Type: Inventory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Inventory", menuName = "Inventory")]
public class Inventory : ScriptableObject, ISaveable<InventorySaveData>
{
  public CardDataList deck = new CardDataList();
  public CardDataList reserve = new CardDataList();
  public List<CardUpgradeData> upgrades = new List<CardUpgradeData>();
  public SafeInt gold;
  public int goldOwed;

  public void AddGold(int amount)
  {
    this.gold += amount;
    this.goldOwed = Mathf.Max(0, this.goldOwed - amount);
  }

  public Inventory Clone()
  {
    Inventory inventory = this.InstantiateKeepName<Inventory>();
    inventory.deck.Clear();
    inventory.reserve.Clear();
    inventory.upgrades.Clear();
    foreach (CardData cardData in this.deck)
      inventory.deck.Add(cardData.Clone());
    foreach (CardData cardData in this.reserve)
      inventory.reserve.Add(cardData.Clone());
    foreach (CardUpgradeData upgrade in this.upgrades)
      inventory.upgrades.Add(upgrade.Clone());
    inventory.gold = new SafeInt(this.gold.Value);
    return inventory;
  }

  public InventorySaveData Save()
  {
    return new InventorySaveData(this.deck.SaveArray<CardData, CardSaveData>(), this.reserve.SaveArray<CardData, CardSaveData>(), this.upgrades.SaveArray<CardUpgradeData, CardUpgradeSaveData>(), this.gold.Value + this.goldOwed);
  }
}
