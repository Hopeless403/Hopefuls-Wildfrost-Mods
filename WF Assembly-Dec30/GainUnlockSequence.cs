// Decompiled with JetBrains decompiler
// Type: GainUnlockSequence
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

#nullable disable
public class GainUnlockSequence : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_titleElement;
  private static readonly IntPtr NativeFieldInfoPtr_descriptionElement;
  private static readonly IntPtr NativeFieldInfoPtr_constructionDisplay;
  private static readonly IntPtr NativeFieldInfoPtr_petHutDisplay;
  private static readonly IntPtr NativeFieldInfoPtr_inventorDisplay;
  private static readonly IntPtr NativeFieldInfoPtr_icebreakerDisplay;
  private static readonly IntPtr NativeFieldInfoPtr_tribeHallDisplay;
  private static readonly IntPtr NativeFieldInfoPtr_hotSpringDisplay;
  private static readonly IntPtr NativeFieldInfoPtr_frostoscopeDisplay;
  private static readonly IntPtr NativeFieldInfoPtr_challengeShrineDisplay;
  private static readonly IntPtr NativeFieldInfoPtr_newItemIcon;
  private static readonly IntPtr NativeFieldInfoPtr_display;
  private static readonly IntPtr NativeMethodInfoPtr_SetUp_Public_Void_UnlockData_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetTitle_Private_Void_UnlockData_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetDisplay_Private_Void_UnlockData_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetDisplay_Private_Void_GameObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetDescription_Private_Void_UnlockData_0;
  private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 99055, RefRangeEnd = 99056, XrefRangeStart = 99026, XrefRangeEnd = 99055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetUp(UnlockData unlockData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) unlockData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GainUnlockSequence.NativeMethodInfoPtr_SetUp_Public_Void_UnlockData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99056, XrefRangeEnd = 99077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetTitle(UnlockData unlockData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) unlockData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GainUnlockSequence.NativeMethodInfoPtr_SetTitle_Private_Void_UnlockData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 99097, RefRangeEnd = 99098, XrefRangeStart = 99077, XrefRangeEnd = 99097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetDisplay(UnlockData unlockData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) unlockData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GainUnlockSequence.NativeMethodInfoPtr_SetDisplay_Private_Void_UnlockData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99098, XrefRangeEnd = 99101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetDisplay(GameObject type)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GainUnlockSequence.NativeMethodInfoPtr_SetDisplay_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99101, XrefRangeEnd = 99106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetDescription(UnlockData unlockData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) unlockData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GainUnlockSequence.NativeMethodInfoPtr_SetDescription_Private_Void_UnlockData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 42411, RefRangeEnd = 42412, XrefRangeStart = 42411, XrefRangeEnd = 42412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Close()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GainUnlockSequence.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GainUnlockSequence()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainUnlockSequence>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GainUnlockSequence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static GainUnlockSequence()
  {
    Il2CppClassPointerStore<GainUnlockSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (GainUnlockSequence));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainUnlockSequence>.NativeClassPtr);
    GainUnlockSequence.NativeFieldInfoPtr_titleElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnlockSequence>.NativeClassPtr, nameof (titleElement));
    GainUnlockSequence.NativeFieldInfoPtr_descriptionElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnlockSequence>.NativeClassPtr, nameof (descriptionElement));
    GainUnlockSequence.NativeFieldInfoPtr_constructionDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnlockSequence>.NativeClassPtr, nameof (constructionDisplay));
    GainUnlockSequence.NativeFieldInfoPtr_petHutDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnlockSequence>.NativeClassPtr, nameof (petHutDisplay));
    GainUnlockSequence.NativeFieldInfoPtr_inventorDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnlockSequence>.NativeClassPtr, nameof (inventorDisplay));
    GainUnlockSequence.NativeFieldInfoPtr_icebreakerDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnlockSequence>.NativeClassPtr, nameof (icebreakerDisplay));
    GainUnlockSequence.NativeFieldInfoPtr_tribeHallDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnlockSequence>.NativeClassPtr, nameof (tribeHallDisplay));
    GainUnlockSequence.NativeFieldInfoPtr_hotSpringDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnlockSequence>.NativeClassPtr, nameof (hotSpringDisplay));
    GainUnlockSequence.NativeFieldInfoPtr_frostoscopeDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnlockSequence>.NativeClassPtr, nameof (frostoscopeDisplay));
    GainUnlockSequence.NativeFieldInfoPtr_challengeShrineDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnlockSequence>.NativeClassPtr, nameof (challengeShrineDisplay));
    GainUnlockSequence.NativeFieldInfoPtr_newItemIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnlockSequence>.NativeClassPtr, nameof (newItemIcon));
    GainUnlockSequence.NativeFieldInfoPtr_display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainUnlockSequence>.NativeClassPtr, nameof (display));
    GainUnlockSequence.NativeMethodInfoPtr_SetUp_Public_Void_UnlockData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnlockSequence>.NativeClassPtr, 100672102);
    GainUnlockSequence.NativeMethodInfoPtr_SetTitle_Private_Void_UnlockData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnlockSequence>.NativeClassPtr, 100672103);
    GainUnlockSequence.NativeMethodInfoPtr_SetDisplay_Private_Void_UnlockData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnlockSequence>.NativeClassPtr, 100672104);
    GainUnlockSequence.NativeMethodInfoPtr_SetDisplay_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnlockSequence>.NativeClassPtr, 100672105);
    GainUnlockSequence.NativeMethodInfoPtr_SetDescription_Private_Void_UnlockData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnlockSequence>.NativeClassPtr, 100672106);
    GainUnlockSequence.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnlockSequence>.NativeClassPtr, 100672107);
    GainUnlockSequence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainUnlockSequence>.NativeClassPtr, 100672108);
  }

  public GainUnlockSequence(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe TMP_Text titleElement
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_titleElement));
      return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_titleElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text descriptionElement
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_descriptionElement));
      return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_descriptionElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject constructionDisplay
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_constructionDisplay));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_constructionDisplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject petHutDisplay
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_petHutDisplay));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_petHutDisplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject inventorDisplay
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_inventorDisplay));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_inventorDisplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject icebreakerDisplay
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_icebreakerDisplay));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_icebreakerDisplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject tribeHallDisplay
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_tribeHallDisplay));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_tribeHallDisplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject hotSpringDisplay
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_hotSpringDisplay));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_hotSpringDisplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject frostoscopeDisplay
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_frostoscopeDisplay));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_frostoscopeDisplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject challengeShrineDisplay
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_challengeShrineDisplay));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_challengeShrineDisplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject newItemIcon
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_newItemIcon));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_newItemIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject display
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_display));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GainUnlockSequence.NativeFieldInfoPtr_display), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
