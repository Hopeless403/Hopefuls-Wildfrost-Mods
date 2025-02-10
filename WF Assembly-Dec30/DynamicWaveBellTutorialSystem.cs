// Decompiled with JetBrains decompiler
// Type: DynamicWaveBellTutorialSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class DynamicWaveBellTutorialSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_helpKey;
  private static readonly IntPtr NativeFieldInfoPtr_emote;
  private static readonly IntPtr NativeFieldInfoPtr_buttonKey;
  private static readonly IntPtr NativeFieldInfoPtr_helpSprite;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_WaveDeployerCountDown_Private_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_ShowHelp_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_End_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77628, XrefRangeEnd = 77644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DynamicWaveBellTutorialSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77644, XrefRangeEnd = 77652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DynamicWaveBellTutorialSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77652, XrefRangeEnd = 77672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void WaveDeployerCountDown(int counter)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &counter
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DynamicWaveBellTutorialSystem.NativeMethodInfoPtr_WaveDeployerCountDown_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77672, XrefRangeEnd = 77688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowHelp()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DynamicWaveBellTutorialSystem.NativeMethodInfoPtr_ShowHelp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77688, XrefRangeEnd = 77697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void End()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DynamicWaveBellTutorialSystem.NativeMethodInfoPtr_End_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77697, XrefRangeEnd = 77698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DynamicWaveBellTutorialSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicWaveBellTutorialSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DynamicWaveBellTutorialSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static DynamicWaveBellTutorialSystem()
  {
    Il2CppClassPointerStore<DynamicWaveBellTutorialSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (DynamicWaveBellTutorialSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicWaveBellTutorialSystem>.NativeClassPtr);
    DynamicWaveBellTutorialSystem.NativeFieldInfoPtr_helpKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicWaveBellTutorialSystem>.NativeClassPtr, nameof (helpKey));
    DynamicWaveBellTutorialSystem.NativeFieldInfoPtr_emote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicWaveBellTutorialSystem>.NativeClassPtr, nameof (emote));
    DynamicWaveBellTutorialSystem.NativeFieldInfoPtr_buttonKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicWaveBellTutorialSystem>.NativeClassPtr, nameof (buttonKey));
    DynamicWaveBellTutorialSystem.NativeFieldInfoPtr_helpSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicWaveBellTutorialSystem>.NativeClassPtr, nameof (helpSprite));
    DynamicWaveBellTutorialSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicWaveBellTutorialSystem>.NativeClassPtr, 100669547);
    DynamicWaveBellTutorialSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicWaveBellTutorialSystem>.NativeClassPtr, 100669548);
    DynamicWaveBellTutorialSystem.NativeMethodInfoPtr_WaveDeployerCountDown_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicWaveBellTutorialSystem>.NativeClassPtr, 100669549);
    DynamicWaveBellTutorialSystem.NativeMethodInfoPtr_ShowHelp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicWaveBellTutorialSystem>.NativeClassPtr, 100669550);
    DynamicWaveBellTutorialSystem.NativeMethodInfoPtr_End_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicWaveBellTutorialSystem>.NativeClassPtr, 100669551);
    DynamicWaveBellTutorialSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicWaveBellTutorialSystem>.NativeClassPtr, 100669552);
  }

  public DynamicWaveBellTutorialSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LocalizedString helpKey
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicWaveBellTutorialSystem.NativeFieldInfoPtr_helpKey));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DynamicWaveBellTutorialSystem.NativeFieldInfoPtr_helpKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Prompt.Emote.Type emote
  {
    get
    {
      return *(Prompt.Emote.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicWaveBellTutorialSystem.NativeFieldInfoPtr_emote));
    }
    [param: In] set
    {
      *(Prompt.Emote.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicWaveBellTutorialSystem.NativeFieldInfoPtr_emote)) = value;
    }
  }

  public unsafe LocalizedString buttonKey
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicWaveBellTutorialSystem.NativeFieldInfoPtr_buttonKey));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DynamicWaveBellTutorialSystem.NativeFieldInfoPtr_buttonKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite helpSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DynamicWaveBellTutorialSystem.NativeFieldInfoPtr_helpSprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DynamicWaveBellTutorialSystem.NativeFieldInfoPtr_helpSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
