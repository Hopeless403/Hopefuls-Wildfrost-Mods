// Decompiled with JetBrains decompiler
// Type: LayoutLink
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
public class LayoutLink : MonoBehaviourRect
{
  private static readonly IntPtr NativeFieldInfoPtr_link;
  private static readonly IntPtr NativeFieldInfoPtr_lerp;
  private static readonly IntPtr NativeFieldInfoPtr_setPositionOnEnable;
  private static readonly IntPtr NativeFieldInfoPtr_offset;
  private static readonly IntPtr NativeFieldInfoPtr_layoutElement;
  private static readonly IntPtr NativeFieldInfoPtr_setLayoutWidth;
  private static readonly IntPtr NativeFieldInfoPtr_setLayoutHeight;
  private static readonly IntPtr NativeMethodInfoPtr_get_HasLayoutElement_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe bool HasLayoutElement
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92043, XrefRangeEnd = 92047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(LayoutLink.NativeMethodInfoPtr_get_HasLayoutElement_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92047, XrefRangeEnd = 92054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LayoutLink.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92054, XrefRangeEnd = 92064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LayoutLink.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92064, XrefRangeEnd = 92070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LayoutLink.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92070, XrefRangeEnd = 92071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LayoutLink()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutLink>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LayoutLink.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LayoutLink()
  {
    Il2CppClassPointerStore<LayoutLink>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LayoutLink));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutLink>.NativeClassPtr);
    LayoutLink.NativeFieldInfoPtr_link = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutLink>.NativeClassPtr, nameof (link));
    LayoutLink.NativeFieldInfoPtr_lerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutLink>.NativeClassPtr, nameof (lerp));
    LayoutLink.NativeFieldInfoPtr_setPositionOnEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutLink>.NativeClassPtr, nameof (setPositionOnEnable));
    LayoutLink.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutLink>.NativeClassPtr, nameof (offset));
    LayoutLink.NativeFieldInfoPtr_layoutElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutLink>.NativeClassPtr, nameof (layoutElement));
    LayoutLink.NativeFieldInfoPtr_setLayoutWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutLink>.NativeClassPtr, nameof (setLayoutWidth));
    LayoutLink.NativeFieldInfoPtr_setLayoutHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutLink>.NativeClassPtr, nameof (setLayoutHeight));
    LayoutLink.NativeMethodInfoPtr_get_HasLayoutElement_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutLink>.NativeClassPtr, 100671225);
    LayoutLink.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutLink>.NativeClassPtr, 100671226);
    LayoutLink.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutLink>.NativeClassPtr, 100671227);
    LayoutLink.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutLink>.NativeClassPtr, 100671228);
    LayoutLink.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutLink>.NativeClassPtr, 100671229);
  }

  public LayoutLink(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe RectTransform link
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LayoutLink.NativeFieldInfoPtr_link));
      return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LayoutLink.NativeFieldInfoPtr_link), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float lerp
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LayoutLink.NativeFieldInfoPtr_lerp));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LayoutLink.NativeFieldInfoPtr_lerp)) = value;
    }
  }

  public unsafe bool setPositionOnEnable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LayoutLink.NativeFieldInfoPtr_setPositionOnEnable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LayoutLink.NativeFieldInfoPtr_setPositionOnEnable)) = value;
    }
  }

  public unsafe Vector3 offset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LayoutLink.NativeFieldInfoPtr_offset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LayoutLink.NativeFieldInfoPtr_offset)) = value;
    }
  }

  public unsafe LayoutElement layoutElement
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LayoutLink.NativeFieldInfoPtr_layoutElement));
      return pointer == IntPtr.Zero ? (LayoutElement) null : new LayoutElement(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LayoutLink.NativeFieldInfoPtr_layoutElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool setLayoutWidth
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LayoutLink.NativeFieldInfoPtr_setLayoutWidth));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LayoutLink.NativeFieldInfoPtr_setLayoutWidth)) = value;
    }
  }

  public unsafe bool setLayoutHeight
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LayoutLink.NativeFieldInfoPtr_setLayoutHeight));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LayoutLink.NativeFieldInfoPtr_setLayoutHeight)) = value;
    }
  }
}
