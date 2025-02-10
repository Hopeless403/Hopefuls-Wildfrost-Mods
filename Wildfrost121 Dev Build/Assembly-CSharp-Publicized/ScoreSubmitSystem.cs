// Decompiled with JetBrains decompiler
// Type: ScoreSubmitSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Steamworks.Data;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class ScoreSubmitSystem : GameSystem
{
  public static ScoreSubmitSystem instance;
  public const int StartScore = -100;
  [CompilerGenerated]
  public static ScoreSubmitSystem.Status \u003Cstatus\u003Ek__BackingField;
  [CompilerGenerated]
  public static int? \u003CplayerRank\u003Ek__BackingField;
  [CompilerGenerated]
  public static int \u003CSubmittedTime\u003Ek__BackingField;
  [CompilerGenerated]
  public static int \u003CSubmittedGold\u003Ek__BackingField;
  [CompilerGenerated]
  public static int \u003CSubmittedBattlesWon\u003Ek__BackingField;
  [CompilerGenerated]
  public static int \u003CSubmittedScore\u003Ek__BackingField;
  [CompilerGenerated]
  public static LeaderboardUpdate? \u003Cresult\u003Ek__BackingField;

  public static ScoreSubmitSystem.Status status
  {
    get => ScoreSubmitSystem.\u003Cstatus\u003Ek__BackingField;
    set => ScoreSubmitSystem.\u003Cstatus\u003Ek__BackingField = value;
  }

  public static int? playerRank
  {
    get => ScoreSubmitSystem.\u003CplayerRank\u003Ek__BackingField;
    set => ScoreSubmitSystem.\u003CplayerRank\u003Ek__BackingField = value;
  }

  public static int SubmittedTime
  {
    get => ScoreSubmitSystem.\u003CSubmittedTime\u003Ek__BackingField;
    set => ScoreSubmitSystem.\u003CSubmittedTime\u003Ek__BackingField = value;
  }

  public static int SubmittedGold
  {
    get => ScoreSubmitSystem.\u003CSubmittedGold\u003Ek__BackingField;
    set => ScoreSubmitSystem.\u003CSubmittedGold\u003Ek__BackingField = value;
  }

  public static int SubmittedBattlesWon
  {
    get => ScoreSubmitSystem.\u003CSubmittedBattlesWon\u003Ek__BackingField;
    set => ScoreSubmitSystem.\u003CSubmittedBattlesWon\u003Ek__BackingField = value;
  }

  public static int SubmittedScore
  {
    get => ScoreSubmitSystem.\u003CSubmittedScore\u003Ek__BackingField;
    set => ScoreSubmitSystem.\u003CSubmittedScore\u003Ek__BackingField = value;
  }

  public void OnEnable()
  {
    ScoreSubmitSystem.instance = this;
    global::Events.OnCampaignEnd += new UnityAction<Campaign.Result, CampaignStats, PlayerData>(ScoreSubmitSystem.CampaignEnd);
  }

  public void OnDisable()
  {
    global::Events.OnCampaignEnd -= new UnityAction<Campaign.Result, CampaignStats, PlayerData>(ScoreSubmitSystem.CampaignEnd);
  }

  public static LeaderboardUpdate? result
  {
    get => ScoreSubmitSystem.\u003Cresult\u003Ek__BackingField;
    set => ScoreSubmitSystem.\u003Cresult\u003Ek__BackingField = value;
  }

  public static void CampaignEnd(
    Campaign.Result result,
    CampaignStats stats,
    PlayerData playerData)
  {
    if (!Campaign.Data.GameMode.submitScore)
      return;
    bool win = result == Campaign.Result.Win;
    ScoreSubmitSystem.instance.StartCoroutine(ScoreSubmitSystem.SubmitScore(win, stats));
  }

  public static IEnumerator SubmitScore(bool win, CampaignStats stats)
  {
    yield return (object) null;
    ScoreSubmitSystem.playerRank = new int?();
    ScoreSubmitSystem.status = ScoreSubmitSystem.Status.Submitting;
    DateTime exact = DateTime.ParseExact(SaveSystem.LoadCampaignData<string>(Campaign.Data.GameMode, "startDate", ""), "dd/MM/yyyy", (IFormatProvider) GameManager.CultureInfo);
    int num = win ? 1 : 0;
    ScoreSubmitSystem.SubmittedTime = Mathf.RoundToInt((float) (stats.hours * 3600) + stats.time);
    ScoreSubmitSystem.SubmittedGold = stats.Count("goldGained");
    ScoreSubmitSystem.SubmittedBattlesWon = stats.Count("battlesWon");
    ScoreSubmitSystem.SubmittedScore = ScoreSubmitSystem.GetScore(win, ScoreSubmitSystem.SubmittedTime, ScoreSubmitSystem.SubmittedGold, ScoreSubmitSystem.SubmittedBattlesWon);
    if (SteamManager.init)
    {
      Task<LeaderboardUpdate?> task = Scores.Submit(Campaign.Data.GameMode.leaderboardType, exact, ScoreSubmitSystem.SubmittedScore, ScoreSubmitSystem.SubmittedTime, num);
      yield return (object) new WaitUntil((Func<bool>) (() => task.IsCompleted));
      ScoreSubmitSystem.result = task.Result;
    }
    else
      ScoreSubmitSystem.result = new LeaderboardUpdate?();
    LeaderboardUpdate? result = ScoreSubmitSystem.result;
    if (result.HasValue)
    {
      result = ScoreSubmitSystem.result;
      ScoreSubmitSystem.playerRank = new int?(result.Value.NewGlobalRank);
      result = ScoreSubmitSystem.result;
      Debug.Log((object) string.Format("Score Changed? {0}", (object) result.Value.Changed));
      result = ScoreSubmitSystem.result;
      if (result.Value.Changed)
      {
        result = ScoreSubmitSystem.result;
        // ISSUE: variable of a boxed type
        __Boxed<int> oldGlobalRank = (ValueType) result.Value.OldGlobalRank;
        result = ScoreSubmitSystem.result;
        // ISSUE: variable of a boxed type
        __Boxed<int> newGlobalRank = (ValueType) result.Value.NewGlobalRank;
        Debug.Log((object) string.Format("Global Rank: {0} → {1}", (object) oldGlobalRank, (object) newGlobalRank));
      }
      ScoreSubmitSystem.status = ScoreSubmitSystem.Status.Success;
    }
    else
    {
      Debug.LogWarning((object) "Submitting score failed!");
      ScoreSubmitSystem.status = ScoreSubmitSystem.Status.Failed;
    }
  }

  public static int GetScore(bool win, int seconds, int gold, int battlesWon)
  {
    int scoreFromTime = ScoreSubmitSystem.GetScoreFromTime(win, seconds);
    int scoreFromGold = ScoreSubmitSystem.GetScoreFromGold(gold);
    int scoreFromBattlesWon = ScoreSubmitSystem.GetScoreFromBattlesWon(battlesWon);
    int num = scoreFromGold;
    return scoreFromTime + num + scoreFromBattlesWon;
  }

  public static int GetScoreFromTime(bool win, int seconds)
  {
    return !win ? 0 : Mathf.Max(0, 3600 - seconds);
  }

  public static int GetScoreFromGold(int goldRemaining) => goldRemaining;

  public static int GetScoreFromBattlesWon(int battlesWon) => battlesWon * 100 - 100;

  public enum Status
  {
    Submitting,
    Failed,
    Success,
  }
}
