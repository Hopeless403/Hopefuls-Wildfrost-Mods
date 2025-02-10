// Decompiled with JetBrains decompiler
// Type: TargetingArrowSystem
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
public class TargetingArrowSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_offensiveArrow;
  private static readonly IntPtr NativeFieldInfoPtr_supportiveArrow;
  private static readonly IntPtr NativeFieldInfoPtr_targetMulti;
  private static readonly IntPtr NativeFieldInfoPtr_target;
  private static readonly IntPtr NativeFieldInfoPtr_hover;
  private static readonly IntPtr NativeFieldInfoPtr_snapToContainer;
  private static readonly IntPtr NativeFieldInfoPtr_active;
  private static readonly IntPtr NativeFieldInfoPtr_toPosition;
  private static readonly IntPtr NativeFieldInfoPtr_lerp;
  private static readonly IntPtr NativeFieldInfoPtr_currentArrow;
  private static readonly IntPtr NativeFieldInfoPtr_offensive;
  private static readonly IntPtr NativeMethodInfoPtr_get_toPositionTarget_Private_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_CorrectType_Private_Static_Boolean_PlayType_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateArrow_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Show_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Hide_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_EntityDrag_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_EntityRelease_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_EntityHover_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_EntityUnHover_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_ContainerHover_Private_Void_CardContainer_0;
  private static readonly IntPtr NativeMethodInfoPtr_ContainerUnHover_Private_Void_CardContainer_0;
  private static readonly IntPtr NativeMethodInfoPtr_SlotHover_Private_Void_CardSlot_0;
  private static readonly IntPtr NativeMethodInfoPtr_SlotUnHover_Private_Void_CardSlot_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe Vector3 toPositionTarget
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 76544, RefRangeEnd = 76547, XrefRangeStart = 76528, XrefRangeEnd = 76544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetingArrowSystem.NativeMethodInfoPtr_get_toPositionTarget_Private_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  public static unsafe bool CorrectType(Card.PlayType playType)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &playType
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetingArrowSystem.NativeMethodInfoPtr_CorrectType_Private_Static_Boolean_PlayType_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76547, XrefRangeEnd = 76599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingArrowSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76599, XrefRangeEnd = 76651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingArrowSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76651, XrefRangeEnd = 76682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingArrowSystem.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76682, XrefRangeEnd = 76684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateArrow()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingArrowSystem.NativeMethodInfoPtr_UpdateArrow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76684, XrefRangeEnd = 76699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Show()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingArrowSystem.NativeMethodInfoPtr_Show_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76699, XrefRangeEnd = 76702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hide()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingArrowSystem.NativeMethodInfoPtr_Hide_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76702, XrefRangeEnd = 76711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityDrag(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingArrowSystem.NativeMethodInfoPtr_EntityDrag_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76711, XrefRangeEnd = 76716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityRelease(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingArrowSystem.NativeMethodInfoPtr_EntityRelease_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76716, XrefRangeEnd = 76721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityHover(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingArrowSystem.NativeMethodInfoPtr_EntityHover_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76721, XrefRangeEnd = 76729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityUnHover(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingArrowSystem.NativeMethodInfoPtr_EntityUnHover_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76729, XrefRangeEnd = 76733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ContainerHover(CardContainer container)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingArrowSystem.NativeMethodInfoPtr_ContainerHover_Private_Void_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76733, XrefRangeEnd = 76741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ContainerUnHover(CardContainer container)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingArrowSystem.NativeMethodInfoPtr_ContainerUnHover_Private_Void_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76741, XrefRangeEnd = 76745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SlotHover(CardSlot slot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) slot)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingArrowSystem.NativeMethodInfoPtr_SlotHover_Private_Void_CardSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76745, XrefRangeEnd = 76753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SlotUnHover(CardSlot slot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) slot)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingArrowSystem.NativeMethodInfoPtr_SlotUnHover_Private_Void_CardSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76753, XrefRangeEnd = 76754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TargetingArrowSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingArrowSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TargetingArrowSystem()
  {
    Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TargetingArrowSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr);
    TargetingArrowSystem.NativeFieldInfoPtr_offensiveArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, nameof (offensiveArrow));
    TargetingArrowSystem.NativeFieldInfoPtr_supportiveArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, nameof (supportiveArrow));
    TargetingArrowSystem.NativeFieldInfoPtr_targetMulti = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, nameof (targetMulti));
    TargetingArrowSystem.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, nameof (target));
    TargetingArrowSystem.NativeFieldInfoPtr_hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, nameof (hover));
    TargetingArrowSystem.NativeFieldInfoPtr_snapToContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, nameof (snapToContainer));
    TargetingArrowSystem.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, nameof (active));
    TargetingArrowSystem.NativeFieldInfoPtr_toPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, nameof (toPosition));
    TargetingArrowSystem.NativeFieldInfoPtr_lerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, nameof (lerp));
    TargetingArrowSystem.NativeFieldInfoPtr_currentArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, nameof (currentArrow));
    TargetingArrowSystem.NativeFieldInfoPtr_offensive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, nameof (offensive));
    TargetingArrowSystem.NativeMethodInfoPtr_get_toPositionTarget_Private_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, 100669448);
    TargetingArrowSystem.NativeMethodInfoPtr_CorrectType_Private_Static_Boolean_PlayType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, 100669449);
    TargetingArrowSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, 100669450);
    TargetingArrowSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, 100669451);
    TargetingArrowSystem.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, 100669452);
    TargetingArrowSystem.NativeMethodInfoPtr_UpdateArrow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, 100669453);
    TargetingArrowSystem.NativeMethodInfoPtr_Show_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, 100669454);
    TargetingArrowSystem.NativeMethodInfoPtr_Hide_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, 100669455);
    TargetingArrowSystem.NativeMethodInfoPtr_EntityDrag_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, 100669456);
    TargetingArrowSystem.NativeMethodInfoPtr_EntityRelease_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, 100669457);
    TargetingArrowSystem.NativeMethodInfoPtr_EntityHover_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, 100669458);
    TargetingArrowSystem.NativeMethodInfoPtr_EntityUnHover_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, 100669459);
    TargetingArrowSystem.NativeMethodInfoPtr_ContainerHover_Private_Void_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, 100669460);
    TargetingArrowSystem.NativeMethodInfoPtr_ContainerUnHover_Private_Void_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, 100669461);
    TargetingArrowSystem.NativeMethodInfoPtr_SlotHover_Private_Void_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, 100669462);
    TargetingArrowSystem.NativeMethodInfoPtr_SlotUnHover_Private_Void_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, 100669463);
    TargetingArrowSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrowSystem>.NativeClassPtr, 100669464);
  }

  public TargetingArrowSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe TargetingDisplay offensiveArrow
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowSystem.NativeFieldInfoPtr_offensiveArrow));
      return pointer == IntPtr.Zero ? (TargetingDisplay) null : new TargetingDisplay(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowSystem.NativeFieldInfoPtr_offensiveArrow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TargetingDisplay supportiveArrow
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowSystem.NativeFieldInfoPtr_supportiveArrow));
      return pointer == IntPtr.Zero ? (TargetingDisplay) null : new TargetingDisplay(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowSystem.NativeFieldInfoPtr_supportiveArrow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TargetingDisplay targetMulti
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowSystem.NativeFieldInfoPtr_targetMulti));
      return pointer == IntPtr.Zero ? (TargetingDisplay) null : new TargetingDisplay(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowSystem.NativeFieldInfoPtr_targetMulti), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Entity target
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowSystem.NativeFieldInfoPtr_target));
      return pointer == IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowSystem.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Entity hover
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowSystem.NativeFieldInfoPtr_hover));
      return pointer == IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowSystem.NativeFieldInfoPtr_hover), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardContainer snapToContainer
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowSystem.NativeFieldInfoPtr_snapToContainer));
      return pointer == IntPtr.Zero ? (CardContainer) null : new CardContainer(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowSystem.NativeFieldInfoPtr_snapToContainer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool active
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowSystem.NativeFieldInfoPtr_active));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowSystem.NativeFieldInfoPtr_active)) = value;
    }
  }

  public unsafe Vector3 toPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowSystem.NativeFieldInfoPtr_toPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowSystem.NativeFieldInfoPtr_toPosition)) = value;
    }
  }

  public unsafe float lerp
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowSystem.NativeFieldInfoPtr_lerp));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowSystem.NativeFieldInfoPtr_lerp)) = value;
    }
  }

  public unsafe TargetingDisplay currentArrow
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowSystem.NativeFieldInfoPtr_currentArrow));
      return pointer == IntPtr.Zero ? (TargetingDisplay) null : new TargetingDisplay(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowSystem.NativeFieldInfoPtr_currentArrow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool offensive
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowSystem.NativeFieldInfoPtr_offensive));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowSystem.NativeFieldInfoPtr_offensive)) = value;
    }
  }
}
