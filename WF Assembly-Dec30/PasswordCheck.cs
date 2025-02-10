// Decompiled with JetBrains decompiler
// Type: PasswordCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public static class PasswordCheck : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPasswordStrength_Public_Static_PasswordStrength_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsStrongPassword_Public_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValidPassword_Public_Static_Boolean_String_PasswordOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValidPassword_Public_Static_Boolean_String_Int32_Int32_Boolean_Boolean_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasMinimumLength_Public_Static_Boolean_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasMinimumUniqueChars_Public_Static_Boolean_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasDigit_Public_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasSpecialChar_Public_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasUpperCaseLetter_Public_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasLowerCaseLetter_Public_Static_Boolean_String_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19954, XrefRangeEnd = 19964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe PasswordCheck.PasswordStrength GetPasswordStrength(string password)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(password)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PasswordCheck.NativeMethodInfoPtr_GetPasswordStrength_Public_Static_PasswordStrength_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(PasswordCheck.PasswordStrength*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19964, XrefRangeEnd = 19967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsStrongPassword(string password)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(password)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PasswordCheck.NativeMethodInfoPtr_IsStrongPassword_Public_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19967, XrefRangeEnd = 19980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsValidPassword(string password, PasswordCheck.PasswordOptions opts)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(password);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &opts;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PasswordCheck.NativeMethodInfoPtr_IsValidPassword_Public_Static_Boolean_String_PasswordOptions_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19980, XrefRangeEnd = 19993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsValidPassword(
    string password,
    int requiredLength,
    int requiredUniqueChars,
    bool requireNonAlphanumeric,
    bool requireLowercase,
    bool requireUppercase,
    bool requireDigit)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(password);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &requiredLength;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &requiredUniqueChars;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &requireNonAlphanumeric;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &requireLowercase;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &requireUppercase;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &requireDigit;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PasswordCheck.NativeMethodInfoPtr_IsValidPassword_Public_Static_Boolean_String_Int32_Int32_Boolean_Boolean_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe bool HasMinimumLength(string password, int minLength)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(password);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &minLength;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PasswordCheck.NativeMethodInfoPtr_HasMinimumLength_Public_Static_Boolean_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19993, XrefRangeEnd = 19999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool HasMinimumUniqueChars(string password, int minUniqueChars)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(password);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &minUniqueChars;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PasswordCheck.NativeMethodInfoPtr_HasMinimumUniqueChars_Public_Static_Boolean_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 20018, RefRangeEnd = 20022, XrefRangeStart = 19999, XrefRangeEnd = 20018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool HasDigit(string password)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(password)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PasswordCheck.NativeMethodInfoPtr_HasDigit_Public_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20022, XrefRangeEnd = 20026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool HasSpecialChar(string password)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(password)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PasswordCheck.NativeMethodInfoPtr_HasSpecialChar_Public_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 20045, RefRangeEnd = 20049, XrefRangeStart = 20026, XrefRangeEnd = 20045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool HasUpperCaseLetter(string password)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(password)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PasswordCheck.NativeMethodInfoPtr_HasUpperCaseLetter_Public_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 20068, RefRangeEnd = 20072, XrefRangeStart = 20049, XrefRangeEnd = 20068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool HasLowerCaseLetter(string password)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(password)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PasswordCheck.NativeMethodInfoPtr_HasLowerCaseLetter_Public_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  static PasswordCheck()
  {
    Il2CppClassPointerStore<PasswordCheck>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (PasswordCheck));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PasswordCheck>.NativeClassPtr);
    PasswordCheck.NativeMethodInfoPtr_GetPasswordStrength_Public_Static_PasswordStrength_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasswordCheck>.NativeClassPtr, 100663741);
    PasswordCheck.NativeMethodInfoPtr_IsStrongPassword_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasswordCheck>.NativeClassPtr, 100663742);
    PasswordCheck.NativeMethodInfoPtr_IsValidPassword_Public_Static_Boolean_String_PasswordOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasswordCheck>.NativeClassPtr, 100663743);
    PasswordCheck.NativeMethodInfoPtr_IsValidPassword_Public_Static_Boolean_String_Int32_Int32_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasswordCheck>.NativeClassPtr, 100663744);
    PasswordCheck.NativeMethodInfoPtr_HasMinimumLength_Public_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasswordCheck>.NativeClassPtr, 100663745);
    PasswordCheck.NativeMethodInfoPtr_HasMinimumUniqueChars_Public_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasswordCheck>.NativeClassPtr, 100663746);
    PasswordCheck.NativeMethodInfoPtr_HasDigit_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasswordCheck>.NativeClassPtr, 100663747);
    PasswordCheck.NativeMethodInfoPtr_HasSpecialChar_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasswordCheck>.NativeClassPtr, 100663748);
    PasswordCheck.NativeMethodInfoPtr_HasUpperCaseLetter_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasswordCheck>.NativeClassPtr, 100663749);
    PasswordCheck.NativeMethodInfoPtr_HasLowerCaseLetter_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasswordCheck>.NativeClassPtr, 100663750);
  }

  public PasswordCheck(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public enum PasswordStrength
  {
    Blank,
    VeryWeak,
    Weak,
    Medium,
    Strong,
    VeryStrong,
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct PasswordOptions
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredUniqueChars;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequireNonAlphanumeric;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequireLowercase;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequireUppercase;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequireDigit;
    [FieldOffset(0)]
    public int RequiredLength;
    [FieldOffset(4)]
    public int RequiredUniqueChars;
    [FieldOffset(8)]
    public bool RequireNonAlphanumeric;
    [FieldOffset(9)]
    public bool RequireLowercase;
    [FieldOffset(10)]
    public bool RequireUppercase;
    [FieldOffset(11)]
    public bool RequireDigit;

    static PasswordOptions()
    {
      Il2CppClassPointerStore<PasswordCheck.PasswordOptions>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PasswordCheck>.NativeClassPtr, nameof (PasswordOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PasswordCheck.PasswordOptions>.NativeClassPtr);
      PasswordCheck.PasswordOptions.NativeFieldInfoPtr_RequiredLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasswordCheck.PasswordOptions>.NativeClassPtr, nameof (RequiredLength));
      PasswordCheck.PasswordOptions.NativeFieldInfoPtr_RequiredUniqueChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasswordCheck.PasswordOptions>.NativeClassPtr, nameof (RequiredUniqueChars));
      PasswordCheck.PasswordOptions.NativeFieldInfoPtr_RequireNonAlphanumeric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasswordCheck.PasswordOptions>.NativeClassPtr, nameof (RequireNonAlphanumeric));
      PasswordCheck.PasswordOptions.NativeFieldInfoPtr_RequireLowercase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasswordCheck.PasswordOptions>.NativeClassPtr, nameof (RequireLowercase));
      PasswordCheck.PasswordOptions.NativeFieldInfoPtr_RequireUppercase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasswordCheck.PasswordOptions>.NativeClassPtr, nameof (RequireUppercase));
      PasswordCheck.PasswordOptions.NativeFieldInfoPtr_RequireDigit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasswordCheck.PasswordOptions>.NativeClassPtr, nameof (RequireDigit));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PasswordCheck.PasswordOptions>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("PasswordCheck/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__10_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__11_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__HasDigit_b__8_0_Internal_Boolean_Char_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__HasUpperCaseLetter_b__10_0_Internal_Boolean_Char_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__HasLowerCaseLetter_b__11_0_Internal_Boolean_Char_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PasswordCheck.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PasswordCheck.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19942, XrefRangeEnd = 19946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _HasDigit_b__8_0(char c)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &c
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PasswordCheck.__c.NativeMethodInfoPtr__HasDigit_b__8_0_Internal_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19946, XrefRangeEnd = 19950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _HasUpperCaseLetter_b__10_0(char c)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &c
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PasswordCheck.__c.NativeMethodInfoPtr__HasUpperCaseLetter_b__10_0_Internal_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19950, XrefRangeEnd = 19954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _HasLowerCaseLetter_b__11_0(char c)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &c
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PasswordCheck.__c.NativeMethodInfoPtr__HasLowerCaseLetter_b__11_0_Internal_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<PasswordCheck.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PasswordCheck>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PasswordCheck.__c>.NativeClassPtr);
      PasswordCheck.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasswordCheck.__c>.NativeClassPtr, "<>9");
      PasswordCheck.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasswordCheck.__c>.NativeClassPtr, "<>9__8_0");
      PasswordCheck.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasswordCheck.__c>.NativeClassPtr, "<>9__10_0");
      PasswordCheck.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasswordCheck.__c>.NativeClassPtr, "<>9__11_0");
      PasswordCheck.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasswordCheck.__c>.NativeClassPtr, 100663752);
      PasswordCheck.__c.NativeMethodInfoPtr__HasDigit_b__8_0_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasswordCheck.__c>.NativeClassPtr, 100663753);
      PasswordCheck.__c.NativeMethodInfoPtr__HasUpperCaseLetter_b__10_0_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasswordCheck.__c>.NativeClassPtr, 100663754);
      PasswordCheck.__c.NativeMethodInfoPtr__HasLowerCaseLetter_b__11_0_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasswordCheck.__c>.NativeClassPtr, 100663755);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe PasswordCheck.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(PasswordCheck.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (PasswordCheck.__c) null : new PasswordCheck.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PasswordCheck.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<char, bool> __9__8_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(PasswordCheck.__c.NativeFieldInfoPtr___9__8_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<char, bool>) null : new Il2CppSystem.Func<char, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PasswordCheck.__c.NativeFieldInfoPtr___9__8_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<char, bool> __9__10_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(PasswordCheck.__c.NativeFieldInfoPtr___9__10_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<char, bool>) null : new Il2CppSystem.Func<char, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PasswordCheck.__c.NativeFieldInfoPtr___9__10_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<char, bool> __9__11_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(PasswordCheck.__c.NativeFieldInfoPtr___9__11_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<char, bool>) null : new Il2CppSystem.Func<char, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PasswordCheck.__c.NativeFieldInfoPtr___9__11_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
