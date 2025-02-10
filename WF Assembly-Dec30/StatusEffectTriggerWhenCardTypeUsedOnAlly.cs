// Decompiled with JetBrains decompiler
// Type: StatusEffectTriggerWhenCardTypeUsedOnAlly
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
public class StatusEffectTriggerWhenCardTypeUsedOnAlly : StatusEffectReaction
{
  private static readonly IntPtr NativeFieldInfoPtr_includeSelf;
  private static readonly IntPtr NativeFieldInfoPtr_cardTypeTriggers;
  private static readonly IntPtr NativeMethodInfoPtr_RunCardPlayedEvent_Public_Virtual_Boolean_Entity_Il2CppReferenceArray_1_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckCardType_Private_Boolean_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckTargets_Private_Boolean_Il2CppReferenceArray_1_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120749, XrefRangeEnd = 120768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunCardPlayedEvent(
    Entity entity,
    Il2CppReferenceArray<Entity> targets)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targets);
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectTriggerWhenCardTypeUsedOnAlly.NativeMethodInfoPtr_RunCardPlayedEvent_Public_Virtual_Boolean_Entity_Il2CppReferenceArray_1_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120768, XrefRangeEnd = 120770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckCardType(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectTriggerWhenCardTypeUsedOnAlly.NativeMethodInfoPtr_CheckCardType_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120770, XrefRangeEnd = 120778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckTargets(Il2CppReferenceArray<Entity> targets)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targets)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectTriggerWhenCardTypeUsedOnAlly.NativeMethodInfoPtr_CheckTargets_Private_Boolean_Il2CppReferenceArray_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(23)]
  [CachedScanResults(RefRangeStart = 118133, RefRangeEnd = 118156, XrefRangeStart = 118133, XrefRangeEnd = 118156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectTriggerWhenCardTypeUsedOnAlly()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectTriggerWhenCardTypeUsedOnAlly>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectTriggerWhenCardTypeUsedOnAlly.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatusEffectTriggerWhenCardTypeUsedOnAlly()
  {
    Il2CppClassPointerStore<StatusEffectTriggerWhenCardTypeUsedOnAlly>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusEffectTriggerWhenCardTypeUsedOnAlly));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectTriggerWhenCardTypeUsedOnAlly>.NativeClassPtr);
    StatusEffectTriggerWhenCardTypeUsedOnAlly.NativeFieldInfoPtr_includeSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectTriggerWhenCardTypeUsedOnAlly>.NativeClassPtr, nameof (includeSelf));
    StatusEffectTriggerWhenCardTypeUsedOnAlly.NativeFieldInfoPtr_cardTypeTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectTriggerWhenCardTypeUsedOnAlly>.NativeClassPtr, nameof (cardTypeTriggers));
    StatusEffectTriggerWhenCardTypeUsedOnAlly.NativeMethodInfoPtr_RunCardPlayedEvent_Public_Virtual_Boolean_Entity_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectTriggerWhenCardTypeUsedOnAlly>.NativeClassPtr, 100675265);
    StatusEffectTriggerWhenCardTypeUsedOnAlly.NativeMethodInfoPtr_CheckCardType_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectTriggerWhenCardTypeUsedOnAlly>.NativeClassPtr, 100675266);
    StatusEffectTriggerWhenCardTypeUsedOnAlly.NativeMethodInfoPtr_CheckTargets_Private_Boolean_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectTriggerWhenCardTypeUsedOnAlly>.NativeClassPtr, 100675267);
    StatusEffectTriggerWhenCardTypeUsedOnAlly.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectTriggerWhenCardTypeUsedOnAlly>.NativeClassPtr, 100675268);
  }

  public StatusEffectTriggerWhenCardTypeUsedOnAlly(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool includeSelf
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectTriggerWhenCardTypeUsedOnAlly.NativeFieldInfoPtr_includeSelf));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectTriggerWhenCardTypeUsedOnAlly.NativeFieldInfoPtr_includeSelf)) = value;
    }
  }

  public unsafe Il2CppStringArray cardTypeTriggers
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectTriggerWhenCardTypeUsedOnAlly.NativeFieldInfoPtr_cardTypeTriggers));
      return pointer == IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectTriggerWhenCardTypeUsedOnAlly.NativeFieldInfoPtr_cardTypeTriggers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
