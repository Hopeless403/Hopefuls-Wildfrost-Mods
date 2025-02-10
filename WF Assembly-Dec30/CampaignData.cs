// Decompiled with JetBrains decompiler
// Type: CampaignData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
[Serializable]
public class CampaignData : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr__GameMode_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Modifiers_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__GameVersion_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Seed_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_GameMode_Public_get_GameMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_GameMode_Public_set_Void_GameMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Modifiers_Public_get_List_1_GameModifierData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Modifiers_Public_set_Void_List_1_GameModifierData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_GameVersion_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_GameVersion_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Seed_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Seed_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameMode_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_CampaignData_GameMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Private_Void_GameMode_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

  public unsafe GameMode GameMode
  {
    [CallerCount(10), CachedScanResults(RefRangeStart = 20094, RefRangeEnd = 20104, XrefRangeStart = 20094, XrefRangeEnd = 20104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignData.NativeMethodInfoPtr_get_GameMode_Public_get_GameMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (GameMode) null : new GameMode(pointer);
    }
    [CallerCount(21), CachedScanResults(RefRangeStart = 20073, RefRangeEnd = 20094, XrefRangeStart = 20073, XrefRangeEnd = 20094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignData.NativeMethodInfoPtr_set_GameMode_Public_set_Void_GameMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe List<GameModifierData> Modifiers
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignData.NativeMethodInfoPtr_get_Modifiers_Public_get_List_1_GameModifierData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<GameModifierData>) null : new List<GameModifierData>(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignData.NativeMethodInfoPtr_set_Modifiers_Public_set_Void_List_1_GameModifierData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe string GameVersion
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CampaignData.NativeMethodInfoPtr_get_GameVersion_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 54210, RefRangeEnd = 54212, XrefRangeStart = 54210, XrefRangeEnd = 54212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignData.NativeMethodInfoPtr_set_GameVersion_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe int Seed
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignData.NativeMethodInfoPtr_get_Seed_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 51140, RefRangeEnd = 51142, XrefRangeStart = 51140, XrefRangeEnd = 51142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignData.NativeMethodInfoPtr_set_Seed_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101962, XrefRangeEnd = 101963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CampaignData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101963, XrefRangeEnd = 101982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CampaignData(string gameModeName, int seed = -1)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(gameModeName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &seed;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 101984, RefRangeEnd = 101988, XrefRangeStart = 101982, XrefRangeEnd = 101984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CampaignData(GameMode gameMode, int seed = -1)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameMode);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &seed;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignData.NativeMethodInfoPtr__ctor_Public_Void_GameMode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101988, XrefRangeEnd = 102011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe CampaignData Load(GameMode gameMode)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameMode)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignData.NativeMethodInfoPtr_Load_Public_Static_CampaignData_GameMode_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CampaignData) null : new CampaignData(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 102039, RefRangeEnd = 102041, XrefRangeStart = 102011, XrefRangeEnd = 102039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init(GameMode gameMode, int seed = -1)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameMode);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &seed;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignData.NativeMethodInfoPtr_Init_Private_Void_GameMode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102041, XrefRangeEnd = 102048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CampaignData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  static CampaignData()
  {
    Il2CppClassPointerStore<CampaignData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CampaignData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignData>.NativeClassPtr);
    CampaignData.NativeFieldInfoPtr__GameMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignData>.NativeClassPtr, "<GameMode>k__BackingField");
    CampaignData.NativeFieldInfoPtr__Modifiers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignData>.NativeClassPtr, "<Modifiers>k__BackingField");
    CampaignData.NativeFieldInfoPtr__GameVersion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignData>.NativeClassPtr, "<GameVersion>k__BackingField");
    CampaignData.NativeFieldInfoPtr__Seed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignData>.NativeClassPtr, "<Seed>k__BackingField");
    CampaignData.NativeMethodInfoPtr_get_GameMode_Public_get_GameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignData>.NativeClassPtr, 100672455);
    CampaignData.NativeMethodInfoPtr_set_GameMode_Public_set_Void_GameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignData>.NativeClassPtr, 100672456);
    CampaignData.NativeMethodInfoPtr_get_Modifiers_Public_get_List_1_GameModifierData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignData>.NativeClassPtr, 100672457);
    CampaignData.NativeMethodInfoPtr_set_Modifiers_Public_set_Void_List_1_GameModifierData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignData>.NativeClassPtr, 100672458);
    CampaignData.NativeMethodInfoPtr_get_GameVersion_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignData>.NativeClassPtr, 100672459);
    CampaignData.NativeMethodInfoPtr_set_GameVersion_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignData>.NativeClassPtr, 100672460);
    CampaignData.NativeMethodInfoPtr_get_Seed_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignData>.NativeClassPtr, 100672461);
    CampaignData.NativeMethodInfoPtr_set_Seed_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignData>.NativeClassPtr, 100672462);
    CampaignData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignData>.NativeClassPtr, 100672463);
    CampaignData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignData>.NativeClassPtr, 100672464);
    CampaignData.NativeMethodInfoPtr__ctor_Public_Void_GameMode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignData>.NativeClassPtr, 100672465);
    CampaignData.NativeMethodInfoPtr_Load_Public_Static_CampaignData_GameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignData>.NativeClassPtr, 100672466);
    CampaignData.NativeMethodInfoPtr_Init_Private_Void_GameMode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignData>.NativeClassPtr, 100672467);
    CampaignData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignData>.NativeClassPtr, 100672468);
  }

  public CampaignData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe GameMode _GameMode_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignData.NativeFieldInfoPtr__GameMode_k__BackingField));
      return pointer == System.IntPtr.Zero ? (GameMode) null : new GameMode(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignData.NativeFieldInfoPtr__GameMode_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameModifierData> _Modifiers_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignData.NativeFieldInfoPtr__Modifiers_k__BackingField));
      return pointer == System.IntPtr.Zero ? (List<GameModifierData>) null : new List<GameModifierData>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignData.NativeFieldInfoPtr__Modifiers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string _GameVersion_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignData.NativeFieldInfoPtr__GameVersion_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignData.NativeFieldInfoPtr__GameVersion_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int _Seed_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignData.NativeFieldInfoPtr__Seed_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignData.NativeFieldInfoPtr__Seed_k__BackingField)) = value;
    }
  }
}
