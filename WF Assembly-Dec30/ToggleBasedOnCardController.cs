// Decompiled with JetBrains decompiler
// Type: ToggleBasedOnCardController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class ToggleBasedOnCardController : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_cardController;
  private static readonly IntPtr NativeFieldInfoPtr_components;
  private static readonly IntPtr NativeFieldInfoPtr_onEnable;
  private static readonly IntPtr NativeFieldInfoPtr_onDisable;
  private static readonly IntPtr NativeMethodInfoPtr_AssignCardController_Public_Void_CardController_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CardControllerEnabled_Private_Void_CardController_0;
  private static readonly IntPtr NativeMethodInfoPtr_CardControllerDisabled_Private_Void_CardController_0;
  private static readonly IntPtr NativeMethodInfoPtr_Enable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Disable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 83279, RefRangeEnd = 83284, XrefRangeStart = 83274, XrefRangeEnd = 83279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AssignCardController(CardController controller)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ToggleBasedOnCardController.NativeMethodInfoPtr_AssignCardController_Public_Void_CardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83284, XrefRangeEnd = 83298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ToggleBasedOnCardController.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83298, XrefRangeEnd = 83312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ToggleBasedOnCardController.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83312, XrefRangeEnd = 83317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CardControllerEnabled(CardController controller)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ToggleBasedOnCardController.NativeMethodInfoPtr_CardControllerEnabled_Private_Void_CardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83317, XrefRangeEnd = 83322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CardControllerDisabled(CardController controller)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ToggleBasedOnCardController.NativeMethodInfoPtr_CardControllerDisabled_Private_Void_CardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 83325, RefRangeEnd = 83327, XrefRangeStart = 83322, XrefRangeEnd = 83325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Enable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ToggleBasedOnCardController.NativeMethodInfoPtr_Enable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 83330, RefRangeEnd = 83332, XrefRangeStart = 83327, XrefRangeEnd = 83330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Disable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ToggleBasedOnCardController.NativeMethodInfoPtr_Disable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ToggleBasedOnCardController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleBasedOnCardController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ToggleBasedOnCardController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ToggleBasedOnCardController()
  {
    Il2CppClassPointerStore<ToggleBasedOnCardController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ToggleBasedOnCardController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleBasedOnCardController>.NativeClassPtr);
    ToggleBasedOnCardController.NativeFieldInfoPtr_cardController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleBasedOnCardController>.NativeClassPtr, nameof (cardController));
    ToggleBasedOnCardController.NativeFieldInfoPtr_components = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleBasedOnCardController>.NativeClassPtr, nameof (components));
    ToggleBasedOnCardController.NativeFieldInfoPtr_onEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleBasedOnCardController>.NativeClassPtr, nameof (onEnable));
    ToggleBasedOnCardController.NativeFieldInfoPtr_onDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleBasedOnCardController>.NativeClassPtr, nameof (onDisable));
    ToggleBasedOnCardController.NativeMethodInfoPtr_AssignCardController_Public_Void_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleBasedOnCardController>.NativeClassPtr, 100670190);
    ToggleBasedOnCardController.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleBasedOnCardController>.NativeClassPtr, 100670191);
    ToggleBasedOnCardController.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleBasedOnCardController>.NativeClassPtr, 100670192);
    ToggleBasedOnCardController.NativeMethodInfoPtr_CardControllerEnabled_Private_Void_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleBasedOnCardController>.NativeClassPtr, 100670193);
    ToggleBasedOnCardController.NativeMethodInfoPtr_CardControllerDisabled_Private_Void_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleBasedOnCardController>.NativeClassPtr, 100670194);
    ToggleBasedOnCardController.NativeMethodInfoPtr_Enable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleBasedOnCardController>.NativeClassPtr, 100670195);
    ToggleBasedOnCardController.NativeMethodInfoPtr_Disable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleBasedOnCardController>.NativeClassPtr, 100670196);
    ToggleBasedOnCardController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleBasedOnCardController>.NativeClassPtr, 100670197);
  }

  public ToggleBasedOnCardController(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe CardController cardController
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ToggleBasedOnCardController.NativeFieldInfoPtr_cardController));
      return pointer == IntPtr.Zero ? (CardController) null : new CardController(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ToggleBasedOnCardController.NativeFieldInfoPtr_cardController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<MonoBehaviour> components
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ToggleBasedOnCardController.NativeFieldInfoPtr_components));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<MonoBehaviour>) null : new Il2CppReferenceArray<MonoBehaviour>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ToggleBasedOnCardController.NativeFieldInfoPtr_components), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent onEnable
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ToggleBasedOnCardController.NativeFieldInfoPtr_onEnable));
      return pointer == IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ToggleBasedOnCardController.NativeFieldInfoPtr_onEnable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent onDisable
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ToggleBasedOnCardController.NativeFieldInfoPtr_onDisable));
      return pointer == IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ToggleBasedOnCardController.NativeFieldInfoPtr_onDisable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
