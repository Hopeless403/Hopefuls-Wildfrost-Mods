// Decompiled with JetBrains decompiler
// Type: CharacterType
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
public class CharacterType : ScriptableObject
{
  private static readonly System.IntPtr NativeFieldInfoPtr_race;
  private static readonly System.IntPtr NativeFieldInfoPtr_gender;
  private static readonly System.IntPtr NativeFieldInfoPtr_prefabs;
  private static readonly System.IntPtr NativeFieldInfoPtr_sprites;
  private static readonly System.IntPtr NativeFieldInfoPtr_colorSets;
  private static readonly System.IntPtr NativeFieldInfoPtr_scales;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterType()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterType>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CharacterType()
  {
    Il2CppClassPointerStore<CharacterType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CharacterType));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterType>.NativeClassPtr);
    CharacterType.NativeFieldInfoPtr_race = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterType>.NativeClassPtr, nameof (race));
    CharacterType.NativeFieldInfoPtr_gender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterType>.NativeClassPtr, nameof (gender));
    CharacterType.NativeFieldInfoPtr_prefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterType>.NativeClassPtr, nameof (prefabs));
    CharacterType.NativeFieldInfoPtr_sprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterType>.NativeClassPtr, nameof (sprites));
    CharacterType.NativeFieldInfoPtr_colorSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterType>.NativeClassPtr, nameof (colorSets));
    CharacterType.NativeFieldInfoPtr_scales = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterType>.NativeClassPtr, nameof (scales));
    CharacterType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterType>.NativeClassPtr, 100673339);
  }

  public CharacterType(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string race
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.NativeFieldInfoPtr_race)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.NativeFieldInfoPtr_race), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string gender
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.NativeFieldInfoPtr_gender)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.NativeFieldInfoPtr_gender), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Il2CppReferenceArray<CharacterType.PrefabGroup> prefabs
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.NativeFieldInfoPtr_prefabs));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CharacterType.PrefabGroup>) null : new Il2CppReferenceArray<CharacterType.PrefabGroup>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.NativeFieldInfoPtr_prefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CharacterType.SpriteGroup> sprites
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.NativeFieldInfoPtr_sprites));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CharacterType.SpriteGroup>) null : new Il2CppReferenceArray<CharacterType.SpriteGroup>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.NativeFieldInfoPtr_sprites), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CharacterType.ColorSetGroup> colorSets
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.NativeFieldInfoPtr_colorSets));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CharacterType.ColorSetGroup>) null : new Il2CppReferenceArray<CharacterType.ColorSetGroup>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.NativeFieldInfoPtr_colorSets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CharacterType.ScaleRange> scales
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.NativeFieldInfoPtr_scales));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CharacterType.ScaleRange>) null : new Il2CppReferenceArray<CharacterType.ScaleRange>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.NativeFieldInfoPtr_scales), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class PrefabGroup : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_collection;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabGroup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterType.PrefabGroup>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterType.PrefabGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PrefabGroup()
    {
      Il2CppClassPointerStore<CharacterType.PrefabGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterType>.NativeClassPtr, nameof (PrefabGroup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterType.PrefabGroup>.NativeClassPtr);
      CharacterType.PrefabGroup.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterType.PrefabGroup>.NativeClassPtr, nameof (name));
      CharacterType.PrefabGroup.NativeFieldInfoPtr_collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterType.PrefabGroup>.NativeClassPtr, nameof (collection));
      CharacterType.PrefabGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterType.PrefabGroup>.NativeClassPtr, 100673340);
    }

    public PrefabGroup(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.PrefabGroup.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.PrefabGroup.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe PrefabCollection collection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.PrefabGroup.NativeFieldInfoPtr_collection));
        return pointer == System.IntPtr.Zero ? (PrefabCollection) null : new PrefabCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.PrefabGroup.NativeFieldInfoPtr_collection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public class SpriteGroup : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_collection;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpriteGroup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterType.SpriteGroup>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterType.SpriteGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpriteGroup()
    {
      Il2CppClassPointerStore<CharacterType.SpriteGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterType>.NativeClassPtr, nameof (SpriteGroup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterType.SpriteGroup>.NativeClassPtr);
      CharacterType.SpriteGroup.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterType.SpriteGroup>.NativeClassPtr, nameof (name));
      CharacterType.SpriteGroup.NativeFieldInfoPtr_collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterType.SpriteGroup>.NativeClassPtr, nameof (collection));
      CharacterType.SpriteGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterType.SpriteGroup>.NativeClassPtr, 100673341);
    }

    public SpriteGroup(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.SpriteGroup.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.SpriteGroup.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe SpriteCollection collection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.SpriteGroup.NativeFieldInfoPtr_collection));
        return pointer == System.IntPtr.Zero ? (SpriteCollection) null : new SpriteCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.SpriteGroup.NativeFieldInfoPtr_collection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public class ColorSetGroup : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_collection;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ColorSetGroup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterType.ColorSetGroup>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterType.ColorSetGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ColorSetGroup()
    {
      Il2CppClassPointerStore<CharacterType.ColorSetGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterType>.NativeClassPtr, nameof (ColorSetGroup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterType.ColorSetGroup>.NativeClassPtr);
      CharacterType.ColorSetGroup.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterType.ColorSetGroup>.NativeClassPtr, nameof (name));
      CharacterType.ColorSetGroup.NativeFieldInfoPtr_collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterType.ColorSetGroup>.NativeClassPtr, nameof (collection));
      CharacterType.ColorSetGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterType.ColorSetGroup>.NativeClassPtr, 100673342);
    }

    public ColorSetGroup(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.ColorSetGroup.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.ColorSetGroup.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe ColorSetCollection collection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.ColorSetGroup.NativeFieldInfoPtr_collection));
        return pointer == System.IntPtr.Zero ? (ColorSetCollection) null : new ColorSetCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.ColorSetGroup.NativeFieldInfoPtr_collection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public class ScaleRange : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_lockRatio;
    private static readonly System.IntPtr NativeFieldInfoPtr_xRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_yRange;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 109011, RefRangeEnd = 109012, XrefRangeStart = 109009, XrefRangeEnd = 109011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Vector2 Convert()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterType.ScaleRange.NativeMethodInfoPtr_Convert_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ScaleRange()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterType.ScaleRange>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterType.ScaleRange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ScaleRange()
    {
      Il2CppClassPointerStore<CharacterType.ScaleRange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterType>.NativeClassPtr, nameof (ScaleRange));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterType.ScaleRange>.NativeClassPtr);
      CharacterType.ScaleRange.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterType.ScaleRange>.NativeClassPtr, nameof (name));
      CharacterType.ScaleRange.NativeFieldInfoPtr_lockRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterType.ScaleRange>.NativeClassPtr, nameof (lockRatio));
      CharacterType.ScaleRange.NativeFieldInfoPtr_xRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterType.ScaleRange>.NativeClassPtr, nameof (xRange));
      CharacterType.ScaleRange.NativeFieldInfoPtr_yRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterType.ScaleRange>.NativeClassPtr, nameof (yRange));
      CharacterType.ScaleRange.NativeMethodInfoPtr_Convert_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterType.ScaleRange>.NativeClassPtr, 100673343);
      CharacterType.ScaleRange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterType.ScaleRange>.NativeClassPtr, 100673344);
    }

    public ScaleRange(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.ScaleRange.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.ScaleRange.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool lockRatio
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.ScaleRange.NativeFieldInfoPtr_lockRatio));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.ScaleRange.NativeFieldInfoPtr_lockRatio)) = value;
      }
    }

    public unsafe Vector2 xRange
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.ScaleRange.NativeFieldInfoPtr_xRange));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.ScaleRange.NativeFieldInfoPtr_xRange)) = value;
      }
    }

    public unsafe Vector2 yRange
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.ScaleRange.NativeFieldInfoPtr_yRange));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterType.ScaleRange.NativeFieldInfoPtr_yRange)) = value;
      }
    }
  }
}
