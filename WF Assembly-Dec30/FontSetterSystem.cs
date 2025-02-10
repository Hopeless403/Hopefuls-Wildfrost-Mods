// Decompiled with JetBrains decompiler
// Type: FontSetterSystem
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
using TMPro;
using UnityEngine.AddressableAssets;

#nullable disable
public class FontSetterSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultFontRef;
  private static readonly System.IntPtr NativeFieldInfoPtr_localeFonts;
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultRef;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentRef;
  private static readonly System.IntPtr NativeFieldInfoPtr_current;
  private static readonly System.IntPtr NativeFieldInfoPtr_lookup;
  private static readonly System.IntPtr NativeFieldInfoPtr_fontSetters;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Register_Public_Static_Void_FontSetter_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Unregister_Public_Static_Void_FontSetter_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LocaleChanged_Private_Static_Void_Locale_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFontSetters_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59910, XrefRangeEnd = 59938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FontSetterSystem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59938, XrefRangeEnd = 59947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FontSetterSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59947, XrefRangeEnd = 59956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FontSetterSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 59972, RefRangeEnd = 59973, XrefRangeStart = 59956, XrefRangeEnd = 59972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Register(FontSetter fontSetter)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fontSetter)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FontSetterSystem.NativeMethodInfoPtr_Register_Public_Static_Void_FontSetter_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 59981, RefRangeEnd = 59982, XrefRangeStart = 59973, XrefRangeEnd = 59981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Unregister(FontSetter fontSetter)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fontSetter)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FontSetterSystem.NativeMethodInfoPtr_Unregister_Public_Static_Void_FontSetter_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 60022, RefRangeEnd = 60023, XrefRangeStart = 59982, XrefRangeEnd = 60022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LocaleChanged(UnityEngine.Localization.Locale locale)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) locale)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FontSetterSystem.NativeMethodInfoPtr_LocaleChanged_Private_Static_Void_Locale_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 60045, RefRangeEnd = 60046, XrefRangeStart = 60023, XrefRangeEnd = 60045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void UpdateFontSetters()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FontSetterSystem.NativeMethodInfoPtr_UpdateFontSetters_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FontSetterSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontSetterSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FontSetterSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static FontSetterSystem()
  {
    Il2CppClassPointerStore<FontSetterSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (FontSetterSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontSetterSystem>.NativeClassPtr);
    FontSetterSystem.NativeFieldInfoPtr_defaultFontRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontSetterSystem>.NativeClassPtr, nameof (defaultFontRef));
    FontSetterSystem.NativeFieldInfoPtr_localeFonts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontSetterSystem>.NativeClassPtr, nameof (localeFonts));
    FontSetterSystem.NativeFieldInfoPtr_defaultRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontSetterSystem>.NativeClassPtr, nameof (defaultRef));
    FontSetterSystem.NativeFieldInfoPtr_currentRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontSetterSystem>.NativeClassPtr, nameof (currentRef));
    FontSetterSystem.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontSetterSystem>.NativeClassPtr, nameof (current));
    FontSetterSystem.NativeFieldInfoPtr_lookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontSetterSystem>.NativeClassPtr, nameof (lookup));
    FontSetterSystem.NativeFieldInfoPtr_fontSetters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontSetterSystem>.NativeClassPtr, nameof (fontSetters));
    FontSetterSystem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontSetterSystem>.NativeClassPtr, 100668200);
    FontSetterSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontSetterSystem>.NativeClassPtr, 100668201);
    FontSetterSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontSetterSystem>.NativeClassPtr, 100668202);
    FontSetterSystem.NativeMethodInfoPtr_Register_Public_Static_Void_FontSetter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontSetterSystem>.NativeClassPtr, 100668203);
    FontSetterSystem.NativeMethodInfoPtr_Unregister_Public_Static_Void_FontSetter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontSetterSystem>.NativeClassPtr, 100668204);
    FontSetterSystem.NativeMethodInfoPtr_LocaleChanged_Private_Static_Void_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontSetterSystem>.NativeClassPtr, 100668205);
    FontSetterSystem.NativeMethodInfoPtr_UpdateFontSetters_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontSetterSystem>.NativeClassPtr, 100668206);
    FontSetterSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontSetterSystem>.NativeClassPtr, 100668207);
  }

  public FontSetterSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe AssetReferenceT<TMP_FontAsset> defaultFontRef
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FontSetterSystem.NativeFieldInfoPtr_defaultFontRef));
      return pointer == System.IntPtr.Zero ? (AssetReferenceT<TMP_FontAsset>) null : new AssetReferenceT<TMP_FontAsset>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FontSetterSystem.NativeFieldInfoPtr_defaultFontRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<FontSetterSystem.LocaleFont> localeFonts
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FontSetterSystem.NativeFieldInfoPtr_localeFonts));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<FontSetterSystem.LocaleFont>) null : new Il2CppReferenceArray<FontSetterSystem.LocaleFont>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FontSetterSystem.NativeFieldInfoPtr_localeFonts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe AssetReferenceT<TMP_FontAsset> defaultRef
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(FontSetterSystem.NativeFieldInfoPtr_defaultRef, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (AssetReferenceT<TMP_FontAsset>) null : new AssetReferenceT<TMP_FontAsset>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FontSetterSystem.NativeFieldInfoPtr_defaultRef, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe AssetReferenceT<TMP_FontAsset> currentRef
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(FontSetterSystem.NativeFieldInfoPtr_currentRef, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (AssetReferenceT<TMP_FontAsset>) null : new AssetReferenceT<TMP_FontAsset>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FontSetterSystem.NativeFieldInfoPtr_currentRef, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe TMP_FontAsset current
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(FontSetterSystem.NativeFieldInfoPtr_current, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (TMP_FontAsset) null : new TMP_FontAsset(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FontSetterSystem.NativeFieldInfoPtr_current, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<string, AssetReferenceT<TMP_FontAsset>> lookup
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(FontSetterSystem.NativeFieldInfoPtr_lookup, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<string, AssetReferenceT<TMP_FontAsset>>) null : new Dictionary<string, AssetReferenceT<TMP_FontAsset>>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FontSetterSystem.NativeFieldInfoPtr_lookup, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe List<FontSetter> fontSetters
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(FontSetterSystem.NativeFieldInfoPtr_fontSetters, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<FontSetter>) null : new List<FontSetter>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FontSetterSystem.NativeFieldInfoPtr_fontSetters, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class LocaleFont : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_localeCode;
    private static readonly System.IntPtr NativeFieldInfoPtr_fontRef;

    static LocaleFont()
    {
      Il2CppClassPointerStore<FontSetterSystem.LocaleFont>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FontSetterSystem>.NativeClassPtr, nameof (LocaleFont));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontSetterSystem.LocaleFont>.NativeClassPtr);
      FontSetterSystem.LocaleFont.NativeFieldInfoPtr_localeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontSetterSystem.LocaleFont>.NativeClassPtr, nameof (localeCode));
      FontSetterSystem.LocaleFont.NativeFieldInfoPtr_fontRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontSetterSystem.LocaleFont>.NativeClassPtr, nameof (fontRef));
    }

    public LocaleFont(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public LocaleFont()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FontSetterSystem.LocaleFont>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FontSetterSystem.LocaleFont>.NativeClassPtr, data));
    }

    public unsafe string localeCode
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FontSetterSystem.LocaleFont.NativeFieldInfoPtr_localeCode)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FontSetterSystem.LocaleFont.NativeFieldInfoPtr_localeCode), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe AssetReferenceT<TMP_FontAsset> fontRef
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FontSetterSystem.LocaleFont.NativeFieldInfoPtr_fontRef));
        return pointer == System.IntPtr.Zero ? (AssetReferenceT<TMP_FontAsset>) null : new AssetReferenceT<TMP_FontAsset>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FontSetterSystem.LocaleFont.NativeFieldInfoPtr_fontRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
