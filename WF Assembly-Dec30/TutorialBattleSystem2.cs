// Decompiled with JetBrains decompiler
// Type: TutorialBattleSystem2
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
public class TutorialBattleSystem2 : TutorialBattleSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_chosenUnit;
  private static readonly System.IntPtr NativeMethodInfoPtr_BattleStart_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InsertPhase_Private_Void_Phase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindChosenUnit_Private_Static_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79355, XrefRangeEnd = 79474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void BattleStart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem2.NativeMethodInfoPtr_BattleStart_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 79478, RefRangeEnd = 79479, XrefRangeStart = 79474, XrefRangeEnd = 79478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InsertPhase(TutorialParentSystem.Phase phase)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) phase)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.NativeMethodInfoPtr_InsertPhase_Private_Void_Phase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 79516, RefRangeEnd = 79517, XrefRangeStart = 79479, XrefRangeEnd = 79516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Entity FindChosenUnit()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.NativeMethodInfoPtr_FindChosenUnit_Private_Static_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TutorialBattleSystem2()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem2>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TutorialBattleSystem2()
  {
    Il2CppClassPointerStore<TutorialBattleSystem2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TutorialBattleSystem2));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem2>.NativeClassPtr);
    TutorialBattleSystem2.NativeFieldInfoPtr_chosenUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2>.NativeClassPtr, nameof (chosenUnit));
    TutorialBattleSystem2.NativeMethodInfoPtr_BattleStart_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2>.NativeClassPtr, 100669676);
    TutorialBattleSystem2.NativeMethodInfoPtr_InsertPhase_Private_Void_Phase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2>.NativeClassPtr, 100669677);
    TutorialBattleSystem2.NativeMethodInfoPtr_FindChosenUnit_Private_Static_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2>.NativeClassPtr, 100669678);
    TutorialBattleSystem2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2>.NativeClassPtr, 100669679);
  }

  public TutorialBattleSystem2(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Entity chosenUnit
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.NativeFieldInfoPtr_chosenUnit));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.NativeFieldInfoPtr_chosenUnit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public class PhaseWaitForLeader : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EntityMove_Private_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78559, XrefRangeEnd = 78567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem2.PhaseWaitForLeader.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78567, XrefRangeEnd = 78575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem2.PhaseWaitForLeader.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78575, XrefRangeEnd = 78582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EntityMove(Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseWaitForLeader.NativeMethodInfoPtr_EntityMove_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhaseWaitForLeader()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWaitForLeader>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseWaitForLeader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PhaseWaitForLeader()
    {
      Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWaitForLeader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem2>.NativeClassPtr, nameof (PhaseWaitForLeader));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWaitForLeader>.NativeClassPtr);
      TutorialBattleSystem2.PhaseWaitForLeader.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWaitForLeader>.NativeClassPtr, 100669680);
      TutorialBattleSystem2.PhaseWaitForLeader.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWaitForLeader>.NativeClassPtr, 100669681);
      TutorialBattleSystem2.PhaseWaitForLeader.NativeMethodInfoPtr_EntityMove_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWaitForLeader>.NativeClassPtr, 100669682);
      TutorialBattleSystem2.PhaseWaitForLeader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWaitForLeader>.NativeClassPtr, 100669683);
    }

    public PhaseWaitForLeader(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }

  public class PhaseInspectEnemy : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_target;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Inspect_Private_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InspectEnd_Private_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CorrectAction_Private_Boolean_PlayAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnEnable_b__3_0_Private_String_0;

    public override unsafe float delay
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem2.PhaseInspectEnemy.NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78582, XrefRangeEnd = 78615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem2.PhaseInspectEnemy.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78615, XrefRangeEnd = 78637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem2.PhaseInspectEnemy.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78637, XrefRangeEnd = 78648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseInspectEnemy.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref PlayAction local = ref action;
      System.IntPtr pointer = ptr;
      PlayAction playAction = pointer == System.IntPtr.Zero ? (PlayAction) null : new PlayAction(pointer);
      local = playAction;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 40865, RefRangeEnd = 40866, XrefRangeStart = 40865, XrefRangeEnd = 40866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Inspect(Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseInspectEnemy.NativeMethodInfoPtr_Inspect_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void InspectEnd(Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseInspectEnemy.NativeMethodInfoPtr_InspectEnd_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78648, XrefRangeEnd = 78654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CorrectAction(PlayAction action)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseInspectEnemy.NativeMethodInfoPtr_CorrectAction_Private_Boolean_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhaseInspectEnemy()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseInspectEnemy>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseInspectEnemy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78654, XrefRangeEnd = 78669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _OnEnable_b__3_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseInspectEnemy.NativeMethodInfoPtr__OnEnable_b__3_0_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static PhaseInspectEnemy()
    {
      Il2CppClassPointerStore<TutorialBattleSystem2.PhaseInspectEnemy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem2>.NativeClassPtr, nameof (PhaseInspectEnemy));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseInspectEnemy>.NativeClassPtr);
      TutorialBattleSystem2.PhaseInspectEnemy.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseInspectEnemy>.NativeClassPtr, nameof (target));
      TutorialBattleSystem2.PhaseInspectEnemy.NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseInspectEnemy>.NativeClassPtr, 100669684);
      TutorialBattleSystem2.PhaseInspectEnemy.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseInspectEnemy>.NativeClassPtr, 100669685);
      TutorialBattleSystem2.PhaseInspectEnemy.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseInspectEnemy>.NativeClassPtr, 100669686);
      TutorialBattleSystem2.PhaseInspectEnemy.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseInspectEnemy>.NativeClassPtr, 100669687);
      TutorialBattleSystem2.PhaseInspectEnemy.NativeMethodInfoPtr_Inspect_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseInspectEnemy>.NativeClassPtr, 100669688);
      TutorialBattleSystem2.PhaseInspectEnemy.NativeMethodInfoPtr_InspectEnd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseInspectEnemy>.NativeClassPtr, 100669689);
      TutorialBattleSystem2.PhaseInspectEnemy.NativeMethodInfoPtr_CorrectAction_Private_Boolean_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseInspectEnemy>.NativeClassPtr, 100669690);
      TutorialBattleSystem2.PhaseInspectEnemy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseInspectEnemy>.NativeClassPtr, 100669691);
      TutorialBattleSystem2.PhaseInspectEnemy.NativeMethodInfoPtr__OnEnable_b__3_0_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseInspectEnemy>.NativeClassPtr, 100669692);
    }

    public PhaseInspectEnemy(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Entity target
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseInspectEnemy.NativeFieldInfoPtr_target));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseInspectEnemy.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
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
    private static readonly System.IntPtr NativeMethodInfoPtr__PromptAfter_b__4_0_Private_String_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 77793, RefRangeEnd = 77796, XrefRangeStart = 77793, XrefRangeEnd = 77796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhasePlaceCompanion(Entity target)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhasePlaceCompanion.NativeMethodInfoPtr__ctor_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78682, XrefRangeEnd = 78706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem2.PhasePlaceCompanion.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78706, XrefRangeEnd = 78722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem2.PhasePlaceCompanion.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78722, XrefRangeEnd = 78727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerator PromptAfter(float delay)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &delay
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhasePlaceCompanion.NativeMethodInfoPtr_PromptAfter_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78727, XrefRangeEnd = 78735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhasePlaceCompanion.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhasePlaceCompanion.NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 78741, RefRangeEnd = 78742, XrefRangeStart = 78735, XrefRangeEnd = 78741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CorrectAction(PlayAction action)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhasePlaceCompanion.NativeMethodInfoPtr_CorrectAction_Private_Boolean_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78742, XrefRangeEnd = 78750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _PromptAfter_b__4_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhasePlaceCompanion.NativeMethodInfoPtr__PromptAfter_b__4_0_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static PhasePlaceCompanion()
    {
      Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem2>.NativeClassPtr, nameof (PhasePlaceCompanion));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion>.NativeClassPtr);
      TutorialBattleSystem2.PhasePlaceCompanion.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion>.NativeClassPtr, nameof (target));
      TutorialBattleSystem2.PhasePlaceCompanion.NativeMethodInfoPtr__ctor_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion>.NativeClassPtr, 100669693);
      TutorialBattleSystem2.PhasePlaceCompanion.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion>.NativeClassPtr, 100669694);
      TutorialBattleSystem2.PhasePlaceCompanion.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion>.NativeClassPtr, 100669695);
      TutorialBattleSystem2.PhasePlaceCompanion.NativeMethodInfoPtr_PromptAfter_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion>.NativeClassPtr, 100669696);
      TutorialBattleSystem2.PhasePlaceCompanion.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion>.NativeClassPtr, 100669697);
      TutorialBattleSystem2.PhasePlaceCompanion.NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion>.NativeClassPtr, 100669698);
      TutorialBattleSystem2.PhasePlaceCompanion.NativeMethodInfoPtr_CorrectAction_Private_Boolean_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion>.NativeClassPtr, 100669699);
      TutorialBattleSystem2.PhasePlaceCompanion.NativeMethodInfoPtr__PromptAfter_b__4_0_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion>.NativeClassPtr, 100669700);
    }

    public PhasePlaceCompanion(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Entity target
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhasePlaceCompanion.NativeFieldInfoPtr_target));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhasePlaceCompanion.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("TutorialBattleSystem2/PhasePlaceCompanion/<PromptAfter>d__4")]
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
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &_param1
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(12611)]
      [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78669, XrefRangeEnd = 78676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78676, XrefRangeEnd = 78682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      static _PromptAfter_d__4()
      {
        Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion>.NativeClassPtr, "<PromptAfter>d__4");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr);
        TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr, "<>1__state");
        TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr, "<>2__current");
        TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr, nameof (delay));
        TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr, "<>4__this");
        TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr, 100669701);
        TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr, 100669702);
        TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr, 100669703);
        TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr, 100669704);
        TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr, 100669705);
        TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4>.NativeClassPtr, 100669706);
      }

      public _PromptAfter_d__4(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe Il2CppSystem.Object __2__current
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr___2__current));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float delay
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr_delay));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr_delay)) = value;
        }
      }

      public unsafe TutorialBattleSystem2.PhasePlaceCompanion __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (TutorialBattleSystem2.PhasePlaceCompanion) null : new TutorialBattleSystem2.PhasePlaceCompanion(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhasePlaceCompanion._PromptAfter_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  public class PhaseWait : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_turns;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_End_Private_Void_Int32_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78750, XrefRangeEnd = 78751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhaseWait(int turns)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWait>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &turns
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseWait.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78751, XrefRangeEnd = 78759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem2.PhaseWait.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78759, XrefRangeEnd = 78767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem2.PhaseWait.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void End(int turn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &turn
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseWait.NativeMethodInfoPtr_End_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PhaseWait()
    {
      Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWait>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem2>.NativeClassPtr, nameof (PhaseWait));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWait>.NativeClassPtr);
      TutorialBattleSystem2.PhaseWait.NativeFieldInfoPtr_turns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWait>.NativeClassPtr, nameof (turns));
      TutorialBattleSystem2.PhaseWait.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWait>.NativeClassPtr, 100669707);
      TutorialBattleSystem2.PhaseWait.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWait>.NativeClassPtr, 100669708);
      TutorialBattleSystem2.PhaseWait.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWait>.NativeClassPtr, 100669709);
      TutorialBattleSystem2.PhaseWait.NativeMethodInfoPtr_End_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWait>.NativeClassPtr, 100669710);
    }

    public PhaseWait(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int turns
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseWait.NativeFieldInfoPtr_turns));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseWait.NativeFieldInfoPtr_turns)) = value;
      }
    }
  }

  public class PhaseWaitDisallowRecall : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_turns;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsRecallAction_Private_Boolean_PlayAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEarlyDeployAction_Private_Boolean_PlayAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_End_Private_Void_Int32_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhaseWaitDisallowRecall(int turns)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWaitDisallowRecall>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &turns
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseWaitDisallowRecall.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78767, XrefRangeEnd = 78782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem2.PhaseWaitDisallowRecall.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78782, XrefRangeEnd = 78797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem2.PhaseWaitDisallowRecall.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78797, XrefRangeEnd = 78808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseWaitDisallowRecall.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref PlayAction local = ref action;
      System.IntPtr pointer = ptr;
      PlayAction playAction = pointer == System.IntPtr.Zero ? (PlayAction) null : new PlayAction(pointer);
      local = playAction;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78808, XrefRangeEnd = 78816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsRecallAction(PlayAction action)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseWaitDisallowRecall.NativeMethodInfoPtr_IsRecallAction_Private_Boolean_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78816, XrefRangeEnd = 78817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsEarlyDeployAction(PlayAction action)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseWaitDisallowRecall.NativeMethodInfoPtr_IsEarlyDeployAction_Private_Boolean_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void End(int turn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &turn
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseWaitDisallowRecall.NativeMethodInfoPtr_End_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PhaseWaitDisallowRecall()
    {
      Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWaitDisallowRecall>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem2>.NativeClassPtr, nameof (PhaseWaitDisallowRecall));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWaitDisallowRecall>.NativeClassPtr);
      TutorialBattleSystem2.PhaseWaitDisallowRecall.NativeFieldInfoPtr_turns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWaitDisallowRecall>.NativeClassPtr, nameof (turns));
      TutorialBattleSystem2.PhaseWaitDisallowRecall.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWaitDisallowRecall>.NativeClassPtr, 100669711);
      TutorialBattleSystem2.PhaseWaitDisallowRecall.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWaitDisallowRecall>.NativeClassPtr, 100669712);
      TutorialBattleSystem2.PhaseWaitDisallowRecall.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWaitDisallowRecall>.NativeClassPtr, 100669713);
      TutorialBattleSystem2.PhaseWaitDisallowRecall.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWaitDisallowRecall>.NativeClassPtr, 100669714);
      TutorialBattleSystem2.PhaseWaitDisallowRecall.NativeMethodInfoPtr_IsRecallAction_Private_Boolean_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWaitDisallowRecall>.NativeClassPtr, 100669715);
      TutorialBattleSystem2.PhaseWaitDisallowRecall.NativeMethodInfoPtr_IsEarlyDeployAction_Private_Boolean_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWaitDisallowRecall>.NativeClassPtr, 100669716);
      TutorialBattleSystem2.PhaseWaitDisallowRecall.NativeMethodInfoPtr_End_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseWaitDisallowRecall>.NativeClassPtr, 100669717);
    }

    public PhaseWaitDisallowRecall(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int turns
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseWaitDisallowRecall.NativeFieldInfoPtr_turns));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseWaitDisallowRecall.NativeFieldInfoPtr_turns)) = value;
      }
    }
  }

  public class PhaseMoveCompanionInFrontOfLeader : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_leader;
    private static readonly System.IntPtr NativeFieldInfoPtr_target;
    private static readonly System.IntPtr NativeFieldInfoPtr_leaderSlot;
    private static readonly System.IntPtr NativeFieldInfoPtr_targetSlot;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CorrectAction_Private_Boolean_PlayAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnEnable_b__5_0_Private_String_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 78819, RefRangeEnd = 78820, XrefRangeStart = 78817, XrefRangeEnd = 78819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhaseMoveCompanionInFrontOfLeader(Entity target)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeMethodInfoPtr__ctor_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78820, XrefRangeEnd = 78901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78901, XrefRangeEnd = 78917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78917, XrefRangeEnd = 78921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref PlayAction local = ref action;
      System.IntPtr pointer = ptr;
      PlayAction playAction = pointer == System.IntPtr.Zero ? (PlayAction) null : new PlayAction(pointer);
      local = playAction;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78921, XrefRangeEnd = 78922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ActionPerform(PlayAction action)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 78933, RefRangeEnd = 78935, XrefRangeStart = 78922, XrefRangeEnd = 78933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CorrectAction(PlayAction action)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeMethodInfoPtr_CorrectAction_Private_Boolean_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78935, XrefRangeEnd = 78943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _OnEnable_b__5_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeMethodInfoPtr__OnEnable_b__5_0_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static PhaseMoveCompanionInFrontOfLeader()
    {
      Il2CppClassPointerStore<TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem2>.NativeClassPtr, nameof (PhaseMoveCompanionInFrontOfLeader));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader>.NativeClassPtr);
      TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeFieldInfoPtr_leader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader>.NativeClassPtr, nameof (leader));
      TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader>.NativeClassPtr, nameof (target));
      TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeFieldInfoPtr_leaderSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader>.NativeClassPtr, nameof (leaderSlot));
      TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeFieldInfoPtr_targetSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader>.NativeClassPtr, nameof (targetSlot));
      TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeMethodInfoPtr__ctor_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader>.NativeClassPtr, 100669718);
      TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader>.NativeClassPtr, 100669719);
      TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader>.NativeClassPtr, 100669720);
      TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader>.NativeClassPtr, 100669721);
      TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader>.NativeClassPtr, 100669722);
      TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeMethodInfoPtr_CorrectAction_Private_Boolean_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader>.NativeClassPtr, 100669723);
      TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeMethodInfoPtr__OnEnable_b__5_0_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader>.NativeClassPtr, 100669724);
    }

    public PhaseMoveCompanionInFrontOfLeader(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Entity leader
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeFieldInfoPtr_leader));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeFieldInfoPtr_leader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity target
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeFieldInfoPtr_target));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CardSlot leaderSlot
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeFieldInfoPtr_leaderSlot));
        return pointer == System.IntPtr.Zero ? (CardSlot) null : new CardSlot(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeFieldInfoPtr_leaderSlot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CardSlot targetSlot
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeFieldInfoPtr_targetSlot));
        return pointer == System.IntPtr.Zero ? (CardSlot) null : new CardSlot(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseMoveCompanionInFrontOfLeader.NativeFieldInfoPtr_targetSlot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class PhaseBarrage : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_unitToMove;
    private static readonly System.IntPtr NativeFieldInfoPtr_chosenUnit;
    private static readonly System.IntPtr NativeFieldInfoPtr_barrageEnemy;
    private static readonly System.IntPtr NativeFieldInfoPtr_correctAction;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CorrectAction_Private_Boolean_PlayAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnEnable_b__5_2_Private_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnEnable_b__5_3_Private_String_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 78819, RefRangeEnd = 78820, XrefRangeStart = 78819, XrefRangeEnd = 78820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhaseBarrage(Entity chosenUnit)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) chosenUnit)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseBarrage.NativeMethodInfoPtr__ctor_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78967, XrefRangeEnd = 79050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem2.PhaseBarrage.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79050, XrefRangeEnd = 79066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem2.PhaseBarrage.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79066, XrefRangeEnd = 79080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseBarrage.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref PlayAction local = ref action;
      System.IntPtr pointer = ptr;
      PlayAction playAction = pointer == System.IntPtr.Zero ? (PlayAction) null : new PlayAction(pointer);
      local = playAction;
    }

    [CallerCount(0)]
    public unsafe void ActionPerform(PlayAction action)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseBarrage.NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79080, XrefRangeEnd = 79091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CorrectAction(PlayAction action)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseBarrage.NativeMethodInfoPtr_CorrectAction_Private_Boolean_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79091, XrefRangeEnd = 79100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _OnEnable_b__5_2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseBarrage.NativeMethodInfoPtr__OnEnable_b__5_2_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79100, XrefRangeEnd = 79109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _OnEnable_b__5_3()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseBarrage.NativeMethodInfoPtr__OnEnable_b__5_3_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static PhaseBarrage()
    {
      Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem2>.NativeClassPtr, nameof (PhaseBarrage));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage>.NativeClassPtr);
      TutorialBattleSystem2.PhaseBarrage.NativeFieldInfoPtr_unitToMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage>.NativeClassPtr, nameof (unitToMove));
      TutorialBattleSystem2.PhaseBarrage.NativeFieldInfoPtr_chosenUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage>.NativeClassPtr, nameof (chosenUnit));
      TutorialBattleSystem2.PhaseBarrage.NativeFieldInfoPtr_barrageEnemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage>.NativeClassPtr, nameof (barrageEnemy));
      TutorialBattleSystem2.PhaseBarrage.NativeFieldInfoPtr_correctAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage>.NativeClassPtr, nameof (correctAction));
      TutorialBattleSystem2.PhaseBarrage.NativeMethodInfoPtr__ctor_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage>.NativeClassPtr, 100669725);
      TutorialBattleSystem2.PhaseBarrage.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage>.NativeClassPtr, 100669726);
      TutorialBattleSystem2.PhaseBarrage.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage>.NativeClassPtr, 100669727);
      TutorialBattleSystem2.PhaseBarrage.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage>.NativeClassPtr, 100669728);
      TutorialBattleSystem2.PhaseBarrage.NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage>.NativeClassPtr, 100669729);
      TutorialBattleSystem2.PhaseBarrage.NativeMethodInfoPtr_CorrectAction_Private_Boolean_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage>.NativeClassPtr, 100669730);
      TutorialBattleSystem2.PhaseBarrage.NativeMethodInfoPtr__OnEnable_b__5_2_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage>.NativeClassPtr, 100669731);
      TutorialBattleSystem2.PhaseBarrage.NativeMethodInfoPtr__OnEnable_b__5_3_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage>.NativeClassPtr, 100669732);
    }

    public PhaseBarrage(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Entity unitToMove
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseBarrage.NativeFieldInfoPtr_unitToMove));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseBarrage.NativeFieldInfoPtr_unitToMove), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity chosenUnit
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseBarrage.NativeFieldInfoPtr_chosenUnit));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseBarrage.NativeFieldInfoPtr_chosenUnit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity barrageEnemy
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseBarrage.NativeFieldInfoPtr_barrageEnemy));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseBarrage.NativeFieldInfoPtr_barrageEnemy), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PlayAction correctAction
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseBarrage.NativeFieldInfoPtr_correctAction));
        return pointer == System.IntPtr.Zero ? (PlayAction) null : new PlayAction(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseBarrage.NativeFieldInfoPtr_correctAction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("TutorialBattleSystem2/PhaseBarrage/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__5_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__5_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnEnable_b__5_0_Internal_Boolean_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnEnable_b__5_1_Internal_Boolean_TraitStacks_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseBarrage.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78943, XrefRangeEnd = 78962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _OnEnable_b__5_0(Entity a)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
        };
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseBarrage.__c.NativeMethodInfoPtr__OnEnable_b__5_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78962, XrefRangeEnd = 78967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _OnEnable_b__5_1(CardData.TraitStacks t)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) t)
        };
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseBarrage.__c.NativeMethodInfoPtr__OnEnable_b__5_1_Internal_Boolean_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage.__c>.NativeClassPtr);
        TutorialBattleSystem2.PhaseBarrage.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage.__c>.NativeClassPtr, "<>9");
        TutorialBattleSystem2.PhaseBarrage.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage.__c>.NativeClassPtr, "<>9__5_1");
        TutorialBattleSystem2.PhaseBarrage.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage.__c>.NativeClassPtr, "<>9__5_0");
        TutorialBattleSystem2.PhaseBarrage.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage.__c>.NativeClassPtr, 100669734);
        TutorialBattleSystem2.PhaseBarrage.__c.NativeMethodInfoPtr__OnEnable_b__5_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage.__c>.NativeClassPtr, 100669735);
        TutorialBattleSystem2.PhaseBarrage.__c.NativeMethodInfoPtr__OnEnable_b__5_1_Internal_Boolean_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseBarrage.__c>.NativeClassPtr, 100669736);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe TutorialBattleSystem2.PhaseBarrage.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem2.PhaseBarrage.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (TutorialBattleSystem2.PhaseBarrage.__c) null : new TutorialBattleSystem2.PhaseBarrage.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem2.PhaseBarrage.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<CardData.TraitStacks, bool> __9__5_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem2.PhaseBarrage.__c.NativeFieldInfoPtr___9__5_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData.TraitStacks, bool>) null : new Il2CppSystem.Func<CardData.TraitStacks, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem2.PhaseBarrage.__c.NativeFieldInfoPtr___9__5_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<Entity, bool> __9__5_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem2.PhaseBarrage.__c.NativeFieldInfoPtr___9__5_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity, bool>) null : new Il2CppSystem.Func<Entity, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem2.PhaseBarrage.__c.NativeFieldInfoPtr___9__5_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  public class PhaseFreeMove : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HidePrompt_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_End_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IllegalAction_Private_Boolean_PlayAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79115, XrefRangeEnd = 79153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem2.PhaseFreeMove.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79153, XrefRangeEnd = 79174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem2.PhaseFreeMove.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79174, XrefRangeEnd = 79187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseFreeMove.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref PlayAction local = ref action;
      System.IntPtr pointer = ptr;
      PlayAction playAction = pointer == System.IntPtr.Zero ? (PlayAction) null : new PlayAction(pointer);
      local = playAction;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 40865, RefRangeEnd = 40866, XrefRangeStart = 40865, XrefRangeEnd = 40866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HidePrompt(int value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseFreeMove.NativeMethodInfoPtr_HidePrompt_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void End(int value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseFreeMove.NativeMethodInfoPtr_End_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79187, XrefRangeEnd = 79199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IllegalAction(PlayAction action)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseFreeMove.NativeMethodInfoPtr_IllegalAction_Private_Boolean_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhaseFreeMove()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseFreeMove>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseFreeMove.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PhaseFreeMove()
    {
      Il2CppClassPointerStore<TutorialBattleSystem2.PhaseFreeMove>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem2>.NativeClassPtr, nameof (PhaseFreeMove));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseFreeMove>.NativeClassPtr);
      TutorialBattleSystem2.PhaseFreeMove.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseFreeMove>.NativeClassPtr, 100669737);
      TutorialBattleSystem2.PhaseFreeMove.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseFreeMove>.NativeClassPtr, 100669738);
      TutorialBattleSystem2.PhaseFreeMove.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseFreeMove>.NativeClassPtr, 100669739);
      TutorialBattleSystem2.PhaseFreeMove.NativeMethodInfoPtr_HidePrompt_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseFreeMove>.NativeClassPtr, 100669740);
      TutorialBattleSystem2.PhaseFreeMove.NativeMethodInfoPtr_End_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseFreeMove>.NativeClassPtr, 100669741);
      TutorialBattleSystem2.PhaseFreeMove.NativeMethodInfoPtr_IllegalAction_Private_Boolean_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseFreeMove>.NativeClassPtr, 100669742);
      TutorialBattleSystem2.PhaseFreeMove.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseFreeMove>.NativeClassPtr, 100669743);
    }

    public PhaseFreeMove(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [ObfuscatedName("TutorialBattleSystem2/PhaseFreeMove/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnEnable_b__0_0_Internal_String_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseFreeMove.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseFreeMove.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79109, XrefRangeEnd = 79115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _OnEnable_b__0_0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseFreeMove.__c.NativeMethodInfoPtr__OnEnable_b__0_0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c()
      {
        Il2CppClassPointerStore<TutorialBattleSystem2.PhaseFreeMove.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseFreeMove>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseFreeMove.__c>.NativeClassPtr);
        TutorialBattleSystem2.PhaseFreeMove.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseFreeMove.__c>.NativeClassPtr, "<>9");
        TutorialBattleSystem2.PhaseFreeMove.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseFreeMove.__c>.NativeClassPtr, "<>9__0_0");
        TutorialBattleSystem2.PhaseFreeMove.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseFreeMove.__c>.NativeClassPtr, 100669745);
        TutorialBattleSystem2.PhaseFreeMove.__c.NativeMethodInfoPtr__OnEnable_b__0_0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseFreeMove.__c>.NativeClassPtr, 100669746);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe TutorialBattleSystem2.PhaseFreeMove.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem2.PhaseFreeMove.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (TutorialBattleSystem2.PhaseFreeMove.__c) null : new TutorialBattleSystem2.PhaseFreeMove.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem2.PhaseFreeMove.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Prompt.GetTextCallback __9__0_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem2.PhaseFreeMove.__c.NativeFieldInfoPtr___9__0_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Prompt.GetTextCallback) null : new Prompt.GetTextCallback(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem2.PhaseFreeMove.__c.NativeFieldInfoPtr___9__0_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  public class PhaseRecallToHeal : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_target;
    private static readonly System.IntPtr NativeFieldInfoPtr_disabledWaveDeploySystem;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CorrectAction_Private_Boolean_PlayAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DiscardHealAction_Private_Static_Boolean_PlayAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnEnable_b__3_0_Private_String_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 77793, RefRangeEnd = 77796, XrefRangeStart = 77793, XrefRangeEnd = 77796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhaseRecallToHeal(Entity target)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallToHeal>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseRecallToHeal.NativeMethodInfoPtr__ctor_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79199, XrefRangeEnd = 79230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem2.PhaseRecallToHeal.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79230, XrefRangeEnd = 79250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem2.PhaseRecallToHeal.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79250, XrefRangeEnd = 79260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseRecallToHeal.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref PlayAction local = ref action;
      System.IntPtr pointer = ptr;
      PlayAction playAction = pointer == System.IntPtr.Zero ? (PlayAction) null : new PlayAction(pointer);
      local = playAction;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79260, XrefRangeEnd = 79261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ActionPerform(PlayAction action)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseRecallToHeal.NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 79272, RefRangeEnd = 79274, XrefRangeStart = 79261, XrefRangeEnd = 79272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CorrectAction(PlayAction action)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseRecallToHeal.NativeMethodInfoPtr_CorrectAction_Private_Boolean_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79274, XrefRangeEnd = 79275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool DiscardHealAction(PlayAction action)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseRecallToHeal.NativeMethodInfoPtr_DiscardHealAction_Private_Static_Boolean_PlayAction_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79275, XrefRangeEnd = 79283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _OnEnable_b__3_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseRecallToHeal.NativeMethodInfoPtr__OnEnable_b__3_0_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static PhaseRecallToHeal()
    {
      Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallToHeal>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem2>.NativeClassPtr, nameof (PhaseRecallToHeal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallToHeal>.NativeClassPtr);
      TutorialBattleSystem2.PhaseRecallToHeal.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallToHeal>.NativeClassPtr, nameof (target));
      TutorialBattleSystem2.PhaseRecallToHeal.NativeFieldInfoPtr_disabledWaveDeploySystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallToHeal>.NativeClassPtr, nameof (disabledWaveDeploySystem));
      TutorialBattleSystem2.PhaseRecallToHeal.NativeMethodInfoPtr__ctor_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallToHeal>.NativeClassPtr, 100669747);
      TutorialBattleSystem2.PhaseRecallToHeal.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallToHeal>.NativeClassPtr, 100669748);
      TutorialBattleSystem2.PhaseRecallToHeal.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallToHeal>.NativeClassPtr, 100669749);
      TutorialBattleSystem2.PhaseRecallToHeal.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallToHeal>.NativeClassPtr, 100669750);
      TutorialBattleSystem2.PhaseRecallToHeal.NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallToHeal>.NativeClassPtr, 100669751);
      TutorialBattleSystem2.PhaseRecallToHeal.NativeMethodInfoPtr_CorrectAction_Private_Boolean_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallToHeal>.NativeClassPtr, 100669752);
      TutorialBattleSystem2.PhaseRecallToHeal.NativeMethodInfoPtr_DiscardHealAction_Private_Static_Boolean_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallToHeal>.NativeClassPtr, 100669753);
      TutorialBattleSystem2.PhaseRecallToHeal.NativeMethodInfoPtr__OnEnable_b__3_0_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallToHeal>.NativeClassPtr, 100669754);
    }

    public PhaseRecallToHeal(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Entity target
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseRecallToHeal.NativeFieldInfoPtr_target));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseRecallToHeal.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WaveDeploySystemOverflow disabledWaveDeploySystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseRecallToHeal.NativeFieldInfoPtr_disabledWaveDeploySystem));
        return pointer == System.IntPtr.Zero ? (WaveDeploySystemOverflow) null : new WaveDeploySystemOverflow(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.PhaseRecallToHeal.NativeFieldInfoPtr_disabledWaveDeploySystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class PhaseRecallFree : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_End_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79289, XrefRangeEnd = 79331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem2.PhaseRecallFree.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79331, XrefRangeEnd = 79352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem2.PhaseRecallFree.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79352, XrefRangeEnd = 79355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseRecallFree.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref PlayAction local = ref action;
      System.IntPtr pointer = ptr;
      PlayAction playAction = pointer == System.IntPtr.Zero ? (PlayAction) null : new PlayAction(pointer);
      local = playAction;
    }

    [CallerCount(0)]
    public unsafe void End(int value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseRecallFree.NativeMethodInfoPtr_End_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhaseRecallFree()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallFree>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseRecallFree.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PhaseRecallFree()
    {
      Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallFree>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem2>.NativeClassPtr, nameof (PhaseRecallFree));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallFree>.NativeClassPtr);
      TutorialBattleSystem2.PhaseRecallFree.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallFree>.NativeClassPtr, 100669755);
      TutorialBattleSystem2.PhaseRecallFree.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallFree>.NativeClassPtr, 100669756);
      TutorialBattleSystem2.PhaseRecallFree.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallFree>.NativeClassPtr, 100669757);
      TutorialBattleSystem2.PhaseRecallFree.NativeMethodInfoPtr_End_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallFree>.NativeClassPtr, 100669758);
      TutorialBattleSystem2.PhaseRecallFree.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallFree>.NativeClassPtr, 100669759);
    }

    public PhaseRecallFree(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [ObfuscatedName("TutorialBattleSystem2/PhaseRecallFree/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnEnable_b__0_0_Internal_String_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallFree.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseRecallFree.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79283, XrefRangeEnd = 79289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _OnEnable_b__0_0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.PhaseRecallFree.__c.NativeMethodInfoPtr__OnEnable_b__0_0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c()
      {
        Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallFree.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallFree>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallFree.__c>.NativeClassPtr);
        TutorialBattleSystem2.PhaseRecallFree.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallFree.__c>.NativeClassPtr, "<>9");
        TutorialBattleSystem2.PhaseRecallFree.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallFree.__c>.NativeClassPtr, "<>9__0_0");
        TutorialBattleSystem2.PhaseRecallFree.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallFree.__c>.NativeClassPtr, 100669761);
        TutorialBattleSystem2.PhaseRecallFree.__c.NativeMethodInfoPtr__OnEnable_b__0_0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.PhaseRecallFree.__c>.NativeClassPtr, 100669762);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe TutorialBattleSystem2.PhaseRecallFree.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem2.PhaseRecallFree.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (TutorialBattleSystem2.PhaseRecallFree.__c) null : new TutorialBattleSystem2.PhaseRecallFree.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem2.PhaseRecallFree.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Prompt.GetTextCallback __9__0_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem2.PhaseRecallFree.__c.NativeFieldInfoPtr___9__0_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Prompt.GetTextCallback) null : new Prompt.GetTextCallback(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem2.PhaseRecallFree.__c.NativeFieldInfoPtr___9__0_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  [ObfuscatedName("TutorialBattleSystem2/<>c__DisplayClass3_0")]
  public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_chosenUnitData;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__FindChosenUnit_b__1_Internal_Boolean_Entity_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass3_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem2.__c__DisplayClass3_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _FindChosenUnit_b__1(Entity a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.__c__DisplayClass3_0.NativeMethodInfoPtr__FindChosenUnit_b__1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass3_0()
    {
      Il2CppClassPointerStore<TutorialBattleSystem2.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem2>.NativeClassPtr, "<>c__DisplayClass3_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem2.__c__DisplayClass3_0>.NativeClassPtr);
      TutorialBattleSystem2.__c__DisplayClass3_0.NativeFieldInfoPtr_chosenUnitData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.__c__DisplayClass3_0>.NativeClassPtr, nameof (chosenUnitData));
      TutorialBattleSystem2.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.__c__DisplayClass3_0>.NativeClassPtr, 100669763);
      TutorialBattleSystem2.__c__DisplayClass3_0.NativeMethodInfoPtr__FindChosenUnit_b__1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.__c__DisplayClass3_0>.NativeClassPtr, 100669764);
    }

    public __c__DisplayClass3_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CardData chosenUnitData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.__c__DisplayClass3_0.NativeFieldInfoPtr_chosenUnitData));
        return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem2.__c__DisplayClass3_0.NativeFieldInfoPtr_chosenUnitData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("TutorialBattleSystem2/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__FindChosenUnit_b__3_0_Internal_Boolean_CardData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem2.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _FindChosenUnit_b__3_0(CardData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem2.__c.NativeMethodInfoPtr__FindChosenUnit_b__3_0_Internal_Boolean_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<TutorialBattleSystem2.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem2>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem2.__c>.NativeClassPtr);
      TutorialBattleSystem2.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.__c>.NativeClassPtr, "<>9");
      TutorialBattleSystem2.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem2.__c>.NativeClassPtr, "<>9__3_0");
      TutorialBattleSystem2.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.__c>.NativeClassPtr, 100669766);
      TutorialBattleSystem2.__c.NativeMethodInfoPtr__FindChosenUnit_b__3_0_Internal_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem2.__c>.NativeClassPtr, 100669767);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe TutorialBattleSystem2.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem2.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (TutorialBattleSystem2.__c) null : new TutorialBattleSystem2.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem2.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData, bool> __9__3_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem2.__c.NativeFieldInfoPtr___9__3_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData, bool>) null : new Il2CppSystem.Func<CardData, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem2.__c.NativeFieldInfoPtr___9__3_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
