// Decompiled with JetBrains decompiler
// Type: SaveFileChecker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class SaveFileChecker : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_saveRequired;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GainUnlocksFromCompletedChallenges_Private_Static_Void_List_1_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetUnlockAndRequirements_Private_Static_HashSet_1_String_UnlockData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckChallengeUnlocks_Private_Static_Void_List_1_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckUnlockRequirements_Private_Static_Void_List_1_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68919, XrefRangeEnd = 68947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveFileChecker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 69041, RefRangeEnd = 69042, XrefRangeStart = 68947, XrefRangeEnd = 69041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GainUnlocksFromCompletedChallenges(List<string> unlocksList)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) unlocksList)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveFileChecker.NativeMethodInfoPtr_GainUnlocksFromCompletedChallenges_Private_Static_Void_List_1_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 69059, RefRangeEnd = 69061, XrefRangeStart = 69042, XrefRangeEnd = 69059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe HashSet<string> GetUnlockAndRequirements(UnlockData unlockData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) unlockData)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SaveFileChecker.NativeMethodInfoPtr_GetUnlockAndRequirements_Private_Static_HashSet_1_String_UnlockData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (HashSet<string>) null : new HashSet<string>(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 69185, RefRangeEnd = 69186, XrefRangeStart = 69061, XrefRangeEnd = 69185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CheckChallengeUnlocks(List<string> unlocksList)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) unlocksList)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveFileChecker.NativeMethodInfoPtr_CheckChallengeUnlocks_Private_Static_Void_List_1_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 69245, RefRangeEnd = 69246, XrefRangeStart = 69186, XrefRangeEnd = 69245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CheckUnlockRequirements(List<string> unlocksList)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) unlocksList)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveFileChecker.NativeMethodInfoPtr_CheckUnlockRequirements_Private_Static_Void_List_1_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SaveFileChecker()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveFileChecker>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveFileChecker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SaveFileChecker()
  {
    Il2CppClassPointerStore<SaveFileChecker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SaveFileChecker));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveFileChecker>.NativeClassPtr);
    SaveFileChecker.NativeFieldInfoPtr_saveRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveFileChecker>.NativeClassPtr, nameof (saveRequired));
    SaveFileChecker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveFileChecker>.NativeClassPtr, 100668955);
    SaveFileChecker.NativeMethodInfoPtr_GainUnlocksFromCompletedChallenges_Private_Static_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveFileChecker>.NativeClassPtr, 100668956);
    SaveFileChecker.NativeMethodInfoPtr_GetUnlockAndRequirements_Private_Static_HashSet_1_String_UnlockData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveFileChecker>.NativeClassPtr, 100668957);
    SaveFileChecker.NativeMethodInfoPtr_CheckChallengeUnlocks_Private_Static_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveFileChecker>.NativeClassPtr, 100668958);
    SaveFileChecker.NativeMethodInfoPtr_CheckUnlockRequirements_Private_Static_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveFileChecker>.NativeClassPtr, 100668959);
    SaveFileChecker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveFileChecker>.NativeClassPtr, 100668960);
  }

  public SaveFileChecker(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe bool saveRequired
  {
    get
    {
      bool saveRequired;
      IL2CPP.il2cpp_field_static_get_value(SaveFileChecker.NativeFieldInfoPtr_saveRequired, (void*) &saveRequired);
      return saveRequired;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SaveFileChecker.NativeFieldInfoPtr_saveRequired, (void*) &value);
    }
  }

  [ObfuscatedName("SaveFileChecker/<>c__DisplayClass2_0")]
  public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_unlocksList;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GainUnlocksFromCompletedChallenges_b__1_Internal_Boolean_String_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass2_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveFileChecker.__c__DisplayClass2_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SaveFileChecker.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68906, XrefRangeEnd = 68909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GainUnlocksFromCompletedChallenges_b__1(string add)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(add)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SaveFileChecker.__c__DisplayClass2_0.NativeMethodInfoPtr__GainUnlocksFromCompletedChallenges_b__1_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass2_0()
    {
      Il2CppClassPointerStore<SaveFileChecker.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveFileChecker>.NativeClassPtr, "<>c__DisplayClass2_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveFileChecker.__c__DisplayClass2_0>.NativeClassPtr);
      SaveFileChecker.__c__DisplayClass2_0.NativeFieldInfoPtr_unlocksList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveFileChecker.__c__DisplayClass2_0>.NativeClassPtr, nameof (unlocksList));
      SaveFileChecker.__c__DisplayClass2_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveFileChecker.__c__DisplayClass2_0>.NativeClassPtr, "<>9__1");
      SaveFileChecker.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveFileChecker.__c__DisplayClass2_0>.NativeClassPtr, 100668961);
      SaveFileChecker.__c__DisplayClass2_0.NativeMethodInfoPtr__GainUnlocksFromCompletedChallenges_b__1_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveFileChecker.__c__DisplayClass2_0>.NativeClassPtr, 100668962);
    }

    public __c__DisplayClass2_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<string> unlocksList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveFileChecker.__c__DisplayClass2_0.NativeFieldInfoPtr_unlocksList));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveFileChecker.__c__DisplayClass2_0.NativeFieldInfoPtr_unlocksList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Func<string, bool> __9__1
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveFileChecker.__c__DisplayClass2_0.NativeFieldInfoPtr___9__1));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<string, bool>) null : new Il2CppSystem.Func<string, bool>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveFileChecker.__c__DisplayClass2_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SaveFileChecker/<>c__DisplayClass2_1")]
  public sealed class __c__DisplayClass2_1 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_challengeName;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GainUnlocksFromCompletedChallenges_b__0_Internal_Boolean_ChallengeData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass2_1()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveFileChecker.__c__DisplayClass2_1>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SaveFileChecker.__c__DisplayClass2_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GainUnlocksFromCompletedChallenges_b__0(ChallengeData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SaveFileChecker.__c__DisplayClass2_1.NativeMethodInfoPtr__GainUnlocksFromCompletedChallenges_b__0_Internal_Boolean_ChallengeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass2_1()
    {
      Il2CppClassPointerStore<SaveFileChecker.__c__DisplayClass2_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveFileChecker>.NativeClassPtr, "<>c__DisplayClass2_1");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveFileChecker.__c__DisplayClass2_1>.NativeClassPtr);
      SaveFileChecker.__c__DisplayClass2_1.NativeFieldInfoPtr_challengeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveFileChecker.__c__DisplayClass2_1>.NativeClassPtr, nameof (challengeName));
      SaveFileChecker.__c__DisplayClass2_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveFileChecker.__c__DisplayClass2_1>.NativeClassPtr, 100668963);
      SaveFileChecker.__c__DisplayClass2_1.NativeMethodInfoPtr__GainUnlocksFromCompletedChallenges_b__0_Internal_Boolean_ChallengeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveFileChecker.__c__DisplayClass2_1>.NativeClassPtr, 100668964);
    }

    public __c__DisplayClass2_1(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string challengeName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveFileChecker.__c__DisplayClass2_1.NativeFieldInfoPtr_challengeName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveFileChecker.__c__DisplayClass2_1.NativeFieldInfoPtr_challengeName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  [ObfuscatedName("SaveFileChecker/<>c__DisplayClass4_0")]
  public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_completedChallenges;
    private static readonly System.IntPtr NativeFieldInfoPtr_removed;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CheckChallengeUnlocks_b__0_Internal_Boolean_ChallengeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CheckChallengeUnlocks_b__1_Internal_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CheckChallengeUnlocks_b__2_Internal_Boolean_String_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass4_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveFileChecker.__c__DisplayClass4_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SaveFileChecker.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68909, XrefRangeEnd = 68913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _CheckChallengeUnlocks_b__0(ChallengeData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SaveFileChecker.__c__DisplayClass4_0.NativeMethodInfoPtr__CheckChallengeUnlocks_b__0_Internal_Boolean_ChallengeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68913, XrefRangeEnd = 68916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _CheckChallengeUnlocks_b__1(string a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SaveFileChecker.__c__DisplayClass4_0.NativeMethodInfoPtr__CheckChallengeUnlocks_b__1_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68916, XrefRangeEnd = 68919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _CheckChallengeUnlocks_b__2(string a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SaveFileChecker.__c__DisplayClass4_0.NativeMethodInfoPtr__CheckChallengeUnlocks_b__2_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass4_0()
    {
      Il2CppClassPointerStore<SaveFileChecker.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveFileChecker>.NativeClassPtr, "<>c__DisplayClass4_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveFileChecker.__c__DisplayClass4_0>.NativeClassPtr);
      SaveFileChecker.__c__DisplayClass4_0.NativeFieldInfoPtr_completedChallenges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveFileChecker.__c__DisplayClass4_0>.NativeClassPtr, nameof (completedChallenges));
      SaveFileChecker.__c__DisplayClass4_0.NativeFieldInfoPtr_removed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveFileChecker.__c__DisplayClass4_0>.NativeClassPtr, nameof (removed));
      SaveFileChecker.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveFileChecker.__c__DisplayClass4_0>.NativeClassPtr, 100668965);
      SaveFileChecker.__c__DisplayClass4_0.NativeMethodInfoPtr__CheckChallengeUnlocks_b__0_Internal_Boolean_ChallengeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveFileChecker.__c__DisplayClass4_0>.NativeClassPtr, 100668966);
      SaveFileChecker.__c__DisplayClass4_0.NativeMethodInfoPtr__CheckChallengeUnlocks_b__1_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveFileChecker.__c__DisplayClass4_0>.NativeClassPtr, 100668967);
      SaveFileChecker.__c__DisplayClass4_0.NativeMethodInfoPtr__CheckChallengeUnlocks_b__2_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveFileChecker.__c__DisplayClass4_0>.NativeClassPtr, 100668968);
    }

    public __c__DisplayClass4_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<string> completedChallenges
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveFileChecker.__c__DisplayClass4_0.NativeFieldInfoPtr_completedChallenges));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveFileChecker.__c__DisplayClass4_0.NativeFieldInfoPtr_completedChallenges), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<string> removed
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveFileChecker.__c__DisplayClass4_0.NativeFieldInfoPtr_removed));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveFileChecker.__c__DisplayClass4_0.NativeFieldInfoPtr_removed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
