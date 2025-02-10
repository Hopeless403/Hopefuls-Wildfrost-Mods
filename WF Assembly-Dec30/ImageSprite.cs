// Decompiled with JetBrains decompiler
// Type: ImageSprite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class ImageSprite : Image
{
  private static readonly IntPtr NativeFieldInfoPtr_copySpriteSize;
  private static readonly IntPtr NativeFieldInfoPtr_copySpritePivot;
  private static readonly IntPtr NativeMethodInfoPtr_SetSprite_Public_Void_Sprite_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(17)]
  [CachedScanResults(RefRangeStart = 90490, RefRangeEnd = 90507, XrefRangeStart = 90473, XrefRangeEnd = 90490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSprite(Sprite sprite)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ImageSprite.NativeMethodInfoPtr_SetSprite_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ImageSprite()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageSprite>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ImageSprite.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ImageSprite()
  {
    Il2CppClassPointerStore<ImageSprite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ImageSprite));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageSprite>.NativeClassPtr);
    ImageSprite.NativeFieldInfoPtr_copySpriteSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSprite>.NativeClassPtr, nameof (copySpriteSize));
    ImageSprite.NativeFieldInfoPtr_copySpritePivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSprite>.NativeClassPtr, nameof (copySpritePivot));
    ImageSprite.NativeMethodInfoPtr_SetSprite_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSprite>.NativeClassPtr, 100671068);
    ImageSprite.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSprite>.NativeClassPtr, 100671069);
  }

  public ImageSprite(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool copySpriteSize
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImageSprite.NativeFieldInfoPtr_copySpriteSize));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImageSprite.NativeFieldInfoPtr_copySpriteSize)) = value;
    }
  }

  public unsafe bool copySpritePivot
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImageSprite.NativeFieldInfoPtr_copySpritePivot));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImageSprite.NativeFieldInfoPtr_copySpritePivot)) = value;
    }
  }
}
