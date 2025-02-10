// Decompiled with JetBrains decompiler
// Type: ButtonAnimator
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
using UnityEngine.UI;

#nullable disable
public class ButtonAnimator : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_type;
  private static readonly IntPtr NativeFieldInfoPtr_button;
  private static readonly IntPtr NativeFieldInfoPtr_nav;
  private static readonly IntPtr NativeFieldInfoPtr_hover;
  private static readonly IntPtr NativeFieldInfoPtr_press;
  private static readonly IntPtr NativeFieldInfoPtr_tween;
  private static readonly IntPtr NativeFieldInfoPtr_text;
  private static readonly IntPtr NativeFieldInfoPtr_textNormalColour;
  private static readonly IntPtr NativeFieldInfoPtr_textCopyBase;
  private static readonly IntPtr NativeFieldInfoPtr_textHighlightColour;
  private static readonly IntPtr NativeFieldInfoPtr_strikeTextWhenDisabled;
  private static readonly IntPtr NativeFieldInfoPtr_textDisabledColour;
  private static readonly IntPtr NativeFieldInfoPtr_image;
  private static readonly IntPtr NativeFieldInfoPtr_baseColourSet;
  private static readonly IntPtr NativeFieldInfoPtr_baseColour;
  private static readonly IntPtr NativeFieldInfoPtr_highlightColour;
  private static readonly IntPtr NativeFieldInfoPtr_disabledColour;
  private static readonly IntPtr NativeFieldInfoPtr_setPressColour;
  private static readonly IntPtr NativeFieldInfoPtr_pressColour;
  private static readonly IntPtr NativeFieldInfoPtr_hoverTween;
  private static readonly IntPtr NativeFieldInfoPtr_unHoverTween;
  private static readonly IntPtr NativeFieldInfoPtr_pressTween;
  private static readonly IntPtr NativeFieldInfoPtr_releaseTween;
  private static readonly IntPtr NativeMethodInfoPtr_get_interactable_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_interactable_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsHoveredOrPressed_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Hover_Public_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnHover_Public_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnHoverInstant_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Press_Public_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_StopCurrentAnimation_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckSetBaseColour_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Highlight_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnHighlight_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Disable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe bool interactable
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ButtonAnimator.NativeMethodInfoPtr_get_interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(29), CachedScanResults(RefRangeStart = 86945, RefRangeEnd = 86974, XrefRangeStart = 86932, XrefRangeEnd = 86945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ButtonAnimator.NativeMethodInfoPtr_set_interactable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe bool IsHoveredOrPressed
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 86974, RefRangeEnd = 86976, XrefRangeStart = 86974, XrefRangeEnd = 86974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ButtonAnimator.NativeMethodInfoPtr_get_IsHoveredOrPressed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86976, XrefRangeEnd = 86978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ButtonAnimator.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86978, XrefRangeEnd = 86988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ButtonAnimator.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86988, XrefRangeEnd = 86992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Hover()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ButtonAnimator.NativeMethodInfoPtr_Hover_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86992, XrefRangeEnd = 86999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void UnHover()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ButtonAnimator.NativeMethodInfoPtr_UnHover_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86999, XrefRangeEnd = 87009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnHoverInstant()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ButtonAnimator.NativeMethodInfoPtr_UnHoverInstant_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87009, XrefRangeEnd = 87018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Press()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ButtonAnimator.NativeMethodInfoPtr_Press_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87018, XrefRangeEnd = 87029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ButtonAnimator.NativeMethodInfoPtr_Release_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 87034, RefRangeEnd = 87035, XrefRangeStart = 87029, XrefRangeEnd = 87034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopCurrentAnimation()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ButtonAnimator.NativeMethodInfoPtr_StopCurrentAnimation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void CheckSetBaseColour()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ButtonAnimator.NativeMethodInfoPtr_CheckSetBaseColour_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 87043, RefRangeEnd = 87045, XrefRangeStart = 87035, XrefRangeEnd = 87043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Highlight()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ButtonAnimator.NativeMethodInfoPtr_Highlight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 87052, RefRangeEnd = 87059, XrefRangeStart = 87045, XrefRangeEnd = 87052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnHighlight()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ButtonAnimator.NativeMethodInfoPtr_UnHighlight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 87068, RefRangeEnd = 87070, XrefRangeStart = 87059, XrefRangeEnd = 87068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Disable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ButtonAnimator.NativeMethodInfoPtr_Disable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87070, XrefRangeEnd = 87071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ButtonAnimator()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ButtonAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ButtonAnimator()
  {
    Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ButtonAnimator));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr);
    ButtonAnimator.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, nameof (type));
    ButtonAnimator.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, nameof (button));
    ButtonAnimator.NativeFieldInfoPtr_nav = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, nameof (nav));
    ButtonAnimator.NativeFieldInfoPtr_hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, nameof (hover));
    ButtonAnimator.NativeFieldInfoPtr_press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, nameof (press));
    ButtonAnimator.NativeFieldInfoPtr_tween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, nameof (tween));
    ButtonAnimator.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, nameof (text));
    ButtonAnimator.NativeFieldInfoPtr_textNormalColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, nameof (textNormalColour));
    ButtonAnimator.NativeFieldInfoPtr_textCopyBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, nameof (textCopyBase));
    ButtonAnimator.NativeFieldInfoPtr_textHighlightColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, nameof (textHighlightColour));
    ButtonAnimator.NativeFieldInfoPtr_strikeTextWhenDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, nameof (strikeTextWhenDisabled));
    ButtonAnimator.NativeFieldInfoPtr_textDisabledColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, nameof (textDisabledColour));
    ButtonAnimator.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, nameof (image));
    ButtonAnimator.NativeFieldInfoPtr_baseColourSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, nameof (baseColourSet));
    ButtonAnimator.NativeFieldInfoPtr_baseColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, nameof (baseColour));
    ButtonAnimator.NativeFieldInfoPtr_highlightColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, nameof (highlightColour));
    ButtonAnimator.NativeFieldInfoPtr_disabledColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, nameof (disabledColour));
    ButtonAnimator.NativeFieldInfoPtr_setPressColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, nameof (setPressColour));
    ButtonAnimator.NativeFieldInfoPtr_pressColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, nameof (pressColour));
    ButtonAnimator.NativeFieldInfoPtr_hoverTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, nameof (hoverTween));
    ButtonAnimator.NativeFieldInfoPtr_unHoverTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, nameof (unHoverTween));
    ButtonAnimator.NativeFieldInfoPtr_pressTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, nameof (pressTween));
    ButtonAnimator.NativeFieldInfoPtr_releaseTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, nameof (releaseTween));
    ButtonAnimator.NativeMethodInfoPtr_get_interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, 100670631);
    ButtonAnimator.NativeMethodInfoPtr_set_interactable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, 100670632);
    ButtonAnimator.NativeMethodInfoPtr_get_IsHoveredOrPressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, 100670633);
    ButtonAnimator.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, 100670634);
    ButtonAnimator.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, 100670635);
    ButtonAnimator.NativeMethodInfoPtr_Hover_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, 100670636);
    ButtonAnimator.NativeMethodInfoPtr_UnHover_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, 100670637);
    ButtonAnimator.NativeMethodInfoPtr_UnHoverInstant_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, 100670638);
    ButtonAnimator.NativeMethodInfoPtr_Press_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, 100670639);
    ButtonAnimator.NativeMethodInfoPtr_Release_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, 100670640);
    ButtonAnimator.NativeMethodInfoPtr_StopCurrentAnimation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, 100670641);
    ButtonAnimator.NativeMethodInfoPtr_CheckSetBaseColour_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, 100670642);
    ButtonAnimator.NativeMethodInfoPtr_Highlight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, 100670643);
    ButtonAnimator.NativeMethodInfoPtr_UnHighlight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, 100670644);
    ButtonAnimator.NativeMethodInfoPtr_Disable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, 100670645);
    ButtonAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonAnimator>.NativeClassPtr, 100670646);
  }

  public ButtonAnimator(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe ButtonType type
  {
    get
    {
      return *(ButtonType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_type));
    }
    [param: In] set
    {
      *(ButtonType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_type)) = value;
    }
  }

  public unsafe Selectable button
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_button));
      return pointer == IntPtr.Zero ? (Selectable) null : new Selectable(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UINavigationItem nav
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_nav));
      return pointer == IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_nav), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool hover
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_hover));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_hover)) = value;
    }
  }

  public unsafe bool press
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_press));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_press)) = value;
    }
  }

  public unsafe LTDescr tween
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_tween));
      return pointer == IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_tween), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text text
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_text));
      return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color textNormalColour
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_textNormalColour));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_textNormalColour)) = value;
    }
  }

  public unsafe bool textCopyBase
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_textCopyBase));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_textCopyBase)) = value;
    }
  }

  public unsafe Color textHighlightColour
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_textHighlightColour));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_textHighlightColour)) = value;
    }
  }

  public unsafe bool strikeTextWhenDisabled
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_strikeTextWhenDisabled));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_strikeTextWhenDisabled)) = value;
    }
  }

  public unsafe Color textDisabledColour
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_textDisabledColour));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_textDisabledColour)) = value;
    }
  }

  public unsafe Image image
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_image));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool baseColourSet
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_baseColourSet));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_baseColourSet)) = value;
    }
  }

  public unsafe Color baseColour
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_baseColour));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_baseColour)) = value;
    }
  }

  public unsafe Color highlightColour
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_highlightColour));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_highlightColour)) = value;
    }
  }

  public unsafe Color disabledColour
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_disabledColour));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_disabledColour)) = value;
    }
  }

  public unsafe bool setPressColour
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_setPressColour));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_setPressColour)) = value;
    }
  }

  public unsafe Color pressColour
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_pressColour));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_pressColour)) = value;
    }
  }

  public unsafe TweenUI hoverTween
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_hoverTween));
      return pointer == IntPtr.Zero ? (TweenUI) null : new TweenUI(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_hoverTween), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TweenUI unHoverTween
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_unHoverTween));
      return pointer == IntPtr.Zero ? (TweenUI) null : new TweenUI(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_unHoverTween), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TweenUI pressTween
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_pressTween));
      return pointer == IntPtr.Zero ? (TweenUI) null : new TweenUI(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_pressTween), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TweenUI releaseTween
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_releaseTween));
      return pointer == IntPtr.Zero ? (TweenUI) null : new TweenUI(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ButtonAnimator.NativeFieldInfoPtr_releaseTween), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
