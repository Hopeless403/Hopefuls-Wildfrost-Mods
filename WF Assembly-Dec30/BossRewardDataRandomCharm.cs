// Decompiled with JetBrains decompiler
// Type: BossRewardDataRandomCharm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class BossRewardDataRandomCharm : BossRewardData
{
  private static readonly IntPtr NativeFieldInfoPtr_minTier;
  private static readonly IntPtr NativeMethodInfoPtr_Pull_Public_Virtual_Data_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckTier_Private_Boolean_DataFile_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105517, XrefRangeEnd = 105539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe BossRewardData.Data Pull()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BossRewardDataRandomCharm.NativeMethodInfoPtr_Pull_Public_Virtual_Data_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (BossRewardData.Data) null : new BossRewardData.Data(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105539, XrefRangeEnd = 105541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckTier(DataFile dataFile)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dataFile)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(BossRewardDataRandomCharm.NativeMethodInfoPtr_CheckTier_Private_Boolean_DataFile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105541, XrefRangeEnd = 105542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BossRewardDataRandomCharm()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BossRewardDataRandomCharm>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BossRewardDataRandomCharm.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BossRewardDataRandomCharm()
  {
    Il2CppClassPointerStore<BossRewardDataRandomCharm>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BossRewardDataRandomCharm));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BossRewardDataRandomCharm>.NativeClassPtr);
    BossRewardDataRandomCharm.NativeFieldInfoPtr_minTier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossRewardDataRandomCharm>.NativeClassPtr, nameof (minTier));
    BossRewardDataRandomCharm.NativeMethodInfoPtr_Pull_Public_Virtual_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardDataRandomCharm>.NativeClassPtr, 100672824);
    BossRewardDataRandomCharm.NativeMethodInfoPtr_CheckTier_Private_Boolean_DataFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardDataRandomCharm>.NativeClassPtr, 100672825);
    BossRewardDataRandomCharm.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardDataRandomCharm>.NativeClassPtr, 100672826);
  }

  public BossRewardDataRandomCharm(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int minTier
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossRewardDataRandomCharm.NativeFieldInfoPtr_minTier));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossRewardDataRandomCharm.NativeFieldInfoPtr_minTier)) = value;
    }
  }

  [Serializable]
  public new class Data : BossRewardData.Data
  {
    private static readonly IntPtr NativeFieldInfoPtr_upgradeName;
    private static readonly IntPtr NativeMethodInfoPtr_GetUpgrade_Public_CardUpgradeData_0;
    private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 105500, RefRangeEnd = 105501, XrefRangeStart = 105492, XrefRangeEnd = 105500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CardUpgradeData GetUpgrade()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(BossRewardDataRandomCharm.Data.NativeMethodInfoPtr_GetUpgrade_Public_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (CardUpgradeData) null : new CardUpgradeData(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105501, XrefRangeEnd = 105517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Select()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BossRewardDataRandomCharm.Data.NativeMethodInfoPtr_Select_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Data()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BossRewardDataRandomCharm.Data>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BossRewardDataRandomCharm.Data.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Data()
    {
      Il2CppClassPointerStore<BossRewardDataRandomCharm.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BossRewardDataRandomCharm>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BossRewardDataRandomCharm.Data>.NativeClassPtr);
      BossRewardDataRandomCharm.Data.NativeFieldInfoPtr_upgradeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossRewardDataRandomCharm.Data>.NativeClassPtr, nameof (upgradeName));
      BossRewardDataRandomCharm.Data.NativeMethodInfoPtr_GetUpgrade_Public_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardDataRandomCharm.Data>.NativeClassPtr, 100672827);
      BossRewardDataRandomCharm.Data.NativeMethodInfoPtr_Select_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardDataRandomCharm.Data>.NativeClassPtr, 100672828);
      BossRewardDataRandomCharm.Data.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardDataRandomCharm.Data>.NativeClassPtr, 100672829);
    }

    public Data(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string upgradeName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossRewardDataRandomCharm.Data.NativeFieldInfoPtr_upgradeName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BossRewardDataRandomCharm.Data.NativeFieldInfoPtr_upgradeName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
