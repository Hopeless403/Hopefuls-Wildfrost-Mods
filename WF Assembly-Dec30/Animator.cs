// Decompiled with JetBrains decompiler
// Type: Animator
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
public class Animator : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_animations;
  private static readonly System.IntPtr NativeFieldInfoPtr_lookup;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26895, XrefRangeEnd = 26906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 26914, RefRangeEnd = 26918, XrefRangeStart = 26906, XrefRangeEnd = 26914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Play(string animationName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(animationName)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_Play_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 26923, RefRangeEnd = 26924, XrefRangeStart = 26918, XrefRangeEnd = 26923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Stop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Animator()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Animator>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Animator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Animator()
  {
    Il2CppClassPointerStore<Animator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Animator));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Animator>.NativeClassPtr);
    Animator.NativeFieldInfoPtr_animations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Animator>.NativeClassPtr, nameof (animations));
    Animator.NativeFieldInfoPtr_lookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Animator>.NativeClassPtr, nameof (lookup));
    Animator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100664714);
    Animator.NativeMethodInfoPtr_Play_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100664715);
    Animator.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100664716);
    Animator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator>.NativeClassPtr, 100664717);
  }

  public Animator(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<Animator.Animation> animations
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Animator.NativeFieldInfoPtr_animations));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Animator.Animation>) null : new Il2CppReferenceArray<Animator.Animation>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Animator.NativeFieldInfoPtr_animations), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, Animator.Animation> lookup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Animator.NativeFieldInfoPtr_lookup));
      return pointer == System.IntPtr.Zero ? (Dictionary<string, Animator.Animation>) null : new Dictionary<string, Animator.Animation>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Animator.NativeFieldInfoPtr_lookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class Animation : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_property;
    private static readonly System.IntPtr NativeFieldInfoPtr_curve;
    private static readonly System.IntPtr NativeFieldInfoPtr_duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_delay;
    private static readonly System.IntPtr NativeFieldInfoPtr_to;
    private static readonly System.IntPtr NativeFieldInfoPtr_from;
    private static readonly System.IntPtr NativeFieldInfoPtr_hasFrom;
    private static readonly System.IntPtr NativeFieldInfoPtr_loop;
    private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_GameObject_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 26894, RefRangeEnd = 26895, XrefRangeStart = 26866, XrefRangeEnd = 26894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Play(GameObject target)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Animator.Animation.NativeMethodInfoPtr_Play_Public_Void_GameObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Animation()
    {
      Il2CppClassPointerStore<Animator.Animation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Animator>.NativeClassPtr, nameof (Animation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Animator.Animation>.NativeClassPtr);
      Animator.Animation.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Animator.Animation>.NativeClassPtr, nameof (name));
      Animator.Animation.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Animator.Animation>.NativeClassPtr, nameof (property));
      Animator.Animation.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Animator.Animation>.NativeClassPtr, nameof (curve));
      Animator.Animation.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Animator.Animation>.NativeClassPtr, nameof (duration));
      Animator.Animation.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Animator.Animation>.NativeClassPtr, nameof (delay));
      Animator.Animation.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Animator.Animation>.NativeClassPtr, nameof (to));
      Animator.Animation.NativeFieldInfoPtr_from = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Animator.Animation>.NativeClassPtr, nameof (from));
      Animator.Animation.NativeFieldInfoPtr_hasFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Animator.Animation>.NativeClassPtr, nameof (hasFrom));
      Animator.Animation.NativeFieldInfoPtr_loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Animator.Animation>.NativeClassPtr, nameof (loop));
      Animator.Animation.NativeMethodInfoPtr_Play_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animator.Animation>.NativeClassPtr, 100664718);
    }

    public Animation(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Animation()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Animator.Animation>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Animator.Animation>.NativeClassPtr, data));
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Animator.Animation.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Animator.Animation.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Animator.Animation.Property property
    {
      get
      {
        return *(Animator.Animation.Property*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Animator.Animation.NativeFieldInfoPtr_property));
      }
      [param: In] set
      {
        *(Animator.Animation.Property*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Animator.Animation.NativeFieldInfoPtr_property)) = value;
      }
    }

    public unsafe AnimationCurve curve
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Animator.Animation.NativeFieldInfoPtr_curve));
        return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Animator.Animation.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector2 duration
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Animator.Animation.NativeFieldInfoPtr_duration));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Animator.Animation.NativeFieldInfoPtr_duration)) = value;
      }
    }

    public unsafe Vector2 delay
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Animator.Animation.NativeFieldInfoPtr_delay));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Animator.Animation.NativeFieldInfoPtr_delay)) = value;
      }
    }

    public unsafe Vector3 to
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Animator.Animation.NativeFieldInfoPtr_to));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Animator.Animation.NativeFieldInfoPtr_to)) = value;
      }
    }

    public unsafe Vector3 from
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Animator.Animation.NativeFieldInfoPtr_from));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Animator.Animation.NativeFieldInfoPtr_from)) = value;
      }
    }

    public unsafe bool hasFrom
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Animator.Animation.NativeFieldInfoPtr_hasFrom));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Animator.Animation.NativeFieldInfoPtr_hasFrom)) = value;
      }
    }

    public unsafe bool loop
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Animator.Animation.NativeFieldInfoPtr_loop));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Animator.Animation.NativeFieldInfoPtr_loop)) = value;
      }
    }

    public enum Property
    {
      Move,
      Rotate,
      Scale,
    }
  }
}
