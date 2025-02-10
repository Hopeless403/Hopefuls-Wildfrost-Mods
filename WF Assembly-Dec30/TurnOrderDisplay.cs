// Decompiled with JetBrains decompiler
// Type: TurnOrderDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class TurnOrderDisplay : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_group;
  private static readonly IntPtr NativeFieldInfoPtr_prefab;
  private static readonly IntPtr NativeFieldInfoPtr_vignette;
  private static readonly IntPtr NativeFieldInfoPtr_musicPitch;
  private static readonly IntPtr NativeFieldInfoPtr_active;
  private static readonly IntPtr NativeFieldInfoPtr_numbers;
  private static readonly IntPtr NativeMethodInfoPtr_Toggle_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Display_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OpenEye_Private_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CloseEye_Private_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateNumber_Private_Void_Entity_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_EntitySelect_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_RedrawBellHit_Private_Void_RedrawBellSystem_0;
  private static readonly IntPtr NativeMethodInfoPtr_DeckpackOpen_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Inspect_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96175, XrefRangeEnd = 96176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Toggle()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TurnOrderDisplay.NativeMethodInfoPtr_Toggle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 96258, RefRangeEnd = 96259, XrefRangeStart = 96176, XrefRangeEnd = 96258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Display()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TurnOrderDisplay.NativeMethodInfoPtr_Display_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 96326, RefRangeEnd = 96332, XrefRangeStart = 96259, XrefRangeEnd = 96326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TurnOrderDisplay.NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96332, XrefRangeEnd = 96340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OpenEye()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TurnOrderDisplay.NativeMethodInfoPtr_OpenEye_Private_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96340, XrefRangeEnd = 96348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CloseEye()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TurnOrderDisplay.NativeMethodInfoPtr_CloseEye_Private_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 96366, RefRangeEnd = 96368, XrefRangeStart = 96348, XrefRangeEnd = 96366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateNumber(Entity entity, int number)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &number;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TurnOrderDisplay.NativeMethodInfoPtr_CreateNumber_Private_Void_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96368, XrefRangeEnd = 96369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntitySelect(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TurnOrderDisplay.NativeMethodInfoPtr_EntitySelect_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RedrawBellHit(RedrawBellSystem redrawBell)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) redrawBell)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TurnOrderDisplay.NativeMethodInfoPtr_RedrawBellHit_Private_Void_RedrawBellSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DeckpackOpen()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TurnOrderDisplay.NativeMethodInfoPtr_DeckpackOpen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Inspect(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TurnOrderDisplay.NativeMethodInfoPtr_Inspect_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96369, XrefRangeEnd = 96378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TurnOrderDisplay()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TurnOrderDisplay>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TurnOrderDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TurnOrderDisplay()
  {
    Il2CppClassPointerStore<TurnOrderDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TurnOrderDisplay));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TurnOrderDisplay>.NativeClassPtr);
    TurnOrderDisplay.NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnOrderDisplay>.NativeClassPtr, nameof (group));
    TurnOrderDisplay.NativeFieldInfoPtr_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnOrderDisplay>.NativeClassPtr, nameof (prefab));
    TurnOrderDisplay.NativeFieldInfoPtr_vignette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnOrderDisplay>.NativeClassPtr, nameof (vignette));
    TurnOrderDisplay.NativeFieldInfoPtr_musicPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnOrderDisplay>.NativeClassPtr, nameof (musicPitch));
    TurnOrderDisplay.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnOrderDisplay>.NativeClassPtr, nameof (active));
    TurnOrderDisplay.NativeFieldInfoPtr_numbers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnOrderDisplay>.NativeClassPtr, nameof (numbers));
    TurnOrderDisplay.NativeMethodInfoPtr_Toggle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnOrderDisplay>.NativeClassPtr, 100671688);
    TurnOrderDisplay.NativeMethodInfoPtr_Display_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnOrderDisplay>.NativeClassPtr, 100671689);
    TurnOrderDisplay.NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnOrderDisplay>.NativeClassPtr, 100671690);
    TurnOrderDisplay.NativeMethodInfoPtr_OpenEye_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnOrderDisplay>.NativeClassPtr, 100671691);
    TurnOrderDisplay.NativeMethodInfoPtr_CloseEye_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnOrderDisplay>.NativeClassPtr, 100671692);
    TurnOrderDisplay.NativeMethodInfoPtr_CreateNumber_Private_Void_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnOrderDisplay>.NativeClassPtr, 100671693);
    TurnOrderDisplay.NativeMethodInfoPtr_EntitySelect_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnOrderDisplay>.NativeClassPtr, 100671694);
    TurnOrderDisplay.NativeMethodInfoPtr_RedrawBellHit_Private_Void_RedrawBellSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnOrderDisplay>.NativeClassPtr, 100671695);
    TurnOrderDisplay.NativeMethodInfoPtr_DeckpackOpen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnOrderDisplay>.NativeClassPtr, 100671696);
    TurnOrderDisplay.NativeMethodInfoPtr_Inspect_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnOrderDisplay>.NativeClassPtr, 100671697);
    TurnOrderDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnOrderDisplay>.NativeClassPtr, 100671698);
  }

  public TurnOrderDisplay(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Transform group
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TurnOrderDisplay.NativeFieldInfoPtr_group));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TurnOrderDisplay.NativeFieldInfoPtr_group), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TurnOrderNumber prefab
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TurnOrderDisplay.NativeFieldInfoPtr_prefab));
      return pointer == IntPtr.Zero ? (TurnOrderNumber) null : new TurnOrderNumber(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TurnOrderDisplay.NativeFieldInfoPtr_prefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CanvasGroup vignette
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TurnOrderDisplay.NativeFieldInfoPtr_vignette));
      return pointer == IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TurnOrderDisplay.NativeFieldInfoPtr_vignette), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float musicPitch
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TurnOrderDisplay.NativeFieldInfoPtr_musicPitch));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TurnOrderDisplay.NativeFieldInfoPtr_musicPitch)) = value;
    }
  }

  public unsafe bool active
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TurnOrderDisplay.NativeFieldInfoPtr_active));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TurnOrderDisplay.NativeFieldInfoPtr_active)) = value;
    }
  }

  public unsafe List<TurnOrderNumber> numbers
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TurnOrderDisplay.NativeFieldInfoPtr_numbers));
      return pointer == IntPtr.Zero ? (List<TurnOrderNumber>) null : new List<TurnOrderNumber>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TurnOrderDisplay.NativeFieldInfoPtr_numbers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
