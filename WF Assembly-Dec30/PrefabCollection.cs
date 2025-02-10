// Decompiled with JetBrains decompiler
// Type: PrefabCollection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
public class PrefabCollection : Collection<GameObject>
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109038, XrefRangeEnd = 109041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PrefabCollection()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabCollection>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PrefabCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static PrefabCollection()
  {
    Il2CppClassPointerStore<PrefabCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (PrefabCollection));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabCollection>.NativeClassPtr);
    PrefabCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollection>.NativeClassPtr, 100673357);
  }

  public PrefabCollection(IntPtr pointer)
    : base(pointer)
  {
  }
}
