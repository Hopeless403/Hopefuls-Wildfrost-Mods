// Decompiled with JetBrains decompiler
// Type: Names
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
using UnityEngine;

#nullable disable
public class Names : MonoBehaviourSingleton<Names>
{
  private static readonly System.IntPtr NativeFieldInfoPtr_assets;
  private static readonly System.IntPtr NativeFieldInfoPtr_files;
  private static readonly System.IntPtr NativeFieldInfoPtr_lookup;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LocaleChanged_Private_Static_Void_Locale_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Pull_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Pull_Public_Static_String_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Private_Static_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFiles_Private_Static_TextAsset_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 20944, RefRangeEnd = 20946, XrefRangeStart = 20925, XrefRangeEnd = 20944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Reset()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Names.NativeMethodInfoPtr_Reset_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20946, XrefRangeEnd = 20955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Names.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20955, XrefRangeEnd = 20964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Names.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20964, XrefRangeEnd = 20978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LocaleChanged(UnityEngine.Localization.Locale locale)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) locale)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Names.NativeMethodInfoPtr_LocaleChanged_Private_Static_Void_Locale_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 21005, RefRangeEnd = 21006, XrefRangeStart = 20978, XrefRangeEnd = 21005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string Pull(string key)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(key)
    };
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Names.NativeMethodInfoPtr_Pull_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 21037, RefRangeEnd = 21038, XrefRangeStart = 21006, XrefRangeEnd = 21037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string Pull(string characterRace, string characterGender)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(characterRace);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(characterGender);
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Names.NativeMethodInfoPtr_Pull_Public_Static_String_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 21077, RefRangeEnd = 21081, XrefRangeStart = 21038, XrefRangeEnd = 21077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Load(string key)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(key)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Names.NativeMethodInfoPtr_Load_Private_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 21136, RefRangeEnd = 21137, XrefRangeStart = 21081, XrefRangeEnd = 21136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe TextAsset GetFiles(string key)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(key)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Names.NativeMethodInfoPtr_GetFiles_Private_Static_TextAsset_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (TextAsset) null : new TextAsset(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21137, XrefRangeEnd = 21140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Names()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Names>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Names.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Names()
  {
    Il2CppClassPointerStore<Names>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Names));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Names>.NativeClassPtr);
    Names.NativeFieldInfoPtr_assets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Names>.NativeClassPtr, nameof (assets));
    Names.NativeFieldInfoPtr_files = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Names>.NativeClassPtr, nameof (files));
    Names.NativeFieldInfoPtr_lookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Names>.NativeClassPtr, nameof (lookup));
    Names.NativeMethodInfoPtr_Reset_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Names>.NativeClassPtr, 100663855);
    Names.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Names>.NativeClassPtr, 100663856);
    Names.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Names>.NativeClassPtr, 100663857);
    Names.NativeMethodInfoPtr_LocaleChanged_Private_Static_Void_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Names>.NativeClassPtr, 100663858);
    Names.NativeMethodInfoPtr_Pull_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Names>.NativeClassPtr, 100663859);
    Names.NativeMethodInfoPtr_Pull_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Names>.NativeClassPtr, 100663860);
    Names.NativeMethodInfoPtr_Load_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Names>.NativeClassPtr, 100663861);
    Names.NativeMethodInfoPtr_GetFiles_Private_Static_TextAsset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Names>.NativeClassPtr, 100663862);
    Names.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Names>.NativeClassPtr, 100663863);
  }

  public Names(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<Names.Asset> assets
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Names.NativeFieldInfoPtr_assets));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Names.Asset>) null : new Il2CppReferenceArray<Names.Asset>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Names.NativeFieldInfoPtr_assets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<string, TextAsset> files
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(Names.NativeFieldInfoPtr_files, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<string, TextAsset>) null : new Dictionary<string, TextAsset>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Names.NativeFieldInfoPtr_files, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<string, Queue<string>> lookup
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(Names.NativeFieldInfoPtr_lookup, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<string, Queue<string>>) null : new Dictionary<string, Queue<string>>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Names.NativeFieldInfoPtr_lookup, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class Asset : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_files;

    static Asset()
    {
      Il2CppClassPointerStore<Names.Asset>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Names>.NativeClassPtr, nameof (Asset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Names.Asset>.NativeClassPtr);
      Names.Asset.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Names.Asset>.NativeClassPtr, nameof (name));
      Names.Asset.NativeFieldInfoPtr_files = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Names.Asset>.NativeClassPtr, nameof (files));
    }

    public Asset(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Asset()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Names.Asset>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Names.Asset>.NativeClassPtr, data));
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Names.Asset.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Names.Asset.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Il2CppReferenceArray<Names.LocaleTextAsset> files
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Names.Asset.NativeFieldInfoPtr_files));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Names.LocaleTextAsset>) null : new Il2CppReferenceArray<Names.LocaleTextAsset>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Names.Asset.NativeFieldInfoPtr_files), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public class LocaleTextAsset : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_locale;
    private static readonly System.IntPtr NativeFieldInfoPtr_textAsset;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LocaleTextAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Names.LocaleTextAsset>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Names.LocaleTextAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LocaleTextAsset()
    {
      Il2CppClassPointerStore<Names.LocaleTextAsset>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Names>.NativeClassPtr, nameof (LocaleTextAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Names.LocaleTextAsset>.NativeClassPtr);
      Names.LocaleTextAsset.NativeFieldInfoPtr_locale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Names.LocaleTextAsset>.NativeClassPtr, nameof (locale));
      Names.LocaleTextAsset.NativeFieldInfoPtr_textAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Names.LocaleTextAsset>.NativeClassPtr, nameof (textAsset));
      Names.LocaleTextAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Names.LocaleTextAsset>.NativeClassPtr, 100663865);
    }

    public LocaleTextAsset(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UnityEngine.Localization.Locale locale
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Names.LocaleTextAsset.NativeFieldInfoPtr_locale));
        return pointer == System.IntPtr.Zero ? (UnityEngine.Localization.Locale) null : new UnityEngine.Localization.Locale(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Names.LocaleTextAsset.NativeFieldInfoPtr_locale), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TextAsset textAsset
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Names.LocaleTextAsset.NativeFieldInfoPtr_textAsset));
        return pointer == System.IntPtr.Zero ? (TextAsset) null : new TextAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Names.LocaleTextAsset.NativeFieldInfoPtr_textAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Names/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__10_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetFiles_b__10_0_Internal_Boolean_LocaleTextAsset_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Names.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Names.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20920, XrefRangeEnd = 20925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetFiles_b__10_0(Names.LocaleTextAsset a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Names.__c.NativeMethodInfoPtr__GetFiles_b__10_0_Internal_Boolean_LocaleTextAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<Names.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Names>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Names.__c>.NativeClassPtr);
      Names.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Names.__c>.NativeClassPtr, "<>9");
      Names.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Names.__c>.NativeClassPtr, "<>9__10_0");
      Names.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Names.__c>.NativeClassPtr, 100663867);
      Names.__c.NativeMethodInfoPtr__GetFiles_b__10_0_Internal_Boolean_LocaleTextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Names.__c>.NativeClassPtr, 100663868);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Names.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Names.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Names.__c) null : new Names.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Names.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Names.LocaleTextAsset, bool> __9__10_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Names.__c.NativeFieldInfoPtr___9__10_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Names.LocaleTextAsset, bool>) null : new Il2CppSystem.Func<Names.LocaleTextAsset, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Names.__c.NativeFieldInfoPtr___9__10_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
