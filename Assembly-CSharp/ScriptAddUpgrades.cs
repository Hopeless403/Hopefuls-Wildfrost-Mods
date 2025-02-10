// Decompiled with JetBrains decompiler
// Type: ScriptAddUpgrades
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Add Upgrades", menuName = "Scripts/Add Upgrades")]
public class ScriptAddUpgrades : Script
{
  [SerializeField]
  private int count = 1;
  [SerializeField]
  private CardUpgradeData[] upgradePool;
  [SerializeField]
  [HideIf("addToRandom")]
  private bool addToFirstEligible = true;
  [SerializeField]
  [HideIf("addToFirstEligible")]
  private bool addToRandom;
  [SerializeField]
  private bool ofCardType;
  [SerializeField]
  [ShowIf("ofCardType")]
  private CardType[] eligibleCardTypes;

  public override IEnumerator Run()
  {
    for (int index = 0; index < this.count; ++index)
      this.AddUpgrade();
    yield break;
  }

  private void AddUpgrade()
  {
    using (IEnumerator<CardUpgradeData> enumerator = ((IEnumerable<CardUpgradeData>) this.upgradePool).InRandomOrder<CardUpgradeData>().GetEnumerator())
    {
      do
        ;
      while (enumerator.MoveNext() && !this.TryAddUpgrade(enumerator.Current));
    }
  }

  private bool TryAddUpgrade(CardUpgradeData upgradeData)
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

  private bool Eligible(CardData cardData) => !this.ofCardType || this.eligibleCardTypes.Contains<CardType>(cardData.cardType);
}
