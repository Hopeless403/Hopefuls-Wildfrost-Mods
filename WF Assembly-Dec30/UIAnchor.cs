// Decompiled with JetBrains decompiler
// Type: UIAnchor
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
public class UIAnchor : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_revealDur;
  private static readonly IntPtr NativeFieldInfoPtr_hideDur;
  private static readonly IntPtr NativeFieldInfoPtr_angleStart;
  private static readonly IntPtr NativeFieldInfoPtr_angleRandomSign;
  private static readonly IntPtr NativeFieldInfoPtr_angleTweenEase;
  private static readonly IntPtr NativeFieldInfoPtr_angleHide;
  private static readonly IntPtr NativeFieldInfoPtr_angleHideRandomSign;
  private static readonly IntPtr NativeFieldInfoPtr_angleHideTweenEase;
  private static readonly IntPtr NativeFieldInfoPtr_scaleStart;
  private static readonly IntPtr NativeFieldInfoPtr_scaleTweenEase;
  private static readonly IntPtr NativeFieldInfoPtr_scaleHide;
  private static readonly IntPtr NativeFieldInfoPtr_scaleHideTweenEase;
  private static readonly IntPtr NativeFieldInfoPtr_wobbleAmount;
  private static readonly IntPtr NativeFieldInfoPtr_doFadeIn;
  private static readonly IntPtr NativeFieldInfoPtr_fadeInDur;
  private static readonly IntPtr NativeFieldInfoPtr_doFadeOut;
  private static readonly IntPtr NativeFieldInfoPtr_fadeOutDur;
  private static readonly IntPtr NativeMethodInfoPtr_SetUp_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reveal_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnReveal_Public_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100203, XrefRangeEnd = 100220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetUp()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UIAnchor.NativeMethodInfoPtr_SetUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 100259, RefRangeEnd = 100260, XrefRangeStart = 100220, XrefRangeEnd = 100259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reveal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UIAnchor.NativeMethodInfoPtr_Reveal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 100291, RefRangeEnd = 100292, XrefRangeStart = 100260, XrefRangeEnd = 100291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnReveal(float delay = 0.0f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &delay
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UIAnchor.NativeMethodInfoPtr_UnReveal_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100292, XrefRangeEnd = 100297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIAnchor()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UIAnchor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static UIAnchor()
  {
    Il2CppClassPointerStore<UIAnchor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (UIAnchor));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr);
    UIAnchor.NativeFieldInfoPtr_revealDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, nameof (revealDur));
    UIAnchor.NativeFieldInfoPtr_hideDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, nameof (hideDur));
    UIAnchor.NativeFieldInfoPtr_angleStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, nameof (angleStart));
    UIAnchor.NativeFieldInfoPtr_angleRandomSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, nameof (angleRandomSign));
    UIAnchor.NativeFieldInfoPtr_angleTweenEase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, nameof (angleTweenEase));
    UIAnchor.NativeFieldInfoPtr_angleHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, nameof (angleHide));
    UIAnchor.NativeFieldInfoPtr_angleHideRandomSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, nameof (angleHideRandomSign));
    UIAnchor.NativeFieldInfoPtr_angleHideTweenEase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, nameof (angleHideTweenEase));
    UIAnchor.NativeFieldInfoPtr_scaleStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, nameof (scaleStart));
    UIAnchor.NativeFieldInfoPtr_scaleTweenEase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, nameof (scaleTweenEase));
    UIAnchor.NativeFieldInfoPtr_scaleHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, nameof (scaleHide));
    UIAnchor.NativeFieldInfoPtr_scaleHideTweenEase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, nameof (scaleHideTweenEase));
    UIAnchor.NativeFieldInfoPtr_wobbleAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, nameof (wobbleAmount));
    UIAnchor.NativeFieldInfoPtr_doFadeIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, nameof (doFadeIn));
    UIAnchor.NativeFieldInfoPtr_fadeInDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, nameof (fadeInDur));
    UIAnchor.NativeFieldInfoPtr_doFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, nameof (doFadeOut));
    UIAnchor.NativeFieldInfoPtr_fadeOutDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, nameof (fadeOutDur));
    UIAnchor.NativeMethodInfoPtr_SetUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, 100672286);
    UIAnchor.NativeMethodInfoPtr_Reveal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, 100672287);
    UIAnchor.NativeMethodInfoPtr_UnReveal_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, 100672288);
    UIAnchor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAnchor>.NativeClassPtr, 100672289);
  }

  public UIAnchor(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float revealDur
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_revealDur));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_revealDur)) = value;
    }
  }

  public unsafe float hideDur
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_hideDur));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_hideDur)) = value;
    }
  }

  public unsafe Vector3 angleStart
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_angleStart));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_angleStart)) = value;
    }
  }

  public unsafe bool angleRandomSign
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_angleRandomSign));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_angleRandomSign)) = value;
    }
  }

  public unsafe LeanTweenType angleTweenEase
  {
    get
    {
      return *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_angleTweenEase));
    }
    [param: In] set
    {
      *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_angleTweenEase)) = value;
    }
  }

  public unsafe Vector3 angleHide
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_angleHide));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_angleHide)) = value;
    }
  }

  public unsafe bool angleHideRandomSign
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_angleHideRandomSign));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_angleHideRandomSign)) = value;
    }
  }

  public unsafe LeanTweenType angleHideTweenEase
  {
    get
    {
      return *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_angleHideTweenEase));
    }
    [param: In] set
    {
      *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_angleHideTweenEase)) = value;
    }
  }

  public unsafe Vector3 scaleStart
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_scaleStart));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_scaleStart)) = value;
    }
  }

  public unsafe LeanTweenType scaleTweenEase
  {
    get
    {
      return *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_scaleTweenEase));
    }
    [param: In] set
    {
      *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_scaleTweenEase)) = value;
    }
  }

  public unsafe Vector3 scaleHide
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_scaleHide));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_scaleHide)) = value;
    }
  }

  public unsafe LeanTweenType scaleHideTweenEase
  {
    get
    {
      return *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_scaleHideTweenEase));
    }
    [param: In] set
    {
      *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_scaleHideTweenEase)) = value;
    }
  }

  public unsafe float wobbleAmount
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_wobbleAmount));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_wobbleAmount)) = value;
    }
  }

  public unsafe bool doFadeIn
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_doFadeIn));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_doFadeIn)) = value;
    }
  }

  public unsafe float fadeInDur
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_fadeInDur));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_fadeInDur)) = value;
    }
  }

  public unsafe bool doFadeOut
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_doFadeOut));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_doFadeOut)) = value;
    }
  }

  public unsafe float fadeOutDur
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_fadeOutDur));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAnchor.NativeFieldInfoPtr_fadeOutDur)) = value;
    }
  }
}
