// Decompiled with JetBrains decompiler
// Type: ChallengeListDisplayBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AddressableAssets;

#nullable disable
public class ChallengeListDisplayBuilder : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_tempGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_finalGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_inProgressPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_completedPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_lockedPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_cancellationTokenSource;
  private static readonly System.IntPtr NativeFieldInfoPtr_cancellationToken;
  private static readonly System.IntPtr NativeFieldInfoPtr_progress;
  private static readonly System.IntPtr NativeFieldInfoPtr__running_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_running_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_running_Private_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Build_Private_Task_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetChallengeLists_Private_Void_byref_List_1_ChallengeData_byref_List_1_ChallengeData_byref_List_1_ChallengeData_byref_List_1_ChallengeProgress_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateInProgressEntry_Private_Task_Int32_ChallengeData_ChallengeProgress_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateCompletedEntry_Private_Task_Int32_ChallengeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateLockedEntry_Private_Task_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe bool running
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder.NativeMethodInfoPtr_get_running_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder.NativeMethodInfoPtr_set_running_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87453, XrefRangeEnd = 87456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87456, XrefRangeEnd = 87462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87462, XrefRangeEnd = 87472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task Build()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder.NativeMethodInfoPtr_Build_Private_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Task) null : new Task(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 87598, RefRangeEnd = 87599, XrefRangeStart = 87472, XrefRangeEnd = 87598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetChallengeLists(
    out List<ChallengeData> inProgressChallenges,
    out List<ChallengeData> completedChallenges,
    out List<ChallengeData> lockedChallenges,
    out List<ChallengeProgress> challengeProgress)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr zero1 = System.IntPtr.Zero;
    System.IntPtr* numPtr3 = &zero1;
    *numPtr2 = (System.IntPtr) numPtr3;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero2 = System.IntPtr.Zero;
    System.IntPtr* numPtr4 = &zero2;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr4;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero3 = System.IntPtr.Zero;
    System.IntPtr* numPtr5 = &zero3;
    *(System.IntPtr*) num2 = (System.IntPtr) numPtr5;
    System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    System.IntPtr zero4 = System.IntPtr.Zero;
    System.IntPtr* numPtr6 = &zero4;
    *(System.IntPtr*) num3 = (System.IntPtr) numPtr6;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder.NativeMethodInfoPtr_GetChallengeLists_Private_Void_byref_List_1_ChallengeData_byref_List_1_ChallengeData_byref_List_1_ChallengeData_byref_List_1_ChallengeProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref List<ChallengeData> local1 = ref inProgressChallenges;
    System.IntPtr pointer1 = zero1;
    List<> list1 = pointer1 == System.IntPtr.Zero ? (List<>) null : new List<>(pointer1);
    local1 = (List<ChallengeData>) list1;
    ref List<ChallengeData> local2 = ref completedChallenges;
    System.IntPtr pointer2 = zero2;
    List<> list2 = pointer2 == System.IntPtr.Zero ? (List<>) null : new List<>(pointer2);
    local2 = (List<ChallengeData>) list2;
    ref List<ChallengeData> local3 = ref lockedChallenges;
    System.IntPtr pointer3 = zero3;
    List<> list3 = pointer3 == System.IntPtr.Zero ? (List<>) null : new List<>(pointer3);
    local3 = (List<ChallengeData>) list3;
    ref List<ChallengeProgress> local4 = ref challengeProgress;
    System.IntPtr pointer4 = zero4;
    List<> list4 = pointer4 == System.IntPtr.Zero ? (List<>) null : new List<>(pointer4);
    local4 = (List<ChallengeProgress>) list4;
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 87611, RefRangeEnd = 87612, XrefRangeStart = 87599, XrefRangeEnd = 87611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task CreateInProgressEntry(
    int challengeIndex,
    ChallengeData challengeData,
    ChallengeProgress progressAmount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &challengeIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) challengeData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) progressAmount);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder.NativeMethodInfoPtr_CreateInProgressEntry_Private_Task_Int32_ChallengeData_ChallengeProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Task) null : new Task(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 87623, RefRangeEnd = 87624, XrefRangeStart = 87612, XrefRangeEnd = 87623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task CreateCompletedEntry(int challengeIndex, ChallengeData challengeData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &challengeIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) challengeData);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder.NativeMethodInfoPtr_CreateCompletedEntry_Private_Task_Int32_ChallengeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Task) null : new Task(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 87634, RefRangeEnd = 87635, XrefRangeStart = 87624, XrefRangeEnd = 87634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task CreateLockedEntry(int challengeIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &challengeIndex
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder.NativeMethodInfoPtr_CreateLockedEntry_Private_Task_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Task) null : new Task(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87635, XrefRangeEnd = 87642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ChallengeListDisplayBuilder()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ChallengeListDisplayBuilder()
  {
    Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ChallengeListDisplayBuilder));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr);
    ChallengeListDisplayBuilder.NativeFieldInfoPtr_tempGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, nameof (tempGroup));
    ChallengeListDisplayBuilder.NativeFieldInfoPtr_finalGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, nameof (finalGroup));
    ChallengeListDisplayBuilder.NativeFieldInfoPtr_inProgressPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, nameof (inProgressPrefab));
    ChallengeListDisplayBuilder.NativeFieldInfoPtr_completedPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, nameof (completedPrefab));
    ChallengeListDisplayBuilder.NativeFieldInfoPtr_lockedPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, nameof (lockedPrefab));
    ChallengeListDisplayBuilder.NativeFieldInfoPtr_cancellationTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, nameof (cancellationTokenSource));
    ChallengeListDisplayBuilder.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, nameof (cancellationToken));
    ChallengeListDisplayBuilder.NativeFieldInfoPtr_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, nameof (progress));
    ChallengeListDisplayBuilder.NativeFieldInfoPtr__running_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, "<running>k__BackingField");
    ChallengeListDisplayBuilder.NativeMethodInfoPtr_get_running_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, 100670681);
    ChallengeListDisplayBuilder.NativeMethodInfoPtr_set_running_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, 100670682);
    ChallengeListDisplayBuilder.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, 100670683);
    ChallengeListDisplayBuilder.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, 100670684);
    ChallengeListDisplayBuilder.NativeMethodInfoPtr_Build_Private_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, 100670685);
    ChallengeListDisplayBuilder.NativeMethodInfoPtr_GetChallengeLists_Private_Void_byref_List_1_ChallengeData_byref_List_1_ChallengeData_byref_List_1_ChallengeData_byref_List_1_ChallengeProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, 100670686);
    ChallengeListDisplayBuilder.NativeMethodInfoPtr_CreateInProgressEntry_Private_Task_Int32_ChallengeData_ChallengeProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, 100670687);
    ChallengeListDisplayBuilder.NativeMethodInfoPtr_CreateCompletedEntry_Private_Task_Int32_ChallengeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, 100670688);
    ChallengeListDisplayBuilder.NativeMethodInfoPtr_CreateLockedEntry_Private_Task_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, 100670689);
    ChallengeListDisplayBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, 100670690);
  }

  public ChallengeListDisplayBuilder(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Transform tempGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder.NativeFieldInfoPtr_tempGroup));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder.NativeFieldInfoPtr_tempGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform finalGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder.NativeFieldInfoPtr_finalGroup));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder.NativeFieldInfoPtr_finalGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AssetReferenceGameObject inProgressPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder.NativeFieldInfoPtr_inProgressPrefab));
      return pointer == System.IntPtr.Zero ? (AssetReferenceGameObject) null : new AssetReferenceGameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder.NativeFieldInfoPtr_inProgressPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AssetReferenceGameObject completedPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder.NativeFieldInfoPtr_completedPrefab));
      return pointer == System.IntPtr.Zero ? (AssetReferenceGameObject) null : new AssetReferenceGameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder.NativeFieldInfoPtr_completedPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AssetReferenceGameObject lockedPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder.NativeFieldInfoPtr_lockedPrefab));
      return pointer == System.IntPtr.Zero ? (AssetReferenceGameObject) null : new AssetReferenceGameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder.NativeFieldInfoPtr_lockedPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CancellationTokenSource cancellationTokenSource
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder.NativeFieldInfoPtr_cancellationTokenSource));
      return pointer == System.IntPtr.Zero ? (CancellationTokenSource) null : new CancellationTokenSource(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder.NativeFieldInfoPtr_cancellationTokenSource), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public CancellationToken cancellationToken
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder.NativeFieldInfoPtr_cancellationToken);
      return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe Il2CppReferenceArray<Transform> progress
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder.NativeFieldInfoPtr_progress));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Transform>) null : new Il2CppReferenceArray<Transform>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder.NativeFieldInfoPtr_progress), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _running_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder.NativeFieldInfoPtr__running_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder.NativeFieldInfoPtr__running_k__BackingField)) = value;
    }
  }

  [ObfuscatedName("ChallengeListDisplayBuilder/<OnEnable>d__13")]
  public sealed class _OnEnable_d__13 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__2;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87248, XrefRangeEnd = 87278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder._OnEnable_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder._OnEnable_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static _OnEnable_d__13()
    {
      Il2CppClassPointerStore<ChallengeListDisplayBuilder._OnEnable_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, "<OnEnable>d__13");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeListDisplayBuilder._OnEnable_d__13>.NativeClassPtr);
      ChallengeListDisplayBuilder._OnEnable_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._OnEnable_d__13>.NativeClassPtr, "<>1__state");
      ChallengeListDisplayBuilder._OnEnable_d__13.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._OnEnable_d__13>.NativeClassPtr, "<>t__builder");
      ChallengeListDisplayBuilder._OnEnable_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._OnEnable_d__13>.NativeClassPtr, "<>4__this");
      ChallengeListDisplayBuilder._OnEnable_d__13.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._OnEnable_d__13>.NativeClassPtr, "<>u__1");
      ChallengeListDisplayBuilder._OnEnable_d__13.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._OnEnable_d__13>.NativeClassPtr, "<>u__2");
      ChallengeListDisplayBuilder._OnEnable_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder._OnEnable_d__13>.NativeClassPtr, 100670691);
      ChallengeListDisplayBuilder._OnEnable_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder._OnEnable_d__13>.NativeClassPtr, 100670692);
    }

    public _OnEnable_d__13(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _OnEnable_d__13()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ChallengeListDisplayBuilder._OnEnable_d__13>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChallengeListDisplayBuilder._OnEnable_d__13>.NativeClassPtr, data));
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._OnEnable_d__13.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._OnEnable_d__13.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._OnEnable_d__13.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._OnEnable_d__13.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ChallengeListDisplayBuilder __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._OnEnable_d__13.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (ChallengeListDisplayBuilder) null : new ChallengeListDisplayBuilder(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._OnEnable_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe YieldAwaitable.YieldAwaiter __u__1
    {
      get
      {
        return *(YieldAwaitable.YieldAwaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._OnEnable_d__13.NativeFieldInfoPtr___u__1));
      }
      [param: In] set
      {
        *(YieldAwaitable.YieldAwaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._OnEnable_d__13.NativeFieldInfoPtr___u__1)) = value;
      }
    }

    public TaskAwaiter __u__2
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._OnEnable_d__13.NativeFieldInfoPtr___u__2);
        return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._OnEnable_d__13.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("ChallengeListDisplayBuilder/<>c__DisplayClass14_0")]
  public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_challenge;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Build_b__0_Internal_Boolean_ChallengeProgress_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass14_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeListDisplayBuilder.__c__DisplayClass14_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87278, XrefRangeEnd = 87281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Build_b__0(ChallengeProgress a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder.__c__DisplayClass14_0.NativeMethodInfoPtr__Build_b__0_Internal_Boolean_ChallengeProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass14_0()
    {
      Il2CppClassPointerStore<ChallengeListDisplayBuilder.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, "<>c__DisplayClass14_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeListDisplayBuilder.__c__DisplayClass14_0>.NativeClassPtr);
      ChallengeListDisplayBuilder.__c__DisplayClass14_0.NativeFieldInfoPtr_challenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder.__c__DisplayClass14_0>.NativeClassPtr, nameof (challenge));
      ChallengeListDisplayBuilder.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder.__c__DisplayClass14_0>.NativeClassPtr, 100670693);
      ChallengeListDisplayBuilder.__c__DisplayClass14_0.NativeMethodInfoPtr__Build_b__0_Internal_Boolean_ChallengeProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder.__c__DisplayClass14_0>.NativeClassPtr, 100670694);
    }

    public __c__DisplayClass14_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ChallengeData challenge
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder.__c__DisplayClass14_0.NativeFieldInfoPtr_challenge));
        return pointer == System.IntPtr.Zero ? (ChallengeData) null : new ChallengeData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder.__c__DisplayClass14_0.NativeFieldInfoPtr_challenge), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("ChallengeListDisplayBuilder/<Build>d__14")]
  public sealed class _Build_d__14 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__completedChallenges_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__lockedChallenges_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__challengeProgress_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr__challengeIndex_5__5;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap5;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87281, XrefRangeEnd = 87386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder._Build_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder._Build_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static _Build_d__14()
    {
      Il2CppClassPointerStore<ChallengeListDisplayBuilder._Build_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, "<Build>d__14");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeListDisplayBuilder._Build_d__14>.NativeClassPtr);
      ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._Build_d__14>.NativeClassPtr, "<>1__state");
      ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._Build_d__14>.NativeClassPtr, "<>t__builder");
      ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._Build_d__14>.NativeClassPtr, "<>4__this");
      ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr__completedChallenges_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._Build_d__14>.NativeClassPtr, "<completedChallenges>5__2");
      ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr__lockedChallenges_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._Build_d__14>.NativeClassPtr, "<lockedChallenges>5__3");
      ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr__challengeProgress_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._Build_d__14>.NativeClassPtr, "<challengeProgress>5__4");
      ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr__challengeIndex_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._Build_d__14>.NativeClassPtr, "<challengeIndex>5__5");
      ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr___7__wrap5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._Build_d__14>.NativeClassPtr, "<>7__wrap5");
      ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._Build_d__14>.NativeClassPtr, "<>u__1");
      ChallengeListDisplayBuilder._Build_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder._Build_d__14>.NativeClassPtr, 100670695);
      ChallengeListDisplayBuilder._Build_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder._Build_d__14>.NativeClassPtr, 100670696);
    }

    public _Build_d__14(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _Build_d__14()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ChallengeListDisplayBuilder._Build_d__14>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChallengeListDisplayBuilder._Build_d__14>.NativeClassPtr, data));
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ChallengeListDisplayBuilder __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (ChallengeListDisplayBuilder) null : new ChallengeListDisplayBuilder(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ChallengeData> _completedChallenges_5__2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr__completedChallenges_5__2));
        return pointer == System.IntPtr.Zero ? (List<ChallengeData>) null : new List<ChallengeData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr__completedChallenges_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ChallengeData> _lockedChallenges_5__3
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr__lockedChallenges_5__3));
        return pointer == System.IntPtr.Zero ? (List<ChallengeData>) null : new List<ChallengeData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr__lockedChallenges_5__3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ChallengeProgress> _challengeProgress_5__4
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr__challengeProgress_5__4));
        return pointer == System.IntPtr.Zero ? (List<ChallengeProgress>) null : new List<ChallengeProgress>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr__challengeProgress_5__4), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _challengeIndex_5__5
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr__challengeIndex_5__5));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr__challengeIndex_5__5)) = value;
      }
    }

    public List<ChallengeData>.Enumerator __7__wrap5
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr___7__wrap5);
        return new List<ChallengeData>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<ChallengeData>.Enumerator>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr___7__wrap5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<ChallengeData>.Enumerator>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public TaskAwaiter __u__1
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._Build_d__14.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("ChallengeListDisplayBuilder/<>c__DisplayClass15_0")]
  public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_challenge;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetChallengeLists_b__1_Internal_Boolean_ChallengeData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass15_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeListDisplayBuilder.__c__DisplayClass15_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetChallengeLists_b__1(ChallengeData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder.__c__DisplayClass15_0.NativeMethodInfoPtr__GetChallengeLists_b__1_Internal_Boolean_ChallengeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass15_0()
    {
      Il2CppClassPointerStore<ChallengeListDisplayBuilder.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, "<>c__DisplayClass15_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeListDisplayBuilder.__c__DisplayClass15_0>.NativeClassPtr);
      ChallengeListDisplayBuilder.__c__DisplayClass15_0.NativeFieldInfoPtr_challenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder.__c__DisplayClass15_0>.NativeClassPtr, nameof (challenge));
      ChallengeListDisplayBuilder.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder.__c__DisplayClass15_0>.NativeClassPtr, 100670697);
      ChallengeListDisplayBuilder.__c__DisplayClass15_0.NativeMethodInfoPtr__GetChallengeLists_b__1_Internal_Boolean_ChallengeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder.__c__DisplayClass15_0>.NativeClassPtr, 100670698);
    }

    public __c__DisplayClass15_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ChallengeData challenge
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder.__c__DisplayClass15_0.NativeFieldInfoPtr_challenge));
        return pointer == System.IntPtr.Zero ? (ChallengeData) null : new ChallengeData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder.__c__DisplayClass15_0.NativeFieldInfoPtr_challenge), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("ChallengeListDisplayBuilder/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__15_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetChallengeLists_b__15_0_Internal_String_ChallengeData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeListDisplayBuilder.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _GetChallengeLists_b__15_0(ChallengeData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder.__c.NativeMethodInfoPtr__GetChallengeLists_b__15_0_Internal_String_ChallengeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static __c()
    {
      Il2CppClassPointerStore<ChallengeListDisplayBuilder.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeListDisplayBuilder.__c>.NativeClassPtr);
      ChallengeListDisplayBuilder.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder.__c>.NativeClassPtr, "<>9");
      ChallengeListDisplayBuilder.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder.__c>.NativeClassPtr, "<>9__15_0");
      ChallengeListDisplayBuilder.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder.__c>.NativeClassPtr, 100670700);
      ChallengeListDisplayBuilder.__c.NativeMethodInfoPtr__GetChallengeLists_b__15_0_Internal_String_ChallengeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder.__c>.NativeClassPtr, 100670701);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe ChallengeListDisplayBuilder.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ChallengeListDisplayBuilder.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ChallengeListDisplayBuilder.__c) null : new ChallengeListDisplayBuilder.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ChallengeListDisplayBuilder.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<ChallengeData, string> __9__15_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ChallengeListDisplayBuilder.__c.NativeFieldInfoPtr___9__15_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ChallengeData, string>) null : new Il2CppSystem.Func<ChallengeData, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ChallengeListDisplayBuilder.__c.NativeFieldInfoPtr___9__15_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("ChallengeListDisplayBuilder/<CreateInProgressEntry>d__16")]
  public sealed class _CreateInProgressEntry_d__16 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_challengeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_challengeData;
    private static readonly System.IntPtr NativeFieldInfoPtr_progressAmount;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87386, XrefRangeEnd = 87411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static _CreateInProgressEntry_d__16()
    {
      Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateInProgressEntry_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, "<CreateInProgressEntry>d__16");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateInProgressEntry_d__16>.NativeClassPtr);
      ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateInProgressEntry_d__16>.NativeClassPtr, "<>1__state");
      ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateInProgressEntry_d__16>.NativeClassPtr, "<>t__builder");
      ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateInProgressEntry_d__16>.NativeClassPtr, "<>4__this");
      ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeFieldInfoPtr_challengeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateInProgressEntry_d__16>.NativeClassPtr, nameof (challengeIndex));
      ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeFieldInfoPtr_challengeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateInProgressEntry_d__16>.NativeClassPtr, nameof (challengeData));
      ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeFieldInfoPtr_progressAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateInProgressEntry_d__16>.NativeClassPtr, nameof (progressAmount));
      ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateInProgressEntry_d__16>.NativeClassPtr, "<>u__1");
      ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateInProgressEntry_d__16>.NativeClassPtr, 100670702);
      ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateInProgressEntry_d__16>.NativeClassPtr, 100670703);
    }

    public _CreateInProgressEntry_d__16(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _CreateInProgressEntry_d__16()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateInProgressEntry_d__16>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateInProgressEntry_d__16>.NativeClassPtr, data));
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ChallengeListDisplayBuilder __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (ChallengeListDisplayBuilder) null : new ChallengeListDisplayBuilder(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int challengeIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeFieldInfoPtr_challengeIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeFieldInfoPtr_challengeIndex)) = value;
      }
    }

    public unsafe ChallengeData challengeData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeFieldInfoPtr_challengeData));
        return pointer == System.IntPtr.Zero ? (ChallengeData) null : new ChallengeData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeFieldInfoPtr_challengeData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ChallengeProgress progressAmount
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeFieldInfoPtr_progressAmount));
        return pointer == System.IntPtr.Zero ? (ChallengeProgress) null : new ChallengeProgress(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeFieldInfoPtr_progressAmount), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public TaskAwaiter<GameObject> __u__1
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter<GameObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<GameObject>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateInProgressEntry_d__16.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<GameObject>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("ChallengeListDisplayBuilder/<CreateCompletedEntry>d__17")]
  public sealed class _CreateCompletedEntry_d__17 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_challengeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_challengeData;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87411, XrefRangeEnd = 87435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder._CreateCompletedEntry_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder._CreateCompletedEntry_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static _CreateCompletedEntry_d__17()
    {
      Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateCompletedEntry_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, "<CreateCompletedEntry>d__17");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateCompletedEntry_d__17>.NativeClassPtr);
      ChallengeListDisplayBuilder._CreateCompletedEntry_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateCompletedEntry_d__17>.NativeClassPtr, "<>1__state");
      ChallengeListDisplayBuilder._CreateCompletedEntry_d__17.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateCompletedEntry_d__17>.NativeClassPtr, "<>t__builder");
      ChallengeListDisplayBuilder._CreateCompletedEntry_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateCompletedEntry_d__17>.NativeClassPtr, "<>4__this");
      ChallengeListDisplayBuilder._CreateCompletedEntry_d__17.NativeFieldInfoPtr_challengeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateCompletedEntry_d__17>.NativeClassPtr, nameof (challengeIndex));
      ChallengeListDisplayBuilder._CreateCompletedEntry_d__17.NativeFieldInfoPtr_challengeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateCompletedEntry_d__17>.NativeClassPtr, nameof (challengeData));
      ChallengeListDisplayBuilder._CreateCompletedEntry_d__17.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateCompletedEntry_d__17>.NativeClassPtr, "<>u__1");
      ChallengeListDisplayBuilder._CreateCompletedEntry_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateCompletedEntry_d__17>.NativeClassPtr, 100670704);
      ChallengeListDisplayBuilder._CreateCompletedEntry_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateCompletedEntry_d__17>.NativeClassPtr, 100670705);
    }

    public _CreateCompletedEntry_d__17(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _CreateCompletedEntry_d__17()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateCompletedEntry_d__17>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateCompletedEntry_d__17>.NativeClassPtr, data));
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateCompletedEntry_d__17.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateCompletedEntry_d__17.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateCompletedEntry_d__17.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateCompletedEntry_d__17.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ChallengeListDisplayBuilder __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateCompletedEntry_d__17.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (ChallengeListDisplayBuilder) null : new ChallengeListDisplayBuilder(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateCompletedEntry_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int challengeIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateCompletedEntry_d__17.NativeFieldInfoPtr_challengeIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateCompletedEntry_d__17.NativeFieldInfoPtr_challengeIndex)) = value;
      }
    }

    public unsafe ChallengeData challengeData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateCompletedEntry_d__17.NativeFieldInfoPtr_challengeData));
        return pointer == System.IntPtr.Zero ? (ChallengeData) null : new ChallengeData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateCompletedEntry_d__17.NativeFieldInfoPtr_challengeData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public TaskAwaiter<GameObject> __u__1
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateCompletedEntry_d__17.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter<GameObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<GameObject>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateCompletedEntry_d__17.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<GameObject>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("ChallengeListDisplayBuilder/<CreateLockedEntry>d__18")]
  public sealed class _CreateLockedEntry_d__18 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_challengeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87435, XrefRangeEnd = 87453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder._CreateLockedEntry_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(ChallengeListDisplayBuilder._CreateLockedEntry_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static _CreateLockedEntry_d__18()
    {
      Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateLockedEntry_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChallengeListDisplayBuilder>.NativeClassPtr, "<CreateLockedEntry>d__18");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateLockedEntry_d__18>.NativeClassPtr);
      ChallengeListDisplayBuilder._CreateLockedEntry_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateLockedEntry_d__18>.NativeClassPtr, "<>1__state");
      ChallengeListDisplayBuilder._CreateLockedEntry_d__18.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateLockedEntry_d__18>.NativeClassPtr, "<>t__builder");
      ChallengeListDisplayBuilder._CreateLockedEntry_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateLockedEntry_d__18>.NativeClassPtr, "<>4__this");
      ChallengeListDisplayBuilder._CreateLockedEntry_d__18.NativeFieldInfoPtr_challengeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateLockedEntry_d__18>.NativeClassPtr, nameof (challengeIndex));
      ChallengeListDisplayBuilder._CreateLockedEntry_d__18.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateLockedEntry_d__18>.NativeClassPtr, "<>u__1");
      ChallengeListDisplayBuilder._CreateLockedEntry_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateLockedEntry_d__18>.NativeClassPtr, 100670706);
      ChallengeListDisplayBuilder._CreateLockedEntry_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateLockedEntry_d__18>.NativeClassPtr, 100670707);
    }

    public _CreateLockedEntry_d__18(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _CreateLockedEntry_d__18()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateLockedEntry_d__18>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChallengeListDisplayBuilder._CreateLockedEntry_d__18>.NativeClassPtr, data));
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateLockedEntry_d__18.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateLockedEntry_d__18.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateLockedEntry_d__18.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateLockedEntry_d__18.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ChallengeListDisplayBuilder __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateLockedEntry_d__18.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (ChallengeListDisplayBuilder) null : new ChallengeListDisplayBuilder(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateLockedEntry_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int challengeIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateLockedEntry_d__18.NativeFieldInfoPtr_challengeIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateLockedEntry_d__18.NativeFieldInfoPtr_challengeIndex)) = value;
      }
    }

    public TaskAwaiter<GameObject> __u__1
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateLockedEntry_d__18.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter<GameObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<GameObject>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListDisplayBuilder._CreateLockedEntry_d__18.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<GameObject>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
