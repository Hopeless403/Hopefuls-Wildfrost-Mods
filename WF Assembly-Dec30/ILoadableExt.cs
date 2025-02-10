// Decompiled with JetBrains decompiler
// Type: ILoadableExt
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
public static class ILoadableExt : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadArray_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_TSaveData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadList_Public_Static_List_1_T_Il2CppArrayBase_1_TSaveData_0;

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 101857, RefRangeEnd = 101861, XrefRangeStart = 101856, XrefRangeEnd = 101857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppArrayBase<T> LoadArray<T, TSaveData>(
    this Il2CppArrayBase<TSaveData> data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ILoadableExt.MethodInfoStoreGeneric_LoadArray_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_TSaveData_0<T, TSaveData>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(pointer);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 101867, RefRangeEnd = 101871, XrefRangeStart = 101861, XrefRangeEnd = 101867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe List<T> LoadList<T, TSaveData>(this Il2CppArrayBase<TSaveData> data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ILoadableExt.MethodInfoStoreGeneric_LoadList_Public_Static_List_1_T_Il2CppArrayBase_1_TSaveData_0<T, TSaveData>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<T>) null : new List<T>(pointer);
  }

  static ILoadableExt()
  {
    Il2CppClassPointerStore<ILoadableExt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ILoadableExt));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ILoadableExt>.NativeClassPtr);
    ILoadableExt.NativeMethodInfoPtr_LoadArray_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_TSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILoadableExt>.NativeClassPtr, 100672429);
    ILoadableExt.NativeMethodInfoPtr_LoadList_Public_Static_List_1_T_Il2CppArrayBase_1_TSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILoadableExt>.NativeClassPtr, 100672430);
  }

  public ILoadableExt(System.IntPtr pointer)
    : base(pointer)
  {
  }

  private sealed class MethodInfoStoreGeneric_LoadArray_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_TSaveData_0<T, TSaveData>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ILoadableExt.NativeMethodInfoPtr_LoadArray_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_TSaveData_0, Il2CppClassPointerStore<ILoadableExt>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSaveData>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_LoadList_Public_Static_List_1_T_Il2CppArrayBase_1_TSaveData_0<T, TSaveData>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ILoadableExt.NativeMethodInfoPtr_LoadList_Public_Static_List_1_T_Il2CppArrayBase_1_TSaveData_0, Il2CppClassPointerStore<ILoadableExt>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSaveData>.NativeClassPtr))
    }))));
  }
}
