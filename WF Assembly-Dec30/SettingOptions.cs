// Decompiled with JetBrains decompiler
// Type: SettingOptions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class SettingOptions : Setting<int>
{
  private static readonly IntPtr NativeFieldInfoPtr_dropdown;
  private static readonly IntPtr NativeFieldInfoPtr_tweener;
  private static readonly IntPtr NativeFieldInfoPtr_tweenCurve;
  private static readonly IntPtr NativeFieldInfoPtr_tweenDur;
  private static readonly IntPtr NativeFieldInfoPtr_onValueChanged;
  private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Increase_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Decrease_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Tween_Private_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94946, XrefRangeEnd = 94951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void SetValue(int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SettingOptions.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94951, XrefRangeEnd = 94955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Add(float single)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &single
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SettingOptions.NativeMethodInfoPtr_Add_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94955, XrefRangeEnd = 94959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Increase()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SettingOptions.NativeMethodInfoPtr_Increase_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94959, XrefRangeEnd = 94963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Decrease()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SettingOptions.NativeMethodInfoPtr_Decrease_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 94972, RefRangeEnd = 94975, XrefRangeStart = 94963, XrefRangeEnd = 94972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Tween(int dir)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &dir
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SettingOptions.NativeMethodInfoPtr_Tween_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94975, XrefRangeEnd = 94978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SettingOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingOptions>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SettingOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SettingOptions()
  {
    Il2CppClassPointerStore<SettingOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SettingOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingOptions>.NativeClassPtr);
    SettingOptions.NativeFieldInfoPtr_dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingOptions>.NativeClassPtr, nameof (dropdown));
    SettingOptions.NativeFieldInfoPtr_tweener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingOptions>.NativeClassPtr, nameof (tweener));
    SettingOptions.NativeFieldInfoPtr_tweenCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingOptions>.NativeClassPtr, nameof (tweenCurve));
    SettingOptions.NativeFieldInfoPtr_tweenDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingOptions>.NativeClassPtr, nameof (tweenDur));
    SettingOptions.NativeFieldInfoPtr_onValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingOptions>.NativeClassPtr, nameof (onValueChanged));
    SettingOptions.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingOptions>.NativeClassPtr, 100671536);
    SettingOptions.NativeMethodInfoPtr_Add_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingOptions>.NativeClassPtr, 100671537);
    SettingOptions.NativeMethodInfoPtr_Increase_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingOptions>.NativeClassPtr, 100671538);
    SettingOptions.NativeMethodInfoPtr_Decrease_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingOptions>.NativeClassPtr, 100671539);
    SettingOptions.NativeMethodInfoPtr_Tween_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingOptions>.NativeClassPtr, 100671540);
    SettingOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingOptions>.NativeClassPtr, 100671541);
  }

  public SettingOptions(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe TMP_Dropdown dropdown
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SettingOptions.NativeFieldInfoPtr_dropdown));
      return pointer == IntPtr.Zero ? (TMP_Dropdown) null : new TMP_Dropdown(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SettingOptions.NativeFieldInfoPtr_dropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject tweener
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SettingOptions.NativeFieldInfoPtr_tweener));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SettingOptions.NativeFieldInfoPtr_tweener), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve tweenCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SettingOptions.NativeFieldInfoPtr_tweenCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SettingOptions.NativeFieldInfoPtr_tweenCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float tweenDur
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SettingOptions.NativeFieldInfoPtr_tweenDur));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SettingOptions.NativeFieldInfoPtr_tweenDur)) = value;
    }
  }

  public unsafe UnityEvent<int> onValueChanged
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SettingOptions.NativeFieldInfoPtr_onValueChanged));
      return pointer == IntPtr.Zero ? (UnityEvent<int>) null : new UnityEvent<int>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SettingOptions.NativeFieldInfoPtr_onValueChanged), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
