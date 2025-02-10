// Decompiled with JetBrains decompiler
// Type: DropGoldSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class DropGoldSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_goldFactor;
  private static readonly IntPtr NativeFieldInfoPtr_goldPerUpgrade;
  private static readonly IntPtr NativeFieldInfoPtr_dropGoldOnFlee;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0;
  private static readonly IntPtr NativeMethodInfoPtr_EntityFlee_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_TryDropGold_Private_Void_Entity_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetGoldToDrop_Private_Int32_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59067, XrefRangeEnd = 59082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DropGoldSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59082, XrefRangeEnd = 59097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DropGoldSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59097, XrefRangeEnd = 59100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityKilled(Entity entity, DeathType deathType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &deathType;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DropGoldSystem.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59100, XrefRangeEnd = 59103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityFlee(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DropGoldSystem.NativeMethodInfoPtr_EntityFlee_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 59119, RefRangeEnd = 59121, XrefRangeStart = 59103, XrefRangeEnd = 59119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TryDropGold(Entity entity, string source)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(source);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DropGoldSystem.NativeMethodInfoPtr_TryDropGold_Private_Void_Entity_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59121, XrefRangeEnd = 59127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetGoldToDrop(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropGoldSystem.NativeMethodInfoPtr_GetGoldToDrop_Private_Int32_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59127, XrefRangeEnd = 59128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DropGoldSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropGoldSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DropGoldSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static DropGoldSystem()
  {
    Il2CppClassPointerStore<DropGoldSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (DropGoldSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropGoldSystem>.NativeClassPtr);
    DropGoldSystem.NativeFieldInfoPtr_goldFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropGoldSystem>.NativeClassPtr, nameof (goldFactor));
    DropGoldSystem.NativeFieldInfoPtr_goldPerUpgrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropGoldSystem>.NativeClassPtr, nameof (goldPerUpgrade));
    DropGoldSystem.NativeFieldInfoPtr_dropGoldOnFlee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropGoldSystem>.NativeClassPtr, nameof (dropGoldOnFlee));
    DropGoldSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropGoldSystem>.NativeClassPtr, 100668133);
    DropGoldSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropGoldSystem>.NativeClassPtr, 100668134);
    DropGoldSystem.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropGoldSystem>.NativeClassPtr, 100668135);
    DropGoldSystem.NativeMethodInfoPtr_EntityFlee_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropGoldSystem>.NativeClassPtr, 100668136);
    DropGoldSystem.NativeMethodInfoPtr_TryDropGold_Private_Void_Entity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropGoldSystem>.NativeClassPtr, 100668137);
    DropGoldSystem.NativeMethodInfoPtr_GetGoldToDrop_Private_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropGoldSystem>.NativeClassPtr, 100668138);
    DropGoldSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropGoldSystem>.NativeClassPtr, 100668139);
  }

  public DropGoldSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float goldFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropGoldSystem.NativeFieldInfoPtr_goldFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropGoldSystem.NativeFieldInfoPtr_goldFactor)) = value;
    }
  }

  public unsafe int goldPerUpgrade
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropGoldSystem.NativeFieldInfoPtr_goldPerUpgrade));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropGoldSystem.NativeFieldInfoPtr_goldPerUpgrade)) = value;
    }
  }

  public unsafe bool dropGoldOnFlee
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropGoldSystem.NativeFieldInfoPtr_dropGoldOnFlee));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropGoldSystem.NativeFieldInfoPtr_dropGoldOnFlee)) = value;
    }
  }
}
