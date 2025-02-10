// Decompiled with JetBrains decompiler
// Type: TargetingMultiple
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
public class TargetingMultiple : TargetingDisplay
{
  private static readonly IntPtr NativeFieldInfoPtr_targetPrefab;
  private static readonly IntPtr NativeFieldInfoPtr_targets;
  private static readonly IntPtr NativeFieldInfoPtr_target;
  private static readonly IntPtr NativeFieldInfoPtr_entitiesToHit;
  private static readonly IntPtr NativeFieldInfoPtr_showingTargets;
  private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Virtual_Void_TargetingArrowSystem_0;
  private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ContainerHover_Private_Void_CardContainer_0;
  private static readonly IntPtr NativeMethodInfoPtr_ContainerUnHover_Private_Void_CardContainer_0;
  private static readonly IntPtr NativeMethodInfoPtr_ShowTargets_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_HideTargets_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76754, XrefRangeEnd = 76770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Show(TargetingArrowSystem system)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetingMultiple.NativeMethodInfoPtr_Show_Public_Virtual_Void_TargetingArrowSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76770, XrefRangeEnd = 76785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Hide()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetingMultiple.NativeMethodInfoPtr_Hide_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76785, XrefRangeEnd = 76795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ContainerHover(CardContainer cardContainer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardContainer)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingMultiple.NativeMethodInfoPtr_ContainerHover_Private_Void_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76795, XrefRangeEnd = 76819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ContainerUnHover(CardContainer cardContainer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardContainer)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingMultiple.NativeMethodInfoPtr_ContainerUnHover_Private_Void_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76819, XrefRangeEnd = 76834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowTargets()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingMultiple.NativeMethodInfoPtr_ShowTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 76851, RefRangeEnd = 76853, XrefRangeStart = 76834, XrefRangeEnd = 76851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HideTargets()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingMultiple.NativeMethodInfoPtr_HideTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76853, XrefRangeEnd = 76862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TargetingMultiple()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetingMultiple>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetingMultiple.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TargetingMultiple()
  {
    Il2CppClassPointerStore<TargetingMultiple>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TargetingMultiple));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetingMultiple>.NativeClassPtr);
    TargetingMultiple.NativeFieldInfoPtr_targetPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingMultiple>.NativeClassPtr, nameof (targetPrefab));
    TargetingMultiple.NativeFieldInfoPtr_targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingMultiple>.NativeClassPtr, nameof (targets));
    TargetingMultiple.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingMultiple>.NativeClassPtr, nameof (target));
    TargetingMultiple.NativeFieldInfoPtr_entitiesToHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingMultiple>.NativeClassPtr, nameof (entitiesToHit));
    TargetingMultiple.NativeFieldInfoPtr_showingTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetingMultiple>.NativeClassPtr, nameof (showingTargets));
    TargetingMultiple.NativeMethodInfoPtr_Show_Public_Virtual_Void_TargetingArrowSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingMultiple>.NativeClassPtr, 100669474);
    TargetingMultiple.NativeMethodInfoPtr_Hide_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingMultiple>.NativeClassPtr, 100669475);
    TargetingMultiple.NativeMethodInfoPtr_ContainerHover_Private_Void_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingMultiple>.NativeClassPtr, 100669476);
    TargetingMultiple.NativeMethodInfoPtr_ContainerUnHover_Private_Void_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingMultiple>.NativeClassPtr, 100669477);
    TargetingMultiple.NativeMethodInfoPtr_ShowTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingMultiple>.NativeClassPtr, 100669478);
    TargetingMultiple.NativeMethodInfoPtr_HideTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingMultiple>.NativeClassPtr, 100669479);
    TargetingMultiple.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetingMultiple>.NativeClassPtr, 100669480);
  }

  public TargetingMultiple(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe GameObject targetPrefab
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingMultiple.NativeFieldInfoPtr_targetPrefab));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingMultiple.NativeFieldInfoPtr_targetPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameObject> targets
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingMultiple.NativeFieldInfoPtr_targets));
      return pointer == IntPtr.Zero ? (List<GameObject>) null : new List<GameObject>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingMultiple.NativeFieldInfoPtr_targets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Entity target
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingMultiple.NativeFieldInfoPtr_target));
      return pointer == IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingMultiple.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Entity> entitiesToHit
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingMultiple.NativeFieldInfoPtr_entitiesToHit));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Entity>) null : new Il2CppReferenceArray<Entity>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetingMultiple.NativeFieldInfoPtr_entitiesToHit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool showingTargets
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingMultiple.NativeFieldInfoPtr_showingTargets));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetingMultiple.NativeFieldInfoPtr_showingTargets)) = value;
    }
  }
}
