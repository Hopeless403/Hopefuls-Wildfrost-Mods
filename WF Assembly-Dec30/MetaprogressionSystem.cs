// Decompiled with JetBrains decompiler
// Type: MetaprogressionSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class MetaprogressionSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_data;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_T_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_T_String_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Static_Void_String_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetUnlockedList_Public_Static_List_1_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetUnlocked_Public_Static_IEnumerable_1_UnlockData_Predicate_1_UnlockData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRemainingUnlocks_Public_Static_List_1_UnlockData_List_1_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsUnlocked_Public_Static_Boolean_UnlockData_List_1_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsUnlocked_Public_Static_Boolean_String_List_1_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLockedClasses_Public_Static_List_1_ClassData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLockedItems_Public_Static_List_1_String_List_1_UnlockData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLockedCompanions_Public_Static_List_1_String_List_1_UnlockData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLockedCharms_Public_Static_List_1_String_List_1_UnlockData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetUnlockedPets_Public_Static_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetUnlocksReady_Public_Static_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckUnlockRequirements_Public_Static_Boolean_UnlockData_ICollection_1_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AnyUnlocksReady_Public_Static_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 63798, RefRangeEnd = 63808, XrefRangeStart = 63788, XrefRangeEnd = 63798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T Get<T>(string key) where T : class
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(key)
    };
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.MethodInfoStoreGeneric_Get_Public_Static_T_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63808, XrefRangeEnd = 63825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T Get<T>(string key, T defaultValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) defaultValue;
      if (!(local2 is string))
      {
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = ptr == System.IntPtr.Zero ? (T&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (T&) ptr : (T&) IL2CPP.il2cpp_object_unbox(ptr));
      }
      else
      {
        // ISSUE: cast to a reference type
        local1 = (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string);
      }
    }
    else
      local1 = ref defaultValue;
    *(System.IntPtr*) num = (System.IntPtr) ref local1;
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.MethodInfoStoreGeneric_Get_Public_Static_T_String_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 63831, RefRangeEnd = 63832, XrefRangeStart = 63825, XrefRangeEnd = 63831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Set<T>(string key, T value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) value;
      if (!(local2 is string))
      {
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = ptr == System.IntPtr.Zero ? (T&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (T&) ptr : (T&) IL2CPP.il2cpp_object_unbox(ptr));
      }
      else
      {
        // ISSUE: cast to a reference type
        local1 = (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string);
      }
    }
    else
      local1 = ref value;
    *(System.IntPtr*) num = (System.IntPtr) ref local1;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.MethodInfoStoreGeneric_Set_Public_Static_Void_String_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(15)]
  [CachedScanResults(RefRangeStart = 63847, RefRangeEnd = 63862, XrefRangeStart = 63832, XrefRangeEnd = 63847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe List<string> GetUnlockedList()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.NativeMethodInfoPtr_GetUnlockedList_Public_Static_List_1_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63862, XrefRangeEnd = 63899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IEnumerable<UnlockData> GetUnlocked(Il2CppSystem.Predicate<UnlockData> match)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) match)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.NativeMethodInfoPtr_GetUnlocked_Public_Static_IEnumerable_1_UnlockData_Predicate_1_UnlockData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerable<UnlockData>) null : new IEnumerable<UnlockData>(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 63948, RefRangeEnd = 63950, XrefRangeStart = 63899, XrefRangeEnd = 63948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe List<UnlockData> GetRemainingUnlocks(List<string> alreadyUnlocked = null)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) alreadyUnlocked)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.NativeMethodInfoPtr_GetRemainingUnlocks_Public_Static_List_1_UnlockData_List_1_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<UnlockData>) null : new List<UnlockData>(pointer);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 63955, RefRangeEnd = 63962, XrefRangeStart = 63950, XrefRangeEnd = 63955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsUnlocked(UnlockData unlockData, List<string> alreadyUnlocked = null)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) unlockData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) alreadyUnlocked);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.NativeMethodInfoPtr_IsUnlocked_Public_Static_Boolean_UnlockData_List_1_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63962, XrefRangeEnd = 63970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsUnlocked(string unlockDataName, List<string> alreadyUnlocked = null)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(unlockDataName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) alreadyUnlocked);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.NativeMethodInfoPtr_IsUnlocked_Public_Static_Boolean_String_List_1_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 63993, RefRangeEnd = 63994, XrefRangeStart = 63970, XrefRangeEnd = 63993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe List<ClassData> GetLockedClasses()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.NativeMethodInfoPtr_GetLockedClasses_Public_Static_List_1_ClassData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<ClassData>) null : new List<ClassData>(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 64030, RefRangeEnd = 64031, XrefRangeStart = 63994, XrefRangeEnd = 64030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe List<string> GetLockedItems(List<UnlockData> remainingUnlocks)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) remainingUnlocks)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.NativeMethodInfoPtr_GetLockedItems_Public_Static_List_1_String_List_1_UnlockData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 64067, RefRangeEnd = 64068, XrefRangeStart = 64031, XrefRangeEnd = 64067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe List<string> GetLockedCompanions(List<UnlockData> remainingUnlocks)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) remainingUnlocks)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.NativeMethodInfoPtr_GetLockedCompanions_Public_Static_List_1_String_List_1_UnlockData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 64104, RefRangeEnd = 64105, XrefRangeStart = 64068, XrefRangeEnd = 64104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe List<string> GetLockedCharms(List<UnlockData> remainingUnlocks)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) remainingUnlocks)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.NativeMethodInfoPtr_GetLockedCharms_Public_Static_List_1_String_List_1_UnlockData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 64128, RefRangeEnd = 64131, XrefRangeStart = 64105, XrefRangeEnd = 64128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppStringArray GetUnlockedPets()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.NativeMethodInfoPtr_GetUnlockedPets_Public_Static_Il2CppStringArray_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 64160, RefRangeEnd = 64164, XrefRangeStart = 64131, XrefRangeEnd = 64160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetUnlocksReady(string unlockName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(unlockName)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.NativeMethodInfoPtr_SetUnlocksReady_Public_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 64179, RefRangeEnd = 64182, XrefRangeStart = 64164, XrefRangeEnd = 64179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CheckUnlockRequirements(
    UnlockData unlock,
    ICollection<string> alreadyUnlocked)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) unlock);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) alreadyUnlocked);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.NativeMethodInfoPtr_CheckUnlockRequirements_Public_Static_Boolean_UnlockData_ICollection_1_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 64197, RefRangeEnd = 64199, XrefRangeStart = 64182, XrefRangeEnd = 64197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool AnyUnlocksReady()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.NativeMethodInfoPtr_AnyUnlocksReady_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MetaprogressionSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static MetaprogressionSystem()
  {
    Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (MetaprogressionSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr);
    MetaprogressionSystem.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr, nameof (data));
    MetaprogressionSystem.NativeMethodInfoPtr_Get_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr, 100668512);
    MetaprogressionSystem.NativeMethodInfoPtr_Get_Public_Static_T_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr, 100668513);
    MetaprogressionSystem.NativeMethodInfoPtr_Set_Public_Static_Void_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr, 100668514);
    MetaprogressionSystem.NativeMethodInfoPtr_GetUnlockedList_Public_Static_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr, 100668515);
    MetaprogressionSystem.NativeMethodInfoPtr_GetUnlocked_Public_Static_IEnumerable_1_UnlockData_Predicate_1_UnlockData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr, 100668516);
    MetaprogressionSystem.NativeMethodInfoPtr_GetRemainingUnlocks_Public_Static_List_1_UnlockData_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr, 100668517);
    MetaprogressionSystem.NativeMethodInfoPtr_IsUnlocked_Public_Static_Boolean_UnlockData_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr, 100668518);
    MetaprogressionSystem.NativeMethodInfoPtr_IsUnlocked_Public_Static_Boolean_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr, 100668519);
    MetaprogressionSystem.NativeMethodInfoPtr_GetLockedClasses_Public_Static_List_1_ClassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr, 100668520);
    MetaprogressionSystem.NativeMethodInfoPtr_GetLockedItems_Public_Static_List_1_String_List_1_UnlockData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr, 100668521);
    MetaprogressionSystem.NativeMethodInfoPtr_GetLockedCompanions_Public_Static_List_1_String_List_1_UnlockData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr, 100668522);
    MetaprogressionSystem.NativeMethodInfoPtr_GetLockedCharms_Public_Static_List_1_String_List_1_UnlockData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr, 100668523);
    MetaprogressionSystem.NativeMethodInfoPtr_GetUnlockedPets_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr, 100668524);
    MetaprogressionSystem.NativeMethodInfoPtr_SetUnlocksReady_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr, 100668525);
    MetaprogressionSystem.NativeMethodInfoPtr_CheckUnlockRequirements_Public_Static_Boolean_UnlockData_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr, 100668526);
    MetaprogressionSystem.NativeMethodInfoPtr_AnyUnlocksReady_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr, 100668527);
    MetaprogressionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr, 100668528);
  }

  public MetaprogressionSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Dictionary<string, Il2CppSystem.Object> data
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(MetaprogressionSystem.NativeFieldInfoPtr_data, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<string, Il2CppSystem.Object>) null : new Dictionary<string, Il2CppSystem.Object>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MetaprogressionSystem.NativeFieldInfoPtr_data, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("MetaprogressionSystem/<>c__DisplayClass5_0")]
  public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_match;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetUnlocked_b__1_Internal_Boolean_UnlockData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass5_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass5_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63766, XrefRangeEnd = 63770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetUnlocked_b__1(UnlockData unlock)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) unlock)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__GetUnlocked_b__1_Internal_Boolean_UnlockData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass5_0()
    {
      Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr, "<>c__DisplayClass5_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass5_0>.NativeClassPtr);
      MetaprogressionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (match));
      MetaprogressionSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass5_0>.NativeClassPtr, 100668530);
      MetaprogressionSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__GetUnlocked_b__1_Internal_Boolean_UnlockData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass5_0>.NativeClassPtr, 100668531);
    }

    public __c__DisplayClass5_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppSystem.Predicate<UnlockData> match
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MetaprogressionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_match));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Predicate<UnlockData>) null : new Il2CppSystem.Predicate<UnlockData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MetaprogressionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("MetaprogressionSystem/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__5_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__6_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__10_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__11_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetUnlocked_b__5_0_Internal_UnlockData_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetRemainingUnlocks_b__6_1_Internal_Single_UnlockData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetLockedItems_b__10_0_Internal_Boolean_UnlockData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetLockedCompanions_b__11_0_Internal_Boolean_UnlockData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetaprogressionSystem.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63770, XrefRangeEnd = 63778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnlockData _GetUnlocked_b__5_0(string n)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(n)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.__c.NativeMethodInfoPtr__GetUnlocked_b__5_0_Internal_UnlockData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (UnlockData) null : new UnlockData(pointer);
    }

    [CallerCount(0)]
    public unsafe float _GetRemainingUnlocks_b__6_1(UnlockData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.__c.NativeMethodInfoPtr__GetRemainingUnlocks_b__6_1_Internal_Single_UnlockData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool _GetLockedItems_b__10_0(UnlockData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.__c.NativeMethodInfoPtr__GetLockedItems_b__10_0_Internal_Boolean_UnlockData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool _GetLockedCompanions_b__11_0(UnlockData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.__c.NativeMethodInfoPtr__GetLockedCompanions_b__11_0_Internal_Boolean_UnlockData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<MetaprogressionSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetaprogressionSystem.__c>.NativeClassPtr);
      MetaprogressionSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaprogressionSystem.__c>.NativeClassPtr, "<>9");
      MetaprogressionSystem.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaprogressionSystem.__c>.NativeClassPtr, "<>9__5_0");
      MetaprogressionSystem.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaprogressionSystem.__c>.NativeClassPtr, "<>9__6_1");
      MetaprogressionSystem.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaprogressionSystem.__c>.NativeClassPtr, "<>9__10_0");
      MetaprogressionSystem.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaprogressionSystem.__c>.NativeClassPtr, "<>9__11_0");
      MetaprogressionSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem.__c>.NativeClassPtr, 100668533);
      MetaprogressionSystem.__c.NativeMethodInfoPtr__GetUnlocked_b__5_0_Internal_UnlockData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem.__c>.NativeClassPtr, 100668534);
      MetaprogressionSystem.__c.NativeMethodInfoPtr__GetRemainingUnlocks_b__6_1_Internal_Single_UnlockData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem.__c>.NativeClassPtr, 100668535);
      MetaprogressionSystem.__c.NativeMethodInfoPtr__GetLockedItems_b__10_0_Internal_Boolean_UnlockData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem.__c>.NativeClassPtr, 100668536);
      MetaprogressionSystem.__c.NativeMethodInfoPtr__GetLockedCompanions_b__11_0_Internal_Boolean_UnlockData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem.__c>.NativeClassPtr, 100668537);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe MetaprogressionSystem.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(MetaprogressionSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (MetaprogressionSystem.__c) null : new MetaprogressionSystem.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MetaprogressionSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<string, UnlockData> __9__5_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(MetaprogressionSystem.__c.NativeFieldInfoPtr___9__5_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<string, UnlockData>) null : new Il2CppSystem.Func<string, UnlockData>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MetaprogressionSystem.__c.NativeFieldInfoPtr___9__5_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<UnlockData, float> __9__6_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(MetaprogressionSystem.__c.NativeFieldInfoPtr___9__6_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<UnlockData, float>) null : new Il2CppSystem.Func<UnlockData, float>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MetaprogressionSystem.__c.NativeFieldInfoPtr___9__6_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<UnlockData, bool> __9__10_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(MetaprogressionSystem.__c.NativeFieldInfoPtr___9__10_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<UnlockData, bool>) null : new Il2CppSystem.Func<UnlockData, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MetaprogressionSystem.__c.NativeFieldInfoPtr___9__10_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<UnlockData, bool> __9__11_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(MetaprogressionSystem.__c.NativeFieldInfoPtr___9__11_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<UnlockData, bool>) null : new Il2CppSystem.Func<UnlockData, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MetaprogressionSystem.__c.NativeFieldInfoPtr___9__11_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("MetaprogressionSystem/<>c__DisplayClass6_0")]
  public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_alreadyUnlocked;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetRemainingUnlocks_b__0_Internal_Boolean_UnlockData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass6_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass6_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63778, XrefRangeEnd = 63782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetRemainingUnlocks_b__0(UnlockData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__GetRemainingUnlocks_b__0_Internal_Boolean_UnlockData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass6_0()
    {
      Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr, "<>c__DisplayClass6_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass6_0>.NativeClassPtr);
      MetaprogressionSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_alreadyUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (alreadyUnlocked));
      MetaprogressionSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass6_0>.NativeClassPtr, 100668538);
      MetaprogressionSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__GetRemainingUnlocks_b__0_Internal_Boolean_UnlockData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass6_0>.NativeClassPtr, 100668539);
    }

    public __c__DisplayClass6_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<string> alreadyUnlocked
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MetaprogressionSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_alreadyUnlocked));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MetaprogressionSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_alreadyUnlocked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("MetaprogressionSystem/<>c__DisplayClass9_0")]
  public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_unlockedList;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetLockedClasses_b__0_Internal_Boolean_ClassData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass9_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass9_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63782, XrefRangeEnd = 63787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetLockedClasses_b__0(ClassData c)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) c)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__GetLockedClasses_b__0_Internal_Boolean_ClassData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass9_0()
    {
      Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr, "<>c__DisplayClass9_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass9_0>.NativeClassPtr);
      MetaprogressionSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_unlockedList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (unlockedList));
      MetaprogressionSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass9_0>.NativeClassPtr, 100668540);
      MetaprogressionSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__GetLockedClasses_b__0_Internal_Boolean_ClassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass9_0>.NativeClassPtr, 100668541);
    }

    public __c__DisplayClass9_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<string> unlockedList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MetaprogressionSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_unlockedList));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MetaprogressionSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_unlockedList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("MetaprogressionSystem/<>c__DisplayClass15_0")]
  public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_alreadyUnlocked;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CheckUnlockRequirements_b__0_Internal_Boolean_UnlockData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass15_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass15_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63787, XrefRangeEnd = 63788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _CheckUnlockRequirements_b__0(UnlockData requirement)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) requirement)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MetaprogressionSystem.__c__DisplayClass15_0.NativeMethodInfoPtr__CheckUnlockRequirements_b__0_Internal_Boolean_UnlockData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass15_0()
    {
      Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr, "<>c__DisplayClass15_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass15_0>.NativeClassPtr);
      MetaprogressionSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_alreadyUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (alreadyUnlocked));
      MetaprogressionSystem.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass15_0>.NativeClassPtr, 100668542);
      MetaprogressionSystem.__c__DisplayClass15_0.NativeMethodInfoPtr__CheckUnlockRequirements_b__0_Internal_Boolean_UnlockData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaprogressionSystem.__c__DisplayClass15_0>.NativeClassPtr, 100668543);
    }

    public __c__DisplayClass15_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ICollection<string> alreadyUnlocked
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MetaprogressionSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_alreadyUnlocked));
        return pointer == System.IntPtr.Zero ? (ICollection<string>) null : new ICollection<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MetaprogressionSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_alreadyUnlocked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_Get_Public_Static_T_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(MetaprogressionSystem.NativeMethodInfoPtr_Get_Public_Static_T_String_0, Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_Get_Public_Static_T_String_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(MetaprogressionSystem.NativeMethodInfoPtr_Get_Public_Static_T_String_T_0, Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_Set_Public_Static_Void_String_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(MetaprogressionSystem.NativeMethodInfoPtr_Set_Public_Static_Void_String_T_0, Il2CppClassPointerStore<MetaprogressionSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
