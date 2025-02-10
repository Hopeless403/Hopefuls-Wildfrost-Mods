// Decompiled with JetBrains decompiler
// Type: BattleMusicSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
[Serializable]
public class BattleMusicSaveData : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_intensity;
  private static readonly System.IntPtr NativeFieldInfoPtr_bossEntered;
  private static readonly System.IntPtr NativeFieldInfoPtr_bossPhase;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1959)]
  [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BattleMusicSaveData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleMusicSaveData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleMusicSaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BattleMusicSaveData()
  {
    Il2CppClassPointerStore<BattleMusicSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BattleMusicSaveData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleMusicSaveData>.NativeClassPtr);
    BattleMusicSaveData.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSaveData>.NativeClassPtr, nameof (intensity));
    BattleMusicSaveData.NativeFieldInfoPtr_bossEntered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSaveData>.NativeClassPtr, nameof (bossEntered));
    BattleMusicSaveData.NativeFieldInfoPtr_bossPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSaveData>.NativeClassPtr, nameof (bossPhase));
    BattleMusicSaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSaveData>.NativeClassPtr, 100672623);
  }

  public BattleMusicSaveData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int intensity
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSaveData.NativeFieldInfoPtr_intensity));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSaveData.NativeFieldInfoPtr_intensity)) = value;
    }
  }

  public unsafe bool bossEntered
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSaveData.NativeFieldInfoPtr_bossEntered));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSaveData.NativeFieldInfoPtr_bossEntered)) = value;
    }
  }

  public unsafe int bossPhase
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSaveData.NativeFieldInfoPtr_bossPhase));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSaveData.NativeFieldInfoPtr_bossPhase)) = value;
    }
  }
}
