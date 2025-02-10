// Decompiled with JetBrains decompiler
// Type: CardScriptRemoveAttackEffect
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
public class CardScriptRemoveAttackEffect : CardScript
{
  private static readonly IntPtr NativeFieldInfoPtr_removeAll;
  private static readonly IntPtr NativeFieldInfoPtr_toRemove;
  private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__Run_b__2_0_Private_Boolean_StatusEffectStacks_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20486, XrefRangeEnd = 20509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Run(CardData target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardScriptRemoveAttackEffect.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardScriptRemoveAttackEffect()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardScriptRemoveAttackEffect>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardScriptRemoveAttackEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20509, XrefRangeEnd = 20513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool _Run_b__2_0(CardData.StatusEffectStacks a)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardScriptRemoveAttackEffect.NativeMethodInfoPtr__Run_b__2_0_Private_Boolean_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  static CardScriptRemoveAttackEffect()
  {
    Il2CppClassPointerStore<CardScriptRemoveAttackEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardScriptRemoveAttackEffect));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardScriptRemoveAttackEffect>.NativeClassPtr);
    CardScriptRemoveAttackEffect.NativeFieldInfoPtr_removeAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptRemoveAttackEffect>.NativeClassPtr, nameof (removeAll));
    CardScriptRemoveAttackEffect.NativeFieldInfoPtr_toRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptRemoveAttackEffect>.NativeClassPtr, nameof (toRemove));
    CardScriptRemoveAttackEffect.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptRemoveAttackEffect>.NativeClassPtr, 100663795);
    CardScriptRemoveAttackEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptRemoveAttackEffect>.NativeClassPtr, 100663796);
    CardScriptRemoveAttackEffect.NativeMethodInfoPtr__Run_b__2_0_Private_Boolean_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptRemoveAttackEffect>.NativeClassPtr, 100663797);
  }

  public CardScriptRemoveAttackEffect(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool removeAll
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRemoveAttackEffect.NativeFieldInfoPtr_removeAll));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRemoveAttackEffect.NativeFieldInfoPtr_removeAll)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<StatusEffectData> toRemove
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRemoveAttackEffect.NativeFieldInfoPtr_toRemove));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<StatusEffectData>) null : new Il2CppReferenceArray<StatusEffectData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRemoveAttackEffect.NativeFieldInfoPtr_toRemove), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
