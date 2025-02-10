// Decompiled with JetBrains decompiler
// Type: CardScriptAddRandomDamage
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
public class CardScriptAddRandomDamage : CardScript
{
  private static readonly IntPtr NativeFieldInfoPtr_damageRange;
  private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20358, XrefRangeEnd = 20359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Run(CardData target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardScriptAddRandomDamage.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardScriptAddRandomDamage()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardScriptAddRandomDamage>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardScriptAddRandomDamage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardScriptAddRandomDamage()
  {
    Il2CppClassPointerStore<CardScriptAddRandomDamage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardScriptAddRandomDamage));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardScriptAddRandomDamage>.NativeClassPtr);
    CardScriptAddRandomDamage.NativeFieldInfoPtr_damageRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptAddRandomDamage>.NativeClassPtr, nameof (damageRange));
    CardScriptAddRandomDamage.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptAddRandomDamage>.NativeClassPtr, 100663775);
    CardScriptAddRandomDamage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptAddRandomDamage>.NativeClassPtr, 100663776);
  }

  public CardScriptAddRandomDamage(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Vector2Int damageRange
  {
    get
    {
      return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptAddRandomDamage.NativeFieldInfoPtr_damageRange));
    }
    [param: In] set
    {
      *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptAddRandomDamage.NativeFieldInfoPtr_damageRange)) = value;
    }
  }
}
