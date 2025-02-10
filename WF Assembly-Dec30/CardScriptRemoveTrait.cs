// Decompiled with JetBrains decompiler
// Type: CardScriptRemoveTrait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class CardScriptRemoveTrait : CardScript
{
  private static readonly IntPtr NativeFieldInfoPtr_removeAll;
  private static readonly IntPtr NativeFieldInfoPtr_toRemove;
  private static readonly IntPtr NativeFieldInfoPtr_excluding;
  private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__Run_b__3_0_Private_Boolean_TraitStacks_0;
  private static readonly IntPtr NativeMethodInfoPtr__Run_b__3_1_Private_Boolean_TraitStacks_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20561, XrefRangeEnd = 20589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Run(CardData target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardScriptRemoveTrait.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardScriptRemoveTrait()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardScriptRemoveTrait>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardScriptRemoveTrait.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20589, XrefRangeEnd = 20593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool _Run_b__3_0(CardData.TraitStacks a)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardScriptRemoveTrait.NativeMethodInfoPtr__Run_b__3_0_Private_Boolean_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20593, XrefRangeEnd = 20597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool _Run_b__3_1(CardData.TraitStacks a)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardScriptRemoveTrait.NativeMethodInfoPtr__Run_b__3_1_Private_Boolean_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  static CardScriptRemoveTrait()
  {
    Il2CppClassPointerStore<CardScriptRemoveTrait>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardScriptRemoveTrait));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardScriptRemoveTrait>.NativeClassPtr);
    CardScriptRemoveTrait.NativeFieldInfoPtr_removeAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptRemoveTrait>.NativeClassPtr, nameof (removeAll));
    CardScriptRemoveTrait.NativeFieldInfoPtr_toRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptRemoveTrait>.NativeClassPtr, nameof (toRemove));
    CardScriptRemoveTrait.NativeFieldInfoPtr_excluding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptRemoveTrait>.NativeClassPtr, nameof (excluding));
    CardScriptRemoveTrait.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptRemoveTrait>.NativeClassPtr, 100663802);
    CardScriptRemoveTrait.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptRemoveTrait>.NativeClassPtr, 100663803);
    CardScriptRemoveTrait.NativeMethodInfoPtr__Run_b__3_0_Private_Boolean_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptRemoveTrait>.NativeClassPtr, 100663804);
    CardScriptRemoveTrait.NativeMethodInfoPtr__Run_b__3_1_Private_Boolean_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptRemoveTrait>.NativeClassPtr, 100663805);
  }

  public CardScriptRemoveTrait(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool removeAll
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRemoveTrait.NativeFieldInfoPtr_removeAll));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRemoveTrait.NativeFieldInfoPtr_removeAll)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<TraitData> toRemove
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRemoveTrait.NativeFieldInfoPtr_toRemove));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<TraitData>) null : new Il2CppReferenceArray<TraitData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRemoveTrait.NativeFieldInfoPtr_toRemove), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<TraitData> excluding
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRemoveTrait.NativeFieldInfoPtr_excluding));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<TraitData>) null : new Il2CppReferenceArray<TraitData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRemoveTrait.NativeFieldInfoPtr_excluding), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
