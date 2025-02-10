// Decompiled with JetBrains decompiler
// Type: PlayerGetGold
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
public class PlayerGetGold : MonoBehaviour
{
  private static readonly IntPtr NativeMethodInfoPtr_GetGold_Public_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53216, XrefRangeEnd = 53224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetGold(int amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &amount
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PlayerGetGold.NativeMethodInfoPtr_GetGold_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerGetGold()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerGetGold>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PlayerGetGold.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static PlayerGetGold()
  {
    Il2CppClassPointerStore<PlayerGetGold>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (PlayerGetGold));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerGetGold>.NativeClassPtr);
    PlayerGetGold.NativeMethodInfoPtr_GetGold_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerGetGold>.NativeClassPtr, 100667591);
    PlayerGetGold.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerGetGold>.NativeClassPtr, 100667592);
  }

  public PlayerGetGold(IntPtr pointer)
    : base(pointer)
  {
  }
}
