// Decompiled with JetBrains decompiler
// Type: PlayerData
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
public class PlayerData : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_classData;
  private static readonly System.IntPtr NativeFieldInfoPtr_handSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_redrawBell;
  private static readonly System.IntPtr NativeFieldInfoPtr_companionLimit;
  private static readonly System.IntPtr NativeFieldInfoPtr_enemyGoldFactor;
  private static readonly System.IntPtr NativeFieldInfoPtr_comboGoldFactor;
  private static readonly System.IntPtr NativeFieldInfoPtr_inventory;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ClassData_Inventory_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 103388, RefRangeEnd = 103389, XrefRangeStart = 103385, XrefRangeEnd = 103388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerData(ClassData classData, Inventory inventory)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) classData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inventory);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PlayerData.NativeMethodInfoPtr__ctor_Public_Void_ClassData_Inventory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static PlayerData()
  {
    Il2CppClassPointerStore<PlayerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (PlayerData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerData>.NativeClassPtr);
    PlayerData.NativeFieldInfoPtr_classData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, nameof (classData));
    PlayerData.NativeFieldInfoPtr_handSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, nameof (handSize));
    PlayerData.NativeFieldInfoPtr_redrawBell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, nameof (redrawBell));
    PlayerData.NativeFieldInfoPtr_companionLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, nameof (companionLimit));
    PlayerData.NativeFieldInfoPtr_enemyGoldFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, nameof (enemyGoldFactor));
    PlayerData.NativeFieldInfoPtr_comboGoldFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, nameof (comboGoldFactor));
    PlayerData.NativeFieldInfoPtr_inventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, nameof (inventory));
    PlayerData.NativeMethodInfoPtr__ctor_Public_Void_ClassData_Inventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, 100672611);
  }

  public PlayerData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe ClassData classData
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_classData));
      return pointer == System.IntPtr.Zero ? (ClassData) null : new ClassData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_classData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int handSize
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_handSize));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_handSize)) = value;
    }
  }

  public unsafe int redrawBell
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_redrawBell));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_redrawBell)) = value;
    }
  }

  public unsafe int companionLimit
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_companionLimit));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_companionLimit)) = value;
    }
  }

  public unsafe float enemyGoldFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_enemyGoldFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_enemyGoldFactor)) = value;
    }
  }

  public unsafe float comboGoldFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_comboGoldFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_comboGoldFactor)) = value;
    }
  }

  public unsafe Inventory inventory
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_inventory));
      return pointer == System.IntPtr.Zero ? (Inventory) null : new Inventory(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_inventory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
