// Decompiled with JetBrains decompiler
// Type: FinalBossSequenceSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.UI;

#nullable disable
public class FinalBossSequenceSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_wispPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_canvas;
  private static readonly System.IntPtr NativeFieldInfoPtr_background;
  private static readonly System.IntPtr NativeFieldInfoPtr_blipFX;
  private static readonly System.IntPtr NativeFieldInfoPtr_bigBlipFX;
  private static readonly System.IntPtr NativeFieldInfoPtr_hitMoveCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_hitRotateCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_sealCard;
  private static readonly System.IntPtr NativeFieldInfoPtr_possessFlashColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_luminFlashColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_continueKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_throwKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_shadeSpawnSfxEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_shadeFleeSfxEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_shadeMoveSfxEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_shadeFlashSfxEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_cameraInSfxEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_cameraOutHeroSfxEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_cameraOutVaseSfxEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_shakeHeroSfxEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_shakeVaseSfxEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_vaseSpawnSfxEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_hitHeroSfxEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_hitVaseSfxEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_pingHeroSfxEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_pingVaseSfxEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_darkLoop;
  private static readonly System.IntPtr NativeFieldInfoPtr_brightLoop;
  private static readonly System.IntPtr NativeFieldInfoPtr_shadeLoop;
  private static readonly System.IntPtr NativeFieldInfoPtr_wisp;
  private static readonly System.IntPtr NativeFieldInfoPtr_running;
  private static readonly System.IntPtr NativeFieldInfoPtr_blockWisp;
  private static readonly System.IntPtr NativeFieldInfoPtr_leader;
  private static readonly System.IntPtr NativeFieldInfoPtr_blockCard;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerNode;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PreBattleEnd_Private_Task_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PossessLeader_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBlockCard_Private_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BlockWisp_Private_IEnumerator_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Flee_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ZoomInOn_Private_Static_Void_GameObject_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Ping_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReturnLeader_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__PossessLeader_b__39_0_Private_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__GetBlockCard_b__40_0_Private_Boolean_CardData_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59723, XrefRangeEnd = 59747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59747, XrefRangeEnd = 59762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59762, XrefRangeEnd = 59828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityKilled(Entity entity, DeathType type)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59828, XrefRangeEnd = 59838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task PreBattleEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem.NativeMethodInfoPtr_PreBattleEnd_Private_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Task) null : new Task(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59838, XrefRangeEnd = 59843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator PossessLeader()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem.NativeMethodInfoPtr_PossessLeader_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59843, XrefRangeEnd = 59855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardData GetBlockCard()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem.NativeMethodInfoPtr_GetBlockCard_Private_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59855, XrefRangeEnd = 59861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator BlockWisp(CardData blockCardData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blockCardData)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem.NativeMethodInfoPtr_BlockWisp_Private_IEnumerator_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59861, XrefRangeEnd = 59866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Flee()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem.NativeMethodInfoPtr_Flee_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59866, XrefRangeEnd = 59880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ZoomInOn(GameObject target, float zPos = -2f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &zPos;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem.NativeMethodInfoPtr_ZoomInOn_Private_Static_Void_GameObject_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59880, XrefRangeEnd = 59891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Ping(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem.NativeMethodInfoPtr_Ping_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 59899, RefRangeEnd = 59901, XrefRangeStart = 59891, XrefRangeEnd = 59899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ReturnLeader()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem.NativeMethodInfoPtr_ReturnLeader_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59901, XrefRangeEnd = 59906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FinalBossSequenceSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59906, XrefRangeEnd = 59907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _PossessLeader_b__39_0(float a)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &a
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem.NativeMethodInfoPtr__PossessLeader_b__39_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59907, XrefRangeEnd = 59910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool _GetBlockCard_b__40_0(CardData a)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem.NativeMethodInfoPtr__GetBlockCard_b__40_0_Private_Boolean_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  static FinalBossSequenceSystem()
  {
    Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (FinalBossSequenceSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr);
    FinalBossSequenceSystem.NativeFieldInfoPtr_wispPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (wispPrefab));
    FinalBossSequenceSystem.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (canvas));
    FinalBossSequenceSystem.NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (background));
    FinalBossSequenceSystem.NativeFieldInfoPtr_blipFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (blipFX));
    FinalBossSequenceSystem.NativeFieldInfoPtr_bigBlipFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (bigBlipFX));
    FinalBossSequenceSystem.NativeFieldInfoPtr_hitMoveCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (hitMoveCurve));
    FinalBossSequenceSystem.NativeFieldInfoPtr_hitRotateCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (hitRotateCurve));
    FinalBossSequenceSystem.NativeFieldInfoPtr_sealCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (sealCard));
    FinalBossSequenceSystem.NativeFieldInfoPtr_possessFlashColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (possessFlashColor));
    FinalBossSequenceSystem.NativeFieldInfoPtr_luminFlashColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (luminFlashColor));
    FinalBossSequenceSystem.NativeFieldInfoPtr_continueKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (continueKey));
    FinalBossSequenceSystem.NativeFieldInfoPtr_throwKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (throwKey));
    FinalBossSequenceSystem.NativeFieldInfoPtr_shadeSpawnSfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (shadeSpawnSfxEvent));
    FinalBossSequenceSystem.NativeFieldInfoPtr_shadeFleeSfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (shadeFleeSfxEvent));
    FinalBossSequenceSystem.NativeFieldInfoPtr_shadeMoveSfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (shadeMoveSfxEvent));
    FinalBossSequenceSystem.NativeFieldInfoPtr_shadeFlashSfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (shadeFlashSfxEvent));
    FinalBossSequenceSystem.NativeFieldInfoPtr_cameraInSfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (cameraInSfxEvent));
    FinalBossSequenceSystem.NativeFieldInfoPtr_cameraOutHeroSfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (cameraOutHeroSfxEvent));
    FinalBossSequenceSystem.NativeFieldInfoPtr_cameraOutVaseSfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (cameraOutVaseSfxEvent));
    FinalBossSequenceSystem.NativeFieldInfoPtr_shakeHeroSfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (shakeHeroSfxEvent));
    FinalBossSequenceSystem.NativeFieldInfoPtr_shakeVaseSfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (shakeVaseSfxEvent));
    FinalBossSequenceSystem.NativeFieldInfoPtr_vaseSpawnSfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (vaseSpawnSfxEvent));
    FinalBossSequenceSystem.NativeFieldInfoPtr_hitHeroSfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (hitHeroSfxEvent));
    FinalBossSequenceSystem.NativeFieldInfoPtr_hitVaseSfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (hitVaseSfxEvent));
    FinalBossSequenceSystem.NativeFieldInfoPtr_pingHeroSfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (pingHeroSfxEvent));
    FinalBossSequenceSystem.NativeFieldInfoPtr_pingVaseSfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (pingVaseSfxEvent));
    FinalBossSequenceSystem.NativeFieldInfoPtr_darkLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (darkLoop));
    FinalBossSequenceSystem.NativeFieldInfoPtr_brightLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (brightLoop));
    FinalBossSequenceSystem.NativeFieldInfoPtr_shadeLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (shadeLoop));
    FinalBossSequenceSystem.NativeFieldInfoPtr_wisp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (wisp));
    FinalBossSequenceSystem.NativeFieldInfoPtr_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (running));
    FinalBossSequenceSystem.NativeFieldInfoPtr_blockWisp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (blockWisp));
    FinalBossSequenceSystem.NativeFieldInfoPtr_leader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (leader));
    FinalBossSequenceSystem.NativeFieldInfoPtr_blockCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (blockCard));
    FinalBossSequenceSystem.NativeFieldInfoPtr_playerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, nameof (playerNode));
    FinalBossSequenceSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, 100668161);
    FinalBossSequenceSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, 100668162);
    FinalBossSequenceSystem.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, 100668163);
    FinalBossSequenceSystem.NativeMethodInfoPtr_PreBattleEnd_Private_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, 100668164);
    FinalBossSequenceSystem.NativeMethodInfoPtr_PossessLeader_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, 100668165);
    FinalBossSequenceSystem.NativeMethodInfoPtr_GetBlockCard_Private_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, 100668166);
    FinalBossSequenceSystem.NativeMethodInfoPtr_BlockWisp_Private_IEnumerator_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, 100668167);
    FinalBossSequenceSystem.NativeMethodInfoPtr_Flee_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, 100668168);
    FinalBossSequenceSystem.NativeMethodInfoPtr_ZoomInOn_Private_Static_Void_GameObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, 100668169);
    FinalBossSequenceSystem.NativeMethodInfoPtr_Ping_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, 100668170);
    FinalBossSequenceSystem.NativeMethodInfoPtr_ReturnLeader_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, 100668171);
    FinalBossSequenceSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, 100668172);
    FinalBossSequenceSystem.NativeMethodInfoPtr__PossessLeader_b__39_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, 100668173);
    FinalBossSequenceSystem.NativeMethodInfoPtr__GetBlockCard_b__40_0_Private_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, 100668174);
  }

  public FinalBossSequenceSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe WispAnimator wispPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_wispPrefab));
      return pointer == System.IntPtr.Zero ? (WispAnimator) null : new WispAnimator(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_wispPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Canvas canvas
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_canvas));
      return pointer == System.IntPtr.Zero ? (Canvas) null : new Canvas(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image background
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_background));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_background), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem blipFX
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_blipFX));
      return pointer == System.IntPtr.Zero ? (ParticleSystem) null : new ParticleSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_blipFX), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem bigBlipFX
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_bigBlipFX));
      return pointer == System.IntPtr.Zero ? (ParticleSystem) null : new ParticleSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_bigBlipFX), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve hitMoveCurve
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_hitMoveCurve));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_hitMoveCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve hitRotateCurve
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_hitRotateCurve));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_hitRotateCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string sealCard
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_sealCard)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_sealCard), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Color possessFlashColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_possessFlashColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_possessFlashColor)) = value;
    }
  }

  public unsafe Color luminFlashColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_luminFlashColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_luminFlashColor)) = value;
    }
  }

  public unsafe LocalizedString continueKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_continueKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_continueKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString throwKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_throwKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_throwKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference shadeSpawnSfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_shadeSpawnSfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_shadeSpawnSfxEvent)) = value;
    }
  }

  public unsafe EventReference shadeFleeSfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_shadeFleeSfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_shadeFleeSfxEvent)) = value;
    }
  }

  public unsafe EventReference shadeMoveSfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_shadeMoveSfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_shadeMoveSfxEvent)) = value;
    }
  }

  public unsafe EventReference shadeFlashSfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_shadeFlashSfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_shadeFlashSfxEvent)) = value;
    }
  }

  public unsafe EventReference cameraInSfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_cameraInSfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_cameraInSfxEvent)) = value;
    }
  }

  public unsafe EventReference cameraOutHeroSfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_cameraOutHeroSfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_cameraOutHeroSfxEvent)) = value;
    }
  }

  public unsafe EventReference cameraOutVaseSfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_cameraOutVaseSfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_cameraOutVaseSfxEvent)) = value;
    }
  }

  public unsafe EventReference shakeHeroSfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_shakeHeroSfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_shakeHeroSfxEvent)) = value;
    }
  }

  public unsafe EventReference shakeVaseSfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_shakeVaseSfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_shakeVaseSfxEvent)) = value;
    }
  }

  public unsafe EventReference vaseSpawnSfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_vaseSpawnSfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_vaseSpawnSfxEvent)) = value;
    }
  }

  public unsafe EventReference hitHeroSfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_hitHeroSfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_hitHeroSfxEvent)) = value;
    }
  }

  public unsafe EventReference hitVaseSfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_hitVaseSfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_hitVaseSfxEvent)) = value;
    }
  }

  public unsafe EventReference pingHeroSfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_pingHeroSfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_pingHeroSfxEvent)) = value;
    }
  }

  public unsafe EventReference pingVaseSfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_pingVaseSfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_pingVaseSfxEvent)) = value;
    }
  }

  public unsafe SfxLoop darkLoop
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_darkLoop));
      return pointer == System.IntPtr.Zero ? (SfxLoop) null : new SfxLoop(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_darkLoop), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SfxLoop brightLoop
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_brightLoop));
      return pointer == System.IntPtr.Zero ? (SfxLoop) null : new SfxLoop(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_brightLoop), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SfxLoop shadeLoop
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_shadeLoop));
      return pointer == System.IntPtr.Zero ? (SfxLoop) null : new SfxLoop(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_shadeLoop), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe WispAnimator wisp
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_wisp));
      return pointer == System.IntPtr.Zero ? (WispAnimator) null : new WispAnimator(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_wisp), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool running
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_running));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_running)) = value;
    }
  }

  public unsafe bool blockWisp
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_blockWisp));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_blockWisp)) = value;
    }
  }

  public unsafe Entity leader
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_leader));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_leader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Entity blockCard
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_blockCard));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_blockCard), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CampaignNode playerNode
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_playerNode));
      return pointer == System.IntPtr.Zero ? (CampaignNode) null : new CampaignNode(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.NativeFieldInfoPtr_playerNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("FinalBossSequenceSystem/<>c__DisplayClass37_0")]
  public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_entity;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__EntityKilled_b__0_Internal_Boolean_Entity_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass37_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalBossSequenceSystem.__c__DisplayClass37_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59319, XrefRangeEnd = 59324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _EntityKilled_b__0(Entity a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__EntityKilled_b__0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass37_0()
    {
      Il2CppClassPointerStore<FinalBossSequenceSystem.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, "<>c__DisplayClass37_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBossSequenceSystem.__c__DisplayClass37_0>.NativeClassPtr);
      FinalBossSequenceSystem.__c__DisplayClass37_0.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem.__c__DisplayClass37_0>.NativeClassPtr, nameof (entity));
      FinalBossSequenceSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem.__c__DisplayClass37_0>.NativeClassPtr, 100668175);
      FinalBossSequenceSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__EntityKilled_b__0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem.__c__DisplayClass37_0>.NativeClassPtr, 100668176);
    }

    public __c__DisplayClass37_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Entity entity
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.__c__DisplayClass37_0.NativeFieldInfoPtr_entity));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem.__c__DisplayClass37_0.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("FinalBossSequenceSystem/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__37_1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__EntityKilled_b__37_1_Internal_Boolean_Entity_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalBossSequenceSystem.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _EntityKilled_b__37_1(Entity a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem.__c.NativeMethodInfoPtr__EntityKilled_b__37_1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<FinalBossSequenceSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBossSequenceSystem.__c>.NativeClassPtr);
      FinalBossSequenceSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem.__c>.NativeClassPtr, "<>9");
      FinalBossSequenceSystem.__c.NativeFieldInfoPtr___9__37_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem.__c>.NativeClassPtr, "<>9__37_1");
      FinalBossSequenceSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem.__c>.NativeClassPtr, 100668178);
      FinalBossSequenceSystem.__c.NativeMethodInfoPtr__EntityKilled_b__37_1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem.__c>.NativeClassPtr, 100668179);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe FinalBossSequenceSystem.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(FinalBossSequenceSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (FinalBossSequenceSystem.__c) null : new FinalBossSequenceSystem.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FinalBossSequenceSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Entity, bool> __9__37_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(FinalBossSequenceSystem.__c.NativeFieldInfoPtr___9__37_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity, bool>) null : new Il2CppSystem.Func<Entity, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FinalBossSequenceSystem.__c.NativeFieldInfoPtr___9__37_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("FinalBossSequenceSystem/<PreBattleEnd>d__38")]
  public sealed class _PreBattleEnd_d__38 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59324, XrefRangeEnd = 59359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem._PreBattleEnd_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem._PreBattleEnd_d__38.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static _PreBattleEnd_d__38()
    {
      Il2CppClassPointerStore<FinalBossSequenceSystem._PreBattleEnd_d__38>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, "<PreBattleEnd>d__38");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBossSequenceSystem._PreBattleEnd_d__38>.NativeClassPtr);
      FinalBossSequenceSystem._PreBattleEnd_d__38.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem._PreBattleEnd_d__38>.NativeClassPtr, "<>1__state");
      FinalBossSequenceSystem._PreBattleEnd_d__38.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem._PreBattleEnd_d__38>.NativeClassPtr, "<>t__builder");
      FinalBossSequenceSystem._PreBattleEnd_d__38.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem._PreBattleEnd_d__38>.NativeClassPtr, "<>4__this");
      FinalBossSequenceSystem._PreBattleEnd_d__38.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem._PreBattleEnd_d__38>.NativeClassPtr, "<>u__1");
      FinalBossSequenceSystem._PreBattleEnd_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem._PreBattleEnd_d__38>.NativeClassPtr, 100668180);
      FinalBossSequenceSystem._PreBattleEnd_d__38.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem._PreBattleEnd_d__38>.NativeClassPtr, 100668181);
    }

    public _PreBattleEnd_d__38(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _PreBattleEnd_d__38()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FinalBossSequenceSystem._PreBattleEnd_d__38>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FinalBossSequenceSystem._PreBattleEnd_d__38>.NativeClassPtr, data));
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._PreBattleEnd_d__38.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._PreBattleEnd_d__38.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._PreBattleEnd_d__38.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._PreBattleEnd_d__38.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe FinalBossSequenceSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._PreBattleEnd_d__38.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (FinalBossSequenceSystem) null : new FinalBossSequenceSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._PreBattleEnd_d__38.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public TaskAwaiter __u__1
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._PreBattleEnd_d__38.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._PreBattleEnd_d__38.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("FinalBossSequenceSystem/<PossessLeader>d__39")]
  public sealed class _PossessLeader_d__39 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__blockCardData_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__hitCard_5__3;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _PossessLeader_d__39(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalBossSequenceSystem._PossessLeader_d__39>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem._PossessLeader_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem._PossessLeader_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59359, XrefRangeEnd = 59602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem._PossessLeader_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem._PossessLeader_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59602, XrefRangeEnd = 59608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem._PossessLeader_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem._PossessLeader_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _PossessLeader_d__39()
    {
      Il2CppClassPointerStore<FinalBossSequenceSystem._PossessLeader_d__39>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, "<PossessLeader>d__39");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBossSequenceSystem._PossessLeader_d__39>.NativeClassPtr);
      FinalBossSequenceSystem._PossessLeader_d__39.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem._PossessLeader_d__39>.NativeClassPtr, "<>1__state");
      FinalBossSequenceSystem._PossessLeader_d__39.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem._PossessLeader_d__39>.NativeClassPtr, "<>2__current");
      FinalBossSequenceSystem._PossessLeader_d__39.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem._PossessLeader_d__39>.NativeClassPtr, "<>4__this");
      FinalBossSequenceSystem._PossessLeader_d__39.NativeFieldInfoPtr__blockCardData_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem._PossessLeader_d__39>.NativeClassPtr, "<blockCardData>5__2");
      FinalBossSequenceSystem._PossessLeader_d__39.NativeFieldInfoPtr__hitCard_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem._PossessLeader_d__39>.NativeClassPtr, "<hitCard>5__3");
      FinalBossSequenceSystem._PossessLeader_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem._PossessLeader_d__39>.NativeClassPtr, 100668182);
      FinalBossSequenceSystem._PossessLeader_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem._PossessLeader_d__39>.NativeClassPtr, 100668183);
      FinalBossSequenceSystem._PossessLeader_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem._PossessLeader_d__39>.NativeClassPtr, 100668184);
      FinalBossSequenceSystem._PossessLeader_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem._PossessLeader_d__39>.NativeClassPtr, 100668185);
      FinalBossSequenceSystem._PossessLeader_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem._PossessLeader_d__39>.NativeClassPtr, 100668186);
      FinalBossSequenceSystem._PossessLeader_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem._PossessLeader_d__39>.NativeClassPtr, 100668187);
    }

    public _PossessLeader_d__39(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._PossessLeader_d__39.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._PossessLeader_d__39.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._PossessLeader_d__39.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._PossessLeader_d__39.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FinalBossSequenceSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._PossessLeader_d__39.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (FinalBossSequenceSystem) null : new FinalBossSequenceSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._PossessLeader_d__39.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CardData _blockCardData_5__2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._PossessLeader_d__39.NativeFieldInfoPtr__blockCardData_5__2));
        return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._PossessLeader_d__39.NativeFieldInfoPtr__blockCardData_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _hitCard_5__3
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._PossessLeader_d__39.NativeFieldInfoPtr__hitCard_5__3));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._PossessLeader_d__39.NativeFieldInfoPtr__hitCard_5__3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("FinalBossSequenceSystem/<BlockWisp>d__41")]
  public sealed class _BlockWisp_d__41 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_blockCardData;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _BlockWisp_d__41(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalBossSequenceSystem._BlockWisp_d__41>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem._BlockWisp_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem._BlockWisp_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59608, XrefRangeEnd = 59696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem._BlockWisp_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem._BlockWisp_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59696, XrefRangeEnd = 59702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem._BlockWisp_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem._BlockWisp_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _BlockWisp_d__41()
    {
      Il2CppClassPointerStore<FinalBossSequenceSystem._BlockWisp_d__41>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, "<BlockWisp>d__41");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBossSequenceSystem._BlockWisp_d__41>.NativeClassPtr);
      FinalBossSequenceSystem._BlockWisp_d__41.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem._BlockWisp_d__41>.NativeClassPtr, "<>1__state");
      FinalBossSequenceSystem._BlockWisp_d__41.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem._BlockWisp_d__41>.NativeClassPtr, "<>2__current");
      FinalBossSequenceSystem._BlockWisp_d__41.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem._BlockWisp_d__41>.NativeClassPtr, "<>4__this");
      FinalBossSequenceSystem._BlockWisp_d__41.NativeFieldInfoPtr_blockCardData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem._BlockWisp_d__41>.NativeClassPtr, nameof (blockCardData));
      FinalBossSequenceSystem._BlockWisp_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem._BlockWisp_d__41>.NativeClassPtr, 100668188);
      FinalBossSequenceSystem._BlockWisp_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem._BlockWisp_d__41>.NativeClassPtr, 100668189);
      FinalBossSequenceSystem._BlockWisp_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem._BlockWisp_d__41>.NativeClassPtr, 100668190);
      FinalBossSequenceSystem._BlockWisp_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem._BlockWisp_d__41>.NativeClassPtr, 100668191);
      FinalBossSequenceSystem._BlockWisp_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem._BlockWisp_d__41>.NativeClassPtr, 100668192);
      FinalBossSequenceSystem._BlockWisp_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem._BlockWisp_d__41>.NativeClassPtr, 100668193);
    }

    public _BlockWisp_d__41(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._BlockWisp_d__41.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._BlockWisp_d__41.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._BlockWisp_d__41.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._BlockWisp_d__41.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FinalBossSequenceSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._BlockWisp_d__41.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (FinalBossSequenceSystem) null : new FinalBossSequenceSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._BlockWisp_d__41.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CardData blockCardData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._BlockWisp_d__41.NativeFieldInfoPtr_blockCardData));
        return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._BlockWisp_d__41.NativeFieldInfoPtr_blockCardData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("FinalBossSequenceSystem/<Flee>d__42")]
  public sealed class _Flee_d__42 : Il2CppSystem.Object
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
    public unsafe _Flee_d__42(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalBossSequenceSystem._Flee_d__42>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem._Flee_d__42.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem._Flee_d__42.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59702, XrefRangeEnd = 59717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem._Flee_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem._Flee_d__42.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59717, XrefRangeEnd = 59723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem._Flee_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossSequenceSystem._Flee_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Flee_d__42()
    {
      Il2CppClassPointerStore<FinalBossSequenceSystem._Flee_d__42>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalBossSequenceSystem>.NativeClassPtr, "<Flee>d__42");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBossSequenceSystem._Flee_d__42>.NativeClassPtr);
      FinalBossSequenceSystem._Flee_d__42.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem._Flee_d__42>.NativeClassPtr, "<>1__state");
      FinalBossSequenceSystem._Flee_d__42.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem._Flee_d__42>.NativeClassPtr, "<>2__current");
      FinalBossSequenceSystem._Flee_d__42.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossSequenceSystem._Flee_d__42>.NativeClassPtr, "<>4__this");
      FinalBossSequenceSystem._Flee_d__42.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem._Flee_d__42>.NativeClassPtr, 100668194);
      FinalBossSequenceSystem._Flee_d__42.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem._Flee_d__42>.NativeClassPtr, 100668195);
      FinalBossSequenceSystem._Flee_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem._Flee_d__42>.NativeClassPtr, 100668196);
      FinalBossSequenceSystem._Flee_d__42.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem._Flee_d__42>.NativeClassPtr, 100668197);
      FinalBossSequenceSystem._Flee_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem._Flee_d__42>.NativeClassPtr, 100668198);
      FinalBossSequenceSystem._Flee_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossSequenceSystem._Flee_d__42>.NativeClassPtr, 100668199);
    }

    public _Flee_d__42(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._Flee_d__42.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._Flee_d__42.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._Flee_d__42.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._Flee_d__42.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FinalBossSequenceSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._Flee_d__42.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (FinalBossSequenceSystem) null : new FinalBossSequenceSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossSequenceSystem._Flee_d__42.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
