// Decompiled with JetBrains decompiler
// Type: StatusEffectChangePriorityPosition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class StatusEffectChangePriorityPosition : StatusEffectData
{
  private static readonly IntPtr NativeFieldInfoPtr_positionPriorityChange;
  private static readonly IntPtr NativeFieldInfoPtr_pre;
  private static readonly IntPtr NativeMethodInfoPtr_RunBeginEvent_Public_Virtual_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_RunEndEvent_Public_Virtual_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_RunEffectBonusChangedEvent_Public_Virtual_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126737, XrefRangeEnd = 126738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunBeginEvent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectChangePriorityPosition.NativeMethodInfoPtr_RunBeginEvent_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public override unsafe bool RunEndEvent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectChangePriorityPosition.NativeMethodInfoPtr_RunEndEvent_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public override unsafe bool RunEffectBonusChangedEvent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectChangePriorityPosition.NativeMethodInfoPtr_RunEffectBonusChangedEvent_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126738, XrefRangeEnd = 126739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectChangePriorityPosition()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectChangePriorityPosition>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectChangePriorityPosition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatusEffectChangePriorityPosition()
  {
    Il2CppClassPointerStore<StatusEffectChangePriorityPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusEffectChangePriorityPosition));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectChangePriorityPosition>.NativeClassPtr);
    StatusEffectChangePriorityPosition.NativeFieldInfoPtr_positionPriorityChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectChangePriorityPosition>.NativeClassPtr, nameof (positionPriorityChange));
    StatusEffectChangePriorityPosition.NativeFieldInfoPtr_pre = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectChangePriorityPosition>.NativeClassPtr, nameof (pre));
    StatusEffectChangePriorityPosition.NativeMethodInfoPtr_RunBeginEvent_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectChangePriorityPosition>.NativeClassPtr, 100676365);
    StatusEffectChangePriorityPosition.NativeMethodInfoPtr_RunEndEvent_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectChangePriorityPosition>.NativeClassPtr, 100676366);
    StatusEffectChangePriorityPosition.NativeMethodInfoPtr_RunEffectBonusChangedEvent_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectChangePriorityPosition>.NativeClassPtr, 100676367);
    StatusEffectChangePriorityPosition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectChangePriorityPosition>.NativeClassPtr, 100676368);
  }

  public StatusEffectChangePriorityPosition(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int positionPriorityChange
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectChangePriorityPosition.NativeFieldInfoPtr_positionPriorityChange));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectChangePriorityPosition.NativeFieldInfoPtr_positionPriorityChange)) = value;
    }
  }

  public unsafe int pre
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectChangePriorityPosition.NativeFieldInfoPtr_pre));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectChangePriorityPosition.NativeFieldInfoPtr_pre)) = value;
    }
  }
}
