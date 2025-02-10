// Decompiled with JetBrains decompiler
// Type: UnlockData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class UnlockData : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_active;
  private static readonly IntPtr NativeFieldInfoPtr_activeInDemo;
  private static readonly IntPtr NativeFieldInfoPtr_activeInPressDemo;
  private static readonly IntPtr NativeFieldInfoPtr_type;
  private static readonly IntPtr NativeFieldInfoPtr_relatedBuilding;
  private static readonly IntPtr NativeFieldInfoPtr_lowPriority;
  private static readonly IntPtr NativeFieldInfoPtr_requires;
  private static readonly IntPtr NativeFieldInfoPtr_unlockTitle;
  private static readonly IntPtr NativeFieldInfoPtr_unlockDesc;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe bool IsActive
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 23871, RefRangeEnd = 23873, XrefRangeStart = 23871, XrefRangeEnd = 23873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnlockData.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110933, XrefRangeEnd = 110939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnlockData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnlockData>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UnlockData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static UnlockData()
  {
    Il2CppClassPointerStore<UnlockData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (UnlockData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnlockData>.NativeClassPtr);
    UnlockData.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockData>.NativeClassPtr, nameof (active));
    UnlockData.NativeFieldInfoPtr_activeInDemo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockData>.NativeClassPtr, nameof (activeInDemo));
    UnlockData.NativeFieldInfoPtr_activeInPressDemo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockData>.NativeClassPtr, nameof (activeInPressDemo));
    UnlockData.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockData>.NativeClassPtr, nameof (type));
    UnlockData.NativeFieldInfoPtr_relatedBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockData>.NativeClassPtr, nameof (relatedBuilding));
    UnlockData.NativeFieldInfoPtr_lowPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockData>.NativeClassPtr, nameof (lowPriority));
    UnlockData.NativeFieldInfoPtr_requires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockData>.NativeClassPtr, nameof (requires));
    UnlockData.NativeFieldInfoPtr_unlockTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockData>.NativeClassPtr, nameof (unlockTitle));
    UnlockData.NativeFieldInfoPtr_unlockDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockData>.NativeClassPtr, nameof (unlockDesc));
    UnlockData.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockData>.NativeClassPtr, 100673672);
    UnlockData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockData>.NativeClassPtr, 100673673);
  }

  public UnlockData(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool active
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnlockData.NativeFieldInfoPtr_active));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnlockData.NativeFieldInfoPtr_active)) = value;
    }
  }

  public unsafe bool activeInDemo
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnlockData.NativeFieldInfoPtr_activeInDemo));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnlockData.NativeFieldInfoPtr_activeInDemo)) = value;
    }
  }

  public unsafe bool activeInPressDemo
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnlockData.NativeFieldInfoPtr_activeInPressDemo));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnlockData.NativeFieldInfoPtr_activeInPressDemo)) = value;
    }
  }

  public unsafe UnlockData.Type type
  {
    get
    {
      return *(UnlockData.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnlockData.NativeFieldInfoPtr_type));
    }
    [param: In] set
    {
      *(UnlockData.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnlockData.NativeFieldInfoPtr_type)) = value;
    }
  }

  public unsafe BuildingType relatedBuilding
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnlockData.NativeFieldInfoPtr_relatedBuilding));
      return pointer == IntPtr.Zero ? (BuildingType) null : new BuildingType(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnlockData.NativeFieldInfoPtr_relatedBuilding), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float lowPriority
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnlockData.NativeFieldInfoPtr_lowPriority));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnlockData.NativeFieldInfoPtr_lowPriority)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<UnlockData> requires
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnlockData.NativeFieldInfoPtr_requires));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<UnlockData>) null : new Il2CppReferenceArray<UnlockData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnlockData.NativeFieldInfoPtr_requires), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString unlockTitle
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnlockData.NativeFieldInfoPtr_unlockTitle));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnlockData.NativeFieldInfoPtr_unlockTitle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString unlockDesc
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnlockData.NativeFieldInfoPtr_unlockDesc));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnlockData.NativeFieldInfoPtr_unlockDesc), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum Type
  {
    None,
    BuildingStarted,
    BuildingFinished,
    Item,
    Pet,
    Tribe,
    Companion,
    Event,
    JournalPage,
    Charm,
  }
}
