// Decompiled with JetBrains decompiler
// Type: CardScriptAddRandomCounter
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
public class CardScriptAddRandomCounter : CardScript
{
  private static readonly IntPtr NativeFieldInfoPtr_counterRange;
  private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20357, XrefRangeEnd = 20358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Run(CardData target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardScriptAddRandomCounter.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardScriptAddRandomCounter()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardScriptAddRandomCounter>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardScriptAddRandomCounter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardScriptAddRandomCounter()
  {
    Il2CppClassPointerStore<CardScriptAddRandomCounter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardScriptAddRandomCounter));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardScriptAddRandomCounter>.NativeClassPtr);
    CardScriptAddRandomCounter.NativeFieldInfoPtr_counterRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptAddRandomCounter>.NativeClassPtr, nameof (counterRange));
    CardScriptAddRandomCounter.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptAddRandomCounter>.NativeClassPtr, 100663773);
    CardScriptAddRandomCounter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptAddRandomCounter>.NativeClassPtr, 100663774);
  }

  public CardScriptAddRandomCounter(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Vector2Int counterRange
  {
    get
    {
      return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptAddRandomCounter.NativeFieldInfoPtr_counterRange));
    }
    [param: In] set
    {
      *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptAddRandomCounter.NativeFieldInfoPtr_counterRange)) = value;
    }
  }
}
