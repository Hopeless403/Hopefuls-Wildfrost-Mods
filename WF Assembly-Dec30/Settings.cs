// Decompiled with JetBrains decompiler
// Type: Settings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
public static class Settings : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_settings;
  private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_String_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_T_String_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0;

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 117225, RefRangeEnd = 117229, XrefRangeStart = 117192, XrefRangeEnd = 117225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Save<T>(string key, T value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) value;
      if (!(local2 is string))
      {
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = ptr == System.IntPtr.Zero ? (T&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (T&) ptr : (T&) IL2CPP.il2cpp_object_unbox(ptr));
      }
      else
      {
        // ISSUE: cast to a reference type
        local1 = (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string);
      }
    }
    else
      local1 = ref value;
    *(System.IntPtr*) num = (System.IntPtr) ref local1;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Settings.MethodInfoStoreGeneric_Save_Public_Static_Void_String_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 117246, RefRangeEnd = 117250, XrefRangeStart = 117229, XrefRangeEnd = 117246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T Load<T>(string key, T defaultValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) defaultValue;
      if (!(local2 is string))
      {
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = ptr == System.IntPtr.Zero ? (T&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (T&) ptr : (T&) IL2CPP.il2cpp_object_unbox(ptr));
      }
      else
      {
        // ISSUE: cast to a reference type
        local1 = (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string);
      }
    }
    else
      local1 = ref defaultValue;
    *(System.IntPtr*) num = (System.IntPtr) ref local1;
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(Settings.MethodInfoStoreGeneric_Load_Public_Static_T_String_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 117255, RefRangeEnd = 117256, XrefRangeStart = 117250, XrefRangeEnd = 117255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Exists(string key)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(key)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  static Settings()
  {
    Il2CppClassPointerStore<Settings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Settings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings>.NativeClassPtr);
    Settings.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, nameof (settings));
    Settings.NativeMethodInfoPtr_Save_Public_Static_Void_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100674485);
    Settings.NativeMethodInfoPtr_Load_Public_Static_T_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100674486);
    Settings.NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100674487);
  }

  public Settings(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe ES3Settings settings
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(Settings.NativeFieldInfoPtr_settings, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ES3Settings) null : new ES3Settings(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Settings.NativeFieldInfoPtr_settings, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  private sealed class MethodInfoStoreGeneric_Save_Public_Static_Void_String_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Settings.NativeMethodInfoPtr_Save_Public_Static_Void_String_T_0, Il2CppClassPointerStore<Settings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_Load_Public_Static_T_String_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Settings.NativeMethodInfoPtr_Load_Public_Static_T_String_T_0, Il2CppClassPointerStore<Settings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
