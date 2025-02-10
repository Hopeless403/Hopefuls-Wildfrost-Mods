// Decompiled with JetBrains decompiler
// Type: RunHistorySystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class RunHistorySystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_max;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CampaignEnd_Private_Static_Void_Result_CampaignStats_PlayerData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67989, XrefRangeEnd = 67997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RunHistorySystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67997, XrefRangeEnd = 68005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RunHistorySystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68005, XrefRangeEnd = 68050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CampaignEnd(
    Campaign.Result result,
    CampaignStats stats,
    PlayerData playerData)
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &result;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stats);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) playerData);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RunHistorySystem.NativeMethodInfoPtr_CampaignEnd_Private_Static_Void_Result_CampaignStats_PlayerData_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RunHistorySystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunHistorySystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RunHistorySystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static RunHistorySystem()
  {
    Il2CppClassPointerStore<RunHistorySystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (RunHistorySystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunHistorySystem>.NativeClassPtr);
    RunHistorySystem.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunHistorySystem>.NativeClassPtr, nameof (max));
    RunHistorySystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunHistorySystem>.NativeClassPtr, 100668879);
    RunHistorySystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunHistorySystem>.NativeClassPtr, 100668880);
    RunHistorySystem.NativeMethodInfoPtr_CampaignEnd_Private_Static_Void_Result_CampaignStats_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunHistorySystem>.NativeClassPtr, 100668881);
    RunHistorySystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunHistorySystem>.NativeClassPtr, 100668882);
  }

  public RunHistorySystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe int max
  {
    get
    {
      int max;
      IL2CPP.il2cpp_field_static_get_value(RunHistorySystem.NativeFieldInfoPtr_max, (void*) &max);
      return max;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RunHistorySystem.NativeFieldInfoPtr_max, (void*) &value);
    }
  }
}
