// Decompiled with JetBrains decompiler
// Type: AchievementsSystem
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
public class AchievementsSystem : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_ChallengeAchievement;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ChallengeCompleted_Private_Static_Void_ChallengeData_0;
  private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Static_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_Achieve_Public_Static_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54739, XrefRangeEnd = 54855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AchievementsSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54855, XrefRangeEnd = 54863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AchievementsSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54863, XrefRangeEnd = 54889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ChallengeCompleted(ChallengeData challengeData)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) challengeData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AchievementsSystem.NativeMethodInfoPtr_ChallengeCompleted_Private_Static_Void_ChallengeData_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54889, XrefRangeEnd = 54909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Check(string challengeName)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(challengeName)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AchievementsSystem.NativeMethodInfoPtr_Check_Public_Static_Void_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 54920, RefRangeEnd = 54921, XrefRangeStart = 54909, XrefRangeEnd = 54920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Achieve(string achievementId)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(achievementId)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AchievementsSystem.NativeMethodInfoPtr_Achieve_Public_Static_Void_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AchievementsSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementsSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AchievementsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static AchievementsSystem()
  {
    Il2CppClassPointerStore<AchievementsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (AchievementsSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementsSystem>.NativeClassPtr);
    AchievementsSystem.NativeFieldInfoPtr_ChallengeAchievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsSystem>.NativeClassPtr, nameof (ChallengeAchievement));
    AchievementsSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsSystem>.NativeClassPtr, 100667813);
    AchievementsSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsSystem>.NativeClassPtr, 100667814);
    AchievementsSystem.NativeMethodInfoPtr_ChallengeCompleted_Private_Static_Void_ChallengeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsSystem>.NativeClassPtr, 100667815);
    AchievementsSystem.NativeMethodInfoPtr_Check_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsSystem>.NativeClassPtr, 100667816);
    AchievementsSystem.NativeMethodInfoPtr_Achieve_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsSystem>.NativeClassPtr, 100667817);
    AchievementsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsSystem>.NativeClassPtr, 100667818);
  }

  public AchievementsSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Dictionary<string, string> ChallengeAchievement
  {
    get
    {
      IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(AchievementsSystem.NativeFieldInfoPtr_ChallengeAchievement, (void*) &num);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Dictionary<string, string>) null : new Dictionary<string, string>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AchievementsSystem.NativeFieldInfoPtr_ChallengeAchievement, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
