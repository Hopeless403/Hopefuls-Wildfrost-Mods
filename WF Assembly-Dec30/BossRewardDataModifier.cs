// Decompiled with JetBrains decompiler
// Type: BossRewardDataModifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class BossRewardDataModifier : BossRewardData
{
  private static readonly IntPtr NativeMethodInfoPtr_Pull_Public_Virtual_Data_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105476, XrefRangeEnd = 105492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe BossRewardData.Data Pull()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BossRewardDataModifier.NativeMethodInfoPtr_Pull_Public_Virtual_Data_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (BossRewardData.Data) null : new BossRewardData.Data(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BossRewardDataModifier()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BossRewardDataModifier>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BossRewardDataModifier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BossRewardDataModifier()
  {
    Il2CppClassPointerStore<BossRewardDataModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BossRewardDataModifier));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BossRewardDataModifier>.NativeClassPtr);
    BossRewardDataModifier.NativeMethodInfoPtr_Pull_Public_Virtual_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardDataModifier>.NativeClassPtr, 100672819);
    BossRewardDataModifier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardDataModifier>.NativeClassPtr, 100672820);
  }

  public BossRewardDataModifier(IntPtr pointer)
    : base(pointer)
  {
  }

  [Serializable]
  public new class Data : BossRewardData.Data
  {
    private static readonly IntPtr NativeFieldInfoPtr_modifierName;
    private static readonly IntPtr NativeMethodInfoPtr_GetModifier_Public_GameModifierData_0;
    private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 105445, RefRangeEnd = 105446, XrefRangeStart = 105437, XrefRangeEnd = 105445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameModifierData GetModifier()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(BossRewardDataModifier.Data.NativeMethodInfoPtr_GetModifier_Public_GameModifierData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (GameModifierData) null : new GameModifierData(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105446, XrefRangeEnd = 105476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Select()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BossRewardDataModifier.Data.NativeMethodInfoPtr_Select_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Data()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BossRewardDataModifier.Data>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BossRewardDataModifier.Data.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Data()
    {
      Il2CppClassPointerStore<BossRewardDataModifier.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BossRewardDataModifier>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BossRewardDataModifier.Data>.NativeClassPtr);
      BossRewardDataModifier.Data.NativeFieldInfoPtr_modifierName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossRewardDataModifier.Data>.NativeClassPtr, nameof (modifierName));
      BossRewardDataModifier.Data.NativeMethodInfoPtr_GetModifier_Public_GameModifierData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardDataModifier.Data>.NativeClassPtr, 100672821);
      BossRewardDataModifier.Data.NativeMethodInfoPtr_Select_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardDataModifier.Data>.NativeClassPtr, 100672822);
      BossRewardDataModifier.Data.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardDataModifier.Data>.NativeClassPtr, 100672823);
    }

    public Data(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string modifierName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossRewardDataModifier.Data.NativeFieldInfoPtr_modifierName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BossRewardDataModifier.Data.NativeFieldInfoPtr_modifierName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
