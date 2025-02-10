// Decompiled with JetBrains decompiler
// Type: LeaderNameHistoryEntry
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
public class LeaderNameHistoryEntry : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_offset;
  private static readonly IntPtr NativeFieldInfoPtr_textElement;
  private static readonly IntPtr NativeFieldInfoPtr_scaleCurve;
  private static readonly IntPtr NativeFieldInfoPtr_colour;
  private static readonly IntPtr NativeFieldInfoPtr_missingColour;
  private static readonly IntPtr NativeMethodInfoPtr_Assign_Public_Void_Name_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91550, RefRangeEnd = 91551, XrefRangeStart = 91535, XrefRangeEnd = 91550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Assign(JournalNameHistory.Name name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) name)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderNameHistoryEntry.NativeMethodInfoPtr_Assign_Public_Void_Name_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LeaderNameHistoryEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderNameHistoryEntry>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderNameHistoryEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LeaderNameHistoryEntry()
  {
    Il2CppClassPointerStore<LeaderNameHistoryEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LeaderNameHistoryEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderNameHistoryEntry>.NativeClassPtr);
    LeaderNameHistoryEntry.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderNameHistoryEntry>.NativeClassPtr, nameof (offset));
    LeaderNameHistoryEntry.NativeFieldInfoPtr_textElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderNameHistoryEntry>.NativeClassPtr, nameof (textElement));
    LeaderNameHistoryEntry.NativeFieldInfoPtr_scaleCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderNameHistoryEntry>.NativeClassPtr, nameof (scaleCurve));
    LeaderNameHistoryEntry.NativeFieldInfoPtr_colour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderNameHistoryEntry>.NativeClassPtr, nameof (colour));
    LeaderNameHistoryEntry.NativeFieldInfoPtr_missingColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderNameHistoryEntry>.NativeClassPtr, nameof (missingColour));
    LeaderNameHistoryEntry.NativeMethodInfoPtr_Assign_Public_Void_Name_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderNameHistoryEntry>.NativeClassPtr, 100671176);
    LeaderNameHistoryEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderNameHistoryEntry>.NativeClassPtr, 100671177);
  }

  public LeaderNameHistoryEntry(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Transform offset
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderNameHistoryEntry.NativeFieldInfoPtr_offset));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderNameHistoryEntry.NativeFieldInfoPtr_offset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text textElement
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderNameHistoryEntry.NativeFieldInfoPtr_textElement));
      return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderNameHistoryEntry.NativeFieldInfoPtr_textElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve scaleCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderNameHistoryEntry.NativeFieldInfoPtr_scaleCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderNameHistoryEntry.NativeFieldInfoPtr_scaleCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Gradient colour
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderNameHistoryEntry.NativeFieldInfoPtr_colour));
      return pointer == IntPtr.Zero ? (Gradient) null : new Gradient(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderNameHistoryEntry.NativeFieldInfoPtr_colour), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Gradient missingColour
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderNameHistoryEntry.NativeFieldInfoPtr_missingColour));
      return pointer == IntPtr.Zero ? (Gradient) null : new Gradient(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderNameHistoryEntry.NativeFieldInfoPtr_missingColour), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
