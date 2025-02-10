// Decompiled with JetBrains decompiler
// Type: TargetConstraintIsCardType
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
public class TargetConstraintIsCardType : TargetConstraint
{
  private static readonly IntPtr NativeFieldInfoPtr_allowedTypes;
  private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Virtual_Boolean_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Virtual_Boolean_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetConstraintIsCardType.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24296, XrefRangeEnd = 24299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Check(CardData targetData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetData)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetConstraintIsCardType.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TargetConstraintIsCardType()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetConstraintIsCardType>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetConstraintIsCardType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TargetConstraintIsCardType()
  {
    Il2CppClassPointerStore<TargetConstraintIsCardType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TargetConstraintIsCardType));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetConstraintIsCardType>.NativeClassPtr);
    TargetConstraintIsCardType.NativeFieldInfoPtr_allowedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetConstraintIsCardType>.NativeClassPtr, nameof (allowedTypes));
    TargetConstraintIsCardType.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintIsCardType>.NativeClassPtr, 100664301);
    TargetConstraintIsCardType.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintIsCardType>.NativeClassPtr, 100664302);
    TargetConstraintIsCardType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintIsCardType>.NativeClassPtr, 100664303);
  }

  public TargetConstraintIsCardType(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<CardType> allowedTypes
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetConstraintIsCardType.NativeFieldInfoPtr_allowedTypes));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<CardType>) null : new Il2CppReferenceArray<CardType>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetConstraintIsCardType.NativeFieldInfoPtr_allowedTypes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
