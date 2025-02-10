// Decompiled with JetBrains decompiler
// Type: ControllerInputSwitcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
public class ControllerInputSwitcher : BaseInputSwitcher
{
  private static readonly IntPtr NativeMethodInfoPtr_CheckSwitchTo_Public_Virtual_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_SwitchTo_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15412, XrefRangeEnd = 15423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool CheckSwitchTo()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerInputSwitcher.NativeMethodInfoPtr_CheckSwitchTo_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15423, XrefRangeEnd = 15453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void SwitchTo()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerInputSwitcher.NativeMethodInfoPtr_SwitchTo_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ControllerInputSwitcher()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerInputSwitcher>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ControllerInputSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ControllerInputSwitcher()
  {
    Il2CppClassPointerStore<ControllerInputSwitcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ControllerInputSwitcher));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerInputSwitcher>.NativeClassPtr);
    ControllerInputSwitcher.NativeMethodInfoPtr_CheckSwitchTo_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerInputSwitcher>.NativeClassPtr, 100663338);
    ControllerInputSwitcher.NativeMethodInfoPtr_SwitchTo_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerInputSwitcher>.NativeClassPtr, 100663339);
    ControllerInputSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerInputSwitcher>.NativeClassPtr, 100663340);
  }

  public ControllerInputSwitcher(IntPtr pointer)
    : base(pointer)
  {
  }
}
