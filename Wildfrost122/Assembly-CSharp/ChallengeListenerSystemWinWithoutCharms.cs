// Decompiled with JetBrains decompiler
// Type: ChallengeListenerSystemWinWithoutCharms
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Linq;
using UnityEngine.Events;

#nullable disable
public class ChallengeListenerSystemWinWithoutCharms : ChallengeListenerSystem
{
  private void OnEnable()
  {
    global::Events.OnCampaignEnd += new UnityAction<Campaign.Result, CampaignStats, PlayerData>(this.CampaignEnd);
  }

  private void OnDisable()
  {
    global::Events.OnCampaignEnd -= new UnityAction<Campaign.Result, CampaignStats, PlayerData>(this.CampaignEnd);
  }

  private void CampaignEnd(Campaign.Result result, CampaignStats stats, PlayerData playerData)
  {
    if (result != Campaign.Result.Win)
      return;
    bool flag = false;
    foreach (CardData cardData in References.PlayerData.inventory.deck)
    {
      if (cardData.upgrades.Any<CardUpgradeData>((Func<CardUpgradeData, bool>) (a => a.type == CardUpgradeData.Type.Charm)))
      {
        flag = true;
        break;
      }
    }
    if (flag)
      return;
    this.Complete();
  }
}
