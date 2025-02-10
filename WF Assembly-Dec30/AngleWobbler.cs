// Decompiled with JetBrains decompiler
// Type: AngleWobbler
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
public class AngleWobbler : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_holder;
  private static readonly IntPtr NativeFieldInfoPtr_target;
  private static readonly IntPtr NativeFieldInfoPtr_globalSpace;
  private static readonly IntPtr NativeFieldInfoPtr_movementInfluence;
  private static readonly IntPtr NativeFieldInfoPtr_rotationMax;
  private static readonly IntPtr NativeFieldInfoPtr_wobbleFactorRange;
  private static readonly IntPtr NativeFieldInfoPtr_wobbleDampingRange;
  private static readonly IntPtr NativeFieldInfoPtr_wobbleAccRange;
  private static readonly IntPtr NativeFieldInfoPtr_wobbleFactor;
  private static readonly IntPtr NativeFieldInfoPtr_wobbleDamping;
  private static readonly IntPtr NativeFieldInfoPtr_wobbleAcc;
  private static readonly IntPtr NativeFieldInfoPtr_prePosition;
  private static readonly IntPtr NativeFieldInfoPtr_rotation;
  private static readonly IntPtr NativeFieldInfoPtr_rotationVelocity;
  private static readonly IntPtr NativeFieldInfoPtr_startAngle;
  private static readonly IntPtr NativeMethodInfoPtr_get_HolderPosition_Private_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Wobble_Public_Void_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_WobbleRandom_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetAngle_Public_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe Vector3 HolderPosition
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26637, XrefRangeEnd = 26638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(AngleWobbler.NativeMethodInfoPtr_get_HolderPosition_Private_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26638, XrefRangeEnd = 26642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AngleWobbler.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26642, XrefRangeEnd = 26647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AngleWobbler.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26647, XrefRangeEnd = 26666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AngleWobbler.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26666, XrefRangeEnd = 26673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Wobble(Vector3 movement)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &movement
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AngleWobbler.NativeMethodInfoPtr_Wobble_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 26675, RefRangeEnd = 26676, XrefRangeStart = 26673, XrefRangeEnd = 26675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void WobbleRandom()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AngleWobbler.NativeMethodInfoPtr_WobbleRandom_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void SetAngle(float angle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &angle
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AngleWobbler.NativeMethodInfoPtr_SetAngle_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26676, XrefRangeEnd = 26677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AngleWobbler()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AngleWobbler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static AngleWobbler()
  {
    Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (AngleWobbler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr);
    AngleWobbler.NativeFieldInfoPtr_holder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr, nameof (holder));
    AngleWobbler.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr, nameof (target));
    AngleWobbler.NativeFieldInfoPtr_globalSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr, nameof (globalSpace));
    AngleWobbler.NativeFieldInfoPtr_movementInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr, nameof (movementInfluence));
    AngleWobbler.NativeFieldInfoPtr_rotationMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr, nameof (rotationMax));
    AngleWobbler.NativeFieldInfoPtr_wobbleFactorRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr, nameof (wobbleFactorRange));
    AngleWobbler.NativeFieldInfoPtr_wobbleDampingRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr, nameof (wobbleDampingRange));
    AngleWobbler.NativeFieldInfoPtr_wobbleAccRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr, nameof (wobbleAccRange));
    AngleWobbler.NativeFieldInfoPtr_wobbleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr, nameof (wobbleFactor));
    AngleWobbler.NativeFieldInfoPtr_wobbleDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr, nameof (wobbleDamping));
    AngleWobbler.NativeFieldInfoPtr_wobbleAcc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr, nameof (wobbleAcc));
    AngleWobbler.NativeFieldInfoPtr_prePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr, nameof (prePosition));
    AngleWobbler.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr, nameof (rotation));
    AngleWobbler.NativeFieldInfoPtr_rotationVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr, nameof (rotationVelocity));
    AngleWobbler.NativeFieldInfoPtr_startAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr, nameof (startAngle));
    AngleWobbler.NativeMethodInfoPtr_get_HolderPosition_Private_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr, 100664657);
    AngleWobbler.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr, 100664658);
    AngleWobbler.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr, 100664659);
    AngleWobbler.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr, 100664660);
    AngleWobbler.NativeMethodInfoPtr_Wobble_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr, 100664661);
    AngleWobbler.NativeMethodInfoPtr_WobbleRandom_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr, 100664662);
    AngleWobbler.NativeMethodInfoPtr_SetAngle_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr, 100664663);
    AngleWobbler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleWobbler>.NativeClassPtr, 100664664);
  }

  public AngleWobbler(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Transform holder
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_holder));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_holder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform target
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_target));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool globalSpace
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_globalSpace));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_globalSpace)) = value;
    }
  }

  public unsafe Vector3 movementInfluence
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_movementInfluence));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_movementInfluence)) = value;
    }
  }

  public unsafe float rotationMax
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_rotationMax));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_rotationMax)) = value;
    }
  }

  public unsafe Vector2 wobbleFactorRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_wobbleFactorRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_wobbleFactorRange)) = value;
    }
  }

  public unsafe Vector2 wobbleDampingRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_wobbleDampingRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_wobbleDampingRange)) = value;
    }
  }

  public unsafe Vector2 wobbleAccRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_wobbleAccRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_wobbleAccRange)) = value;
    }
  }

  public unsafe float wobbleFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_wobbleFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_wobbleFactor)) = value;
    }
  }

  public unsafe float wobbleDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_wobbleDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_wobbleDamping)) = value;
    }
  }

  public unsafe float wobbleAcc
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_wobbleAcc));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_wobbleAcc)) = value;
    }
  }

  public unsafe Vector3 prePosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_prePosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_prePosition)) = value;
    }
  }

  public unsafe float rotation
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_rotation));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_rotation)) = value;
    }
  }

  public unsafe float rotationVelocity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_rotationVelocity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_rotationVelocity)) = value;
    }
  }

  public unsafe float startAngle
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_startAngle));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AngleWobbler.NativeFieldInfoPtr_startAngle)) = value;
    }
  }
}
