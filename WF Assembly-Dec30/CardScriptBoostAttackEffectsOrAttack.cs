// Decompiled with JetBrains decompiler
// Type: CardScriptBoostAttackEffectsOrAttack
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
public class CardScriptBoostAttackEffectsOrAttack : CardScript
{
  private static readonly IntPtr NativeFieldInfoPtr_range;
  private static readonly IntPtr NativeFieldInfoPtr_reducePerCharm;
  private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20411, XrefRangeEnd = 20431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Run(CardData target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardScriptBoostAttackEffectsOrAttack.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20431, XrefRangeEnd = 20432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardScriptBoostAttackEffectsOrAttack()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardScriptBoostAttackEffectsOrAttack>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardScriptBoostAttackEffectsOrAttack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardScriptBoostAttackEffectsOrAttack()
  {
    Il2CppClassPointerStore<CardScriptBoostAttackEffectsOrAttack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardScriptBoostAttackEffectsOrAttack));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardScriptBoostAttackEffectsOrAttack>.NativeClassPtr);
    CardScriptBoostAttackEffectsOrAttack.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptBoostAttackEffectsOrAttack>.NativeClassPtr, nameof (range));
    CardScriptBoostAttackEffectsOrAttack.NativeFieldInfoPtr_reducePerCharm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptBoostAttackEffectsOrAttack>.NativeClassPtr, nameof (reducePerCharm));
    CardScriptBoostAttackEffectsOrAttack.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptBoostAttackEffectsOrAttack>.NativeClassPtr, 100663783);
    CardScriptBoostAttackEffectsOrAttack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptBoostAttackEffectsOrAttack>.NativeClassPtr, 100663784);
  }

  public CardScriptBoostAttackEffectsOrAttack(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Vector2Int range
  {
    get
    {
      return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptBoostAttackEffectsOrAttack.NativeFieldInfoPtr_range));
    }
    [param: In] set
    {
      *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptBoostAttackEffectsOrAttack.NativeFieldInfoPtr_range)) = value;
    }
  }

  public unsafe float reducePerCharm
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptBoostAttackEffectsOrAttack.NativeFieldInfoPtr_reducePerCharm));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptBoostAttackEffectsOrAttack.NativeFieldInfoPtr_reducePerCharm)) = value;
    }
  }
}
