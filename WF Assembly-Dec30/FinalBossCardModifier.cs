// Decompiled with JetBrains decompiler
// Type: FinalBossCardModifier
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

#nullable disable
public class FinalBossCardModifier : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_card;
  private static readonly IntPtr NativeFieldInfoPtr_runAll;
  private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Void_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 109090, RefRangeEnd = 109091, XrefRangeStart = 109078, XrefRangeEnd = 109090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Run(CardData card)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossCardModifier.NativeMethodInfoPtr_Run_Public_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FinalBossCardModifier()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalBossCardModifier>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossCardModifier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static FinalBossCardModifier()
  {
    Il2CppClassPointerStore<FinalBossCardModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (FinalBossCardModifier));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBossCardModifier>.NativeClassPtr);
    FinalBossCardModifier.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossCardModifier>.NativeClassPtr, nameof (card));
    FinalBossCardModifier.NativeFieldInfoPtr_runAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossCardModifier>.NativeClassPtr, nameof (runAll));
    FinalBossCardModifier.NativeMethodInfoPtr_Run_Public_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossCardModifier>.NativeClassPtr, 100673368);
    FinalBossCardModifier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossCardModifier>.NativeClassPtr, 100673369);
  }

  public FinalBossCardModifier(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe CardData card
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossCardModifier.NativeFieldInfoPtr_card));
      return pointer == IntPtr.Zero ? (CardData) null : new CardData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossCardModifier.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardScript> runAll
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossCardModifier.NativeFieldInfoPtr_runAll));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<CardScript>) null : new Il2CppReferenceArray<CardScript>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossCardModifier.NativeFieldInfoPtr_runAll), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
