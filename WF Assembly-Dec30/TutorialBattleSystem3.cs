// Decompiled with JetBrains decompiler
// Type: TutorialBattleSystem3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class TutorialBattleSystem3 : TutorialBattleSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_chosenUnit;
  private static readonly System.IntPtr NativeMethodInfoPtr_BattleStart_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindChosenUnit_Private_Static_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79625, XrefRangeEnd = 79701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void BattleStart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem3.NativeMethodInfoPtr_BattleStart_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 79755, RefRangeEnd = 79756, XrefRangeStart = 79701, XrefRangeEnd = 79755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Entity FindChosenUnit()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem3.NativeMethodInfoPtr_FindChosenUnit_Private_Static_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TutorialBattleSystem3()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem3>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TutorialBattleSystem3()
  {
    Il2CppClassPointerStore<TutorialBattleSystem3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TutorialBattleSystem3));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem3>.NativeClassPtr);
    TutorialBattleSystem3.NativeFieldInfoPtr_chosenUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem3>.NativeClassPtr, nameof (chosenUnit));
    TutorialBattleSystem3.NativeMethodInfoPtr_BattleStart_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3>.NativeClassPtr, 100669768);
    TutorialBattleSystem3.NativeMethodInfoPtr_FindChosenUnit_Private_Static_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3>.NativeClassPtr, 100669769);
    TutorialBattleSystem3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3>.NativeClassPtr, 100669770);
  }

  public TutorialBattleSystem3(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Entity chosenUnit
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem3.NativeFieldInfoPtr_chosenUnit));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem3.NativeFieldInfoPtr_chosenUnit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public class PhaseWaitForLeader : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EntityMove_Private_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79517, XrefRangeEnd = 79525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem3.PhaseWaitForLeader.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79525, XrefRangeEnd = 79533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem3.PhaseWaitForLeader.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79533, XrefRangeEnd = 79540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EntityMove(Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem3.PhaseWaitForLeader.NativeMethodInfoPtr_EntityMove_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhaseWaitForLeader()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem3.PhaseWaitForLeader>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem3.PhaseWaitForLeader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PhaseWaitForLeader()
    {
      Il2CppClassPointerStore<TutorialBattleSystem3.PhaseWaitForLeader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem3>.NativeClassPtr, nameof (PhaseWaitForLeader));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem3.PhaseWaitForLeader>.NativeClassPtr);
      TutorialBattleSystem3.PhaseWaitForLeader.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.PhaseWaitForLeader>.NativeClassPtr, 100669771);
      TutorialBattleSystem3.PhaseWaitForLeader.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.PhaseWaitForLeader>.NativeClassPtr, 100669772);
      TutorialBattleSystem3.PhaseWaitForLeader.NativeMethodInfoPtr_EntityMove_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.PhaseWaitForLeader>.NativeClassPtr, 100669773);
      TutorialBattleSystem3.PhaseWaitForLeader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.PhaseWaitForLeader>.NativeClassPtr, 100669774);
    }

    public PhaseWaitForLeader(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }

  public class PhasePlaceCompanion : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_target;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PromptAfter_Private_IEnumerator_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CorrectAction_Private_Boolean_PlayAction_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 77793, RefRangeEnd = 77796, XrefRangeStart = 77793, XrefRangeEnd = 77796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhasePlaceCompanion(Entity target)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem3.PhasePlaceCompanion.NativeMethodInfoPtr__ctor_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79560, XrefRangeEnd = 79584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem3.PhasePlaceCompanion.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79584, XrefRangeEnd = 79600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem3.PhasePlaceCompanion.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79600, XrefRangeEnd = 79605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerator PromptAfter(float delay)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &delay
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem3.PhasePlaceCompanion.NativeMethodInfoPtr_PromptAfter_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79605, XrefRangeEnd = 79619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem3.PhasePlaceCompanion.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref PlayAction local = ref action;
      System.IntPtr pointer = ptr;
      PlayAction playAction = pointer == System.IntPtr.Zero ? (PlayAction) null : new PlayAction(pointer);
      local = playAction;
    }

    [CallerCount(0)]
    public unsafe void BattleTurnStart(int turn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &turn
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem3.PhasePlaceCompanion.NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79619, XrefRangeEnd = 79625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CorrectAction(PlayAction action)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem3.PhasePlaceCompanion.NativeMethodInfoPtr_CorrectAction_Private_Boolean_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static PhasePlaceCompanion()
    {
      Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem3>.NativeClassPtr, nameof (PhasePlaceCompanion));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion>.NativeClassPtr);
      TutorialBattleSystem3.PhasePlaceCompanion.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion>.NativeClassPtr, nameof (target));
      TutorialBattleSystem3.PhasePlaceCompanion.NativeMethodInfoPtr__ctor_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion>.NativeClassPtr, 100669775);
      TutorialBattleSystem3.PhasePlaceCompanion.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion>.NativeClassPtr, 100669776);
      TutorialBattleSystem3.PhasePlaceCompanion.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion>.NativeClassPtr, 100669777);
      TutorialBattleSystem3.PhasePlaceCompanion.NativeMethodInfoPtr_PromptAfter_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion>.NativeClassPtr, 100669778);
      TutorialBattleSystem3.PhasePlaceCompanion.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion>.NativeClassPtr, 100669779);
      TutorialBattleSystem3.PhasePlaceCompanion.NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion>.NativeClassPtr, 100669780);
      TutorialBattleSystem3.PhasePlaceCompanion.NativeMethodInfoPtr_CorrectAction_Private_Boolean_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion>.NativeClassPtr, 100669781);
    }

    public PhasePlaceCompanion(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Entity target
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem3.PhasePlaceCompanion.NativeFieldInfoPtr_target));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem3.PhasePlaceCompanion.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("TutorialBattleSystem3/PhasePlaceCompanion/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__4_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PromptAfter_b__4_0_Internal_String_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem3.PhasePlaceCompanion.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79540, XrefRangeEnd = 79546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _PromptAfter_b__4_0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem3.PhasePlaceCompanion.__c.NativeMethodInfoPtr__PromptAfter_b__4_0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c()
      {
        Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion.__c>.NativeClassPtr);
        TutorialBattleSystem3.PhasePlaceCompanion.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion.__c>.NativeClassPtr, "<>9");
        TutorialBattleSystem3.PhasePlaceCompanion.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion.__c>.NativeClassPtr, "<>9__4_0");
        TutorialBattleSystem3.PhasePlaceCompanion.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion.__c>.NativeClassPtr, 100669783);
        TutorialBattleSystem3.PhasePlaceCompanion.__c.NativeMethodInfoPtr__PromptAfter_b__4_0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion.__c>.NativeClassPtr, 100669784);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe TutorialBattleSystem3.PhasePlaceCompanion.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem3.PhasePlaceCompanion.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (TutorialBattleSystem3.PhasePlaceCompanion.__c) null : new TutorialBattleSystem3.PhasePlaceCompanion.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem3.PhasePlaceCompanion.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Prompt.GetTextCallback __9__4_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem3.PhasePlaceCompanion.__c.NativeFieldInfoPtr___9__4_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Prompt.GetTextCallback) null : new Prompt.GetTextCallback(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem3.PhasePlaceCompanion.__c.NativeFieldInfoPtr___9__4_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("TutorialBattleSystem3/PhasePlaceCompanion/<PromptAfter>d__4")]
    public sealed class _PromptAfter_d__4 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
      private static readonly System.IntPtr NativeFieldInfoPtr_delay;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

      [CallerCount(53)]
      [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe _PromptAfter_d__4(int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &_param1
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(12611)]
      [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79546, XrefRangeEnd = 79554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79554, XrefRangeEnd = 79560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      static _PromptAfter_d__4()
      {
        Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion>.NativeClassPtr, "<PromptAfter>d__4");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr);
        TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr, "<>1__state");
        TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr, "<>2__current");
        TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr, nameof (delay));
        TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr, "<>4__this");
        TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr, 100669785);
        TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr, 100669786);
        TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr, 100669787);
        TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr, 100669788);
        TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr, 100669789);
        TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr, 100669790);
      }

      public _PromptAfter_d__4(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe Il2CppSystem.Object __2__current
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr___2__current));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float delay
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr_delay));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr_delay)) = value;
        }
      }

      public unsafe TutorialBattleSystem3.PhasePlaceCompanion __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (TutorialBattleSystem3.PhasePlaceCompanion) null : new TutorialBattleSystem3.PhasePlaceCompanion(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem3.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  [ObfuscatedName("TutorialBattleSystem3/<>c__DisplayClass2_0")]
  public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_chosenUnitData;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__FindChosenUnit_b__2_Internal_Boolean_Entity_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass2_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem3.__c__DisplayClass2_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem3.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _FindChosenUnit_b__2(Entity a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem3.__c__DisplayClass2_0.NativeMethodInfoPtr__FindChosenUnit_b__2_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass2_0()
    {
      Il2CppClassPointerStore<TutorialBattleSystem3.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem3>.NativeClassPtr, "<>c__DisplayClass2_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem3.__c__DisplayClass2_0>.NativeClassPtr);
      TutorialBattleSystem3.__c__DisplayClass2_0.NativeFieldInfoPtr_chosenUnitData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem3.__c__DisplayClass2_0>.NativeClassPtr, nameof (chosenUnitData));
      TutorialBattleSystem3.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.__c__DisplayClass2_0>.NativeClassPtr, 100669791);
      TutorialBattleSystem3.__c__DisplayClass2_0.NativeMethodInfoPtr__FindChosenUnit_b__2_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.__c__DisplayClass2_0>.NativeClassPtr, 100669792);
    }

    public __c__DisplayClass2_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CardData chosenUnitData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem3.__c__DisplayClass2_0.NativeFieldInfoPtr_chosenUnitData));
        return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem3.__c__DisplayClass2_0.NativeFieldInfoPtr_chosenUnitData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("TutorialBattleSystem3/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__2_1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__FindChosenUnit_b__2_0_Internal_Int32_CardData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__FindChosenUnit_b__2_1_Internal_Boolean_CardData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem3.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem3.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe int _FindChosenUnit_b__2_0(CardData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem3.__c.NativeMethodInfoPtr__FindChosenUnit_b__2_0_Internal_Int32_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool _FindChosenUnit_b__2_1(CardData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem3.__c.NativeMethodInfoPtr__FindChosenUnit_b__2_1_Internal_Boolean_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<TutorialBattleSystem3.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem3>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem3.__c>.NativeClassPtr);
      TutorialBattleSystem3.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem3.__c>.NativeClassPtr, "<>9");
      TutorialBattleSystem3.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem3.__c>.NativeClassPtr, "<>9__2_0");
      TutorialBattleSystem3.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem3.__c>.NativeClassPtr, "<>9__2_1");
      TutorialBattleSystem3.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.__c>.NativeClassPtr, 100669794);
      TutorialBattleSystem3.__c.NativeMethodInfoPtr__FindChosenUnit_b__2_0_Internal_Int32_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.__c>.NativeClassPtr, 100669795);
      TutorialBattleSystem3.__c.NativeMethodInfoPtr__FindChosenUnit_b__2_1_Internal_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem3.__c>.NativeClassPtr, 100669796);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe TutorialBattleSystem3.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem3.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (TutorialBattleSystem3.__c) null : new TutorialBattleSystem3.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem3.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData, int> __9__2_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem3.__c.NativeFieldInfoPtr___9__2_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData, int>) null : new Il2CppSystem.Func<CardData, int>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem3.__c.NativeFieldInfoPtr___9__2_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData, bool> __9__2_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem3.__c.NativeFieldInfoPtr___9__2_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData, bool>) null : new Il2CppSystem.Func<CardData, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem3.__c.NativeFieldInfoPtr___9__2_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
