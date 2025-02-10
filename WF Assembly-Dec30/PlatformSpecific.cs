// Decompiled with JetBrains decompiler
// Type: PlatformSpecific
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
public class PlatformSpecific : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_editor;
  private static readonly IntPtr NativeFieldInfoPtr_windows;
  private static readonly IntPtr NativeFieldInfoPtr_switch;
  private static readonly IntPtr NativeFieldInfoPtr_release;
  private static readonly IntPtr NativeFieldInfoPtr_demo;
  private static readonly IntPtr NativeFieldInfoPtr_notDemo;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53214, XrefRangeEnd = 53216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PlatformSpecific.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 27357, RefRangeEnd = 27361, XrefRangeStart = 27357, XrefRangeEnd = 27361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlatformSpecific()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformSpecific>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PlatformSpecific.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static PlatformSpecific()
  {
    Il2CppClassPointerStore<PlatformSpecific>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (PlatformSpecific));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformSpecific>.NativeClassPtr);
    PlatformSpecific.NativeFieldInfoPtr_editor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformSpecific>.NativeClassPtr, nameof (editor));
    PlatformSpecific.NativeFieldInfoPtr_windows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformSpecific>.NativeClassPtr, nameof (windows));
    PlatformSpecific.NativeFieldInfoPtr_switch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformSpecific>.NativeClassPtr, nameof (@switch));
    PlatformSpecific.NativeFieldInfoPtr_release = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformSpecific>.NativeClassPtr, nameof (release));
    PlatformSpecific.NativeFieldInfoPtr_demo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformSpecific>.NativeClassPtr, nameof (demo));
    PlatformSpecific.NativeFieldInfoPtr_notDemo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformSpecific>.NativeClassPtr, nameof (notDemo));
    PlatformSpecific.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSpecific>.NativeClassPtr, 100667589);
    PlatformSpecific.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSpecific>.NativeClassPtr, 100667590);
  }

  public PlatformSpecific(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool editor
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformSpecific.NativeFieldInfoPtr_editor));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformSpecific.NativeFieldInfoPtr_editor)) = value;
    }
  }

  public unsafe bool windows
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformSpecific.NativeFieldInfoPtr_windows));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformSpecific.NativeFieldInfoPtr_windows)) = value;
    }
  }

  public unsafe bool @switch
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformSpecific.NativeFieldInfoPtr_switch));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformSpecific.NativeFieldInfoPtr_switch)) = value;
    }
  }

  public unsafe bool release
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformSpecific.NativeFieldInfoPtr_release));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformSpecific.NativeFieldInfoPtr_release)) = value;
    }
  }

  public unsafe bool demo
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformSpecific.NativeFieldInfoPtr_demo));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformSpecific.NativeFieldInfoPtr_demo)) = value;
    }
  }

  public unsafe bool notDemo
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformSpecific.NativeFieldInfoPtr_notDemo));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlatformSpecific.NativeFieldInfoPtr_notDemo)) = value;
    }
  }
}
