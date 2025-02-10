// Decompiled with JetBrains decompiler
// Type: CardScriptMultiplyHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class CardScriptMultiplyHealth : CardScript
{
  private static readonly IntPtr NativeFieldInfoPtr_multiply;
  private static readonly IntPtr NativeFieldInfoPtr_roundUp;
  private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20474, XrefRangeEnd = 20480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Run(CardData target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardScriptMultiplyHealth.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardScriptMultiplyHealth()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardScriptMultiplyHealth>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardScriptMultiplyHealth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardScriptMultiplyHealth()
  {
    Il2CppClassPointerStore<CardScriptMultiplyHealth>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardScriptMultiplyHealth));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardScriptMultiplyHealth>.NativeClassPtr);
    CardScriptMultiplyHealth.NativeFieldInfoPtr_multiply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptMultiplyHealth>.NativeClassPtr, nameof (multiply));
    CardScriptMultiplyHealth.NativeFieldInfoPtr_roundUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptMultiplyHealth>.NativeClassPtr, nameof (roundUp));
    CardScriptMultiplyHealth.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptMultiplyHealth>.NativeClassPtr, 100663791);
    CardScriptMultiplyHealth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptMultiplyHealth>.NativeClassPtr, 100663792);
  }

  public CardScriptMultiplyHealth(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float multiply
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptMultiplyHealth.NativeFieldInfoPtr_multiply));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptMultiplyHealth.NativeFieldInfoPtr_multiply)) = value;
    }
  }

  public unsafe bool roundUp
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptMultiplyHealth.NativeFieldInfoPtr_roundUp));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptMultiplyHealth.NativeFieldInfoPtr_roundUp)) = value;
    }
  }
}
