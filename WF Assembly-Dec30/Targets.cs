// Decompiled with JetBrains decompiler
// Type: Targets
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;

#nullable disable
public static class Targets : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckFlag_Public_Static_Boolean_Flag_Flag_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_List_1_Entity_Entity_Flag_StatusEffectData_Il2CppReferenceArray_1_TargetConstraint_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveIneligible_Private_Static_Void_IList_1_Entity_StatusEffectData_Il2CppReferenceArray_1_TargetConstraint_0;

  [CallerCount(0)]
  public static unsafe bool CheckFlag(Targets.Flag flags, Targets.Flag target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &flags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Targets.NativeMethodInfoPtr_CheckFlag_Public_Static_Boolean_Flag_Flag_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 117923, RefRangeEnd = 117924, XrefRangeStart = 117748, XrefRangeEnd = 117923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe List<Entity> Get(
    Entity self,
    Targets.Flag canTarget,
    StatusEffectData effectToApply,
    Il2CppReferenceArray<TargetConstraint> applyConstraints,
    Hit hit = null)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) self);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &canTarget;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) effectToApply);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) applyConstraints);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Targets.NativeMethodInfoPtr_Get_Public_Static_List_1_Entity_Entity_Flag_StatusEffectData_Il2CppReferenceArray_1_TargetConstraint_Hit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<Entity>) null : new List<Entity>(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 117936, RefRangeEnd = 117939, XrefRangeStart = 117924, XrefRangeEnd = 117936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RemoveIneligible(
    IList<Entity> list,
    StatusEffectData effectToApply,
    Il2CppReferenceArray<TargetConstraint> applyConstraints)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) list);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) effectToApply);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) applyConstraints);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Targets.NativeMethodInfoPtr_RemoveIneligible_Private_Static_Void_IList_1_Entity_StatusEffectData_Il2CppReferenceArray_1_TargetConstraint_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Targets()
  {
    Il2CppClassPointerStore<Targets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Targets));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Targets>.NativeClassPtr);
    Targets.NativeMethodInfoPtr_CheckFlag_Public_Static_Boolean_Flag_Flag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Targets>.NativeClassPtr, 100674645);
    Targets.NativeMethodInfoPtr_Get_Public_Static_List_1_Entity_Entity_Flag_StatusEffectData_Il2CppReferenceArray_1_TargetConstraint_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Targets>.NativeClassPtr, 100674646);
    Targets.NativeMethodInfoPtr_RemoveIneligible_Private_Static_Void_IList_1_Entity_StatusEffectData_Il2CppReferenceArray_1_TargetConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Targets>.NativeClassPtr, 100674647);
  }

  public Targets(System.IntPtr pointer)
    : base(pointer)
  {
  }

  [Flags]
  public enum Flag
  {
    None = 0,
    Self = 1,
    Hand = 2,
    EnemyHand = 4,
    Allies = 8,
    AlliesInRow = 16, // 0x00000010
    FrontAlly = 32, // 0x00000020
    BackAlly = 64, // 0x00000040
    AllyInFrontOf = 128, // 0x00000080
    AllyBehind = 256, // 0x00000100
    Enemies = 512, // 0x00000200
    EnemiesInRow = 1024, // 0x00000400
    FrontEnemy = 2048, // 0x00000800
    Attacker = 4096, // 0x00001000
    Target = 8192, // 0x00002000
    RandomAlly = 16384, // 0x00004000
    RandomEnemy = 32768, // 0x00008000
    RandomUnit = 65536, // 0x00010000
  }
}
