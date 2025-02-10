// Decompiled with JetBrains decompiler
// Type: TargetConstraintCanBeBoosted
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class TargetConstraintCanBeBoosted : TargetConstraint
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Check_Public_Virtual_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Check_Public_Virtual_Boolean_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckAttackEffects_Private_Static_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckAttackEffects_Private_Static_Boolean_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckAttackEffects_Private_Static_Boolean_IEnumerable_1_StatusEffectData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckPassiveEffects_Private_Static_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckPassiveEffects_Private_Static_Boolean_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckPassiveEffects_Private_Static_Boolean_IEnumerable_1_StatusEffectData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckTraits_Private_Static_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckTraits_Private_Static_Boolean_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23703, XrefRangeEnd = 23724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Check(Entity target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetConstraintCanBeBoosted.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23724, XrefRangeEnd = 23764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Check(CardData targetData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetData)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetConstraintCanBeBoosted.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23764, XrefRangeEnd = 23784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CheckAttackEffects(Entity target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetConstraintCanBeBoosted.NativeMethodInfoPtr_CheckAttackEffects_Private_Static_Boolean_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23784, XrefRangeEnd = 23804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CheckAttackEffects(CardData targetData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetData)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetConstraintCanBeBoosted.NativeMethodInfoPtr_CheckAttackEffects_Private_Static_Boolean_CardData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 23808, RefRangeEnd = 23812, XrefRangeStart = 23804, XrefRangeEnd = 23808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CheckAttackEffects(IEnumerable<StatusEffectData> effects)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) effects)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetConstraintCanBeBoosted.NativeMethodInfoPtr_CheckAttackEffects_Private_Static_Boolean_IEnumerable_1_StatusEffectData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23812, XrefRangeEnd = 23814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CheckPassiveEffects(Entity target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetConstraintCanBeBoosted.NativeMethodInfoPtr_CheckPassiveEffects_Private_Static_Boolean_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23814, XrefRangeEnd = 23834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CheckPassiveEffects(CardData targetData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetData)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetConstraintCanBeBoosted.NativeMethodInfoPtr_CheckPassiveEffects_Private_Static_Boolean_CardData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 23838, RefRangeEnd = 23844, XrefRangeStart = 23834, XrefRangeEnd = 23838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CheckPassiveEffects(IEnumerable<StatusEffectData> effects)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) effects)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetConstraintCanBeBoosted.NativeMethodInfoPtr_CheckPassiveEffects_Private_Static_Boolean_IEnumerable_1_StatusEffectData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23844, XrefRangeEnd = 23855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CheckTraits(Entity target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetConstraintCanBeBoosted.NativeMethodInfoPtr_CheckTraits_Private_Static_Boolean_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 23866, RefRangeEnd = 23867, XrefRangeStart = 23855, XrefRangeEnd = 23866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CheckTraits(CardData targetData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetData)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetConstraintCanBeBoosted.NativeMethodInfoPtr_CheckTraits_Private_Static_Boolean_CardData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TargetConstraintCanBeBoosted()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetConstraintCanBeBoosted>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetConstraintCanBeBoosted.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TargetConstraintCanBeBoosted()
  {
    Il2CppClassPointerStore<TargetConstraintCanBeBoosted>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TargetConstraintCanBeBoosted));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetConstraintCanBeBoosted>.NativeClassPtr);
    TargetConstraintCanBeBoosted.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintCanBeBoosted>.NativeClassPtr, 100664191);
    TargetConstraintCanBeBoosted.NativeMethodInfoPtr_Check_Public_Virtual_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintCanBeBoosted>.NativeClassPtr, 100664192);
    TargetConstraintCanBeBoosted.NativeMethodInfoPtr_CheckAttackEffects_Private_Static_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintCanBeBoosted>.NativeClassPtr, 100664193);
    TargetConstraintCanBeBoosted.NativeMethodInfoPtr_CheckAttackEffects_Private_Static_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintCanBeBoosted>.NativeClassPtr, 100664194);
    TargetConstraintCanBeBoosted.NativeMethodInfoPtr_CheckAttackEffects_Private_Static_Boolean_IEnumerable_1_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintCanBeBoosted>.NativeClassPtr, 100664195);
    TargetConstraintCanBeBoosted.NativeMethodInfoPtr_CheckPassiveEffects_Private_Static_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintCanBeBoosted>.NativeClassPtr, 100664196);
    TargetConstraintCanBeBoosted.NativeMethodInfoPtr_CheckPassiveEffects_Private_Static_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintCanBeBoosted>.NativeClassPtr, 100664197);
    TargetConstraintCanBeBoosted.NativeMethodInfoPtr_CheckPassiveEffects_Private_Static_Boolean_IEnumerable_1_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintCanBeBoosted>.NativeClassPtr, 100664198);
    TargetConstraintCanBeBoosted.NativeMethodInfoPtr_CheckTraits_Private_Static_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintCanBeBoosted>.NativeClassPtr, 100664199);
    TargetConstraintCanBeBoosted.NativeMethodInfoPtr_CheckTraits_Private_Static_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintCanBeBoosted>.NativeClassPtr, 100664200);
    TargetConstraintCanBeBoosted.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintCanBeBoosted>.NativeClassPtr, 100664201);
  }

  public TargetConstraintCanBeBoosted(System.IntPtr pointer)
    : base(pointer)
  {
  }

  [ObfuscatedName("TargetConstraintCanBeBoosted/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__3_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__4_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__6_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__7_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CheckAttackEffects_b__2_0_Internal_StatusEffectData_StatusEffectStacks_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CheckAttackEffects_b__3_0_Internal_StatusEffectData_StatusEffectStacks_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CheckAttackEffects_b__4_0_Internal_Boolean_StatusEffectData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CheckPassiveEffects_b__6_0_Internal_StatusEffectData_StatusEffectStacks_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CheckPassiveEffects_b__7_0_Internal_Boolean_StatusEffectData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetConstraintCanBeBoosted.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TargetConstraintCanBeBoosted.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe StatusEffectData _CheckAttackEffects_b__2_0(CardData.StatusEffectStacks a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetConstraintCanBeBoosted.__c.NativeMethodInfoPtr__CheckAttackEffects_b__2_0_Internal_StatusEffectData_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (StatusEffectData) null : new StatusEffectData(pointer);
    }

    [CallerCount(0)]
    public unsafe StatusEffectData _CheckAttackEffects_b__3_0(CardData.StatusEffectStacks a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetConstraintCanBeBoosted.__c.NativeMethodInfoPtr__CheckAttackEffects_b__3_0_Internal_StatusEffectData_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (StatusEffectData) null : new StatusEffectData(pointer);
    }

    [CallerCount(0)]
    public unsafe bool _CheckAttackEffects_b__4_0(StatusEffectData e)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetConstraintCanBeBoosted.__c.NativeMethodInfoPtr__CheckAttackEffects_b__4_0_Internal_Boolean_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe StatusEffectData _CheckPassiveEffects_b__6_0(CardData.StatusEffectStacks a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetConstraintCanBeBoosted.__c.NativeMethodInfoPtr__CheckPassiveEffects_b__6_0_Internal_StatusEffectData_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (StatusEffectData) null : new StatusEffectData(pointer);
    }

    [CallerCount(0)]
    public unsafe bool _CheckPassiveEffects_b__7_0(StatusEffectData e)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetConstraintCanBeBoosted.__c.NativeMethodInfoPtr__CheckPassiveEffects_b__7_0_Internal_Boolean_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<TargetConstraintCanBeBoosted.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetConstraintCanBeBoosted>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetConstraintCanBeBoosted.__c>.NativeClassPtr);
      TargetConstraintCanBeBoosted.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetConstraintCanBeBoosted.__c>.NativeClassPtr, "<>9");
      TargetConstraintCanBeBoosted.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetConstraintCanBeBoosted.__c>.NativeClassPtr, "<>9__2_0");
      TargetConstraintCanBeBoosted.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetConstraintCanBeBoosted.__c>.NativeClassPtr, "<>9__3_0");
      TargetConstraintCanBeBoosted.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetConstraintCanBeBoosted.__c>.NativeClassPtr, "<>9__4_0");
      TargetConstraintCanBeBoosted.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetConstraintCanBeBoosted.__c>.NativeClassPtr, "<>9__6_0");
      TargetConstraintCanBeBoosted.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetConstraintCanBeBoosted.__c>.NativeClassPtr, "<>9__7_0");
      TargetConstraintCanBeBoosted.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintCanBeBoosted.__c>.NativeClassPtr, 100664203);
      TargetConstraintCanBeBoosted.__c.NativeMethodInfoPtr__CheckAttackEffects_b__2_0_Internal_StatusEffectData_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintCanBeBoosted.__c>.NativeClassPtr, 100664204);
      TargetConstraintCanBeBoosted.__c.NativeMethodInfoPtr__CheckAttackEffects_b__3_0_Internal_StatusEffectData_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintCanBeBoosted.__c>.NativeClassPtr, 100664205);
      TargetConstraintCanBeBoosted.__c.NativeMethodInfoPtr__CheckAttackEffects_b__4_0_Internal_Boolean_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintCanBeBoosted.__c>.NativeClassPtr, 100664206);
      TargetConstraintCanBeBoosted.__c.NativeMethodInfoPtr__CheckPassiveEffects_b__6_0_Internal_StatusEffectData_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintCanBeBoosted.__c>.NativeClassPtr, 100664207);
      TargetConstraintCanBeBoosted.__c.NativeMethodInfoPtr__CheckPassiveEffects_b__7_0_Internal_Boolean_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetConstraintCanBeBoosted.__c>.NativeClassPtr, 100664208);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe TargetConstraintCanBeBoosted.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TargetConstraintCanBeBoosted.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (TargetConstraintCanBeBoosted.__c) null : new TargetConstraintCanBeBoosted.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TargetConstraintCanBeBoosted.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData.StatusEffectStacks, StatusEffectData> __9__2_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TargetConstraintCanBeBoosted.__c.NativeFieldInfoPtr___9__2_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData.StatusEffectStacks, StatusEffectData>) null : new Il2CppSystem.Func<CardData.StatusEffectStacks, StatusEffectData>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TargetConstraintCanBeBoosted.__c.NativeFieldInfoPtr___9__2_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData.StatusEffectStacks, StatusEffectData> __9__3_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TargetConstraintCanBeBoosted.__c.NativeFieldInfoPtr___9__3_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData.StatusEffectStacks, StatusEffectData>) null : new Il2CppSystem.Func<CardData.StatusEffectStacks, StatusEffectData>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TargetConstraintCanBeBoosted.__c.NativeFieldInfoPtr___9__3_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<StatusEffectData, bool> __9__4_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TargetConstraintCanBeBoosted.__c.NativeFieldInfoPtr___9__4_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<StatusEffectData, bool>) null : new Il2CppSystem.Func<StatusEffectData, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TargetConstraintCanBeBoosted.__c.NativeFieldInfoPtr___9__4_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData.StatusEffectStacks, StatusEffectData> __9__6_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TargetConstraintCanBeBoosted.__c.NativeFieldInfoPtr___9__6_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData.StatusEffectStacks, StatusEffectData>) null : new Il2CppSystem.Func<CardData.StatusEffectStacks, StatusEffectData>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TargetConstraintCanBeBoosted.__c.NativeFieldInfoPtr___9__6_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<StatusEffectData, bool> __9__7_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TargetConstraintCanBeBoosted.__c.NativeFieldInfoPtr___9__7_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<StatusEffectData, bool>) null : new Il2CppSystem.Func<StatusEffectData, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TargetConstraintCanBeBoosted.__c.NativeFieldInfoPtr___9__7_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
