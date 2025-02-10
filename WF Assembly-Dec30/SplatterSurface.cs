// Decompiled with JetBrains decompiler
// Type: SplatterSurface
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
public class SplatterSurface : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_splatterContainer;
  private static readonly System.IntPtr NativeFieldInfoPtr_splatterScaleRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_splatterAlphaRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_limitSplatters;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxSplatters;
  private static readonly System.IntPtr NativeFieldInfoPtr_colorBlend;
  private static readonly System.IntPtr NativeFieldInfoPtr_colorBlendRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_blend;
  private static readonly System.IntPtr NativeFieldInfoPtr_fadeSplatters;
  private static readonly System.IntPtr NativeFieldInfoPtr_fadeToColour;
  private static readonly System.IntPtr NativeFieldInfoPtr_fadeToDelay;
  private static readonly System.IntPtr NativeFieldInfoPtr_splatters;
  private static readonly System.IntPtr NativeMethodInfoPtr_Splat_Public_Void_SplatterParticle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_SplatterData_Splatter_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveSplatters_Public_Il2CppReferenceArray_1_Splatter_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 75303, RefRangeEnd = 75304, XrefRangeStart = 75224, XrefRangeEnd = 75303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Splat(SplatterParticle particle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) particle)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplatterSurface.NativeMethodInfoPtr_Splat_Public_Void_SplatterParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75304, XrefRangeEnd = 75318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Load(SplatterPersistenceSystem.SplatterData data, Splatter prefab)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplatterSurface.NativeMethodInfoPtr_Load_Public_Void_SplatterData_Splatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75318, XrefRangeEnd = 75340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppReferenceArray<Splatter> GetActiveSplatters()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SplatterSurface.NativeMethodInfoPtr_GetActiveSplatters_Public_Il2CppReferenceArray_1_Splatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr nativeObject = num;
    return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Splatter>) null : new Il2CppReferenceArray<Splatter>(nativeObject);
  }

  [CallerCount(12611)]
  [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnGetFromPool()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplatterSurface.NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 75361, RefRangeEnd = 75362, XrefRangeStart = 75340, XrefRangeEnd = 75361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnReturnToPool()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplatterSurface.NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75362, XrefRangeEnd = 75371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SplatterSurface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SplatterSurface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplatterSurface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SplatterSurface()
  {
    Il2CppClassPointerStore<SplatterSurface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SplatterSurface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplatterSurface>.NativeClassPtr);
    SplatterSurface.NativeFieldInfoPtr_splatterContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSurface>.NativeClassPtr, nameof (splatterContainer));
    SplatterSurface.NativeFieldInfoPtr_splatterScaleRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSurface>.NativeClassPtr, nameof (splatterScaleRange));
    SplatterSurface.NativeFieldInfoPtr_splatterAlphaRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSurface>.NativeClassPtr, nameof (splatterAlphaRange));
    SplatterSurface.NativeFieldInfoPtr_limitSplatters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSurface>.NativeClassPtr, nameof (limitSplatters));
    SplatterSurface.NativeFieldInfoPtr_maxSplatters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSurface>.NativeClassPtr, nameof (maxSplatters));
    SplatterSurface.NativeFieldInfoPtr_colorBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSurface>.NativeClassPtr, nameof (colorBlend));
    SplatterSurface.NativeFieldInfoPtr_colorBlendRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSurface>.NativeClassPtr, nameof (colorBlendRange));
    SplatterSurface.NativeFieldInfoPtr_blend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSurface>.NativeClassPtr, nameof (blend));
    SplatterSurface.NativeFieldInfoPtr_fadeSplatters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSurface>.NativeClassPtr, nameof (fadeSplatters));
    SplatterSurface.NativeFieldInfoPtr_fadeToColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSurface>.NativeClassPtr, nameof (fadeToColour));
    SplatterSurface.NativeFieldInfoPtr_fadeToDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSurface>.NativeClassPtr, nameof (fadeToDelay));
    SplatterSurface.NativeFieldInfoPtr_splatters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSurface>.NativeClassPtr, nameof (splatters));
    SplatterSurface.NativeMethodInfoPtr_Splat_Public_Void_SplatterParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterSurface>.NativeClassPtr, 100669376);
    SplatterSurface.NativeMethodInfoPtr_Load_Public_Void_SplatterData_Splatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterSurface>.NativeClassPtr, 100669377);
    SplatterSurface.NativeMethodInfoPtr_GetActiveSplatters_Public_Il2CppReferenceArray_1_Splatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterSurface>.NativeClassPtr, 100669378);
    SplatterSurface.NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterSurface>.NativeClassPtr, 100669379);
    SplatterSurface.NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterSurface>.NativeClassPtr, 100669380);
    SplatterSurface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterSurface>.NativeClassPtr, 100669381);
  }

  public SplatterSurface(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe RectTransform splatterContainer
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_splatterContainer));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_splatterContainer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 splatterScaleRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_splatterScaleRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_splatterScaleRange)) = value;
    }
  }

  public unsafe Vector2 splatterAlphaRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_splatterAlphaRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_splatterAlphaRange)) = value;
    }
  }

  public unsafe bool limitSplatters
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_limitSplatters));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_limitSplatters)) = value;
    }
  }

  public unsafe int maxSplatters
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_maxSplatters));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_maxSplatters)) = value;
    }
  }

  public unsafe bool colorBlend
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_colorBlend));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_colorBlend)) = value;
    }
  }

  public unsafe Vector2 colorBlendRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_colorBlendRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_colorBlendRange)) = value;
    }
  }

  public unsafe Color blend
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_blend));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_blend)) = value;
    }
  }

  public unsafe bool fadeSplatters
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_fadeSplatters));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_fadeSplatters)) = value;
    }
  }

  public unsafe Color fadeToColour
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_fadeToColour));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_fadeToColour)) = value;
    }
  }

  public unsafe float fadeToDelay
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_fadeToDelay));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_fadeToDelay)) = value;
    }
  }

  public unsafe List<Splatter> splatters
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_splatters));
      return pointer == System.IntPtr.Zero ? (List<Splatter>) null : new List<Splatter>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.NativeFieldInfoPtr_splatters), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SplatterSurface/<>c__DisplayClass12_0")]
  public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_splatter;
    private static readonly System.IntPtr NativeFieldInfoPtr_from;
    private static readonly System.IntPtr NativeFieldInfoPtr_to;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Splat_b__0_Internal_Void_Single_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass12_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SplatterSurface.__c__DisplayClass12_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SplatterSurface.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75223, XrefRangeEnd = 75224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Splat_b__0(float a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &a
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SplatterSurface.__c__DisplayClass12_0.NativeMethodInfoPtr__Splat_b__0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass12_0()
    {
      Il2CppClassPointerStore<SplatterSurface.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SplatterSurface>.NativeClassPtr, "<>c__DisplayClass12_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplatterSurface.__c__DisplayClass12_0>.NativeClassPtr);
      SplatterSurface.__c__DisplayClass12_0.NativeFieldInfoPtr_splatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSurface.__c__DisplayClass12_0>.NativeClassPtr, nameof (splatter));
      SplatterSurface.__c__DisplayClass12_0.NativeFieldInfoPtr_from = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSurface.__c__DisplayClass12_0>.NativeClassPtr, nameof (from));
      SplatterSurface.__c__DisplayClass12_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSurface.__c__DisplayClass12_0>.NativeClassPtr, nameof (to));
      SplatterSurface.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterSurface.__c__DisplayClass12_0>.NativeClassPtr, 100669382);
      SplatterSurface.__c__DisplayClass12_0.NativeMethodInfoPtr__Splat_b__0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterSurface.__c__DisplayClass12_0>.NativeClassPtr, 100669383);
    }

    public __c__DisplayClass12_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Splatter splatter
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.__c__DisplayClass12_0.NativeFieldInfoPtr_splatter));
        return pointer == System.IntPtr.Zero ? (Splatter) null : new Splatter(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.__c__DisplayClass12_0.NativeFieldInfoPtr_splatter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color from
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.__c__DisplayClass12_0.NativeFieldInfoPtr_from));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.__c__DisplayClass12_0.NativeFieldInfoPtr_from)) = value;
      }
    }

    public unsafe Color to
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.__c__DisplayClass12_0.NativeFieldInfoPtr_to));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSurface.__c__DisplayClass12_0.NativeFieldInfoPtr_to)) = value;
      }
    }
  }

  [ObfuscatedName("SplatterSurface/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__14_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetActiveSplatters_b__14_0_Internal_Boolean_Splatter_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SplatterSurface.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SplatterSurface.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _GetActiveSplatters_b__14_0(Splatter a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SplatterSurface.__c.NativeMethodInfoPtr__GetActiveSplatters_b__14_0_Internal_Boolean_Splatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<SplatterSurface.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SplatterSurface>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplatterSurface.__c>.NativeClassPtr);
      SplatterSurface.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSurface.__c>.NativeClassPtr, "<>9");
      SplatterSurface.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSurface.__c>.NativeClassPtr, "<>9__14_0");
      SplatterSurface.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterSurface.__c>.NativeClassPtr, 100669385);
      SplatterSurface.__c.NativeMethodInfoPtr__GetActiveSplatters_b__14_0_Internal_Boolean_Splatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterSurface.__c>.NativeClassPtr, 100669386);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe SplatterSurface.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SplatterSurface.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (SplatterSurface.__c) null : new SplatterSurface.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SplatterSurface.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Splatter, bool> __9__14_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SplatterSurface.__c.NativeFieldInfoPtr___9__14_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Splatter, bool>) null : new Il2CppSystem.Func<Splatter, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SplatterSurface.__c.NativeFieldInfoPtr___9__14_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
