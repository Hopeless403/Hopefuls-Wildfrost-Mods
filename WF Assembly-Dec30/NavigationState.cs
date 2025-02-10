// Decompiled with JetBrains decompiler
// Type: NavigationState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
public static class NavigationState : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_stateHistory;
  private static readonly System.IntPtr NativeMethodInfoPtr_PeekCurrentState_Private_Static_INavigationState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PopCurrentState_Private_Static_INavigationState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Static_Void_INavigationState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BackToPreviousState_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Static_Void_0;

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 15573, RefRangeEnd = 15577, XrefRangeStart = 15563, XrefRangeEnd = 15573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe INavigationState PeekCurrentState()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NavigationState.NativeMethodInfoPtr_PeekCurrentState_Private_Static_INavigationState_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (INavigationState) null : new INavigationState(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15577, XrefRangeEnd = 15587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe INavigationState PopCurrentState()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NavigationState.NativeMethodInfoPtr_PopCurrentState_Private_Static_INavigationState_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (INavigationState) null : new INavigationState(pointer);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 15602, RefRangeEnd = 15609, XrefRangeStart = 15587, XrefRangeEnd = 15602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Start(INavigationState state)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) state)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NavigationState.NativeMethodInfoPtr_Start_Public_Static_Void_INavigationState_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 15634, RefRangeEnd = 15641, XrefRangeStart = 15609, XrefRangeEnd = 15634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void BackToPreviousState()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NavigationState.NativeMethodInfoPtr_BackToPreviousState_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 15667, RefRangeEnd = 15668, XrefRangeStart = 15641, XrefRangeEnd = 15667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Reset()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NavigationState.NativeMethodInfoPtr_Reset_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static NavigationState()
  {
    Il2CppClassPointerStore<NavigationState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (NavigationState));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationState>.NativeClassPtr);
    NavigationState.NativeFieldInfoPtr_stateHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationState>.NativeClassPtr, nameof (stateHistory));
    NavigationState.NativeMethodInfoPtr_PeekCurrentState_Private_Static_INavigationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationState>.NativeClassPtr, 100663358);
    NavigationState.NativeMethodInfoPtr_PopCurrentState_Private_Static_INavigationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationState>.NativeClassPtr, 100663359);
    NavigationState.NativeMethodInfoPtr_Start_Public_Static_Void_INavigationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationState>.NativeClassPtr, 100663360);
    NavigationState.NativeMethodInfoPtr_BackToPreviousState_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationState>.NativeClassPtr, 100663361);
    NavigationState.NativeMethodInfoPtr_Reset_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationState>.NativeClassPtr, 100663362);
  }

  public NavigationState(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Stack<INavigationState> stateHistory
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(NavigationState.NativeFieldInfoPtr_stateHistory, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Stack<INavigationState>) null : new Stack<INavigationState>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NavigationState.NativeFieldInfoPtr_stateHistory, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
