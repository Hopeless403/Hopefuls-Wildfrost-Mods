// Decompiled with JetBrains decompiler
// Type: AssetLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class AssetLoader : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_groups;
  private static readonly System.IntPtr NativeFieldInfoPtr_groupLookup;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Lookup_Public_Static_T_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGroup_Public_Static_Group_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerable_Public_Static_IEnumerable_1_T_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetList_Public_Static_List_1_T_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetArray_Public_Static_Il2CppArrayBase_1_T_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27507, XrefRangeEnd = 27565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AssetLoader.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 27575, RefRangeEnd = 27582, XrefRangeStart = 27565, XrefRangeEnd = 27575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T Lookup<T>(string groupName, string assetName) where T : UnityEngine.Object
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(groupName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(assetName);
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(AssetLoader.MethodInfoStoreGeneric_Lookup_Public_Static_T_String_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 27589, RefRangeEnd = 27591, XrefRangeStart = 27582, XrefRangeEnd = 27589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AssetLoader.Group GetGroup(string groupName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(groupName)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetLoader.NativeMethodInfoPtr_GetGroup_Public_Static_Group_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (AssetLoader.Group) null : new AssetLoader.Group(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27591, XrefRangeEnd = 27592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IEnumerable<T> GetEnumerable<T>(string groupName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(groupName)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetLoader.MethodInfoStoreGeneric_GetEnumerable_Public_Static_IEnumerable_1_T_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerable<T>) null : new IEnumerable<T>(pointer);
  }

  [CallerCount(0)]
  public static unsafe List<T> GetList<T>(string groupName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(groupName)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetLoader.MethodInfoStoreGeneric_GetList_Public_Static_List_1_T_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<T>) null : new List<T>(pointer);
  }

  [CallerCount(0)]
  public static unsafe Il2CppArrayBase<T> GetArray<T>(string groupName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(groupName)
    };
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(AssetLoader.MethodInfoStoreGeneric_GetArray_Public_Static_Il2CppArrayBase_1_T_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(pointer);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AssetLoader()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AssetLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static AssetLoader()
  {
    Il2CppClassPointerStore<AssetLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (AssetLoader));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr);
    AssetLoader.NativeFieldInfoPtr_groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, nameof (groups));
    AssetLoader.NativeFieldInfoPtr_groupLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, nameof (groupLookup));
    AssetLoader.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100664789);
    AssetLoader.NativeMethodInfoPtr_Lookup_Public_Static_T_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100664790);
    AssetLoader.NativeMethodInfoPtr_GetGroup_Public_Static_Group_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100664791);
    AssetLoader.NativeMethodInfoPtr_GetEnumerable_Public_Static_IEnumerable_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100664792);
    AssetLoader.NativeMethodInfoPtr_GetList_Public_Static_List_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100664793);
    AssetLoader.NativeMethodInfoPtr_GetArray_Public_Static_Il2CppArrayBase_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100664794);
    AssetLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100664795);
  }

  public AssetLoader(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<AssetLoader.Group> groups
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetLoader.NativeFieldInfoPtr_groups));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<AssetLoader.Group>) null : new Il2CppReferenceArray<AssetLoader.Group>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AssetLoader.NativeFieldInfoPtr_groups), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<string, AssetLoader.Group> groupLookup
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(AssetLoader.NativeFieldInfoPtr_groupLookup, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<string, AssetLoader.Group>) null : new Dictionary<string, AssetLoader.Group>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AssetLoader.NativeFieldInfoPtr_groupLookup, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class Group : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_assets;
    private static readonly System.IntPtr NativeFieldInfoPtr_lookup;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Group()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetLoader.Group>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AssetLoader.Group.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Group()
    {
      Il2CppClassPointerStore<AssetLoader.Group>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, nameof (Group));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetLoader.Group>.NativeClassPtr);
      AssetLoader.Group.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader.Group>.NativeClassPtr, nameof (name));
      AssetLoader.Group.NativeFieldInfoPtr_assets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader.Group>.NativeClassPtr, nameof (assets));
      AssetLoader.Group.NativeFieldInfoPtr_lookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader.Group>.NativeClassPtr, nameof (lookup));
      AssetLoader.Group.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader.Group>.NativeClassPtr, 100664796);
    }

    public Group(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetLoader.Group.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AssetLoader.Group.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Il2CppReferenceArray<UnityEngine.Object> assets
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetLoader.Group.NativeFieldInfoPtr_assets));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<UnityEngine.Object>) null : new Il2CppReferenceArray<UnityEngine.Object>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AssetLoader.Group.NativeFieldInfoPtr_assets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<string, UnityEngine.Object> lookup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetLoader.Group.NativeFieldInfoPtr_lookup));
        return pointer == System.IntPtr.Zero ? (Dictionary<string, UnityEngine.Object>) null : new Dictionary<string, UnityEngine.Object>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AssetLoader.Group.NativeFieldInfoPtr_lookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_Lookup_Public_Static_T_String_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(AssetLoader.NativeMethodInfoPtr_Lookup_Public_Static_T_String_String_0, Il2CppClassPointerStore<AssetLoader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetEnumerable_Public_Static_IEnumerable_1_T_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(AssetLoader.NativeMethodInfoPtr_GetEnumerable_Public_Static_IEnumerable_1_T_String_0, Il2CppClassPointerStore<AssetLoader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetList_Public_Static_List_1_T_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(AssetLoader.NativeMethodInfoPtr_GetList_Public_Static_List_1_T_String_0, Il2CppClassPointerStore<AssetLoader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetArray_Public_Static_Il2CppArrayBase_1_T_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(AssetLoader.NativeMethodInfoPtr_GetArray_Public_Static_Il2CppArrayBase_1_T_String_0, Il2CppClassPointerStore<AssetLoader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
