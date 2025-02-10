// Decompiled with JetBrains decompiler
// Type: FloatingTextManager
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
public class FloatingTextManager : MonoBehaviourSingleton<FloatingTextManager>
{
  private static readonly System.IntPtr NativeFieldInfoPtr_prefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_animations;
  private static readonly System.IntPtr NativeFieldInfoPtr_fadeCurves;
  private static readonly System.IntPtr NativeFieldInfoPtr_animationDictionary;
  private static readonly System.IntPtr NativeFieldInfoPtr_fadeCurveDictionary;
  private static readonly System.IntPtr NativeFieldInfoPtr_pool;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAnimation_Public_Static_Animation_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFadeCurve_Public_Static_FadeCurve_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFromPool_Public_Static_FloatingText_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReturnToPool_Public_Static_Void_FloatingText_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreatePrefab_Private_FloatingText_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50421, XrefRangeEnd = 50443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FloatingTextManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50443, XrefRangeEnd = 50450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe FloatingTextManager.Animation GetAnimation(string name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FloatingTextManager.NativeMethodInfoPtr_GetAnimation_Public_Static_Animation_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return new FloatingTextManager.Animation(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50450, XrefRangeEnd = 50457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe FloatingTextManager.FadeCurve GetFadeCurve(string name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FloatingTextManager.NativeMethodInfoPtr_GetFadeCurve_Public_Static_FadeCurve_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return new FloatingTextManager.FadeCurve(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 50476, RefRangeEnd = 50478, XrefRangeStart = 50457, XrefRangeEnd = 50476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe FloatingText GetFromPool()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FloatingTextManager.NativeMethodInfoPtr_GetFromPool_Public_Static_FloatingText_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (FloatingText) null : new FloatingText(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 50498, RefRangeEnd = 50499, XrefRangeStart = 50478, XrefRangeEnd = 50498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ReturnToPool(FloatingText item)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FloatingTextManager.NativeMethodInfoPtr_ReturnToPool_Public_Static_Void_FloatingText_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50499, XrefRangeEnd = 50508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FloatingText CreatePrefab()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FloatingTextManager.NativeMethodInfoPtr_CreatePrefab_Private_FloatingText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (FloatingText) null : new FloatingText(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50508, XrefRangeEnd = 50511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FloatingTextManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatingTextManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FloatingTextManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static FloatingTextManager()
  {
    Il2CppClassPointerStore<FloatingTextManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (FloatingTextManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatingTextManager>.NativeClassPtr);
    FloatingTextManager.NativeFieldInfoPtr_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatingTextManager>.NativeClassPtr, nameof (prefab));
    FloatingTextManager.NativeFieldInfoPtr_animations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatingTextManager>.NativeClassPtr, nameof (animations));
    FloatingTextManager.NativeFieldInfoPtr_fadeCurves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatingTextManager>.NativeClassPtr, nameof (fadeCurves));
    FloatingTextManager.NativeFieldInfoPtr_animationDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatingTextManager>.NativeClassPtr, nameof (animationDictionary));
    FloatingTextManager.NativeFieldInfoPtr_fadeCurveDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatingTextManager>.NativeClassPtr, nameof (fadeCurveDictionary));
    FloatingTextManager.NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatingTextManager>.NativeClassPtr, nameof (pool));
    FloatingTextManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatingTextManager>.NativeClassPtr, 100667290);
    FloatingTextManager.NativeMethodInfoPtr_GetAnimation_Public_Static_Animation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatingTextManager>.NativeClassPtr, 100667291);
    FloatingTextManager.NativeMethodInfoPtr_GetFadeCurve_Public_Static_FadeCurve_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatingTextManager>.NativeClassPtr, 100667292);
    FloatingTextManager.NativeMethodInfoPtr_GetFromPool_Public_Static_FloatingText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatingTextManager>.NativeClassPtr, 100667293);
    FloatingTextManager.NativeMethodInfoPtr_ReturnToPool_Public_Static_Void_FloatingText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatingTextManager>.NativeClassPtr, 100667294);
    FloatingTextManager.NativeMethodInfoPtr_CreatePrefab_Private_FloatingText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatingTextManager>.NativeClassPtr, 100667295);
    FloatingTextManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatingTextManager>.NativeClassPtr, 100667296);
  }

  public FloatingTextManager(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe FloatingText prefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.NativeFieldInfoPtr_prefab));
      return pointer == System.IntPtr.Zero ? (FloatingText) null : new FloatingText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.NativeFieldInfoPtr_prefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<FloatingTextManager.Animation> animations
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.NativeFieldInfoPtr_animations));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<FloatingTextManager.Animation>) null : new Il2CppReferenceArray<FloatingTextManager.Animation>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.NativeFieldInfoPtr_animations), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<FloatingTextManager.FadeCurve> fadeCurves
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.NativeFieldInfoPtr_fadeCurves));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<FloatingTextManager.FadeCurve>) null : new Il2CppReferenceArray<FloatingTextManager.FadeCurve>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.NativeFieldInfoPtr_fadeCurves), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, FloatingTextManager.Animation> animationDictionary
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.NativeFieldInfoPtr_animationDictionary));
      return pointer == System.IntPtr.Zero ? (Dictionary<string, FloatingTextManager.Animation>) null : new Dictionary<string, FloatingTextManager.Animation>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.NativeFieldInfoPtr_animationDictionary), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, FloatingTextManager.FadeCurve> fadeCurveDictionary
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.NativeFieldInfoPtr_fadeCurveDictionary));
      return pointer == System.IntPtr.Zero ? (Dictionary<string, FloatingTextManager.FadeCurve>) null : new Dictionary<string, FloatingTextManager.FadeCurve>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.NativeFieldInfoPtr_fadeCurveDictionary), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Queue<FloatingText> pool
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(FloatingTextManager.NativeFieldInfoPtr_pool, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Queue<FloatingText>) null : new Queue<FloatingText>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FloatingTextManager.NativeFieldInfoPtr_pool, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class Animation : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_tweens;
    private static readonly System.IntPtr NativeMethodInfoPtr_Fire_Public_Void_GameObject_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDuration_Public_Single_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 50419, RefRangeEnd = 50420, XrefRangeStart = 50417, XrefRangeEnd = 50419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Fire(GameObject target, float strength)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &strength;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FloatingTextManager.Animation.NativeMethodInfoPtr_Fire_Public_Void_GameObject_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50420, XrefRangeEnd = 50421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetDuration()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FloatingTextManager.Animation.NativeMethodInfoPtr_GetDuration_Public_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static Animation()
    {
      Il2CppClassPointerStore<FloatingTextManager.Animation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatingTextManager>.NativeClassPtr, nameof (Animation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatingTextManager.Animation>.NativeClassPtr);
      FloatingTextManager.Animation.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatingTextManager.Animation>.NativeClassPtr, nameof (name));
      FloatingTextManager.Animation.NativeFieldInfoPtr_tweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatingTextManager.Animation>.NativeClassPtr, nameof (tweens));
      FloatingTextManager.Animation.NativeMethodInfoPtr_Fire_Public_Void_GameObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatingTextManager.Animation>.NativeClassPtr, 100667298);
      FloatingTextManager.Animation.NativeMethodInfoPtr_GetDuration_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatingTextManager.Animation>.NativeClassPtr, 100667299);
    }

    public Animation(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Animation()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FloatingTextManager.Animation>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FloatingTextManager.Animation>.NativeClassPtr, data));
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.Animation.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.Animation.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Il2CppReferenceArray<FloatingTextManager.Animation.Tween> tweens
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.Animation.NativeFieldInfoPtr_tweens));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<FloatingTextManager.Animation.Tween>) null : new Il2CppReferenceArray<FloatingTextManager.Animation.Tween>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.Animation.NativeFieldInfoPtr_tweens), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public sealed class Tween : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ease;
      private static readonly System.IntPtr NativeFieldInfoPtr_curve;
      private static readonly System.IntPtr NativeFieldInfoPtr_duration;
      private static readonly System.IntPtr NativeFieldInfoPtr_delay;
      private static readonly System.IntPtr NativeFieldInfoPtr_property;
      private static readonly System.IntPtr NativeFieldInfoPtr_relative;
      private static readonly System.IntPtr NativeFieldInfoPtr_to;
      private static readonly System.IntPtr NativeFieldInfoPtr_hasFrom;
      private static readonly System.IntPtr NativeFieldInfoPtr_from;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAnimationCurve_Private_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Fire_Public_Void_GameObject_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetDuration_Public_Single_0;

      public unsafe bool IsAnimationCurve
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FloatingTextManager.Animation.Tween.NativeMethodInfoPtr_get_IsAnimationCurve_Private_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 50416, RefRangeEnd = 50417, XrefRangeStart = 50382, XrefRangeEnd = 50416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Fire(GameObject target, float strength)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &strength;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FloatingTextManager.Animation.Tween.NativeMethodInfoPtr_Fire_Public_Void_GameObject_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe float GetDuration()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FloatingTextManager.Animation.Tween.NativeMethodInfoPtr_GetDuration_Public_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Tween()
      {
        Il2CppClassPointerStore<FloatingTextManager.Animation.Tween>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatingTextManager.Animation>.NativeClassPtr, nameof (Tween));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatingTextManager.Animation.Tween>.NativeClassPtr);
        FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_ease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatingTextManager.Animation.Tween>.NativeClassPtr, nameof (ease));
        FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatingTextManager.Animation.Tween>.NativeClassPtr, nameof (curve));
        FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatingTextManager.Animation.Tween>.NativeClassPtr, nameof (duration));
        FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatingTextManager.Animation.Tween>.NativeClassPtr, nameof (delay));
        FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatingTextManager.Animation.Tween>.NativeClassPtr, nameof (property));
        FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_relative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatingTextManager.Animation.Tween>.NativeClassPtr, nameof (relative));
        FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatingTextManager.Animation.Tween>.NativeClassPtr, nameof (to));
        FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_hasFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatingTextManager.Animation.Tween>.NativeClassPtr, nameof (hasFrom));
        FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_from = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatingTextManager.Animation.Tween>.NativeClassPtr, nameof (from));
        FloatingTextManager.Animation.Tween.NativeMethodInfoPtr_get_IsAnimationCurve_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatingTextManager.Animation.Tween>.NativeClassPtr, 100667300);
        FloatingTextManager.Animation.Tween.NativeMethodInfoPtr_Fire_Public_Void_GameObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatingTextManager.Animation.Tween>.NativeClassPtr, 100667301);
        FloatingTextManager.Animation.Tween.NativeMethodInfoPtr_GetDuration_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatingTextManager.Animation.Tween>.NativeClassPtr, 100667302);
      }

      public Tween(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Tween()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FloatingTextManager.Animation.Tween>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FloatingTextManager.Animation.Tween>.NativeClassPtr, data));
      }

      public unsafe LeanTweenType ease
      {
        get
        {
          return *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_ease));
        }
        [param: In] set
        {
          *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_ease)) = value;
        }
      }

      public unsafe AnimationCurve curve
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_curve));
          return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float duration
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_duration));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_duration)) = value;
        }
      }

      public unsafe float delay
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_delay));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_delay)) = value;
        }
      }

      public unsafe FloatingTextManager.Animation.Tween.Property property
      {
        get
        {
          return *(FloatingTextManager.Animation.Tween.Property*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_property));
        }
        [param: In] set
        {
          *(FloatingTextManager.Animation.Tween.Property*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_property)) = value;
        }
      }

      public unsafe bool relative
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_relative));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_relative)) = value;
        }
      }

      public unsafe Vector3 to
      {
        get
        {
          return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_to));
        }
        [param: In] set
        {
          *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_to)) = value;
        }
      }

      public unsafe bool hasFrom
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_hasFrom));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_hasFrom)) = value;
        }
      }

      public unsafe Vector3 from
      {
        get
        {
          return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_from));
        }
        [param: In] set
        {
          *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.Animation.Tween.NativeFieldInfoPtr_from)) = value;
        }
      }

      public enum Property
      {
        Move,
        Scale,
        Rotate,
      }
    }
  }

  [Serializable]
  public sealed class FadeCurve : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_curve;

    static FadeCurve()
    {
      Il2CppClassPointerStore<FloatingTextManager.FadeCurve>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatingTextManager>.NativeClassPtr, nameof (FadeCurve));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatingTextManager.FadeCurve>.NativeClassPtr);
      FloatingTextManager.FadeCurve.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatingTextManager.FadeCurve>.NativeClassPtr, nameof (name));
      FloatingTextManager.FadeCurve.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatingTextManager.FadeCurve>.NativeClassPtr, nameof (curve));
    }

    public FadeCurve(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public FadeCurve()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FloatingTextManager.FadeCurve>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FloatingTextManager.FadeCurve>.NativeClassPtr, data));
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.FadeCurve.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.FadeCurve.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe AnimationCurve curve
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.FadeCurve.NativeFieldInfoPtr_curve));
        return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FloatingTextManager.FadeCurve.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
