// Decompiled with JetBrains decompiler
// Type: RunHistory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
public class RunHistory : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_gameModeName;
  private static readonly System.IntPtr NativeFieldInfoPtr_result;
  private static readonly System.IntPtr NativeFieldInfoPtr_stats;
  private static readonly System.IntPtr NativeFieldInfoPtr_tribe;
  private static readonly System.IntPtr NativeFieldInfoPtr_inventory;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameMode_Result_CampaignStats_PlayerData_0;

  [CallerCount(1959)]
  [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RunHistory()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunHistory>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RunHistory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 103944, RefRangeEnd = 103945, XrefRangeStart = 103935, XrefRangeEnd = 103944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RunHistory(
    GameMode gameMode,
    Campaign.Result result,
    CampaignStats stats,
    PlayerData playerData)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunHistory>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameMode);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stats);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) playerData);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RunHistory.NativeMethodInfoPtr__ctor_Public_Void_GameMode_Result_CampaignStats_PlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static RunHistory()
  {
    Il2CppClassPointerStore<RunHistory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (RunHistory));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunHistory>.NativeClassPtr);
    RunHistory.NativeFieldInfoPtr_gameModeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunHistory>.NativeClassPtr, nameof (gameModeName));
    RunHistory.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunHistory>.NativeClassPtr, nameof (result));
    RunHistory.NativeFieldInfoPtr_stats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunHistory>.NativeClassPtr, nameof (stats));
    RunHistory.NativeFieldInfoPtr_tribe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunHistory>.NativeClassPtr, nameof (tribe));
    RunHistory.NativeFieldInfoPtr_inventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunHistory>.NativeClassPtr, nameof (inventory));
    RunHistory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunHistory>.NativeClassPtr, 100672679);
    RunHistory.NativeMethodInfoPtr__ctor_Public_Void_GameMode_Result_CampaignStats_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunHistory>.NativeClassPtr, 100672680);
  }

  public RunHistory(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string gameModeName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RunHistory.NativeFieldInfoPtr_gameModeName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RunHistory.NativeFieldInfoPtr_gameModeName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Campaign.Result result
  {
    get
    {
      return *(Campaign.Result*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RunHistory.NativeFieldInfoPtr_result));
    }
    [param: In] set
    {
      *(Campaign.Result*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RunHistory.NativeFieldInfoPtr_result)) = value;
    }
  }

  public unsafe CampaignStats stats
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RunHistory.NativeFieldInfoPtr_stats));
      return pointer == System.IntPtr.Zero ? (CampaignStats) null : new CampaignStats(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RunHistory.NativeFieldInfoPtr_stats), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClassSaveData tribe
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RunHistory.NativeFieldInfoPtr_tribe));
      return pointer == System.IntPtr.Zero ? (ClassSaveData) null : new ClassSaveData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RunHistory.NativeFieldInfoPtr_tribe), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe InventorySaveData inventory
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RunHistory.NativeFieldInfoPtr_inventory));
      return pointer == System.IntPtr.Zero ? (InventorySaveData) null : new InventorySaveData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RunHistory.NativeFieldInfoPtr_inventory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
