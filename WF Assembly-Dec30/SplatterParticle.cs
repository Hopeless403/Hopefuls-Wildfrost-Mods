// Decompiled with JetBrains decompiler
// Type: SplatterParticle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class SplatterParticle : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_splatterPrefab;
  private static readonly IntPtr NativeFieldInfoPtr_canHitSource;
  private static readonly IntPtr NativeFieldInfoPtr_source;
  private static readonly IntPtr NativeFieldInfoPtr_canvas;
  private static readonly IntPtr NativeFieldInfoPtr_image;
  private static readonly IntPtr NativeFieldInfoPtr_sizeRange;
  private static readonly IntPtr NativeFieldInfoPtr_velocity;
  private static readonly IntPtr NativeFieldInfoPtr_gravity;
  private static readonly IntPtr NativeFieldInfoPtr_frictMult;
  private static readonly IntPtr NativeFieldInfoPtr_isInBackground;
  private static readonly IntPtr NativeFieldInfoPtr_backgroundZThreshold;
  private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetSource_Public_Void_SplatterSurface_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe Color color
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SplatterParticle.NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SplatterParticle.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74941, XrefRangeEnd = 74946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplatterParticle.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74946, XrefRangeEnd = 74974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplatterParticle.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 74975, RefRangeEnd = 74976, XrefRangeStart = 74974, XrefRangeEnd = 74975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSource(SplatterSurface source)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplatterParticle.NativeMethodInfoPtr_SetSource_Public_Void_SplatterSurface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74976, XrefRangeEnd = 74990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTriggerEnter(Collider other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplatterParticle.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74990, XrefRangeEnd = 74991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SplatterParticle()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SplatterParticle>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplatterParticle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SplatterParticle()
  {
    Il2CppClassPointerStore<SplatterParticle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SplatterParticle));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplatterParticle>.NativeClassPtr);
    SplatterParticle.NativeFieldInfoPtr_splatterPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterParticle>.NativeClassPtr, nameof (splatterPrefab));
    SplatterParticle.NativeFieldInfoPtr_canHitSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterParticle>.NativeClassPtr, nameof (canHitSource));
    SplatterParticle.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterParticle>.NativeClassPtr, nameof (source));
    SplatterParticle.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterParticle>.NativeClassPtr, nameof (canvas));
    SplatterParticle.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterParticle>.NativeClassPtr, nameof (image));
    SplatterParticle.NativeFieldInfoPtr_sizeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterParticle>.NativeClassPtr, nameof (sizeRange));
    SplatterParticle.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterParticle>.NativeClassPtr, nameof (velocity));
    SplatterParticle.NativeFieldInfoPtr_gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterParticle>.NativeClassPtr, nameof (gravity));
    SplatterParticle.NativeFieldInfoPtr_frictMult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterParticle>.NativeClassPtr, nameof (frictMult));
    SplatterParticle.NativeFieldInfoPtr_isInBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterParticle>.NativeClassPtr, nameof (isInBackground));
    SplatterParticle.NativeFieldInfoPtr_backgroundZThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterParticle>.NativeClassPtr, nameof (backgroundZThreshold));
    SplatterParticle.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterParticle>.NativeClassPtr, 100669356);
    SplatterParticle.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterParticle>.NativeClassPtr, 100669357);
    SplatterParticle.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterParticle>.NativeClassPtr, 100669358);
    SplatterParticle.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterParticle>.NativeClassPtr, 100669359);
    SplatterParticle.NativeMethodInfoPtr_SetSource_Public_Void_SplatterSurface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterParticle>.NativeClassPtr, 100669360);
    SplatterParticle.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterParticle>.NativeClassPtr, 100669361);
    SplatterParticle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterParticle>.NativeClassPtr, 100669362);
  }

  public SplatterParticle(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Splatter splatterPrefab
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterParticle.NativeFieldInfoPtr_splatterPrefab));
      return pointer == IntPtr.Zero ? (Splatter) null : new Splatter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplatterParticle.NativeFieldInfoPtr_splatterPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool canHitSource
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterParticle.NativeFieldInfoPtr_canHitSource));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterParticle.NativeFieldInfoPtr_canHitSource)) = value;
    }
  }

  public unsafe SplatterSurface source
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterParticle.NativeFieldInfoPtr_source));
      return pointer == IntPtr.Zero ? (SplatterSurface) null : new SplatterSurface(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplatterParticle.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Canvas canvas
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterParticle.NativeFieldInfoPtr_canvas));
      return pointer == IntPtr.Zero ? (Canvas) null : new Canvas(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplatterParticle.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image image
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterParticle.NativeFieldInfoPtr_image));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplatterParticle.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 sizeRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterParticle.NativeFieldInfoPtr_sizeRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterParticle.NativeFieldInfoPtr_sizeRange)) = value;
    }
  }

  public unsafe Vector3 velocity
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterParticle.NativeFieldInfoPtr_velocity));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterParticle.NativeFieldInfoPtr_velocity)) = value;
    }
  }

  public unsafe Vector3 gravity
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterParticle.NativeFieldInfoPtr_gravity));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterParticle.NativeFieldInfoPtr_gravity)) = value;
    }
  }

  public unsafe Vector3 frictMult
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterParticle.NativeFieldInfoPtr_frictMult));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterParticle.NativeFieldInfoPtr_frictMult)) = value;
    }
  }

  public unsafe bool isInBackground
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterParticle.NativeFieldInfoPtr_isInBackground));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterParticle.NativeFieldInfoPtr_isInBackground)) = value;
    }
  }

  public unsafe float backgroundZThreshold
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterParticle.NativeFieldInfoPtr_backgroundZThreshold));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterParticle.NativeFieldInfoPtr_backgroundZThreshold)) = value;
    }
  }
}
