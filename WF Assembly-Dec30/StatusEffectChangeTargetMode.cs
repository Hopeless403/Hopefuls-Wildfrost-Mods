// Decompiled with JetBrains decompiler
// Type: StatusEffectChangeTargetMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class StatusEffectChangeTargetMode : StatusEffectData
{
  private static readonly IntPtr NativeFieldInfoPtr_targetMode;
  private static readonly IntPtr NativeFieldInfoPtr_pre;
  private static readonly IntPtr NativeMethodInfoPtr_RunBeginEvent_Public_Virtual_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_RunEndEvent_Public_Virtual_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_RunEffectBonusChangedEvent_Public_Virtual_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126739, XrefRangeEnd = 126742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunBeginEvent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectChangeTargetMode.NativeMethodInfoPtr_RunBeginEvent_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126742, XrefRangeEnd = 126743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunEndEvent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectChangeTargetMode.NativeMethodInfoPtr_RunEndEvent_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public override unsafe bool RunEffectBonusChangedEvent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectChangeTargetMode.NativeMethodInfoPtr_RunEffectBonusChangedEvent_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(23)]
  [CachedScanResults(RefRangeStart = 118133, RefRangeEnd = 118156, XrefRangeStart = 118133, XrefRangeEnd = 118156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectChangeTargetMode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectChangeTargetMode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectChangeTargetMode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatusEffectChangeTargetMode()
  {
    Il2CppClassPointerStore<StatusEffectChangeTargetMode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusEffectChangeTargetMode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectChangeTargetMode>.NativeClassPtr);
    StatusEffectChangeTargetMode.NativeFieldInfoPtr_targetMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectChangeTargetMode>.NativeClassPtr, nameof (targetMode));
    StatusEffectChangeTargetMode.NativeFieldInfoPtr_pre = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectChangeTargetMode>.NativeClassPtr, nameof (pre));
    StatusEffectChangeTargetMode.NativeMethodInfoPtr_RunBeginEvent_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectChangeTargetMode>.NativeClassPtr, 100676369);
    StatusEffectChangeTargetMode.NativeMethodInfoPtr_RunEndEvent_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectChangeTargetMode>.NativeClassPtr, 100676370);
    StatusEffectChangeTargetMode.NativeMethodInfoPtr_RunEffectBonusChangedEvent_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectChangeTargetMode>.NativeClassPtr, 100676371);
    StatusEffectChangeTargetMode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectChangeTargetMode>.NativeClassPtr, 100676372);
  }

  public StatusEffectChangeTargetMode(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe TargetMode targetMode
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectChangeTargetMode.NativeFieldInfoPtr_targetMode));
      return pointer == IntPtr.Zero ? (TargetMode) null : new TargetMode(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectChangeTargetMode.NativeFieldInfoPtr_targetMode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TargetMode pre
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectChangeTargetMode.NativeFieldInfoPtr_pre));
      return pointer == IntPtr.Zero ? (TargetMode) null : new TargetMode(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectChangeTargetMode.NativeFieldInfoPtr_pre), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
