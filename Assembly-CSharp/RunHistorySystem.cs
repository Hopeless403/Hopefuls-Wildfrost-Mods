// Decompiled with JetBrains decompiler
// Type: RunHistorySystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RunHistorySystem : GameSystem
{
  private const int max = 50;

  private void OnEnable() => global::Events.OnCampaignEnd += new UnityAction<Campaign.Result, CampaignStats, PlayerData>(RunHistorySystem.CampaignEnd);

  private void OnDisable() => global::Events.OnCampaignEnd -= new UnityAction<Campaign.Result, CampaignStats, PlayerData>(RunHistorySystem.CampaignEnd);

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
