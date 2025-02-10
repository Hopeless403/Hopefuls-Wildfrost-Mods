// Decompiled with JetBrains decompiler
// Type: IListExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

#nullable disable
public static class IListExt : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_ToSaveCollectionOfNames_Public_Static_SaveCollection_1_String_IList_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DestroyAllAndClear_Public_Static_Void_IList_1_GameObject_0;

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 101832, RefRangeEnd = 101834, XrefRangeStart = 101830, XrefRangeEnd = 101832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe SaveCollection<string> ToSaveCollectionOfNames<T>(this IList<T> list) where T : UnityEngine.Object
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) list)
    };
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IListExt.MethodInfoStoreGeneric_ToSaveCollectionOfNames_Public_Static_SaveCollection_1_String_IList_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return new SaveCollection<string>(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 101855, RefRangeEnd = 101856, XrefRangeStart = 101834, XrefRangeEnd = 101855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DestroyAllAndClear(this IList<GameObject> list)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) list)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IListExt.NativeMethodInfoPtr_DestroyAllAndClear_Public_Static_Void_IList_1_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static IListExt()
  {
    Il2CppClassPointerStore<IListExt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (IListExt));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IListExt>.NativeClassPtr);
    IListExt.NativeMethodInfoPtr_ToSaveCollectionOfNames_Public_Static_SaveCollection_1_String_IList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IListExt>.NativeClassPtr, 100672427);
    IListExt.NativeMethodInfoPtr_DestroyAllAndClear_Public_Static_Void_IList_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IListExt>.NativeClassPtr, 100672428);
  }

  public IListExt(System.IntPtr pointer)
    : base(pointer)
  {
  }

  private sealed class MethodInfoStoreGeneric_ToSaveCollectionOfNames_Public_Static_SaveCollection_1_String_IList_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(IListExt.NativeMethodInfoPtr_ToSaveCollectionOfNames_Public_Static_SaveCollection_1_String_IList_1_T_0, Il2CppClassPointerStore<IListExt>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
