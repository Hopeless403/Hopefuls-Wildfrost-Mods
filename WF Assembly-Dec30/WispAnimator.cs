// Decompiled with JetBrains decompiler
// Type: WispAnimator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class WispAnimator : MonoBehaviourCacheTransform
{
  private static readonly System.IntPtr NativeFieldInfoPtr_knockback;
  private static readonly System.IntPtr NativeFieldInfoPtr_gravitate;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_smokeFx;
  private static readonly System.IntPtr NativeFieldInfoPtr_sprite;
  private static readonly System.IntPtr NativeFieldInfoPtr_faceSprite;
  private static readonly System.IntPtr NativeFieldInfoPtr_pingPS;
  private static readonly System.IntPtr NativeFieldInfoPtr_velocity;
  private static readonly System.IntPtr NativeFieldInfoPtr_target;
  private static readonly System.IntPtr NativeMethodInfoPtr_KnockBackFrom_Public_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTarget_Public_Void_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TargetExists_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_JumpToTarget_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FadeToColour_Public_Void_Color_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSortingLayer_Public_Void_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 101366, RefRangeEnd = 101367, XrefRangeStart = 101362, XrefRangeEnd = 101366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void KnockBackFrom(Vector3 from)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &from
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WispAnimator.NativeMethodInfoPtr_KnockBackFrom_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetTarget(Transform target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WispAnimator.NativeMethodInfoPtr_SetTarget_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 101371, RefRangeEnd = 101372, XrefRangeStart = 101367, XrefRangeEnd = 101371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TargetExists()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WispAnimator.NativeMethodInfoPtr_TargetExists_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 101381, RefRangeEnd = 101383, XrefRangeStart = 101372, XrefRangeEnd = 101381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void JumpToTarget()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WispAnimator.NativeMethodInfoPtr_JumpToTarget_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 101418, RefRangeEnd = 101419, XrefRangeStart = 101383, XrefRangeEnd = 101418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FadeToColour(Color color, float delay, float duration)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &delay;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WispAnimator.NativeMethodInfoPtr_FadeToColour_Public_Void_Color_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 101431, RefRangeEnd = 101432, XrefRangeStart = 101419, XrefRangeEnd = 101431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSortingLayer(string layerName, int orderInLayer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(layerName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &orderInLayer;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WispAnimator.NativeMethodInfoPtr_SetSortingLayer_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101432, XrefRangeEnd = 101454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WispAnimator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101454, XrefRangeEnd = 101457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WispAnimator()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WispAnimator>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WispAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static WispAnimator()
  {
    Il2CppClassPointerStore<WispAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (WispAnimator));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WispAnimator>.NativeClassPtr);
    WispAnimator.NativeFieldInfoPtr_knockback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WispAnimator>.NativeClassPtr, nameof (knockback));
    WispAnimator.NativeFieldInfoPtr_gravitate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WispAnimator>.NativeClassPtr, nameof (gravitate));
    WispAnimator.NativeFieldInfoPtr_maxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WispAnimator>.NativeClassPtr, nameof (maxSpeed));
    WispAnimator.NativeFieldInfoPtr_smokeFx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WispAnimator>.NativeClassPtr, nameof (smokeFx));
    WispAnimator.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WispAnimator>.NativeClassPtr, nameof (sprite));
    WispAnimator.NativeFieldInfoPtr_faceSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WispAnimator>.NativeClassPtr, nameof (faceSprite));
    WispAnimator.NativeFieldInfoPtr_pingPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WispAnimator>.NativeClassPtr, nameof (pingPS));
    WispAnimator.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WispAnimator>.NativeClassPtr, nameof (velocity));
    WispAnimator.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WispAnimator>.NativeClassPtr, nameof (target));
    WispAnimator.NativeMethodInfoPtr_KnockBackFrom_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WispAnimator>.NativeClassPtr, 100672390);
    WispAnimator.NativeMethodInfoPtr_SetTarget_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WispAnimator>.NativeClassPtr, 100672391);
    WispAnimator.NativeMethodInfoPtr_TargetExists_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WispAnimator>.NativeClassPtr, 100672392);
    WispAnimator.NativeMethodInfoPtr_JumpToTarget_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WispAnimator>.NativeClassPtr, 100672393);
    WispAnimator.NativeMethodInfoPtr_FadeToColour_Public_Void_Color_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WispAnimator>.NativeClassPtr, 100672394);
    WispAnimator.NativeMethodInfoPtr_SetSortingLayer_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WispAnimator>.NativeClassPtr, 100672395);
    WispAnimator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WispAnimator>.NativeClassPtr, 100672396);
    WispAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WispAnimator>.NativeClassPtr, 100672397);
  }

  public WispAnimator(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float knockback
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WispAnimator.NativeFieldInfoPtr_knockback));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WispAnimator.NativeFieldInfoPtr_knockback)) = value;
    }
  }

  public unsafe float gravitate
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WispAnimator.NativeFieldInfoPtr_gravitate));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WispAnimator.NativeFieldInfoPtr_gravitate)) = value;
    }
  }

  public unsafe float maxSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WispAnimator.NativeFieldInfoPtr_maxSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WispAnimator.NativeFieldInfoPtr_maxSpeed)) = value;
    }
  }

  public unsafe ParticleSystem smokeFx
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WispAnimator.NativeFieldInfoPtr_smokeFx));
      return pointer == System.IntPtr.Zero ? (ParticleSystem) null : new ParticleSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WispAnimator.NativeFieldInfoPtr_smokeFx), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SpriteRenderer sprite
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WispAnimator.NativeFieldInfoPtr_sprite));
      return pointer == System.IntPtr.Zero ? (SpriteRenderer) null : new SpriteRenderer(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WispAnimator.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SpriteRenderer faceSprite
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WispAnimator.NativeFieldInfoPtr_faceSprite));
      return pointer == System.IntPtr.Zero ? (SpriteRenderer) null : new SpriteRenderer(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WispAnimator.NativeFieldInfoPtr_faceSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem pingPS
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WispAnimator.NativeFieldInfoPtr_pingPS));
      return pointer == System.IntPtr.Zero ? (ParticleSystem) null : new ParticleSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WispAnimator.NativeFieldInfoPtr_pingPS), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 velocity
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WispAnimator.NativeFieldInfoPtr_velocity));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WispAnimator.NativeFieldInfoPtr_velocity)) = value;
    }
  }

  public unsafe Transform target
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WispAnimator.NativeFieldInfoPtr_target));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WispAnimator.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("WispAnimator/<>c__DisplayClass13_0")]
  public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_gradient;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__FadeToColour_b__0_Internal_Void_Single_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass13_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WispAnimator.__c__DisplayClass13_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WispAnimator.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101357, XrefRangeEnd = 101362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _FadeToColour_b__0(float a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &a
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WispAnimator.__c__DisplayClass13_0.NativeMethodInfoPtr__FadeToColour_b__0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass13_0()
    {
      Il2CppClassPointerStore<WispAnimator.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WispAnimator>.NativeClassPtr, "<>c__DisplayClass13_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WispAnimator.__c__DisplayClass13_0>.NativeClassPtr);
      WispAnimator.__c__DisplayClass13_0.NativeFieldInfoPtr_gradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WispAnimator.__c__DisplayClass13_0>.NativeClassPtr, nameof (gradient));
      WispAnimator.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WispAnimator.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
      WispAnimator.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WispAnimator.__c__DisplayClass13_0>.NativeClassPtr, 100672398);
      WispAnimator.__c__DisplayClass13_0.NativeMethodInfoPtr__FadeToColour_b__0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WispAnimator.__c__DisplayClass13_0>.NativeClassPtr, 100672399);
    }

    public __c__DisplayClass13_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Gradient gradient
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WispAnimator.__c__DisplayClass13_0.NativeFieldInfoPtr_gradient));
        return pointer == System.IntPtr.Zero ? (Gradient) null : new Gradient(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WispAnimator.__c__DisplayClass13_0.NativeFieldInfoPtr_gradient), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WispAnimator __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WispAnimator.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (WispAnimator) null : new WispAnimator(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WispAnimator.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
