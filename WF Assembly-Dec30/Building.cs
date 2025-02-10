// Decompiled with JetBrains decompiler
// Type: Building
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class Building : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_type;
  private static readonly System.IntPtr NativeFieldInfoPtr_canSelect;
  private static readonly System.IntPtr NativeFieldInfoPtr_onSelect;
  private static readonly System.IntPtr NativeFieldInfoPtr_toBuild;
  private static readonly System.IntPtr NativeFieldInfoPtr_underConstruction;
  private static readonly System.IntPtr NativeFieldInfoPtr_fullyBuilt;
  private static readonly System.IntPtr NativeFieldInfoPtr_icons;
  private static readonly System.IntPtr NativeFieldInfoPtr_onDataUpdated;
  private static readonly System.IntPtr NativeFieldInfoPtr_buildStarted;
  private static readonly System.IntPtr NativeFieldInfoPtr_built;
  private static readonly System.IntPtr NativeFieldInfoPtr_unlocks;
  private static readonly System.IntPtr NativeFieldInfoPtr_uncheckedUnlocks;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentActiveIcon;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_checkedUnlocks_Public_get_List_1_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasUncheckedUnlocks_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckIfUnlocked_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunUpdateEvent_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Select_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSprite_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSuitableIcon_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetIcon_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Bloop_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateDisplay_Public_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe List<string> checkedUnlocks
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 84895, RefRangeEnd = 84898, XrefRangeStart = 84889, XrefRangeEnd = 84895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Building.NativeMethodInfoPtr_get_checkedUnlocks_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
    }
  }

  public unsafe bool HasUncheckedUnlocks
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84898, XrefRangeEnd = 84899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Building.NativeMethodInfoPtr_get_HasUncheckedUnlocks_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 84923, RefRangeEnd = 84925, XrefRangeStart = 84899, XrefRangeEnd = 84923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckIfUnlocked()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Building.NativeMethodInfoPtr_CheckIfUnlocked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 85010, RefRangeEnd = 85012, XrefRangeStart = 84925, XrefRangeEnd = 85010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RunUpdateEvent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Building.NativeMethodInfoPtr_RunUpdateEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 85020, RefRangeEnd = 85021, XrefRangeStart = 85012, XrefRangeEnd = 85020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Select()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Building.NativeMethodInfoPtr_Select_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85021, XrefRangeEnd = 85038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateSprite()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Building.NativeMethodInfoPtr_UpdateSprite_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 85047, RefRangeEnd = 85049, XrefRangeStart = 85038, XrefRangeEnd = 85047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSuitableIcon()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Building.NativeMethodInfoPtr_SetSuitableIcon_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 85071, RefRangeEnd = 85073, XrefRangeStart = 85049, XrefRangeEnd = 85071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetIcon(string name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Building.NativeMethodInfoPtr_SetIcon_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85073, XrefRangeEnd = 85086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Bloop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Building.NativeMethodInfoPtr_Bloop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85086, XrefRangeEnd = 85093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateDisplay(GameObject prefab)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Building.NativeMethodInfoPtr_CreateDisplay_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Building()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Building>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Building.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Building()
  {
    Il2CppClassPointerStore<Building>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Building));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Building>.NativeClassPtr);
    Building.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Building>.NativeClassPtr, nameof (type));
    Building.NativeFieldInfoPtr_canSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Building>.NativeClassPtr, nameof (canSelect));
    Building.NativeFieldInfoPtr_onSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Building>.NativeClassPtr, nameof (onSelect));
    Building.NativeFieldInfoPtr_toBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Building>.NativeClassPtr, nameof (toBuild));
    Building.NativeFieldInfoPtr_underConstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Building>.NativeClassPtr, nameof (underConstruction));
    Building.NativeFieldInfoPtr_fullyBuilt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Building>.NativeClassPtr, nameof (fullyBuilt));
    Building.NativeFieldInfoPtr_icons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Building>.NativeClassPtr, nameof (icons));
    Building.NativeFieldInfoPtr_onDataUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Building>.NativeClassPtr, nameof (onDataUpdated));
    Building.NativeFieldInfoPtr_buildStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Building>.NativeClassPtr, nameof (buildStarted));
    Building.NativeFieldInfoPtr_built = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Building>.NativeClassPtr, nameof (built));
    Building.NativeFieldInfoPtr_unlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Building>.NativeClassPtr, nameof (unlocks));
    Building.NativeFieldInfoPtr_uncheckedUnlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Building>.NativeClassPtr, nameof (uncheckedUnlocks));
    Building.NativeFieldInfoPtr_currentActiveIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Building>.NativeClassPtr, nameof (currentActiveIcon));
    Building.NativeMethodInfoPtr_get_checkedUnlocks_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Building>.NativeClassPtr, 100670382);
    Building.NativeMethodInfoPtr_get_HasUncheckedUnlocks_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Building>.NativeClassPtr, 100670383);
    Building.NativeMethodInfoPtr_CheckIfUnlocked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Building>.NativeClassPtr, 100670384);
    Building.NativeMethodInfoPtr_RunUpdateEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Building>.NativeClassPtr, 100670385);
    Building.NativeMethodInfoPtr_Select_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Building>.NativeClassPtr, 100670386);
    Building.NativeMethodInfoPtr_UpdateSprite_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Building>.NativeClassPtr, 100670387);
    Building.NativeMethodInfoPtr_SetSuitableIcon_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Building>.NativeClassPtr, 100670388);
    Building.NativeMethodInfoPtr_SetIcon_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Building>.NativeClassPtr, 100670389);
    Building.NativeMethodInfoPtr_Bloop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Building>.NativeClassPtr, 100670390);
    Building.NativeMethodInfoPtr_CreateDisplay_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Building>.NativeClassPtr, 100670391);
    Building.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Building>.NativeClassPtr, 100670392);
  }

  public Building(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe BuildingType type
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_type));
      return pointer == System.IntPtr.Zero ? (BuildingType) null : new BuildingType(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool canSelect
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_canSelect));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_canSelect)) = value;
    }
  }

  public unsafe UnityEventGameObject onSelect
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_onSelect));
      return pointer == System.IntPtr.Zero ? (UnityEventGameObject) null : new UnityEventGameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_onSelect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject toBuild
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_toBuild));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_toBuild), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject underConstruction
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_underConstruction));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_underConstruction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject fullyBuilt
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_fullyBuilt));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_fullyBuilt), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Building.Icon> icons
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_icons));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Building.Icon>) null : new Il2CppReferenceArray<Building.Icon>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_icons), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent onDataUpdated
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_onDataUpdated));
      return pointer == System.IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_onDataUpdated), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool buildStarted
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_buildStarted));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_buildStarted)) = value;
    }
  }

  public unsafe bool built
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_built));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_built)) = value;
    }
  }

  public unsafe List<string> unlocks
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_unlocks));
      return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_unlocks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<string> uncheckedUnlocks
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_uncheckedUnlocks));
      return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_uncheckedUnlocks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject currentActiveIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_currentActiveIcon));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Building.NativeFieldInfoPtr_currentActiveIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class Icon : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_obj;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Icon()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Building.Icon>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Building.Icon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Icon()
    {
      Il2CppClassPointerStore<Building.Icon>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Building>.NativeClassPtr, nameof (Icon));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Building.Icon>.NativeClassPtr);
      Building.Icon.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Building.Icon>.NativeClassPtr, nameof (name));
      Building.Icon.NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Building.Icon>.NativeClassPtr, nameof (obj));
      Building.Icon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Building.Icon>.NativeClassPtr, 100670393);
    }

    public Icon(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Building.Icon.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Building.Icon.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe GameObject obj
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Building.Icon.NativeFieldInfoPtr_obj));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Building.Icon.NativeFieldInfoPtr_obj), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Building/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__18_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__RunUpdateEvent_b__18_0_Internal_String_UnlockData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Building.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Building.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _RunUpdateEvent_b__18_0(UnlockData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Building.__c.NativeMethodInfoPtr__RunUpdateEvent_b__18_0_Internal_String_UnlockData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static __c()
    {
      Il2CppClassPointerStore<Building.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Building>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Building.__c>.NativeClassPtr);
      Building.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Building.__c>.NativeClassPtr, "<>9");
      Building.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Building.__c>.NativeClassPtr, "<>9__18_0");
      Building.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Building.__c>.NativeClassPtr, 100670395);
      Building.__c.NativeMethodInfoPtr__RunUpdateEvent_b__18_0_Internal_String_UnlockData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Building.__c>.NativeClassPtr, 100670396);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Building.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Building.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Building.__c) null : new Building.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Building.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<UnlockData, string> __9__18_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Building.__c.NativeFieldInfoPtr___9__18_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<UnlockData, string>) null : new Il2CppSystem.Func<UnlockData, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Building.__c.NativeFieldInfoPtr___9__18_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Building/<>c__DisplayClass22_0")]
  public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetIcon_b__0_Internal_Boolean_Icon_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass22_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Building.__c__DisplayClass22_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Building.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _SetIcon_b__0(Building.Icon a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Building.__c__DisplayClass22_0.NativeMethodInfoPtr__SetIcon_b__0_Internal_Boolean_Icon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass22_0()
    {
      Il2CppClassPointerStore<Building.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Building>.NativeClassPtr, "<>c__DisplayClass22_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Building.__c__DisplayClass22_0>.NativeClassPtr);
      Building.__c__DisplayClass22_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Building.__c__DisplayClass22_0>.NativeClassPtr, nameof (name));
      Building.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Building.__c__DisplayClass22_0>.NativeClassPtr, 100670397);
      Building.__c__DisplayClass22_0.NativeMethodInfoPtr__SetIcon_b__0_Internal_Boolean_Icon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Building.__c__DisplayClass22_0>.NativeClassPtr, 100670398);
    }

    public __c__DisplayClass22_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Building.__c__DisplayClass22_0.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Building.__c__DisplayClass22_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
