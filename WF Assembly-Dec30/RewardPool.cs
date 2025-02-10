// Decompiled with JetBrains decompiler
// Type: RewardPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class RewardPool : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_type;
  private static readonly IntPtr NativeFieldInfoPtr_copies;
  private static readonly IntPtr NativeFieldInfoPtr_list;
  private static readonly IntPtr NativeFieldInfoPtr_isGeneralPool;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109853, XrefRangeEnd = 109854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RewardPool()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewardPool>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RewardPool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static RewardPool()
  {
    Il2CppClassPointerStore<RewardPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (RewardPool));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewardPool>.NativeClassPtr);
    RewardPool.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewardPool>.NativeClassPtr, nameof (type));
    RewardPool.NativeFieldInfoPtr_copies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewardPool>.NativeClassPtr, nameof (copies));
    RewardPool.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewardPool>.NativeClassPtr, nameof (list));
    RewardPool.NativeFieldInfoPtr_isGeneralPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewardPool>.NativeClassPtr, nameof (isGeneralPool));
    RewardPool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewardPool>.NativeClassPtr, 100673439);
  }

  public RewardPool(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string type
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewardPool.NativeFieldInfoPtr_type)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewardPool.NativeFieldInfoPtr_type), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int copies
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewardPool.NativeFieldInfoPtr_copies));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewardPool.NativeFieldInfoPtr_copies)) = value;
    }
  }

  public unsafe List<DataFile> list
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewardPool.NativeFieldInfoPtr_list));
      return pointer == IntPtr.Zero ? (List<DataFile>) null : new List<DataFile>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewardPool.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool isGeneralPool
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewardPool.NativeFieldInfoPtr_isGeneralPool));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewardPool.NativeFieldInfoPtr_isGeneralPool)) = value;
    }
  }

  public enum Type
  {
    Items,
    Units,
    Charms,
  }
}
