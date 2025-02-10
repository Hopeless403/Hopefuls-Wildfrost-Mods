// Decompiled with JetBrains decompiler
// Type: SteamManager
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
public class SteamManager : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr__init_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr_appId;
  private static readonly IntPtr NativeMethodInfoPtr_get_init_Public_Static_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_init_Private_Static_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public static unsafe bool init
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54517, XrefRangeEnd = 54519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamManager.NativeMethodInfoPtr_get_init_Public_Static_get_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54519, XrefRangeEnd = 54521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamManager.NativeMethodInfoPtr_set_init_Private_Static_set_Void_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54521, XrefRangeEnd = 54545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SteamManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54545, XrefRangeEnd = 54562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SteamManager.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54562, XrefRangeEnd = 54566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SteamManager.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SteamManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamManager>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SteamManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SteamManager()
  {
    Il2CppClassPointerStore<SteamManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SteamManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamManager>.NativeClassPtr);
    SteamManager.NativeFieldInfoPtr__init_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, "<init>k__BackingField");
    SteamManager.NativeFieldInfoPtr_appId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, nameof (appId));
    SteamManager.NativeMethodInfoPtr_get_init_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100667786);
    SteamManager.NativeMethodInfoPtr_set_init_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100667787);
    SteamManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100667788);
    SteamManager.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100667789);
    SteamManager.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100667790);
    SteamManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100667791);
  }

  public SteamManager(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe bool _init_k__BackingField
  {
    get
    {
      bool initKBackingField;
      IL2CPP.il2cpp_field_static_get_value(SteamManager.NativeFieldInfoPtr__init_k__BackingField, (void*) &initKBackingField);
      return initKBackingField;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SteamManager.NativeFieldInfoPtr__init_k__BackingField, (void*) &value);
    }
  }

  public static unsafe int appId
  {
    get
    {
      int appId;
      IL2CPP.il2cpp_field_static_get_value(SteamManager.NativeFieldInfoPtr_appId, (void*) &appId);
      return appId;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SteamManager.NativeFieldInfoPtr_appId, (void*) &value);
    }
  }
}
