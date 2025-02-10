// Decompiled with JetBrains decompiler
// Type: BoostEnemyDamageModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class BoostEnemyDamageModifierSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_attackAdd;
  private static readonly IntPtr NativeFieldInfoPtr_healthAdd;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CardDataCreated_Private_Static_Void_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65119, XrefRangeEnd = 65127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostEnemyDamageModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65127, XrefRangeEnd = 65135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostEnemyDamageModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65135, XrefRangeEnd = 65148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CardDataCreated(CardData cardData)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostEnemyDamageModifierSystem.NativeMethodInfoPtr_CardDataCreated_Private_Static_Void_CardData_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BoostEnemyDamageModifierSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoostEnemyDamageModifierSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostEnemyDamageModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BoostEnemyDamageModifierSystem()
  {
    Il2CppClassPointerStore<BoostEnemyDamageModifierSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BoostEnemyDamageModifierSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoostEnemyDamageModifierSystem>.NativeClassPtr);
    BoostEnemyDamageModifierSystem.NativeFieldInfoPtr_attackAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoostEnemyDamageModifierSystem>.NativeClassPtr, nameof (attackAdd));
    BoostEnemyDamageModifierSystem.NativeFieldInfoPtr_healthAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoostEnemyDamageModifierSystem>.NativeClassPtr, nameof (healthAdd));
    BoostEnemyDamageModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostEnemyDamageModifierSystem>.NativeClassPtr, 100668632);
    BoostEnemyDamageModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostEnemyDamageModifierSystem>.NativeClassPtr, 100668633);
    BoostEnemyDamageModifierSystem.NativeMethodInfoPtr_CardDataCreated_Private_Static_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostEnemyDamageModifierSystem>.NativeClassPtr, 100668634);
    BoostEnemyDamageModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostEnemyDamageModifierSystem>.NativeClassPtr, 100668635);
  }

  public BoostEnemyDamageModifierSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe int attackAdd
  {
    get
    {
      int attackAdd;
      IL2CPP.il2cpp_field_static_get_value(BoostEnemyDamageModifierSystem.NativeFieldInfoPtr_attackAdd, (void*) &attackAdd);
      return attackAdd;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BoostEnemyDamageModifierSystem.NativeFieldInfoPtr_attackAdd, (void*) &value);
    }
  }

  public static unsafe int healthAdd
  {
    get
    {
      int healthAdd;
      IL2CPP.il2cpp_field_static_get_value(BoostEnemyDamageModifierSystem.NativeFieldInfoPtr_healthAdd, (void*) &healthAdd);
      return healthAdd;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BoostEnemyDamageModifierSystem.NativeFieldInfoPtr_healthAdd, (void*) &value);
    }
  }
}
