// Decompiled with JetBrains decompiler
// Type: BattleGenerationScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class BattleGenerationScript : ScriptableObject
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Virtual_New_SaveCollection_1_WaveData_BattleData_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddGoldGivers_Protected_Void_WaveList_BattleData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddBonusUnits_Protected_Void_WaveList_BattleData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  [CallerCount(44)]
  [CachedScanResults(RefRangeStart = 26224, RefRangeEnd = 26268, XrefRangeStart = 26224, XrefRangeEnd = 26268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe SaveCollection<BattleWaveManager.WaveData> Run(
    BattleData battleData,
    int points)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) battleData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &points;
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleGenerationScript.NativeMethodInfoPtr_Run_Public_Virtual_New_SaveCollection_1_WaveData_BattleData_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return new SaveCollection<BattleWaveManager.WaveData>(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 104810, RefRangeEnd = 104812, XrefRangeStart = 104787, XrefRangeEnd = 104810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddGoldGivers(BattleGenerationScript.WaveList waves, BattleData battleData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) waves);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) battleData);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleGenerationScript.NativeMethodInfoPtr_AddGoldGivers_Protected_Void_WaveList_BattleData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 104839, RefRangeEnd = 104841, XrefRangeStart = 104812, XrefRangeEnd = 104839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddBonusUnits(BattleGenerationScript.WaveList waves, BattleData battleData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) waves);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) battleData);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleGenerationScript.NativeMethodInfoPtr_AddBonusUnits_Protected_Void_WaveList_BattleData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BattleGenerationScript()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleGenerationScript>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleGenerationScript.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BattleGenerationScript()
  {
    Il2CppClassPointerStore<BattleGenerationScript>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BattleGenerationScript));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleGenerationScript>.NativeClassPtr);
    BattleGenerationScript.NativeMethodInfoPtr_Run_Public_Virtual_New_SaveCollection_1_WaveData_BattleData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScript>.NativeClassPtr, 100672783);
    BattleGenerationScript.NativeMethodInfoPtr_AddGoldGivers_Protected_Void_WaveList_BattleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScript>.NativeClassPtr, 100672784);
    BattleGenerationScript.NativeMethodInfoPtr_AddBonusUnits_Protected_Void_WaveList_BattleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScript>.NativeClassPtr, 100672785);
    BattleGenerationScript.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScript>.NativeClassPtr, 100672786);
  }

  public BattleGenerationScript(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public class WaveList : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_list;
    private static readonly System.IntPtr NativeFieldInfoPtr_value;
    private static readonly System.IntPtr NativeFieldInfoPtr_targetValue;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_Wave_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetWave_Public_Wave_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddUnit_Public_Void_Int32_CardData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Satisfied_Public_Boolean_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104744, XrefRangeEnd = 104745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WaveList(int targetValue)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleGenerationScript.WaveList>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &targetValue
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleGenerationScript.WaveList.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 104767, RefRangeEnd = 104770, XrefRangeStart = 104745, XrefRangeEnd = 104767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Add(BattleWavePoolData.Wave wave)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) wave))
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleGenerationScript.WaveList.NativeMethodInfoPtr_Add_Public_Void_Wave_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 104774, RefRangeEnd = 104775, XrefRangeStart = 104770, XrefRangeEnd = 104774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveAt(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleGenerationScript.WaveList.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104775, XrefRangeEnd = 104778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BattleWavePoolData.Wave GetWave(int waveIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &waveIndex
      };
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(BattleGenerationScript.WaveList.NativeMethodInfoPtr_GetWave_Public_Wave_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new BattleWavePoolData.Wave(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 104784, RefRangeEnd = 104786, XrefRangeStart = 104778, XrefRangeEnd = 104784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddUnit(int waveIndex, CardData unit)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &waveIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) unit);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleGenerationScript.WaveList.NativeMethodInfoPtr_AddUnit_Public_Void_Int32_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe int Count
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104786, XrefRangeEnd = 104787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleGenerationScript.WaveList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    public unsafe bool Satisfied()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleGenerationScript.WaveList.NativeMethodInfoPtr_Satisfied_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static WaveList()
    {
      Il2CppClassPointerStore<BattleGenerationScript.WaveList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleGenerationScript>.NativeClassPtr, nameof (WaveList));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleGenerationScript.WaveList>.NativeClassPtr);
      BattleGenerationScript.WaveList.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScript.WaveList>.NativeClassPtr, nameof (list));
      BattleGenerationScript.WaveList.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScript.WaveList>.NativeClassPtr, nameof (value));
      BattleGenerationScript.WaveList.NativeFieldInfoPtr_targetValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScript.WaveList>.NativeClassPtr, nameof (targetValue));
      BattleGenerationScript.WaveList.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScript.WaveList>.NativeClassPtr, 100672787);
      BattleGenerationScript.WaveList.NativeMethodInfoPtr_Add_Public_Void_Wave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScript.WaveList>.NativeClassPtr, 100672788);
      BattleGenerationScript.WaveList.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScript.WaveList>.NativeClassPtr, 100672789);
      BattleGenerationScript.WaveList.NativeMethodInfoPtr_GetWave_Public_Wave_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScript.WaveList>.NativeClassPtr, 100672790);
      BattleGenerationScript.WaveList.NativeMethodInfoPtr_AddUnit_Public_Void_Int32_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScript.WaveList>.NativeClassPtr, 100672791);
      BattleGenerationScript.WaveList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScript.WaveList>.NativeClassPtr, 100672792);
      BattleGenerationScript.WaveList.NativeMethodInfoPtr_Satisfied_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScript.WaveList>.NativeClassPtr, 100672793);
    }

    public WaveList(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<BattleWavePoolData.Wave> list
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScript.WaveList.NativeFieldInfoPtr_list));
        return pointer == System.IntPtr.Zero ? (List<BattleWavePoolData.Wave>) null : new List<BattleWavePoolData.Wave>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScript.WaveList.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int value
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScript.WaveList.NativeFieldInfoPtr_value));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScript.WaveList.NativeFieldInfoPtr_value)) = value;
      }
    }

    public unsafe int targetValue
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScript.WaveList.NativeFieldInfoPtr_targetValue));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScript.WaveList.NativeFieldInfoPtr_targetValue)) = value;
      }
    }
  }
}
