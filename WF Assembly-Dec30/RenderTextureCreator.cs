// Decompiled with JetBrains decompiler
// Type: RenderTextureCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.Rendering;

#nullable disable
public class RenderTextureCreator : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_width;
  private static readonly IntPtr NativeFieldInfoPtr_height;
  private static readonly IntPtr NativeFieldInfoPtr_colorFormat;
  private static readonly IntPtr NativeFieldInfoPtr_depthStencilFormat;
  private static readonly IntPtr NativeFieldInfoPtr_mipCount;
  private static readonly IntPtr NativeFieldInfoPtr_destroyOnDisable;
  private static readonly IntPtr NativeFieldInfoPtr_onCreate;
  private static readonly IntPtr NativeFieldInfoPtr_rt;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27676, XrefRangeEnd = 27690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RenderTextureCreator.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27690, XrefRangeEnd = 27695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RenderTextureCreator.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27695, XrefRangeEnd = 27696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureCreator()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTextureCreator>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RenderTextureCreator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static RenderTextureCreator()
  {
    Il2CppClassPointerStore<RenderTextureCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (RenderTextureCreator));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTextureCreator>.NativeClassPtr);
    RenderTextureCreator.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureCreator>.NativeClassPtr, nameof (width));
    RenderTextureCreator.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureCreator>.NativeClassPtr, nameof (height));
    RenderTextureCreator.NativeFieldInfoPtr_colorFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureCreator>.NativeClassPtr, nameof (colorFormat));
    RenderTextureCreator.NativeFieldInfoPtr_depthStencilFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureCreator>.NativeClassPtr, nameof (depthStencilFormat));
    RenderTextureCreator.NativeFieldInfoPtr_mipCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureCreator>.NativeClassPtr, nameof (mipCount));
    RenderTextureCreator.NativeFieldInfoPtr_destroyOnDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureCreator>.NativeClassPtr, nameof (destroyOnDisable));
    RenderTextureCreator.NativeFieldInfoPtr_onCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureCreator>.NativeClassPtr, nameof (onCreate));
    RenderTextureCreator.NativeFieldInfoPtr_rt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureCreator>.NativeClassPtr, nameof (rt));
    RenderTextureCreator.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureCreator>.NativeClassPtr, 100664801);
    RenderTextureCreator.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureCreator>.NativeClassPtr, 100664802);
    RenderTextureCreator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureCreator>.NativeClassPtr, 100664803);
  }

  public RenderTextureCreator(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int width
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTextureCreator.NativeFieldInfoPtr_width));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTextureCreator.NativeFieldInfoPtr_width)) = value;
    }
  }

  public unsafe int height
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTextureCreator.NativeFieldInfoPtr_height));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTextureCreator.NativeFieldInfoPtr_height)) = value;
    }
  }

  public unsafe GraphicsFormat colorFormat
  {
    get
    {
      return *(GraphicsFormat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTextureCreator.NativeFieldInfoPtr_colorFormat));
    }
    [param: In] set
    {
      *(GraphicsFormat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTextureCreator.NativeFieldInfoPtr_colorFormat)) = value;
    }
  }

  public unsafe GraphicsFormat depthStencilFormat
  {
    get
    {
      return *(GraphicsFormat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTextureCreator.NativeFieldInfoPtr_depthStencilFormat));
    }
    [param: In] set
    {
      *(GraphicsFormat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTextureCreator.NativeFieldInfoPtr_depthStencilFormat)) = value;
    }
  }

  public unsafe int mipCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTextureCreator.NativeFieldInfoPtr_mipCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTextureCreator.NativeFieldInfoPtr_mipCount)) = value;
    }
  }

  public unsafe bool destroyOnDisable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTextureCreator.NativeFieldInfoPtr_destroyOnDisable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTextureCreator.NativeFieldInfoPtr_destroyOnDisable)) = value;
    }
  }

  public unsafe UnityEvent<RenderTexture> onCreate
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTextureCreator.NativeFieldInfoPtr_onCreate));
      return pointer == IntPtr.Zero ? (UnityEvent<RenderTexture>) null : new UnityEvent<RenderTexture>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RenderTextureCreator.NativeFieldInfoPtr_onCreate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RenderTexture rt
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTextureCreator.NativeFieldInfoPtr_rt));
      return pointer == IntPtr.Zero ? (RenderTexture) null : new RenderTexture(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RenderTextureCreator.NativeFieldInfoPtr_rt), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
