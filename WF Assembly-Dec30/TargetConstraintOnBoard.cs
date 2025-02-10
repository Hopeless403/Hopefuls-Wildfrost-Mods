// Decompiled with JetBrains decompiler
// Type: TargetConstraintOnBoard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
public class TargetConstraintOnBoard : TargetConstraint
{
  private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Virtual_Boolean_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Virtual_Boolean_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24328, XrefRangeEnd = 24329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Check(Entity target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetConstraintOnBoard.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 23871, RefRangeEnd = 23873, XrefRangeStart = 23871, XrefRangeEnd = 23873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Check(CardData targetData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetData)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetConstraintOnBoard.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TargetConstraintOnBoard()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetConstraintOnBoard>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetConstraintOnBoard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TargetConstraintOnBoard()
  {
    Il2CppClassPointerStore<TargetConstraintOnBoard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TargetConstraintOnBoard));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetConstraintOnBoard>.NativeClassPtr);
    TargetConstraintOnBoard.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintOnBoard>.NativeClassPtr, 100664325);
    TargetConstraintOnBoard.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintOnBoard>.NativeClassPtr, 100664326);
    TargetConstraintOnBoard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintOnBoard>.NativeClassPtr, 100664327);
  }

  public TargetConstraintOnBoard(IntPtr pointer)
    : base(pointer)
  {
  }
}
