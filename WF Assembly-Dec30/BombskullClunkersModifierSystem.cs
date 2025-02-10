// Decompiled with JetBrains decompiler
// Type: BombskullClunkersModifierSystem
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
public class BombskullClunkersModifierSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr__upgradeData;
  private static readonly IntPtr NativeFieldInfoPtr_ids;
  private static readonly IntPtr NativeMethodInfoPtr_get_upgradeData_Private_Static_get_CardUpgradeData_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CardDataCreated_Private_Void_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr_EntityCreated_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public static unsafe CardUpgradeData upgradeData
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64793, XrefRangeEnd = 64808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(BombskullClunkersModifierSystem.NativeMethodInfoPtr_get_upgradeData_Private_Static_get_CardUpgradeData_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (CardUpgradeData) null : new CardUpgradeData(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64808, XrefRangeEnd = 64823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BombskullClunkersModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64823, XrefRangeEnd = 64838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BombskullClunkersModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64838, XrefRangeEnd = 64844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CardDataCreated(CardData cardData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BombskullClunkersModifierSystem.NativeMethodInfoPtr_CardDataCreated_Private_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64844, XrefRangeEnd = 64873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityCreated(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BombskullClunkersModifierSystem.NativeMethodInfoPtr_EntityCreated_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64873, XrefRangeEnd = 64882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BombskullClunkersModifierSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BombskullClunkersModifierSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BombskullClunkersModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BombskullClunkersModifierSystem()
  {
    Il2CppClassPointerStore<BombskullClunkersModifierSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BombskullClunkersModifierSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BombskullClunkersModifierSystem>.NativeClassPtr);
    BombskullClunkersModifierSystem.NativeFieldInfoPtr__upgradeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombskullClunkersModifierSystem>.NativeClassPtr, nameof (_upgradeData));
    BombskullClunkersModifierSystem.NativeFieldInfoPtr_ids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombskullClunkersModifierSystem>.NativeClassPtr, nameof (ids));
    BombskullClunkersModifierSystem.NativeMethodInfoPtr_get_upgradeData_Private_Static_get_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombskullClunkersModifierSystem>.NativeClassPtr, 100668601);
    BombskullClunkersModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombskullClunkersModifierSystem>.NativeClassPtr, 100668602);
    BombskullClunkersModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombskullClunkersModifierSystem>.NativeClassPtr, 100668603);
    BombskullClunkersModifierSystem.NativeMethodInfoPtr_CardDataCreated_Private_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombskullClunkersModifierSystem>.NativeClassPtr, 100668604);
    BombskullClunkersModifierSystem.NativeMethodInfoPtr_EntityCreated_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombskullClunkersModifierSystem>.NativeClassPtr, 100668605);
    BombskullClunkersModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombskullClunkersModifierSystem>.NativeClassPtr, 100668606);
  }

  public BombskullClunkersModifierSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe CardUpgradeData _upgradeData
  {
    get
    {
      IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(BombskullClunkersModifierSystem.NativeFieldInfoPtr__upgradeData, (void*) &num);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (CardUpgradeData) null : new CardUpgradeData(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BombskullClunkersModifierSystem.NativeFieldInfoPtr__upgradeData, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ulong> ids
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BombskullClunkersModifierSystem.NativeFieldInfoPtr_ids));
      return pointer == IntPtr.Zero ? (List<ulong>) null : new List<ulong>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BombskullClunkersModifierSystem.NativeFieldInfoPtr_ids), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
