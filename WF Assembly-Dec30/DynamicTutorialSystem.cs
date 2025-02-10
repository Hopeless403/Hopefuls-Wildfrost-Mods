// Decompiled with JetBrains decompiler
// Type: DynamicTutorialSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class DynamicTutorialSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_redrawTutorial;
  private static readonly System.IntPtr NativeFieldInfoPtr_moveTutorial;
  private static readonly System.IntPtr NativeFieldInfoPtr_recallTutorial;
  private static readonly System.IntPtr NativeFieldInfoPtr_aimlessTutorial;
  private static readonly System.IntPtr NativeFieldInfoPtr_reactionTutorial;
  private static readonly System.IntPtr NativeFieldInfoPtr_tutorials;
  private static readonly System.IntPtr NativeFieldInfoPtr_aimlessTutorialDone;
  private static readonly System.IntPtr NativeFieldInfoPtr_reactionTutorialDone;
  private static readonly System.IntPtr NativeFieldInfoPtr_aimlessEnemy;
  private static readonly System.IntPtr NativeFieldInfoPtr_reactionEnemy;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityPlace_Private_Void_Entity_Il2CppReferenceArray_1_CardContainer_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Discard_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RedrawBellHit_Private_Void_RedrawBellSystem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TurnStart_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TurnEnd_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckAimlessTutorial_Private_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckReactionTutorial_Private_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckRecallTutorial_Private_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckRedrawTutorial_Private_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckMoveTutorial_Private_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Save_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77298, XrefRangeEnd = 77379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77379, XrefRangeEnd = 77421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77421, XrefRangeEnd = 77424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityPlace(
    Entity entity,
    Il2CppReferenceArray<CardContainer> slots,
    bool freeMove)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) slots);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &freeMove;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.NativeMethodInfoPtr_EntityPlace_Private_Void_Entity_Il2CppReferenceArray_1_CardContainer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77424, XrefRangeEnd = 77425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Discard(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.NativeMethodInfoPtr_Discard_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77425, XrefRangeEnd = 77427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RedrawBellHit(RedrawBellSystem redrawBellSystem)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) redrawBellSystem)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.NativeMethodInfoPtr_RedrawBellHit_Private_Void_RedrawBellSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77427, XrefRangeEnd = 77429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TurnStart(int turnCount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &turnCount
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.NativeMethodInfoPtr_TurnStart_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77429, XrefRangeEnd = 77439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TurnEnd(int turnCount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &turnCount
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.NativeMethodInfoPtr_TurnEnd_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 77483, RefRangeEnd = 77484, XrefRangeStart = 77439, XrefRangeEnd = 77483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckAimlessTutorial(int turnCount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &turnCount
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.NativeMethodInfoPtr_CheckAimlessTutorial_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 77526, RefRangeEnd = 77527, XrefRangeStart = 77484, XrefRangeEnd = 77526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckReactionTutorial(int turnCount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &turnCount
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.NativeMethodInfoPtr_CheckReactionTutorial_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 77550, RefRangeEnd = 77551, XrefRangeStart = 77527, XrefRangeEnd = 77550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckRecallTutorial()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.NativeMethodInfoPtr_CheckRecallTutorial_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 77582, RefRangeEnd = 77583, XrefRangeStart = 77551, XrefRangeEnd = 77582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckRedrawTutorial()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.NativeMethodInfoPtr_CheckRedrawTutorial_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 77625, RefRangeEnd = 77626, XrefRangeStart = 77583, XrefRangeEnd = 77625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckMoveTutorial()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.NativeMethodInfoPtr_CheckMoveTutorial_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77626, XrefRangeEnd = 77628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Save()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.NativeMethodInfoPtr_Save_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DynamicTutorialSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static DynamicTutorialSystem()
  {
    Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (DynamicTutorialSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr);
    DynamicTutorialSystem.NativeFieldInfoPtr_redrawTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, nameof (redrawTutorial));
    DynamicTutorialSystem.NativeFieldInfoPtr_moveTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, nameof (moveTutorial));
    DynamicTutorialSystem.NativeFieldInfoPtr_recallTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, nameof (recallTutorial));
    DynamicTutorialSystem.NativeFieldInfoPtr_aimlessTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, nameof (aimlessTutorial));
    DynamicTutorialSystem.NativeFieldInfoPtr_reactionTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, nameof (reactionTutorial));
    DynamicTutorialSystem.NativeFieldInfoPtr_tutorials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, nameof (tutorials));
    DynamicTutorialSystem.NativeFieldInfoPtr_aimlessTutorialDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, nameof (aimlessTutorialDone));
    DynamicTutorialSystem.NativeFieldInfoPtr_reactionTutorialDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, nameof (reactionTutorialDone));
    DynamicTutorialSystem.NativeFieldInfoPtr_aimlessEnemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, nameof (aimlessEnemy));
    DynamicTutorialSystem.NativeFieldInfoPtr_reactionEnemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, nameof (reactionEnemy));
    DynamicTutorialSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, 100669507);
    DynamicTutorialSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, 100669508);
    DynamicTutorialSystem.NativeMethodInfoPtr_EntityPlace_Private_Void_Entity_Il2CppReferenceArray_1_CardContainer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, 100669509);
    DynamicTutorialSystem.NativeMethodInfoPtr_Discard_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, 100669510);
    DynamicTutorialSystem.NativeMethodInfoPtr_RedrawBellHit_Private_Void_RedrawBellSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, 100669511);
    DynamicTutorialSystem.NativeMethodInfoPtr_TurnStart_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, 100669512);
    DynamicTutorialSystem.NativeMethodInfoPtr_TurnEnd_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, 100669513);
    DynamicTutorialSystem.NativeMethodInfoPtr_CheckAimlessTutorial_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, 100669514);
    DynamicTutorialSystem.NativeMethodInfoPtr_CheckReactionTutorial_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, 100669515);
    DynamicTutorialSystem.NativeMethodInfoPtr_CheckRecallTutorial_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, 100669516);
    DynamicTutorialSystem.NativeMethodInfoPtr_CheckRedrawTutorial_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, 100669517);
    DynamicTutorialSystem.NativeMethodInfoPtr_CheckMoveTutorial_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, 100669518);
    DynamicTutorialSystem.NativeMethodInfoPtr_Save_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, 100669519);
    DynamicTutorialSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, 100669520);
  }

  public DynamicTutorialSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe DynamicTutorialSystem.Tutorial redrawTutorial
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.NativeFieldInfoPtr_redrawTutorial));
      return pointer == System.IntPtr.Zero ? (DynamicTutorialSystem.Tutorial) null : new DynamicTutorialSystem.Tutorial(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.NativeFieldInfoPtr_redrawTutorial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DynamicTutorialSystem.Tutorial moveTutorial
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.NativeFieldInfoPtr_moveTutorial));
      return pointer == System.IntPtr.Zero ? (DynamicTutorialSystem.Tutorial) null : new DynamicTutorialSystem.Tutorial(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.NativeFieldInfoPtr_moveTutorial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DynamicTutorialSystem.Tutorial recallTutorial
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.NativeFieldInfoPtr_recallTutorial));
      return pointer == System.IntPtr.Zero ? (DynamicTutorialSystem.Tutorial) null : new DynamicTutorialSystem.Tutorial(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.NativeFieldInfoPtr_recallTutorial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DynamicTutorialSystem.Tutorial aimlessTutorial
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.NativeFieldInfoPtr_aimlessTutorial));
      return pointer == System.IntPtr.Zero ? (DynamicTutorialSystem.Tutorial) null : new DynamicTutorialSystem.Tutorial(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.NativeFieldInfoPtr_aimlessTutorial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DynamicTutorialSystem.Tutorial reactionTutorial
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.NativeFieldInfoPtr_reactionTutorial));
      return pointer == System.IntPtr.Zero ? (DynamicTutorialSystem.Tutorial) null : new DynamicTutorialSystem.Tutorial(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.NativeFieldInfoPtr_reactionTutorial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<DynamicTutorialSystem.Tutorial> tutorials
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.NativeFieldInfoPtr_tutorials));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<DynamicTutorialSystem.Tutorial>) null : new Il2CppReferenceArray<DynamicTutorialSystem.Tutorial>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.NativeFieldInfoPtr_tutorials), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool aimlessTutorialDone
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.NativeFieldInfoPtr_aimlessTutorialDone));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.NativeFieldInfoPtr_aimlessTutorialDone)) = value;
    }
  }

  public unsafe bool reactionTutorialDone
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.NativeFieldInfoPtr_reactionTutorialDone));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.NativeFieldInfoPtr_reactionTutorialDone)) = value;
    }
  }

  public unsafe Entity aimlessEnemy
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.NativeFieldInfoPtr_aimlessEnemy));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.NativeFieldInfoPtr_aimlessEnemy), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Entity reactionEnemy
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.NativeFieldInfoPtr_reactionEnemy));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.NativeFieldInfoPtr_reactionEnemy), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class Tutorial : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_onlyShowOnce;
    private static readonly System.IntPtr NativeFieldInfoPtr_turnsRequired;
    private static readonly System.IntPtr NativeFieldInfoPtr_resetOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_saveString;
    private static readonly System.IntPtr NativeFieldInfoPtr_stringRef;
    private static readonly System.IntPtr NativeFieldInfoPtr_promptAnchor;
    private static readonly System.IntPtr NativeFieldInfoPtr_promptPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_promptWidth;
    private static readonly System.IntPtr NativeFieldInfoPtr_promptEmote;
    private static readonly System.IntPtr NativeFieldInfoPtr_flipEmote;
    private static readonly System.IntPtr NativeFieldInfoPtr__current_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__currentBool_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__shown_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__actionDoneThisTurn_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_current_Private_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_current_Private_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_currentBool_Private_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_currentBool_Private_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_shown_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_shown_Private_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_actionDoneThisTurn_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_actionDoneThisTurn_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResetCount_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckIncreaseCount_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Check_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Void_Il2CppReferenceArray_1_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe int current
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 31402, RefRangeEnd = 31405, XrefRangeStart = 31402, XrefRangeEnd = 31405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_get_current_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_set_current_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool currentBool
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_get_currentBool_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_set_currentBool_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool shown
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_get_shown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_set_shown_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool actionDoneThisTurn
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_get_actionDoneThisTurn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_set_actionDoneThisTurn_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 77201, RefRangeEnd = 77204, XrefRangeStart = 77200, XrefRangeEnd = 77201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ResetCount()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_ResetCount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 77210, RefRangeEnd = 77211, XrefRangeStart = 77204, XrefRangeEnd = 77210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Load()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_Load_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 77217, RefRangeEnd = 77218, XrefRangeStart = 77211, XrefRangeEnd = 77217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Save()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_Save_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 77218, RefRangeEnd = 77219, XrefRangeStart = 77218, XrefRangeEnd = 77218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckIncreaseCount()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_CheckIncreaseCount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 77219, RefRangeEnd = 77222, XrefRangeStart = 77219, XrefRangeEnd = 77219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Check()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_Check_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 77242, RefRangeEnd = 77247, XrefRangeStart = 77222, XrefRangeEnd = 77242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Show([Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
    {
      if (args == null)
        args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_Show_Public_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 77248, RefRangeEnd = 77249, XrefRangeStart = 77247, XrefRangeEnd = 77248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Hide()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77249, XrefRangeEnd = 77250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Tutorial()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public void Show(params Il2CppSystem.Object[] args)
    {
      this.Show(new Il2CppReferenceArray<Il2CppSystem.Object>(args));
    }

    static Tutorial()
    {
      Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, nameof (Tutorial));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr);
      DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_onlyShowOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, nameof (onlyShowOnce));
      DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_turnsRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, nameof (turnsRequired));
      DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_resetOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, nameof (resetOffset));
      DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_saveString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, nameof (saveString));
      DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_stringRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, nameof (stringRef));
      DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_promptAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, nameof (promptAnchor));
      DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_promptPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, nameof (promptPosition));
      DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_promptWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, nameof (promptWidth));
      DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_promptEmote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, nameof (promptEmote));
      DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_flipEmote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, nameof (flipEmote));
      DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr__current_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, "<current>k__BackingField");
      DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr__currentBool_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, "<currentBool>k__BackingField");
      DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr__shown_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, "<shown>k__BackingField");
      DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr__actionDoneThisTurn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, "<actionDoneThisTurn>k__BackingField");
      DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_get_current_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, 100669521);
      DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_set_current_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, 100669522);
      DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_get_currentBool_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, 100669523);
      DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_set_currentBool_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, 100669524);
      DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_get_shown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, 100669525);
      DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_set_shown_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, 100669526);
      DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_get_actionDoneThisTurn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, 100669527);
      DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_set_actionDoneThisTurn_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, 100669528);
      DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_ResetCount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, 100669529);
      DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_Load_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, 100669530);
      DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_Save_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, 100669531);
      DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_CheckIncreaseCount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, 100669532);
      DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_Check_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, 100669533);
      DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_Show_Public_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, 100669534);
      DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, 100669535);
      DynamicTutorialSystem.Tutorial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, 100669536);
    }

    public Tutorial(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool onlyShowOnce
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_onlyShowOnce));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_onlyShowOnce)) = value;
      }
    }

    public unsafe int turnsRequired
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_turnsRequired));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_turnsRequired)) = value;
      }
    }

    public unsafe int resetOffset
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_resetOffset));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_resetOffset)) = value;
      }
    }

    public unsafe string saveString
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_saveString)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_saveString), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe LocalizedString stringRef
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_stringRef));
        return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_stringRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Prompt.Anchor promptAnchor
    {
      get
      {
        return *(Prompt.Anchor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_promptAnchor));
      }
      [param: In] set
      {
        *(Prompt.Anchor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_promptAnchor)) = value;
      }
    }

    public unsafe Vector2 promptPosition
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_promptPosition));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_promptPosition)) = value;
      }
    }

    public unsafe float promptWidth
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_promptWidth));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_promptWidth)) = value;
      }
    }

    public unsafe Prompt.Emote.Type promptEmote
    {
      get
      {
        return *(Prompt.Emote.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_promptEmote));
      }
      [param: In] set
      {
        *(Prompt.Emote.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_promptEmote)) = value;
      }
    }

    public unsafe int flipEmote
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_flipEmote));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr_flipEmote)) = value;
      }
    }

    public unsafe int _current_k__BackingField
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr__current_k__BackingField));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr__current_k__BackingField)) = value;
      }
    }

    public unsafe bool _currentBool_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr__currentBool_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr__currentBool_k__BackingField)) = value;
      }
    }

    public unsafe bool _shown_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr__shown_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr__shown_k__BackingField)) = value;
      }
    }

    public unsafe bool _actionDoneThisTurn_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr__actionDoneThisTurn_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.NativeFieldInfoPtr__actionDoneThisTurn_k__BackingField)) = value;
      }
    }

    [ObfuscatedName("DynamicTutorialSystem/Tutorial/<>c__DisplayClass31_0")]
    public sealed class __c__DisplayClass31_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_args;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Show_b__0_Internal_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Show_b__1_Internal_String_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass31_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial.__c__DisplayClass31_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.Tutorial.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77195, XrefRangeEnd = 77198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _Show_b__0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.Tutorial.__c__DisplayClass31_0.NativeMethodInfoPtr__Show_b__0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77198, XrefRangeEnd = 77200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _Show_b__1()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.Tutorial.__c__DisplayClass31_0.NativeMethodInfoPtr__Show_b__1_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c__DisplayClass31_0()
      {
        Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial>.NativeClassPtr, "<>c__DisplayClass31_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial.__c__DisplayClass31_0>.NativeClassPtr);
        DynamicTutorialSystem.Tutorial.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial.__c__DisplayClass31_0>.NativeClassPtr, "<>4__this");
        DynamicTutorialSystem.Tutorial.__c__DisplayClass31_0.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial.__c__DisplayClass31_0>.NativeClassPtr, nameof (args));
        DynamicTutorialSystem.Tutorial.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial.__c__DisplayClass31_0>.NativeClassPtr, 100669537);
        DynamicTutorialSystem.Tutorial.__c__DisplayClass31_0.NativeMethodInfoPtr__Show_b__0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial.__c__DisplayClass31_0>.NativeClassPtr, 100669538);
        DynamicTutorialSystem.Tutorial.__c__DisplayClass31_0.NativeMethodInfoPtr__Show_b__1_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.Tutorial.__c__DisplayClass31_0>.NativeClassPtr, 100669539);
      }

      public __c__DisplayClass31_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe DynamicTutorialSystem.Tutorial __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DynamicTutorialSystem.Tutorial) null : new DynamicTutorialSystem.Tutorial(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<Il2CppSystem.Object> args
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.__c__DisplayClass31_0.NativeFieldInfoPtr_args));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Object>) null : new Il2CppReferenceArray<Il2CppSystem.Object>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DynamicTutorialSystem.Tutorial.__c__DisplayClass31_0.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  [ObfuscatedName("DynamicTutorialSystem/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__17_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__17_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__18_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__18_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__21_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CheckAimlessTutorial_b__17_0_Internal_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CheckAimlessTutorial_b__17_1_Internal_Boolean_TraitStacks_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CheckReactionTutorial_b__18_0_Internal_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CheckReactionTutorial_b__18_1_Internal_Boolean_StatusEffectData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CheckMoveTutorial_b__21_0_Internal_Boolean_StatusEffectData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicTutorialSystem.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77250, XrefRangeEnd = 77269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _CheckAimlessTutorial_b__17_0(Entity a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.__c.NativeMethodInfoPtr__CheckAimlessTutorial_b__17_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77269, XrefRangeEnd = 77274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _CheckAimlessTutorial_b__17_1(CardData.TraitStacks t)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) t)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.__c.NativeMethodInfoPtr__CheckAimlessTutorial_b__17_1_Internal_Boolean_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77274, XrefRangeEnd = 77293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _CheckReactionTutorial_b__18_0(Entity a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.__c.NativeMethodInfoPtr__CheckReactionTutorial_b__18_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool _CheckReactionTutorial_b__18_1(StatusEffectData s)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) s)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.__c.NativeMethodInfoPtr__CheckReactionTutorial_b__18_1_Internal_Boolean_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77293, XrefRangeEnd = 77298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _CheckMoveTutorial_b__21_0(StatusEffectData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicTutorialSystem.__c.NativeMethodInfoPtr__CheckMoveTutorial_b__21_0_Internal_Boolean_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<DynamicTutorialSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicTutorialSystem>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicTutorialSystem.__c>.NativeClassPtr);
      DynamicTutorialSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem.__c>.NativeClassPtr, "<>9");
      DynamicTutorialSystem.__c.NativeFieldInfoPtr___9__17_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem.__c>.NativeClassPtr, "<>9__17_1");
      DynamicTutorialSystem.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem.__c>.NativeClassPtr, "<>9__17_0");
      DynamicTutorialSystem.__c.NativeFieldInfoPtr___9__18_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem.__c>.NativeClassPtr, "<>9__18_1");
      DynamicTutorialSystem.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem.__c>.NativeClassPtr, "<>9__18_0");
      DynamicTutorialSystem.__c.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicTutorialSystem.__c>.NativeClassPtr, "<>9__21_0");
      DynamicTutorialSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.__c>.NativeClassPtr, 100669541);
      DynamicTutorialSystem.__c.NativeMethodInfoPtr__CheckAimlessTutorial_b__17_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.__c>.NativeClassPtr, 100669542);
      DynamicTutorialSystem.__c.NativeMethodInfoPtr__CheckAimlessTutorial_b__17_1_Internal_Boolean_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.__c>.NativeClassPtr, 100669543);
      DynamicTutorialSystem.__c.NativeMethodInfoPtr__CheckReactionTutorial_b__18_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.__c>.NativeClassPtr, 100669544);
      DynamicTutorialSystem.__c.NativeMethodInfoPtr__CheckReactionTutorial_b__18_1_Internal_Boolean_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.__c>.NativeClassPtr, 100669545);
      DynamicTutorialSystem.__c.NativeMethodInfoPtr__CheckMoveTutorial_b__21_0_Internal_Boolean_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicTutorialSystem.__c>.NativeClassPtr, 100669546);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe DynamicTutorialSystem.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(DynamicTutorialSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (DynamicTutorialSystem.__c) null : new DynamicTutorialSystem.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DynamicTutorialSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData.TraitStacks, bool> __9__17_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(DynamicTutorialSystem.__c.NativeFieldInfoPtr___9__17_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData.TraitStacks, bool>) null : new Il2CppSystem.Func<CardData.TraitStacks, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DynamicTutorialSystem.__c.NativeFieldInfoPtr___9__17_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Entity, bool> __9__17_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(DynamicTutorialSystem.__c.NativeFieldInfoPtr___9__17_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity, bool>) null : new Il2CppSystem.Func<Entity, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DynamicTutorialSystem.__c.NativeFieldInfoPtr___9__17_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<StatusEffectData, bool> __9__18_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(DynamicTutorialSystem.__c.NativeFieldInfoPtr___9__18_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<StatusEffectData, bool>) null : new Il2CppSystem.Func<StatusEffectData, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DynamicTutorialSystem.__c.NativeFieldInfoPtr___9__18_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Entity, bool> __9__18_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(DynamicTutorialSystem.__c.NativeFieldInfoPtr___9__18_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity, bool>) null : new Il2CppSystem.Func<Entity, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DynamicTutorialSystem.__c.NativeFieldInfoPtr___9__18_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<StatusEffectData, bool> __9__21_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(DynamicTutorialSystem.__c.NativeFieldInfoPtr___9__21_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<StatusEffectData, bool>) null : new Il2CppSystem.Func<StatusEffectData, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DynamicTutorialSystem.__c.NativeFieldInfoPtr___9__21_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
