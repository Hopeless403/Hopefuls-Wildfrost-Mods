// Decompiled with JetBrains decompiler
// Type: InjurySystem
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
public class InjurySystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_typesThatCanBeInjured;
  private static readonly System.IntPtr NativeFieldInfoPtr_injuryEffect;
  private static readonly System.IntPtr NativeFieldInfoPtr_injuredThisBattle;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BattleStart_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BattleSaved_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BattleLoaded_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsPlayerCard_Private_Static_Boolean_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsCloneOfPlayerCard_Private_Static_Boolean_CardData_byref_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Injure_Public_Void_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanInjure_Public_Boolean_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanInjure_Public_Boolean_CardType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInjuriesThisBattle_Public_Static_Il2CppReferenceArray_1_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsCardAlive_Private_Static_Boolean_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AnyAliveClonesOfThisCard_Private_Static_Boolean_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61315, XrefRangeEnd = 61342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InjurySystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61342, XrefRangeEnd = 61369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InjurySystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61369, XrefRangeEnd = 61389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityKilled(Entity entity, DeathType deathType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deathType;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InjurySystem.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61389, XrefRangeEnd = 61398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BattleStart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InjurySystem.NativeMethodInfoPtr_BattleStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61398, XrefRangeEnd = 61462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BattleSaved()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InjurySystem.NativeMethodInfoPtr_BattleSaved_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61462, XrefRangeEnd = 61506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BattleLoaded()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InjurySystem.NativeMethodInfoPtr_BattleLoaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61506, XrefRangeEnd = 61523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsPlayerCard(CardData cardData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InjurySystem.NativeMethodInfoPtr_IsPlayerCard_Private_Static_Boolean_CardData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 61541, RefRangeEnd = 61542, XrefRangeStart = 61523, XrefRangeEnd = 61541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsCloneOfPlayerCard(CardData cardData, out CardData originalCardData)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr exc;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InjurySystem.NativeMethodInfoPtr_IsCloneOfPlayerCard_Private_Static_Boolean_CardData_byref_CardData_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref CardData local = ref originalCardData;
    System.IntPtr pointer = zero;
    CardData cardData1 = pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
    local = cardData1;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 61575, RefRangeEnd = 61576, XrefRangeStart = 61542, XrefRangeEnd = 61575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Injure(CardData cardData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InjurySystem.NativeMethodInfoPtr_Injure_Public_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61576, XrefRangeEnd = 61580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CanInjure(CardData cardData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InjurySystem.NativeMethodInfoPtr_CanInjure_Public_Boolean_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61580, XrefRangeEnd = 61583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CanInjure(CardType cardType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardType)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InjurySystem.NativeMethodInfoPtr_CanInjure_Public_Boolean_CardType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 61606, RefRangeEnd = 61608, XrefRangeStart = 61583, XrefRangeEnd = 61606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppReferenceArray<CardData> GetInjuriesThisBattle()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InjurySystem.NativeMethodInfoPtr_GetInjuriesThisBattle_Public_Static_Il2CppReferenceArray_1_CardData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr nativeObject = num;
    return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardData>) null : new Il2CppReferenceArray<CardData>(nativeObject);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 61621, RefRangeEnd = 61622, XrefRangeStart = 61608, XrefRangeEnd = 61621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsCardAlive(CardData cardData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InjurySystem.NativeMethodInfoPtr_IsCardAlive_Private_Static_Boolean_CardData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 61649, RefRangeEnd = 61650, XrefRangeStart = 61622, XrefRangeEnd = 61649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool AnyAliveClonesOfThisCard(CardData originalCardData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) originalCardData)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InjurySystem.NativeMethodInfoPtr_AnyAliveClonesOfThisCard_Private_Static_Boolean_CardData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InjurySystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InjurySystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InjurySystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static InjurySystem()
  {
    Il2CppClassPointerStore<InjurySystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (InjurySystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InjurySystem>.NativeClassPtr);
    InjurySystem.NativeFieldInfoPtr_typesThatCanBeInjured = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjurySystem>.NativeClassPtr, nameof (typesThatCanBeInjured));
    InjurySystem.NativeFieldInfoPtr_injuryEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjurySystem>.NativeClassPtr, nameof (injuryEffect));
    InjurySystem.NativeFieldInfoPtr_injuredThisBattle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjurySystem>.NativeClassPtr, nameof (injuredThisBattle));
    InjurySystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjurySystem>.NativeClassPtr, 100668294);
    InjurySystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjurySystem>.NativeClassPtr, 100668295);
    InjurySystem.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjurySystem>.NativeClassPtr, 100668296);
    InjurySystem.NativeMethodInfoPtr_BattleStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjurySystem>.NativeClassPtr, 100668297);
    InjurySystem.NativeMethodInfoPtr_BattleSaved_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjurySystem>.NativeClassPtr, 100668298);
    InjurySystem.NativeMethodInfoPtr_BattleLoaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjurySystem>.NativeClassPtr, 100668299);
    InjurySystem.NativeMethodInfoPtr_IsPlayerCard_Private_Static_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjurySystem>.NativeClassPtr, 100668300);
    InjurySystem.NativeMethodInfoPtr_IsCloneOfPlayerCard_Private_Static_Boolean_CardData_byref_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjurySystem>.NativeClassPtr, 100668301);
    InjurySystem.NativeMethodInfoPtr_Injure_Public_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjurySystem>.NativeClassPtr, 100668302);
    InjurySystem.NativeMethodInfoPtr_CanInjure_Public_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjurySystem>.NativeClassPtr, 100668303);
    InjurySystem.NativeMethodInfoPtr_CanInjure_Public_Boolean_CardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjurySystem>.NativeClassPtr, 100668304);
    InjurySystem.NativeMethodInfoPtr_GetInjuriesThisBattle_Public_Static_Il2CppReferenceArray_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjurySystem>.NativeClassPtr, 100668305);
    InjurySystem.NativeMethodInfoPtr_IsCardAlive_Private_Static_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjurySystem>.NativeClassPtr, 100668306);
    InjurySystem.NativeMethodInfoPtr_AnyAliveClonesOfThisCard_Private_Static_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjurySystem>.NativeClassPtr, 100668307);
    InjurySystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjurySystem>.NativeClassPtr, 100668308);
  }

  public InjurySystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<CardType> typesThatCanBeInjured
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InjurySystem.NativeFieldInfoPtr_typesThatCanBeInjured));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardType>) null : new Il2CppReferenceArray<CardType>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InjurySystem.NativeFieldInfoPtr_typesThatCanBeInjured), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData injuryEffect
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InjurySystem.NativeFieldInfoPtr_injuryEffect));
      return pointer == System.IntPtr.Zero ? (StatusEffectData) null : new StatusEffectData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InjurySystem.NativeFieldInfoPtr_injuryEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<CardData> injuredThisBattle
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InjurySystem.NativeFieldInfoPtr_injuredThisBattle));
      return pointer == System.IntPtr.Zero ? (List<CardData>) null : new List<CardData>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InjurySystem.NativeFieldInfoPtr_injuredThisBattle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class SaveState : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_campaignNodeId;
    private static readonly System.IntPtr NativeFieldInfoPtr_injuredThisBattleIds;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_IEnumerable_1_CardData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_List_1_CardData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SaveState()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InjurySystem.SaveState>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InjurySystem.SaveState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61258, XrefRangeEnd = 61282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SaveState(int campaignNodeId, IEnumerable<CardData> injuredThisBattle)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InjurySystem.SaveState>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &campaignNodeId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) injuredThisBattle);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InjurySystem.SaveState.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEnumerable_1_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 61314, RefRangeEnd = 61315, XrefRangeStart = 61282, XrefRangeEnd = 61314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<CardData> Load()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InjurySystem.SaveState.NativeMethodInfoPtr_Load_Public_List_1_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<CardData>) null : new List<CardData>(pointer);
    }

    static SaveState()
    {
      Il2CppClassPointerStore<InjurySystem.SaveState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InjurySystem>.NativeClassPtr, nameof (SaveState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InjurySystem.SaveState>.NativeClassPtr);
      InjurySystem.SaveState.NativeFieldInfoPtr_campaignNodeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjurySystem.SaveState>.NativeClassPtr, nameof (campaignNodeId));
      InjurySystem.SaveState.NativeFieldInfoPtr_injuredThisBattleIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjurySystem.SaveState>.NativeClassPtr, nameof (injuredThisBattleIds));
      InjurySystem.SaveState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjurySystem.SaveState>.NativeClassPtr, 100668309);
      InjurySystem.SaveState.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEnumerable_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjurySystem.SaveState>.NativeClassPtr, 100668310);
      InjurySystem.SaveState.NativeMethodInfoPtr_Load_Public_List_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjurySystem.SaveState>.NativeClassPtr, 100668311);
    }

    public SaveState(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int campaignNodeId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InjurySystem.SaveState.NativeFieldInfoPtr_campaignNodeId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InjurySystem.SaveState.NativeFieldInfoPtr_campaignNodeId)) = value;
      }
    }

    public unsafe List<ulong> injuredThisBattleIds
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InjurySystem.SaveState.NativeFieldInfoPtr_injuredThisBattleIds));
        return pointer == System.IntPtr.Zero ? (List<ulong>) null : new List<ulong>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InjurySystem.SaveState.NativeFieldInfoPtr_injuredThisBattleIds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("InjurySystem/SaveState/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__3_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__3_0_Internal_UInt64_CardData_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InjurySystem.SaveState.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InjurySystem.SaveState.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe ulong __ctor_b__3_0(CardData a)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
        };
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InjurySystem.SaveState.__c.NativeMethodInfoPtr___ctor_b__3_0_Internal_UInt64_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<InjurySystem.SaveState.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InjurySystem.SaveState>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InjurySystem.SaveState.__c>.NativeClassPtr);
        InjurySystem.SaveState.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjurySystem.SaveState.__c>.NativeClassPtr, "<>9");
        InjurySystem.SaveState.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjurySystem.SaveState.__c>.NativeClassPtr, "<>9__3_0");
        InjurySystem.SaveState.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjurySystem.SaveState.__c>.NativeClassPtr, 100668313);
        InjurySystem.SaveState.__c.NativeMethodInfoPtr___ctor_b__3_0_Internal_UInt64_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjurySystem.SaveState.__c>.NativeClassPtr, 100668314);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe InjurySystem.SaveState.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(InjurySystem.SaveState.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InjurySystem.SaveState.__c) null : new InjurySystem.SaveState.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(InjurySystem.SaveState.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<CardData, ulong> __9__3_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(InjurySystem.SaveState.__c.NativeFieldInfoPtr___9__3_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData, ulong>) null : new Il2CppSystem.Func<CardData, ulong>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(InjurySystem.SaveState.__c.NativeFieldInfoPtr___9__3_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  [ObfuscatedName("InjurySystem/<>c__DisplayClass9_0")]
  public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_cardData;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__IsPlayerCard_b__0_Internal_Boolean_CardData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass9_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InjurySystem.__c__DisplayClass9_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InjurySystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _IsPlayerCard_b__0(CardData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InjurySystem.__c__DisplayClass9_0.NativeMethodInfoPtr__IsPlayerCard_b__0_Internal_Boolean_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass9_0()
    {
      Il2CppClassPointerStore<InjurySystem.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InjurySystem>.NativeClassPtr, "<>c__DisplayClass9_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InjurySystem.__c__DisplayClass9_0>.NativeClassPtr);
      InjurySystem.__c__DisplayClass9_0.NativeFieldInfoPtr_cardData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjurySystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (cardData));
      InjurySystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjurySystem.__c__DisplayClass9_0>.NativeClassPtr, 100668315);
      InjurySystem.__c__DisplayClass9_0.NativeMethodInfoPtr__IsPlayerCard_b__0_Internal_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjurySystem.__c__DisplayClass9_0>.NativeClassPtr, 100668316);
    }

    public __c__DisplayClass9_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CardData cardData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InjurySystem.__c__DisplayClass9_0.NativeFieldInfoPtr_cardData));
        return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InjurySystem.__c__DisplayClass9_0.NativeFieldInfoPtr_cardData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
