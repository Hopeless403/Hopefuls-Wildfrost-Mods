// Decompiled with JetBrains decompiler
// Type: DeckpackBlocker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class DeckpackBlocker : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_open;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Block_Public_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Unblock_Public_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetButtonsInteractable_Private_Static_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 89661, RefRangeEnd = 89663, XrefRangeStart = 89654, XrefRangeEnd = 89661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeckpackBlocker.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 89670, RefRangeEnd = 89676, XrefRangeStart = 89663, XrefRangeEnd = 89670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeckpackBlocker.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 89661, RefRangeEnd = 89663, XrefRangeStart = 89661, XrefRangeEnd = 89663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Block()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeckpackBlocker.NativeMethodInfoPtr_Block_Public_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 89670, RefRangeEnd = 89676, XrefRangeStart = 89670, XrefRangeEnd = 89676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Unblock()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeckpackBlocker.NativeMethodInfoPtr_Unblock_Public_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 89684, RefRangeEnd = 89688, XrefRangeStart = 89676, XrefRangeEnd = 89684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetButtonsInteractable(bool interactable)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &interactable
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeckpackBlocker.NativeMethodInfoPtr_SetButtonsInteractable_Private_Static_Void_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DeckpackBlocker()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeckpackBlocker>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeckpackBlocker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static DeckpackBlocker()
  {
    Il2CppClassPointerStore<DeckpackBlocker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (DeckpackBlocker));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeckpackBlocker>.NativeClassPtr);
    DeckpackBlocker.NativeFieldInfoPtr_open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckpackBlocker>.NativeClassPtr, nameof (open));
    DeckpackBlocker.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckpackBlocker>.NativeClassPtr, 100670928);
    DeckpackBlocker.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckpackBlocker>.NativeClassPtr, 100670929);
    DeckpackBlocker.NativeMethodInfoPtr_Block_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckpackBlocker>.NativeClassPtr, 100670930);
    DeckpackBlocker.NativeMethodInfoPtr_Unblock_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckpackBlocker>.NativeClassPtr, 100670931);
    DeckpackBlocker.NativeMethodInfoPtr_SetButtonsInteractable_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckpackBlocker>.NativeClassPtr, 100670932);
    DeckpackBlocker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckpackBlocker>.NativeClassPtr, 100670933);
  }

  public DeckpackBlocker(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe uint open
  {
    get
    {
      uint open;
      IL2CPP.il2cpp_field_static_get_value(DeckpackBlocker.NativeFieldInfoPtr_open, (void*) &open);
      return open;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DeckpackBlocker.NativeFieldInfoPtr_open, (void*) &value);
    }
  }
}
