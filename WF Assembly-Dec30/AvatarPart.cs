// Decompiled with JetBrains decompiler
// Type: AvatarPart
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
using UnityEngine.UI;

#nullable disable
public class AvatarPart : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_anchors;
  private static readonly System.IntPtr NativeFieldInfoPtr_parts;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAnchor_Public_Transform_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Part_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 27729, RefRangeEnd = 27734, XrefRangeStart = 27715, XrefRangeEnd = 27729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Transform GetAnchor(string name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AvatarPart.NativeMethodInfoPtr_GetAnchor_Public_Transform_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 27748, RefRangeEnd = 27750, XrefRangeStart = 27734, XrefRangeEnd = 27748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AvatarPart.Part Get(string name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(AvatarPart.NativeMethodInfoPtr_Get_Public_Part_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return new AvatarPart.Part(pointer);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AvatarPart()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarPart>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AvatarPart.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static AvatarPart()
  {
    Il2CppClassPointerStore<AvatarPart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (AvatarPart));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarPart>.NativeClassPtr);
    AvatarPart.NativeFieldInfoPtr_anchors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarPart>.NativeClassPtr, nameof (anchors));
    AvatarPart.NativeFieldInfoPtr_parts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarPart>.NativeClassPtr, nameof (parts));
    AvatarPart.NativeMethodInfoPtr_GetAnchor_Public_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarPart>.NativeClassPtr, 100664806);
    AvatarPart.NativeMethodInfoPtr_Get_Public_Part_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarPart>.NativeClassPtr, 100664807);
    AvatarPart.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarPart>.NativeClassPtr, 100664808);
  }

  public AvatarPart(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<AvatarPart.Anchor> anchors
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPart.NativeFieldInfoPtr_anchors));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<AvatarPart.Anchor>) null : new Il2CppReferenceArray<AvatarPart.Anchor>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AvatarPart.NativeFieldInfoPtr_anchors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<AvatarPart.Part> parts
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPart.NativeFieldInfoPtr_parts));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<AvatarPart.Part>) null : new Il2CppReferenceArray<AvatarPart.Part>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AvatarPart.NativeFieldInfoPtr_parts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class Anchor : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_transform;

    static Anchor()
    {
      Il2CppClassPointerStore<AvatarPart.Anchor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarPart>.NativeClassPtr, nameof (Anchor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarPart.Anchor>.NativeClassPtr);
      AvatarPart.Anchor.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarPart.Anchor>.NativeClassPtr, nameof (name));
      AvatarPart.Anchor.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarPart.Anchor>.NativeClassPtr, nameof (transform));
    }

    public Anchor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Anchor()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AvatarPart.Anchor>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AvatarPart.Anchor>.NativeClassPtr, data));
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPart.Anchor.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AvatarPart.Anchor.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Transform transform
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPart.Anchor.NativeFieldInfoPtr_transform));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AvatarPart.Anchor.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public sealed class Part : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_image;
    private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Sprite_Vector2_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 27702, RefRangeEnd = 27703, XrefRangeStart = 27697, XrefRangeEnd = 27702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Disable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AvatarPart.Part.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 27712, RefRangeEnd = 27714, XrefRangeStart = 27703, XrefRangeEnd = 27712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(Sprite sprite, Vector2 scale)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AvatarPart.Part.NativeMethodInfoPtr_Set_Public_Void_Sprite_Vector2_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Part()
    {
      Il2CppClassPointerStore<AvatarPart.Part>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarPart>.NativeClassPtr, nameof (Part));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarPart.Part>.NativeClassPtr);
      AvatarPart.Part.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarPart.Part>.NativeClassPtr, nameof (name));
      AvatarPart.Part.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarPart.Part>.NativeClassPtr, nameof (image));
      AvatarPart.Part.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarPart.Part>.NativeClassPtr, 100664809);
      AvatarPart.Part.NativeMethodInfoPtr_Set_Public_Void_Sprite_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarPart.Part>.NativeClassPtr, 100664810);
    }

    public Part(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Part()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AvatarPart.Part>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AvatarPart.Part>.NativeClassPtr, data));
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPart.Part.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AvatarPart.Part.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Image image
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPart.Part.NativeFieldInfoPtr_image));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AvatarPart.Part.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("AvatarPart/<>c__DisplayClass2_0")]
  public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetAnchor_b__0_Internal_Boolean_Anchor_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass2_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarPart.__c__DisplayClass2_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AvatarPart.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27714, XrefRangeEnd = 27715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetAnchor_b__0(AvatarPart.Anchor a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a))
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AvatarPart.__c__DisplayClass2_0.NativeMethodInfoPtr__GetAnchor_b__0_Internal_Boolean_Anchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass2_0()
    {
      Il2CppClassPointerStore<AvatarPart.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarPart>.NativeClassPtr, "<>c__DisplayClass2_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarPart.__c__DisplayClass2_0>.NativeClassPtr);
      AvatarPart.__c__DisplayClass2_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarPart.__c__DisplayClass2_0>.NativeClassPtr, nameof (name));
      AvatarPart.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarPart.__c__DisplayClass2_0>.NativeClassPtr, 100664811);
      AvatarPart.__c__DisplayClass2_0.NativeMethodInfoPtr__GetAnchor_b__0_Internal_Boolean_Anchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarPart.__c__DisplayClass2_0>.NativeClassPtr, 100664812);
    }

    public __c__DisplayClass2_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPart.__c__DisplayClass2_0.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AvatarPart.__c__DisplayClass2_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  [ObfuscatedName("AvatarPart/<>c__DisplayClass3_0")]
  public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Get_b__0_Internal_Boolean_Part_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass3_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarPart.__c__DisplayClass3_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AvatarPart.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Get_b__0(AvatarPart.Part a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a))
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AvatarPart.__c__DisplayClass3_0.NativeMethodInfoPtr__Get_b__0_Internal_Boolean_Part_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass3_0()
    {
      Il2CppClassPointerStore<AvatarPart.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarPart>.NativeClassPtr, "<>c__DisplayClass3_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarPart.__c__DisplayClass3_0>.NativeClassPtr);
      AvatarPart.__c__DisplayClass3_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarPart.__c__DisplayClass3_0>.NativeClassPtr, nameof (name));
      AvatarPart.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarPart.__c__DisplayClass3_0>.NativeClassPtr, 100664813);
      AvatarPart.__c__DisplayClass3_0.NativeMethodInfoPtr__Get_b__0_Internal_Boolean_Part_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarPart.__c__DisplayClass3_0>.NativeClassPtr, 100664814);
    }

    public __c__DisplayClass3_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPart.__c__DisplayClass3_0.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AvatarPart.__c__DisplayClass3_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
