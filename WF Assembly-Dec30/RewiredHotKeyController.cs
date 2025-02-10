// Decompiled with JetBrains decompiler
// Type: RewiredHotKeyController
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
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
public class RewiredHotKeyController : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_HotKeyString;
  private static readonly IntPtr NativeFieldInfoPtr_uINavigationLayer;
  private static readonly IntPtr NativeFieldInfoPtr_uiButton;
  private static readonly IntPtr NativeFieldInfoPtr_eventTrigger;
  private static readonly IntPtr NativeFieldInfoPtr_OnHotKeyPressed;
  private static readonly IntPtr NativeFieldInfoPtr_ignoreLayers;
  private static readonly IntPtr NativeFieldInfoPtr_ignoreActivateCooldown;
  private static readonly IntPtr NativeFieldInfoPtr_display;
  private static readonly IntPtr NativeFieldInfoPtr_hasKeyboardInput;
  private static readonly IntPtr NativeFieldInfoPtr_keyboardAction;
  private static readonly IntPtr NativeFieldInfoPtr_press;
  private static readonly IntPtr NativeFieldInfoPtr_ActivateCooldown;
  private static readonly IntPtr NativeFieldInfoPtr_ActivateCooldownInstance;
  private static readonly IntPtr NativeMethodInfoPtr_IsHotKeyHeld_Private_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_IsHotKeyPressed_Private_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetActionName_Public_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Press_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Invoke_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17319, XrefRangeEnd = 17324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsHotKeyHeld()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredHotKeyController.NativeMethodInfoPtr_IsHotKeyHeld_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17324, XrefRangeEnd = 17329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsHotKeyPressed()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredHotKeyController.NativeMethodInfoPtr_IsHotKeyPressed_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 17335, RefRangeEnd = 17336, XrefRangeStart = 17329, XrefRangeEnd = 17335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetActionName(string value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(value)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RewiredHotKeyController.NativeMethodInfoPtr_SetActionName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17336, XrefRangeEnd = 17359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RewiredHotKeyController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17359, XrefRangeEnd = 17369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RewiredHotKeyController.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17369, XrefRangeEnd = 17374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Press()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RewiredHotKeyController.NativeMethodInfoPtr_Press_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 17386, RefRangeEnd = 17387, XrefRangeStart = 17374, XrefRangeEnd = 17386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RewiredHotKeyController.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17387, XrefRangeEnd = 17390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Invoke()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RewiredHotKeyController.NativeMethodInfoPtr_Invoke_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RewiredHotKeyController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RewiredHotKeyController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static RewiredHotKeyController()
  {
    Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (RewiredHotKeyController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr);
    RewiredHotKeyController.NativeFieldInfoPtr_HotKeyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr, nameof (HotKeyString));
    RewiredHotKeyController.NativeFieldInfoPtr_uINavigationLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr, nameof (uINavigationLayer));
    RewiredHotKeyController.NativeFieldInfoPtr_uiButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr, nameof (uiButton));
    RewiredHotKeyController.NativeFieldInfoPtr_eventTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr, nameof (eventTrigger));
    RewiredHotKeyController.NativeFieldInfoPtr_OnHotKeyPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr, nameof (OnHotKeyPressed));
    RewiredHotKeyController.NativeFieldInfoPtr_ignoreLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr, nameof (ignoreLayers));
    RewiredHotKeyController.NativeFieldInfoPtr_ignoreActivateCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr, nameof (ignoreActivateCooldown));
    RewiredHotKeyController.NativeFieldInfoPtr_display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr, nameof (display));
    RewiredHotKeyController.NativeFieldInfoPtr_hasKeyboardInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr, nameof (hasKeyboardInput));
    RewiredHotKeyController.NativeFieldInfoPtr_keyboardAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr, nameof (keyboardAction));
    RewiredHotKeyController.NativeFieldInfoPtr_press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr, nameof (press));
    RewiredHotKeyController.NativeFieldInfoPtr_ActivateCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr, nameof (ActivateCooldown));
    RewiredHotKeyController.NativeFieldInfoPtr_ActivateCooldownInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr, nameof (ActivateCooldownInstance));
    RewiredHotKeyController.NativeMethodInfoPtr_IsHotKeyHeld_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr, 100663465);
    RewiredHotKeyController.NativeMethodInfoPtr_IsHotKeyPressed_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr, 100663466);
    RewiredHotKeyController.NativeMethodInfoPtr_SetActionName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr, 100663467);
    RewiredHotKeyController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr, 100663468);
    RewiredHotKeyController.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr, 100663469);
    RewiredHotKeyController.NativeMethodInfoPtr_Press_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr, 100663470);
    RewiredHotKeyController.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr, 100663471);
    RewiredHotKeyController.NativeMethodInfoPtr_Invoke_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr, 100663472);
    RewiredHotKeyController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredHotKeyController>.NativeClassPtr, 100663473);
  }

  public RewiredHotKeyController(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string HotKeyString
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredHotKeyController.NativeFieldInfoPtr_HotKeyString)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredHotKeyController.NativeFieldInfoPtr_HotKeyString), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe UINavigationLayer uINavigationLayer
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredHotKeyController.NativeFieldInfoPtr_uINavigationLayer));
      return pointer == IntPtr.Zero ? (UINavigationLayer) null : new UINavigationLayer(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredHotKeyController.NativeFieldInfoPtr_uINavigationLayer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button uiButton
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredHotKeyController.NativeFieldInfoPtr_uiButton));
      return pointer == IntPtr.Zero ? (Button) null : new Button(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredHotKeyController.NativeFieldInfoPtr_uiButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventTrigger eventTrigger
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredHotKeyController.NativeFieldInfoPtr_eventTrigger));
      return pointer == IntPtr.Zero ? (EventTrigger) null : new EventTrigger(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredHotKeyController.NativeFieldInfoPtr_eventTrigger), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent OnHotKeyPressed
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredHotKeyController.NativeFieldInfoPtr_OnHotKeyPressed));
      return pointer == IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredHotKeyController.NativeFieldInfoPtr_OnHotKeyPressed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool ignoreLayers
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredHotKeyController.NativeFieldInfoPtr_ignoreLayers));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredHotKeyController.NativeFieldInfoPtr_ignoreLayers)) = value;
    }
  }

  public unsafe bool ignoreActivateCooldown
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredHotKeyController.NativeFieldInfoPtr_ignoreActivateCooldown));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredHotKeyController.NativeFieldInfoPtr_ignoreActivateCooldown)) = value;
    }
  }

  public unsafe HotKeyDisplay display
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredHotKeyController.NativeFieldInfoPtr_display));
      return pointer == IntPtr.Zero ? (HotKeyDisplay) null : new HotKeyDisplay(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredHotKeyController.NativeFieldInfoPtr_display), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool hasKeyboardInput
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredHotKeyController.NativeFieldInfoPtr_hasKeyboardInput));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredHotKeyController.NativeFieldInfoPtr_hasKeyboardInput)) = value;
    }
  }

  public unsafe KeyCode keyboardAction
  {
    get
    {
      return *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredHotKeyController.NativeFieldInfoPtr_keyboardAction));
    }
    [param: In] set
    {
      *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredHotKeyController.NativeFieldInfoPtr_keyboardAction)) = value;
    }
  }

  public unsafe bool press
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredHotKeyController.NativeFieldInfoPtr_press));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredHotKeyController.NativeFieldInfoPtr_press)) = value;
    }
  }

  public static unsafe int ActivateCooldown
  {
    get
    {
      int activateCooldown;
      IL2CPP.il2cpp_field_static_get_value(RewiredHotKeyController.NativeFieldInfoPtr_ActivateCooldown, (void*) &activateCooldown);
      return activateCooldown;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RewiredHotKeyController.NativeFieldInfoPtr_ActivateCooldown, (void*) &value);
    }
  }

  public static unsafe RewiredHotKeyController ActivateCooldownInstance
  {
    get
    {
      IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(RewiredHotKeyController.NativeFieldInfoPtr_ActivateCooldownInstance, (void*) &num);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (RewiredHotKeyController) null : new RewiredHotKeyController(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RewiredHotKeyController.NativeFieldInfoPtr_ActivateCooldownInstance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
