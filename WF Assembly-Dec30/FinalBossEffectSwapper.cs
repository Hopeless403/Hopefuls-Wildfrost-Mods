// Decompiled with JetBrains decompiler
// Type: FinalBossEffectSwapper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class FinalBossEffectSwapper : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_effect;
  private static readonly IntPtr NativeFieldInfoPtr_remove;
  private static readonly IntPtr NativeFieldInfoPtr_replaceWithOptions;
  private static readonly IntPtr NativeFieldInfoPtr_replaceWithAttackEffect;
  private static readonly IntPtr NativeFieldInfoPtr_boostRange;
  private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Void_CardData_StatusEffectStacks_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 109124, RefRangeEnd = 109125, XrefRangeStart = 109091, XrefRangeEnd = 109124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Process(CardData card, CardData.StatusEffectStacks stack, int stackIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stack);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &stackIndex;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossEffectSwapper.NativeMethodInfoPtr_Process_Public_Void_CardData_StatusEffectStacks_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109125, XrefRangeEnd = 109126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FinalBossEffectSwapper()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalBossEffectSwapper>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossEffectSwapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static FinalBossEffectSwapper()
  {
    Il2CppClassPointerStore<FinalBossEffectSwapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (FinalBossEffectSwapper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBossEffectSwapper>.NativeClassPtr);
    FinalBossEffectSwapper.NativeFieldInfoPtr_effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossEffectSwapper>.NativeClassPtr, nameof (effect));
    FinalBossEffectSwapper.NativeFieldInfoPtr_remove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossEffectSwapper>.NativeClassPtr, nameof (remove));
    FinalBossEffectSwapper.NativeFieldInfoPtr_replaceWithOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossEffectSwapper>.NativeClassPtr, nameof (replaceWithOptions));
    FinalBossEffectSwapper.NativeFieldInfoPtr_replaceWithAttackEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossEffectSwapper>.NativeClassPtr, nameof (replaceWithAttackEffect));
    FinalBossEffectSwapper.NativeFieldInfoPtr_boostRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossEffectSwapper>.NativeClassPtr, nameof (boostRange));
    FinalBossEffectSwapper.NativeMethodInfoPtr_Process_Public_Void_CardData_StatusEffectStacks_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossEffectSwapper>.NativeClassPtr, 100673370);
    FinalBossEffectSwapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossEffectSwapper>.NativeClassPtr, 100673371);
  }

  public FinalBossEffectSwapper(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe StatusEffectData effect
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossEffectSwapper.NativeFieldInfoPtr_effect));
      return pointer == IntPtr.Zero ? (StatusEffectData) null : new StatusEffectData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossEffectSwapper.NativeFieldInfoPtr_effect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool remove
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossEffectSwapper.NativeFieldInfoPtr_remove));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossEffectSwapper.NativeFieldInfoPtr_remove)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<StatusEffectData> replaceWithOptions
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossEffectSwapper.NativeFieldInfoPtr_replaceWithOptions));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<StatusEffectData>) null : new Il2CppReferenceArray<StatusEffectData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossEffectSwapper.NativeFieldInfoPtr_replaceWithOptions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData replaceWithAttackEffect
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossEffectSwapper.NativeFieldInfoPtr_replaceWithAttackEffect));
      return pointer == IntPtr.Zero ? (StatusEffectData) null : new StatusEffectData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossEffectSwapper.NativeFieldInfoPtr_replaceWithAttackEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2Int boostRange
  {
    get
    {
      return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossEffectSwapper.NativeFieldInfoPtr_boostRange));
    }
    [param: In] set
    {
      *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossEffectSwapper.NativeFieldInfoPtr_boostRange)) = value;
    }
  }
}
