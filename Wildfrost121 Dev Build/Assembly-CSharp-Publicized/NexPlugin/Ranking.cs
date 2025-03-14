﻿// Decompiled with JetBrains decompiler
// Type: NexPlugin.Ranking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;

#nullable disable
namespace NexPlugin
{
  public static class Ranking
  {
    public const byte MAX_COMMON_DATA_SIZE = 255;
    public const uint MAX_RANGE_RANKING_ORDER = 1000;
    public const uint MAX_ACCURATE_ORDER = 5000;

    public enum RankingMode
    {
      RANKING_MODE_RANGE,
      RANKING_MODE_NEAR,
      RANKING_MODE_FRIEND_RANGE,
      RANKING_MODE_FRIEND_NEAR,
      RANKING_MODE_USER,
    }

    public enum FilterGroupIndex
    {
      FILTER_GROUP_INDEX_0 = 0,
      FILTER_GROUP_INDEX_1 = 1,
      FILTER_GROUP_INDEX_2 = 2,
      FILTER_GROUP_INDEX_3 = 3,
      FILTER_GROUP_INDEX_NONE = 255, // 0x000000FF
    }

    public enum OrderBy
    {
      ORDER_BY_ASC,
      ORDER_BY_DESC,
    }

    public enum UpdateMode
    {
      UPDATE_MODE_NORMAL,
      UPDATE_MODE_DELETE_OLD,
    }

    public enum OrderCalculation
    {
      ORDER_CALCULATION_113,
      ORDER_CALCULATION_123,
    }

    public enum TimeScope
    {
      TIME_SCOPE_CUSTOM_0,
      TIME_SCOPE_CUSTOM_1,
      TIME_SCOPE_ALL,
    }

    [Flags]
    public enum ModificationFlag
    {
      MODIFICATION_FLAG_NONE = 0,
      MODIFICATION_FLAG_GROUP0 = 1,
      MODIFICATION_FLAG_GROUP1 = 2,
      MODIFICATION_FLAG_GROUP2 = 4,
      MODIFICATION_FLAG_GROUP3 = 8,
      MODIFICATION_FLAG_PARAM = 16, // 0x00000010
    }

    [Flags]
    public enum StatsFlag
    {
      STATS_FLAG_TOTAL = 1,
      STATS_FLAG_SUM = 2,
      STATS_FLAG_MIN = 4,
      STATS_FLAG_MAX = 8,
      STATS_FLAG_AVERAGE = 16, // 0x00000010
    }
  }
}
