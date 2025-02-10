// Decompiled with JetBrains decompiler
// Type: TitleSetter
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
using UnityEngine.Localization.Components;
using UnityEngine.UI;

#nullable disable
public class TitleSetter : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_gameObject;
  private static readonly IntPtr NativeFieldInfoPtr_text;
  private static readonly IntPtr NativeFieldInfoPtr_underline;
  private static readonly IntPtr NativeFieldInfoPtr_setActive;
  private static readonly IntPtr NativeFieldInfoPtr_setKey;
  private static readonly IntPtr NativeFieldInfoPtr_setUnderlineSprite;
  private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 95670, RefRangeEnd = 95673, XrefRangeStart = 95667, XrefRangeEnd = 95670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TitleSetter.NativeMethodInfoPtr_Set_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95673, XrefRangeEnd = 95674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TitleSetter()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TitleSetter>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TitleSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TitleSetter()
  {
    Il2CppClassPointerStore<TitleSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TitleSetter));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TitleSetter>.NativeClassPtr);
    TitleSetter.NativeFieldInfoPtr_gameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleSetter>.NativeClassPtr, nameof (gameObject));
    TitleSetter.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleSetter>.NativeClassPtr, nameof (text));
    TitleSetter.NativeFieldInfoPtr_underline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleSetter>.NativeClassPtr, nameof (underline));
    TitleSetter.NativeFieldInfoPtr_setActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleSetter>.NativeClassPtr, nameof (setActive));
    TitleSetter.NativeFieldInfoPtr_setKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleSetter>.NativeClassPtr, nameof (setKey));
    TitleSetter.NativeFieldInfoPtr_setUnderlineSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleSetter>.NativeClassPtr, nameof (setUnderlineSprite));
    TitleSetter.NativeMethodInfoPtr_Set_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleSetter>.NativeClassPtr, 100671642);
    TitleSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleSetter>.NativeClassPtr, 100671643);
  }

  public TitleSetter(IntPtr pointer)
    : base(pointer)
  {
  }

  public new unsafe GameObject gameObject
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TitleSetter.NativeFieldInfoPtr_gameObject));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TitleSetter.NativeFieldInfoPtr_gameObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizeStringEvent text
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TitleSetter.NativeFieldInfoPtr_text));
      return pointer == IntPtr.Zero ? (LocalizeStringEvent) null : new LocalizeStringEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TitleSetter.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image underline
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TitleSetter.NativeFieldInfoPtr_underline));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TitleSetter.NativeFieldInfoPtr_underline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool setActive
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TitleSetter.NativeFieldInfoPtr_setActive));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TitleSetter.NativeFieldInfoPtr_setActive)) = value;
    }
  }

  public unsafe LocalizedString setKey
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TitleSetter.NativeFieldInfoPtr_setKey));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TitleSetter.NativeFieldInfoPtr_setKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite setUnderlineSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TitleSetter.NativeFieldInfoPtr_setUnderlineSprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TitleSetter.NativeFieldInfoPtr_setUnderlineSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
