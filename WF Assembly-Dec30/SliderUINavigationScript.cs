// Decompiled with JetBrains decompiler
// Type: SliderUINavigationScript
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
public class SliderUINavigationScript : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_valueMultiplier;
  private static readonly IntPtr NativeFieldInfoPtr_slider;
  private static readonly IntPtr NativeFieldInfoPtr_sfx;
  private static readonly IntPtr NativeMethodInfoPtr_OnChangeSliderValue_Public_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17390, XrefRangeEnd = 17395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnChangeSliderValue(float inValueChange)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &inValueChange
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SliderUINavigationScript.NativeMethodInfoPtr_OnChangeSliderValue_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17395, XrefRangeEnd = 17396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SliderUINavigationScript()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SliderUINavigationScript>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SliderUINavigationScript.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SliderUINavigationScript()
  {
    Il2CppClassPointerStore<SliderUINavigationScript>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SliderUINavigationScript));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SliderUINavigationScript>.NativeClassPtr);
    SliderUINavigationScript.NativeFieldInfoPtr_valueMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderUINavigationScript>.NativeClassPtr, nameof (valueMultiplier));
    SliderUINavigationScript.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderUINavigationScript>.NativeClassPtr, nameof (slider));
    SliderUINavigationScript.NativeFieldInfoPtr_sfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderUINavigationScript>.NativeClassPtr, nameof (sfx));
    SliderUINavigationScript.NativeMethodInfoPtr_OnChangeSliderValue_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderUINavigationScript>.NativeClassPtr, 100663474);
    SliderUINavigationScript.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderUINavigationScript>.NativeClassPtr, 100663475);
  }

  public SliderUINavigationScript(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float valueMultiplier
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SliderUINavigationScript.NativeFieldInfoPtr_valueMultiplier));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SliderUINavigationScript.NativeFieldInfoPtr_valueMultiplier)) = value;
    }
  }

  public unsafe Slider slider
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SliderUINavigationScript.NativeFieldInfoPtr_slider));
      return pointer == IntPtr.Zero ? (Slider) null : new Slider(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SliderUINavigationScript.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SliderSfx sfx
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SliderUINavigationScript.NativeFieldInfoPtr_sfx));
      return pointer == IntPtr.Zero ? (SliderSfx) null : new SliderSfx(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SliderUINavigationScript.NativeFieldInfoPtr_sfx), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
