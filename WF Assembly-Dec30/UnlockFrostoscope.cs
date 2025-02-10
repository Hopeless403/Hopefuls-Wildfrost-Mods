// Decompiled with JetBrains decompiler
// Type: UnlockFrostoscope
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
public class UnlockFrostoscope : MonoBehaviour
{
  private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Void_GameObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_Check_Private_Void_Building_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85578, XrefRangeEnd = 85610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Check(GameObject gameObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UnlockFrostoscope.NativeMethodInfoPtr_Check_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85610, XrefRangeEnd = 85639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Check(Building building)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) building)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UnlockFrostoscope.NativeMethodInfoPtr_Check_Private_Void_Building_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnlockFrostoscope()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnlockFrostoscope>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UnlockFrostoscope.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static UnlockFrostoscope()
  {
    Il2CppClassPointerStore<UnlockFrostoscope>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (UnlockFrostoscope));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnlockFrostoscope>.NativeClassPtr);
    UnlockFrostoscope.NativeMethodInfoPtr_Check_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockFrostoscope>.NativeClassPtr, 100670449);
    UnlockFrostoscope.NativeMethodInfoPtr_Check_Private_Void_Building_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockFrostoscope>.NativeClassPtr, 100670450);
    UnlockFrostoscope.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockFrostoscope>.NativeClassPtr, 100670451);
  }

  public UnlockFrostoscope(IntPtr pointer)
    : base(pointer)
  {
  }
}
