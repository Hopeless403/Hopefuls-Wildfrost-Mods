// Decompiled with JetBrains decompiler
// Type: BuildingPlot
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
public class BuildingPlot : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_sortingLayerName;
  private static readonly IntPtr NativeFieldInfoPtr_sortingOrder;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85403, XrefRangeEnd = 85421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BuildingPlot.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BuildingPlot()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildingPlot>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BuildingPlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BuildingPlot()
  {
    Il2CppClassPointerStore<BuildingPlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BuildingPlot));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildingPlot>.NativeClassPtr);
    BuildingPlot.NativeFieldInfoPtr_sortingLayerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPlot>.NativeClassPtr, nameof (sortingLayerName));
    BuildingPlot.NativeFieldInfoPtr_sortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPlot>.NativeClassPtr, nameof (sortingOrder));
    BuildingPlot.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingPlot>.NativeClassPtr, 100670431);
    BuildingPlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingPlot>.NativeClassPtr, 100670432);
  }

  public BuildingPlot(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string sortingLayerName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingPlot.NativeFieldInfoPtr_sortingLayerName)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildingPlot.NativeFieldInfoPtr_sortingLayerName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int sortingOrder
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingPlot.NativeFieldInfoPtr_sortingOrder));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingPlot.NativeFieldInfoPtr_sortingOrder)) = value;
    }
  }
}
