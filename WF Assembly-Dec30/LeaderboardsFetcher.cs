// Decompiled with JetBrains decompiler
// Type: LeaderboardsFetcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class LeaderboardsFetcher : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_boardType;
  private static readonly System.IntPtr NativeFieldInfoPtr__result_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerRankFetched;
  private static readonly System.IntPtr NativeFieldInfoPtr__playerHasRank_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__playerRank_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__totalScores_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_fetchCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_leaderboard;
  private static readonly System.IntPtr NativeFieldInfoPtr__info_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_fetchBoardTaskId;
  private static readonly System.IntPtr NativeFieldInfoPtr_fetchScoresTaskId;
  private static readonly System.IntPtr NativeFieldInfoPtr_fetchPlayerRankTaskId;
  private static readonly System.IntPtr NativeFieldInfoPtr_dayOffset;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_result_Public_get_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_result_Private_set_Void_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_playerHasRank_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_playerHasRank_Private_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_playerRank_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_playerRank_Private_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_totalScores_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_totalScores_Private_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetPlayerRank_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_info_Public_get_Il2CppReferenceArray_1_LeaderboardEntry_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_info_Private_set_Void_Il2CppReferenceArray_1_LeaderboardEntry_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Fetch_Public_Task_Type_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FetchPlayerRankIfNecessary_Private_Task_Leaderboard_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe LeaderboardsFetcher.Result result
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaderboardsFetcher.NativeMethodInfoPtr_get_result_Public_get_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(LeaderboardsFetcher.Result*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 27305, RefRangeEnd = 27306, XrefRangeStart = 27305, XrefRangeEnd = 27306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardsFetcher.NativeMethodInfoPtr_set_result_Private_set_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe bool playerHasRank
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaderboardsFetcher.NativeMethodInfoPtr_get_playerHasRank_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardsFetcher.NativeMethodInfoPtr_set_playerHasRank_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe uint playerRank
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaderboardsFetcher.NativeMethodInfoPtr_get_playerRank_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 51136, RefRangeEnd = 51140, XrefRangeStart = 51136, XrefRangeEnd = 51136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardsFetcher.NativeMethodInfoPtr_set_playerRank_Private_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe uint totalScores
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaderboardsFetcher.NativeMethodInfoPtr_get_totalScores_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 51140, RefRangeEnd = 51142, XrefRangeStart = 51140, XrefRangeEnd = 51140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardsFetcher.NativeMethodInfoPtr_set_totalScores_Private_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 51142, RefRangeEnd = 51143, XrefRangeStart = 51142, XrefRangeEnd = 51142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetPlayerRank()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsFetcher.NativeMethodInfoPtr_ResetPlayerRank_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public unsafe Il2CppReferenceArray<LeaderboardEntry> info
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 51143, RefRangeEnd = 51144, XrefRangeStart = 51143, XrefRangeEnd = 51143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaderboardsFetcher.NativeMethodInfoPtr_get_info_Public_get_Il2CppReferenceArray_1_LeaderboardEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<LeaderboardEntry>) null : new Il2CppReferenceArray<LeaderboardEntry>(nativeObject);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51144, XrefRangeEnd = 51145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardsFetcher.NativeMethodInfoPtr_set_info_Private_set_Void_Il2CppReferenceArray_1_LeaderboardEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 51155, RefRangeEnd = 51156, XrefRangeStart = 51145, XrefRangeEnd = 51155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task Fetch(
    LeaderboardsFetcher.Type type,
    int dayOffset,
    int entriesPerPage,
    int page = -1)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &type;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dayOffset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entriesPerPage;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &page;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaderboardsFetcher.NativeMethodInfoPtr_Fetch_Public_Task_Type_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Task) null : new Task(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51156, XrefRangeEnd = 51166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task FetchPlayerRankIfNecessary(Leaderboard board)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &board
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaderboardsFetcher.NativeMethodInfoPtr_FetchPlayerRankIfNecessary_Private_Task_Leaderboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Task) null : new Task(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51166, XrefRangeEnd = 51167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LeaderboardsFetcher()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsFetcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LeaderboardsFetcher()
  {
    Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LeaderboardsFetcher));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr);
    LeaderboardsFetcher.NativeFieldInfoPtr_boardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, nameof (boardType));
    LeaderboardsFetcher.NativeFieldInfoPtr__result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, "<result>k__BackingField");
    LeaderboardsFetcher.NativeFieldInfoPtr_playerRankFetched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, nameof (playerRankFetched));
    LeaderboardsFetcher.NativeFieldInfoPtr__playerHasRank_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, "<playerHasRank>k__BackingField");
    LeaderboardsFetcher.NativeFieldInfoPtr__playerRank_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, "<playerRank>k__BackingField");
    LeaderboardsFetcher.NativeFieldInfoPtr__totalScores_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, "<totalScores>k__BackingField");
    LeaderboardsFetcher.NativeFieldInfoPtr_fetchCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, nameof (fetchCount));
    LeaderboardsFetcher.NativeFieldInfoPtr_leaderboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, nameof (leaderboard));
    LeaderboardsFetcher.NativeFieldInfoPtr__info_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, "<info>k__BackingField");
    LeaderboardsFetcher.NativeFieldInfoPtr_fetchBoardTaskId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, nameof (fetchBoardTaskId));
    LeaderboardsFetcher.NativeFieldInfoPtr_fetchScoresTaskId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, nameof (fetchScoresTaskId));
    LeaderboardsFetcher.NativeFieldInfoPtr_fetchPlayerRankTaskId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, nameof (fetchPlayerRankTaskId));
    LeaderboardsFetcher.NativeFieldInfoPtr_dayOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, nameof (dayOffset));
    LeaderboardsFetcher.NativeMethodInfoPtr_get_result_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, 100667393);
    LeaderboardsFetcher.NativeMethodInfoPtr_set_result_Private_set_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, 100667394);
    LeaderboardsFetcher.NativeMethodInfoPtr_get_playerHasRank_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, 100667395);
    LeaderboardsFetcher.NativeMethodInfoPtr_set_playerHasRank_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, 100667396);
    LeaderboardsFetcher.NativeMethodInfoPtr_get_playerRank_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, 100667397);
    LeaderboardsFetcher.NativeMethodInfoPtr_set_playerRank_Private_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, 100667398);
    LeaderboardsFetcher.NativeMethodInfoPtr_get_totalScores_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, 100667399);
    LeaderboardsFetcher.NativeMethodInfoPtr_set_totalScores_Private_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, 100667400);
    LeaderboardsFetcher.NativeMethodInfoPtr_ResetPlayerRank_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, 100667401);
    LeaderboardsFetcher.NativeMethodInfoPtr_get_info_Public_get_Il2CppReferenceArray_1_LeaderboardEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, 100667402);
    LeaderboardsFetcher.NativeMethodInfoPtr_set_info_Private_set_Void_Il2CppReferenceArray_1_LeaderboardEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, 100667403);
    LeaderboardsFetcher.NativeMethodInfoPtr_Fetch_Public_Task_Type_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, 100667404);
    LeaderboardsFetcher.NativeMethodInfoPtr_FetchPlayerRankIfNecessary_Private_Task_Leaderboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, 100667405);
    LeaderboardsFetcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, 100667406);
  }

  public LeaderboardsFetcher(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Scores.Type boardType
  {
    get
    {
      return *(Scores.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr_boardType));
    }
    [param: In] set
    {
      *(Scores.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr_boardType)) = value;
    }
  }

  public unsafe LeaderboardsFetcher.Result _result_k__BackingField
  {
    get
    {
      return *(LeaderboardsFetcher.Result*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr__result_k__BackingField));
    }
    [param: In] set
    {
      *(LeaderboardsFetcher.Result*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr__result_k__BackingField)) = value;
    }
  }

  public unsafe bool playerRankFetched
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr_playerRankFetched));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr_playerRankFetched)) = value;
    }
  }

  public unsafe bool _playerHasRank_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr__playerHasRank_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr__playerHasRank_k__BackingField)) = value;
    }
  }

  public unsafe uint _playerRank_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr__playerRank_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr__playerRank_k__BackingField)) = value;
    }
  }

  public unsafe uint _totalScores_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr__totalScores_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr__totalScores_k__BackingField)) = value;
    }
  }

  public unsafe uint fetchCount
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr_fetchCount));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr_fetchCount)) = value;
    }
  }

  public Il2CppSystem.Nullable<Leaderboard> leaderboard
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr_leaderboard);
      return new Il2CppSystem.Nullable<Leaderboard>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<Leaderboard>>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr_leaderboard), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<Leaderboard>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe Il2CppReferenceArray<LeaderboardEntry> _info_k__BackingField
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr__info_k__BackingField));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<LeaderboardEntry>) null : new Il2CppReferenceArray<LeaderboardEntry>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr__info_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int fetchBoardTaskId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr_fetchBoardTaskId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr_fetchBoardTaskId)) = value;
    }
  }

  public unsafe int fetchScoresTaskId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr_fetchScoresTaskId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr_fetchScoresTaskId)) = value;
    }
  }

  public unsafe int fetchPlayerRankTaskId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr_fetchPlayerRankTaskId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr_fetchPlayerRankTaskId)) = value;
    }
  }

  public unsafe int dayOffset
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr_dayOffset));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher.NativeFieldInfoPtr_dayOffset)) = value;
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

  [ObfuscatedName("LeaderboardsFetcher/<Fetch>d__31")]
  public sealed class _Fetch_d__31 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_dayOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_page;
    private static readonly System.IntPtr NativeFieldInfoPtr_entriesPerPage;
    private static readonly System.IntPtr NativeFieldInfoPtr_type;
    private static readonly System.IntPtr NativeFieldInfoPtr__fetchBoardTask_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__fetchGlobalScoresTask_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__fetchFriendsScoresTask_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__3;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51034, XrefRangeEnd = 51115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardsFetcher._Fetch_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardsFetcher._Fetch_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static _Fetch_d__31()
    {
      Il2CppClassPointerStore<LeaderboardsFetcher._Fetch_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, "<Fetch>d__31");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardsFetcher._Fetch_d__31>.NativeClassPtr);
      LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher._Fetch_d__31>.NativeClassPtr, "<>1__state");
      LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher._Fetch_d__31>.NativeClassPtr, "<>t__builder");
      LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr_dayOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher._Fetch_d__31>.NativeClassPtr, nameof (dayOffset));
      LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher._Fetch_d__31>.NativeClassPtr, "<>4__this");
      LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr_page = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher._Fetch_d__31>.NativeClassPtr, nameof (page));
      LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr_entriesPerPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher._Fetch_d__31>.NativeClassPtr, nameof (entriesPerPage));
      LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher._Fetch_d__31>.NativeClassPtr, nameof (type));
      LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr__fetchBoardTask_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher._Fetch_d__31>.NativeClassPtr, "<fetchBoardTask>5__2");
      LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher._Fetch_d__31>.NativeClassPtr, "<>u__1");
      LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher._Fetch_d__31>.NativeClassPtr, "<>u__2");
      LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr__fetchGlobalScoresTask_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher._Fetch_d__31>.NativeClassPtr, "<fetchGlobalScoresTask>5__3");
      LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr__fetchFriendsScoresTask_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher._Fetch_d__31>.NativeClassPtr, "<fetchFriendsScoresTask>5__4");
      LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher._Fetch_d__31>.NativeClassPtr, "<>u__3");
      LeaderboardsFetcher._Fetch_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsFetcher._Fetch_d__31>.NativeClassPtr, 100667407);
      LeaderboardsFetcher._Fetch_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsFetcher._Fetch_d__31>.NativeClassPtr, 100667408);
    }

    public _Fetch_d__31(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _Fetch_d__31()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LeaderboardsFetcher._Fetch_d__31>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LeaderboardsFetcher._Fetch_d__31>.NativeClassPtr, data));
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int dayOffset
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr_dayOffset));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr_dayOffset)) = value;
      }
    }

    public unsafe LeaderboardsFetcher __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (LeaderboardsFetcher) null : new LeaderboardsFetcher(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int page
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr_page));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr_page)) = value;
      }
    }

    public unsafe int entriesPerPage
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr_entriesPerPage));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr_entriesPerPage)) = value;
      }
    }

    public unsafe LeaderboardsFetcher.Type type
    {
      get
      {
        return *(LeaderboardsFetcher.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr_type));
      }
      [param: In] set
      {
        *(LeaderboardsFetcher.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr_type)) = value;
      }
    }

    public unsafe Task<Il2CppSystem.Nullable<Leaderboard>> _fetchBoardTask_5__2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr__fetchBoardTask_5__2));
        return pointer == System.IntPtr.Zero ? (Task<Il2CppSystem.Nullable<Leaderboard>>) null : new Task<Il2CppSystem.Nullable<Leaderboard>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr__fetchBoardTask_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public TaskAwaiter<Il2CppSystem.Nullable<Leaderboard>> __u__1
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter<Il2CppSystem.Nullable<Leaderboard>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Il2CppSystem.Nullable<Leaderboard>>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Il2CppSystem.Nullable<Leaderboard>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public TaskAwaiter __u__2
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr___u__2);
        return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Task<Il2CppReferenceArray<LeaderboardEntry>> _fetchGlobalScoresTask_5__3
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr__fetchGlobalScoresTask_5__3));
        return pointer == System.IntPtr.Zero ? (Task<Il2CppReferenceArray<LeaderboardEntry>>) null : new Task<Il2CppReferenceArray<LeaderboardEntry>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr__fetchGlobalScoresTask_5__3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Task<Il2CppReferenceArray<LeaderboardEntry>> _fetchFriendsScoresTask_5__4
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr__fetchFriendsScoresTask_5__4));
        return pointer == System.IntPtr.Zero ? (Task<Il2CppReferenceArray<LeaderboardEntry>>) null : new Task<Il2CppReferenceArray<LeaderboardEntry>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr__fetchFriendsScoresTask_5__4), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>> __u__3
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr___u__3);
        return new TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._Fetch_d__31.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("LeaderboardsFetcher/<FetchPlayerRankIfNecessary>d__32")]
  public sealed class _FetchPlayerRankIfNecessary_d__32 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_board;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__fetchPlayerRankTask_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51115, XrefRangeEnd = 51136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static _FetchPlayerRankIfNecessary_d__32()
    {
      Il2CppClassPointerStore<LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeaderboardsFetcher>.NativeClassPtr, "<FetchPlayerRankIfNecessary>d__32");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32>.NativeClassPtr);
      LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32>.NativeClassPtr, "<>1__state");
      LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32>.NativeClassPtr, "<>t__builder");
      LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32.NativeFieldInfoPtr_board = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32>.NativeClassPtr, nameof (board));
      LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32>.NativeClassPtr, "<>4__this");
      LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32.NativeFieldInfoPtr__fetchPlayerRankTask_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32>.NativeClassPtr, "<fetchPlayerRankTask>5__2");
      LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32>.NativeClassPtr, "<>u__1");
      LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32>.NativeClassPtr, 100667409);
      LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32>.NativeClassPtr, 100667410);
    }

    public _FetchPlayerRankIfNecessary_d__32(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _FetchPlayerRankIfNecessary_d__32()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32>.NativeClassPtr, data));
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Leaderboard board
    {
      get
      {
        return *(Leaderboard*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32.NativeFieldInfoPtr_board));
      }
      [param: In] set
      {
        *(Leaderboard*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32.NativeFieldInfoPtr_board)) = value;
      }
    }

    public unsafe LeaderboardsFetcher __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (LeaderboardsFetcher) null : new LeaderboardsFetcher(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Task<Il2CppReferenceArray<LeaderboardEntry>> _fetchPlayerRankTask_5__2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32.NativeFieldInfoPtr__fetchPlayerRankTask_5__2));
        return pointer == System.IntPtr.Zero ? (Task<Il2CppReferenceArray<LeaderboardEntry>>) null : new Task<Il2CppReferenceArray<LeaderboardEntry>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32.NativeFieldInfoPtr__fetchPlayerRankTask_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>> __u__1
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsFetcher._FetchPlayerRankIfNecessary_d__32.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
