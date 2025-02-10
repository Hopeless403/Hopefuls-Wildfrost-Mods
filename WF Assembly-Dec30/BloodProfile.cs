// Decompiled with JetBrains decompiler
// Type: BloodProfile
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
public class BloodProfile : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_variableColor;
  private static readonly IntPtr NativeFieldInfoPtr_color;
  private static readonly IntPtr NativeFieldInfoPtr_colorRange;
  private static readonly IntPtr NativeFieldInfoPtr_bleedFactor;
  private static readonly IntPtr NativeFieldInfoPtr_splatterParticlePrefab;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105399, XrefRangeEnd = 105400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BloodProfile()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodProfile>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BloodProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BloodProfile()
  {
    Il2CppClassPointerStore<BloodProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BloodProfile));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodProfile>.NativeClassPtr);
    BloodProfile.NativeFieldInfoPtr_variableColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodProfile>.NativeClassPtr, nameof (variableColor));
    BloodProfile.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodProfile>.NativeClassPtr, nameof (color));
    BloodProfile.NativeFieldInfoPtr_colorRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodProfile>.NativeClassPtr, nameof (colorRange));
    BloodProfile.NativeFieldInfoPtr_bleedFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodProfile>.NativeClassPtr, nameof (bleedFactor));
    BloodProfile.NativeFieldInfoPtr_splatterParticlePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodProfile>.NativeClassPtr, nameof (splatterParticlePrefab));
    BloodProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodProfile>.NativeClassPtr, 100672809);
  }

  public BloodProfile(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool variableColor
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodProfile.NativeFieldInfoPtr_variableColor));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodProfile.NativeFieldInfoPtr_variableColor)) = value;
    }
  }

  public unsafe Color color
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodProfile.NativeFieldInfoPtr_color));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodProfile.NativeFieldInfoPtr_color)) = value;
    }
  }

  public unsafe Gradient colorRange
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodProfile.NativeFieldInfoPtr_colorRange));
      return pointer == IntPtr.Zero ? (Gradient) null : new Gradient(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodProfile.NativeFieldInfoPtr_colorRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float bleedFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodProfile.NativeFieldInfoPtr_bleedFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodProfile.NativeFieldInfoPtr_bleedFactor)) = value;
    }
  }

  public unsafe SplatterParticle splatterParticlePrefab
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodProfile.NativeFieldInfoPtr_splatterParticlePrefab));
      return pointer == IntPtr.Zero ? (SplatterParticle) null : new SplatterParticle(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodProfile.NativeFieldInfoPtr_splatterParticlePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
