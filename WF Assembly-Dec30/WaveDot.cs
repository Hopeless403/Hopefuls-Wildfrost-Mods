// Decompiled with JetBrains decompiler
// Type: WaveDot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class WaveDot : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_onImage;
  private static readonly IntPtr NativeFieldInfoPtr_offImage;
  private static readonly IntPtr NativeMethodInfoPtr_TurnOn_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_TurnOff_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101286, XrefRangeEnd = 101289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TurnOn()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDot.NativeMethodInfoPtr_TurnOn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 101292, RefRangeEnd = 101294, XrefRangeStart = 101289, XrefRangeEnd = 101292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TurnOff()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDot.NativeMethodInfoPtr_TurnOff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WaveDot()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaveDot>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static WaveDot()
  {
    Il2CppClassPointerStore<WaveDot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (WaveDot));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaveDot>.NativeClassPtr);
    WaveDot.NativeFieldInfoPtr_onImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDot>.NativeClassPtr, nameof (onImage));
    WaveDot.NativeFieldInfoPtr_offImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDot>.NativeClassPtr, nameof (offImage));
    WaveDot.NativeMethodInfoPtr_TurnOn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDot>.NativeClassPtr, 100672372);
    WaveDot.NativeMethodInfoPtr_TurnOff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDot>.NativeClassPtr, 100672373);
    WaveDot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDot>.NativeClassPtr, 100672374);
  }

  public WaveDot(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Image onImage
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDot.NativeFieldInfoPtr_onImage));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDot.NativeFieldInfoPtr_onImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image offImage
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDot.NativeFieldInfoPtr_offImage));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDot.NativeFieldInfoPtr_offImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
