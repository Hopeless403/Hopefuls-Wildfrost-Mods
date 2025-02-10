// Decompiled with JetBrains decompiler
// Type: FinalBossDeckGenerationSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class FinalBossDeckGenerationSystem : GameSystem
{
  public void OnEnable() => global::Events.OnCampaignEnd += new UnityAction<Campaign.Result, CampaignStats, PlayerData>(FinalBossDeckGenerationSystem.CampaignEnd);

  public void OnDisable() => global::Events.OnCampaignEnd -= new UnityAction<Campaign.Result, CampaignStats, PlayerData>(FinalBossDeckGenerationSystem.CampaignEnd);

  public static void CampaignEnd(
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

  public static bool CheckResult(Campaign.Result result)
  {
    bool flag = SaveSystem.LoadCampaignData<bool>(Campaign.Data.GameMode, "trueWin", false);
    return result == Campaign.Result.Win && !flag || result != Campaign.Result.Win & flag;
  }

  public static bool CheckTrueWin(Campaign.Result result)
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
