// Decompiled with JetBrains decompiler
// Type: InspectNewUnitSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class InspectNewUnitSequence : UISequence
{
  private static readonly System.IntPtr NativeFieldInfoPtr_takeCard;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardHolder;
  private static readonly System.IntPtr NativeFieldInfoPtr_speechBubble;
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultGreetMessages;
  private static readonly System.IntPtr NativeFieldInfoPtr_nameHighlightColour;
  private static readonly System.IntPtr NativeFieldInfoPtr_nameTextColour;
  private static readonly System.IntPtr NativeFieldInfoPtr_unit;
  private static readonly System.IntPtr NativeFieldInfoPtr_greeting;
  private static readonly System.IntPtr NativeFieldInfoPtr_unitPreParent;
  private static readonly System.IntPtr NativeFieldInfoPtr_unitPrePosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_unitPreRotation;
  private static readonly System.IntPtr NativeFieldInfoPtr_unitPreScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_unitMoveWobble;
  private static readonly System.IntPtr NativeFieldInfoPtr_unitMoveCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_unitMoveDur;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardSelector;
  private static readonly System.IntPtr NativeFieldInfoPtr_renameSequence;
  private static readonly System.IntPtr NativeFieldInfoPtr_destroyOnEnd;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetUnit_Public_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetUnit_Public_Void_Entity_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateUnit_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnsetUnit_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TakeCard_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartRename_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 99139, RefRangeEnd = 99143, XrefRangeStart = 99123, XrefRangeEnd = 99139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetUnit(Entity unit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) unit)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectNewUnitSequence.NativeMethodInfoPtr_SetUnit_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 99159, RefRangeEnd = 99160, XrefRangeStart = 99143, XrefRangeEnd = 99159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetUnit(Entity unit, bool updateGreeting)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) unit);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &updateGreeting;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectNewUnitSequence.NativeMethodInfoPtr_SetUnit_Public_Void_Entity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 99215, RefRangeEnd = 99217, XrefRangeStart = 99160, XrefRangeEnd = 99215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateUnit()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectNewUnitSequence.NativeMethodInfoPtr_UpdateUnit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 99218, RefRangeEnd = 99219, XrefRangeStart = 99217, XrefRangeEnd = 99218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnsetUnit()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectNewUnitSequence.NativeMethodInfoPtr_UnsetUnit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99219, XrefRangeEnd = 99224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator Run()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InspectNewUnitSequence.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99224, XrefRangeEnd = 99229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TakeCard()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectNewUnitSequence.NativeMethodInfoPtr_TakeCard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99229, XrefRangeEnd = 99231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartRename()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectNewUnitSequence.NativeMethodInfoPtr_StartRename_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99231, XrefRangeEnd = 99232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InspectNewUnitSequence()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectNewUnitSequence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static InspectNewUnitSequence()
  {
    Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (InspectNewUnitSequence));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr);
    InspectNewUnitSequence.NativeFieldInfoPtr_takeCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, nameof (takeCard));
    InspectNewUnitSequence.NativeFieldInfoPtr_cardHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, nameof (cardHolder));
    InspectNewUnitSequence.NativeFieldInfoPtr_speechBubble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, nameof (speechBubble));
    InspectNewUnitSequence.NativeFieldInfoPtr_defaultGreetMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, nameof (defaultGreetMessages));
    InspectNewUnitSequence.NativeFieldInfoPtr_nameHighlightColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, nameof (nameHighlightColour));
    InspectNewUnitSequence.NativeFieldInfoPtr_nameTextColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, nameof (nameTextColour));
    InspectNewUnitSequence.NativeFieldInfoPtr_unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, nameof (unit));
    InspectNewUnitSequence.NativeFieldInfoPtr_greeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, nameof (greeting));
    InspectNewUnitSequence.NativeFieldInfoPtr_unitPreParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, nameof (unitPreParent));
    InspectNewUnitSequence.NativeFieldInfoPtr_unitPrePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, nameof (unitPrePosition));
    InspectNewUnitSequence.NativeFieldInfoPtr_unitPreRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, nameof (unitPreRotation));
    InspectNewUnitSequence.NativeFieldInfoPtr_unitPreScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, nameof (unitPreScale));
    InspectNewUnitSequence.NativeFieldInfoPtr_unitMoveWobble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, nameof (unitMoveWobble));
    InspectNewUnitSequence.NativeFieldInfoPtr_unitMoveCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, nameof (unitMoveCurve));
    InspectNewUnitSequence.NativeFieldInfoPtr_unitMoveDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, nameof (unitMoveDur));
    InspectNewUnitSequence.NativeFieldInfoPtr_cardSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, nameof (cardSelector));
    InspectNewUnitSequence.NativeFieldInfoPtr_renameSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, nameof (renameSequence));
    InspectNewUnitSequence.NativeFieldInfoPtr_destroyOnEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, nameof (destroyOnEnd));
    InspectNewUnitSequence.NativeMethodInfoPtr_SetUnit_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, 100672109);
    InspectNewUnitSequence.NativeMethodInfoPtr_SetUnit_Public_Void_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, 100672110);
    InspectNewUnitSequence.NativeMethodInfoPtr_UpdateUnit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, 100672111);
    InspectNewUnitSequence.NativeMethodInfoPtr_UnsetUnit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, 100672112);
    InspectNewUnitSequence.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, 100672113);
    InspectNewUnitSequence.NativeMethodInfoPtr_TakeCard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, 100672114);
    InspectNewUnitSequence.NativeMethodInfoPtr_StartRename_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, 100672115);
    InspectNewUnitSequence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, 100672116);
  }

  public InspectNewUnitSequence(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool takeCard
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_takeCard));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_takeCard)) = value;
    }
  }

  public unsafe Transform cardHolder
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_cardHolder));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_cardHolder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SpeechBubble speechBubble
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_speechBubble));
      return pointer == System.IntPtr.Zero ? (SpeechBubble) null : new SpeechBubble(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_speechBubble), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<LocalizedString> defaultGreetMessages
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_defaultGreetMessages));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<LocalizedString>) null : new Il2CppReferenceArray<LocalizedString>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_defaultGreetMessages), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color nameHighlightColour
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_nameHighlightColour));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_nameHighlightColour)) = value;
    }
  }

  public unsafe Color nameTextColour
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_nameTextColour));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_nameTextColour)) = value;
    }
  }

  public unsafe Entity unit
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_unit));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_unit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string greeting
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_greeting)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_greeting), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Transform unitPreParent
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_unitPreParent));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_unitPreParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 unitPrePosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_unitPrePosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_unitPrePosition)) = value;
    }
  }

  public unsafe Vector3 unitPreRotation
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_unitPreRotation));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_unitPreRotation)) = value;
    }
  }

  public unsafe Vector3 unitPreScale
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_unitPreScale));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_unitPreScale)) = value;
    }
  }

  public unsafe float unitMoveWobble
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_unitMoveWobble));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_unitMoveWobble)) = value;
    }
  }

  public unsafe AnimationCurve unitMoveCurve
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_unitMoveCurve));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_unitMoveCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float unitMoveDur
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_unitMoveDur));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_unitMoveDur)) = value;
    }
  }

  public unsafe CardSelector cardSelector
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_cardSelector));
      return pointer == System.IntPtr.Zero ? (CardSelector) null : new CardSelector(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_cardSelector), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RenameCompanionSequence renameSequence
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_renameSequence));
      return pointer == System.IntPtr.Zero ? (RenameCompanionSequence) null : new RenameCompanionSequence(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_renameSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool destroyOnEnd
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_destroyOnEnd));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence.NativeFieldInfoPtr_destroyOnEnd)) = value;
    }
  }

  [ObfuscatedName("InspectNewUnitSequence/<Run>d__22")]
  public sealed class _Run_d__22 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__anchors_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__c_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__i_5__4;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Run_d__22(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InspectNewUnitSequence._Run_d__22>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InspectNewUnitSequence._Run_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InspectNewUnitSequence._Run_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99106, XrefRangeEnd = 99117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectNewUnitSequence._Run_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectNewUnitSequence._Run_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99117, XrefRangeEnd = 99123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InspectNewUnitSequence._Run_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectNewUnitSequence._Run_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Run_d__22()
    {
      Il2CppClassPointerStore<InspectNewUnitSequence._Run_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InspectNewUnitSequence>.NativeClassPtr, "<Run>d__22");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InspectNewUnitSequence._Run_d__22>.NativeClassPtr);
      InspectNewUnitSequence._Run_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence._Run_d__22>.NativeClassPtr, "<>1__state");
      InspectNewUnitSequence._Run_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence._Run_d__22>.NativeClassPtr, "<>2__current");
      InspectNewUnitSequence._Run_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence._Run_d__22>.NativeClassPtr, "<>4__this");
      InspectNewUnitSequence._Run_d__22.NativeFieldInfoPtr__anchors_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence._Run_d__22>.NativeClassPtr, "<anchors>5__2");
      InspectNewUnitSequence._Run_d__22.NativeFieldInfoPtr__c_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence._Run_d__22>.NativeClassPtr, "<c>5__3");
      InspectNewUnitSequence._Run_d__22.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectNewUnitSequence._Run_d__22>.NativeClassPtr, "<i>5__4");
      InspectNewUnitSequence._Run_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectNewUnitSequence._Run_d__22>.NativeClassPtr, 100672117);
      InspectNewUnitSequence._Run_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectNewUnitSequence._Run_d__22>.NativeClassPtr, 100672118);
      InspectNewUnitSequence._Run_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectNewUnitSequence._Run_d__22>.NativeClassPtr, 100672119);
      InspectNewUnitSequence._Run_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectNewUnitSequence._Run_d__22>.NativeClassPtr, 100672120);
      InspectNewUnitSequence._Run_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectNewUnitSequence._Run_d__22>.NativeClassPtr, 100672121);
      InspectNewUnitSequence._Run_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectNewUnitSequence._Run_d__22>.NativeClassPtr, 100672122);
    }

    public _Run_d__22(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence._Run_d__22.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence._Run_d__22.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence._Run_d__22.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence._Run_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InspectNewUnitSequence __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence._Run_d__22.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (InspectNewUnitSequence) null : new InspectNewUnitSequence(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence._Run_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIAnchors _anchors_5__2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence._Run_d__22.NativeFieldInfoPtr__anchors_5__2));
        return pointer == System.IntPtr.Zero ? (UIAnchors) null : new UIAnchors(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence._Run_d__22.NativeFieldInfoPtr__anchors_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _c_5__3
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence._Run_d__22.NativeFieldInfoPtr__c_5__3));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence._Run_d__22.NativeFieldInfoPtr__c_5__3)) = value;
      }
    }

    public unsafe int _i_5__4
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence._Run_d__22.NativeFieldInfoPtr__i_5__4));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectNewUnitSequence._Run_d__22.NativeFieldInfoPtr__i_5__4)) = value;
      }
    }
  }
}
