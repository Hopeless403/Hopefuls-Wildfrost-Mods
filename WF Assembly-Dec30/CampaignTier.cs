// Decompiled with JetBrains decompiler
// Type: CampaignTier
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
public class CampaignTier : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_pointRange;
  private static readonly IntPtr NativeFieldInfoPtr_battlePool;
  private static readonly IntPtr NativeFieldInfoPtr_rewardPool;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CampaignTier()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignTier>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignTier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CampaignTier()
  {
    Il2CppClassPointerStore<CampaignTier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CampaignTier));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignTier>.NativeClassPtr);
    CampaignTier.NativeFieldInfoPtr_pointRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignTier>.NativeClassPtr, nameof (pointRange));
    CampaignTier.NativeFieldInfoPtr_battlePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignTier>.NativeClassPtr, nameof (battlePool));
    CampaignTier.NativeFieldInfoPtr_rewardPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignTier>.NativeClassPtr, nameof (rewardPool));
    CampaignTier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignTier>.NativeClassPtr, 100673156);
  }

  public CampaignTier(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Vector2Int pointRange
  {
    get
    {
      return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignTier.NativeFieldInfoPtr_pointRange));
    }
    [param: In] set
    {
      *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignTier.NativeFieldInfoPtr_pointRange)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<BattleData> battlePool
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignTier.NativeFieldInfoPtr_battlePool));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<BattleData>) null : new Il2CppReferenceArray<BattleData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignTier.NativeFieldInfoPtr_battlePool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CampaignNodeType> rewardPool
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignTier.NativeFieldInfoPtr_rewardPool));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<CampaignNodeType>) null : new Il2CppReferenceArray<CampaignNodeType>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignTier.NativeFieldInfoPtr_rewardPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
