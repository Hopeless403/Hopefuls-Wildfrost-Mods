// Decompiled with JetBrains decompiler
// Type: ScoreSubmitSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;
using System.Runtime.InteropServices;

#nullable disable
public class ScoreSubmitSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instance;
  private static readonly System.IntPtr NativeFieldInfoPtr_StartScore;
  private static readonly System.IntPtr NativeFieldInfoPtr__status_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__playerRank_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__SubmittedTime_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__SubmittedGold_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__SubmittedBattlesWon_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__SubmittedScore_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__result_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_status_Public_Static_get_Status_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_status_Private_Static_set_Void_Status_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_playerRank_Public_Static_get_Nullable_1_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_playerRank_Private_Static_set_Void_Nullable_1_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SubmittedTime_Public_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SubmittedTime_Private_Static_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SubmittedGold_Public_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SubmittedGold_Private_Static_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SubmittedBattlesWon_Public_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SubmittedBattlesWon_Private_Static_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SubmittedScore_Public_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SubmittedScore_Private_Static_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_result_Public_Static_get_Nullable_1_LeaderboardUpdate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_result_Private_Static_set_Void_Nullable_1_LeaderboardUpdate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CampaignEnd_Private_Static_Void_Result_CampaignStats_PlayerData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SubmitScore_Private_Static_IEnumerator_Boolean_CampaignStats_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetScore_Private_Static_Int32_Boolean_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetScoreFromTime_Public_Static_Int32_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetScoreFromGold_Public_Static_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetScoreFromBattlesWon_Public_Static_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public static unsafe ScoreSubmitSystem.Status status
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70272, XrefRangeEnd = 70274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.NativeMethodInfoPtr_get_status_Public_Static_get_Status_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ScoreSubmitSystem.Status*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70274, XrefRangeEnd = 70276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.NativeMethodInfoPtr_set_status_Private_Static_set_Void_Status_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public static unsafe Il2CppSystem.Nullable<int> playerRank
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70276, XrefRangeEnd = 70278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.NativeMethodInfoPtr_get_playerRank_Public_Static_get_Nullable_1_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new Il2CppSystem.Nullable<int>(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70278, XrefRangeEnd = 70280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.NativeMethodInfoPtr_set_playerRank_Private_Static_set_Void_Nullable_1_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public static unsafe int SubmittedTime
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70280, XrefRangeEnd = 70282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.NativeMethodInfoPtr_get_SubmittedTime_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70282, XrefRangeEnd = 70284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.NativeMethodInfoPtr_set_SubmittedTime_Private_Static_set_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public static unsafe int SubmittedGold
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70284, XrefRangeEnd = 70286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.NativeMethodInfoPtr_get_SubmittedGold_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70286, XrefRangeEnd = 70288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.NativeMethodInfoPtr_set_SubmittedGold_Private_Static_set_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public static unsafe int SubmittedBattlesWon
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70288, XrefRangeEnd = 70290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.NativeMethodInfoPtr_get_SubmittedBattlesWon_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70290, XrefRangeEnd = 70292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.NativeMethodInfoPtr_set_SubmittedBattlesWon_Private_Static_set_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public static unsafe int SubmittedScore
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70292, XrefRangeEnd = 70294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.NativeMethodInfoPtr_get_SubmittedScore_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70294, XrefRangeEnd = 70296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.NativeMethodInfoPtr_set_SubmittedScore_Private_Static_set_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70296, XrefRangeEnd = 70308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70308, XrefRangeEnd = 70316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public static unsafe Il2CppSystem.Nullable<LeaderboardUpdate> result
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70316, XrefRangeEnd = 70318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.NativeMethodInfoPtr_get_result_Public_Static_get_Nullable_1_LeaderboardUpdate_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new Il2CppSystem.Nullable<LeaderboardUpdate>(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70318, XrefRangeEnd = 70320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.NativeMethodInfoPtr_set_result_Private_Static_set_Void_Nullable_1_LeaderboardUpdate_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70320, XrefRangeEnd = 70330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CampaignEnd(
    Campaign.Result result,
    CampaignStats stats,
    PlayerData playerData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &result;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stats);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) playerData);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.NativeMethodInfoPtr_CampaignEnd_Private_Static_Void_Result_CampaignStats_PlayerData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70330, XrefRangeEnd = 70335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IEnumerator SubmitScore(bool win, CampaignStats stats)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &win;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stats);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.NativeMethodInfoPtr_SubmitScore_Private_Static_IEnumerator_Boolean_CampaignStats_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  public static unsafe int GetScore(bool win, int seconds, int gold, int battlesWon)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &win;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &seconds;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &gold;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &battlesWon;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.NativeMethodInfoPtr_GetScore_Private_Static_Int32_Boolean_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe int GetScoreFromTime(bool win, int seconds)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &win;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &seconds;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.NativeMethodInfoPtr_GetScoreFromTime_Public_Static_Int32_Boolean_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(124)]
  [CachedScanResults(RefRangeStart = 70335, RefRangeEnd = 70459, XrefRangeStart = 70335, XrefRangeEnd = 70335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetScoreFromGold(int goldRemaining)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &goldRemaining
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.NativeMethodInfoPtr_GetScoreFromGold_Public_Static_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe int GetScoreFromBattlesWon(int battlesWon)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &battlesWon
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.NativeMethodInfoPtr_GetScoreFromBattlesWon_Public_Static_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScoreSubmitSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ScoreSubmitSystem()
  {
    Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ScoreSubmitSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr);
    ScoreSubmitSystem.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, nameof (instance));
    ScoreSubmitSystem.NativeFieldInfoPtr_StartScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, nameof (StartScore));
    ScoreSubmitSystem.NativeFieldInfoPtr__status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, "<status>k__BackingField");
    ScoreSubmitSystem.NativeFieldInfoPtr__playerRank_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, "<playerRank>k__BackingField");
    ScoreSubmitSystem.NativeFieldInfoPtr__SubmittedTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, "<SubmittedTime>k__BackingField");
    ScoreSubmitSystem.NativeFieldInfoPtr__SubmittedGold_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, "<SubmittedGold>k__BackingField");
    ScoreSubmitSystem.NativeFieldInfoPtr__SubmittedBattlesWon_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, "<SubmittedBattlesWon>k__BackingField");
    ScoreSubmitSystem.NativeFieldInfoPtr__SubmittedScore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, "<SubmittedScore>k__BackingField");
    ScoreSubmitSystem.NativeFieldInfoPtr__result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, "<result>k__BackingField");
    ScoreSubmitSystem.NativeMethodInfoPtr_get_status_Public_Static_get_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, 100669017);
    ScoreSubmitSystem.NativeMethodInfoPtr_set_status_Private_Static_set_Void_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, 100669018);
    ScoreSubmitSystem.NativeMethodInfoPtr_get_playerRank_Public_Static_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, 100669019);
    ScoreSubmitSystem.NativeMethodInfoPtr_set_playerRank_Private_Static_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, 100669020);
    ScoreSubmitSystem.NativeMethodInfoPtr_get_SubmittedTime_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, 100669021);
    ScoreSubmitSystem.NativeMethodInfoPtr_set_SubmittedTime_Private_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, 100669022);
    ScoreSubmitSystem.NativeMethodInfoPtr_get_SubmittedGold_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, 100669023);
    ScoreSubmitSystem.NativeMethodInfoPtr_set_SubmittedGold_Private_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, 100669024);
    ScoreSubmitSystem.NativeMethodInfoPtr_get_SubmittedBattlesWon_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, 100669025);
    ScoreSubmitSystem.NativeMethodInfoPtr_set_SubmittedBattlesWon_Private_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, 100669026);
    ScoreSubmitSystem.NativeMethodInfoPtr_get_SubmittedScore_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, 100669027);
    ScoreSubmitSystem.NativeMethodInfoPtr_set_SubmittedScore_Private_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, 100669028);
    ScoreSubmitSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, 100669029);
    ScoreSubmitSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, 100669030);
    ScoreSubmitSystem.NativeMethodInfoPtr_get_result_Public_Static_get_Nullable_1_LeaderboardUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, 100669031);
    ScoreSubmitSystem.NativeMethodInfoPtr_set_result_Private_Static_set_Void_Nullable_1_LeaderboardUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, 100669032);
    ScoreSubmitSystem.NativeMethodInfoPtr_CampaignEnd_Private_Static_Void_Result_CampaignStats_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, 100669033);
    ScoreSubmitSystem.NativeMethodInfoPtr_SubmitScore_Private_Static_IEnumerator_Boolean_CampaignStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, 100669034);
    ScoreSubmitSystem.NativeMethodInfoPtr_GetScore_Private_Static_Int32_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, 100669035);
    ScoreSubmitSystem.NativeMethodInfoPtr_GetScoreFromTime_Public_Static_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, 100669036);
    ScoreSubmitSystem.NativeMethodInfoPtr_GetScoreFromGold_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, 100669037);
    ScoreSubmitSystem.NativeMethodInfoPtr_GetScoreFromBattlesWon_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, 100669038);
    ScoreSubmitSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, 100669039);
  }

  public ScoreSubmitSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe ScoreSubmitSystem instance
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ScoreSubmitSystem.NativeFieldInfoPtr_instance, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ScoreSubmitSystem) null : new ScoreSubmitSystem(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScoreSubmitSystem.NativeFieldInfoPtr_instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe int StartScore
  {
    get
    {
      int startScore;
      IL2CPP.il2cpp_field_static_get_value(ScoreSubmitSystem.NativeFieldInfoPtr_StartScore, (void*) &startScore);
      return startScore;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScoreSubmitSystem.NativeFieldInfoPtr_StartScore, (void*) &value);
    }
  }

  public static unsafe ScoreSubmitSystem.Status _status_k__BackingField
  {
    get
    {
      ScoreSubmitSystem.Status statusKBackingField;
      IL2CPP.il2cpp_field_static_get_value(ScoreSubmitSystem.NativeFieldInfoPtr__status_k__BackingField, (void*) &statusKBackingField);
      return statusKBackingField;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScoreSubmitSystem.NativeFieldInfoPtr__status_k__BackingField, (void*) &value);
    }
  }

  public static unsafe Il2CppSystem.Nullable<int> _playerRank_k__BackingField
  {
    get
    {
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      IL2CPP.il2cpp_field_static_get_value(ScoreSubmitSystem.NativeFieldInfoPtr__playerRank_k__BackingField, (void*) data);
      return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, data));
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScoreSubmitSystem.NativeFieldInfoPtr__playerRank_k__BackingField, (void*) IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value)));
    }
  }

  public static unsafe int _SubmittedTime_k__BackingField
  {
    get
    {
      int timeKBackingField;
      IL2CPP.il2cpp_field_static_get_value(ScoreSubmitSystem.NativeFieldInfoPtr__SubmittedTime_k__BackingField, (void*) &timeKBackingField);
      return timeKBackingField;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScoreSubmitSystem.NativeFieldInfoPtr__SubmittedTime_k__BackingField, (void*) &value);
    }
  }

  public static unsafe int _SubmittedGold_k__BackingField
  {
    get
    {
      int goldKBackingField;
      IL2CPP.il2cpp_field_static_get_value(ScoreSubmitSystem.NativeFieldInfoPtr__SubmittedGold_k__BackingField, (void*) &goldKBackingField);
      return goldKBackingField;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScoreSubmitSystem.NativeFieldInfoPtr__SubmittedGold_k__BackingField, (void*) &value);
    }
  }

  public static unsafe int _SubmittedBattlesWon_k__BackingField
  {
    get
    {
      int wonKBackingField;
      IL2CPP.il2cpp_field_static_get_value(ScoreSubmitSystem.NativeFieldInfoPtr__SubmittedBattlesWon_k__BackingField, (void*) &wonKBackingField);
      return wonKBackingField;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScoreSubmitSystem.NativeFieldInfoPtr__SubmittedBattlesWon_k__BackingField, (void*) &value);
    }
  }

  public static unsafe int _SubmittedScore_k__BackingField
  {
    get
    {
      int scoreKBackingField;
      IL2CPP.il2cpp_field_static_get_value(ScoreSubmitSystem.NativeFieldInfoPtr__SubmittedScore_k__BackingField, (void*) &scoreKBackingField);
      return scoreKBackingField;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScoreSubmitSystem.NativeFieldInfoPtr__SubmittedScore_k__BackingField, (void*) &value);
    }
  }

  public static unsafe Il2CppSystem.Nullable<LeaderboardUpdate> _result_k__BackingField
  {
    get
    {
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<LeaderboardUpdate>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      IL2CPP.il2cpp_field_static_get_value(ScoreSubmitSystem.NativeFieldInfoPtr__result_k__BackingField, (void*) data);
      return new Il2CppSystem.Nullable<LeaderboardUpdate>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<LeaderboardUpdate>>.NativeClassPtr, data));
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScoreSubmitSystem.NativeFieldInfoPtr__result_k__BackingField, (void*) IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value)));
    }
  }

  public enum Status
  {
    Submitting,
    Failed,
    Success,
  }

  [ObfuscatedName("ScoreSubmitSystem/<>c__DisplayClass34_0")]
  public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_task;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SubmitScore_b__0_Internal_Boolean_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass34_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScoreSubmitSystem.__c__DisplayClass34_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70141, XrefRangeEnd = 70143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _SubmitScore_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem.__c__DisplayClass34_0.NativeMethodInfoPtr__SubmitScore_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass34_0()
    {
      Il2CppClassPointerStore<ScoreSubmitSystem.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, "<>c__DisplayClass34_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScoreSubmitSystem.__c__DisplayClass34_0>.NativeClassPtr);
      ScoreSubmitSystem.__c__DisplayClass34_0.NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScoreSubmitSystem.__c__DisplayClass34_0>.NativeClassPtr, nameof (task));
      ScoreSubmitSystem.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem.__c__DisplayClass34_0>.NativeClassPtr, 100669040);
      ScoreSubmitSystem.__c__DisplayClass34_0.NativeMethodInfoPtr__SubmitScore_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem.__c__DisplayClass34_0>.NativeClassPtr, 100669041);
    }

    public __c__DisplayClass34_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Task<Il2CppSystem.Nullable<LeaderboardUpdate>> task
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScoreSubmitSystem.__c__DisplayClass34_0.NativeFieldInfoPtr_task));
        return pointer == System.IntPtr.Zero ? (Task<Il2CppSystem.Nullable<LeaderboardUpdate>>) null : new Task<Il2CppSystem.Nullable<LeaderboardUpdate>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScoreSubmitSystem.__c__DisplayClass34_0.NativeFieldInfoPtr_task), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("ScoreSubmitSystem/<SubmitScore>d__34")]
  public sealed class _SubmitScore_d__34 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_win;
    private static readonly System.IntPtr NativeFieldInfoPtr_stats;
    private static readonly System.IntPtr NativeFieldInfoPtr___8__1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _SubmitScore_d__34(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScoreSubmitSystem._SubmitScore_d__34>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem._SubmitScore_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem._SubmitScore_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70143, XrefRangeEnd = 70266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem._SubmitScore_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem._SubmitScore_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70266, XrefRangeEnd = 70272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem._SubmitScore_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScoreSubmitSystem._SubmitScore_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _SubmitScore_d__34()
    {
      Il2CppClassPointerStore<ScoreSubmitSystem._SubmitScore_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScoreSubmitSystem>.NativeClassPtr, "<SubmitScore>d__34");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScoreSubmitSystem._SubmitScore_d__34>.NativeClassPtr);
      ScoreSubmitSystem._SubmitScore_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScoreSubmitSystem._SubmitScore_d__34>.NativeClassPtr, "<>1__state");
      ScoreSubmitSystem._SubmitScore_d__34.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScoreSubmitSystem._SubmitScore_d__34>.NativeClassPtr, "<>2__current");
      ScoreSubmitSystem._SubmitScore_d__34.NativeFieldInfoPtr_win = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScoreSubmitSystem._SubmitScore_d__34>.NativeClassPtr, nameof (win));
      ScoreSubmitSystem._SubmitScore_d__34.NativeFieldInfoPtr_stats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScoreSubmitSystem._SubmitScore_d__34>.NativeClassPtr, nameof (stats));
      ScoreSubmitSystem._SubmitScore_d__34.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScoreSubmitSystem._SubmitScore_d__34>.NativeClassPtr, "<>8__1");
      ScoreSubmitSystem._SubmitScore_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem._SubmitScore_d__34>.NativeClassPtr, 100669042);
      ScoreSubmitSystem._SubmitScore_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem._SubmitScore_d__34>.NativeClassPtr, 100669043);
      ScoreSubmitSystem._SubmitScore_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem._SubmitScore_d__34>.NativeClassPtr, 100669044);
      ScoreSubmitSystem._SubmitScore_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem._SubmitScore_d__34>.NativeClassPtr, 100669045);
      ScoreSubmitSystem._SubmitScore_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem._SubmitScore_d__34>.NativeClassPtr, 100669046);
      ScoreSubmitSystem._SubmitScore_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScoreSubmitSystem._SubmitScore_d__34>.NativeClassPtr, 100669047);
    }

    public _SubmitScore_d__34(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScoreSubmitSystem._SubmitScore_d__34.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScoreSubmitSystem._SubmitScore_d__34.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScoreSubmitSystem._SubmitScore_d__34.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScoreSubmitSystem._SubmitScore_d__34.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool win
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScoreSubmitSystem._SubmitScore_d__34.NativeFieldInfoPtr_win));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScoreSubmitSystem._SubmitScore_d__34.NativeFieldInfoPtr_win)) = value;
      }
    }

    public unsafe CampaignStats stats
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScoreSubmitSystem._SubmitScore_d__34.NativeFieldInfoPtr_stats));
        return pointer == System.IntPtr.Zero ? (CampaignStats) null : new CampaignStats(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScoreSubmitSystem._SubmitScore_d__34.NativeFieldInfoPtr_stats), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ScoreSubmitSystem.__c__DisplayClass34_0 __8__1
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScoreSubmitSystem._SubmitScore_d__34.NativeFieldInfoPtr___8__1));
        return pointer == System.IntPtr.Zero ? (ScoreSubmitSystem.__c__DisplayClass34_0) null : new ScoreSubmitSystem.__c__DisplayClass34_0(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScoreSubmitSystem._SubmitScore_d__34.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
