// Decompiled with JetBrains decompiler
// Type: CharacterSaveData
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
public class CharacterSaveData : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_name;
  private static readonly System.IntPtr NativeFieldInfoPtr_title;
  private static readonly System.IntPtr NativeFieldInfoPtr_team;
  private static readonly System.IntPtr NativeFieldInfoPtr_classData;
  private static readonly System.IntPtr NativeFieldInfoPtr_inventoryData;
  private static readonly System.IntPtr NativeFieldInfoPtr_handSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_redrawBell;
  private static readonly System.IntPtr NativeFieldInfoPtr_companionLimit;
  private static readonly System.IntPtr NativeFieldInfoPtr_enemyGoldFactor;
  private static readonly System.IntPtr NativeFieldInfoPtr_comboGoldFactor;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Character_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Character_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadPlayerData_Public_PlayerData_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103836, XrefRangeEnd = 103837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterSaveData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterSaveData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterSaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 103845, RefRangeEnd = 103846, XrefRangeStart = 103837, XrefRangeEnd = 103845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterSaveData(Character character)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterSaveData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) character)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterSaveData.NativeMethodInfoPtr__ctor_Public_Void_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 103870, RefRangeEnd = 103871, XrefRangeStart = 103846, XrefRangeEnd = 103870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Character Load()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterSaveData.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Character) null : new Character(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 103886, RefRangeEnd = 103887, XrefRangeStart = 103871, XrefRangeEnd = 103886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerData LoadPlayerData()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterSaveData.NativeMethodInfoPtr_LoadPlayerData_Public_PlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (PlayerData) null : new PlayerData(pointer);
  }

  static CharacterSaveData()
  {
    Il2CppClassPointerStore<CharacterSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CharacterSaveData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterSaveData>.NativeClassPtr);
    CharacterSaveData.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSaveData>.NativeClassPtr, nameof (name));
    CharacterSaveData.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSaveData>.NativeClassPtr, nameof (title));
    CharacterSaveData.NativeFieldInfoPtr_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSaveData>.NativeClassPtr, nameof (team));
    CharacterSaveData.NativeFieldInfoPtr_classData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSaveData>.NativeClassPtr, nameof (classData));
    CharacterSaveData.NativeFieldInfoPtr_inventoryData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSaveData>.NativeClassPtr, nameof (inventoryData));
    CharacterSaveData.NativeFieldInfoPtr_handSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSaveData>.NativeClassPtr, nameof (handSize));
    CharacterSaveData.NativeFieldInfoPtr_redrawBell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSaveData>.NativeClassPtr, nameof (redrawBell));
    CharacterSaveData.NativeFieldInfoPtr_companionLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSaveData>.NativeClassPtr, nameof (companionLimit));
    CharacterSaveData.NativeFieldInfoPtr_enemyGoldFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSaveData>.NativeClassPtr, nameof (enemyGoldFactor));
    CharacterSaveData.NativeFieldInfoPtr_comboGoldFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSaveData>.NativeClassPtr, nameof (comboGoldFactor));
    CharacterSaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSaveData>.NativeClassPtr, 100672665);
    CharacterSaveData.NativeMethodInfoPtr__ctor_Public_Void_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSaveData>.NativeClassPtr, 100672666);
    CharacterSaveData.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSaveData>.NativeClassPtr, 100672667);
    CharacterSaveData.NativeMethodInfoPtr_LoadPlayerData_Public_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSaveData>.NativeClassPtr, 100672668);
  }

  public CharacterSaveData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string name
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSaveData.NativeFieldInfoPtr_name)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterSaveData.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string title
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSaveData.NativeFieldInfoPtr_title)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterSaveData.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int team
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSaveData.NativeFieldInfoPtr_team));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSaveData.NativeFieldInfoPtr_team)) = value;
    }
  }

  public unsafe ClassSaveData classData
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSaveData.NativeFieldInfoPtr_classData));
      return pointer == System.IntPtr.Zero ? (ClassSaveData) null : new ClassSaveData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterSaveData.NativeFieldInfoPtr_classData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe InventorySaveData inventoryData
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSaveData.NativeFieldInfoPtr_inventoryData));
      return pointer == System.IntPtr.Zero ? (InventorySaveData) null : new InventorySaveData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterSaveData.NativeFieldInfoPtr_inventoryData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int handSize
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSaveData.NativeFieldInfoPtr_handSize));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSaveData.NativeFieldInfoPtr_handSize)) = value;
    }
  }

  public unsafe int redrawBell
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSaveData.NativeFieldInfoPtr_redrawBell));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSaveData.NativeFieldInfoPtr_redrawBell)) = value;
    }
  }

  public unsafe int companionLimit
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSaveData.NativeFieldInfoPtr_companionLimit));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSaveData.NativeFieldInfoPtr_companionLimit)) = value;
    }
  }

  public unsafe float enemyGoldFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSaveData.NativeFieldInfoPtr_enemyGoldFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSaveData.NativeFieldInfoPtr_enemyGoldFactor)) = value;
    }
  }

  public unsafe float comboGoldFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSaveData.NativeFieldInfoPtr_comboGoldFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSaveData.NativeFieldInfoPtr_comboGoldFactor)) = value;
    }
  }
}
