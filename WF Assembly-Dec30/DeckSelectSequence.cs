// Decompiled with JetBrains decompiler
// Type: DeckSelectSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
public class DeckSelectSequence : UISequence
{
  private static readonly System.IntPtr NativeFieldInfoPtr_onEnable;
  private static readonly System.IntPtr NativeFieldInfoPtr_onDisable;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardHolder;
  private static readonly System.IntPtr NativeFieldInfoPtr_fade;
  private static readonly System.IntPtr NativeFieldInfoPtr_fadeInTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_fadeOutTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardSelector;
  private static readonly System.IntPtr NativeFieldInfoPtr_renameSequence;
  private static readonly System.IntPtr NativeFieldInfoPtr_crownHolder;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttonGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttonShowTween;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttonHideTween;
  private static readonly System.IntPtr NativeFieldInfoPtr_renameButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_takeCrownButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_moveDownButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_moveDownButtonButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_moveUpButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_moveUpButtonButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_entityScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_moveWobble;
  private static readonly System.IntPtr NativeFieldInfoPtr_moveCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_moveDur;
  private static readonly System.IntPtr NativeFieldInfoPtr_entity;
  private static readonly System.IntPtr NativeFieldInfoPtr_entityPreParent;
  private static readonly System.IntPtr NativeFieldInfoPtr_promptRename;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetEntity_Public_Void_Entity_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityHasRemovableCrown_Private_Static_Boolean_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddMoveDown_Public_Void_UnityAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddMoveUp_Public_Void_UnityAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rename_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TakeCrown_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_End_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__AddMoveDown_b__27_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__AddMoveUp_b__28_0_Private_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 98118, RefRangeEnd = 98119, XrefRangeStart = 98093, XrefRangeEnd = 98118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetEntity(Entity entity, bool canRename = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &canRename;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeckSelectSequence.NativeMethodInfoPtr_SetEntity_Public_Void_Entity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98119, XrefRangeEnd = 98124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool EntityHasRemovableCrown(CardData cardData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DeckSelectSequence.NativeMethodInfoPtr_EntityHasRemovableCrown_Private_Static_Boolean_CardData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 98135, RefRangeEnd = 98136, XrefRangeStart = 98124, XrefRangeEnd = 98135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddMoveDown(UnityAction callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeckSelectSequence.NativeMethodInfoPtr_AddMoveDown_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 98147, RefRangeEnd = 98148, XrefRangeStart = 98136, XrefRangeEnd = 98147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddMoveUp(UnityAction callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeckSelectSequence.NativeMethodInfoPtr_AddMoveUp_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void Rename()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeckSelectSequence.NativeMethodInfoPtr_Rename_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98148, XrefRangeEnd = 98159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TakeCrown()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeckSelectSequence.NativeMethodInfoPtr_TakeCrown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 66591, RefRangeEnd = 66605, XrefRangeStart = 66591, XrefRangeEnd = 66605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void End()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DeckSelectSequence.NativeMethodInfoPtr_End_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98159, XrefRangeEnd = 98164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator Run()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DeckSelectSequence.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98164, XrefRangeEnd = 98165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DeckSelectSequence()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeckSelectSequence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98165, XrefRangeEnd = 98166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _AddMoveDown_b__27_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeckSelectSequence.NativeMethodInfoPtr__AddMoveDown_b__27_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _AddMoveUp_b__28_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeckSelectSequence.NativeMethodInfoPtr__AddMoveUp_b__28_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static DeckSelectSequence()
  {
    Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (DeckSelectSequence));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr);
    DeckSelectSequence.NativeFieldInfoPtr_onEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (onEnable));
    DeckSelectSequence.NativeFieldInfoPtr_onDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (onDisable));
    DeckSelectSequence.NativeFieldInfoPtr_cardHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (cardHolder));
    DeckSelectSequence.NativeFieldInfoPtr_fade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (fade));
    DeckSelectSequence.NativeFieldInfoPtr_fadeInTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (fadeInTime));
    DeckSelectSequence.NativeFieldInfoPtr_fadeOutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (fadeOutTime));
    DeckSelectSequence.NativeFieldInfoPtr_cardSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (cardSelector));
    DeckSelectSequence.NativeFieldInfoPtr_renameSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (renameSequence));
    DeckSelectSequence.NativeFieldInfoPtr_crownHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (crownHolder));
    DeckSelectSequence.NativeFieldInfoPtr_buttonGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (buttonGroup));
    DeckSelectSequence.NativeFieldInfoPtr_buttonShowTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (buttonShowTween));
    DeckSelectSequence.NativeFieldInfoPtr_buttonHideTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (buttonHideTween));
    DeckSelectSequence.NativeFieldInfoPtr_renameButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (renameButton));
    DeckSelectSequence.NativeFieldInfoPtr_takeCrownButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (takeCrownButton));
    DeckSelectSequence.NativeFieldInfoPtr_moveDownButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (moveDownButton));
    DeckSelectSequence.NativeFieldInfoPtr_moveDownButtonButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (moveDownButtonButton));
    DeckSelectSequence.NativeFieldInfoPtr_moveUpButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (moveUpButton));
    DeckSelectSequence.NativeFieldInfoPtr_moveUpButtonButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (moveUpButtonButton));
    DeckSelectSequence.NativeFieldInfoPtr_entityScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (entityScale));
    DeckSelectSequence.NativeFieldInfoPtr_moveWobble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (moveWobble));
    DeckSelectSequence.NativeFieldInfoPtr_moveCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (moveCurve));
    DeckSelectSequence.NativeFieldInfoPtr_moveDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (moveDur));
    DeckSelectSequence.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (entity));
    DeckSelectSequence.NativeFieldInfoPtr_entityPreParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (entityPreParent));
    DeckSelectSequence.NativeFieldInfoPtr_promptRename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, nameof (promptRename));
    DeckSelectSequence.NativeMethodInfoPtr_SetEntity_Public_Void_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, 100671925);
    DeckSelectSequence.NativeMethodInfoPtr_EntityHasRemovableCrown_Private_Static_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, 100671926);
    DeckSelectSequence.NativeMethodInfoPtr_AddMoveDown_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, 100671927);
    DeckSelectSequence.NativeMethodInfoPtr_AddMoveUp_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, 100671928);
    DeckSelectSequence.NativeMethodInfoPtr_Rename_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, 100671929);
    DeckSelectSequence.NativeMethodInfoPtr_TakeCrown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, 100671930);
    DeckSelectSequence.NativeMethodInfoPtr_End_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, 100671931);
    DeckSelectSequence.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, 100671932);
    DeckSelectSequence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, 100671933);
    DeckSelectSequence.NativeMethodInfoPtr__AddMoveDown_b__27_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, 100671934);
    DeckSelectSequence.NativeMethodInfoPtr__AddMoveUp_b__28_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, 100671935);
  }

  public DeckSelectSequence(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe UnityEvent onEnable
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_onEnable));
      return pointer == System.IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_onEnable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent onDisable
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_onDisable));
      return pointer == System.IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_onDisable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform cardHolder
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_cardHolder));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_cardHolder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CanvasGroup fade
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_fade));
      return pointer == System.IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_fade), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float fadeInTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_fadeInTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_fadeInTime)) = value;
    }
  }

  public unsafe float fadeOutTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_fadeOutTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_fadeOutTime)) = value;
    }
  }

  public unsafe CardSelector cardSelector
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_cardSelector));
      return pointer == System.IntPtr.Zero ? (CardSelector) null : new CardSelector(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_cardSelector), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RenameCompanionSequence renameSequence
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_renameSequence));
      return pointer == System.IntPtr.Zero ? (RenameCompanionSequence) null : new RenameCompanionSequence(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_renameSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CrownHolder crownHolder
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_crownHolder));
      return pointer == System.IntPtr.Zero ? (CrownHolder) null : new CrownHolder(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_crownHolder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject buttonGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_buttonGroup));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_buttonGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TweenUI buttonShowTween
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_buttonShowTween));
      return pointer == System.IntPtr.Zero ? (TweenUI) null : new TweenUI(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_buttonShowTween), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TweenUI buttonHideTween
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_buttonHideTween));
      return pointer == System.IntPtr.Zero ? (TweenUI) null : new TweenUI(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_buttonHideTween), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject renameButton
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_renameButton));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_renameButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject takeCrownButton
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_takeCrownButton));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_takeCrownButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject moveDownButton
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_moveDownButton));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_moveDownButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button moveDownButtonButton
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_moveDownButtonButton));
      return pointer == System.IntPtr.Zero ? (Button) null : new Button(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_moveDownButtonButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject moveUpButton
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_moveUpButton));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_moveUpButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button moveUpButtonButton
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_moveUpButtonButton));
      return pointer == System.IntPtr.Zero ? (Button) null : new Button(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_moveUpButtonButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float entityScale
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_entityScale));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_entityScale)) = value;
    }
  }

  public unsafe float moveWobble
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_moveWobble));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_moveWobble)) = value;
    }
  }

  public unsafe AnimationCurve moveCurve
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_moveCurve));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_moveCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float moveDur
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_moveDur));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_moveDur)) = value;
    }
  }

  public unsafe Entity entity
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_entity));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform entityPreParent
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_entityPreParent));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_entityPreParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool promptRename
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_promptRename));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence.NativeFieldInfoPtr_promptRename)) = value;
    }
  }

  [ObfuscatedName("DeckSelectSequence/<Run>d__32")]
  public sealed class _Run_d__32 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__protectEnd_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__protectEndCount_5__3;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Run_d__32(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeckSelectSequence._Run_d__32>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeckSelectSequence._Run_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeckSelectSequence._Run_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98046, XrefRangeEnd = 98087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DeckSelectSequence._Run_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DeckSelectSequence._Run_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98087, XrefRangeEnd = 98093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeckSelectSequence._Run_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DeckSelectSequence._Run_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Run_d__32()
    {
      Il2CppClassPointerStore<DeckSelectSequence._Run_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeckSelectSequence>.NativeClassPtr, "<Run>d__32");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeckSelectSequence._Run_d__32>.NativeClassPtr);
      DeckSelectSequence._Run_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence._Run_d__32>.NativeClassPtr, "<>1__state");
      DeckSelectSequence._Run_d__32.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence._Run_d__32>.NativeClassPtr, "<>2__current");
      DeckSelectSequence._Run_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence._Run_d__32>.NativeClassPtr, "<>4__this");
      DeckSelectSequence._Run_d__32.NativeFieldInfoPtr__protectEnd_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence._Run_d__32>.NativeClassPtr, "<protectEnd>5__2");
      DeckSelectSequence._Run_d__32.NativeFieldInfoPtr__protectEndCount_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSelectSequence._Run_d__32>.NativeClassPtr, "<protectEndCount>5__3");
      DeckSelectSequence._Run_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSelectSequence._Run_d__32>.NativeClassPtr, 100671936);
      DeckSelectSequence._Run_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSelectSequence._Run_d__32>.NativeClassPtr, 100671937);
      DeckSelectSequence._Run_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSelectSequence._Run_d__32>.NativeClassPtr, 100671938);
      DeckSelectSequence._Run_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSelectSequence._Run_d__32>.NativeClassPtr, 100671939);
      DeckSelectSequence._Run_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSelectSequence._Run_d__32>.NativeClassPtr, 100671940);
      DeckSelectSequence._Run_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSelectSequence._Run_d__32>.NativeClassPtr, 100671941);
    }

    public _Run_d__32(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence._Run_d__32.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence._Run_d__32.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence._Run_d__32.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence._Run_d__32.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DeckSelectSequence __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence._Run_d__32.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (DeckSelectSequence) null : new DeckSelectSequence(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence._Run_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _protectEnd_5__2
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence._Run_d__32.NativeFieldInfoPtr__protectEnd_5__2));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence._Run_d__32.NativeFieldInfoPtr__protectEnd_5__2)) = value;
      }
    }

    public unsafe int _protectEndCount_5__3
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence._Run_d__32.NativeFieldInfoPtr__protectEndCount_5__3));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeckSelectSequence._Run_d__32.NativeFieldInfoPtr__protectEndCount_5__3)) = value;
      }
    }
  }
}
