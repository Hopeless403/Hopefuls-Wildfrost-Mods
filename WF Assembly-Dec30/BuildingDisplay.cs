// Decompiled with JetBrains decompiler
// Type: BuildingDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class BuildingDisplay : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_onEnable;
  private static readonly IntPtr NativeFieldInfoPtr_onDisable;
  private static readonly IntPtr NativeFieldInfoPtr_setSiblingIndex;
  private static readonly IntPtr NativeFieldInfoPtr_helpShower;
  private static readonly IntPtr NativeFieldInfoPtr_current;
  private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Void_GameObject_Building_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetHelp_Private_Void_BuildingType_0;
  private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 85166, RefRangeEnd = 85168, XrefRangeStart = 85136, XrefRangeEnd = 85166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Create(GameObject prefab, Building building)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) building);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BuildingDisplay.NativeMethodInfoPtr_Create_Public_Void_GameObject_Building_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85168, XrefRangeEnd = 85175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetHelp(BuildingType buildingType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buildingType)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BuildingDisplay.NativeMethodInfoPtr_SetHelp_Private_Void_BuildingType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 85185, RefRangeEnd = 85187, XrefRangeStart = 85175, XrefRangeEnd = 85185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void End()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BuildingDisplay.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85187, XrefRangeEnd = 85188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BuildingDisplay()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildingDisplay>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BuildingDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BuildingDisplay()
  {
    Il2CppClassPointerStore<BuildingDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BuildingDisplay));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildingDisplay>.NativeClassPtr);
    BuildingDisplay.NativeFieldInfoPtr_onEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDisplay>.NativeClassPtr, nameof (onEnable));
    BuildingDisplay.NativeFieldInfoPtr_onDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDisplay>.NativeClassPtr, nameof (onDisable));
    BuildingDisplay.NativeFieldInfoPtr_setSiblingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDisplay>.NativeClassPtr, nameof (setSiblingIndex));
    BuildingDisplay.NativeFieldInfoPtr_helpShower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDisplay>.NativeClassPtr, nameof (helpShower));
    BuildingDisplay.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingDisplay>.NativeClassPtr, nameof (current));
    BuildingDisplay.NativeMethodInfoPtr_Create_Public_Void_GameObject_Building_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingDisplay>.NativeClassPtr, 100670409);
    BuildingDisplay.NativeMethodInfoPtr_SetHelp_Private_Void_BuildingType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingDisplay>.NativeClassPtr, 100670410);
    BuildingDisplay.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingDisplay>.NativeClassPtr, 100670411);
    BuildingDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingDisplay>.NativeClassPtr, 100670412);
  }

  public BuildingDisplay(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe UnityEvent onEnable
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingDisplay.NativeFieldInfoPtr_onEnable));
      return pointer == IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildingDisplay.NativeFieldInfoPtr_onEnable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent onDisable
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingDisplay.NativeFieldInfoPtr_onDisable));
      return pointer == IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildingDisplay.NativeFieldInfoPtr_onDisable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int setSiblingIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingDisplay.NativeFieldInfoPtr_setSiblingIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingDisplay.NativeFieldInfoPtr_setSiblingIndex)) = value;
    }
  }

  public unsafe HelpPanelShower helpShower
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingDisplay.NativeFieldInfoPtr_helpShower));
      return pointer == IntPtr.Zero ? (HelpPanelShower) null : new HelpPanelShower(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildingDisplay.NativeFieldInfoPtr_helpShower), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject current
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingDisplay.NativeFieldInfoPtr_current));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildingDisplay.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
