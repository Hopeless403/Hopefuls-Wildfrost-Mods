// Decompiled with JetBrains decompiler
// Type: StatusEffectWhileInHandX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;

#nullable disable
public class StatusEffectWhileInHandX : StatusEffectWhileActiveX
{
  private static readonly IntPtr NativeMethodInfoPtr_CanActivate_Protected_Virtual_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckActivateOnMove_Protected_Virtual_Boolean_Il2CppReferenceArray_1_CardContainer_Il2CppReferenceArray_1_CardContainer_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckDeactivateOnMove_Protected_Virtual_Boolean_Il2CppReferenceArray_1_CardContainer_Il2CppReferenceArray_1_CardContainer_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125107, XrefRangeEnd = 125109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool CanActivate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectWhileInHandX.NativeMethodInfoPtr_CanActivate_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125109, XrefRangeEnd = 125112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool CheckActivateOnMove(
    Il2CppReferenceArray<CardContainer> fromContainers,
    Il2CppReferenceArray<CardContainer> toContainers)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fromContainers);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) toContainers);
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectWhileInHandX.NativeMethodInfoPtr_CheckActivateOnMove_Protected_Virtual_Boolean_Il2CppReferenceArray_1_CardContainer_Il2CppReferenceArray_1_CardContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125112, XrefRangeEnd = 125115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool CheckDeactivateOnMove(
    Il2CppReferenceArray<CardContainer> fromContainers,
    Il2CppReferenceArray<CardContainer> toContainers)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fromContainers);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) toContainers);
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectWhileInHandX.NativeMethodInfoPtr_CheckDeactivateOnMove_Protected_Virtual_Boolean_Il2CppReferenceArray_1_CardContainer_Il2CppReferenceArray_1_CardContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125115, XrefRangeEnd = 125116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectWhileInHandX()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectWhileInHandX>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectWhileInHandX.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatusEffectWhileInHandX()
  {
    Il2CppClassPointerStore<StatusEffectWhileInHandX>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusEffectWhileInHandX));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectWhileInHandX>.NativeClassPtr);
    StatusEffectWhileInHandX.NativeMethodInfoPtr_CanActivate_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectWhileInHandX>.NativeClassPtr, 100675959);
    StatusEffectWhileInHandX.NativeMethodInfoPtr_CheckActivateOnMove_Protected_Virtual_Boolean_Il2CppReferenceArray_1_CardContainer_Il2CppReferenceArray_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectWhileInHandX>.NativeClassPtr, 100675960);
    StatusEffectWhileInHandX.NativeMethodInfoPtr_CheckDeactivateOnMove_Protected_Virtual_Boolean_Il2CppReferenceArray_1_CardContainer_Il2CppReferenceArray_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectWhileInHandX>.NativeClassPtr, 100675961);
    StatusEffectWhileInHandX.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectWhileInHandX>.NativeClassPtr, 100675962);
  }

  public StatusEffectWhileInHandX(IntPtr pointer)
    : base(pointer)
  {
  }
}
