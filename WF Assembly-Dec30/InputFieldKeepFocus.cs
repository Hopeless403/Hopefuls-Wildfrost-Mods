// Decompiled with JetBrains decompiler
// Type: InputFieldKeepFocus
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
using UnityEngine.EventSystems;

#nullable disable
public class InputFieldKeepFocus : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr__i;
  private static readonly IntPtr NativeFieldInfoPtr__e;
  private static readonly IntPtr NativeFieldInfoPtr_focused;
  private static readonly IntPtr NativeMethodInfoPtr_get_i_Private_get_TMP_InputField_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_e_Private_get_PointerEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe TMP_InputField i
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 90511, RefRangeEnd = 90512, XrefRangeStart = 90507, XrefRangeEnd = 90511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputFieldKeepFocus.NativeMethodInfoPtr_get_i_Private_get_TMP_InputField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
    }
  }

  public unsafe PointerEventData e
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90512, XrefRangeEnd = 90521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputFieldKeepFocus.NativeMethodInfoPtr_get_e_Private_get_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (PointerEventData) null : new PointerEventData(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90521, XrefRangeEnd = 90549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InputFieldKeepFocus.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 53209, RefRangeEnd = 53213, XrefRangeStart = 53209, XrefRangeEnd = 53213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InputFieldKeepFocus.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InputFieldKeepFocus()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputFieldKeepFocus>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InputFieldKeepFocus.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static InputFieldKeepFocus()
  {
    Il2CppClassPointerStore<InputFieldKeepFocus>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (InputFieldKeepFocus));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputFieldKeepFocus>.NativeClassPtr);
    InputFieldKeepFocus.NativeFieldInfoPtr__i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldKeepFocus>.NativeClassPtr, nameof (_i));
    InputFieldKeepFocus.NativeFieldInfoPtr__e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldKeepFocus>.NativeClassPtr, nameof (_e));
    InputFieldKeepFocus.NativeFieldInfoPtr_focused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldKeepFocus>.NativeClassPtr, nameof (focused));
    InputFieldKeepFocus.NativeMethodInfoPtr_get_i_Private_get_TMP_InputField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldKeepFocus>.NativeClassPtr, 100671070);
    InputFieldKeepFocus.NativeMethodInfoPtr_get_e_Private_get_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldKeepFocus>.NativeClassPtr, 100671071);
    InputFieldKeepFocus.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldKeepFocus>.NativeClassPtr, 100671072);
    InputFieldKeepFocus.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldKeepFocus>.NativeClassPtr, 100671073);
    InputFieldKeepFocus.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldKeepFocus>.NativeClassPtr, 100671074);
  }

  public InputFieldKeepFocus(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe TMP_InputField _i
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputFieldKeepFocus.NativeFieldInfoPtr__i));
      return pointer == IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputFieldKeepFocus.NativeFieldInfoPtr__i), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PointerEventData _e
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputFieldKeepFocus.NativeFieldInfoPtr__e));
      return pointer == IntPtr.Zero ? (PointerEventData) null : new PointerEventData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputFieldKeepFocus.NativeFieldInfoPtr__e), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool focused
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputFieldKeepFocus.NativeFieldInfoPtr_focused));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputFieldKeepFocus.NativeFieldInfoPtr_focused)) = value;
    }
  }
}
