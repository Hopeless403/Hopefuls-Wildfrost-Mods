// Decompiled with JetBrains decompiler
// Type: PopUpAddStatsSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Localization;

#nullable disable
public class PopUpAddStatsSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_counterRef;
  private static readonly IntPtr NativeFieldInfoPtr_counterThisTurnRef;
  private static readonly IntPtr NativeFieldInfoPtr_counterFrozenRef;
  private static readonly IntPtr NativeFieldInfoPtr_reactionRef;
  private static readonly IntPtr NativeFieldInfoPtr_reactionJoinRef;
  private static readonly IntPtr NativeFieldInfoPtr_reactionFrozenRef;
  private static readonly IntPtr NativeFieldInfoPtr_reactionSilencedRef;
  private static readonly IntPtr NativeFieldInfoPtr_hover;
  private static readonly IntPtr NativeFieldInfoPtr_hoverEntityIsSnowed;
  private static readonly IntPtr NativeFieldInfoPtr_hoverEntitySilenced;
  private static readonly IntPtr NativeFieldInfoPtr_buffedColour;
  private static readonly IntPtr NativeFieldInfoPtr_debuffedColour;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_HoverChanged_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_PopupCreated_Private_Void_KeywordData_CardPopUpPanel_0;
  private static readonly IntPtr NativeMethodInfoPtr_BuildCounterBodyText_Private_String_Boolean_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_BuildReactionBodyText_Private_String_Boolean_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_FormatReactionText_Private_Static_String_StatusEffectData_0;
  private static readonly IntPtr NativeMethodInfoPtr_FirstCharToLowerCase_Private_Static_String_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66739, XrefRangeEnd = 66754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PopUpAddStatsSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66754, XrefRangeEnd = 66769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PopUpAddStatsSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66769, XrefRangeEnd = 66772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HoverChanged(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PopUpAddStatsSystem.NativeMethodInfoPtr_HoverChanged_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66772, XrefRangeEnd = 66849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PopupCreated(KeywordData keyword, CardPopUpPanel panel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keyword);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) panel);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PopUpAddStatsSystem.NativeMethodInfoPtr_PopupCreated_Private_Void_KeywordData_CardPopUpPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66849, XrefRangeEnd = 66860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string BuildCounterBodyText(bool frozen, int turnsTilTrigger)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &frozen;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &turnsTilTrigger;
    IntPtr exc;
    IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PopUpAddStatsSystem.NativeMethodInfoPtr_BuildCounterBodyText_Private_String_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66860, XrefRangeEnd = 66917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string BuildReactionBodyText(bool frozen, bool silenced)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &frozen;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &silenced;
    IntPtr exc;
    IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PopUpAddStatsSystem.NativeMethodInfoPtr_BuildReactionBodyText_Private_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 66984, RefRangeEnd = 66985, XrefRangeStart = 66917, XrefRangeEnd = 66984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string FormatReactionText(StatusEffectData effect)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) effect)
    };
    IntPtr exc;
    IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PopUpAddStatsSystem.NativeMethodInfoPtr_FormatReactionText_Private_Static_String_StatusEffectData_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 66990, RefRangeEnd = 66991, XrefRangeStart = 66985, XrefRangeEnd = 66990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string FirstCharToLowerCase(string str)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(str)
    };
    IntPtr exc;
    IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PopUpAddStatsSystem.NativeMethodInfoPtr_FirstCharToLowerCase_Private_Static_String_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PopUpAddStatsSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PopUpAddStatsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static PopUpAddStatsSystem()
  {
    Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (PopUpAddStatsSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr);
    PopUpAddStatsSystem.NativeFieldInfoPtr_counterRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr, nameof (counterRef));
    PopUpAddStatsSystem.NativeFieldInfoPtr_counterThisTurnRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr, nameof (counterThisTurnRef));
    PopUpAddStatsSystem.NativeFieldInfoPtr_counterFrozenRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr, nameof (counterFrozenRef));
    PopUpAddStatsSystem.NativeFieldInfoPtr_reactionRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr, nameof (reactionRef));
    PopUpAddStatsSystem.NativeFieldInfoPtr_reactionJoinRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr, nameof (reactionJoinRef));
    PopUpAddStatsSystem.NativeFieldInfoPtr_reactionFrozenRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr, nameof (reactionFrozenRef));
    PopUpAddStatsSystem.NativeFieldInfoPtr_reactionSilencedRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr, nameof (reactionSilencedRef));
    PopUpAddStatsSystem.NativeFieldInfoPtr_hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr, nameof (hover));
    PopUpAddStatsSystem.NativeFieldInfoPtr_hoverEntityIsSnowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr, nameof (hoverEntityIsSnowed));
    PopUpAddStatsSystem.NativeFieldInfoPtr_hoverEntitySilenced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr, nameof (hoverEntitySilenced));
    PopUpAddStatsSystem.NativeFieldInfoPtr_buffedColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr, nameof (buffedColour));
    PopUpAddStatsSystem.NativeFieldInfoPtr_debuffedColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr, nameof (debuffedColour));
    PopUpAddStatsSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr, 100668794);
    PopUpAddStatsSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr, 100668795);
    PopUpAddStatsSystem.NativeMethodInfoPtr_HoverChanged_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr, 100668796);
    PopUpAddStatsSystem.NativeMethodInfoPtr_PopupCreated_Private_Void_KeywordData_CardPopUpPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr, 100668797);
    PopUpAddStatsSystem.NativeMethodInfoPtr_BuildCounterBodyText_Private_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr, 100668798);
    PopUpAddStatsSystem.NativeMethodInfoPtr_BuildReactionBodyText_Private_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr, 100668799);
    PopUpAddStatsSystem.NativeMethodInfoPtr_FormatReactionText_Private_Static_String_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr, 100668800);
    PopUpAddStatsSystem.NativeMethodInfoPtr_FirstCharToLowerCase_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr, 100668801);
    PopUpAddStatsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopUpAddStatsSystem>.NativeClassPtr, 100668802);
  }

  public PopUpAddStatsSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LocalizedString counterRef
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PopUpAddStatsSystem.NativeFieldInfoPtr_counterRef));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PopUpAddStatsSystem.NativeFieldInfoPtr_counterRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString counterThisTurnRef
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PopUpAddStatsSystem.NativeFieldInfoPtr_counterThisTurnRef));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PopUpAddStatsSystem.NativeFieldInfoPtr_counterThisTurnRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString counterFrozenRef
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PopUpAddStatsSystem.NativeFieldInfoPtr_counterFrozenRef));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PopUpAddStatsSystem.NativeFieldInfoPtr_counterFrozenRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString reactionRef
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PopUpAddStatsSystem.NativeFieldInfoPtr_reactionRef));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PopUpAddStatsSystem.NativeFieldInfoPtr_reactionRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString reactionJoinRef
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PopUpAddStatsSystem.NativeFieldInfoPtr_reactionJoinRef));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PopUpAddStatsSystem.NativeFieldInfoPtr_reactionJoinRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString reactionFrozenRef
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PopUpAddStatsSystem.NativeFieldInfoPtr_reactionFrozenRef));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PopUpAddStatsSystem.NativeFieldInfoPtr_reactionFrozenRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString reactionSilencedRef
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PopUpAddStatsSystem.NativeFieldInfoPtr_reactionSilencedRef));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PopUpAddStatsSystem.NativeFieldInfoPtr_reactionSilencedRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Entity hover
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PopUpAddStatsSystem.NativeFieldInfoPtr_hover));
      return pointer == IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PopUpAddStatsSystem.NativeFieldInfoPtr_hover), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool hoverEntityIsSnowed
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PopUpAddStatsSystem.NativeFieldInfoPtr_hoverEntityIsSnowed));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PopUpAddStatsSystem.NativeFieldInfoPtr_hoverEntityIsSnowed)) = value;
    }
  }

  public unsafe bool hoverEntitySilenced
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PopUpAddStatsSystem.NativeFieldInfoPtr_hoverEntitySilenced));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PopUpAddStatsSystem.NativeFieldInfoPtr_hoverEntitySilenced)) = value;
    }
  }

  public static unsafe string buffedColour
  {
    get
    {
      IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(PopUpAddStatsSystem.NativeFieldInfoPtr_buffedColour, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PopUpAddStatsSystem.NativeFieldInfoPtr_buffedColour, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string debuffedColour
  {
    get
    {
      IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(PopUpAddStatsSystem.NativeFieldInfoPtr_debuffedColour, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PopUpAddStatsSystem.NativeFieldInfoPtr_debuffedColour, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
