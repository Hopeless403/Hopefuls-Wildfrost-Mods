// Decompiled with JetBrains decompiler
// Type: TargetModeBack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;

#nullable disable
public class TargetModeBack : TargetMode
{
  private static readonly IntPtr NativeMethodInfoPtr_GetPotentialTargets_Public_Virtual_Il2CppReferenceArray_1_Entity_Entity_Entity_CardContainer_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetTargetSlots_Public_Virtual_Il2CppReferenceArray_1_CardSlot_CardSlotLane_0;
  private static readonly IntPtr NativeMethodInfoPtr_CanTarget_Public_Virtual_Boolean_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddTargets_Private_Void_Entity_HashSet_1_Entity_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetTarget_Private_Entity_IList_1_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24415, XrefRangeEnd = 24464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Il2CppReferenceArray<Entity> GetPotentialTargets(
    Entity entity,
    Entity target,
    CardContainer targetContainer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetContainer);
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetModeBack.NativeMethodInfoPtr_GetPotentialTargets_Public_Virtual_Il2CppReferenceArray_1_Entity_Entity_Entity_CardContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr nativeObject = num;
    return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Entity>) null : new Il2CppReferenceArray<Entity>(nativeObject);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24464, XrefRangeEnd = 24472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Il2CppReferenceArray<CardSlot> GetTargetSlots(CardSlotLane row)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) row)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetModeBack.NativeMethodInfoPtr_GetTargetSlots_Public_Virtual_Il2CppReferenceArray_1_CardSlot_CardSlotLane_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr nativeObject = num;
    return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<CardSlot>) null : new Il2CppReferenceArray<CardSlot>(nativeObject);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24472, XrefRangeEnd = 24480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool CanTarget(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetModeBack.NativeMethodInfoPtr_CanTarget_Public_Virtual_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 24492, RefRangeEnd = 24493, XrefRangeStart = 24480, XrefRangeEnd = 24492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddTargets(Entity entity, HashSet<Entity> targets, int rowIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targets);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &rowIndex;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetModeBack.NativeMethodInfoPtr_AddTargets_Private_Void_Entity_HashSet_1_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 24505, RefRangeEnd = 24508, XrefRangeStart = 24493, XrefRangeEnd = 24505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Entity GetTarget(IList<Entity> targets)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targets)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetModeBack.NativeMethodInfoPtr_GetTarget_Private_Entity_IList_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (Entity) null : new Entity(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TargetModeBack()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetModeBack>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetModeBack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TargetModeBack()
  {
    Il2CppClassPointerStore<TargetModeBack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TargetModeBack));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetModeBack>.NativeClassPtr);
    TargetModeBack.NativeMethodInfoPtr_GetPotentialTargets_Public_Virtual_Il2CppReferenceArray_1_Entity_Entity_Entity_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetModeBack>.NativeClassPtr, 100664348);
    TargetModeBack.NativeMethodInfoPtr_GetTargetSlots_Public_Virtual_Il2CppReferenceArray_1_CardSlot_CardSlotLane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetModeBack>.NativeClassPtr, 100664349);
    TargetModeBack.NativeMethodInfoPtr_CanTarget_Public_Virtual_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetModeBack>.NativeClassPtr, 100664350);
    TargetModeBack.NativeMethodInfoPtr_AddTargets_Private_Void_Entity_HashSet_1_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetModeBack>.NativeClassPtr, 100664351);
    TargetModeBack.NativeMethodInfoPtr_GetTarget_Private_Entity_IList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetModeBack>.NativeClassPtr, 100664352);
    TargetModeBack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetModeBack>.NativeClassPtr, 100664353);
  }

  public TargetModeBack(IntPtr pointer)
    : base(pointer)
  {
  }
}
