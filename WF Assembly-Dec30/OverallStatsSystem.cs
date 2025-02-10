// Decompiled with JetBrains decompiler
// Type: OverallStatsSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
public class OverallStatsSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instance;
  private static readonly System.IntPtr NativeFieldInfoPtr_stats;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_CampaignStats_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GameStart_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CampaignEnd_Private_Void_Result_CampaignStats_PlayerData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetWinStreak_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Save_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Combine_Public_Static_Void_CampaignStats_CampaignStats_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Change_Private_Static_Void_String_String_Int32_byref_Dictionary_2_String_Dictionary_2_String_Int32_Func_3_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Private_Static_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Max_Private_Static_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66275, XrefRangeEnd = 66279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(OverallStatsSystem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66279, XrefRangeEnd = 66294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(OverallStatsSystem.NativeMethodInfoPtr_OnEnable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66294, XrefRangeEnd = 66309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(OverallStatsSystem.NativeMethodInfoPtr_OnDisable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 66311, RefRangeEnd = 66313, XrefRangeStart = 66309, XrefRangeEnd = 66311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe CampaignStats Get()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OverallStatsSystem.NativeMethodInfoPtr_Get_Public_Static_CampaignStats_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CampaignStats) null : new CampaignStats(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66313, XrefRangeEnd = 66356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GameStart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(OverallStatsSystem.NativeMethodInfoPtr_GameStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66356, XrefRangeEnd = 66427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CampaignEnd(
    Campaign.Result result,
    CampaignStats stats,
    PlayerData playerData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &result;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stats);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) playerData);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(OverallStatsSystem.NativeMethodInfoPtr_CampaignEnd_Private_Void_Result_CampaignStats_PlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 66434, RefRangeEnd = 66436, XrefRangeStart = 66427, XrefRangeEnd = 66434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetWinStreak()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(OverallStatsSystem.NativeMethodInfoPtr_ResetWinStreak_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66436, XrefRangeEnd = 66445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Save()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(OverallStatsSystem.NativeMethodInfoPtr_Save_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 66510, RefRangeEnd = 66513, XrefRangeStart = 66445, XrefRangeEnd = 66510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Combine(CampaignStats stats, CampaignStats other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stats);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(OverallStatsSystem.NativeMethodInfoPtr_Combine_Public_Static_Void_CampaignStats_CampaignStats_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 66545, RefRangeEnd = 66547, XrefRangeStart = 66513, XrefRangeEnd = 66545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Change(
    string stat,
    string key,
    int value,
    ref Dictionary<string, Dictionary<string, int>> values,
    Il2CppSystem.Func<int, int, int> action)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(stat);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) values);
    System.IntPtr* numPtr2 = &ptr;
    *(System.IntPtr*) num = (System.IntPtr) numPtr2;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(OverallStatsSystem.NativeMethodInfoPtr_Change_Private_Static_Void_String_String_Int32_byref_Dictionary_2_String_Dictionary_2_String_Int32_Func_3_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref Dictionary<string, Dictionary<string, int>> local = ref values;
    System.IntPtr pointer = ptr;
    Dictionary<,> dictionary = pointer == System.IntPtr.Zero ? (Dictionary<,>) null : new Dictionary<,>(pointer);
    local = (Dictionary<string, Dictionary<string, int>>) dictionary;
  }

  [CallerCount(0)]
  public static unsafe int Add(int value, int add)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &add;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OverallStatsSystem.NativeMethodInfoPtr_Add_Private_Static_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe int Max(int value, int max)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &max;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OverallStatsSystem.NativeMethodInfoPtr_Max_Private_Static_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe OverallStatsSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverallStatsSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(OverallStatsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static OverallStatsSystem()
  {
    Il2CppClassPointerStore<OverallStatsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (OverallStatsSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverallStatsSystem>.NativeClassPtr);
    OverallStatsSystem.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverallStatsSystem>.NativeClassPtr, nameof (instance));
    OverallStatsSystem.NativeFieldInfoPtr_stats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverallStatsSystem>.NativeClassPtr, nameof (stats));
    OverallStatsSystem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverallStatsSystem>.NativeClassPtr, 100668766);
    OverallStatsSystem.NativeMethodInfoPtr_OnEnable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverallStatsSystem>.NativeClassPtr, 100668767);
    OverallStatsSystem.NativeMethodInfoPtr_OnDisable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverallStatsSystem>.NativeClassPtr, 100668768);
    OverallStatsSystem.NativeMethodInfoPtr_Get_Public_Static_CampaignStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverallStatsSystem>.NativeClassPtr, 100668769);
    OverallStatsSystem.NativeMethodInfoPtr_GameStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverallStatsSystem>.NativeClassPtr, 100668770);
    OverallStatsSystem.NativeMethodInfoPtr_CampaignEnd_Private_Void_Result_CampaignStats_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverallStatsSystem>.NativeClassPtr, 100668771);
    OverallStatsSystem.NativeMethodInfoPtr_ResetWinStreak_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverallStatsSystem>.NativeClassPtr, 100668772);
    OverallStatsSystem.NativeMethodInfoPtr_Save_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverallStatsSystem>.NativeClassPtr, 100668773);
    OverallStatsSystem.NativeMethodInfoPtr_Combine_Public_Static_Void_CampaignStats_CampaignStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverallStatsSystem>.NativeClassPtr, 100668774);
    OverallStatsSystem.NativeMethodInfoPtr_Change_Private_Static_Void_String_String_Int32_byref_Dictionary_2_String_Dictionary_2_String_Int32_Func_3_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverallStatsSystem>.NativeClassPtr, 100668775);
    OverallStatsSystem.NativeMethodInfoPtr_Add_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverallStatsSystem>.NativeClassPtr, 100668776);
    OverallStatsSystem.NativeMethodInfoPtr_Max_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverallStatsSystem>.NativeClassPtr, 100668777);
    OverallStatsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverallStatsSystem>.NativeClassPtr, 100668778);
  }

  public OverallStatsSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe OverallStatsSystem instance
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(OverallStatsSystem.NativeFieldInfoPtr_instance, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (OverallStatsSystem) null : new OverallStatsSystem(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(OverallStatsSystem.NativeFieldInfoPtr_instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CampaignStats stats
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverallStatsSystem.NativeFieldInfoPtr_stats));
      return pointer == System.IntPtr.Zero ? (CampaignStats) null : new CampaignStats(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OverallStatsSystem.NativeFieldInfoPtr_stats), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
