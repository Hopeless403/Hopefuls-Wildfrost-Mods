// Decompiled with JetBrains decompiler
// Type: CardTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class CardTooltip : Tooltip
{
  private static readonly IntPtr NativeFieldInfoPtr_titleElement;
  private static readonly IntPtr NativeFieldInfoPtr_descElement;
  private static readonly IntPtr NativeFieldInfoPtr_cardArt;
  private static readonly IntPtr NativeFieldInfoPtr_textBox;
  private static readonly IntPtr NativeFieldInfoPtr_nameTag;
  private static readonly IntPtr NativeFieldInfoPtr_healthIconGroup;
  private static readonly IntPtr NativeFieldInfoPtr_damageIconGroup;
  private static readonly IntPtr NativeFieldInfoPtr_counterIconGroup;
  private static readonly IntPtr NativeFieldInfoPtr_crownIconGroup;
  private static readonly IntPtr NativeFieldInfoPtr_iconGroups;
  private static readonly IntPtr NativeFieldInfoPtr_keywords;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateIcon_Private_Void_String_String_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95872, XrefRangeEnd = 95902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardTooltip.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 95940, RefRangeEnd = 95943, XrefRangeStart = 95902, XrefRangeEnd = 95940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(CardData data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardTooltip.NativeMethodInfoPtr_Set_Public_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 95952, RefRangeEnd = 95956, XrefRangeStart = 95943, XrefRangeEnd = 95952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateIcon(string type, string iconGroupName, int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(type);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(iconGroupName);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardTooltip.NativeMethodInfoPtr_CreateIcon_Private_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95956, XrefRangeEnd = 95965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardTooltip()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardTooltip>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardTooltip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardTooltip()
  {
    Il2CppClassPointerStore<CardTooltip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardTooltip));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardTooltip>.NativeClassPtr);
    CardTooltip.NativeFieldInfoPtr_titleElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardTooltip>.NativeClassPtr, nameof (titleElement));
    CardTooltip.NativeFieldInfoPtr_descElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardTooltip>.NativeClassPtr, nameof (descElement));
    CardTooltip.NativeFieldInfoPtr_cardArt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardTooltip>.NativeClassPtr, nameof (cardArt));
    CardTooltip.NativeFieldInfoPtr_textBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardTooltip>.NativeClassPtr, nameof (textBox));
    CardTooltip.NativeFieldInfoPtr_nameTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardTooltip>.NativeClassPtr, nameof (nameTag));
    CardTooltip.NativeFieldInfoPtr_healthIconGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardTooltip>.NativeClassPtr, nameof (healthIconGroup));
    CardTooltip.NativeFieldInfoPtr_damageIconGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardTooltip>.NativeClassPtr, nameof (damageIconGroup));
    CardTooltip.NativeFieldInfoPtr_counterIconGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardTooltip>.NativeClassPtr, nameof (counterIconGroup));
    CardTooltip.NativeFieldInfoPtr_crownIconGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardTooltip>.NativeClassPtr, nameof (crownIconGroup));
    CardTooltip.NativeFieldInfoPtr_iconGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardTooltip>.NativeClassPtr, nameof (iconGroups));
    CardTooltip.NativeFieldInfoPtr_keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardTooltip>.NativeClassPtr, nameof (keywords));
    CardTooltip.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardTooltip>.NativeClassPtr, 100671661);
    CardTooltip.NativeMethodInfoPtr_Set_Public_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardTooltip>.NativeClassPtr, 100671662);
    CardTooltip.NativeMethodInfoPtr_CreateIcon_Private_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardTooltip>.NativeClassPtr, 100671663);
    CardTooltip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardTooltip>.NativeClassPtr, 100671664);
  }

  public CardTooltip(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe TMP_Text titleElement
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardTooltip.NativeFieldInfoPtr_titleElement));
      return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardTooltip.NativeFieldInfoPtr_titleElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text descElement
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardTooltip.NativeFieldInfoPtr_descElement));
      return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardTooltip.NativeFieldInfoPtr_descElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image cardArt
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardTooltip.NativeFieldInfoPtr_cardArt));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardTooltip.NativeFieldInfoPtr_cardArt), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image textBox
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardTooltip.NativeFieldInfoPtr_textBox));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardTooltip.NativeFieldInfoPtr_textBox), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image nameTag
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardTooltip.NativeFieldInfoPtr_nameTag));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardTooltip.NativeFieldInfoPtr_nameTag), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform healthIconGroup
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardTooltip.NativeFieldInfoPtr_healthIconGroup));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardTooltip.NativeFieldInfoPtr_healthIconGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform damageIconGroup
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardTooltip.NativeFieldInfoPtr_damageIconGroup));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardTooltip.NativeFieldInfoPtr_damageIconGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform counterIconGroup
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardTooltip.NativeFieldInfoPtr_counterIconGroup));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardTooltip.NativeFieldInfoPtr_counterIconGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform crownIconGroup
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardTooltip.NativeFieldInfoPtr_crownIconGroup));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardTooltip.NativeFieldInfoPtr_crownIconGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, Transform> iconGroups
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardTooltip.NativeFieldInfoPtr_iconGroups));
      return pointer == IntPtr.Zero ? (Dictionary<string, Transform>) null : new Dictionary<string, Transform>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardTooltip.NativeFieldInfoPtr_iconGroups), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe HashSet<KeywordData> keywords
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardTooltip.NativeFieldInfoPtr_keywords));
      return pointer == IntPtr.Zero ? (HashSet<KeywordData>) null : new HashSet<KeywordData>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardTooltip.NativeFieldInfoPtr_keywords), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
