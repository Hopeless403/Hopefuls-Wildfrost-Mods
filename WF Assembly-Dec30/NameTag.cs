// Decompiled with JetBrains decompiler
// Type: NameTag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class NameTag : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_styles;
  private static readonly IntPtr NativeFieldInfoPtr_currentStyle;
  private static readonly IntPtr NativeFieldInfoPtr_styleDictionary;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetStyle_Public_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94296, XrefRangeEnd = 94305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NameTag.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94305, XrefRangeEnd = 94317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetStyle(string styleName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(styleName)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NameTag.NativeMethodInfoPtr_SetStyle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94317, XrefRangeEnd = 94326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NameTag()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameTag>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NameTag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static NameTag()
  {
    Il2CppClassPointerStore<NameTag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (NameTag));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameTag>.NativeClassPtr);
    NameTag.NativeFieldInfoPtr_styles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTag>.NativeClassPtr, nameof (styles));
    NameTag.NativeFieldInfoPtr_currentStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTag>.NativeClassPtr, nameof (currentStyle));
    NameTag.NativeFieldInfoPtr_styleDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTag>.NativeClassPtr, nameof (styleDictionary));
    NameTag.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTag>.NativeClassPtr, 100671416);
    NameTag.NativeMethodInfoPtr_SetStyle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTag>.NativeClassPtr, 100671417);
    NameTag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTag>.NativeClassPtr, 100671418);
  }

  public NameTag(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<NameTagStyle> styles
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NameTag.NativeFieldInfoPtr_styles));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<NameTagStyle>) null : new Il2CppReferenceArray<NameTagStyle>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NameTag.NativeFieldInfoPtr_styles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe NameTagStyle currentStyle
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NameTag.NativeFieldInfoPtr_currentStyle));
      return pointer == IntPtr.Zero ? (NameTagStyle) null : new NameTagStyle(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NameTag.NativeFieldInfoPtr_currentStyle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, NameTagStyle> styleDictionary
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NameTag.NativeFieldInfoPtr_styleDictionary));
      return pointer == IntPtr.Zero ? (Dictionary<string, NameTagStyle>) null : new Dictionary<string, NameTagStyle>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NameTag.NativeFieldInfoPtr_styleDictionary), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
