// Decompiled with JetBrains decompiler
// Type: AddressablePrefabLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;

#nullable disable
public class AddressablePrefabLoader : AddressableAssetLoader<GameObject>
{
  private static readonly IntPtr NativeFieldInfoPtr_prefabRef;
  private static readonly IntPtr NativeFieldInfoPtr_setChildIndex;
  private static readonly IntPtr NativeFieldInfoPtr_childIndex;
  private static readonly IntPtr NativeFieldInfoPtr_onLoad;
  private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Loaded_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__Load_b__4_0_Private_Void_AsyncOperationHandle_1_GameObject_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27361, XrefRangeEnd = 27377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Load()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AddressablePrefabLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 27387, RefRangeEnd = 27389, XrefRangeStart = 27377, XrefRangeEnd = 27387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Loaded()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressablePrefabLoader.NativeMethodInfoPtr_Loaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27389, XrefRangeEnd = 27392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AddressablePrefabLoader()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablePrefabLoader>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressablePrefabLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27392, XrefRangeEnd = 27393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _Load_b__4_0(AsyncOperationHandle<GameObject> _)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) _))
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressablePrefabLoader.NativeMethodInfoPtr__Load_b__4_0_Private_Void_AsyncOperationHandle_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static AddressablePrefabLoader()
  {
    Il2CppClassPointerStore<AddressablePrefabLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (AddressablePrefabLoader));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablePrefabLoader>.NativeClassPtr);
    AddressablePrefabLoader.NativeFieldInfoPtr_prefabRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablePrefabLoader>.NativeClassPtr, nameof (prefabRef));
    AddressablePrefabLoader.NativeFieldInfoPtr_setChildIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablePrefabLoader>.NativeClassPtr, nameof (setChildIndex));
    AddressablePrefabLoader.NativeFieldInfoPtr_childIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablePrefabLoader>.NativeClassPtr, nameof (childIndex));
    AddressablePrefabLoader.NativeFieldInfoPtr_onLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablePrefabLoader>.NativeClassPtr, nameof (onLoad));
    AddressablePrefabLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablePrefabLoader>.NativeClassPtr, 100664765);
    AddressablePrefabLoader.NativeMethodInfoPtr_Loaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablePrefabLoader>.NativeClassPtr, 100664766);
    AddressablePrefabLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablePrefabLoader>.NativeClassPtr, 100664767);
    AddressablePrefabLoader.NativeMethodInfoPtr__Load_b__4_0_Private_Void_AsyncOperationHandle_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablePrefabLoader>.NativeClassPtr, 100664768);
  }

  public AddressablePrefabLoader(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe AssetReferenceGameObject prefabRef
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressablePrefabLoader.NativeFieldInfoPtr_prefabRef));
      return pointer == IntPtr.Zero ? (AssetReferenceGameObject) null : new AssetReferenceGameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddressablePrefabLoader.NativeFieldInfoPtr_prefabRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool setChildIndex
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressablePrefabLoader.NativeFieldInfoPtr_setChildIndex));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressablePrefabLoader.NativeFieldInfoPtr_setChildIndex)) = value;
    }
  }

  public unsafe int childIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressablePrefabLoader.NativeFieldInfoPtr_childIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressablePrefabLoader.NativeFieldInfoPtr_childIndex)) = value;
    }
  }

  public unsafe UnityEvent<GameObject> onLoad
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressablePrefabLoader.NativeFieldInfoPtr_onLoad));
      return pointer == IntPtr.Zero ? (UnityEvent<GameObject>) null : new UnityEvent<GameObject>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddressablePrefabLoader.NativeFieldInfoPtr_onLoad), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
