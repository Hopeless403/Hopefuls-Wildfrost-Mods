// Decompiled with JetBrains decompiler
// Type: TouchInputSwitcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
public class TouchInputSwitcher : BaseInputSwitcher
{
  private static readonly IntPtr NativeMethodInfoPtr_CheckSwitchTo_Public_Virtual_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_SwitchTo_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  public override unsafe bool CheckSwitchTo()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TouchInputSwitcher.NativeMethodInfoPtr_CheckSwitchTo_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15504, XrefRangeEnd = 15531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void SwitchTo()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TouchInputSwitcher.NativeMethodInfoPtr_SwitchTo_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TouchInputSwitcher()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchInputSwitcher>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TouchInputSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TouchInputSwitcher()
  {
    Il2CppClassPointerStore<TouchInputSwitcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TouchInputSwitcher));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchInputSwitcher>.NativeClassPtr);
    TouchInputSwitcher.NativeMethodInfoPtr_CheckSwitchTo_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputSwitcher>.NativeClassPtr, 100663350);
    TouchInputSwitcher.NativeMethodInfoPtr_SwitchTo_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputSwitcher>.NativeClassPtr, 100663351);
    TouchInputSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputSwitcher>.NativeClassPtr, 100663352);
  }

  public TouchInputSwitcher(IntPtr pointer)
    : base(pointer)
  {
  }
}
