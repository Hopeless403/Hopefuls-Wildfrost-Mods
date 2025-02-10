// Decompiled with JetBrains decompiler
// Type: Fader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class Fader : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr__graphic;
  private static readonly IntPtr NativeFieldInfoPtr_gradient;
  private static readonly IntPtr NativeFieldInfoPtr_startFadedIn;
  private static readonly IntPtr NativeFieldInfoPtr_ease;
  private static readonly IntPtr NativeFieldInfoPtr_delay;
  private static readonly IntPtr NativeFieldInfoPtr_dur;
  private static readonly IntPtr NativeFieldInfoPtr_onAwake;
  private static readonly IntPtr NativeFieldInfoPtr_onEnable;
  private static readonly IntPtr NativeFieldInfoPtr_loop;
  private static readonly IntPtr NativeFieldInfoPtr_ignoreTimeScale;
  private static readonly IntPtr NativeFieldInfoPtr_current;
  private static readonly IntPtr NativeMethodInfoPtr_get_graphic_Private_get_Graphic_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Set_Private_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_In_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_In_Public_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_In_Public_Void_Single_LeanTweenType_0;
  private static readonly IntPtr NativeMethodInfoPtr_Out_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Out_Public_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Out_Public_Void_Single_LeanTweenType_0;
  private static readonly IntPtr NativeMethodInfoPtr_Tween_Private_Void_Single_Single_LeanTweenType_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe Graphic graphic
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89688, XrefRangeEnd = 89692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(Fader.NativeMethodInfoPtr_get_graphic_Private_get_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Graphic) null : new Graphic(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89692, XrefRangeEnd = 89695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Fader.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89695, XrefRangeEnd = 89697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Fader.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 89702, RefRangeEnd = 89704, XrefRangeStart = 89697, XrefRangeEnd = 89702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Fader.NativeMethodInfoPtr_Set_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 89705, RefRangeEnd = 89706, XrefRangeStart = 89704, XrefRangeEnd = 89705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void In()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Fader.NativeMethodInfoPtr_In_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89706, XrefRangeEnd = 89707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void In(float dur)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &dur
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Fader.NativeMethodInfoPtr_In_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89707, XrefRangeEnd = 89708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void In(float dur, LeanTweenType ease)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &dur;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &ease;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Fader.NativeMethodInfoPtr_In_Public_Void_Single_LeanTweenType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 89709, RefRangeEnd = 89710, XrefRangeStart = 89708, XrefRangeEnd = 89709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Out()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Fader.NativeMethodInfoPtr_Out_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 89711, RefRangeEnd = 89712, XrefRangeStart = 89710, XrefRangeEnd = 89711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Out(float dur)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &dur
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Fader.NativeMethodInfoPtr_Out_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 89713, RefRangeEnd = 89714, XrefRangeStart = 89712, XrefRangeEnd = 89713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Out(float dur, LeanTweenType ease)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &dur;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &ease;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Fader.NativeMethodInfoPtr_Out_Public_Void_Single_LeanTweenType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 89732, RefRangeEnd = 89740, XrefRangeStart = 89714, XrefRangeEnd = 89732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Tween(float to, float dur, LeanTweenType ease)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &to;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dur;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &ease;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Fader.NativeMethodInfoPtr_Tween_Private_Void_Single_Single_LeanTweenType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89740, XrefRangeEnd = 89741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Fader()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fader>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Fader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Fader()
  {
    Il2CppClassPointerStore<Fader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Fader));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fader>.NativeClassPtr);
    Fader.NativeFieldInfoPtr__graphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fader>.NativeClassPtr, nameof (_graphic));
    Fader.NativeFieldInfoPtr_gradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fader>.NativeClassPtr, nameof (gradient));
    Fader.NativeFieldInfoPtr_startFadedIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fader>.NativeClassPtr, nameof (startFadedIn));
    Fader.NativeFieldInfoPtr_ease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fader>.NativeClassPtr, nameof (ease));
    Fader.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fader>.NativeClassPtr, nameof (delay));
    Fader.NativeFieldInfoPtr_dur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fader>.NativeClassPtr, nameof (dur));
    Fader.NativeFieldInfoPtr_onAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fader>.NativeClassPtr, nameof (onAwake));
    Fader.NativeFieldInfoPtr_onEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fader>.NativeClassPtr, nameof (onEnable));
    Fader.NativeFieldInfoPtr_loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fader>.NativeClassPtr, nameof (loop));
    Fader.NativeFieldInfoPtr_ignoreTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fader>.NativeClassPtr, nameof (ignoreTimeScale));
    Fader.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fader>.NativeClassPtr, nameof (current));
    Fader.NativeMethodInfoPtr_get_graphic_Private_get_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fader>.NativeClassPtr, 100670934);
    Fader.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fader>.NativeClassPtr, 100670935);
    Fader.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fader>.NativeClassPtr, 100670936);
    Fader.NativeMethodInfoPtr_Set_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fader>.NativeClassPtr, 100670937);
    Fader.NativeMethodInfoPtr_In_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fader>.NativeClassPtr, 100670938);
    Fader.NativeMethodInfoPtr_In_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fader>.NativeClassPtr, 100670939);
    Fader.NativeMethodInfoPtr_In_Public_Void_Single_LeanTweenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fader>.NativeClassPtr, 100670940);
    Fader.NativeMethodInfoPtr_Out_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fader>.NativeClassPtr, 100670941);
    Fader.NativeMethodInfoPtr_Out_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fader>.NativeClassPtr, 100670942);
    Fader.NativeMethodInfoPtr_Out_Public_Void_Single_LeanTweenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fader>.NativeClassPtr, 100670943);
    Fader.NativeMethodInfoPtr_Tween_Private_Void_Single_Single_LeanTweenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fader>.NativeClassPtr, 100670944);
    Fader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fader>.NativeClassPtr, 100670945);
  }

  public Fader(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Graphic _graphic
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fader.NativeFieldInfoPtr__graphic));
      return pointer == IntPtr.Zero ? (Graphic) null : new Graphic(pointer);
    }
    [param: System.Runtime.InteropServices.In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Fader.NativeFieldInfoPtr__graphic), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Gradient gradient
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fader.NativeFieldInfoPtr_gradient));
      return pointer == IntPtr.Zero ? (Gradient) null : new Gradient(pointer);
    }
    [param: System.Runtime.InteropServices.In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Fader.NativeFieldInfoPtr_gradient), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool startFadedIn
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fader.NativeFieldInfoPtr_startFadedIn));
    }
    [param: System.Runtime.InteropServices.In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fader.NativeFieldInfoPtr_startFadedIn)) = value;
    }
  }

  public unsafe LeanTweenType ease
  {
    get
    {
      return *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fader.NativeFieldInfoPtr_ease));
    }
    [param: System.Runtime.InteropServices.In] set
    {
      *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fader.NativeFieldInfoPtr_ease)) = value;
    }
  }

  public unsafe float delay
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fader.NativeFieldInfoPtr_delay));
    }
    [param: System.Runtime.InteropServices.In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fader.NativeFieldInfoPtr_delay)) = value;
    }
  }

  public unsafe float dur
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fader.NativeFieldInfoPtr_dur));
    }
    [param: System.Runtime.InteropServices.In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fader.NativeFieldInfoPtr_dur)) = value;
    }
  }

  public unsafe bool onAwake
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fader.NativeFieldInfoPtr_onAwake));
    }
    [param: System.Runtime.InteropServices.In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fader.NativeFieldInfoPtr_onAwake)) = value;
    }
  }

  public unsafe bool onEnable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fader.NativeFieldInfoPtr_onEnable));
    }
    [param: System.Runtime.InteropServices.In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fader.NativeFieldInfoPtr_onEnable)) = value;
    }
  }

  public unsafe bool loop
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fader.NativeFieldInfoPtr_loop));
    }
    [param: System.Runtime.InteropServices.In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fader.NativeFieldInfoPtr_loop)) = value;
    }
  }

  public unsafe bool ignoreTimeScale
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fader.NativeFieldInfoPtr_ignoreTimeScale));
    }
    [param: System.Runtime.InteropServices.In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fader.NativeFieldInfoPtr_ignoreTimeScale)) = value;
    }
  }

  public unsafe float current
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fader.NativeFieldInfoPtr_current));
    }
    [param: System.Runtime.InteropServices.In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fader.NativeFieldInfoPtr_current)) = value;
    }
  }
}
