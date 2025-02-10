// Decompiled with JetBrains decompiler
// Type: RunHistorySystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RunHistorySystem : GameSystem
{
  public const int max = 50;

  public void OnEnable() => global::Events.OnCampaignEnd += new UnityAction<Campaign.Result, CampaignStats, PlayerData>(RunHistorySystem.CampaignEnd);

  public void OnDisable() => global::Events.OnCampaignEnd -= new UnityAction<Campaign.Result, CampaignStats, PlayerData>(RunHistorySystem.CampaignEnd);

  public static void CampaignEnd(
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
