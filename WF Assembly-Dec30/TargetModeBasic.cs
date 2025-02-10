// Decompiled with JetBrains decompiler
// Type: TargetModeBasic
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
public class TargetModeBasic : TargetMode
{
  private static readonly IntPtr NativeMethodInfoPtr_GetPotentialTargets_Public_Virtual_Il2CppReferenceArray_1_Entity_Entity_Entity_CardContainer_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddTargets_Private_Void_Entity_HashSet_1_Entity_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24508, XrefRangeEnd = 24536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetModeBasic.NativeMethodInfoPtr_GetPotentialTargets_Public_Virtual_Il2CppReferenceArray_1_Entity_Entity_Entity_CardContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr nativeObject = num;
    return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Entity>) null : new Il2CppReferenceArray<Entity>(nativeObject);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 24568, RefRangeEnd = 24570, XrefRangeStart = 24536, XrefRangeEnd = 24568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddTargets(Entity entity, HashSet<Entity> targets, int rowIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targets);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &rowIndex;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetModeBasic.NativeMethodInfoPtr_AddTargets_Private_Void_Entity_HashSet_1_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TargetModeBasic()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetModeBasic>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetModeBasic.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TargetModeBasic()
  {
    Il2CppClassPointerStore<TargetModeBasic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TargetModeBasic));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetModeBasic>.NativeClassPtr);
    TargetModeBasic.NativeMethodInfoPtr_GetPotentialTargets_Public_Virtual_Il2CppReferenceArray_1_Entity_Entity_Entity_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetModeBasic>.NativeClassPtr, 100664354);
    TargetModeBasic.NativeMethodInfoPtr_AddTargets_Private_Void_Entity_HashSet_1_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetModeBasic>.NativeClassPtr, 100664355);
    TargetModeBasic.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetModeBasic>.NativeClassPtr, 100664356);
  }

  public TargetModeBasic(IntPtr pointer)
    : base(pointer)
  {
  }
}
