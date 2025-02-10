// Decompiled with JetBrains decompiler
// Type: CardPopUpTarget
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
public class CardPopUpTarget : MonoBehaviourRect
{
  private static readonly IntPtr NativeFieldInfoPtr_popped;
  private static readonly IntPtr NativeFieldInfoPtr_card;
  private static readonly IntPtr NativeFieldInfoPtr_keywords;
  private static readonly IntPtr NativeFieldInfoPtr_posX;
  private static readonly IntPtr NativeFieldInfoPtr_posY;
  private static readonly IntPtr NativeFieldInfoPtr_current;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsCard_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnPop_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe bool IsCard
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36823, XrefRangeEnd = 36827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardPopUpTarget.NativeMethodInfoPtr_get_IsCard_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 36888, RefRangeEnd = 36890, XrefRangeStart = 36827, XrefRangeEnd = 36888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Pop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUpTarget.NativeMethodInfoPtr_Pop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 36909, RefRangeEnd = 36911, XrefRangeStart = 36890, XrefRangeEnd = 36909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnPop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUpTarget.NativeMethodInfoPtr_UnPop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36911, XrefRangeEnd = 36915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUpTarget.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36915, XrefRangeEnd = 36924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardPopUpTarget()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardPopUpTarget>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUpTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardPopUpTarget()
  {
    Il2CppClassPointerStore<CardPopUpTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardPopUpTarget));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardPopUpTarget>.NativeClassPtr);
    CardPopUpTarget.NativeFieldInfoPtr_popped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUpTarget>.NativeClassPtr, nameof (popped));
    CardPopUpTarget.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUpTarget>.NativeClassPtr, nameof (card));
    CardPopUpTarget.NativeFieldInfoPtr_keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUpTarget>.NativeClassPtr, nameof (keywords));
    CardPopUpTarget.NativeFieldInfoPtr_posX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUpTarget>.NativeClassPtr, nameof (posX));
    CardPopUpTarget.NativeFieldInfoPtr_posY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUpTarget>.NativeClassPtr, nameof (posY));
    CardPopUpTarget.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUpTarget>.NativeClassPtr, nameof (current));
    CardPopUpTarget.NativeMethodInfoPtr_get_IsCard_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUpTarget>.NativeClassPtr, 100665742);
    CardPopUpTarget.NativeMethodInfoPtr_Pop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUpTarget>.NativeClassPtr, 100665743);
    CardPopUpTarget.NativeMethodInfoPtr_UnPop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUpTarget>.NativeClassPtr, 100665744);
    CardPopUpTarget.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUpTarget>.NativeClassPtr, 100665745);
    CardPopUpTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUpTarget>.NativeClassPtr, 100665746);
  }

  public CardPopUpTarget(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool popped
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpTarget.NativeFieldInfoPtr_popped));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpTarget.NativeFieldInfoPtr_popped)) = value;
    }
  }

  public unsafe Card card
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpTarget.NativeFieldInfoPtr_card));
      return pointer == IntPtr.Zero ? (Card) null : new Card(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpTarget.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<KeywordData> keywords
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpTarget.NativeFieldInfoPtr_keywords));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<KeywordData>) null : new Il2CppReferenceArray<KeywordData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpTarget.NativeFieldInfoPtr_keywords), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float posX
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpTarget.NativeFieldInfoPtr_posX));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpTarget.NativeFieldInfoPtr_posX)) = value;
    }
  }

  public unsafe float posY
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpTarget.NativeFieldInfoPtr_posY));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpTarget.NativeFieldInfoPtr_posY)) = value;
    }
  }

  public unsafe HashSet<string> current
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpTarget.NativeFieldInfoPtr_current));
      return pointer == IntPtr.Zero ? (HashSet<string>) null : new HashSet<string>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpTarget.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
