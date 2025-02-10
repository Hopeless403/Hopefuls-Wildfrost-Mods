// Decompiled with JetBrains decompiler
// Type: AudioSettingsSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using FMOD;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine.AddressableAssets;

#nullable disable
public class AudioSettingsSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Loading;
  private static readonly System.IntPtr NativeFieldInfoPtr_buses;
  private static readonly System.IntPtr NativeFieldInfoPtr_slowmoPitchMin;
  private static readonly System.IntPtr NativeFieldInfoPtr_slowmoPitchLerp;
  private static readonly System.IntPtr NativeFieldInfoPtr_slowmoLerpUseDelta;
  private static readonly System.IntPtr NativeFieldInfoPtr_banksToLoad;
  private static readonly System.IntPtr NativeFieldInfoPtr_busLookup;
  private static readonly System.IntPtr NativeFieldInfoPtr_slowmoPitch;
  private static readonly System.IntPtr NativeFieldInfoPtr_slowmoPitchTarget;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadBanks_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TimeScaleChange_Private_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetVolume_Private_Void_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Volume_Public_Static_Void_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetVolume_Public_Static_Single_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPitch_Private_Void_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PromptUpdate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71066, XrefRangeEnd = 71073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AudioSettingsSystem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71073, XrefRangeEnd = 71094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AudioSettingsSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71094, XrefRangeEnd = 71115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AudioSettingsSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71115, XrefRangeEnd = 71120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator LoadBanks()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AudioSettingsSystem.NativeMethodInfoPtr_LoadBanks_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71120, XrefRangeEnd = 71130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AudioSettingsSystem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71130, XrefRangeEnd = 71135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TimeScaleChange(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AudioSettingsSystem.NativeMethodInfoPtr_TimeScaleChange_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71135, XrefRangeEnd = 71145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetVolume(string busName, float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(busName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AudioSettingsSystem.NativeMethodInfoPtr_SetVolume_Private_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 71163, RefRangeEnd = 71164, XrefRangeStart = 71145, XrefRangeEnd = 71163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Volume(string busName, float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(busName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AudioSettingsSystem.NativeMethodInfoPtr_Volume_Public_Static_Void_String_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 71175, RefRangeEnd = 71176, XrefRangeStart = 71164, XrefRangeEnd = 71175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GetVolume(string busName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(busName)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AudioSettingsSystem.NativeMethodInfoPtr_GetVolume_Public_Static_Single_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 71180, RefRangeEnd = 71181, XrefRangeStart = 71176, XrefRangeEnd = 71180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPitch(string busName, float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(busName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AudioSettingsSystem.NativeMethodInfoPtr_SetPitch_Private_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71181, XrefRangeEnd = 71184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PromptUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AudioSettingsSystem.NativeMethodInfoPtr_PromptUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71184, XrefRangeEnd = 71185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AudioSettingsSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AudioSettingsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static AudioSettingsSystem()
  {
    Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (AudioSettingsSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr);
    AudioSettingsSystem.NativeFieldInfoPtr_Loading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr, nameof (Loading));
    AudioSettingsSystem.NativeFieldInfoPtr_buses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr, nameof (buses));
    AudioSettingsSystem.NativeFieldInfoPtr_slowmoPitchMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr, nameof (slowmoPitchMin));
    AudioSettingsSystem.NativeFieldInfoPtr_slowmoPitchLerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr, nameof (slowmoPitchLerp));
    AudioSettingsSystem.NativeFieldInfoPtr_slowmoLerpUseDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr, nameof (slowmoLerpUseDelta));
    AudioSettingsSystem.NativeFieldInfoPtr_banksToLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr, nameof (banksToLoad));
    AudioSettingsSystem.NativeFieldInfoPtr_busLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr, nameof (busLookup));
    AudioSettingsSystem.NativeFieldInfoPtr_slowmoPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr, nameof (slowmoPitch));
    AudioSettingsSystem.NativeFieldInfoPtr_slowmoPitchTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr, nameof (slowmoPitchTarget));
    AudioSettingsSystem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr, 100669110);
    AudioSettingsSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr, 100669111);
    AudioSettingsSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr, 100669112);
    AudioSettingsSystem.NativeMethodInfoPtr_LoadBanks_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr, 100669113);
    AudioSettingsSystem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr, 100669114);
    AudioSettingsSystem.NativeMethodInfoPtr_TimeScaleChange_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr, 100669115);
    AudioSettingsSystem.NativeMethodInfoPtr_SetVolume_Private_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr, 100669116);
    AudioSettingsSystem.NativeMethodInfoPtr_Volume_Public_Static_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr, 100669117);
    AudioSettingsSystem.NativeMethodInfoPtr_GetVolume_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr, 100669118);
    AudioSettingsSystem.NativeMethodInfoPtr_SetPitch_Private_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr, 100669119);
    AudioSettingsSystem.NativeMethodInfoPtr_PromptUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr, 100669120);
    AudioSettingsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr, 100669121);
  }

  public AudioSettingsSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe bool Loading
  {
    get
    {
      bool loading;
      IL2CPP.il2cpp_field_static_get_value(AudioSettingsSystem.NativeFieldInfoPtr_Loading, (void*) &loading);
      return loading;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AudioSettingsSystem.NativeFieldInfoPtr_Loading, (void*) &value);
    }
  }

  public unsafe Il2CppReferenceArray<AudioSettingsSystem.Bus> buses
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.NativeFieldInfoPtr_buses));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<AudioSettingsSystem.Bus>) null : new Il2CppReferenceArray<AudioSettingsSystem.Bus>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.NativeFieldInfoPtr_buses), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float slowmoPitchMin
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.NativeFieldInfoPtr_slowmoPitchMin));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.NativeFieldInfoPtr_slowmoPitchMin)) = value;
    }
  }

  public unsafe float slowmoPitchLerp
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.NativeFieldInfoPtr_slowmoPitchLerp));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.NativeFieldInfoPtr_slowmoPitchLerp)) = value;
    }
  }

  public unsafe bool slowmoLerpUseDelta
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.NativeFieldInfoPtr_slowmoLerpUseDelta));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.NativeFieldInfoPtr_slowmoLerpUseDelta)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<AssetReference> banksToLoad
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.NativeFieldInfoPtr_banksToLoad));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<AssetReference>) null : new Il2CppReferenceArray<AssetReference>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.NativeFieldInfoPtr_banksToLoad), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, AudioSettingsSystem.Bus> busLookup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.NativeFieldInfoPtr_busLookup));
      return pointer == System.IntPtr.Zero ? (Dictionary<string, AudioSettingsSystem.Bus>) null : new Dictionary<string, AudioSettingsSystem.Bus>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.NativeFieldInfoPtr_busLookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float slowmoPitch
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.NativeFieldInfoPtr_slowmoPitch));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.NativeFieldInfoPtr_slowmoPitch)) = value;
    }
  }

  public unsafe float slowmoPitchTarget
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.NativeFieldInfoPtr_slowmoPitchTarget));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.NativeFieldInfoPtr_slowmoPitchTarget)) = value;
    }
  }

  [Serializable]
  public class Bus : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_path;
    private static readonly System.IntPtr NativeFieldInfoPtr_volumeSettingsKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_volume;
    private static readonly System.IntPtr NativeFieldInfoPtr_pitch;
    private static readonly System.IntPtr NativeFieldInfoPtr_bus;
    private static readonly System.IntPtr NativeFieldInfoPtr_channelGroup;
    private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVolume_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePitch_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71025, XrefRangeEnd = 71039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Init()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AudioSettingsSystem.Bus.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 71040, RefRangeEnd = 71043, XrefRangeStart = 71039, XrefRangeEnd = 71040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateVolume()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AudioSettingsSystem.Bus.NativeMethodInfoPtr_UpdateVolume_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 71045, RefRangeEnd = 71047, XrefRangeStart = 71043, XrefRangeEnd = 71045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdatePitch()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AudioSettingsSystem.Bus.NativeMethodInfoPtr_UpdatePitch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71047, XrefRangeEnd = 71048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Bus()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSettingsSystem.Bus>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AudioSettingsSystem.Bus.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Bus()
    {
      Il2CppClassPointerStore<AudioSettingsSystem.Bus>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr, nameof (Bus));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSettingsSystem.Bus>.NativeClassPtr);
      AudioSettingsSystem.Bus.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsSystem.Bus>.NativeClassPtr, nameof (name));
      AudioSettingsSystem.Bus.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsSystem.Bus>.NativeClassPtr, nameof (path));
      AudioSettingsSystem.Bus.NativeFieldInfoPtr_volumeSettingsKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsSystem.Bus>.NativeClassPtr, nameof (volumeSettingsKey));
      AudioSettingsSystem.Bus.NativeFieldInfoPtr_volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsSystem.Bus>.NativeClassPtr, nameof (volume));
      AudioSettingsSystem.Bus.NativeFieldInfoPtr_pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsSystem.Bus>.NativeClassPtr, nameof (pitch));
      AudioSettingsSystem.Bus.NativeFieldInfoPtr_bus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsSystem.Bus>.NativeClassPtr, nameof (bus));
      AudioSettingsSystem.Bus.NativeFieldInfoPtr_channelGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsSystem.Bus>.NativeClassPtr, nameof (channelGroup));
      AudioSettingsSystem.Bus.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsSystem.Bus>.NativeClassPtr, 100669122);
      AudioSettingsSystem.Bus.NativeMethodInfoPtr_UpdateVolume_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsSystem.Bus>.NativeClassPtr, 100669123);
      AudioSettingsSystem.Bus.NativeMethodInfoPtr_UpdatePitch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsSystem.Bus>.NativeClassPtr, 100669124);
      AudioSettingsSystem.Bus.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsSystem.Bus>.NativeClassPtr, 100669125);
    }

    public Bus(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.Bus.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.Bus.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string path
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.Bus.NativeFieldInfoPtr_path)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.Bus.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string volumeSettingsKey
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.Bus.NativeFieldInfoPtr_volumeSettingsKey)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.Bus.NativeFieldInfoPtr_volumeSettingsKey), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe float volume
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.Bus.NativeFieldInfoPtr_volume));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.Bus.NativeFieldInfoPtr_volume)) = value;
      }
    }

    public unsafe float pitch
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.Bus.NativeFieldInfoPtr_pitch));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.Bus.NativeFieldInfoPtr_pitch)) = value;
      }
    }

    public unsafe FMOD.Studio.Bus bus
    {
      get
      {
        return *(FMOD.Studio.Bus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.Bus.NativeFieldInfoPtr_bus));
      }
      [param: In] set
      {
        *(FMOD.Studio.Bus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.Bus.NativeFieldInfoPtr_bus)) = value;
      }
    }

    public unsafe ChannelGroup channelGroup
    {
      get
      {
        return *(ChannelGroup*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.Bus.NativeFieldInfoPtr_channelGroup));
      }
      [param: In] set
      {
        *(ChannelGroup*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem.Bus.NativeFieldInfoPtr_channelGroup)) = value;
      }
    }
  }

  [ObfuscatedName("AudioSettingsSystem/<LoadBanks>d__12")]
  public sealed class _LoadBanks_d__12 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _LoadBanks_d__12(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSettingsSystem._LoadBanks_d__12>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AudioSettingsSystem._LoadBanks_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AudioSettingsSystem._LoadBanks_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71048, XrefRangeEnd = 71060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AudioSettingsSystem._LoadBanks_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AudioSettingsSystem._LoadBanks_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71060, XrefRangeEnd = 71066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AudioSettingsSystem._LoadBanks_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AudioSettingsSystem._LoadBanks_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _LoadBanks_d__12()
    {
      Il2CppClassPointerStore<AudioSettingsSystem._LoadBanks_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioSettingsSystem>.NativeClassPtr, "<LoadBanks>d__12");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSettingsSystem._LoadBanks_d__12>.NativeClassPtr);
      AudioSettingsSystem._LoadBanks_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsSystem._LoadBanks_d__12>.NativeClassPtr, "<>1__state");
      AudioSettingsSystem._LoadBanks_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsSystem._LoadBanks_d__12>.NativeClassPtr, "<>2__current");
      AudioSettingsSystem._LoadBanks_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsSystem._LoadBanks_d__12>.NativeClassPtr, "<>4__this");
      AudioSettingsSystem._LoadBanks_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsSystem._LoadBanks_d__12>.NativeClassPtr, 100669126);
      AudioSettingsSystem._LoadBanks_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsSystem._LoadBanks_d__12>.NativeClassPtr, 100669127);
      AudioSettingsSystem._LoadBanks_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsSystem._LoadBanks_d__12>.NativeClassPtr, 100669128);
      AudioSettingsSystem._LoadBanks_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsSystem._LoadBanks_d__12>.NativeClassPtr, 100669129);
      AudioSettingsSystem._LoadBanks_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsSystem._LoadBanks_d__12>.NativeClassPtr, 100669130);
      AudioSettingsSystem._LoadBanks_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsSystem._LoadBanks_d__12>.NativeClassPtr, 100669131);
    }

    public _LoadBanks_d__12(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem._LoadBanks_d__12.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem._LoadBanks_d__12.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem._LoadBanks_d__12.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem._LoadBanks_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AudioSettingsSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem._LoadBanks_d__12.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (AudioSettingsSystem) null : new AudioSettingsSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioSettingsSystem._LoadBanks_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
