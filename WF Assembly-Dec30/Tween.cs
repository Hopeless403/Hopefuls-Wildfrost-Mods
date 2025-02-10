// Decompiled with JetBrains decompiler
// Type: Tween
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
[Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct Tween
{
  private static readonly System.IntPtr NativeFieldInfoPtr_ease;
  private static readonly System.IntPtr NativeFieldInfoPtr_dur;
  private static readonly System.IntPtr NativeFieldInfoPtr_hasFrom;
  private static readonly System.IntPtr NativeFieldInfoPtr_scaleFrom;
  private static readonly System.IntPtr NativeFieldInfoPtr_scaleTo;
  private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Void_GameObject_0;
  [FieldOffset(0)]
  public LeanTweenType ease;
  [FieldOffset(4)]
  public float dur;
  [FieldOffset(8)]
  public bool hasFrom;
  [FieldOffset(12)]
  public float scaleFrom;
  [FieldOffset(16)]
  public float scaleTo;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104593, XrefRangeEnd = 104607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Run(GameObject gameObject)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Tween.NativeMethodInfoPtr_Run_Public_Void_GameObject_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Tween()
  {
    Il2CppClassPointerStore<Tween>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Tween));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tween>.NativeClassPtr);
    Tween.NativeFieldInfoPtr_ease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, nameof (ease));
    Tween.NativeFieldInfoPtr_dur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, nameof (dur));
    Tween.NativeFieldInfoPtr_hasFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, nameof (hasFrom));
    Tween.NativeFieldInfoPtr_scaleFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, nameof (scaleFrom));
    Tween.NativeFieldInfoPtr_scaleTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, nameof (scaleTo));
    Tween.NativeMethodInfoPtr_Run_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100672774);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Tween>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
