// Decompiled with JetBrains decompiler
// Type: StormBellDifficulty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;

#nullable disable
public class StormBellDifficulty : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_setOnAwake;
  private static readonly System.IntPtr NativeFieldInfoPtr_locEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_text;
  private static readonly System.IntPtr NativeFieldInfoPtr_levels;
  private static readonly System.IntPtr NativeFieldInfoPtr__points;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_points_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_points_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateText_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe int points
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StormBellDifficulty.NativeMethodInfoPtr_get_points_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93305, XrefRangeEnd = 93307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StormBellDifficulty.NativeMethodInfoPtr_set_points_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93307, XrefRangeEnd = 93315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateText(string text)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(text)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StormBellDifficulty.NativeMethodInfoPtr_UpdateText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93315, XrefRangeEnd = 93333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StormBellDifficulty.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StormBellDifficulty()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StormBellDifficulty>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StormBellDifficulty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StormBellDifficulty()
  {
    Il2CppClassPointerStore<StormBellDifficulty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StormBellDifficulty));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StormBellDifficulty>.NativeClassPtr);
    StormBellDifficulty.NativeFieldInfoPtr_setOnAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellDifficulty>.NativeClassPtr, nameof (setOnAwake));
    StormBellDifficulty.NativeFieldInfoPtr_locEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellDifficulty>.NativeClassPtr, nameof (locEvent));
    StormBellDifficulty.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellDifficulty>.NativeClassPtr, nameof (text));
    StormBellDifficulty.NativeFieldInfoPtr_levels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellDifficulty>.NativeClassPtr, nameof (levels));
    StormBellDifficulty.NativeFieldInfoPtr__points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellDifficulty>.NativeClassPtr, nameof (_points));
    StormBellDifficulty.NativeMethodInfoPtr_get_points_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellDifficulty>.NativeClassPtr, 100671363);
    StormBellDifficulty.NativeMethodInfoPtr_set_points_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellDifficulty>.NativeClassPtr, 100671364);
    StormBellDifficulty.NativeMethodInfoPtr_UpdateText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellDifficulty>.NativeClassPtr, 100671365);
    StormBellDifficulty.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellDifficulty>.NativeClassPtr, 100671366);
    StormBellDifficulty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellDifficulty>.NativeClassPtr, 100671367);
  }

  public StormBellDifficulty(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool setOnAwake
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellDifficulty.NativeFieldInfoPtr_setOnAwake));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellDifficulty.NativeFieldInfoPtr_setOnAwake)) = value;
    }
  }

  public unsafe LocalizeStringEvent locEvent
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellDifficulty.NativeFieldInfoPtr_locEvent));
      return pointer == System.IntPtr.Zero ? (LocalizeStringEvent) null : new LocalizeStringEvent(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellDifficulty.NativeFieldInfoPtr_locEvent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text text
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellDifficulty.NativeFieldInfoPtr_text));
      return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellDifficulty.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<StormBellDifficulty.Level> levels
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellDifficulty.NativeFieldInfoPtr_levels));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<StormBellDifficulty.Level>) null : new Il2CppReferenceArray<StormBellDifficulty.Level>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellDifficulty.NativeFieldInfoPtr_levels), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _points
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellDifficulty.NativeFieldInfoPtr__points));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellDifficulty.NativeFieldInfoPtr__points)) = value;
    }
  }

  [Serializable]
  public sealed class Level : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_threshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_colour;

    static Level()
    {
      Il2CppClassPointerStore<StormBellDifficulty.Level>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StormBellDifficulty>.NativeClassPtr, nameof (Level));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StormBellDifficulty.Level>.NativeClassPtr);
      StormBellDifficulty.Level.NativeFieldInfoPtr_threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellDifficulty.Level>.NativeClassPtr, nameof (threshold));
      StormBellDifficulty.Level.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellDifficulty.Level>.NativeClassPtr, nameof (name));
      StormBellDifficulty.Level.NativeFieldInfoPtr_colour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellDifficulty.Level>.NativeClassPtr, nameof (colour));
    }

    public Level(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Level()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StormBellDifficulty.Level>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StormBellDifficulty.Level>.NativeClassPtr, data));
    }

    public unsafe int threshold
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellDifficulty.Level.NativeFieldInfoPtr_threshold));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellDifficulty.Level.NativeFieldInfoPtr_threshold)) = value;
      }
    }

    public unsafe LocalizedString name
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellDifficulty.Level.NativeFieldInfoPtr_name));
        return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellDifficulty.Level.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color colour
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellDifficulty.Level.NativeFieldInfoPtr_colour));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellDifficulty.Level.NativeFieldInfoPtr_colour)) = value;
      }
    }
  }
}
