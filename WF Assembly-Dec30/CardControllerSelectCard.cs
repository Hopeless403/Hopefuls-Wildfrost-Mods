// Decompiled with JetBrains decompiler
// Type: CardControllerSelectCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class CardControllerSelectCard : CardController
{
  private static readonly IntPtr NativeFieldInfoPtr_cardPressScaleFrom;
  private static readonly IntPtr NativeFieldInfoPtr_cardPressScaleTo;
  private static readonly IntPtr NativeFieldInfoPtr_cardPressEase;
  private static readonly IntPtr NativeFieldInfoPtr_cardPressEaseDur;
  private static readonly IntPtr NativeFieldInfoPtr_cardPressWobble;
  private static readonly IntPtr NativeFieldInfoPtr_pressEvent;
  private static readonly IntPtr NativeFieldInfoPtr_hoverEvent;
  private static readonly IntPtr NativeFieldInfoPtr_unHoverEvent;
  private static readonly IntPtr NativeMethodInfoPtr_get_AllowDynamicSelectRelease_Protected_Virtual_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Press_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Release_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CardHover_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_CardUnHover_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public override unsafe bool AllowDynamicSelectRelease
  {
    [CallerCount(126), CachedScanResults(RefRangeStart = 15285, RefRangeEnd = 15411, XrefRangeStart = 15285, XrefRangeEnd = 15411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardControllerSelectCard.NativeMethodInfoPtr_get_AllowDynamicSelectRelease_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33925, XrefRangeEnd = 33939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardControllerSelectCard.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33939, XrefRangeEnd = 33953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardControllerSelectCard.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33953, XrefRangeEnd = 33980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Press()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardControllerSelectCard.NativeMethodInfoPtr_Press_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33980, XrefRangeEnd = 33998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardControllerSelectCard.NativeMethodInfoPtr_Release_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33998, XrefRangeEnd = 34002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CardHover(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardControllerSelectCard.NativeMethodInfoPtr_CardHover_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34002, XrefRangeEnd = 34006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CardUnHover(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardControllerSelectCard.NativeMethodInfoPtr_CardUnHover_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34006, XrefRangeEnd = 34007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardControllerSelectCard()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardControllerSelectCard>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardControllerSelectCard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardControllerSelectCard()
  {
    Il2CppClassPointerStore<CardControllerSelectCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardControllerSelectCard));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardControllerSelectCard>.NativeClassPtr);
    CardControllerSelectCard.NativeFieldInfoPtr_cardPressScaleFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardControllerSelectCard>.NativeClassPtr, nameof (cardPressScaleFrom));
    CardControllerSelectCard.NativeFieldInfoPtr_cardPressScaleTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardControllerSelectCard>.NativeClassPtr, nameof (cardPressScaleTo));
    CardControllerSelectCard.NativeFieldInfoPtr_cardPressEase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardControllerSelectCard>.NativeClassPtr, nameof (cardPressEase));
    CardControllerSelectCard.NativeFieldInfoPtr_cardPressEaseDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardControllerSelectCard>.NativeClassPtr, nameof (cardPressEaseDur));
    CardControllerSelectCard.NativeFieldInfoPtr_cardPressWobble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardControllerSelectCard>.NativeClassPtr, nameof (cardPressWobble));
    CardControllerSelectCard.NativeFieldInfoPtr_pressEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardControllerSelectCard>.NativeClassPtr, nameof (pressEvent));
    CardControllerSelectCard.NativeFieldInfoPtr_hoverEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardControllerSelectCard>.NativeClassPtr, nameof (hoverEvent));
    CardControllerSelectCard.NativeFieldInfoPtr_unHoverEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardControllerSelectCard>.NativeClassPtr, nameof (unHoverEvent));
    CardControllerSelectCard.NativeMethodInfoPtr_get_AllowDynamicSelectRelease_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerSelectCard>.NativeClassPtr, 100665443);
    CardControllerSelectCard.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerSelectCard>.NativeClassPtr, 100665444);
    CardControllerSelectCard.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerSelectCard>.NativeClassPtr, 100665445);
    CardControllerSelectCard.NativeMethodInfoPtr_Press_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerSelectCard>.NativeClassPtr, 100665446);
    CardControllerSelectCard.NativeMethodInfoPtr_Release_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerSelectCard>.NativeClassPtr, 100665447);
    CardControllerSelectCard.NativeMethodInfoPtr_CardHover_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerSelectCard>.NativeClassPtr, 100665448);
    CardControllerSelectCard.NativeMethodInfoPtr_CardUnHover_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerSelectCard>.NativeClassPtr, 100665449);
    CardControllerSelectCard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerSelectCard>.NativeClassPtr, 100665450);
  }

  public CardControllerSelectCard(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float cardPressScaleFrom
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerSelectCard.NativeFieldInfoPtr_cardPressScaleFrom));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerSelectCard.NativeFieldInfoPtr_cardPressScaleFrom)) = value;
    }
  }

  public unsafe float cardPressScaleTo
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerSelectCard.NativeFieldInfoPtr_cardPressScaleTo));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerSelectCard.NativeFieldInfoPtr_cardPressScaleTo)) = value;
    }
  }

  public unsafe LeanTweenType cardPressEase
  {
    get
    {
      return *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerSelectCard.NativeFieldInfoPtr_cardPressEase));
    }
    [param: In] set
    {
      *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerSelectCard.NativeFieldInfoPtr_cardPressEase)) = value;
    }
  }

  public unsafe float cardPressEaseDur
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerSelectCard.NativeFieldInfoPtr_cardPressEaseDur));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerSelectCard.NativeFieldInfoPtr_cardPressEaseDur)) = value;
    }
  }

  public unsafe float cardPressWobble
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerSelectCard.NativeFieldInfoPtr_cardPressWobble));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerSelectCard.NativeFieldInfoPtr_cardPressWobble)) = value;
    }
  }

  public unsafe UnityEventEntity pressEvent
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerSelectCard.NativeFieldInfoPtr_pressEvent));
      return pointer == IntPtr.Zero ? (UnityEventEntity) null : new UnityEventEntity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardControllerSelectCard.NativeFieldInfoPtr_pressEvent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEventEntity hoverEvent
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerSelectCard.NativeFieldInfoPtr_hoverEvent));
      return pointer == IntPtr.Zero ? (UnityEventEntity) null : new UnityEventEntity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardControllerSelectCard.NativeFieldInfoPtr_hoverEvent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEventEntity unHoverEvent
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerSelectCard.NativeFieldInfoPtr_unHoverEvent));
      return pointer == IntPtr.Zero ? (UnityEventEntity) null : new UnityEventEntity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardControllerSelectCard.NativeFieldInfoPtr_unHoverEvent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
