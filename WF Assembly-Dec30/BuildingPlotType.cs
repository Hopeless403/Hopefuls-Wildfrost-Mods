// Decompiled with JetBrains decompiler
// Type: BuildingPlotType
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
public class BuildingPlotType : DataFile
{
  private static readonly IntPtr NativeFieldInfoPtr_illegalBuildings;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BuildingPlotType()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildingPlotType>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BuildingPlotType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BuildingPlotType()
  {
    Il2CppClassPointerStore<BuildingPlotType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BuildingPlotType));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildingPlotType>.NativeClassPtr);
    BuildingPlotType.NativeFieldInfoPtr_illegalBuildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPlotType>.NativeClassPtr, nameof (illegalBuildings));
    BuildingPlotType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingPlotType>.NativeClassPtr, 100673669);
  }

  public BuildingPlotType(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<BuildingType> illegalBuildings
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingPlotType.NativeFieldInfoPtr_illegalBuildings));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<BuildingType>) null : new Il2CppReferenceArray<BuildingType>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildingPlotType.NativeFieldInfoPtr_illegalBuildings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
