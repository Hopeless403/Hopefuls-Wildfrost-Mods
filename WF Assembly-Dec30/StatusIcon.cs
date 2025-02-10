// Decompiled with JetBrains decompiler
// Type: StatusIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
public class StatusIcon : MonoBehaviourRect
{
  private static readonly IntPtr NativeFieldInfoPtr__target_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr_type;
  private static readonly IntPtr NativeFieldInfoPtr_textElement;
  private static readonly IntPtr NativeFieldInfoPtr_persistent;
  private static readonly IntPtr NativeFieldInfoPtr_alterTextColours;
  private static readonly IntPtr NativeFieldInfoPtr_textColour;
  private static readonly IntPtr NativeFieldInfoPtr_textColourAboveMax;
  private static readonly IntPtr NativeFieldInfoPtr_textColourBelowMax;
  private static readonly IntPtr NativeFieldInfoPtr_textMaterialAboveMax;
  private static readonly IntPtr NativeFieldInfoPtr_fill;
  private static readonly IntPtr NativeFieldInfoPtr_value;
  private static readonly IntPtr NativeFieldInfoPtr_textFormat;
  private static readonly IntPtr NativeFieldInfoPtr_textAdd;
  private static readonly IntPtr NativeFieldInfoPtr_normalMaterial;
  private static readonly IntPtr NativeFieldInfoPtr_currentMaterialIsNormal;
  private static readonly IntPtr NativeFieldInfoPtr_onCreate;
  private static readonly IntPtr NativeFieldInfoPtr_onValueDown;
  private static readonly IntPtr NativeFieldInfoPtr_onValueUp;
  private static readonly IntPtr NativeFieldInfoPtr_afterUpdate;
  private static readonly IntPtr NativeFieldInfoPtr_onDestroy;
  private static readonly IntPtr NativeMethodInfoPtr_get_target_Public_get_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_target_Private_set_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_New_Stat_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Stat_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Assign_Public_Virtual_New_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateEvent_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateEvent_Public_Void_Stat_Stat_0;
  private static readonly IntPtr NativeMethodInfoPtr_DestroyEvent_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Ping_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckRemove_Public_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckDestroy_Public_Void_Stat_Stat_0;
  private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__CheckRemove_b__31_0_Private_Boolean_StatusEffectData_0;

