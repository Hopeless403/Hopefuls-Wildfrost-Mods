// Decompiled with JetBrains decompiler
// Type: ScreenSystem
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
public class ScreenSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instance;
  private static readonly System.IntPtr NativeFieldInfoPtr_windowedWidth;
  private static readonly System.IntPtr NativeFieldInfoPtr_windowedHeight;
  private static readonly System.IntPtr NativeFieldInfoPtr_windowedMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_fullMode;
  private static readonly System.IntPtr NativeFieldInfoPtr__displayIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_current;
  private static readonly System.IntPtr NativeFieldInfoPtr_vsync;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetFramerate;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_fullScreenWidth_Private_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_fullScreenHeight_Private_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_displayIndex_Private_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_display_Private_get_Display_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsWindowed_Private_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SettingChanged_Private_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetWindowed_Private_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetFull_Private_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetBorderless_Private_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTargetFramerate_Private_Static_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetVsync_Private_Static_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetResolutionFullscreen_Public_Static_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetResolutionBorderless_Public_Static_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetResolutionWindowed_Public_Static_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe int fullScreenWidth
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70520, XrefRangeEnd = 70523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScreenSystem.NativeMethodInfoPtr_get_fullScreenWidth_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe int fullScreenHeight
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70523, XrefRangeEnd = 70526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScreenSystem.NativeMethodInfoPtr_get_fullScreenHeight_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe int displayIndex
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70526, XrefRangeEnd = 70532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScreenSystem.NativeMethodInfoPtr_get_displayIndex_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe UnityEngine.Display display
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 70542, RefRangeEnd = 70548, XrefRangeStart = 70532, XrefRangeEnd = 70542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScreenSystem.NativeMethodInfoPtr_get_display_Private_get_Display_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (UnityEngine.Display) null : new UnityEngine.Display(pointer);
    }
  }

  public static unsafe bool IsWindowed
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70548, XrefRangeEnd = 70549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScreenSystem.NativeMethodInfoPtr_get_IsWindowed_Private_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70549, XrefRangeEnd = 70586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70586, XrefRangeEnd = 70594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70594, XrefRangeEnd = 70603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SettingChanged(string key, Il2CppSystem.Object value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenSystem.NativeMethodInfoPtr_SettingChanged_Private_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70603, XrefRangeEnd = 70645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenSystem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 70659, RefRangeEnd = 70661, XrefRangeStart = 70645, XrefRangeEnd = 70659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(int mode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &mode
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenSystem.NativeMethodInfoPtr_Set_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 70672, RefRangeEnd = 70673, XrefRangeStart = 70661, XrefRangeEnd = 70672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetWindowed(int forceWidth = 0, int forceHeight = 0)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &forceWidth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &forceHeight;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenSystem.NativeMethodInfoPtr_SetWindowed_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 70691, RefRangeEnd = 70693, XrefRangeStart = 70673, XrefRangeEnd = 70691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetFull(int forceWidth = 0, int forceHeight = 0)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &forceWidth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &forceHeight;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenSystem.NativeMethodInfoPtr_SetFull_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 70711, RefRangeEnd = 70713, XrefRangeStart = 70693, XrefRangeEnd = 70711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetBorderless(int forceWidth = 0, int forceHeight = 0)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &forceWidth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &forceHeight;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenSystem.NativeMethodInfoPtr_SetBorderless_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 70720, RefRangeEnd = 70721, XrefRangeStart = 70713, XrefRangeEnd = 70720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetTargetFramerate(int mode)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &mode
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenSystem.NativeMethodInfoPtr_SetTargetFramerate_Private_Static_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70721, XrefRangeEnd = 70723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetVsync(int mode)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &mode
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenSystem.NativeMethodInfoPtr_SetVsync_Private_Static_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70723, XrefRangeEnd = 70727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetResolutionFullscreen(int width, int height)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenSystem.NativeMethodInfoPtr_SetResolutionFullscreen_Public_Static_Void_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70727, XrefRangeEnd = 70731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetResolutionBorderless(int width, int height)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenSystem.NativeMethodInfoPtr_SetResolutionBorderless_Public_Static_Void_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 70735, RefRangeEnd = 70736, XrefRangeStart = 70731, XrefRangeEnd = 70735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetResolutionWindowed(int width, int height)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenSystem.NativeMethodInfoPtr_SetResolutionWindowed_Public_Static_Void_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70736, XrefRangeEnd = 70737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScreenSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ScreenSystem()
  {
    Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ScreenSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr);
    ScreenSystem.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, nameof (instance));
    ScreenSystem.NativeFieldInfoPtr_windowedWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, nameof (windowedWidth));
    ScreenSystem.NativeFieldInfoPtr_windowedHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, nameof (windowedHeight));
    ScreenSystem.NativeFieldInfoPtr_windowedMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, nameof (windowedMode));
    ScreenSystem.NativeFieldInfoPtr_fullMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, nameof (fullMode));
    ScreenSystem.NativeFieldInfoPtr__displayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, nameof (_displayIndex));
    ScreenSystem.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, nameof (current));
    ScreenSystem.NativeFieldInfoPtr_vsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, nameof (vsync));
    ScreenSystem.NativeFieldInfoPtr_targetFramerate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, nameof (targetFramerate));
    ScreenSystem.NativeMethodInfoPtr_get_fullScreenWidth_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, 100669057);
    ScreenSystem.NativeMethodInfoPtr_get_fullScreenHeight_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, 100669058);
    ScreenSystem.NativeMethodInfoPtr_get_displayIndex_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, 100669059);
    ScreenSystem.NativeMethodInfoPtr_get_display_Private_get_Display_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, 100669060);
    ScreenSystem.NativeMethodInfoPtr_get_IsWindowed_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, 100669061);
    ScreenSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, 100669062);
    ScreenSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, 100669063);
    ScreenSystem.NativeMethodInfoPtr_SettingChanged_Private_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, 100669064);
    ScreenSystem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, 100669065);
    ScreenSystem.NativeMethodInfoPtr_Set_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, 100669066);
    ScreenSystem.NativeMethodInfoPtr_SetWindowed_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, 100669067);
    ScreenSystem.NativeMethodInfoPtr_SetFull_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, 100669068);
    ScreenSystem.NativeMethodInfoPtr_SetBorderless_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, 100669069);
    ScreenSystem.NativeMethodInfoPtr_SetTargetFramerate_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, 100669070);
    ScreenSystem.NativeMethodInfoPtr_SetVsync_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, 100669071);
    ScreenSystem.NativeMethodInfoPtr_SetResolutionFullscreen_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, 100669072);
    ScreenSystem.NativeMethodInfoPtr_SetResolutionBorderless_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, 100669073);
    ScreenSystem.NativeMethodInfoPtr_SetResolutionWindowed_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, 100669074);
    ScreenSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, 100669075);
  }

  public ScreenSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe ScreenSystem instance
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ScreenSystem.NativeFieldInfoPtr_instance, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ScreenSystem) null : new ScreenSystem(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScreenSystem.NativeFieldInfoPtr_instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int windowedWidth
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenSystem.NativeFieldInfoPtr_windowedWidth));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenSystem.NativeFieldInfoPtr_windowedWidth)) = value;
    }
  }

  public unsafe int windowedHeight
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenSystem.NativeFieldInfoPtr_windowedHeight));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenSystem.NativeFieldInfoPtr_windowedHeight)) = value;
    }
  }

  public unsafe FullScreenMode windowedMode
  {
    get
    {
      return *(FullScreenMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenSystem.NativeFieldInfoPtr_windowedMode));
    }
    [param: In] set
    {
      *(FullScreenMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenSystem.NativeFieldInfoPtr_windowedMode)) = value;
    }
  }

  public unsafe FullScreenMode fullMode
  {
    get
    {
      return *(FullScreenMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenSystem.NativeFieldInfoPtr_fullMode));
    }
    [param: In] set
    {
      *(FullScreenMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenSystem.NativeFieldInfoPtr_fullMode)) = value;
    }
  }

  public unsafe int _displayIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenSystem.NativeFieldInfoPtr__displayIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenSystem.NativeFieldInfoPtr__displayIndex)) = value;
    }
  }

  public unsafe int current
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenSystem.NativeFieldInfoPtr_current));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenSystem.NativeFieldInfoPtr_current)) = value;
    }
  }

  public unsafe int vsync
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenSystem.NativeFieldInfoPtr_vsync));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenSystem.NativeFieldInfoPtr_vsync)) = value;
    }
  }

  public unsafe int targetFramerate
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenSystem.NativeFieldInfoPtr_targetFramerate));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenSystem.NativeFieldInfoPtr_targetFramerate)) = value;
    }
  }

  [ObfuscatedName("ScreenSystem/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__22_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__22_0_Internal_Boolean_SetSettingInt_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenSystem.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScreenSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70516, XrefRangeEnd = 70520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Update_b__22_0(SetSettingInt a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScreenSystem.__c.NativeMethodInfoPtr__Update_b__22_0_Internal_Boolean_SetSettingInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<ScreenSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenSystem>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSystem.__c>.NativeClassPtr);
      ScreenSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSystem.__c>.NativeClassPtr, "<>9");
      ScreenSystem.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSystem.__c>.NativeClassPtr, "<>9__22_0");
      ScreenSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSystem.__c>.NativeClassPtr, 100669077);
      ScreenSystem.__c.NativeMethodInfoPtr__Update_b__22_0_Internal_Boolean_SetSettingInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSystem.__c>.NativeClassPtr, 100669078);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe ScreenSystem.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ScreenSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ScreenSystem.__c) null : new ScreenSystem.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ScreenSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<SetSettingInt, bool> __9__22_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ScreenSystem.__c.NativeFieldInfoPtr___9__22_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<SetSettingInt, bool>) null : new Il2CppSystem.Func<SetSettingInt, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ScreenSystem.__c.NativeFieldInfoPtr___9__22_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
