// Decompiled with JetBrains decompiler
// Type: BossRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class BossRewardData : DataFile
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Pull_Public_Abstract_Virtual_New_Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  [CallerCount(0)]
  public virtual unsafe BossRewardData.Data Pull()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BossRewardData.NativeMethodInfoPtr_Pull_Public_Abstract_Virtual_New_Data_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (BossRewardData.Data) null : new BossRewardData.Data(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BossRewardData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BossRewardData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BossRewardData.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BossRewardData()
  {
    Il2CppClassPointerStore<BossRewardData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BossRewardData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BossRewardData>.NativeClassPtr);
    BossRewardData.NativeMethodInfoPtr_Pull_Public_Abstract_Virtual_New_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardData>.NativeClassPtr, 100672810);
    BossRewardData.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardData>.NativeClassPtr, 100672811);
  }

  public BossRewardData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public enum Type
  {
    Modifier,
    Charm,
    Crown,
  }

  [Serializable]
  public class Data : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_type;
    private static readonly System.IntPtr NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    [CallerCount(0)]
    public virtual unsafe void Select()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BossRewardData.Data.NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Data()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BossRewardData.Data>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BossRewardData.Data.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Data()
    {
      Il2CppClassPointerStore<BossRewardData.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BossRewardData>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BossRewardData.Data>.NativeClassPtr);
      BossRewardData.Data.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossRewardData.Data>.NativeClassPtr, nameof (type));
      BossRewardData.Data.NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardData.Data>.NativeClassPtr, 100672812);
      BossRewardData.Data.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardData.Data>.NativeClassPtr, 100672813);
    }

    public Data(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BossRewardData.Type type
    {
      get
      {
        return *(BossRewardData.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossRewardData.Data.NativeFieldInfoPtr_type));
      }
      [param: In] set
      {
        *(BossRewardData.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossRewardData.Data.NativeFieldInfoPtr_type)) = value;
      }
    }
  }
}
