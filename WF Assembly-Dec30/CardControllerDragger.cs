// Decompiled with JetBrains decompiler
// Type: CardControllerDragger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class CardControllerDragger : CardController
{
  private static readonly IntPtr NativeFieldInfoPtr_canDrag;
  private static readonly IntPtr NativeFieldInfoPtr_onDrag;
  private static readonly IntPtr NativeFieldInfoPtr_onRelease;
  private static readonly IntPtr NativeFieldInfoPtr_onCancel;
  private static readonly IntPtr NativeMethodInfoPtr_Press_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_DragCancel_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Release_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_DragEnd_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33896, XrefRangeEnd = 33907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Press()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardControllerDragger.NativeMethodInfoPtr_Press_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33907, XrefRangeEnd = 33914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DragCancel()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardControllerDragger.NativeMethodInfoPtr_DragCancel_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33914, XrefRangeEnd = 33921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardControllerDragger.NativeMethodInfoPtr_Release_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33921, XrefRangeEnd = 33924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DragEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardControllerDragger.NativeMethodInfoPtr_DragEnd_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33924, XrefRangeEnd = 33925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardControllerDragger()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardControllerDragger>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardControllerDragger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardControllerDragger()
  {
    Il2CppClassPointerStore<CardControllerDragger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardControllerDragger));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardControllerDragger>.NativeClassPtr);
    CardControllerDragger.NativeFieldInfoPtr_canDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardControllerDragger>.NativeClassPtr, nameof (canDrag));
    CardControllerDragger.NativeFieldInfoPtr_onDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardControllerDragger>.NativeClassPtr, nameof (onDrag));
    CardControllerDragger.NativeFieldInfoPtr_onRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardControllerDragger>.NativeClassPtr, nameof (onRelease));
    CardControllerDragger.NativeFieldInfoPtr_onCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardControllerDragger>.NativeClassPtr, nameof (onCancel));
    CardControllerDragger.NativeMethodInfoPtr_Press_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerDragger>.NativeClassPtr, 100665438);
    CardControllerDragger.NativeMethodInfoPtr_DragCancel_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerDragger>.NativeClassPtr, 100665439);
    CardControllerDragger.NativeMethodInfoPtr_Release_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerDragger>.NativeClassPtr, 100665440);
    CardControllerDragger.NativeMethodInfoPtr_DragEnd_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerDragger>.NativeClassPtr, 100665441);
    CardControllerDragger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerDragger>.NativeClassPtr, 100665442);
  }

  public CardControllerDragger(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool canDrag
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerDragger.NativeFieldInfoPtr_canDrag));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerDragger.NativeFieldInfoPtr_canDrag)) = value;
    }
  }

  public unsafe UnityEventEntity onDrag
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerDragger.NativeFieldInfoPtr_onDrag));
      return pointer == IntPtr.Zero ? (UnityEventEntity) null : new UnityEventEntity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardControllerDragger.NativeFieldInfoPtr_onDrag), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEventEntity onRelease
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerDragger.NativeFieldInfoPtr_onRelease));
      return pointer == IntPtr.Zero ? (UnityEventEntity) null : new UnityEventEntity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardControllerDragger.NativeFieldInfoPtr_onRelease), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEventEntity onCancel
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerDragger.NativeFieldInfoPtr_onCancel));
      return pointer == IntPtr.Zero ? (UnityEventEntity) null : new UnityEventEntity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardControllerDragger.NativeFieldInfoPtr_onCancel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
