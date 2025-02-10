// Decompiled with JetBrains decompiler
// Type: LeaderboardsPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class LeaderboardsPanel : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_loading;
  private static readonly System.IntPtr NativeFieldInfoPtr_noEntries;
  private static readonly System.IntPtr NativeFieldInfoPtr_noConnection;
  private static readonly System.IntPtr NativeFieldInfoPtr_tooManyRequests;
  private static readonly System.IntPtr NativeFieldInfoPtr_entriesGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_dateTextSetter;
  private static readonly System.IntPtr NativeFieldInfoPtr_fetcher;
  private static readonly System.IntPtr NativeFieldInfoPtr_entryPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_fetchEveryTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_entriesPerPage;
  private static readonly System.IntPtr NativeFieldInfoPtr_type;
  private static readonly System.IntPtr NativeFieldInfoPtr_globalButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_friendsButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerRankButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_nextPageButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_prePageButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_nextDayButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_preDayButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_page;
  private static readonly System.IntPtr NativeFieldInfoPtr_dayOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerRankPage;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxDayOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxPage;
  private static readonly System.IntPtr NativeFieldInfoPtr_fetched;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_fetch_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Fetch_Private_IEnumerator_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Populate_Private_Void_IReadOnlyCollection_1_LeaderboardEntry_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PreviousDay_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NextDay_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetDayOffset_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NextPage_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PreviousPage_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPage_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Global_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Friends_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_JumpToPlayer_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Refetch_Private_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SecondsToTimeString_Private_Static_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe bool fetch
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel.NativeMethodInfoPtr_get_fetch_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92108, XrefRangeEnd = 92112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 92119, RefRangeEnd = 92128, XrefRangeStart = 92112, XrefRangeEnd = 92119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel.NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 92133, RefRangeEnd = 92142, XrefRangeStart = 92128, XrefRangeEnd = 92133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Fetch(bool aroundPlayer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aroundPlayer
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel.NativeMethodInfoPtr_Fetch_Private_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92142, XrefRangeEnd = 92203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Populate(IReadOnlyCollection<LeaderboardEntry> entries)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entries)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel.NativeMethodInfoPtr_Populate_Private_Void_IReadOnlyCollection_1_LeaderboardEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92203, XrefRangeEnd = 92208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PreviousDay()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel.NativeMethodInfoPtr_PreviousDay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92208, XrefRangeEnd = 92213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void NextDay()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel.NativeMethodInfoPtr_NextDay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 92221, RefRangeEnd = 92223, XrefRangeStart = 92213, XrefRangeEnd = 92221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetDayOffset(int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel.NativeMethodInfoPtr_SetDayOffset_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92223, XrefRangeEnd = 92229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void NextPage()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel.NativeMethodInfoPtr_NextPage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92229, XrefRangeEnd = 92235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PreviousPage()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel.NativeMethodInfoPtr_PreviousPage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92235, XrefRangeEnd = 92238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPage(int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel.NativeMethodInfoPtr_SetPage_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92238, XrefRangeEnd = 92244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Global()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel.NativeMethodInfoPtr_Global_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92244, XrefRangeEnd = 92250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Friends()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel.NativeMethodInfoPtr_Friends_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92250, XrefRangeEnd = 92256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void JumpToPlayer()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel.NativeMethodInfoPtr_JumpToPlayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92256, XrefRangeEnd = 92260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Refetch(bool aroundPlayer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aroundPlayer
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel.NativeMethodInfoPtr_Refetch_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92260, XrefRangeEnd = 92281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string SecondsToTimeString(int seconds)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &seconds
    };
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel.NativeMethodInfoPtr_SecondsToTimeString_Private_Static_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92281, XrefRangeEnd = 92282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LeaderboardsPanel()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LeaderboardsPanel()
  {
    Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LeaderboardsPanel));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr);
    LeaderboardsPanel.NativeFieldInfoPtr_loading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (loading));
    LeaderboardsPanel.NativeFieldInfoPtr_noEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (noEntries));
    LeaderboardsPanel.NativeFieldInfoPtr_noConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (noConnection));
    LeaderboardsPanel.NativeFieldInfoPtr_tooManyRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (tooManyRequests));
    LeaderboardsPanel.NativeFieldInfoPtr_entriesGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (entriesGroup));
    LeaderboardsPanel.NativeFieldInfoPtr_dateTextSetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (dateTextSetter));
    LeaderboardsPanel.NativeFieldInfoPtr_fetcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (fetcher));
    LeaderboardsPanel.NativeFieldInfoPtr_entryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (entryPrefab));
    LeaderboardsPanel.NativeFieldInfoPtr_fetchEveryTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (fetchEveryTime));
    LeaderboardsPanel.NativeFieldInfoPtr_entriesPerPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (entriesPerPage));
    LeaderboardsPanel.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (type));
    LeaderboardsPanel.NativeFieldInfoPtr_globalButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (globalButton));
    LeaderboardsPanel.NativeFieldInfoPtr_friendsButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (friendsButton));
    LeaderboardsPanel.NativeFieldInfoPtr_playerRankButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (playerRankButton));
    LeaderboardsPanel.NativeFieldInfoPtr_nextPageButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (nextPageButton));
    LeaderboardsPanel.NativeFieldInfoPtr_prePageButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (prePageButton));
    LeaderboardsPanel.NativeFieldInfoPtr_nextDayButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (nextDayButton));
    LeaderboardsPanel.NativeFieldInfoPtr_preDayButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (preDayButton));
    LeaderboardsPanel.NativeFieldInfoPtr_page = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (page));
    LeaderboardsPanel.NativeFieldInfoPtr_dayOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (dayOffset));
    LeaderboardsPanel.NativeFieldInfoPtr_playerRankPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (playerRankPage));
    LeaderboardsPanel.NativeFieldInfoPtr_maxDayOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (maxDayOffset));
    LeaderboardsPanel.NativeFieldInfoPtr_maxPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (maxPage));
    LeaderboardsPanel.NativeFieldInfoPtr_fetched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, nameof (fetched));
    LeaderboardsPanel.NativeMethodInfoPtr_get_fetch_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, 100671232);
    LeaderboardsPanel.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, 100671233);
    LeaderboardsPanel.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, 100671234);
    LeaderboardsPanel.NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, 100671235);
    LeaderboardsPanel.NativeMethodInfoPtr_Fetch_Private_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, 100671236);
    LeaderboardsPanel.NativeMethodInfoPtr_Populate_Private_Void_IReadOnlyCollection_1_LeaderboardEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, 100671237);
    LeaderboardsPanel.NativeMethodInfoPtr_PreviousDay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, 100671238);
    LeaderboardsPanel.NativeMethodInfoPtr_NextDay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, 100671239);
    LeaderboardsPanel.NativeMethodInfoPtr_SetDayOffset_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, 100671240);
    LeaderboardsPanel.NativeMethodInfoPtr_NextPage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, 100671241);
    LeaderboardsPanel.NativeMethodInfoPtr_PreviousPage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, 100671242);
    LeaderboardsPanel.NativeMethodInfoPtr_SetPage_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, 100671243);
    LeaderboardsPanel.NativeMethodInfoPtr_Global_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, 100671244);
    LeaderboardsPanel.NativeMethodInfoPtr_Friends_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, 100671245);
    LeaderboardsPanel.NativeMethodInfoPtr_JumpToPlayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, 100671246);
    LeaderboardsPanel.NativeMethodInfoPtr_Refetch_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, 100671247);
    LeaderboardsPanel.NativeMethodInfoPtr_SecondsToTimeString_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, 100671248);
    LeaderboardsPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, 100671249);
  }

  public LeaderboardsPanel(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe GameObject loading
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_loading));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_loading), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject noEntries
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_noEntries));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_noEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject noConnection
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_noConnection));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_noConnection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject tooManyRequests
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_tooManyRequests));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_tooManyRequests), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform entriesGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_entriesGroup));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_entriesGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DateTextSetter dateTextSetter
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_dateTextSetter));
      return pointer == System.IntPtr.Zero ? (DateTextSetter) null : new DateTextSetter(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_dateTextSetter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LeaderboardsFetcher fetcher
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_fetcher));
      return pointer == System.IntPtr.Zero ? (LeaderboardsFetcher) null : new LeaderboardsFetcher(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_fetcher), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LeaderboardsEntry entryPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_entryPrefab));
      return pointer == System.IntPtr.Zero ? (LeaderboardsEntry) null : new LeaderboardsEntry(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_entryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool fetchEveryTime
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_fetchEveryTime));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_fetchEveryTime)) = value;
    }
  }

  public unsafe int entriesPerPage
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_entriesPerPage));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_entriesPerPage)) = value;
    }
  }

  public unsafe LeaderboardsFetcher.Type type
  {
    get
    {
      return *(LeaderboardsFetcher.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_type));
    }
    [param: In] set
    {
      *(LeaderboardsFetcher.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_type)) = value;
    }
  }

  public unsafe ButtonAnimator globalButton
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_globalButton));
      return pointer == System.IntPtr.Zero ? (ButtonAnimator) null : new ButtonAnimator(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_globalButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ButtonAnimator friendsButton
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_friendsButton));
      return pointer == System.IntPtr.Zero ? (ButtonAnimator) null : new ButtonAnimator(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_friendsButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ButtonAnimator playerRankButton
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_playerRankButton));
      return pointer == System.IntPtr.Zero ? (ButtonAnimator) null : new ButtonAnimator(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_playerRankButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ButtonAnimator nextPageButton
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_nextPageButton));
      return pointer == System.IntPtr.Zero ? (ButtonAnimator) null : new ButtonAnimator(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_nextPageButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ButtonAnimator prePageButton
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_prePageButton));
      return pointer == System.IntPtr.Zero ? (ButtonAnimator) null : new ButtonAnimator(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_prePageButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ButtonAnimator nextDayButton
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_nextDayButton));
      return pointer == System.IntPtr.Zero ? (ButtonAnimator) null : new ButtonAnimator(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_nextDayButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ButtonAnimator preDayButton
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_preDayButton));
      return pointer == System.IntPtr.Zero ? (ButtonAnimator) null : new ButtonAnimator(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_preDayButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int page
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_page));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_page)) = value;
    }
  }

  public unsafe int dayOffset
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_dayOffset));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_dayOffset)) = value;
    }
  }

  public unsafe int playerRankPage
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_playerRankPage));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_playerRankPage)) = value;
    }
  }

  public static unsafe int maxDayOffset
  {
    get
    {
      int maxDayOffset;
      IL2CPP.il2cpp_field_static_get_value(LeaderboardsPanel.NativeFieldInfoPtr_maxDayOffset, (void*) &maxDayOffset);
      return maxDayOffset;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeaderboardsPanel.NativeFieldInfoPtr_maxDayOffset, (void*) &value);
    }
  }

  public unsafe int maxPage
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_maxPage));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_maxPage)) = value;
    }
  }

  public unsafe bool fetched
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_fetched));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.NativeFieldInfoPtr_fetched)) = value;
    }
  }

  [ObfuscatedName("LeaderboardsPanel/<>c__DisplayClass29_0")]
  public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_op;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Fetch_b__0_Internal_Boolean_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass29_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderboardsPanel.__c__DisplayClass29_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Fetch_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel.__c__DisplayClass29_0.NativeMethodInfoPtr__Fetch_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass29_0()
    {
      Il2CppClassPointerStore<LeaderboardsPanel.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, "<>c__DisplayClass29_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardsPanel.__c__DisplayClass29_0>.NativeClassPtr);
      LeaderboardsPanel.__c__DisplayClass29_0.NativeFieldInfoPtr_op = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel.__c__DisplayClass29_0>.NativeClassPtr, nameof (op));
      LeaderboardsPanel.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel.__c__DisplayClass29_0>.NativeClassPtr, 100671250);
      LeaderboardsPanel.__c__DisplayClass29_0.NativeMethodInfoPtr__Fetch_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel.__c__DisplayClass29_0>.NativeClassPtr, 100671251);
    }

    public __c__DisplayClass29_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Task op
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.__c__DisplayClass29_0.NativeFieldInfoPtr_op));
        return pointer == System.IntPtr.Zero ? (Task) null : new Task(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel.__c__DisplayClass29_0.NativeFieldInfoPtr_op), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("LeaderboardsPanel/<Fetch>d__29")]
  public sealed class _Fetch_d__29 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_aroundPlayer;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Fetch_d__29(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderboardsPanel._Fetch_d__29>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel._Fetch_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel._Fetch_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92077, XrefRangeEnd = 92102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel._Fetch_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel._Fetch_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92102, XrefRangeEnd = 92108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel._Fetch_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaderboardsPanel._Fetch_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Fetch_d__29()
    {
      Il2CppClassPointerStore<LeaderboardsPanel._Fetch_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeaderboardsPanel>.NativeClassPtr, "<Fetch>d__29");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardsPanel._Fetch_d__29>.NativeClassPtr);
      LeaderboardsPanel._Fetch_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel._Fetch_d__29>.NativeClassPtr, "<>1__state");
      LeaderboardsPanel._Fetch_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel._Fetch_d__29>.NativeClassPtr, "<>2__current");
      LeaderboardsPanel._Fetch_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel._Fetch_d__29>.NativeClassPtr, "<>4__this");
      LeaderboardsPanel._Fetch_d__29.NativeFieldInfoPtr_aroundPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsPanel._Fetch_d__29>.NativeClassPtr, nameof (aroundPlayer));
      LeaderboardsPanel._Fetch_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel._Fetch_d__29>.NativeClassPtr, 100671252);
      LeaderboardsPanel._Fetch_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel._Fetch_d__29>.NativeClassPtr, 100671253);
      LeaderboardsPanel._Fetch_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel._Fetch_d__29>.NativeClassPtr, 100671254);
      LeaderboardsPanel._Fetch_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel._Fetch_d__29>.NativeClassPtr, 100671255);
      LeaderboardsPanel._Fetch_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel._Fetch_d__29>.NativeClassPtr, 100671256);
      LeaderboardsPanel._Fetch_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsPanel._Fetch_d__29>.NativeClassPtr, 100671257);
    }

    public _Fetch_d__29(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel._Fetch_d__29.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel._Fetch_d__29.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel._Fetch_d__29.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel._Fetch_d__29.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LeaderboardsPanel __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel._Fetch_d__29.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (LeaderboardsPanel) null : new LeaderboardsPanel(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel._Fetch_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool aroundPlayer
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel._Fetch_d__29.NativeFieldInfoPtr_aroundPlayer));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderboardsPanel._Fetch_d__29.NativeFieldInfoPtr_aroundPlayer)) = value;
      }
    }
  }
}
