// Decompiled with JetBrains decompiler
// Type: LeaderboardsFetcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Steamworks.Data;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

public class LeaderboardsFetcher : MonoBehaviour
{
  [SerializeField]
  public Scores.Type boardType = Scores.Type.Daily;
  [CompilerGenerated]
  public LeaderboardsFetcher.Result \u003Cresult\u003Ek__BackingField;
  public bool playerRankFetched;
  [CompilerGenerated]
  public bool \u003CplayerHasRank\u003Ek__BackingField;
  [CompilerGenerated]
  public uint \u003CplayerRank\u003Ek__BackingField;
  [CompilerGenerated]
  public uint \u003CtotalScores\u003Ek__BackingField;
  public uint fetchCount;
  public Leaderboard? leaderboard;
  [CompilerGenerated]
  public LeaderboardEntry[] \u003Cinfo\u003Ek__BackingField;
  public int fetchBoardTaskId;
  public int fetchScoresTaskId;
  public int fetchPlayerRankTaskId;
  public int dayOffset = -1;

  public LeaderboardsFetcher.Result result
  {
    get => this.\u003Cresult\u003Ek__BackingField;
    set => this.\u003Cresult\u003Ek__BackingField = value;
  }

  public bool playerHasRank
  {
    get => this.\u003CplayerHasRank\u003Ek__BackingField;
    set => this.\u003CplayerHasRank\u003Ek__BackingField = value;
  }

  public uint playerRank
  {
    get => this.\u003CplayerRank\u003Ek__BackingField;
    set => this.\u003CplayerRank\u003Ek__BackingField = value;
  }

  public uint totalScores
  {
    get => this.\u003CtotalScores\u003Ek__BackingField;
    set => this.\u003CtotalScores\u003Ek__BackingField = value;
  }

  public void ResetPlayerRank()
  {
    this.playerRankFetched = false;
    this.playerHasRank = false;
    this.playerRank = 0U;
  }

  public LeaderboardEntry[] info
  {
    get => this.\u003Cinfo\u003Ek__BackingField;
    set => this.\u003Cinfo\u003Ek__BackingField = value;
  }

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

  public async Task FetchPlayerRankIfNecessary(Leaderboard board)
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
