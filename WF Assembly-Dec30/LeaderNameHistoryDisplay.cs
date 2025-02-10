// Decompiled with JetBrains decompiler
// Type: LeaderNameHistoryDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class LeaderNameHistoryDisplay : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_namePrefab;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Populate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddName_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Repopulate_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91473, XrefRangeEnd = 91474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderNameHistoryDisplay.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91474, XrefRangeEnd = 91476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderNameHistoryDisplay.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 91508, RefRangeEnd = 91511, XrefRangeStart = 91476, XrefRangeEnd = 91508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Populate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderNameHistoryDisplay.NativeMethodInfoPtr_Populate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91511, XrefRangeEnd = 91532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddName()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderNameHistoryDisplay.NativeMethodInfoPtr_AddName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91532, XrefRangeEnd = 91535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Repopulate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderNameHistoryDisplay.NativeMethodInfoPtr_Repopulate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LeaderNameHistoryDisplay()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderNameHistoryDisplay>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderNameHistoryDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LeaderNameHistoryDisplay()
  {
    Il2CppClassPointerStore<LeaderNameHistoryDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LeaderNameHistoryDisplay));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderNameHistoryDisplay>.NativeClassPtr);
    LeaderNameHistoryDisplay.NativeFieldInfoPtr_namePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderNameHistoryDisplay>.NativeClassPtr, nameof (namePrefab));
    LeaderNameHistoryDisplay.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderNameHistoryDisplay>.NativeClassPtr, 100671170);
    LeaderNameHistoryDisplay.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderNameHistoryDisplay>.NativeClassPtr, 100671171);
    LeaderNameHistoryDisplay.NativeMethodInfoPtr_Populate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderNameHistoryDisplay>.NativeClassPtr, 100671172);
    LeaderNameHistoryDisplay.NativeMethodInfoPtr_AddName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderNameHistoryDisplay>.NativeClassPtr, 100671173);
    LeaderNameHistoryDisplay.NativeMethodInfoPtr_Repopulate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderNameHistoryDisplay>.NativeClassPtr, 100671174);
    LeaderNameHistoryDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderNameHistoryDisplay>.NativeClassPtr, 100671175);
  }

  public LeaderNameHistoryDisplay(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LeaderNameHistoryEntry namePrefab
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderNameHistoryDisplay.NativeFieldInfoPtr_namePrefab));
      return pointer == IntPtr.Zero ? (LeaderNameHistoryEntry) null : new LeaderNameHistoryEntry(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderNameHistoryDisplay.NativeFieldInfoPtr_namePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
