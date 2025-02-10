// Decompiled with JetBrains decompiler
// Type: MusicSystem
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
public class MusicSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instance;
  private static readonly System.IntPtr NativeFieldInfoPtr_music;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventMusic;
  private static readonly System.IntPtr NativeFieldInfoPtr_current;
  private static readonly System.IntPtr NativeFieldInfoPtr_fadePitchTween;
  private static readonly System.IntPtr NativeFieldInfoPtr_pitch;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartMusic_Public_Static_Void_EventReference_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartMusic_Private_Static_Void_GUID_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetParam_Public_Static_Void_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopMusic_Public_Static_Void_STOP_MODE_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FadePitchTo_Public_Static_Void_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsRunning_Private_Static_Boolean_EventInstance_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71621, XrefRangeEnd = 71635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71635, XrefRangeEnd = 71647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71647, XrefRangeEnd = 71667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SceneChanged(Scene from, Scene to)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71667, XrefRangeEnd = 71687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SceneChanged(Scene scene)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &scene
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 71691, RefRangeEnd = 71693, XrefRangeStart = 71687, XrefRangeEnd = 71691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void StartMusic(EventReference eventId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &eventId
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_StartMusic_Public_Static_Void_EventReference_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 71707, RefRangeEnd = 71710, XrefRangeStart = 71693, XrefRangeEnd = 71707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void StartMusic(GUID eventGUID)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &eventGUID
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_StartMusic_Private_Static_Void_GUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 71720, RefRangeEnd = 71722, XrefRangeStart = 71710, XrefRangeEnd = 71720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetParam(string name, float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_SetParam_Public_Static_Void_String_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 71734, RefRangeEnd = 71738, XrefRangeStart = 71722, XrefRangeEnd = 71734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void StopMusic(FMOD.Studio.STOP_MODE stopMode = FMOD.Studio.STOP_MODE.ALLOWFADEOUT)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &stopMode
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_StopMusic_Public_Static_Void_STOP_MODE_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 71770, RefRangeEnd = 71772, XrefRangeStart = 71738, XrefRangeEnd = 71770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void FadePitchTo(float value, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_FadePitchTo_Public_Static_Void_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsRunning(EventInstance instance)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &instance
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr_IsRunning_Private_Static_Boolean_EventInstance_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MusicSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MusicSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static MusicSystem()
  {
    Il2CppClassPointerStore<MusicSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (MusicSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr);
    MusicSystem.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, nameof (instance));
    MusicSystem.NativeFieldInfoPtr_music = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, nameof (music));
    MusicSystem.NativeFieldInfoPtr_eventMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, nameof (eventMusic));
    MusicSystem.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, nameof (current));
    MusicSystem.NativeFieldInfoPtr_fadePitchTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, nameof (fadePitchTween));
    MusicSystem.NativeFieldInfoPtr_pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, nameof (pitch));
    MusicSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100669172);
    MusicSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100669173);
    MusicSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100669174);
    MusicSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100669175);
    MusicSystem.NativeMethodInfoPtr_StartMusic_Public_Static_Void_EventReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100669176);
    MusicSystem.NativeMethodInfoPtr_StartMusic_Private_Static_Void_GUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100669177);
    MusicSystem.NativeMethodInfoPtr_SetParam_Public_Static_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100669178);
    MusicSystem.NativeMethodInfoPtr_StopMusic_Public_Static_Void_STOP_MODE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100669179);
    MusicSystem.NativeMethodInfoPtr_FadePitchTo_Public_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100669180);
    MusicSystem.NativeMethodInfoPtr_IsRunning_Private_Static_Boolean_EventInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100669181);
    MusicSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, 100669182);
  }

  public MusicSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe MusicSystem instance
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(MusicSystem.NativeFieldInfoPtr_instance, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (MusicSystem) null : new MusicSystem(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MusicSystem.NativeFieldInfoPtr_instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<MusicSystem.Music> music
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_music));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<MusicSystem.Music>) null : new Il2CppReferenceArray<MusicSystem.Music>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_music), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<MusicSystem.Music> eventMusic
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_eventMusic));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<MusicSystem.Music>) null : new Il2CppReferenceArray<MusicSystem.Music>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MusicSystem.NativeFieldInfoPtr_eventMusic), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe EventInstance current
  {
    get
    {
      EventInstance current;
      IL2CPP.il2cpp_field_static_get_value(MusicSystem.NativeFieldInfoPtr_current, (void*) &current);
      return current;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MusicSystem.NativeFieldInfoPtr_current, (void*) &value);
    }
  }

  public static unsafe LTDescr fadePitchTween
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(MusicSystem.NativeFieldInfoPtr_fadePitchTween, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MusicSystem.NativeFieldInfoPtr_fadePitchTween, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe float pitch
  {
    get
    {
      float pitch;
      IL2CPP.il2cpp_field_static_get_value(MusicSystem.NativeFieldInfoPtr_pitch, (void*) &pitch);
      return pitch;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MusicSystem.NativeFieldInfoPtr_pitch, (void*) &value);
    }
  }

  [Serializable]
  public class Music : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_sceneName;
    private static readonly System.IntPtr NativeFieldInfoPtr_eventId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Music()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicSystem.Music>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MusicSystem.Music.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Music()
    {
      Il2CppClassPointerStore<MusicSystem.Music>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, nameof (Music));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicSystem.Music>.NativeClassPtr);
      MusicSystem.Music.NativeFieldInfoPtr_sceneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem.Music>.NativeClassPtr, nameof (sceneName));
      MusicSystem.Music.NativeFieldInfoPtr_eventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem.Music>.NativeClassPtr, nameof (eventId));
      MusicSystem.Music.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem.Music>.NativeClassPtr, 100669184);
    }

    public Music(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string sceneName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicSystem.Music.NativeFieldInfoPtr_sceneName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MusicSystem.Music.NativeFieldInfoPtr_sceneName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe EventReference eventId
    {
      get
      {
        return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicSystem.Music.NativeFieldInfoPtr_eventId));
      }
      [param: In] set
      {
        *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicSystem.Music.NativeFieldInfoPtr_eventId)) = value;
      }
    }
  }

  [ObfuscatedName("MusicSystem/<>c__DisplayClass10_0")]
  public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_scene;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SceneChanged_b__0_Internal_Boolean_Music_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass10_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicSystem.__c__DisplayClass10_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MusicSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _SceneChanged_b__0(MusicSystem.Music a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MusicSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__SceneChanged_b__0_Internal_Boolean_Music_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass10_0()
    {
      Il2CppClassPointerStore<MusicSystem.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "<>c__DisplayClass10_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicSystem.__c__DisplayClass10_0>.NativeClassPtr);
      MusicSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_scene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (scene));
      MusicSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem.__c__DisplayClass10_0>.NativeClassPtr, 100669185);
      MusicSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__SceneChanged_b__0_Internal_Boolean_Music_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem.__c__DisplayClass10_0>.NativeClassPtr, 100669186);
    }

    public __c__DisplayClass10_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Scene scene
    {
      get
      {
        return *(Scene*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_scene));
      }
      [param: In] set
      {
        *(Scene*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_scene)) = value;
      }
    }
  }

  [ObfuscatedName("MusicSystem/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__15_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__FadePitchTo_b__15_0_Internal_Void_Single_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicSystem.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MusicSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71610, XrefRangeEnd = 71621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _FadePitchTo_b__15_0(float a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &a
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MusicSystem.__c.NativeMethodInfoPtr__FadePitchTo_b__15_0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c()
    {
      Il2CppClassPointerStore<MusicSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicSystem>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicSystem.__c>.NativeClassPtr);
      MusicSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem.__c>.NativeClassPtr, "<>9");
      MusicSystem.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSystem.__c>.NativeClassPtr, "<>9__15_0");
      MusicSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem.__c>.NativeClassPtr, 100669188);
      MusicSystem.__c.NativeMethodInfoPtr__FadePitchTo_b__15_0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSystem.__c>.NativeClassPtr, 100669189);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe MusicSystem.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(MusicSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (MusicSystem.__c) null : new MusicSystem.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MusicSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<float> __9__15_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(MusicSystem.__c.NativeFieldInfoPtr___9__15_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<float>) null : new Il2CppSystem.Action<float>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MusicSystem.__c.NativeFieldInfoPtr___9__15_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
