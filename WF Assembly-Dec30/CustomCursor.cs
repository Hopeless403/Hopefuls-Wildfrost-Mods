// Decompiled with JetBrains decompiler
// Type: CustomCursor
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
public class CustomCursor : MonoBehaviourSingleton<CustomCursor>
{
  private static readonly System.IntPtr NativeFieldInfoPtr_cursorMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_styles;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentStyle;
  private static readonly System.IntPtr NativeFieldInfoPtr_styleLookup;
  private static readonly System.IntPtr NativeFieldInfoPtr_visible;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Private_Style_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Private_Void_Style_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetStyle_Public_Static_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateState_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38615, XrefRangeEnd = 38622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomCursor.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38622, XrefRangeEnd = 38628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CustomCursor.Style Get(string styleName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(styleName)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomCursor.NativeMethodInfoPtr_Get_Private_Style_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CustomCursor.Style) null : new CustomCursor.Style(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38628, XrefRangeEnd = 38638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(CustomCursor.Style style)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) style)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CustomCursor.NativeMethodInfoPtr_Set_Private_Void_Style_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 38660, RefRangeEnd = 38664, XrefRangeStart = 38638, XrefRangeEnd = 38660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetStyle(string styleName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(styleName)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CustomCursor.NativeMethodInfoPtr_SetStyle_Public_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38664, XrefRangeEnd = 38671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnApplicationFocus(bool focus)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &focus
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CustomCursor.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 38697, RefRangeEnd = 38705, XrefRangeStart = 38671, XrefRangeEnd = 38697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void UpdateState()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CustomCursor.NativeMethodInfoPtr_UpdateState_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38705, XrefRangeEnd = 38712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CustomCursor()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomCursor>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CustomCursor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CustomCursor()
  {
    Il2CppClassPointerStore<CustomCursor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CustomCursor));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomCursor>.NativeClassPtr);
    CustomCursor.NativeFieldInfoPtr_cursorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomCursor>.NativeClassPtr, nameof (cursorMode));
    CustomCursor.NativeFieldInfoPtr_styles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomCursor>.NativeClassPtr, nameof (styles));
    CustomCursor.NativeFieldInfoPtr_currentStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomCursor>.NativeClassPtr, nameof (currentStyle));
    CustomCursor.NativeFieldInfoPtr_styleLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomCursor>.NativeClassPtr, nameof (styleLookup));
    CustomCursor.NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomCursor>.NativeClassPtr, nameof (visible));
    CustomCursor.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCursor>.NativeClassPtr, 100665923);
    CustomCursor.NativeMethodInfoPtr_Get_Private_Style_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCursor>.NativeClassPtr, 100665924);
    CustomCursor.NativeMethodInfoPtr_Set_Private_Void_Style_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCursor>.NativeClassPtr, 100665925);
    CustomCursor.NativeMethodInfoPtr_SetStyle_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCursor>.NativeClassPtr, 100665926);
    CustomCursor.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCursor>.NativeClassPtr, 100665927);
    CustomCursor.NativeMethodInfoPtr_UpdateState_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCursor>.NativeClassPtr, 100665928);
    CustomCursor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCursor>.NativeClassPtr, 100665929);
  }

  public CustomCursor(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe CursorMode cursorMode
  {
    get
    {
      return *(CursorMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomCursor.NativeFieldInfoPtr_cursorMode));
    }
    [param: In] set
    {
      *(CursorMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomCursor.NativeFieldInfoPtr_cursorMode)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<CustomCursor.Style> styles
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomCursor.NativeFieldInfoPtr_styles));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CustomCursor.Style>) null : new Il2CppReferenceArray<CustomCursor.Style>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomCursor.NativeFieldInfoPtr_styles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string currentStyle
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomCursor.NativeFieldInfoPtr_currentStyle)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomCursor.NativeFieldInfoPtr_currentStyle), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Dictionary<string, CustomCursor.Style> styleLookup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomCursor.NativeFieldInfoPtr_styleLookup));
      return pointer == System.IntPtr.Zero ? (Dictionary<string, CustomCursor.Style>) null : new Dictionary<string, CustomCursor.Style>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomCursor.NativeFieldInfoPtr_styleLookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe bool visible
  {
    get
    {
      bool visible;
      IL2CPP.il2cpp_field_static_get_value(CustomCursor.NativeFieldInfoPtr_visible, (void*) &visible);
      return visible;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CustomCursor.NativeFieldInfoPtr_visible, (void*) &value);
    }
  }

  [Serializable]
  public class Style : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_sprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_hotSpot;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Style()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomCursor.Style>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomCursor.Style.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Style()
    {
      Il2CppClassPointerStore<CustomCursor.Style>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomCursor>.NativeClassPtr, nameof (Style));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomCursor.Style>.NativeClassPtr);
      CustomCursor.Style.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomCursor.Style>.NativeClassPtr, nameof (name));
      CustomCursor.Style.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomCursor.Style>.NativeClassPtr, nameof (sprite));
      CustomCursor.Style.NativeFieldInfoPtr_hotSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomCursor.Style>.NativeClassPtr, nameof (hotSpot));
      CustomCursor.Style.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCursor.Style>.NativeClassPtr, 100665931);
    }

    public Style(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomCursor.Style.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomCursor.Style.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Texture2D sprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomCursor.Style.NativeFieldInfoPtr_sprite));
        return pointer == System.IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomCursor.Style.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector2 hotSpot
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomCursor.Style.NativeFieldInfoPtr_hotSpot));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomCursor.Style.NativeFieldInfoPtr_hotSpot)) = value;
      }
    }
  }
}
