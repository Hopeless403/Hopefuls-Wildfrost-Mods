// Decompiled with JetBrains decompiler
// Type: OverallStatsDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
public class OverallStatsDisplay : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_stats;
  private static readonly IntPtr NativeFieldInfoPtr_statsPerGroup;
  private static readonly IntPtr NativeFieldInfoPtr_nameGroups;
  private static readonly IntPtr NativeFieldInfoPtr_valueGroups;
  private static readonly IntPtr NativeFieldInfoPtr_lineHeight;
  private static readonly IntPtr NativeFieldInfoPtr_localesCentred;
  private static readonly IntPtr NativeFieldInfoPtr_centred;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Populate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91748, XrefRangeEnd = 91760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(OverallStatsDisplay.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91891, RefRangeEnd = 91892, XrefRangeStart = 91760, XrefRangeEnd = 91891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Populate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(OverallStatsDisplay.NativeMethodInfoPtr_Populate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91911, RefRangeEnd = 91912, XrefRangeStart = 91892, XrefRangeEnd = 91911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(OverallStatsDisplay.NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91912, XrefRangeEnd = 91913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe OverallStatsDisplay()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverallStatsDisplay>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(OverallStatsDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static OverallStatsDisplay()
  {
    Il2CppClassPointerStore<OverallStatsDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (OverallStatsDisplay));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverallStatsDisplay>.NativeClassPtr);
    OverallStatsDisplay.NativeFieldInfoPtr_stats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverallStatsDisplay>.NativeClassPtr, nameof (stats));
    OverallStatsDisplay.NativeFieldInfoPtr_statsPerGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverallStatsDisplay>.NativeClassPtr, nameof (statsPerGroup));
    OverallStatsDisplay.NativeFieldInfoPtr_nameGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverallStatsDisplay>.NativeClassPtr, nameof (nameGroups));
    OverallStatsDisplay.NativeFieldInfoPtr_valueGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverallStatsDisplay>.NativeClassPtr, nameof (valueGroups));
    OverallStatsDisplay.NativeFieldInfoPtr_lineHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverallStatsDisplay>.NativeClassPtr, nameof (lineHeight));
    OverallStatsDisplay.NativeFieldInfoPtr_localesCentred = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverallStatsDisplay>.NativeClassPtr, nameof (localesCentred));
    OverallStatsDisplay.NativeFieldInfoPtr_centred = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverallStatsDisplay>.NativeClassPtr, nameof (centred));
    OverallStatsDisplay.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverallStatsDisplay>.NativeClassPtr, 100671189);
    OverallStatsDisplay.NativeMethodInfoPtr_Populate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverallStatsDisplay>.NativeClassPtr, 100671190);
    OverallStatsDisplay.NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverallStatsDisplay>.NativeClassPtr, 100671191);
    OverallStatsDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverallStatsDisplay>.NativeClassPtr, 100671192);
  }

  public OverallStatsDisplay(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<GameStatData> stats
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverallStatsDisplay.NativeFieldInfoPtr_stats));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<GameStatData>) null : new Il2CppReferenceArray<GameStatData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OverallStatsDisplay.NativeFieldInfoPtr_stats), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int statsPerGroup
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverallStatsDisplay.NativeFieldInfoPtr_statsPerGroup));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverallStatsDisplay.NativeFieldInfoPtr_statsPerGroup)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<TMP_Text> nameGroups
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverallStatsDisplay.NativeFieldInfoPtr_nameGroups));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<TMP_Text>) null : new Il2CppReferenceArray<TMP_Text>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OverallStatsDisplay.NativeFieldInfoPtr_nameGroups), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<TMP_Text> valueGroups
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverallStatsDisplay.NativeFieldInfoPtr_valueGroups));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<TMP_Text>) null : new Il2CppReferenceArray<TMP_Text>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OverallStatsDisplay.NativeFieldInfoPtr_valueGroups), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float lineHeight
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverallStatsDisplay.NativeFieldInfoPtr_lineHeight));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverallStatsDisplay.NativeFieldInfoPtr_lineHeight)) = value;
    }
  }

  public static unsafe Dictionary<string, bool> localesCentred
  {
    get
    {
      IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(OverallStatsDisplay.NativeFieldInfoPtr_localesCentred, (void*) &num);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Dictionary<string, bool>) null : new Dictionary<string, bool>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(OverallStatsDisplay.NativeFieldInfoPtr_localesCentred, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe bool centred
  {
    get
    {
      bool centred;
      IL2CPP.il2cpp_field_static_get_value(OverallStatsDisplay.NativeFieldInfoPtr_centred, (void*) &centred);
      return centred;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(OverallStatsDisplay.NativeFieldInfoPtr_centred, (void*) &value);
    }
  }
}
