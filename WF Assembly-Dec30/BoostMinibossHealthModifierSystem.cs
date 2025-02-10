// Decompiled with JetBrains decompiler
// Type: BoostMinibossHealthModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class BoostMinibossHealthModifierSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_healthFactor;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CardDataCreated_Private_Void_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr_BoostHealth_Private_Void_CardData_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_BoostStatusEffect_Private_Void_CardData_String_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65168, XrefRangeEnd = 65176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostMinibossHealthModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65176, XrefRangeEnd = 65184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostMinibossHealthModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65184, XrefRangeEnd = 65197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CardDataCreated(CardData cardData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostMinibossHealthModifierSystem.NativeMethodInfoPtr_CardDataCreated_Private_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65197, XrefRangeEnd = 65198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BoostHealth(CardData cardData, float factor)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &factor;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostMinibossHealthModifierSystem.NativeMethodInfoPtr_BoostHealth_Private_Void_CardData_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65198, XrefRangeEnd = 65201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BoostStatusEffect(CardData cardData, string statusType, float factor)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(statusType);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &factor;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostMinibossHealthModifierSystem.NativeMethodInfoPtr_BoostStatusEffect_Private_Void_CardData_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BoostMinibossHealthModifierSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoostMinibossHealthModifierSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BoostMinibossHealthModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BoostMinibossHealthModifierSystem()
  {
    Il2CppClassPointerStore<BoostMinibossHealthModifierSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BoostMinibossHealthModifierSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoostMinibossHealthModifierSystem>.NativeClassPtr);
    BoostMinibossHealthModifierSystem.NativeFieldInfoPtr_healthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoostMinibossHealthModifierSystem>.NativeClassPtr, nameof (healthFactor));
    BoostMinibossHealthModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostMinibossHealthModifierSystem>.NativeClassPtr, 100668640);
    BoostMinibossHealthModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostMinibossHealthModifierSystem>.NativeClassPtr, 100668641);
    BoostMinibossHealthModifierSystem.NativeMethodInfoPtr_CardDataCreated_Private_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostMinibossHealthModifierSystem>.NativeClassPtr, 100668642);
    BoostMinibossHealthModifierSystem.NativeMethodInfoPtr_BoostHealth_Private_Void_CardData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostMinibossHealthModifierSystem>.NativeClassPtr, 100668643);
    BoostMinibossHealthModifierSystem.NativeMethodInfoPtr_BoostStatusEffect_Private_Void_CardData_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostMinibossHealthModifierSystem>.NativeClassPtr, 100668644);
    BoostMinibossHealthModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoostMinibossHealthModifierSystem>.NativeClassPtr, 100668645);
  }

  public BoostMinibossHealthModifierSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe float healthFactor
  {
    get
    {
      float healthFactor;
      IL2CPP.il2cpp_field_static_get_value(BoostMinibossHealthModifierSystem.NativeFieldInfoPtr_healthFactor, (void*) &healthFactor);
      return healthFactor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BoostMinibossHealthModifierSystem.NativeFieldInfoPtr_healthFactor, (void*) &value);
    }
  }
}
