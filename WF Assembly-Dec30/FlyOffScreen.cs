// Decompiled with JetBrains decompiler
// Type: FlyOffScreen
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
public class FlyOffScreen : MonoBehaviourCacheTransform
{
  private static readonly IntPtr NativeFieldInfoPtr_velocity;
  private static readonly IntPtr NativeFieldInfoPtr_grav;
  private static readonly IntPtr NativeFieldInfoPtr_rotation;
  private static readonly IntPtr NativeFieldInfoPtr_frictMult;
  private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;
  private static readonly IntPtr NativeFieldInfoPtr_alpha;
  private static readonly IntPtr NativeFieldInfoPtr_fade;
  private static readonly IntPtr NativeFieldInfoPtr_rotateRangeX;
  private static readonly IntPtr NativeFieldInfoPtr_rotateRangeY;
  private static readonly IntPtr NativeFieldInfoPtr_rotateRangeZ;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Knockback_Public_Void_Hit_0;
  private static readonly IntPtr NativeMethodInfoPtr_Knockback_Public_Void_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50511, XrefRangeEnd = 50514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FlyOffScreen.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50514, XrefRangeEnd = 50545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FlyOffScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 50574, RefRangeEnd = 50575, XrefRangeStart = 50545, XrefRangeEnd = 50574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Knockback(Hit lastHit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) lastHit)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FlyOffScreen.NativeMethodInfoPtr_Knockback_Public_Void_Hit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void Knockback(Vector3 dir)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &dir
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FlyOffScreen.NativeMethodInfoPtr_Knockback_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(12611)]
  [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Begin()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlyOffScreen.NativeMethodInfoPtr_Begin_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50575, XrefRangeEnd = 50577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void End()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlyOffScreen.NativeMethodInfoPtr_End_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 50578, RefRangeEnd = 50579, XrefRangeStart = 50577, XrefRangeEnd = 50578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FlyOffScreen()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlyOffScreen>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FlyOffScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static FlyOffScreen()
  {
    Il2CppClassPointerStore<FlyOffScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (FlyOffScreen));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlyOffScreen>.NativeClassPtr);
    FlyOffScreen.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyOffScreen>.NativeClassPtr, nameof (velocity));
    FlyOffScreen.NativeFieldInfoPtr_grav = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyOffScreen>.NativeClassPtr, nameof (grav));
    FlyOffScreen.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyOffScreen>.NativeClassPtr, nameof (rotation));
    FlyOffScreen.NativeFieldInfoPtr_frictMult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyOffScreen>.NativeClassPtr, nameof (frictMult));
    FlyOffScreen.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyOffScreen>.NativeClassPtr, nameof (canvasGroup));
    FlyOffScreen.NativeFieldInfoPtr_alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyOffScreen>.NativeClassPtr, nameof (alpha));
    FlyOffScreen.NativeFieldInfoPtr_fade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyOffScreen>.NativeClassPtr, nameof (fade));
    FlyOffScreen.NativeFieldInfoPtr_rotateRangeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyOffScreen>.NativeClassPtr, nameof (rotateRangeX));
    FlyOffScreen.NativeFieldInfoPtr_rotateRangeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyOffScreen>.NativeClassPtr, nameof (rotateRangeY));
    FlyOffScreen.NativeFieldInfoPtr_rotateRangeZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyOffScreen>.NativeClassPtr, nameof (rotateRangeZ));
    FlyOffScreen.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyOffScreen>.NativeClassPtr, 100667303);
    FlyOffScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyOffScreen>.NativeClassPtr, 100667304);
    FlyOffScreen.NativeMethodInfoPtr_Knockback_Public_Void_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyOffScreen>.NativeClassPtr, 100667305);
    FlyOffScreen.NativeMethodInfoPtr_Knockback_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyOffScreen>.NativeClassPtr, 100667306);
    FlyOffScreen.NativeMethodInfoPtr_Begin_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyOffScreen>.NativeClassPtr, 100667307);
    FlyOffScreen.NativeMethodInfoPtr_End_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyOffScreen>.NativeClassPtr, 100667308);
    FlyOffScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyOffScreen>.NativeClassPtr, 100667309);
  }

  public FlyOffScreen(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Vector3 velocity
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyOffScreen.NativeFieldInfoPtr_velocity));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyOffScreen.NativeFieldInfoPtr_velocity)) = value;
    }
  }

  public unsafe Vector3 grav
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyOffScreen.NativeFieldInfoPtr_grav));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyOffScreen.NativeFieldInfoPtr_grav)) = value;
    }
  }

  public unsafe Vector3 rotation
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyOffScreen.NativeFieldInfoPtr_rotation));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyOffScreen.NativeFieldInfoPtr_rotation)) = value;
    }
  }

  public unsafe Vector3 frictMult
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyOffScreen.NativeFieldInfoPtr_frictMult));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyOffScreen.NativeFieldInfoPtr_frictMult)) = value;
    }
  }

  public unsafe CanvasGroup canvasGroup
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyOffScreen.NativeFieldInfoPtr_canvasGroup));
      return pointer == IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlyOffScreen.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float alpha
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyOffScreen.NativeFieldInfoPtr_alpha));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyOffScreen.NativeFieldInfoPtr_alpha)) = value;
    }
  }

  public unsafe float fade
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyOffScreen.NativeFieldInfoPtr_fade));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyOffScreen.NativeFieldInfoPtr_fade)) = value;
    }
  }

  public unsafe Vector2 rotateRangeX
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyOffScreen.NativeFieldInfoPtr_rotateRangeX));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyOffScreen.NativeFieldInfoPtr_rotateRangeX)) = value;
    }
  }

  public unsafe Vector2 rotateRangeY
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyOffScreen.NativeFieldInfoPtr_rotateRangeY));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyOffScreen.NativeFieldInfoPtr_rotateRangeY)) = value;
    }
  }

  public unsafe Vector2 rotateRangeZ
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyOffScreen.NativeFieldInfoPtr_rotateRangeZ));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyOffScreen.NativeFieldInfoPtr_rotateRangeZ)) = value;
    }
  }
}
