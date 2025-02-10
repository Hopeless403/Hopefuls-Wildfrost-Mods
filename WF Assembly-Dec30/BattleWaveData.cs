// Decompiled with JetBrains decompiler
// Type: BattleWaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
[Serializable]
public class BattleWaveData : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_deployed;
  private static readonly System.IntPtr NativeFieldInfoPtr_counter;
  private static readonly System.IntPtr NativeFieldInfoPtr_counterMax;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentWave;
  private static readonly System.IntPtr NativeFieldInfoPtr_overflowWaveIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_waves;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1959)]
  [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BattleWaveData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleWaveData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleWaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BattleWaveData()
  {
    Il2CppClassPointerStore<BattleWaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BattleWaveData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleWaveData>.NativeClassPtr);
    BattleWaveData.NativeFieldInfoPtr_deployed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveData>.NativeClassPtr, nameof (deployed));
    BattleWaveData.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveData>.NativeClassPtr, nameof (counter));
    BattleWaveData.NativeFieldInfoPtr_counterMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveData>.NativeClassPtr, nameof (counterMax));
    BattleWaveData.NativeFieldInfoPtr_currentWave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveData>.NativeClassPtr, nameof (currentWave));
    BattleWaveData.NativeFieldInfoPtr_overflowWaveIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveData>.NativeClassPtr, nameof (overflowWaveIndex));
    BattleWaveData.NativeFieldInfoPtr_waves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveData>.NativeClassPtr, nameof (waves));
    BattleWaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveData>.NativeClassPtr, 100672638);
  }

  public BattleWaveData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe List<ulong> deployed
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveData.NativeFieldInfoPtr_deployed));
      return pointer == System.IntPtr.Zero ? (List<ulong>) null : new List<ulong>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveData.NativeFieldInfoPtr_deployed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int counter
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveData.NativeFieldInfoPtr_counter));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveData.NativeFieldInfoPtr_counter)) = value;
    }
  }

  public unsafe int counterMax
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveData.NativeFieldInfoPtr_counterMax));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveData.NativeFieldInfoPtr_counterMax)) = value;
    }
  }

  public unsafe int currentWave
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveData.NativeFieldInfoPtr_currentWave));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveData.NativeFieldInfoPtr_currentWave)) = value;
    }
  }

  public unsafe int overflowWaveIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveData.NativeFieldInfoPtr_overflowWaveIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveData.NativeFieldInfoPtr_overflowWaveIndex)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<BattleWaveData.Wave> waves
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveData.NativeFieldInfoPtr_waves));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<BattleWaveData.Wave>) null : new Il2CppReferenceArray<BattleWaveData.Wave>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveData.NativeFieldInfoPtr_waves), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class Wave : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_counter;
    private static readonly System.IntPtr NativeFieldInfoPtr_unitIds;
    private static readonly System.IntPtr NativeFieldInfoPtr_isBossWave;
    private static readonly System.IntPtr NativeFieldInfoPtr_spawned;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Wave_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Wave()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleWaveData.Wave>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleWaveData.Wave.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 103585, RefRangeEnd = 103586, XrefRangeStart = 103545, XrefRangeEnd = 103585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Wave(BattleWaveManager.Wave wave)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleWaveData.Wave>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) wave)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleWaveData.Wave.NativeMethodInfoPtr__ctor_Public_Void_Wave_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Wave()
    {
      Il2CppClassPointerStore<BattleWaveData.Wave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleWaveData>.NativeClassPtr, nameof (Wave));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleWaveData.Wave>.NativeClassPtr);
      BattleWaveData.Wave.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveData.Wave>.NativeClassPtr, nameof (counter));
      BattleWaveData.Wave.NativeFieldInfoPtr_unitIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveData.Wave>.NativeClassPtr, nameof (unitIds));
      BattleWaveData.Wave.NativeFieldInfoPtr_isBossWave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveData.Wave>.NativeClassPtr, nameof (isBossWave));
      BattleWaveData.Wave.NativeFieldInfoPtr_spawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveData.Wave>.NativeClassPtr, nameof (spawned));
      BattleWaveData.Wave.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveData.Wave>.NativeClassPtr, 100672639);
      BattleWaveData.Wave.NativeMethodInfoPtr__ctor_Public_Void_Wave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveData.Wave>.NativeClassPtr, 100672640);
    }

    public Wave(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int counter
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveData.Wave.NativeFieldInfoPtr_counter));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveData.Wave.NativeFieldInfoPtr_counter)) = value;
      }
    }

    public unsafe Il2CppStructArray<ulong> unitIds
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveData.Wave.NativeFieldInfoPtr_unitIds));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<ulong>) null : new Il2CppStructArray<ulong>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveData.Wave.NativeFieldInfoPtr_unitIds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool isBossWave
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveData.Wave.NativeFieldInfoPtr_isBossWave));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveData.Wave.NativeFieldInfoPtr_isBossWave)) = value;
      }
    }

    public unsafe bool spawned
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveData.Wave.NativeFieldInfoPtr_spawned));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveData.Wave.NativeFieldInfoPtr_spawned)) = value;
      }
    }

    [ObfuscatedName("BattleWaveData/Wave/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__5_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__5_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__5_0_Internal_Boolean_CardData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__5_1_Internal_UInt64_CardData_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleWaveData.Wave.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BattleWaveData.Wave.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103541, XrefRangeEnd = 103545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool __ctor_b__5_0(CardData a)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
        };
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleWaveData.Wave.__c.NativeMethodInfoPtr___ctor_b__5_0_Internal_Boolean_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe ulong __ctor_b__5_1(CardData a)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
        };
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleWaveData.Wave.__c.NativeMethodInfoPtr___ctor_b__5_1_Internal_UInt64_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<BattleWaveData.Wave.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleWaveData.Wave>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleWaveData.Wave.__c>.NativeClassPtr);
        BattleWaveData.Wave.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveData.Wave.__c>.NativeClassPtr, "<>9");
        BattleWaveData.Wave.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveData.Wave.__c>.NativeClassPtr, "<>9__5_0");
        BattleWaveData.Wave.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveData.Wave.__c>.NativeClassPtr, "<>9__5_1");
        BattleWaveData.Wave.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveData.Wave.__c>.NativeClassPtr, 100672642);
        BattleWaveData.Wave.__c.NativeMethodInfoPtr___ctor_b__5_0_Internal_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveData.Wave.__c>.NativeClassPtr, 100672643);
        BattleWaveData.Wave.__c.NativeMethodInfoPtr___ctor_b__5_1_Internal_UInt64_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveData.Wave.__c>.NativeClassPtr, 100672644);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe BattleWaveData.Wave.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BattleWaveData.Wave.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (BattleWaveData.Wave.__c) null : new BattleWaveData.Wave.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BattleWaveData.Wave.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<CardData, bool> __9__5_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BattleWaveData.Wave.__c.NativeFieldInfoPtr___9__5_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData, bool>) null : new Il2CppSystem.Func<CardData, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BattleWaveData.Wave.__c.NativeFieldInfoPtr___9__5_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<CardData, ulong> __9__5_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BattleWaveData.Wave.__c.NativeFieldInfoPtr___9__5_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData, ulong>) null : new Il2CppSystem.Func<CardData, ulong>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BattleWaveData.Wave.__c.NativeFieldInfoPtr___9__5_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
