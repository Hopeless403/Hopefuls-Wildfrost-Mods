// Decompiled with JetBrains decompiler
// Type: BossRewardPool
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
public class BossRewardPool : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_bossRewards;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BossRewardPool()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BossRewardPool>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BossRewardPool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BossRewardPool()
  {
    Il2CppClassPointerStore<BossRewardPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BossRewardPool));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BossRewardPool>.NativeClassPtr);
    BossRewardPool.NativeFieldInfoPtr_bossRewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossRewardPool>.NativeClassPtr, nameof (bossRewards));
    BossRewardPool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardPool>.NativeClassPtr, 100672830);
  }

  public BossRewardPool(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<BossRewardData> bossRewards
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossRewardPool.NativeFieldInfoPtr_bossRewards));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<BossRewardData>) null : new Il2CppReferenceArray<BossRewardData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BossRewardPool.NativeFieldInfoPtr_bossRewards), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
