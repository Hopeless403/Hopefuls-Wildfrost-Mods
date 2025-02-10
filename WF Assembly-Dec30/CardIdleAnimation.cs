// Decompiled with JetBrains decompiler
// Type: CardIdleAnimation
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
public class CardIdleAnimation : MonoBehaviourCacheTransform
{
  private static readonly IntPtr NativeFieldInfoPtr_profile;
  private static readonly IntPtr NativeFieldInfoPtr__entity;
  private static readonly IntPtr NativeFieldInfoPtr_alwaysOn;
  private static readonly IntPtr NativeFieldInfoPtr_strength;
  private static readonly IntPtr NativeFieldInfoPtr_speedFactor;
  private static readonly IntPtr NativeFieldInfoPtr_fadeInTime;
  private static readonly IntPtr NativeFieldInfoPtr_fadeInStrength;
  private static readonly IntPtr NativeFieldInfoPtr_speed;
  private static readonly IntPtr NativeFieldInfoPtr_offset;
  private static readonly IntPtr NativeFieldInfoPtr_basePosition;
  private static readonly IntPtr NativeFieldInfoPtr_baseRotation;
  private static readonly IntPtr NativeFieldInfoPtr_baseScale;
  private static readonly IntPtr NativeFieldInfoPtr_setProfile;
  private static readonly IntPtr NativeFieldInfoPtr_currentAction;
  private static readonly IntPtr NativeMethodInfoPtr_get_entity_Public_get_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_entity_Public_set_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetSpeed_Public_Void_Single_Single_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetProfile_Private_Void_CardAnimationProfile_0;
  private static readonly IntPtr NativeMethodInfoPtr_StartAction_Private_Void_Action_0;
  private static readonly IntPtr NativeMethodInfoPtr_RunAction_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_FadeIn_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_FadeOut_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe Entity entity
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 35469, RefRangeEnd = 35472, XrefRangeStart = 35469, XrefRangeEnd = 35469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardIdleAnimation.NativeMethodInfoPtr_get_entity_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 35475, RefRangeEnd = 35477, XrefRangeStart = 35472, XrefRangeEnd = 35475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardIdleAnimation.NativeMethodInfoPtr_set_entity_Public_set_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35477, XrefRangeEnd = 35484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardIdleAnimation.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35484, XrefRangeEnd = 35485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardIdleAnimation.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35485, XrefRangeEnd = 35486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardIdleAnimation.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35486, XrefRangeEnd = 35527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardIdleAnimation.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void SetSpeed(float speed, float speedFactor, float offset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &speed;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &speedFactor;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &offset;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardIdleAnimation.NativeMethodInfoPtr_SetSpeed_Public_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 35537, RefRangeEnd = 35539, XrefRangeStart = 35527, XrefRangeEnd = 35537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetProfile(CardAnimationProfile profile)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) profile)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardIdleAnimation.NativeMethodInfoPtr_SetProfile_Private_Void_CardAnimationProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 35542, RefRangeEnd = 35543, XrefRangeStart = 35539, XrefRangeEnd = 35542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartAction(CardIdleAnimation.Action action)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &action
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardIdleAnimation.NativeMethodInfoPtr_StartAction_Private_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void RunAction()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardIdleAnimation.NativeMethodInfoPtr_RunAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 35544, RefRangeEnd = 35549, XrefRangeStart = 35543, XrefRangeEnd = 35544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FadeIn()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardIdleAnimation.NativeMethodInfoPtr_FadeIn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 35553, RefRangeEnd = 35564, XrefRangeStart = 35549, XrefRangeEnd = 35553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FadeOut()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardIdleAnimation.NativeMethodInfoPtr_FadeOut_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 35564, RefRangeEnd = 35566, XrefRangeStart = 35564, XrefRangeEnd = 35564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardIdleAnimation.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(12611)]
  [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnGetFromPool()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardIdleAnimation.NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 35564, RefRangeEnd = 35566, XrefRangeStart = 35564, XrefRangeEnd = 35566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnReturnToPool()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardIdleAnimation.NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35566, XrefRangeEnd = 35567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardIdleAnimation()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardIdleAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardIdleAnimation()
  {
    Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardIdleAnimation));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr);
    CardIdleAnimation.NativeFieldInfoPtr_profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, nameof (profile));
    CardIdleAnimation.NativeFieldInfoPtr__entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, nameof (_entity));
    CardIdleAnimation.NativeFieldInfoPtr_alwaysOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, nameof (alwaysOn));
    CardIdleAnimation.NativeFieldInfoPtr_strength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, nameof (strength));
    CardIdleAnimation.NativeFieldInfoPtr_speedFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, nameof (speedFactor));
    CardIdleAnimation.NativeFieldInfoPtr_fadeInTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, nameof (fadeInTime));
    CardIdleAnimation.NativeFieldInfoPtr_fadeInStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, nameof (fadeInStrength));
    CardIdleAnimation.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, nameof (speed));
    CardIdleAnimation.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, nameof (offset));
    CardIdleAnimation.NativeFieldInfoPtr_basePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, nameof (basePosition));
    CardIdleAnimation.NativeFieldInfoPtr_baseRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, nameof (baseRotation));
    CardIdleAnimation.NativeFieldInfoPtr_baseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, nameof (baseScale));
    CardIdleAnimation.NativeFieldInfoPtr_setProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, nameof (setProfile));
    CardIdleAnimation.NativeFieldInfoPtr_currentAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, nameof (currentAction));
    CardIdleAnimation.NativeMethodInfoPtr_get_entity_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, 100665640);
    CardIdleAnimation.NativeMethodInfoPtr_set_entity_Public_set_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, 100665641);
    CardIdleAnimation.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, 100665642);
    CardIdleAnimation.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, 100665643);
    CardIdleAnimation.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, 100665644);
    CardIdleAnimation.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, 100665645);
    CardIdleAnimation.NativeMethodInfoPtr_SetSpeed_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, 100665646);
    CardIdleAnimation.NativeMethodInfoPtr_SetProfile_Private_Void_CardAnimationProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, 100665647);
    CardIdleAnimation.NativeMethodInfoPtr_StartAction_Private_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, 100665648);
    CardIdleAnimation.NativeMethodInfoPtr_RunAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, 100665649);
    CardIdleAnimation.NativeMethodInfoPtr_FadeIn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, 100665650);
    CardIdleAnimation.NativeMethodInfoPtr_FadeOut_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, 100665651);
    CardIdleAnimation.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, 100665652);
    CardIdleAnimation.NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, 100665653);
    CardIdleAnimation.NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, 100665654);
    CardIdleAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIdleAnimation>.NativeClassPtr, 100665655);
  }

  public CardIdleAnimation(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe CardAnimationProfile profile
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_profile));
      return pointer == IntPtr.Zero ? (CardAnimationProfile) null : new CardAnimationProfile(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_profile), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Entity _entity
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr__entity));
      return pointer == IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr__entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool alwaysOn
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_alwaysOn));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_alwaysOn)) = value;
    }
  }

  public unsafe float strength
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_strength));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_strength)) = value;
    }
  }

  public unsafe float speedFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_speedFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_speedFactor)) = value;
    }
  }

  public unsafe float fadeInTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_fadeInTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_fadeInTime)) = value;
    }
  }

  public unsafe float fadeInStrength
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_fadeInStrength));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_fadeInStrength)) = value;
    }
  }

  public unsafe float speed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_speed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_speed)) = value;
    }
  }

  public unsafe float offset
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_offset));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_offset)) = value;
    }
  }

  public unsafe Vector3 basePosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_basePosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_basePosition)) = value;
    }
  }

  public unsafe Vector3 baseRotation
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_baseRotation));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_baseRotation)) = value;
    }
  }

  public unsafe Vector3 baseScale
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_baseScale));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_baseScale)) = value;
    }
  }

  public unsafe CardAnimationProfile setProfile
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_setProfile));
      return pointer == IntPtr.Zero ? (CardAnimationProfile) null : new CardAnimationProfile(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_setProfile), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardIdleAnimation.Action currentAction
  {
    get
    {
      return *(CardIdleAnimation.Action*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_currentAction));
    }
    [param: In] set
    {
      *(CardIdleAnimation.Action*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIdleAnimation.NativeFieldInfoPtr_currentAction)) = value;
    }
  }

  public enum Action
  {
    None,
    FadeIn,
    FadeOut,
  }
}
