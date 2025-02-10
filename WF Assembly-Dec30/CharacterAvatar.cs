// Decompiled with JetBrains decompiler
// Type: CharacterAvatar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine;

#nullable disable
public class CharacterAvatar : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_root;
  private static readonly System.IntPtr NativeFieldInfoPtr_paletteTexture;
  private static readonly System.IntPtr NativeFieldInfoPtr_recolourMaterial;
  private static readonly System.IntPtr NativeFieldInfoPtr_recolourMaterialCopy;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDisplay_Public_Void_CharacterData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPrefab_Private_Static_GameObject_CharacterType_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSprite_Private_Static_Sprite_CharacterType_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetColorSet_Private_Static_ColorSet_CharacterType_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSprite_Private_Static_Void_CharacterType_AvatarPart_String_Sprite_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSprite_Private_Static_Void_CharacterType_AvatarPart_Sprite_Vector2_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTexturePixels_Private_Static_Void_CharacterType_Texture2D_NativeArray_1_Color32_Int32_ColorSet_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27865, XrefRangeEnd = 27878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterAvatar.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 28065, RefRangeEnd = 28066, XrefRangeStart = 27878, XrefRangeEnd = 28065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateDisplay(CharacterData data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterAvatar.NativeMethodInfoPtr_UpdateDisplay_Public_Void_CharacterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 28083, RefRangeEnd = 28088, XrefRangeStart = 28066, XrefRangeEnd = 28083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GameObject GetPrefab(CharacterType type, string name, int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterAvatar.NativeMethodInfoPtr_GetPrefab_Private_Static_GameObject_CharacterType_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 28105, RefRangeEnd = 28113, XrefRangeStart = 28088, XrefRangeEnd = 28105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Sprite GetSprite(CharacterType type, string name, int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterAvatar.NativeMethodInfoPtr_GetSprite_Private_Static_Sprite_CharacterType_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 28130, RefRangeEnd = 28135, XrefRangeStart = 28113, XrefRangeEnd = 28130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ColorSet GetColorSet(CharacterType type, string name, int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterAvatar.NativeMethodInfoPtr_GetColorSet_Private_Static_ColorSet_CharacterType_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (ColorSet) null : new ColorSet(pointer);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 28141, RefRangeEnd = 28149, XrefRangeStart = 28135, XrefRangeEnd = 28141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetSprite(
    CharacterType type,
    AvatarPart part,
    string partName,
    Sprite sprite,
    Vector2 scale)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) part);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(partName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterAvatar.NativeMethodInfoPtr_SetSprite_Private_Static_Void_CharacterType_AvatarPart_String_Sprite_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28149, XrefRangeEnd = 28158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetSprite(
    CharacterType type,
    AvatarPart part,
    Sprite sprite,
    Vector2 scale,
    [Optional] Il2CppStringArray partNames)
  {
    if (partNames == null)
      partNames = new Il2CppStringArray(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) part);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) partNames);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterAvatar.NativeMethodInfoPtr_SetSprite_Private_Static_Void_CharacterType_AvatarPart_Sprite_Vector2_Il2CppStringArray_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 28167, RefRangeEnd = 28172, XrefRangeStart = 28158, XrefRangeEnd = 28167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetTexturePixels(
    CharacterType type,
    Texture2D texture,
    NativeArray<Color32> data,
    int startX,
    ColorSet colorSet)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &startX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) colorSet);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterAvatar.NativeMethodInfoPtr_SetTexturePixels_Private_Static_Void_CharacterType_Texture2D_NativeArray_1_Color32_Int32_ColorSet_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterAvatar()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAvatar>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterAvatar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public static void SetSprite(
    CharacterType type,
    AvatarPart part,
    Sprite sprite,
    Vector2 scale,
    params string[] partNames)
  {
    CharacterAvatar.SetSprite(type, part, sprite, scale, new Il2CppStringArray(partNames));
  }

  static CharacterAvatar()
  {
    Il2CppClassPointerStore<CharacterAvatar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CharacterAvatar));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAvatar>.NativeClassPtr);
    CharacterAvatar.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAvatar>.NativeClassPtr, nameof (root));
    CharacterAvatar.NativeFieldInfoPtr_paletteTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAvatar>.NativeClassPtr, nameof (paletteTexture));
    CharacterAvatar.NativeFieldInfoPtr_recolourMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAvatar>.NativeClassPtr, nameof (recolourMaterial));
    CharacterAvatar.NativeFieldInfoPtr_recolourMaterialCopy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAvatar>.NativeClassPtr, nameof (recolourMaterialCopy));
    CharacterAvatar.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAvatar>.NativeClassPtr, 100664831);
    CharacterAvatar.NativeMethodInfoPtr_UpdateDisplay_Public_Void_CharacterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAvatar>.NativeClassPtr, 100664832);
    CharacterAvatar.NativeMethodInfoPtr_GetPrefab_Private_Static_GameObject_CharacterType_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAvatar>.NativeClassPtr, 100664833);
    CharacterAvatar.NativeMethodInfoPtr_GetSprite_Private_Static_Sprite_CharacterType_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAvatar>.NativeClassPtr, 100664834);
    CharacterAvatar.NativeMethodInfoPtr_GetColorSet_Private_Static_ColorSet_CharacterType_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAvatar>.NativeClassPtr, 100664835);
    CharacterAvatar.NativeMethodInfoPtr_SetSprite_Private_Static_Void_CharacterType_AvatarPart_String_Sprite_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAvatar>.NativeClassPtr, 100664836);
    CharacterAvatar.NativeMethodInfoPtr_SetSprite_Private_Static_Void_CharacterType_AvatarPart_Sprite_Vector2_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAvatar>.NativeClassPtr, 100664837);
    CharacterAvatar.NativeMethodInfoPtr_SetTexturePixels_Private_Static_Void_CharacterType_Texture2D_NativeArray_1_Color32_Int32_ColorSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAvatar>.NativeClassPtr, 100664838);
    CharacterAvatar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAvatar>.NativeClassPtr, 100664839);
  }

  public CharacterAvatar(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe AvatarPart root
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAvatar.NativeFieldInfoPtr_root));
      return pointer == System.IntPtr.Zero ? (AvatarPart) null : new AvatarPart(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAvatar.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture2D paletteTexture
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAvatar.NativeFieldInfoPtr_paletteTexture));
      return pointer == System.IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAvatar.NativeFieldInfoPtr_paletteTexture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material recolourMaterial
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAvatar.NativeFieldInfoPtr_recolourMaterial));
      return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAvatar.NativeFieldInfoPtr_recolourMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material recolourMaterialCopy
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAvatar.NativeFieldInfoPtr_recolourMaterialCopy));
      return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAvatar.NativeFieldInfoPtr_recolourMaterialCopy), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("CharacterAvatar/<>c__DisplayClass6_0")]
  public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetPrefab_b__0_Internal_Boolean_PrefabGroup_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass6_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAvatar.__c__DisplayClass6_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterAvatar.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27863, XrefRangeEnd = 27865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetPrefab_b__0(CharacterType.PrefabGroup a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterAvatar.__c__DisplayClass6_0.NativeMethodInfoPtr__GetPrefab_b__0_Internal_Boolean_PrefabGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass6_0()
    {
      Il2CppClassPointerStore<CharacterAvatar.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterAvatar>.NativeClassPtr, "<>c__DisplayClass6_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAvatar.__c__DisplayClass6_0>.NativeClassPtr);
      CharacterAvatar.__c__DisplayClass6_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAvatar.__c__DisplayClass6_0>.NativeClassPtr, nameof (name));
      CharacterAvatar.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAvatar.__c__DisplayClass6_0>.NativeClassPtr, 100664840);
      CharacterAvatar.__c__DisplayClass6_0.NativeMethodInfoPtr__GetPrefab_b__0_Internal_Boolean_PrefabGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAvatar.__c__DisplayClass6_0>.NativeClassPtr, 100664841);
    }

    public __c__DisplayClass6_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAvatar.__c__DisplayClass6_0.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAvatar.__c__DisplayClass6_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  [ObfuscatedName("CharacterAvatar/<>c__DisplayClass7_0")]
  public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSprite_b__0_Internal_Boolean_SpriteGroup_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass7_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAvatar.__c__DisplayClass7_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterAvatar.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetSprite_b__0(CharacterType.SpriteGroup a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterAvatar.__c__DisplayClass7_0.NativeMethodInfoPtr__GetSprite_b__0_Internal_Boolean_SpriteGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass7_0()
    {
      Il2CppClassPointerStore<CharacterAvatar.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterAvatar>.NativeClassPtr, "<>c__DisplayClass7_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAvatar.__c__DisplayClass7_0>.NativeClassPtr);
      CharacterAvatar.__c__DisplayClass7_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAvatar.__c__DisplayClass7_0>.NativeClassPtr, nameof (name));
      CharacterAvatar.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAvatar.__c__DisplayClass7_0>.NativeClassPtr, 100664842);
      CharacterAvatar.__c__DisplayClass7_0.NativeMethodInfoPtr__GetSprite_b__0_Internal_Boolean_SpriteGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAvatar.__c__DisplayClass7_0>.NativeClassPtr, 100664843);
    }

    public __c__DisplayClass7_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAvatar.__c__DisplayClass7_0.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAvatar.__c__DisplayClass7_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  [ObfuscatedName("CharacterAvatar/<>c__DisplayClass8_0")]
  public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetColorSet_b__0_Internal_Boolean_ColorSetGroup_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass8_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAvatar.__c__DisplayClass8_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterAvatar.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetColorSet_b__0(CharacterType.ColorSetGroup a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterAvatar.__c__DisplayClass8_0.NativeMethodInfoPtr__GetColorSet_b__0_Internal_Boolean_ColorSetGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass8_0()
    {
      Il2CppClassPointerStore<CharacterAvatar.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterAvatar>.NativeClassPtr, "<>c__DisplayClass8_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAvatar.__c__DisplayClass8_0>.NativeClassPtr);
      CharacterAvatar.__c__DisplayClass8_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAvatar.__c__DisplayClass8_0>.NativeClassPtr, nameof (name));
      CharacterAvatar.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAvatar.__c__DisplayClass8_0>.NativeClassPtr, 100664844);
      CharacterAvatar.__c__DisplayClass8_0.NativeMethodInfoPtr__GetColorSet_b__0_Internal_Boolean_ColorSetGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAvatar.__c__DisplayClass8_0>.NativeClassPtr, 100664845);
    }

    public __c__DisplayClass8_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAvatar.__c__DisplayClass8_0.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAvatar.__c__DisplayClass8_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
