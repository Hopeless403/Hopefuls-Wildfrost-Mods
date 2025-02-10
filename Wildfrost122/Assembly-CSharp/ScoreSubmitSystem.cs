// Decompiled with JetBrains decompiler
// Type: ScoreSubmitSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Steamworks.Data;
using System;
using System.Collections;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class ScoreSubmitSystem : GameSystem
{
  private static ScoreSubmitSystem instance;
  public const int StartScore = -100;

  public static ScoreSubmitSystem.Status status { get; private set; }

  public static int? playerRank { get; private set; }

  public static int SubmittedTime { get; private set; }

  public static int SubmittedGold { get; private set; }

  public static int SubmittedBattlesWon { get; private set; }

  public static int SubmittedScore { get; private set; }

  private void OnEnable()
  {
    ScoreSubmitSystem.instance = this;
    global::Events.OnCampaignEnd += new UnityAction<Campaign.Result, CampaignStats, PlayerData>(ScoreSubmitSystem.CampaignEnd);
  }

  private void OnDisable()
  {
    global::Events.OnCampaignEnd -= new UnityAction<Campaign.Result, CampaignStats, PlayerData>(ScoreSubmitSystem.CampaignEnd);
  }

  public static LeaderboardUpdate? result { get; private set; }

  private static void CampaignEnd(
    Campaign.Result result,
    CampaignStats stats,
    PlayerData playerData)
  {
    if (!Campaign.Data.GameMode.submitScore)
      return;
    bool win = result == Campaign.Result.Win;
    ScoreSubmitSystem.instance.StartCoroutine(ScoreSubmitSystem.SubmitScore(win, stats));
  }

  private static IEnumerator SubmitScore(bool win, CampaignStats stats)
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

  private static int GetScore(bool win, int seconds, int gold, int battlesWon)
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
