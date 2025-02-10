// Decompiled with JetBrains decompiler
// Type: VirtualPointer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
public class VirtualPointer : MonoBehaviourSingleton<VirtualPointer>
{
  private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 20296, RefRangeEnd = 20299, XrefRangeStart = 20286, XrefRangeEnd = 20296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Hide()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VirtualPointer.NativeMethodInfoPtr_Hide_Public_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 20309, RefRangeEnd = 20312, XrefRangeStart = 20299, XrefRangeEnd = 20309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Show()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VirtualPointer.NativeMethodInfoPtr_Show_Public_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20312, XrefRangeEnd = 20319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VirtualPointer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VirtualPointer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VirtualPointer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static VirtualPointer()
  {
    Il2CppClassPointerStore<VirtualPointer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (VirtualPointer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VirtualPointer>.NativeClassPtr);
    VirtualPointer.NativeMethodInfoPtr_Hide_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualPointer>.NativeClassPtr, 100663764);
    VirtualPointer.NativeMethodInfoPtr_Show_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualPointer>.NativeClassPtr, 100663765);
    VirtualPointer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualPointer>.NativeClassPtr, 100663766);
  }

  public VirtualPointer(IntPtr pointer)
    : base(pointer)
  {
  }
}
