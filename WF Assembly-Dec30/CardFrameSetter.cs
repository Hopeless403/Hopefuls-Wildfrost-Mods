// Decompiled with JetBrains decompiler
// Type: CardFrameSetter
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
public class CardFrameSetter : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_spriteSetters;
  private static readonly IntPtr NativeFieldInfoPtr_loaded;
  private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35330, XrefRangeEnd = 35332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Load(int frameLevel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &frameLevel
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardFrameSetter.NativeMethodInfoPtr_Load_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardFrameSetter()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardFrameSetter>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardFrameSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardFrameSetter()
  {
    Il2CppClassPointerStore<CardFrameSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardFrameSetter));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardFrameSetter>.NativeClassPtr);
    CardFrameSetter.NativeFieldInfoPtr_spriteSetters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardFrameSetter>.NativeClassPtr, nameof (spriteSetters));
    CardFrameSetter.NativeFieldInfoPtr_loaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardFrameSetter>.NativeClassPtr, nameof (loaded));
    CardFrameSetter.NativeMethodInfoPtr_Load_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardFrameSetter>.NativeClassPtr, 100665613);
    CardFrameSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardFrameSetter>.NativeClassPtr, 100665614);
  }

  public CardFrameSetter(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<AddressableTieredSpriteLoader> spriteSetters
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardFrameSetter.NativeFieldInfoPtr_spriteSetters));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<AddressableTieredSpriteLoader>) null : new Il2CppReferenceArray<AddressableTieredSpriteLoader>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardFrameSetter.NativeFieldInfoPtr_spriteSetters), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool loaded
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardFrameSetter.NativeFieldInfoPtr_loaded));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardFrameSetter.NativeFieldInfoPtr_loaded)) = value;
    }
  }
}
