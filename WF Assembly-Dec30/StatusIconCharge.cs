// Decompiled with JetBrains decompiler
// Type: StatusIconCharge
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
public class StatusIconCharge : StatusIcon
{
  private static readonly IntPtr NativeFieldInfoPtr_chargedSprite;
  private static readonly IntPtr NativeFieldInfoPtr_chargedMaterial;
  private static readonly IntPtr NativeFieldInfoPtr_snowSprite;
  private static readonly IntPtr NativeFieldInfoPtr_snowMaterial;
  private static readonly IntPtr NativeFieldInfoPtr__image;
  private static readonly IntPtr NativeFieldInfoPtr_baseSprite;
  private static readonly IntPtr NativeFieldInfoPtr_baseMaterial;
  private static readonly IntPtr NativeMethodInfoPtr_get_image_Private_get_Image_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckSetSprite_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe Image image
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54326, XrefRangeEnd = 54335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusIconCharge.NativeMethodInfoPtr_get_image_Private_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54335, XrefRangeEnd = 54337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusIconCharge.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54337, XrefRangeEnd = 54364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckSetSprite()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusIconCharge.NativeMethodInfoPtr_CheckSetSprite_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54364, XrefRangeEnd = 54365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusIconCharge()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusIconCharge>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusIconCharge.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatusIconCharge()
  {
    Il2CppClassPointerStore<StatusIconCharge>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusIconCharge));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusIconCharge>.NativeClassPtr);
    StatusIconCharge.NativeFieldInfoPtr_chargedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIconCharge>.NativeClassPtr, nameof (chargedSprite));
    StatusIconCharge.NativeFieldInfoPtr_chargedMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIconCharge>.NativeClassPtr, nameof (chargedMaterial));
    StatusIconCharge.NativeFieldInfoPtr_snowSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIconCharge>.NativeClassPtr, nameof (snowSprite));
    StatusIconCharge.NativeFieldInfoPtr_snowMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIconCharge>.NativeClassPtr, nameof (snowMaterial));
    StatusIconCharge.NativeFieldInfoPtr__image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIconCharge>.NativeClassPtr, nameof (_image));
    StatusIconCharge.NativeFieldInfoPtr_baseSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIconCharge>.NativeClassPtr, nameof (baseSprite));
    StatusIconCharge.NativeFieldInfoPtr_baseMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIconCharge>.NativeClassPtr, nameof (baseMaterial));
    StatusIconCharge.NativeMethodInfoPtr_get_image_Private_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIconCharge>.NativeClassPtr, 100667762);
    StatusIconCharge.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIconCharge>.NativeClassPtr, 100667763);
    StatusIconCharge.NativeMethodInfoPtr_CheckSetSprite_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIconCharge>.NativeClassPtr, 100667764);
    StatusIconCharge.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIconCharge>.NativeClassPtr, 100667765);
  }

  public StatusIconCharge(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Sprite chargedSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIconCharge.NativeFieldInfoPtr_chargedSprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIconCharge.NativeFieldInfoPtr_chargedSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material chargedMaterial
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIconCharge.NativeFieldInfoPtr_chargedMaterial));
      return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIconCharge.NativeFieldInfoPtr_chargedMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite snowSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIconCharge.NativeFieldInfoPtr_snowSprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIconCharge.NativeFieldInfoPtr_snowSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material snowMaterial
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIconCharge.NativeFieldInfoPtr_snowMaterial));
      return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIconCharge.NativeFieldInfoPtr_snowMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image _image
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIconCharge.NativeFieldInfoPtr__image));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIconCharge.NativeFieldInfoPtr__image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite baseSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIconCharge.NativeFieldInfoPtr_baseSprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIconCharge.NativeFieldInfoPtr_baseSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material baseMaterial
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIconCharge.NativeFieldInfoPtr_baseMaterial));
      return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIconCharge.NativeFieldInfoPtr_baseMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
