// Decompiled with JetBrains decompiler
// Type: DictionaryExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

#nullable disable
public static class DictionaryExt : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveCollection_Public_Static_Il2CppArrayBase_1_T_Dictionary_2_String_Object_String_0;

  [CallerCount(17)]
  [CachedScanResults(RefRangeStart = 101564, RefRangeEnd = 101581, XrefRangeStart = 101559, XrefRangeEnd = 101564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppArrayBase<T> GetSaveCollection<T>(
    this Dictionary<string, Il2CppSystem.Object> dict,
    string key)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dict);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(key);
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DictionaryExt.MethodInfoStoreGeneric_GetSaveCollection_Public_Static_Il2CppArrayBase_1_T_Dictionary_2_String_Object_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(pointer);
  }

  static DictionaryExt()
  {
    Il2CppClassPointerStore<DictionaryExt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (DictionaryExt));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryExt>.NativeClassPtr);
    DictionaryExt.NativeMethodInfoPtr_GetSaveCollection_Public_Static_Il2CppArrayBase_1_T_Dictionary_2_String_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryExt>.NativeClassPtr, 100672409);
  }

  public DictionaryExt(System.IntPtr pointer)
    : base(pointer)
  {
  }

  private sealed class MethodInfoStoreGeneric_GetSaveCollection_Public_Static_Il2CppArrayBase_1_T_Dictionary_2_String_Object_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(DictionaryExt.NativeMethodInfoPtr_GetSaveCollection_Public_Static_Il2CppArrayBase_1_T_Dictionary_2_String_Object_String_0, Il2CppClassPointerStore<DictionaryExt>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
