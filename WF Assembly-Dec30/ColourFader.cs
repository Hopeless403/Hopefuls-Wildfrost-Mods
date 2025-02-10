// Decompiled with JetBrains decompiler
// Type: ColourFader
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
using UnityEngine.UI;

#nullable disable
public class ColourFader : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr__graphic;
  private static readonly System.IntPtr NativeFieldInfoPtr_colours;
  private static readonly System.IntPtr NativeFieldInfoPtr_duration;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetColour;
  private static readonly System.IntPtr NativeFieldInfoPtr_fadeAmount;
  private static readonly System.IntPtr NativeFieldInfoPtr_fadeDuration;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_graphic_Private_get_Graphic_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FadeToColour_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FadeToColour_Public_Void_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe Graphic graphic
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89097, XrefRangeEnd = 89101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColourFader.NativeMethodInfoPtr_get_graphic_Private_get_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Graphic) null : new Graphic(pointer);
    }
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 89103, RefRangeEnd = 89108, XrefRangeStart = 89101, XrefRangeEnd = 89103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FadeToColour(string name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ColourFader.NativeMethodInfoPtr_FadeToColour_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void FadeToColour(Color colour)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &colour
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ColourFader.NativeMethodInfoPtr_FadeToColour_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89108, XrefRangeEnd = 89118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ColourFader.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ColourFader()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColourFader>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ColourFader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ColourFader()
  {
    Il2CppClassPointerStore<ColourFader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ColourFader));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColourFader>.NativeClassPtr);
    ColourFader.NativeFieldInfoPtr__graphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColourFader>.NativeClassPtr, nameof (_graphic));
    ColourFader.NativeFieldInfoPtr_colours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColourFader>.NativeClassPtr, nameof (colours));
    ColourFader.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColourFader>.NativeClassPtr, nameof (duration));
    ColourFader.NativeFieldInfoPtr_targetColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColourFader>.NativeClassPtr, nameof (targetColour));
    ColourFader.NativeFieldInfoPtr_fadeAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColourFader>.NativeClassPtr, nameof (fadeAmount));
    ColourFader.NativeFieldInfoPtr_fadeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColourFader>.NativeClassPtr, nameof (fadeDuration));
    ColourFader.NativeMethodInfoPtr_get_graphic_Private_get_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColourFader>.NativeClassPtr, 100670858);
    ColourFader.NativeMethodInfoPtr_FadeToColour_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColourFader>.NativeClassPtr, 100670859);
    ColourFader.NativeMethodInfoPtr_FadeToColour_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColourFader>.NativeClassPtr, 100670860);
    ColourFader.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColourFader>.NativeClassPtr, 100670861);
    ColourFader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColourFader>.NativeClassPtr, 100670862);
  }

  public ColourFader(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Graphic _graphic
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColourFader.NativeFieldInfoPtr__graphic));
      return pointer == System.IntPtr.Zero ? (Graphic) null : new Graphic(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ColourFader.NativeFieldInfoPtr__graphic), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ColourFader.Colour> colours
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColourFader.NativeFieldInfoPtr_colours));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ColourFader.Colour>) null : new Il2CppReferenceArray<ColourFader.Colour>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ColourFader.NativeFieldInfoPtr_colours), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float duration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColourFader.NativeFieldInfoPtr_duration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColourFader.NativeFieldInfoPtr_duration)) = value;
    }
  }

  public unsafe Color targetColour
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColourFader.NativeFieldInfoPtr_targetColour));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColourFader.NativeFieldInfoPtr_targetColour)) = value;
    }
  }

  public unsafe float fadeAmount
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColourFader.NativeFieldInfoPtr_fadeAmount));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColourFader.NativeFieldInfoPtr_fadeAmount)) = value;
    }
  }

  public unsafe float fadeDuration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColourFader.NativeFieldInfoPtr_fadeDuration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColourFader.NativeFieldInfoPtr_fadeDuration)) = value;
    }
  }

  [Serializable]
  public sealed class Colour : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_colour;

    static Colour()
    {
      Il2CppClassPointerStore<ColourFader.Colour>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColourFader>.NativeClassPtr, nameof (Colour));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColourFader.Colour>.NativeClassPtr);
      ColourFader.Colour.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColourFader.Colour>.NativeClassPtr, nameof (name));
      ColourFader.Colour.NativeFieldInfoPtr_colour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColourFader.Colour>.NativeClassPtr, nameof (colour));
    }

    public Colour(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Colour()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ColourFader.Colour>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColourFader.Colour>.NativeClassPtr, data));
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColourFader.Colour.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ColourFader.Colour.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Color colour
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColourFader.Colour.NativeFieldInfoPtr_colour));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColourFader.Colour.NativeFieldInfoPtr_colour)) = value;
      }
    }
  }
}
