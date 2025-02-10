// Decompiled with JetBrains decompiler
// Type: WorldSpaceCanvasFitScreenSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
public class WorldSpaceCanvasFitScreenSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_instance;
  private static readonly IntPtr NativeFieldInfoPtr_exists;
  private static readonly IntPtr NativeFieldInfoPtr_screenWidth;
  private static readonly IntPtr NativeFieldInfoPtr_screenHeight;
  private static readonly IntPtr NativeFieldInfoPtr_aspectRatio;
  private static readonly IntPtr NativeFieldInfoPtr_safeArea;
  private static readonly IntPtr NativeFieldInfoPtr_fixedHeight;
  private static readonly IntPtr NativeFieldInfoPtr_maxWidth;
  private static readonly IntPtr NativeFieldInfoPtr_minWidth;
  private static readonly IntPtr NativeFieldInfoPtr_minAspect;
  private static readonly IntPtr NativeFieldInfoPtr_maxAspect;
  private static readonly IntPtr NativeFieldInfoPtr__cam_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr_canvases;
  private static readonly IntPtr NativeFieldInfoPtr_camPosition;
  private static readonly IntPtr NativeFieldInfoPtr_lastOrientation;
  private static readonly IntPtr NativeFieldInfoPtr_lastSafeArea;
  private static readonly IntPtr NativeMethodInfoPtr_get_cam_Public_get_Camera_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_cam_Private_set_Void_Camera_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AspectRatio_Public_Static_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateSize_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Static_Void_WorldSpaceCanvasUpdater_0;
  private static readonly IntPtr NativeMethodInfoPtr_Unregister_Public_Static_Void_WorldSpaceCanvasUpdater_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe Camera cam
  {
    [CallerCount(9), CachedScanResults(RefRangeStart = 40606, RefRangeEnd = 40615, XrefRangeStart = 40606, XrefRangeEnd = 40615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldSpaceCanvasFitScreenSystem.NativeMethodInfoPtr_get_cam_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Camera) null : new Camera(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldSpaceCanvasFitScreenSystem.NativeMethodInfoPtr_set_cam_Private_set_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public static unsafe float AspectRatio
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 82837, RefRangeEnd = 82838, XrefRangeStart = 82831, XrefRangeEnd = 82837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldSpaceCanvasFitScreenSystem.NativeMethodInfoPtr_get_AspectRatio_Public_Static_get_Single_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82838, XrefRangeEnd = 82854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WorldSpaceCanvasFitScreenSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82854, XrefRangeEnd = 82862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WorldSpaceCanvasFitScreenSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82862, XrefRangeEnd = 82863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SceneChanged(Scene scene)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &scene
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WorldSpaceCanvasFitScreenSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82863, XrefRangeEnd = 82876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WorldSpaceCanvasFitScreenSystem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 82974, RefRangeEnd = 82977, XrefRangeStart = 82876, XrefRangeEnd = 82974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateSize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WorldSpaceCanvasFitScreenSystem.NativeMethodInfoPtr_UpdateSize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 82985, RefRangeEnd = 82986, XrefRangeStart = 82977, XrefRangeEnd = 82985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Register(WorldSpaceCanvasUpdater canvas)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) canvas)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WorldSpaceCanvasFitScreenSystem.NativeMethodInfoPtr_Register_Public_Static_Void_WorldSpaceCanvasUpdater_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 82994, RefRangeEnd = 82995, XrefRangeStart = 82986, XrefRangeEnd = 82994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Unregister(WorldSpaceCanvasUpdater canvas)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) canvas)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WorldSpaceCanvasFitScreenSystem.NativeMethodInfoPtr_Unregister_Public_Static_Void_WorldSpaceCanvasUpdater_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WorldSpaceCanvasFitScreenSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WorldSpaceCanvasFitScreenSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static WorldSpaceCanvasFitScreenSystem()
  {
    Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (WorldSpaceCanvasFitScreenSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr);
    WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, nameof (instance));
    WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_exists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, nameof (exists));
    WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_screenWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, nameof (screenWidth));
    WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_screenHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, nameof (screenHeight));
    WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_aspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, nameof (aspectRatio));
    WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_safeArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, nameof (safeArea));
    WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_fixedHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, nameof (fixedHeight));
    WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_maxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, nameof (maxWidth));
    WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_minWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, nameof (minWidth));
    WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_minAspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, nameof (minAspect));
    WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_maxAspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, nameof (maxAspect));
    WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr__cam_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, "<cam>k__BackingField");
    WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_canvases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, nameof (canvases));
    WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_camPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, nameof (camPosition));
    WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_lastOrientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, nameof (lastOrientation));
    WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_lastSafeArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, nameof (lastSafeArea));
    WorldSpaceCanvasFitScreenSystem.NativeMethodInfoPtr_get_cam_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, 100670139);
    WorldSpaceCanvasFitScreenSystem.NativeMethodInfoPtr_set_cam_Private_set_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, 100670140);
    WorldSpaceCanvasFitScreenSystem.NativeMethodInfoPtr_get_AspectRatio_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, 100670141);
    WorldSpaceCanvasFitScreenSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, 100670142);
    WorldSpaceCanvasFitScreenSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, 100670143);
    WorldSpaceCanvasFitScreenSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, 100670144);
    WorldSpaceCanvasFitScreenSystem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, 100670145);
    WorldSpaceCanvasFitScreenSystem.NativeMethodInfoPtr_UpdateSize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, 100670146);
    WorldSpaceCanvasFitScreenSystem.NativeMethodInfoPtr_Register_Public_Static_Void_WorldSpaceCanvasUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, 100670147);
    WorldSpaceCanvasFitScreenSystem.NativeMethodInfoPtr_Unregister_Public_Static_Void_WorldSpaceCanvasUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, 100670148);
    WorldSpaceCanvasFitScreenSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceCanvasFitScreenSystem>.NativeClassPtr, 100670149);
  }

  public WorldSpaceCanvasFitScreenSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe WorldSpaceCanvasFitScreenSystem instance
  {
    get
    {
      IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_instance, (void*) &num);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (WorldSpaceCanvasFitScreenSystem) null : new WorldSpaceCanvasFitScreenSystem(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe bool exists
  {
    get
    {
      bool exists;
      IL2CPP.il2cpp_field_static_get_value(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_exists, (void*) &exists);
      return exists;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_exists, (void*) &value);
    }
  }

  public unsafe int screenWidth
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_screenWidth));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_screenWidth)) = value;
    }
  }

  public unsafe int screenHeight
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_screenHeight));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_screenHeight)) = value;
    }
  }

  public unsafe float aspectRatio
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_aspectRatio));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_aspectRatio)) = value;
    }
  }

  public unsafe Rect safeArea
  {
    get
    {
      return *(Rect*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_safeArea));
    }
    [param: In] set
    {
      *(Rect*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_safeArea)) = value;
    }
  }

  public static unsafe float fixedHeight
  {
    get
    {
      float fixedHeight;
      IL2CPP.il2cpp_field_static_get_value(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_fixedHeight, (void*) &fixedHeight);
      return fixedHeight;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_fixedHeight, (void*) &value);
    }
  }

  public static unsafe float maxWidth
  {
    get
    {
      float maxWidth;
      IL2CPP.il2cpp_field_static_get_value(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_maxWidth, (void*) &maxWidth);
      return maxWidth;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_maxWidth, (void*) &value);
    }
  }

  public static unsafe float minWidth
  {
    get
    {
      float minWidth;
      IL2CPP.il2cpp_field_static_get_value(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_minWidth, (void*) &minWidth);
      return minWidth;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_minWidth, (void*) &value);
    }
  }

  public static unsafe float minAspect
  {
    get
    {
      float minAspect;
      IL2CPP.il2cpp_field_static_get_value(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_minAspect, (void*) &minAspect);
      return minAspect;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_minAspect, (void*) &value);
    }
  }

  public static unsafe float maxAspect
  {
    get
    {
      float maxAspect;
      IL2CPP.il2cpp_field_static_get_value(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_maxAspect, (void*) &maxAspect);
      return maxAspect;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_maxAspect, (void*) &value);
    }
  }

  public unsafe Camera _cam_k__BackingField
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr__cam_k__BackingField));
      return pointer == IntPtr.Zero ? (Camera) null : new Camera(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr__cam_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe List<WorldSpaceCanvasUpdater> canvases
  {
    get
    {
      IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_canvases, (void*) &num);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (List<WorldSpaceCanvasUpdater>) null : new List<WorldSpaceCanvasUpdater>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_canvases, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Vector3 camPosition
  {
    get
    {
      Vector3 camPosition;
      IL2CPP.il2cpp_field_static_get_value(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_camPosition, (void*) &camPosition);
      return camPosition;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_camPosition, (void*) &value);
    }
  }

  public unsafe ScreenOrientation lastOrientation
  {
    get
    {
      return *(ScreenOrientation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_lastOrientation));
    }
    [param: In] set
    {
      *(ScreenOrientation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_lastOrientation)) = value;
    }
  }

  public unsafe Rect lastSafeArea
  {
    get
    {
      return *(Rect*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_lastSafeArea));
    }
    [param: In] set
    {
      *(Rect*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasFitScreenSystem.NativeFieldInfoPtr_lastSafeArea)) = value;
    }
  }
}
