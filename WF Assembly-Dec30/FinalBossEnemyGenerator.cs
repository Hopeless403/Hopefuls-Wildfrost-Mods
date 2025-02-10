// Decompiled with JetBrains decompiler
// Type: FinalBossEnemyGenerator
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
public class FinalBossEnemyGenerator : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_enemy;
  private static readonly IntPtr NativeFieldInfoPtr_fromCards;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FinalBossEnemyGenerator()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalBossEnemyGenerator>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossEnemyGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static FinalBossEnemyGenerator()
  {
    Il2CppClassPointerStore<FinalBossEnemyGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (FinalBossEnemyGenerator));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBossEnemyGenerator>.NativeClassPtr);
    FinalBossEnemyGenerator.NativeFieldInfoPtr_enemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossEnemyGenerator>.NativeClassPtr, nameof (enemy));
    FinalBossEnemyGenerator.NativeFieldInfoPtr_fromCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossEnemyGenerator>.NativeClassPtr, nameof (fromCards));
    FinalBossEnemyGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossEnemyGenerator>.NativeClassPtr, 100673372);
  }

  public FinalBossEnemyGenerator(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe CardData enemy
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossEnemyGenerator.NativeFieldInfoPtr_enemy));
      return pointer == IntPtr.Zero ? (CardData) null : new CardData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossEnemyGenerator.NativeFieldInfoPtr_enemy), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardData> fromCards
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossEnemyGenerator.NativeFieldInfoPtr_fromCards));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<CardData>) null : new Il2CppReferenceArray<CardData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossEnemyGenerator.NativeFieldInfoPtr_fromCards), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
