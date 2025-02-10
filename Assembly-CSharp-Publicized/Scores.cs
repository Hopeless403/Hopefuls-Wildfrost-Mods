// Decompiled with JetBrains decompiler
// Type: Scores
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Steamworks;
using Steamworks.Data;
using System;
using System.Threading.Tasks;
using UnityEngine;

public static class Scores
{
  public static string GetLeaderboardName(Scores.Type boardType, DateTime date)
  {
    string leaderboardName;
    switch (boardType)
    {
      case Scores.Type.TopScores:
        leaderboardName = nameof (Scores);
        break;
      case Scores.Type.Daily:
        leaderboardName = DailyFetcher.GetLeaderboardName(date);
        break;
      default:
        leaderboardName = "Unknown";
        break;
    }
    return leaderboardName;
  }

  public static async Task<LeaderboardUpdate?> Submit(
    Scores.Type type,
    DateTime date,
    int score,
    params int[] details)
  {
    string leaderboardName = Scores.GetLeaderboardName(type, date);
    Debug.Log((object) string.Format("> Submitting Score [{0}] to Leaderboard [{1}]", (object) score, (object) leaderboardName));
    Leaderboard? leaderboard = await Scores.GetLeaderboard(leaderboardName);
    return leaderboard.HasValue ? await leaderboard.Value.SubmitScoreAsync(score, details.Length != 0 ? details : (int[]) null) : new LeaderboardUpdate?();
  }

  public static async Task<Leaderboard?> GetLeaderboard(Scores.Type type, DateTime date) => !SteamManager.init ? new Leaderboard?() : await Scores.GetLeaderboard(Scores.GetLeaderboardName(type, date));

  public static async Task<Leaderboard?> GetLeaderboard(string leaderboardName) => !SteamManager.init ? new Leaderboard?() : await SteamUserStats.FindOrCreateLeaderboardAsync(leaderboardName, LeaderboardSort.Descending, LeaderboardDisplay.Numeric);

  public static async Task<LeaderboardEntry[]> GetGlobal(
    Leaderboard board,
    int entries,
    int offset)
  {
    return !SteamManager.init ? (LeaderboardEntry[]) null : await board.GetScoresAsync(entries, offset);
  }

  public static async Task<LeaderboardEntry[]> GetFriends(Leaderboard board, int entries) => !SteamManager.init ? (LeaderboardEntry[]) null : await board.GetScoresFromFriendsAsync();

  public static async Task<LeaderboardEntry[]> GetAround(Leaderboard board, int entries)
  {
    if (!SteamManager.init)
      return (LeaderboardEntry[]) null;
    int end = entries / 2;
    return await board.GetScoresAroundUserAsync(-end, end);
  }

  public enum Type
  {
    TopScores,
    Daily,
  }
}
