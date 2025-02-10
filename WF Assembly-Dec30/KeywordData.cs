// Decompiled with JetBrains decompiler
// Type: KeywordData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class KeywordData : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_titleKey;
  private static readonly IntPtr NativeFieldInfoPtr_descKey;
  private static readonly IntPtr NativeFieldInfoPtr_titleColour;
  private static readonly IntPtr NativeFieldInfoPtr_bodyColour;
  private static readonly IntPtr NativeFieldInfoPtr_noteColour;
  private static readonly IntPtr NativeFieldInfoPtr_panelSprite;
  private static readonly IntPtr NativeFieldInfoPtr_panelColor;
  private static readonly IntPtr NativeFieldInfoPtr_iconName;
  private static readonly IntPtr NativeFieldInfoPtr_iconTintHex;
  private static readonly IntPtr NativeFieldInfoPtr_show;
  private static readonly IntPtr NativeFieldInfoPtr_showName;
  private static readonly IntPtr NativeFieldInfoPtr_showIcon;
  private static readonly IntPtr NativeFieldInfoPtr_canStack;
  private static readonly IntPtr NativeMethodInfoPtr_get_HasTitle_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_title_Public_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_body_Public_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_note_Public_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe bool HasTitle
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 109714, RefRangeEnd = 109715, XrefRangeStart = 109713, XrefRangeEnd = 109714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(KeywordData.NativeMethodInfoPtr_get_HasTitle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe string title
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 81141, RefRangeEnd = 81143, XrefRangeStart = 81141, XrefRangeEnd = 81143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(KeywordData.NativeMethodInfoPtr_get_title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
  }

  public unsafe string body
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 109718, RefRangeEnd = 109722, XrefRangeStart = 109715, XrefRangeEnd = 109718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(KeywordData.NativeMethodInfoPtr_get_body_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
  }

  public unsafe string note
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 109725, RefRangeEnd = 109726, XrefRangeStart = 109722, XrefRangeEnd = 109725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(KeywordData.NativeMethodInfoPtr_get_note_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109726, XrefRangeEnd = 109727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe KeywordData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeywordData>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(KeywordData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static KeywordData()
  {
    Il2CppClassPointerStore<KeywordData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (KeywordData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeywordData>.NativeClassPtr);
    KeywordData.NativeFieldInfoPtr_titleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeywordData>.NativeClassPtr, nameof (titleKey));
    KeywordData.NativeFieldInfoPtr_descKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeywordData>.NativeClassPtr, nameof (descKey));
    KeywordData.NativeFieldInfoPtr_titleColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeywordData>.NativeClassPtr, nameof (titleColour));
    KeywordData.NativeFieldInfoPtr_bodyColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeywordData>.NativeClassPtr, nameof (bodyColour));
    KeywordData.NativeFieldInfoPtr_noteColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeywordData>.NativeClassPtr, nameof (noteColour));
    KeywordData.NativeFieldInfoPtr_panelSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeywordData>.NativeClassPtr, nameof (panelSprite));
    KeywordData.NativeFieldInfoPtr_panelColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeywordData>.NativeClassPtr, nameof (panelColor));
    KeywordData.NativeFieldInfoPtr_iconName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeywordData>.NativeClassPtr, nameof (iconName));
    KeywordData.NativeFieldInfoPtr_iconTintHex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeywordData>.NativeClassPtr, nameof (iconTintHex));
    KeywordData.NativeFieldInfoPtr_show = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeywordData>.NativeClassPtr, nameof (show));
    KeywordData.NativeFieldInfoPtr_showName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeywordData>.NativeClassPtr, nameof (showName));
    KeywordData.NativeFieldInfoPtr_showIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeywordData>.NativeClassPtr, nameof (showIcon));
    KeywordData.NativeFieldInfoPtr_canStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeywordData>.NativeClassPtr, nameof (canStack));
    KeywordData.NativeMethodInfoPtr_get_HasTitle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeywordData>.NativeClassPtr, 100673424);
    KeywordData.NativeMethodInfoPtr_get_title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeywordData>.NativeClassPtr, 100673425);
    KeywordData.NativeMethodInfoPtr_get_body_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeywordData>.NativeClassPtr, 100673426);
    KeywordData.NativeMethodInfoPtr_get_note_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeywordData>.NativeClassPtr, 100673427);
    KeywordData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeywordData>.NativeClassPtr, 100673428);
  }

  public KeywordData(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LocalizedString titleKey
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_titleKey));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_titleKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString descKey
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_descKey));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_descKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color titleColour
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_titleColour));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_titleColour)) = value;
    }
  }

  public unsafe Color bodyColour
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_bodyColour));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_bodyColour)) = value;
    }
  }

  public unsafe Color noteColour
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_noteColour));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_noteColour)) = value;
    }
  }

  public unsafe Sprite panelSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_panelSprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_panelSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color panelColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_panelColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_panelColor)) = value;
    }
  }

  public unsafe string iconName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_iconName)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_iconName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string iconTintHex
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_iconTintHex)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_iconTintHex), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool show
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_show));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_show)) = value;
    }
  }

  public unsafe bool showName
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_showName));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_showName)) = value;
    }
  }

  public unsafe bool showIcon
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_showIcon));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_showIcon)) = value;
    }
  }

  public unsafe bool canStack
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_canStack));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeywordData.NativeFieldInfoPtr_canStack)) = value;
    }
  }
}
