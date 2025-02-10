// Decompiled with JetBrains decompiler
// Type: CardControllerCardOrganizer
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
public class CardControllerCardOrganizer : CardController
{
  private static readonly IntPtr NativeFieldInfoPtr_cardPlane;
  private static readonly IntPtr NativeFieldInfoPtr_snapOffset;
  private static readonly IntPtr NativeFieldInfoPtr_snapSize;
  private static readonly IntPtr NativeMethodInfoPtr_Press_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Release_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_DragUpdatePosition_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Snap_Private_Vector3_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33715, XrefRangeEnd = 33722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Press()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardControllerCardOrganizer.NativeMethodInfoPtr_Press_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33722, XrefRangeEnd = 33742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardControllerCardOrganizer.NativeMethodInfoPtr_Release_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33742, XrefRangeEnd = 33761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DragUpdatePosition()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardControllerCardOrganizer.NativeMethodInfoPtr_DragUpdatePosition_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33761, XrefRangeEnd = 33763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 Snap(Vector3 position)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &position
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardControllerCardOrganizer.NativeMethodInfoPtr_Snap_Private_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33763, XrefRangeEnd = 33764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardControllerCardOrganizer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardControllerCardOrganizer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardControllerCardOrganizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardControllerCardOrganizer()
  {
    Il2CppClassPointerStore<CardControllerCardOrganizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardControllerCardOrganizer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardControllerCardOrganizer>.NativeClassPtr);
    CardControllerCardOrganizer.NativeFieldInfoPtr_cardPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardControllerCardOrganizer>.NativeClassPtr, nameof (cardPlane));
    CardControllerCardOrganizer.NativeFieldInfoPtr_snapOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardControllerCardOrganizer>.NativeClassPtr, nameof (snapOffset));
    CardControllerCardOrganizer.NativeFieldInfoPtr_snapSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardControllerCardOrganizer>.NativeClassPtr, nameof (snapSize));
    CardControllerCardOrganizer.NativeMethodInfoPtr_Press_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerCardOrganizer>.NativeClassPtr, 100665411);
    CardControllerCardOrganizer.NativeMethodInfoPtr_Release_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerCardOrganizer>.NativeClassPtr, 100665412);
    CardControllerCardOrganizer.NativeMethodInfoPtr_DragUpdatePosition_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerCardOrganizer>.NativeClassPtr, 100665413);
    CardControllerCardOrganizer.NativeMethodInfoPtr_Snap_Private_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerCardOrganizer>.NativeClassPtr, 100665414);
    CardControllerCardOrganizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerCardOrganizer>.NativeClassPtr, 100665415);
  }

  public CardControllerCardOrganizer(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe CardPlane cardPlane
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerCardOrganizer.NativeFieldInfoPtr_cardPlane));
      return pointer == IntPtr.Zero ? (CardPlane) null : new CardPlane(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardControllerCardOrganizer.NativeFieldInfoPtr_cardPlane), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 snapOffset
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerCardOrganizer.NativeFieldInfoPtr_snapOffset));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerCardOrganizer.NativeFieldInfoPtr_snapOffset)) = value;
    }
  }

  public unsafe Vector2 snapSize
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerCardOrganizer.NativeFieldInfoPtr_snapSize));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerCardOrganizer.NativeFieldInfoPtr_snapSize)) = value;
    }
  }
}
