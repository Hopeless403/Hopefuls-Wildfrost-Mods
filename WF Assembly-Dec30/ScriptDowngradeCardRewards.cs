// Decompiled with JetBrains decompiler
// Type: ScriptDowngradeCardRewards
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class ScriptDowngradeCardRewards : Script
{
  private static readonly System.IntPtr NativeFieldInfoPtr_charms;
  private static readonly System.IntPtr NativeFieldInfoPtr_downgradesPerTier;
  private static readonly System.IntPtr NativeFieldInfoPtr_charmSets;
  private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryAddDowngrade_Private_Boolean_CampaignNode_List_1_CardUpgradeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddUpgradeToCardInNodeData_Private_Static_Void_CampaignNode_Int32_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryAddDowngrade_Private_Boolean_Il2CppStringArray_List_1_CardUpgradeData_byref_Int32_byref_CardUpgradeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindDowngrade_Private_CardUpgradeData_CardData_List_1_CardUpgradeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PopulatePool_Private_List_1_CardUpgradeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22486, XrefRangeEnd = 22491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator Run()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScriptDowngradeCardRewards.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 22615, RefRangeEnd = 22616, XrefRangeStart = 22491, XrefRangeEnd = 22615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryAddDowngrade(CampaignNode node, List<CardUpgradeData> pool)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pool);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptDowngradeCardRewards.NativeMethodInfoPtr_TryAddDowngrade_Private_Boolean_CampaignNode_List_1_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 22657, RefRangeEnd = 22659, XrefRangeStart = 22616, XrefRangeEnd = 22657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddUpgradeToCardInNodeData(
    CampaignNode node,
    int cardIndex,
    string upgradeName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cardIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(upgradeName);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScriptDowngradeCardRewards.NativeMethodInfoPtr_AddUpgradeToCardInNodeData_Private_Static_Void_CampaignNode_Int32_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 22718, RefRangeEnd = 22721, XrefRangeStart = 22659, XrefRangeEnd = 22718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryAddDowngrade(
    Il2CppStringArray cardNames,
    List<CardUpgradeData> pool,
    out int appliedToIndex,
    out CardUpgradeData downgradeApplied)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardNames);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pool);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref appliedToIndex;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr exc;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDowngradeCardRewards.NativeMethodInfoPtr_TryAddDowngrade_Private_Boolean_Il2CppStringArray_List_1_CardUpgradeData_byref_Int32_byref_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref CardUpgradeData local = ref downgradeApplied;
    System.IntPtr pointer = zero;
    CardUpgradeData cardUpgradeData = pointer == System.IntPtr.Zero ? (CardUpgradeData) null : new CardUpgradeData(pointer);
    local = cardUpgradeData;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22721, XrefRangeEnd = 22731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardUpgradeData FindDowngrade(CardData cardData, List<CardUpgradeData> pool)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pool);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptDowngradeCardRewards.NativeMethodInfoPtr_FindDowngrade_Private_CardUpgradeData_CardData_List_1_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CardUpgradeData) null : new CardUpgradeData(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22731, XrefRangeEnd = 22747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<CardUpgradeData> PopulatePool()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptDowngradeCardRewards.NativeMethodInfoPtr_PopulatePool_Private_List_1_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<CardUpgradeData>) null : new List<CardUpgradeData>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22747, XrefRangeEnd = 22748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScriptDowngradeCardRewards()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptDowngradeCardRewards>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScriptDowngradeCardRewards.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ScriptDowngradeCardRewards()
  {
    Il2CppClassPointerStore<ScriptDowngradeCardRewards>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ScriptDowngradeCardRewards));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptDowngradeCardRewards>.NativeClassPtr);
    ScriptDowngradeCardRewards.NativeFieldInfoPtr_charms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptDowngradeCardRewards>.NativeClassPtr, nameof (charms));
    ScriptDowngradeCardRewards.NativeFieldInfoPtr_downgradesPerTier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptDowngradeCardRewards>.NativeClassPtr, nameof (downgradesPerTier));
    ScriptDowngradeCardRewards.NativeFieldInfoPtr_charmSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptDowngradeCardRewards>.NativeClassPtr, nameof (charmSets));
    ScriptDowngradeCardRewards.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDowngradeCardRewards>.NativeClassPtr, 100664061);
    ScriptDowngradeCardRewards.NativeMethodInfoPtr_TryAddDowngrade_Private_Boolean_CampaignNode_List_1_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDowngradeCardRewards>.NativeClassPtr, 100664062);
    ScriptDowngradeCardRewards.NativeMethodInfoPtr_AddUpgradeToCardInNodeData_Private_Static_Void_CampaignNode_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDowngradeCardRewards>.NativeClassPtr, 100664063);
    ScriptDowngradeCardRewards.NativeMethodInfoPtr_TryAddDowngrade_Private_Boolean_Il2CppStringArray_List_1_CardUpgradeData_byref_Int32_byref_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDowngradeCardRewards>.NativeClassPtr, 100664064);
    ScriptDowngradeCardRewards.NativeMethodInfoPtr_FindDowngrade_Private_CardUpgradeData_CardData_List_1_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDowngradeCardRewards>.NativeClassPtr, 100664065);
    ScriptDowngradeCardRewards.NativeMethodInfoPtr_PopulatePool_Private_List_1_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDowngradeCardRewards>.NativeClassPtr, 100664066);
    ScriptDowngradeCardRewards.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDowngradeCardRewards>.NativeClassPtr, 100664067);
  }

  public ScriptDowngradeCardRewards(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<CardUpgradeData> charms
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptDowngradeCardRewards.NativeFieldInfoPtr_charms));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardUpgradeData>) null : new Il2CppReferenceArray<CardUpgradeData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptDowngradeCardRewards.NativeFieldInfoPtr_charms), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int downgradesPerTier
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptDowngradeCardRewards.NativeFieldInfoPtr_downgradesPerTier));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptDowngradeCardRewards.NativeFieldInfoPtr_downgradesPerTier)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<ScriptDowngradeCardRewards.FixedCharmSet> charmSets
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptDowngradeCardRewards.NativeFieldInfoPtr_charmSets));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ScriptDowngradeCardRewards.FixedCharmSet>) null : new Il2CppReferenceArray<ScriptDowngradeCardRewards.FixedCharmSet>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptDowngradeCardRewards.NativeFieldInfoPtr_charmSets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class FixedCharmSet : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_cards;
    private static readonly System.IntPtr NativeFieldInfoPtr_charmOptions;

    static FixedCharmSet()
    {
      Il2CppClassPointerStore<ScriptDowngradeCardRewards.FixedCharmSet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptDowngradeCardRewards>.NativeClassPtr, nameof (FixedCharmSet));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptDowngradeCardRewards.FixedCharmSet>.NativeClassPtr);
      ScriptDowngradeCardRewards.FixedCharmSet.NativeFieldInfoPtr_cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptDowngradeCardRewards.FixedCharmSet>.NativeClassPtr, nameof (cards));
      ScriptDowngradeCardRewards.FixedCharmSet.NativeFieldInfoPtr_charmOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptDowngradeCardRewards.FixedCharmSet>.NativeClassPtr, nameof (charmOptions));
    }

    public FixedCharmSet(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public FixedCharmSet()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ScriptDowngradeCardRewards.FixedCharmSet>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptDowngradeCardRewards.FixedCharmSet>.NativeClassPtr, data));
    }

    public unsafe Il2CppStringArray cards
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptDowngradeCardRewards.FixedCharmSet.NativeFieldInfoPtr_cards));
        return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptDowngradeCardRewards.FixedCharmSet.NativeFieldInfoPtr_cards), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<CardUpgradeData> charmOptions
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptDowngradeCardRewards.FixedCharmSet.NativeFieldInfoPtr_charmOptions));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardUpgradeData>) null : new Il2CppReferenceArray<CardUpgradeData>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptDowngradeCardRewards.FixedCharmSet.NativeFieldInfoPtr_charmOptions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("ScriptDowngradeCardRewards/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__3_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__4_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__4_1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Run_b__3_0_Internal_Boolean_CampaignNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TryAddDowngrade_b__4_0_Internal_String_Item_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TryAddDowngrade_b__4_1_Internal_String_UpgradedCard_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptDowngradeCardRewards.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScriptDowngradeCardRewards.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Run_b__3_0(CampaignNode a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptDowngradeCardRewards.__c.NativeMethodInfoPtr__Run_b__3_0_Internal_Boolean_CampaignNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe string _TryAddDowngrade_b__4_0(ShopRoutine.Item a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ScriptDowngradeCardRewards.__c.NativeMethodInfoPtr__TryAddDowngrade_b__4_0_Internal_String_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    public unsafe string _TryAddDowngrade_b__4_1(EventRoutineCharmShop.UpgradedCard a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ScriptDowngradeCardRewards.__c.NativeMethodInfoPtr__TryAddDowngrade_b__4_1_Internal_String_UpgradedCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static __c()
    {
      Il2CppClassPointerStore<ScriptDowngradeCardRewards.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptDowngradeCardRewards>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptDowngradeCardRewards.__c>.NativeClassPtr);
      ScriptDowngradeCardRewards.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptDowngradeCardRewards.__c>.NativeClassPtr, "<>9");
      ScriptDowngradeCardRewards.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptDowngradeCardRewards.__c>.NativeClassPtr, "<>9__3_0");
      ScriptDowngradeCardRewards.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptDowngradeCardRewards.__c>.NativeClassPtr, "<>9__4_0");
      ScriptDowngradeCardRewards.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptDowngradeCardRewards.__c>.NativeClassPtr, "<>9__4_1");
      ScriptDowngradeCardRewards.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDowngradeCardRewards.__c>.NativeClassPtr, 100664069);
      ScriptDowngradeCardRewards.__c.NativeMethodInfoPtr__Run_b__3_0_Internal_Boolean_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDowngradeCardRewards.__c>.NativeClassPtr, 100664070);
      ScriptDowngradeCardRewards.__c.NativeMethodInfoPtr__TryAddDowngrade_b__4_0_Internal_String_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDowngradeCardRewards.__c>.NativeClassPtr, 100664071);
      ScriptDowngradeCardRewards.__c.NativeMethodInfoPtr__TryAddDowngrade_b__4_1_Internal_String_UpgradedCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDowngradeCardRewards.__c>.NativeClassPtr, 100664072);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe ScriptDowngradeCardRewards.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ScriptDowngradeCardRewards.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ScriptDowngradeCardRewards.__c) null : new ScriptDowngradeCardRewards.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ScriptDowngradeCardRewards.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CampaignNode, bool> __9__3_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ScriptDowngradeCardRewards.__c.NativeFieldInfoPtr___9__3_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CampaignNode, bool>) null : new Il2CppSystem.Func<CampaignNode, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ScriptDowngradeCardRewards.__c.NativeFieldInfoPtr___9__3_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<ShopRoutine.Item, string> __9__4_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ScriptDowngradeCardRewards.__c.NativeFieldInfoPtr___9__4_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ShopRoutine.Item, string>) null : new Il2CppSystem.Func<ShopRoutine.Item, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ScriptDowngradeCardRewards.__c.NativeFieldInfoPtr___9__4_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<EventRoutineCharmShop.UpgradedCard, string> __9__4_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ScriptDowngradeCardRewards.__c.NativeFieldInfoPtr___9__4_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<EventRoutineCharmShop.UpgradedCard, string>) null : new Il2CppSystem.Func<EventRoutineCharmShop.UpgradedCard, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ScriptDowngradeCardRewards.__c.NativeFieldInfoPtr___9__4_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("ScriptDowngradeCardRewards/<Run>d__3")]
  public sealed class _Run_d__3 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Run_d__3(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptDowngradeCardRewards._Run_d__3>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScriptDowngradeCardRewards._Run_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScriptDowngradeCardRewards._Run_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22406, XrefRangeEnd = 22480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptDowngradeCardRewards._Run_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptDowngradeCardRewards._Run_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22480, XrefRangeEnd = 22486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScriptDowngradeCardRewards._Run_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptDowngradeCardRewards._Run_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Run_d__3()
    {
      Il2CppClassPointerStore<ScriptDowngradeCardRewards._Run_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptDowngradeCardRewards>.NativeClassPtr, "<Run>d__3");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptDowngradeCardRewards._Run_d__3>.NativeClassPtr);
      ScriptDowngradeCardRewards._Run_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptDowngradeCardRewards._Run_d__3>.NativeClassPtr, "<>1__state");
      ScriptDowngradeCardRewards._Run_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptDowngradeCardRewards._Run_d__3>.NativeClassPtr, "<>2__current");
      ScriptDowngradeCardRewards._Run_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptDowngradeCardRewards._Run_d__3>.NativeClassPtr, "<>4__this");
      ScriptDowngradeCardRewards._Run_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDowngradeCardRewards._Run_d__3>.NativeClassPtr, 100664073);
      ScriptDowngradeCardRewards._Run_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDowngradeCardRewards._Run_d__3>.NativeClassPtr, 100664074);
      ScriptDowngradeCardRewards._Run_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDowngradeCardRewards._Run_d__3>.NativeClassPtr, 100664075);
      ScriptDowngradeCardRewards._Run_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDowngradeCardRewards._Run_d__3>.NativeClassPtr, 100664076);
      ScriptDowngradeCardRewards._Run_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDowngradeCardRewards._Run_d__3>.NativeClassPtr, 100664077);
      ScriptDowngradeCardRewards._Run_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDowngradeCardRewards._Run_d__3>.NativeClassPtr, 100664078);
    }

    public _Run_d__3(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptDowngradeCardRewards._Run_d__3.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptDowngradeCardRewards._Run_d__3.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptDowngradeCardRewards._Run_d__3.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptDowngradeCardRewards._Run_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ScriptDowngradeCardRewards __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptDowngradeCardRewards._Run_d__3.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (ScriptDowngradeCardRewards) null : new ScriptDowngradeCardRewards(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptDowngradeCardRewards._Run_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
