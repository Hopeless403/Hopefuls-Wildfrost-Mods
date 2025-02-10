// Decompiled with JetBrains decompiler
// Type: ShopPrice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
public class ShopPrice : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_target;
  private static readonly IntPtr NativeFieldInfoPtr_follow;
  private static readonly IntPtr NativeFieldInfoPtr_offset;
  private static readonly IntPtr NativeFieldInfoPtr_textAsset;
  private static readonly IntPtr NativeFieldInfoPtr_format;
  private static readonly IntPtr NativeFieldInfoPtr_discountedFormat;
  private static readonly IntPtr NativeFieldInfoPtr_scaleWithTarget;
  private static readonly IntPtr NativeFieldInfoPtr_scaleOffsetWithTarget;
  private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_ShopItem_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetOffset_Public_Void_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPrice_Public_Void_Int32_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetText_Private_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdatePosition_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48974, XrefRangeEnd = 48977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(ShopItem target, Vector3 offset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &offset;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShopPrice.NativeMethodInfoPtr_Set_Public_Void_ShopItem_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void SetOffset(Vector3 offset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &offset
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShopPrice.NativeMethodInfoPtr_SetOffset_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 48988, RefRangeEnd = 48996, XrefRangeStart = 48977, XrefRangeEnd = 48988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPrice(int price, float priceFactor = 1f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &price;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &priceFactor;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShopPrice.NativeMethodInfoPtr_SetPrice_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48996, XrefRangeEnd = 48997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetText(string text)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(text)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShopPrice.NativeMethodInfoPtr_SetText_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48997, XrefRangeEnd = 49001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Check()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShopPrice.NativeMethodInfoPtr_Check_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 49018, RefRangeEnd = 49019, XrefRangeStart = 49001, XrefRangeEnd = 49018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdatePosition()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShopPrice.NativeMethodInfoPtr_UpdatePosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49019, XrefRangeEnd = 49028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShopPrice()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopPrice>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShopPrice.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ShopPrice()
  {
    Il2CppClassPointerStore<ShopPrice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ShopPrice));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopPrice>.NativeClassPtr);
    ShopPrice.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPrice>.NativeClassPtr, nameof (target));
    ShopPrice.NativeFieldInfoPtr_follow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPrice>.NativeClassPtr, nameof (follow));
    ShopPrice.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPrice>.NativeClassPtr, nameof (offset));
    ShopPrice.NativeFieldInfoPtr_textAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPrice>.NativeClassPtr, nameof (textAsset));
    ShopPrice.NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPrice>.NativeClassPtr, nameof (format));
    ShopPrice.NativeFieldInfoPtr_discountedFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPrice>.NativeClassPtr, nameof (discountedFormat));
    ShopPrice.NativeFieldInfoPtr_scaleWithTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPrice>.NativeClassPtr, nameof (scaleWithTarget));
    ShopPrice.NativeFieldInfoPtr_scaleOffsetWithTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPrice>.NativeClassPtr, nameof (scaleOffsetWithTarget));
    ShopPrice.NativeMethodInfoPtr_Set_Public_Void_ShopItem_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPrice>.NativeClassPtr, 100667121);
    ShopPrice.NativeMethodInfoPtr_SetOffset_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPrice>.NativeClassPtr, 100667122);
    ShopPrice.NativeMethodInfoPtr_SetPrice_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPrice>.NativeClassPtr, 100667123);
    ShopPrice.NativeMethodInfoPtr_SetText_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPrice>.NativeClassPtr, 100667124);
    ShopPrice.NativeMethodInfoPtr_Check_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPrice>.NativeClassPtr, 100667125);
    ShopPrice.NativeMethodInfoPtr_UpdatePosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPrice>.NativeClassPtr, 100667126);
    ShopPrice.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPrice>.NativeClassPtr, 100667127);
  }

  public ShopPrice(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe ShopItem target
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShopPrice.NativeFieldInfoPtr_target));
      return pointer == IntPtr.Zero ? (ShopItem) null : new ShopItem(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShopPrice.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform follow
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShopPrice.NativeFieldInfoPtr_follow));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShopPrice.NativeFieldInfoPtr_follow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 offset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShopPrice.NativeFieldInfoPtr_offset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShopPrice.NativeFieldInfoPtr_offset)) = value;
    }
  }

  public unsafe TMP_Text textAsset
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShopPrice.NativeFieldInfoPtr_textAsset));
      return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShopPrice.NativeFieldInfoPtr_textAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string format
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShopPrice.NativeFieldInfoPtr_format)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShopPrice.NativeFieldInfoPtr_format), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string discountedFormat
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShopPrice.NativeFieldInfoPtr_discountedFormat)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShopPrice.NativeFieldInfoPtr_discountedFormat), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe float scaleWithTarget
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShopPrice.NativeFieldInfoPtr_scaleWithTarget));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShopPrice.NativeFieldInfoPtr_scaleWithTarget)) = value;
    }
  }

  public unsafe float scaleOffsetWithTarget
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShopPrice.NativeFieldInfoPtr_scaleOffsetWithTarget));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShopPrice.NativeFieldInfoPtr_scaleOffsetWithTarget)) = value;
    }
  }

  public enum Position
  {
    Top,
    Bottom,
  }
}
