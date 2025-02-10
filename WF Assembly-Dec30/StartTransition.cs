// Decompiled with JetBrains decompiler
// Type: StartTransition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
public class StartTransition : MonoBehaviour
{
  private static readonly IntPtr NativeMethodInfoPtr_GoTo_Public_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85690, XrefRangeEnd = 85697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GoTo(string sceneName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(sceneName)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StartTransition.NativeMethodInfoPtr_GoTo_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StartTransition()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartTransition>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StartTransition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StartTransition()
  {
    Il2CppClassPointerStore<StartTransition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StartTransition));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartTransition>.NativeClassPtr);
    StartTransition.NativeMethodInfoPtr_GoTo_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartTransition>.NativeClassPtr, 100670467);
    StartTransition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartTransition>.NativeClassPtr, 100670468);
  }

  public StartTransition(IntPtr pointer)
    : base(pointer)
  {
  }
}
