// Decompiled with JetBrains decompiler
// Type: JournalCharm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class JournalCharm : MonoBehaviourRect
{
  private static readonly IntPtr NativeFieldInfoPtr_popUpOffset;
  private static readonly IntPtr NativeFieldInfoPtr_image;
  private static readonly IntPtr NativeFieldInfoPtr_discoveredMaterial;
  private static readonly IntPtr NativeFieldInfoPtr_upgradeData;
  private static readonly IntPtr NativeFieldInfoPtr_discovered;
  private static readonly IntPtr NativeFieldInfoPtr_hover;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Assign_Public_Void_CardUpgradeData_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckDiscovered_Public_Void_List_1_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetDiscovered_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Hover_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnHover_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91083, XrefRangeEnd = 91085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCharm.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91085, XrefRangeEnd = 91088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Assign(CardUpgradeData upgradeData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgradeData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCharm.NativeMethodInfoPtr_Assign_Public_Void_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91088, XrefRangeEnd = 91093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckDiscovered(List<string> discoveredCharms)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) discoveredCharms)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCharm.NativeMethodInfoPtr_CheckDiscovered_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 91093, RefRangeEnd = 91095, XrefRangeStart = 91093, XrefRangeEnd = 91093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetDiscovered()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCharm.NativeMethodInfoPtr_SetDiscovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91095, XrefRangeEnd = 91101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hover()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCharm.NativeMethodInfoPtr_Hover_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnHover()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCharm.NativeMethodInfoPtr_UnHover_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91101, XrefRangeEnd = 91102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JournalCharm()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalCharm>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCharm.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static JournalCharm()
  {
    Il2CppClassPointerStore<JournalCharm>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (JournalCharm));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalCharm>.NativeClassPtr);
    JournalCharm.NativeFieldInfoPtr_popUpOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCharm>.NativeClassPtr, nameof (popUpOffset));
    JournalCharm.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCharm>.NativeClassPtr, nameof (image));
    JournalCharm.NativeFieldInfoPtr_discoveredMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCharm>.NativeClassPtr, nameof (discoveredMaterial));
    JournalCharm.NativeFieldInfoPtr_upgradeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCharm>.NativeClassPtr, nameof (upgradeData));
    JournalCharm.NativeFieldInfoPtr_discovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCharm>.NativeClassPtr, nameof (discovered));
    JournalCharm.NativeFieldInfoPtr_hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCharm>.NativeClassPtr, nameof (hover));
    JournalCharm.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCharm>.NativeClassPtr, 100671125);
    JournalCharm.NativeMethodInfoPtr_Assign_Public_Void_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCharm>.NativeClassPtr, 100671126);
    JournalCharm.NativeMethodInfoPtr_CheckDiscovered_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCharm>.NativeClassPtr, 100671127);
    JournalCharm.NativeMethodInfoPtr_SetDiscovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCharm>.NativeClassPtr, 100671128);
    JournalCharm.NativeMethodInfoPtr_Hover_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCharm>.NativeClassPtr, 100671129);
    JournalCharm.NativeMethodInfoPtr_UnHover_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCharm>.NativeClassPtr, 100671130);
    JournalCharm.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCharm>.NativeClassPtr, 100671131);
  }

  public JournalCharm(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Vector2 popUpOffset
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCharm.NativeFieldInfoPtr_popUpOffset));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCharm.NativeFieldInfoPtr_popUpOffset)) = value;
    }
  }

  public unsafe Image image
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCharm.NativeFieldInfoPtr_image));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCharm.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material discoveredMaterial
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCharm.NativeFieldInfoPtr_discoveredMaterial));
      return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCharm.NativeFieldInfoPtr_discoveredMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardUpgradeData upgradeData
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCharm.NativeFieldInfoPtr_upgradeData));
      return pointer == IntPtr.Zero ? (CardUpgradeData) null : new CardUpgradeData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCharm.NativeFieldInfoPtr_upgradeData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool discovered
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCharm.NativeFieldInfoPtr_discovered));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCharm.NativeFieldInfoPtr_discovered)) = value;
    }
  }

  public unsafe bool hover
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCharm.NativeFieldInfoPtr_hover));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCharm.NativeFieldInfoPtr_hover)) = value;
    }
  }
}
