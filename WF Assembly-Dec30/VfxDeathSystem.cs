// Decompiled with JetBrains decompiler
// Type: VfxDeathSystem
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
public class VfxDeathSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_sacrificeFX;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateEffect_Private_Void_GameObject_Vector3_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81143, XrefRangeEnd = 81151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VfxDeathSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81151, XrefRangeEnd = 81159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VfxDeathSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81159, XrefRangeEnd = 81181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityKilled(Entity entity, DeathType deathType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &deathType;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VfxDeathSystem.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81181, XrefRangeEnd = 81195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateEffect(GameObject prefab, Vector3 position, Vector3 scale)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &position;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &scale;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VfxDeathSystem.NativeMethodInfoPtr_CreateEffect_Private_Void_GameObject_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VfxDeathSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VfxDeathSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VfxDeathSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static VfxDeathSystem()
  {
    Il2CppClassPointerStore<VfxDeathSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (VfxDeathSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VfxDeathSystem>.NativeClassPtr);
    VfxDeathSystem.NativeFieldInfoPtr_sacrificeFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VfxDeathSystem>.NativeClassPtr, nameof (sacrificeFX));
    VfxDeathSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VfxDeathSystem>.NativeClassPtr, 100669946);
    VfxDeathSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VfxDeathSystem>.NativeClassPtr, 100669947);
    VfxDeathSystem.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VfxDeathSystem>.NativeClassPtr, 100669948);
    VfxDeathSystem.NativeMethodInfoPtr_CreateEffect_Private_Void_GameObject_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VfxDeathSystem>.NativeClassPtr, 100669949);
    VfxDeathSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VfxDeathSystem>.NativeClassPtr, 100669950);
  }

  public VfxDeathSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe GameObject sacrificeFX
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VfxDeathSystem.NativeFieldInfoPtr_sacrificeFX));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VfxDeathSystem.NativeFieldInfoPtr_sacrificeFX), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
