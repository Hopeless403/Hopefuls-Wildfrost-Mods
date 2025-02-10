// Decompiled with JetBrains decompiler
// Type: ScriptAddUpgrades
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Add Upgrades", menuName = "Scripts/Add Upgrades")]
public class ScriptAddUpgrades : Script
{
  [SerializeField]
  public int count = 1;
  [SerializeField]
  public CardUpgradeData[] upgradePool;
  [SerializeField]
  [HideIf("addToRandom")]
  public bool addToFirstEligible = true;
  [SerializeField]
  [HideIf("addToFirstEligible")]
  public bool addToRandom;
  [SerializeField]
  public bool ofCardType;
  [SerializeField]
  [ShowIf("ofCardType")]
  public CardType[] eligibleCardTypes;

  public override IEnumerator Run()
  {
    for (int index = 0; index < this.count; ++index)
      this.AddUpgrade();
    yield break;
  }

  public void AddUpgrade()
  {
    using (IEnumerator<CardUpgradeData> enumerator = ((IEnumerable<CardUpgradeData>) this.upgradePool).InRandomOrder<CardUpgradeData>().GetEnumerator())
    {
      do
        ;
      while (enumerator.MoveNext() && !this.TryAddUpgrade(enumerator.Current));
    }
  }

  public bool TryAddUpgrade(CardUpgradeData upgradeData)
  {
    bool flag = false;
    if (this.addToFirstEligible)
    {
      foreach (CardData cardData in References.PlayerData.inventory.deck)
      {
        if (this.Eligible(cardData) && upgradeData.CanAssign(cardData))
        {
          upgradeData.Clone().Assign(cardData);
          flag = true;
          break;
        }
      }
    }
    else if (this.addToRandom)
    {
      foreach (CardData cardData in (IEnumerable<CardData>) References.PlayerData.inventory.deck.InRandomOrder<CardData>())
      {
        if (this.Eligible(cardData) && upgradeData.CanAssign(cardData))
        {
          upgradeData.Clone().Assign(cardData);
          flag = true;
          break;
        }
      }
    }
    else
    {
      References.PlayerData.inventory.upgrades.Add(upgradeData.Clone());
      flag = true;
    }
    return flag;
  }

  public bool Eligible(CardData cardData)
  {
    return !this.ofCardType || this.eligibleCardTypes.Contains<CardType>(cardData.cardType);
  }
}
