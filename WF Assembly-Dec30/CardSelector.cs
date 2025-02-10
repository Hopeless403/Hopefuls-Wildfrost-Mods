// Decompiled with JetBrains decompiler
// Type: CardSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class CardSelector : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_character;
  private static readonly IntPtr NativeFieldInfoPtr_selectEvent;
  private static readonly IntPtr NativeMethodInfoPtr_TakeCard_Public_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_TakeFirstCard_Public_Void_CardContainer_0;
  private static readonly IntPtr NativeMethodInfoPtr_MoveCardToDeck_Public_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 37083, RefRangeEnd = 37090, XrefRangeStart = 37025, XrefRangeEnd = 37083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TakeCard(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardSelector.NativeMethodInfoPtr_TakeCard_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37090, XrefRangeEnd = 37091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TakeFirstCard(CardContainer cardContainer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardContainer)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardSelector.NativeMethodInfoPtr_TakeFirstCard_Public_Void_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37091, XrefRangeEnd = 37110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveCardToDeck(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardSelector.NativeMethodInfoPtr_MoveCardToDeck_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardSelector()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardSelector>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardSelector()
  {
    Il2CppClassPointerStore<CardSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardSelector));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardSelector>.NativeClassPtr);
    CardSelector.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardSelector>.NativeClassPtr, nameof (character));
    CardSelector.NativeFieldInfoPtr_selectEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardSelector>.NativeClassPtr, nameof (selectEvent));
    CardSelector.NativeMethodInfoPtr_TakeCard_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardSelector>.NativeClassPtr, 100665781);
    CardSelector.NativeMethodInfoPtr_TakeFirstCard_Public_Void_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardSelector>.NativeClassPtr, 100665782);
    CardSelector.NativeMethodInfoPtr_MoveCardToDeck_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardSelector>.NativeClassPtr, 100665783);
    CardSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardSelector>.NativeClassPtr, 100665784);
  }

  public CardSelector(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Character character
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardSelector.NativeFieldInfoPtr_character));
      return pointer == IntPtr.Zero ? (Character) null : new Character(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardSelector.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEventEntity selectEvent
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardSelector.NativeFieldInfoPtr_selectEvent));
      return pointer == IntPtr.Zero ? (UnityEventEntity) null : new UnityEventEntity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardSelector.NativeFieldInfoPtr_selectEvent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
