// Decompiled with JetBrains decompiler
// Type: TweenProfile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
[Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct TweenProfile
{
  private static readonly System.IntPtr NativeFieldInfoPtr_ease;
  private static readonly System.IntPtr NativeFieldInfoPtr_duration;
  [FieldOffset(0)]
  public LeanTweenType ease;
  [FieldOffset(4)]
  public float duration;

  static TweenProfile()
  {
    Il2CppClassPointerStore<TweenProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TweenProfile));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenProfile>.NativeClassPtr);
    TweenProfile.NativeFieldInfoPtr_ease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenProfile>.NativeClassPtr, nameof (ease));
    TweenProfile.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenProfile>.NativeClassPtr, nameof (duration));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TweenProfile>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
