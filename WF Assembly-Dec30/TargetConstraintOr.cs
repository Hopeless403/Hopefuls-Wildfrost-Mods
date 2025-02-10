// Decompiled with JetBrains decompiler
// Type: TargetConstraintOr
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class TargetConstraintOr : TargetConstraint
{
  private static readonly IntPtr NativeFieldInfoPtr_constraints;
  private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Virtual_Boolean_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Virtual_Boolean_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24329, XrefRangeEnd = 24330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Check(Entity target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetConstraintOr.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24330, XrefRangeEnd = 24331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Check(CardData targetData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetData)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetConstraintOr.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TargetConstraintOr()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetConstraintOr>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetConstraintOr.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TargetConstraintOr()
  {
    Il2CppClassPointerStore<TargetConstraintOr>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TargetConstraintOr));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetConstraintOr>.NativeClassPtr);
    TargetConstraintOr.NativeFieldInfoPtr_constraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetConstraintOr>.NativeClassPtr, nameof (constraints));
    TargetConstraintOr.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintOr>.NativeClassPtr, 100664328);
    TargetConstraintOr.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintOr>.NativeClassPtr, 100664329);
    TargetConstraintOr.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintOr>.NativeClassPtr, 100664330);
  }

  public TargetConstraintOr(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<TargetConstraint> constraints
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetConstraintOr.NativeFieldInfoPtr_constraints));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<TargetConstraint>) null : new Il2CppReferenceArray<TargetConstraint>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetConstraintOr.NativeFieldInfoPtr_constraints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
