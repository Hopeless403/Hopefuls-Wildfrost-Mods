// Decompiled with JetBrains decompiler
// Type: TextMeshFitter
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

#nullable disable
public class TextMeshFitter : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr__textElement;
  private static readonly IntPtr NativeFieldInfoPtr__rectTransform;
  private static readonly IntPtr NativeFieldInfoPtr_parentSprite;
  private static readonly IntPtr NativeFieldInfoPtr_autoUpdate;
  private static readonly IntPtr NativeFieldInfoPtr_minSize;
  private static readonly IntPtr NativeFieldInfoPtr_dirty;
  private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_textElement_Private_get_TMP_Text_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Run_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ForceUpdate_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe string text
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95580, XrefRangeEnd = 95585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TextMeshFitter.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95585, XrefRangeEnd = 95589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TextMeshFitter.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe TMP_Text textElement
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 95593, RefRangeEnd = 95594, XrefRangeStart = 95589, XrefRangeEnd = 95593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(TextMeshFitter.NativeMethodInfoPtr_get_textElement_Private_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
  }

  public unsafe RectTransform rectTransform
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95594, XrefRangeEnd = 95598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(TextMeshFitter.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95598, XrefRangeEnd = 95600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TextMeshFitter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 95627, RefRangeEnd = 95629, XrefRangeStart = 95600, XrefRangeEnd = 95627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Run()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TextMeshFitter.NativeMethodInfoPtr_Run_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95629, XrefRangeEnd = 95630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ForceUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TextMeshFitter.NativeMethodInfoPtr_ForceUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95630, XrefRangeEnd = 95631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TextMeshFitter()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextMeshFitter>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TextMeshFitter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TextMeshFitter()
  {
    Il2CppClassPointerStore<TextMeshFitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TextMeshFitter));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextMeshFitter>.NativeClassPtr);
    TextMeshFitter.NativeFieldInfoPtr__textElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshFitter>.NativeClassPtr, nameof (_textElement));
    TextMeshFitter.NativeFieldInfoPtr__rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshFitter>.NativeClassPtr, nameof (_rectTransform));
    TextMeshFitter.NativeFieldInfoPtr_parentSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshFitter>.NativeClassPtr, nameof (parentSprite));
    TextMeshFitter.NativeFieldInfoPtr_autoUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshFitter>.NativeClassPtr, nameof (autoUpdate));
    TextMeshFitter.NativeFieldInfoPtr_minSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshFitter>.NativeClassPtr, nameof (minSize));
    TextMeshFitter.NativeFieldInfoPtr_dirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshFitter>.NativeClassPtr, nameof (dirty));
    TextMeshFitter.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshFitter>.NativeClassPtr, 100671620);
    TextMeshFitter.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshFitter>.NativeClassPtr, 100671621);
    TextMeshFitter.NativeMethodInfoPtr_get_textElement_Private_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshFitter>.NativeClassPtr, 100671622);
    TextMeshFitter.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshFitter>.NativeClassPtr, 100671623);
    TextMeshFitter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshFitter>.NativeClassPtr, 100671624);
    TextMeshFitter.NativeMethodInfoPtr_Run_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshFitter>.NativeClassPtr, 100671625);
    TextMeshFitter.NativeMethodInfoPtr_ForceUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshFitter>.NativeClassPtr, 100671626);
    TextMeshFitter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshFitter>.NativeClassPtr, 100671627);
  }

  public TextMeshFitter(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe TMP_Text _textElement
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextMeshFitter.NativeFieldInfoPtr__textElement));
      return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextMeshFitter.NativeFieldInfoPtr__textElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform _rectTransform
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextMeshFitter.NativeFieldInfoPtr__rectTransform));
      return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextMeshFitter.NativeFieldInfoPtr__rectTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SpriteRenderer parentSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextMeshFitter.NativeFieldInfoPtr_parentSprite));
      return pointer == IntPtr.Zero ? (SpriteRenderer) null : new SpriteRenderer(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextMeshFitter.NativeFieldInfoPtr_parentSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool autoUpdate
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextMeshFitter.NativeFieldInfoPtr_autoUpdate));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextMeshFitter.NativeFieldInfoPtr_autoUpdate)) = value;
    }
  }

  public unsafe Vector2 minSize
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextMeshFitter.NativeFieldInfoPtr_minSize));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextMeshFitter.NativeFieldInfoPtr_minSize)) = value;
    }
  }

  public unsafe bool dirty
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextMeshFitter.NativeFieldInfoPtr_dirty));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextMeshFitter.NativeFieldInfoPtr_dirty)) = value;
    }
  }
}
