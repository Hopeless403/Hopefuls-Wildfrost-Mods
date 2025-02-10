// Decompiled with JetBrains decompiler
// Type: SnowfallParticles
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
public class SnowfallParticles : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_storminess;
  private static readonly IntPtr NativeFieldInfoPtr_updateCurve;
  private static readonly IntPtr NativeFieldInfoPtr_backSnow;
  private static readonly IntPtr NativeFieldInfoPtr_midSnow;
  private static readonly IntPtr NativeFieldInfoPtr_frontSnow;
  private static readonly IntPtr NativeFieldInfoPtr_bloops;
  private static readonly IntPtr NativeFieldInfoPtr_fade;
  private static readonly IntPtr NativeFieldInfoPtr_angleRange;
  private static readonly IntPtr NativeFieldInfoPtr_backEmissionRange;
  private static readonly IntPtr NativeFieldInfoPtr_midEmissionRange;
  private static readonly IntPtr NativeFieldInfoPtr_frontEmissionRange;
  private static readonly IntPtr NativeFieldInfoPtr_bloopsEmissionRange;
  private static readonly IntPtr NativeFieldInfoPtr_fadeAlphaRange;
  private static readonly IntPtr NativeFieldInfoPtr_simulationSpeedRange;
  private static readonly IntPtr NativeFieldInfoPtr_backSnowGravityRange;
  private static readonly IntPtr NativeFieldInfoPtr_midSnowGravityRange;
  private static readonly IntPtr NativeFieldInfoPtr_frontSnowGravityRange;
  private static readonly IntPtr NativeFieldInfoPtr_bloopsGravityRange;
  private static readonly IntPtr NativeFieldInfoPtr_xRange;
  private static readonly IntPtr NativeFieldInfoPtr_backSnowXSpeedRange;
  private static readonly IntPtr NativeFieldInfoPtr_midSnowXSpeedRange;
  private static readonly IntPtr NativeFieldInfoPtr_frontSnowXSpeedRange;
  private static readonly IntPtr NativeFieldInfoPtr_bloopsXSpeedRange;
  private static readonly IntPtr NativeFieldInfoPtr_backSnowMain;
  private static readonly IntPtr NativeFieldInfoPtr_midSnowMain;
  private static readonly IntPtr NativeFieldInfoPtr_frontSnowMain;
  private static readonly IntPtr NativeFieldInfoPtr_bloopsMain;
  private static readonly IntPtr NativeFieldInfoPtr_backSnowEmission;
  private static readonly IntPtr NativeFieldInfoPtr_midSnowEmission;
  private static readonly IntPtr NativeFieldInfoPtr_frontSnowEmission;
  private static readonly IntPtr NativeFieldInfoPtr_bloopsEmission;
  private static readonly IntPtr NativeFieldInfoPtr_backSnowVel;
  private static readonly IntPtr NativeFieldInfoPtr_midSnowVel;
  private static readonly IntPtr NativeFieldInfoPtr_frontSnowVel;
  private static readonly IntPtr NativeFieldInfoPtr_bloopsVel;
  private static readonly IntPtr NativeFieldInfoPtr_t;
  private static readonly IntPtr NativeFieldInfoPtr_storminessFrom;
  private static readonly IntPtr NativeFieldInfoPtr_storminessTo;
  private static readonly IntPtr NativeFieldInfoPtr_d;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetStorminess_Private_Void_Single_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53783, XrefRangeEnd = 53808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SnowfallParticles.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53808, XrefRangeEnd = 53817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SnowfallParticles.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53817, XrefRangeEnd = 53825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SnowfallParticles.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void SetStorminess(float amount, float duration)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &amount;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &duration;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SnowfallParticles.NativeMethodInfoPtr_SetStorminess_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53825, XrefRangeEnd = 53828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SnowfallParticles.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 53875, RefRangeEnd = 53877, XrefRangeStart = 53828, XrefRangeEnd = 53875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Evaluate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SnowfallParticles.NativeMethodInfoPtr_Evaluate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53877, XrefRangeEnd = 53878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SnowfallParticles()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SnowfallParticles.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SnowfallParticles()
  {
    Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SnowfallParticles));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr);
    SnowfallParticles.NativeFieldInfoPtr_storminess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (storminess));
    SnowfallParticles.NativeFieldInfoPtr_updateCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (updateCurve));
    SnowfallParticles.NativeFieldInfoPtr_backSnow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (backSnow));
    SnowfallParticles.NativeFieldInfoPtr_midSnow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (midSnow));
    SnowfallParticles.NativeFieldInfoPtr_frontSnow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (frontSnow));
    SnowfallParticles.NativeFieldInfoPtr_bloops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (bloops));
    SnowfallParticles.NativeFieldInfoPtr_fade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (fade));
    SnowfallParticles.NativeFieldInfoPtr_angleRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (angleRange));
    SnowfallParticles.NativeFieldInfoPtr_backEmissionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (backEmissionRange));
    SnowfallParticles.NativeFieldInfoPtr_midEmissionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (midEmissionRange));
    SnowfallParticles.NativeFieldInfoPtr_frontEmissionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (frontEmissionRange));
    SnowfallParticles.NativeFieldInfoPtr_bloopsEmissionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (bloopsEmissionRange));
    SnowfallParticles.NativeFieldInfoPtr_fadeAlphaRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (fadeAlphaRange));
    SnowfallParticles.NativeFieldInfoPtr_simulationSpeedRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (simulationSpeedRange));
    SnowfallParticles.NativeFieldInfoPtr_backSnowGravityRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (backSnowGravityRange));
    SnowfallParticles.NativeFieldInfoPtr_midSnowGravityRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (midSnowGravityRange));
    SnowfallParticles.NativeFieldInfoPtr_frontSnowGravityRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (frontSnowGravityRange));
    SnowfallParticles.NativeFieldInfoPtr_bloopsGravityRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (bloopsGravityRange));
    SnowfallParticles.NativeFieldInfoPtr_xRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (xRange));
    SnowfallParticles.NativeFieldInfoPtr_backSnowXSpeedRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (backSnowXSpeedRange));
    SnowfallParticles.NativeFieldInfoPtr_midSnowXSpeedRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (midSnowXSpeedRange));
    SnowfallParticles.NativeFieldInfoPtr_frontSnowXSpeedRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (frontSnowXSpeedRange));
    SnowfallParticles.NativeFieldInfoPtr_bloopsXSpeedRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (bloopsXSpeedRange));
    SnowfallParticles.NativeFieldInfoPtr_backSnowMain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (backSnowMain));
    SnowfallParticles.NativeFieldInfoPtr_midSnowMain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (midSnowMain));
    SnowfallParticles.NativeFieldInfoPtr_frontSnowMain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (frontSnowMain));
    SnowfallParticles.NativeFieldInfoPtr_bloopsMain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (bloopsMain));
    SnowfallParticles.NativeFieldInfoPtr_backSnowEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (backSnowEmission));
    SnowfallParticles.NativeFieldInfoPtr_midSnowEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (midSnowEmission));
    SnowfallParticles.NativeFieldInfoPtr_frontSnowEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (frontSnowEmission));
    SnowfallParticles.NativeFieldInfoPtr_bloopsEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (bloopsEmission));
    SnowfallParticles.NativeFieldInfoPtr_backSnowVel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (backSnowVel));
    SnowfallParticles.NativeFieldInfoPtr_midSnowVel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (midSnowVel));
    SnowfallParticles.NativeFieldInfoPtr_frontSnowVel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (frontSnowVel));
    SnowfallParticles.NativeFieldInfoPtr_bloopsVel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (bloopsVel));
    SnowfallParticles.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (t));
    SnowfallParticles.NativeFieldInfoPtr_storminessFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (storminessFrom));
    SnowfallParticles.NativeFieldInfoPtr_storminessTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (storminessTo));
    SnowfallParticles.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, nameof (d));
    SnowfallParticles.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, 100667696);
    SnowfallParticles.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, 100667697);
    SnowfallParticles.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, 100667698);
    SnowfallParticles.NativeMethodInfoPtr_SetStorminess_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, 100667699);
    SnowfallParticles.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, 100667700);
    SnowfallParticles.NativeMethodInfoPtr_Evaluate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, 100667701);
    SnowfallParticles.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnowfallParticles>.NativeClassPtr, 100667702);
  }

  public SnowfallParticles(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float storminess
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_storminess));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_storminess)) = value;
    }
  }

  public unsafe AnimationCurve updateCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_updateCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_updateCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem backSnow
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_backSnow));
      return pointer == IntPtr.Zero ? (ParticleSystem) null : new ParticleSystem(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_backSnow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem midSnow
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_midSnow));
      return pointer == IntPtr.Zero ? (ParticleSystem) null : new ParticleSystem(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_midSnow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem frontSnow
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_frontSnow));
      return pointer == IntPtr.Zero ? (ParticleSystem) null : new ParticleSystem(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_frontSnow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem bloops
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_bloops));
      return pointer == IntPtr.Zero ? (ParticleSystem) null : new ParticleSystem(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_bloops), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SpriteRenderer fade
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_fade));
      return pointer == IntPtr.Zero ? (SpriteRenderer) null : new SpriteRenderer(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_fade), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve angleRange
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_angleRange));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_angleRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve backEmissionRange
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_backEmissionRange));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_backEmissionRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve midEmissionRange
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_midEmissionRange));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_midEmissionRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve frontEmissionRange
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_frontEmissionRange));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_frontEmissionRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve bloopsEmissionRange
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_bloopsEmissionRange));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_bloopsEmissionRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve fadeAlphaRange
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_fadeAlphaRange));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_fadeAlphaRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve simulationSpeedRange
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_simulationSpeedRange));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_simulationSpeedRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve backSnowGravityRange
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_backSnowGravityRange));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_backSnowGravityRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve midSnowGravityRange
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_midSnowGravityRange));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_midSnowGravityRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve frontSnowGravityRange
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_frontSnowGravityRange));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_frontSnowGravityRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve bloopsGravityRange
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_bloopsGravityRange));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_bloopsGravityRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve xRange
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_xRange));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_xRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve backSnowXSpeedRange
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_backSnowXSpeedRange));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_backSnowXSpeedRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve midSnowXSpeedRange
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_midSnowXSpeedRange));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_midSnowXSpeedRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve frontSnowXSpeedRange
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_frontSnowXSpeedRange));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_frontSnowXSpeedRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve bloopsXSpeedRange
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_bloopsXSpeedRange));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_bloopsXSpeedRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public ParticleSystem.MainModule backSnowMain
  {
    get
    {
      IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_backSnowMain);
      return new ParticleSystem.MainModule(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_backSnowMain), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }

  public ParticleSystem.MainModule midSnowMain
  {
    get
    {
      IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_midSnowMain);
      return new ParticleSystem.MainModule(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_midSnowMain), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }

  public ParticleSystem.MainModule frontSnowMain
  {
    get
    {
      IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_frontSnowMain);
      return new ParticleSystem.MainModule(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_frontSnowMain), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }

  public ParticleSystem.MainModule bloopsMain
  {
    get
    {
      IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_bloopsMain);
      return new ParticleSystem.MainModule(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_bloopsMain), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }

  public ParticleSystem.EmissionModule backSnowEmission
  {
    get
    {
      IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_backSnowEmission);
      return new ParticleSystem.EmissionModule(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.EmissionModule>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_backSnowEmission), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystem.EmissionModule>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }

  public ParticleSystem.EmissionModule midSnowEmission
  {
    get
    {
      IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_midSnowEmission);
      return new ParticleSystem.EmissionModule(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.EmissionModule>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_midSnowEmission), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystem.EmissionModule>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }

  public ParticleSystem.EmissionModule frontSnowEmission
  {
    get
    {
      IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_frontSnowEmission);
      return new ParticleSystem.EmissionModule(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.EmissionModule>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_frontSnowEmission), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystem.EmissionModule>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }

  public ParticleSystem.EmissionModule bloopsEmission
  {
    get
    {
      IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_bloopsEmission);
      return new ParticleSystem.EmissionModule(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.EmissionModule>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_bloopsEmission), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystem.EmissionModule>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }

  public ParticleSystem.VelocityOverLifetimeModule backSnowVel
  {
    get
    {
      IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_backSnowVel);
      return new ParticleSystem.VelocityOverLifetimeModule(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.VelocityOverLifetimeModule>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_backSnowVel), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystem.VelocityOverLifetimeModule>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }

  public ParticleSystem.VelocityOverLifetimeModule midSnowVel
  {
    get
    {
      IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_midSnowVel);
      return new ParticleSystem.VelocityOverLifetimeModule(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.VelocityOverLifetimeModule>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_midSnowVel), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystem.VelocityOverLifetimeModule>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }

  public ParticleSystem.VelocityOverLifetimeModule frontSnowVel
  {
    get
    {
      IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_frontSnowVel);
      return new ParticleSystem.VelocityOverLifetimeModule(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.VelocityOverLifetimeModule>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_frontSnowVel), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystem.VelocityOverLifetimeModule>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }

  public ParticleSystem.VelocityOverLifetimeModule bloopsVel
  {
    get
    {
      IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_bloopsVel);
      return new ParticleSystem.VelocityOverLifetimeModule(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.VelocityOverLifetimeModule>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_bloopsVel), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystem.VelocityOverLifetimeModule>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }

  public unsafe float t
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_t));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_t)) = value;
    }
  }

  public unsafe float storminessFrom
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_storminessFrom));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_storminessFrom)) = value;
    }
  }

  public unsafe float storminessTo
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_storminessTo));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_storminessTo)) = value;
    }
  }

  public unsafe float d
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_d));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowfallParticles.NativeFieldInfoPtr_d)) = value;
    }
  }
}
