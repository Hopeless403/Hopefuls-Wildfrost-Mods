// Decompiled with JetBrains decompiler
// Type: LeanAudio
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
public class LeanAudio : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_MIN_FREQEUNCY_PERIOD;
  private static readonly System.IntPtr NativeFieldInfoPtr_PROCESSING_ITERATIONS_MAX;
  private static readonly System.IntPtr NativeFieldInfoPtr_generatedWaveDistances;
  private static readonly System.IntPtr NativeFieldInfoPtr_generatedWaveDistancesCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_longList;
  private static readonly System.IntPtr NativeMethodInfoPtr_options_Public_Static_LeanAudioOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_createAudioStream_Public_Static_LeanAudioStream_AnimationCurve_AnimationCurve_LeanAudioOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_createAudio_Public_Static_AudioClip_AnimationCurve_AnimationCurve_LeanAudioOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_createAudioWave_Private_Static_Int32_AnimationCurve_AnimationCurve_LeanAudioOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_createAudioFromWave_Private_Static_AudioClip_Int32_LeanAudioOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAudioSetPosition_Private_Static_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_generateAudioFromCurve_Public_Static_AudioClip_AnimationCurve_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_playClipAt_Public_Static_AudioSource_AudioClip_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_printOutAudioClip_Public_Static_Void_AudioClip_byref_AnimationCurve_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128454, XrefRangeEnd = 128476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LeanAudioOptions options()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_options_Public_Static_LeanAudioOptions_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LeanAudioOptions) null : new LeanAudioOptions(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128476, XrefRangeEnd = 128485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LeanAudioStream createAudioStream(
    AnimationCurve volume,
    AnimationCurve frequency,
    LeanAudioOptions options = null)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volume);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frequency);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_createAudioStream_Public_Static_LeanAudioStream_AnimationCurve_AnimationCurve_LeanAudioOptions_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LeanAudioStream) null : new LeanAudioStream(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128485, XrefRangeEnd = 128495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AudioClip createAudio(
    AnimationCurve volume,
    AnimationCurve frequency,
    LeanAudioOptions options = null)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volume);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frequency);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_createAudio_Public_Static_AudioClip_AnimationCurve_AnimationCurve_LeanAudioOptions_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (AudioClip) null : new AudioClip(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 128532, RefRangeEnd = 128534, XrefRangeStart = 128495, XrefRangeEnd = 128532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int createAudioWave(
    AnimationCurve volume,
    AnimationCurve frequency,
    LeanAudioOptions options)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volume);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frequency);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_createAudioWave_Private_Static_Int32_AnimationCurve_AnimationCurve_LeanAudioOptions_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 128588, RefRangeEnd = 128590, XrefRangeStart = 128534, XrefRangeEnd = 128588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AudioClip createAudioFromWave(int waveLength, LeanAudioOptions options)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &waveLength;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_createAudioFromWave_Private_Static_AudioClip_Int32_LeanAudioOptions_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (AudioClip) null : new AudioClip(pointer);
  }

  [CallerCount(12611)]
  [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnAudioSetPosition(int newPosition)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &newPosition
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_OnAudioSetPosition_Private_Static_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128590, XrefRangeEnd = 128602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AudioClip generateAudioFromCurve(AnimationCurve curve, int frequencyRate = 44100)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) curve);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &frequencyRate;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_generateAudioFromCurve_Public_Static_AudioClip_AnimationCurve_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (AudioClip) null : new AudioClip(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128602, XrefRangeEnd = 128609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AudioSource play(AudioClip audio, float volume)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) audio);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &volume;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (AudioSource) null : new AudioSource(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128609, XrefRangeEnd = 128615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AudioSource play(AudioClip audio)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) audio)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (AudioSource) null : new AudioSource(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128615, XrefRangeEnd = 128619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AudioSource play(AudioClip audio, Vector3 pos)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) audio);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pos;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (AudioSource) null : new AudioSource(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128619, XrefRangeEnd = 128625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AudioSource play(AudioClip audio, Vector3 pos, float volume)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) audio);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &volume;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (AudioSource) null : new AudioSource(pointer);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 128641, RefRangeEnd = 128645, XrefRangeStart = 128625, XrefRangeEnd = 128641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AudioSource playClipAt(AudioClip clip, Vector3 pos)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pos;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_playClipAt_Public_Static_AudioSource_AudioClip_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (AudioSource) null : new AudioSource(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128645, XrefRangeEnd = 128664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void printOutAudioClip(
    AudioClip audioClip,
    ref AnimationCurve curve,
    float scaleX = 1f)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) audioClip);
    System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) curve);
    System.IntPtr* numPtr2 = &ptr;
    *(System.IntPtr*) num = (System.IntPtr) numPtr2;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &scaleX;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr_printOutAudioClip_Public_Static_Void_AudioClip_byref_AnimationCurve_Single_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref AnimationCurve local = ref curve;
    System.IntPtr pointer = ptr;
    AnimationCurve animationCurve = pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    local = animationCurve;
  }

  [CallerCount(1959)]
  [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LeanAudio()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanAudio.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LeanAudio()
  {
    Il2CppClassPointerStore<LeanAudio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LeanAudio));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr);
    LeanAudio.NativeFieldInfoPtr_MIN_FREQEUNCY_PERIOD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, nameof (MIN_FREQEUNCY_PERIOD));
    LeanAudio.NativeFieldInfoPtr_PROCESSING_ITERATIONS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, nameof (PROCESSING_ITERATIONS_MAX));
    LeanAudio.NativeFieldInfoPtr_generatedWaveDistances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, nameof (generatedWaveDistances));
    LeanAudio.NativeFieldInfoPtr_generatedWaveDistancesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, nameof (generatedWaveDistancesCount));
    LeanAudio.NativeFieldInfoPtr_longList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, nameof (longList));
    LeanAudio.NativeMethodInfoPtr_options_Public_Static_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100676581);
    LeanAudio.NativeMethodInfoPtr_createAudioStream_Public_Static_LeanAudioStream_AnimationCurve_AnimationCurve_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100676582);
    LeanAudio.NativeMethodInfoPtr_createAudio_Public_Static_AudioClip_AnimationCurve_AnimationCurve_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100676583);
    LeanAudio.NativeMethodInfoPtr_createAudioWave_Private_Static_Int32_AnimationCurve_AnimationCurve_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100676584);
    LeanAudio.NativeMethodInfoPtr_createAudioFromWave_Private_Static_AudioClip_Int32_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100676585);
    LeanAudio.NativeMethodInfoPtr_OnAudioSetPosition_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100676586);
    LeanAudio.NativeMethodInfoPtr_generateAudioFromCurve_Public_Static_AudioClip_AnimationCurve_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100676587);
    LeanAudio.NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100676588);
    LeanAudio.NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100676589);
    LeanAudio.NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100676590);
    LeanAudio.NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100676591);
    LeanAudio.NativeMethodInfoPtr_playClipAt_Public_Static_AudioSource_AudioClip_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100676592);
    LeanAudio.NativeMethodInfoPtr_printOutAudioClip_Public_Static_Void_AudioClip_byref_AnimationCurve_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100676593);
    LeanAudio.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100676594);
  }

  public LeanAudio(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe float MIN_FREQEUNCY_PERIOD
  {
    get
    {
      float minFreqeuncyPeriod;
      IL2CPP.il2cpp_field_static_get_value(LeanAudio.NativeFieldInfoPtr_MIN_FREQEUNCY_PERIOD, (void*) &minFreqeuncyPeriod);
      return minFreqeuncyPeriod;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanAudio.NativeFieldInfoPtr_MIN_FREQEUNCY_PERIOD, (void*) &value);
    }
  }

  public static unsafe int PROCESSING_ITERATIONS_MAX
  {
    get
    {
      int processingIterationsMax;
      IL2CPP.il2cpp_field_static_get_value(LeanAudio.NativeFieldInfoPtr_PROCESSING_ITERATIONS_MAX, (void*) &processingIterationsMax);
      return processingIterationsMax;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanAudio.NativeFieldInfoPtr_PROCESSING_ITERATIONS_MAX, (void*) &value);
    }
  }

  public static unsafe Il2CppStructArray<float> generatedWaveDistances
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LeanAudio.NativeFieldInfoPtr_generatedWaveDistances, (void*) &num);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<float>) null : new Il2CppStructArray<float>(nativeObject);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanAudio.NativeFieldInfoPtr_generatedWaveDistances, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe int generatedWaveDistancesCount
  {
    get
    {
      int waveDistancesCount;
      IL2CPP.il2cpp_field_static_get_value(LeanAudio.NativeFieldInfoPtr_generatedWaveDistancesCount, (void*) &waveDistancesCount);
      return waveDistancesCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanAudio.NativeFieldInfoPtr_generatedWaveDistancesCount, (void*) &value);
    }
  }

  public static unsafe Il2CppStructArray<float> longList
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LeanAudio.NativeFieldInfoPtr_longList, (void*) &num);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<float>) null : new Il2CppStructArray<float>(nativeObject);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanAudio.NativeFieldInfoPtr_longList, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
