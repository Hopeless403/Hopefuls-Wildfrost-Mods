// Decompiled with JetBrains decompiler
// Type: CardScriptRemovePassiveEffect
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
public class CardScriptRemovePassiveEffect : CardScript
{
  private static readonly IntPtr NativeFieldInfoPtr_removeAll;
  private static readonly IntPtr NativeFieldInfoPtr_toRemove;
  private static readonly IntPtr NativeFieldInfoPtr_excludingStatusEffects;
  private static readonly IntPtr NativeFieldInfoPtr_excluding;
  private static readonly IntPtr NativeFieldInfoPtr_excludingTypes;
  private static readonly IntPtr NativeFieldInfoPtr_reduceStacks;
  private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr_Exclude_Private_Boolean_StatusEffectData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__Run_b__6_0_Private_Boolean_StatusEffectStacks_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20513, XrefRangeEnd = 20553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Run(CardData target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardScriptRemovePassiveEffect.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20553, XrefRangeEnd = 20557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Exclude(StatusEffectData effectData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) effectData)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardScriptRemovePassiveEffect.NativeMethodInfoPtr_Exclude_Private_Boolean_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardScriptRemovePassiveEffect()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardScriptRemovePassiveEffect>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardScriptRemovePassiveEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20557, XrefRangeEnd = 20561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool _Run_b__6_0(CardData.StatusEffectStacks a)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardScriptRemovePassiveEffect.NativeMethodInfoPtr__Run_b__6_0_Private_Boolean_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  static CardScriptRemovePassiveEffect()
  {
    Il2CppClassPointerStore<CardScriptRemovePassiveEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardScriptRemovePassiveEffect));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardScriptRemovePassiveEffect>.NativeClassPtr);
    CardScriptRemovePassiveEffect.NativeFieldInfoPtr_removeAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptRemovePassiveEffect>.NativeClassPtr, nameof (removeAll));
    CardScriptRemovePassiveEffect.NativeFieldInfoPtr_toRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptRemovePassiveEffect>.NativeClassPtr, nameof (toRemove));
    CardScriptRemovePassiveEffect.NativeFieldInfoPtr_excludingStatusEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptRemovePassiveEffect>.NativeClassPtr, nameof (excludingStatusEffects));
    CardScriptRemovePassiveEffect.NativeFieldInfoPtr_excluding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptRemovePassiveEffect>.NativeClassPtr, nameof (excluding));
    CardScriptRemovePassiveEffect.NativeFieldInfoPtr_excludingTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptRemovePassiveEffect>.NativeClassPtr, nameof (excludingTypes));
    CardScriptRemovePassiveEffect.NativeFieldInfoPtr_reduceStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptRemovePassiveEffect>.NativeClassPtr, nameof (reduceStacks));
    CardScriptRemovePassiveEffect.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptRemovePassiveEffect>.NativeClassPtr, 100663798);
    CardScriptRemovePassiveEffect.NativeMethodInfoPtr_Exclude_Private_Boolean_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptRemovePassiveEffect>.NativeClassPtr, 100663799);
    CardScriptRemovePassiveEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptRemovePassiveEffect>.NativeClassPtr, 100663800);
    CardScriptRemovePassiveEffect.NativeMethodInfoPtr__Run_b__6_0_Private_Boolean_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptRemovePassiveEffect>.NativeClassPtr, 100663801);
  }

  public CardScriptRemovePassiveEffect(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool removeAll
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRemovePassiveEffect.NativeFieldInfoPtr_removeAll));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRemovePassiveEffect.NativeFieldInfoPtr_removeAll)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<StatusEffectData> toRemove
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRemovePassiveEffect.NativeFieldInfoPtr_toRemove));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<StatusEffectData>) null : new Il2CppReferenceArray<StatusEffectData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRemovePassiveEffect.NativeFieldInfoPtr_toRemove), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool excludingStatusEffects
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRemovePassiveEffect.NativeFieldInfoPtr_excludingStatusEffects));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRemovePassiveEffect.NativeFieldInfoPtr_excludingStatusEffects)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<StatusEffectData> excluding
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRemovePassiveEffect.NativeFieldInfoPtr_excluding));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<StatusEffectData>) null : new Il2CppReferenceArray<StatusEffectData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRemovePassiveEffect.NativeFieldInfoPtr_excluding), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStringArray excludingTypes
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRemovePassiveEffect.NativeFieldInfoPtr_excludingTypes));
      return pointer == IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRemovePassiveEffect.NativeFieldInfoPtr_excludingTypes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int reduceStacks
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRemovePassiveEffect.NativeFieldInfoPtr_reduceStacks));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRemovePassiveEffect.NativeFieldInfoPtr_reduceStacks)) = value;
    }
  }
}
