// Decompiled with JetBrains decompiler
// Type: DiscardHealSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class DiscardHealSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_healAmount;
  private static readonly IntPtr NativeFieldInfoPtr_healTextKey;
  private static readonly IntPtr NativeFieldInfoPtr_healPopupOffset;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Discard_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59018, XrefRangeEnd = 59026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DiscardHealSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59026, XrefRangeEnd = 59034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DiscardHealSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59034, XrefRangeEnd = 59064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Discard(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DiscardHealSystem.NativeMethodInfoPtr_Discard_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59064, XrefRangeEnd = 59067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DiscardHealSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiscardHealSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DiscardHealSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static DiscardHealSystem()
  {
    Il2CppClassPointerStore<DiscardHealSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (DiscardHealSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscardHealSystem>.NativeClassPtr);
    DiscardHealSystem.NativeFieldInfoPtr_healAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscardHealSystem>.NativeClassPtr, nameof (healAmount));
    DiscardHealSystem.NativeFieldInfoPtr_healTextKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscardHealSystem>.NativeClassPtr, nameof (healTextKey));
    DiscardHealSystem.NativeFieldInfoPtr_healPopupOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscardHealSystem>.NativeClassPtr, nameof (healPopupOffset));
    DiscardHealSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscardHealSystem>.NativeClassPtr, 100668129);
    DiscardHealSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscardHealSystem>.NativeClassPtr, 100668130);
    DiscardHealSystem.NativeMethodInfoPtr_Discard_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscardHealSystem>.NativeClassPtr, 100668131);
    DiscardHealSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscardHealSystem>.NativeClassPtr, 100668132);
  }

  public DiscardHealSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int healAmount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DiscardHealSystem.NativeFieldInfoPtr_healAmount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DiscardHealSystem.NativeFieldInfoPtr_healAmount)) = value;
    }
  }

  public unsafe LocalizedString healTextKey
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DiscardHealSystem.NativeFieldInfoPtr_healTextKey));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DiscardHealSystem.NativeFieldInfoPtr_healTextKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 healPopupOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DiscardHealSystem.NativeFieldInfoPtr_healPopupOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DiscardHealSystem.NativeFieldInfoPtr_healPopupOffset)) = value;
    }
  }
}
