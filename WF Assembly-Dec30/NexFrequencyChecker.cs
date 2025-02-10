// Decompiled with JetBrains decompiler
// Type: NexFrequencyChecker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
public static class NexFrequencyChecker : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_lookup;
  private static readonly System.IntPtr NativeMethodInfoPtr_Check_Public_Static_Boolean_Function_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116142, XrefRangeEnd = 116155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Check(NexFrequencyChecker.Function functionName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &functionName
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NexFrequencyChecker.NativeMethodInfoPtr_Check_Public_Static_Boolean_Function_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  static NexFrequencyChecker()
  {
    Il2CppClassPointerStore<NexFrequencyChecker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (NexFrequencyChecker));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NexFrequencyChecker>.NativeClassPtr);
    NexFrequencyChecker.NativeFieldInfoPtr_lookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NexFrequencyChecker>.NativeClassPtr, nameof (lookup));
    NexFrequencyChecker.NativeMethodInfoPtr_Check_Public_Static_Boolean_Function_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NexFrequencyChecker>.NativeClassPtr, 100674316);
  }

  public NexFrequencyChecker(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Dictionary<NexFrequencyChecker.Function, NexFrequencyChecker.Profile> lookup
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(NexFrequencyChecker.NativeFieldInfoPtr_lookup, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<NexFrequencyChecker.Function, NexFrequencyChecker.Profile>) null : new Dictionary<NexFrequencyChecker.Function, NexFrequencyChecker.Profile>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NexFrequencyChecker.NativeFieldInfoPtr_lookup, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum Function
  {
    PutScore,
    GetCommonData,
    PutCommonData,
    DeleteCommonData,
    GetRanking,
    GetCategorySetting,
    GetRankingChart,
    GetEstimatedScoreRank,
  }

  public sealed class Profile : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_allowedRequests;
    private static readonly System.IntPtr NativeFieldInfoPtr_cooldownSeconds;
    private static readonly System.IntPtr NativeFieldInfoPtr_requests;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Check_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveInactive_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogRequest_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116119, XrefRangeEnd = 116127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Profile(int allowedRequests, float cooldownSeconds)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NexFrequencyChecker.Profile>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &allowedRequests;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cooldownSeconds;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NexFrequencyChecker.Profile.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116127, XrefRangeEnd = 116130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Check()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NexFrequencyChecker.Profile.NativeMethodInfoPtr_Check_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 116137, RefRangeEnd = 116139, XrefRangeStart = 116130, XrefRangeEnd = 116137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveInactive(float time)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &time
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NexFrequencyChecker.Profile.NativeMethodInfoPtr_RemoveInactive_Private_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116139, XrefRangeEnd = 116142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LogRequest()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NexFrequencyChecker.Profile.NativeMethodInfoPtr_LogRequest_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Profile()
    {
      Il2CppClassPointerStore<NexFrequencyChecker.Profile>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NexFrequencyChecker>.NativeClassPtr, nameof (Profile));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NexFrequencyChecker.Profile>.NativeClassPtr);
      NexFrequencyChecker.Profile.NativeFieldInfoPtr_allowedRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NexFrequencyChecker.Profile>.NativeClassPtr, nameof (allowedRequests));
      NexFrequencyChecker.Profile.NativeFieldInfoPtr_cooldownSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NexFrequencyChecker.Profile>.NativeClassPtr, nameof (cooldownSeconds));
      NexFrequencyChecker.Profile.NativeFieldInfoPtr_requests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NexFrequencyChecker.Profile>.NativeClassPtr, nameof (requests));
      NexFrequencyChecker.Profile.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NexFrequencyChecker.Profile>.NativeClassPtr, 100674318);
      NexFrequencyChecker.Profile.NativeMethodInfoPtr_Check_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NexFrequencyChecker.Profile>.NativeClassPtr, 100674319);
      NexFrequencyChecker.Profile.NativeMethodInfoPtr_RemoveInactive_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NexFrequencyChecker.Profile>.NativeClassPtr, 100674320);
      NexFrequencyChecker.Profile.NativeMethodInfoPtr_LogRequest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NexFrequencyChecker.Profile>.NativeClassPtr, 100674321);
    }

    public Profile(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Profile()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NexFrequencyChecker.Profile>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NexFrequencyChecker.Profile>.NativeClassPtr, data));
    }

    public unsafe int allowedRequests
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NexFrequencyChecker.Profile.NativeFieldInfoPtr_allowedRequests));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NexFrequencyChecker.Profile.NativeFieldInfoPtr_allowedRequests)) = value;
      }
    }

    public unsafe float cooldownSeconds
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NexFrequencyChecker.Profile.NativeFieldInfoPtr_cooldownSeconds));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NexFrequencyChecker.Profile.NativeFieldInfoPtr_cooldownSeconds)) = value;
      }
    }

    public unsafe List<float> requests
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NexFrequencyChecker.Profile.NativeFieldInfoPtr_requests));
        return pointer == System.IntPtr.Zero ? (List<float>) null : new List<float>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NexFrequencyChecker.Profile.NativeFieldInfoPtr_requests), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
