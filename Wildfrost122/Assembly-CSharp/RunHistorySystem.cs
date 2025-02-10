// Decompiled with JetBrains decompiler
// Type: RunHistorySystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class RunHistorySystem : GameSystem
{
  private const int max = 50;

  private void OnEnable()
  {
    global::Events.OnCampaignEnd += new UnityAction<Campaign.Result, CampaignStats, PlayerData>(RunHistorySystem.CampaignEnd);
  }

  private void OnDisable()
  {
    global::Events.OnCampaignEnd -= new UnityAction<Campaign.Result, CampaignStats, PlayerData>(RunHistorySystem.CampaignEnd);
  }

  private static void CampaignEnd(
    Campaign.Result result,
    CampaignStats stats,
    PlayerData playerData)
  {
    Debug.Log((object) "Saving Run History...");
    List<RunHistory> runHistoryList = SaveSystem.LoadHistoryData<List<RunHistory>>("list") ?? new List<RunHistory>();
    runHistoryList.Add(new RunHistory(Campaign.Data.GameMode, result, stats, playerData));
    if (runHistoryList.Count > 50)
      runHistoryList.RemoveAt(0);
    SaveSystem.SaveHistoryData<List<RunHistory>>("list", runHistoryList);
    Debug.Log((object) "Run History Saved!");
  }
}
