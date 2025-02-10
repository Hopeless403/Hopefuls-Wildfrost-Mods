// Decompiled with JetBrains decompiler
// Type: BoostArea3EnemyDamageModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class BoostArea3EnemyDamageModifierSystem : GameSystem
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
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65067, XrefRangeEnd = 65081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostArea3EnemyDamageModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65081, XrefRangeEnd = 65095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostArea3EnemyDamageModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65095, XrefRangeEnd = 65102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PreBattleSetUp(CampaignNode node)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostArea3EnemyDamageModifierSystem.NativeMethodInfoPtr_PreBattleSetUp_Private_Void_CampaignNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65102, XrefRangeEnd = 65109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PostBattleSetUp(CampaignNode node)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostArea3EnemyDamageModifierSystem.NativeMethodInfoPtr_PostBattleSetUp_Private_Void_CampaignNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65109, XrefRangeEnd = 65119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CardDataCreated(CardData cardData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostArea3EnemyDamageModifierSystem.NativeMethodInfoPtr_CardDataCreated_Private_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BoostArea3EnemyDamageModifierSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoostArea3EnemyDamageModifierSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostArea3EnemyDamageModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BoostArea3EnemyDamageModifierSystem()
  {
    Il2CppClassPointerStore<BoostArea3EnemyDamageModifierSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BoostArea3EnemyDamageModifierSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoostArea3EnemyDamageModifierSystem>.NativeClassPtr);
    BoostArea3EnemyDamageModifierSystem.NativeFieldInfoPtr_area = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoostArea3EnemyDamageModifierSystem>.NativeClassPtr, nameof (area));
    BoostArea3EnemyDamageModifierSystem.NativeFieldInfoPtr_damageAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoostArea3EnemyDamageModifierSystem>.NativeClassPtr, nameof (damageAdd));
    BoostArea3EnemyDamageModifierSystem.NativeFieldInfoPtr_correctArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoostArea3EnemyDamageModifierSystem>.NativeClassPtr, nameof (correctArea));
    BoostArea3EnemyDamageModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostArea3EnemyDamageModifierSystem>.NativeClassPtr, 100668626);
    BoostArea3EnemyDamageModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostArea3EnemyDamageModifierSystem>.NativeClassPtr, 100668627);
    BoostArea3EnemyDamageModifierSystem.NativeMethodInfoPtr_PreBattleSetUp_Private_Void_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostArea3EnemyDamageModifierSystem>.NativeClassPtr, 100668628);
    BoostArea3EnemyDamageModifierSystem.NativeMethodInfoPtr_PostBattleSetUp_Private_Void_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostArea3EnemyDamageModifierSystem>.NativeClassPtr, 100668629);
    BoostArea3EnemyDamageModifierSystem.NativeMethodInfoPtr_CardDataCreated_Private_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostArea3EnemyDamageModifierSystem>.NativeClassPtr, 100668630);
    BoostArea3EnemyDamageModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostArea3EnemyDamageModifierSystem>.NativeClassPtr, 100668631);
  }

  public BoostArea3EnemyDamageModifierSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe int area
  {
    get
    {
      int area;
      IL2CPP.il2cpp_field_static_get_value(BoostArea3EnemyDamageModifierSystem.NativeFieldInfoPtr_area, (void*) &area);
      return area;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BoostArea3EnemyDamageModifierSystem.NativeFieldInfoPtr_area, (void*) &value);
    }
  }

  public static unsafe int damageAdd
  {
    get
    {
      int damageAdd;
      IL2CPP.il2cpp_field_static_get_value(BoostArea3EnemyDamageModifierSystem.NativeFieldInfoPtr_damageAdd, (void*) &damageAdd);
      return damageAdd;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BoostArea3EnemyDamageModifierSystem.NativeFieldInfoPtr_damageAdd, (void*) &value);
    }
  }

  public unsafe bool correctArea
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BoostArea3EnemyDamageModifierSystem.NativeFieldInfoPtr_correctArea));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BoostArea3EnemyDamageModifierSystem.NativeFieldInfoPtr_correctArea)) = value;
    }
  }
}
