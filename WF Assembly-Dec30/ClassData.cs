// Decompiled with JetBrains decompiler
// Type: ClassData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class ClassData : DataFile
{
  private static readonly IntPtr NativeFieldInfoPtr_requiresUnlock;
  private static readonly IntPtr NativeFieldInfoPtr_startingInventory;
  private static readonly IntPtr NativeFieldInfoPtr_leaders;
  private static readonly IntPtr NativeFieldInfoPtr_characterPrefab;
  private static readonly IntPtr NativeFieldInfoPtr_rewardPools;
  private static readonly IntPtr NativeFieldInfoPtr_selectSfxEvent;
  private static readonly IntPtr NativeFieldInfoPtr_flag;
  private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Final_New_ClassSaveData_0;
  private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 109017, RefRangeEnd = 109019, XrefRangeStart = 109012, XrefRangeEnd = 109017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe ClassSaveData Save()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClassData.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_ClassSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (ClassSaveData) null : new ClassSaveData(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClassData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ClassData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClassData>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ClassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ClassData()
  {
    Il2CppClassPointerStore<ClassData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ClassData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClassData>.NativeClassPtr);
    ClassData.NativeFieldInfoPtr_requiresUnlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassData>.NativeClassPtr, nameof (requiresUnlock));
    ClassData.NativeFieldInfoPtr_startingInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassData>.NativeClassPtr, nameof (startingInventory));
    ClassData.NativeFieldInfoPtr_leaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassData>.NativeClassPtr, nameof (leaders));
    ClassData.NativeFieldInfoPtr_characterPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassData>.NativeClassPtr, nameof (characterPrefab));
    ClassData.NativeFieldInfoPtr_rewardPools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassData>.NativeClassPtr, nameof (rewardPools));
    ClassData.NativeFieldInfoPtr_selectSfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassData>.NativeClassPtr, nameof (selectSfxEvent));
    ClassData.NativeFieldInfoPtr_flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassData>.NativeClassPtr, nameof (flag));
    ClassData.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_ClassSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassData>.NativeClassPtr, 100673345);
    ClassData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassData>.NativeClassPtr, 100673346);
    ClassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassData>.NativeClassPtr, 100673347);
  }

  public ClassData(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe UnlockData requiresUnlock
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClassData.NativeFieldInfoPtr_requiresUnlock));
      return pointer == IntPtr.Zero ? (UnlockData) null : new UnlockData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClassData.NativeFieldInfoPtr_requiresUnlock), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Inventory startingInventory
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClassData.NativeFieldInfoPtr_startingInventory));
      return pointer == IntPtr.Zero ? (Inventory) null : new Inventory(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClassData.NativeFieldInfoPtr_startingInventory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardData> leaders
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClassData.NativeFieldInfoPtr_leaders));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<CardData>) null : new Il2CppReferenceArray<CardData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClassData.NativeFieldInfoPtr_leaders), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Character characterPrefab
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClassData.NativeFieldInfoPtr_characterPrefab));
      return pointer == IntPtr.Zero ? (Character) null : new Character(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClassData.NativeFieldInfoPtr_characterPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<RewardPool> rewardPools
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClassData.NativeFieldInfoPtr_rewardPools));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<RewardPool>) null : new Il2CppReferenceArray<RewardPool>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClassData.NativeFieldInfoPtr_rewardPools), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference selectSfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClassData.NativeFieldInfoPtr_selectSfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClassData.NativeFieldInfoPtr_selectSfxEvent)) = value;
    }
  }

  public unsafe Sprite flag
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClassData.NativeFieldInfoPtr_flag));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClassData.NativeFieldInfoPtr_flag), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
