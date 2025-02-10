// Decompiled with JetBrains decompiler
// Type: BlingParticle
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
public class BlingParticle : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_system;
  private static readonly IntPtr NativeFieldInfoPtr_owner;
  private static readonly IntPtr NativeFieldInfoPtr_value;
  private static readonly IntPtr NativeFieldInfoPtr_sizeRange;
  private static readonly IntPtr NativeFieldInfoPtr_angleRange;
  private static readonly IntPtr NativeFieldInfoPtr_groundRotation;
  private static readonly IntPtr NativeFieldInfoPtr_bounceRange;
  private static readonly IntPtr NativeFieldInfoPtr_bounceSlowdownRange;
  private static readonly IntPtr NativeFieldInfoPtr_flyToBagRange;
  private static readonly IntPtr NativeFieldInfoPtr_startSpeedRange;
  private static readonly IntPtr NativeFieldInfoPtr_startUpSpeedRange;
  private static readonly IntPtr NativeFieldInfoPtr_frictMultRange;
  private static readonly IntPtr NativeFieldInfoPtr_grav;
  private static readonly IntPtr NativeFieldInfoPtr_groundOffsetRange;
  private static readonly IntPtr NativeFieldInfoPtr_startTimerWhenOnGround;
  private static readonly IntPtr NativeFieldInfoPtr_zInfluence;
  private static readonly IntPtr NativeFieldInfoPtr_flyToBagSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_flyMaxSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_worldGroundY;
  private static readonly IntPtr NativeFieldInfoPtr_bounce;
  private static readonly IntPtr NativeFieldInfoPtr_bounceSlowdown;
  private static readonly IntPtr NativeFieldInfoPtr_flyToBag;
  private static readonly IntPtr NativeFieldInfoPtr_velocity;
  private static readonly IntPtr NativeFieldInfoPtr_frictMult;
  private static readonly IntPtr NativeFieldInfoPtr_onGround;
  private static readonly IntPtr NativeFieldInfoPtr_targetBag;
  private static readonly IntPtr NativeFieldInfoPtr__spr;
  private static readonly IntPtr NativeMethodInfoPtr_get_spr_Private_get_SpriteRenderer_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayer_Private_set_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_FlyToBag_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Collect_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ReturnToPool_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe SpriteRenderer spr
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30699, XrefRangeEnd = 30703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(BlingParticle.NativeMethodInfoPtr_get_spr_Private_get_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (SpriteRenderer) null : new SpriteRenderer(pointer);
    }
  }

  public unsafe Sprite sprite
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 30709, RefRangeEnd = 30710, XrefRangeStart = 30703, XrefRangeEnd = 30709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlingParticle.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe string sortingLayer
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 30716, RefRangeEnd = 30719, XrefRangeStart = 30710, XrefRangeEnd = 30716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlingParticle.NativeMethodInfoPtr_set_sortingLayer_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30719, XrefRangeEnd = 30753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BlingParticle.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30753, XrefRangeEnd = 30800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BlingParticle.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30800, XrefRangeEnd = 30813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FlyToBag()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BlingParticle.NativeMethodInfoPtr_FlyToBag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30813, XrefRangeEnd = 30817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Collect()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BlingParticle.NativeMethodInfoPtr_Collect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30817, XrefRangeEnd = 30819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ReturnToPool()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BlingParticle.NativeMethodInfoPtr_ReturnToPool_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30819, XrefRangeEnd = 30820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BlingParticle()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BlingParticle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BlingParticle()
  {
    Il2CppClassPointerStore<BlingParticle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BlingParticle));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr);
    BlingParticle.NativeFieldInfoPtr_system = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (system));
    BlingParticle.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (owner));
    BlingParticle.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (value));
    BlingParticle.NativeFieldInfoPtr_sizeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (sizeRange));
    BlingParticle.NativeFieldInfoPtr_angleRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (angleRange));
    BlingParticle.NativeFieldInfoPtr_groundRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (groundRotation));
    BlingParticle.NativeFieldInfoPtr_bounceRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (bounceRange));
    BlingParticle.NativeFieldInfoPtr_bounceSlowdownRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (bounceSlowdownRange));
    BlingParticle.NativeFieldInfoPtr_flyToBagRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (flyToBagRange));
    BlingParticle.NativeFieldInfoPtr_startSpeedRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (startSpeedRange));
    BlingParticle.NativeFieldInfoPtr_startUpSpeedRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (startUpSpeedRange));
    BlingParticle.NativeFieldInfoPtr_frictMultRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (frictMultRange));
    BlingParticle.NativeFieldInfoPtr_grav = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (grav));
    BlingParticle.NativeFieldInfoPtr_groundOffsetRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (groundOffsetRange));
    BlingParticle.NativeFieldInfoPtr_startTimerWhenOnGround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (startTimerWhenOnGround));
    BlingParticle.NativeFieldInfoPtr_zInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (zInfluence));
    BlingParticle.NativeFieldInfoPtr_flyToBagSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (flyToBagSpeed));
    BlingParticle.NativeFieldInfoPtr_flyMaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (flyMaxSpeed));
    BlingParticle.NativeFieldInfoPtr_worldGroundY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (worldGroundY));
    BlingParticle.NativeFieldInfoPtr_bounce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (bounce));
    BlingParticle.NativeFieldInfoPtr_bounceSlowdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (bounceSlowdown));
    BlingParticle.NativeFieldInfoPtr_flyToBag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (flyToBag));
    BlingParticle.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (velocity));
    BlingParticle.NativeFieldInfoPtr_frictMult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (frictMult));
    BlingParticle.NativeFieldInfoPtr_onGround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (onGround));
    BlingParticle.NativeFieldInfoPtr_targetBag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (targetBag));
    BlingParticle.NativeFieldInfoPtr__spr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, nameof (_spr));
    BlingParticle.NativeMethodInfoPtr_get_spr_Private_get_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, 100665083);
    BlingParticle.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, 100665084);
    BlingParticle.NativeMethodInfoPtr_set_sortingLayer_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, 100665085);
    BlingParticle.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, 100665086);
    BlingParticle.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, 100665087);
    BlingParticle.NativeMethodInfoPtr_FlyToBag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, 100665088);
    BlingParticle.NativeMethodInfoPtr_Collect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, 100665089);
    BlingParticle.NativeMethodInfoPtr_ReturnToPool_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, 100665090);
    BlingParticle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlingParticle>.NativeClassPtr, 100665091);
  }

  public BlingParticle(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe BlingParticleSystem system
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_system));
      return pointer == IntPtr.Zero ? (BlingParticleSystem) null : new BlingParticleSystem(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_system), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Character owner
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_owner));
      return pointer == IntPtr.Zero ? (Character) null : new Character(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int value
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_value));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_value)) = value;
    }
  }

  public unsafe Vector2 sizeRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_sizeRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_sizeRange)) = value;
    }
  }

  public unsafe Vector2 angleRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_angleRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_angleRange)) = value;
    }
  }

  public unsafe Vector3 groundRotation
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_groundRotation));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_groundRotation)) = value;
    }
  }

  public unsafe Vector2 bounceRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_bounceRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_bounceRange)) = value;
    }
  }

  public unsafe Vector2 bounceSlowdownRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_bounceSlowdownRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_bounceSlowdownRange)) = value;
    }
  }

  public unsafe Vector2 flyToBagRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_flyToBagRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_flyToBagRange)) = value;
    }
  }

  public unsafe Vector2 startSpeedRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_startSpeedRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_startSpeedRange)) = value;
    }
  }

  public unsafe Vector2 startUpSpeedRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_startUpSpeedRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_startUpSpeedRange)) = value;
    }
  }

  public unsafe Vector2 frictMultRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_frictMultRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_frictMultRange)) = value;
    }
  }

  public unsafe float grav
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_grav));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_grav)) = value;
    }
  }

  public unsafe Vector2 groundOffsetRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_groundOffsetRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_groundOffsetRange)) = value;
    }
  }

  public unsafe bool startTimerWhenOnGround
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_startTimerWhenOnGround));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_startTimerWhenOnGround)) = value;
    }
  }

  public unsafe float zInfluence
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_zInfluence));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_zInfluence)) = value;
    }
  }

  public unsafe float flyToBagSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_flyToBagSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_flyToBagSpeed)) = value;
    }
  }

  public unsafe float flyMaxSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_flyMaxSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_flyMaxSpeed)) = value;
    }
  }

  public unsafe float worldGroundY
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_worldGroundY));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_worldGroundY)) = value;
    }
  }

  public unsafe float bounce
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_bounce));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_bounce)) = value;
    }
  }

  public unsafe float bounceSlowdown
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_bounceSlowdown));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_bounceSlowdown)) = value;
    }
  }

  public unsafe float flyToBag
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_flyToBag));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_flyToBag)) = value;
    }
  }

  public unsafe Vector3 velocity
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_velocity));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_velocity)) = value;
    }
  }

  public unsafe float frictMult
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_frictMult));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_frictMult)) = value;
    }
  }

  public unsafe bool onGround
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_onGround));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_onGround)) = value;
    }
  }

  public unsafe GoldDisplay targetBag
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_targetBag));
      return pointer == IntPtr.Zero ? (GoldDisplay) null : new GoldDisplay(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr_targetBag), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SpriteRenderer _spr
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr__spr));
      return pointer == IntPtr.Zero ? (SpriteRenderer) null : new SpriteRenderer(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlingParticle.NativeFieldInfoPtr__spr), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
