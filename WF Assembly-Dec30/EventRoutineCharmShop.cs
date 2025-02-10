// Decompiled with JetBrains decompiler
// Type: EventRoutineCharmShop
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
public class EventRoutineCharmShop : EventRoutine
{
  private static readonly System.IntPtr NativeFieldInfoPtr_priceManager;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardController;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardContainer;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardSelector;
  private static readonly System.IntPtr NativeFieldInfoPtr_holders;
  private static readonly System.IntPtr NativeFieldInfoPtr_gainCharmSequence;
  private static readonly System.IntPtr NativeFieldInfoPtr_talker;
  private static readonly System.IntPtr NativeFieldInfoPtr_speechBubDelay;
  private static readonly System.IntPtr NativeFieldInfoPtr_speechBubTimer;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentHover;
  private static readonly System.IntPtr NativeFieldInfoPtr_items;
  private static readonly System.IntPtr NativeFieldInfoPtr_promptEnd;
  private static readonly System.IntPtr NativeMethodInfoPtr_PromptEnd_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityHover_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityUnHover_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Populate_Public_Virtual_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Bub_Private_Void_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryBuy_Public_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryBuy_Public_Void_ShopItem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Hover_Public_Void_ShopItem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnHover_Public_Void_ShopItem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateUpgrade_Private_Void_CardUpgradeData_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 29269, RefRangeEnd = 29270, XrefRangeStart = 29269, XrefRangeEnd = 29270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PromptEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.NativeMethodInfoPtr_PromptEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46505, XrefRangeEnd = 46519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46519, XrefRangeEnd = 46533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46533, XrefRangeEnd = 46537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityHover(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.NativeMethodInfoPtr_EntityHover_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46537, XrefRangeEnd = 46541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityUnHover(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.NativeMethodInfoPtr_EntityUnHover_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46541, XrefRangeEnd = 46542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46542, XrefRangeEnd = 46547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator Populate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EventRoutineCharmShop.NativeMethodInfoPtr_Populate_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46547, XrefRangeEnd = 46552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator Run()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EventRoutineCharmShop.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46552, XrefRangeEnd = 46553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Bub(string speechType, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> inserts)
  {
    if (inserts == null)
      inserts = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(speechType);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inserts);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.NativeMethodInfoPtr_Bub_Private_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46553, XrefRangeEnd = 46580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TryBuy(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.NativeMethodInfoPtr_TryBuy_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 46599, RefRangeEnd = 46600, XrefRangeStart = 46580, XrefRangeEnd = 46599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TryBuy(ShopItem item)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.NativeMethodInfoPtr_TryBuy_Public_Void_ShopItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 46624, RefRangeEnd = 46626, XrefRangeStart = 46600, XrefRangeEnd = 46624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hover(ShopItem item)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.NativeMethodInfoPtr_Hover_Public_Void_ShopItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 46641, RefRangeEnd = 46644, XrefRangeStart = 46626, XrefRangeEnd = 46641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnHover(ShopItem item)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.NativeMethodInfoPtr_UnHover_Public_Void_ShopItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 46707, RefRangeEnd = 46708, XrefRangeStart = 46644, XrefRangeEnd = 46707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateUpgrade(CardUpgradeData upgradeDataClone, int price, float priceFactor)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgradeDataClone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &price;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &priceFactor;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.NativeMethodInfoPtr_CreateUpgrade_Private_Void_CardUpgradeData_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46708, XrefRangeEnd = 46717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EventRoutineCharmShop()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public void Bub(string speechType, params Il2CppSystem.Object[] inserts)
  {
    this.Bub(speechType, new Il2CppReferenceArray<Il2CppSystem.Object>(inserts));
  }

  static EventRoutineCharmShop()
  {
    Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (EventRoutineCharmShop));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr);
    EventRoutineCharmShop.NativeFieldInfoPtr_priceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, nameof (priceManager));
    EventRoutineCharmShop.NativeFieldInfoPtr_cardController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, nameof (cardController));
    EventRoutineCharmShop.NativeFieldInfoPtr_cardContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, nameof (cardContainer));
    EventRoutineCharmShop.NativeFieldInfoPtr_cardSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, nameof (cardSelector));
    EventRoutineCharmShop.NativeFieldInfoPtr_holders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, nameof (holders));
    EventRoutineCharmShop.NativeFieldInfoPtr_gainCharmSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, nameof (gainCharmSequence));
    EventRoutineCharmShop.NativeFieldInfoPtr_talker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, nameof (talker));
    EventRoutineCharmShop.NativeFieldInfoPtr_speechBubDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, nameof (speechBubDelay));
    EventRoutineCharmShop.NativeFieldInfoPtr_speechBubTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, nameof (speechBubTimer));
    EventRoutineCharmShop.NativeFieldInfoPtr_currentHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, nameof (currentHover));
    EventRoutineCharmShop.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, nameof (items));
    EventRoutineCharmShop.NativeFieldInfoPtr_promptEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, nameof (promptEnd));
    EventRoutineCharmShop.NativeMethodInfoPtr_PromptEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, 100666784);
    EventRoutineCharmShop.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, 100666785);
    EventRoutineCharmShop.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, 100666786);
    EventRoutineCharmShop.NativeMethodInfoPtr_EntityHover_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, 100666787);
    EventRoutineCharmShop.NativeMethodInfoPtr_EntityUnHover_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, 100666788);
    EventRoutineCharmShop.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, 100666789);
    EventRoutineCharmShop.NativeMethodInfoPtr_Populate_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, 100666790);
    EventRoutineCharmShop.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, 100666791);
    EventRoutineCharmShop.NativeMethodInfoPtr_Bub_Private_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, 100666792);
    EventRoutineCharmShop.NativeMethodInfoPtr_TryBuy_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, 100666793);
    EventRoutineCharmShop.NativeMethodInfoPtr_TryBuy_Public_Void_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, 100666794);
    EventRoutineCharmShop.NativeMethodInfoPtr_Hover_Public_Void_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, 100666795);
    EventRoutineCharmShop.NativeMethodInfoPtr_UnHover_Public_Void_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, 100666796);
    EventRoutineCharmShop.NativeMethodInfoPtr_CreateUpgrade_Private_Void_CardUpgradeData_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, 100666797);
    EventRoutineCharmShop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, 100666798);
  }

  public EventRoutineCharmShop(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe ShopPriceManager priceManager
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.NativeFieldInfoPtr_priceManager));
      return pointer == System.IntPtr.Zero ? (ShopPriceManager) null : new ShopPriceManager(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.NativeFieldInfoPtr_priceManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardController cardController
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.NativeFieldInfoPtr_cardController));
      return pointer == System.IntPtr.Zero ? (CardController) null : new CardController(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.NativeFieldInfoPtr_cardController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardContainer cardContainer
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.NativeFieldInfoPtr_cardContainer));
      return pointer == System.IntPtr.Zero ? (CardContainer) null : new CardContainer(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.NativeFieldInfoPtr_cardContainer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardSelector cardSelector
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.NativeFieldInfoPtr_cardSelector));
      return pointer == System.IntPtr.Zero ? (CardSelector) null : new CardSelector(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.NativeFieldInfoPtr_cardSelector), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardCharmHolder> holders
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.NativeFieldInfoPtr_holders));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardCharmHolder>) null : new Il2CppReferenceArray<CardCharmHolder>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.NativeFieldInfoPtr_holders), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GainCharmSequence gainCharmSequence
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.NativeFieldInfoPtr_gainCharmSequence));
      return pointer == System.IntPtr.Zero ? (GainCharmSequence) null : new GainCharmSequence(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.NativeFieldInfoPtr_gainCharmSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Talker talker
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.NativeFieldInfoPtr_talker));
      return pointer == System.IntPtr.Zero ? (Talker) null : new Talker(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.NativeFieldInfoPtr_talker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe float speechBubDelay
  {
    get
    {
      float speechBubDelay;
      IL2CPP.il2cpp_field_static_get_value(EventRoutineCharmShop.NativeFieldInfoPtr_speechBubDelay, (void*) &speechBubDelay);
      return speechBubDelay;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EventRoutineCharmShop.NativeFieldInfoPtr_speechBubDelay, (void*) &value);
    }
  }

  public unsafe float speechBubTimer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.NativeFieldInfoPtr_speechBubTimer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.NativeFieldInfoPtr_speechBubTimer)) = value;
    }
  }

  public unsafe ShopItem currentHover
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.NativeFieldInfoPtr_currentHover));
      return pointer == System.IntPtr.Zero ? (ShopItem) null : new ShopItem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.NativeFieldInfoPtr_currentHover), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ShopItem> items
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.NativeFieldInfoPtr_items));
      return pointer == System.IntPtr.Zero ? (List<ShopItem>) null : new List<ShopItem>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool promptEnd
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.NativeFieldInfoPtr_promptEnd));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.NativeFieldInfoPtr_promptEnd)) = value;
    }
  }

  [Serializable]
  public class Data : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_cards;
    private static readonly System.IntPtr NativeFieldInfoPtr_items;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Data()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventRoutineCharmShop.Data>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.Data.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Data()
    {
      Il2CppClassPointerStore<EventRoutineCharmShop.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventRoutineCharmShop.Data>.NativeClassPtr);
      EventRoutineCharmShop.Data.NativeFieldInfoPtr_cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop.Data>.NativeClassPtr, nameof (cards));
      EventRoutineCharmShop.Data.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop.Data>.NativeClassPtr, nameof (items));
      EventRoutineCharmShop.Data.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop.Data>.NativeClassPtr, 100666799);
    }

    public Data(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<EventRoutineCharmShop.UpgradedCard> cards
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.Data.NativeFieldInfoPtr_cards));
        return pointer == System.IntPtr.Zero ? (List<EventRoutineCharmShop.UpgradedCard>) null : new List<EventRoutineCharmShop.UpgradedCard>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.Data.NativeFieldInfoPtr_cards), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<EventRoutineCharmShop.CharmShopItemData> items
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.Data.NativeFieldInfoPtr_items));
        return pointer == System.IntPtr.Zero ? (List<EventRoutineCharmShop.CharmShopItemData>) null : new List<EventRoutineCharmShop.CharmShopItemData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.Data.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public class UpgradedCard : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_cardDataName;
    private static readonly System.IntPtr NativeFieldInfoPtr_upgradeNames;
    private static readonly System.IntPtr NativeFieldInfoPtr_price;
    private static readonly System.IntPtr NativeFieldInfoPtr_priceFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_purchased;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UpgradedCard()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventRoutineCharmShop.UpgradedCard>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.UpgradedCard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UpgradedCard()
    {
      Il2CppClassPointerStore<EventRoutineCharmShop.UpgradedCard>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, nameof (UpgradedCard));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventRoutineCharmShop.UpgradedCard>.NativeClassPtr);
      EventRoutineCharmShop.UpgradedCard.NativeFieldInfoPtr_cardDataName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop.UpgradedCard>.NativeClassPtr, nameof (cardDataName));
      EventRoutineCharmShop.UpgradedCard.NativeFieldInfoPtr_upgradeNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop.UpgradedCard>.NativeClassPtr, nameof (upgradeNames));
      EventRoutineCharmShop.UpgradedCard.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop.UpgradedCard>.NativeClassPtr, nameof (price));
      EventRoutineCharmShop.UpgradedCard.NativeFieldInfoPtr_priceFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop.UpgradedCard>.NativeClassPtr, nameof (priceFactor));
      EventRoutineCharmShop.UpgradedCard.NativeFieldInfoPtr_purchased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop.UpgradedCard>.NativeClassPtr, nameof (purchased));
      EventRoutineCharmShop.UpgradedCard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop.UpgradedCard>.NativeClassPtr, 100666800);
    }

    public UpgradedCard(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string cardDataName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.UpgradedCard.NativeFieldInfoPtr_cardDataName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.UpgradedCard.NativeFieldInfoPtr_cardDataName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Il2CppStringArray upgradeNames
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.UpgradedCard.NativeFieldInfoPtr_upgradeNames));
        return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.UpgradedCard.NativeFieldInfoPtr_upgradeNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int price
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.UpgradedCard.NativeFieldInfoPtr_price));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.UpgradedCard.NativeFieldInfoPtr_price)) = value;
      }
    }

    public unsafe float priceFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.UpgradedCard.NativeFieldInfoPtr_priceFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.UpgradedCard.NativeFieldInfoPtr_priceFactor)) = value;
      }
    }

    public unsafe bool purchased
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.UpgradedCard.NativeFieldInfoPtr_purchased));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.UpgradedCard.NativeFieldInfoPtr_purchased)) = value;
      }
    }
  }

  [Serializable]
  public class CharmShopItemData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_upgradeDataName;
    private static readonly System.IntPtr NativeFieldInfoPtr_price;
    private static readonly System.IntPtr NativeFieldInfoPtr_priceFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_purchased;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CharmShopItemData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventRoutineCharmShop.CharmShopItemData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.CharmShopItemData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46239, XrefRangeEnd = 46242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CharmShopItemData(string upgradeDataName, int price, float priceFactor = 1f)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventRoutineCharmShop.CharmShopItemData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(upgradeDataName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &price;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &priceFactor;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.CharmShopItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CharmShopItemData()
    {
      Il2CppClassPointerStore<EventRoutineCharmShop.CharmShopItemData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, nameof (CharmShopItemData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventRoutineCharmShop.CharmShopItemData>.NativeClassPtr);
      EventRoutineCharmShop.CharmShopItemData.NativeFieldInfoPtr_upgradeDataName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop.CharmShopItemData>.NativeClassPtr, nameof (upgradeDataName));
      EventRoutineCharmShop.CharmShopItemData.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop.CharmShopItemData>.NativeClassPtr, nameof (price));
      EventRoutineCharmShop.CharmShopItemData.NativeFieldInfoPtr_priceFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop.CharmShopItemData>.NativeClassPtr, nameof (priceFactor));
      EventRoutineCharmShop.CharmShopItemData.NativeFieldInfoPtr_purchased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop.CharmShopItemData>.NativeClassPtr, nameof (purchased));
      EventRoutineCharmShop.CharmShopItemData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop.CharmShopItemData>.NativeClassPtr, 100666801);
      EventRoutineCharmShop.CharmShopItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop.CharmShopItemData>.NativeClassPtr, 100666802);
    }

    public CharmShopItemData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string upgradeDataName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.CharmShopItemData.NativeFieldInfoPtr_upgradeDataName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.CharmShopItemData.NativeFieldInfoPtr_upgradeDataName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int price
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.CharmShopItemData.NativeFieldInfoPtr_price));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.CharmShopItemData.NativeFieldInfoPtr_price)) = value;
      }
    }

    public unsafe float priceFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.CharmShopItemData.NativeFieldInfoPtr_priceFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.CharmShopItemData.NativeFieldInfoPtr_priceFactor)) = value;
      }
    }

    public unsafe bool purchased
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.CharmShopItemData.NativeFieldInfoPtr_purchased));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.CharmShopItemData.NativeFieldInfoPtr_purchased)) = value;
      }
    }
  }

  [ObfuscatedName("EventRoutineCharmShop/<>c__DisplayClass18_0")]
  public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_card;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Populate_b__0_Internal_Boolean_Entity_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass18_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventRoutineCharmShop.__c__DisplayClass18_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46242, XrefRangeEnd = 46245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Populate_b__0(Entity a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.__c__DisplayClass18_0.NativeMethodInfoPtr__Populate_b__0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass18_0()
    {
      Il2CppClassPointerStore<EventRoutineCharmShop.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, "<>c__DisplayClass18_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventRoutineCharmShop.__c__DisplayClass18_0>.NativeClassPtr);
      EventRoutineCharmShop.__c__DisplayClass18_0.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop.__c__DisplayClass18_0>.NativeClassPtr, nameof (card));
      EventRoutineCharmShop.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop.__c__DisplayClass18_0>.NativeClassPtr, 100666803);
      EventRoutineCharmShop.__c__DisplayClass18_0.NativeMethodInfoPtr__Populate_b__0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop.__c__DisplayClass18_0>.NativeClassPtr, 100666804);
    }

    public __c__DisplayClass18_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EventRoutineCharmShop.UpgradedCard card
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.__c__DisplayClass18_0.NativeFieldInfoPtr_card));
        return pointer == System.IntPtr.Zero ? (EventRoutineCharmShop.UpgradedCard) null : new EventRoutineCharmShop.UpgradedCard(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.__c__DisplayClass18_0.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("EventRoutineCharmShop/<Populate>d__18")]
  public sealed class _Populate_d__18 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__shopData_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Populate_d__18(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventRoutineCharmShop._Populate_d__18>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop._Populate_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 46252, RefRangeEnd = 46253, XrefRangeStart = 46245, XrefRangeEnd = 46252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop._Populate_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46253, XrefRangeEnd = 46374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop._Populate_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46374, XrefRangeEnd = 46377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __m__Finally1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop._Populate_d__18.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop._Populate_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46377, XrefRangeEnd = 46383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop._Populate_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop._Populate_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Populate_d__18()
    {
      Il2CppClassPointerStore<EventRoutineCharmShop._Populate_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, "<Populate>d__18");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventRoutineCharmShop._Populate_d__18>.NativeClassPtr);
      EventRoutineCharmShop._Populate_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop._Populate_d__18>.NativeClassPtr, "<>1__state");
      EventRoutineCharmShop._Populate_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop._Populate_d__18>.NativeClassPtr, "<>2__current");
      EventRoutineCharmShop._Populate_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop._Populate_d__18>.NativeClassPtr, "<>4__this");
      EventRoutineCharmShop._Populate_d__18.NativeFieldInfoPtr__shopData_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop._Populate_d__18>.NativeClassPtr, "<shopData>5__2");
      EventRoutineCharmShop._Populate_d__18.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop._Populate_d__18>.NativeClassPtr, "<>7__wrap2");
      EventRoutineCharmShop._Populate_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop._Populate_d__18>.NativeClassPtr, 100666805);
      EventRoutineCharmShop._Populate_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop._Populate_d__18>.NativeClassPtr, 100666806);
      EventRoutineCharmShop._Populate_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop._Populate_d__18>.NativeClassPtr, 100666807);
      EventRoutineCharmShop._Populate_d__18.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop._Populate_d__18>.NativeClassPtr, 100666808);
      EventRoutineCharmShop._Populate_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop._Populate_d__18>.NativeClassPtr, 100666809);
      EventRoutineCharmShop._Populate_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop._Populate_d__18>.NativeClassPtr, 100666810);
      EventRoutineCharmShop._Populate_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop._Populate_d__18>.NativeClassPtr, 100666811);
    }

    public _Populate_d__18(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop._Populate_d__18.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop._Populate_d__18.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop._Populate_d__18.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop._Populate_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EventRoutineCharmShop __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop._Populate_d__18.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (EventRoutineCharmShop) null : new EventRoutineCharmShop(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop._Populate_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EventRoutineCharmShop.Data _shopData_5__2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop._Populate_d__18.NativeFieldInfoPtr__shopData_5__2));
        return pointer == System.IntPtr.Zero ? (EventRoutineCharmShop.Data) null : new EventRoutineCharmShop.Data(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop._Populate_d__18.NativeFieldInfoPtr__shopData_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public List<EventRoutineCharmShop.UpgradedCard>.Enumerator __7__wrap2
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop._Populate_d__18.NativeFieldInfoPtr___7__wrap2);
        return new List<EventRoutineCharmShop.UpgradedCard>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<EventRoutineCharmShop.UpgradedCard>.Enumerator>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop._Populate_d__18.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<EventRoutineCharmShop.UpgradedCard>.Enumerator>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("EventRoutineCharmShop/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__19_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__25_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Run_b__19_0_Internal_Boolean_CharmShopItemData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CreateUpgrade_b__25_0_Internal_Boolean_CardCharmHolder_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventRoutineCharmShop.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Run_b__19_0(EventRoutineCharmShop.CharmShopItemData i)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) i)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.__c.NativeMethodInfoPtr__Run_b__19_0_Internal_Boolean_CharmShopItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46383, XrefRangeEnd = 46385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _CreateUpgrade_b__25_0(CardCharmHolder a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.__c.NativeMethodInfoPtr__CreateUpgrade_b__25_0_Internal_Boolean_CardCharmHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<EventRoutineCharmShop.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventRoutineCharmShop.__c>.NativeClassPtr);
      EventRoutineCharmShop.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop.__c>.NativeClassPtr, "<>9");
      EventRoutineCharmShop.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop.__c>.NativeClassPtr, "<>9__19_0");
      EventRoutineCharmShop.__c.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop.__c>.NativeClassPtr, "<>9__25_0");
      EventRoutineCharmShop.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop.__c>.NativeClassPtr, 100666813);
      EventRoutineCharmShop.__c.NativeMethodInfoPtr__Run_b__19_0_Internal_Boolean_CharmShopItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop.__c>.NativeClassPtr, 100666814);
      EventRoutineCharmShop.__c.NativeMethodInfoPtr__CreateUpgrade_b__25_0_Internal_Boolean_CardCharmHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop.__c>.NativeClassPtr, 100666815);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe EventRoutineCharmShop.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(EventRoutineCharmShop.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (EventRoutineCharmShop.__c) null : new EventRoutineCharmShop.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EventRoutineCharmShop.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<EventRoutineCharmShop.CharmShopItemData, bool> __9__19_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(EventRoutineCharmShop.__c.NativeFieldInfoPtr___9__19_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<EventRoutineCharmShop.CharmShopItemData, bool>) null : new Il2CppSystem.Func<EventRoutineCharmShop.CharmShopItemData, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EventRoutineCharmShop.__c.NativeFieldInfoPtr___9__19_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardCharmHolder, bool> __9__25_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(EventRoutineCharmShop.__c.NativeFieldInfoPtr___9__25_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardCharmHolder, bool>) null : new Il2CppSystem.Func<CardCharmHolder, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EventRoutineCharmShop.__c.NativeFieldInfoPtr___9__25_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("EventRoutineCharmShop/<Run>d__19")]
  public sealed class _Run_d__19 : Il2CppSystem.Object
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
    public unsafe _Run_d__19(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventRoutineCharmShop._Run_d__19>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop._Run_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop._Run_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46385, XrefRangeEnd = 46490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop._Run_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop._Run_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46490, XrefRangeEnd = 46496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop._Run_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop._Run_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Run_d__19()
    {
      Il2CppClassPointerStore<EventRoutineCharmShop._Run_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, "<Run>d__19");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventRoutineCharmShop._Run_d__19>.NativeClassPtr);
      EventRoutineCharmShop._Run_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop._Run_d__19>.NativeClassPtr, "<>1__state");
      EventRoutineCharmShop._Run_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop._Run_d__19>.NativeClassPtr, "<>2__current");
      EventRoutineCharmShop._Run_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop._Run_d__19>.NativeClassPtr, "<>4__this");
      EventRoutineCharmShop._Run_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop._Run_d__19>.NativeClassPtr, 100666816);
      EventRoutineCharmShop._Run_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop._Run_d__19>.NativeClassPtr, 100666817);
      EventRoutineCharmShop._Run_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop._Run_d__19>.NativeClassPtr, 100666818);
      EventRoutineCharmShop._Run_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop._Run_d__19>.NativeClassPtr, 100666819);
      EventRoutineCharmShop._Run_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop._Run_d__19>.NativeClassPtr, 100666820);
      EventRoutineCharmShop._Run_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop._Run_d__19>.NativeClassPtr, 100666821);
    }

    public _Run_d__19(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop._Run_d__19.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop._Run_d__19.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop._Run_d__19.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop._Run_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EventRoutineCharmShop __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop._Run_d__19.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (EventRoutineCharmShop) null : new EventRoutineCharmShop(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop._Run_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("EventRoutineCharmShop/<>c__DisplayClass21_0")]
  public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_entity;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TryBuy_b__0_Internal_Boolean_UpgradedCard_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass21_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventRoutineCharmShop.__c__DisplayClass21_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46496, XrefRangeEnd = 46499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _TryBuy_b__0(EventRoutineCharmShop.UpgradedCard a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.__c__DisplayClass21_0.NativeMethodInfoPtr__TryBuy_b__0_Internal_Boolean_UpgradedCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass21_0()
    {
      Il2CppClassPointerStore<EventRoutineCharmShop.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, "<>c__DisplayClass21_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventRoutineCharmShop.__c__DisplayClass21_0>.NativeClassPtr);
      EventRoutineCharmShop.__c__DisplayClass21_0.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop.__c__DisplayClass21_0>.NativeClassPtr, nameof (entity));
      EventRoutineCharmShop.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop.__c__DisplayClass21_0>.NativeClassPtr, 100666822);
      EventRoutineCharmShop.__c__DisplayClass21_0.NativeMethodInfoPtr__TryBuy_b__0_Internal_Boolean_UpgradedCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop.__c__DisplayClass21_0>.NativeClassPtr, 100666823);
    }

    public __c__DisplayClass21_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Entity entity
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.__c__DisplayClass21_0.NativeFieldInfoPtr_entity));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.__c__DisplayClass21_0.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("EventRoutineCharmShop/<>c__DisplayClass25_0")]
  public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_shopItem;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CreateUpgrade_b__1_Internal_Void_UpgradeDisplay_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CreateUpgrade_b__2_Internal_Void_UpgradeDisplay_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CreateUpgrade_b__3_Internal_Void_UpgradeDisplay_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass25_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventRoutineCharmShop.__c__DisplayClass25_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46499, XrefRangeEnd = 46501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _CreateUpgrade_b__1(UpgradeDisplay _)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.__c__DisplayClass25_0.NativeMethodInfoPtr__CreateUpgrade_b__1_Internal_Void_UpgradeDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46501, XrefRangeEnd = 46503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _CreateUpgrade_b__2(UpgradeDisplay _)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.__c__DisplayClass25_0.NativeMethodInfoPtr__CreateUpgrade_b__2_Internal_Void_UpgradeDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46503, XrefRangeEnd = 46505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _CreateUpgrade_b__3(UpgradeDisplay _)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventRoutineCharmShop.__c__DisplayClass25_0.NativeMethodInfoPtr__CreateUpgrade_b__3_Internal_Void_UpgradeDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass25_0()
    {
      Il2CppClassPointerStore<EventRoutineCharmShop.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventRoutineCharmShop>.NativeClassPtr, "<>c__DisplayClass25_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventRoutineCharmShop.__c__DisplayClass25_0>.NativeClassPtr);
      EventRoutineCharmShop.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop.__c__DisplayClass25_0>.NativeClassPtr, "<>4__this");
      EventRoutineCharmShop.__c__DisplayClass25_0.NativeFieldInfoPtr_shopItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutineCharmShop.__c__DisplayClass25_0>.NativeClassPtr, nameof (shopItem));
      EventRoutineCharmShop.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop.__c__DisplayClass25_0>.NativeClassPtr, 100666824);
      EventRoutineCharmShop.__c__DisplayClass25_0.NativeMethodInfoPtr__CreateUpgrade_b__1_Internal_Void_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop.__c__DisplayClass25_0>.NativeClassPtr, 100666825);
      EventRoutineCharmShop.__c__DisplayClass25_0.NativeMethodInfoPtr__CreateUpgrade_b__2_Internal_Void_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop.__c__DisplayClass25_0>.NativeClassPtr, 100666826);
      EventRoutineCharmShop.__c__DisplayClass25_0.NativeMethodInfoPtr__CreateUpgrade_b__3_Internal_Void_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutineCharmShop.__c__DisplayClass25_0>.NativeClassPtr, 100666827);
    }

    public __c__DisplayClass25_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EventRoutineCharmShop __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (EventRoutineCharmShop) null : new EventRoutineCharmShop(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ShopItem shopItem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.__c__DisplayClass25_0.NativeFieldInfoPtr_shopItem));
        return pointer == System.IntPtr.Zero ? (ShopItem) null : new ShopItem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutineCharmShop.__c__DisplayClass25_0.NativeFieldInfoPtr_shopItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
