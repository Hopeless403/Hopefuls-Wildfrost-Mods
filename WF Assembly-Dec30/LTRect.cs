// Decompiled with JetBrains decompiler
// Type: LTRect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
[Serializable]
public class LTRect : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr__rect;
  private static readonly System.IntPtr NativeFieldInfoPtr_alpha;
  private static readonly System.IntPtr NativeFieldInfoPtr_rotation;
  private static readonly System.IntPtr NativeFieldInfoPtr_pivot;
  private static readonly System.IntPtr NativeFieldInfoPtr_margin;
  private static readonly System.IntPtr NativeFieldInfoPtr_relativeRect;
  private static readonly System.IntPtr NativeFieldInfoPtr_rotateEnabled;
  private static readonly System.IntPtr NativeFieldInfoPtr_rotateFinished;
  private static readonly System.IntPtr NativeFieldInfoPtr_alphaEnabled;
  private static readonly System.IntPtr NativeFieldInfoPtr_labelStr;
  private static readonly System.IntPtr NativeFieldInfoPtr_type;
  private static readonly System.IntPtr NativeFieldInfoPtr_style;
  private static readonly System.IntPtr NativeFieldInfoPtr_useColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_color;
  private static readonly System.IntPtr NativeFieldInfoPtr_fontScaleToFit;
  private static readonly System.IntPtr NativeFieldInfoPtr_useSimpleScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_sizeByHeight;
  private static readonly System.IntPtr NativeFieldInfoPtr_texture;
  private static readonly System.IntPtr NativeFieldInfoPtr__id;
  private static readonly System.IntPtr NativeFieldInfoPtr_counter;
  private static readonly System.IntPtr NativeFieldInfoPtr_colorTouched;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_hasInitiliazed_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setId_Public_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_reset_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_resetForRotation_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_x_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_y_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_width_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_width_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_height_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_height_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_rect_Public_get_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setStyle_Public_LTRect_GUIStyle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setFontScaleToFit_Public_LTRect_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setColor_Public_LTRect_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setAlpha_Public_LTRect_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setLabel_Public_LTRect_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setUseSimpleScale_Public_LTRect_Boolean_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setUseSimpleScale_Public_LTRect_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setSizeByHeight_Public_LTRect_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132395, XrefRangeEnd = 132400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTRect()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTRect>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 132404, RefRangeEnd = 132407, XrefRangeStart = 132400, XrefRangeEnd = 132404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTRect(Rect rect)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTRect>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &rect
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr__ctor_Public_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132407, XrefRangeEnd = 132410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTRect(float x, float y, float width, float height)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTRect>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132410, XrefRangeEnd = 132413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTRect(float x, float y, float width, float height, float alpha)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTRect>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &alpha;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132413, XrefRangeEnd = 132417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTRect(float x, float y, float width, float height, float alpha, float rotation)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTRect>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &alpha;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public unsafe bool hasInitiliazed
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_get_hasInitiliazed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe int id
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 132417, RefRangeEnd = 132418, XrefRangeStart = 132417, XrefRangeEnd = 132417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  public unsafe void setId(int id, int counter)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &id;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &counter;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_setId_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132418, XrefRangeEnd = 132420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 132441, RefRangeEnd = 132443, XrefRangeStart = 132420, XrefRangeEnd = 132441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void resetForRotation()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_resetForRotation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public unsafe float x
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132443, XrefRangeEnd = 132444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_get_x_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132444, XrefRangeEnd = 132445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe float y
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132445, XrefRangeEnd = 132446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_get_y_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132446, XrefRangeEnd = 132450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe float width
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132450, XrefRangeEnd = 132451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_get_width_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132451, XrefRangeEnd = 132452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_set_width_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe float height
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132452, XrefRangeEnd = 132453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_get_height_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132453, XrefRangeEnd = 132454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_set_height_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe Rect rect
  {
    [CallerCount(23), CachedScanResults(RefRangeStart = 132476, RefRangeEnd = 132499, XrefRangeStart = 132454, XrefRangeEnd = 132476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_get_rect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Rect*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132499, XrefRangeEnd = 132500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTRect setStyle(GUIStyle style)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) style)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_setStyle_Public_LTRect_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTRect) null : new LTRect(pointer);
  }

  [CallerCount(0)]
  public unsafe LTRect setFontScaleToFit(bool fontScaleToFit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &fontScaleToFit
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_setFontScaleToFit_Public_LTRect_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTRect) null : new LTRect(pointer);
  }

  [CallerCount(0)]
  public unsafe LTRect setColor(Color color)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &color
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_setColor_Public_LTRect_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTRect) null : new LTRect(pointer);
  }

  [CallerCount(0)]
  public unsafe LTRect setAlpha(float alpha)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &alpha
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_setAlpha_Public_LTRect_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTRect) null : new LTRect(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132500, XrefRangeEnd = 132501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTRect setLabel(string str)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(str)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_setLabel_Public_LTRect_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTRect) null : new LTRect(pointer);
  }

  [CallerCount(0)]
  public unsafe LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &useSimpleScale;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &relativeRect;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_setUseSimpleScale_Public_LTRect_Boolean_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTRect) null : new LTRect(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132501, XrefRangeEnd = 132504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTRect setUseSimpleScale(bool useSimpleScale)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &useSimpleScale
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_setUseSimpleScale_Public_LTRect_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTRect) null : new LTRect(pointer);
  }

  [CallerCount(0)]
  public unsafe LTRect setSizeByHeight(bool sizeByHeight)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &sizeByHeight
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTRect.NativeMethodInfoPtr_setSizeByHeight_Public_LTRect_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTRect) null : new LTRect(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132504, XrefRangeEnd = 132544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LTRect.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  static LTRect()
  {
    Il2CppClassPointerStore<LTRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LTRect));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTRect>.NativeClassPtr);
    LTRect.NativeFieldInfoPtr__rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, nameof (_rect));
    LTRect.NativeFieldInfoPtr_alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, nameof (alpha));
    LTRect.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, nameof (rotation));
    LTRect.NativeFieldInfoPtr_pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, nameof (pivot));
    LTRect.NativeFieldInfoPtr_margin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, nameof (margin));
    LTRect.NativeFieldInfoPtr_relativeRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, nameof (relativeRect));
    LTRect.NativeFieldInfoPtr_rotateEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, nameof (rotateEnabled));
    LTRect.NativeFieldInfoPtr_rotateFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, nameof (rotateFinished));
    LTRect.NativeFieldInfoPtr_alphaEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, nameof (alphaEnabled));
    LTRect.NativeFieldInfoPtr_labelStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, nameof (labelStr));
    LTRect.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, nameof (type));
    LTRect.NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, nameof (style));
    LTRect.NativeFieldInfoPtr_useColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, nameof (useColor));
    LTRect.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, nameof (color));
    LTRect.NativeFieldInfoPtr_fontScaleToFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, nameof (fontScaleToFit));
    LTRect.NativeFieldInfoPtr_useSimpleScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, nameof (useSimpleScale));
    LTRect.NativeFieldInfoPtr_sizeByHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, nameof (sizeByHeight));
    LTRect.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, nameof (texture));
    LTRect.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, nameof (_id));
    LTRect.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, nameof (counter));
    LTRect.NativeFieldInfoPtr_colorTouched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, nameof (colorTouched));
    LTRect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676898);
    LTRect.NativeMethodInfoPtr__ctor_Public_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676899);
    LTRect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676900);
    LTRect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676901);
    LTRect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676902);
    LTRect.NativeMethodInfoPtr_get_hasInitiliazed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676903);
    LTRect.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676904);
    LTRect.NativeMethodInfoPtr_setId_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676905);
    LTRect.NativeMethodInfoPtr_reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676906);
    LTRect.NativeMethodInfoPtr_resetForRotation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676907);
    LTRect.NativeMethodInfoPtr_get_x_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676908);
    LTRect.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676909);
    LTRect.NativeMethodInfoPtr_get_y_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676910);
    LTRect.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676911);
    LTRect.NativeMethodInfoPtr_get_width_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676912);
    LTRect.NativeMethodInfoPtr_set_width_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676913);
    LTRect.NativeMethodInfoPtr_get_height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676914);
    LTRect.NativeMethodInfoPtr_set_height_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676915);
    LTRect.NativeMethodInfoPtr_get_rect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676916);
    LTRect.NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676917);
    LTRect.NativeMethodInfoPtr_setStyle_Public_LTRect_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676918);
    LTRect.NativeMethodInfoPtr_setFontScaleToFit_Public_LTRect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676919);
    LTRect.NativeMethodInfoPtr_setColor_Public_LTRect_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676920);
    LTRect.NativeMethodInfoPtr_setAlpha_Public_LTRect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676921);
    LTRect.NativeMethodInfoPtr_setLabel_Public_LTRect_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676922);
    LTRect.NativeMethodInfoPtr_setUseSimpleScale_Public_LTRect_Boolean_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676923);
    LTRect.NativeMethodInfoPtr_setUseSimpleScale_Public_LTRect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676924);
    LTRect.NativeMethodInfoPtr_setSizeByHeight_Public_LTRect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676925);
    LTRect.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100676926);
  }

  public LTRect(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Rect _rect
  {
    get
    {
      return *(Rect*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr__rect));
    }
    [param: In] set
    {
      *(Rect*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr__rect)) = value;
    }
  }

  public unsafe float alpha
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_alpha));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_alpha)) = value;
    }
  }

  public unsafe float rotation
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_rotation));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_rotation)) = value;
    }
  }

  public unsafe Vector2 pivot
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_pivot));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_pivot)) = value;
    }
  }

  public unsafe Vector2 margin
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_margin));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_margin)) = value;
    }
  }

  public unsafe Rect relativeRect
  {
    get
    {
      return *(Rect*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_relativeRect));
    }
    [param: In] set
    {
      *(Rect*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_relativeRect)) = value;
    }
  }

  public unsafe bool rotateEnabled
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_rotateEnabled));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_rotateEnabled)) = value;
    }
  }

  public unsafe bool rotateFinished
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_rotateFinished));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_rotateFinished)) = value;
    }
  }

  public unsafe bool alphaEnabled
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_alphaEnabled));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_alphaEnabled)) = value;
    }
  }

  public unsafe string labelStr
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_labelStr)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_labelStr), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe LTGUI.Element_Type type
  {
    get
    {
      return *(LTGUI.Element_Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_type));
    }
    [param: In] set
    {
      *(LTGUI.Element_Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_type)) = value;
    }
  }

  public unsafe GUIStyle style
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_style));
      return pointer == System.IntPtr.Zero ? (GUIStyle) null : new GUIStyle(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_style), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool useColor
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_useColor));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_useColor)) = value;
    }
  }

  public unsafe Color color
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_color));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_color)) = value;
    }
  }

  public unsafe bool fontScaleToFit
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_fontScaleToFit));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_fontScaleToFit)) = value;
    }
  }

  public unsafe bool useSimpleScale
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_useSimpleScale));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_useSimpleScale)) = value;
    }
  }

  public unsafe bool sizeByHeight
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_sizeByHeight));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_sizeByHeight)) = value;
    }
  }

  public unsafe Texture texture
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_texture));
      return pointer == System.IntPtr.Zero ? (Texture) null : new Texture(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _id
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr__id));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr__id)) = value;
    }
  }

  public unsafe int counter
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_counter));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTRect.NativeFieldInfoPtr_counter)) = value;
    }
  }

  public static unsafe bool colorTouched
  {
    get
    {
      bool colorTouched;
      IL2CPP.il2cpp_field_static_get_value(LTRect.NativeFieldInfoPtr_colorTouched, (void*) &colorTouched);
      return colorTouched;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LTRect.NativeFieldInfoPtr_colorTouched, (void*) &value);
    }
  }
}
