// Decompiled with JetBrains decompiler
// Type: MapInspectSequence
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
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

#nullable disable
public class MapInspectSequence : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_title;
  private static readonly System.IntPtr NativeFieldInfoPtr_desc;
  private static readonly System.IntPtr NativeFieldInfoPtr_image;
  private static readonly System.IntPtr NativeFieldInfoPtr_profiles;
  private static readonly System.IntPtr NativeMethodInfoPtr_Inspect_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Inspect_Private_Void_Profile_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Inspect_Private_Void_LocalizedString_LocalizedString_Sprite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 99384, RefRangeEnd = 99385, XrefRangeStart = 99377, XrefRangeEnd = 99384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Inspect(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapInspectSequence.NativeMethodInfoPtr_Inspect_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99385, XrefRangeEnd = 99391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Inspect(MapInspectSequence.Profile profile)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) profile))
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapInspectSequence.NativeMethodInfoPtr_Inspect_Private_Void_Profile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99391, XrefRangeEnd = 99397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Inspect(LocalizedString titleKey, LocalizedString descKey, Sprite icon)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) titleKey);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) descKey);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) icon);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapInspectSequence.NativeMethodInfoPtr_Inspect_Private_Void_LocalizedString_LocalizedString_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MapInspectSequence()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapInspectSequence>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapInspectSequence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static MapInspectSequence()
  {
    Il2CppClassPointerStore<MapInspectSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (MapInspectSequence));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapInspectSequence>.NativeClassPtr);
    MapInspectSequence.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapInspectSequence>.NativeClassPtr, nameof (title));
    MapInspectSequence.NativeFieldInfoPtr_desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapInspectSequence>.NativeClassPtr, nameof (desc));
    MapInspectSequence.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapInspectSequence>.NativeClassPtr, nameof (image));
    MapInspectSequence.NativeFieldInfoPtr_profiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapInspectSequence>.NativeClassPtr, nameof (profiles));
    MapInspectSequence.NativeMethodInfoPtr_Inspect_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapInspectSequence>.NativeClassPtr, 100672173);
    MapInspectSequence.NativeMethodInfoPtr_Inspect_Private_Void_Profile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapInspectSequence>.NativeClassPtr, 100672174);
    MapInspectSequence.NativeMethodInfoPtr_Inspect_Private_Void_LocalizedString_LocalizedString_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapInspectSequence>.NativeClassPtr, 100672175);
    MapInspectSequence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapInspectSequence>.NativeClassPtr, 100672176);
  }

  public MapInspectSequence(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LocalizeStringEvent title
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapInspectSequence.NativeFieldInfoPtr_title));
      return pointer == System.IntPtr.Zero ? (LocalizeStringEvent) null : new LocalizeStringEvent(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapInspectSequence.NativeFieldInfoPtr_title), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizeStringEvent desc
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapInspectSequence.NativeFieldInfoPtr_desc));
      return pointer == System.IntPtr.Zero ? (LocalizeStringEvent) null : new LocalizeStringEvent(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapInspectSequence.NativeFieldInfoPtr_desc), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image image
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapInspectSequence.NativeFieldInfoPtr_image));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapInspectSequence.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<MapInspectSequence.Profile> profiles
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapInspectSequence.NativeFieldInfoPtr_profiles));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<MapInspectSequence.Profile>) null : new Il2CppReferenceArray<MapInspectSequence.Profile>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapInspectSequence.NativeFieldInfoPtr_profiles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class Profile : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_titleKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_descKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_icon;

    static Profile()
    {
      Il2CppClassPointerStore<MapInspectSequence.Profile>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapInspectSequence>.NativeClassPtr, nameof (Profile));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapInspectSequence.Profile>.NativeClassPtr);
      MapInspectSequence.Profile.NativeFieldInfoPtr_titleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapInspectSequence.Profile>.NativeClassPtr, nameof (titleKey));
      MapInspectSequence.Profile.NativeFieldInfoPtr_descKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapInspectSequence.Profile>.NativeClassPtr, nameof (descKey));
      MapInspectSequence.Profile.NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapInspectSequence.Profile>.NativeClassPtr, nameof (icon));
    }

    public Profile(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Profile()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapInspectSequence.Profile>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapInspectSequence.Profile>.NativeClassPtr, data));
    }

    public unsafe LocalizedString titleKey
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapInspectSequence.Profile.NativeFieldInfoPtr_titleKey));
        return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapInspectSequence.Profile.NativeFieldInfoPtr_titleKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedString descKey
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapInspectSequence.Profile.NativeFieldInfoPtr_descKey));
        return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapInspectSequence.Profile.NativeFieldInfoPtr_descKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite icon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapInspectSequence.Profile.NativeFieldInfoPtr_icon));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapInspectSequence.Profile.NativeFieldInfoPtr_icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
