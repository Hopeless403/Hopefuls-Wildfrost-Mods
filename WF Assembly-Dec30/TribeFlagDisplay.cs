// Decompiled with JetBrains decompiler
// Type: TribeFlagDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
public class TribeFlagDisplay : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_flagImage;
  private static readonly IntPtr NativeFieldInfoPtr_flagSprite;
  private static readonly IntPtr NativeFieldInfoPtr_locked;
  private static readonly IntPtr NativeFieldInfoPtr_button;
  private static readonly IntPtr NativeFieldInfoPtr_inputAction;
  private static readonly IntPtr NativeMethodInfoPtr_SetFlagSprite_Public_Void_Sprite_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddPressAction_Public_Void_UnityAction_0;
  private static readonly IntPtr NativeMethodInfoPtr_ClearPressActions_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetUnlocked_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetAvailable_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 96046, RefRangeEnd = 96048, XrefRangeStart = 96043, XrefRangeEnd = 96046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetFlagSprite(Sprite sprite)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TribeFlagDisplay.NativeMethodInfoPtr_SetFlagSprite_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 96050, RefRangeEnd = 96052, XrefRangeStart = 96048, XrefRangeEnd = 96050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddPressAction(UnityAction action)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TribeFlagDisplay.NativeMethodInfoPtr_AddPressAction_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 96054, RefRangeEnd = 96055, XrefRangeStart = 96052, XrefRangeEnd = 96054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearPressActions()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TribeFlagDisplay.NativeMethodInfoPtr_ClearPressActions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 96057, RefRangeEnd = 96058, XrefRangeStart = 96055, XrefRangeEnd = 96057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetInteractable(bool interactable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &interactable
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TribeFlagDisplay.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 96061, RefRangeEnd = 96063, XrefRangeStart = 96058, XrefRangeEnd = 96061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetUnlocked()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TribeFlagDisplay.NativeMethodInfoPtr_SetUnlocked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 96065, RefRangeEnd = 96067, XrefRangeStart = 96063, XrefRangeEnd = 96065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetAvailable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TribeFlagDisplay.NativeMethodInfoPtr_SetAvailable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TribeFlagDisplay()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TribeFlagDisplay>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TribeFlagDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TribeFlagDisplay()
  {
    Il2CppClassPointerStore<TribeFlagDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TribeFlagDisplay));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TribeFlagDisplay>.NativeClassPtr);
    TribeFlagDisplay.NativeFieldInfoPtr_flagImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TribeFlagDisplay>.NativeClassPtr, nameof (flagImage));
    TribeFlagDisplay.NativeFieldInfoPtr_flagSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TribeFlagDisplay>.NativeClassPtr, nameof (flagSprite));
    TribeFlagDisplay.NativeFieldInfoPtr_locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TribeFlagDisplay>.NativeClassPtr, nameof (locked));
    TribeFlagDisplay.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TribeFlagDisplay>.NativeClassPtr, nameof (button));
    TribeFlagDisplay.NativeFieldInfoPtr_inputAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TribeFlagDisplay>.NativeClassPtr, nameof (inputAction));
    TribeFlagDisplay.NativeMethodInfoPtr_SetFlagSprite_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TribeFlagDisplay>.NativeClassPtr, 100671669);
    TribeFlagDisplay.NativeMethodInfoPtr_AddPressAction_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TribeFlagDisplay>.NativeClassPtr, 100671670);
    TribeFlagDisplay.NativeMethodInfoPtr_ClearPressActions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TribeFlagDisplay>.NativeClassPtr, 100671671);
    TribeFlagDisplay.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TribeFlagDisplay>.NativeClassPtr, 100671672);
    TribeFlagDisplay.NativeMethodInfoPtr_SetUnlocked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TribeFlagDisplay>.NativeClassPtr, 100671673);
    TribeFlagDisplay.NativeMethodInfoPtr_SetAvailable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TribeFlagDisplay>.NativeClassPtr, 100671674);
    TribeFlagDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TribeFlagDisplay>.NativeClassPtr, 100671675);
  }

  public TribeFlagDisplay(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Image flagImage
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TribeFlagDisplay.NativeFieldInfoPtr_flagImage));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TribeFlagDisplay.NativeFieldInfoPtr_flagImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite flagSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TribeFlagDisplay.NativeFieldInfoPtr_flagSprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TribeFlagDisplay.NativeFieldInfoPtr_flagSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject locked
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TribeFlagDisplay.NativeFieldInfoPtr_locked));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TribeFlagDisplay.NativeFieldInfoPtr_locked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ButtonAnimator button
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TribeFlagDisplay.NativeFieldInfoPtr_button));
      return pointer == IntPtr.Zero ? (ButtonAnimator) null : new ButtonAnimator(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TribeFlagDisplay.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe InputAction inputAction
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TribeFlagDisplay.NativeFieldInfoPtr_inputAction));
      return pointer == IntPtr.Zero ? (InputAction) null : new InputAction(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TribeFlagDisplay.NativeFieldInfoPtr_inputAction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
