// Decompiled with JetBrains decompiler
// Type: BattleMusicSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using FMOD;
using FMOD.Studio;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine.SceneManagement;

#nullable disable
public class BattleMusicSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_startingIntensity;
  private static readonly System.IntPtr NativeFieldInfoPtr_normalIntensity;
  private static readonly System.IntPtr NativeFieldInfoPtr_winJingle;
  private static readonly System.IntPtr NativeFieldInfoPtr_loseJingle;
  private static readonly System.IntPtr NativeFieldInfoPtr_minibossIntroDefault;
  private static readonly System.IntPtr NativeFieldInfoPtr_minibossIntros;
  private static readonly System.IntPtr NativeFieldInfoPtr_minibossIntroDuration;
  private static readonly System.IntPtr NativeFieldInfoPtr_minibossIntroLookup;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentScene;
  private static readonly System.IntPtr NativeFieldInfoPtr_current;
  private static readonly System.IntPtr NativeFieldInfoPtr_minibossIntroInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_intensity;
  private static readonly System.IntPtr NativeFieldInfoPtr_intensityParameterId;
  private static readonly System.IntPtr NativeFieldInfoPtr_bossEntered;
  private static readonly System.IntPtr NativeFieldInfoPtr_promptStartMiniboss;
  private static readonly System.IntPtr NativeFieldInfoPtr_bossPhase;
  private static readonly System.IntPtr NativeFieldInfoPtr_volume;
  private static readonly System.IntPtr NativeFieldInfoPtr_pitch;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetVolume;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetPitch;
  private static readonly System.IntPtr NativeFieldInfoPtr_fadeAmount;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FadePitchTo_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SceneChange_Private_Void_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BattlePhaseChange_Private_Void_Phase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BattleEnd_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityMove_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MinibossIntro_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityChangePhase_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Check_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitBattleMusic_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartMusic_Private_Void_EventReference_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartMusic_Private_Void_GUID_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopMusic_Private_Void_STOP_MODE_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetIntensity_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetParam_Private_Void_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsRunning_Private_Static_Boolean_EventInstance_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsBossBattle_Private_Static_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Final_New_BattleMusicSaveData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_BattleMusicSaveData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71185, XrefRangeEnd = 71190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71190, XrefRangeEnd = 71239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71239, XrefRangeEnd = 71288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71288, XrefRangeEnd = 71290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71290, XrefRangeEnd = 71301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void FadePitchTo(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_FadePitchTo_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71301, XrefRangeEnd = 71302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SceneChange(Scene scene)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &scene
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_SceneChange_Private_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71302, XrefRangeEnd = 71304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BattlePhaseChange(Battle.Phase phase)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &phase
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_BattlePhaseChange_Private_Void_Phase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71304, XrefRangeEnd = 71322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BattleEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_BattleEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71322, XrefRangeEnd = 71323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityHit(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71323, XrefRangeEnd = 71338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityMove(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_EntityMove_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71338, XrefRangeEnd = 71361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MinibossIntro(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_MinibossIntro_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71361, XrefRangeEnd = 71366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityChangePhase(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_EntityChangePhase_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 71375, RefRangeEnd = 71377, XrefRangeStart = 71366, XrefRangeEnd = 71375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Check()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_Check_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71377, XrefRangeEnd = 71382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InitBattleMusic()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_InitBattleMusic_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71382, XrefRangeEnd = 71383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartMusic(EventReference eventReference)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &eventReference
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_StartMusic_Private_Void_EventReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 71393, RefRangeEnd = 71396, XrefRangeStart = 71383, XrefRangeEnd = 71393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartMusic(GUID eventGUID)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &eventGUID
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_StartMusic_Private_Void_GUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 71398, RefRangeEnd = 71399, XrefRangeStart = 71396, XrefRangeEnd = 71398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopMusic(FMOD.Studio.STOP_MODE stopMode = FMOD.Studio.STOP_MODE.IMMEDIATE)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &stopMode
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_StopMusic_Private_Void_STOP_MODE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 71410, RefRangeEnd = 71413, XrefRangeStart = 71399, XrefRangeEnd = 71410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetIntensity(int amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &amount
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_SetIntensity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 71426, RefRangeEnd = 71428, XrefRangeStart = 71413, XrefRangeEnd = 71426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetParam(string name, float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_SetParam_Private_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsRunning(EventInstance instance)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &instance
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_IsRunning_Private_Static_Boolean_EventInstance_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71428, XrefRangeEnd = 71431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsBossBattle()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_IsBossBattle_Private_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 71435, RefRangeEnd = 71436, XrefRangeStart = 71431, XrefRangeEnd = 71435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe BattleMusicSaveData Save()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_BattleMusicSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (BattleMusicSaveData) null : new BattleMusicSaveData(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 71447, RefRangeEnd = 71448, XrefRangeStart = 71436, XrefRangeEnd = 71447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Load(BattleMusicSaveData state)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) state)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr_Load_Public_Void_BattleMusicSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71448, XrefRangeEnd = 71457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BattleMusicSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleMusicSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BattleMusicSystem()
  {
    Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BattleMusicSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr);
    BattleMusicSystem.NativeFieldInfoPtr_startingIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, nameof (startingIntensity));
    BattleMusicSystem.NativeFieldInfoPtr_normalIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, nameof (normalIntensity));
    BattleMusicSystem.NativeFieldInfoPtr_winJingle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, nameof (winJingle));
    BattleMusicSystem.NativeFieldInfoPtr_loseJingle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, nameof (loseJingle));
    BattleMusicSystem.NativeFieldInfoPtr_minibossIntroDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, nameof (minibossIntroDefault));
    BattleMusicSystem.NativeFieldInfoPtr_minibossIntros = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, nameof (minibossIntros));
    BattleMusicSystem.NativeFieldInfoPtr_minibossIntroDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, nameof (minibossIntroDuration));
    BattleMusicSystem.NativeFieldInfoPtr_minibossIntroLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, nameof (minibossIntroLookup));
    BattleMusicSystem.NativeFieldInfoPtr_currentScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, nameof (currentScene));
    BattleMusicSystem.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, nameof (current));
    BattleMusicSystem.NativeFieldInfoPtr_minibossIntroInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, nameof (minibossIntroInstance));
    BattleMusicSystem.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, nameof (intensity));
    BattleMusicSystem.NativeFieldInfoPtr_intensityParameterId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, nameof (intensityParameterId));
    BattleMusicSystem.NativeFieldInfoPtr_bossEntered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, nameof (bossEntered));
    BattleMusicSystem.NativeFieldInfoPtr_promptStartMiniboss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, nameof (promptStartMiniboss));
    BattleMusicSystem.NativeFieldInfoPtr_bossPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, nameof (bossPhase));
    BattleMusicSystem.NativeFieldInfoPtr_volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, nameof (volume));
    BattleMusicSystem.NativeFieldInfoPtr_pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, nameof (pitch));
    BattleMusicSystem.NativeFieldInfoPtr_targetVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, nameof (targetVolume));
    BattleMusicSystem.NativeFieldInfoPtr_targetPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, nameof (targetPitch));
    BattleMusicSystem.NativeFieldInfoPtr_fadeAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, nameof (fadeAmount));
    BattleMusicSystem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669132);
    BattleMusicSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669133);
    BattleMusicSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669134);
    BattleMusicSystem.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669135);
    BattleMusicSystem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669136);
    BattleMusicSystem.NativeMethodInfoPtr_FadePitchTo_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669137);
    BattleMusicSystem.NativeMethodInfoPtr_SceneChange_Private_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669138);
    BattleMusicSystem.NativeMethodInfoPtr_BattlePhaseChange_Private_Void_Phase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669139);
    BattleMusicSystem.NativeMethodInfoPtr_BattleEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669140);
    BattleMusicSystem.NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669141);
    BattleMusicSystem.NativeMethodInfoPtr_EntityMove_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669142);
    BattleMusicSystem.NativeMethodInfoPtr_MinibossIntro_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669143);
    BattleMusicSystem.NativeMethodInfoPtr_EntityChangePhase_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669144);
    BattleMusicSystem.NativeMethodInfoPtr_Check_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669145);
    BattleMusicSystem.NativeMethodInfoPtr_InitBattleMusic_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669146);
    BattleMusicSystem.NativeMethodInfoPtr_StartMusic_Private_Void_EventReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669147);
    BattleMusicSystem.NativeMethodInfoPtr_StartMusic_Private_Void_GUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669148);
    BattleMusicSystem.NativeMethodInfoPtr_StopMusic_Private_Void_STOP_MODE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669149);
    BattleMusicSystem.NativeMethodInfoPtr_SetIntensity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669150);
    BattleMusicSystem.NativeMethodInfoPtr_SetParam_Private_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669151);
    BattleMusicSystem.NativeMethodInfoPtr_IsRunning_Private_Static_Boolean_EventInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669152);
    BattleMusicSystem.NativeMethodInfoPtr_IsBossBattle_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669153);
    BattleMusicSystem.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_BattleMusicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669154);
    BattleMusicSystem.NativeMethodInfoPtr_Load_Public_Void_BattleMusicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669155);
    BattleMusicSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, 100669156);
  }

  public BattleMusicSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int startingIntensity
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_startingIntensity));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_startingIntensity)) = value;
    }
  }

  public unsafe int normalIntensity
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_normalIntensity));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_normalIntensity)) = value;
    }
  }

  public unsafe EventReference winJingle
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_winJingle));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_winJingle)) = value;
    }
  }

  public unsafe EventReference loseJingle
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_loseJingle));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_loseJingle)) = value;
    }
  }

  public unsafe EventReference minibossIntroDefault
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_minibossIntroDefault));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_minibossIntroDefault)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<BattleMusicSystem.MinibossIntroRef> minibossIntros
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_minibossIntros));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<BattleMusicSystem.MinibossIntroRef>) null : new Il2CppReferenceArray<BattleMusicSystem.MinibossIntroRef>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_minibossIntros), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float minibossIntroDuration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_minibossIntroDuration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_minibossIntroDuration)) = value;
    }
  }

  public unsafe Dictionary<string, EventReference> minibossIntroLookup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_minibossIntroLookup));
      return pointer == System.IntPtr.Zero ? (Dictionary<string, EventReference>) null : new Dictionary<string, EventReference>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_minibossIntroLookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Scene currentScene
  {
    get
    {
      return *(Scene*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_currentScene));
    }
    [param: In] set
    {
      *(Scene*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_currentScene)) = value;
    }
  }

  public unsafe EventInstance current
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_current));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_current)) = value;
    }
  }

  public unsafe EventInstance minibossIntroInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_minibossIntroInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_minibossIntroInstance)) = value;
    }
  }

  public unsafe int intensity
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_intensity));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_intensity)) = value;
    }
  }

  public unsafe PARAMETER_ID intensityParameterId
  {
    get
    {
      return *(PARAMETER_ID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_intensityParameterId));
    }
    [param: In] set
    {
      *(PARAMETER_ID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_intensityParameterId)) = value;
    }
  }

  public unsafe bool bossEntered
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_bossEntered));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_bossEntered)) = value;
    }
  }

  public unsafe float promptStartMiniboss
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_promptStartMiniboss));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_promptStartMiniboss)) = value;
    }
  }

  public unsafe int bossPhase
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_bossPhase));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_bossPhase)) = value;
    }
  }

  public unsafe float volume
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_volume));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_volume)) = value;
    }
  }

  public unsafe float pitch
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_pitch));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_pitch)) = value;
    }
  }

  public unsafe float targetVolume
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_targetVolume));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_targetVolume)) = value;
    }
  }

  public unsafe float targetPitch
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_targetPitch));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.NativeFieldInfoPtr_targetPitch)) = value;
    }
  }

  public static unsafe float fadeAmount
  {
    get
    {
      float fadeAmount;
      IL2CPP.il2cpp_field_static_get_value(BattleMusicSystem.NativeFieldInfoPtr_fadeAmount, (void*) &fadeAmount);
      return fadeAmount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BattleMusicSystem.NativeFieldInfoPtr_fadeAmount, (void*) &value);
    }
  }

  [Serializable]
  public sealed class MinibossIntroRef : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_cardData;
    private static readonly System.IntPtr NativeFieldInfoPtr_introEvent;

    static MinibossIntroRef()
    {
      Il2CppClassPointerStore<BattleMusicSystem.MinibossIntroRef>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleMusicSystem>.NativeClassPtr, nameof (MinibossIntroRef));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleMusicSystem.MinibossIntroRef>.NativeClassPtr);
      BattleMusicSystem.MinibossIntroRef.NativeFieldInfoPtr_cardData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSystem.MinibossIntroRef>.NativeClassPtr, nameof (cardData));
      BattleMusicSystem.MinibossIntroRef.NativeFieldInfoPtr_introEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleMusicSystem.MinibossIntroRef>.NativeClassPtr, nameof (introEvent));
    }

    public MinibossIntroRef(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public MinibossIntroRef()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BattleMusicSystem.MinibossIntroRef>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BattleMusicSystem.MinibossIntroRef>.NativeClassPtr, data));
    }

    public unsafe CardData cardData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.MinibossIntroRef.NativeFieldInfoPtr_cardData));
        return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.MinibossIntroRef.NativeFieldInfoPtr_cardData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EventReference introEvent
    {
      get
      {
        return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.MinibossIntroRef.NativeFieldInfoPtr_introEvent));
      }
      [param: In] set
      {
        *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleMusicSystem.MinibossIntroRef.NativeFieldInfoPtr_introEvent)) = value;
      }
    }
  }
}
