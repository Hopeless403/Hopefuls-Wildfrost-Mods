// Decompiled with JetBrains decompiler
// Type: CardScriptReplaceAttackWithApply
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class CardScriptReplaceAttackWithApply : CardScript
{
  private static readonly IntPtr NativeFieldInfoPtr_effect;
  private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20597, XrefRangeEnd = 20608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Run(CardData target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardScriptReplaceAttackWithApply.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardScriptReplaceAttackWithApply()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardScriptReplaceAttackWithApply>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardScriptReplaceAttackWithApply.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardScriptReplaceAttackWithApply()
  {
    Il2CppClassPointerStore<CardScriptReplaceAttackWithApply>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardScriptReplaceAttackWithApply));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardScriptReplaceAttackWithApply>.NativeClassPtr);
    CardScriptReplaceAttackWithApply.NativeFieldInfoPtr_effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptReplaceAttackWithApply>.NativeClassPtr, nameof (effect));
    CardScriptReplaceAttackWithApply.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptReplaceAttackWithApply>.NativeClassPtr, 100663806);
    CardScriptReplaceAttackWithApply.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptReplaceAttackWithApply>.NativeClassPtr, 100663807);
  }

  public CardScriptReplaceAttackWithApply(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe StatusEffectData effect
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptReplaceAttackWithApply.NativeFieldInfoPtr_effect));
      return pointer == IntPtr.Zero ? (StatusEffectData) null : new StatusEffectData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardScriptReplaceAttackWithApply.NativeFieldInfoPtr_effect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
