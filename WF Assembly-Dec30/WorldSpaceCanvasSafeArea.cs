// Decompiled with JetBrains decompiler
// Type: WorldSpaceCanvasSafeArea
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
public class WorldSpaceCanvasSafeArea : WorldSpaceCanvasUpdater
{
  private static readonly IntPtr NativeFieldInfoPtr_parent;
  private static readonly IntPtr NativeFieldInfoPtr_considerX;
  private static readonly IntPtr NativeFieldInfoPtr_considerY;
  private static readonly IntPtr NativeFieldInfoPtr_waitForParent;
  private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateSize_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100536, XrefRangeEnd = 100592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WorldSpaceCanvasSafeArea.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public override unsafe void UpdateSize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WorldSpaceCanvasSafeArea.NativeMethodInfoPtr_UpdateSize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100592, XrefRangeEnd = 100593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WorldSpaceCanvasSafeArea()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldSpaceCanvasSafeArea>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WorldSpaceCanvasSafeArea.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static WorldSpaceCanvasSafeArea()
  {
    Il2CppClassPointerStore<WorldSpaceCanvasSafeArea>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (WorldSpaceCanvasSafeArea));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldSpaceCanvasSafeArea>.NativeClassPtr);
    WorldSpaceCanvasSafeArea.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasSafeArea>.NativeClassPtr, nameof (parent));
    WorldSpaceCanvasSafeArea.NativeFieldInfoPtr_considerX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasSafeArea>.NativeClassPtr, nameof (considerX));
    WorldSpaceCanvasSafeArea.NativeFieldInfoPtr_considerY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasSafeArea>.NativeClassPtr, nameof (considerY));
    WorldSpaceCanvasSafeArea.NativeFieldInfoPtr_waitForParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasSafeArea>.NativeClassPtr, nameof (waitForParent));
    WorldSpaceCanvasSafeArea.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceCanvasSafeArea>.NativeClassPtr, 100672336);
    WorldSpaceCanvasSafeArea.NativeMethodInfoPtr_UpdateSize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceCanvasSafeArea>.NativeClassPtr, 100672337);
    WorldSpaceCanvasSafeArea.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceCanvasSafeArea>.NativeClassPtr, 100672338);
  }

  public WorldSpaceCanvasSafeArea(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe RectTransform parent
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasSafeArea.NativeFieldInfoPtr_parent));
      return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasSafeArea.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool considerX
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasSafeArea.NativeFieldInfoPtr_considerX));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasSafeArea.NativeFieldInfoPtr_considerX)) = value;
    }
  }

  public unsafe bool considerY
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasSafeArea.NativeFieldInfoPtr_considerY));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasSafeArea.NativeFieldInfoPtr_considerY)) = value;
    }
  }

  public unsafe bool waitForParent
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasSafeArea.NativeFieldInfoPtr_waitForParent));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasSafeArea.NativeFieldInfoPtr_waitForParent)) = value;
    }
  }
}
