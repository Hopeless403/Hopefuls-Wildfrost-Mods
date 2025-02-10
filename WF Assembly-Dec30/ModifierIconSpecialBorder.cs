// Decompiled with JetBrains decompiler
// Type: ModifierIconSpecialBorder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class ModifierIconSpecialBorder : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_border;
  private static readonly IntPtr NativeFieldInfoPtr_specialBorder;
  private static readonly IntPtr NativeMethodInfoPtr_SetSpecialBorder_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93260, XrefRangeEnd = 93262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSpecialBorder()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ModifierIconSpecialBorder.NativeMethodInfoPtr_SetSpecialBorder_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ModifierIconSpecialBorder()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifierIconSpecialBorder>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ModifierIconSpecialBorder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ModifierIconSpecialBorder()
  {
    Il2CppClassPointerStore<ModifierIconSpecialBorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ModifierIconSpecialBorder));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifierIconSpecialBorder>.NativeClassPtr);
    ModifierIconSpecialBorder.NativeFieldInfoPtr_border = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierIconSpecialBorder>.NativeClassPtr, nameof (border));
    ModifierIconSpecialBorder.NativeFieldInfoPtr_specialBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierIconSpecialBorder>.NativeClassPtr, nameof (specialBorder));
    ModifierIconSpecialBorder.NativeMethodInfoPtr_SetSpecialBorder_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierIconSpecialBorder>.NativeClassPtr, 100671354);
    ModifierIconSpecialBorder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierIconSpecialBorder>.NativeClassPtr, 100671355);
  }

  public ModifierIconSpecialBorder(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Image border
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIconSpecialBorder.NativeFieldInfoPtr_border));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifierIconSpecialBorder.NativeFieldInfoPtr_border), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite specialBorder
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIconSpecialBorder.NativeFieldInfoPtr_specialBorder));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifierIconSpecialBorder.NativeFieldInfoPtr_specialBorder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
