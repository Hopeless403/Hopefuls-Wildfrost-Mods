// Decompiled with JetBrains decompiler
// Type: TurnOrderNumber
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
using UnityEngine.UI;

#nullable disable
public class TurnOrderNumber : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_glow;
  private static readonly IntPtr NativeFieldInfoPtr_imminentGlowColour;
  private static readonly IntPtr NativeFieldInfoPtr_image;
  private static readonly IntPtr NativeFieldInfoPtr_imminentSprite;
  private static readonly IntPtr NativeFieldInfoPtr_textElement;
  private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Entity_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96378, XrefRangeEnd = 96382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Entity entity, int number)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &number;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TurnOrderNumber.NativeMethodInfoPtr_Set_Public_Void_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96382, XrefRangeEnd = 96383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TurnOrderNumber()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TurnOrderNumber>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TurnOrderNumber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TurnOrderNumber()
  {
    Il2CppClassPointerStore<TurnOrderNumber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TurnOrderNumber));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TurnOrderNumber>.NativeClassPtr);
    TurnOrderNumber.NativeFieldInfoPtr_glow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnOrderNumber>.NativeClassPtr, nameof (glow));
    TurnOrderNumber.NativeFieldInfoPtr_imminentGlowColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnOrderNumber>.NativeClassPtr, nameof (imminentGlowColour));
    TurnOrderNumber.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnOrderNumber>.NativeClassPtr, nameof (image));
    TurnOrderNumber.NativeFieldInfoPtr_imminentSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnOrderNumber>.NativeClassPtr, nameof (imminentSprite));
    TurnOrderNumber.NativeFieldInfoPtr_textElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnOrderNumber>.NativeClassPtr, nameof (textElement));
    TurnOrderNumber.NativeMethodInfoPtr_Set_Public_Void_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnOrderNumber>.NativeClassPtr, 100671699);
    TurnOrderNumber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnOrderNumber>.NativeClassPtr, 100671700);
  }

  public TurnOrderNumber(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Image glow
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TurnOrderNumber.NativeFieldInfoPtr_glow));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TurnOrderNumber.NativeFieldInfoPtr_glow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color imminentGlowColour
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TurnOrderNumber.NativeFieldInfoPtr_imminentGlowColour));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TurnOrderNumber.NativeFieldInfoPtr_imminentGlowColour)) = value;
    }
  }

  public unsafe Image image
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TurnOrderNumber.NativeFieldInfoPtr_image));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TurnOrderNumber.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite imminentSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TurnOrderNumber.NativeFieldInfoPtr_imminentSprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TurnOrderNumber.NativeFieldInfoPtr_imminentSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text textElement
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TurnOrderNumber.NativeFieldInfoPtr_textElement));
      return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TurnOrderNumber.NativeFieldInfoPtr_textElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
