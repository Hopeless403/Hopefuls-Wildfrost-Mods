// Decompiled with JetBrains decompiler
// Type: Inventory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Dead;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class Inventory : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_deck;
  private static readonly IntPtr NativeFieldInfoPtr_reserve;
  private static readonly IntPtr NativeFieldInfoPtr_upgrades;
  private static readonly IntPtr NativeFieldInfoPtr_gold;
  private static readonly IntPtr NativeFieldInfoPtr_goldOwed;
  private static readonly IntPtr NativeMethodInfoPtr_AddGold_Public_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Inventory_0;
  private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Final_New_InventorySaveData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 109586, RefRangeEnd = 109587, XrefRangeStart = 109585, XrefRangeEnd = 109586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddGold(int amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &amount
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Inventory.NativeMethodInfoPtr_AddGold_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 109648, RefRangeEnd = 109649, XrefRangeStart = 109587, XrefRangeEnd = 109648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Inventory Clone()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(Inventory.NativeMethodInfoPtr_Clone_Public_Inventory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (Inventory) null : new Inventory(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 109662, RefRangeEnd = 109664, XrefRangeStart = 109649, XrefRangeEnd = 109662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe InventorySaveData Save()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(Inventory.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_InventorySaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (InventorySaveData) null : new InventorySaveData(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109664, XrefRangeEnd = 109682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Inventory()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Inventory>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Inventory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Inventory()
  {
    Il2CppClassPointerStore<Inventory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Inventory));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Inventory>.NativeClassPtr);
    Inventory.NativeFieldInfoPtr_deck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inventory>.NativeClassPtr, nameof (deck));
    Inventory.NativeFieldInfoPtr_reserve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inventory>.NativeClassPtr, nameof (reserve));
    Inventory.NativeFieldInfoPtr_upgrades = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inventory>.NativeClassPtr, nameof (upgrades));
    Inventory.NativeFieldInfoPtr_gold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inventory>.NativeClassPtr, nameof (gold));
    Inventory.NativeFieldInfoPtr_goldOwed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inventory>.NativeClassPtr, nameof (goldOwed));
    Inventory.NativeMethodInfoPtr_AddGold_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100673410);
    Inventory.NativeMethodInfoPtr_Clone_Public_Inventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100673411);
    Inventory.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_InventorySaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100673412);
    Inventory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100673413);
  }

  public Inventory(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe CardDataList deck
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_deck));
      return pointer == IntPtr.Zero ? (CardDataList) null : new CardDataList(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_deck), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardDataList reserve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_reserve));
      return pointer == IntPtr.Zero ? (CardDataList) null : new CardDataList(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_reserve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<CardUpgradeData> upgrades
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_upgrades));
      return pointer == IntPtr.Zero ? (List<CardUpgradeData>) null : new List<CardUpgradeData>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_upgrades), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SafeInt gold
  {
    get
    {
      return *(SafeInt*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_gold));
    }
    [param: In] set
    {
      *(SafeInt*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_gold)) = value;
    }
  }

  public unsafe int goldOwed
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_goldOwed));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_goldOwed)) = value;
    }
  }
}
