// Decompiled with JetBrains decompiler
// Type: BattleLogDisplayBuilder
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
public class BattleLogDisplayBuilder : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_battleLogDisplay;
  private static readonly System.IntPtr NativeFieldInfoPtr_tempGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_finalGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_groupPrefabRef;
  private static readonly System.IntPtr NativeFieldInfoPtr_entryTypes;
  private static readonly System.IntPtr NativeFieldInfoPtr_entryLookup;
  private static readonly System.IntPtr NativeFieldInfoPtr_progress;
  private static readonly System.IntPtr NativeFieldInfoPtr_battleLogSystem;
  private static readonly System.IntPtr NativeFieldInfoPtr_cancellationTokenSource;
  private static readonly System.IntPtr NativeFieldInfoPtr_cancellationToken;
  private static readonly System.IntPtr NativeFieldInfoPtr__entries_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__running_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_entries_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_entries_Private_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_running_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_running_Private_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Build_Private_Task_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Populate_Private_Task_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateGroup_Private_Task_Int32_List_1_BattleLog_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateGroup_Private_Task_1_Transform_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateEntry_Private_Task_1_Transform_BattleLog_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe int entries
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder.NativeMethodInfoPtr_get_entries_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(11), CachedScanResults(RefRangeStart = 86525, RefRangeEnd = 86536, XrefRangeStart = 86525, XrefRangeEnd = 86525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder.NativeMethodInfoPtr_set_entries_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe bool running
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder.NativeMethodInfoPtr_get_running_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder.NativeMethodInfoPtr_set_running_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86536, XrefRangeEnd = 86547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86547, XrefRangeEnd = 86553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86553, XrefRangeEnd = 86563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task Build()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder.NativeMethodInfoPtr_Build_Private_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Task) null : new Task(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86563, XrefRangeEnd = 86573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task Populate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder.NativeMethodInfoPtr_Populate_Private_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Task) null : new Task(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 86584, RefRangeEnd = 86585, XrefRangeStart = 86573, XrefRangeEnd = 86584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task CreateGroup(int groupIndex, List<BattleLog> logs)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &groupIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) logs);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder.NativeMethodInfoPtr_CreateGroup_Private_Task_Int32_List_1_BattleLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Task) null : new Task(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86585, XrefRangeEnd = 86600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task<Transform> CreateGroup(Transform parent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder.NativeMethodInfoPtr_CreateGroup_Private_Task_1_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Task<Transform>) null : new Task<Transform>(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 86616, RefRangeEnd = 86617, XrefRangeStart = 86600, XrefRangeEnd = 86616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task<Transform> CreateEntry(BattleLog log, Transform group)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) log));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) group);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder.NativeMethodInfoPtr_CreateEntry_Private_Task_1_Transform_BattleLog_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Task<Transform>) null : new Task<Transform>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86617, XrefRangeEnd = 86619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Cancel()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86619, XrefRangeEnd = 86640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BattleLogDisplayBuilder()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BattleLogDisplayBuilder()
  {
    Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BattleLogDisplayBuilder));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr);
    BattleLogDisplayBuilder.NativeFieldInfoPtr_battleLogDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, nameof (battleLogDisplay));
    BattleLogDisplayBuilder.NativeFieldInfoPtr_tempGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, nameof (tempGroup));
    BattleLogDisplayBuilder.NativeFieldInfoPtr_finalGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, nameof (finalGroup));
    BattleLogDisplayBuilder.NativeFieldInfoPtr_groupPrefabRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, nameof (groupPrefabRef));
    BattleLogDisplayBuilder.NativeFieldInfoPtr_entryTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, nameof (entryTypes));
    BattleLogDisplayBuilder.NativeFieldInfoPtr_entryLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, nameof (entryLookup));
    BattleLogDisplayBuilder.NativeFieldInfoPtr_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, nameof (progress));
    BattleLogDisplayBuilder.NativeFieldInfoPtr_battleLogSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, nameof (battleLogSystem));
    BattleLogDisplayBuilder.NativeFieldInfoPtr_cancellationTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, nameof (cancellationTokenSource));
    BattleLogDisplayBuilder.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, nameof (cancellationToken));
    BattleLogDisplayBuilder.NativeFieldInfoPtr__entries_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, "<entries>k__BackingField");
    BattleLogDisplayBuilder.NativeFieldInfoPtr__running_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, "<running>k__BackingField");
    BattleLogDisplayBuilder.NativeMethodInfoPtr_get_entries_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, 100670570);
    BattleLogDisplayBuilder.NativeMethodInfoPtr_set_entries_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, 100670571);
    BattleLogDisplayBuilder.NativeMethodInfoPtr_get_running_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, 100670572);
    BattleLogDisplayBuilder.NativeMethodInfoPtr_set_running_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, 100670573);
    BattleLogDisplayBuilder.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, 100670574);
    BattleLogDisplayBuilder.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, 100670575);
    BattleLogDisplayBuilder.NativeMethodInfoPtr_Build_Private_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, 100670576);
    BattleLogDisplayBuilder.NativeMethodInfoPtr_Populate_Private_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, 100670577);
    BattleLogDisplayBuilder.NativeMethodInfoPtr_CreateGroup_Private_Task_Int32_List_1_BattleLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, 100670578);
    BattleLogDisplayBuilder.NativeMethodInfoPtr_CreateGroup_Private_Task_1_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, 100670579);
    BattleLogDisplayBuilder.NativeMethodInfoPtr_CreateEntry_Private_Task_1_Transform_BattleLog_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, 100670580);
    BattleLogDisplayBuilder.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, 100670581);
    BattleLogDisplayBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, 100670582);
  }

  public BattleLogDisplayBuilder(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe BattleLogDisplay battleLogDisplay
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr_battleLogDisplay));
      return pointer == System.IntPtr.Zero ? (BattleLogDisplay) null : new BattleLogDisplay(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr_battleLogDisplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform tempGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr_tempGroup));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr_tempGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform finalGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr_finalGroup));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr_finalGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AssetReferenceGameObject groupPrefabRef
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr_groupPrefabRef));
      return pointer == System.IntPtr.Zero ? (AssetReferenceGameObject) null : new AssetReferenceGameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr_groupPrefabRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<BattleLogDisplayBuilder.EntryLookup> entryTypes
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr_entryTypes));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<BattleLogDisplayBuilder.EntryLookup>) null : new Il2CppReferenceArray<BattleLogDisplayBuilder.EntryLookup>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr_entryTypes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<BattleLogType, AssetReferenceGameObject> entryLookup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr_entryLookup));
      return pointer == System.IntPtr.Zero ? (Dictionary<BattleLogType, AssetReferenceGameObject>) null : new Dictionary<BattleLogType, AssetReferenceGameObject>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr_entryLookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Transform> progress
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr_progress));
      return pointer == System.IntPtr.Zero ? (List<Transform>) null : new List<Transform>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr_progress), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BattleLogSystem battleLogSystem
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr_battleLogSystem));
      return pointer == System.IntPtr.Zero ? (BattleLogSystem) null : new BattleLogSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr_battleLogSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CancellationTokenSource cancellationTokenSource
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr_cancellationTokenSource));
      return pointer == System.IntPtr.Zero ? (CancellationTokenSource) null : new CancellationTokenSource(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr_cancellationTokenSource), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public CancellationToken cancellationToken
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr_cancellationToken);
      return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe int _entries_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr__entries_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr__entries_k__BackingField)) = value;
    }
  }

  public unsafe bool _running_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr__running_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.NativeFieldInfoPtr__running_k__BackingField)) = value;
    }
  }

  [Serializable]
  public sealed class EntryLookup : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_type;
    private static readonly System.IntPtr NativeFieldInfoPtr_entryPrefab;

    static EntryLookup()
    {
      Il2CppClassPointerStore<BattleLogDisplayBuilder.EntryLookup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, nameof (EntryLookup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleLogDisplayBuilder.EntryLookup>.NativeClassPtr);
      BattleLogDisplayBuilder.EntryLookup.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder.EntryLookup>.NativeClassPtr, nameof (type));
      BattleLogDisplayBuilder.EntryLookup.NativeFieldInfoPtr_entryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder.EntryLookup>.NativeClassPtr, nameof (entryPrefab));
    }

    public EntryLookup(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public EntryLookup()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BattleLogDisplayBuilder.EntryLookup>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BattleLogDisplayBuilder.EntryLookup>.NativeClassPtr, data));
    }

    public unsafe BattleLogType type
    {
      get
      {
        return *(BattleLogType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.EntryLookup.NativeFieldInfoPtr_type));
      }
      [param: In] set
      {
        *(BattleLogType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.EntryLookup.NativeFieldInfoPtr_type)) = value;
      }
    }

    public unsafe AssetReferenceGameObject entryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.EntryLookup.NativeFieldInfoPtr_entryPrefab));
        return pointer == System.IntPtr.Zero ? (AssetReferenceGameObject) null : new AssetReferenceGameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder.EntryLookup.NativeFieldInfoPtr_entryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("BattleLogDisplayBuilder/<OnEnable>d__19")]
  public sealed class _OnEnable_d__19 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__2;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86207, XrefRangeEnd = 86251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder._OnEnable_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder._OnEnable_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static _OnEnable_d__19()
    {
      Il2CppClassPointerStore<BattleLogDisplayBuilder._OnEnable_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, "<OnEnable>d__19");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleLogDisplayBuilder._OnEnable_d__19>.NativeClassPtr);
      BattleLogDisplayBuilder._OnEnable_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._OnEnable_d__19>.NativeClassPtr, "<>1__state");
      BattleLogDisplayBuilder._OnEnable_d__19.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._OnEnable_d__19>.NativeClassPtr, "<>t__builder");
      BattleLogDisplayBuilder._OnEnable_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._OnEnable_d__19>.NativeClassPtr, "<>4__this");
      BattleLogDisplayBuilder._OnEnable_d__19.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._OnEnable_d__19>.NativeClassPtr, "<>u__1");
      BattleLogDisplayBuilder._OnEnable_d__19.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._OnEnable_d__19>.NativeClassPtr, "<>u__2");
      BattleLogDisplayBuilder._OnEnable_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder._OnEnable_d__19>.NativeClassPtr, 100670583);
      BattleLogDisplayBuilder._OnEnable_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder._OnEnable_d__19>.NativeClassPtr, 100670584);
    }

    public _OnEnable_d__19(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _OnEnable_d__19()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BattleLogDisplayBuilder._OnEnable_d__19>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BattleLogDisplayBuilder._OnEnable_d__19>.NativeClassPtr, data));
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._OnEnable_d__19.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._OnEnable_d__19.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._OnEnable_d__19.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._OnEnable_d__19.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe BattleLogDisplayBuilder __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._OnEnable_d__19.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (BattleLogDisplayBuilder) null : new BattleLogDisplayBuilder(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._OnEnable_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe YieldAwaitable.YieldAwaiter __u__1
    {
      get
      {
        return *(YieldAwaitable.YieldAwaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._OnEnable_d__19.NativeFieldInfoPtr___u__1));
      }
      [param: In] set
      {
        *(YieldAwaitable.YieldAwaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._OnEnable_d__19.NativeFieldInfoPtr___u__1)) = value;
      }
    }

    public TaskAwaiter __u__2
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._OnEnable_d__19.NativeFieldInfoPtr___u__2);
        return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._OnEnable_d__19.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("BattleLogDisplayBuilder/<Build>d__20")]
  public sealed class _Build_d__20 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86251, XrefRangeEnd = 86287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder._Build_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder._Build_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static _Build_d__20()
    {
      Il2CppClassPointerStore<BattleLogDisplayBuilder._Build_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, "<Build>d__20");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleLogDisplayBuilder._Build_d__20>.NativeClassPtr);
      BattleLogDisplayBuilder._Build_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._Build_d__20>.NativeClassPtr, "<>1__state");
      BattleLogDisplayBuilder._Build_d__20.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._Build_d__20>.NativeClassPtr, "<>t__builder");
      BattleLogDisplayBuilder._Build_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._Build_d__20>.NativeClassPtr, "<>4__this");
      BattleLogDisplayBuilder._Build_d__20.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._Build_d__20>.NativeClassPtr, "<>u__1");
      BattleLogDisplayBuilder._Build_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder._Build_d__20>.NativeClassPtr, 100670585);
      BattleLogDisplayBuilder._Build_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder._Build_d__20>.NativeClassPtr, 100670586);
    }

    public _Build_d__20(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _Build_d__20()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BattleLogDisplayBuilder._Build_d__20>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BattleLogDisplayBuilder._Build_d__20>.NativeClassPtr, data));
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._Build_d__20.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._Build_d__20.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._Build_d__20.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._Build_d__20.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe BattleLogDisplayBuilder __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._Build_d__20.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (BattleLogDisplayBuilder) null : new BattleLogDisplayBuilder(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._Build_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public TaskAwaiter __u__1
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._Build_d__20.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._Build_d__20.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("BattleLogDisplayBuilder/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__21_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Populate_b__21_0_Internal_Boolean_BattleLog_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleLogDisplayBuilder.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Populate_b__21_0(BattleLog a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a))
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder.__c.NativeMethodInfoPtr__Populate_b__21_0_Internal_Boolean_BattleLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<BattleLogDisplayBuilder.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleLogDisplayBuilder.__c>.NativeClassPtr);
      BattleLogDisplayBuilder.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder.__c>.NativeClassPtr, "<>9");
      BattleLogDisplayBuilder.__c.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder.__c>.NativeClassPtr, "<>9__21_0");
      BattleLogDisplayBuilder.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder.__c>.NativeClassPtr, 100670588);
      BattleLogDisplayBuilder.__c.NativeMethodInfoPtr__Populate_b__21_0_Internal_Boolean_BattleLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder.__c>.NativeClassPtr, 100670589);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe BattleLogDisplayBuilder.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BattleLogDisplayBuilder.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (BattleLogDisplayBuilder.__c) null : new BattleLogDisplayBuilder.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BattleLogDisplayBuilder.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Predicate<BattleLog> __9__21_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BattleLogDisplayBuilder.__c.NativeFieldInfoPtr___9__21_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Predicate<BattleLog>) null : new Il2CppSystem.Predicate<BattleLog>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BattleLogDisplayBuilder.__c.NativeFieldInfoPtr___9__21_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("BattleLogDisplayBuilder/<Populate>d__21")]
  public sealed class _Populate_d__21 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86287, XrefRangeEnd = 86347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder._Populate_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder._Populate_d__21.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static _Populate_d__21()
    {
      Il2CppClassPointerStore<BattleLogDisplayBuilder._Populate_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, "<Populate>d__21");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleLogDisplayBuilder._Populate_d__21>.NativeClassPtr);
      BattleLogDisplayBuilder._Populate_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._Populate_d__21>.NativeClassPtr, "<>1__state");
      BattleLogDisplayBuilder._Populate_d__21.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._Populate_d__21>.NativeClassPtr, "<>t__builder");
      BattleLogDisplayBuilder._Populate_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._Populate_d__21>.NativeClassPtr, "<>4__this");
      BattleLogDisplayBuilder._Populate_d__21.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._Populate_d__21>.NativeClassPtr, "<>u__1");
      BattleLogDisplayBuilder._Populate_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder._Populate_d__21>.NativeClassPtr, 100670590);
      BattleLogDisplayBuilder._Populate_d__21.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder._Populate_d__21>.NativeClassPtr, 100670591);
    }

    public _Populate_d__21(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _Populate_d__21()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BattleLogDisplayBuilder._Populate_d__21>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BattleLogDisplayBuilder._Populate_d__21>.NativeClassPtr, data));
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._Populate_d__21.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._Populate_d__21.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._Populate_d__21.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._Populate_d__21.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe BattleLogDisplayBuilder __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._Populate_d__21.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (BattleLogDisplayBuilder) null : new BattleLogDisplayBuilder(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._Populate_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public TaskAwaiter __u__1
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._Populate_d__21.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._Populate_d__21.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("BattleLogDisplayBuilder/<CreateGroup>d__22")]
  public sealed class _CreateGroup_d__22 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_groupIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_logs;
    private static readonly System.IntPtr NativeFieldInfoPtr__tasks_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__2;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86347, XrefRangeEnd = 86449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder._CreateGroup_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder._CreateGroup_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static _CreateGroup_d__22()
    {
      Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, "<CreateGroup>d__22");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__22>.NativeClassPtr);
      BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__22>.NativeClassPtr, "<>1__state");
      BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__22>.NativeClassPtr, "<>t__builder");
      BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__22>.NativeClassPtr, "<>4__this");
      BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr_groupIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__22>.NativeClassPtr, nameof (groupIndex));
      BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr_logs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__22>.NativeClassPtr, nameof (logs));
      BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr__tasks_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__22>.NativeClassPtr, "<tasks>5__2");
      BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__22>.NativeClassPtr, "<>u__1");
      BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__22>.NativeClassPtr, "<>u__2");
      BattleLogDisplayBuilder._CreateGroup_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__22>.NativeClassPtr, 100670592);
      BattleLogDisplayBuilder._CreateGroup_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__22>.NativeClassPtr, 100670593);
    }

    public _CreateGroup_d__22(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _CreateGroup_d__22()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__22>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__22>.NativeClassPtr, data));
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe BattleLogDisplayBuilder __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (BattleLogDisplayBuilder) null : new BattleLogDisplayBuilder(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int groupIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr_groupIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr_groupIndex)) = value;
      }
    }

    public unsafe List<BattleLog> logs
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr_logs));
        return pointer == System.IntPtr.Zero ? (List<BattleLog>) null : new List<BattleLog>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr_logs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<Task<Transform>> _tasks_5__2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr__tasks_5__2));
        return pointer == System.IntPtr.Zero ? (List<Task<Transform>>) null : new List<Task<Transform>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr__tasks_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public TaskAwaiter<Transform> __u__1
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter<Transform>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Transform>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Transform>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public TaskAwaiter<Il2CppReferenceArray<Transform>> __u__2
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr___u__2);
        return new TaskAwaiter<Il2CppReferenceArray<Transform>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Il2CppReferenceArray<Transform>>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__22.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Il2CppReferenceArray<Transform>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("BattleLogDisplayBuilder/<CreateGroup>d__23")]
  public sealed class _CreateGroup_d__23 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_parent;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86449, XrefRangeEnd = 86467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder._CreateGroup_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86467, XrefRangeEnd = 86470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder._CreateGroup_d__23.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static _CreateGroup_d__23()
    {
      Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, "<CreateGroup>d__23");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__23>.NativeClassPtr);
      BattleLogDisplayBuilder._CreateGroup_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__23>.NativeClassPtr, "<>1__state");
      BattleLogDisplayBuilder._CreateGroup_d__23.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__23>.NativeClassPtr, "<>t__builder");
      BattleLogDisplayBuilder._CreateGroup_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__23>.NativeClassPtr, "<>4__this");
      BattleLogDisplayBuilder._CreateGroup_d__23.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__23>.NativeClassPtr, nameof (parent));
      BattleLogDisplayBuilder._CreateGroup_d__23.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__23>.NativeClassPtr, "<>u__1");
      BattleLogDisplayBuilder._CreateGroup_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__23>.NativeClassPtr, 100670594);
      BattleLogDisplayBuilder._CreateGroup_d__23.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__23>.NativeClassPtr, 100670595);
    }

    public _CreateGroup_d__23(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _CreateGroup_d__23()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__23>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateGroup_d__23>.NativeClassPtr, data));
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__23.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__23.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder<Transform> __t__builder
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__23.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder<Transform>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Transform>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__23.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Transform>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe BattleLogDisplayBuilder __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__23.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (BattleLogDisplayBuilder) null : new BattleLogDisplayBuilder(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform parent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__23.NativeFieldInfoPtr_parent));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__23.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public TaskAwaiter<GameObject> __u__1
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__23.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter<GameObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<GameObject>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateGroup_d__23.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<GameObject>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("BattleLogDisplayBuilder/<CreateEntry>d__24")]
  public sealed class _CreateEntry_d__24 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_log;
    private static readonly System.IntPtr NativeFieldInfoPtr_group;
    private static readonly System.IntPtr NativeFieldInfoPtr__result_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__2;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86470, XrefRangeEnd = 86522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder._CreateEntry_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86522, XrefRangeEnd = 86525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleLogDisplayBuilder._CreateEntry_d__24.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static _CreateEntry_d__24()
    {
      Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateEntry_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleLogDisplayBuilder>.NativeClassPtr, "<CreateEntry>d__24");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateEntry_d__24>.NativeClassPtr);
      BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateEntry_d__24>.NativeClassPtr, "<>1__state");
      BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateEntry_d__24>.NativeClassPtr, "<>t__builder");
      BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateEntry_d__24>.NativeClassPtr, "<>4__this");
      BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr_log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateEntry_d__24>.NativeClassPtr, nameof (log));
      BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateEntry_d__24>.NativeClassPtr, nameof (group));
      BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr__result_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateEntry_d__24>.NativeClassPtr, "<result>5__2");
      BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateEntry_d__24>.NativeClassPtr, "<>u__1");
      BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateEntry_d__24>.NativeClassPtr, "<>u__2");
      BattleLogDisplayBuilder._CreateEntry_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateEntry_d__24>.NativeClassPtr, 100670596);
      BattleLogDisplayBuilder._CreateEntry_d__24.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateEntry_d__24>.NativeClassPtr, 100670597);
    }

    public _CreateEntry_d__24(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _CreateEntry_d__24()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateEntry_d__24>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BattleLogDisplayBuilder._CreateEntry_d__24>.NativeClassPtr, data));
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder<Transform> __t__builder
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder<Transform>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Transform>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Transform>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe BattleLogDisplayBuilder __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (BattleLogDisplayBuilder) null : new BattleLogDisplayBuilder(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public BattleLog log
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr_log);
        return new BattleLog(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BattleLog>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr_log), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BattleLog>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Transform group
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr_group));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr_group), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject _result_5__2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr__result_5__2));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr__result_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public TaskAwaiter<GameObject> __u__1
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter<GameObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<GameObject>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<GameObject>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public TaskAwaiter __u__2
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr___u__2);
        return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplayBuilder._CreateEntry_d__24.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
