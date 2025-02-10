// Decompiled with JetBrains decompiler
// Type: Swayer
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
public class Swayer : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_randomStart;
  private static readonly IntPtr NativeFieldInfoPtr_swayPosition;
  private static readonly IntPtr NativeFieldInfoPtr_positionInfluence;
  private static readonly IntPtr NativeFieldInfoPtr_positionSway;
  private static readonly IntPtr NativeFieldInfoPtr_swayRotation;
  private static readonly IntPtr NativeFieldInfoPtr_rotationInfluence;
  private static readonly IntPtr NativeFieldInfoPtr_rotationSway;
  private static readonly IntPtr NativeFieldInfoPtr_startPosition;
  private static readonly IntPtr NativeFieldInfoPtr_startRotation;
  private static readonly IntPtr NativeFieldInfoPtr_t;
  private static readonly IntPtr NativeFieldInfoPtr_transform;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SwayPositionToggled_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SwayRotationToggled_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54569, XrefRangeEnd = 54576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Swayer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54576, XrefRangeEnd = 54585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Swayer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54585, XrefRangeEnd = 54586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SwayPositionToggled()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Swayer.NativeMethodInfoPtr_SwayPositionToggled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54586, XrefRangeEnd = 54587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SwayRotationToggled()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Swayer.NativeMethodInfoPtr_SwayRotationToggled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54587, XrefRangeEnd = 54596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Swayer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Swayer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Swayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Swayer()
  {
    Il2CppClassPointerStore<Swayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Swayer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Swayer>.NativeClassPtr);
    Swayer.NativeFieldInfoPtr_randomStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swayer>.NativeClassPtr, nameof (randomStart));
    Swayer.NativeFieldInfoPtr_swayPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swayer>.NativeClassPtr, nameof (swayPosition));
    Swayer.NativeFieldInfoPtr_positionInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swayer>.NativeClassPtr, nameof (positionInfluence));
    Swayer.NativeFieldInfoPtr_positionSway = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swayer>.NativeClassPtr, nameof (positionSway));
    Swayer.NativeFieldInfoPtr_swayRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swayer>.NativeClassPtr, nameof (swayRotation));
    Swayer.NativeFieldInfoPtr_rotationInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swayer>.NativeClassPtr, nameof (rotationInfluence));
    Swayer.NativeFieldInfoPtr_rotationSway = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swayer>.NativeClassPtr, nameof (rotationSway));
    Swayer.NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swayer>.NativeClassPtr, nameof (startPosition));
    Swayer.NativeFieldInfoPtr_startRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swayer>.NativeClassPtr, nameof (startRotation));
    Swayer.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swayer>.NativeClassPtr, nameof (t));
    Swayer.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swayer>.NativeClassPtr, nameof (transform));
    Swayer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Swayer>.NativeClassPtr, 100667793);
    Swayer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Swayer>.NativeClassPtr, 100667794);
    Swayer.NativeMethodInfoPtr_SwayPositionToggled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Swayer>.NativeClassPtr, 100667795);
    Swayer.NativeMethodInfoPtr_SwayRotationToggled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Swayer>.NativeClassPtr, 100667796);
    Swayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Swayer>.NativeClassPtr, 100667797);
  }

  public Swayer(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool randomStart
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swayer.NativeFieldInfoPtr_randomStart));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swayer.NativeFieldInfoPtr_randomStart)) = value;
    }
  }

  public unsafe bool swayPosition
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swayer.NativeFieldInfoPtr_swayPosition));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swayer.NativeFieldInfoPtr_swayPosition)) = value;
    }
  }

  public unsafe Vector3 positionInfluence
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swayer.NativeFieldInfoPtr_positionInfluence));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swayer.NativeFieldInfoPtr_positionInfluence)) = value;
    }
  }

  public unsafe Vector3 positionSway
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swayer.NativeFieldInfoPtr_positionSway));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swayer.NativeFieldInfoPtr_positionSway)) = value;
    }
  }

  public unsafe bool swayRotation
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swayer.NativeFieldInfoPtr_swayRotation));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swayer.NativeFieldInfoPtr_swayRotation)) = value;
    }
  }

  public unsafe Vector3 rotationInfluence
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swayer.NativeFieldInfoPtr_rotationInfluence));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swayer.NativeFieldInfoPtr_rotationInfluence)) = value;
    }
  }

  public unsafe Vector3 rotationSway
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swayer.NativeFieldInfoPtr_rotationSway));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swayer.NativeFieldInfoPtr_rotationSway)) = value;
    }
  }

  public unsafe Vector3 startPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swayer.NativeFieldInfoPtr_startPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swayer.NativeFieldInfoPtr_startPosition)) = value;
    }
  }

  public unsafe Vector3 startRotation
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swayer.NativeFieldInfoPtr_startRotation));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swayer.NativeFieldInfoPtr_startRotation)) = value;
    }
  }

  public unsafe float t
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swayer.NativeFieldInfoPtr_t));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swayer.NativeFieldInfoPtr_t)) = value;
    }
  }

  public new unsafe Transform transform
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swayer.NativeFieldInfoPtr_transform));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Swayer.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
