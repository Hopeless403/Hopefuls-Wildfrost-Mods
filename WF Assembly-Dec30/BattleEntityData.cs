// Decompiled with JetBrains decompiler
// Type: BattleEntityData
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
[Serializable]
public class BattleEntityData : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_cardSaveData;
  private static readonly System.IntPtr NativeFieldInfoPtr_height;
  private static readonly System.IntPtr NativeFieldInfoPtr_damage;
  private static readonly System.IntPtr NativeFieldInfoPtr_damageMax;
  private static readonly System.IntPtr NativeFieldInfoPtr_hp;
  private static readonly System.IntPtr NativeFieldInfoPtr_hpMax;
  private static readonly System.IntPtr NativeFieldInfoPtr_counter;
  private static readonly System.IntPtr NativeFieldInfoPtr_counterMax;
  private static readonly System.IntPtr NativeFieldInfoPtr_uses;
  private static readonly System.IntPtr NativeFieldInfoPtr_usesMax;
  private static readonly System.IntPtr NativeFieldInfoPtr_flipped;
  private static readonly System.IntPtr NativeFieldInfoPtr_attackEffects;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_0;

  [CallerCount(1959)]
  [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BattleEntityData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleEntityData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleEntityData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 103434, RefRangeEnd = 103436, XrefRangeStart = 103399, XrefRangeEnd = 103434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BattleEntityData(Entity entity)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleEntityData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleEntityData.NativeMethodInfoPtr__ctor_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BattleEntityData()
  {
    Il2CppClassPointerStore<BattleEntityData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BattleEntityData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleEntityData>.NativeClassPtr);
    BattleEntityData.NativeFieldInfoPtr_cardSaveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleEntityData>.NativeClassPtr, nameof (cardSaveData));
    BattleEntityData.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleEntityData>.NativeClassPtr, nameof (height));
    BattleEntityData.NativeFieldInfoPtr_damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleEntityData>.NativeClassPtr, nameof (damage));
    BattleEntityData.NativeFieldInfoPtr_damageMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleEntityData>.NativeClassPtr, nameof (damageMax));
    BattleEntityData.NativeFieldInfoPtr_hp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleEntityData>.NativeClassPtr, nameof (hp));
    BattleEntityData.NativeFieldInfoPtr_hpMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleEntityData>.NativeClassPtr, nameof (hpMax));
    BattleEntityData.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleEntityData>.NativeClassPtr, nameof (counter));
    BattleEntityData.NativeFieldInfoPtr_counterMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleEntityData>.NativeClassPtr, nameof (counterMax));
    BattleEntityData.NativeFieldInfoPtr_uses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleEntityData>.NativeClassPtr, nameof (uses));
    BattleEntityData.NativeFieldInfoPtr_usesMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleEntityData>.NativeClassPtr, nameof (usesMax));
    BattleEntityData.NativeFieldInfoPtr_flipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleEntityData>.NativeClassPtr, nameof (flipped));
    BattleEntityData.NativeFieldInfoPtr_attackEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleEntityData>.NativeClassPtr, nameof (attackEffects));
    BattleEntityData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleEntityData>.NativeClassPtr, 100672618);
    BattleEntityData.NativeMethodInfoPtr__ctor_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleEntityData>.NativeClassPtr, 100672619);
  }

  public BattleEntityData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe CardSaveData cardSaveData
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_cardSaveData));
      return pointer == System.IntPtr.Zero ? (CardSaveData) null : new CardSaveData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_cardSaveData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int height
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_height));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_height)) = value;
    }
  }

  public unsafe int damage
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_damage));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_damage)) = value;
    }
  }

  public unsafe int damageMax
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_damageMax));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_damageMax)) = value;
    }
  }

  public unsafe int hp
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_hp));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_hp)) = value;
    }
  }

  public unsafe int hpMax
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_hpMax));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_hpMax)) = value;
    }
  }

  public unsafe int counter
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_counter));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_counter)) = value;
    }
  }

  public unsafe int counterMax
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_counterMax));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_counterMax)) = value;
    }
  }

  public unsafe int uses
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_uses));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_uses)) = value;
    }
  }

  public unsafe int usesMax
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_usesMax));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_usesMax)) = value;
    }
  }

  public unsafe bool flipped
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_flipped));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_flipped)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<StatusEffectSaveData> attackEffects
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_attackEffects));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<StatusEffectSaveData>) null : new Il2CppReferenceArray<StatusEffectSaveData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleEntityData.NativeFieldInfoPtr_attackEffects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("BattleEntityData/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__13_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__13_0_Internal_StatusEffectSaveData_StatusEffectStacks_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleEntityData.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleEntityData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103397, XrefRangeEnd = 103399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StatusEffectSaveData __ctor_b__13_0(CardData.StatusEffectStacks a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleEntityData.__c.NativeMethodInfoPtr___ctor_b__13_0_Internal_StatusEffectSaveData_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (StatusEffectSaveData) null : new StatusEffectSaveData(pointer);
    }

    static __c()
    {
      Il2CppClassPointerStore<BattleEntityData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleEntityData>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleEntityData.__c>.NativeClassPtr);
      BattleEntityData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleEntityData.__c>.NativeClassPtr, "<>9");
      BattleEntityData.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleEntityData.__c>.NativeClassPtr, "<>9__13_0");
      BattleEntityData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleEntityData.__c>.NativeClassPtr, 100672621);
      BattleEntityData.__c.NativeMethodInfoPtr___ctor_b__13_0_Internal_StatusEffectSaveData_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleEntityData.__c>.NativeClassPtr, 100672622);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe BattleEntityData.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BattleEntityData.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (BattleEntityData.__c) null : new BattleEntityData.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BattleEntityData.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData.StatusEffectStacks, StatusEffectSaveData> __9__13_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BattleEntityData.__c.NativeFieldInfoPtr___9__13_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData.StatusEffectStacks, StatusEffectSaveData>) null : new Il2CppSystem.Func<CardData.StatusEffectStacks, StatusEffectSaveData>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BattleEntityData.__c.NativeFieldInfoPtr___9__13_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
