// Decompiled with JetBrains decompiler
// Type: HardModeModifierData
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

#nullable disable
public class HardModeModifierData : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_modifierData;
  private static readonly IntPtr NativeFieldInfoPtr_stormPoints;
  private static readonly IntPtr NativeFieldInfoPtr_unlockedByDefault;
  private static readonly IntPtr NativeFieldInfoPtr_unlockRequires;
  private static readonly IntPtr NativeFieldInfoPtr_unlockRequiresPoints;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HardModeModifierData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardModeModifierData>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HardModeModifierData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static HardModeModifierData()
  {
    Il2CppClassPointerStore<HardModeModifierData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (HardModeModifierData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HardModeModifierData>.NativeClassPtr);
    HardModeModifierData.NativeFieldInfoPtr_modifierData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardModeModifierData>.NativeClassPtr, nameof (modifierData));
    HardModeModifierData.NativeFieldInfoPtr_stormPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardModeModifierData>.NativeClassPtr, nameof (stormPoints));
    HardModeModifierData.NativeFieldInfoPtr_unlockedByDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardModeModifierData>.NativeClassPtr, nameof (unlockedByDefault));
    HardModeModifierData.NativeFieldInfoPtr_unlockRequires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardModeModifierData>.NativeClassPtr, nameof (unlockRequires));
    HardModeModifierData.NativeFieldInfoPtr_unlockRequiresPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardModeModifierData>.NativeClassPtr, nameof (unlockRequiresPoints));
    HardModeModifierData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardModeModifierData>.NativeClassPtr, 100673409);
  }

  public HardModeModifierData(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe GameModifierData modifierData
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HardModeModifierData.NativeFieldInfoPtr_modifierData));
      return pointer == IntPtr.Zero ? (GameModifierData) null : new GameModifierData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HardModeModifierData.NativeFieldInfoPtr_modifierData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int stormPoints
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HardModeModifierData.NativeFieldInfoPtr_stormPoints));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HardModeModifierData.NativeFieldInfoPtr_stormPoints)) = value;
    }
  }

  public unsafe bool unlockedByDefault
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HardModeModifierData.NativeFieldInfoPtr_unlockedByDefault));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HardModeModifierData.NativeFieldInfoPtr_unlockedByDefault)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<HardModeModifierData> unlockRequires
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HardModeModifierData.NativeFieldInfoPtr_unlockRequires));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<HardModeModifierData>) null : new Il2CppReferenceArray<HardModeModifierData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HardModeModifierData.NativeFieldInfoPtr_unlockRequires), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int unlockRequiresPoints
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HardModeModifierData.NativeFieldInfoPtr_unlockRequiresPoints));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HardModeModifierData.NativeFieldInfoPtr_unlockRequiresPoints)) = value;
    }
  }
}
