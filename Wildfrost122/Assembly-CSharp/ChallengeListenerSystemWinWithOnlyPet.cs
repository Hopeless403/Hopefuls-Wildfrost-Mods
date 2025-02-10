// Decompiled with JetBrains decompiler
// Type: ChallengeListenerSystemWinWithOnlyPet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine.Events;

#nullable disable
public class ChallengeListenerSystemWinWithOnlyPet : ChallengeListenerSystem
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
    string str = (string) null;
    int num = 0;
    foreach (CardData cardData in References.PlayerData.inventory.deck)
    {
      if (cardData.cardType.name == "Friendly")
      {
        if (++num <= 1)
        {
          str = cardData.name;
        }
        else
        {
          str = (string) null;
          break;
        }
      }
    }
    if (num != 1 || !MetaprogressionSystem.GetUnlockedPets().Contains<string>(str))
      return;
    this.Complete();
  }
}
