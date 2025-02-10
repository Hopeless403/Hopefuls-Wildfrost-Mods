// Decompiled with JetBrains decompiler
// Type: AreaData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AddressableAssets;

#nullable disable
public class AreaData : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_battleMusicEvent;
  private static readonly IntPtr NativeFieldInfoPtr_minibossMusicEvent;
  private static readonly IntPtr NativeFieldInfoPtr_bossMusicEvent;
  private static readonly IntPtr NativeFieldInfoPtr_ambienceEvent;
  private static readonly IntPtr NativeFieldInfoPtr_battleBackgroundPrefabRef;
  private static readonly IntPtr NativeFieldInfoPtr_battleBaseSprite;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104607, XrefRangeEnd = 104608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AreaData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AreaData>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AreaData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static AreaData()
  {
    Il2CppClassPointerStore<AreaData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (AreaData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AreaData>.NativeClassPtr);
    AreaData.NativeFieldInfoPtr_battleMusicEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, nameof (battleMusicEvent));
    AreaData.NativeFieldInfoPtr_minibossMusicEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, nameof (minibossMusicEvent));
    AreaData.NativeFieldInfoPtr_bossMusicEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, nameof (bossMusicEvent));
    AreaData.NativeFieldInfoPtr_ambienceEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, nameof (ambienceEvent));
    AreaData.NativeFieldInfoPtr_battleBackgroundPrefabRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, nameof (battleBackgroundPrefabRef));
    AreaData.NativeFieldInfoPtr_battleBaseSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaData>.NativeClassPtr, nameof (battleBaseSprite));
    AreaData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaData>.NativeClassPtr, 100672775);
  }

  public AreaData(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe EventReference battleMusicEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AreaData.NativeFieldInfoPtr_battleMusicEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AreaData.NativeFieldInfoPtr_battleMusicEvent)) = value;
    }
  }

  public unsafe EventReference minibossMusicEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AreaData.NativeFieldInfoPtr_minibossMusicEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AreaData.NativeFieldInfoPtr_minibossMusicEvent)) = value;
    }
  }

  public unsafe EventReference bossMusicEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AreaData.NativeFieldInfoPtr_bossMusicEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AreaData.NativeFieldInfoPtr_bossMusicEvent)) = value;
    }
  }

  public unsafe EventReference ambienceEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AreaData.NativeFieldInfoPtr_ambienceEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AreaData.NativeFieldInfoPtr_ambienceEvent)) = value;
    }
  }

  public unsafe AssetReferenceGameObject battleBackgroundPrefabRef
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AreaData.NativeFieldInfoPtr_battleBackgroundPrefabRef));
      return pointer == IntPtr.Zero ? (AssetReferenceGameObject) null : new AssetReferenceGameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AreaData.NativeFieldInfoPtr_battleBackgroundPrefabRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite battleBaseSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AreaData.NativeFieldInfoPtr_battleBaseSprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AreaData.NativeFieldInfoPtr_battleBaseSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
