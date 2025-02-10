// Decompiled with JetBrains decompiler
// Type: RedrawBellStartChargedModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
public class RedrawBellStartChargedModifierSystem : GameSystem
{
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_RedrawBellRevealed_Private_Static_Void_RedrawBellSystem_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65728, XrefRangeEnd = 65736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RedrawBellStartChargedModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65736, XrefRangeEnd = 65744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RedrawBellStartChargedModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65744, XrefRangeEnd = 65746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RedrawBellRevealed(RedrawBellSystem redrawBellSystem)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) redrawBellSystem)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RedrawBellStartChargedModifierSystem.NativeMethodInfoPtr_RedrawBellRevealed_Private_Static_Void_RedrawBellSystem_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RedrawBellStartChargedModifierSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RedrawBellStartChargedModifierSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RedrawBellStartChargedModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static RedrawBellStartChargedModifierSystem()
  {
    Il2CppClassPointerStore<RedrawBellStartChargedModifierSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (RedrawBellStartChargedModifierSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RedrawBellStartChargedModifierSystem>.NativeClassPtr);
    RedrawBellStartChargedModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellStartChargedModifierSystem>.NativeClassPtr, 100668712);
    RedrawBellStartChargedModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellStartChargedModifierSystem>.NativeClassPtr, 100668713);
    RedrawBellStartChargedModifierSystem.NativeMethodInfoPtr_RedrawBellRevealed_Private_Static_Void_RedrawBellSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellStartChargedModifierSystem>.NativeClassPtr, 100668714);
    RedrawBellStartChargedModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellStartChargedModifierSystem>.NativeClassPtr, 100668715);
  }

  public RedrawBellStartChargedModifierSystem(IntPtr pointer)
    : base(pointer)
  {
  }
}
