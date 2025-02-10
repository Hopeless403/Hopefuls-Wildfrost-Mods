// Decompiled with JetBrains decompiler
// Type: BlessingData
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
public class BlessingData : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_modifierToAdd;
  private static readonly System.IntPtr NativeMethodInfoPtr_Select_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 98571, RefRangeEnd = 98572, XrefRangeStart = 98549, XrefRangeEnd = 98571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Select()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BlessingData.NativeMethodInfoPtr_Select_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1959)]
  [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BlessingData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlessingData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BlessingData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BlessingData()
  {
    Il2CppClassPointerStore<BlessingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BlessingData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlessingData>.NativeClassPtr);
    BlessingData.NativeFieldInfoPtr_modifierToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlessingData>.NativeClassPtr, nameof (modifierToAdd));
    BlessingData.NativeMethodInfoPtr_Select_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlessingData>.NativeClassPtr, 100671998);
    BlessingData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlessingData>.NativeClassPtr, 100671999);
  }

  public BlessingData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe GameModifierData modifierToAdd
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlessingData.NativeFieldInfoPtr_modifierToAdd));
      return pointer == System.IntPtr.Zero ? (GameModifierData) null : new GameModifierData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlessingData.NativeFieldInfoPtr_modifierToAdd), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
