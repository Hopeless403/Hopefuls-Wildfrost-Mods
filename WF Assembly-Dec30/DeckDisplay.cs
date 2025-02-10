// Decompiled with JetBrains decompiler
// Type: DeckDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class DeckDisplay : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_owner;
  private static readonly IntPtr NativeFieldInfoPtr_displaySequence;
  private static readonly IntPtr NativeFieldInfoPtr_companionLimitSequence;
  private static readonly IntPtr NativeFieldInfoPtr_companionRecoverSequence;
  private static readonly IntPtr NativeFieldInfoPtr_cardControllers;
  private static readonly IntPtr NativeFieldInfoPtr_cardContainers;
  private static readonly IntPtr NativeFieldInfoPtr_backButtonNavigationItem;
  private static readonly IntPtr NativeMethodInfoPtr_SetOwner_Public_Void_Character_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 42712, RefRangeEnd = 42713, XrefRangeStart = 42697, XrefRangeEnd = 42712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetOwner(Character owner)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) owner)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeckDisplay.NativeMethodInfoPtr_SetOwner_Public_Void_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DeckDisplay()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeckDisplay>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeckDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static DeckDisplay()
  {
    Il2CppClassPointerStore<DeckDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (DeckDisplay));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeckDisplay>.NativeClassPtr);
    DeckDisplay.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckDisplay>.NativeClassPtr, nameof (owner));
    DeckDisplay.NativeFieldInfoPtr_displaySequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckDisplay>.NativeClassPtr, nameof (displaySequence));
    DeckDisplay.NativeFieldInfoPtr_companionLimitSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckDisplay>.NativeClassPtr, nameof (companionLimitSequence));
    DeckDisplay.NativeFieldInfoPtr_companionRecoverSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckDisplay>.NativeClassPtr, nameof (companionRecoverSequence));
    DeckDisplay.NativeFieldInfoPtr_cardControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckDisplay>.NativeClassPtr, nameof (cardControllers));
    DeckDisplay.NativeFieldInfoPtr_cardContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckDisplay>.NativeClassPtr, nameof (cardContainers));
    DeckDisplay.NativeFieldInfoPtr_backButtonNavigationItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckDisplay>.NativeClassPtr, nameof (backButtonNavigationItem));
    DeckDisplay.NativeMethodInfoPtr_SetOwner_Public_Void_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckDisplay>.NativeClassPtr, 100666465);
    DeckDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckDisplay>.NativeClassPtr, 100666466);
  }

  public DeckDisplay(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Character owner
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckDisplay.NativeFieldInfoPtr_owner));
      return pointer == IntPtr.Zero ? (Character) null : new Character(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckDisplay.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DeckDisplaySequence displaySequence
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckDisplay.NativeFieldInfoPtr_displaySequence));
      return pointer == IntPtr.Zero ? (DeckDisplaySequence) null : new DeckDisplaySequence(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckDisplay.NativeFieldInfoPtr_displaySequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CompanionLimitSequence companionLimitSequence
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckDisplay.NativeFieldInfoPtr_companionLimitSequence));
      return pointer == IntPtr.Zero ? (CompanionLimitSequence) null : new CompanionLimitSequence(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckDisplay.NativeFieldInfoPtr_companionLimitSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CompanionRecoverSequence companionRecoverSequence
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckDisplay.NativeFieldInfoPtr_companionRecoverSequence));
      return pointer == IntPtr.Zero ? (CompanionRecoverSequence) null : new CompanionRecoverSequence(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckDisplay.NativeFieldInfoPtr_companionRecoverSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardController> cardControllers
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckDisplay.NativeFieldInfoPtr_cardControllers));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<CardController>) null : new Il2CppReferenceArray<CardController>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckDisplay.NativeFieldInfoPtr_cardControllers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardContainer> cardContainers
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckDisplay.NativeFieldInfoPtr_cardContainers));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<CardContainer>) null : new Il2CppReferenceArray<CardContainer>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckDisplay.NativeFieldInfoPtr_cardContainers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UINavigationItem backButtonNavigationItem
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckDisplay.NativeFieldInfoPtr_backButtonNavigationItem));
      return pointer == IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckDisplay.NativeFieldInfoPtr_backButtonNavigationItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
