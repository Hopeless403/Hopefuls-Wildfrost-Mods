// Decompiled with JetBrains decompiler
// Type: LeanAudioOptions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class LeanAudioOptions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_waveStyle;
  private static readonly System.IntPtr NativeFieldInfoPtr_vibrato;
  private static readonly System.IntPtr NativeFieldInfoPtr_modulation;
  private static readonly System.IntPtr NativeFieldInfoPtr_frequencyRate;
  private static readonly System.IntPtr NativeFieldInfoPtr_waveNoiseScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_waveNoiseInfluence;
  private static readonly System.IntPtr NativeFieldInfoPtr_useSetData;
  private static readonly System.IntPtr NativeFieldInfoPtr_stream;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setFrequency_Public_LeanAudioOptions_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setVibrato_Public_LeanAudioOptions_Il2CppStructArray_1_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setWaveSine_Public_LeanAudioOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setWaveSquare_Public_LeanAudioOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setWaveSawtooth_Public_LeanAudioOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setWaveNoise_Public_LeanAudioOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setWaveStyle_Public_LeanAudioOptions_LeanAudioWaveStyle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setWaveNoiseScale_Public_LeanAudioOptions_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setWaveNoiseInfluence_Public_LeanAudioOptions_Single_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128664, XrefRangeEnd = 128665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LeanAudioOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanAudioOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe LeanAudioOptions setFrequency(int frequencyRate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &frequencyRate
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanAudioOptions.NativeMethodInfoPtr_setFrequency_Public_LeanAudioOptions_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LeanAudioOptions) null : new LeanAudioOptions(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128665, XrefRangeEnd = 128666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LeanAudioOptions setVibrato(Il2CppStructArray<Vector3> vibrato)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vibrato)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanAudioOptions.NativeMethodInfoPtr_setVibrato_Public_LeanAudioOptions_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LeanAudioOptions) null : new LeanAudioOptions(pointer);
  }

  [CallerCount(0)]
  public unsafe LeanAudioOptions setWaveSine()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanAudioOptions.NativeMethodInfoPtr_setWaveSine_Public_LeanAudioOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LeanAudioOptions) null : new LeanAudioOptions(pointer);
  }

  [CallerCount(0)]
  public unsafe LeanAudioOptions setWaveSquare()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanAudioOptions.NativeMethodInfoPtr_setWaveSquare_Public_LeanAudioOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LeanAudioOptions) null : new LeanAudioOptions(pointer);
  }

  [CallerCount(0)]
  public unsafe LeanAudioOptions setWaveSawtooth()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanAudioOptions.NativeMethodInfoPtr_setWaveSawtooth_Public_LeanAudioOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LeanAudioOptions) null : new LeanAudioOptions(pointer);
  }

  [CallerCount(0)]
  public unsafe LeanAudioOptions setWaveNoise()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanAudioOptions.NativeMethodInfoPtr_setWaveNoise_Public_LeanAudioOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LeanAudioOptions) null : new LeanAudioOptions(pointer);
  }

  [CallerCount(0)]
  public unsafe LeanAudioOptions setWaveStyle(LeanAudioOptions.LeanAudioWaveStyle style)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &style
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanAudioOptions.NativeMethodInfoPtr_setWaveStyle_Public_LeanAudioOptions_LeanAudioWaveStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LeanAudioOptions) null : new LeanAudioOptions(pointer);
  }

  [CallerCount(0)]
  public unsafe LeanAudioOptions setWaveNoiseScale(float waveScale)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &waveScale
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanAudioOptions.NativeMethodInfoPtr_setWaveNoiseScale_Public_LeanAudioOptions_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LeanAudioOptions) null : new LeanAudioOptions(pointer);
  }

  [CallerCount(0)]
  public unsafe LeanAudioOptions setWaveNoiseInfluence(float influence)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &influence
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanAudioOptions.NativeMethodInfoPtr_setWaveNoiseInfluence_Public_LeanAudioOptions_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LeanAudioOptions) null : new LeanAudioOptions(pointer);
  }

  static LeanAudioOptions()
  {
    Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LeanAudioOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr);
    LeanAudioOptions.NativeFieldInfoPtr_waveStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, nameof (waveStyle));
    LeanAudioOptions.NativeFieldInfoPtr_vibrato = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, nameof (vibrato));
    LeanAudioOptions.NativeFieldInfoPtr_modulation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, nameof (modulation));
    LeanAudioOptions.NativeFieldInfoPtr_frequencyRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, nameof (frequencyRate));
    LeanAudioOptions.NativeFieldInfoPtr_waveNoiseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, nameof (waveNoiseScale));
    LeanAudioOptions.NativeFieldInfoPtr_waveNoiseInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, nameof (waveNoiseInfluence));
    LeanAudioOptions.NativeFieldInfoPtr_useSetData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, nameof (useSetData));
    LeanAudioOptions.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, nameof (stream));
    LeanAudioOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100676596);
    LeanAudioOptions.NativeMethodInfoPtr_setFrequency_Public_LeanAudioOptions_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100676597);
    LeanAudioOptions.NativeMethodInfoPtr_setVibrato_Public_LeanAudioOptions_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100676598);
    LeanAudioOptions.NativeMethodInfoPtr_setWaveSine_Public_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100676599);
    LeanAudioOptions.NativeMethodInfoPtr_setWaveSquare_Public_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100676600);
    LeanAudioOptions.NativeMethodInfoPtr_setWaveSawtooth_Public_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100676601);
    LeanAudioOptions.NativeMethodInfoPtr_setWaveNoise_Public_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100676602);
    LeanAudioOptions.NativeMethodInfoPtr_setWaveStyle_Public_LeanAudioOptions_LeanAudioWaveStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100676603);
    LeanAudioOptions.NativeMethodInfoPtr_setWaveNoiseScale_Public_LeanAudioOptions_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100676604);
    LeanAudioOptions.NativeMethodInfoPtr_setWaveNoiseInfluence_Public_LeanAudioOptions_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100676605);
  }

  public LeanAudioOptions(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LeanAudioOptions.LeanAudioWaveStyle waveStyle
  {
    get
    {
      return *(LeanAudioOptions.LeanAudioWaveStyle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_waveStyle));
    }
    [param: In] set
    {
      *(LeanAudioOptions.LeanAudioWaveStyle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_waveStyle)) = value;
    }
  }

  public unsafe Il2CppStructArray<Vector3> vibrato
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_vibrato));
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : new Il2CppStructArray<Vector3>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_vibrato), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<Vector3> modulation
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_modulation));
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : new Il2CppStructArray<Vector3>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_modulation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int frequencyRate
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_frequencyRate));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_frequencyRate)) = value;
    }
  }

  public unsafe float waveNoiseScale
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_waveNoiseScale));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_waveNoiseScale)) = value;
    }
  }

  public unsafe float waveNoiseInfluence
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_waveNoiseInfluence));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_waveNoiseInfluence)) = value;
    }
  }

  public unsafe bool useSetData
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_useSetData));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_useSetData)) = value;
    }
  }

  public unsafe LeanAudioStream stream
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_stream));
      return pointer == System.IntPtr.Zero ? (LeanAudioStream) null : new LeanAudioStream(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeanAudioOptions.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum LeanAudioWaveStyle
  {
    Sine,
    Square,
    Sawtooth,
    Noise,
  }
}
