// Decompiled with JetBrains decompiler
// Type: TutorialCompanionSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine.SceneManagement;

#nullable disable
public class TutorialCompanionSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_companionEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_init;
  private static readonly System.IntPtr NativeFieldInfoPtr_waitForBreak;
  private static readonly System.IntPtr NativeFieldInfoPtr_waitForInspect;
  private static readonly System.IntPtr NativeFieldInfoPtr_inspectDone;
  private static readonly System.IntPtr NativeFieldInfoPtr_promptDelay;
  private static readonly System.IntPtr NativeFieldInfoPtr_prompt2Show;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Private_Void_EventRoutineCompanion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EventStart_Private_Void_CampaignNode_EventRoutine_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Inspected_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ActionPerformed_Private_Void_PlayAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80009, XrefRangeEnd = 80045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialCompanionSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80045, XrefRangeEnd = 80082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialCompanionSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80082, XrefRangeEnd = 80083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init(EventRoutineCompanion companionEvent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) companionEvent)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialCompanionSystem.NativeMethodInfoPtr_Init_Private_Void_EventRoutineCompanion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80083, XrefRangeEnd = 80106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialCompanionSystem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80106, XrefRangeEnd = 80130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckAction(ref PlayAction action, ref bool allow)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action);
    System.IntPtr* numPtr3 = &ptr;
    *numPtr2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref allow;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialCompanionSystem.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref PlayAction local = ref action;
    System.IntPtr pointer = ptr;
    PlayAction playAction = pointer == System.IntPtr.Zero ? (PlayAction) null : new PlayAction(pointer);
    local = playAction;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80130, XrefRangeEnd = 80133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EventStart(CampaignNode node, EventRoutine @event)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @event);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialCompanionSystem.NativeMethodInfoPtr_EventStart_Private_Void_CampaignNode_EventRoutine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80133, XrefRangeEnd = 80134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Inspected(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialCompanionSystem.NativeMethodInfoPtr_Inspected_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80134, XrefRangeEnd = 80137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ActionPerformed(PlayAction action)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialCompanionSystem.NativeMethodInfoPtr_ActionPerformed_Private_Void_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80137, XrefRangeEnd = 80141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SceneChanged(Scene scene)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &scene
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialCompanionSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80141, XrefRangeEnd = 80142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TutorialCompanionSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCompanionSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialCompanionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TutorialCompanionSystem()
  {
    Il2CppClassPointerStore<TutorialCompanionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TutorialCompanionSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCompanionSystem>.NativeClassPtr);
    TutorialCompanionSystem.NativeFieldInfoPtr_companionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCompanionSystem>.NativeClassPtr, nameof (companionEvent));
    TutorialCompanionSystem.NativeFieldInfoPtr_init = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCompanionSystem>.NativeClassPtr, nameof (init));
    TutorialCompanionSystem.NativeFieldInfoPtr_waitForBreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCompanionSystem>.NativeClassPtr, nameof (waitForBreak));
    TutorialCompanionSystem.NativeFieldInfoPtr_waitForInspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCompanionSystem>.NativeClassPtr, nameof (waitForInspect));
    TutorialCompanionSystem.NativeFieldInfoPtr_inspectDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCompanionSystem>.NativeClassPtr, nameof (inspectDone));
    TutorialCompanionSystem.NativeFieldInfoPtr_promptDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCompanionSystem>.NativeClassPtr, nameof (promptDelay));
    TutorialCompanionSystem.NativeFieldInfoPtr_prompt2Show = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCompanionSystem>.NativeClassPtr, nameof (prompt2Show));
    TutorialCompanionSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCompanionSystem>.NativeClassPtr, 100669835);
    TutorialCompanionSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCompanionSystem>.NativeClassPtr, 100669836);
    TutorialCompanionSystem.NativeMethodInfoPtr_Init_Private_Void_EventRoutineCompanion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCompanionSystem>.NativeClassPtr, 100669837);
    TutorialCompanionSystem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCompanionSystem>.NativeClassPtr, 100669838);
    TutorialCompanionSystem.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCompanionSystem>.NativeClassPtr, 100669839);
    TutorialCompanionSystem.NativeMethodInfoPtr_EventStart_Private_Void_CampaignNode_EventRoutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCompanionSystem>.NativeClassPtr, 100669840);
    TutorialCompanionSystem.NativeMethodInfoPtr_Inspected_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCompanionSystem>.NativeClassPtr, 100669841);
    TutorialCompanionSystem.NativeMethodInfoPtr_ActionPerformed_Private_Void_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCompanionSystem>.NativeClassPtr, 100669842);
    TutorialCompanionSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCompanionSystem>.NativeClassPtr, 100669843);
    TutorialCompanionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCompanionSystem>.NativeClassPtr, 100669844);
  }

  public TutorialCompanionSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe EventRoutineCompanion companionEvent
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCompanionSystem.NativeFieldInfoPtr_companionEvent));
      return pointer == System.IntPtr.Zero ? (EventRoutineCompanion) null : new EventRoutineCompanion(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCompanionSystem.NativeFieldInfoPtr_companionEvent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool init
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCompanionSystem.NativeFieldInfoPtr_init));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCompanionSystem.NativeFieldInfoPtr_init)) = value;
    }
  }

  public unsafe bool waitForBreak
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCompanionSystem.NativeFieldInfoPtr_waitForBreak));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCompanionSystem.NativeFieldInfoPtr_waitForBreak)) = value;
    }
  }

  public unsafe bool waitForInspect
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCompanionSystem.NativeFieldInfoPtr_waitForInspect));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCompanionSystem.NativeFieldInfoPtr_waitForInspect)) = value;
    }
  }

  public unsafe bool inspectDone
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCompanionSystem.NativeFieldInfoPtr_inspectDone));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCompanionSystem.NativeFieldInfoPtr_inspectDone)) = value;
    }
  }

  public unsafe float promptDelay
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCompanionSystem.NativeFieldInfoPtr_promptDelay));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCompanionSystem.NativeFieldInfoPtr_promptDelay)) = value;
    }
  }

  public unsafe bool prompt2Show
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCompanionSystem.NativeFieldInfoPtr_prompt2Show));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCompanionSystem.NativeFieldInfoPtr_prompt2Show)) = value;
    }
  }

  [ObfuscatedName("TutorialCompanionSystem/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__10_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__11_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__10_0_Internal_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CheckAction_b__11_0_Internal_String_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCompanionSystem.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialCompanionSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79984, XrefRangeEnd = 80003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _Update_b__10_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TutorialCompanionSystem.__c.NativeMethodInfoPtr__Update_b__10_0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80003, XrefRangeEnd = 80009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _CheckAction_b__11_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TutorialCompanionSystem.__c.NativeMethodInfoPtr__CheckAction_b__11_0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static __c()
    {
      Il2CppClassPointerStore<TutorialCompanionSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCompanionSystem>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCompanionSystem.__c>.NativeClassPtr);
      TutorialCompanionSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCompanionSystem.__c>.NativeClassPtr, "<>9");
      TutorialCompanionSystem.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCompanionSystem.__c>.NativeClassPtr, "<>9__10_0");
      TutorialCompanionSystem.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCompanionSystem.__c>.NativeClassPtr, "<>9__11_0");
      TutorialCompanionSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCompanionSystem.__c>.NativeClassPtr, 100669846);
      TutorialCompanionSystem.__c.NativeMethodInfoPtr__Update_b__10_0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCompanionSystem.__c>.NativeClassPtr, 100669847);
      TutorialCompanionSystem.__c.NativeMethodInfoPtr__CheckAction_b__11_0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCompanionSystem.__c>.NativeClassPtr, 100669848);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe TutorialCompanionSystem.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TutorialCompanionSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (TutorialCompanionSystem.__c) null : new TutorialCompanionSystem.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TutorialCompanionSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Prompt.GetTextCallback __9__10_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TutorialCompanionSystem.__c.NativeFieldInfoPtr___9__10_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Prompt.GetTextCallback) null : new Prompt.GetTextCallback(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TutorialCompanionSystem.__c.NativeFieldInfoPtr___9__10_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Prompt.GetTextCallback __9__11_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TutorialCompanionSystem.__c.NativeFieldInfoPtr___9__11_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Prompt.GetTextCallback) null : new Prompt.GetTextCallback(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TutorialCompanionSystem.__c.NativeFieldInfoPtr___9__11_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
