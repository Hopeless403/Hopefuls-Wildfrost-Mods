// Decompiled with JetBrains decompiler
// Type: ChallengeProgressSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
public class ChallengeProgressSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instance;
  private static readonly System.IntPtr NativeFieldInfoPtr_progress;
  private static readonly System.IntPtr NativeFieldInfoPtr_saveRequired;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetProgress_Public_Static_Int32_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddProgress_Public_Static_Void_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadProgress_Private_Static_List_1_ChallengeProgress_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckSave_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56811, XrefRangeEnd = 56815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeProgressSystem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56815, XrefRangeEnd = 56833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeProgressSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56833, XrefRangeEnd = 56847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeProgressSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 56863, RefRangeEnd = 56865, XrefRangeStart = 56847, XrefRangeEnd = 56863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetProgress(string challengeName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(challengeName)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChallengeProgressSystem.NativeMethodInfoPtr_GetProgress_Public_Static_Int32_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 56908, RefRangeEnd = 56912, XrefRangeStart = 56865, XrefRangeEnd = 56908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddProgress(string challengeName, int add)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(challengeName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &add;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeProgressSystem.NativeMethodInfoPtr_AddProgress_Public_Static_Void_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 56940, RefRangeEnd = 56942, XrefRangeStart = 56912, XrefRangeEnd = 56940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe List<ChallengeProgress> LoadProgress()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChallengeProgressSystem.NativeMethodInfoPtr_LoadProgress_Private_Static_List_1_ChallengeProgress_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<ChallengeProgress>) null : new List<ChallengeProgress>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56942, XrefRangeEnd = 56958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckSave()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeProgressSystem.NativeMethodInfoPtr_CheckSave_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56958, XrefRangeEnd = 56998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Load()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeProgressSystem.NativeMethodInfoPtr_Load_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ChallengeProgressSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeProgressSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeProgressSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ChallengeProgressSystem()
  {
    Il2CppClassPointerStore<ChallengeProgressSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ChallengeProgressSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeProgressSystem>.NativeClassPtr);
    ChallengeProgressSystem.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeProgressSystem>.NativeClassPtr, nameof (instance));
    ChallengeProgressSystem.NativeFieldInfoPtr_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeProgressSystem>.NativeClassPtr, nameof (progress));
    ChallengeProgressSystem.NativeFieldInfoPtr_saveRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeProgressSystem>.NativeClassPtr, nameof (saveRequired));
    ChallengeProgressSystem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressSystem>.NativeClassPtr, 100667948);
    ChallengeProgressSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressSystem>.NativeClassPtr, 100667949);
    ChallengeProgressSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressSystem>.NativeClassPtr, 100667950);
    ChallengeProgressSystem.NativeMethodInfoPtr_GetProgress_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressSystem>.NativeClassPtr, 100667951);
    ChallengeProgressSystem.NativeMethodInfoPtr_AddProgress_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressSystem>.NativeClassPtr, 100667952);
    ChallengeProgressSystem.NativeMethodInfoPtr_LoadProgress_Private_Static_List_1_ChallengeProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressSystem>.NativeClassPtr, 100667953);
    ChallengeProgressSystem.NativeMethodInfoPtr_CheckSave_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressSystem>.NativeClassPtr, 100667954);
    ChallengeProgressSystem.NativeMethodInfoPtr_Load_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressSystem>.NativeClassPtr, 100667955);
    ChallengeProgressSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressSystem>.NativeClassPtr, 100667956);
  }

  public ChallengeProgressSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe ChallengeProgressSystem instance
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ChallengeProgressSystem.NativeFieldInfoPtr_instance, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ChallengeProgressSystem) null : new ChallengeProgressSystem(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ChallengeProgressSystem.NativeFieldInfoPtr_instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ChallengeProgress> progress
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgressSystem.NativeFieldInfoPtr_progress));
      return pointer == System.IntPtr.Zero ? (List<ChallengeProgress>) null : new List<ChallengeProgress>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgressSystem.NativeFieldInfoPtr_progress), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool saveRequired
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgressSystem.NativeFieldInfoPtr_saveRequired));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgressSystem.NativeFieldInfoPtr_saveRequired)) = value;
    }
  }

  [ObfuscatedName("ChallengeProgressSystem/<>c__DisplayClass6_0")]
  public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_challengeName;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetProgress_b__0_Internal_Boolean_ChallengeProgress_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass6_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeProgressSystem.__c__DisplayClass6_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChallengeProgressSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetProgress_b__0(ChallengeProgress a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChallengeProgressSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__GetProgress_b__0_Internal_Boolean_ChallengeProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass6_0()
    {
      Il2CppClassPointerStore<ChallengeProgressSystem.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChallengeProgressSystem>.NativeClassPtr, "<>c__DisplayClass6_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeProgressSystem.__c__DisplayClass6_0>.NativeClassPtr);
      ChallengeProgressSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_challengeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeProgressSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (challengeName));
      ChallengeProgressSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressSystem.__c__DisplayClass6_0>.NativeClassPtr, 100667957);
      ChallengeProgressSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__GetProgress_b__0_Internal_Boolean_ChallengeProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressSystem.__c__DisplayClass6_0>.NativeClassPtr, 100667958);
    }

    public __c__DisplayClass6_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string challengeName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgressSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_challengeName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgressSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_challengeName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  [ObfuscatedName("ChallengeProgressSystem/<>c__DisplayClass7_0")]
  public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_challengeName;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__AddProgress_b__0_Internal_Boolean_ChallengeProgress_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__AddProgress_b__1_Internal_Boolean_ChallengeProgress_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass7_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeProgressSystem.__c__DisplayClass7_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChallengeProgressSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _AddProgress_b__0(ChallengeProgress a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChallengeProgressSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__AddProgress_b__0_Internal_Boolean_ChallengeProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _AddProgress_b__1(ChallengeProgress a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChallengeProgressSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__AddProgress_b__1_Internal_Boolean_ChallengeProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass7_0()
    {
      Il2CppClassPointerStore<ChallengeProgressSystem.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChallengeProgressSystem>.NativeClassPtr, "<>c__DisplayClass7_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeProgressSystem.__c__DisplayClass7_0>.NativeClassPtr);
      ChallengeProgressSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_challengeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeProgressSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (challengeName));
      ChallengeProgressSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressSystem.__c__DisplayClass7_0>.NativeClassPtr, 100667959);
      ChallengeProgressSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__AddProgress_b__0_Internal_Boolean_ChallengeProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressSystem.__c__DisplayClass7_0>.NativeClassPtr, 100667960);
      ChallengeProgressSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__AddProgress_b__1_Internal_Boolean_ChallengeProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressSystem.__c__DisplayClass7_0>.NativeClassPtr, 100667961);
    }

    public __c__DisplayClass7_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string challengeName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgressSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_challengeName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgressSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_challengeName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  [ObfuscatedName("ChallengeProgressSystem/<>c__DisplayClass10_0")]
  public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_inCampaignData;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ChallengeProgress_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass10_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeProgressSystem.__c__DisplayClass10_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChallengeProgressSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56809, XrefRangeEnd = 56811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Load_b__0(ChallengeProgress a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChallengeProgressSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ChallengeProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass10_0()
    {
      Il2CppClassPointerStore<ChallengeProgressSystem.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChallengeProgressSystem>.NativeClassPtr, "<>c__DisplayClass10_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeProgressSystem.__c__DisplayClass10_0>.NativeClassPtr);
      ChallengeProgressSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_inCampaignData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeProgressSystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (inCampaignData));
      ChallengeProgressSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressSystem.__c__DisplayClass10_0>.NativeClassPtr, 100667962);
      ChallengeProgressSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ChallengeProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressSystem.__c__DisplayClass10_0>.NativeClassPtr, 100667963);
    }

    public __c__DisplayClass10_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ChallengeProgress inCampaignData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgressSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_inCampaignData));
        return pointer == System.IntPtr.Zero ? (ChallengeProgress) null : new ChallengeProgress(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgressSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_inCampaignData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
