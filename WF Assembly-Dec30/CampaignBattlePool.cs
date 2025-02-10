// Decompiled with JetBrains decompiler
// Type: CampaignBattlePool
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
public class CampaignBattlePool : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_basePoints;
  private static readonly System.IntPtr NativeFieldInfoPtr_tiers;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomBattle_Public_BattleData_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomBossBattle_Public_BattleData_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPoints_Public_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31708, XrefRangeEnd = 31713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BattleData GetRandomBattle(int tier)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &tier
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignBattlePool.NativeMethodInfoPtr_GetRandomBattle_Public_BattleData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (BattleData) null : new BattleData(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31713, XrefRangeEnd = 31718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BattleData GetRandomBossBattle(int tier)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &tier
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignBattlePool.NativeMethodInfoPtr_GetRandomBossBattle_Public_BattleData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (BattleData) null : new BattleData(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31718, XrefRangeEnd = 31719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetPoints(int tier, int battleLevel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &tier;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &battleLevel;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignBattlePool.NativeMethodInfoPtr_GetPoints_Public_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CampaignBattlePool()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignBattlePool>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignBattlePool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CampaignBattlePool()
  {
    Il2CppClassPointerStore<CampaignBattlePool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CampaignBattlePool));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignBattlePool>.NativeClassPtr);
    CampaignBattlePool.NativeFieldInfoPtr_basePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignBattlePool>.NativeClassPtr, nameof (basePoints));
    CampaignBattlePool.NativeFieldInfoPtr_tiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignBattlePool>.NativeClassPtr, nameof (tiers));
    CampaignBattlePool.NativeMethodInfoPtr_GetRandomBattle_Public_BattleData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignBattlePool>.NativeClassPtr, 100665191);
    CampaignBattlePool.NativeMethodInfoPtr_GetRandomBossBattle_Public_BattleData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignBattlePool>.NativeClassPtr, 100665192);
    CampaignBattlePool.NativeMethodInfoPtr_GetPoints_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignBattlePool>.NativeClassPtr, 100665193);
    CampaignBattlePool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignBattlePool>.NativeClassPtr, 100665194);
  }

  public CampaignBattlePool(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int basePoints
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignBattlePool.NativeFieldInfoPtr_basePoints));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignBattlePool.NativeFieldInfoPtr_basePoints)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<CampaignBattlePool.Tier> tiers
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignBattlePool.NativeFieldInfoPtr_tiers));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CampaignBattlePool.Tier>) null : new Il2CppReferenceArray<CampaignBattlePool.Tier>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignBattlePool.NativeFieldInfoPtr_tiers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class Tier : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_pointRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_pointsAdd;
    private static readonly System.IntPtr NativeFieldInfoPtr_battles;
    private static readonly System.IntPtr NativeFieldInfoPtr_bosses;

    static Tier()
    {
      Il2CppClassPointerStore<CampaignBattlePool.Tier>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignBattlePool>.NativeClassPtr, nameof (Tier));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignBattlePool.Tier>.NativeClassPtr);
      CampaignBattlePool.Tier.NativeFieldInfoPtr_pointRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignBattlePool.Tier>.NativeClassPtr, nameof (pointRange));
      CampaignBattlePool.Tier.NativeFieldInfoPtr_pointsAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignBattlePool.Tier>.NativeClassPtr, nameof (pointsAdd));
      CampaignBattlePool.Tier.NativeFieldInfoPtr_battles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignBattlePool.Tier>.NativeClassPtr, nameof (battles));
      CampaignBattlePool.Tier.NativeFieldInfoPtr_bosses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignBattlePool.Tier>.NativeClassPtr, nameof (bosses));
    }

    public Tier(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Tier()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CampaignBattlePool.Tier>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CampaignBattlePool.Tier>.NativeClassPtr, data));
    }

    public unsafe Vector2Int pointRange
    {
      get
      {
        return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignBattlePool.Tier.NativeFieldInfoPtr_pointRange));
      }
      [param: In] set
      {
        *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignBattlePool.Tier.NativeFieldInfoPtr_pointRange)) = value;
      }
    }

    public unsafe int pointsAdd
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignBattlePool.Tier.NativeFieldInfoPtr_pointsAdd));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignBattlePool.Tier.NativeFieldInfoPtr_pointsAdd)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<BattleData> battles
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignBattlePool.Tier.NativeFieldInfoPtr_battles));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<BattleData>) null : new Il2CppReferenceArray<BattleData>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignBattlePool.Tier.NativeFieldInfoPtr_battles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<BattleData> bosses
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignBattlePool.Tier.NativeFieldInfoPtr_bosses));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<BattleData>) null : new Il2CppReferenceArray<BattleData>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignBattlePool.Tier.NativeFieldInfoPtr_bosses), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
