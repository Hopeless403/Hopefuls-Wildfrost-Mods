// Decompiled with JetBrains decompiler
// Type: SfxLoop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using FMOD.Studio;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class SfxLoop : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_onEnable;
  private static readonly System.IntPtr NativeFieldInfoPtr_useAreaAmbience;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventRef;
  private static readonly System.IntPtr NativeFieldInfoPtr_params;
  private static readonly System.IntPtr NativeFieldInfoPtr_loop;
  private static readonly System.IntPtr NativeFieldInfoPtr_playing;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_e_Private_get_EventReference_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetParam_Public_Void_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetParam_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe EventReference e
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53547, XrefRangeEnd = 53548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SfxLoop.NativeMethodInfoPtr_get_e_Private_get_EventReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EventReference*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53548, XrefRangeEnd = 53559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxLoop.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 53566, RefRangeEnd = 53572, XrefRangeStart = 53559, XrefRangeEnd = 53566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxLoop.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 53583, RefRangeEnd = 53587, XrefRangeStart = 53572, XrefRangeEnd = 53583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Play()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxLoop.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 53566, RefRangeEnd = 53572, XrefRangeStart = 53566, XrefRangeEnd = 53572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Stop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxLoop.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53587, XrefRangeEnd = 53591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetParam(string name, float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxLoop.NativeMethodInfoPtr_SetParam_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53591, XrefRangeEnd = 53595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetParam(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxLoop.NativeMethodInfoPtr_SetParam_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SfxLoop()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SfxLoop>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxLoop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SfxLoop()
  {
    Il2CppClassPointerStore<SfxLoop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SfxLoop));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SfxLoop>.NativeClassPtr);
    SfxLoop.NativeFieldInfoPtr_onEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxLoop>.NativeClassPtr, nameof (onEnable));
    SfxLoop.NativeFieldInfoPtr_useAreaAmbience = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxLoop>.NativeClassPtr, nameof (useAreaAmbience));
    SfxLoop.NativeFieldInfoPtr_eventRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxLoop>.NativeClassPtr, nameof (eventRef));
    SfxLoop.NativeFieldInfoPtr_params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxLoop>.NativeClassPtr, nameof (@params));
    SfxLoop.NativeFieldInfoPtr_loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxLoop>.NativeClassPtr, nameof (loop));
    SfxLoop.NativeFieldInfoPtr_playing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxLoop>.NativeClassPtr, nameof (playing));
    SfxLoop.NativeMethodInfoPtr_get_e_Private_get_EventReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxLoop>.NativeClassPtr, 100667662);
    SfxLoop.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxLoop>.NativeClassPtr, 100667663);
    SfxLoop.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxLoop>.NativeClassPtr, 100667664);
    SfxLoop.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxLoop>.NativeClassPtr, 100667665);
    SfxLoop.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxLoop>.NativeClassPtr, 100667666);
    SfxLoop.NativeMethodInfoPtr_SetParam_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxLoop>.NativeClassPtr, 100667667);
    SfxLoop.NativeMethodInfoPtr_SetParam_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxLoop>.NativeClassPtr, 100667668);
    SfxLoop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxLoop>.NativeClassPtr, 100667669);
  }

  public SfxLoop(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool onEnable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxLoop.NativeFieldInfoPtr_onEnable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxLoop.NativeFieldInfoPtr_onEnable)) = value;
    }
  }

  public unsafe bool useAreaAmbience
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxLoop.NativeFieldInfoPtr_useAreaAmbience));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxLoop.NativeFieldInfoPtr_useAreaAmbience)) = value;
    }
  }

  public unsafe EventReference eventRef
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxLoop.NativeFieldInfoPtr_eventRef));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxLoop.NativeFieldInfoPtr_eventRef)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<SfxLoop.Param> @params
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxLoop.NativeFieldInfoPtr_params));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SfxLoop.Param>) null : new Il2CppReferenceArray<SfxLoop.Param>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SfxLoop.NativeFieldInfoPtr_params), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventInstance loop
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxLoop.NativeFieldInfoPtr_loop));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxLoop.NativeFieldInfoPtr_loop)) = value;
    }
  }

  public unsafe bool playing
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxLoop.NativeFieldInfoPtr_playing));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxLoop.NativeFieldInfoPtr_playing)) = value;
    }
  }

  [Serializable]
  public sealed class Param : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_value;

    static Param()
    {
      Il2CppClassPointerStore<SfxLoop.Param>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SfxLoop>.NativeClassPtr, nameof (Param));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SfxLoop.Param>.NativeClassPtr);
      SfxLoop.Param.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxLoop.Param>.NativeClassPtr, nameof (name));
      SfxLoop.Param.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxLoop.Param>.NativeClassPtr, nameof (value));
    }

    public Param(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Param()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SfxLoop.Param>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SfxLoop.Param>.NativeClassPtr, data));
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxLoop.Param.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SfxLoop.Param.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe float value
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxLoop.Param.NativeFieldInfoPtr_value));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxLoop.Param.NativeFieldInfoPtr_value)) = value;
      }
    }
  }
}
