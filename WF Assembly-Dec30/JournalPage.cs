// Decompiled with JetBrains decompiler
// Type: JournalPage
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
public class JournalPage : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_journal;
  private static readonly IntPtr NativeFieldInfoPtr_pageSprite;
  private static readonly IntPtr NativeFieldInfoPtr_alsoOpen;
  private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91952, RefRangeEnd = 91953, XrefRangeStart = 91913, XrefRangeEnd = 91952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Open()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalPage.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 42411, RefRangeEnd = 42412, XrefRangeStart = 42411, XrefRangeEnd = 42412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Close()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalPage.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JournalPage()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalPage>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalPage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static JournalPage()
  {
    Il2CppClassPointerStore<JournalPage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (JournalPage));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalPage>.NativeClassPtr);
    JournalPage.NativeFieldInfoPtr_journal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalPage>.NativeClassPtr, nameof (journal));
    JournalPage.NativeFieldInfoPtr_pageSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalPage>.NativeClassPtr, nameof (pageSprite));
    JournalPage.NativeFieldInfoPtr_alsoOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalPage>.NativeClassPtr, nameof (alsoOpen));
    JournalPage.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalPage>.NativeClassPtr, 100671194);
    JournalPage.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalPage>.NativeClassPtr, 100671195);
    JournalPage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalPage>.NativeClassPtr, 100671196);
  }

  public JournalPage(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Journal journal
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalPage.NativeFieldInfoPtr_journal));
      return pointer == IntPtr.Zero ? (Journal) null : new Journal(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalPage.NativeFieldInfoPtr_journal), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite pageSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalPage.NativeFieldInfoPtr_pageSprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalPage.NativeFieldInfoPtr_pageSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe JournalPage alsoOpen
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalPage.NativeFieldInfoPtr_alsoOpen));
      return pointer == IntPtr.Zero ? (JournalPage) null : new JournalPage(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalPage.NativeFieldInfoPtr_alsoOpen), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
