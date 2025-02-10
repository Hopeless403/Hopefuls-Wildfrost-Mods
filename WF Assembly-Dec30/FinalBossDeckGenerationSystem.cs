// Decompiled with JetBrains decompiler
// Type: FinalBossDeckGenerationSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class FinalBossDeckGenerationSystem : GameSystem
{
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CampaignEnd_Private_Static_Void_Result_CampaignStats_PlayerData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckResult_Private_Static_Boolean_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckTrueWin_Private_Static_Boolean_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetNewBoss_Public_Static_Void_PlayerData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RevertToDefaultBoss_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59196, XrefRangeEnd = 59204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossDeckGenerationSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59204, XrefRangeEnd = 59212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossDeckGenerationSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59212, XrefRangeEnd = 59235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CampaignEnd(
    Campaign.Result result,
    CampaignStats stats,
    PlayerData playerData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &result;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stats);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) playerData);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossDeckGenerationSystem.NativeMethodInfoPtr_CampaignEnd_Private_Static_Void_Result_CampaignStats_PlayerData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59235, XrefRangeEnd = 59245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CheckResult(Campaign.Result result)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &result
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossDeckGenerationSystem.NativeMethodInfoPtr_CheckResult_Private_Static_Boolean_Result_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59245, XrefRangeEnd = 59255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CheckTrueWin(Campaign.Result result)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &result
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossDeckGenerationSystem.NativeMethodInfoPtr_CheckTrueWin_Private_Static_Boolean_Result_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 59302, RefRangeEnd = 59304, XrefRangeStart = 59255, XrefRangeEnd = 59302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetNewBoss(PlayerData playerData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) playerData)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossDeckGenerationSystem.NativeMethodInfoPtr_SetNewBoss_Public_Static_Void_PlayerData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59304, XrefRangeEnd = 59319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RevertToDefaultBoss()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossDeckGenerationSystem.NativeMethodInfoPtr_RevertToDefaultBoss_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FinalBossDeckGenerationSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalBossDeckGenerationSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossDeckGenerationSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static FinalBossDeckGenerationSystem()
  {
    Il2CppClassPointerStore<FinalBossDeckGenerationSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (FinalBossDeckGenerationSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBossDeckGenerationSystem>.NativeClassPtr);
    FinalBossDeckGenerationSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossDeckGenerationSystem>.NativeClassPtr, 100668150);
    FinalBossDeckGenerationSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossDeckGenerationSystem>.NativeClassPtr, 100668151);
    FinalBossDeckGenerationSystem.NativeMethodInfoPtr_CampaignEnd_Private_Static_Void_Result_CampaignStats_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossDeckGenerationSystem>.NativeClassPtr, 100668152);
    FinalBossDeckGenerationSystem.NativeMethodInfoPtr_CheckResult_Private_Static_Boolean_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossDeckGenerationSystem>.NativeClassPtr, 100668153);
    FinalBossDeckGenerationSystem.NativeMethodInfoPtr_CheckTrueWin_Private_Static_Boolean_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossDeckGenerationSystem>.NativeClassPtr, 100668154);
    FinalBossDeckGenerationSystem.NativeMethodInfoPtr_SetNewBoss_Public_Static_Void_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossDeckGenerationSystem>.NativeClassPtr, 100668155);
    FinalBossDeckGenerationSystem.NativeMethodInfoPtr_RevertToDefaultBoss_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossDeckGenerationSystem>.NativeClassPtr, 100668156);
    FinalBossDeckGenerationSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossDeckGenerationSystem>.NativeClassPtr, 100668157);
  }

  public FinalBossDeckGenerationSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  [ObfuscatedName("FinalBossDeckGenerationSystem/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__5_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetNewBoss_b__5_0_Internal_String_CardData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalBossDeckGenerationSystem.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FinalBossDeckGenerationSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _SetNewBoss_b__5_0(CardData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(FinalBossDeckGenerationSystem.__c.NativeMethodInfoPtr__SetNewBoss_b__5_0_Internal_String_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static __c()
    {
      Il2CppClassPointerStore<FinalBossDeckGenerationSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalBossDeckGenerationSystem>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBossDeckGenerationSystem.__c>.NativeClassPtr);
      FinalBossDeckGenerationSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossDeckGenerationSystem.__c>.NativeClassPtr, "<>9");
      FinalBossDeckGenerationSystem.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossDeckGenerationSystem.__c>.NativeClassPtr, "<>9__5_0");
      FinalBossDeckGenerationSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossDeckGenerationSystem.__c>.NativeClassPtr, 100668159);
      FinalBossDeckGenerationSystem.__c.NativeMethodInfoPtr__SetNewBoss_b__5_0_Internal_String_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossDeckGenerationSystem.__c>.NativeClassPtr, 100668160);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe FinalBossDeckGenerationSystem.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(FinalBossDeckGenerationSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (FinalBossDeckGenerationSystem.__c) null : new FinalBossDeckGenerationSystem.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FinalBossDeckGenerationSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData, string> __9__5_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(FinalBossDeckGenerationSystem.__c.NativeFieldInfoPtr___9__5_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData, string>) null : new Il2CppSystem.Func<CardData, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FinalBossDeckGenerationSystem.__c.NativeFieldInfoPtr___9__5_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
