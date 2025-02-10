// Decompiled with JetBrains decompiler
// Type: NoTargetTextSystem
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
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class NoTargetTextSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instance;
  private static readonly System.IntPtr NativeFieldInfoPtr_shakeCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_shakeAmount;
  private static readonly System.IntPtr NativeFieldInfoPtr_shakeDurationRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_textElement;
  private static readonly System.IntPtr NativeFieldInfoPtr_textPopOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_sfxEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_noTargetToAttackText;
  private static readonly System.IntPtr NativeFieldInfoPtr_noAlliesToHealText;
  private static readonly System.IntPtr NativeFieldInfoPtr_noTargetForStatusText;
  private static readonly System.IntPtr NativeFieldInfoPtr_noSpaceToSummonText;
  private static readonly System.IntPtr NativeFieldInfoPtr_noCardsToDrawText;
  private static readonly System.IntPtr NativeFieldInfoPtr_noAllyToBoostText;
  private static readonly System.IntPtr NativeFieldInfoPtr_noEnemyToBoostText;
  private static readonly System.IntPtr NativeFieldInfoPtr_requiresJunkText;
  private static readonly System.IntPtr NativeFieldInfoPtr_cantSplitText;
  private static readonly System.IntPtr NativeFieldInfoPtr_noSummonedAlliesText;
  private static readonly System.IntPtr NativeFieldInfoPtr_playCrownCardsText;
  private static readonly System.IntPtr NativeFieldInfoPtr_noAllyToAttackText;
  private static readonly System.IntPtr NativeFieldInfoPtr_cantMoveText;
  private static readonly System.IntPtr NativeFieldInfoPtr_strings;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LocaleChanged_Private_Void_Locale_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PopulateStrings_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Exists_Public_Static_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Static_IEnumerator_Entity_NoTargetType_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Run_Private_IEnumerator_Entity_NoTargetType_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PopText_Private_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66127, XrefRangeEnd = 66140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NoTargetTextSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66140, XrefRangeEnd = 66148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NoTargetTextSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66148, XrefRangeEnd = 66149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LocaleChanged(UnityEngine.Localization.Locale locale)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) locale)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NoTargetTextSystem.NativeMethodInfoPtr_LocaleChanged_Private_Void_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 66193, RefRangeEnd = 66195, XrefRangeStart = 66149, XrefRangeEnd = 66193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PopulateStrings()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NoTargetTextSystem.NativeMethodInfoPtr_PopulateStrings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 66201, RefRangeEnd = 66207, XrefRangeStart = 66195, XrefRangeEnd = 66201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Exists()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NoTargetTextSystem.NativeMethodInfoPtr_Exists_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 66216, RefRangeEnd = 66221, XrefRangeStart = 66207, XrefRangeEnd = 66216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IEnumerator Run(
    Entity entity,
    NoTargetType type,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
  {
    if (args == null)
      args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NoTargetTextSystem.NativeMethodInfoPtr_Run_Public_Static_IEnumerator_Entity_NoTargetType_Il2CppReferenceArray_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66221, XrefRangeEnd = 66228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator _Run(
    Entity entity,
    NoTargetType type,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
  {
    if (args == null)
      args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NoTargetTextSystem.NativeMethodInfoPtr__Run_Private_IEnumerator_Entity_NoTargetType_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 66265, RefRangeEnd = 66266, XrefRangeStart = 66228, XrefRangeEnd = 66265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PopText(Vector3 fromPos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &fromPos
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NoTargetTextSystem.NativeMethodInfoPtr_PopText_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66266, XrefRangeEnd = 66275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NoTargetTextSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NoTargetTextSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public static IEnumerator Run(Entity entity, NoTargetType type, params Il2CppSystem.Object[] args)
  {
    return NoTargetTextSystem.Run(entity, type, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
  }

  public IEnumerator _Run(Entity entity, NoTargetType type, params Il2CppSystem.Object[] args)
  {
    return this._Run(entity, type, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
  }

  static NoTargetTextSystem()
  {
    Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (NoTargetTextSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr);
    NoTargetTextSystem.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, nameof (instance));
    NoTargetTextSystem.NativeFieldInfoPtr_shakeCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, nameof (shakeCurve));
    NoTargetTextSystem.NativeFieldInfoPtr_shakeAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, nameof (shakeAmount));
    NoTargetTextSystem.NativeFieldInfoPtr_shakeDurationRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, nameof (shakeDurationRange));
    NoTargetTextSystem.NativeFieldInfoPtr_textElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, nameof (textElement));
    NoTargetTextSystem.NativeFieldInfoPtr_textPopOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, nameof (textPopOffset));
    NoTargetTextSystem.NativeFieldInfoPtr_sfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, nameof (sfxEvent));
    NoTargetTextSystem.NativeFieldInfoPtr_noTargetToAttackText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, nameof (noTargetToAttackText));
    NoTargetTextSystem.NativeFieldInfoPtr_noAlliesToHealText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, nameof (noAlliesToHealText));
    NoTargetTextSystem.NativeFieldInfoPtr_noTargetForStatusText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, nameof (noTargetForStatusText));
    NoTargetTextSystem.NativeFieldInfoPtr_noSpaceToSummonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, nameof (noSpaceToSummonText));
    NoTargetTextSystem.NativeFieldInfoPtr_noCardsToDrawText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, nameof (noCardsToDrawText));
    NoTargetTextSystem.NativeFieldInfoPtr_noAllyToBoostText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, nameof (noAllyToBoostText));
    NoTargetTextSystem.NativeFieldInfoPtr_noEnemyToBoostText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, nameof (noEnemyToBoostText));
    NoTargetTextSystem.NativeFieldInfoPtr_requiresJunkText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, nameof (requiresJunkText));
    NoTargetTextSystem.NativeFieldInfoPtr_cantSplitText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, nameof (cantSplitText));
    NoTargetTextSystem.NativeFieldInfoPtr_noSummonedAlliesText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, nameof (noSummonedAlliesText));
    NoTargetTextSystem.NativeFieldInfoPtr_playCrownCardsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, nameof (playCrownCardsText));
    NoTargetTextSystem.NativeFieldInfoPtr_noAllyToAttackText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, nameof (noAllyToAttackText));
    NoTargetTextSystem.NativeFieldInfoPtr_cantMoveText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, nameof (cantMoveText));
    NoTargetTextSystem.NativeFieldInfoPtr_strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, nameof (strings));
    NoTargetTextSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, 100668748);
    NoTargetTextSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, 100668749);
    NoTargetTextSystem.NativeMethodInfoPtr_LocaleChanged_Private_Void_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, 100668750);
    NoTargetTextSystem.NativeMethodInfoPtr_PopulateStrings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, 100668751);
    NoTargetTextSystem.NativeMethodInfoPtr_Exists_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, 100668752);
    NoTargetTextSystem.NativeMethodInfoPtr_Run_Public_Static_IEnumerator_Entity_NoTargetType_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, 100668753);
    NoTargetTextSystem.NativeMethodInfoPtr__Run_Private_IEnumerator_Entity_NoTargetType_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, 100668754);
    NoTargetTextSystem.NativeMethodInfoPtr_PopText_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, 100668755);
    NoTargetTextSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, 100668756);
  }

  public NoTargetTextSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe NoTargetTextSystem instance
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(NoTargetTextSystem.NativeFieldInfoPtr_instance, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (NoTargetTextSystem) null : new NoTargetTextSystem(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NoTargetTextSystem.NativeFieldInfoPtr_instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve shakeCurve
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_shakeCurve));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_shakeCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 shakeAmount
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_shakeAmount));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_shakeAmount)) = value;
    }
  }

  public unsafe Vector2 shakeDurationRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_shakeDurationRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_shakeDurationRange)) = value;
    }
  }

  public unsafe TMP_Text textElement
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_textElement));
      return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_textElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 textPopOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_textPopOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_textPopOffset)) = value;
    }
  }

  public unsafe EventReference sfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_sfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_sfxEvent)) = value;
    }
  }

  public unsafe LocalizedString noTargetToAttackText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_noTargetToAttackText));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_noTargetToAttackText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString noAlliesToHealText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_noAlliesToHealText));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_noAlliesToHealText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString noTargetForStatusText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_noTargetForStatusText));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_noTargetForStatusText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString noSpaceToSummonText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_noSpaceToSummonText));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_noSpaceToSummonText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString noCardsToDrawText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_noCardsToDrawText));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_noCardsToDrawText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString noAllyToBoostText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_noAllyToBoostText));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_noAllyToBoostText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString noEnemyToBoostText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_noEnemyToBoostText));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_noEnemyToBoostText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString requiresJunkText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_requiresJunkText));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_requiresJunkText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString cantSplitText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_cantSplitText));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_cantSplitText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString noSummonedAlliesText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_noSummonedAlliesText));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_noSummonedAlliesText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString playCrownCardsText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_playCrownCardsText));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_playCrownCardsText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString noAllyToAttackText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_noAllyToAttackText));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_noAllyToAttackText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString cantMoveText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_cantMoveText));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_cantMoveText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<NoTargetType, string> strings
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_strings));
      return pointer == System.IntPtr.Zero ? (Dictionary<NoTargetType, string>) null : new Dictionary<NoTargetType, string>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.NativeFieldInfoPtr_strings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("NoTargetTextSystem/<_Run>d__27")]
  public sealed class __Run_d__27 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_type;
    private static readonly System.IntPtr NativeFieldInfoPtr_args;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __Run_d__27(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoTargetTextSystem.__Run_d__27>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NoTargetTextSystem.__Run_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NoTargetTextSystem.__Run_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66101, XrefRangeEnd = 66118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NoTargetTextSystem.__Run_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NoTargetTextSystem.__Run_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66118, XrefRangeEnd = 66124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NoTargetTextSystem.__Run_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NoTargetTextSystem.__Run_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static __Run_d__27()
    {
      Il2CppClassPointerStore<NoTargetTextSystem.__Run_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, "<_Run>d__27");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoTargetTextSystem.__Run_d__27>.NativeClassPtr);
      NoTargetTextSystem.__Run_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem.__Run_d__27>.NativeClassPtr, "<>1__state");
      NoTargetTextSystem.__Run_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem.__Run_d__27>.NativeClassPtr, "<>2__current");
      NoTargetTextSystem.__Run_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem.__Run_d__27>.NativeClassPtr, "<>4__this");
      NoTargetTextSystem.__Run_d__27.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem.__Run_d__27>.NativeClassPtr, nameof (entity));
      NoTargetTextSystem.__Run_d__27.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem.__Run_d__27>.NativeClassPtr, nameof (type));
      NoTargetTextSystem.__Run_d__27.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem.__Run_d__27>.NativeClassPtr, nameof (args));
      NoTargetTextSystem.__Run_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoTargetTextSystem.__Run_d__27>.NativeClassPtr, 100668757);
      NoTargetTextSystem.__Run_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoTargetTextSystem.__Run_d__27>.NativeClassPtr, 100668758);
      NoTargetTextSystem.__Run_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoTargetTextSystem.__Run_d__27>.NativeClassPtr, 100668759);
      NoTargetTextSystem.__Run_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoTargetTextSystem.__Run_d__27>.NativeClassPtr, 100668760);
      NoTargetTextSystem.__Run_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoTargetTextSystem.__Run_d__27>.NativeClassPtr, 100668761);
      NoTargetTextSystem.__Run_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoTargetTextSystem.__Run_d__27>.NativeClassPtr, 100668762);
    }

    public __Run_d__27(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.__Run_d__27.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.__Run_d__27.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.__Run_d__27.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.__Run_d__27.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NoTargetTextSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.__Run_d__27.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (NoTargetTextSystem) null : new NoTargetTextSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.__Run_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity entity
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.__Run_d__27.NativeFieldInfoPtr_entity));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.__Run_d__27.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NoTargetType type
    {
      get
      {
        return *(NoTargetType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.__Run_d__27.NativeFieldInfoPtr_type));
      }
      [param: In] set
      {
        *(NoTargetType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.__Run_d__27.NativeFieldInfoPtr_type)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<Il2CppSystem.Object> args
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.__Run_d__27.NativeFieldInfoPtr_args));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Object>) null : new Il2CppReferenceArray<Il2CppSystem.Object>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.__Run_d__27.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("NoTargetTextSystem/<>c__DisplayClass28_0")]
  public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_obj;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__PopText_b__0_Internal_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__PopText_b__1_Internal_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass28_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoTargetTextSystem.__c__DisplayClass28_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NoTargetTextSystem.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66124, XrefRangeEnd = 66125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _PopText_b__0(float a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &a
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NoTargetTextSystem.__c__DisplayClass28_0.NativeMethodInfoPtr__PopText_b__0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66125, XrefRangeEnd = 66127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _PopText_b__1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NoTargetTextSystem.__c__DisplayClass28_0.NativeMethodInfoPtr__PopText_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass28_0()
    {
      Il2CppClassPointerStore<NoTargetTextSystem.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoTargetTextSystem>.NativeClassPtr, "<>c__DisplayClass28_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoTargetTextSystem.__c__DisplayClass28_0>.NativeClassPtr);
      NoTargetTextSystem.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem.__c__DisplayClass28_0>.NativeClassPtr, "<>4__this");
      NoTargetTextSystem.__c__DisplayClass28_0.NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoTargetTextSystem.__c__DisplayClass28_0>.NativeClassPtr, nameof (obj));
      NoTargetTextSystem.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoTargetTextSystem.__c__DisplayClass28_0>.NativeClassPtr, 100668763);
      NoTargetTextSystem.__c__DisplayClass28_0.NativeMethodInfoPtr__PopText_b__0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoTargetTextSystem.__c__DisplayClass28_0>.NativeClassPtr, 100668764);
      NoTargetTextSystem.__c__DisplayClass28_0.NativeMethodInfoPtr__PopText_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoTargetTextSystem.__c__DisplayClass28_0>.NativeClassPtr, 100668765);
    }

    public __c__DisplayClass28_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NoTargetTextSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (NoTargetTextSystem) null : new NoTargetTextSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject obj
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.__c__DisplayClass28_0.NativeFieldInfoPtr_obj));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoTargetTextSystem.__c__DisplayClass28_0.NativeFieldInfoPtr_obj), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
