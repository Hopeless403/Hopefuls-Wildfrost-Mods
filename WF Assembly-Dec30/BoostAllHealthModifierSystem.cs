// Decompiled with JetBrains decompiler
// Type: BoostAllHealthModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class BoostAllHealthModifierSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_healthAdd;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CardDataCreated_Private_Static_Void_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64995, XrefRangeEnd = 65003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostAllHealthModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65003, XrefRangeEnd = 65011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostAllHealthModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65011, XrefRangeEnd = 65015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CardDataCreated(CardData cardData)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostAllHealthModifierSystem.NativeMethodInfoPtr_CardDataCreated_Private_Static_Void_CardData_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BoostAllHealthModifierSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoostAllHealthModifierSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostAllHealthModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BoostAllHealthModifierSystem()
  {
    Il2CppClassPointerStore<BoostAllHealthModifierSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BoostAllHealthModifierSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoostAllHealthModifierSystem>.NativeClassPtr);
    BoostAllHealthModifierSystem.NativeFieldInfoPtr_healthAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoostAllHealthModifierSystem>.NativeClassPtr, nameof (healthAdd));
    BoostAllHealthModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostAllHealthModifierSystem>.NativeClassPtr, 100668616);
    BoostAllHealthModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostAllHealthModifierSystem>.NativeClassPtr, 100668617);
    BoostAllHealthModifierSystem.NativeMethodInfoPtr_CardDataCreated_Private_Static_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostAllHealthModifierSystem>.NativeClassPtr, 100668618);
    BoostAllHealthModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostAllHealthModifierSystem>.NativeClassPtr, 100668619);
  }

  public BoostAllHealthModifierSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe int healthAdd
  {
    get
    {
      int healthAdd;
      IL2CPP.il2cpp_field_static_get_value(BoostAllHealthModifierSystem.NativeFieldInfoPtr_healthAdd, (void*) &healthAdd);
      return healthAdd;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BoostAllHealthModifierSystem.NativeFieldInfoPtr_healthAdd, (void*) &value);
    }
  }
}
