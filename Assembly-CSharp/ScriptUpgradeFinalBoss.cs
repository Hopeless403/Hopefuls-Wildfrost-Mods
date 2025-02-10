// Decompiled with JetBrains decompiler
// Type: ScriptUpgradeFinalBoss
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Upgrade Final Boss", menuName = "Scripts/Upgrade Final Boss")]
public class ScriptUpgradeFinalBoss : Script
{
  [SerializeField]
  private CardUpgradeData attackUpgrade;
  [SerializeField]
  private CardUpgradeData effectsUpgrade;
  [SerializeField]
  private TargetConstraint canBeBoostedConstraint;

  public override IEnumerator Run()
  {
    using (List<CampaignNode>.Enumerator enumerator = References.Campaign.nodes.GetEnumerator())
    {
      while (enumerator.MoveNext())
        this.AddUpgrade(enumerator.Current);
      yield break;
    }
  }

  private void AddUpgrade(CampaignNode node)
  {
    if (!node.type.isBattle || !node.type.isBoss || !(node.type.name == "CampaignNodeFinalBoss"))
      return;
    foreach (BattleWaveManager.WaveData save in node.data.GetSaveCollection<BattleWaveManager.WaveData>("waves"))
    {
      if (save.isBossWave)
      {
        for (int index = 0; index < save.Count; ++index)
        {
          CardData cardData = save.GetCardData(index);
          if (cardData.cardType.miniboss)
          {
            CardUpgradeData upgradeData = this.GetUpgrade(cardData).Clone();
            save.AddUpgradeToCard(index, upgradeData);
          }
        }
      }
    }
  }

  private CardUpgradeData GetUpgrade(CardData cardData) => !this.canBeBoostedConstraint.Check(cardData) ? this.attackUpgrade : this.effectsUpgrade;
}
