// Decompiled with JetBrains decompiler
// Type: CameraRumbleSystem
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
public class CameraRumbleSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_target;
  private static readonly IntPtr NativeFieldInfoPtr_strength;
  private static readonly IntPtr NativeFieldInfoPtr_positionInfluence;
  private static readonly IntPtr NativeFieldInfoPtr_rotationInfluence;
  private static readonly IntPtr NativeFieldInfoPtr_t;
  private static readonly IntPtr NativeFieldInfoPtr_d;
  private static readonly IntPtr NativeFieldInfoPtr_curve;
  private static readonly IntPtr NativeFieldInfoPtr_active;
  private static readonly IntPtr NativeFieldInfoPtr_delay;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Rumble_Private_Void_Single_Single_Single_Single_Single_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56081, XrefRangeEnd = 56089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraRumbleSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56089, XrefRangeEnd = 56097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraRumbleSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56097, XrefRangeEnd = 56112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraRumbleSystem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56112, XrefRangeEnd = 56130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Rumble(
    float startStrength,
    float endStrength,
    float delay,
    float fadeInTime,
    float holdTime,
    float fadeOutTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[6];
    numPtr[0] = (IntPtr) &startStrength;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &endStrength;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &delay;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &fadeInTime;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &holdTime;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &fadeOutTime;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraRumbleSystem.NativeMethodInfoPtr_Rumble_Private_Void_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56130, XrefRangeEnd = 56131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CameraRumbleSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraRumbleSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraRumbleSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CameraRumbleSystem()
  {
    Il2CppClassPointerStore<CameraRumbleSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CameraRumbleSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraRumbleSystem>.NativeClassPtr);
    CameraRumbleSystem.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRumbleSystem>.NativeClassPtr, nameof (target));
    CameraRumbleSystem.NativeFieldInfoPtr_strength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRumbleSystem>.NativeClassPtr, nameof (strength));
    CameraRumbleSystem.NativeFieldInfoPtr_positionInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRumbleSystem>.NativeClassPtr, nameof (positionInfluence));
    CameraRumbleSystem.NativeFieldInfoPtr_rotationInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRumbleSystem>.NativeClassPtr, nameof (rotationInfluence));
    CameraRumbleSystem.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRumbleSystem>.NativeClassPtr, nameof (t));
    CameraRumbleSystem.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRumbleSystem>.NativeClassPtr, nameof (d));
    CameraRumbleSystem.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRumbleSystem>.NativeClassPtr, nameof (curve));
    CameraRumbleSystem.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRumbleSystem>.NativeClassPtr, nameof (active));
    CameraRumbleSystem.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRumbleSystem>.NativeClassPtr, nameof (delay));
    CameraRumbleSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRumbleSystem>.NativeClassPtr, 100667886);
    CameraRumbleSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRumbleSystem>.NativeClassPtr, 100667887);
    CameraRumbleSystem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRumbleSystem>.NativeClassPtr, 100667888);
    CameraRumbleSystem.NativeMethodInfoPtr_Rumble_Private_Void_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRumbleSystem>.NativeClassPtr, 100667889);
    CameraRumbleSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRumbleSystem>.NativeClassPtr, 100667890);
  }

  public CameraRumbleSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Transform target
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraRumbleSystem.NativeFieldInfoPtr_target));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CameraRumbleSystem.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float strength
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraRumbleSystem.NativeFieldInfoPtr_strength));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraRumbleSystem.NativeFieldInfoPtr_strength)) = value;
    }
  }

  public unsafe Vector3 positionInfluence
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraRumbleSystem.NativeFieldInfoPtr_positionInfluence));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraRumbleSystem.NativeFieldInfoPtr_positionInfluence)) = value;
    }
  }

  public unsafe Vector3 rotationInfluence
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraRumbleSystem.NativeFieldInfoPtr_rotationInfluence));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraRumbleSystem.NativeFieldInfoPtr_rotationInfluence)) = value;
    }
  }

  public unsafe float t
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraRumbleSystem.NativeFieldInfoPtr_t));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraRumbleSystem.NativeFieldInfoPtr_t)) = value;
    }
  }

  public unsafe float d
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraRumbleSystem.NativeFieldInfoPtr_d));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraRumbleSystem.NativeFieldInfoPtr_d)) = value;
    }
  }

  public unsafe AnimationCurve curve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraRumbleSystem.NativeFieldInfoPtr_curve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CameraRumbleSystem.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool active
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraRumbleSystem.NativeFieldInfoPtr_active));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraRumbleSystem.NativeFieldInfoPtr_active)) = value;
    }
  }

  public unsafe float delay
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraRumbleSystem.NativeFieldInfoPtr_delay));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraRumbleSystem.NativeFieldInfoPtr_delay)) = value;
    }
  }
}
