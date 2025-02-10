// Decompiled with JetBrains decompiler
// Type: BattleWavePoolData
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
using UnityEngine;

#nullable disable
public class BattleWavePoolData : ScriptableObject
{
  private static readonly System.IntPtr NativeFieldInfoPtr_weight;
  private static readonly System.IntPtr NativeFieldInfoPtr_forcePulls;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxPulls;
  private static readonly System.IntPtr NativeFieldInfoPtr_waves;
  private static readonly System.IntPtr NativeFieldInfoPtr_pullCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_workingList;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanPull_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MustPull_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Pull_Public_Wave_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  public unsafe bool CanPull()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleWavePoolData.NativeMethodInfoPtr_CanPull_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public unsafe bool MustPull()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleWavePoolData.NativeMethodInfoPtr_MustPull_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 104740, RefRangeEnd = 104742, XrefRangeStart = 104720, XrefRangeEnd = 104740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BattleWavePoolData.Wave Pull()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(BattleWavePoolData.NativeMethodInfoPtr_Pull_Public_Wave_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return new BattleWavePoolData.Wave(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104742, XrefRangeEnd = 104743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleWavePoolData.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104743, XrefRangeEnd = 104744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BattleWavePoolData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleWavePoolData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleWavePoolData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BattleWavePoolData()
  {
    Il2CppClassPointerStore<BattleWavePoolData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BattleWavePoolData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleWavePoolData>.NativeClassPtr);
    BattleWavePoolData.NativeFieldInfoPtr_weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWavePoolData>.NativeClassPtr, nameof (weight));
    BattleWavePoolData.NativeFieldInfoPtr_forcePulls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWavePoolData>.NativeClassPtr, nameof (forcePulls));
    BattleWavePoolData.NativeFieldInfoPtr_maxPulls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWavePoolData>.NativeClassPtr, nameof (maxPulls));
    BattleWavePoolData.NativeFieldInfoPtr_waves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWavePoolData>.NativeClassPtr, nameof (waves));
    BattleWavePoolData.NativeFieldInfoPtr_pullCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWavePoolData>.NativeClassPtr, nameof (pullCount));
    BattleWavePoolData.NativeFieldInfoPtr_workingList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWavePoolData>.NativeClassPtr, nameof (workingList));
    BattleWavePoolData.NativeMethodInfoPtr_CanPull_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWavePoolData>.NativeClassPtr, 100672777);
    BattleWavePoolData.NativeMethodInfoPtr_MustPull_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWavePoolData>.NativeClassPtr, 100672778);
    BattleWavePoolData.NativeMethodInfoPtr_Pull_Public_Wave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWavePoolData>.NativeClassPtr, 100672779);
    BattleWavePoolData.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWavePoolData>.NativeClassPtr, 100672780);
    BattleWavePoolData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWavePoolData>.NativeClassPtr, 100672781);
  }

  public BattleWavePoolData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int weight
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWavePoolData.NativeFieldInfoPtr_weight));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWavePoolData.NativeFieldInfoPtr_weight)) = value;
    }
  }

  public unsafe int forcePulls
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWavePoolData.NativeFieldInfoPtr_forcePulls));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWavePoolData.NativeFieldInfoPtr_forcePulls)) = value;
    }
  }

  public unsafe int maxPulls
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWavePoolData.NativeFieldInfoPtr_maxPulls));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWavePoolData.NativeFieldInfoPtr_maxPulls)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<BattleWavePoolData.Wave> waves
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWavePoolData.NativeFieldInfoPtr_waves));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<BattleWavePoolData.Wave>) null : new Il2CppReferenceArray<BattleWavePoolData.Wave>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleWavePoolData.NativeFieldInfoPtr_waves), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int pullCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWavePoolData.NativeFieldInfoPtr_pullCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWavePoolData.NativeFieldInfoPtr_pullCount)) = value;
    }
  }

  public unsafe List<BattleWavePoolData.Wave> workingList
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWavePoolData.NativeFieldInfoPtr_workingList));
      return pointer == System.IntPtr.Zero ? (List<BattleWavePoolData.Wave>) null : new List<BattleWavePoolData.Wave>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleWavePoolData.NativeFieldInfoPtr_workingList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class Wave : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_units;
    private static readonly System.IntPtr NativeFieldInfoPtr_value;
    private static readonly System.IntPtr NativeFieldInfoPtr_positionPriority;
    private static readonly System.IntPtr NativeFieldInfoPtr_fixedOrder;
    private static readonly System.IntPtr NativeFieldInfoPtr_maxSize;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanAddTo_Public_Boolean_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104719, XrefRangeEnd = 104720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CanAddTo()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleWavePoolData.Wave.NativeMethodInfoPtr_CanAddTo_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static Wave()
    {
      Il2CppClassPointerStore<BattleWavePoolData.Wave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleWavePoolData>.NativeClassPtr, nameof (Wave));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleWavePoolData.Wave>.NativeClassPtr);
      BattleWavePoolData.Wave.NativeFieldInfoPtr_units = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWavePoolData.Wave>.NativeClassPtr, nameof (units));
      BattleWavePoolData.Wave.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWavePoolData.Wave>.NativeClassPtr, nameof (value));
      BattleWavePoolData.Wave.NativeFieldInfoPtr_positionPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWavePoolData.Wave>.NativeClassPtr, nameof (positionPriority));
      BattleWavePoolData.Wave.NativeFieldInfoPtr_fixedOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWavePoolData.Wave>.NativeClassPtr, nameof (fixedOrder));
      BattleWavePoolData.Wave.NativeFieldInfoPtr_maxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWavePoolData.Wave>.NativeClassPtr, nameof (maxSize));
      BattleWavePoolData.Wave.NativeMethodInfoPtr_CanAddTo_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWavePoolData.Wave>.NativeClassPtr, 100672782);
    }

    public Wave(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Wave()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BattleWavePoolData.Wave>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BattleWavePoolData.Wave>.NativeClassPtr, data));
    }

    public unsafe List<CardData> units
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWavePoolData.Wave.NativeFieldInfoPtr_units));
        return pointer == System.IntPtr.Zero ? (List<CardData>) null : new List<CardData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleWavePoolData.Wave.NativeFieldInfoPtr_units), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int value
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWavePoolData.Wave.NativeFieldInfoPtr_value));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWavePoolData.Wave.NativeFieldInfoPtr_value)) = value;
      }
    }

    public unsafe int positionPriority
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWavePoolData.Wave.NativeFieldInfoPtr_positionPriority));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWavePoolData.Wave.NativeFieldInfoPtr_positionPriority)) = value;
      }
    }

    public unsafe bool fixedOrder
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWavePoolData.Wave.NativeFieldInfoPtr_fixedOrder));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWavePoolData.Wave.NativeFieldInfoPtr_fixedOrder)) = value;
      }
    }

    public unsafe int maxSize
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWavePoolData.Wave.NativeFieldInfoPtr_maxSize));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWavePoolData.Wave.NativeFieldInfoPtr_maxSize)) = value;
      }
    }
  }
}
