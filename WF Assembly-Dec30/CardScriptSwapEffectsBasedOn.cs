// Decompiled with JetBrains decompiler
// Type: CardScriptSwapEffectsBasedOn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class CardScriptSwapEffectsBasedOn : CardScript
{
  private static readonly IntPtr NativeFieldInfoPtr_statusA;
  private static readonly IntPtr NativeFieldInfoPtr_statusB;
  private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr_Swap_Private_Static_Boolean_StatusEffectStacks_StatusEffectData_StatusEffectData_0;
  private static readonly IntPtr NativeMethodInfoPtr_TrySwap_Private_Static_Void_StatusEffectInstantDoubleX_StatusEffectStacks_StatusEffectData_StatusEffectData_0;
  private static readonly IntPtr NativeMethodInfoPtr_TrySwap_Private_Static_Void_StatusEffectApplyX_StatusEffectStacks_StatusEffectData_StatusEffectData_0;
  private static readonly IntPtr NativeMethodInfoPtr_TrySwap_Private_Static_Void_StatusEffectApplyXWhenYAppliedTo_StatusEffectStacks_StatusEffectData_StatusEffectData_0;
  private static readonly IntPtr NativeMethodInfoPtr_TrySwap_Private_Static_Void_StatusEffectApplyXWhenYAppliedToAlly_StatusEffectStacks_StatusEffectData_StatusEffectData_0;
  private static readonly IntPtr NativeMethodInfoPtr_TrySwap_Private_Static_Void_StatusEffectApplyXWhenYAppliedToSelf_StatusEffectStacks_StatusEffectData_StatusEffectData_0;
  private static readonly IntPtr NativeMethodInfoPtr_TrySwap_Private_Static_Void_StatusEffectBonusDamageEqualToX_StatusEffectStacks_StatusEffectData_StatusEffectData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20620, XrefRangeEnd = 20678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Run(CardData target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardScriptSwapEffectsBasedOn.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 20722, RefRangeEnd = 20731, XrefRangeStart = 20678, XrefRangeEnd = 20722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Swap(
    CardData.StatusEffectStacks stacks,
    StatusEffectData a,
    StatusEffectData b)
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stacks);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardScriptSwapEffectsBasedOn.NativeMethodInfoPtr_Swap_Private_Static_Boolean_StatusEffectStacks_StatusEffectData_StatusEffectData_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20731, XrefRangeEnd = 20738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void TrySwap(
    StatusEffectInstantDoubleX effect,
    CardData.StatusEffectStacks stacks,
    StatusEffectData a,
    StatusEffectData b)
  {
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) effect);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stacks);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardScriptSwapEffectsBasedOn.NativeMethodInfoPtr_TrySwap_Private_Static_Void_StatusEffectInstantDoubleX_StatusEffectStacks_StatusEffectData_StatusEffectData_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20738, XrefRangeEnd = 20745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void TrySwap(
    StatusEffectApplyX effect,
    CardData.StatusEffectStacks stacks,
    StatusEffectData a,
    StatusEffectData b)
  {
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) effect);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stacks);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardScriptSwapEffectsBasedOn.NativeMethodInfoPtr_TrySwap_Private_Static_Void_StatusEffectApplyX_StatusEffectStacks_StatusEffectData_StatusEffectData_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20745, XrefRangeEnd = 20757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void TrySwap(
    StatusEffectApplyXWhenYAppliedTo effect,
    CardData.StatusEffectStacks stacks,
    StatusEffectData a,
    StatusEffectData b)
  {
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) effect);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stacks);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardScriptSwapEffectsBasedOn.NativeMethodInfoPtr_TrySwap_Private_Static_Void_StatusEffectApplyXWhenYAppliedTo_StatusEffectStacks_StatusEffectData_StatusEffectData_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20757, XrefRangeEnd = 20769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void TrySwap(
    StatusEffectApplyXWhenYAppliedToAlly effect,
    CardData.StatusEffectStacks stacks,
    StatusEffectData a,
    StatusEffectData b)
  {
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) effect);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stacks);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardScriptSwapEffectsBasedOn.NativeMethodInfoPtr_TrySwap_Private_Static_Void_StatusEffectApplyXWhenYAppliedToAlly_StatusEffectStacks_StatusEffectData_StatusEffectData_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20769, XrefRangeEnd = 20781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void TrySwap(
    StatusEffectApplyXWhenYAppliedToSelf effect,
    CardData.StatusEffectStacks stacks,
    StatusEffectData a,
    StatusEffectData b)
  {
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) effect);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stacks);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardScriptSwapEffectsBasedOn.NativeMethodInfoPtr_TrySwap_Private_Static_Void_StatusEffectApplyXWhenYAppliedToSelf_StatusEffectStacks_StatusEffectData_StatusEffectData_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20781, XrefRangeEnd = 20784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void TrySwap(
    StatusEffectBonusDamageEqualToX effect,
    CardData.StatusEffectStacks stacks,
    StatusEffectData a,
    StatusEffectData b)
  {
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) effect);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stacks);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardScriptSwapEffectsBasedOn.NativeMethodInfoPtr_TrySwap_Private_Static_Void_StatusEffectBonusDamageEqualToX_StatusEffectStacks_StatusEffectData_StatusEffectData_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardScriptSwapEffectsBasedOn()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardScriptSwapEffectsBasedOn>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardScriptSwapEffectsBasedOn.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardScriptSwapEffectsBasedOn()
  {
    Il2CppClassPointerStore<CardScriptSwapEffectsBasedOn>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardScriptSwapEffectsBasedOn));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardScriptSwapEffectsBasedOn>.NativeClassPtr);
    CardScriptSwapEffectsBasedOn.NativeFieldInfoPtr_statusA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptSwapEffectsBasedOn>.NativeClassPtr, nameof (statusA));
    CardScriptSwapEffectsBasedOn.NativeFieldInfoPtr_statusB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptSwapEffectsBasedOn>.NativeClassPtr, nameof (statusB));
    CardScriptSwapEffectsBasedOn.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptSwapEffectsBasedOn>.NativeClassPtr, 100663810);
    CardScriptSwapEffectsBasedOn.NativeMethodInfoPtr_Swap_Private_Static_Boolean_StatusEffectStacks_StatusEffectData_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptSwapEffectsBasedOn>.NativeClassPtr, 100663811);
    CardScriptSwapEffectsBasedOn.NativeMethodInfoPtr_TrySwap_Private_Static_Void_StatusEffectInstantDoubleX_StatusEffectStacks_StatusEffectData_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptSwapEffectsBasedOn>.NativeClassPtr, 100663812);
    CardScriptSwapEffectsBasedOn.NativeMethodInfoPtr_TrySwap_Private_Static_Void_StatusEffectApplyX_StatusEffectStacks_StatusEffectData_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptSwapEffectsBasedOn>.NativeClassPtr, 100663813);
    CardScriptSwapEffectsBasedOn.NativeMethodInfoPtr_TrySwap_Private_Static_Void_StatusEffectApplyXWhenYAppliedTo_StatusEffectStacks_StatusEffectData_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptSwapEffectsBasedOn>.NativeClassPtr, 100663814);
    CardScriptSwapEffectsBasedOn.NativeMethodInfoPtr_TrySwap_Private_Static_Void_StatusEffectApplyXWhenYAppliedToAlly_StatusEffectStacks_StatusEffectData_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptSwapEffectsBasedOn>.NativeClassPtr, 100663815);
    CardScriptSwapEffectsBasedOn.NativeMethodInfoPtr_TrySwap_Private_Static_Void_StatusEffectApplyXWhenYAppliedToSelf_StatusEffectStacks_StatusEffectData_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptSwapEffectsBasedOn>.NativeClassPtr, 100663816);
    CardScriptSwapEffectsBasedOn.NativeMethodInfoPtr_TrySwap_Private_Static_Void_StatusEffectBonusDamageEqualToX_StatusEffectStacks_StatusEffectData_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptSwapEffectsBasedOn>.NativeClassPtr, 100663817);
    CardScriptSwapEffectsBasedOn.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptSwapEffectsBasedOn>.NativeClassPtr, 100663818);
  }

  public CardScriptSwapEffectsBasedOn(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe StatusEffectData statusA
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptSwapEffectsBasedOn.NativeFieldInfoPtr_statusA));
      return pointer == IntPtr.Zero ? (StatusEffectData) null : new StatusEffectData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardScriptSwapEffectsBasedOn.NativeFieldInfoPtr_statusA), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData statusB
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptSwapEffectsBasedOn.NativeFieldInfoPtr_statusB));
      return pointer == IntPtr.Zero ? (StatusEffectData) null : new StatusEffectData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardScriptSwapEffectsBasedOn.NativeFieldInfoPtr_statusB), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
