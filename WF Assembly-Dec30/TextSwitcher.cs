// Decompiled with JetBrains decompiler
// Type: TextSwitcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
public class TextSwitcher : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_useExistingTextAsFirst;
  private static readonly IntPtr NativeFieldInfoPtr_switchTime;
  private static readonly IntPtr NativeFieldInfoPtr_texts;
  private static readonly IntPtr NativeFieldInfoPtr_i;
  private static readonly IntPtr NativeFieldInfoPtr_t;
  private static readonly IntPtr NativeFieldInfoPtr_tmp;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95636, XrefRangeEnd = 95643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TextSwitcher.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95643, XrefRangeEnd = 95648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TextSwitcher.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95648, XrefRangeEnd = 95649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TextSwitcher()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextSwitcher>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TextSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TextSwitcher()
  {
    Il2CppClassPointerStore<TextSwitcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TextSwitcher));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextSwitcher>.NativeClassPtr);
    TextSwitcher.NativeFieldInfoPtr_useExistingTextAsFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSwitcher>.NativeClassPtr, nameof (useExistingTextAsFirst));
    TextSwitcher.NativeFieldInfoPtr_switchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSwitcher>.NativeClassPtr, nameof (switchTime));
    TextSwitcher.NativeFieldInfoPtr_texts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSwitcher>.NativeClassPtr, nameof (texts));
    TextSwitcher.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSwitcher>.NativeClassPtr, nameof (i));
    TextSwitcher.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSwitcher>.NativeClassPtr, nameof (t));
    TextSwitcher.NativeFieldInfoPtr_tmp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSwitcher>.NativeClassPtr, nameof (tmp));
    TextSwitcher.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSwitcher>.NativeClassPtr, 100671630);
    TextSwitcher.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSwitcher>.NativeClassPtr, 100671631);
    TextSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSwitcher>.NativeClassPtr, 100671632);
  }

  public TextSwitcher(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool useExistingTextAsFirst
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextSwitcher.NativeFieldInfoPtr_useExistingTextAsFirst));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextSwitcher.NativeFieldInfoPtr_useExistingTextAsFirst)) = value;
    }
  }

  public unsafe float switchTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextSwitcher.NativeFieldInfoPtr_switchTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextSwitcher.NativeFieldInfoPtr_switchTime)) = value;
    }
  }

  public unsafe List<string> texts
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextSwitcher.NativeFieldInfoPtr_texts));
      return pointer == IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextSwitcher.NativeFieldInfoPtr_texts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int i
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextSwitcher.NativeFieldInfoPtr_i));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextSwitcher.NativeFieldInfoPtr_i)) = value;
    }
  }

  public unsafe float t
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextSwitcher.NativeFieldInfoPtr_t));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextSwitcher.NativeFieldInfoPtr_t)) = value;
    }
  }

  public unsafe TextMeshProUGUI tmp
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextSwitcher.NativeFieldInfoPtr_tmp));
      return pointer == IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextSwitcher.NativeFieldInfoPtr_tmp), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
