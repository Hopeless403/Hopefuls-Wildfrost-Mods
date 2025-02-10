// Decompiled with JetBrains decompiler
// Type: AddressableTieredSpriteLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

#nullable disable
public class AddressableTieredSpriteLoader : AddressableAssetLoader<Sprite>
{
  private static readonly System.IntPtr NativeFieldInfoPtr_tiers;
  private static readonly System.IntPtr NativeFieldInfoPtr_type;
  private static readonly System.IntPtr NativeFieldInfoPtr_spriteRenderer;
  private static readonly System.IntPtr NativeFieldInfoPtr_image;
  private static readonly System.IntPtr NativeFieldInfoPtr_imageSprite;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSpriteRenderer_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsImage_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsImageSprite_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Private_Void_Tier_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSprite_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Load_b__14_0_Private_Void_AsyncOperationHandle_1_Sprite_0;

  public unsafe bool IsSpriteRenderer
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AddressableTieredSpriteLoader.NativeMethodInfoPtr_get_IsSpriteRenderer_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool IsImage
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AddressableTieredSpriteLoader.NativeMethodInfoPtr_get_IsImage_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool IsImageSprite
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AddressableTieredSpriteLoader.NativeMethodInfoPtr_get_IsImageSprite_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27419, XrefRangeEnd = 27434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Load()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AddressableTieredSpriteLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 27450, RefRangeEnd = 27452, XrefRangeStart = 27434, XrefRangeEnd = 27450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Load(int tier)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &tier
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressableTieredSpriteLoader.NativeMethodInfoPtr_Load_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27452, XrefRangeEnd = 27468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Load(AddressableTieredSpriteLoader.Tier tier)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) tier))
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressableTieredSpriteLoader.NativeMethodInfoPtr_Load_Private_Void_Tier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 27472, RefRangeEnd = 27476, XrefRangeStart = 27468, XrefRangeEnd = 27472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSprite()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressableTieredSpriteLoader.NativeMethodInfoPtr_SetSprite_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27476, XrefRangeEnd = 27479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AddressableTieredSpriteLoader()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressableTieredSpriteLoader>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressableTieredSpriteLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27479, XrefRangeEnd = 27480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _Load_b__14_0(AsyncOperationHandle<Sprite> _)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) _))
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddressableTieredSpriteLoader.NativeMethodInfoPtr__Load_b__14_0_Private_Void_AsyncOperationHandle_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static AddressableTieredSpriteLoader()
  {
    Il2CppClassPointerStore<AddressableTieredSpriteLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (AddressableTieredSpriteLoader));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressableTieredSpriteLoader>.NativeClassPtr);
    AddressableTieredSpriteLoader.NativeFieldInfoPtr_tiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableTieredSpriteLoader>.NativeClassPtr, nameof (tiers));
    AddressableTieredSpriteLoader.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableTieredSpriteLoader>.NativeClassPtr, nameof (type));
    AddressableTieredSpriteLoader.NativeFieldInfoPtr_spriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableTieredSpriteLoader>.NativeClassPtr, nameof (spriteRenderer));
    AddressableTieredSpriteLoader.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableTieredSpriteLoader>.NativeClassPtr, nameof (image));
    AddressableTieredSpriteLoader.NativeFieldInfoPtr_imageSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableTieredSpriteLoader>.NativeClassPtr, nameof (imageSprite));
    AddressableTieredSpriteLoader.NativeMethodInfoPtr_get_IsSpriteRenderer_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableTieredSpriteLoader>.NativeClassPtr, 100664776);
    AddressableTieredSpriteLoader.NativeMethodInfoPtr_get_IsImage_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableTieredSpriteLoader>.NativeClassPtr, 100664777);
    AddressableTieredSpriteLoader.NativeMethodInfoPtr_get_IsImageSprite_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableTieredSpriteLoader>.NativeClassPtr, 100664778);
    AddressableTieredSpriteLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableTieredSpriteLoader>.NativeClassPtr, 100664779);
    AddressableTieredSpriteLoader.NativeMethodInfoPtr_Load_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableTieredSpriteLoader>.NativeClassPtr, 100664780);
    AddressableTieredSpriteLoader.NativeMethodInfoPtr_Load_Private_Void_Tier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableTieredSpriteLoader>.NativeClassPtr, 100664781);
    AddressableTieredSpriteLoader.NativeMethodInfoPtr_SetSprite_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableTieredSpriteLoader>.NativeClassPtr, 100664782);
    AddressableTieredSpriteLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableTieredSpriteLoader>.NativeClassPtr, 100664783);
    AddressableTieredSpriteLoader.NativeMethodInfoPtr__Load_b__14_0_Private_Void_AsyncOperationHandle_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressableTieredSpriteLoader>.NativeClassPtr, 100664784);
  }

  public AddressableTieredSpriteLoader(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<AddressableTieredSpriteLoader.Tier> tiers
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableTieredSpriteLoader.NativeFieldInfoPtr_tiers));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<AddressableTieredSpriteLoader.Tier>) null : new Il2CppReferenceArray<AddressableTieredSpriteLoader.Tier>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddressableTieredSpriteLoader.NativeFieldInfoPtr_tiers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AddressableTieredSpriteLoader.Type type
  {
    get
    {
      return *(AddressableTieredSpriteLoader.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableTieredSpriteLoader.NativeFieldInfoPtr_type));
    }
    [param: In] set
    {
      *(AddressableTieredSpriteLoader.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableTieredSpriteLoader.NativeFieldInfoPtr_type)) = value;
    }
  }

  public unsafe SpriteRenderer spriteRenderer
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableTieredSpriteLoader.NativeFieldInfoPtr_spriteRenderer));
      return pointer == System.IntPtr.Zero ? (SpriteRenderer) null : new SpriteRenderer(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddressableTieredSpriteLoader.NativeFieldInfoPtr_spriteRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image image
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableTieredSpriteLoader.NativeFieldInfoPtr_image));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddressableTieredSpriteLoader.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ImageSprite imageSprite
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableTieredSpriteLoader.NativeFieldInfoPtr_imageSprite));
      return pointer == System.IntPtr.Zero ? (ImageSprite) null : new ImageSprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddressableTieredSpriteLoader.NativeFieldInfoPtr_imageSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum Type
  {
    SpriteRenderer,
    Image,
    ImageSprite,
  }

  [Serializable]
  public sealed class Tier : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_atlas;
    private static readonly System.IntPtr NativeFieldInfoPtr_atlasedSpriteRef;
    private static readonly System.IntPtr NativeFieldInfoPtr_spriteRef;

    static Tier()
    {
      Il2CppClassPointerStore<AddressableTieredSpriteLoader.Tier>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressableTieredSpriteLoader>.NativeClassPtr, nameof (Tier));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressableTieredSpriteLoader.Tier>.NativeClassPtr);
      AddressableTieredSpriteLoader.Tier.NativeFieldInfoPtr_atlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableTieredSpriteLoader.Tier>.NativeClassPtr, nameof (atlas));
      AddressableTieredSpriteLoader.Tier.NativeFieldInfoPtr_atlasedSpriteRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableTieredSpriteLoader.Tier>.NativeClassPtr, nameof (atlasedSpriteRef));
      AddressableTieredSpriteLoader.Tier.NativeFieldInfoPtr_spriteRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressableTieredSpriteLoader.Tier>.NativeClassPtr, nameof (spriteRef));
    }

    public Tier(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Tier()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AddressableTieredSpriteLoader.Tier>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AddressableTieredSpriteLoader.Tier>.NativeClassPtr, data));
    }

    public unsafe bool atlas
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableTieredSpriteLoader.Tier.NativeFieldInfoPtr_atlas));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableTieredSpriteLoader.Tier.NativeFieldInfoPtr_atlas)) = value;
      }
    }

    public unsafe AssetReferenceAtlasedSprite atlasedSpriteRef
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableTieredSpriteLoader.Tier.NativeFieldInfoPtr_atlasedSpriteRef));
        return pointer == System.IntPtr.Zero ? (AssetReferenceAtlasedSprite) null : new AssetReferenceAtlasedSprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddressableTieredSpriteLoader.Tier.NativeFieldInfoPtr_atlasedSpriteRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AssetReferenceSprite spriteRef
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddressableTieredSpriteLoader.Tier.NativeFieldInfoPtr_spriteRef));
        return pointer == System.IntPtr.Zero ? (AssetReferenceSprite) null : new AssetReferenceSprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddressableTieredSpriteLoader.Tier.NativeFieldInfoPtr_spriteRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
