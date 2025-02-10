// Decompiled with JetBrains decompiler
// Type: CardPocket
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class CardPocket : CardContainer
{
  private static readonly System.IntPtr NativeFieldInfoPtr_slideInPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_slideCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_slideDuration;
  private static readonly System.IntPtr NativeFieldInfoPtr_slideDelay;
  private static readonly System.IntPtr NativeFieldInfoPtr_randomAngleAmount;
  private static readonly System.IntPtr NativeFieldInfoPtr_interaction;
  private static readonly System.IntPtr NativeFieldInfoPtr_skipAnimationFromContainers;
  private static readonly System.IntPtr NativeFieldInfoPtr_positions;
  private static readonly System.IntPtr NativeMethodInfoPtr_AssignController_Public_Virtual_Void_CardController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSize_Public_Virtual_Void_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetChildPosition_Public_Virtual_Vector3_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetChildRotation_Public_Virtual_Vector3_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFinalChildPosition_Public_Vector3_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Hover_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnHover_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CardAdded_Protected_Virtual_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CardRemoved_Protected_Virtual_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32467, XrefRangeEnd = 32472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void AssignController(CardController controller)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardPocket.NativeMethodInfoPtr_AssignController_Public_Virtual_Void_CardController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32472, XrefRangeEnd = 32489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPocket.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32489, XrefRangeEnd = 32495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void SetSize(int size, float cardScale)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &size;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cardScale;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardPocket.NativeMethodInfoPtr_SetSize_Public_Virtual_Void_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32495, XrefRangeEnd = 32499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Vector3 GetChildPosition(Entity child)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) child)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardPocket.NativeMethodInfoPtr_GetChildPosition_Public_Virtual_Vector3_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public override unsafe Vector3 GetChildRotation(Entity child)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) child)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardPocket.NativeMethodInfoPtr_GetChildRotation_Public_Virtual_Vector3_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public unsafe Vector3 GetFinalChildPosition(Entity child)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) child)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardPocket.NativeMethodInfoPtr_GetFinalChildPosition_Public_Vector3_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32499, XrefRangeEnd = 32513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Hover()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardPocket.NativeMethodInfoPtr_Hover_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32513, XrefRangeEnd = 32529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void UnHover()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardPocket.NativeMethodInfoPtr_UnHover_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32529, XrefRangeEnd = 32558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CardAdded(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardPocket.NativeMethodInfoPtr_CardAdded_Protected_Virtual_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32558, XrefRangeEnd = 32567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CardRemoved(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardPocket.NativeMethodInfoPtr_CardRemoved_Protected_Virtual_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32567, XrefRangeEnd = 32576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardPocket()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardPocket>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPocket.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardPocket()
  {
    Il2CppClassPointerStore<CardPocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardPocket));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardPocket>.NativeClassPtr);
    CardPocket.NativeFieldInfoPtr_slideInPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocket>.NativeClassPtr, nameof (slideInPosition));
    CardPocket.NativeFieldInfoPtr_slideCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocket>.NativeClassPtr, nameof (slideCurve));
    CardPocket.NativeFieldInfoPtr_slideDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocket>.NativeClassPtr, nameof (slideDuration));
    CardPocket.NativeFieldInfoPtr_slideDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocket>.NativeClassPtr, nameof (slideDelay));
    CardPocket.NativeFieldInfoPtr_randomAngleAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocket>.NativeClassPtr, nameof (randomAngleAmount));
    CardPocket.NativeFieldInfoPtr_interaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocket>.NativeClassPtr, nameof (interaction));
    CardPocket.NativeFieldInfoPtr_skipAnimationFromContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocket>.NativeClassPtr, nameof (skipAnimationFromContainers));
    CardPocket.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocket>.NativeClassPtr, nameof (positions));
    CardPocket.NativeMethodInfoPtr_AssignController_Public_Virtual_Void_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocket>.NativeClassPtr, 100665299);
    CardPocket.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocket>.NativeClassPtr, 100665300);
    CardPocket.NativeMethodInfoPtr_SetSize_Public_Virtual_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocket>.NativeClassPtr, 100665301);
    CardPocket.NativeMethodInfoPtr_GetChildPosition_Public_Virtual_Vector3_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocket>.NativeClassPtr, 100665302);
    CardPocket.NativeMethodInfoPtr_GetChildRotation_Public_Virtual_Vector3_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocket>.NativeClassPtr, 100665303);
    CardPocket.NativeMethodInfoPtr_GetFinalChildPosition_Public_Vector3_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocket>.NativeClassPtr, 100665304);
    CardPocket.NativeMethodInfoPtr_Hover_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocket>.NativeClassPtr, 100665305);
    CardPocket.NativeMethodInfoPtr_UnHover_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocket>.NativeClassPtr, 100665306);
    CardPocket.NativeMethodInfoPtr_CardAdded_Protected_Virtual_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocket>.NativeClassPtr, 100665307);
    CardPocket.NativeMethodInfoPtr_CardRemoved_Protected_Virtual_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocket>.NativeClassPtr, 100665308);
    CardPocket.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocket>.NativeClassPtr, 100665309);
  }

  public CardPocket(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Transform slideInPosition
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.NativeFieldInfoPtr_slideInPosition));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.NativeFieldInfoPtr_slideInPosition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve slideCurve
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.NativeFieldInfoPtr_slideCurve));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.NativeFieldInfoPtr_slideCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float slideDuration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.NativeFieldInfoPtr_slideDuration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.NativeFieldInfoPtr_slideDuration)) = value;
    }
  }

  public unsafe float slideDelay
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.NativeFieldInfoPtr_slideDelay));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.NativeFieldInfoPtr_slideDelay)) = value;
    }
  }

  public unsafe Vector3 randomAngleAmount
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.NativeFieldInfoPtr_randomAngleAmount));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.NativeFieldInfoPtr_randomAngleAmount)) = value;
    }
  }

  public unsafe CardPocketInteraction interaction
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.NativeFieldInfoPtr_interaction));
      return pointer == System.IntPtr.Zero ? (CardPocketInteraction) null : new CardPocketInteraction(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.NativeFieldInfoPtr_interaction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardContainer> skipAnimationFromContainers
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.NativeFieldInfoPtr_skipAnimationFromContainers));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardContainer>) null : new Il2CppReferenceArray<CardContainer>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.NativeFieldInfoPtr_skipAnimationFromContainers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<Entity, CardPocket.PositionHandler> positions
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.NativeFieldInfoPtr_positions));
      return pointer == System.IntPtr.Zero ? (Dictionary<Entity, CardPocket.PositionHandler>) null : new Dictionary<Entity, CardPocket.PositionHandler>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.NativeFieldInfoPtr_positions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public class PositionHandler : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_pocket;
    private static readonly System.IntPtr NativeFieldInfoPtr_entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_startPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_positionChange;
    private static readonly System.IntPtr NativeFieldInfoPtr_curve;
    private static readonly System.IntPtr NativeFieldInfoPtr_duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_delay;
    private static readonly System.IntPtr NativeFieldInfoPtr_t;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsFinished_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CardPocket_Entity_Vector3_Vector3_AnimationCurve_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPosition_Public_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Skip_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_Single_0;

    public unsafe bool IsFinished
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardPocket.PositionHandler.NativeMethodInfoPtr_get_IsFinished_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32455, XrefRangeEnd = 32459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PositionHandler(
      CardPocket pocket,
      Entity entity,
      Vector3 fromPosition,
      Vector3 toPosition,
      AnimationCurve slideCurve,
      float slideDuration,
      float slideDelay)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardPocket.PositionHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pocket);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fromPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &toPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) slideCurve);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &slideDuration;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &slideDelay;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardPocket.PositionHandler.NativeMethodInfoPtr__ctor_Public_Void_CardPocket_Entity_Vector3_Vector3_AnimationCurve_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32459, XrefRangeEnd = 32460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Vector3 GetPosition()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardPocket.PositionHandler.NativeMethodInfoPtr_GetPosition_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32460, XrefRangeEnd = 32461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Skip()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardPocket.PositionHandler.NativeMethodInfoPtr_Skip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 32464, RefRangeEnd = 32467, XrefRangeStart = 32461, XrefRangeEnd = 32464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update(float delta)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &delta
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardPocket.PositionHandler.NativeMethodInfoPtr_Update_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PositionHandler()
    {
      Il2CppClassPointerStore<CardPocket.PositionHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardPocket>.NativeClassPtr, nameof (PositionHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardPocket.PositionHandler>.NativeClassPtr);
      CardPocket.PositionHandler.NativeFieldInfoPtr_pocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocket.PositionHandler>.NativeClassPtr, nameof (pocket));
      CardPocket.PositionHandler.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocket.PositionHandler>.NativeClassPtr, nameof (entity));
      CardPocket.PositionHandler.NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocket.PositionHandler>.NativeClassPtr, nameof (startPosition));
      CardPocket.PositionHandler.NativeFieldInfoPtr_positionChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocket.PositionHandler>.NativeClassPtr, nameof (positionChange));
      CardPocket.PositionHandler.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocket.PositionHandler>.NativeClassPtr, nameof (curve));
      CardPocket.PositionHandler.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocket.PositionHandler>.NativeClassPtr, nameof (duration));
      CardPocket.PositionHandler.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocket.PositionHandler>.NativeClassPtr, nameof (delay));
      CardPocket.PositionHandler.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPocket.PositionHandler>.NativeClassPtr, nameof (t));
      CardPocket.PositionHandler.NativeMethodInfoPtr_get_IsFinished_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocket.PositionHandler>.NativeClassPtr, 100665310);
      CardPocket.PositionHandler.NativeMethodInfoPtr__ctor_Public_Void_CardPocket_Entity_Vector3_Vector3_AnimationCurve_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocket.PositionHandler>.NativeClassPtr, 100665311);
      CardPocket.PositionHandler.NativeMethodInfoPtr_GetPosition_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocket.PositionHandler>.NativeClassPtr, 100665312);
      CardPocket.PositionHandler.NativeMethodInfoPtr_Skip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocket.PositionHandler>.NativeClassPtr, 100665313);
      CardPocket.PositionHandler.NativeMethodInfoPtr_Update_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPocket.PositionHandler>.NativeClassPtr, 100665314);
    }

    public PositionHandler(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CardPocket pocket
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.PositionHandler.NativeFieldInfoPtr_pocket));
        return pointer == System.IntPtr.Zero ? (CardPocket) null : new CardPocket(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.PositionHandler.NativeFieldInfoPtr_pocket), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity entity
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.PositionHandler.NativeFieldInfoPtr_entity));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.PositionHandler.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 startPosition
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.PositionHandler.NativeFieldInfoPtr_startPosition));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.PositionHandler.NativeFieldInfoPtr_startPosition)) = value;
      }
    }

    public unsafe Vector3 positionChange
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.PositionHandler.NativeFieldInfoPtr_positionChange));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.PositionHandler.NativeFieldInfoPtr_positionChange)) = value;
      }
    }

    public unsafe AnimationCurve curve
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.PositionHandler.NativeFieldInfoPtr_curve));
        return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.PositionHandler.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float duration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.PositionHandler.NativeFieldInfoPtr_duration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.PositionHandler.NativeFieldInfoPtr_duration)) = value;
      }
    }

    public unsafe float delay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.PositionHandler.NativeFieldInfoPtr_delay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.PositionHandler.NativeFieldInfoPtr_delay)) = value;
      }
    }

    public unsafe float t
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.PositionHandler.NativeFieldInfoPtr_t));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPocket.PositionHandler.NativeFieldInfoPtr_t)) = value;
      }
    }
  }
}
