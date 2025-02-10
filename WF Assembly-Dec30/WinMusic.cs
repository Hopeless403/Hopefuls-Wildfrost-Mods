// Decompiled with JetBrains decompiler
// Type: WinMusic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using FMOD;
using FMOD.Studio;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
public class WinMusic : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_playOnStart;
  private static readonly IntPtr NativeFieldInfoPtr_musicEvent;
  private static readonly IntPtr NativeFieldInfoPtr_current;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_BackToMainMenu_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0;
  private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_StartMusic_Private_Void_GUID_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetEndParam_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetParam_Private_Void_String_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_IsRunning_Private_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101294, XrefRangeEnd = 101309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WinMusic.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101309, XrefRangeEnd = 101324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WinMusic.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101324, XrefRangeEnd = 101331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WinMusic.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101331, XrefRangeEnd = 101332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BackToMainMenu()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WinMusic.NativeMethodInfoPtr_BackToMainMenu_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SceneChanged(Scene scene)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &scene
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WinMusic.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 101333, RefRangeEnd = 101334, XrefRangeStart = 101332, XrefRangeEnd = 101333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Play()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WinMusic.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 101343, RefRangeEnd = 101345, XrefRangeStart = 101334, XrefRangeEnd = 101343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartMusic(GUID eventGUID)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &eventGUID
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WinMusic.NativeMethodInfoPtr_StartMusic_Private_Void_GUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 101350, RefRangeEnd = 101352, XrefRangeStart = 101345, XrefRangeEnd = 101350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetEndParam()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WinMusic.NativeMethodInfoPtr_SetEndParam_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101352, XrefRangeEnd = 101355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetParam(string name, float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WinMusic.NativeMethodInfoPtr_SetParam_Private_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101355, XrefRangeEnd = 101357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsRunning()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(WinMusic.NativeMethodInfoPtr_IsRunning_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WinMusic()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WinMusic>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WinMusic.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static WinMusic()
  {
    Il2CppClassPointerStore<WinMusic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (WinMusic));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WinMusic>.NativeClassPtr);
    WinMusic.NativeFieldInfoPtr_playOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WinMusic>.NativeClassPtr, nameof (playOnStart));
    WinMusic.NativeFieldInfoPtr_musicEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WinMusic>.NativeClassPtr, nameof (musicEvent));
    WinMusic.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WinMusic>.NativeClassPtr, nameof (current));
    WinMusic.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinMusic>.NativeClassPtr, 100672379);
    WinMusic.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinMusic>.NativeClassPtr, 100672380);
    WinMusic.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinMusic>.NativeClassPtr, 100672381);
    WinMusic.NativeMethodInfoPtr_BackToMainMenu_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinMusic>.NativeClassPtr, 100672382);
    WinMusic.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinMusic>.NativeClassPtr, 100672383);
    WinMusic.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinMusic>.NativeClassPtr, 100672384);
    WinMusic.NativeMethodInfoPtr_StartMusic_Private_Void_GUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinMusic>.NativeClassPtr, 100672385);
    WinMusic.NativeMethodInfoPtr_SetEndParam_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinMusic>.NativeClassPtr, 100672386);
    WinMusic.NativeMethodInfoPtr_SetParam_Private_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinMusic>.NativeClassPtr, 100672387);
    WinMusic.NativeMethodInfoPtr_IsRunning_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinMusic>.NativeClassPtr, 100672388);
    WinMusic.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinMusic>.NativeClassPtr, 100672389);
  }

  public WinMusic(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool playOnStart
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WinMusic.NativeFieldInfoPtr_playOnStart));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WinMusic.NativeFieldInfoPtr_playOnStart)) = value;
    }
  }

  public unsafe EventReference musicEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WinMusic.NativeFieldInfoPtr_musicEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WinMusic.NativeFieldInfoPtr_musicEvent)) = value;
    }
  }

  public unsafe EventInstance current
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WinMusic.NativeFieldInfoPtr_current));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WinMusic.NativeFieldInfoPtr_current)) = value;
    }
  }
}
