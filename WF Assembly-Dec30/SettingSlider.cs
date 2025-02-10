// Decompiled with JetBrains decompiler
// Type: SettingSlider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine.UI;

#nullable disable
public class SettingSlider : Setting<float>
{
  private static readonly IntPtr NativeFieldInfoPtr_slider;
  private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94978, XrefRangeEnd = 94979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void SetValue(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SettingSlider.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94979, XrefRangeEnd = 94982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SettingSlider()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingSlider>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SettingSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SettingSlider()
  {
    Il2CppClassPointerStore<SettingSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SettingSlider));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingSlider>.NativeClassPtr);
    SettingSlider.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingSlider>.NativeClassPtr, nameof (slider));
    SettingSlider.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingSlider>.NativeClassPtr, 100671542);
    SettingSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingSlider>.NativeClassPtr, 100671543);
  }

  public SettingSlider(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Slider slider
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SettingSlider.NativeFieldInfoPtr_slider));
      return pointer == IntPtr.Zero ? (Slider) null : new Slider(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SettingSlider.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
