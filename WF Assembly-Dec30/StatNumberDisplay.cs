// Decompiled with JetBrains decompiler
// Type: StatNumberDisplay
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
public class StatNumberDisplay : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_disableIfZero;
  private static readonly IntPtr NativeFieldInfoPtr_statName;
  private static readonly IntPtr NativeFieldInfoPtr_statKey;
  private static readonly IntPtr NativeFieldInfoPtr_text;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95252, XrefRangeEnd = 95256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatNumberDisplay.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95256, XrefRangeEnd = 95265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatNumberDisplay()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatNumberDisplay>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatNumberDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatNumberDisplay()
  {
    Il2CppClassPointerStore<StatNumberDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatNumberDisplay));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatNumberDisplay>.NativeClassPtr);
    StatNumberDisplay.NativeFieldInfoPtr_disableIfZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatNumberDisplay>.NativeClassPtr, nameof (disableIfZero));
    StatNumberDisplay.NativeFieldInfoPtr_statName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatNumberDisplay>.NativeClassPtr, nameof (statName));
    StatNumberDisplay.NativeFieldInfoPtr_statKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatNumberDisplay>.NativeClassPtr, nameof (statKey));
    StatNumberDisplay.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatNumberDisplay>.NativeClassPtr, nameof (text));
    StatNumberDisplay.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatNumberDisplay>.NativeClassPtr, 100671587);
    StatNumberDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatNumberDisplay>.NativeClassPtr, 100671588);
  }

  public StatNumberDisplay(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool disableIfZero
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatNumberDisplay.NativeFieldInfoPtr_disableIfZero));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatNumberDisplay.NativeFieldInfoPtr_disableIfZero)) = value;
    }
  }

  public unsafe string statName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatNumberDisplay.NativeFieldInfoPtr_statName)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatNumberDisplay.NativeFieldInfoPtr_statName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string statKey
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatNumberDisplay.NativeFieldInfoPtr_statKey)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatNumberDisplay.NativeFieldInfoPtr_statKey), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe TMP_Text text
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatNumberDisplay.NativeFieldInfoPtr_text));
      return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatNumberDisplay.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
