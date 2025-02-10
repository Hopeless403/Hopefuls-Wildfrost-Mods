// Decompiled with JetBrains decompiler
// Type: DoubleGoblingGoldModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class DoubleGoblingGoldModifierSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_multiplier;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CardDataCreated_Private_Static_Void_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65277, XrefRangeEnd = 65285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DoubleGoblingGoldModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65285, XrefRangeEnd = 65293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DoubleGoblingGoldModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65293, XrefRangeEnd = 65298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CardDataCreated(CardData cardData)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DoubleGoblingGoldModifierSystem.NativeMethodInfoPtr_CardDataCreated_Private_Static_Void_CardData_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DoubleGoblingGoldModifierSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleGoblingGoldModifierSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DoubleGoblingGoldModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static DoubleGoblingGoldModifierSystem()
  {
    Il2CppClassPointerStore<DoubleGoblingGoldModifierSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (DoubleGoblingGoldModifierSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleGoblingGoldModifierSystem>.NativeClassPtr);
    DoubleGoblingGoldModifierSystem.NativeFieldInfoPtr_multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleGoblingGoldModifierSystem>.NativeClassPtr, nameof (multiplier));
    DoubleGoblingGoldModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleGoblingGoldModifierSystem>.NativeClassPtr, 100668657);
    DoubleGoblingGoldModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleGoblingGoldModifierSystem>.NativeClassPtr, 100668658);
    DoubleGoblingGoldModifierSystem.NativeMethodInfoPtr_CardDataCreated_Private_Static_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleGoblingGoldModifierSystem>.NativeClassPtr, 100668659);
    DoubleGoblingGoldModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleGoblingGoldModifierSystem>.NativeClassPtr, 100668660);
  }

  public DoubleGoblingGoldModifierSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe float multiplier
  {
    get
    {
      float multiplier;
      IL2CPP.il2cpp_field_static_get_value(DoubleGoblingGoldModifierSystem.NativeFieldInfoPtr_multiplier, (void*) &multiplier);
      return multiplier;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DoubleGoblingGoldModifierSystem.NativeFieldInfoPtr_multiplier, (void*) &value);
    }
  }
}
