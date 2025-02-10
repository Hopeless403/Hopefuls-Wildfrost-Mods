// Decompiled with JetBrains decompiler
// Type: CardController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class CardController : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_owner;
  private static readonly IntPtr NativeFieldInfoPtr_hover;
  private static readonly IntPtr NativeFieldInfoPtr_hoverEntity;
  private static readonly IntPtr NativeFieldInfoPtr_dragging;
  private static readonly IntPtr NativeFieldInfoPtr_hoverContainer;
  private static readonly IntPtr NativeFieldInfoPtr_hoverSlot;
  private static readonly IntPtr NativeFieldInfoPtr_canHoverWhileDragging;
  private static readonly IntPtr NativeFieldInfoPtr_dragLerp;
  private static readonly IntPtr NativeFieldInfoPtr_hoverZ;
  private static readonly IntPtr NativeFieldInfoPtr_dragZ;
  private static readonly IntPtr NativeFieldInfoPtr_cardHoverScale;
  private static readonly IntPtr NativeFieldInfoPtr_cardHoverEase;
  private static readonly IntPtr NativeFieldInfoPtr_cardHoverEaseDur;
  private static readonly IntPtr NativeFieldInfoPtr_cardUnHoverEase;
  private static readonly IntPtr NativeFieldInfoPtr_cardUnHoverEaseDur;
  private static readonly IntPtr NativeFieldInfoPtr_hoverDrawOrder;
  private static readonly IntPtr NativeFieldInfoPtr_dragDrawOrder;
  private static readonly IntPtr NativeFieldInfoPtr_interactWithInPlay;
  private static readonly IntPtr NativeFieldInfoPtr_interactWithNotInPlay;
  private static readonly IntPtr NativeFieldInfoPtr_canPress;
  private static readonly IntPtr NativeFieldInfoPtr_canPressAndHoverInSameFrame;
  private static readonly IntPtr NativeFieldInfoPtr_draggingPositionPre;
  private static readonly IntPtr NativeFieldInfoPtr_draggingLayerPre;
  private static readonly IntPtr NativeFieldInfoPtr_pressEntity;
  private static readonly IntPtr NativeFieldInfoPtr_press;
  private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_CardController_GameObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AllowDynamicSelectRelease_Protected_Virtual_New_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_CardHoverScale_Private_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Press_Protected_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Release_Protected_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_TryDrag_Protected_Boolean_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_Drag_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_DragEnd_Protected_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_DragUpdate_Protected_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_DragCancel_Public_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CanUseOn_Public_Virtual_New_Boolean_Entity_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetDragPosition_Protected_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_DragUpdatePosition_Protected_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Hover_Public_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnHover_Public_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnHover_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_HoverContainer_Public_Void_CardContainer_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnHoverContainer_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_HoverSlot_Public_Void_CardSlot_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnHoverSlot_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_TweenHover_Protected_Void_Entity_Boolean_Boolean_Boolean_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_TweenUnHover_Protected_Void_Entity_Boolean_Boolean_Boolean_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33194, XrefRangeEnd = 33198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe CardController Find(GameObject gameObject)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_Find_Public_Static_CardController_GameObject_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (CardController) null : new CardController(pointer);
  }

  public virtual unsafe bool AllowDynamicSelectRelease
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33198, XrefRangeEnd = 33202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardController.NativeMethodInfoPtr_get_AllowDynamicSelectRelease_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe Vector3 CardHoverScale
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_get_CardHoverScale_Private_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33202, XrefRangeEnd = 33227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardController.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(15)]
  [CachedScanResults(RefRangeStart = 33228, RefRangeEnd = 33243, XrefRangeStart = 33227, XrefRangeEnd = 33228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Enable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_Enable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33243, XrefRangeEnd = 33244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(17)]
  [CachedScanResults(RefRangeStart = 33250, RefRangeEnd = 33267, XrefRangeStart = 33244, XrefRangeEnd = 33250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Disable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33267, XrefRangeEnd = 33268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(12611)]
  [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Press()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardController.NativeMethodInfoPtr_Press_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(12611)]
  [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardController.NativeMethodInfoPtr_Release_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 33269, RefRangeEnd = 33272, XrefRangeStart = 33268, XrefRangeEnd = 33269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryDrag(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_TryDrag_Protected_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33272, XrefRangeEnd = 33285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Drag(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_Drag_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 33289, RefRangeEnd = 33291, XrefRangeStart = 33285, XrefRangeEnd = 33289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void DragEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardController.NativeMethodInfoPtr_DragEnd_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33291, XrefRangeEnd = 33298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void DragUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardController.NativeMethodInfoPtr_DragUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33298, XrefRangeEnd = 33299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void DragCancel()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardController.NativeMethodInfoPtr_DragCancel_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33299, XrefRangeEnd = 33320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool CanUseOn(Entity entity, Entity target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardController.NativeMethodInfoPtr_CanUseOn_Public_Virtual_New_Boolean_Entity_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 33331, RefRangeEnd = 33335, XrefRangeStart = 33320, XrefRangeEnd = 33331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 GetDragPosition()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_GetDragPosition_Protected_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33335, XrefRangeEnd = 33345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void DragUpdatePosition()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardController.NativeMethodInfoPtr_DragUpdatePosition_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 33366, RefRangeEnd = 33368, XrefRangeStart = 33345, XrefRangeEnd = 33366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hover(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_Hover_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 33381, RefRangeEnd = 33391, XrefRangeStart = 33368, XrefRangeEnd = 33381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnHover(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_UnHover_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 33396, RefRangeEnd = 33401, XrefRangeStart = 33391, XrefRangeEnd = 33396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnHover()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_UnHover_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33401, XrefRangeEnd = 33404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HoverContainer(CardContainer container)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_HoverContainer_Public_Void_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 33410, RefRangeEnd = 33415, XrefRangeStart = 33404, XrefRangeEnd = 33410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnHoverContainer()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_UnHoverContainer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 33423, RefRangeEnd = 33425, XrefRangeStart = 33415, XrefRangeEnd = 33423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HoverSlot(CardSlot slot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) slot)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_HoverSlot_Public_Void_CardSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 33431, RefRangeEnd = 33434, XrefRangeStart = 33425, XrefRangeEnd = 33431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnHoverSlot()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_UnHoverSlot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 33466, RefRangeEnd = 33468, XrefRangeStart = 33434, XrefRangeEnd = 33466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TweenHover(
    Entity entity,
    bool doScale = true,
    bool doMove = true,
    bool doRotate = true,
    bool doDrawOrder = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &doScale;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &doMove;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &doRotate;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &doDrawOrder;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_TweenHover_Protected_Void_Entity_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 33499, RefRangeEnd = 33504, XrefRangeStart = 33468, XrefRangeEnd = 33499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TweenUnHover(
    Entity entity,
    bool retainScale = false,
    bool retainPosition = false,
    bool retainRotation = false,
    bool retainDrawOrder = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &retainScale;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &retainPosition;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &retainRotation;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &retainDrawOrder;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_TweenUnHover_Protected_Void_Entity_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33504, XrefRangeEnd = 33505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardController()
  {
    Il2CppClassPointerStore<CardController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardController>.NativeClassPtr);
    CardController.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (owner));
    CardController.NativeFieldInfoPtr_hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (hover));
    CardController.NativeFieldInfoPtr_hoverEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (hoverEntity));
    CardController.NativeFieldInfoPtr_dragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (dragging));
    CardController.NativeFieldInfoPtr_hoverContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (hoverContainer));
    CardController.NativeFieldInfoPtr_hoverSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (hoverSlot));
    CardController.NativeFieldInfoPtr_canHoverWhileDragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (canHoverWhileDragging));
    CardController.NativeFieldInfoPtr_dragLerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (dragLerp));
    CardController.NativeFieldInfoPtr_hoverZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (hoverZ));
    CardController.NativeFieldInfoPtr_dragZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (dragZ));
    CardController.NativeFieldInfoPtr_cardHoverScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (cardHoverScale));
    CardController.NativeFieldInfoPtr_cardHoverEase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (cardHoverEase));
    CardController.NativeFieldInfoPtr_cardHoverEaseDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (cardHoverEaseDur));
    CardController.NativeFieldInfoPtr_cardUnHoverEase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (cardUnHoverEase));
    CardController.NativeFieldInfoPtr_cardUnHoverEaseDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (cardUnHoverEaseDur));
    CardController.NativeFieldInfoPtr_hoverDrawOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (hoverDrawOrder));
    CardController.NativeFieldInfoPtr_dragDrawOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (dragDrawOrder));
    CardController.NativeFieldInfoPtr_interactWithInPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (interactWithInPlay));
    CardController.NativeFieldInfoPtr_interactWithNotInPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (interactWithNotInPlay));
    CardController.NativeFieldInfoPtr_canPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (canPress));
    CardController.NativeFieldInfoPtr_canPressAndHoverInSameFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (canPressAndHoverInSameFrame));
    CardController.NativeFieldInfoPtr_draggingPositionPre = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (draggingPositionPre));
    CardController.NativeFieldInfoPtr_draggingLayerPre = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (draggingLayerPre));
    CardController.NativeFieldInfoPtr_pressEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (pressEntity));
    CardController.NativeFieldInfoPtr_press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, nameof (press));
    CardController.NativeMethodInfoPtr_Find_Public_Static_CardController_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665377);
    CardController.NativeMethodInfoPtr_get_AllowDynamicSelectRelease_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665378);
    CardController.NativeMethodInfoPtr_get_CardHoverScale_Private_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665379);
    CardController.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665380);
    CardController.NativeMethodInfoPtr_Enable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665381);
    CardController.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665382);
    CardController.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665383);
    CardController.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665384);
    CardController.NativeMethodInfoPtr_Press_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665385);
    CardController.NativeMethodInfoPtr_Release_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665386);
    CardController.NativeMethodInfoPtr_TryDrag_Protected_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665387);
    CardController.NativeMethodInfoPtr_Drag_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665388);
    CardController.NativeMethodInfoPtr_DragEnd_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665389);
    CardController.NativeMethodInfoPtr_DragUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665390);
    CardController.NativeMethodInfoPtr_DragCancel_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665391);
    CardController.NativeMethodInfoPtr_CanUseOn_Public_Virtual_New_Boolean_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665392);
    CardController.NativeMethodInfoPtr_GetDragPosition_Protected_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665393);
    CardController.NativeMethodInfoPtr_DragUpdatePosition_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665394);
    CardController.NativeMethodInfoPtr_Hover_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665395);
    CardController.NativeMethodInfoPtr_UnHover_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665396);
    CardController.NativeMethodInfoPtr_UnHover_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665397);
    CardController.NativeMethodInfoPtr_HoverContainer_Public_Void_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665398);
    CardController.NativeMethodInfoPtr_UnHoverContainer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665399);
    CardController.NativeMethodInfoPtr_HoverSlot_Public_Void_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665400);
    CardController.NativeMethodInfoPtr_UnHoverSlot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665401);
    CardController.NativeMethodInfoPtr_TweenHover_Protected_Void_Entity_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665402);
    CardController.NativeMethodInfoPtr_TweenUnHover_Protected_Void_Entity_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665403);
    CardController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100665404);
  }

  public CardController(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Character owner
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_owner));
      return pointer == IntPtr.Zero ? (Character) null : new Character(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject hover
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_hover));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_hover), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Entity hoverEntity
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_hoverEntity));
      return pointer == IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_hoverEntity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Entity dragging
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_dragging));
      return pointer == IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_dragging), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardContainer hoverContainer
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_hoverContainer));
      return pointer == IntPtr.Zero ? (CardContainer) null : new CardContainer(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_hoverContainer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardSlot hoverSlot
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_hoverSlot));
      return pointer == IntPtr.Zero ? (CardSlot) null : new CardSlot(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_hoverSlot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool canHoverWhileDragging
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_canHoverWhileDragging));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_canHoverWhileDragging)) = value;
    }
  }

  public unsafe float dragLerp
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_dragLerp));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_dragLerp)) = value;
    }
  }

  public unsafe float hoverZ
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_hoverZ));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_hoverZ)) = value;
    }
  }

  public unsafe float dragZ
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_dragZ));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_dragZ)) = value;
    }
  }

  public unsafe float cardHoverScale
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_cardHoverScale));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_cardHoverScale)) = value;
    }
  }

  public unsafe LeanTweenType cardHoverEase
  {
    get
    {
      return *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_cardHoverEase));
    }
    [param: In] set
    {
      *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_cardHoverEase)) = value;
    }
  }

  public unsafe float cardHoverEaseDur
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_cardHoverEaseDur));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_cardHoverEaseDur)) = value;
    }
  }

  public unsafe LeanTweenType cardUnHoverEase
  {
    get
    {
      return *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_cardUnHoverEase));
    }
    [param: In] set
    {
      *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_cardUnHoverEase)) = value;
    }
  }

  public unsafe float cardUnHoverEaseDur
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_cardUnHoverEaseDur));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_cardUnHoverEaseDur)) = value;
    }
  }

  public unsafe int hoverDrawOrder
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_hoverDrawOrder));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_hoverDrawOrder)) = value;
    }
  }

  public unsafe int dragDrawOrder
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_dragDrawOrder));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_dragDrawOrder)) = value;
    }
  }

  public unsafe bool interactWithInPlay
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_interactWithInPlay));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_interactWithInPlay)) = value;
    }
  }

  public unsafe bool interactWithNotInPlay
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_interactWithNotInPlay));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_interactWithNotInPlay)) = value;
    }
  }

  public unsafe bool canPress
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_canPress));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_canPress)) = value;
    }
  }

  public unsafe bool canPressAndHoverInSameFrame
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_canPressAndHoverInSameFrame));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_canPressAndHoverInSameFrame)) = value;
    }
  }

  public unsafe Vector3 draggingPositionPre
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_draggingPositionPre));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_draggingPositionPre)) = value;
    }
  }

  public unsafe int draggingLayerPre
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_draggingLayerPre));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_draggingLayerPre)) = value;
    }
  }

  public unsafe Entity pressEntity
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_pressEntity));
      return pointer == IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_pressEntity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool press
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_press));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_press)) = value;
    }
  }
}
