// Decompiled with JetBrains decompiler
// Type: FinalBossDeckGenerationSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class FinalBossDeckGenerationSystem : GameSystem
{
  private void OnEnable()
  {
    global::Events.OnCampaignEnd += new UnityAction<Campaign.Result, CampaignStats, PlayerData>(FinalBossDeckGenerationSystem.CampaignEnd);
  }

  private void OnDisable()
  {
    global::Events.OnCampaignEnd -= new UnityAction<Campaign.Result, CampaignStats, PlayerData>(FinalBossDeckGenerationSystem.CampaignEnd);
  }

  private static void CampaignEnd(
    Campaign.Result result,
    CampaignStats stats,
    PlayerData playerData)
  {
    if (!Campaign.Data.GameMode.mainGameMode)
      return;
    if (FinalBossDeckGenerationSystem.CheckTrueWin(result))
    {
      FinalBossDeckGenerationSystem.RevertToDefaultBoss();
    }
    else
    {
      if (!FinalBossDeckGenerationSystem.CheckResult(result))
        return;
      FinalBossDeckGenerationSystem.SetNewBoss(playerData);
    }
  }

  private static bool CheckResult(Campaign.Result result)
  {
    bool flag = SaveSystem.LoadCampaignData<bool>(Campaign.Data.GameMode, "trueWin", false);
    return result == Campaign.Result.Win && !flag || result != Campaign.Result.Win & flag;
  }

  private static bool CheckTrueWin(Campaign.Result result)
  {
    bool flag = SaveSystem.LoadCampaignData<bool>(Campaign.Data.GameMode, "trueWin", false);
    return result == Campaign.Result.Win & flag;
  }

  public static void SetNewBoss(PlayerData playerData)
  {
    SaveSystem.SaveProgressData<CardSaveData[]>("finalBossDeck", playerData.inventory.deck.SaveArray<CardData, CardSaveData>());
    SaveSystem.SaveProgressData<bool>("newFinalBoss", true);
    Debug.Log((object) ("~ Player's Deck Saved! [" + string.Join(", ", playerData.inventory.deck.Select<CardData, string>((Func<CardData, string>) (a => a.name))) + "]"));
  }

  public static void RevertToDefaultBoss()
  {
    SaveSystem.DeleteProgressData("finalBossDeck");
    SaveSystem.DeleteProgressData("newFinalBoss");
    Debug.Log((object) "~ TRUE VICTORY! Reverting Final Boss To Default");
  }
}
