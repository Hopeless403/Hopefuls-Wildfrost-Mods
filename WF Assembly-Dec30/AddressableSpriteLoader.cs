// Decompiled with JetBrains decompiler
// Type: AddressableSpriteLoader
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
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

#nullable disable
public class AddressableSpriteLoader : AddressableAssetLoader<Sprite>
{
  private static readonly IntPtr NativeFieldInfoPtr_atlas;
  private static readonly IntPtr NativeFieldInfoPtr_atlasedSpriteRef;
  private static readonly IntPtr NativeFieldInfoPtr_spriteRef;
  private static readonly IntPtr NativeFieldInfoPtr_type;
  private static readonly IntPtr NativeFieldInfoPtr_spriteRenderer;
  private static readonly IntPtr NativeFieldInfoPtr_image;
  private static readonly IntPtr NativeFieldInfoPtr_imageSprite;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsSpriteRenderer_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsImage_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsImageSprite_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetSprite_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__Load_b__14_0_Private_Void_AsyncOperationHandle_1_Sprite_0;

  public unsafe bool IsSpriteRenderer
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(AddressableSpriteLoader.NativeMethodInfoPtr_get_IsSpriteRenderer_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool IsImage
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(AddressableSpriteLoader.NativeMethodInfoPtr_get_IsImage_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool IsImageSprite
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(AddressableSpriteLoader.NativeMethodInfoPtr_get_IsImageSprite_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27393, XrefRangeEnd = 27409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Load()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AddressableSpriteLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 27413, RefRangeEnd = 27415, XrefRangeStart = 27409, XrefRangeEnd = 27413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSprite()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressableSpriteLoader.NativeMethodInfoPtr_SetSprite_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27415, XrefRangeEnd = 27418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AddressableSpriteLoader()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressableSpriteLoader>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressableSpriteLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27418, XrefRangeEnd = 27419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _Load_b__14_0(AsyncOperationHandle<Sprite> _)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) _))
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressableSpriteLoader.NativeMethodInfoPtr__Load_b__14_0_Private_Void_AsyncOperationHandle_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static AddressableSpriteLoader()
  {
    Il2CppClassPointerStore<AddressableSpriteLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (AddressableSpriteLoader));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressableSpriteLoader>.NativeClassPtr);
    AddressableSpriteLoader.NativeFieldInfoPtr_atlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableSpriteLoader>.NativeClassPtr, nameof (atlas));
    AddressableSpriteLoader.NativeFieldInfoPtr_atlasedSpriteRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableSpriteLoader>.NativeClassPtr, nameof (atlasedSpriteRef));
    AddressableSpriteLoader.NativeFieldInfoPtr_spriteRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableSpriteLoader>.NativeClassPtr, nameof (spriteRef));
    AddressableSpriteLoader.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableSpriteLoader>.NativeClassPtr, nameof (type));
    AddressableSpriteLoader.NativeFieldInfoPtr_spriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableSpriteLoader>.NativeClassPtr, nameof (spriteRenderer));
    AddressableSpriteLoader.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableSpriteLoader>.NativeClassPtr, nameof (image));
    AddressableSpriteLoader.NativeFieldInfoPtr_imageSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableSpriteLoader>.NativeClassPtr, nameof (imageSprite));
    AddressableSpriteLoader.NativeMethodInfoPtr_get_IsSpriteRenderer_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableSpriteLoader>.NativeClassPtr, 100664769);
    AddressableSpriteLoader.NativeMethodInfoPtr_get_IsImage_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableSpriteLoader>.NativeClassPtr, 100664770);
    AddressableSpriteLoader.NativeMethodInfoPtr_get_IsImageSprite_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableSpriteLoader>.NativeClassPtr, 100664771);
    AddressableSpriteLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableSpriteLoader>.NativeClassPtr, 100664772);
    AddressableSpriteLoader.NativeMethodInfoPtr_SetSprite_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableSpriteLoader>.NativeClassPtr, 100664773);
    AddressableSpriteLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableSpriteLoader>.NativeClassPtr, 100664774);
    AddressableSpriteLoader.NativeMethodInfoPtr__Load_b__14_0_Private_Void_AsyncOperationHandle_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableSpriteLoader>.NativeClassPtr, 100664775);
  }

  public AddressableSpriteLoader(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool atlas
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableSpriteLoader.NativeFieldInfoPtr_atlas));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableSpriteLoader.NativeFieldInfoPtr_atlas)) = value;
    }
  }

  public unsafe AssetReferenceAtlasedSprite atlasedSpriteRef
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableSpriteLoader.NativeFieldInfoPtr_atlasedSpriteRef));
      return pointer == IntPtr.Zero ? (AssetReferenceAtlasedSprite) null : new AssetReferenceAtlasedSprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddressableSpriteLoader.NativeFieldInfoPtr_atlasedSpriteRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AssetReferenceSprite spriteRef
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableSpriteLoader.NativeFieldInfoPtr_spriteRef));
      return pointer == IntPtr.Zero ? (AssetReferenceSprite) null : new AssetReferenceSprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddressableSpriteLoader.NativeFieldInfoPtr_spriteRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AddressableSpriteLoader.Type type
  {
    get
    {
      return *(AddressableSpriteLoader.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableSpriteLoader.NativeFieldInfoPtr_type));
    }
    [param: In] set
    {
      *(AddressableSpriteLoader.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableSpriteLoader.NativeFieldInfoPtr_type)) = value;
    }
  }

  public unsafe SpriteRenderer spriteRenderer
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableSpriteLoader.NativeFieldInfoPtr_spriteRenderer));
      return pointer == IntPtr.Zero ? (SpriteRenderer) null : new SpriteRenderer(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddressableSpriteLoader.NativeFieldInfoPtr_spriteRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image image
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableSpriteLoader.NativeFieldInfoPtr_image));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddressableSpriteLoader.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ImageSprite imageSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableSpriteLoader.NativeFieldInfoPtr_imageSprite));
      return pointer == IntPtr.Zero ? (ImageSprite) null : new ImageSprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddressableSpriteLoader.NativeFieldInfoPtr_imageSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum Type
  {
    SpriteRenderer,
    Image,
    ImageSprite,
  }
}
