// Decompiled with JetBrains decompiler
// Type: Journal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class Journal : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_openOnEnable;
  private static readonly IntPtr NativeFieldInfoPtr_leftPageGroup;
  private static readonly IntPtr NativeFieldInfoPtr_rightPageGroup;
  private static readonly IntPtr NativeFieldInfoPtr_page;
  private static readonly IntPtr NativeFieldInfoPtr_closeSfxRef;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_PagedOpened_Public_Void_JournalPage_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPageImage_Public_Void_Sprite_0;
  private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90549, XrefRangeEnd = 90561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Journal.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 90594, RefRangeEnd = 90595, XrefRangeStart = 90561, XrefRangeEnd = 90594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PagedOpened(JournalPage page)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) page)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Journal.NativeMethodInfoPtr_PagedOpened_Public_Void_JournalPage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 74905, RefRangeEnd = 74906, XrefRangeStart = 74905, XrefRangeEnd = 74906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPageImage(Sprite sprite)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Journal.NativeMethodInfoPtr_SetPageImage_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90595, XrefRangeEnd = 90599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Close()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Journal.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Journal()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Journal>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Journal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Journal()
  {
    Il2CppClassPointerStore<Journal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Journal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Journal>.NativeClassPtr);
    Journal.NativeFieldInfoPtr_openOnEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Journal>.NativeClassPtr, nameof (openOnEnable));
    Journal.NativeFieldInfoPtr_leftPageGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Journal>.NativeClassPtr, nameof (leftPageGroup));
    Journal.NativeFieldInfoPtr_rightPageGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Journal>.NativeClassPtr, nameof (rightPageGroup));
    Journal.NativeFieldInfoPtr_page = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Journal>.NativeClassPtr, nameof (page));
    Journal.NativeFieldInfoPtr_closeSfxRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Journal>.NativeClassPtr, nameof (closeSfxRef));
    Journal.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Journal>.NativeClassPtr, 100671075);
    Journal.NativeMethodInfoPtr_PagedOpened_Public_Void_JournalPage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Journal>.NativeClassPtr, 100671076);
    Journal.NativeMethodInfoPtr_SetPageImage_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Journal>.NativeClassPtr, 100671077);
    Journal.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Journal>.NativeClassPtr, 100671078);
    Journal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Journal>.NativeClassPtr, 100671079);
  }

  public Journal(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe JournalTab openOnEnable
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Journal.NativeFieldInfoPtr_openOnEnable));
      return pointer == IntPtr.Zero ? (JournalTab) null : new JournalTab(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Journal.NativeFieldInfoPtr_openOnEnable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform leftPageGroup
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Journal.NativeFieldInfoPtr_leftPageGroup));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Journal.NativeFieldInfoPtr_leftPageGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform rightPageGroup
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Journal.NativeFieldInfoPtr_rightPageGroup));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Journal.NativeFieldInfoPtr_rightPageGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image page
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Journal.NativeFieldInfoPtr_page));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Journal.NativeFieldInfoPtr_page), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference closeSfxRef
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Journal.NativeFieldInfoPtr_closeSfxRef));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Journal.NativeFieldInfoPtr_closeSfxRef)) = value;
    }
  }
}
