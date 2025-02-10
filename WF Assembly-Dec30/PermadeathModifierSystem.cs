// Decompiled with JetBrains decompiler
// Type: PermadeathModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class PermadeathModifierSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_LegalTypes;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_EntityKilled_Private_Static_Void_Entity_DeathType_0;
  private static readonly IntPtr NativeMethodInfoPtr_IsPlayerCard_Private_Static_Boolean_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_IsLegalCardType_Private_Static_Boolean_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_RemoveFromDeck_Private_Static_Void_Entity_Inventory_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65607, XrefRangeEnd = 65615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PermadeathModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65615, XrefRangeEnd = 65623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PermadeathModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65623, XrefRangeEnd = 65656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EntityKilled(Entity entity, DeathType deathType)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &deathType;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PermadeathModifierSystem.NativeMethodInfoPtr_EntityKilled_Private_Static_Void_Entity_DeathType_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65656, XrefRangeEnd = 65662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsPlayerCard(Entity entity)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(PermadeathModifierSystem.NativeMethodInfoPtr_IsPlayerCard_Private_Static_Boolean_Entity_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65662, XrefRangeEnd = 65671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsLegalCardType(Entity entity)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(PermadeathModifierSystem.NativeMethodInfoPtr_IsLegalCardType_Private_Static_Boolean_Entity_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65671, XrefRangeEnd = 65696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RemoveFromDeck(Entity entity, Inventory inventory)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inventory);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PermadeathModifierSystem.NativeMethodInfoPtr_RemoveFromDeck_Private_Static_Void_Entity_Inventory_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PermadeathModifierSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PermadeathModifierSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PermadeathModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static PermadeathModifierSystem()
  {
    Il2CppClassPointerStore<PermadeathModifierSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (PermadeathModifierSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PermadeathModifierSystem>.NativeClassPtr);
    PermadeathModifierSystem.NativeFieldInfoPtr_LegalTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PermadeathModifierSystem>.NativeClassPtr, nameof (LegalTypes));
    PermadeathModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermadeathModifierSystem>.NativeClassPtr, 100668699);
    PermadeathModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermadeathModifierSystem>.NativeClassPtr, 100668700);
    PermadeathModifierSystem.NativeMethodInfoPtr_EntityKilled_Private_Static_Void_Entity_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermadeathModifierSystem>.NativeClassPtr, 100668701);
    PermadeathModifierSystem.NativeMethodInfoPtr_IsPlayerCard_Private_Static_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermadeathModifierSystem>.NativeClassPtr, 100668702);
    PermadeathModifierSystem.NativeMethodInfoPtr_IsLegalCardType_Private_Static_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermadeathModifierSystem>.NativeClassPtr, 100668703);
    PermadeathModifierSystem.NativeMethodInfoPtr_RemoveFromDeck_Private_Static_Void_Entity_Inventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermadeathModifierSystem>.NativeClassPtr, 100668704);
    PermadeathModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermadeathModifierSystem>.NativeClassPtr, 100668705);
  }

  public PermadeathModifierSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Il2CppStringArray LegalTypes
  {
    get
    {
      IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(PermadeathModifierSystem.NativeFieldInfoPtr_LegalTypes, (void*) &num);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PermadeathModifierSystem.NativeFieldInfoPtr_LegalTypes, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
