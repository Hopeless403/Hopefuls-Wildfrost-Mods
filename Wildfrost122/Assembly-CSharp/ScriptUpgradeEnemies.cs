// Decompiled with JetBrains decompiler
// Type: ScriptUpgradeEnemies
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Pool;

#nullable disable
[CreateAssetMenu(fileName = "Upgrade Enemies", menuName = "Scripts/Upgrade Enemies")]
public class ScriptUpgradeEnemies : Script
{
  [SerializeField]
  private string[] illegalCards = new string[1]{ "Gobling" };
  [SerializeField]
  private CardUpgradeData[] upgradePool;
  [SerializeField]
  private ScriptUpgradeEnemies.Tier[] tiers;

  public override IEnumerator Run()
  {
    List<CardUpgradeData> currentPool = new List<CardUpgradeData>();
    using (List<CampaignNode>.Enumerator enumerator = References.Campaign.nodes.GetEnumerator())
    {
      while (enumerator.MoveNext())
      {
        CampaignNode current = enumerator.Current;
        if (current.type.isBattle)
        {
          BattleWaveManager.WaveData[] saveCollection = current.data.GetSaveCollection<BattleWaveManager.WaveData>("waves");
          int upgradeCount = this.tiers.Length > current.tier ? this.tiers[current.tier].upgradesRange.Random() : 0;
          if (upgradeCount > 0)
            this.AddUpgrades(currentPool, saveCollection, upgradeCount, this.tiers[current.tier].canAffectMiniboss);
        }
      }
      yield break;
    }
  }

  private void AddUpgrades(
    List<CardUpgradeData> currentPool,
    BattleWaveManager.WaveData[] waves,
    int upgradeCount,
    bool canUpgradeMiniboss)
  {
    foreach (BattleWaveManager.WaveData wave in waves)
    {
      if (this.TryAddUpgrade(currentPool, wave, canUpgradeMiniboss) && --upgradeCount <= 0)
        break;
    }
  }

  private bool TryAddUpgrade(
    List<CardUpgradeData> currentPool,
    BattleWaveManager.WaveData wave,
    bool canUpgradeMiniboss)
  {
    bool flag = false;
    List<int> intList = GenericPool<List<int>>.Get();
    intList.Clear();
    for (int index = 0; index < wave.Count; ++index)
      intList.Add(index);
    foreach (int cardIndex in (IEnumerable<int>) intList.InRandomOrder<int>())
    {
      if (this.TryAddUpgrade(currentPool, wave, cardIndex, canUpgradeMiniboss))
      {
        flag = true;
        break;
      }
    }
    GenericPool<List<int>>.Release(intList);
    return flag;
  }

  private bool TryAddUpgrade(
    List<CardUpgradeData> currentPool,
    BattleWaveManager.WaveData wave,
    int cardIndex,
    bool canUpgradeMiniboss)
  {
    if (this.IllegalCard(wave.GetCardName(cardIndex)))
      return false;
    CardData cardData = wave.PeekCardData(cardIndex);
    if (!(bool) (UnityEngine.Object) cardData || cardData.cardType.miniboss && !canUpgradeMiniboss)
      return false;
    CardUpgradeData cardUpgradeData = currentPool.Count > 0 ? currentPool.FirstOrDefault<CardUpgradeData>((Func<CardUpgradeData, bool>) (a => wave.AddUpgradeToCard(cardIndex, a))) : (CardUpgradeData) null;
    if (!(bool) (UnityEngine.Object) cardUpgradeData)
    {
      currentPool.AddRange((IEnumerable<CardUpgradeData>) ((IEnumerable<CardUpgradeData>) this.upgradePool).InRandomOrder<CardUpgradeData>());
      cardUpgradeData = currentPool.FirstOrDefault<CardUpgradeData>((Func<CardUpgradeData, bool>) (a => wave.AddUpgradeToCard(cardIndex, a)));
    }
    if (!(bool) (UnityEngine.Object) cardUpgradeData)
      return false;
    currentPool.Remove(cardUpgradeData);
    return true;
  }

  private bool IllegalCard(string cardDataName) => this.illegalCards.Contains<string>(cardDataName);

  [Serializable]
  private struct Tier
  {
    public Vector2Int upgradesRange;
    public bool canAffectMiniboss;
  }
}
