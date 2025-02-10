// Decompiled with JetBrains decompiler
// Type: BuildingIconSetterUnlocks
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
public class BuildingIconSetterUnlocks : BuildingIconSetter
{
  private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_String_Building_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85219, XrefRangeEnd = 85223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string Get(Building building)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) building)
    };
    IntPtr exc;
    IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BuildingIconSetterUnlocks.NativeMethodInfoPtr_Get_Public_Virtual_String_Building_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BuildingIconSetterUnlocks()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildingIconSetterUnlocks>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BuildingIconSetterUnlocks.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BuildingIconSetterUnlocks()
  {
    Il2CppClassPointerStore<BuildingIconSetterUnlocks>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BuildingIconSetterUnlocks));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildingIconSetterUnlocks>.NativeClassPtr);
    BuildingIconSetterUnlocks.NativeMethodInfoPtr_Get_Public_Virtual_String_Building_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingIconSetterUnlocks>.NativeClassPtr, 100670418);
    BuildingIconSetterUnlocks.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingIconSetterUnlocks>.NativeClassPtr, 100670419);
  }

  public BuildingIconSetterUnlocks(IntPtr pointer)
    : base(pointer)
  {
  }
}
