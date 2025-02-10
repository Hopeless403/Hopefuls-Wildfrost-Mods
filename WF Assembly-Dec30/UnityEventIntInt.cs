// Decompiled with JetBrains decompiler
// Type: UnityEventIntInt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine.Events;

#nullable disable
[Serializable]
public class UnityEventIntInt : UnityEvent<int, int>
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101900, XrefRangeEnd = 101903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityEventIntInt()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEventIntInt>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UnityEventIntInt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static UnityEventIntInt()
  {
    Il2CppClassPointerStore<UnityEventIntInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (UnityEventIntInt));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventIntInt>.NativeClassPtr);
    UnityEventIntInt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventIntInt>.NativeClassPtr, 100672440);
  }

  public UnityEventIntInt(IntPtr pointer)
    : base(pointer)
  {
  }
}
