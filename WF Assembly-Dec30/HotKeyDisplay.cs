// Decompiled with JetBrains decompiler
// Type: HotKeyDisplay
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
public class HotKeyDisplay : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr__image;
  private static readonly IntPtr NativeFieldInfoPtr_actionName;
  private static readonly IntPtr NativeMethodInfoPtr_get_image_Private_get_Image_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetActionName_Public_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe Image image
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 90352, RefRangeEnd = 90353, XrefRangeStart = 90348, XrefRangeEnd = 90352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(HotKeyDisplay.NativeMethodInfoPtr_get_image_Private_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90353, XrefRangeEnd = 90362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HotKeyDisplay.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90362, XrefRangeEnd = 90370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HotKeyDisplay.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 90393, RefRangeEnd = 90395, XrefRangeStart = 90370, XrefRangeEnd = 90393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Refresh()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HotKeyDisplay.NativeMethodInfoPtr_Refresh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 90397, RefRangeEnd = 90398, XrefRangeStart = 90395, XrefRangeEnd = 90397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetActionName(string value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(value)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HotKeyDisplay.NativeMethodInfoPtr_SetActionName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HotKeyDisplay()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HotKeyDisplay>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HotKeyDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static HotKeyDisplay()
  {
    Il2CppClassPointerStore<HotKeyDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (HotKeyDisplay));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HotKeyDisplay>.NativeClassPtr);
    HotKeyDisplay.NativeFieldInfoPtr__image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotKeyDisplay>.NativeClassPtr, nameof (_image));
    HotKeyDisplay.NativeFieldInfoPtr_actionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotKeyDisplay>.NativeClassPtr, nameof (actionName));
    HotKeyDisplay.NativeMethodInfoPtr_get_image_Private_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotKeyDisplay>.NativeClassPtr, 100671051);
    HotKeyDisplay.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotKeyDisplay>.NativeClassPtr, 100671052);
    HotKeyDisplay.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotKeyDisplay>.NativeClassPtr, 100671053);
    HotKeyDisplay.NativeMethodInfoPtr_Refresh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotKeyDisplay>.NativeClassPtr, 100671054);
    HotKeyDisplay.NativeMethodInfoPtr_SetActionName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotKeyDisplay>.NativeClassPtr, 100671055);
    HotKeyDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotKeyDisplay>.NativeClassPtr, 100671056);
  }

  public HotKeyDisplay(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Image _image
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HotKeyDisplay.NativeFieldInfoPtr__image));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HotKeyDisplay.NativeFieldInfoPtr__image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string actionName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HotKeyDisplay.NativeFieldInfoPtr_actionName)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HotKeyDisplay.NativeFieldInfoPtr_actionName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
