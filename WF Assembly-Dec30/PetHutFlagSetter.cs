// Decompiled with JetBrains decompiler
// Type: PetHutFlagSetter
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
public class PetHutFlagSetter : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_flag;
  private static readonly IntPtr NativeFieldInfoPtr_flagSprites;
  private static readonly IntPtr NativeMethodInfoPtr_SetupFlag_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85421, XrefRangeEnd = 85433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupFlag()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PetHutFlagSetter.NativeMethodInfoPtr_SetupFlag_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PetHutFlagSetter()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PetHutFlagSetter>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PetHutFlagSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static PetHutFlagSetter()
  {
    Il2CppClassPointerStore<PetHutFlagSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (PetHutFlagSetter));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PetHutFlagSetter>.NativeClassPtr);
    PetHutFlagSetter.NativeFieldInfoPtr_flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetHutFlagSetter>.NativeClassPtr, nameof (flag));
    PetHutFlagSetter.NativeFieldInfoPtr_flagSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetHutFlagSetter>.NativeClassPtr, nameof (flagSprites));
    PetHutFlagSetter.NativeMethodInfoPtr_SetupFlag_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PetHutFlagSetter>.NativeClassPtr, 100670433);
    PetHutFlagSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PetHutFlagSetter>.NativeClassPtr, 100670434);
  }

  public PetHutFlagSetter(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe SpriteRenderer flag
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PetHutFlagSetter.NativeFieldInfoPtr_flag));
      return pointer == IntPtr.Zero ? (SpriteRenderer) null : new SpriteRenderer(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PetHutFlagSetter.NativeFieldInfoPtr_flag), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Sprite> flagSprites
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PetHutFlagSetter.NativeFieldInfoPtr_flagSprites));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : new Il2CppReferenceArray<Sprite>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PetHutFlagSetter.NativeFieldInfoPtr_flagSprites), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
