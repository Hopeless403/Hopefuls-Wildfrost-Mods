// Decompiled with JetBrains decompiler
// Type: Blink
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
public class Blink : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_onRange;
  private static readonly IntPtr NativeFieldInfoPtr_offRange;
  private static readonly IntPtr NativeFieldInfoPtr_blinkCurve;
  private static readonly IntPtr NativeFieldInfoPtr_unblinkCurve;
  private static readonly IntPtr NativeFieldInfoPtr_blinkCurveDuration;
  private static readonly IntPtr NativeFieldInfoPtr_startOn;
  private static readonly IntPtr NativeFieldInfoPtr_on;
  private static readonly IntPtr NativeFieldInfoPtr_timer;
  private static readonly IntPtr NativeFieldInfoPtr_preScaleY;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Toggle_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30820, XrefRangeEnd = 30825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Blink.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30825, XrefRangeEnd = 30827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Blink.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 30846, RefRangeEnd = 30847, XrefRangeStart = 30827, XrefRangeEnd = 30846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Toggle()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Blink.NativeMethodInfoPtr_Toggle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30847, XrefRangeEnd = 30848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Blink()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Blink>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Blink.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Blink()
  {
    Il2CppClassPointerStore<Blink>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Blink));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Blink>.NativeClassPtr);
    Blink.NativeFieldInfoPtr_onRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blink>.NativeClassPtr, nameof (onRange));
    Blink.NativeFieldInfoPtr_offRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blink>.NativeClassPtr, nameof (offRange));
    Blink.NativeFieldInfoPtr_blinkCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blink>.NativeClassPtr, nameof (blinkCurve));
    Blink.NativeFieldInfoPtr_unblinkCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blink>.NativeClassPtr, nameof (unblinkCurve));
    Blink.NativeFieldInfoPtr_blinkCurveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blink>.NativeClassPtr, nameof (blinkCurveDuration));
    Blink.NativeFieldInfoPtr_startOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blink>.NativeClassPtr, nameof (startOn));
    Blink.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blink>.NativeClassPtr, nameof (on));
    Blink.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blink>.NativeClassPtr, nameof (timer));
    Blink.NativeFieldInfoPtr_preScaleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blink>.NativeClassPtr, nameof (preScaleY));
    Blink.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blink>.NativeClassPtr, 100665092);
    Blink.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blink>.NativeClassPtr, 100665093);
    Blink.NativeMethodInfoPtr_Toggle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blink>.NativeClassPtr, 100665094);
    Blink.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blink>.NativeClassPtr, 100665095);
  }

  public Blink(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Vector2 onRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Blink.NativeFieldInfoPtr_onRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Blink.NativeFieldInfoPtr_onRange)) = value;
    }
  }

  public unsafe Vector2 offRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Blink.NativeFieldInfoPtr_offRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Blink.NativeFieldInfoPtr_offRange)) = value;
    }
  }

  public unsafe AnimationCurve blinkCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Blink.NativeFieldInfoPtr_blinkCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Blink.NativeFieldInfoPtr_blinkCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve unblinkCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Blink.NativeFieldInfoPtr_unblinkCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Blink.NativeFieldInfoPtr_unblinkCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float blinkCurveDuration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Blink.NativeFieldInfoPtr_blinkCurveDuration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Blink.NativeFieldInfoPtr_blinkCurveDuration)) = value;
    }
  }

  public unsafe bool startOn
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Blink.NativeFieldInfoPtr_startOn));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Blink.NativeFieldInfoPtr_startOn)) = value;
    }
  }

  public unsafe bool on
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Blink.NativeFieldInfoPtr_on));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Blink.NativeFieldInfoPtr_on)) = value;
    }
  }

  public unsafe float timer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Blink.NativeFieldInfoPtr_timer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Blink.NativeFieldInfoPtr_timer)) = value;
    }
  }

  public unsafe float preScaleY
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Blink.NativeFieldInfoPtr_preScaleY));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Blink.NativeFieldInfoPtr_preScaleY)) = value;
    }
  }
}
