// Decompiled with JetBrains decompiler
// Type: Glow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class Glow : MonoBehaviourRect
{
  private static readonly IntPtr NativeFieldInfoPtr_image;
  private static readonly IntPtr NativeFieldInfoPtr_fadeCurve;
  private static readonly IntPtr NativeFieldInfoPtr_fadeDuration;
  private static readonly IntPtr NativeFieldInfoPtr_delay;
  private static readonly IntPtr NativeFieldInfoPtr_t;
  private static readonly IntPtr NativeMethodInfoPtr_SetSize_Public_Glow_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Glow_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Glow_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_RandomColor_Public_Glow_Single_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Fade_Public_Glow_AnimationCurve_Single_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50633, XrefRangeEnd = 50635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Glow SetSize(Vector2 size)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &size
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(Glow.NativeMethodInfoPtr_SetSize_Public_Glow_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (Glow) null : new Glow(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50635, XrefRangeEnd = 50637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Glow SetPosition(Vector2 position)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &position
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(Glow.NativeMethodInfoPtr_SetPosition_Public_Glow_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (Glow) null : new Glow(pointer);
  }

  [CallerCount(0)]
  public unsafe Glow SetColor(Color color)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &color
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(Glow.NativeMethodInfoPtr_SetColor_Public_Glow_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (Glow) null : new Glow(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50637, XrefRangeEnd = 50639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Glow RandomColor(float saturation = 1f, float brightness = 1f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &saturation;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &brightness;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(Glow.NativeMethodInfoPtr_RandomColor_Public_Glow_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (Glow) null : new Glow(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50639, XrefRangeEnd = 50641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Glow Fade(AnimationCurve curve, float duration, float delay = 0.0f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) curve);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &duration;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &delay;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(Glow.NativeMethodInfoPtr_Fade_Public_Glow_AnimationCurve_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (Glow) null : new Glow(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50641, XrefRangeEnd = 50649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Glow.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50649, XrefRangeEnd = 50650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Glow()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Glow>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Glow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Glow()
  {
    Il2CppClassPointerStore<Glow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Glow));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Glow>.NativeClassPtr);
    Glow.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glow>.NativeClassPtr, nameof (image));
    Glow.NativeFieldInfoPtr_fadeCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glow>.NativeClassPtr, nameof (fadeCurve));
    Glow.NativeFieldInfoPtr_fadeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glow>.NativeClassPtr, nameof (fadeDuration));
    Glow.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glow>.NativeClassPtr, nameof (delay));
    Glow.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glow>.NativeClassPtr, nameof (t));
    Glow.NativeMethodInfoPtr_SetSize_Public_Glow_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glow>.NativeClassPtr, 100667326);
    Glow.NativeMethodInfoPtr_SetPosition_Public_Glow_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glow>.NativeClassPtr, 100667327);
    Glow.NativeMethodInfoPtr_SetColor_Public_Glow_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glow>.NativeClassPtr, 100667328);
    Glow.NativeMethodInfoPtr_RandomColor_Public_Glow_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glow>.NativeClassPtr, 100667329);
    Glow.NativeMethodInfoPtr_Fade_Public_Glow_AnimationCurve_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glow>.NativeClassPtr, 100667330);
    Glow.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glow>.NativeClassPtr, 100667331);
    Glow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glow>.NativeClassPtr, 100667332);
  }

  public Glow(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Image image
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Glow.NativeFieldInfoPtr_image));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Glow.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve fadeCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Glow.NativeFieldInfoPtr_fadeCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Glow.NativeFieldInfoPtr_fadeCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float fadeDuration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Glow.NativeFieldInfoPtr_fadeDuration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Glow.NativeFieldInfoPtr_fadeDuration)) = value;
    }
  }

  public unsafe float delay
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Glow.NativeFieldInfoPtr_delay));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Glow.NativeFieldInfoPtr_delay)) = value;
    }
  }

  public unsafe float t
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Glow.NativeFieldInfoPtr_t));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Glow.NativeFieldInfoPtr_t)) = value;
    }
  }
}
