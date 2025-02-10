// Decompiled with JetBrains decompiler
// Type: TextImageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class TextImageData : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_chars;
  private static readonly IntPtr NativeFieldInfoPtr_sprites;
  private static readonly IntPtr NativeMethodInfoPtr_TryGetSprite_Public_Boolean_Char_byref_Sprite_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 110931, RefRangeEnd = 110932, XrefRangeStart = 110926, XrefRangeEnd = 110931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGetSprite(char value, out Sprite result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[2];
    numPtr1[0] = (IntPtr) &value;
    IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr2 = &zero;
    *(IntPtr*) num1 = (IntPtr) numPtr2;
    IntPtr exc;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextImageData.NativeMethodInfoPtr_TryGetSprite_Public_Boolean_Char_byref_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref Sprite local = ref result;
    IntPtr pointer = zero;
    Sprite sprite = pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    local = sprite;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TextImageData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextImageData>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TextImageData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TextImageData()
  {
    Il2CppClassPointerStore<TextImageData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TextImageData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextImageData>.NativeClassPtr);
    TextImageData.NativeFieldInfoPtr_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextImageData>.NativeClassPtr, nameof (chars));
    TextImageData.NativeFieldInfoPtr_sprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextImageData>.NativeClassPtr, nameof (sprites));
    TextImageData.NativeMethodInfoPtr_TryGetSprite_Public_Boolean_Char_byref_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextImageData>.NativeClassPtr, 100673667);
    TextImageData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextImageData>.NativeClassPtr, 100673668);
  }

  public TextImageData(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe List<char> chars
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextImageData.NativeFieldInfoPtr_chars));
      return pointer == IntPtr.Zero ? (List<char>) null : new List<char>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextImageData.NativeFieldInfoPtr_chars), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Sprite> sprites
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextImageData.NativeFieldInfoPtr_sprites));
      return pointer == IntPtr.Zero ? (List<Sprite>) null : new List<Sprite>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextImageData.NativeFieldInfoPtr_sprites), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
