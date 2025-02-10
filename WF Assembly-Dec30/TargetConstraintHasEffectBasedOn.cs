// Decompiled with JetBrains decompiler
// Type: TargetConstraintHasEffectBasedOn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class TargetConstraintHasEffectBasedOn : TargetConstraint
{
  private static readonly IntPtr NativeFieldInfoPtr_basedOnStatusType;
  private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Virtual_Boolean_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Virtual_Boolean_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24171, XrefRangeEnd = 24182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Check(CardData targetData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetData)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetConstraintHasEffectBasedOn.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Check(Entity target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetConstraintHasEffectBasedOn.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TargetConstraintHasEffectBasedOn()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetConstraintHasEffectBasedOn>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetConstraintHasEffectBasedOn.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TargetConstraintHasEffectBasedOn()
  {
    Il2CppClassPointerStore<TargetConstraintHasEffectBasedOn>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TargetConstraintHasEffectBasedOn));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetConstraintHasEffectBasedOn>.NativeClassPtr);
    TargetConstraintHasEffectBasedOn.NativeFieldInfoPtr_basedOnStatusType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetConstraintHasEffectBasedOn>.NativeClassPtr, nameof (basedOnStatusType));
    TargetConstraintHasEffectBasedOn.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintHasEffectBasedOn>.NativeClassPtr, 100664272);
    TargetConstraintHasEffectBasedOn.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintHasEffectBasedOn>.NativeClassPtr, 100664273);
    TargetConstraintHasEffectBasedOn.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintHasEffectBasedOn>.NativeClassPtr, 100664274);
  }

  public TargetConstraintHasEffectBasedOn(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string basedOnStatusType
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetConstraintHasEffectBasedOn.NativeFieldInfoPtr_basedOnStatusType)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetConstraintHasEffectBasedOn.NativeFieldInfoPtr_basedOnStatusType), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
