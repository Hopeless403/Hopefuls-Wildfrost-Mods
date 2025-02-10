// Decompiled with JetBrains decompiler
// Type: NexPlugin.Ranking2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

#nullable disable
namespace NexPlugin
{
  public static class Ranking2
  {
    public const int MAX_BINARY_DATA_LENGTH = 100;
    public const uint MAX_CHART_GET_LENGTH = 20;
    public const uint MAX_PUT_MULTI_SCORES = 20;
    public const uint MAX_RANKING_LENGTH = 100;
    public const int MAX_USERNAME_LENGTH = 20;
    public const bool SCORE_ORDER_ASC = false;
    public const bool SCORE_ORDER_DESC = true;

    public enum Ranking2SortFlags
    {
      NOTHING = 0,
      MOVE_TO_TOP_IN_TIE = 4,
    }

    public enum Ranking2GetOptionFlags
    {
      NOTHING,
      MII_REQUIRED,
    }

    public enum Ranking2Mode : byte
    {
      MIN = 0,
      USER_RANKING = 0,
      NEAR_RANKING = 1,
      RANGE_RANKING = 2,
      FRIEND_RANKING = 3,
      MAX = 3,
    }

    public enum Ranking2ResetMode : byte
    {
      MIN = 0,
      NOTHING = 0,
      EVERYDAY = 1,
      EVERYWEEK = 2,
      MULTI_MONTH = 3,
      MAX = 4,
      MULTI_MONTH_WEEKDAY = 4,
    }
  }
}
