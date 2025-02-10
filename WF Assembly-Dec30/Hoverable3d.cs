// Decompiled with JetBrains decompiler
// Type: Hoverable3d
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Events;

#nullable disable
public class Hoverable3d : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_onHover;
  private static readonly IntPtr NativeFieldInfoPtr_onUnHover;
  private static readonly IntPtr NativeMethodInfoPtr_Hover_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnHover_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61067, XrefRangeEnd = 61068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hover()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Hoverable3d.NativeMethodInfoPtr_Hover_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61068, XrefRangeEnd = 61069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnHover()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Hoverable3d.NativeMethodInfoPtr_UnHover_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Hoverable3d()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hoverable3d>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Hoverable3d.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Hoverable3d()
  {
    Il2CppClassPointerStore<Hoverable3d>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Hoverable3d));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hoverable3d>.NativeClassPtr);
    Hoverable3d.NativeFieldInfoPtr_onHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hoverable3d>.NativeClassPtr, nameof (onHover));
    Hoverable3d.NativeFieldInfoPtr_onUnHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hoverable3d>.NativeClassPtr, nameof (onUnHover));
    Hoverable3d.NativeMethodInfoPtr_Hover_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hoverable3d>.NativeClassPtr, 100668277);
    Hoverable3d.NativeMethodInfoPtr_UnHover_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hoverable3d>.NativeClassPtr, 100668278);
    Hoverable3d.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hoverable3d>.NativeClassPtr, 100668279);
  }

  public Hoverable3d(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe UnityEvent onHover
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hoverable3d.NativeFieldInfoPtr_onHover));
      return pointer == IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Hoverable3d.NativeFieldInfoPtr_onHover), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent onUnHover
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hoverable3d.NativeFieldInfoPtr_onUnHover));
      return pointer == IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Hoverable3d.NativeFieldInfoPtr_onUnHover), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
