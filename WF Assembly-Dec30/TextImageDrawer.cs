// Decompiled with JetBrains decompiler
// Type: TextImageDrawer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class TextImageDrawer : TMP_Text
{
  private static readonly IntPtr NativeFieldInfoPtr_data;
  private static readonly IntPtr NativeFieldInfoPtr_images;
  private static readonly IntPtr NativeFieldInfoPtr__transform;
  private static readonly IntPtr NativeMethodInfoPtr_get_transform_Private_get_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_Virtual_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_Virtual_set_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_Virtual_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_Virtual_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_DrawText_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetColour_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public new unsafe Transform transform
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 83192, RefRangeEnd = 83193, XrefRangeStart = 83188, XrefRangeEnd = 83192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(TextImageDrawer.NativeMethodInfoPtr_get_transform_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
  }

  public override unsafe string text
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 83193, RefRangeEnd = 83194, XrefRangeStart = 83193, XrefRangeEnd = 83193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TextImageDrawer.NativeMethodInfoPtr_get_text_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83194, XrefRangeEnd = 83197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TextImageDrawer.NativeMethodInfoPtr_set_text_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public override unsafe Color color
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TextImageDrawer.NativeMethodInfoPtr_get_color_Public_Virtual_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83197, XrefRangeEnd = 83198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TextImageDrawer.NativeMethodInfoPtr_set_color_Public_Virtual_set_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83198, XrefRangeEnd = 83200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TextImageDrawer.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 83245, RefRangeEnd = 83247, XrefRangeStart = 83200, XrefRangeEnd = 83245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrawText()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TextImageDrawer.NativeMethodInfoPtr_DrawText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83247, XrefRangeEnd = 83248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetColour()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TextImageDrawer.NativeMethodInfoPtr_SetColour_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83248, XrefRangeEnd = 83262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TextImageDrawer.NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83262, XrefRangeEnd = 83266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TextImageDrawer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextImageDrawer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TextImageDrawer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TextImageDrawer()
  {
    Il2CppClassPointerStore<TextImageDrawer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TextImageDrawer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextImageDrawer>.NativeClassPtr);
    TextImageDrawer.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextImageDrawer>.NativeClassPtr, nameof (data));
    TextImageDrawer.NativeFieldInfoPtr_images = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextImageDrawer>.NativeClassPtr, nameof (images));
    TextImageDrawer.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextImageDrawer>.NativeClassPtr, nameof (_transform));
    TextImageDrawer.NativeMethodInfoPtr_get_transform_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextImageDrawer>.NativeClassPtr, 100670178);
    TextImageDrawer.NativeMethodInfoPtr_get_text_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextImageDrawer>.NativeClassPtr, 100670179);
    TextImageDrawer.NativeMethodInfoPtr_set_text_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextImageDrawer>.NativeClassPtr, 100670180);
    TextImageDrawer.NativeMethodInfoPtr_get_color_Public_Virtual_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextImageDrawer>.NativeClassPtr, 100670181);
    TextImageDrawer.NativeMethodInfoPtr_set_color_Public_Virtual_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextImageDrawer>.NativeClassPtr, 100670182);
    TextImageDrawer.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextImageDrawer>.NativeClassPtr, 100670183);
    TextImageDrawer.NativeMethodInfoPtr_DrawText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextImageDrawer>.NativeClassPtr, 100670184);
    TextImageDrawer.NativeMethodInfoPtr_SetColour_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextImageDrawer>.NativeClassPtr, 100670185);
    TextImageDrawer.NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextImageDrawer>.NativeClassPtr, 100670186);
    TextImageDrawer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextImageDrawer>.NativeClassPtr, 100670187);
  }

  public TextImageDrawer(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe TextImageData data
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextImageDrawer.NativeFieldInfoPtr_data));
      return pointer == IntPtr.Zero ? (TextImageData) null : new TextImageData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextImageDrawer.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Image> images
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextImageDrawer.NativeFieldInfoPtr_images));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Image>) null : new Il2CppReferenceArray<Image>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextImageDrawer.NativeFieldInfoPtr_images), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform _transform
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextImageDrawer.NativeFieldInfoPtr__transform));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextImageDrawer.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
