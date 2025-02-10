// Decompiled with JetBrains decompiler
// Type: Dice
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
public class Dice : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_value;
  private static readonly IntPtr NativeFieldInfoPtr_rb;
  private static readonly IntPtr NativeFieldInfoPtr_spriteRenderer;
  private static readonly IntPtr NativeFieldInfoPtr_throwSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_spinAmount;
  private static readonly IntPtr NativeFieldInfoPtr_drag;
  private static readonly IntPtr NativeFieldInfoPtr_faceSprites;
  private static readonly IntPtr NativeFieldInfoPtr_faceValues;
  private static readonly IntPtr NativeMethodInfoPtr_Roll_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Throw_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Throw_Public_Void_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_DisableCollisions_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42713, XrefRangeEnd = 42717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Roll()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Dice.NativeMethodInfoPtr_Roll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42717, XrefRangeEnd = 42737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Throw()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Dice.NativeMethodInfoPtr_Throw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 42755, RefRangeEnd = 42757, XrefRangeStart = 42737, XrefRangeEnd = 42755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Throw(Vector2 direction)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &direction
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Dice.NativeMethodInfoPtr_Throw_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42757, XrefRangeEnd = 42759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DisableCollisions()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Dice.NativeMethodInfoPtr_DisableCollisions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42759, XrefRangeEnd = 42767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Dice()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dice>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Dice.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Dice()
  {
    Il2CppClassPointerStore<Dice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Dice));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dice>.NativeClassPtr);
    Dice.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dice>.NativeClassPtr, nameof (value));
    Dice.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dice>.NativeClassPtr, nameof (rb));
    Dice.NativeFieldInfoPtr_spriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dice>.NativeClassPtr, nameof (spriteRenderer));
    Dice.NativeFieldInfoPtr_throwSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dice>.NativeClassPtr, nameof (throwSpeed));
    Dice.NativeFieldInfoPtr_spinAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dice>.NativeClassPtr, nameof (spinAmount));
    Dice.NativeFieldInfoPtr_drag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dice>.NativeClassPtr, nameof (drag));
    Dice.NativeFieldInfoPtr_faceSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dice>.NativeClassPtr, nameof (faceSprites));
    Dice.NativeFieldInfoPtr_faceValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dice>.NativeClassPtr, nameof (faceValues));
    Dice.NativeMethodInfoPtr_Roll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dice>.NativeClassPtr, 100666467);
    Dice.NativeMethodInfoPtr_Throw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dice>.NativeClassPtr, 100666468);
    Dice.NativeMethodInfoPtr_Throw_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dice>.NativeClassPtr, 100666469);
    Dice.NativeMethodInfoPtr_DisableCollisions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dice>.NativeClassPtr, 100666470);
    Dice.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dice>.NativeClassPtr, 100666471);
  }

  public Dice(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int value
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Dice.NativeFieldInfoPtr_value));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Dice.NativeFieldInfoPtr_value)) = value;
    }
  }

  public unsafe Rigidbody2D rb
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Dice.NativeFieldInfoPtr_rb));
      return pointer == IntPtr.Zero ? (Rigidbody2D) null : new Rigidbody2D(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Dice.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SpriteRenderer spriteRenderer
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Dice.NativeFieldInfoPtr_spriteRenderer));
      return pointer == IntPtr.Zero ? (SpriteRenderer) null : new SpriteRenderer(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Dice.NativeFieldInfoPtr_spriteRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 throwSpeed
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Dice.NativeFieldInfoPtr_throwSpeed));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Dice.NativeFieldInfoPtr_throwSpeed)) = value;
    }
  }

  public unsafe Vector2 spinAmount
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Dice.NativeFieldInfoPtr_spinAmount));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Dice.NativeFieldInfoPtr_spinAmount)) = value;
    }
  }

  public unsafe Vector2 drag
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Dice.NativeFieldInfoPtr_drag));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Dice.NativeFieldInfoPtr_drag)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<Sprite> faceSprites
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Dice.NativeFieldInfoPtr_faceSprites));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : new Il2CppReferenceArray<Sprite>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Dice.NativeFieldInfoPtr_faceSprites), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<int> faceValues
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Dice.NativeFieldInfoPtr_faceValues));
      return nativeObject == IntPtr.Zero ? (Il2CppStructArray<int>) null : new Il2CppStructArray<int>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Dice.NativeFieldInfoPtr_faceValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
