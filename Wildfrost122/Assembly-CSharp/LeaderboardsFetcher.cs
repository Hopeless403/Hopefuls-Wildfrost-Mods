// Decompiled with JetBrains decompiler
// Type: LeaderboardsFetcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Steamworks.Data;
using System;
using System.Threading.Tasks;
using UnityEngine;

#nullable disable
public class LeaderboardsFetcher : MonoBehaviour
{
  [SerializeField]
  private Scores.Type boardType = Scores.Type.Daily;
  private bool playerRankFetched;
  private uint fetchCount;
  private Leaderboard? leaderboard;
  private int fetchBoardTaskId;
  private int fetchScoresTaskId;
  private int fetchPlayerRankTaskId;
  private int dayOffset = -1;

  public LeaderboardsFetcher.Result result { get; private set; }

  public bool playerHasRank { get; private set; }

  public uint playerRank { get; private set; }

  public uint totalScores { get; private set; }

  public void ResetPlayerRank()
  {
    this.playerRankFetched = false;
    this.playerHasRank = false;
    this.playerRank = 0U;
  }

  public LeaderboardEntry[] info { get; private set; }

  public async Task Fetch(
    LeaderboardsFetcher.Type type,
    int dayOffset,
    int entriesPerPage,
    int page = -1)
  {
    DateTime date = DailyFetcher.GetDateTime().AddDays((double) -dayOffset);
    if (this.dayOffset != dayOffset || !this.leaderboard.HasValue)
    {
      this.dayOffset = dayOffset;
      Task<Leaderboard?> fetchBoardTask = Scores.GetLeaderboard(this.boardType, date);
      this.fetchBoardTaskId = fetchBoardTask.Id;
      Leaderboard? nullable = await fetchBoardTask;
      if (this.fetchBoardTaskId == fetchBoardTask.Id)
        this.leaderboard = fetchBoardTask.Result;
      fetchBoardTask = (Task<Leaderboard?>) null;
    }
    if (!this.leaderboard.HasValue)
      return;
    this.totalScores = (uint) this.leaderboard.Value.EntryCount;
    if (!this.playerRankFetched)
      await this.FetchPlayerRankIfNecessary(this.leaderboard.Value);
    if (page < 0)
      page = this.playerHasRank ? Mathf.FloorToInt((float) (this.playerRank - 1U) / (float) entriesPerPage) : 0;
    Task<LeaderboardEntry[]> fetchGlobalScoresTask;
    Task<LeaderboardEntry[]> fetchFriendsScoresTask;
    switch (type)
    {
      case LeaderboardsFetcher.Type.Global:
        fetchGlobalScoresTask = Scores.GetGlobal(this.leaderboard.Value, entriesPerPage, 1 + page * entriesPerPage);
        this.fetchScoresTaskId = fetchGlobalScoresTask.Id;
        LeaderboardEntry[] leaderboardEntryArray1 = await fetchGlobalScoresTask;
        if (this.fetchScoresTaskId == fetchGlobalScoresTask.Id)
        {
          this.info = fetchGlobalScoresTask.Result;
          break;
        }
        break;
      case LeaderboardsFetcher.Type.Friends:
        fetchFriendsScoresTask = Scores.GetFriends(this.leaderboard.Value, entriesPerPage);
        this.fetchScoresTaskId = fetchFriendsScoresTask.Id;
        LeaderboardEntry[] leaderboardEntryArray2 = await fetchFriendsScoresTask;
        if (this.fetchScoresTaskId == fetchFriendsScoresTask.Id)
        {
          this.info = fetchFriendsScoresTask.Result;
          break;
        }
        break;
    }
    fetchGlobalScoresTask = (Task<LeaderboardEntry[]>) null;
    fetchFriendsScoresTask = (Task<LeaderboardEntry[]>) null;
  }

  private async Task FetchPlayerRankIfNecessary(Leaderboard board)
  {
    Task<LeaderboardEntry[]> fetchPlayerRankTask = Scores.GetAround(board, 0);
    this.fetchPlayerRankTaskId = fetchPlayerRankTask.Id;
    LeaderboardEntry[] leaderboardEntryArray = await fetchPlayerRankTask;
    if (fetchPlayerRankTask.Id != this.fetchPlayerRankTaskId)
    {
      fetchPlayerRankTask = (Task<LeaderboardEntry[]>) null;
    }
    else
    {
      LeaderboardEntry[] result = fetchPlayerRankTask.Result;
      if (result != null && result.Length > 0)
      {
        this.playerHasRank = true;
        this.playerRank = (uint) result[0].GlobalRank;
      }
      this.playerRankFetched = true;
      fetchPlayerRankTask = (Task<LeaderboardEntry[]>) null;
    }
  }

  public enum Type
  {
    Global,
    Friends,
    Around,
  }

  public enum Result
  {
    Success,
    NoConnection,
    TooManyRequests,
    Cancel,
  }
}
