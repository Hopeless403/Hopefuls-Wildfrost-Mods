// Decompiled with JetBrains decompiler
// Type: CardHover
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
public class CardHover : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_IsMaster;
  private static readonly IntPtr NativeFieldInfoPtr_master;
  private static readonly IntPtr NativeFieldInfoPtr_graphicRaycaster;
  private static readonly IntPtr NativeFieldInfoPtr_entity;
  private static readonly IntPtr NativeFieldInfoPtr_disableWhileDragging;
  private static readonly IntPtr NativeFieldInfoPtr_flipper;
  private static readonly IntPtr NativeFieldInfoPtr_onHover;
  private static readonly IntPtr NativeFieldInfoPtr_onUnHover;
  private static readonly IntPtr NativeFieldInfoPtr_pop;
  private static readonly IntPtr NativeFieldInfoPtr_mouseOver;
  private static readonly IntPtr NativeFieldInfoPtr_childMouseOverCount;
  private static readonly IntPtr NativeFieldInfoPtr_preMouseOver;
  private static readonly IntPtr NativeFieldInfoPtr_hovering;
  private static readonly IntPtr NativeFieldInfoPtr_controller;
  private static readonly IntPtr NativeFieldInfoPtr_hoverable;
  private static readonly IntPtr NativeFieldInfoPtr_dragging;
  private static readonly IntPtr NativeFieldInfoPtr_hasPop;
  private static readonly IntPtr NativeFieldInfoPtr__WasHovering_k__BackingField;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsHovering_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsMouseOver_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_CanHover_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_WasHovering_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_WasHovering_Private_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateInputSystem_Private_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_CardControllerEnabled_Private_Void_CardController_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckHover_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckUnHover_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Hover_Protected_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnHover_Protected_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ForceUnHover_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnPointerAfterExit_Public_Virtual_Final_New_Void_PointerEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe bool IsHovering
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_get_IsHovering_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool IsHoverable
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool IsMouseOver
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_get_IsMouseOver_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool CanHover
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35332, XrefRangeEnd = 35338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_get_CanHover_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool WasHovering
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_get_WasHovering_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_set_WasHovering_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35338, XrefRangeEnd = 35342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35342, XrefRangeEnd = 35358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35358, XrefRangeEnd = 35378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35378, XrefRangeEnd = 35383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35383, XrefRangeEnd = 35397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void UpdateInputSystem(bool forceTouch)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &forceTouch
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_UpdateInputSystem_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35397, XrefRangeEnd = 35403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CardControllerEnabled(CardController controller)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_CardControllerEnabled_Private_Void_CardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35403, XrefRangeEnd = 35404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckHover()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_CheckHover_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35404, XrefRangeEnd = 35405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckUnHover()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_CheckUnHover_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35405, XrefRangeEnd = 35408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Enable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_Enable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35408, XrefRangeEnd = 35412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Disable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 35413, RefRangeEnd = 35421, XrefRangeStart = 35412, XrefRangeEnd = 35413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetHoverable(bool value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 35430, RefRangeEnd = 35433, XrefRangeStart = 35421, XrefRangeEnd = 35430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hover()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_Hover_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 35444, RefRangeEnd = 35453, XrefRangeStart = 35433, XrefRangeEnd = 35444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnHover()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_UnHover_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 35454, RefRangeEnd = 35455, XrefRangeStart = 35453, XrefRangeEnd = 35454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ForceUnHover()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_ForceUnHover_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35455, XrefRangeEnd = 35466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnPointerEnter(PointerEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 35466, RefRangeEnd = 35467, XrefRangeStart = 35466, XrefRangeEnd = 35466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnPointerExit(PointerEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35467, XrefRangeEnd = 35468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnPointerAfterExit(PointerEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr_OnPointerAfterExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35468, XrefRangeEnd = 35469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardHover()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardHover>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardHover.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardHover()
  {
    Il2CppClassPointerStore<CardHover>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardHover));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardHover>.NativeClassPtr);
    CardHover.NativeFieldInfoPtr_IsMaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHover>.NativeClassPtr, nameof (IsMaster));
    CardHover.NativeFieldInfoPtr_master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHover>.NativeClassPtr, nameof (master));
    CardHover.NativeFieldInfoPtr_graphicRaycaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHover>.NativeClassPtr, nameof (graphicRaycaster));
    CardHover.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHover>.NativeClassPtr, nameof (entity));
    CardHover.NativeFieldInfoPtr_disableWhileDragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHover>.NativeClassPtr, nameof (disableWhileDragging));
    CardHover.NativeFieldInfoPtr_flipper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHover>.NativeClassPtr, nameof (flipper));
    CardHover.NativeFieldInfoPtr_onHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHover>.NativeClassPtr, nameof (onHover));
    CardHover.NativeFieldInfoPtr_onUnHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHover>.NativeClassPtr, nameof (onUnHover));
    CardHover.NativeFieldInfoPtr_pop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHover>.NativeClassPtr, nameof (pop));
    CardHover.NativeFieldInfoPtr_mouseOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHover>.NativeClassPtr, nameof (mouseOver));
    CardHover.NativeFieldInfoPtr_childMouseOverCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHover>.NativeClassPtr, nameof (childMouseOverCount));
    CardHover.NativeFieldInfoPtr_preMouseOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHover>.NativeClassPtr, nameof (preMouseOver));
    CardHover.NativeFieldInfoPtr_hovering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHover>.NativeClassPtr, nameof (hovering));
    CardHover.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHover>.NativeClassPtr, nameof (controller));
    CardHover.NativeFieldInfoPtr_hoverable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHover>.NativeClassPtr, nameof (hoverable));
    CardHover.NativeFieldInfoPtr_dragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHover>.NativeClassPtr, nameof (dragging));
    CardHover.NativeFieldInfoPtr_hasPop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHover>.NativeClassPtr, nameof (hasPop));
    CardHover.NativeFieldInfoPtr__WasHovering_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHover>.NativeClassPtr, "<WasHovering>k__BackingField");
    CardHover.NativeMethodInfoPtr_get_IsHovering_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665615);
    CardHover.NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665616);
    CardHover.NativeMethodInfoPtr_get_IsMouseOver_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665617);
    CardHover.NativeMethodInfoPtr_get_CanHover_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665618);
    CardHover.NativeMethodInfoPtr_get_WasHovering_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665619);
    CardHover.NativeMethodInfoPtr_set_WasHovering_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665620);
    CardHover.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665621);
    CardHover.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665622);
    CardHover.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665623);
    CardHover.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665624);
    CardHover.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665625);
    CardHover.NativeMethodInfoPtr_UpdateInputSystem_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665626);
    CardHover.NativeMethodInfoPtr_CardControllerEnabled_Private_Void_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665627);
    CardHover.NativeMethodInfoPtr_CheckHover_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665628);
    CardHover.NativeMethodInfoPtr_CheckUnHover_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665629);
    CardHover.NativeMethodInfoPtr_Enable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665630);
    CardHover.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665631);
    CardHover.NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665632);
    CardHover.NativeMethodInfoPtr_Hover_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665633);
    CardHover.NativeMethodInfoPtr_UnHover_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665634);
    CardHover.NativeMethodInfoPtr_ForceUnHover_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665635);
    CardHover.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665636);
    CardHover.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665637);
    CardHover.NativeMethodInfoPtr_OnPointerAfterExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665638);
    CardHover.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHover>.NativeClassPtr, 100665639);
  }

  public CardHover(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool IsMaster
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_IsMaster));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_IsMaster)) = value;
    }
  }

  public unsafe CardHover master
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_master));
      return pointer == IntPtr.Zero ? (CardHover) null : new CardHover(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_master), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GraphicRaycaster graphicRaycaster
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_graphicRaycaster));
      return pointer == IntPtr.Zero ? (GraphicRaycaster) null : new GraphicRaycaster(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_graphicRaycaster), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Entity entity
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_entity));
      return pointer == IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool disableWhileDragging
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_disableWhileDragging));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_disableWhileDragging)) = value;
    }
  }

  public unsafe Flipper flipper
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_flipper));
      return pointer == IntPtr.Zero ? (Flipper) null : new Flipper(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_flipper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent onHover
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_onHover));
      return pointer == IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_onHover), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent onUnHover
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_onUnHover));
      return pointer == IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_onUnHover), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardPopUpTarget pop
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_pop));
      return pointer == IntPtr.Zero ? (CardPopUpTarget) null : new CardPopUpTarget(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_pop), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool mouseOver
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_mouseOver));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_mouseOver)) = value;
    }
  }

  public unsafe int childMouseOverCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_childMouseOverCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_childMouseOverCount)) = value;
    }
  }

  public unsafe bool preMouseOver
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_preMouseOver));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_preMouseOver)) = value;
    }
  }

  public unsafe bool hovering
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_hovering));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_hovering)) = value;
    }
  }

  public unsafe CardController controller
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_controller));
      return pointer == IntPtr.Zero ? (CardController) null : new CardController(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool hoverable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_hoverable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_hoverable)) = value;
    }
  }

  public unsafe bool dragging
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_dragging));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_dragging)) = value;
    }
  }

  public unsafe bool hasPop
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_hasPop));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr_hasPop)) = value;
    }
  }

  public unsafe bool _WasHovering_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr__WasHovering_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHover.NativeFieldInfoPtr__WasHovering_k__BackingField)) = value;
    }
  }
}
