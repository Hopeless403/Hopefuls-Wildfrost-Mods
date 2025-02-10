// Decompiled with JetBrains decompiler
// Type: InventorySaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
[Serializable]
public class InventorySaveData : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_deck;
  private static readonly System.IntPtr NativeFieldInfoPtr_reserve;
  private static readonly System.IntPtr NativeFieldInfoPtr_upgrades;
  private static readonly System.IntPtr NativeFieldInfoPtr_gold;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_CardSaveData_Il2CppReferenceArray_1_CardSaveData_Il2CppReferenceArray_1_CardUpgradeSaveData_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Inventory_0;

  [CallerCount(1959)]
  [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InventorySaveData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventorySaveData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InventorySaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 103899, RefRangeEnd = 103901, XrefRangeStart = 103895, XrefRangeEnd = 103899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InventorySaveData(
    Il2CppReferenceArray<CardSaveData> deck,
    Il2CppReferenceArray<CardSaveData> reserve,
    Il2CppReferenceArray<CardUpgradeSaveData> upgrades,
    int gold)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventorySaveData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) deck);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) reserve);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgrades);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &gold;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InventorySaveData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_CardSaveData_Il2CppReferenceArray_1_CardSaveData_Il2CppReferenceArray_1_CardUpgradeSaveData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 103928, RefRangeEnd = 103930, XrefRangeStart = 103901, XrefRangeEnd = 103928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Inventory Load()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventorySaveData.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Inventory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Inventory) null : new Inventory(pointer);
  }

  static InventorySaveData()
  {
    Il2CppClassPointerStore<InventorySaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (InventorySaveData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventorySaveData>.NativeClassPtr);
    InventorySaveData.NativeFieldInfoPtr_deck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySaveData>.NativeClassPtr, nameof (deck));
    InventorySaveData.NativeFieldInfoPtr_reserve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySaveData>.NativeClassPtr, nameof (reserve));
    InventorySaveData.NativeFieldInfoPtr_upgrades = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySaveData>.NativeClassPtr, nameof (upgrades));
    InventorySaveData.NativeFieldInfoPtr_gold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySaveData>.NativeClassPtr, nameof (gold));
    InventorySaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySaveData>.NativeClassPtr, 100672673);
    InventorySaveData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_CardSaveData_Il2CppReferenceArray_1_CardSaveData_Il2CppReferenceArray_1_CardUpgradeSaveData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySaveData>.NativeClassPtr, 100672674);
    InventorySaveData.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Inventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySaveData>.NativeClassPtr, 100672675);
  }

  public InventorySaveData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<CardSaveData> deck
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySaveData.NativeFieldInfoPtr_deck));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardSaveData>) null : new Il2CppReferenceArray<CardSaveData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySaveData.NativeFieldInfoPtr_deck), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardSaveData> reserve
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySaveData.NativeFieldInfoPtr_reserve));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardSaveData>) null : new Il2CppReferenceArray<CardSaveData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySaveData.NativeFieldInfoPtr_reserve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardUpgradeSaveData> upgrades
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySaveData.NativeFieldInfoPtr_upgrades));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardUpgradeSaveData>) null : new Il2CppReferenceArray<CardUpgradeSaveData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventorySaveData.NativeFieldInfoPtr_upgrades), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int gold
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySaveData.NativeFieldInfoPtr_gold));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventorySaveData.NativeFieldInfoPtr_gold)) = value;
    }
  }
}
