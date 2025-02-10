// Decompiled with JetBrains decompiler
// Type: BattleEntity
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Localization;

#nullable disable
[Serializable]
public sealed class BattleEntity : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_titleKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_forceTitle;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardType;
  private static readonly System.IntPtr NativeFieldInfoPtr_friendly;

  static BattleEntity()
  {
    Il2CppClassPointerStore<BattleEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BattleEntity));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleEntity>.NativeClassPtr);
    BattleEntity.NativeFieldInfoPtr_titleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleEntity>.NativeClassPtr, nameof (titleKey));
    BattleEntity.NativeFieldInfoPtr_forceTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleEntity>.NativeClassPtr, nameof (forceTitle));
    BattleEntity.NativeFieldInfoPtr_cardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleEntity>.NativeClassPtr, nameof (cardType));
    BattleEntity.NativeFieldInfoPtr_friendly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleEntity>.NativeClassPtr, nameof (friendly));
  }

  public BattleEntity(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public BattleEntity()
  {
    // ISSUE: cast to a reference type
    // ISSUE: untyped stack allocation
    System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BattleEntity>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    // ISSUE: explicit constructor call
    base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BattleEntity>.NativeClassPtr, data));
  }

  public unsafe LocalizedString titleKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntity.NativeFieldInfoPtr_titleKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleEntity.NativeFieldInfoPtr_titleKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string forceTitle
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntity.NativeFieldInfoPtr_forceTitle)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleEntity.NativeFieldInfoPtr_forceTitle), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string cardType
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntity.NativeFieldInfoPtr_cardType)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleEntity.NativeFieldInfoPtr_cardType), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool friendly
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntity.NativeFieldInfoPtr_friendly));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleEntity.NativeFieldInfoPtr_friendly)) = value;
    }
  }
}
