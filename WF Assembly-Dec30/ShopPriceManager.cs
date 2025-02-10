// Decompiled with JetBrains decompiler
// Type: ShopPriceManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class ShopPriceManager : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_pricePrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_targets;
  private static readonly System.IntPtr NativeFieldInfoPtr_positionProfiles;
  private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_ShopPrice_ShopItem_Position_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_ShopPrice_ShopItem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_ShopItem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49033, XrefRangeEnd = 49046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShopPriceManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 49074, RefRangeEnd = 49082, XrefRangeStart = 49046, XrefRangeEnd = 49074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShopPrice Add(ShopItem target, ShopPrice.Position position)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShopPriceManager.NativeMethodInfoPtr_Add_Public_ShopPrice_ShopItem_Position_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (ShopPrice) null : new ShopPrice(pointer);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 49097, RefRangeEnd = 49101, XrefRangeStart = 49082, XrefRangeEnd = 49097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShopPrice Get(ShopItem target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShopPriceManager.NativeMethodInfoPtr_Get_Public_ShopPrice_ShopItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (ShopPrice) null : new ShopPrice(pointer);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 49108, RefRangeEnd = 49114, XrefRangeStart = 49101, XrefRangeEnd = 49108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Remove(ShopItem target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShopPriceManager.NativeMethodInfoPtr_Remove_Public_Void_ShopItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 49131, RefRangeEnd = 49134, XrefRangeStart = 49114, XrefRangeEnd = 49131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShopPriceManager.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49134, XrefRangeEnd = 49143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShopPriceManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopPriceManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShopPriceManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ShopPriceManager()
  {
    Il2CppClassPointerStore<ShopPriceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ShopPriceManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopPriceManager>.NativeClassPtr);
    ShopPriceManager.NativeFieldInfoPtr_pricePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPriceManager>.NativeClassPtr, nameof (pricePrefab));
    ShopPriceManager.NativeFieldInfoPtr_targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPriceManager>.NativeClassPtr, nameof (targets));
    ShopPriceManager.NativeFieldInfoPtr_positionProfiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPriceManager>.NativeClassPtr, nameof (positionProfiles));
    ShopPriceManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPriceManager>.NativeClassPtr, 100667128);
    ShopPriceManager.NativeMethodInfoPtr_Add_Public_ShopPrice_ShopItem_Position_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPriceManager>.NativeClassPtr, 100667129);
    ShopPriceManager.NativeMethodInfoPtr_Get_Public_ShopPrice_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPriceManager>.NativeClassPtr, 100667130);
    ShopPriceManager.NativeMethodInfoPtr_Remove_Public_Void_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPriceManager>.NativeClassPtr, 100667131);
    ShopPriceManager.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPriceManager>.NativeClassPtr, 100667132);
    ShopPriceManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPriceManager>.NativeClassPtr, 100667133);
  }

  public ShopPriceManager(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe ShopPrice pricePrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShopPriceManager.NativeFieldInfoPtr_pricePrefab));
      return pointer == System.IntPtr.Zero ? (ShopPrice) null : new ShopPrice(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShopPriceManager.NativeFieldInfoPtr_pricePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ShopPrice> targets
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShopPriceManager.NativeFieldInfoPtr_targets));
      return pointer == System.IntPtr.Zero ? (List<ShopPrice>) null : new List<ShopPrice>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShopPriceManager.NativeFieldInfoPtr_targets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<ShopPriceManager.PositionProfile> positionProfiles
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShopPriceManager.NativeFieldInfoPtr_positionProfiles));
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<ShopPriceManager.PositionProfile>) null : new Il2CppStructArray<ShopPriceManager.PositionProfile>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShopPriceManager.NativeFieldInfoPtr_positionProfiles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct PositionProfile
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_type;
    private static readonly System.IntPtr NativeFieldInfoPtr_offset;
    [FieldOffset(0)]
    public ShopPrice.Position type;
    [FieldOffset(4)]
    public Vector3 offset;

    static PositionProfile()
    {
      Il2CppClassPointerStore<ShopPriceManager.PositionProfile>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopPriceManager>.NativeClassPtr, nameof (PositionProfile));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopPriceManager.PositionProfile>.NativeClassPtr);
      ShopPriceManager.PositionProfile.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPriceManager.PositionProfile>.NativeClassPtr, nameof (type));
      ShopPriceManager.PositionProfile.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPriceManager.PositionProfile>.NativeClassPtr, nameof (offset));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShopPriceManager.PositionProfile>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("ShopPriceManager/<>c__DisplayClass4_0")]
  public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_position;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Add_b__0_Internal_Boolean_PositionProfile_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass4_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopPriceManager.__c__DisplayClass4_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShopPriceManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Add_b__0(ShopPriceManager.PositionProfile a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &a
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShopPriceManager.__c__DisplayClass4_0.NativeMethodInfoPtr__Add_b__0_Internal_Boolean_PositionProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass4_0()
    {
      Il2CppClassPointerStore<ShopPriceManager.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopPriceManager>.NativeClassPtr, "<>c__DisplayClass4_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopPriceManager.__c__DisplayClass4_0>.NativeClassPtr);
      ShopPriceManager.__c__DisplayClass4_0.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPriceManager.__c__DisplayClass4_0>.NativeClassPtr, nameof (position));
      ShopPriceManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPriceManager.__c__DisplayClass4_0>.NativeClassPtr, 100667134);
      ShopPriceManager.__c__DisplayClass4_0.NativeMethodInfoPtr__Add_b__0_Internal_Boolean_PositionProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPriceManager.__c__DisplayClass4_0>.NativeClassPtr, 100667135);
    }

    public __c__DisplayClass4_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ShopPrice.Position position
    {
      get
      {
        return *(ShopPrice.Position*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShopPriceManager.__c__DisplayClass4_0.NativeFieldInfoPtr_position));
      }
      [param: In] set
      {
        *(ShopPrice.Position*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShopPriceManager.__c__DisplayClass4_0.NativeFieldInfoPtr_position)) = value;
      }
    }
  }

  [ObfuscatedName("ShopPriceManager/<>c__DisplayClass5_0")]
  public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_target;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Get_b__0_Internal_Boolean_ShopPrice_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass5_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopPriceManager.__c__DisplayClass5_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShopPriceManager.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49028, XrefRangeEnd = 49033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Get_b__0(ShopPrice a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShopPriceManager.__c__DisplayClass5_0.NativeMethodInfoPtr__Get_b__0_Internal_Boolean_ShopPrice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass5_0()
    {
      Il2CppClassPointerStore<ShopPriceManager.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopPriceManager>.NativeClassPtr, "<>c__DisplayClass5_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopPriceManager.__c__DisplayClass5_0>.NativeClassPtr);
      ShopPriceManager.__c__DisplayClass5_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPriceManager.__c__DisplayClass5_0>.NativeClassPtr, nameof (target));
      ShopPriceManager.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPriceManager.__c__DisplayClass5_0>.NativeClassPtr, 100667136);
      ShopPriceManager.__c__DisplayClass5_0.NativeMethodInfoPtr__Get_b__0_Internal_Boolean_ShopPrice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPriceManager.__c__DisplayClass5_0>.NativeClassPtr, 100667137);
    }

    public __c__DisplayClass5_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ShopItem target
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShopPriceManager.__c__DisplayClass5_0.NativeFieldInfoPtr_target));
        return pointer == System.IntPtr.Zero ? (ShopItem) null : new ShopItem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShopPriceManager.__c__DisplayClass5_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
