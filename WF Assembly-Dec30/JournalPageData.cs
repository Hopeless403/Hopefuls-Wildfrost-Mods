// Decompiled with JetBrains decompiler
// Type: JournalPageData
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
using UnityEngine.AddressableAssets;

#nullable disable
public class JournalPageData : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_unlock;
  private static readonly IntPtr NativeFieldInfoPtr_unlockOnMap;
  private static readonly IntPtr NativeFieldInfoPtr_mapTierIndex;
  private static readonly IntPtr NativeFieldInfoPtr_mapAfterLetter;
  private static readonly IntPtr NativeFieldInfoPtr_mapNodeType;
  private static readonly IntPtr NativeFieldInfoPtr_prefabRef;
  private static readonly IntPtr NativeFieldInfoPtr_legalGameModes;
  private static readonly IntPtr NativeFieldInfoPtr_legalTribes;
  private static readonly IntPtr NativeFieldInfoPtr_requiresModifiers;
  private static readonly IntPtr NativeFieldInfoPtr_requiresStormPoints;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JournalPageData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalPageData>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalPageData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static JournalPageData()
  {
    Il2CppClassPointerStore<JournalPageData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (JournalPageData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalPageData>.NativeClassPtr);
    JournalPageData.NativeFieldInfoPtr_unlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalPageData>.NativeClassPtr, nameof (unlock));
    JournalPageData.NativeFieldInfoPtr_unlockOnMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalPageData>.NativeClassPtr, nameof (unlockOnMap));
    JournalPageData.NativeFieldInfoPtr_mapTierIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalPageData>.NativeClassPtr, nameof (mapTierIndex));
    JournalPageData.NativeFieldInfoPtr_mapAfterLetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalPageData>.NativeClassPtr, nameof (mapAfterLetter));
    JournalPageData.NativeFieldInfoPtr_mapNodeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalPageData>.NativeClassPtr, nameof (mapNodeType));
    JournalPageData.NativeFieldInfoPtr_prefabRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalPageData>.NativeClassPtr, nameof (prefabRef));
    JournalPageData.NativeFieldInfoPtr_legalGameModes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalPageData>.NativeClassPtr, nameof (legalGameModes));
    JournalPageData.NativeFieldInfoPtr_legalTribes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalPageData>.NativeClassPtr, nameof (legalTribes));
    JournalPageData.NativeFieldInfoPtr_requiresModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalPageData>.NativeClassPtr, nameof (requiresModifiers));
    JournalPageData.NativeFieldInfoPtr_requiresStormPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalPageData>.NativeClassPtr, nameof (requiresStormPoints));
    JournalPageData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalPageData>.NativeClassPtr, 100673414);
  }

  public JournalPageData(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe UnlockData unlock
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalPageData.NativeFieldInfoPtr_unlock));
      return pointer == IntPtr.Zero ? (UnlockData) null : new UnlockData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalPageData.NativeFieldInfoPtr_unlock), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool unlockOnMap
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalPageData.NativeFieldInfoPtr_unlockOnMap));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalPageData.NativeFieldInfoPtr_unlockOnMap)) = value;
    }
  }

  public unsafe char mapTierIndex
  {
    get
    {
      return *(char*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalPageData.NativeFieldInfoPtr_mapTierIndex));
    }
    [param: In] set
    {
      *(char*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalPageData.NativeFieldInfoPtr_mapTierIndex)) = value;
    }
  }

  public unsafe char mapAfterLetter
  {
    get
    {
      return *(char*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalPageData.NativeFieldInfoPtr_mapAfterLetter));
    }
    [param: In] set
    {
      *(char*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalPageData.NativeFieldInfoPtr_mapAfterLetter)) = value;
    }
  }

  public unsafe CampaignNodeType mapNodeType
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalPageData.NativeFieldInfoPtr_mapNodeType));
      return pointer == IntPtr.Zero ? (CampaignNodeType) null : new CampaignNodeType(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalPageData.NativeFieldInfoPtr_mapNodeType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AssetReferenceGameObject prefabRef
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalPageData.NativeFieldInfoPtr_prefabRef));
      return pointer == IntPtr.Zero ? (AssetReferenceGameObject) null : new AssetReferenceGameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalPageData.NativeFieldInfoPtr_prefabRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<GameMode> legalGameModes
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalPageData.NativeFieldInfoPtr_legalGameModes));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<GameMode>) null : new Il2CppReferenceArray<GameMode>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalPageData.NativeFieldInfoPtr_legalGameModes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ClassData> legalTribes
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalPageData.NativeFieldInfoPtr_legalTribes));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<ClassData>) null : new Il2CppReferenceArray<ClassData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalPageData.NativeFieldInfoPtr_legalTribes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<GameModifierData> requiresModifiers
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalPageData.NativeFieldInfoPtr_requiresModifiers));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<GameModifierData>) null : new Il2CppReferenceArray<GameModifierData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalPageData.NativeFieldInfoPtr_requiresModifiers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int requiresStormPoints
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalPageData.NativeFieldInfoPtr_requiresStormPoints));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalPageData.NativeFieldInfoPtr_requiresStormPoints)) = value;
    }
  }
}
