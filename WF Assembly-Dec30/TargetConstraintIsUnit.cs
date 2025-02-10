// Decompiled with JetBrains decompiler
// Type: TargetConstraintIsUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class TargetConstraintIsUnit : TargetConstraint
{
  private static readonly IntPtr NativeFieldInfoPtr_mustBeMiniboss;
  private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Virtual_Boolean_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Virtual_Boolean_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckMiniboss_Private_Boolean_CardType_0;
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
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetConstraintIsUnit.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24319, XrefRangeEnd = 24326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Check(CardData targetData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetData)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetConstraintIsUnit.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public unsafe bool CheckMiniboss(CardType cardType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardType)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetConstraintIsUnit.NativeMethodInfoPtr_CheckMiniboss_Private_Boolean_CardType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TargetConstraintIsUnit()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetConstraintIsUnit>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetConstraintIsUnit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TargetConstraintIsUnit()
  {
    Il2CppClassPointerStore<TargetConstraintIsUnit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TargetConstraintIsUnit));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetConstraintIsUnit>.NativeClassPtr);
    TargetConstraintIsUnit.NativeFieldInfoPtr_mustBeMiniboss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetConstraintIsUnit>.NativeClassPtr, nameof (mustBeMiniboss));
    TargetConstraintIsUnit.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintIsUnit>.NativeClassPtr, 100664315);
    TargetConstraintIsUnit.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintIsUnit>.NativeClassPtr, 100664316);
    TargetConstraintIsUnit.NativeMethodInfoPtr_CheckMiniboss_Private_Boolean_CardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintIsUnit>.NativeClassPtr, 100664317);
    TargetConstraintIsUnit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintIsUnit>.NativeClassPtr, 100664318);
  }

  public TargetConstraintIsUnit(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool mustBeMiniboss
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetConstraintIsUnit.NativeFieldInfoPtr_mustBeMiniboss));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetConstraintIsUnit.NativeFieldInfoPtr_mustBeMiniboss)) = value;
    }
  }
}
