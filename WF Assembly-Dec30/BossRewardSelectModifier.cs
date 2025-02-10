// Decompiled with JetBrains decompiler
// Type: BossRewardSelectModifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class BossRewardSelectModifier : BossRewardSelect
{
  private static readonly IntPtr NativeFieldInfoPtr_bellImage;
  private static readonly IntPtr NativeFieldInfoPtr_dingerImage;
  private static readonly IntPtr NativeMethodInfoPtr_SetUp_Public_Virtual_Void_Data_GainBlessingSequence2_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86916, XrefRangeEnd = 86928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void SetUp(
    BossRewardData.Data rewardData,
    GainBlessingSequence2 gainBlessingSequence)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rewardData);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gainBlessingSequence);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BossRewardSelectModifier.NativeMethodInfoPtr_SetUp_Public_Virtual_Void_Data_GainBlessingSequence2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86928, XrefRangeEnd = 86932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BossRewardSelectModifier()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BossRewardSelectModifier>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BossRewardSelectModifier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BossRewardSelectModifier()
  {
    Il2CppClassPointerStore<BossRewardSelectModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BossRewardSelectModifier));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BossRewardSelectModifier>.NativeClassPtr);
    BossRewardSelectModifier.NativeFieldInfoPtr_bellImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossRewardSelectModifier>.NativeClassPtr, nameof (bellImage));
    BossRewardSelectModifier.NativeFieldInfoPtr_dingerImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossRewardSelectModifier>.NativeClassPtr, nameof (dingerImage));
    BossRewardSelectModifier.NativeMethodInfoPtr_SetUp_Public_Virtual_Void_Data_GainBlessingSequence2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardSelectModifier>.NativeClassPtr, 100670629);
    BossRewardSelectModifier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardSelectModifier>.NativeClassPtr, 100670630);
  }

  public BossRewardSelectModifier(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe ImageSprite bellImage
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossRewardSelectModifier.NativeFieldInfoPtr_bellImage));
      return pointer == IntPtr.Zero ? (ImageSprite) null : new ImageSprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BossRewardSelectModifier.NativeFieldInfoPtr_bellImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ImageSprite dingerImage
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossRewardSelectModifier.NativeFieldInfoPtr_dingerImage));
      return pointer == IntPtr.Zero ? (ImageSprite) null : new ImageSprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BossRewardSelectModifier.NativeFieldInfoPtr_dingerImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
