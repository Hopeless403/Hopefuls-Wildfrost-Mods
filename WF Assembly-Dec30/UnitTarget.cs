// Decompiled with JetBrains decompiler
// Type: UnitTarget
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
public class UnitTarget : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_aimlessOverlay;
  private static readonly IntPtr NativeFieldInfoPtr_frenzyUnderlay;
  private static readonly IntPtr NativeMethodInfoPtr_SetAimless_Public_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetFrenzy_Public_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76862, XrefRangeEnd = 76864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetAimless(bool aimless)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &aimless
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UnitTarget.NativeMethodInfoPtr_SetAimless_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76864, XrefRangeEnd = 76867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetFrenzy(bool frenzy)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &frenzy
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UnitTarget.NativeMethodInfoPtr_SetFrenzy_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnitTarget()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitTarget>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UnitTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static UnitTarget()
  {
    Il2CppClassPointerStore<UnitTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (UnitTarget));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitTarget>.NativeClassPtr);
    UnitTarget.NativeFieldInfoPtr_aimlessOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitTarget>.NativeClassPtr, nameof (aimlessOverlay));
    UnitTarget.NativeFieldInfoPtr_frenzyUnderlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitTarget>.NativeClassPtr, nameof (frenzyUnderlay));
    UnitTarget.NativeMethodInfoPtr_SetAimless_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitTarget>.NativeClassPtr, 100669481);
    UnitTarget.NativeMethodInfoPtr_SetFrenzy_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitTarget>.NativeClassPtr, 100669482);
    UnitTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitTarget>.NativeClassPtr, 100669483);
  }

  public UnitTarget(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe GameObject aimlessOverlay
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitTarget.NativeFieldInfoPtr_aimlessOverlay));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitTarget.NativeFieldInfoPtr_aimlessOverlay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject frenzyUnderlay
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitTarget.NativeFieldInfoPtr_frenzyUnderlay));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitTarget.NativeFieldInfoPtr_frenzyUnderlay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
