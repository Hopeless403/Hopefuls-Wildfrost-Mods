// Decompiled with JetBrains decompiler
// Type: CardType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;

#nullable disable
public class CardType : DataFile
{
  private static readonly IntPtr NativeFieldInfoPtr_sortPriority;
  private static readonly IntPtr NativeFieldInfoPtr_icon;
  private static readonly IntPtr NativeFieldInfoPtr_prefabRef;
  private static readonly IntPtr NativeFieldInfoPtr_textBoxSprite;
  private static readonly IntPtr NativeFieldInfoPtr_nameTagSprite;
  private static readonly IntPtr NativeFieldInfoPtr_titleKey;
  private static readonly IntPtr NativeFieldInfoPtr_canDie;
  private static readonly IntPtr NativeFieldInfoPtr_canTakeCrown;
  private static readonly IntPtr NativeFieldInfoPtr_canRecall;
  private static readonly IntPtr NativeFieldInfoPtr_canReserve;
  private static readonly IntPtr NativeFieldInfoPtr_item;
  private static readonly IntPtr NativeFieldInfoPtr_unit;
  private static readonly IntPtr NativeFieldInfoPtr_tag;
  private static readonly IntPtr NativeFieldInfoPtr_miniboss;
  private static readonly IntPtr NativeFieldInfoPtr_discoverInJournal;
  private static readonly IntPtr NativeFieldInfoPtr_descriptionColours;
  private static readonly IntPtr NativeMethodInfoPtr_get_title_Public_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe string title
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 108515, RefRangeEnd = 108517, XrefRangeStart = 108513, XrefRangeEnd = 108515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CardType.NativeMethodInfoPtr_get_title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
  }

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardType()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardType>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardType()
  {
    Il2CppClassPointerStore<CardType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardType));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardType>.NativeClassPtr);
    CardType.NativeFieldInfoPtr_sortPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, nameof (sortPriority));
    CardType.NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, nameof (icon));
    CardType.NativeFieldInfoPtr_prefabRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, nameof (prefabRef));
    CardType.NativeFieldInfoPtr_textBoxSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, nameof (textBoxSprite));
    CardType.NativeFieldInfoPtr_nameTagSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, nameof (nameTagSprite));
    CardType.NativeFieldInfoPtr_titleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, nameof (titleKey));
    CardType.NativeFieldInfoPtr_canDie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, nameof (canDie));
    CardType.NativeFieldInfoPtr_canTakeCrown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, nameof (canTakeCrown));
    CardType.NativeFieldInfoPtr_canRecall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, nameof (canRecall));
    CardType.NativeFieldInfoPtr_canReserve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, nameof (canReserve));
    CardType.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, nameof (item));
    CardType.NativeFieldInfoPtr_unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, nameof (unit));
    CardType.NativeFieldInfoPtr_tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, nameof (tag));
    CardType.NativeFieldInfoPtr_miniboss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, nameof (miniboss));
    CardType.NativeFieldInfoPtr_discoverInJournal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, nameof (discoverInJournal));
    CardType.NativeFieldInfoPtr_descriptionColours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, nameof (descriptionColours));
    CardType.NativeMethodInfoPtr_get_title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardType>.NativeClassPtr, 100673286);
    CardType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardType>.NativeClassPtr, 100673287);
  }

  public CardType(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int sortPriority
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_sortPriority));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_sortPriority)) = value;
    }
  }

  public unsafe Sprite icon
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_icon));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AssetReference prefabRef
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_prefabRef));
      return pointer == IntPtr.Zero ? (AssetReference) null : new AssetReference(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_prefabRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite textBoxSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_textBoxSprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_textBoxSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite nameTagSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_nameTagSprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_nameTagSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString titleKey
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_titleKey));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_titleKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool canDie
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_canDie));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_canDie)) = value;
    }
  }

  public unsafe bool canTakeCrown
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_canTakeCrown));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_canTakeCrown)) = value;
    }
  }

  public unsafe bool canRecall
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_canRecall));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_canRecall)) = value;
    }
  }

  public unsafe bool canReserve
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_canReserve));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_canReserve)) = value;
    }
  }

  public unsafe bool item
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_item));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_item)) = value;
    }
  }

  public unsafe bool unit
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_unit));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_unit)) = value;
    }
  }

  public unsafe string tag
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_tag)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_tag), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool miniboss
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_miniboss));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_miniboss)) = value;
    }
  }

  public unsafe bool discoverInJournal
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_discoverInJournal));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_discoverInJournal)) = value;
    }
  }

  public Text.ColourProfileHex descriptionColours
  {
    get
    {
      IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_descriptionColours);
      return new Text.ColourProfileHex(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Text.ColourProfileHex>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_descriptionColours), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Text.ColourProfileHex>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }
}
