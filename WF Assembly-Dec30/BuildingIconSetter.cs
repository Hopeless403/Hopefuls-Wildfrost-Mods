// Decompiled with JetBrains decompiler
// Type: BuildingIconSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
public class BuildingIconSetter : MonoBehaviour
{
  private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_New_String_Building_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85188, XrefRangeEnd = 85190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe string Get(Building building)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) building)
    };
    IntPtr exc;
    IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BuildingIconSetter.NativeMethodInfoPtr_Get_Public_Virtual_New_String_Building_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BuildingIconSetter()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildingIconSetter>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BuildingIconSetter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BuildingIconSetter()
  {
    Il2CppClassPointerStore<BuildingIconSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BuildingIconSetter));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildingIconSetter>.NativeClassPtr);
    BuildingIconSetter.NativeMethodInfoPtr_Get_Public_Virtual_New_String_Building_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingIconSetter>.NativeClassPtr, 100670413);
    BuildingIconSetter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingIconSetter>.NativeClassPtr, 100670414);
  }

  public BuildingIconSetter(IntPtr pointer)
    : base(pointer)
  {
  }
}
