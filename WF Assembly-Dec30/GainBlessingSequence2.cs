// Decompiled with JetBrains decompiler
// Type: GainBlessingSequence2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class GainBlessingSequence2 : UISequence
{
  private static readonly System.IntPtr NativeFieldInfoPtr_rewardGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_titleKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_chooseKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_selectSfxEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_animator;
  private static readonly System.IntPtr NativeFieldInfoPtr_buildUpPS;
  private static readonly System.IntPtr NativeFieldInfoPtr_explodePS;
  private static readonly System.IntPtr NativeFieldInfoPtr_handleSpinner;
  private static readonly System.IntPtr NativeFieldInfoPtr_openTrigger;
  private static readonly System.IntPtr NativeFieldInfoPtr_closedEye;
  private static readonly System.IntPtr NativeFieldInfoPtr_openEye;
  private static readonly System.IntPtr NativeFieldInfoPtr_selectPrefabs;
  private static readonly System.IntPtr NativeFieldInfoPtr_spacing;
  private static readonly System.IntPtr NativeFieldInfoPtr_randX;
  private static readonly System.IntPtr NativeFieldInfoPtr_randY;
  private static readonly System.IntPtr NativeFieldInfoPtr_appearSfxEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_openSfxEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_rewardData;
  private static readonly System.IntPtr NativeFieldInfoPtr_canOpen;
  private static readonly System.IntPtr NativeFieldInfoPtr_open;
  private static readonly System.IntPtr NativeFieldInfoPtr_taken;
  private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartOpen_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OpenRoutine_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCinemaBarPrompt_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateRewards_Private_Void_List_1_Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateReward_Private_Void_Data_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Select_Public_Void_Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98615, XrefRangeEnd = 98620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator Run()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GainBlessingSequence2.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98620, XrefRangeEnd = 98627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartOpen()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GainBlessingSequence2.NativeMethodInfoPtr_StartOpen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98627, XrefRangeEnd = 98632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator OpenRoutine()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GainBlessingSequence2.NativeMethodInfoPtr_OpenRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 98649, RefRangeEnd = 98651, XrefRangeStart = 98632, XrefRangeEnd = 98649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateCinemaBarPrompt()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GainBlessingSequence2.NativeMethodInfoPtr_UpdateCinemaBarPrompt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98651, XrefRangeEnd = 98678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateRewards(List<BossRewardData.Data> rewardsToCreate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rewardsToCreate)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GainBlessingSequence2.NativeMethodInfoPtr_CreateRewards_Private_Void_List_1_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 98711, RefRangeEnd = 98712, XrefRangeStart = 98678, XrefRangeEnd = 98711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateReward(
    BossRewardData.Data reward,
    float startX,
    float startY,
    float ySign)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) reward);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &startY;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &ySign;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GainBlessingSequence2.NativeMethodInfoPtr_CreateReward_Private_Void_Data_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 98718, RefRangeEnd = 98719, XrefRangeStart = 98712, XrefRangeEnd = 98718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Select(BossRewardData.Data reward)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) reward)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GainBlessingSequence2.NativeMethodInfoPtr_Select_Public_Void_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98719, XrefRangeEnd = 98720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GainBlessingSequence2()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GainBlessingSequence2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static GainBlessingSequence2()
  {
    Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (GainBlessingSequence2));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr);
    GainBlessingSequence2.NativeFieldInfoPtr_rewardGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, nameof (rewardGroup));
    GainBlessingSequence2.NativeFieldInfoPtr_titleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, nameof (titleKey));
    GainBlessingSequence2.NativeFieldInfoPtr_chooseKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, nameof (chooseKey));
    GainBlessingSequence2.NativeFieldInfoPtr_selectSfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, nameof (selectSfxEvent));
    GainBlessingSequence2.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, nameof (animator));
    GainBlessingSequence2.NativeFieldInfoPtr_buildUpPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, nameof (buildUpPS));
    GainBlessingSequence2.NativeFieldInfoPtr_explodePS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, nameof (explodePS));
    GainBlessingSequence2.NativeFieldInfoPtr_handleSpinner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, nameof (handleSpinner));
    GainBlessingSequence2.NativeFieldInfoPtr_openTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, nameof (openTrigger));
    GainBlessingSequence2.NativeFieldInfoPtr_closedEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, nameof (closedEye));
    GainBlessingSequence2.NativeFieldInfoPtr_openEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, nameof (openEye));
    GainBlessingSequence2.NativeFieldInfoPtr_selectPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, nameof (selectPrefabs));
    GainBlessingSequence2.NativeFieldInfoPtr_spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, nameof (spacing));
    GainBlessingSequence2.NativeFieldInfoPtr_randX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, nameof (randX));
    GainBlessingSequence2.NativeFieldInfoPtr_randY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, nameof (randY));
    GainBlessingSequence2.NativeFieldInfoPtr_appearSfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, nameof (appearSfxEvent));
    GainBlessingSequence2.NativeFieldInfoPtr_openSfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, nameof (openSfxEvent));
    GainBlessingSequence2.NativeFieldInfoPtr_rewardData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, nameof (rewardData));
    GainBlessingSequence2.NativeFieldInfoPtr_canOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, nameof (canOpen));
    GainBlessingSequence2.NativeFieldInfoPtr_open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, nameof (open));
    GainBlessingSequence2.NativeFieldInfoPtr_taken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, nameof (taken));
    GainBlessingSequence2.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, 100672000);
    GainBlessingSequence2.NativeMethodInfoPtr_StartOpen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, 100672001);
    GainBlessingSequence2.NativeMethodInfoPtr_OpenRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, 100672002);
    GainBlessingSequence2.NativeMethodInfoPtr_UpdateCinemaBarPrompt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, 100672003);
    GainBlessingSequence2.NativeMethodInfoPtr_CreateRewards_Private_Void_List_1_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, 100672004);
    GainBlessingSequence2.NativeMethodInfoPtr_CreateReward_Private_Void_Data_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, 100672005);
    GainBlessingSequence2.NativeMethodInfoPtr_Select_Public_Void_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, 100672006);
    GainBlessingSequence2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, 100672007);
  }

  public GainBlessingSequence2(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Transform rewardGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_rewardGroup));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_rewardGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString titleKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_titleKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_titleKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString chooseKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_chooseKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_chooseKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference selectSfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_selectSfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_selectSfxEvent)) = value;
    }
  }

  public unsafe UnityEngine.Animator animator
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_animator));
      return pointer == System.IntPtr.Zero ? (UnityEngine.Animator) null : new UnityEngine.Animator(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem buildUpPS
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_buildUpPS));
      return pointer == System.IntPtr.Zero ? (ParticleSystem) null : new ParticleSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_buildUpPS), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem explodePS
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_explodePS));
      return pointer == System.IntPtr.Zero ? (ParticleSystem) null : new ParticleSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_explodePS), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe HandleSpinner handleSpinner
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_handleSpinner));
      return pointer == System.IntPtr.Zero ? (HandleSpinner) null : new HandleSpinner(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_handleSpinner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject openTrigger
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_openTrigger));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_openTrigger), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject closedEye
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_closedEye));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_closedEye), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject openEye
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_openEye));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_openEye), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<GainBlessingSequence2.SelectPrefab> selectPrefabs
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_selectPrefabs));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<GainBlessingSequence2.SelectPrefab>) null : new Il2CppReferenceArray<GainBlessingSequence2.SelectPrefab>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_selectPrefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float spacing
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_spacing));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_spacing)) = value;
    }
  }

  public unsafe float randX
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_randX));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_randX)) = value;
    }
  }

  public unsafe float randY
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_randY));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_randY)) = value;
    }
  }

  public unsafe EventReference appearSfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_appearSfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_appearSfxEvent)) = value;
    }
  }

  public unsafe EventReference openSfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_openSfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_openSfxEvent)) = value;
    }
  }

  public unsafe CampaignNodeTypeBoss.RewardData rewardData
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_rewardData));
      return pointer == System.IntPtr.Zero ? (CampaignNodeTypeBoss.RewardData) null : new CampaignNodeTypeBoss.RewardData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_rewardData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool canOpen
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_canOpen));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_canOpen)) = value;
    }
  }

  public unsafe bool open
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_open));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_open)) = value;
    }
  }

  public unsafe int taken
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_taken));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.NativeFieldInfoPtr_taken)) = value;
    }
  }

  [Serializable]
  public sealed class SelectPrefab : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_bossRewardType;
    private static readonly System.IntPtr NativeFieldInfoPtr_prefab;

    static SelectPrefab()
    {
      Il2CppClassPointerStore<GainBlessingSequence2.SelectPrefab>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, nameof (SelectPrefab));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainBlessingSequence2.SelectPrefab>.NativeClassPtr);
      GainBlessingSequence2.SelectPrefab.NativeFieldInfoPtr_bossRewardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2.SelectPrefab>.NativeClassPtr, nameof (bossRewardType));
      GainBlessingSequence2.SelectPrefab.NativeFieldInfoPtr_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2.SelectPrefab>.NativeClassPtr, nameof (prefab));
    }

    public SelectPrefab(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public SelectPrefab()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GainBlessingSequence2.SelectPrefab>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GainBlessingSequence2.SelectPrefab>.NativeClassPtr, data));
    }

    public unsafe BossRewardData.Type bossRewardType
    {
      get
      {
        return *(BossRewardData.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.SelectPrefab.NativeFieldInfoPtr_bossRewardType));
      }
      [param: In] set
      {
        *(BossRewardData.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.SelectPrefab.NativeFieldInfoPtr_bossRewardType)) = value;
      }
    }

    public unsafe BossRewardSelect prefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.SelectPrefab.NativeFieldInfoPtr_prefab));
        return pointer == System.IntPtr.Zero ? (BossRewardSelect) null : new BossRewardSelect(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.SelectPrefab.NativeFieldInfoPtr_prefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("GainBlessingSequence2/<Run>d__21")]
  public sealed class _Run_d__21 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__rewardsToCreate_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Run_d__21(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainBlessingSequence2._Run_d__21>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GainBlessingSequence2._Run_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GainBlessingSequence2._Run_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98572, XrefRangeEnd = 98592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GainBlessingSequence2._Run_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GainBlessingSequence2._Run_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98592, XrefRangeEnd = 98598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GainBlessingSequence2._Run_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GainBlessingSequence2._Run_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Run_d__21()
    {
      Il2CppClassPointerStore<GainBlessingSequence2._Run_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, "<Run>d__21");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainBlessingSequence2._Run_d__21>.NativeClassPtr);
      GainBlessingSequence2._Run_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2._Run_d__21>.NativeClassPtr, "<>1__state");
      GainBlessingSequence2._Run_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2._Run_d__21>.NativeClassPtr, "<>2__current");
      GainBlessingSequence2._Run_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2._Run_d__21>.NativeClassPtr, "<>4__this");
      GainBlessingSequence2._Run_d__21.NativeFieldInfoPtr__rewardsToCreate_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2._Run_d__21>.NativeClassPtr, "<rewardsToCreate>5__2");
      GainBlessingSequence2._Run_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainBlessingSequence2._Run_d__21>.NativeClassPtr, 100672008);
      GainBlessingSequence2._Run_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainBlessingSequence2._Run_d__21>.NativeClassPtr, 100672009);
      GainBlessingSequence2._Run_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainBlessingSequence2._Run_d__21>.NativeClassPtr, 100672010);
      GainBlessingSequence2._Run_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainBlessingSequence2._Run_d__21>.NativeClassPtr, 100672011);
      GainBlessingSequence2._Run_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainBlessingSequence2._Run_d__21>.NativeClassPtr, 100672012);
      GainBlessingSequence2._Run_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainBlessingSequence2._Run_d__21>.NativeClassPtr, 100672013);
    }

    public _Run_d__21(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2._Run_d__21.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2._Run_d__21.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2._Run_d__21.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2._Run_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GainBlessingSequence2 __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2._Run_d__21.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (GainBlessingSequence2) null : new GainBlessingSequence2(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2._Run_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<BossRewardData.Data> _rewardsToCreate_5__2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2._Run_d__21.NativeFieldInfoPtr__rewardsToCreate_5__2));
        return pointer == System.IntPtr.Zero ? (List<BossRewardData.Data>) null : new List<BossRewardData.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2._Run_d__21.NativeFieldInfoPtr__rewardsToCreate_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("GainBlessingSequence2/<OpenRoutine>d__23")]
  public sealed class _OpenRoutine_d__23 : Il2CppSystem.Object
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
    public unsafe _OpenRoutine_d__23(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainBlessingSequence2._OpenRoutine_d__23>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GainBlessingSequence2._OpenRoutine_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GainBlessingSequence2._OpenRoutine_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98598, XrefRangeEnd = 98609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GainBlessingSequence2._OpenRoutine_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GainBlessingSequence2._OpenRoutine_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98609, XrefRangeEnd = 98615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GainBlessingSequence2._OpenRoutine_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GainBlessingSequence2._OpenRoutine_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _OpenRoutine_d__23()
    {
      Il2CppClassPointerStore<GainBlessingSequence2._OpenRoutine_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, "<OpenRoutine>d__23");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainBlessingSequence2._OpenRoutine_d__23>.NativeClassPtr);
      GainBlessingSequence2._OpenRoutine_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2._OpenRoutine_d__23>.NativeClassPtr, "<>1__state");
      GainBlessingSequence2._OpenRoutine_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2._OpenRoutine_d__23>.NativeClassPtr, "<>2__current");
      GainBlessingSequence2._OpenRoutine_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2._OpenRoutine_d__23>.NativeClassPtr, "<>4__this");
      GainBlessingSequence2._OpenRoutine_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainBlessingSequence2._OpenRoutine_d__23>.NativeClassPtr, 100672014);
      GainBlessingSequence2._OpenRoutine_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainBlessingSequence2._OpenRoutine_d__23>.NativeClassPtr, 100672015);
      GainBlessingSequence2._OpenRoutine_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainBlessingSequence2._OpenRoutine_d__23>.NativeClassPtr, 100672016);
      GainBlessingSequence2._OpenRoutine_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainBlessingSequence2._OpenRoutine_d__23>.NativeClassPtr, 100672017);
      GainBlessingSequence2._OpenRoutine_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainBlessingSequence2._OpenRoutine_d__23>.NativeClassPtr, 100672018);
      GainBlessingSequence2._OpenRoutine_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainBlessingSequence2._OpenRoutine_d__23>.NativeClassPtr, 100672019);
    }

    public _OpenRoutine_d__23(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2._OpenRoutine_d__23.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2._OpenRoutine_d__23.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2._OpenRoutine_d__23.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2._OpenRoutine_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GainBlessingSequence2 __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2._OpenRoutine_d__23.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (GainBlessingSequence2) null : new GainBlessingSequence2(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2._OpenRoutine_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("GainBlessingSequence2/<>c__DisplayClass26_0")]
  public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_reward;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CreateReward_b__0_Internal_Boolean_SelectPrefab_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass26_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainBlessingSequence2.__c__DisplayClass26_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GainBlessingSequence2.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _CreateReward_b__0(GainBlessingSequence2.SelectPrefab a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a))
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GainBlessingSequence2.__c__DisplayClass26_0.NativeMethodInfoPtr__CreateReward_b__0_Internal_Boolean_SelectPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass26_0()
    {
      Il2CppClassPointerStore<GainBlessingSequence2.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainBlessingSequence2>.NativeClassPtr, "<>c__DisplayClass26_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainBlessingSequence2.__c__DisplayClass26_0>.NativeClassPtr);
      GainBlessingSequence2.__c__DisplayClass26_0.NativeFieldInfoPtr_reward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainBlessingSequence2.__c__DisplayClass26_0>.NativeClassPtr, nameof (reward));
      GainBlessingSequence2.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainBlessingSequence2.__c__DisplayClass26_0>.NativeClassPtr, 100672020);
      GainBlessingSequence2.__c__DisplayClass26_0.NativeMethodInfoPtr__CreateReward_b__0_Internal_Boolean_SelectPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainBlessingSequence2.__c__DisplayClass26_0>.NativeClassPtr, 100672021);
    }

    public __c__DisplayClass26_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BossRewardData.Data reward
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.__c__DisplayClass26_0.NativeFieldInfoPtr_reward));
        return pointer == System.IntPtr.Zero ? (BossRewardData.Data) null : new BossRewardData.Data(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainBlessingSequence2.__c__DisplayClass26_0.NativeFieldInfoPtr_reward), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
