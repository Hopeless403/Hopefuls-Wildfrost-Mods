// Decompiled with JetBrains decompiler
// Type: LeaderProfileData
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

#nullable disable
public class LeaderProfileData : ScriptableObject
{
  private static readonly System.IntPtr NativeFieldInfoPtr_backgroundPool;
  private static readonly System.IntPtr NativeFieldInfoPtr_collectionsToAdd;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomBackground_Public_Sprite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Void_CharacterType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnApply_Public_Void_CharacterType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 109770, RefRangeEnd = 109771, XrefRangeStart = 109766, XrefRangeEnd = 109770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Sprite GetRandomBackground()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaderProfileData.NativeMethodInfoPtr_GetRandomBackground_Public_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 109811, RefRangeEnd = 109812, XrefRangeStart = 109771, XrefRangeEnd = 109811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Apply(CharacterType type)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderProfileData.NativeMethodInfoPtr_Apply_Public_Void_CharacterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 109852, RefRangeEnd = 109853, XrefRangeStart = 109812, XrefRangeEnd = 109852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnApply(CharacterType type)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderProfileData.NativeMethodInfoPtr_UnApply_Public_Void_CharacterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LeaderProfileData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderProfileData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeaderProfileData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LeaderProfileData()
  {
    Il2CppClassPointerStore<LeaderProfileData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LeaderProfileData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderProfileData>.NativeClassPtr);
    LeaderProfileData.NativeFieldInfoPtr_backgroundPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderProfileData>.NativeClassPtr, nameof (backgroundPool));
    LeaderProfileData.NativeFieldInfoPtr_collectionsToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderProfileData>.NativeClassPtr, nameof (collectionsToAdd));
    LeaderProfileData.NativeMethodInfoPtr_GetRandomBackground_Public_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderProfileData>.NativeClassPtr, 100673429);
    LeaderProfileData.NativeMethodInfoPtr_Apply_Public_Void_CharacterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderProfileData>.NativeClassPtr, 100673430);
    LeaderProfileData.NativeMethodInfoPtr_UnApply_Public_Void_CharacterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderProfileData>.NativeClassPtr, 100673431);
    LeaderProfileData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderProfileData>.NativeClassPtr, 100673432);
  }

  public LeaderProfileData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe SpriteCollection backgroundPool
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderProfileData.NativeFieldInfoPtr_backgroundPool));
      return pointer == System.IntPtr.Zero ? (SpriteCollection) null : new SpriteCollection(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderProfileData.NativeFieldInfoPtr_backgroundPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<LeaderProfileData.Collection> collectionsToAdd
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderProfileData.NativeFieldInfoPtr_collectionsToAdd));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<LeaderProfileData.Collection>) null : new Il2CppReferenceArray<LeaderProfileData.Collection>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderProfileData.NativeFieldInfoPtr_collectionsToAdd), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class Collection : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_collectionName;
    private static readonly System.IntPtr NativeFieldInfoPtr_type;
    private static readonly System.IntPtr NativeFieldInfoPtr_modifier;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddTo_Public_Void_CharacterType_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__AddTo_b__4_0_Private_Boolean_PrefabGroup_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__AddTo_b__4_1_Private_Boolean_SpriteGroup_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__AddTo_b__4_2_Private_Boolean_ColorSetGroup_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109727, XrefRangeEnd = 109766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddTo(CharacterType characterType, float multiply = 1f)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) characterType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &multiply;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderProfileData.Collection.NativeMethodInfoPtr_AddTo_Public_Void_CharacterType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Collection()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderProfileData.Collection>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderProfileData.Collection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _AddTo_b__4_0(CharacterType.PrefabGroup a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaderProfileData.Collection.NativeMethodInfoPtr__AddTo_b__4_0_Private_Boolean_PrefabGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _AddTo_b__4_1(CharacterType.SpriteGroup a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaderProfileData.Collection.NativeMethodInfoPtr__AddTo_b__4_1_Private_Boolean_SpriteGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _AddTo_b__4_2(CharacterType.ColorSetGroup a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaderProfileData.Collection.NativeMethodInfoPtr__AddTo_b__4_2_Private_Boolean_ColorSetGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static Collection()
    {
      Il2CppClassPointerStore<LeaderProfileData.Collection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeaderProfileData>.NativeClassPtr, nameof (Collection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderProfileData.Collection>.NativeClassPtr);
      LeaderProfileData.Collection.NativeFieldInfoPtr_collectionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderProfileData.Collection>.NativeClassPtr, nameof (collectionName));
      LeaderProfileData.Collection.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderProfileData.Collection>.NativeClassPtr, nameof (type));
      LeaderProfileData.Collection.NativeFieldInfoPtr_modifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderProfileData.Collection>.NativeClassPtr, nameof (modifier));
      LeaderProfileData.Collection.NativeMethodInfoPtr_AddTo_Public_Void_CharacterType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderProfileData.Collection>.NativeClassPtr, 100673433);
      LeaderProfileData.Collection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderProfileData.Collection>.NativeClassPtr, 100673434);
      LeaderProfileData.Collection.NativeMethodInfoPtr__AddTo_b__4_0_Private_Boolean_PrefabGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderProfileData.Collection>.NativeClassPtr, 100673435);
      LeaderProfileData.Collection.NativeMethodInfoPtr__AddTo_b__4_1_Private_Boolean_SpriteGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderProfileData.Collection>.NativeClassPtr, 100673436);
      LeaderProfileData.Collection.NativeMethodInfoPtr__AddTo_b__4_2_Private_Boolean_ColorSetGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderProfileData.Collection>.NativeClassPtr, 100673437);
    }

    public Collection(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string collectionName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderProfileData.Collection.NativeFieldInfoPtr_collectionName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderProfileData.Collection.NativeFieldInfoPtr_collectionName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe LeaderProfileData.Collection.Type type
    {
      get
      {
        return *(LeaderProfileData.Collection.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderProfileData.Collection.NativeFieldInfoPtr_type));
      }
      [param: In] set
      {
        *(LeaderProfileData.Collection.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderProfileData.Collection.NativeFieldInfoPtr_type)) = value;
      }
    }

    public unsafe CollectionModifier modifier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeaderProfileData.Collection.NativeFieldInfoPtr_modifier));
        return pointer == System.IntPtr.Zero ? (CollectionModifier) null : new CollectionModifier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeaderProfileData.Collection.NativeFieldInfoPtr_modifier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public enum Type
    {
      Prefab,
      Sprite,
      ColorSet,
    }
  }
}
