// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXOnCardPlayed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System;

#nullable disable
public class StatusEffectApplyXOnCardPlayed : StatusEffectApplyX
{
  private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetWasInRows_Private_Static_Il2CppReferenceArray_1_CardContainer_Entity_IEnumerable_1_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_RunCardPlayedEvent_Public_Virtual_Boolean_Entity_Il2CppReferenceArray_1_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_Check_Private_IEnumerator_Entity_Il2CppReferenceArray_1_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121798, XrefRangeEnd = 121806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectApplyXOnCardPlayed.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 121841, RefRangeEnd = 121842, XrefRangeStart = 121806, XrefRangeEnd = 121841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppReferenceArray<CardContainer> GetWasInRows(
    Entity entity,
    IEnumerable<Entity> targets)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targets);
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXOnCardPlayed.NativeMethodInfoPtr_GetWasInRows_Private_Static_Il2CppReferenceArray_1_CardContainer_Entity_IEnumerable_1_Entity_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr nativeObject = num;
    return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<CardContainer>) null : new Il2CppReferenceArray<CardContainer>(nativeObject);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121842, XrefRangeEnd = 121844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunCardPlayedEvent(
    Entity entity,
    Il2CppReferenceArray<Entity> targets)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targets);
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectApplyXOnCardPlayed.NativeMethodInfoPtr_RunCardPlayedEvent_Public_Virtual_Boolean_Entity_Il2CppReferenceArray_1_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121844, XrefRangeEnd = 121847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Check(Entity entity, Il2CppReferenceArray<Entity> targets)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targets);
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXOnCardPlayed.NativeMethodInfoPtr_Check_Private_IEnumerator_Entity_Il2CppReferenceArray_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(23)]
  [CachedScanResults(RefRangeStart = 121710, RefRangeEnd = 121733, XrefRangeStart = 121710, XrefRangeEnd = 121733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectApplyXOnCardPlayed()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectApplyXOnCardPlayed>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXOnCardPlayed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatusEffectApplyXOnCardPlayed()
  {
    Il2CppClassPointerStore<StatusEffectApplyXOnCardPlayed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusEffectApplyXOnCardPlayed));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectApplyXOnCardPlayed>.NativeClassPtr);
    StatusEffectApplyXOnCardPlayed.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXOnCardPlayed>.NativeClassPtr, 100675365);
    StatusEffectApplyXOnCardPlayed.NativeMethodInfoPtr_GetWasInRows_Private_Static_Il2CppReferenceArray_1_CardContainer_Entity_IEnumerable_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXOnCardPlayed>.NativeClassPtr, 100675366);
    StatusEffectApplyXOnCardPlayed.NativeMethodInfoPtr_RunCardPlayedEvent_Public_Virtual_Boolean_Entity_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXOnCardPlayed>.NativeClassPtr, 100675367);
    StatusEffectApplyXOnCardPlayed.NativeMethodInfoPtr_Check_Private_IEnumerator_Entity_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXOnCardPlayed>.NativeClassPtr, 100675368);
    StatusEffectApplyXOnCardPlayed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXOnCardPlayed>.NativeClassPtr, 100675369);
  }

  public StatusEffectApplyXOnCardPlayed(IntPtr pointer)
    : base(pointer)
  {
  }
}
