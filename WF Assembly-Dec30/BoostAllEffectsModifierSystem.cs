// Decompiled with JetBrains decompiler
// Type: BoostAllEffectsModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class BoostAllEffectsModifierSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_add;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CardDataCreated_Private_Static_Void_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64882, XrefRangeEnd = 64890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostAllEffectsModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64890, XrefRangeEnd = 64898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostAllEffectsModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64898, XrefRangeEnd = 64995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CardDataCreated(CardData cardData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostAllEffectsModifierSystem.NativeMethodInfoPtr_CardDataCreated_Private_Static_Void_CardData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BoostAllEffectsModifierSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoostAllEffectsModifierSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostAllEffectsModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BoostAllEffectsModifierSystem()
  {
    Il2CppClassPointerStore<BoostAllEffectsModifierSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BoostAllEffectsModifierSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoostAllEffectsModifierSystem>.NativeClassPtr);
    BoostAllEffectsModifierSystem.NativeFieldInfoPtr_add = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoostAllEffectsModifierSystem>.NativeClassPtr, nameof (add));
    BoostAllEffectsModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostAllEffectsModifierSystem>.NativeClassPtr, 100668607);
    BoostAllEffectsModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostAllEffectsModifierSystem>.NativeClassPtr, 100668608);
    BoostAllEffectsModifierSystem.NativeMethodInfoPtr_CardDataCreated_Private_Static_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostAllEffectsModifierSystem>.NativeClassPtr, 100668609);
    BoostAllEffectsModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostAllEffectsModifierSystem>.NativeClassPtr, 100668610);
  }

  public BoostAllEffectsModifierSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe int add
  {
    get
    {
      int add;
      IL2CPP.il2cpp_field_static_get_value(BoostAllEffectsModifierSystem.NativeFieldInfoPtr_add, (void*) &add);
      return add;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BoostAllEffectsModifierSystem.NativeFieldInfoPtr_add, (void*) &value);
    }
  }

  [ObfuscatedName("BoostAllEffectsModifierSystem/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__3_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__3_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__3_2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CardDataCreated_b__3_0_Internal_Boolean_StatusEffectStacks_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CardDataCreated_b__3_1_Internal_Boolean_StatusEffectStacks_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CardDataCreated_b__3_2_Internal_Boolean_TraitStacks_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoostAllEffectsModifierSystem.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BoostAllEffectsModifierSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _CardDataCreated_b__3_0(CardData.StatusEffectStacks e)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoostAllEffectsModifierSystem.__c.NativeMethodInfoPtr__CardDataCreated_b__3_0_Internal_Boolean_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool _CardDataCreated_b__3_1(CardData.StatusEffectStacks e)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoostAllEffectsModifierSystem.__c.NativeMethodInfoPtr__CardDataCreated_b__3_1_Internal_Boolean_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool _CardDataCreated_b__3_2(CardData.TraitStacks t)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) t)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoostAllEffectsModifierSystem.__c.NativeMethodInfoPtr__CardDataCreated_b__3_2_Internal_Boolean_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<BoostAllEffectsModifierSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BoostAllEffectsModifierSystem>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoostAllEffectsModifierSystem.__c>.NativeClassPtr);
      BoostAllEffectsModifierSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoostAllEffectsModifierSystem.__c>.NativeClassPtr, "<>9");
      BoostAllEffectsModifierSystem.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoostAllEffectsModifierSystem.__c>.NativeClassPtr, "<>9__3_0");
      BoostAllEffectsModifierSystem.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoostAllEffectsModifierSystem.__c>.NativeClassPtr, "<>9__3_1");
      BoostAllEffectsModifierSystem.__c.NativeFieldInfoPtr___9__3_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoostAllEffectsModifierSystem.__c>.NativeClassPtr, "<>9__3_2");
      BoostAllEffectsModifierSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostAllEffectsModifierSystem.__c>.NativeClassPtr, 100668612);
      BoostAllEffectsModifierSystem.__c.NativeMethodInfoPtr__CardDataCreated_b__3_0_Internal_Boolean_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostAllEffectsModifierSystem.__c>.NativeClassPtr, 100668613);
      BoostAllEffectsModifierSystem.__c.NativeMethodInfoPtr__CardDataCreated_b__3_1_Internal_Boolean_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostAllEffectsModifierSystem.__c>.NativeClassPtr, 100668614);
      BoostAllEffectsModifierSystem.__c.NativeMethodInfoPtr__CardDataCreated_b__3_2_Internal_Boolean_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostAllEffectsModifierSystem.__c>.NativeClassPtr, 100668615);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe BoostAllEffectsModifierSystem.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BoostAllEffectsModifierSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (BoostAllEffectsModifierSystem.__c) null : new BoostAllEffectsModifierSystem.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BoostAllEffectsModifierSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData.StatusEffectStacks, bool> __9__3_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BoostAllEffectsModifierSystem.__c.NativeFieldInfoPtr___9__3_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData.StatusEffectStacks, bool>) null : new Il2CppSystem.Func<CardData.StatusEffectStacks, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BoostAllEffectsModifierSystem.__c.NativeFieldInfoPtr___9__3_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData.StatusEffectStacks, bool> __9__3_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BoostAllEffectsModifierSystem.__c.NativeFieldInfoPtr___9__3_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData.StatusEffectStacks, bool>) null : new Il2CppSystem.Func<CardData.StatusEffectStacks, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BoostAllEffectsModifierSystem.__c.NativeFieldInfoPtr___9__3_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData.TraitStacks, bool> __9__3_2
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BoostAllEffectsModifierSystem.__c.NativeFieldInfoPtr___9__3_2, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData.TraitStacks, bool>) null : new Il2CppSystem.Func<CardData.TraitStacks, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BoostAllEffectsModifierSystem.__c.NativeFieldInfoPtr___9__3_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
