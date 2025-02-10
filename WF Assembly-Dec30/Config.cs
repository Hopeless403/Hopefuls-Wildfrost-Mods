// Decompiled with JetBrains decompiler
// Type: Config
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class Config : MonoBehaviourSingleton<Config>
{
  private static readonly System.IntPtr NativeFieldInfoPtr_configFile;
  private static readonly System.IntPtr NativeFieldInfoPtr__data;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_data_Public_Static_get_Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public static unsafe Config.Data data
  {
    [CallerCount(8), CachedScanResults(RefRangeStart = 38164, RefRangeEnd = 38172, XrefRangeStart = 38151, XrefRangeEnd = 38164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_data_Public_Static_get_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Config.Data) null : new Config.Data(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38172, XrefRangeEnd = 38187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Config.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38187, XrefRangeEnd = 38190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Config()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Config>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Config()
  {
    Il2CppClassPointerStore<Config>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Config));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Config>.NativeClassPtr);
    Config.NativeFieldInfoPtr_configFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, nameof (configFile));
    Config.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, nameof (_data));
    Config.NativeMethodInfoPtr_get_data_Public_Static_get_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100665868);
    Config.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100665869);
    Config.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100665870);
  }

  public Config(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe TextAsset configFile
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_configFile));
      return pointer == System.IntPtr.Zero ? (TextAsset) null : new TextAsset(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_configFile), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Config.Data _data
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr__data, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Config.Data) null : new Config.Data(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr__data, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class Data : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_version;
    private static readonly System.IntPtr NativeFieldInfoPtr_versionNotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_versionFormat;
    private static readonly System.IntPtr NativeFieldInfoPtr_beta;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Data()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Config.Data>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Config.Data.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Data()
    {
      Il2CppClassPointerStore<Config.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Config>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Config.Data>.NativeClassPtr);
      Config.Data.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config.Data>.NativeClassPtr, nameof (version));
      Config.Data.NativeFieldInfoPtr_versionNotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config.Data>.NativeClassPtr, nameof (versionNotation));
      Config.Data.NativeFieldInfoPtr_versionFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config.Data>.NativeClassPtr, nameof (versionFormat));
      Config.Data.NativeFieldInfoPtr_beta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config.Data>.NativeClassPtr, nameof (beta));
      Config.Data.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config.Data>.NativeClassPtr, 100665871);
    }

    public Data(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string version
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Config.Data.NativeFieldInfoPtr_version)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Config.Data.NativeFieldInfoPtr_version), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string versionNotation
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Config.Data.NativeFieldInfoPtr_versionNotation)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Config.Data.NativeFieldInfoPtr_versionNotation), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string versionFormat
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Config.Data.NativeFieldInfoPtr_versionFormat)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Config.Data.NativeFieldInfoPtr_versionFormat), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool beta
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Config.Data.NativeFieldInfoPtr_beta));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Config.Data.NativeFieldInfoPtr_beta)) = value;
      }
    }
  }
}
