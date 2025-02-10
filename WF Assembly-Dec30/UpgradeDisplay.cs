// Decompiled with JetBrains decompiler
// Type: UpgradeDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class UpgradeDisplay : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr__data_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr_image;
  private static readonly IntPtr NativeFieldInfoPtr_navigationItem;
  private static readonly IntPtr NativeFieldInfoPtr__raycast;
  private static readonly IntPtr NativeMethodInfoPtr_get_data_Public_get_CardUpgradeData_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_data_Private_set_Void_CardUpgradeData_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_raycast_Private_get_Image_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_CanRaycast_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Virtual_New_Void_CardUpgradeData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe CardUpgradeData data
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpgradeDisplay.NativeMethodInfoPtr_get_data_Public_get_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (CardUpgradeData) null : new CardUpgradeData(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpgradeDisplay.NativeMethodInfoPtr_set_data_Private_set_Void_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe Image raycast
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44367, XrefRangeEnd = 44371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpgradeDisplay.NativeMethodInfoPtr_get_raycast_Private_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
  }

  public unsafe bool CanRaycast
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 44376, RefRangeEnd = 44383, XrefRangeStart = 44371, XrefRangeEnd = 44376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpgradeDisplay.NativeMethodInfoPtr_set_CanRaycast_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44383, XrefRangeEnd = 44386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SetData(CardUpgradeData data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpgradeDisplay.NativeMethodInfoPtr_SetData_Public_Virtual_New_Void_CardUpgradeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UpgradeDisplay()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpgradeDisplay>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UpgradeDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static UpgradeDisplay()
  {
    Il2CppClassPointerStore<UpgradeDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (UpgradeDisplay));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpgradeDisplay>.NativeClassPtr);
    UpgradeDisplay.NativeFieldInfoPtr__data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeDisplay>.NativeClassPtr, "<data>k__BackingField");
    UpgradeDisplay.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeDisplay>.NativeClassPtr, nameof (image));
    UpgradeDisplay.NativeFieldInfoPtr_navigationItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeDisplay>.NativeClassPtr, nameof (navigationItem));
    UpgradeDisplay.NativeFieldInfoPtr__raycast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeDisplay>.NativeClassPtr, nameof (_raycast));
    UpgradeDisplay.NativeMethodInfoPtr_get_data_Public_get_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeDisplay>.NativeClassPtr, 100666615);
    UpgradeDisplay.NativeMethodInfoPtr_set_data_Private_set_Void_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeDisplay>.NativeClassPtr, 100666616);
    UpgradeDisplay.NativeMethodInfoPtr_get_raycast_Private_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeDisplay>.NativeClassPtr, 100666617);
    UpgradeDisplay.NativeMethodInfoPtr_set_CanRaycast_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeDisplay>.NativeClassPtr, 100666618);
    UpgradeDisplay.NativeMethodInfoPtr_SetData_Public_Virtual_New_Void_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeDisplay>.NativeClassPtr, 100666619);
    UpgradeDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeDisplay>.NativeClassPtr, 100666620);
  }

  public UpgradeDisplay(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe CardUpgradeData _data_k__BackingField
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeDisplay.NativeFieldInfoPtr__data_k__BackingField));
      return pointer == IntPtr.Zero ? (CardUpgradeData) null : new CardUpgradeData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpgradeDisplay.NativeFieldInfoPtr__data_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image image
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeDisplay.NativeFieldInfoPtr_image));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpgradeDisplay.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UINavigationItem navigationItem
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeDisplay.NativeFieldInfoPtr_navigationItem));
      return pointer == IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpgradeDisplay.NativeFieldInfoPtr_navigationItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image _raycast
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeDisplay.NativeFieldInfoPtr__raycast));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpgradeDisplay.NativeFieldInfoPtr__raycast), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
