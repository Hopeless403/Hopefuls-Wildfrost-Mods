// Decompiled with JetBrains decompiler
// Type: BoostArea2EnemyDamageModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class BoostArea2EnemyDamageModifierSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_area;
  private static readonly IntPtr NativeFieldInfoPtr_damageAdd;
  private static readonly IntPtr NativeFieldInfoPtr_correctArea;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_PreBattleSetUp_Private_Void_CampaignNode_0;
  private static readonly IntPtr NativeMethodInfoPtr_PostBattleSetUp_Private_Void_CampaignNode_0;
  private static readonly IntPtr NativeMethodInfoPtr_CardDataCreated_Private_Void_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65015, XrefRangeEnd = 65029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostArea2EnemyDamageModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65029, XrefRangeEnd = 65043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostArea2EnemyDamageModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65043, XrefRangeEnd = 65050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PreBattleSetUp(CampaignNode node)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostArea2EnemyDamageModifierSystem.NativeMethodInfoPtr_PreBattleSetUp_Private_Void_CampaignNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65050, XrefRangeEnd = 65057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PostBattleSetUp(CampaignNode node)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostArea2EnemyDamageModifierSystem.NativeMethodInfoPtr_PostBattleSetUp_Private_Void_CampaignNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65057, XrefRangeEnd = 65067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CardDataCreated(CardData cardData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostArea2EnemyDamageModifierSystem.NativeMethodInfoPtr_CardDataCreated_Private_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BoostArea2EnemyDamageModifierSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoostArea2EnemyDamageModifierSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostArea2EnemyDamageModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BoostArea2EnemyDamageModifierSystem()
  {
    Il2CppClassPointerStore<BoostArea2EnemyDamageModifierSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BoostArea2EnemyDamageModifierSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoostArea2EnemyDamageModifierSystem>.NativeClassPtr);
    BoostArea2EnemyDamageModifierSystem.NativeFieldInfoPtr_area = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoostArea2EnemyDamageModifierSystem>.NativeClassPtr, nameof (area));
    BoostArea2EnemyDamageModifierSystem.NativeFieldInfoPtr_damageAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoostArea2EnemyDamageModifierSystem>.NativeClassPtr, nameof (damageAdd));
    BoostArea2EnemyDamageModifierSystem.NativeFieldInfoPtr_correctArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoostArea2EnemyDamageModifierSystem>.NativeClassPtr, nameof (correctArea));
    BoostArea2EnemyDamageModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostArea2EnemyDamageModifierSystem>.NativeClassPtr, 100668620);
    BoostArea2EnemyDamageModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostArea2EnemyDamageModifierSystem>.NativeClassPtr, 100668621);
    BoostArea2EnemyDamageModifierSystem.NativeMethodInfoPtr_PreBattleSetUp_Private_Void_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostArea2EnemyDamageModifierSystem>.NativeClassPtr, 100668622);
    BoostArea2EnemyDamageModifierSystem.NativeMethodInfoPtr_PostBattleSetUp_Private_Void_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostArea2EnemyDamageModifierSystem>.NativeClassPtr, 100668623);
    BoostArea2EnemyDamageModifierSystem.NativeMethodInfoPtr_CardDataCreated_Private_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostArea2EnemyDamageModifierSystem>.NativeClassPtr, 100668624);
    BoostArea2EnemyDamageModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostArea2EnemyDamageModifierSystem>.NativeClassPtr, 100668625);
  }

  public BoostArea2EnemyDamageModifierSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe int area
  {
    get
    {
      int area;
      IL2CPP.il2cpp_field_static_get_value(BoostArea2EnemyDamageModifierSystem.NativeFieldInfoPtr_area, (void*) &area);
      return area;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BoostArea2EnemyDamageModifierSystem.NativeFieldInfoPtr_area, (void*) &value);
    }
  }

  public static unsafe int damageAdd
  {
    get
    {
      int damageAdd;
      IL2CPP.il2cpp_field_static_get_value(BoostArea2EnemyDamageModifierSystem.NativeFieldInfoPtr_damageAdd, (void*) &damageAdd);
      return damageAdd;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BoostArea2EnemyDamageModifierSystem.NativeFieldInfoPtr_damageAdd, (void*) &value);
    }
  }

  public unsafe bool correctArea
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BoostArea2EnemyDamageModifierSystem.NativeFieldInfoPtr_correctArea));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BoostArea2EnemyDamageModifierSystem.NativeFieldInfoPtr_correctArea)) = value;
    }
  }
}
