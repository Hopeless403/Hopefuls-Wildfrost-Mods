// Decompiled with JetBrains decompiler
// Type: CardPocketInteraction
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

#nullable disable
public class CardPocketInteraction : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_nav;
  private static readonly IntPtr NativeFieldInfoPtr_root;
  private static readonly IntPtr NativeFieldInfoPtr_onClick;
  private static readonly IntPtr NativeFieldInfoPtr_onPress;
  private static readonly IntPtr NativeFieldInfoPtr_onRelease;
  private static readonly IntPtr NativeFieldInfoPtr_onHover;
  private static readonly IntPtr NativeFieldInfoPtr_onUnHover;
  private static readonly IntPtr NativeFieldInfoPtr_interactable;
  private static readonly IntPtr NativeFieldInfoPtr_defaultAnimations;
  private static readonly IntPtr NativeFieldInfoPtr_hover;
  private static readonly IntPtr NativeFieldInfoPtr_hovered;
  private static readonly IntPtr NativeFieldInfoPtr_press;
  private static readonly IntPtr NativeFieldInfoPtr_pressed;
  private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsInteractable_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Hover_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnHover_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Press_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  public unsafe void SetInteractable(bool value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPocketInteraction.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public unsafe bool IsInteractable
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 87142, RefRangeEnd = 87146, XrefRangeStart = 87141, XrefRangeEnd = 87142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardPocketInteraction.NativeMethodInfoPtr_get_IsInteractable_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87146, XrefRangeEnd = 87206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPocketInteraction.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 87207, RefRangeEnd = 87208, XrefRangeStart = 87206, XrefRangeEnd = 87207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hover()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPocketInteraction.NativeMethodInfoPtr_Hover_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 87208, RefRangeEnd = 87209, XrefRangeStart = 87208, XrefRangeEnd = 87208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnHover()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPocketInteraction.NativeMethodInfoPtr_UnHover_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87209, XrefRangeEnd = 87210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Press()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPocketInteraction.NativeMethodInfoPtr_Press_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPocketInteraction.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87210, XrefRangeEnd = 87211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardPocketInteraction()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPocketInteraction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardPocketInteraction()
  {
    Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardPocketInteraction));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr);
    CardPocketInteraction.NativeFieldInfoPtr_nav = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr, nameof (nav));
    CardPocketInteraction.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr, nameof (root));
    CardPocketInteraction.NativeFieldInfoPtr_onClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr, nameof (onClick));
    CardPocketInteraction.NativeFieldInfoPtr_onPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr, nameof (onPress));
    CardPocketInteraction.NativeFieldInfoPtr_onRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr, nameof (onRelease));
    CardPocketInteraction.NativeFieldInfoPtr_onHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr, nameof (onHover));
    CardPocketInteraction.NativeFieldInfoPtr_onUnHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr, nameof (onUnHover));
    CardPocketInteraction.NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr, nameof (interactable));
    CardPocketInteraction.NativeFieldInfoPtr_defaultAnimations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr, nameof (defaultAnimations));
    CardPocketInteraction.NativeFieldInfoPtr_hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr, nameof (hover));
    CardPocketInteraction.NativeFieldInfoPtr_hovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr, nameof (hovered));
    CardPocketInteraction.NativeFieldInfoPtr_press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr, nameof (press));
    CardPocketInteraction.NativeFieldInfoPtr_pressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr, nameof (pressed));
    CardPocketInteraction.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr, 100670666);
    CardPocketInteraction.NativeMethodInfoPtr_get_IsInteractable_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr, 100670667);
    CardPocketInteraction.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr, 100670668);
    CardPocketInteraction.NativeMethodInfoPtr_Hover_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr, 100670669);
    CardPocketInteraction.NativeMethodInfoPtr_UnHover_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr, 100670670);
    CardPocketInteraction.NativeMethodInfoPtr_Press_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr, 100670671);
    CardPocketInteraction.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr, 100670672);
    CardPocketInteraction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocketInteraction>.NativeClassPtr, 100670673);
  }

  public CardPocketInteraction(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe UINavigationItem nav
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_nav));
      return pointer == IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_nav), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject root
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_root));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent onClick
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_onClick));
      return pointer == IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_onClick), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent onPress
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_onPress));
      return pointer == IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_onPress), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent onRelease
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_onRelease));
      return pointer == IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_onRelease), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent onHover
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_onHover));
      return pointer == IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_onHover), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent onUnHover
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_onUnHover));
      return pointer == IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_onUnHover), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool interactable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_interactable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_interactable)) = value;
    }
  }

  public unsafe bool defaultAnimations
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_defaultAnimations));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_defaultAnimations)) = value;
    }
  }

  public unsafe bool hover
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_hover));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_hover)) = value;
    }
  }

  public unsafe bool hovered
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_hovered));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_hovered)) = value;
    }
  }

  public unsafe bool press
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_press));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_press)) = value;
    }
  }

  public unsafe bool pressed
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_pressed));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocketInteraction.NativeFieldInfoPtr_pressed)) = value;
    }
  }
}
