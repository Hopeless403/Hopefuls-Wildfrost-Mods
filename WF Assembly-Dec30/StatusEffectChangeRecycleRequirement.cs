// Decompiled with JetBrains decompiler
// Type: StatusEffectChangeRecycleRequirement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class StatusEffectChangeRecycleRequirement : StatusEffectData
{
  private static readonly IntPtr NativeFieldInfoPtr_lower;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckRecycleAmount_Private_Void_byref_Entity_byref_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123730, XrefRangeEnd = 123738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectChangeRecycleRequirement.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123738, XrefRangeEnd = 123746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectChangeRecycleRequirement.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123746, XrefRangeEnd = 123750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckRecycleAmount(ref Entity entity, ref int amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[2];
    IntPtr* numPtr2 = numPtr1;
    IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    IntPtr* numPtr3 = &ptr;
    *numPtr2 = (IntPtr) numPtr3;
    *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref amount;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectChangeRecycleRequirement.NativeMethodInfoPtr_CheckRecycleAmount_Private_Void_byref_Entity_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref Entity local = ref entity;
    IntPtr pointer = ptr;
    Entity entity1 = pointer == IntPtr.Zero ? (Entity) null : new Entity(pointer);
    local = entity1;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectChangeRecycleRequirement()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectChangeRecycleRequirement>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectChangeRecycleRequirement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatusEffectChangeRecycleRequirement()
  {
    Il2CppClassPointerStore<StatusEffectChangeRecycleRequirement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusEffectChangeRecycleRequirement));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectChangeRecycleRequirement>.NativeClassPtr);
    StatusEffectChangeRecycleRequirement.NativeFieldInfoPtr_lower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectChangeRecycleRequirement>.NativeClassPtr, nameof (lower));
    StatusEffectChangeRecycleRequirement.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectChangeRecycleRequirement>.NativeClassPtr, 100675721);
    StatusEffectChangeRecycleRequirement.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectChangeRecycleRequirement>.NativeClassPtr, 100675722);
    StatusEffectChangeRecycleRequirement.NativeMethodInfoPtr_CheckRecycleAmount_Private_Void_byref_Entity_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectChangeRecycleRequirement>.NativeClassPtr, 100675723);
    StatusEffectChangeRecycleRequirement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectChangeRecycleRequirement>.NativeClassPtr, 100675724);
  }

  public StatusEffectChangeRecycleRequirement(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool lower
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectChangeRecycleRequirement.NativeFieldInfoPtr_lower));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectChangeRecycleRequirement.NativeFieldInfoPtr_lower)) = value;
    }
  }
}
