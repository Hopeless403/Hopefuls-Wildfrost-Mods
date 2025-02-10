// Decompiled with JetBrains decompiler
// Type: TargetingArrowHeadRow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class TargetingArrowHeadRow : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_targetArrowSystem;
  private static readonly IntPtr NativeFieldInfoPtr_targetTransforms;
  private static readonly IntPtr NativeFieldInfoPtr_targets;
  private static readonly IntPtr NativeFieldInfoPtr_canTarget;
  private static readonly IntPtr NativeFieldInfoPtr_cannotTarget;
  private static readonly IntPtr NativeFieldInfoPtr_slots;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76503, XrefRangeEnd = 76521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingArrowHeadRow.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76521, XrefRangeEnd = 76528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingArrowHeadRow.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TargetingArrowHeadRow()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetingArrowHeadRow>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingArrowHeadRow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TargetingArrowHeadRow()
  {
    Il2CppClassPointerStore<TargetingArrowHeadRow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TargetingArrowHeadRow));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetingArrowHeadRow>.NativeClassPtr);
    TargetingArrowHeadRow.NativeFieldInfoPtr_targetArrowSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrowHeadRow>.NativeClassPtr, nameof (targetArrowSystem));
    TargetingArrowHeadRow.NativeFieldInfoPtr_targetTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrowHeadRow>.NativeClassPtr, nameof (targetTransforms));
    TargetingArrowHeadRow.NativeFieldInfoPtr_targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrowHeadRow>.NativeClassPtr, nameof (targets));
    TargetingArrowHeadRow.NativeFieldInfoPtr_canTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrowHeadRow>.NativeClassPtr, nameof (canTarget));
    TargetingArrowHeadRow.NativeFieldInfoPtr_cannotTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrowHeadRow>.NativeClassPtr, nameof (cannotTarget));
    TargetingArrowHeadRow.NativeFieldInfoPtr_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrowHeadRow>.NativeClassPtr, nameof (slots));
    TargetingArrowHeadRow.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrowHeadRow>.NativeClassPtr, 100669445);
    TargetingArrowHeadRow.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrowHeadRow>.NativeClassPtr, 100669446);
    TargetingArrowHeadRow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrowHeadRow>.NativeClassPtr, 100669447);
  }

  public TargetingArrowHeadRow(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe TargetingArrowSystem targetArrowSystem
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowHeadRow.NativeFieldInfoPtr_targetArrowSystem));
      return pointer == IntPtr.Zero ? (TargetingArrowSystem) null : new TargetingArrowSystem(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowHeadRow.NativeFieldInfoPtr_targetArrowSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Transform> targetTransforms
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowHeadRow.NativeFieldInfoPtr_targetTransforms));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Transform>) null : new Il2CppReferenceArray<Transform>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowHeadRow.NativeFieldInfoPtr_targetTransforms), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<SpriteRenderer> targets
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowHeadRow.NativeFieldInfoPtr_targets));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<SpriteRenderer>) null : new Il2CppReferenceArray<SpriteRenderer>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowHeadRow.NativeFieldInfoPtr_targets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite canTarget
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowHeadRow.NativeFieldInfoPtr_canTarget));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowHeadRow.NativeFieldInfoPtr_canTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite cannotTarget
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowHeadRow.NativeFieldInfoPtr_cannotTarget));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowHeadRow.NativeFieldInfoPtr_cannotTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<CardSlot> slots
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowHeadRow.NativeFieldInfoPtr_slots));
      return pointer == IntPtr.Zero ? (List<CardSlot>) null : new List<CardSlot>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrowHeadRow.NativeFieldInfoPtr_slots), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
