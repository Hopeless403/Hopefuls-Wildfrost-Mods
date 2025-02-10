// Decompiled with JetBrains decompiler
// Type: CampaignBattleRewardPool
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
public class CampaignBattleRewardPool : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_pools;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CampaignBattleRewardPool()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignBattleRewardPool>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignBattleRewardPool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CampaignBattleRewardPool()
  {
    Il2CppClassPointerStore<CampaignBattleRewardPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CampaignBattleRewardPool));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignBattleRewardPool>.NativeClassPtr);
    CampaignBattleRewardPool.NativeFieldInfoPtr_pools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignBattleRewardPool>.NativeClassPtr, nameof (pools));
    CampaignBattleRewardPool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignBattleRewardPool>.NativeClassPtr, 100665195);
  }

  public CampaignBattleRewardPool(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<CampaignBattleRewardPool.Pool> pools
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignBattleRewardPool.NativeFieldInfoPtr_pools));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CampaignBattleRewardPool.Pool>) null : new Il2CppReferenceArray<CampaignBattleRewardPool.Pool>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignBattleRewardPool.NativeFieldInfoPtr_pools), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class Pool : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_nodeTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_rewards;
    private static readonly System.IntPtr NativeFieldInfoPtr_pool;
    private static readonly System.IntPtr NativeMethodInfoPtr_Pull_Public_RewardData_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31719, XrefRangeEnd = 31739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RewardData Pull()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignBattleRewardPool.Pool.NativeMethodInfoPtr_Pull_Public_RewardData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (RewardData) null : new RewardData(pointer);
    }

    static Pool()
    {
      Il2CppClassPointerStore<CampaignBattleRewardPool.Pool>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignBattleRewardPool>.NativeClassPtr, nameof (Pool));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignBattleRewardPool.Pool>.NativeClassPtr);
      CampaignBattleRewardPool.Pool.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignBattleRewardPool.Pool>.NativeClassPtr, nameof (name));
      CampaignBattleRewardPool.Pool.NativeFieldInfoPtr_nodeTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignBattleRewardPool.Pool>.NativeClassPtr, nameof (nodeTypes));
      CampaignBattleRewardPool.Pool.NativeFieldInfoPtr_rewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignBattleRewardPool.Pool>.NativeClassPtr, nameof (rewards));
      CampaignBattleRewardPool.Pool.NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignBattleRewardPool.Pool>.NativeClassPtr, nameof (pool));
      CampaignBattleRewardPool.Pool.NativeMethodInfoPtr_Pull_Public_RewardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignBattleRewardPool.Pool>.NativeClassPtr, 100665196);
    }

    public Pool(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Pool()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CampaignBattleRewardPool.Pool>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CampaignBattleRewardPool.Pool>.NativeClassPtr, data));
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignBattleRewardPool.Pool.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignBattleRewardPool.Pool.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe List<CampaignNodeType> nodeTypes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignBattleRewardPool.Pool.NativeFieldInfoPtr_nodeTypes));
        return pointer == System.IntPtr.Zero ? (List<CampaignNodeType>) null : new List<CampaignNodeType>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignBattleRewardPool.Pool.NativeFieldInfoPtr_nodeTypes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<RewardData> rewards
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignBattleRewardPool.Pool.NativeFieldInfoPtr_rewards));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<RewardData>) null : new Il2CppReferenceArray<RewardData>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignBattleRewardPool.Pool.NativeFieldInfoPtr_rewards), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<RewardData> pool
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignBattleRewardPool.Pool.NativeFieldInfoPtr_pool));
        return pointer == System.IntPtr.Zero ? (List<RewardData>) null : new List<RewardData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignBattleRewardPool.Pool.NativeFieldInfoPtr_pool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
