// Decompiled with JetBrains decompiler
// Type: AmbienceSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using FMOD;
using FMOD.Studio;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine.SceneManagement;

#nullable disable
public class AmbienceSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_validScenes;
  private static readonly IntPtr NativeFieldInfoPtr_current;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0;
  private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_Void_EventReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_Play_Private_Static_Void_GUID_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetParam_Public_Static_Void_String_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Stop_Private_Static_Void_STOP_MODE_0;
  private static readonly IntPtr NativeMethodInfoPtr_IsRunning_Private_Static_Boolean_EventInstance_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70944, XrefRangeEnd = 70952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AmbienceSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70952, XrefRangeEnd = 70961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AmbienceSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70961, XrefRangeEnd = 70968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SceneChanged(Scene scene)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &scene
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AmbienceSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70968, XrefRangeEnd = 70969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Play(EventReference eventId)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &eventId
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AmbienceSystem.NativeMethodInfoPtr_Play_Public_Static_Void_EventReference_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 70981, RefRangeEnd = 70983, XrefRangeStart = 70969, XrefRangeEnd = 70981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Play(GUID eventGUID)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &eventGUID
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AmbienceSystem.NativeMethodInfoPtr_Play_Private_Static_Void_GUID_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 70989, RefRangeEnd = 70992, XrefRangeStart = 70983, XrefRangeEnd = 70989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetParam(string name, float value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AmbienceSystem.NativeMethodInfoPtr_SetParam_Public_Static_Void_String_Single_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 71000, RefRangeEnd = 71002, XrefRangeStart = 70992, XrefRangeEnd = 71000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Stop(FMOD.Studio.STOP_MODE stopMode = FMOD.Studio.STOP_MODE.ALLOWFADEOUT)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &stopMode
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AmbienceSystem.NativeMethodInfoPtr_Stop_Private_Static_Void_STOP_MODE_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71002, XrefRangeEnd = 71004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsRunning(EventInstance instance)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &instance
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(AmbienceSystem.NativeMethodInfoPtr_IsRunning_Private_Static_Boolean_EventInstance_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71004, XrefRangeEnd = 71025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AmbienceSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbienceSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AmbienceSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static AmbienceSystem()
  {
    Il2CppClassPointerStore<AmbienceSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (AmbienceSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbienceSystem>.NativeClassPtr);
    AmbienceSystem.NativeFieldInfoPtr_validScenes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbienceSystem>.NativeClassPtr, nameof (validScenes));
    AmbienceSystem.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbienceSystem>.NativeClassPtr, nameof (current));
    AmbienceSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbienceSystem>.NativeClassPtr, 100669101);
    AmbienceSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbienceSystem>.NativeClassPtr, 100669102);
    AmbienceSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbienceSystem>.NativeClassPtr, 100669103);
    AmbienceSystem.NativeMethodInfoPtr_Play_Public_Static_Void_EventReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbienceSystem>.NativeClassPtr, 100669104);
    AmbienceSystem.NativeMethodInfoPtr_Play_Private_Static_Void_GUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbienceSystem>.NativeClassPtr, 100669105);
    AmbienceSystem.NativeMethodInfoPtr_SetParam_Public_Static_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbienceSystem>.NativeClassPtr, 100669106);
    AmbienceSystem.NativeMethodInfoPtr_Stop_Private_Static_Void_STOP_MODE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbienceSystem>.NativeClassPtr, 100669107);
    AmbienceSystem.NativeMethodInfoPtr_IsRunning_Private_Static_Boolean_EventInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbienceSystem>.NativeClassPtr, 100669108);
    AmbienceSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbienceSystem>.NativeClassPtr, 100669109);
  }

  public AmbienceSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppStringArray validScenes
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AmbienceSystem.NativeFieldInfoPtr_validScenes));
      return pointer == IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AmbienceSystem.NativeFieldInfoPtr_validScenes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe EventInstance current
  {
    get
    {
      EventInstance current;
      IL2CPP.il2cpp_field_static_get_value(AmbienceSystem.NativeFieldInfoPtr_current, (void*) &current);
      return current;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AmbienceSystem.NativeFieldInfoPtr_current, (void*) &value);
    }
  }
}
