// Decompiled with JetBrains decompiler
// Type: TownHallFlagSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class TownHallFlagSetter : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_flags;
  private static readonly IntPtr NativeMethodInfoPtr_SetupFlags_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85559, XrefRangeEnd = 85578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupFlags()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TownHallFlagSetter.NativeMethodInfoPtr_SetupFlags_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TownHallFlagSetter()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TownHallFlagSetter>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TownHallFlagSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TownHallFlagSetter()
  {
    Il2CppClassPointerStore<TownHallFlagSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TownHallFlagSetter));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TownHallFlagSetter>.NativeClassPtr);
    TownHallFlagSetter.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TownHallFlagSetter>.NativeClassPtr, nameof (flags));
    TownHallFlagSetter.NativeMethodInfoPtr_SetupFlags_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TownHallFlagSetter>.NativeClassPtr, 100670447);
    TownHallFlagSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TownHallFlagSetter>.NativeClassPtr, 100670448);
  }

  public TownHallFlagSetter(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<GameObject> flags
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TownHallFlagSetter.NativeFieldInfoPtr_flags));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : new Il2CppReferenceArray<GameObject>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TownHallFlagSetter.NativeFieldInfoPtr_flags), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
