// Decompiled with JetBrains decompiler
// Type: ScriptUpgradeFinalBoss
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Upgrade Final Boss", menuName = "Scripts/Upgrade Final Boss")]
public class ScriptUpgradeFinalBoss : Script
{
  [SerializeField]
  public CardUpgradeData attackUpgrade;
  [SerializeField]
  public CardUpgradeData effectsUpgrade;
  [SerializeField]
  public TargetConstraint canBeBoostedConstraint;

  public override IEnumerator Run()
  {
    using (List<CampaignNode>.Enumerator enumerator = References.Campaign.nodes.GetEnumerator())
    {
      while (enumerator.MoveNext())
        this.AddUpgrade(enumerator.Current);
      yield break;
    }
  }

  public void AddUpgrade(CampaignNode node)
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

  public CardUpgradeData GetUpgrade(CardData cardData) => !this.canBeBoostedConstraint.Check(cardData) ? this.attackUpgrade : this.effectsUpgrade;
}
