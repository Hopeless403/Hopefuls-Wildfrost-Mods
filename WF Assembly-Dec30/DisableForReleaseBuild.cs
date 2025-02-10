// Decompiled with JetBrains decompiler
// Type: DisableForReleaseBuild
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
public class DisableForReleaseBuild : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_disableGameObject;
  private static readonly IntPtr NativeFieldInfoPtr_disableComponent;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42767, XrefRangeEnd = 42770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DisableForReleaseBuild.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DisableForReleaseBuild()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisableForReleaseBuild>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DisableForReleaseBuild.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static DisableForReleaseBuild()
  {
    Il2CppClassPointerStore<DisableForReleaseBuild>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (DisableForReleaseBuild));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableForReleaseBuild>.NativeClassPtr);
    DisableForReleaseBuild.NativeFieldInfoPtr_disableGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableForReleaseBuild>.NativeClassPtr, nameof (disableGameObject));
    DisableForReleaseBuild.NativeFieldInfoPtr_disableComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableForReleaseBuild>.NativeClassPtr, nameof (disableComponent));
    DisableForReleaseBuild.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableForReleaseBuild>.NativeClassPtr, 100666472);
    DisableForReleaseBuild.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableForReleaseBuild>.NativeClassPtr, 100666473);
  }

  public DisableForReleaseBuild(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool disableGameObject
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableForReleaseBuild.NativeFieldInfoPtr_disableGameObject));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableForReleaseBuild.NativeFieldInfoPtr_disableGameObject)) = value;
    }
  }

  public unsafe bool disableComponent
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableForReleaseBuild.NativeFieldInfoPtr_disableComponent));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableForReleaseBuild.NativeFieldInfoPtr_disableComponent)) = value;
    }
  }
}
