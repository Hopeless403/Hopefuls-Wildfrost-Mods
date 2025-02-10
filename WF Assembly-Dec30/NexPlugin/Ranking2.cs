// Decompiled with JetBrains decompiler
// Type: NexPlugin.Ranking2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace NexPlugin
{
  public static class Ranking2 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_BINARY_DATA_LENGTH;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_CHART_GET_LENGTH;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_PUT_MULTI_SCORES;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_RANKING_LENGTH;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_USERNAME_LENGTH;
    private static readonly System.IntPtr NativeFieldInfoPtr_SCORE_ORDER_ASC;
    private static readonly System.IntPtr NativeFieldInfoPtr_SCORE_ORDER_DESC;

    static Ranking2()
    {
      Il2CppClassPointerStore<Ranking2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NexPlugin", nameof (Ranking2));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ranking2>.NativeClassPtr);
      Ranking2.NativeFieldInfoPtr_MAX_BINARY_DATA_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ranking2>.NativeClassPtr, nameof (MAX_BINARY_DATA_LENGTH));
      Ranking2.NativeFieldInfoPtr_MAX_CHART_GET_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ranking2>.NativeClassPtr, nameof (MAX_CHART_GET_LENGTH));
      Ranking2.NativeFieldInfoPtr_MAX_PUT_MULTI_SCORES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ranking2>.NativeClassPtr, nameof (MAX_PUT_MULTI_SCORES));
      Ranking2.NativeFieldInfoPtr_MAX_RANKING_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ranking2>.NativeClassPtr, nameof (MAX_RANKING_LENGTH));
      Ranking2.NativeFieldInfoPtr_MAX_USERNAME_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ranking2>.NativeClassPtr, nameof (MAX_USERNAME_LENGTH));
      Ranking2.NativeFieldInfoPtr_SCORE_ORDER_ASC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ranking2>.NativeClassPtr, nameof (SCORE_ORDER_ASC));
      Ranking2.NativeFieldInfoPtr_SCORE_ORDER_DESC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ranking2>.NativeClassPtr, nameof (SCORE_ORDER_DESC));
    }

    public Ranking2(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int MAX_BINARY_DATA_LENGTH
    {
      get
      {
        int binaryDataLength;
        IL2CPP.il2cpp_field_static_get_value(Ranking2.NativeFieldInfoPtr_MAX_BINARY_DATA_LENGTH, (void*) &binaryDataLength);
        return binaryDataLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Ranking2.NativeFieldInfoPtr_MAX_BINARY_DATA_LENGTH, (void*) &value);
      }
    }

    public static unsafe uint MAX_CHART_GET_LENGTH
    {
      get
      {
        uint maxChartGetLength;
        IL2CPP.il2cpp_field_static_get_value(Ranking2.NativeFieldInfoPtr_MAX_CHART_GET_LENGTH, (void*) &maxChartGetLength);
        return maxChartGetLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Ranking2.NativeFieldInfoPtr_MAX_CHART_GET_LENGTH, (void*) &value);
      }
    }

    public static unsafe uint MAX_PUT_MULTI_SCORES
    {
      get
      {
        uint maxPutMultiScores;
        IL2CPP.il2cpp_field_static_get_value(Ranking2.NativeFieldInfoPtr_MAX_PUT_MULTI_SCORES, (void*) &maxPutMultiScores);
        return maxPutMultiScores;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Ranking2.NativeFieldInfoPtr_MAX_PUT_MULTI_SCORES, (void*) &value);
      }
    }

    public static unsafe uint MAX_RANKING_LENGTH
    {
      get
      {
        uint maxRankingLength;
        IL2CPP.il2cpp_field_static_get_value(Ranking2.NativeFieldInfoPtr_MAX_RANKING_LENGTH, (void*) &maxRankingLength);
        return maxRankingLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Ranking2.NativeFieldInfoPtr_MAX_RANKING_LENGTH, (void*) &value);
      }
    }

    public static unsafe int MAX_USERNAME_LENGTH
    {
      get
      {
        int maxUsernameLength;
        IL2CPP.il2cpp_field_static_get_value(Ranking2.NativeFieldInfoPtr_MAX_USERNAME_LENGTH, (void*) &maxUsernameLength);
        return maxUsernameLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Ranking2.NativeFieldInfoPtr_MAX_USERNAME_LENGTH, (void*) &value);
      }
    }

    public static unsafe bool SCORE_ORDER_ASC
    {
      get
      {
        bool scoreOrderAsc;
        IL2CPP.il2cpp_field_static_get_value(Ranking2.NativeFieldInfoPtr_SCORE_ORDER_ASC, (void*) &scoreOrderAsc);
        return scoreOrderAsc;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Ranking2.NativeFieldInfoPtr_SCORE_ORDER_ASC, (void*) &value);
      }
    }

    public static unsafe bool SCORE_ORDER_DESC
    {
      get
      {
        bool scoreOrderDesc;
        IL2CPP.il2cpp_field_static_get_value(Ranking2.NativeFieldInfoPtr_SCORE_ORDER_DESC, (void*) &scoreOrderDesc);
        return scoreOrderDesc;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Ranking2.NativeFieldInfoPtr_SCORE_ORDER_DESC, (void*) &value);
      }
    }

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
