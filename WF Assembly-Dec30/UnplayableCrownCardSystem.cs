// Decompiled with JetBrains decompiler
// Type: UnplayableCrownCardSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Localization;
using UnityEngine.SceneManagement;

#nullable disable
public class UnplayableCrownCardSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_promptKey;
  private static readonly IntPtr NativeFieldInfoPtr_active;
  private static readonly IntPtr NativeFieldInfoPtr_blocked;
  private static readonly IntPtr NativeFieldInfoPtr_promptShown;
  private static readonly IntPtr NativeFieldInfoPtr_handCount;
  private static readonly IntPtr NativeFieldInfoPtr_timerMax;
  private static readonly IntPtr NativeFieldInfoPtr_timer;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_BattleStart_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0;
  private static readonly IntPtr NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0;
  private static readonly IntPtr NativeMethodInfoPtr_Activate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Check_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckBlocked_Private_Static_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_CardIsBlocked_Private_Static_Boolean_Entity_Il2CppReferenceArray_1_CardContainer_0;
  private static readonly IntPtr NativeMethodInfoPtr_ShowPrompt_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ShowPrompt_b__18_0_Private_String_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80984, XrefRangeEnd = 81006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UnplayableCrownCardSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81006, XrefRangeEnd = 81028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UnplayableCrownCardSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81028, XrefRangeEnd = 81030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BattleStart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UnplayableCrownCardSystem.NativeMethodInfoPtr_BattleStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81030, XrefRangeEnd = 81031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SceneChanged(Scene scene)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &scene
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UnplayableCrownCardSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81031, XrefRangeEnd = 81040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ActionPerform(PlayAction action)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UnplayableCrownCardSystem.NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81040, XrefRangeEnd = 81042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Activate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UnplayableCrownCardSystem.NativeMethodInfoPtr_Activate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81042, XrefRangeEnd = 81044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UnplayableCrownCardSystem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 81063, RefRangeEnd = 81064, XrefRangeStart = 81044, XrefRangeEnd = 81063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Check()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UnplayableCrownCardSystem.NativeMethodInfoPtr_Check_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81064, XrefRangeEnd = 81065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Deactivate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UnplayableCrownCardSystem.NativeMethodInfoPtr_Deactivate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 81092, RefRangeEnd = 81093, XrefRangeStart = 81065, XrefRangeEnd = 81092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CheckBlocked()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnplayableCrownCardSystem.NativeMethodInfoPtr_CheckBlocked_Private_Static_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 81130, RefRangeEnd = 81131, XrefRangeStart = 81093, XrefRangeEnd = 81130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CardIsBlocked(
    Entity card,
    Il2CppReferenceArray<CardContainer> containers)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) containers);
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnplayableCrownCardSystem.NativeMethodInfoPtr_CardIsBlocked_Private_Static_Boolean_Entity_Il2CppReferenceArray_1_CardContainer_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81131, XrefRangeEnd = 81139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowPrompt()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UnplayableCrownCardSystem.NativeMethodInfoPtr_ShowPrompt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnplayableCrownCardSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UnplayableCrownCardSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 81141, RefRangeEnd = 81143, XrefRangeStart = 81139, XrefRangeEnd = 81141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string _ShowPrompt_b__18_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UnplayableCrownCardSystem.NativeMethodInfoPtr__ShowPrompt_b__18_0_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  static UnplayableCrownCardSystem()
  {
    Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (UnplayableCrownCardSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr);
    UnplayableCrownCardSystem.NativeFieldInfoPtr_promptKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr, nameof (promptKey));
    UnplayableCrownCardSystem.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr, nameof (active));
    UnplayableCrownCardSystem.NativeFieldInfoPtr_blocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr, nameof (blocked));
    UnplayableCrownCardSystem.NativeFieldInfoPtr_promptShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr, nameof (promptShown));
    UnplayableCrownCardSystem.NativeFieldInfoPtr_handCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr, nameof (handCount));
    UnplayableCrownCardSystem.NativeFieldInfoPtr_timerMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr, nameof (timerMax));
    UnplayableCrownCardSystem.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr, nameof (timer));
    UnplayableCrownCardSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr, 100669932);
    UnplayableCrownCardSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr, 100669933);
    UnplayableCrownCardSystem.NativeMethodInfoPtr_BattleStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr, 100669934);
    UnplayableCrownCardSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr, 100669935);
    UnplayableCrownCardSystem.NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr, 100669936);
    UnplayableCrownCardSystem.NativeMethodInfoPtr_Activate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr, 100669937);
    UnplayableCrownCardSystem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr, 100669938);
    UnplayableCrownCardSystem.NativeMethodInfoPtr_Check_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr, 100669939);
    UnplayableCrownCardSystem.NativeMethodInfoPtr_Deactivate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr, 100669940);
    UnplayableCrownCardSystem.NativeMethodInfoPtr_CheckBlocked_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr, 100669941);
    UnplayableCrownCardSystem.NativeMethodInfoPtr_CardIsBlocked_Private_Static_Boolean_Entity_Il2CppReferenceArray_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr, 100669942);
    UnplayableCrownCardSystem.NativeMethodInfoPtr_ShowPrompt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr, 100669943);
    UnplayableCrownCardSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr, 100669944);
    UnplayableCrownCardSystem.NativeMethodInfoPtr__ShowPrompt_b__18_0_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnplayableCrownCardSystem>.NativeClassPtr, 100669945);
  }

  public UnplayableCrownCardSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LocalizedString promptKey
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnplayableCrownCardSystem.NativeFieldInfoPtr_promptKey));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnplayableCrownCardSystem.NativeFieldInfoPtr_promptKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool active
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnplayableCrownCardSystem.NativeFieldInfoPtr_active));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnplayableCrownCardSystem.NativeFieldInfoPtr_active)) = value;
    }
  }

  public unsafe bool blocked
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnplayableCrownCardSystem.NativeFieldInfoPtr_blocked));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnplayableCrownCardSystem.NativeFieldInfoPtr_blocked)) = value;
    }
  }

  public unsafe bool promptShown
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnplayableCrownCardSystem.NativeFieldInfoPtr_promptShown));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnplayableCrownCardSystem.NativeFieldInfoPtr_promptShown)) = value;
    }
  }

  public unsafe int handCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnplayableCrownCardSystem.NativeFieldInfoPtr_handCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnplayableCrownCardSystem.NativeFieldInfoPtr_handCount)) = value;
    }
  }

  public static unsafe float timerMax
  {
    get
    {
      float timerMax;
      IL2CPP.il2cpp_field_static_get_value(UnplayableCrownCardSystem.NativeFieldInfoPtr_timerMax, (void*) &timerMax);
      return timerMax;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UnplayableCrownCardSystem.NativeFieldInfoPtr_timerMax, (void*) &value);
    }
  }

  public unsafe float timer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnplayableCrownCardSystem.NativeFieldInfoPtr_timer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnplayableCrownCardSystem.NativeFieldInfoPtr_timer)) = value;
    }
  }
}
