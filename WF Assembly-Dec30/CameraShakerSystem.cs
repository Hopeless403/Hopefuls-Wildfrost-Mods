// Decompiled with JetBrains decompiler
// Type: CameraShakerSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class CameraShakerSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_target;
  private static readonly System.IntPtr NativeFieldInfoPtr_magnitudeMod;
  private static readonly System.IntPtr NativeFieldInfoPtr_angularMod;
  private static readonly System.IntPtr NativeFieldInfoPtr_accelerationMod;
  private static readonly System.IntPtr NativeFieldInfoPtr_hitStrengthCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_frict;
  private static readonly System.IntPtr NativeFieldInfoPtr_angleRand;
  private static readonly System.IntPtr NativeFieldInfoPtr_angularFrict;
  private static readonly System.IntPtr NativeFieldInfoPtr_positionInfluence;
  private static readonly System.IntPtr NativeFieldInfoPtr_rotationInfluence;
  private static readonly System.IntPtr NativeFieldInfoPtr_pos;
  private static readonly System.IntPtr NativeFieldInfoPtr_velocity;
  private static readonly System.IntPtr NativeFieldInfoPtr_angle;
  private static readonly System.IntPtr NativeFieldInfoPtr_angularSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_ShakeAmount;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SettingChanged_Private_Static_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Hit_Private_Void_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Shake_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Shake_Public_Void_Single_Nullable_1_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHitDirection_Public_Single_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56131, XrefRangeEnd = 56162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraShakerSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56162, XrefRangeEnd = 56197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraShakerSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56197, XrefRangeEnd = 56205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SettingChanged(string key, Il2CppSystem.Object value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraShakerSystem.NativeMethodInfoPtr_SettingChanged_Private_Static_Void_String_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56205, XrefRangeEnd = 56222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hit(global::Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraShakerSystem.NativeMethodInfoPtr_Hit_Private_Void_Hit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56222, XrefRangeEnd = 56227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Shake(float magnitude = 1f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &magnitude
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraShakerSystem.NativeMethodInfoPtr_Shake_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 56242, RefRangeEnd = 56244, XrefRangeStart = 56227, XrefRangeEnd = 56242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Shake(float magnitude = 1f, Il2CppSystem.Nullable<float> direction = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &magnitude;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) direction));
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraShakerSystem.NativeMethodInfoPtr_Shake_Public_Void_Single_Nullable_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56244, XrefRangeEnd = 56258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Stop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraShakerSystem.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56258, XrefRangeEnd = 56274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraShakerSystem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56274, XrefRangeEnd = 56283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetHitDirection(global::Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraShakerSystem.NativeMethodInfoPtr_GetHitDirection_Public_Single_Hit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56283, XrefRangeEnd = 56284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CameraShakerSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraShakerSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CameraShakerSystem()
  {
    Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CameraShakerSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr);
    CameraShakerSystem.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, nameof (target));
    CameraShakerSystem.NativeFieldInfoPtr_magnitudeMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, nameof (magnitudeMod));
    CameraShakerSystem.NativeFieldInfoPtr_angularMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, nameof (angularMod));
    CameraShakerSystem.NativeFieldInfoPtr_accelerationMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, nameof (accelerationMod));
    CameraShakerSystem.NativeFieldInfoPtr_hitStrengthCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, nameof (hitStrengthCurve));
    CameraShakerSystem.NativeFieldInfoPtr_frict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, nameof (frict));
    CameraShakerSystem.NativeFieldInfoPtr_angleRand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, nameof (angleRand));
    CameraShakerSystem.NativeFieldInfoPtr_angularFrict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, nameof (angularFrict));
    CameraShakerSystem.NativeFieldInfoPtr_positionInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, nameof (positionInfluence));
    CameraShakerSystem.NativeFieldInfoPtr_rotationInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, nameof (rotationInfluence));
    CameraShakerSystem.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, nameof (pos));
    CameraShakerSystem.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, nameof (velocity));
    CameraShakerSystem.NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, nameof (angle));
    CameraShakerSystem.NativeFieldInfoPtr_angularSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, nameof (angularSpeed));
    CameraShakerSystem.NativeFieldInfoPtr_ShakeAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, nameof (ShakeAmount));
    CameraShakerSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, 100667891);
    CameraShakerSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, 100667892);
    CameraShakerSystem.NativeMethodInfoPtr_SettingChanged_Private_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, 100667893);
    CameraShakerSystem.NativeMethodInfoPtr_Hit_Private_Void_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, 100667894);
    CameraShakerSystem.NativeMethodInfoPtr_Shake_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, 100667895);
    CameraShakerSystem.NativeMethodInfoPtr_Shake_Public_Void_Single_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, 100667896);
    CameraShakerSystem.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, 100667897);
    CameraShakerSystem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, 100667898);
    CameraShakerSystem.NativeMethodInfoPtr_GetHitDirection_Public_Single_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, 100667899);
    CameraShakerSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraShakerSystem>.NativeClassPtr, 100667900);
  }

  public CameraShakerSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Transform target
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_target));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float magnitudeMod
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_magnitudeMod));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_magnitudeMod)) = value;
    }
  }

  public unsafe float angularMod
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_angularMod));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_angularMod)) = value;
    }
  }

  public unsafe float accelerationMod
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_accelerationMod));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_accelerationMod)) = value;
    }
  }

  public unsafe AnimationCurve hitStrengthCurve
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_hitStrengthCurve));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_hitStrengthCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float frict
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_frict));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_frict)) = value;
    }
  }

  public unsafe float angleRand
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_angleRand));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_angleRand)) = value;
    }
  }

  public unsafe float angularFrict
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_angularFrict));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_angularFrict)) = value;
    }
  }

  public unsafe Vector3 positionInfluence
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_positionInfluence));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_positionInfluence)) = value;
    }
  }

  public unsafe Vector3 rotationInfluence
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_rotationInfluence));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_rotationInfluence)) = value;
    }
  }

  public unsafe Vector2 pos
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_pos));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_pos)) = value;
    }
  }

  public unsafe Vector2 velocity
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_velocity));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_velocity)) = value;
    }
  }

  public unsafe float angle
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_angle));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_angle)) = value;
    }
  }

  public unsafe float angularSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_angularSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakerSystem.NativeFieldInfoPtr_angularSpeed)) = value;
    }
  }

  public static unsafe float ShakeAmount
  {
    get
    {
      float shakeAmount;
      IL2CPP.il2cpp_field_static_get_value(CameraShakerSystem.NativeFieldInfoPtr_ShakeAmount, (void*) &shakeAmount);
      return shakeAmount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CameraShakerSystem.NativeFieldInfoPtr_ShakeAmount, (void*) &value);
    }
  }
}
