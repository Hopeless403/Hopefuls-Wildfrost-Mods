// Decompiled with JetBrains decompiler
// Type: ItemHolderPet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class ItemHolderPet : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_owner;
  private static readonly IntPtr NativeFieldInfoPtr_usedPrefab;
  private static readonly IntPtr NativeFieldInfoPtr_showTween;
  private static readonly IntPtr NativeFieldInfoPtr_headWobbler;
  private static readonly IntPtr NativeFieldInfoPtr_headOptions;
  private static readonly IntPtr NativeFieldInfoPtr_head;
  private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Used_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 50986, RefRangeEnd = 50987, XrefRangeStart = 50964, XrefRangeEnd = 50986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Show()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ItemHolderPet.NativeMethodInfoPtr_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 50996, RefRangeEnd = 50997, XrefRangeStart = 50987, XrefRangeEnd = 50996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hide()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ItemHolderPet.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 51018, RefRangeEnd = 51020, XrefRangeStart = 50997, XrefRangeEnd = 51018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Used()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ItemHolderPet.NativeMethodInfoPtr_Used_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ItemHolderPet()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemHolderPet>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ItemHolderPet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ItemHolderPet()
  {
    Il2CppClassPointerStore<ItemHolderPet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ItemHolderPet));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemHolderPet>.NativeClassPtr);
    ItemHolderPet.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemHolderPet>.NativeClassPtr, nameof (owner));
    ItemHolderPet.NativeFieldInfoPtr_usedPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemHolderPet>.NativeClassPtr, nameof (usedPrefab));
    ItemHolderPet.NativeFieldInfoPtr_showTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemHolderPet>.NativeClassPtr, nameof (showTween));
    ItemHolderPet.NativeFieldInfoPtr_headWobbler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemHolderPet>.NativeClassPtr, nameof (headWobbler));
    ItemHolderPet.NativeFieldInfoPtr_headOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemHolderPet>.NativeClassPtr, nameof (headOptions));
    ItemHolderPet.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemHolderPet>.NativeClassPtr, nameof (head));
    ItemHolderPet.NativeMethodInfoPtr_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemHolderPet>.NativeClassPtr, 100667386);
    ItemHolderPet.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemHolderPet>.NativeClassPtr, 100667387);
    ItemHolderPet.NativeMethodInfoPtr_Used_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemHolderPet>.NativeClassPtr, 100667388);
    ItemHolderPet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemHolderPet>.NativeClassPtr, 100667389);
  }

  public ItemHolderPet(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Entity owner
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemHolderPet.NativeFieldInfoPtr_owner));
      return pointer == IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemHolderPet.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ItemHolderPetUsed usedPrefab
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemHolderPet.NativeFieldInfoPtr_usedPrefab));
      return pointer == IntPtr.Zero ? (ItemHolderPetUsed) null : new ItemHolderPetUsed(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemHolderPet.NativeFieldInfoPtr_usedPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TweenUI showTween
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemHolderPet.NativeFieldInfoPtr_showTween));
      return pointer == IntPtr.Zero ? (TweenUI) null : new TweenUI(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemHolderPet.NativeFieldInfoPtr_showTween), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AngleWobbler headWobbler
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemHolderPet.NativeFieldInfoPtr_headWobbler));
      return pointer == IntPtr.Zero ? (AngleWobbler) null : new AngleWobbler(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemHolderPet.NativeFieldInfoPtr_headWobbler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Sprite> headOptions
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemHolderPet.NativeFieldInfoPtr_headOptions));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : new Il2CppReferenceArray<Sprite>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemHolderPet.NativeFieldInfoPtr_headOptions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image head
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemHolderPet.NativeFieldInfoPtr_head));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemHolderPet.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
