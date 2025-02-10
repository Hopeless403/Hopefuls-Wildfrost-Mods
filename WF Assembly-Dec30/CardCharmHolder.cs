// Decompiled with JetBrains decompiler
// Type: CardCharmHolder
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
public class CardCharmHolder : UpgradeHolder
{
  private static readonly IntPtr NativeFieldInfoPtr_angleAdd;
  private static readonly IntPtr NativeFieldInfoPtr_charmPivot;
  private static readonly IntPtr NativeFieldInfoPtr_ropeImage;
  private static readonly IntPtr NativeMethodInfoPtr_SetPositions_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CalculateSiblingIndex_Private_Static_Int32_Int32_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Void_UpgradeDisplay_0;
  private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_Void_Int32_UpgradeDisplay_0;
  private static readonly IntPtr NativeMethodInfoPtr_CharmAdded_Private_Void_UpgradeDisplay_0;
  private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44048, XrefRangeEnd = 44059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void SetPositions()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardCharmHolder.NativeMethodInfoPtr_SetPositions_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 44065, RefRangeEnd = 44066, XrefRangeStart = 44059, XrefRangeEnd = 44065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int CalculateSiblingIndex(int listIndex, int listLength)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &listIndex;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &listLength;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardCharmHolder.NativeMethodInfoPtr_CalculateSiblingIndex_Private_Static_Int32_Int32_Int32_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44066, XrefRangeEnd = 44067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Add(UpgradeDisplay upgrade)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgrade)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardCharmHolder.NativeMethodInfoPtr_Add_Public_Virtual_Void_UpgradeDisplay_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44067, XrefRangeEnd = 44083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Insert(int index, UpgradeDisplay upgrade)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &index;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgrade);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardCharmHolder.NativeMethodInfoPtr_Insert_Public_Virtual_Void_Int32_UpgradeDisplay_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 44091, RefRangeEnd = 44093, XrefRangeStart = 44083, XrefRangeEnd = 44091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CharmAdded(UpgradeDisplay upgrade)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgrade)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardCharmHolder.NativeMethodInfoPtr_CharmAdded_Private_Void_UpgradeDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44093, XrefRangeEnd = 44099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardCharmHolder.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44099, XrefRangeEnd = 44100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardCharmHolder()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardCharmHolder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardCharmHolder()
  {
    Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardCharmHolder));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr);
    CardCharmHolder.NativeFieldInfoPtr_angleAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr, nameof (angleAdd));
    CardCharmHolder.NativeFieldInfoPtr_charmPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr, nameof (charmPivot));
    CardCharmHolder.NativeFieldInfoPtr_ropeImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr, nameof (ropeImage));
    CardCharmHolder.NativeMethodInfoPtr_SetPositions_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr, 100666594);
    CardCharmHolder.NativeMethodInfoPtr_CalculateSiblingIndex_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr, 100666595);
    CardCharmHolder.NativeMethodInfoPtr_Add_Public_Virtual_Void_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr, 100666596);
    CardCharmHolder.NativeMethodInfoPtr_Insert_Public_Virtual_Void_Int32_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr, 100666597);
    CardCharmHolder.NativeMethodInfoPtr_CharmAdded_Private_Void_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr, 100666598);
    CardCharmHolder.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr, 100666599);
    CardCharmHolder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr, 100666600);
  }

  public CardCharmHolder(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float angleAdd
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharmHolder.NativeFieldInfoPtr_angleAdd));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharmHolder.NativeFieldInfoPtr_angleAdd)) = value;
    }
  }

  public unsafe Vector2 charmPivot
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharmHolder.NativeFieldInfoPtr_charmPivot));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharmHolder.NativeFieldInfoPtr_charmPivot)) = value;
    }
  }

  public unsafe Image ropeImage
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardCharmHolder.NativeFieldInfoPtr_ropeImage));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardCharmHolder.NativeFieldInfoPtr_ropeImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
