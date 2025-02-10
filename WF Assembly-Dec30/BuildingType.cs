// Decompiled with JetBrains decompiler
// Type: BuildingType
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
public class BuildingType : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_titleKey;
  private static readonly IntPtr NativeFieldInfoPtr_helpKey;
  private static readonly IntPtr NativeFieldInfoPtr_helpEmoteType;
  private static readonly IntPtr NativeFieldInfoPtr_started;
  private static readonly IntPtr NativeFieldInfoPtr_finished;
  private static readonly IntPtr NativeFieldInfoPtr_unlocks;
  private static readonly IntPtr NativeFieldInfoPtr_unlockedCheckedKey;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110932, XrefRangeEnd = 110933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BuildingType()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildingType>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BuildingType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BuildingType()
  {
    Il2CppClassPointerStore<BuildingType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BuildingType));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildingType>.NativeClassPtr);
    BuildingType.NativeFieldInfoPtr_titleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingType>.NativeClassPtr, nameof (titleKey));
    BuildingType.NativeFieldInfoPtr_helpKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingType>.NativeClassPtr, nameof (helpKey));
    BuildingType.NativeFieldInfoPtr_helpEmoteType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingType>.NativeClassPtr, nameof (helpEmoteType));
    BuildingType.NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingType>.NativeClassPtr, nameof (started));
    BuildingType.NativeFieldInfoPtr_finished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingType>.NativeClassPtr, nameof (finished));
    BuildingType.NativeFieldInfoPtr_unlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingType>.NativeClassPtr, nameof (unlocks));
    BuildingType.NativeFieldInfoPtr_unlockedCheckedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingType>.NativeClassPtr, nameof (unlockedCheckedKey));
    BuildingType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingType>.NativeClassPtr, 100673670);
  }

  public BuildingType(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LocalizedString titleKey
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingType.NativeFieldInfoPtr_titleKey));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildingType.NativeFieldInfoPtr_titleKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString helpKey
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingType.NativeFieldInfoPtr_helpKey));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildingType.NativeFieldInfoPtr_helpKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Prompt.Emote.Type helpEmoteType
  {
    get
    {
      return *(Prompt.Emote.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingType.NativeFieldInfoPtr_helpEmoteType));
    }
    [param: In] set
    {
      *(Prompt.Emote.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingType.NativeFieldInfoPtr_helpEmoteType)) = value;
    }
  }

  public unsafe UnlockData started
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingType.NativeFieldInfoPtr_started));
      return pointer == IntPtr.Zero ? (UnlockData) null : new UnlockData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildingType.NativeFieldInfoPtr_started), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnlockData finished
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingType.NativeFieldInfoPtr_finished));
      return pointer == IntPtr.Zero ? (UnlockData) null : new UnlockData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildingType.NativeFieldInfoPtr_finished), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<UnlockData> unlocks
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingType.NativeFieldInfoPtr_unlocks));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<UnlockData>) null : new Il2CppReferenceArray<UnlockData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildingType.NativeFieldInfoPtr_unlocks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string unlockedCheckedKey
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingType.NativeFieldInfoPtr_unlockedCheckedKey)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildingType.NativeFieldInfoPtr_unlockedCheckedKey), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
