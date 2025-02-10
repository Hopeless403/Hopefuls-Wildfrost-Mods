// Decompiled with JetBrains decompiler
// Type: NexPlugin.Ranking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace NexPlugin
{
  public static class Ranking : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_COMMON_DATA_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_RANGE_RANKING_ORDER;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_ACCURATE_ORDER;

    static Ranking()
    {
      Il2CppClassPointerStore<Ranking>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NexPlugin", nameof (Ranking));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ranking>.NativeClassPtr);
      Ranking.NativeFieldInfoPtr_MAX_COMMON_DATA_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ranking>.NativeClassPtr, nameof (MAX_COMMON_DATA_SIZE));
      Ranking.NativeFieldInfoPtr_MAX_RANGE_RANKING_ORDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ranking>.NativeClassPtr, nameof (MAX_RANGE_RANKING_ORDER));
      Ranking.NativeFieldInfoPtr_MAX_ACCURATE_ORDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ranking>.NativeClassPtr, nameof (MAX_ACCURATE_ORDER));
    }

    public Ranking(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe byte MAX_COMMON_DATA_SIZE
    {
      get
      {
        byte maxCommonDataSize;
        IL2CPP.il2cpp_field_static_get_value(Ranking.NativeFieldInfoPtr_MAX_COMMON_DATA_SIZE, (void*) &maxCommonDataSize);
        return maxCommonDataSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Ranking.NativeFieldInfoPtr_MAX_COMMON_DATA_SIZE, (void*) &value);
      }
    }

    public static unsafe uint MAX_RANGE_RANKING_ORDER
    {
      get
      {
        uint rangeRankingOrder;
        IL2CPP.il2cpp_field_static_get_value(Ranking.NativeFieldInfoPtr_MAX_RANGE_RANKING_ORDER, (void*) &rangeRankingOrder);
        return rangeRankingOrder;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Ranking.NativeFieldInfoPtr_MAX_RANGE_RANKING_ORDER, (void*) &value);
      }
    }

    public static unsafe uint MAX_ACCURATE_ORDER
    {
      get
      {
        uint maxAccurateOrder;
        IL2CPP.il2cpp_field_static_get_value(Ranking.NativeFieldInfoPtr_MAX_ACCURATE_ORDER, (void*) &maxAccurateOrder);
        return maxAccurateOrder;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Ranking.NativeFieldInfoPtr_MAX_ACCURATE_ORDER, (void*) &value);
      }
    }

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
