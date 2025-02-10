// Decompiled with JetBrains decompiler
// Type: CampaignStats
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
[Serializable]
public class CampaignStats : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_time;
  private static readonly System.IntPtr NativeFieldInfoPtr_hours;
  private static readonly System.IntPtr NativeFieldInfoPtr_add;
  private static readonly System.IntPtr NativeFieldInfoPtr_max;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_String_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Void_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Void_String_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Change_Private_Void_String_Int32_byref_Dictionary_2_String_Dictionary_2_String_Int32_Func_3_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Change_Private_Void_String_String_Int32_byref_Dictionary_2_String_Dictionary_2_String_Int32_Func_3_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Private_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Max_Private_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Dictionary_2_String_Int32_String_Dictionary_2_String_Dictionary_2_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Dictionary_2_String_Int32_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Int32_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Int32_String_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Best_Public_Int32_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Best_Public_Int32_String_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Count_Public_Int32_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_String_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetBest_Public_Void_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetBest_Public_Void_String_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Private_Void_Dictionary_2_String_Dictionary_2_String_Int32_String_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Delete_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeleteBest_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_CampaignStats_0;

  [CallerCount(1959)]
  [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CampaignStats()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 102307, RefRangeEnd = 102316, XrefRangeStart = 102298, XrefRangeEnd = 102307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Add(string stat, int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(stat);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr_Add_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(43)]
  [CachedScanResults(RefRangeStart = 102323, RefRangeEnd = 102366, XrefRangeStart = 102316, XrefRangeEnd = 102323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Add(string stat, string key, int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(stat);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr_Add_Public_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 102375, RefRangeEnd = 102379, XrefRangeStart = 102366, XrefRangeEnd = 102375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Max(string stat, int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(stat);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr_Max_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 102386, RefRangeEnd = 102389, XrefRangeStart = 102379, XrefRangeEnd = 102386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Max(string stat, string key, int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(stat);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr_Max_Public_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102389, XrefRangeEnd = 102392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Change(
    string stat,
    int value,
    ref Dictionary<string, Dictionary<string, int>> values,
    Il2CppSystem.Func<int, int, int> action)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(stat);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) values);
    System.IntPtr* numPtr2 = &ptr;
    *(System.IntPtr*) num = (System.IntPtr) numPtr2;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr_Change_Private_Void_String_Int32_byref_Dictionary_2_String_Dictionary_2_String_Int32_Func_3_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref Dictionary<string, Dictionary<string, int>> local = ref values;
    System.IntPtr pointer = ptr;
    Dictionary<,> dictionary = pointer == System.IntPtr.Zero ? (Dictionary<,>) null : new Dictionary<,>(pointer);
    local = (Dictionary<string, Dictionary<string, int>>) dictionary;
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 102424, RefRangeEnd = 102429, XrefRangeStart = 102392, XrefRangeEnd = 102424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Change(
    string stat,
    string key,
    int value,
    ref Dictionary<string, Dictionary<string, int>> values,
    Il2CppSystem.Func<int, int, int> action)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
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
    IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr_Change_Private_Void_String_String_Int32_byref_Dictionary_2_String_Dictionary_2_String_Int32_Func_3_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref Dictionary<string, Dictionary<string, int>> local = ref values;
    System.IntPtr pointer = ptr;
    Dictionary<,> dictionary = pointer == System.IntPtr.Zero ? (Dictionary<,>) null : new Dictionary<,>(pointer);
    local = (Dictionary<string, Dictionary<string, int>>) dictionary;
  }

  [CallerCount(0)]
  public unsafe int Add(int value, int add)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &add;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr_Add_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public unsafe int Max(int value, int max)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &max;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr_Max_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102429, XrefRangeEnd = 102435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Dictionary<string, int> Get(
    string stat,
    Dictionary<string, Dictionary<string, int>> source)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(stat);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr_Get_Public_Dictionary_2_String_Int32_String_Dictionary_2_String_Dictionary_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Dictionary<string, int>) null : new Dictionary<string, int>(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 102441, RefRangeEnd = 102442, XrefRangeStart = 102435, XrefRangeEnd = 102441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Dictionary<string, int> Get(string stat)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(stat)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr_Get_Public_Dictionary_2_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Dictionary<string, int>) null : new Dictionary<string, int>(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 102457, RefRangeEnd = 102460, XrefRangeStart = 102442, XrefRangeEnd = 102457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int Get(string stat, int defaultValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(stat);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultValue;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr_Get_Public_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 102473, RefRangeEnd = 102480, XrefRangeStart = 102460, XrefRangeEnd = 102473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int Get(string stat, string key, int defaultValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(stat);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultValue;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr_Get_Public_Int32_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 102493, RefRangeEnd = 102494, XrefRangeStart = 102480, XrefRangeEnd = 102493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int Best(string stat, int defaultValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(stat);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultValue;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr_Best_Public_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 102507, RefRangeEnd = 102508, XrefRangeStart = 102494, XrefRangeEnd = 102507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int Best(string stat, string key, int defaultValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(stat);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultValue;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr_Best_Public_Int32_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 102518, RefRangeEnd = 102523, XrefRangeStart = 102508, XrefRangeEnd = 102518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int Count(string stat)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(stat)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr_Count_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 102526, RefRangeEnd = 102529, XrefRangeStart = 102523, XrefRangeEnd = 102526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(string stat, int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(stat);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr_Set_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 102530, RefRangeEnd = 102531, XrefRangeStart = 102529, XrefRangeEnd = 102530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(string stat, string key, int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(stat);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr_Set_Public_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102531, XrefRangeEnd = 102534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetBest(string stat, int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(stat);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr_SetBest_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102534, XrefRangeEnd = 102535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetBest(string stat, string key, int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(stat);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr_SetBest_Public_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 102548, RefRangeEnd = 102552, XrefRangeStart = 102535, XrefRangeEnd = 102548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(
    Dictionary<string, Dictionary<string, int>> dict,
    string stat,
    string key,
    int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dict);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(stat);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr_Set_Private_Void_Dictionary_2_String_Dictionary_2_String_Int32_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 102556, RefRangeEnd = 102557, XrefRangeStart = 102552, XrefRangeEnd = 102556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Delete(string stat)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(stat)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr_Delete_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102557, XrefRangeEnd = 102561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DeleteBest(string stat)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(stat)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr_DeleteBest_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 102627, RefRangeEnd = 102628, XrefRangeStart = 102561, XrefRangeEnd = 102627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CampaignStats Clone()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignStats.NativeMethodInfoPtr_Clone_Public_CampaignStats_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CampaignStats) null : new CampaignStats(pointer);
  }

  static CampaignStats()
  {
    Il2CppClassPointerStore<CampaignStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CampaignStats));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr);
    CampaignStats.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, nameof (time));
    CampaignStats.NativeFieldInfoPtr_hours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, nameof (hours));
    CampaignStats.NativeFieldInfoPtr_add = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, nameof (add));
    CampaignStats.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, nameof (max));
    CampaignStats.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672487);
    CampaignStats.NativeMethodInfoPtr_Add_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672488);
    CampaignStats.NativeMethodInfoPtr_Add_Public_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672489);
    CampaignStats.NativeMethodInfoPtr_Max_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672490);
    CampaignStats.NativeMethodInfoPtr_Max_Public_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672491);
    CampaignStats.NativeMethodInfoPtr_Change_Private_Void_String_Int32_byref_Dictionary_2_String_Dictionary_2_String_Int32_Func_3_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672492);
    CampaignStats.NativeMethodInfoPtr_Change_Private_Void_String_String_Int32_byref_Dictionary_2_String_Dictionary_2_String_Int32_Func_3_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672493);
    CampaignStats.NativeMethodInfoPtr_Add_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672494);
    CampaignStats.NativeMethodInfoPtr_Max_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672495);
    CampaignStats.NativeMethodInfoPtr_Get_Public_Dictionary_2_String_Int32_String_Dictionary_2_String_Dictionary_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672496);
    CampaignStats.NativeMethodInfoPtr_Get_Public_Dictionary_2_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672497);
    CampaignStats.NativeMethodInfoPtr_Get_Public_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672498);
    CampaignStats.NativeMethodInfoPtr_Get_Public_Int32_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672499);
    CampaignStats.NativeMethodInfoPtr_Best_Public_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672500);
    CampaignStats.NativeMethodInfoPtr_Best_Public_Int32_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672501);
    CampaignStats.NativeMethodInfoPtr_Count_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672502);
    CampaignStats.NativeMethodInfoPtr_Set_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672503);
    CampaignStats.NativeMethodInfoPtr_Set_Public_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672504);
    CampaignStats.NativeMethodInfoPtr_SetBest_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672505);
    CampaignStats.NativeMethodInfoPtr_SetBest_Public_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672506);
    CampaignStats.NativeMethodInfoPtr_Set_Private_Void_Dictionary_2_String_Dictionary_2_String_Int32_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672507);
    CampaignStats.NativeMethodInfoPtr_Delete_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672508);
    CampaignStats.NativeMethodInfoPtr_DeleteBest_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672509);
    CampaignStats.NativeMethodInfoPtr_Clone_Public_CampaignStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, 100672510);
  }

  public CampaignStats(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float time
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignStats.NativeFieldInfoPtr_time));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignStats.NativeFieldInfoPtr_time)) = value;
    }
  }

  public unsafe int hours
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignStats.NativeFieldInfoPtr_hours));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignStats.NativeFieldInfoPtr_hours)) = value;
    }
  }

  public unsafe Dictionary<string, Dictionary<string, int>> add
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignStats.NativeFieldInfoPtr_add));
      return pointer == System.IntPtr.Zero ? (Dictionary<string, Dictionary<string, int>>) null : new Dictionary<string, Dictionary<string, int>>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignStats.NativeFieldInfoPtr_add), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, Dictionary<string, int>> max
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignStats.NativeFieldInfoPtr_max));
      return pointer == System.IntPtr.Zero ? (Dictionary<string, Dictionary<string, int>>) null : new Dictionary<string, Dictionary<string, int>>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignStats.NativeFieldInfoPtr_max), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("CampaignStats/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__27_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__27_4;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__27_5;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__27_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__27_2;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__27_6;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__27_7;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__27_3;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Clone_b__27_0_Internal_String_KeyValuePair_2_String_Dictionary_2_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Clone_b__27_1_Internal_Dictionary_2_String_Int32_KeyValuePair_2_String_Dictionary_2_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Clone_b__27_4_Internal_String_KeyValuePair_2_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Clone_b__27_5_Internal_Int32_KeyValuePair_2_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Clone_b__27_2_Internal_String_KeyValuePair_2_String_Dictionary_2_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Clone_b__27_3_Internal_Dictionary_2_String_Int32_KeyValuePair_2_String_Dictionary_2_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Clone_b__27_6_Internal_String_KeyValuePair_2_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Clone_b__27_7_Internal_Int32_KeyValuePair_2_String_Int32_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignStats.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignStats.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102224, XrefRangeEnd = 102225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _Clone_b__27_0(KeyValuePair<string, Dictionary<string, int>> a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a))
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CampaignStats.__c.NativeMethodInfoPtr__Clone_b__27_0_Internal_String_KeyValuePair_2_String_Dictionary_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102225, XrefRangeEnd = 102259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Dictionary<string, int> _Clone_b__27_1(
      KeyValuePair<string, Dictionary<string, int>> a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a))
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignStats.__c.NativeMethodInfoPtr__Clone_b__27_1_Internal_Dictionary_2_String_Int32_KeyValuePair_2_String_Dictionary_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<string, int>) null : new Dictionary<string, int>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102259, XrefRangeEnd = 102260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _Clone_b__27_4(KeyValuePair<string, int> b)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) b))
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CampaignStats.__c.NativeMethodInfoPtr__Clone_b__27_4_Internal_String_KeyValuePair_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102260, XrefRangeEnd = 102261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int _Clone_b__27_5(KeyValuePair<string, int> b)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) b))
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignStats.__c.NativeMethodInfoPtr__Clone_b__27_5_Internal_Int32_KeyValuePair_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102261, XrefRangeEnd = 102262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _Clone_b__27_2(KeyValuePair<string, Dictionary<string, int>> a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a))
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CampaignStats.__c.NativeMethodInfoPtr__Clone_b__27_2_Internal_String_KeyValuePair_2_String_Dictionary_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102262, XrefRangeEnd = 102296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Dictionary<string, int> _Clone_b__27_3(
      KeyValuePair<string, Dictionary<string, int>> a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a))
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignStats.__c.NativeMethodInfoPtr__Clone_b__27_3_Internal_Dictionary_2_String_Int32_KeyValuePair_2_String_Dictionary_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<string, int>) null : new Dictionary<string, int>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102296, XrefRangeEnd = 102297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _Clone_b__27_6(KeyValuePair<string, int> b)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) b))
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CampaignStats.__c.NativeMethodInfoPtr__Clone_b__27_6_Internal_String_KeyValuePair_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102297, XrefRangeEnd = 102298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int _Clone_b__27_7(KeyValuePair<string, int> b)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) b))
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignStats.__c.NativeMethodInfoPtr__Clone_b__27_7_Internal_Int32_KeyValuePair_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<CampaignStats.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignStats>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignStats.__c>.NativeClassPtr);
      CampaignStats.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignStats.__c>.NativeClassPtr, "<>9");
      CampaignStats.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignStats.__c>.NativeClassPtr, "<>9__27_0");
      CampaignStats.__c.NativeFieldInfoPtr___9__27_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignStats.__c>.NativeClassPtr, "<>9__27_4");
      CampaignStats.__c.NativeFieldInfoPtr___9__27_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignStats.__c>.NativeClassPtr, "<>9__27_5");
      CampaignStats.__c.NativeFieldInfoPtr___9__27_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignStats.__c>.NativeClassPtr, "<>9__27_1");
      CampaignStats.__c.NativeFieldInfoPtr___9__27_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignStats.__c>.NativeClassPtr, "<>9__27_2");
      CampaignStats.__c.NativeFieldInfoPtr___9__27_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignStats.__c>.NativeClassPtr, "<>9__27_6");
      CampaignStats.__c.NativeFieldInfoPtr___9__27_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignStats.__c>.NativeClassPtr, "<>9__27_7");
      CampaignStats.__c.NativeFieldInfoPtr___9__27_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignStats.__c>.NativeClassPtr, "<>9__27_3");
      CampaignStats.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats.__c>.NativeClassPtr, 100672512);
      CampaignStats.__c.NativeMethodInfoPtr__Clone_b__27_0_Internal_String_KeyValuePair_2_String_Dictionary_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats.__c>.NativeClassPtr, 100672513);
      CampaignStats.__c.NativeMethodInfoPtr__Clone_b__27_1_Internal_Dictionary_2_String_Int32_KeyValuePair_2_String_Dictionary_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats.__c>.NativeClassPtr, 100672514);
      CampaignStats.__c.NativeMethodInfoPtr__Clone_b__27_4_Internal_String_KeyValuePair_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats.__c>.NativeClassPtr, 100672515);
      CampaignStats.__c.NativeMethodInfoPtr__Clone_b__27_5_Internal_Int32_KeyValuePair_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats.__c>.NativeClassPtr, 100672516);
      CampaignStats.__c.NativeMethodInfoPtr__Clone_b__27_2_Internal_String_KeyValuePair_2_String_Dictionary_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats.__c>.NativeClassPtr, 100672517);
      CampaignStats.__c.NativeMethodInfoPtr__Clone_b__27_3_Internal_Dictionary_2_String_Int32_KeyValuePair_2_String_Dictionary_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats.__c>.NativeClassPtr, 100672518);
      CampaignStats.__c.NativeMethodInfoPtr__Clone_b__27_6_Internal_String_KeyValuePair_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats.__c>.NativeClassPtr, 100672519);
      CampaignStats.__c.NativeMethodInfoPtr__Clone_b__27_7_Internal_Int32_KeyValuePair_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignStats.__c>.NativeClassPtr, 100672520);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe CampaignStats.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CampaignStats.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (CampaignStats.__c) null : new CampaignStats.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CampaignStats.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<KeyValuePair<string, Dictionary<string, int>>, string> __9__27_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CampaignStats.__c.NativeFieldInfoPtr___9__27_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair<string, Dictionary<string, int>>, string>) null : new Il2CppSystem.Func<KeyValuePair<string, Dictionary<string, int>>, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CampaignStats.__c.NativeFieldInfoPtr___9__27_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<KeyValuePair<string, int>, string> __9__27_4
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CampaignStats.__c.NativeFieldInfoPtr___9__27_4, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair<string, int>, string>) null : new Il2CppSystem.Func<KeyValuePair<string, int>, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CampaignStats.__c.NativeFieldInfoPtr___9__27_4, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<KeyValuePair<string, int>, int> __9__27_5
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CampaignStats.__c.NativeFieldInfoPtr___9__27_5, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair<string, int>, int>) null : new Il2CppSystem.Func<KeyValuePair<string, int>, int>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CampaignStats.__c.NativeFieldInfoPtr___9__27_5, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<KeyValuePair<string, Dictionary<string, int>>, Dictionary<string, int>> __9__27_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CampaignStats.__c.NativeFieldInfoPtr___9__27_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair<string, Dictionary<string, int>>, Dictionary<string, int>>) null : new Il2CppSystem.Func<KeyValuePair<string, Dictionary<string, int>>, Dictionary<string, int>>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CampaignStats.__c.NativeFieldInfoPtr___9__27_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<KeyValuePair<string, Dictionary<string, int>>, string> __9__27_2
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CampaignStats.__c.NativeFieldInfoPtr___9__27_2, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair<string, Dictionary<string, int>>, string>) null : new Il2CppSystem.Func<KeyValuePair<string, Dictionary<string, int>>, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CampaignStats.__c.NativeFieldInfoPtr___9__27_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<KeyValuePair<string, int>, string> __9__27_6
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CampaignStats.__c.NativeFieldInfoPtr___9__27_6, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair<string, int>, string>) null : new Il2CppSystem.Func<KeyValuePair<string, int>, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CampaignStats.__c.NativeFieldInfoPtr___9__27_6, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<KeyValuePair<string, int>, int> __9__27_7
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CampaignStats.__c.NativeFieldInfoPtr___9__27_7, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair<string, int>, int>) null : new Il2CppSystem.Func<KeyValuePair<string, int>, int>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CampaignStats.__c.NativeFieldInfoPtr___9__27_7, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<KeyValuePair<string, Dictionary<string, int>>, Dictionary<string, int>> __9__27_3
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CampaignStats.__c.NativeFieldInfoPtr___9__27_3, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair<string, Dictionary<string, int>>, Dictionary<string, int>>) null : new Il2CppSystem.Func<KeyValuePair<string, Dictionary<string, int>>, Dictionary<string, int>>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CampaignStats.__c.NativeFieldInfoPtr___9__27_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
