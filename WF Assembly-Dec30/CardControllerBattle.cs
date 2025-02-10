// Decompiled with JetBrains decompiler
// Type: CardControllerBattle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class CardControllerBattle : CardController
{
  private static readonly IntPtr NativeFieldInfoPtr_useOnHandAnchor;
  private static readonly IntPtr NativeMethodInfoPtr_Press_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_DragUpdatePosition_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_DragCancel_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_DragEnd_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Release_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33505, XrefRangeEnd = 33532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Press()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardControllerBattle.NativeMethodInfoPtr_Press_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33532, XrefRangeEnd = 33653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DragUpdatePosition()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardControllerBattle.NativeMethodInfoPtr_DragUpdatePosition_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33653, XrefRangeEnd = 33656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DragCancel()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardControllerBattle.NativeMethodInfoPtr_DragCancel_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33656, XrefRangeEnd = 33661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DragEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardControllerBattle.NativeMethodInfoPtr_DragEnd_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33661, XrefRangeEnd = 33715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardControllerBattle.NativeMethodInfoPtr_Release_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardControllerBattle()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardControllerBattle>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardControllerBattle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardControllerBattle()
  {
    Il2CppClassPointerStore<CardControllerBattle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardControllerBattle));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardControllerBattle>.NativeClassPtr);
    CardControllerBattle.NativeFieldInfoPtr_useOnHandAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardControllerBattle>.NativeClassPtr, nameof (useOnHandAnchor));
    CardControllerBattle.NativeMethodInfoPtr_Press_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerBattle>.NativeClassPtr, 100665405);
    CardControllerBattle.NativeMethodInfoPtr_DragUpdatePosition_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerBattle>.NativeClassPtr, 100665406);
    CardControllerBattle.NativeMethodInfoPtr_DragCancel_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerBattle>.NativeClassPtr, 100665407);
    CardControllerBattle.NativeMethodInfoPtr_DragEnd_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerBattle>.NativeClassPtr, 100665408);
    CardControllerBattle.NativeMethodInfoPtr_Release_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerBattle>.NativeClassPtr, 100665409);
    CardControllerBattle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardControllerBattle>.NativeClassPtr, 100665410);
  }

  public CardControllerBattle(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe UINavigationItem useOnHandAnchor
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardControllerBattle.NativeFieldInfoPtr_useOnHandAnchor));
      return pointer == IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardControllerBattle.NativeFieldInfoPtr_useOnHandAnchor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
