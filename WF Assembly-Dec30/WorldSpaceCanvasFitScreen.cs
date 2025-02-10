// Decompiled with JetBrains decompiler
// Type: WorldSpaceCanvasFitScreen
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
public class WorldSpaceCanvasFitScreen : WorldSpaceCanvasUpdater
{
  private static readonly IntPtr NativeFieldInfoPtr_width;
  private static readonly IntPtr NativeFieldInfoPtr_height;
  private static readonly IntPtr NativeFieldInfoPtr_scale;
  private static readonly IntPtr NativeFieldInfoPtr_largeScaleCurve;
  private static readonly IntPtr NativeFieldInfoPtr_padding;
  private static readonly IntPtr NativeFieldInfoPtr_onUpdate;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateSize_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100510, XrefRangeEnd = 100536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void UpdateSize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WorldSpaceCanvasFitScreen.NativeMethodInfoPtr_UpdateSize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WorldSpaceCanvasFitScreen()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldSpaceCanvasFitScreen>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WorldSpaceCanvasFitScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static WorldSpaceCanvasFitScreen()
  {
    Il2CppClassPointerStore<WorldSpaceCanvasFitScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (WorldSpaceCanvasFitScreen));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldSpaceCanvasFitScreen>.NativeClassPtr);
    WorldSpaceCanvasFitScreen.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasFitScreen>.NativeClassPtr, nameof (width));
    WorldSpaceCanvasFitScreen.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasFitScreen>.NativeClassPtr, nameof (height));
    WorldSpaceCanvasFitScreen.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasFitScreen>.NativeClassPtr, nameof (scale));
    WorldSpaceCanvasFitScreen.NativeFieldInfoPtr_largeScaleCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasFitScreen>.NativeClassPtr, nameof (largeScaleCurve));
    WorldSpaceCanvasFitScreen.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasFitScreen>.NativeClassPtr, nameof (padding));
    WorldSpaceCanvasFitScreen.NativeFieldInfoPtr_onUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasFitScreen>.NativeClassPtr, nameof (onUpdate));
    WorldSpaceCanvasFitScreen.NativeMethodInfoPtr_UpdateSize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceCanvasFitScreen>.NativeClassPtr, 100672334);
    WorldSpaceCanvasFitScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceCanvasFitScreen>.NativeClassPtr, 100672335);
  }

  public WorldSpaceCanvasFitScreen(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float width
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreen.NativeFieldInfoPtr_width));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreen.NativeFieldInfoPtr_width)) = value;
    }
  }

  public unsafe float height
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreen.NativeFieldInfoPtr_height));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreen.NativeFieldInfoPtr_height)) = value;
    }
  }

  public unsafe float scale
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreen.NativeFieldInfoPtr_scale));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreen.NativeFieldInfoPtr_scale)) = value;
    }
  }

  public unsafe AnimationCurve largeScaleCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreen.NativeFieldInfoPtr_largeScaleCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreen.NativeFieldInfoPtr_largeScaleCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 padding
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreen.NativeFieldInfoPtr_padding));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreen.NativeFieldInfoPtr_padding)) = value;
    }
  }

  public unsafe UnityEvent<RectTransform> onUpdate
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreen.NativeFieldInfoPtr_onUpdate));
      return pointer == IntPtr.Zero ? (UnityEvent<RectTransform>) null : new UnityEvent<RectTransform>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreen.NativeFieldInfoPtr_onUpdate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
