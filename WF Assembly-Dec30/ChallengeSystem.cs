// Decompiled with JetBrains decompiler
// Type: ChallengeSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class ChallengeSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_activeChallenges;
  private static readonly System.IntPtr NativeFieldInfoPtr_saveRequired;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StatChanged_Private_Void_String_String_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OverallStatsChanged_Private_Void_CampaignStats_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckSave_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAllChallenges_Public_Static_IEnumerable_1_ChallengeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56998, XrefRangeEnd = 57095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57095, XrefRangeEnd = 57117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57117, XrefRangeEnd = 57131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StatChanged(string stat, string key, int oldValue, int newValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(stat);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &oldValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &newValue;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeSystem.NativeMethodInfoPtr_StatChanged_Private_Void_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57131, XrefRangeEnd = 57146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OverallStatsChanged(CampaignStats stats)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stats)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeSystem.NativeMethodInfoPtr_OverallStatsChanged_Private_Void_CampaignStats_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 57220, RefRangeEnd = 57221, XrefRangeStart = 57146, XrefRangeEnd = 57220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckSave()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeSystem.NativeMethodInfoPtr_CheckSave_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 57248, RefRangeEnd = 57251, XrefRangeStart = 57221, XrefRangeEnd = 57248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IEnumerable<ChallengeData> GetAllChallenges()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChallengeSystem.NativeMethodInfoPtr_GetAllChallenges_Public_Static_IEnumerable_1_ChallengeData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerable<ChallengeData>) null : new IEnumerable<ChallengeData>(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ChallengeSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ChallengeSystem()
  {
    Il2CppClassPointerStore<ChallengeSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ChallengeSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeSystem>.NativeClassPtr);
    ChallengeSystem.NativeFieldInfoPtr_activeChallenges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeSystem>.NativeClassPtr, nameof (activeChallenges));
    ChallengeSystem.NativeFieldInfoPtr_saveRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeSystem>.NativeClassPtr, nameof (saveRequired));
    ChallengeSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeSystem>.NativeClassPtr, 100667964);
    ChallengeSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeSystem>.NativeClassPtr, 100667965);
    ChallengeSystem.NativeMethodInfoPtr_StatChanged_Private_Void_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeSystem>.NativeClassPtr, 100667966);
    ChallengeSystem.NativeMethodInfoPtr_OverallStatsChanged_Private_Void_CampaignStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeSystem>.NativeClassPtr, 100667967);
    ChallengeSystem.NativeMethodInfoPtr_CheckSave_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeSystem>.NativeClassPtr, 100667968);
    ChallengeSystem.NativeMethodInfoPtr_GetAllChallenges_Public_Static_IEnumerable_1_ChallengeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeSystem>.NativeClassPtr, 100667969);
    ChallengeSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeSystem>.NativeClassPtr, 100667970);
  }

  public ChallengeSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe List<ChallengeData> activeChallenges
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeSystem.NativeFieldInfoPtr_activeChallenges));
      return pointer == System.IntPtr.Zero ? (List<ChallengeData>) null : new List<ChallengeData>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeSystem.NativeFieldInfoPtr_activeChallenges), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ChallengeData> saveRequired
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeSystem.NativeFieldInfoPtr_saveRequired));
      return pointer == System.IntPtr.Zero ? (List<ChallengeData>) null : new List<ChallengeData>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeSystem.NativeFieldInfoPtr_saveRequired), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("ChallengeSystem/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__7_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetAllChallenges_b__7_0_Internal_Boolean_ChallengeData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeSystem.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChallengeSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _GetAllChallenges_b__7_0(ChallengeData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChallengeSystem.__c.NativeMethodInfoPtr__GetAllChallenges_b__7_0_Internal_Boolean_ChallengeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<ChallengeSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChallengeSystem>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeSystem.__c>.NativeClassPtr);
      ChallengeSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeSystem.__c>.NativeClassPtr, "<>9");
      ChallengeSystem.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeSystem.__c>.NativeClassPtr, "<>9__7_0");
      ChallengeSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeSystem.__c>.NativeClassPtr, 100667972);
      ChallengeSystem.__c.NativeMethodInfoPtr__GetAllChallenges_b__7_0_Internal_Boolean_ChallengeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeSystem.__c>.NativeClassPtr, 100667973);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe ChallengeSystem.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ChallengeSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ChallengeSystem.__c) null : new ChallengeSystem.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ChallengeSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<ChallengeData, bool> __9__7_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ChallengeSystem.__c.NativeFieldInfoPtr___9__7_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ChallengeData, bool>) null : new Il2CppSystem.Func<ChallengeData, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ChallengeSystem.__c.NativeFieldInfoPtr___9__7_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
