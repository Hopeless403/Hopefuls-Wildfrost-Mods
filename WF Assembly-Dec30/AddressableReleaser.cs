// Decompiled with JetBrains decompiler
// Type: AddressableReleaser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

#nullable disable
public class AddressableReleaser : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_releaseOnDisable;
  private static readonly IntPtr NativeFieldInfoPtr_releaseOnDestroy;
  private static readonly IntPtr NativeFieldInfoPtr__assetsToRelease_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr_handles;
  private static readonly IntPtr NativeMethodInfoPtr_get_assetsToRelease_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_assetsToRelease_Private_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_AsyncOperationHandle_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ReleaseAll_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe int assetsToRelease
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(AddressableReleaser.NativeMethodInfoPtr_get_assetsToRelease_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 27305, RefRangeEnd = 27306, XrefRangeStart = 27305, XrefRangeEnd = 27305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AddressableReleaser.NativeMethodInfoPtr_set_assetsToRelease_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 27308, RefRangeEnd = 27311, XrefRangeStart = 27306, XrefRangeEnd = 27308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Add(AsyncOperationHandle handle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) handle))
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressableReleaser.NativeMethodInfoPtr_Add_Public_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27311, XrefRangeEnd = 27312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressableReleaser.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27312, XrefRangeEnd = 27313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressableReleaser.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 27341, RefRangeEnd = 27343, XrefRangeStart = 27313, XrefRangeEnd = 27341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ReleaseAll()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressableReleaser.NativeMethodInfoPtr_ReleaseAll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27343, XrefRangeEnd = 27352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AddressableReleaser()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressableReleaser>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressableReleaser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static AddressableReleaser()
  {
    Il2CppClassPointerStore<AddressableReleaser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (AddressableReleaser));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressableReleaser>.NativeClassPtr);
    AddressableReleaser.NativeFieldInfoPtr_releaseOnDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableReleaser>.NativeClassPtr, nameof (releaseOnDisable));
    AddressableReleaser.NativeFieldInfoPtr_releaseOnDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableReleaser>.NativeClassPtr, nameof (releaseOnDestroy));
    AddressableReleaser.NativeFieldInfoPtr__assetsToRelease_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableReleaser>.NativeClassPtr, "<assetsToRelease>k__BackingField");
    AddressableReleaser.NativeFieldInfoPtr_handles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableReleaser>.NativeClassPtr, nameof (handles));
    AddressableReleaser.NativeMethodInfoPtr_get_assetsToRelease_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableReleaser>.NativeClassPtr, 100664752);
    AddressableReleaser.NativeMethodInfoPtr_set_assetsToRelease_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableReleaser>.NativeClassPtr, 100664753);
    AddressableReleaser.NativeMethodInfoPtr_Add_Public_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableReleaser>.NativeClassPtr, 100664754);
    AddressableReleaser.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableReleaser>.NativeClassPtr, 100664755);
    AddressableReleaser.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableReleaser>.NativeClassPtr, 100664756);
    AddressableReleaser.NativeMethodInfoPtr_ReleaseAll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableReleaser>.NativeClassPtr, 100664757);
    AddressableReleaser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableReleaser>.NativeClassPtr, 100664758);
  }

  public AddressableReleaser(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool releaseOnDisable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableReleaser.NativeFieldInfoPtr_releaseOnDisable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableReleaser.NativeFieldInfoPtr_releaseOnDisable)) = value;
    }
  }

  public unsafe bool releaseOnDestroy
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableReleaser.NativeFieldInfoPtr_releaseOnDestroy));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableReleaser.NativeFieldInfoPtr_releaseOnDestroy)) = value;
    }
  }

  public unsafe int _assetsToRelease_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableReleaser.NativeFieldInfoPtr__assetsToRelease_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableReleaser.NativeFieldInfoPtr__assetsToRelease_k__BackingField)) = value;
    }
  }

  public unsafe List<AsyncOperationHandle> handles
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableReleaser.NativeFieldInfoPtr_handles));
      return pointer == IntPtr.Zero ? (List<AsyncOperationHandle>) null : new List<AsyncOperationHandle>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddressableReleaser.NativeFieldInfoPtr_handles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
