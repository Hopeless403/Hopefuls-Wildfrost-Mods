// Decompiled with JetBrains decompiler
// Type: ImageCutout
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
public class ImageCutout : ImageSprite
{
  private static readonly IntPtr NativeMethodInfoPtr_get_materialForRendering_Public_Virtual_get_Material_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public override unsafe Material materialForRendering
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90398, XrefRangeEnd = 90406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ImageCutout.NativeMethodInfoPtr_get_materialForRendering_Public_Virtual_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90406, XrefRangeEnd = 90410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ImageCutout()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageCutout>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ImageCutout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ImageCutout()
  {
    Il2CppClassPointerStore<ImageCutout>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ImageCutout));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageCutout>.NativeClassPtr);
    ImageCutout.NativeMethodInfoPtr_get_materialForRendering_Public_Virtual_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCutout>.NativeClassPtr, 100671057);
    ImageCutout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCutout>.NativeClassPtr, 100671058);
  }

  public ImageCutout(IntPtr pointer)
    : base(pointer)
  {
  }
}
