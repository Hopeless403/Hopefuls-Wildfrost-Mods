// Decompiled with JetBrains decompiler
// Type: SaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
[Serializable]
public class SaveData : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_stats;
  private static readonly System.IntPtr NativeFieldInfoPtr_runHistory;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1959)]
  [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SaveData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SaveData()
  {
    Il2CppClassPointerStore<SaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SaveData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveData>.NativeClassPtr);
    SaveData.NativeFieldInfoPtr_stats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, nameof (stats));
    SaveData.NativeFieldInfoPtr_runHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, nameof (runHistory));
    SaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveData>.NativeClassPtr, 100672690);
  }

  public SaveData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe StatsSaveData stats
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_stats));
      return pointer == System.IntPtr.Zero ? (StatsSaveData) null : new StatsSaveData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_stats), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CampaignSaveData> runHistory
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_runHistory));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CampaignSaveData>) null : new Il2CppReferenceArray<CampaignSaveData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_runHistory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
