// Decompiled with JetBrains decompiler
// Type: BattleWaveManager
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
public class BattleWaveManager : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_list;
  private static readonly System.IntPtr NativeFieldInfoPtr_remainingWaves;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddWave_Public_Void_Wave_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddEntities_Public_Void_Il2CppReferenceArray_1_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Pull_Public_Il2CppReferenceArray_1_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Peek_Public_Il2CppReferenceArray_1_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30657, XrefRangeEnd = 30675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddWave(BattleWaveManager.Wave wave)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) wave)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleWaveManager.NativeMethodInfoPtr_AddWave_Public_Void_Wave_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 30686, RefRangeEnd = 30687, XrefRangeStart = 30675, XrefRangeEnd = 30686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddEntities(Il2CppReferenceArray<Entity> entities)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entities)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleWaveManager.NativeMethodInfoPtr_AddEntities_Public_Void_Il2CppReferenceArray_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 30691, RefRangeEnd = 30693, XrefRangeStart = 30687, XrefRangeEnd = 30691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppReferenceArray<Entity> Pull()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleWaveManager.NativeMethodInfoPtr_Pull_Public_Il2CppReferenceArray_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr nativeObject = num;
    return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Entity>) null : new Il2CppReferenceArray<Entity>(nativeObject);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 30697, RefRangeEnd = 30699, XrefRangeStart = 30693, XrefRangeEnd = 30697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppReferenceArray<Entity> Peek()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleWaveManager.NativeMethodInfoPtr_Peek_Public_Il2CppReferenceArray_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr nativeObject = num;
    return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Entity>) null : new Il2CppReferenceArray<Entity>(nativeObject);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BattleWaveManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleWaveManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleWaveManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BattleWaveManager()
  {
    Il2CppClassPointerStore<BattleWaveManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BattleWaveManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleWaveManager>.NativeClassPtr);
    BattleWaveManager.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveManager>.NativeClassPtr, nameof (list));
    BattleWaveManager.NativeFieldInfoPtr_remainingWaves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveManager>.NativeClassPtr, nameof (remainingWaves));
    BattleWaveManager.NativeMethodInfoPtr_AddWave_Public_Void_Wave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager>.NativeClassPtr, 100665046);
    BattleWaveManager.NativeMethodInfoPtr_AddEntities_Public_Void_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager>.NativeClassPtr, 100665047);
    BattleWaveManager.NativeMethodInfoPtr_Pull_Public_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager>.NativeClassPtr, 100665048);
    BattleWaveManager.NativeMethodInfoPtr_Peek_Public_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager>.NativeClassPtr, 100665049);
    BattleWaveManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager>.NativeClassPtr, 100665050);
  }

  public BattleWaveManager(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe List<BattleWaveManager.Wave> list
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.NativeFieldInfoPtr_list));
      return pointer == System.IntPtr.Zero ? (List<BattleWaveManager.Wave>) null : new List<BattleWaveManager.Wave>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Queue<Il2CppReferenceArray<Entity>> remainingWaves
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.NativeFieldInfoPtr_remainingWaves));
      return pointer == System.IntPtr.Zero ? (Queue<Il2CppReferenceArray<Entity>>) null : new Queue<Il2CppReferenceArray<Entity>>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.NativeFieldInfoPtr_remainingWaves), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class Wave : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_counter;
    private static readonly System.IntPtr NativeFieldInfoPtr_units;
    private static readonly System.IntPtr NativeFieldInfoPtr_isBossWave;
    private static readonly System.IntPtr NativeFieldInfoPtr_spawned;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_WaveData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Wave()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleWaveManager.Wave>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleWaveManager.Wave.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 30293, RefRangeEnd = 30295, XrefRangeStart = 30282, XrefRangeEnd = 30293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Wave(BattleWaveManager.WaveData data)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleWaveManager.Wave>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleWaveManager.Wave.NativeMethodInfoPtr__ctor_Public_Void_WaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30295, XrefRangeEnd = 30306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleWaveManager.Wave.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static Wave()
    {
      Il2CppClassPointerStore<BattleWaveManager.Wave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleWaveManager>.NativeClassPtr, nameof (Wave));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleWaveManager.Wave>.NativeClassPtr);
      BattleWaveManager.Wave.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveManager.Wave>.NativeClassPtr, nameof (counter));
      BattleWaveManager.Wave.NativeFieldInfoPtr_units = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveManager.Wave>.NativeClassPtr, nameof (units));
      BattleWaveManager.Wave.NativeFieldInfoPtr_isBossWave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveManager.Wave>.NativeClassPtr, nameof (isBossWave));
      BattleWaveManager.Wave.NativeFieldInfoPtr_spawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveManager.Wave>.NativeClassPtr, nameof (spawned));
      BattleWaveManager.Wave.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.Wave>.NativeClassPtr, 100665051);
      BattleWaveManager.Wave.NativeMethodInfoPtr__ctor_Public_Void_WaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.Wave>.NativeClassPtr, 100665052);
      BattleWaveManager.Wave.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.Wave>.NativeClassPtr, 100665053);
    }

    public Wave(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int counter
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.Wave.NativeFieldInfoPtr_counter));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.Wave.NativeFieldInfoPtr_counter)) = value;
      }
    }

    public unsafe List<CardData> units
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.Wave.NativeFieldInfoPtr_units));
        return pointer == System.IntPtr.Zero ? (List<CardData>) null : new List<CardData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.Wave.NativeFieldInfoPtr_units), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool isBossWave
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.Wave.NativeFieldInfoPtr_isBossWave));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.Wave.NativeFieldInfoPtr_isBossWave)) = value;
      }
    }

    public unsafe bool spawned
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.Wave.NativeFieldInfoPtr_spawned));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.Wave.NativeFieldInfoPtr_spawned)) = value;
      }
    }
  }

  [Serializable]
  public class WaveData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_counter;
    private static readonly System.IntPtr NativeFieldInfoPtr_isBossWave;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddCard_Public_Abstract_Virtual_New_Void_CardData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InsertCard_Public_Abstract_Virtual_New_Void_Int32_CardData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCardData_Public_Abstract_Virtual_New_CardData_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCardName_Public_Abstract_Virtual_New_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PeekCardData_Public_Abstract_Virtual_New_CardData_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddUpgradeToCard_Public_Abstract_Virtual_New_Boolean_Int32_CardUpgradeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    public virtual unsafe int Count
    {
      [CallerCount(44), CachedScanResults(RefRangeStart = 26224, RefRangeEnd = 26268, XrefRangeStart = 26224, XrefRangeEnd = 26268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleWaveManager.WaveData.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    public virtual unsafe void AddCard(CardData card)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleWaveManager.WaveData.NativeMethodInfoPtr_AddCard_Public_Abstract_Virtual_New_Void_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void InsertCard(int index, CardData card)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleWaveManager.WaveData.NativeMethodInfoPtr_InsertCard_Public_Abstract_Virtual_New_Void_Int32_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe CardData GetCardData(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleWaveManager.WaveData.NativeMethodInfoPtr_GetCardData_Public_Abstract_Virtual_New_CardData_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
    }

    [CallerCount(0)]
    public virtual unsafe string GetCardName(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleWaveManager.WaveData.NativeMethodInfoPtr_GetCardName_Public_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    public virtual unsafe CardData PeekCardData(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleWaveManager.WaveData.NativeMethodInfoPtr_PeekCardData_Public_Abstract_Virtual_New_CardData_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
    }

    [CallerCount(0)]
    public virtual unsafe bool AddUpgradeToCard(int index, CardUpgradeData upgradeData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgradeData);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleWaveManager.WaveData.NativeMethodInfoPtr_AddUpgradeToCard_Public_Abstract_Virtual_New_Boolean_Int32_CardUpgradeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WaveData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleWaveManager.WaveData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleWaveManager.WaveData.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WaveData()
    {
      Il2CppClassPointerStore<BattleWaveManager.WaveData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleWaveManager>.NativeClassPtr, nameof (WaveData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleWaveManager.WaveData>.NativeClassPtr);
      BattleWaveManager.WaveData.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveManager.WaveData>.NativeClassPtr, nameof (counter));
      BattleWaveManager.WaveData.NativeFieldInfoPtr_isBossWave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveManager.WaveData>.NativeClassPtr, nameof (isBossWave));
      BattleWaveManager.WaveData.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveData>.NativeClassPtr, 100665054);
      BattleWaveManager.WaveData.NativeMethodInfoPtr_AddCard_Public_Abstract_Virtual_New_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveData>.NativeClassPtr, 100665055);
      BattleWaveManager.WaveData.NativeMethodInfoPtr_InsertCard_Public_Abstract_Virtual_New_Void_Int32_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveData>.NativeClassPtr, 100665056);
      BattleWaveManager.WaveData.NativeMethodInfoPtr_GetCardData_Public_Abstract_Virtual_New_CardData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveData>.NativeClassPtr, 100665057);
      BattleWaveManager.WaveData.NativeMethodInfoPtr_GetCardName_Public_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveData>.NativeClassPtr, 100665058);
      BattleWaveManager.WaveData.NativeMethodInfoPtr_PeekCardData_Public_Abstract_Virtual_New_CardData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveData>.NativeClassPtr, 100665059);
      BattleWaveManager.WaveData.NativeMethodInfoPtr_AddUpgradeToCard_Public_Abstract_Virtual_New_Boolean_Int32_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveData>.NativeClassPtr, 100665060);
      BattleWaveManager.WaveData.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveData>.NativeClassPtr, 100665061);
    }

    public WaveData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int counter
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.WaveData.NativeFieldInfoPtr_counter));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.WaveData.NativeFieldInfoPtr_counter)) = value;
      }
    }

    public unsafe bool isBossWave
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.WaveData.NativeFieldInfoPtr_isBossWave));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.WaveData.NativeFieldInfoPtr_isBossWave)) = value;
      }
    }
  }

  [Serializable]
  public class WaveDataBasic : BattleWaveManager.WaveData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_cards;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddCard_Public_Virtual_Void_CardData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InsertCard_Public_Virtual_Void_Int32_CardData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCardData_Public_Virtual_CardData_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PeekCardData_Public_Virtual_CardData_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCardName_Public_Virtual_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddUpgradeToCard_Public_Virtual_Boolean_Int32_CardUpgradeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Card_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToFull_Public_WaveDataFull_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe int Count
    {
      [CallerCount(13), CachedScanResults(RefRangeStart = 30306, RefRangeEnd = 30319, XrefRangeStart = 30306, XrefRangeEnd = 30306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleWaveManager.WaveDataBasic.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30319, XrefRangeEnd = 30336, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void AddCard(CardData card)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleWaveManager.WaveDataBasic.NativeMethodInfoPtr_AddCard_Public_Virtual_Void_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30336, XrefRangeEnd = 30353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void InsertCard(int index, CardData card)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleWaveManager.WaveDataBasic.NativeMethodInfoPtr_InsertCard_Public_Virtual_Void_Int32_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30353, XrefRangeEnd = 30385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe CardData GetCardData(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleWaveManager.WaveDataBasic.NativeMethodInfoPtr_GetCardData_Public_Virtual_CardData_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30385, XrefRangeEnd = 30395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe CardData PeekCardData(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleWaveManager.WaveDataBasic.NativeMethodInfoPtr_PeekCardData_Public_Virtual_CardData_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
    }

    [CallerCount(0)]
    public override unsafe string GetCardName(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleWaveManager.WaveDataBasic.NativeMethodInfoPtr_GetCardName_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30395, XrefRangeEnd = 30404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool AddUpgradeToCard(int index, CardUpgradeData upgradeData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgradeData);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleWaveManager.WaveDataBasic.NativeMethodInfoPtr_AddUpgradeToCard_Public_Virtual_Boolean_Int32_CardUpgradeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 30404, RefRangeEnd = 30411, XrefRangeStart = 30404, XrefRangeEnd = 30404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BattleWaveManager.Card Get(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleWaveManager.WaveDataBasic.NativeMethodInfoPtr_Get_Public_Card_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BattleWaveManager.Card) null : new BattleWaveManager.Card(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30411, XrefRangeEnd = 30465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BattleWaveManager.WaveDataFull ConvertToFull()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleWaveManager.WaveDataBasic.NativeMethodInfoPtr_ConvertToFull_Public_WaveDataFull_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BattleWaveManager.WaveDataFull) null : new BattleWaveManager.WaveDataFull(pointer);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WaveDataBasic()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleWaveManager.WaveDataBasic>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleWaveManager.WaveDataBasic.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WaveDataBasic()
    {
      Il2CppClassPointerStore<BattleWaveManager.WaveDataBasic>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleWaveManager>.NativeClassPtr, nameof (WaveDataBasic));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleWaveManager.WaveDataBasic>.NativeClassPtr);
      BattleWaveManager.WaveDataBasic.NativeFieldInfoPtr_cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveManager.WaveDataBasic>.NativeClassPtr, nameof (cards));
      BattleWaveManager.WaveDataBasic.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveDataBasic>.NativeClassPtr, 100665062);
      BattleWaveManager.WaveDataBasic.NativeMethodInfoPtr_AddCard_Public_Virtual_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveDataBasic>.NativeClassPtr, 100665063);
      BattleWaveManager.WaveDataBasic.NativeMethodInfoPtr_InsertCard_Public_Virtual_Void_Int32_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveDataBasic>.NativeClassPtr, 100665064);
      BattleWaveManager.WaveDataBasic.NativeMethodInfoPtr_GetCardData_Public_Virtual_CardData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveDataBasic>.NativeClassPtr, 100665065);
      BattleWaveManager.WaveDataBasic.NativeMethodInfoPtr_PeekCardData_Public_Virtual_CardData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveDataBasic>.NativeClassPtr, 100665066);
      BattleWaveManager.WaveDataBasic.NativeMethodInfoPtr_GetCardName_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveDataBasic>.NativeClassPtr, 100665067);
      BattleWaveManager.WaveDataBasic.NativeMethodInfoPtr_AddUpgradeToCard_Public_Virtual_Boolean_Int32_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveDataBasic>.NativeClassPtr, 100665068);
      BattleWaveManager.WaveDataBasic.NativeMethodInfoPtr_Get_Public_Card_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveDataBasic>.NativeClassPtr, 100665069);
      BattleWaveManager.WaveDataBasic.NativeMethodInfoPtr_ConvertToFull_Public_WaveDataFull_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveDataBasic>.NativeClassPtr, 100665070);
      BattleWaveManager.WaveDataBasic.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveDataBasic>.NativeClassPtr, 100665071);
    }

    public WaveDataBasic(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<BattleWaveManager.Card> cards
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.WaveDataBasic.NativeFieldInfoPtr_cards));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<BattleWaveManager.Card>) null : new Il2CppReferenceArray<BattleWaveManager.Card>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.WaveDataBasic.NativeFieldInfoPtr_cards), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public class WaveDataFull : BattleWaveManager.WaveData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_cardDatas;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddCard_Public_Virtual_Void_CardData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InsertCard_Public_Virtual_Void_Int32_CardData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCardData_Public_Virtual_CardData_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PeekCardData_Public_Virtual_CardData_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCardName_Public_Virtual_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddUpgradeToCard_Public_Virtual_Boolean_Int32_CardUpgradeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe int Count
    {
      [CallerCount(13), CachedScanResults(RefRangeStart = 30306, RefRangeEnd = 30319, XrefRangeStart = 30306, XrefRangeEnd = 30319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleWaveManager.WaveDataFull.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30465, XrefRangeEnd = 30480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void AddCard(CardData card)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleWaveManager.WaveDataFull.NativeMethodInfoPtr_AddCard_Public_Virtual_Void_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30480, XrefRangeEnd = 30495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void InsertCard(int index, CardData card)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleWaveManager.WaveDataFull.NativeMethodInfoPtr_InsertCard_Public_Virtual_Void_Int32_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30495, XrefRangeEnd = 30498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe CardData GetCardData(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleWaveManager.WaveDataFull.NativeMethodInfoPtr_GetCardData_Public_Virtual_CardData_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30498, XrefRangeEnd = 30508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe CardData PeekCardData(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleWaveManager.WaveDataFull.NativeMethodInfoPtr_PeekCardData_Public_Virtual_CardData_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
    }

    [CallerCount(0)]
    public override unsafe string GetCardName(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleWaveManager.WaveDataFull.NativeMethodInfoPtr_GetCardName_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30508, XrefRangeEnd = 30517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool AddUpgradeToCard(int index, CardUpgradeData upgradeData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgradeData);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleWaveManager.WaveDataFull.NativeMethodInfoPtr_AddUpgradeToCard_Public_Virtual_Boolean_Int32_CardUpgradeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WaveDataFull()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleWaveManager.WaveDataFull>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleWaveManager.WaveDataFull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WaveDataFull()
    {
      Il2CppClassPointerStore<BattleWaveManager.WaveDataFull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleWaveManager>.NativeClassPtr, nameof (WaveDataFull));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleWaveManager.WaveDataFull>.NativeClassPtr);
      BattleWaveManager.WaveDataFull.NativeFieldInfoPtr_cardDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveManager.WaveDataFull>.NativeClassPtr, nameof (cardDatas));
      BattleWaveManager.WaveDataFull.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveDataFull>.NativeClassPtr, 100665072);
      BattleWaveManager.WaveDataFull.NativeMethodInfoPtr_AddCard_Public_Virtual_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveDataFull>.NativeClassPtr, 100665073);
      BattleWaveManager.WaveDataFull.NativeMethodInfoPtr_InsertCard_Public_Virtual_Void_Int32_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveDataFull>.NativeClassPtr, 100665074);
      BattleWaveManager.WaveDataFull.NativeMethodInfoPtr_GetCardData_Public_Virtual_CardData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveDataFull>.NativeClassPtr, 100665075);
      BattleWaveManager.WaveDataFull.NativeMethodInfoPtr_PeekCardData_Public_Virtual_CardData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveDataFull>.NativeClassPtr, 100665076);
      BattleWaveManager.WaveDataFull.NativeMethodInfoPtr_GetCardName_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveDataFull>.NativeClassPtr, 100665077);
      BattleWaveManager.WaveDataFull.NativeMethodInfoPtr_AddUpgradeToCard_Public_Virtual_Boolean_Int32_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveDataFull>.NativeClassPtr, 100665078);
      BattleWaveManager.WaveDataFull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.WaveDataFull>.NativeClassPtr, 100665079);
    }

    public WaveDataFull(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<CardSaveData> cardDatas
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.WaveDataFull.NativeFieldInfoPtr_cardDatas));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardSaveData>) null : new Il2CppReferenceArray<CardSaveData>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.WaveDataFull.NativeFieldInfoPtr_cardDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public class Card : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_cardName;
    private static readonly System.IntPtr NativeFieldInfoPtr_upgradeNames;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddUpgrade_Public_Void_String_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Card()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleWaveManager.Card>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleWaveManager.Card.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(127)]
    [CachedScanResults(RefRangeStart = 30519, RefRangeEnd = 30646, XrefRangeStart = 30517, XrefRangeEnd = 30519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Card(string cardName)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleWaveManager.Card>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(cardName)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleWaveManager.Card.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30646, XrefRangeEnd = 30657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddUpgrade(string upgradeName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(upgradeName)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleWaveManager.Card.NativeMethodInfoPtr_AddUpgrade_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Card()
    {
      Il2CppClassPointerStore<BattleWaveManager.Card>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleWaveManager>.NativeClassPtr, nameof (Card));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleWaveManager.Card>.NativeClassPtr);
      BattleWaveManager.Card.NativeFieldInfoPtr_cardName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveManager.Card>.NativeClassPtr, nameof (cardName));
      BattleWaveManager.Card.NativeFieldInfoPtr_upgradeNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleWaveManager.Card>.NativeClassPtr, nameof (upgradeNames));
      BattleWaveManager.Card.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.Card>.NativeClassPtr, 100665080);
      BattleWaveManager.Card.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.Card>.NativeClassPtr, 100665081);
      BattleWaveManager.Card.NativeMethodInfoPtr_AddUpgrade_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleWaveManager.Card>.NativeClassPtr, 100665082);
    }

    public Card(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string cardName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.Card.NativeFieldInfoPtr_cardName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.Card.NativeFieldInfoPtr_cardName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe List<string> upgradeNames
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.Card.NativeFieldInfoPtr_upgradeNames));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleWaveManager.Card.NativeFieldInfoPtr_upgradeNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
