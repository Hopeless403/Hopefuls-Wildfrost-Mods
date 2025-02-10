// Decompiled with JetBrains decompiler
// Type: CardScriptAddTrait
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
public class CardScriptAddTrait : CardScript
{
  private static readonly IntPtr NativeFieldInfoPtr_trait;
  private static readonly IntPtr NativeFieldInfoPtr_countRange;
  private static readonly IntPtr NativeFieldInfoPtr_override;
  private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20360, XrefRangeEnd = 20410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Run(CardData target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardScriptAddTrait.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20410, XrefRangeEnd = 20411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardScriptAddTrait()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardScriptAddTrait>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardScriptAddTrait.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardScriptAddTrait()
  {
    Il2CppClassPointerStore<CardScriptAddTrait>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardScriptAddTrait));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardScriptAddTrait>.NativeClassPtr);
    CardScriptAddTrait.NativeFieldInfoPtr_trait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptAddTrait>.NativeClassPtr, nameof (trait));
    CardScriptAddTrait.NativeFieldInfoPtr_countRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptAddTrait>.NativeClassPtr, nameof (countRange));
    CardScriptAddTrait.NativeFieldInfoPtr_override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptAddTrait>.NativeClassPtr, nameof (@override));
    CardScriptAddTrait.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptAddTrait>.NativeClassPtr, 100663779);
    CardScriptAddTrait.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptAddTrait>.NativeClassPtr, 100663780);
  }

  public CardScriptAddTrait(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe TraitData trait
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptAddTrait.NativeFieldInfoPtr_trait));
      return pointer == IntPtr.Zero ? (TraitData) null : new TraitData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardScriptAddTrait.NativeFieldInfoPtr_trait), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2Int countRange
  {
    get
    {
      return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptAddTrait.NativeFieldInfoPtr_countRange));
    }
    [param: In] set
    {
      *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptAddTrait.NativeFieldInfoPtr_countRange)) = value;
    }
  }

  public unsafe bool @override
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptAddTrait.NativeFieldInfoPtr_override));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptAddTrait.NativeFieldInfoPtr_override)) = value;
    }
  }
}
