// Decompiled with JetBrains decompiler
// Type: InjuredCompanionEventSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;

#nullable disable
public class InjuredCompanionEventSystem : GameSystem
{
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetCampaignInsertPosition_Private_Static_Int32_RunHistory_0;
  private static readonly IntPtr NativeMethodInfoPtr_CampaignLoadPreset_Private_Static_Void_byref_Il2CppStringArray_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetMostRecentRun_Public_Static_RunHistory_0;
  private static readonly IntPtr NativeMethodInfoPtr_HasEligibleCompanion_Private_Static_Boolean_RunHistory_0;
  private static readonly IntPtr NativeMethodInfoPtr_IsEligible_Private_Static_Boolean_CardSaveData_Il2CppStringArray_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetEligibleCompanions_Public_Static_List_1_CardSaveData_RunHistory_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61128, XrefRangeEnd = 61136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InjuredCompanionEventSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61136, XrefRangeEnd = 61144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InjuredCompanionEventSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61144, XrefRangeEnd = 61161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetCampaignInsertPosition(RunHistory mostRecentRun)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mostRecentRun)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(InjuredCompanionEventSystem.NativeMethodInfoPtr_GetCampaignInsertPosition_Private_Static_Int32_RunHistory_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61161, XrefRangeEnd = 61187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CampaignLoadPreset(ref Il2CppStringArray lines)
  {
    IntPtr* numPtr1 = stackalloc IntPtr[1];
    IntPtr* numPtr2 = numPtr1;
    IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp((string) lines);
    IntPtr* numPtr3 = &il2Cpp;
    *numPtr2 = (IntPtr) numPtr3;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InjuredCompanionEventSystem.NativeMethodInfoPtr_CampaignLoadPreset_Private_Static_Void_byref_Il2CppStringArray_0, IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref Il2CppStringArray local = ref lines;
    IntPtr pointer = il2Cpp;
    Il2CppStringArray il2CppStringArray = pointer == IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    local = il2CppStringArray;
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 61209, RefRangeEnd = 61210, XrefRangeStart = 61187, XrefRangeEnd = 61209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RunHistory GetMostRecentRun()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(InjuredCompanionEventSystem.NativeMethodInfoPtr_GetMostRecentRun_Public_Static_RunHistory_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (RunHistory) null : new RunHistory(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61210, XrefRangeEnd = 61218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool HasEligibleCompanion(RunHistory run)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) run)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(InjuredCompanionEventSystem.NativeMethodInfoPtr_HasEligibleCompanion_Private_Static_Boolean_RunHistory_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 61222, RefRangeEnd = 61224, XrefRangeStart = 61218, XrefRangeEnd = 61222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsEligible(CardSaveData card, Il2CppStringArray illegal)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) illegal);
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(InjuredCompanionEventSystem.NativeMethodInfoPtr_IsEligible_Private_Static_Boolean_CardSaveData_Il2CppStringArray_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 61257, RefRangeEnd = 61258, XrefRangeStart = 61224, XrefRangeEnd = 61257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe List<CardSaveData> GetEligibleCompanions(RunHistory run)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) run)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(InjuredCompanionEventSystem.NativeMethodInfoPtr_GetEligibleCompanions_Public_Static_List_1_CardSaveData_RunHistory_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (List<CardSaveData>) null : new List<CardSaveData>(pointer);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InjuredCompanionEventSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InjuredCompanionEventSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InjuredCompanionEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static InjuredCompanionEventSystem()
  {
    Il2CppClassPointerStore<InjuredCompanionEventSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (InjuredCompanionEventSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InjuredCompanionEventSystem>.NativeClassPtr);
    InjuredCompanionEventSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuredCompanionEventSystem>.NativeClassPtr, 100668285);
    InjuredCompanionEventSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuredCompanionEventSystem>.NativeClassPtr, 100668286);
    InjuredCompanionEventSystem.NativeMethodInfoPtr_GetCampaignInsertPosition_Private_Static_Int32_RunHistory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuredCompanionEventSystem>.NativeClassPtr, 100668287);
    InjuredCompanionEventSystem.NativeMethodInfoPtr_CampaignLoadPreset_Private_Static_Void_byref_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuredCompanionEventSystem>.NativeClassPtr, 100668288);
    InjuredCompanionEventSystem.NativeMethodInfoPtr_GetMostRecentRun_Public_Static_RunHistory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuredCompanionEventSystem>.NativeClassPtr, 100668289);
    InjuredCompanionEventSystem.NativeMethodInfoPtr_HasEligibleCompanion_Private_Static_Boolean_RunHistory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuredCompanionEventSystem>.NativeClassPtr, 100668290);
    InjuredCompanionEventSystem.NativeMethodInfoPtr_IsEligible_Private_Static_Boolean_CardSaveData_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuredCompanionEventSystem>.NativeClassPtr, 100668291);
    InjuredCompanionEventSystem.NativeMethodInfoPtr_GetEligibleCompanions_Public_Static_List_1_CardSaveData_RunHistory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuredCompanionEventSystem>.NativeClassPtr, 100668292);
    InjuredCompanionEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuredCompanionEventSystem>.NativeClassPtr, 100668293);
  }

  public InjuredCompanionEventSystem(IntPtr pointer)
    : base(pointer)
  {
  }
}
