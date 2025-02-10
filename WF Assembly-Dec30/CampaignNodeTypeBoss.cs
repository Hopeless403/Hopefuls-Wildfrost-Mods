// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeBoss
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class CampaignNodeTypeBoss : CampaignNodeTypeBattle
{
  private static readonly System.IntPtr NativeFieldInfoPtr_areaProfiles;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetUp_Public_Virtual_IEnumerator_CampaignNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRewards_Public_Void_CampaignNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRewards_Private_Static_List_1_Data_AreaProfile_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106188, XrefRangeEnd = 106194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator SetUp(CampaignNode node)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CampaignNodeTypeBoss.NativeMethodInfoPtr_SetUp_Public_Virtual_IEnumerator_CampaignNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 106226, RefRangeEnd = 106228, XrefRangeStart = 106194, XrefRangeEnd = 106226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetRewards(CampaignNode node)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignNodeTypeBoss.NativeMethodInfoPtr_GetRewards_Public_Void_CampaignNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 106261, RefRangeEnd = 106262, XrefRangeStart = 106228, XrefRangeEnd = 106261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe List<BossRewardData.Data> GetRewards(CampaignNodeTypeBoss.AreaProfile profile)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) profile)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignNodeTypeBoss.NativeMethodInfoPtr_GetRewards_Private_Static_List_1_Data_AreaProfile_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<BossRewardData.Data>) null : new List<BossRewardData.Data>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CampaignNodeTypeBoss()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignNodeTypeBoss>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignNodeTypeBoss.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CampaignNodeTypeBoss()
  {
    Il2CppClassPointerStore<CampaignNodeTypeBoss>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CampaignNodeTypeBoss));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignNodeTypeBoss>.NativeClassPtr);
    CampaignNodeTypeBoss.NativeFieldInfoPtr_areaProfiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeTypeBoss>.NativeClassPtr, nameof (areaProfiles));
    CampaignNodeTypeBoss.NativeMethodInfoPtr_SetUp_Public_Virtual_IEnumerator_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNodeTypeBoss>.NativeClassPtr, 100672891);
    CampaignNodeTypeBoss.NativeMethodInfoPtr_GetRewards_Public_Void_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNodeTypeBoss>.NativeClassPtr, 100672892);
    CampaignNodeTypeBoss.NativeMethodInfoPtr_GetRewards_Private_Static_List_1_Data_AreaProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNodeTypeBoss>.NativeClassPtr, 100672893);
    CampaignNodeTypeBoss.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNodeTypeBoss>.NativeClassPtr, 100672894);
  }

  public CampaignNodeTypeBoss(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<CampaignNodeTypeBoss.AreaProfile> areaProfiles
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeTypeBoss.NativeFieldInfoPtr_areaProfiles));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CampaignNodeTypeBoss.AreaProfile>) null : new Il2CppReferenceArray<CampaignNodeTypeBoss.AreaProfile>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeTypeBoss.NativeFieldInfoPtr_areaProfiles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class AreaProfile : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_areaIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_canTake;
    private static readonly System.IntPtr NativeFieldInfoPtr_pool;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106180, XrefRangeEnd = 106181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AreaProfile()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignNodeTypeBoss.AreaProfile>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignNodeTypeBoss.AreaProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AreaProfile()
    {
      Il2CppClassPointerStore<CampaignNodeTypeBoss.AreaProfile>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignNodeTypeBoss>.NativeClassPtr, nameof (AreaProfile));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignNodeTypeBoss.AreaProfile>.NativeClassPtr);
      CampaignNodeTypeBoss.AreaProfile.NativeFieldInfoPtr_areaIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeTypeBoss.AreaProfile>.NativeClassPtr, nameof (areaIndex));
      CampaignNodeTypeBoss.AreaProfile.NativeFieldInfoPtr_canTake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeTypeBoss.AreaProfile>.NativeClassPtr, nameof (canTake));
      CampaignNodeTypeBoss.AreaProfile.NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeTypeBoss.AreaProfile>.NativeClassPtr, nameof (pool));
      CampaignNodeTypeBoss.AreaProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNodeTypeBoss.AreaProfile>.NativeClassPtr, 100672895);
    }

    public AreaProfile(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int areaIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeTypeBoss.AreaProfile.NativeFieldInfoPtr_areaIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeTypeBoss.AreaProfile.NativeFieldInfoPtr_areaIndex)) = value;
      }
    }

    public unsafe int canTake
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeTypeBoss.AreaProfile.NativeFieldInfoPtr_canTake));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeTypeBoss.AreaProfile.NativeFieldInfoPtr_canTake)) = value;
      }
    }

    public unsafe BossRewardPool pool
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeTypeBoss.AreaProfile.NativeFieldInfoPtr_pool));
        return pointer == System.IntPtr.Zero ? (BossRewardPool) null : new BossRewardPool(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeTypeBoss.AreaProfile.NativeFieldInfoPtr_pool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public class RewardData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_rewards;
    private static readonly System.IntPtr NativeFieldInfoPtr_canTake;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RewardData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignNodeTypeBoss.RewardData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignNodeTypeBoss.RewardData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RewardData()
    {
      Il2CppClassPointerStore<CampaignNodeTypeBoss.RewardData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignNodeTypeBoss>.NativeClassPtr, nameof (RewardData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignNodeTypeBoss.RewardData>.NativeClassPtr);
      CampaignNodeTypeBoss.RewardData.NativeFieldInfoPtr_rewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeTypeBoss.RewardData>.NativeClassPtr, nameof (rewards));
      CampaignNodeTypeBoss.RewardData.NativeFieldInfoPtr_canTake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeTypeBoss.RewardData>.NativeClassPtr, nameof (canTake));
      CampaignNodeTypeBoss.RewardData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNodeTypeBoss.RewardData>.NativeClassPtr, 100672896);
    }

    public RewardData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<BossRewardData.Data> rewards
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeTypeBoss.RewardData.NativeFieldInfoPtr_rewards));
        return pointer == System.IntPtr.Zero ? (List<BossRewardData.Data>) null : new List<BossRewardData.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeTypeBoss.RewardData.NativeFieldInfoPtr_rewards), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int canTake
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeTypeBoss.RewardData.NativeFieldInfoPtr_canTake));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeTypeBoss.RewardData.NativeFieldInfoPtr_canTake)) = value;
      }
    }
  }

  [ObfuscatedName("CampaignNodeTypeBoss/<SetUp>d__1")]
  public sealed class _SetUp_d__1 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_node;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _SetUp_d__1(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignNodeTypeBoss._SetUp_d__1>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignNodeTypeBoss._SetUp_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignNodeTypeBoss._SetUp_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106181, XrefRangeEnd = 106182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignNodeTypeBoss._SetUp_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignNodeTypeBoss._SetUp_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106182, XrefRangeEnd = 106188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignNodeTypeBoss._SetUp_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignNodeTypeBoss._SetUp_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _SetUp_d__1()
    {
      Il2CppClassPointerStore<CampaignNodeTypeBoss._SetUp_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignNodeTypeBoss>.NativeClassPtr, "<SetUp>d__1");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignNodeTypeBoss._SetUp_d__1>.NativeClassPtr);
      CampaignNodeTypeBoss._SetUp_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeTypeBoss._SetUp_d__1>.NativeClassPtr, "<>1__state");
      CampaignNodeTypeBoss._SetUp_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeTypeBoss._SetUp_d__1>.NativeClassPtr, "<>2__current");
      CampaignNodeTypeBoss._SetUp_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeTypeBoss._SetUp_d__1>.NativeClassPtr, "<>4__this");
      CampaignNodeTypeBoss._SetUp_d__1.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeTypeBoss._SetUp_d__1>.NativeClassPtr, nameof (node));
      CampaignNodeTypeBoss._SetUp_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNodeTypeBoss._SetUp_d__1>.NativeClassPtr, 100672897);
      CampaignNodeTypeBoss._SetUp_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNodeTypeBoss._SetUp_d__1>.NativeClassPtr, 100672898);
      CampaignNodeTypeBoss._SetUp_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNodeTypeBoss._SetUp_d__1>.NativeClassPtr, 100672899);
      CampaignNodeTypeBoss._SetUp_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNodeTypeBoss._SetUp_d__1>.NativeClassPtr, 100672900);
      CampaignNodeTypeBoss._SetUp_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNodeTypeBoss._SetUp_d__1>.NativeClassPtr, 100672901);
      CampaignNodeTypeBoss._SetUp_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNodeTypeBoss._SetUp_d__1>.NativeClassPtr, 100672902);
    }

    public _SetUp_d__1(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeTypeBoss._SetUp_d__1.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeTypeBoss._SetUp_d__1.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeTypeBoss._SetUp_d__1.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeTypeBoss._SetUp_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CampaignNodeTypeBoss __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeTypeBoss._SetUp_d__1.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (CampaignNodeTypeBoss) null : new CampaignNodeTypeBoss(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeTypeBoss._SetUp_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CampaignNode node
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeTypeBoss._SetUp_d__1.NativeFieldInfoPtr_node));
        return pointer == System.IntPtr.Zero ? (CampaignNode) null : new CampaignNode(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeTypeBoss._SetUp_d__1.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("CampaignNodeTypeBoss/<>c__DisplayClass2_0")]
  public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_node;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetRewards_b__0_Internal_Boolean_AreaProfile_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass2_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignNodeTypeBoss.__c__DisplayClass2_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignNodeTypeBoss.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _GetRewards_b__0(CampaignNodeTypeBoss.AreaProfile a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignNodeTypeBoss.__c__DisplayClass2_0.NativeMethodInfoPtr__GetRewards_b__0_Internal_Boolean_AreaProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass2_0()
    {
      Il2CppClassPointerStore<CampaignNodeTypeBoss.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignNodeTypeBoss>.NativeClassPtr, "<>c__DisplayClass2_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignNodeTypeBoss.__c__DisplayClass2_0>.NativeClassPtr);
      CampaignNodeTypeBoss.__c__DisplayClass2_0.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeTypeBoss.__c__DisplayClass2_0>.NativeClassPtr, nameof (node));
      CampaignNodeTypeBoss.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNodeTypeBoss.__c__DisplayClass2_0>.NativeClassPtr, 100672903);
      CampaignNodeTypeBoss.__c__DisplayClass2_0.NativeMethodInfoPtr__GetRewards_b__0_Internal_Boolean_AreaProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNodeTypeBoss.__c__DisplayClass2_0>.NativeClassPtr, 100672904);
    }

    public __c__DisplayClass2_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CampaignNode node
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeTypeBoss.__c__DisplayClass2_0.NativeFieldInfoPtr_node));
        return pointer == System.IntPtr.Zero ? (CampaignNode) null : new CampaignNode(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeTypeBoss.__c__DisplayClass2_0.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
