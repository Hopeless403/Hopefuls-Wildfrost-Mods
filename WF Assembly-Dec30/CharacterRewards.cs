// Decompiled with JetBrains decompiler
// Type: CharacterRewards
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class CharacterRewards : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_poolLookup;
  private static readonly System.IntPtr NativeMethodInfoPtr_Populate_Public_Void_ClassData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_RewardPool_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetItemsInPool_Public_List_1_DataFile_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_String_IEnumerable_1_DataFile_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveLockedCards_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveCardsFromStartingDeck_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveCompanionsInFinalBossBattle_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Pull_Public_T_Object_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Pull_Public_Il2CppArrayBase_1_T_Object_String_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Pull_Public_Il2CppArrayBase_1_T_Object_String_Int32_Boolean_Predicate_1_DataFile_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFromOriginalList_Public_Il2CppArrayBase_1_T_Object_String_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFromOriginalList_Public_Il2CppArrayBase_1_T_Object_String_Int32_Boolean_Predicate_1_DataFile_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PullOut_Public_Void_String_IEnumerable_1_DataFile_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PullOut_Public_Void_String_DataFile_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 37556, RefRangeEnd = 37557, XrefRangeStart = 37551, XrefRangeEnd = 37556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Populate(ClassData classData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) classData)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterRewards.NativeMethodInfoPtr_Populate_Public_Void_ClassData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 37584, RefRangeEnd = 37586, XrefRangeStart = 37557, XrefRangeEnd = 37584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Add(RewardPool rewardPool)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rewardPool)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterRewards.NativeMethodInfoPtr_Add_Public_Void_RewardPool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37586, XrefRangeEnd = 37589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<DataFile> GetItemsInPool(string name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterRewards.NativeMethodInfoPtr_GetItemsInPool_Public_List_1_DataFile_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<DataFile>) null : new List<DataFile>(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 37604, RefRangeEnd = 37605, XrefRangeStart = 37589, XrefRangeEnd = 37604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Add(string poolName, IEnumerable<DataFile> items)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(poolName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) items);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterRewards.NativeMethodInfoPtr_Add_Public_Void_String_IEnumerable_1_DataFile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 37664, RefRangeEnd = 37666, XrefRangeStart = 37605, XrefRangeEnd = 37664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveLockedCards()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterRewards.NativeMethodInfoPtr_RemoveLockedCards_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37666, XrefRangeEnd = 37751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveCardsFromStartingDeck()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterRewards.NativeMethodInfoPtr_RemoveCardsFromStartingDeck_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37751, XrefRangeEnd = 37787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveCompanionsInFinalBossBattle()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterRewards.NativeMethodInfoPtr_RemoveCompanionsInFinalBossBattle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 37787, RefRangeEnd = 37788, XrefRangeStart = 37787, XrefRangeEnd = 37787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe T Pull<T>(Il2CppSystem.Object pulledBy, string poolName) where T : DataFile
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pulledBy);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(poolName);
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(CharacterRewards.MethodInfoStoreGeneric_Pull_Public_T_Object_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 37815, RefRangeEnd = 37821, XrefRangeStart = 37788, XrefRangeEnd = 37815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppArrayBase<T> Pull<T>(
    Il2CppSystem.Object pulledBy,
    string poolName,
    int itemCount,
    bool allowDuplicates = false)
    where T : DataFile
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pulledBy);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(poolName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &allowDuplicates;
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CharacterRewards.MethodInfoStoreGeneric_Pull_Public_Il2CppArrayBase_1_T_Object_String_Int32_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 37848, RefRangeEnd = 37851, XrefRangeStart = 37821, XrefRangeEnd = 37848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppArrayBase<T> Pull<T>(
    Il2CppSystem.Object pulledBy,
    string poolName,
    int itemCount,
    bool allowDuplicates,
    Il2CppSystem.Predicate<DataFile> match)
    where T : DataFile
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pulledBy);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(poolName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &allowDuplicates;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) match);
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CharacterRewards.MethodInfoStoreGeneric_Pull_Public_Il2CppArrayBase_1_T_Object_String_Int32_Boolean_Predicate_1_DataFile_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 37862, RefRangeEnd = 37863, XrefRangeStart = 37851, XrefRangeEnd = 37862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppArrayBase<T> GetFromOriginalList<T>(
    Il2CppSystem.Object pulledBy,
    string poolName,
    int itemCount,
    bool allowDuplicates)
    where T : DataFile
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pulledBy);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(poolName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &allowDuplicates;
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CharacterRewards.MethodInfoStoreGeneric_GetFromOriginalList_Public_Il2CppArrayBase_1_T_Object_String_Int32_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37863, XrefRangeEnd = 37874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppArrayBase<T> GetFromOriginalList<T>(
    Il2CppSystem.Object pulledBy,
    string poolName,
    int itemCount,
    bool allowDuplicates,
    Il2CppSystem.Predicate<DataFile> match)
    where T : DataFile
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pulledBy);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(poolName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &allowDuplicates;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) match);
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CharacterRewards.MethodInfoStoreGeneric_GetFromOriginalList_Public_Il2CppArrayBase_1_T_Object_String_Int32_Boolean_Predicate_1_DataFile_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 37878, RefRangeEnd = 37880, XrefRangeStart = 37874, XrefRangeEnd = 37878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PullOut(string poolName, IEnumerable<DataFile> items)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(poolName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) items);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterRewards.NativeMethodInfoPtr_PullOut_Public_Void_String_IEnumerable_1_DataFile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 37888, RefRangeEnd = 37889, XrefRangeStart = 37880, XrefRangeEnd = 37888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PullOut(string poolName, DataFile item)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(poolName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterRewards.NativeMethodInfoPtr_PullOut_Public_Void_String_DataFile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37889, XrefRangeEnd = 37898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterRewards()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterRewards.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CharacterRewards()
  {
    Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CharacterRewards));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr);
    CharacterRewards.NativeFieldInfoPtr_poolLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr, nameof (poolLookup));
    CharacterRewards.NativeMethodInfoPtr_Populate_Public_Void_ClassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr, 100665805);
    CharacterRewards.NativeMethodInfoPtr_Add_Public_Void_RewardPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr, 100665806);
    CharacterRewards.NativeMethodInfoPtr_GetItemsInPool_Public_List_1_DataFile_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr, 100665807);
    CharacterRewards.NativeMethodInfoPtr_Add_Public_Void_String_IEnumerable_1_DataFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr, 100665808);
    CharacterRewards.NativeMethodInfoPtr_RemoveLockedCards_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr, 100665809);
    CharacterRewards.NativeMethodInfoPtr_RemoveCardsFromStartingDeck_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr, 100665810);
    CharacterRewards.NativeMethodInfoPtr_RemoveCompanionsInFinalBossBattle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr, 100665811);
    CharacterRewards.NativeMethodInfoPtr_Pull_Public_T_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr, 100665812);
    CharacterRewards.NativeMethodInfoPtr_Pull_Public_Il2CppArrayBase_1_T_Object_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr, 100665813);
    CharacterRewards.NativeMethodInfoPtr_Pull_Public_Il2CppArrayBase_1_T_Object_String_Int32_Boolean_Predicate_1_DataFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr, 100665814);
    CharacterRewards.NativeMethodInfoPtr_GetFromOriginalList_Public_Il2CppArrayBase_1_T_Object_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr, 100665815);
    CharacterRewards.NativeMethodInfoPtr_GetFromOriginalList_Public_Il2CppArrayBase_1_T_Object_String_Int32_Boolean_Predicate_1_DataFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr, 100665816);
    CharacterRewards.NativeMethodInfoPtr_PullOut_Public_Void_String_IEnumerable_1_DataFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr, 100665817);
    CharacterRewards.NativeMethodInfoPtr_PullOut_Public_Void_String_DataFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr, 100665818);
    CharacterRewards.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr, 100665819);
  }

  public CharacterRewards(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Dictionary<string, CharacterRewards.Pool> poolLookup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterRewards.NativeFieldInfoPtr_poolLookup));
      return pointer == System.IntPtr.Zero ? (Dictionary<string, CharacterRewards.Pool>) null : new Dictionary<string, CharacterRewards.Pool>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterRewards.NativeFieldInfoPtr_poolLookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public class Pool : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__list_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_current;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_list_Public_get_List_1_DataFile_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_list_Private_set_Void_List_1_DataFile_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_DataFile_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_IEnumerable_1_DataFile_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_IEnumerable_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PullOut_Public_Void_IEnumerable_1_DataFile_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PullOut_Public_Void_DataFile_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Pull_Public_DataFile_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Pull_Public_Il2CppReferenceArray_1_DataFile_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Pull_Public_Il2CppReferenceArray_1_DataFile_Int32_Boolean_Predicate_1_DataFile_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFromOriginalList_Public_Il2CppReferenceArray_1_DataFile_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFromOriginalList_Public_Il2CppReferenceArray_1_DataFile_Int32_Boolean_Predicate_1_DataFile_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckPopulate_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Populate_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe List<DataFile> list
    {
      [CallerCount(10), CachedScanResults(RefRangeStart = 20094, RefRangeEnd = 20104, XrefRangeStart = 20094, XrefRangeEnd = 20104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterRewards.Pool.NativeMethodInfoPtr_get_list_Public_get_List_1_DataFile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<DataFile>) null : new List<DataFile>(pointer);
      }
      [CallerCount(21), CachedScanResults(RefRangeStart = 20073, RefRangeEnd = 20094, XrefRangeStart = 20073, XrefRangeEnd = 20094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CharacterRewards.Pool.NativeMethodInfoPtr_set_list_Private_set_Void_List_1_DataFile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37254, XrefRangeEnd = 37265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Add(DataFile item)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterRewards.Pool.NativeMethodInfoPtr_Add_Public_Void_DataFile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 37276, RefRangeEnd = 37278, XrefRangeStart = 37265, XrefRangeEnd = 37276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Add(IEnumerable<DataFile> content)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) content)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterRewards.Pool.NativeMethodInfoPtr_Add_Public_Void_IEnumerable_1_DataFile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 37296, RefRangeEnd = 37301, XrefRangeStart = 37278, XrefRangeEnd = 37296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Remove(IEnumerable<string> itemNames)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) itemNames)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterRewards.Pool.NativeMethodInfoPtr_Remove_Public_Void_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 37325, RefRangeEnd = 37327, XrefRangeStart = 37301, XrefRangeEnd = 37325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Remove(string itemName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(itemName)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterRewards.Pool.NativeMethodInfoPtr_Remove_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 37349, RefRangeEnd = 37350, XrefRangeStart = 37327, XrefRangeEnd = 37349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PullOut(IEnumerable<DataFile> items)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) items)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterRewards.Pool.NativeMethodInfoPtr_PullOut_Public_Void_IEnumerable_1_DataFile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 37356, RefRangeEnd = 37358, XrefRangeStart = 37350, XrefRangeEnd = 37356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PullOut(DataFile item)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterRewards.Pool.NativeMethodInfoPtr_PullOut_Public_Void_DataFile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37358, XrefRangeEnd = 37366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DataFile Pull()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterRewards.Pool.NativeMethodInfoPtr_Pull_Public_DataFile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (DataFile) null : new DataFile(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 37393, RefRangeEnd = 37394, XrefRangeStart = 37366, XrefRangeEnd = 37393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppReferenceArray<DataFile> Pull(int itemCount, bool allowDuplicates = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &itemCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allowDuplicates;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterRewards.Pool.NativeMethodInfoPtr_Pull_Public_Il2CppReferenceArray_1_DataFile_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<DataFile>) null : new Il2CppReferenceArray<DataFile>(nativeObject);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 37441, RefRangeEnd = 37442, XrefRangeStart = 37394, XrefRangeEnd = 37441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppReferenceArray<DataFile> Pull(
      int itemCount,
      bool allowDuplicates,
      Il2CppSystem.Predicate<DataFile> match)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &itemCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allowDuplicates;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) match);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterRewards.Pool.NativeMethodInfoPtr_Pull_Public_Il2CppReferenceArray_1_DataFile_Int32_Boolean_Predicate_1_DataFile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<DataFile>) null : new Il2CppReferenceArray<DataFile>(nativeObject);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 37480, RefRangeEnd = 37481, XrefRangeStart = 37442, XrefRangeEnd = 37480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppReferenceArray<DataFile> GetFromOriginalList(
      int itemCount,
      bool allowDuplicates)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &itemCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allowDuplicates;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterRewards.Pool.NativeMethodInfoPtr_GetFromOriginalList_Public_Il2CppReferenceArray_1_DataFile_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<DataFile>) null : new Il2CppReferenceArray<DataFile>(nativeObject);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 37522, RefRangeEnd = 37523, XrefRangeStart = 37481, XrefRangeEnd = 37522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppReferenceArray<DataFile> GetFromOriginalList(
      int itemCount,
      bool allowDuplicates,
      Il2CppSystem.Predicate<DataFile> match)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &itemCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allowDuplicates;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) match);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterRewards.Pool.NativeMethodInfoPtr_GetFromOriginalList_Public_Il2CppReferenceArray_1_DataFile_Int32_Boolean_Predicate_1_DataFile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<DataFile>) null : new Il2CppReferenceArray<DataFile>(nativeObject);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37523, XrefRangeEnd = 37525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckPopulate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterRewards.Pool.NativeMethodInfoPtr_CheckPopulate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 37532, RefRangeEnd = 37540, XrefRangeStart = 37525, XrefRangeEnd = 37532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Populate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterRewards.Pool.NativeMethodInfoPtr_Populate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 37549, RefRangeEnd = 37551, XrefRangeStart = 37540, XrefRangeEnd = 37549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Pool()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterRewards.Pool>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterRewards.Pool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Pool()
    {
      Il2CppClassPointerStore<CharacterRewards.Pool>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr, nameof (Pool));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterRewards.Pool>.NativeClassPtr);
      CharacterRewards.Pool.NativeFieldInfoPtr__list_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterRewards.Pool>.NativeClassPtr, "<list>k__BackingField");
      CharacterRewards.Pool.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterRewards.Pool>.NativeClassPtr, nameof (current));
      CharacterRewards.Pool.NativeMethodInfoPtr_get_list_Public_get_List_1_DataFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards.Pool>.NativeClassPtr, 100665820);
      CharacterRewards.Pool.NativeMethodInfoPtr_set_list_Private_set_Void_List_1_DataFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards.Pool>.NativeClassPtr, 100665821);
      CharacterRewards.Pool.NativeMethodInfoPtr_Add_Public_Void_DataFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards.Pool>.NativeClassPtr, 100665822);
      CharacterRewards.Pool.NativeMethodInfoPtr_Add_Public_Void_IEnumerable_1_DataFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards.Pool>.NativeClassPtr, 100665823);
      CharacterRewards.Pool.NativeMethodInfoPtr_Remove_Public_Void_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards.Pool>.NativeClassPtr, 100665824);
      CharacterRewards.Pool.NativeMethodInfoPtr_Remove_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards.Pool>.NativeClassPtr, 100665825);
      CharacterRewards.Pool.NativeMethodInfoPtr_PullOut_Public_Void_IEnumerable_1_DataFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards.Pool>.NativeClassPtr, 100665826);
      CharacterRewards.Pool.NativeMethodInfoPtr_PullOut_Public_Void_DataFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards.Pool>.NativeClassPtr, 100665827);
      CharacterRewards.Pool.NativeMethodInfoPtr_Pull_Public_DataFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards.Pool>.NativeClassPtr, 100665828);
      CharacterRewards.Pool.NativeMethodInfoPtr_Pull_Public_Il2CppReferenceArray_1_DataFile_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards.Pool>.NativeClassPtr, 100665829);
      CharacterRewards.Pool.NativeMethodInfoPtr_Pull_Public_Il2CppReferenceArray_1_DataFile_Int32_Boolean_Predicate_1_DataFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards.Pool>.NativeClassPtr, 100665830);
      CharacterRewards.Pool.NativeMethodInfoPtr_GetFromOriginalList_Public_Il2CppReferenceArray_1_DataFile_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards.Pool>.NativeClassPtr, 100665831);
      CharacterRewards.Pool.NativeMethodInfoPtr_GetFromOriginalList_Public_Il2CppReferenceArray_1_DataFile_Int32_Boolean_Predicate_1_DataFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards.Pool>.NativeClassPtr, 100665832);
      CharacterRewards.Pool.NativeMethodInfoPtr_CheckPopulate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards.Pool>.NativeClassPtr, 100665833);
      CharacterRewards.Pool.NativeMethodInfoPtr_Populate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards.Pool>.NativeClassPtr, 100665834);
      CharacterRewards.Pool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards.Pool>.NativeClassPtr, 100665835);
    }

    public Pool(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<DataFile> _list_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterRewards.Pool.NativeFieldInfoPtr__list_k__BackingField));
        return pointer == System.IntPtr.Zero ? (List<DataFile>) null : new List<DataFile>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterRewards.Pool.NativeFieldInfoPtr__list_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<DataFile> current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterRewards.Pool.NativeFieldInfoPtr_current));
        return pointer == System.IntPtr.Zero ? (List<DataFile>) null : new List<DataFile>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterRewards.Pool.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("CharacterRewards/Pool/<>c__DisplayClass8_0")]
    public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_itemName;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_DataFile_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterRewards.Pool.__c__DisplayClass8_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CharacterRewards.Pool.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37251, XrefRangeEnd = 37254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _Remove_b__0(DataFile a)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
        };
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterRewards.Pool.__c__DisplayClass8_0.NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_DataFile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass8_0()
      {
        Il2CppClassPointerStore<CharacterRewards.Pool.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterRewards.Pool>.NativeClassPtr, "<>c__DisplayClass8_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterRewards.Pool.__c__DisplayClass8_0>.NativeClassPtr);
        CharacterRewards.Pool.__c__DisplayClass8_0.NativeFieldInfoPtr_itemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterRewards.Pool.__c__DisplayClass8_0>.NativeClassPtr, nameof (itemName));
        CharacterRewards.Pool.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards.Pool.__c__DisplayClass8_0>.NativeClassPtr, 100665836);
        CharacterRewards.Pool.__c__DisplayClass8_0.NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_DataFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterRewards.Pool.__c__DisplayClass8_0>.NativeClassPtr, 100665837);
      }

      public __c__DisplayClass8_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe string itemName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterRewards.Pool.__c__DisplayClass8_0.NativeFieldInfoPtr_itemName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterRewards.Pool.__c__DisplayClass8_0.NativeFieldInfoPtr_itemName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_Pull_Public_T_Object_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CharacterRewards.NativeMethodInfoPtr_Pull_Public_T_Object_String_0, Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_Pull_Public_Il2CppArrayBase_1_T_Object_String_Int32_Boolean_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CharacterRewards.NativeMethodInfoPtr_Pull_Public_Il2CppArrayBase_1_T_Object_String_Int32_Boolean_0, Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_Pull_Public_Il2CppArrayBase_1_T_Object_String_Int32_Boolean_Predicate_1_DataFile_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CharacterRewards.NativeMethodInfoPtr_Pull_Public_Il2CppArrayBase_1_T_Object_String_Int32_Boolean_Predicate_1_DataFile_0, Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetFromOriginalList_Public_Il2CppArrayBase_1_T_Object_String_Int32_Boolean_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CharacterRewards.NativeMethodInfoPtr_GetFromOriginalList_Public_Il2CppArrayBase_1_T_Object_String_Int32_Boolean_0, Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetFromOriginalList_Public_Il2CppArrayBase_1_T_Object_String_Int32_Boolean_Predicate_1_DataFile_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CharacterRewards.NativeMethodInfoPtr_GetFromOriginalList_Public_Il2CppArrayBase_1_T_Object_String_Int32_Boolean_Predicate_1_DataFile_0, Il2CppClassPointerStore<CharacterRewards>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
