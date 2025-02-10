// Decompiled with JetBrains decompiler
// Type: StatDisplay
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
using UnityEngine.Localization.Components;

#nullable disable
public class StatDisplay : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_textElement;
  private static readonly IntPtr NativeFieldInfoPtr_localizeStringEvent;
  private static readonly IntPtr NativeFieldInfoPtr_statValue;
  private static readonly IntPtr NativeMethodInfoPtr_Assign_Public_Void_GameStatData_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95242, XrefRangeEnd = 95245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Assign(GameStatData statData, string stringValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) statData);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(stringValue);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatDisplay.NativeMethodInfoPtr_Assign_Public_Void_GameStatData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95245, XrefRangeEnd = 95252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetText(string text)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(text)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatDisplay.NativeMethodInfoPtr_SetText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatDisplay()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatDisplay>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatDisplay()
  {
    Il2CppClassPointerStore<StatDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatDisplay));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatDisplay>.NativeClassPtr);
    StatDisplay.NativeFieldInfoPtr_textElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatDisplay>.NativeClassPtr, nameof (textElement));
    StatDisplay.NativeFieldInfoPtr_localizeStringEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatDisplay>.NativeClassPtr, nameof (localizeStringEvent));
    StatDisplay.NativeFieldInfoPtr_statValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatDisplay>.NativeClassPtr, nameof (statValue));
    StatDisplay.NativeMethodInfoPtr_Assign_Public_Void_GameStatData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatDisplay>.NativeClassPtr, 100671584);
    StatDisplay.NativeMethodInfoPtr_SetText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatDisplay>.NativeClassPtr, 100671585);
    StatDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatDisplay>.NativeClassPtr, 100671586);
  }

  public StatDisplay(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe TMP_Text textElement
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatDisplay.NativeFieldInfoPtr_textElement));
      return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatDisplay.NativeFieldInfoPtr_textElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizeStringEvent localizeStringEvent
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatDisplay.NativeFieldInfoPtr_localizeStringEvent));
      return pointer == IntPtr.Zero ? (LocalizeStringEvent) null : new LocalizeStringEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatDisplay.NativeFieldInfoPtr_localizeStringEvent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string statValue
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatDisplay.NativeFieldInfoPtr_statValue)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatDisplay.NativeFieldInfoPtr_statValue), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
