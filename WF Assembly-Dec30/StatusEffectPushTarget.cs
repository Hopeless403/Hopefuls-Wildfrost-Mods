// Decompiled with JetBrains decompiler
// Type: StatusEffectPushTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class StatusEffectPushTarget : StatusEffectData
{
  private static readonly IntPtr NativeFieldInfoPtr_storedHit;
  private static readonly IntPtr NativeMethodInfoPtr_RunPreAttackEvent_Public_Virtual_Boolean_Hit_0;
  private static readonly IntPtr NativeMethodInfoPtr_RunHitEvent_Public_Virtual_Boolean_Hit_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127109, XrefRangeEnd = 127120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunPreAttackEvent(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectPushTarget.NativeMethodInfoPtr_RunPreAttackEvent_Public_Virtual_Boolean_Hit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127120, XrefRangeEnd = 127135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunHitEvent(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectPushTarget.NativeMethodInfoPtr_RunHitEvent_Public_Virtual_Boolean_Hit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(23)]
  [CachedScanResults(RefRangeStart = 118133, RefRangeEnd = 118156, XrefRangeStart = 118133, XrefRangeEnd = 118156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectPushTarget()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectPushTarget>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectPushTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatusEffectPushTarget()
  {
    Il2CppClassPointerStore<StatusEffectPushTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusEffectPushTarget));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectPushTarget>.NativeClassPtr);
    StatusEffectPushTarget.NativeFieldInfoPtr_storedHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectPushTarget>.NativeClassPtr, nameof (storedHit));
    StatusEffectPushTarget.NativeMethodInfoPtr_RunPreAttackEvent_Public_Virtual_Boolean_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectPushTarget>.NativeClassPtr, 100676438);
    StatusEffectPushTarget.NativeMethodInfoPtr_RunHitEvent_Public_Virtual_Boolean_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectPushTarget>.NativeClassPtr, 100676439);
    StatusEffectPushTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectPushTarget>.NativeClassPtr, 100676440);
  }

  public StatusEffectPushTarget(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Hit storedHit
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectPushTarget.NativeFieldInfoPtr_storedHit));
      return pointer == IntPtr.Zero ? (Hit) null : new Hit(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectPushTarget.NativeFieldInfoPtr_storedHit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
