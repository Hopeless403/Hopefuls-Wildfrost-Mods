// Decompiled with JetBrains decompiler
// Type: CardScriptRoundHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class CardScriptRoundHealth : CardScript
{
  private static readonly IntPtr NativeFieldInfoPtr_ceil;
  private static readonly IntPtr NativeFieldInfoPtr_floor;
  private static readonly IntPtr NativeFieldInfoPtr_round;
  private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20608, XrefRangeEnd = 20619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Run(CardData target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardScriptRoundHealth.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20619, XrefRangeEnd = 20620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardScriptRoundHealth()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardScriptRoundHealth>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardScriptRoundHealth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardScriptRoundHealth()
  {
    Il2CppClassPointerStore<CardScriptRoundHealth>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardScriptRoundHealth));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardScriptRoundHealth>.NativeClassPtr);
    CardScriptRoundHealth.NativeFieldInfoPtr_ceil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptRoundHealth>.NativeClassPtr, nameof (ceil));
    CardScriptRoundHealth.NativeFieldInfoPtr_floor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptRoundHealth>.NativeClassPtr, nameof (floor));
    CardScriptRoundHealth.NativeFieldInfoPtr_round = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptRoundHealth>.NativeClassPtr, nameof (round));
    CardScriptRoundHealth.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptRoundHealth>.NativeClassPtr, 100663808);
    CardScriptRoundHealth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptRoundHealth>.NativeClassPtr, 100663809);
  }

  public CardScriptRoundHealth(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool ceil
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRoundHealth.NativeFieldInfoPtr_ceil));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRoundHealth.NativeFieldInfoPtr_ceil)) = value;
    }
  }

  public unsafe bool floor
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRoundHealth.NativeFieldInfoPtr_floor));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRoundHealth.NativeFieldInfoPtr_floor)) = value;
    }
  }

  public unsafe int round
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRoundHealth.NativeFieldInfoPtr_round));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptRoundHealth.NativeFieldInfoPtr_round)) = value;
    }
  }
}
