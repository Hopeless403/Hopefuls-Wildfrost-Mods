// Decompiled with JetBrains decompiler
// Type: LeanTest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
public class LeanTest : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_expected;
  private static readonly System.IntPtr NativeFieldInfoPtr_tests;
  private static readonly System.IntPtr NativeFieldInfoPtr_passes;
  private static readonly System.IntPtr NativeFieldInfoPtr_timeout;
  private static readonly System.IntPtr NativeFieldInfoPtr_timeoutStarted;
  private static readonly System.IntPtr NativeFieldInfoPtr_testsFinished;
  private static readonly System.IntPtr NativeMethodInfoPtr_debug_Public_Static_Void_String_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_expect_Public_Static_Void_Boolean_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_padRight_Public_Static_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_printOutLength_Public_Static_Single_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_formatBC_Public_Static_String_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_formatB_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_formatC_Public_Static_String_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_overview_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128799, XrefRangeEnd = 128803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void debug(string name, bool didPass, string failExplaination = null)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &didPass;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(failExplaination);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTest.NativeMethodInfoPtr_debug_Public_Static_Void_String_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 128926, RefRangeEnd = 128927, XrefRangeStart = 128803, XrefRangeEnd = 128926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void expect(bool didPass, string definition, string failExplaination = null)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &didPass;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(definition);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(failExplaination);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTest.NativeMethodInfoPtr_expect_Public_Static_Void_Boolean_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128927, XrefRangeEnd = 128932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string padRight(int len)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &len
    };
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LeanTest.NativeMethodInfoPtr_padRight_Public_Static_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128932, XrefRangeEnd = 128943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float printOutLength(string str)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(str)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTest.NativeMethodInfoPtr_printOutLength_Public_Static_Single_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 128952, RefRangeEnd = 128954, XrefRangeStart = 128943, XrefRangeEnd = 128952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string formatBC(string str, string color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(str);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(color);
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LeanTest.NativeMethodInfoPtr_formatBC_Public_Static_String_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128954, XrefRangeEnd = 128959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string formatB(string str)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(str)
    };
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LeanTest.NativeMethodInfoPtr_formatB_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 128994, RefRangeEnd = 128996, XrefRangeStart = 128959, XrefRangeEnd = 128994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string formatC(string str, string color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(str);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(color);
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LeanTest.NativeMethodInfoPtr_formatC_Public_Static_String_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 129058, RefRangeEnd = 129059, XrefRangeStart = 128996, XrefRangeEnd = 129058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void overview()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTest.NativeMethodInfoPtr_overview_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1959)]
  [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LeanTest()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanTest>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LeanTest()
  {
    Il2CppClassPointerStore<LeanTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LeanTest));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanTest>.NativeClassPtr);
    LeanTest.NativeFieldInfoPtr_expected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, nameof (expected));
    LeanTest.NativeFieldInfoPtr_tests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, nameof (tests));
    LeanTest.NativeFieldInfoPtr_passes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, nameof (passes));
    LeanTest.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, nameof (timeout));
    LeanTest.NativeFieldInfoPtr_timeoutStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, nameof (timeoutStarted));
    LeanTest.NativeFieldInfoPtr_testsFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, nameof (testsFinished));
    LeanTest.NativeMethodInfoPtr_debug_Public_Static_Void_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100676628);
    LeanTest.NativeMethodInfoPtr_expect_Public_Static_Void_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100676629);
    LeanTest.NativeMethodInfoPtr_padRight_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100676630);
    LeanTest.NativeMethodInfoPtr_printOutLength_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100676631);
    LeanTest.NativeMethodInfoPtr_formatBC_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100676632);
    LeanTest.NativeMethodInfoPtr_formatB_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100676633);
    LeanTest.NativeMethodInfoPtr_formatC_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100676634);
    LeanTest.NativeMethodInfoPtr_overview_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100676635);
    LeanTest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100676636);
  }

  public LeanTest(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe int expected
  {
    get
    {
      int expected;
      IL2CPP.il2cpp_field_static_get_value(LeanTest.NativeFieldInfoPtr_expected, (void*) &expected);
      return expected;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTest.NativeFieldInfoPtr_expected, (void*) &value);
    }
  }

  public static unsafe int tests
  {
    get
    {
      int tests;
      IL2CPP.il2cpp_field_static_get_value(LeanTest.NativeFieldInfoPtr_tests, (void*) &tests);
      return tests;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTest.NativeFieldInfoPtr_tests, (void*) &value);
    }
  }

  public static unsafe int passes
  {
    get
    {
      int passes;
      IL2CPP.il2cpp_field_static_get_value(LeanTest.NativeFieldInfoPtr_passes, (void*) &passes);
      return passes;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTest.NativeFieldInfoPtr_passes, (void*) &value);
    }
  }

  public static unsafe float timeout
  {
    get
    {
      float timeout;
      IL2CPP.il2cpp_field_static_get_value(LeanTest.NativeFieldInfoPtr_timeout, (void*) &timeout);
      return timeout;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTest.NativeFieldInfoPtr_timeout, (void*) &value);
    }
  }

  public static unsafe bool timeoutStarted
  {
    get
    {
      bool timeoutStarted;
      IL2CPP.il2cpp_field_static_get_value(LeanTest.NativeFieldInfoPtr_timeoutStarted, (void*) &timeoutStarted);
      return timeoutStarted;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTest.NativeFieldInfoPtr_timeoutStarted, (void*) &value);
    }
  }

  public static unsafe bool testsFinished
  {
    get
    {
      bool testsFinished;
      IL2CPP.il2cpp_field_static_get_value(LeanTest.NativeFieldInfoPtr_testsFinished, (void*) &testsFinished);
      return testsFinished;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTest.NativeFieldInfoPtr_testsFinished, (void*) &value);
    }
  }
}
