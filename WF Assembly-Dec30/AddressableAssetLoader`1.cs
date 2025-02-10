// Decompiled with JetBrains decompiler
// Type: AddressableAssetLoader`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

#nullable disable
public class AddressableAssetLoader<T> : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instant;
  private static readonly System.IntPtr NativeFieldInfoPtr_onEnable;
  private static readonly System.IntPtr NativeFieldInfoPtr_releaseOnDisable;
  private static readonly System.IntPtr NativeFieldInfoPtr_operation;
  private static readonly System.IntPtr NativeFieldInfoPtr_loaded;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Protected_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  [CallerCount(0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressableAssetLoader<T>.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressableAssetLoader<T>.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressableAssetLoader<T>.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27352, XrefRangeEnd = 27356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressableAssetLoader<T>.NativeMethodInfoPtr_Release_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(12611)]
  [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Load()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AddressableAssetLoader<T>.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 27357, RefRangeEnd = 27361, XrefRangeStart = 27356, XrefRangeEnd = 27357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AddressableAssetLoader()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressableAssetLoader<T>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressableAssetLoader<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static AddressableAssetLoader()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<AddressableAssetLoader<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AddressableAssetLoader`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressableAssetLoader<T>>.NativeClassPtr);
    AddressableAssetLoader<T>.NativeFieldInfoPtr_instant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableAssetLoader<T>>.NativeClassPtr, nameof (instant));
    AddressableAssetLoader<T>.NativeFieldInfoPtr_onEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableAssetLoader<T>>.NativeClassPtr, nameof (onEnable));
    AddressableAssetLoader<T>.NativeFieldInfoPtr_releaseOnDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableAssetLoader<T>>.NativeClassPtr, nameof (releaseOnDisable));
    AddressableAssetLoader<T>.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableAssetLoader<T>>.NativeClassPtr, nameof (operation));
    AddressableAssetLoader<T>.NativeFieldInfoPtr_loaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableAssetLoader<T>>.NativeClassPtr, nameof (loaded));
    AddressableAssetLoader<T>.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableAssetLoader<T>>.NativeClassPtr, 100664759);
    AddressableAssetLoader<T>.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableAssetLoader<T>>.NativeClassPtr, 100664760);
    AddressableAssetLoader<T>.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableAssetLoader<T>>.NativeClassPtr, 100664761);
    AddressableAssetLoader<T>.NativeMethodInfoPtr_Release_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableAssetLoader<T>>.NativeClassPtr, 100664762);
    AddressableAssetLoader<T>.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableAssetLoader<T>>.NativeClassPtr, 100664763);
    AddressableAssetLoader<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableAssetLoader<T>>.NativeClassPtr, 100664764);
  }

  public AddressableAssetLoader(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool instant
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableAssetLoader<T>.NativeFieldInfoPtr_instant));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableAssetLoader<T>.NativeFieldInfoPtr_instant)) = value;
    }
  }

  public unsafe bool onEnable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableAssetLoader<T>.NativeFieldInfoPtr_onEnable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableAssetLoader<T>.NativeFieldInfoPtr_onEnable)) = value;
    }
  }

  public unsafe bool releaseOnDisable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableAssetLoader<T>.NativeFieldInfoPtr_releaseOnDisable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableAssetLoader<T>.NativeFieldInfoPtr_releaseOnDisable)) = value;
    }
  }

  public AsyncOperationHandle<T> operation
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableAssetLoader<T>.NativeFieldInfoPtr_operation);
      return new AsyncOperationHandle<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<T>>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableAssetLoader<T>.NativeFieldInfoPtr_operation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<T>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe bool loaded
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableAssetLoader<T>.NativeFieldInfoPtr_loaded));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableAssetLoader<T>.NativeFieldInfoPtr_loaded)) = value;
    }
  }
}
