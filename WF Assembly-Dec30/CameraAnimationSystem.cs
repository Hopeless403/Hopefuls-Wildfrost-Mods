// Decompiled with JetBrains decompiler
// Type: CameraAnimationSystem
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
public class CameraAnimationSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_target;
  private static readonly System.IntPtr NativeFieldInfoPtr_animations;
  private static readonly System.IntPtr NativeFieldInfoPtr_lookup;
  private static readonly System.IntPtr NativeFieldInfoPtr_running;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Run_Private_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Run_Private_Void_Animation_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56001, XrefRangeEnd = 56023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraAnimationSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56023, XrefRangeEnd = 56031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraAnimationSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56031, XrefRangeEnd = 56046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraAnimationSystem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56046, XrefRangeEnd = 56062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Run(string name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraAnimationSystem.NativeMethodInfoPtr_Run_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56062, XrefRangeEnd = 56072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Run(CameraAnimationSystem.Animation animation)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) animation))
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraAnimationSystem.NativeMethodInfoPtr_Run_Private_Void_Animation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56072, XrefRangeEnd = 56081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CameraAnimationSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraAnimationSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraAnimationSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CameraAnimationSystem()
  {
    Il2CppClassPointerStore<CameraAnimationSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CameraAnimationSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraAnimationSystem>.NativeClassPtr);
    CameraAnimationSystem.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimationSystem>.NativeClassPtr, nameof (target));
    CameraAnimationSystem.NativeFieldInfoPtr_animations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimationSystem>.NativeClassPtr, nameof (animations));
    CameraAnimationSystem.NativeFieldInfoPtr_lookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimationSystem>.NativeClassPtr, nameof (lookup));
    CameraAnimationSystem.NativeFieldInfoPtr_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimationSystem>.NativeClassPtr, nameof (running));
    CameraAnimationSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraAnimationSystem>.NativeClassPtr, 100667875);
    CameraAnimationSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraAnimationSystem>.NativeClassPtr, 100667876);
    CameraAnimationSystem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraAnimationSystem>.NativeClassPtr, 100667877);
    CameraAnimationSystem.NativeMethodInfoPtr_Run_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraAnimationSystem>.NativeClassPtr, 100667878);
    CameraAnimationSystem.NativeMethodInfoPtr_Run_Private_Void_Animation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraAnimationSystem>.NativeClassPtr, 100667879);
    CameraAnimationSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraAnimationSystem>.NativeClassPtr, 100667880);
  }

  public CameraAnimationSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Transform target
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.NativeFieldInfoPtr_target));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CameraAnimationSystem.Animation> animations
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.NativeFieldInfoPtr_animations));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CameraAnimationSystem.Animation>) null : new Il2CppReferenceArray<CameraAnimationSystem.Animation>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.NativeFieldInfoPtr_animations), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, CameraAnimationSystem.Animation> lookup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.NativeFieldInfoPtr_lookup));
      return pointer == System.IntPtr.Zero ? (Dictionary<string, CameraAnimationSystem.Animation>) null : new Dictionary<string, CameraAnimationSystem.Animation>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.NativeFieldInfoPtr_lookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<CameraAnimationSystem.RunCurve> running
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.NativeFieldInfoPtr_running));
      return pointer == System.IntPtr.Zero ? (List<CameraAnimationSystem.RunCurve>) null : new List<CameraAnimationSystem.RunCurve>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.NativeFieldInfoPtr_running), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class Animation : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_curves;

    static Animation()
    {
      Il2CppClassPointerStore<CameraAnimationSystem.Animation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraAnimationSystem>.NativeClassPtr, nameof (Animation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraAnimationSystem.Animation>.NativeClassPtr);
      CameraAnimationSystem.Animation.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimationSystem.Animation>.NativeClassPtr, nameof (name));
      CameraAnimationSystem.Animation.NativeFieldInfoPtr_curves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimationSystem.Animation>.NativeClassPtr, nameof (curves));
    }

    public Animation(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Animation()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CameraAnimationSystem.Animation>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraAnimationSystem.Animation>.NativeClassPtr, data));
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.Animation.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.Animation.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Il2CppReferenceArray<CameraAnimationSystem.Curve> curves
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.Animation.NativeFieldInfoPtr_curves));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CameraAnimationSystem.Curve>) null : new Il2CppReferenceArray<CameraAnimationSystem.Curve>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.Animation.NativeFieldInfoPtr_curves), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public sealed class Curve : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_curve;
    private static readonly System.IntPtr NativeFieldInfoPtr_moveAmount;
    private static readonly System.IntPtr NativeFieldInfoPtr_rotateAmount;
    private static readonly System.IntPtr NativeFieldInfoPtr_durationRange;

    static Curve()
    {
      Il2CppClassPointerStore<CameraAnimationSystem.Curve>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraAnimationSystem>.NativeClassPtr, nameof (Curve));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraAnimationSystem.Curve>.NativeClassPtr);
      CameraAnimationSystem.Curve.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimationSystem.Curve>.NativeClassPtr, nameof (curve));
      CameraAnimationSystem.Curve.NativeFieldInfoPtr_moveAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimationSystem.Curve>.NativeClassPtr, nameof (moveAmount));
      CameraAnimationSystem.Curve.NativeFieldInfoPtr_rotateAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimationSystem.Curve>.NativeClassPtr, nameof (rotateAmount));
      CameraAnimationSystem.Curve.NativeFieldInfoPtr_durationRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimationSystem.Curve>.NativeClassPtr, nameof (durationRange));
    }

    public Curve(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Curve()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CameraAnimationSystem.Curve>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraAnimationSystem.Curve>.NativeClassPtr, data));
    }

    public unsafe AnimationCurve curve
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.Curve.NativeFieldInfoPtr_curve));
        return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.Curve.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 moveAmount
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.Curve.NativeFieldInfoPtr_moveAmount));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.Curve.NativeFieldInfoPtr_moveAmount)) = value;
      }
    }

    public unsafe Vector3 rotateAmount
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.Curve.NativeFieldInfoPtr_rotateAmount));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.Curve.NativeFieldInfoPtr_rotateAmount)) = value;
      }
    }

    public unsafe Vector2 durationRange
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.Curve.NativeFieldInfoPtr_durationRange));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.Curve.NativeFieldInfoPtr_durationRange)) = value;
      }
    }
  }

  public class RunCurve : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_curve;
    private static readonly System.IntPtr NativeFieldInfoPtr_time;
    private static readonly System.IntPtr NativeFieldInfoPtr_duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_value;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Curve_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPosOffset_Public_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRotOffset_Public_Vector3_0;

    public unsafe bool IsDone
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraAnimationSystem.RunCurve.NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55997, XrefRangeEnd = 56000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RunCurve(CameraAnimationSystem.Curve curve)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraAnimationSystem.RunCurve>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) curve))
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CameraAnimationSystem.RunCurve.NativeMethodInfoPtr__ctor_Public_Void_Curve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56000, XrefRangeEnd = 56001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update(float delta)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &delta
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CameraAnimationSystem.RunCurve.NativeMethodInfoPtr_Update_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe Vector3 GetPosOffset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraAnimationSystem.RunCurve.NativeMethodInfoPtr_GetPosOffset_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe Vector3 GetRotOffset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraAnimationSystem.RunCurve.NativeMethodInfoPtr_GetRotOffset_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    static RunCurve()
    {
      Il2CppClassPointerStore<CameraAnimationSystem.RunCurve>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraAnimationSystem>.NativeClassPtr, nameof (RunCurve));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraAnimationSystem.RunCurve>.NativeClassPtr);
      CameraAnimationSystem.RunCurve.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimationSystem.RunCurve>.NativeClassPtr, nameof (curve));
      CameraAnimationSystem.RunCurve.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimationSystem.RunCurve>.NativeClassPtr, nameof (time));
      CameraAnimationSystem.RunCurve.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimationSystem.RunCurve>.NativeClassPtr, nameof (duration));
      CameraAnimationSystem.RunCurve.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraAnimationSystem.RunCurve>.NativeClassPtr, nameof (value));
      CameraAnimationSystem.RunCurve.NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraAnimationSystem.RunCurve>.NativeClassPtr, 100667881);
      CameraAnimationSystem.RunCurve.NativeMethodInfoPtr__ctor_Public_Void_Curve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraAnimationSystem.RunCurve>.NativeClassPtr, 100667882);
      CameraAnimationSystem.RunCurve.NativeMethodInfoPtr_Update_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraAnimationSystem.RunCurve>.NativeClassPtr, 100667883);
      CameraAnimationSystem.RunCurve.NativeMethodInfoPtr_GetPosOffset_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraAnimationSystem.RunCurve>.NativeClassPtr, 100667884);
      CameraAnimationSystem.RunCurve.NativeMethodInfoPtr_GetRotOffset_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraAnimationSystem.RunCurve>.NativeClassPtr, 100667885);
    }

    public RunCurve(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public CameraAnimationSystem.Curve curve
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.RunCurve.NativeFieldInfoPtr_curve);
        return new CameraAnimationSystem.Curve(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraAnimationSystem.Curve>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.RunCurve.NativeFieldInfoPtr_curve), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CameraAnimationSystem.Curve>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe float time
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.RunCurve.NativeFieldInfoPtr_time));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.RunCurve.NativeFieldInfoPtr_time)) = value;
      }
    }

    public unsafe float duration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.RunCurve.NativeFieldInfoPtr_duration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.RunCurve.NativeFieldInfoPtr_duration)) = value;
      }
    }

    public unsafe float value
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.RunCurve.NativeFieldInfoPtr_value));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraAnimationSystem.RunCurve.NativeFieldInfoPtr_value)) = value;
      }
    }
  }
}
