// Decompiled with JetBrains decompiler
// Type: TargetingArrow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class TargetingArrow : TargetingDisplay
{
  private static readonly System.IntPtr NativeFieldInfoPtr_head;
  private static readonly System.IntPtr NativeFieldInfoPtr_curviness;
  private static readonly System.IntPtr NativeFieldInfoPtr_arch;
  private static readonly System.IntPtr NativeFieldInfoPtr_headStyles;
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultStyleName;
  private static readonly System.IntPtr NativeFieldInfoPtr__headStyleLookup;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentHeadStyle;
  private static readonly System.IntPtr NativeFieldInfoPtr__bezier;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_headStyleLookup_Private_get_Dictionary_2_String_ArrowHeadStyle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_bezier_Private_get_Bezier_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePosition_Public_Virtual_Void_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePosition_Public_Virtual_Void_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityHover_Public_Virtual_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ContainerHover_Public_Virtual_Void_CardContainer_TargetingArrowSystem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SlotHover_Public_Virtual_Void_CardSlot_TargetingArrowSystem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetStyle_Private_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetStyle_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe Dictionary<string, TargetingArrow.ArrowHeadStyle> headStyleLookup
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 76398, RefRangeEnd = 76401, XrefRangeStart = 76387, XrefRangeEnd = 76398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetingArrow.NativeMethodInfoPtr_get_headStyleLookup_Private_get_Dictionary_2_String_ArrowHeadStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<string, TargetingArrow.ArrowHeadStyle>) null : new Dictionary<string, TargetingArrow.ArrowHeadStyle>(pointer);
    }
  }

  public unsafe Bezier bezier
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 76405, RefRangeEnd = 76408, XrefRangeStart = 76401, XrefRangeEnd = 76405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetingArrow.NativeMethodInfoPtr_get_bezier_Private_get_Bezier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Bezier) null : new Bezier(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76408, XrefRangeEnd = 76411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void UpdatePosition(Transform target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetingArrow.NativeMethodInfoPtr_UpdatePosition_Public_Virtual_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76411, XrefRangeEnd = 76444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void UpdatePosition(Vector3 start, Vector3 end)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetingArrow.NativeMethodInfoPtr_UpdatePosition_Public_Virtual_Void_Vector3_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76444, XrefRangeEnd = 76447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void EntityHover(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetingArrow.NativeMethodInfoPtr_EntityHover_Public_Virtual_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76447, XrefRangeEnd = 76457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ContainerHover(
    CardContainer cardContainer,
    TargetingArrowSystem system)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardContainer);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetingArrow.NativeMethodInfoPtr_ContainerHover_Public_Virtual_Void_CardContainer_TargetingArrowSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76457, XrefRangeEnd = 76462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void SlotHover(CardSlot slot, TargetingArrowSystem system)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) slot);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetingArrow.NativeMethodInfoPtr_SlotHover_Public_Virtual_Void_CardSlot_TargetingArrowSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 76493, RefRangeEnd = 76497, XrefRangeStart = 76462, XrefRangeEnd = 76493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetStyle(string name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingArrow.NativeMethodInfoPtr_SetStyle_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76497, XrefRangeEnd = 76498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ResetStyle()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetingArrow.NativeMethodInfoPtr_ResetStyle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76498, XrefRangeEnd = 76503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TargetingArrow()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetingArrow>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingArrow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TargetingArrow()
  {
    Il2CppClassPointerStore<TargetingArrow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TargetingArrow));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetingArrow>.NativeClassPtr);
    TargetingArrow.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrow>.NativeClassPtr, nameof (head));
    TargetingArrow.NativeFieldInfoPtr_curviness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrow>.NativeClassPtr, nameof (curviness));
    TargetingArrow.NativeFieldInfoPtr_arch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrow>.NativeClassPtr, nameof (arch));
    TargetingArrow.NativeFieldInfoPtr_headStyles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrow>.NativeClassPtr, nameof (headStyles));
    TargetingArrow.NativeFieldInfoPtr_defaultStyleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrow>.NativeClassPtr, nameof (defaultStyleName));
    TargetingArrow.NativeFieldInfoPtr__headStyleLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrow>.NativeClassPtr, nameof (_headStyleLookup));
    TargetingArrow.NativeFieldInfoPtr_currentHeadStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrow>.NativeClassPtr, nameof (currentHeadStyle));
    TargetingArrow.NativeFieldInfoPtr__bezier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrow>.NativeClassPtr, nameof (_bezier));
    TargetingArrow.NativeMethodInfoPtr_get_headStyleLookup_Private_get_Dictionary_2_String_ArrowHeadStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrow>.NativeClassPtr, 100669434);
    TargetingArrow.NativeMethodInfoPtr_get_bezier_Private_get_Bezier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrow>.NativeClassPtr, 100669435);
    TargetingArrow.NativeMethodInfoPtr_UpdatePosition_Public_Virtual_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrow>.NativeClassPtr, 100669436);
    TargetingArrow.NativeMethodInfoPtr_UpdatePosition_Public_Virtual_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrow>.NativeClassPtr, 100669437);
    TargetingArrow.NativeMethodInfoPtr_EntityHover_Public_Virtual_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrow>.NativeClassPtr, 100669438);
    TargetingArrow.NativeMethodInfoPtr_ContainerHover_Public_Virtual_Void_CardContainer_TargetingArrowSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrow>.NativeClassPtr, 100669439);
    TargetingArrow.NativeMethodInfoPtr_SlotHover_Public_Virtual_Void_CardSlot_TargetingArrowSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrow>.NativeClassPtr, 100669440);
    TargetingArrow.NativeMethodInfoPtr_SetStyle_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrow>.NativeClassPtr, 100669441);
    TargetingArrow.NativeMethodInfoPtr_ResetStyle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrow>.NativeClassPtr, 100669442);
    TargetingArrow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrow>.NativeClassPtr, 100669443);
  }

  public TargetingArrow(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Transform head
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.NativeFieldInfoPtr_head));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float curviness
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.NativeFieldInfoPtr_curviness));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.NativeFieldInfoPtr_curviness)) = value;
    }
  }

  public unsafe float arch
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.NativeFieldInfoPtr_arch));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.NativeFieldInfoPtr_arch)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<TargetingArrow.ArrowHeadStyle> headStyles
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.NativeFieldInfoPtr_headStyles));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<TargetingArrow.ArrowHeadStyle>) null : new Il2CppReferenceArray<TargetingArrow.ArrowHeadStyle>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.NativeFieldInfoPtr_headStyles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string defaultStyleName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.NativeFieldInfoPtr_defaultStyleName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.NativeFieldInfoPtr_defaultStyleName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Dictionary<string, TargetingArrow.ArrowHeadStyle> _headStyleLookup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.NativeFieldInfoPtr__headStyleLookup));
      return pointer == System.IntPtr.Zero ? (Dictionary<string, TargetingArrow.ArrowHeadStyle>) null : new Dictionary<string, TargetingArrow.ArrowHeadStyle>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.NativeFieldInfoPtr__headStyleLookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TargetingArrow.ArrowHeadStyle currentHeadStyle
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.NativeFieldInfoPtr_currentHeadStyle));
      return pointer == System.IntPtr.Zero ? (TargetingArrow.ArrowHeadStyle) null : new TargetingArrow.ArrowHeadStyle(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.NativeFieldInfoPtr_currentHeadStyle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Bezier _bezier
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.NativeFieldInfoPtr__bezier));
      return pointer == System.IntPtr.Zero ? (Bezier) null : new Bezier(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.NativeFieldInfoPtr__bezier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class ArrowHeadStyle : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_gameObject;
    private static readonly System.IntPtr NativeFieldInfoPtr_transform;
    private static readonly System.IntPtr NativeFieldInfoPtr_renderer;
    private static readonly System.IntPtr NativeFieldInfoPtr_directional;
    private static readonly System.IntPtr NativeFieldInfoPtr_headColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_lineColor;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ArrowHeadStyle()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetingArrow.ArrowHeadStyle>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TargetingArrow.ArrowHeadStyle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ArrowHeadStyle()
    {
      Il2CppClassPointerStore<TargetingArrow.ArrowHeadStyle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetingArrow>.NativeClassPtr, nameof (ArrowHeadStyle));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetingArrow.ArrowHeadStyle>.NativeClassPtr);
      TargetingArrow.ArrowHeadStyle.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrow.ArrowHeadStyle>.NativeClassPtr, nameof (name));
      TargetingArrow.ArrowHeadStyle.NativeFieldInfoPtr_gameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrow.ArrowHeadStyle>.NativeClassPtr, nameof (gameObject));
      TargetingArrow.ArrowHeadStyle.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrow.ArrowHeadStyle>.NativeClassPtr, nameof (transform));
      TargetingArrow.ArrowHeadStyle.NativeFieldInfoPtr_renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrow.ArrowHeadStyle>.NativeClassPtr, nameof (renderer));
      TargetingArrow.ArrowHeadStyle.NativeFieldInfoPtr_directional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrow.ArrowHeadStyle>.NativeClassPtr, nameof (directional));
      TargetingArrow.ArrowHeadStyle.NativeFieldInfoPtr_headColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrow.ArrowHeadStyle>.NativeClassPtr, nameof (headColor));
      TargetingArrow.ArrowHeadStyle.NativeFieldInfoPtr_lineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingArrow.ArrowHeadStyle>.NativeClassPtr, nameof (lineColor));
      TargetingArrow.ArrowHeadStyle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingArrow.ArrowHeadStyle>.NativeClassPtr, 100669444);
    }

    public ArrowHeadStyle(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.ArrowHeadStyle.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.ArrowHeadStyle.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe GameObject gameObject
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.ArrowHeadStyle.NativeFieldInfoPtr_gameObject));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.ArrowHeadStyle.NativeFieldInfoPtr_gameObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform transform
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.ArrowHeadStyle.NativeFieldInfoPtr_transform));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.ArrowHeadStyle.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpriteRenderer renderer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.ArrowHeadStyle.NativeFieldInfoPtr_renderer));
        return pointer == System.IntPtr.Zero ? (SpriteRenderer) null : new SpriteRenderer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.ArrowHeadStyle.NativeFieldInfoPtr_renderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool directional
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.ArrowHeadStyle.NativeFieldInfoPtr_directional));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.ArrowHeadStyle.NativeFieldInfoPtr_directional)) = value;
      }
    }

    public unsafe Color headColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.ArrowHeadStyle.NativeFieldInfoPtr_headColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.ArrowHeadStyle.NativeFieldInfoPtr_headColor)) = value;
      }
    }

    public unsafe Gradient lineColor
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.ArrowHeadStyle.NativeFieldInfoPtr_lineColor));
        return pointer == System.IntPtr.Zero ? (Gradient) null : new Gradient(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingArrow.ArrowHeadStyle.NativeFieldInfoPtr_lineColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
