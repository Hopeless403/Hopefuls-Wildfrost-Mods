// Decompiled with JetBrains decompiler
// Type: Tooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class Tooltip : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_animate;
  private static readonly IntPtr NativeFieldInfoPtr_ignoreTimeScale;
  private static readonly IntPtr NativeFieldInfoPtr_children;
  private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;
  private static readonly IntPtr NativeFieldInfoPtr_panel;
  private static readonly IntPtr NativeFieldInfoPtr_defaultPanelSprite;
  private static readonly IntPtr NativeFieldInfoPtr_defaultPanelColor;
  private static readonly IntPtr NativeFieldInfoPtr_scaleFrom;
  private static readonly IntPtr NativeFieldInfoPtr_scaleCurve;
  private static readonly IntPtr NativeFieldInfoPtr_scaleDur;
  private static readonly IntPtr NativeFieldInfoPtr_fadeFrom;
  private static readonly IntPtr NativeFieldInfoPtr_fadeCurve;
  private static readonly IntPtr NativeFieldInfoPtr_fadeDur;
  private static readonly IntPtr NativeMethodInfoPtr_Ping_Protected_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 95982, RefRangeEnd = 95984, XrefRangeStart = 95965, XrefRangeEnd = 95982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Ping()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Tooltip.NativeMethodInfoPtr_Ping_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 95995, RefRangeEnd = 95997, XrefRangeStart = 95984, XrefRangeEnd = 95995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Tooltip()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tooltip>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Tooltip.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Tooltip()
  {
    Il2CppClassPointerStore<Tooltip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Tooltip));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tooltip>.NativeClassPtr);
    Tooltip.NativeFieldInfoPtr_animate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, nameof (animate));
    Tooltip.NativeFieldInfoPtr_ignoreTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, nameof (ignoreTimeScale));
    Tooltip.NativeFieldInfoPtr_children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, nameof (children));
    Tooltip.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, nameof (canvasGroup));
    Tooltip.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, nameof (panel));
    Tooltip.NativeFieldInfoPtr_defaultPanelSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, nameof (defaultPanelSprite));
    Tooltip.NativeFieldInfoPtr_defaultPanelColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, nameof (defaultPanelColor));
    Tooltip.NativeFieldInfoPtr_scaleFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, nameof (scaleFrom));
    Tooltip.NativeFieldInfoPtr_scaleCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, nameof (scaleCurve));
    Tooltip.NativeFieldInfoPtr_scaleDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, nameof (scaleDur));
    Tooltip.NativeFieldInfoPtr_fadeFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, nameof (fadeFrom));
    Tooltip.NativeFieldInfoPtr_fadeCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, nameof (fadeCurve));
    Tooltip.NativeFieldInfoPtr_fadeDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, nameof (fadeDur));
    Tooltip.NativeMethodInfoPtr_Ping_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, 100671665);
    Tooltip.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, 100671666);
  }

  public Tooltip(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool animate
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_animate));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_animate)) = value;
    }
  }

  public unsafe bool ignoreTimeScale
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_ignoreTimeScale));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_ignoreTimeScale)) = value;
    }
  }

  public unsafe HashSet<Tooltip> children
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_children));
      return pointer == IntPtr.Zero ? (HashSet<Tooltip>) null : new HashSet<Tooltip>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_children), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CanvasGroup canvasGroup
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_canvasGroup));
      return pointer == IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image panel
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_panel));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite defaultPanelSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_defaultPanelSprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_defaultPanelSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color defaultPanelColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_defaultPanelColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_defaultPanelColor)) = value;
    }
  }

  public unsafe Vector3 scaleFrom
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_scaleFrom));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_scaleFrom)) = value;
    }
  }

  public unsafe AnimationCurve scaleCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_scaleCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_scaleCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float scaleDur
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_scaleDur));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_scaleDur)) = value;
    }
  }

  public unsafe float fadeFrom
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_fadeFrom));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_fadeFrom)) = value;
    }
  }

  public unsafe AnimationCurve fadeCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_fadeCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_fadeCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float fadeDur
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_fadeDur));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_fadeDur)) = value;
    }
  }
}
