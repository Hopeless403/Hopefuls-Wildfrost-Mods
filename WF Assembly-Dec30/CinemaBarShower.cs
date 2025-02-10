// Decompiled with JetBrains decompiler
// Type: CinemaBarShower
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class CinemaBarShower : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_showOnEnable;
  private static readonly IntPtr NativeFieldInfoPtr_setSortingOrder;
  private static readonly IntPtr NativeFieldInfoPtr_sortingLayer;
  private static readonly IntPtr NativeFieldInfoPtr_orderInLayer;
  private static readonly IntPtr NativeFieldInfoPtr_topText;
  private static readonly IntPtr NativeFieldInfoPtr_topScript;
  private static readonly IntPtr NativeFieldInfoPtr_topPrompt;
  private static readonly IntPtr NativeFieldInfoPtr_topAction;
  private static readonly IntPtr NativeFieldInfoPtr_bottomText;
  private static readonly IntPtr NativeFieldInfoPtr_bottomScript;
  private static readonly IntPtr NativeFieldInfoPtr_bottomPrompt;
  private static readonly IntPtr NativeFieldInfoPtr_bottomAction;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38116, XrefRangeEnd = 38117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CinemaBarShower.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 38134, RefRangeEnd = 38135, XrefRangeStart = 38117, XrefRangeEnd = 38134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Show()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CinemaBarShower.NativeMethodInfoPtr_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 38137, RefRangeEnd = 38138, XrefRangeStart = 38135, XrefRangeEnd = 38137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hide()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CinemaBarShower.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38138, XrefRangeEnd = 38143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemaBarShower()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemaBarShower>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CinemaBarShower.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CinemaBarShower()
  {
    Il2CppClassPointerStore<CinemaBarShower>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CinemaBarShower));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemaBarShower>.NativeClassPtr);
    CinemaBarShower.NativeFieldInfoPtr_showOnEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarShower>.NativeClassPtr, nameof (showOnEnable));
    CinemaBarShower.NativeFieldInfoPtr_setSortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarShower>.NativeClassPtr, nameof (setSortingOrder));
    CinemaBarShower.NativeFieldInfoPtr_sortingLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarShower>.NativeClassPtr, nameof (sortingLayer));
    CinemaBarShower.NativeFieldInfoPtr_orderInLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarShower>.NativeClassPtr, nameof (orderInLayer));
    CinemaBarShower.NativeFieldInfoPtr_topText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarShower>.NativeClassPtr, nameof (topText));
    CinemaBarShower.NativeFieldInfoPtr_topScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarShower>.NativeClassPtr, nameof (topScript));
    CinemaBarShower.NativeFieldInfoPtr_topPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarShower>.NativeClassPtr, nameof (topPrompt));
    CinemaBarShower.NativeFieldInfoPtr_topAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarShower>.NativeClassPtr, nameof (topAction));
    CinemaBarShower.NativeFieldInfoPtr_bottomText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarShower>.NativeClassPtr, nameof (bottomText));
    CinemaBarShower.NativeFieldInfoPtr_bottomScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarShower>.NativeClassPtr, nameof (bottomScript));
    CinemaBarShower.NativeFieldInfoPtr_bottomPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarShower>.NativeClassPtr, nameof (bottomPrompt));
    CinemaBarShower.NativeFieldInfoPtr_bottomAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarShower>.NativeClassPtr, nameof (bottomAction));
    CinemaBarShower.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarShower>.NativeClassPtr, 100665861);
    CinemaBarShower.NativeMethodInfoPtr_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarShower>.NativeClassPtr, 100665862);
    CinemaBarShower.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarShower>.NativeClassPtr, 100665863);
    CinemaBarShower.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarShower>.NativeClassPtr, 100665864);
  }

  public CinemaBarShower(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool showOnEnable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_showOnEnable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_showOnEnable)) = value;
    }
  }

  public unsafe bool setSortingOrder
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_setSortingOrder));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_setSortingOrder)) = value;
    }
  }

  public unsafe string sortingLayer
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_sortingLayer)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_sortingLayer), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int orderInLayer
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_orderInLayer));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_orderInLayer)) = value;
    }
  }

  public unsafe bool topText
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_topText));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_topText)) = value;
    }
  }

  public unsafe LocalizedString topScript
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_topScript));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_topScript), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString topPrompt
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_topPrompt));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_topPrompt), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string topAction
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_topAction)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_topAction), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool bottomText
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_bottomText));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_bottomText)) = value;
    }
  }

  public unsafe LocalizedString bottomScript
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_bottomScript));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_bottomScript), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString bottomPrompt
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_bottomPrompt));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_bottomPrompt), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string bottomAction
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_bottomAction)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarShower.NativeFieldInfoPtr_bottomAction), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