  public unsafe Entity target
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusIcon.NativeMethodInfoPtr_get_target_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 54210, RefRangeEnd = 54212, XrefRangeStart = 54209, XrefRangeEnd = 54210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusIcon.NativeMethodInfoPtr_set_target_Private_set_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  public virtual unsafe Stat GetValue()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusIcon.NativeMethodInfoPtr_GetValue_Public_Virtual_New_Stat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Stat*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 54232, RefRangeEnd = 54243, XrefRangeStart = 54212, XrefRangeEnd = 54232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetValue(Stat value, bool doPing = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &value;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &doPing;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusIcon.NativeMethodInfoPtr_SetValue_Public_Void_Stat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 54210, RefRangeEnd = 54212, XrefRangeStart = 54210, XrefRangeEnd = 54212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Assign(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusIcon.NativeMethodInfoPtr_Assign_Public_Virtual_New_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 54245, RefRangeEnd = 54246, XrefRangeStart = 54243, XrefRangeEnd = 54245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateEvent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusIcon.NativeMethodInfoPtr_CreateEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54246, XrefRangeEnd = 54255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateEvent(Stat previousValue, Stat newValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &previousValue;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &newValue;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusIcon.NativeMethodInfoPtr_UpdateEvent_Public_Void_Stat_Stat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54255, XrefRangeEnd = 54257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DestroyEvent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusIcon.NativeMethodInfoPtr_DestroyEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54257, XrefRangeEnd = 54277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetText()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusIcon.NativeMethodInfoPtr_SetText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 54290, RefRangeEnd = 54291, XrefRangeStart = 54277, XrefRangeEnd = 54290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Ping()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusIcon.NativeMethodInfoPtr_Ping_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54291, XrefRangeEnd = 54305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void CheckRemove()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusIcon.NativeMethodInfoPtr_CheckRemove_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54305, XrefRangeEnd = 54310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckDestroy(Stat previousValue, Stat newValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &previousValue;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &newValue;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusIcon.NativeMethodInfoPtr_CheckDestroy_Public_Void_Stat_Stat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 54314, RefRangeEnd = 54315, XrefRangeStart = 54310, XrefRangeEnd = 54314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Destroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusIcon.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 54320, RefRangeEnd = 54324, XrefRangeStart = 54315, XrefRangeEnd = 54320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusIcon()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusIcon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54324, XrefRangeEnd = 54326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool _CheckRemove_b__31_0(StatusEffectData a)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusIcon.NativeMethodInfoPtr__CheckRemove_b__31_0_Private_Boolean_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  static StatusIcon()
  {
    Il2CppClassPointerStore<StatusIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusIcon));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr);
    StatusIcon.NativeFieldInfoPtr__target_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, "<target>k__BackingField");
    StatusIcon.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, nameof (type));
    StatusIcon.NativeFieldInfoPtr_textElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, nameof (textElement));
    StatusIcon.NativeFieldInfoPtr_persistent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, nameof (persistent));
    StatusIcon.NativeFieldInfoPtr_alterTextColours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, nameof (alterTextColours));
    StatusIcon.NativeFieldInfoPtr_textColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, nameof (textColour));
    StatusIcon.NativeFieldInfoPtr_textColourAboveMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, nameof (textColourAboveMax));
    StatusIcon.NativeFieldInfoPtr_textColourBelowMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, nameof (textColourBelowMax));
    StatusIcon.NativeFieldInfoPtr_textMaterialAboveMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, nameof (textMaterialAboveMax));
    StatusIcon.NativeFieldInfoPtr_fill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, nameof (fill));
    StatusIcon.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, nameof (value));
    StatusIcon.NativeFieldInfoPtr_textFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, nameof (textFormat));
    StatusIcon.NativeFieldInfoPtr_textAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, nameof (textAdd));
    StatusIcon.NativeFieldInfoPtr_normalMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, nameof (normalMaterial));
    StatusIcon.NativeFieldInfoPtr_currentMaterialIsNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, nameof (currentMaterialIsNormal));
    StatusIcon.NativeFieldInfoPtr_onCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, nameof (onCreate));
    StatusIcon.NativeFieldInfoPtr_onValueDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, nameof (onValueDown));
    StatusIcon.NativeFieldInfoPtr_onValueUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, nameof (onValueUp));
    StatusIcon.NativeFieldInfoPtr_afterUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, nameof (afterUpdate));
    StatusIcon.NativeFieldInfoPtr_onDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, nameof (onDestroy));
    StatusIcon.NativeMethodInfoPtr_get_target_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, 100667747);
    StatusIcon.NativeMethodInfoPtr_set_target_Private_set_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, 100667748);
    StatusIcon.NativeMethodInfoPtr_GetValue_Public_Virtual_New_Stat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, 100667749);
    StatusIcon.NativeMethodInfoPtr_SetValue_Public_Void_Stat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, 100667750);
    StatusIcon.NativeMethodInfoPtr_Assign_Public_Virtual_New_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, 100667751);
    StatusIcon.NativeMethodInfoPtr_CreateEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, 100667752);
    StatusIcon.NativeMethodInfoPtr_UpdateEvent_Public_Void_Stat_Stat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, 100667753);
    StatusIcon.NativeMethodInfoPtr_DestroyEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, 100667754);
    StatusIcon.NativeMethodInfoPtr_SetText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, 100667755);
    StatusIcon.NativeMethodInfoPtr_Ping_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, 100667756);
    StatusIcon.NativeMethodInfoPtr_CheckRemove_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, 100667757);
    StatusIcon.NativeMethodInfoPtr_CheckDestroy_Public_Void_Stat_Stat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, 100667758);
    StatusIcon.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, 100667759);
    StatusIcon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, 100667760);
    StatusIcon.NativeMethodInfoPtr__CheckRemove_b__31_0_Private_Boolean_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIcon>.NativeClassPtr, 100667761);
  }

  public StatusIcon(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Entity _target_k__BackingField
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr__target_k__BackingField));
      return pointer == IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr__target_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string type
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_type)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_type), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe TMP_Text textElement
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_textElement));
      return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_textElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool persistent
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_persistent));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_persistent)) = value;
    }
  }

  public unsafe bool alterTextColours
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_alterTextColours));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_alterTextColours)) = value;
    }
  }

  public unsafe Color textColour
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_textColour));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_textColour)) = value;
    }
  }

  public unsafe Color textColourAboveMax
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_textColourAboveMax));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_textColourAboveMax)) = value;
    }
  }

  public unsafe Color textColourBelowMax
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_textColourBelowMax));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_textColourBelowMax)) = value;
    }
  }

  public unsafe Material textMaterialAboveMax
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_textMaterialAboveMax));
      return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_textMaterialAboveMax), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image fill
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_fill));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_fill), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Stat value
  {
    get
    {
      return *(Stat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_value));
    }
    [param: In] set
    {
      *(Stat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_value)) = value;
    }
  }

  public unsafe string textFormat
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_textFormat)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_textFormat), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int textAdd
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_textAdd));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_textAdd)) = value;
    }
  }

  public unsafe Material normalMaterial
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_normalMaterial));
      return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_normalMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool currentMaterialIsNormal
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_currentMaterialIsNormal));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_currentMaterialIsNormal)) = value;
    }
  }

  public unsafe UnityEvent onCreate
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_onCreate));
      return pointer == IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_onCreate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEventStatStat onValueDown
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_onValueDown));
      return pointer == IntPtr.Zero ? (UnityEventStatStat) null : new UnityEventStatStat(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_onValueDown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEventStatStat onValueUp
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_onValueUp));
      return pointer == IntPtr.Zero ? (UnityEventStatStat) null : new UnityEventStatStat(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_onValueUp), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent afterUpdate
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_afterUpdate));
      return pointer == IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_afterUpdate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent onDestroy
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_onDestroy));
      return pointer == IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIcon.NativeFieldInfoPtr_onDestroy), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
