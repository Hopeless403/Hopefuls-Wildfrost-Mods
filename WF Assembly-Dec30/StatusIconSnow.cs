// Decompiled with JetBrains decompiler
// Type: StatusIconSnow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
public class StatusIconSnow : StatusIcon
{
  private static readonly IntPtr NativeMethodInfoPtr_CustomSetText_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CustomDestroy_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54472, XrefRangeEnd = 54481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CustomSetText()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusIconSnow.NativeMethodInfoPtr_CustomSetText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54481, XrefRangeEnd = 54517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CustomDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusIconSnow.NativeMethodInfoPtr_CustomDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusIconSnow()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusIconSnow>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusIconSnow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatusIconSnow()
  {
    Il2CppClassPointerStore<StatusIconSnow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusIconSnow));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusIconSnow>.NativeClassPtr);
    StatusIconSnow.NativeMethodInfoPtr_CustomSetText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIconSnow>.NativeClassPtr, 100667783);
    StatusIconSnow.NativeMethodInfoPtr_CustomDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIconSnow>.NativeClassPtr, 100667784);
    StatusIconSnow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIconSnow>.NativeClassPtr, 100667785);
  }

  public StatusIconSnow(IntPtr pointer)
    : base(pointer)
  {
  }
}
