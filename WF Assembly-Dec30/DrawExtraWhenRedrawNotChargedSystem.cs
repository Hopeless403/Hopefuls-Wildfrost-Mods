// Decompiled with JetBrains decompiler
// Type: DrawExtraWhenRedrawNotChargedSystem
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
public class DrawExtraWhenRedrawNotChargedSystem : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_extraDraw;
  private static readonly IntPtr NativeFieldInfoPtr__redrawBellSystem;
  private static readonly IntPtr NativeMethodInfoPtr_get_redrawBellSystem_Private_get_RedrawBellSystem_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetHandSize_Private_Void_byref_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe RedrawBellSystem redrawBellSystem
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65421, XrefRangeEnd = 65428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrawExtraWhenRedrawNotChargedSystem.NativeMethodInfoPtr_get_redrawBellSystem_Private_get_RedrawBellSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (RedrawBellSystem) null : new RedrawBellSystem(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65428, XrefRangeEnd = 65436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DrawExtraWhenRedrawNotChargedSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65436, XrefRangeEnd = 65444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DrawExtraWhenRedrawNotChargedSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65444, XrefRangeEnd = 65452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetHandSize(ref int handSize)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) ref handSize
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DrawExtraWhenRedrawNotChargedSystem.NativeMethodInfoPtr_GetHandSize_Private_Void_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DrawExtraWhenRedrawNotChargedSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawExtraWhenRedrawNotChargedSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DrawExtraWhenRedrawNotChargedSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static DrawExtraWhenRedrawNotChargedSystem()
  {
    Il2CppClassPointerStore<DrawExtraWhenRedrawNotChargedSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (DrawExtraWhenRedrawNotChargedSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawExtraWhenRedrawNotChargedSystem>.NativeClassPtr);
    DrawExtraWhenRedrawNotChargedSystem.NativeFieldInfoPtr_extraDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawExtraWhenRedrawNotChargedSystem>.NativeClassPtr, nameof (extraDraw));
    DrawExtraWhenRedrawNotChargedSystem.NativeFieldInfoPtr__redrawBellSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawExtraWhenRedrawNotChargedSystem>.NativeClassPtr, nameof (_redrawBellSystem));
    DrawExtraWhenRedrawNotChargedSystem.NativeMethodInfoPtr_get_redrawBellSystem_Private_get_RedrawBellSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawExtraWhenRedrawNotChargedSystem>.NativeClassPtr, 100668679);
    DrawExtraWhenRedrawNotChargedSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawExtraWhenRedrawNotChargedSystem>.NativeClassPtr, 100668680);
    DrawExtraWhenRedrawNotChargedSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawExtraWhenRedrawNotChargedSystem>.NativeClassPtr, 100668681);
    DrawExtraWhenRedrawNotChargedSystem.NativeMethodInfoPtr_GetHandSize_Private_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawExtraWhenRedrawNotChargedSystem>.NativeClassPtr, 100668682);
    DrawExtraWhenRedrawNotChargedSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawExtraWhenRedrawNotChargedSystem>.NativeClassPtr, 100668683);
  }

  public DrawExtraWhenRedrawNotChargedSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe int extraDraw
  {
    get
    {
      int extraDraw;
      IL2CPP.il2cpp_field_static_get_value(DrawExtraWhenRedrawNotChargedSystem.NativeFieldInfoPtr_extraDraw, (void*) &extraDraw);
      return extraDraw;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DrawExtraWhenRedrawNotChargedSystem.NativeFieldInfoPtr_extraDraw, (void*) &value);
    }
  }

  public unsafe RedrawBellSystem _redrawBellSystem
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawExtraWhenRedrawNotChargedSystem.NativeFieldInfoPtr__redrawBellSystem));
      return pointer == IntPtr.Zero ? (RedrawBellSystem) null : new RedrawBellSystem(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DrawExtraWhenRedrawNotChargedSystem.NativeFieldInfoPtr__redrawBellSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
