// Decompiled with JetBrains decompiler
// Type: ChallengeListenerSystemWinWithoutCharms
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Linq;
using UnityEngine.Events;

#nullable disable
public class ChallengeListenerSystemWinWithoutCharms : ChallengeListenerSystem
{
  public void OnEnable()
  {
    global::Events.OnCampaignEnd += new UnityAction<Campaign.Result, CampaignStats, PlayerData>(this.CampaignEnd);
  }

  public void OnDisable()
  {
    global::Events.OnCampaignEnd -= new UnityAction<Campaign.Result, CampaignStats, PlayerData>(this.CampaignEnd);
  }

  public void CampaignEnd(Campaign.Result result, CampaignStats stats, PlayerData playerData)
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
