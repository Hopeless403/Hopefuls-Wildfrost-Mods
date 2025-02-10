// Decompiled with JetBrains decompiler
// Type: BaseInputSwitcher
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
public class BaseInputSwitcher : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_canSwitchTo;
  private static readonly IntPtr NativeMethodInfoPtr_CheckSwitchTo_Public_Virtual_New_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_SwitchTo_Public_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(126)]
  [CachedScanResults(RefRangeStart = 15285, RefRangeEnd = 15411, XrefRangeStart = 15285, XrefRangeEnd = 15285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool CheckSwitchTo()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseInputSwitcher.NativeMethodInfoPtr_CheckSwitchTo_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(12611)]
  [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SwitchTo()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseInputSwitcher.NativeMethodInfoPtr_SwitchTo_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15411, XrefRangeEnd = 15412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BaseInputSwitcher()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseInputSwitcher>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BaseInputSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BaseInputSwitcher()
  {
    Il2CppClassPointerStore<BaseInputSwitcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BaseInputSwitcher));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseInputSwitcher>.NativeClassPtr);
    BaseInputSwitcher.NativeFieldInfoPtr_canSwitchTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseInputSwitcher>.NativeClassPtr, nameof (canSwitchTo));
    BaseInputSwitcher.NativeMethodInfoPtr_CheckSwitchTo_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputSwitcher>.NativeClassPtr, 100663335);
    BaseInputSwitcher.NativeMethodInfoPtr_SwitchTo_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputSwitcher>.NativeClassPtr, 100663336);
    BaseInputSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputSwitcher>.NativeClassPtr, 100663337);
  }

  public BaseInputSwitcher(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool canSwitchTo
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseInputSwitcher.NativeFieldInfoPtr_canSwitchTo));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseInputSwitcher.NativeFieldInfoPtr_canSwitchTo)) = value;
    }
  }
}
