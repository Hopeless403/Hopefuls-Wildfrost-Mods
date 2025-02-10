// Decompiled with JetBrains decompiler
// Type: LTGUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class LTGUI : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_RECT_LEVELS;
  private static readonly System.IntPtr NativeFieldInfoPtr_RECTS_PER_LEVEL;
  private static readonly System.IntPtr NativeFieldInfoPtr_BUTTONS_MAX;
  private static readonly System.IntPtr NativeFieldInfoPtr_levels;
  private static readonly System.IntPtr NativeFieldInfoPtr_levelDepths;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttons;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttonLevels;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttonLastFrame;
  private static readonly System.IntPtr NativeFieldInfoPtr_r;
  private static readonly System.IntPtr NativeFieldInfoPtr_color;
  private static readonly System.IntPtr NativeFieldInfoPtr_isGUIEnabled;
  private static readonly System.IntPtr NativeFieldInfoPtr_global_counter;
  private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_initRectCheck_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_reset_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Static_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_checkOnScreen_Public_Static_Boolean_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_destroy_Public_Static_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_destroyAll_Public_Static_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_label_Public_Static_LTRect_Rect_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_label_Public_Static_LTRect_LTRect_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_texture_Public_Static_LTRect_Rect_Texture_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_texture_Public_Static_LTRect_LTRect_Texture_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_element_Public_Static_LTRect_LTRect_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_hasNoOverlap_Public_Static_Boolean_Rect_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_pressedWithinRect_Public_Static_Boolean_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_checkWithinRect_Public_Static_Boolean_Vector2_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_firstTouch_Public_Static_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 132573, RefRangeEnd = 132575, XrefRangeStart = 132554, XrefRangeEnd = 132573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void init()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_init_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132575, XrefRangeEnd = 132606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void initRectCheck()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_initRectCheck_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 132625, RefRangeEnd = 132627, XrefRangeStart = 132606, XrefRangeEnd = 132625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void reset()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_reset_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132627, XrefRangeEnd = 132792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void update(int updateLevel)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &updateLevel
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_update_Public_Static_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132792, XrefRangeEnd = 132800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool checkOnScreen(Rect rect)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &rect
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_checkOnScreen_Public_Static_Boolean_Rect_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 132811, RefRangeEnd = 132812, XrefRangeStart = 132800, XrefRangeEnd = 132811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void destroy(int id)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &id
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_destroy_Public_Static_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132812, XrefRangeEnd = 132823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void destroyAll(int depth)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &depth
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_destroyAll_Public_Static_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132823, XrefRangeEnd = 132836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTRect label(Rect rect, string label, int depth)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &rect;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(label);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_label_Public_Static_LTRect_Rect_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTRect) null : new LTRect(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132836, XrefRangeEnd = 132842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTRect label(LTRect rect, string label, int depth)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rect);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(label);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_label_Public_Static_LTRect_LTRect_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTRect) null : new LTRect(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132842, XrefRangeEnd = 132855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTRect texture(Rect rect, Texture texture, int depth)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &rect;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_texture_Public_Static_LTRect_Rect_Texture_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTRect) null : new LTRect(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132855, XrefRangeEnd = 132861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTRect texture(LTRect rect, Texture texture, int depth)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rect);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_texture_Public_Static_LTRect_LTRect_Texture_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTRect) null : new LTRect(pointer);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 132905, RefRangeEnd = 132909, XrefRangeStart = 132861, XrefRangeEnd = 132905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTRect element(LTRect rect, int depth)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rect);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_element_Public_Static_LTRect_LTRect_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTRect) null : new LTRect(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132909, XrefRangeEnd = 132971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool hasNoOverlap(Rect rect, int depth)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &rect;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_hasNoOverlap_Public_Static_Boolean_Rect_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 132988, RefRangeEnd = 132989, XrefRangeStart = 132971, XrefRangeEnd = 132988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool pressedWithinRect(Rect rect)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &rect
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_pressedWithinRect_Public_Static_Boolean_Rect_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132989, XrefRangeEnd = 132997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool checkWithinRect(Vector2 vec2, Rect rect)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &vec2;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rect;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_checkWithinRect_Public_Static_Boolean_Vector2_Rect_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132997, XrefRangeEnd = 132999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 firstTouch()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_firstTouch_Public_Static_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1959)]
  [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTGUI()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTGUI>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LTGUI()
  {
    Il2CppClassPointerStore<LTGUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LTGUI));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTGUI>.NativeClassPtr);
    LTGUI.NativeFieldInfoPtr_RECT_LEVELS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, nameof (RECT_LEVELS));
    LTGUI.NativeFieldInfoPtr_RECTS_PER_LEVEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, nameof (RECTS_PER_LEVEL));
    LTGUI.NativeFieldInfoPtr_BUTTONS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, nameof (BUTTONS_MAX));
    LTGUI.NativeFieldInfoPtr_levels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, nameof (levels));
    LTGUI.NativeFieldInfoPtr_levelDepths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, nameof (levelDepths));
    LTGUI.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, nameof (buttons));
    LTGUI.NativeFieldInfoPtr_buttonLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, nameof (buttonLevels));
    LTGUI.NativeFieldInfoPtr_buttonLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, nameof (buttonLastFrame));
    LTGUI.NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, nameof (r));
    LTGUI.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, nameof (color));
    LTGUI.NativeFieldInfoPtr_isGUIEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, nameof (isGUIEnabled));
    LTGUI.NativeFieldInfoPtr_global_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, nameof (global_counter));
    LTGUI.NativeMethodInfoPtr_init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100676928);
    LTGUI.NativeMethodInfoPtr_initRectCheck_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100676929);
    LTGUI.NativeMethodInfoPtr_reset_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100676930);
    LTGUI.NativeMethodInfoPtr_update_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100676931);
    LTGUI.NativeMethodInfoPtr_checkOnScreen_Public_Static_Boolean_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100676932);
    LTGUI.NativeMethodInfoPtr_destroy_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100676933);
    LTGUI.NativeMethodInfoPtr_destroyAll_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100676934);
    LTGUI.NativeMethodInfoPtr_label_Public_Static_LTRect_Rect_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100676935);
    LTGUI.NativeMethodInfoPtr_label_Public_Static_LTRect_LTRect_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100676936);
    LTGUI.NativeMethodInfoPtr_texture_Public_Static_LTRect_Rect_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100676937);
    LTGUI.NativeMethodInfoPtr_texture_Public_Static_LTRect_LTRect_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100676938);
    LTGUI.NativeMethodInfoPtr_element_Public_Static_LTRect_LTRect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100676939);
    LTGUI.NativeMethodInfoPtr_hasNoOverlap_Public_Static_Boolean_Rect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100676940);
    LTGUI.NativeMethodInfoPtr_pressedWithinRect_Public_Static_Boolean_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100676941);
    LTGUI.NativeMethodInfoPtr_checkWithinRect_Public_Static_Boolean_Vector2_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100676942);
    LTGUI.NativeMethodInfoPtr_firstTouch_Public_Static_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100676943);
    LTGUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100676944);
  }

  public LTGUI(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe int RECT_LEVELS
  {
    get
    {
      int rectLevels;
      IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_RECT_LEVELS, (void*) &rectLevels);
      return rectLevels;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_RECT_LEVELS, (void*) &value);
    }
  }

  public static unsafe int RECTS_PER_LEVEL
  {
    get
    {
      int rectsPerLevel;
      IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_RECTS_PER_LEVEL, (void*) &rectsPerLevel);
      return rectsPerLevel;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_RECTS_PER_LEVEL, (void*) &value);
    }
  }

  public static unsafe int BUTTONS_MAX
  {
    get
    {
      int buttonsMax;
      IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_BUTTONS_MAX, (void*) &buttonsMax);
      return buttonsMax;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_BUTTONS_MAX, (void*) &value);
    }
  }

  public static unsafe Il2CppReferenceArray<LTRect> levels
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_levels, (void*) &num);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<LTRect>) null : new Il2CppReferenceArray<LTRect>(nativeObject);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_levels, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStructArray<int> levelDepths
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_levelDepths, (void*) &num);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<int>) null : new Il2CppStructArray<int>(nativeObject);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_levelDepths, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStructArray<Rect> buttons
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_buttons, (void*) &num);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<Rect>) null : new Il2CppStructArray<Rect>(nativeObject);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_buttons, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStructArray<int> buttonLevels
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_buttonLevels, (void*) &num);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<int>) null : new Il2CppStructArray<int>(nativeObject);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_buttonLevels, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStructArray<int> buttonLastFrame
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_buttonLastFrame, (void*) &num);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<int>) null : new Il2CppStructArray<int>(nativeObject);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_buttonLastFrame, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe LTRect r
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_r, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (LTRect) null : new LTRect(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_r, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Color color
  {
    get
    {
      Color color;
      IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_color, (void*) &color);
      return color;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_color, (void*) &value);
    }
  }

  public static unsafe bool isGUIEnabled
  {
    get
    {
      bool isGuiEnabled;
      IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_isGUIEnabled, (void*) &isGuiEnabled);
      return isGuiEnabled;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_isGUIEnabled, (void*) &value);
    }
  }

  public static unsafe int global_counter
  {
    get
    {
      int globalCounter;
      IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_global_counter, (void*) &globalCounter);
      return globalCounter;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_global_counter, (void*) &value);
    }
  }

  public enum Element_Type
  {
    Texture,
    Label,
  }
}
