// Decompiled with JetBrains decompiler
// Type: AddressableVideoClipLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.Video;

#nullable disable
public class AddressableVideoClipLoader : AddressableAssetLoader<VideoClip>
{
  private static readonly IntPtr NativeFieldInfoPtr_videoClipRef;
  private static readonly IntPtr NativeFieldInfoPtr_videoPlayer;
  private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetVideoClip_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__Load_b__2_0_Private_Void_AsyncOperationHandle_1_VideoClip_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27480, XrefRangeEnd = 27495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Load()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AddressableVideoClipLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 27501, RefRangeEnd = 27503, XrefRangeStart = 27495, XrefRangeEnd = 27501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetVideoClip()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressableVideoClipLoader.NativeMethodInfoPtr_SetVideoClip_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27503, XrefRangeEnd = 27506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AddressableVideoClipLoader()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressableVideoClipLoader>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressableVideoClipLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27506, XrefRangeEnd = 27507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _Load_b__2_0(AsyncOperationHandle<VideoClip> _)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) _))
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressableVideoClipLoader.NativeMethodInfoPtr__Load_b__2_0_Private_Void_AsyncOperationHandle_1_VideoClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static AddressableVideoClipLoader()
  {
    Il2CppClassPointerStore<AddressableVideoClipLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (AddressableVideoClipLoader));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressableVideoClipLoader>.NativeClassPtr);
    AddressableVideoClipLoader.NativeFieldInfoPtr_videoClipRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableVideoClipLoader>.NativeClassPtr, nameof (videoClipRef));
    AddressableVideoClipLoader.NativeFieldInfoPtr_videoPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableVideoClipLoader>.NativeClassPtr, nameof (videoPlayer));
    AddressableVideoClipLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableVideoClipLoader>.NativeClassPtr, 100664785);
    AddressableVideoClipLoader.NativeMethodInfoPtr_SetVideoClip_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableVideoClipLoader>.NativeClassPtr, 100664786);
    AddressableVideoClipLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableVideoClipLoader>.NativeClassPtr, 100664787);
    AddressableVideoClipLoader.NativeMethodInfoPtr__Load_b__2_0_Private_Void_AsyncOperationHandle_1_VideoClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableVideoClipLoader>.NativeClassPtr, 100664788);
  }

  public AddressableVideoClipLoader(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe AssetReferenceT<VideoClip> videoClipRef
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableVideoClipLoader.NativeFieldInfoPtr_videoClipRef));
      return pointer == IntPtr.Zero ? (AssetReferenceT<VideoClip>) null : new AssetReferenceT<VideoClip>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddressableVideoClipLoader.NativeFieldInfoPtr_videoClipRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe VideoPlayer videoPlayer
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableVideoClipLoader.NativeFieldInfoPtr_videoPlayer));
      return pointer == IntPtr.Zero ? (VideoPlayer) null : new VideoPlayer(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddressableVideoClipLoader.NativeFieldInfoPtr_videoPlayer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
