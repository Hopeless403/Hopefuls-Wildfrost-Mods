// Decompiled with JetBrains decompiler
// Type: CardDiscoverSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class CardDiscoverSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instance;
  private static readonly System.IntPtr NativeFieldInfoPtr_phaseChanges;
  private static readonly System.IntPtr NativeFieldInfoPtr_discoveredCards;
  private static readonly System.IntPtr NativeFieldInfoPtr_discoveredCharms;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CampaignStart_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntitySummoned_Private_Void_Entity_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityShowUnlocked_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpgradeGained_Private_Void_CardUpgradeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityEnterBackpack_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DiscoverCard_Private_Void_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DiscoverCard_Private_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DiscoverCharm_Private_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckDiscoverCharm_Public_Static_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56314, XrefRangeEnd = 56388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDiscoverSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56388, XrefRangeEnd = 56430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDiscoverSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56430, XrefRangeEnd = 56464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CampaignStart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDiscoverSystem.NativeMethodInfoPtr_CampaignStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56464, XrefRangeEnd = 56488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityKilled(Entity entity, DeathType deathType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deathType;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDiscoverSystem.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56488, XrefRangeEnd = 56490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntitySummoned(Entity entity, Entity summonedBy)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) summonedBy);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDiscoverSystem.NativeMethodInfoPtr_EntitySummoned_Private_Void_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityShowUnlocked(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDiscoverSystem.NativeMethodInfoPtr_EntityShowUnlocked_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56490, XrefRangeEnd = 56492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpgradeGained(CardUpgradeData upgradeData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgradeData)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDiscoverSystem.NativeMethodInfoPtr_UpgradeGained_Private_Void_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56492, XrefRangeEnd = 56510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityEnterBackpack(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDiscoverSystem.NativeMethodInfoPtr_EntityEnterBackpack_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56510, XrefRangeEnd = 56512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DiscoverCard(CardData cardData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDiscoverSystem.NativeMethodInfoPtr_DiscoverCard_Private_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 56526, RefRangeEnd = 56533, XrefRangeStart = 56512, XrefRangeEnd = 56526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DiscoverCard(string cardDataName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(cardDataName)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDiscoverSystem.NativeMethodInfoPtr_DiscoverCard_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 56547, RefRangeEnd = 56551, XrefRangeStart = 56533, XrefRangeEnd = 56547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DiscoverCharm(string charmName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(charmName)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDiscoverSystem.NativeMethodInfoPtr_DiscoverCharm_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 56555, RefRangeEnd = 56556, XrefRangeStart = 56551, XrefRangeEnd = 56555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CheckDiscoverCharm(string charmName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(charmName)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDiscoverSystem.NativeMethodInfoPtr_CheckDiscoverCharm_Public_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardDiscoverSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardDiscoverSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDiscoverSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardDiscoverSystem()
  {
    Il2CppClassPointerStore<CardDiscoverSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardDiscoverSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardDiscoverSystem>.NativeClassPtr);
    CardDiscoverSystem.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardDiscoverSystem>.NativeClassPtr, nameof (instance));
    CardDiscoverSystem.NativeFieldInfoPtr_phaseChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardDiscoverSystem>.NativeClassPtr, nameof (phaseChanges));
    CardDiscoverSystem.NativeFieldInfoPtr_discoveredCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardDiscoverSystem>.NativeClassPtr, nameof (discoveredCards));
    CardDiscoverSystem.NativeFieldInfoPtr_discoveredCharms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardDiscoverSystem>.NativeClassPtr, nameof (discoveredCharms));
    CardDiscoverSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDiscoverSystem>.NativeClassPtr, 100667903);
    CardDiscoverSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDiscoverSystem>.NativeClassPtr, 100667904);
    CardDiscoverSystem.NativeMethodInfoPtr_CampaignStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDiscoverSystem>.NativeClassPtr, 100667905);
    CardDiscoverSystem.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDiscoverSystem>.NativeClassPtr, 100667906);
    CardDiscoverSystem.NativeMethodInfoPtr_EntitySummoned_Private_Void_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDiscoverSystem>.NativeClassPtr, 100667907);
    CardDiscoverSystem.NativeMethodInfoPtr_EntityShowUnlocked_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDiscoverSystem>.NativeClassPtr, 100667908);
    CardDiscoverSystem.NativeMethodInfoPtr_UpgradeGained_Private_Void_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDiscoverSystem>.NativeClassPtr, 100667909);
    CardDiscoverSystem.NativeMethodInfoPtr_EntityEnterBackpack_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDiscoverSystem>.NativeClassPtr, 100667910);
    CardDiscoverSystem.NativeMethodInfoPtr_DiscoverCard_Private_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDiscoverSystem>.NativeClassPtr, 100667911);
    CardDiscoverSystem.NativeMethodInfoPtr_DiscoverCard_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDiscoverSystem>.NativeClassPtr, 100667912);
    CardDiscoverSystem.NativeMethodInfoPtr_DiscoverCharm_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDiscoverSystem>.NativeClassPtr, 100667913);
    CardDiscoverSystem.NativeMethodInfoPtr_CheckDiscoverCharm_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDiscoverSystem>.NativeClassPtr, 100667914);
    CardDiscoverSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDiscoverSystem>.NativeClassPtr, 100667915);
  }

  public CardDiscoverSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe CardDiscoverSystem instance
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CardDiscoverSystem.NativeFieldInfoPtr_instance, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardDiscoverSystem) null : new CardDiscoverSystem(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CardDiscoverSystem.NativeFieldInfoPtr_instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardDiscoverSystem.PhaseChange> phaseChanges
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardDiscoverSystem.NativeFieldInfoPtr_phaseChanges));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardDiscoverSystem.PhaseChange>) null : new Il2CppReferenceArray<CardDiscoverSystem.PhaseChange>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardDiscoverSystem.NativeFieldInfoPtr_phaseChanges), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<string> discoveredCards
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardDiscoverSystem.NativeFieldInfoPtr_discoveredCards));
      return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardDiscoverSystem.NativeFieldInfoPtr_discoveredCards), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<string> discoveredCharms
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardDiscoverSystem.NativeFieldInfoPtr_discoveredCharms));
      return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardDiscoverSystem.NativeFieldInfoPtr_discoveredCharms), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class PhaseChange : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_phasedCardName;
    private static readonly System.IntPtr NativeFieldInfoPtr_originalCardName;

    static PhaseChange()
    {
      Il2CppClassPointerStore<CardDiscoverSystem.PhaseChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardDiscoverSystem>.NativeClassPtr, nameof (PhaseChange));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardDiscoverSystem.PhaseChange>.NativeClassPtr);
      CardDiscoverSystem.PhaseChange.NativeFieldInfoPtr_phasedCardName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardDiscoverSystem.PhaseChange>.NativeClassPtr, nameof (phasedCardName));
      CardDiscoverSystem.PhaseChange.NativeFieldInfoPtr_originalCardName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardDiscoverSystem.PhaseChange>.NativeClassPtr, nameof (originalCardName));
    }

    public PhaseChange(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public PhaseChange()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CardDiscoverSystem.PhaseChange>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CardDiscoverSystem.PhaseChange>.NativeClassPtr, data));
    }

    public unsafe string phasedCardName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardDiscoverSystem.PhaseChange.NativeFieldInfoPtr_phasedCardName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardDiscoverSystem.PhaseChange.NativeFieldInfoPtr_phasedCardName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string originalCardName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardDiscoverSystem.PhaseChange.NativeFieldInfoPtr_originalCardName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardDiscoverSystem.PhaseChange.NativeFieldInfoPtr_originalCardName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  [ObfuscatedName("CardDiscoverSystem/<>c__DisplayClass7_0")]
  public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_entity;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__EntityKilled_b__0_Internal_Boolean_PhaseChange_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass7_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardDiscoverSystem.__c__DisplayClass7_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardDiscoverSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56311, XrefRangeEnd = 56314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _EntityKilled_b__0(CardDiscoverSystem.PhaseChange a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a))
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardDiscoverSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__EntityKilled_b__0_Internal_Boolean_PhaseChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass7_0()
    {
      Il2CppClassPointerStore<CardDiscoverSystem.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardDiscoverSystem>.NativeClassPtr, "<>c__DisplayClass7_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardDiscoverSystem.__c__DisplayClass7_0>.NativeClassPtr);
      CardDiscoverSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardDiscoverSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (entity));
      CardDiscoverSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDiscoverSystem.__c__DisplayClass7_0>.NativeClassPtr, 100667916);
      CardDiscoverSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__EntityKilled_b__0_Internal_Boolean_PhaseChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDiscoverSystem.__c__DisplayClass7_0>.NativeClassPtr, 100667917);
    }

    public __c__DisplayClass7_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Entity entity
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardDiscoverSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_entity));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardDiscoverSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
