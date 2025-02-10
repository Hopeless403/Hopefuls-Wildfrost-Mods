// Decompiled with JetBrains decompiler
// Type: RedrawBellSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.SceneManagement;

#nullable disable
public class RedrawBellSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr__rectTransform;
  private static readonly IntPtr NativeFieldInfoPtr_bell;
  private static readonly IntPtr NativeFieldInfoPtr_bellActive;
  private static readonly IntPtr NativeFieldInfoPtr_chargeParticleSystem;
  private static readonly IntPtr NativeFieldInfoPtr_hitParticleSystem;
  private static readonly IntPtr NativeFieldInfoPtr_navigationItem;
  private static readonly IntPtr NativeFieldInfoPtr_counterChange;
  private static readonly IntPtr NativeFieldInfoPtr_counterIcon;
  private static readonly IntPtr NativeFieldInfoPtr_popUpKeyword;
  private static readonly IntPtr NativeFieldInfoPtr_popUpOffset;
  private static readonly IntPtr NativeFieldInfoPtr_textNotCharged;
  private static readonly IntPtr NativeFieldInfoPtr_textCharged;
  private static readonly IntPtr NativeFieldInfoPtr__animator;
  private static readonly IntPtr NativeFieldInfoPtr_owner;
  private static readonly IntPtr NativeFieldInfoPtr_controller;
  private static readonly IntPtr NativeFieldInfoPtr_counter;
  private static readonly IntPtr NativeFieldInfoPtr_reset;
  private static readonly IntPtr NativeFieldInfoPtr_interactable;
  private static readonly IntPtr NativeFieldInfoPtr_poppedUp;
  private static readonly IntPtr NativeFieldInfoPtr_nav;
  private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_animator_Private_get_Animator_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsCharged_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_BecomeInteractable_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Show_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Hide_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0;
  private static readonly IntPtr NativeMethodInfoPtr_BattlePhaseStart_Private_Void_Phase_0;
  private static readonly IntPtr NativeMethodInfoPtr_CounterIncrement_Private_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_Assign_Public_Void_Character_CardController_0;
  private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Counter_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetCounter_Public_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnPop_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_AnimatorTrigger_Public_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_AnimatorSetHover_Public_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_AnimatorSetPress_Public_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_PlayChargeParticleSystem_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe RectTransform rectTransform
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67673, XrefRangeEnd = 67677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
  }

  public unsafe UnityEngine.Animator animator
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67677, XrefRangeEnd = 67681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_get_animator_Private_get_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (UnityEngine.Animator) null : new UnityEngine.Animator(pointer);
    }
  }

  public unsafe bool IsCharged
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 67682, RefRangeEnd = 67683, XrefRangeStart = 67681, XrefRangeEnd = 67682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_get_IsCharged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67683, XrefRangeEnd = 67709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67709, XrefRangeEnd = 67731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 67753, RefRangeEnd = 67757, XrefRangeStart = 67731, XrefRangeEnd = 67753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BecomeInteractable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_BecomeInteractable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67757, XrefRangeEnd = 67772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Show()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_Show_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 67777, RefRangeEnd = 67779, XrefRangeStart = 67772, XrefRangeEnd = 67777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hide()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_Hide_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67779, XrefRangeEnd = 67784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SceneChanged(Scene scene)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &scene
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67784, XrefRangeEnd = 67786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BattlePhaseStart(Battle.Phase phase)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &phase
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_BattlePhaseStart_Private_Void_Phase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67786, XrefRangeEnd = 67802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CounterIncrement(int turnNumber)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &turnNumber
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_CounterIncrement_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67802, XrefRangeEnd = 67808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Assign(Character owner, CardController controller)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) owner);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_Assign_Public_Void_Character_CardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67808, XrefRangeEnd = 67846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Activate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_Activate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67846, XrefRangeEnd = 67860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Counter()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_Counter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 67884, RefRangeEnd = 67892, XrefRangeStart = 67860, XrefRangeEnd = 67884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetCounter(int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_SetCounter_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67892, XrefRangeEnd = 67922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Pop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_Pop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67922, XrefRangeEnd = 67924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnPop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_UnPop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 67930, RefRangeEnd = 67935, XrefRangeStart = 67924, XrefRangeEnd = 67930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AnimatorTrigger(string name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_AnimatorTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67935, XrefRangeEnd = 67943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AnimatorSetHover(bool value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_AnimatorSetHover_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67943, XrefRangeEnd = 67951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AnimatorSetPress(bool value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_AnimatorSetPress_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67951, XrefRangeEnd = 67953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlayChargeParticleSystem()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_PlayChargeParticleSystem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67953, XrefRangeEnd = 67954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RedrawBellSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static RedrawBellSystem()
  {
    Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (RedrawBellSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr);
    RedrawBellSystem.NativeFieldInfoPtr__rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, nameof (_rectTransform));
    RedrawBellSystem.NativeFieldInfoPtr_bell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, nameof (bell));
    RedrawBellSystem.NativeFieldInfoPtr_bellActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, nameof (bellActive));
    RedrawBellSystem.NativeFieldInfoPtr_chargeParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, nameof (chargeParticleSystem));
    RedrawBellSystem.NativeFieldInfoPtr_hitParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, nameof (hitParticleSystem));
    RedrawBellSystem.NativeFieldInfoPtr_navigationItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, nameof (navigationItem));
    RedrawBellSystem.NativeFieldInfoPtr_counterChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, nameof (counterChange));
    RedrawBellSystem.NativeFieldInfoPtr_counterIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, nameof (counterIcon));
    RedrawBellSystem.NativeFieldInfoPtr_popUpKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, nameof (popUpKeyword));
    RedrawBellSystem.NativeFieldInfoPtr_popUpOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, nameof (popUpOffset));
    RedrawBellSystem.NativeFieldInfoPtr_textNotCharged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, nameof (textNotCharged));
    RedrawBellSystem.NativeFieldInfoPtr_textCharged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, nameof (textCharged));
    RedrawBellSystem.NativeFieldInfoPtr__animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, nameof (_animator));
    RedrawBellSystem.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, nameof (owner));
    RedrawBellSystem.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, nameof (controller));
    RedrawBellSystem.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, nameof (counter));
    RedrawBellSystem.NativeFieldInfoPtr_reset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, nameof (reset));
    RedrawBellSystem.NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, nameof (interactable));
    RedrawBellSystem.NativeFieldInfoPtr_poppedUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, nameof (poppedUp));
    RedrawBellSystem.NativeFieldInfoPtr_nav = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, nameof (nav));
    RedrawBellSystem.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100668853);
    RedrawBellSystem.NativeMethodInfoPtr_get_animator_Private_get_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100668854);
    RedrawBellSystem.NativeMethodInfoPtr_get_IsCharged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100668855);
    RedrawBellSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100668856);
    RedrawBellSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100668857);
    RedrawBellSystem.NativeMethodInfoPtr_BecomeInteractable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100668858);
    RedrawBellSystem.NativeMethodInfoPtr_Show_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100668859);
    RedrawBellSystem.NativeMethodInfoPtr_Hide_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100668860);
    RedrawBellSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100668861);
    RedrawBellSystem.NativeMethodInfoPtr_BattlePhaseStart_Private_Void_Phase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100668862);
    RedrawBellSystem.NativeMethodInfoPtr_CounterIncrement_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100668863);
    RedrawBellSystem.NativeMethodInfoPtr_Assign_Public_Void_Character_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100668864);
    RedrawBellSystem.NativeMethodInfoPtr_Activate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100668865);
    RedrawBellSystem.NativeMethodInfoPtr_Counter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100668866);
    RedrawBellSystem.NativeMethodInfoPtr_SetCounter_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100668867);
    RedrawBellSystem.NativeMethodInfoPtr_Pop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100668868);
    RedrawBellSystem.NativeMethodInfoPtr_UnPop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100668869);
    RedrawBellSystem.NativeMethodInfoPtr_AnimatorTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100668870);
    RedrawBellSystem.NativeMethodInfoPtr_AnimatorSetHover_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100668871);
    RedrawBellSystem.NativeMethodInfoPtr_AnimatorSetPress_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100668872);
    RedrawBellSystem.NativeMethodInfoPtr_PlayChargeParticleSystem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100668873);
    RedrawBellSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100668874);
  }

  public RedrawBellSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe RectTransform _rectTransform
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr__rectTransform));
      return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr__rectTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject bell
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_bell));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_bell), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject bellActive
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_bellActive));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_bellActive), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem chargeParticleSystem
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_chargeParticleSystem));
      return pointer == IntPtr.Zero ? (ParticleSystem) null : new ParticleSystem(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_chargeParticleSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem hitParticleSystem
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_hitParticleSystem));
      return pointer == IntPtr.Zero ? (ParticleSystem) null : new ParticleSystem(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_hitParticleSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UINavigationItem navigationItem
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_navigationItem));
      return pointer == IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_navigationItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int counterChange
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_counterChange));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_counterChange)) = value;
    }
  }

  public unsafe StatusIcon counterIcon
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_counterIcon));
      return pointer == IntPtr.Zero ? (StatusIcon) null : new StatusIcon(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_counterIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe KeywordData popUpKeyword
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_popUpKeyword));
      return pointer == IntPtr.Zero ? (KeywordData) null : new KeywordData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_popUpKeyword), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 popUpOffset
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_popUpOffset));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_popUpOffset)) = value;
    }
  }

  public unsafe LocalizedString textNotCharged
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_textNotCharged));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_textNotCharged), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString textCharged
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_textCharged));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_textCharged), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.Animator _animator
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr__animator));
      return pointer == IntPtr.Zero ? (UnityEngine.Animator) null : new UnityEngine.Animator(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr__animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Character owner
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_owner));
      return pointer == IntPtr.Zero ? (Character) null : new Character(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardController controller
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_controller));
      return pointer == IntPtr.Zero ? (CardController) null : new CardController(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Stat counter
  {
    get
    {
      return *(Stat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_counter));
    }
    [param: In] set
    {
      *(Stat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_counter)) = value;
    }
  }

  public unsafe bool reset
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_reset));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_reset)) = value;
    }
  }

  public unsafe bool interactable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_interactable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_interactable)) = value;
    }
  }

  public unsafe bool poppedUp
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_poppedUp));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_poppedUp)) = value;
    }
  }

  public static unsafe UINavigationItem nav
  {
    get
    {
      IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(RedrawBellSystem.NativeFieldInfoPtr_nav, (void*) &num);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RedrawBellSystem.NativeFieldInfoPtr_nav, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
