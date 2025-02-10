// Decompiled with JetBrains decompiler
// Type: ShopItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class ShopItem : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_price;
  private static readonly IntPtr NativeFieldInfoPtr_priceFactor;
  private static readonly IntPtr NativeMethodInfoPtr_GetPrice_Public_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48973, XrefRangeEnd = 48974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetPrice()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShopItem.NativeMethodInfoPtr_GetPrice_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShopItem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopItem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShopItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ShopItem()
  {
    Il2CppClassPointerStore<ShopItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ShopItem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopItem>.NativeClassPtr);
    ShopItem.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopItem>.NativeClassPtr, nameof (price));
    ShopItem.NativeFieldInfoPtr_priceFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopItem>.NativeClassPtr, nameof (priceFactor));
    ShopItem.NativeMethodInfoPtr_GetPrice_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopItem>.NativeClassPtr, 100667119);
    ShopItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopItem>.NativeClassPtr, 100667120);
  }

  public ShopItem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int price
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShopItem.NativeFieldInfoPtr_price));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShopItem.NativeFieldInfoPtr_price)) = value;
    }
  }

  public unsafe float priceFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShopItem.NativeFieldInfoPtr_priceFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShopItem.NativeFieldInfoPtr_priceFactor)) = value;
    }
  }
}
