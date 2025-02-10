// Decompiled with JetBrains decompiler
// Type: CardCharm
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
public class CardCharm : UpgradeDisplay
{
  private static readonly IntPtr NativeFieldInfoPtr_holder;
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
  private static readonly IntPtr NativeFieldInfoPtr_startingZAngle;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Wobble_Public_Void_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetAngle_Public_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_StopWobble_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44014, XrefRangeEnd = 44017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardCharm.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44017, XrefRangeEnd = 44022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardCharm.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44022, XrefRangeEnd = 44038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardCharm.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44038, XrefRangeEnd = 44045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Wobble(Vector3 movement)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &movement
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardCharm.NativeMethodInfoPtr_Wobble_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
    IL2CPP.il2cpp_runtime_invoke(CardCharm.NativeMethodInfoPtr_SetAngle_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44045, XrefRangeEnd = 44047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopWobble()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardCharm.NativeMethodInfoPtr_StopWobble_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44047, XrefRangeEnd = 44048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardCharm()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardCharm>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardCharm.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardCharm()
  {
    Il2CppClassPointerStore<CardCharm>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardCharm));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardCharm>.NativeClassPtr);
    CardCharm.NativeFieldInfoPtr_holder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, nameof (holder));
    CardCharm.NativeFieldInfoPtr_movementInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, nameof (movementInfluence));
    CardCharm.NativeFieldInfoPtr_rotationMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, nameof (rotationMax));
    CardCharm.NativeFieldInfoPtr_wobbleFactorRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, nameof (wobbleFactorRange));
    CardCharm.NativeFieldInfoPtr_wobbleDampingRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, nameof (wobbleDampingRange));
    CardCharm.NativeFieldInfoPtr_wobbleAccRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, nameof (wobbleAccRange));
    CardCharm.NativeFieldInfoPtr_wobbleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, nameof (wobbleFactor));
    CardCharm.NativeFieldInfoPtr_wobbleDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, nameof (wobbleDamping));
    CardCharm.NativeFieldInfoPtr_wobbleAcc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, nameof (wobbleAcc));
    CardCharm.NativeFieldInfoPtr_prePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, nameof (prePosition));
    CardCharm.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, nameof (rotation));
    CardCharm.NativeFieldInfoPtr_rotationVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, nameof (rotationVelocity));
    CardCharm.NativeFieldInfoPtr_startingZAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, nameof (startingZAngle));
    CardCharm.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, 100666587);
    CardCharm.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, 100666588);
    CardCharm.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, 100666589);
    CardCharm.NativeMethodInfoPtr_Wobble_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, 100666590);
    CardCharm.NativeMethodInfoPtr_SetAngle_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, 100666591);
    CardCharm.NativeMethodInfoPtr_StopWobble_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, 100666592);
    CardCharm.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, 100666593);
  }

  public CardCharm(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Transform holder
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_holder));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_holder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 movementInfluence
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_movementInfluence));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_movementInfluence)) = value;
    }
  }

  public unsafe float rotationMax
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_rotationMax));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_rotationMax)) = value;
    }
  }

  public unsafe Vector2 wobbleFactorRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleFactorRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleFactorRange)) = value;
    }
  }

  public unsafe Vector2 wobbleDampingRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleDampingRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleDampingRange)) = value;
    }
  }

  public unsafe Vector2 wobbleAccRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleAccRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleAccRange)) = value;
    }
  }

  public unsafe float wobbleFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleFactor)) = value;
    }
  }

  public unsafe float wobbleDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleDamping)) = value;
    }
  }

  public unsafe float wobbleAcc
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleAcc));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleAcc)) = value;
    }
  }

  public unsafe Vector3 prePosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_prePosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_prePosition)) = value;
    }
  }

  public unsafe float rotation
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_rotation));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_rotation)) = value;
    }
  }

  public unsafe float rotationVelocity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_rotationVelocity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_rotationVelocity)) = value;
    }
  }

  public unsafe float startingZAngle
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_startingZAngle));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_startingZAngle)) = value;
    }
  }
}
