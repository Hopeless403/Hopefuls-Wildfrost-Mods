// Decompiled with JetBrains decompiler
// Type: GameModifierData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class GameModifierData : DataFile
{
  private static readonly IntPtr NativeFieldInfoPtr_value;
  private static readonly IntPtr NativeFieldInfoPtr_visible;
  private static readonly IntPtr NativeFieldInfoPtr_bellSprite;
  private static readonly IntPtr NativeFieldInfoPtr_dingerSprite;
  private static readonly IntPtr NativeFieldInfoPtr_titleKey;
  private static readonly IntPtr NativeFieldInfoPtr_descriptionKey;
  private static readonly IntPtr NativeFieldInfoPtr_systemsToAdd;
  private static readonly IntPtr NativeFieldInfoPtr_setupScripts;
  private static readonly IntPtr NativeFieldInfoPtr_startScripts;
  private static readonly IntPtr NativeFieldInfoPtr_scriptPriority;
  private static readonly IntPtr NativeFieldInfoPtr_blockedBy;
  private static readonly IntPtr NativeFieldInfoPtr_linkedStormBell;
  private static readonly IntPtr NativeFieldInfoPtr_ringSfxEvent;
  private static readonly IntPtr NativeFieldInfoPtr_ringSfxPitch;
  private static readonly IntPtr NativeMethodInfoPtr_PlayRingSfx_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 109507, RefRangeEnd = 109508, XrefRangeStart = 109499, XrefRangeEnd = 109507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlayRingSfx()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GameModifierData.NativeMethodInfoPtr_PlayRingSfx_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109508, XrefRangeEnd = 109509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GameModifierData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameModifierData>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GameModifierData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static GameModifierData()
  {
    Il2CppClassPointerStore<GameModifierData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (GameModifierData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameModifierData>.NativeClassPtr);
    GameModifierData.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameModifierData>.NativeClassPtr, nameof (value));
    GameModifierData.NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameModifierData>.NativeClassPtr, nameof (visible));
    GameModifierData.NativeFieldInfoPtr_bellSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameModifierData>.NativeClassPtr, nameof (bellSprite));
    GameModifierData.NativeFieldInfoPtr_dingerSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameModifierData>.NativeClassPtr, nameof (dingerSprite));
    GameModifierData.NativeFieldInfoPtr_titleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameModifierData>.NativeClassPtr, nameof (titleKey));
    GameModifierData.NativeFieldInfoPtr_descriptionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameModifierData>.NativeClassPtr, nameof (descriptionKey));
    GameModifierData.NativeFieldInfoPtr_systemsToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameModifierData>.NativeClassPtr, nameof (systemsToAdd));
    GameModifierData.NativeFieldInfoPtr_setupScripts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameModifierData>.NativeClassPtr, nameof (setupScripts));
    GameModifierData.NativeFieldInfoPtr_startScripts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameModifierData>.NativeClassPtr, nameof (startScripts));
    GameModifierData.NativeFieldInfoPtr_scriptPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameModifierData>.NativeClassPtr, nameof (scriptPriority));
    GameModifierData.NativeFieldInfoPtr_blockedBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameModifierData>.NativeClassPtr, nameof (blockedBy));
    GameModifierData.NativeFieldInfoPtr_linkedStormBell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameModifierData>.NativeClassPtr, nameof (linkedStormBell));
    GameModifierData.NativeFieldInfoPtr_ringSfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameModifierData>.NativeClassPtr, nameof (ringSfxEvent));
    GameModifierData.NativeFieldInfoPtr_ringSfxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameModifierData>.NativeClassPtr, nameof (ringSfxPitch));
    GameModifierData.NativeMethodInfoPtr_PlayRingSfx_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameModifierData>.NativeClassPtr, 100673392);
    GameModifierData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameModifierData>.NativeClassPtr, 100673393);
  }

  public GameModifierData(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int value
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_value));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_value)) = value;
    }
  }

  public unsafe bool visible
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_visible));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_visible)) = value;
    }
  }

  public unsafe Sprite bellSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_bellSprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_bellSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite dingerSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_dingerSprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_dingerSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString titleKey
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_titleKey));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_titleKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString descriptionKey
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_descriptionKey));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_descriptionKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStringArray systemsToAdd
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_systemsToAdd));
      return pointer == IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_systemsToAdd), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Script> setupScripts
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_setupScripts));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Script>) null : new Il2CppReferenceArray<Script>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_setupScripts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Script> startScripts
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_startScripts));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Script>) null : new Il2CppReferenceArray<Script>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_startScripts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int scriptPriority
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_scriptPriority));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_scriptPriority)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<GameModifierData> blockedBy
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_blockedBy));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<GameModifierData>) null : new Il2CppReferenceArray<GameModifierData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_blockedBy), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe HardModeModifierData linkedStormBell
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_linkedStormBell));
      return pointer == IntPtr.Zero ? (HardModeModifierData) null : new HardModeModifierData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_linkedStormBell), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference ringSfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_ringSfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_ringSfxEvent)) = value;
    }
  }

  public unsafe Vector2 ringSfxPitch
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_ringSfxPitch));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameModifierData.NativeFieldInfoPtr_ringSfxPitch)) = value;
    }
  }
}
