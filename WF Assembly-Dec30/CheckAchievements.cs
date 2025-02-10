// Decompiled with JetBrains decompiler
// Type: CheckAchievements
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class CheckAchievements : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_AchievementChallenge;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37936, XrefRangeEnd = 38004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CheckAchievements.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CheckAchievements()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckAchievements>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CheckAchievements.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CheckAchievements()
  {
    Il2CppClassPointerStore<CheckAchievements>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CheckAchievements));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckAchievements>.NativeClassPtr);
    CheckAchievements.NativeFieldInfoPtr_AchievementChallenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckAchievements>.NativeClassPtr, nameof (AchievementChallenge));
    CheckAchievements.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckAchievements>.NativeClassPtr, 100665849);
    CheckAchievements.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckAchievements>.NativeClassPtr, 100665850);
  }

  public CheckAchievements(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Dictionary<string, string> AchievementChallenge
  {
    get
    {
      IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CheckAchievements.NativeFieldInfoPtr_AchievementChallenge, (void*) &num);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Dictionary<string, string>) null : new Dictionary<string, string>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CheckAchievements.NativeFieldInfoPtr_AchievementChallenge, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
