// Decompiled with JetBrains decompiler
// Type: StatusEffectResistX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class StatusEffectResistX : StatusEffectData
{
  private static readonly IntPtr NativeFieldInfoPtr_resistType;
  private static readonly IntPtr NativeMethodInfoPtr_RunApplyStatusEvent_Public_Virtual_Boolean_StatusEffectApply_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117986, XrefRangeEnd = 117993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunApplyStatusEvent(StatusEffectApply apply)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) apply)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectResistX.NativeMethodInfoPtr_RunApplyStatusEvent_Public_Virtual_Boolean_StatusEffectApply_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117993, XrefRangeEnd = 117998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectResistX()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectResistX>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectResistX.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatusEffectResistX()
  {
    Il2CppClassPointerStore<StatusEffectResistX>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusEffectResistX));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectResistX>.NativeClassPtr);
    StatusEffectResistX.NativeFieldInfoPtr_resistType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectResistX>.NativeClassPtr, nameof (resistType));
    StatusEffectResistX.NativeMethodInfoPtr_RunApplyStatusEvent_Public_Virtual_Boolean_StatusEffectApply_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectResistX>.NativeClassPtr, 100674658);
    StatusEffectResistX.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectResistX>.NativeClassPtr, 100674659);
  }

  public StatusEffectResistX(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string resistType
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectResistX.NativeFieldInfoPtr_resistType)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectResistX.NativeFieldInfoPtr_resistType), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
