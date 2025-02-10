// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenYAppliedToAlly
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class StatusEffectApplyXWhenYAppliedToAlly : StatusEffectApplyX
{
  private static readonly IntPtr NativeFieldInfoPtr_whenAppliedType;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_RunPostApplyStatusEvent_Public_Virtual_Boolean_StatusEffectApply_0;
  private static readonly IntPtr NativeMethodInfoPtr_Check_Private_IEnumerator_StatusEffectApply_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123019, XrefRangeEnd = 123027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectApplyXWhenYAppliedToAlly.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123027, XrefRangeEnd = 123036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunPostApplyStatusEvent(StatusEffectApply apply)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) apply)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectApplyXWhenYAppliedToAlly.NativeMethodInfoPtr_RunPostApplyStatusEvent_Public_Virtual_Boolean_StatusEffectApply_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Check(StatusEffectApply apply)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) apply)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXWhenYAppliedToAlly.NativeMethodInfoPtr_Check_Private_IEnumerator_StatusEffectApply_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123036, XrefRangeEnd = 123041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectApplyXWhenYAppliedToAlly()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedToAlly>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXWhenYAppliedToAlly.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatusEffectApplyXWhenYAppliedToAlly()
  {
    Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedToAlly>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusEffectApplyXWhenYAppliedToAlly));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedToAlly>.NativeClassPtr);
    StatusEffectApplyXWhenYAppliedToAlly.NativeFieldInfoPtr_whenAppliedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedToAlly>.NativeClassPtr, nameof (whenAppliedType));
    StatusEffectApplyXWhenYAppliedToAlly.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedToAlly>.NativeClassPtr, 100675623);
    StatusEffectApplyXWhenYAppliedToAlly.NativeMethodInfoPtr_RunPostApplyStatusEvent_Public_Virtual_Boolean_StatusEffectApply_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedToAlly>.NativeClassPtr, 100675624);
    StatusEffectApplyXWhenYAppliedToAlly.NativeMethodInfoPtr_Check_Private_IEnumerator_StatusEffectApply_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedToAlly>.NativeClassPtr, 100675625);
    StatusEffectApplyXWhenYAppliedToAlly.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedToAlly>.NativeClassPtr, 100675626);
  }

  public StatusEffectApplyXWhenYAppliedToAlly(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string whenAppliedType
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenYAppliedToAlly.NativeFieldInfoPtr_whenAppliedType)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenYAppliedToAlly.NativeFieldInfoPtr_whenAppliedType), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
