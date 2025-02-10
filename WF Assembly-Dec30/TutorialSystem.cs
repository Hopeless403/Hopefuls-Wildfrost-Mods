// Decompiled with JetBrains decompiler
// Type: TutorialSystem
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
using UnityEngine.SceneManagement;

#nullable disable
public class TutorialSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_redrawBellHelpKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_redrawBellHelpEmote;
  private static readonly System.IntPtr NativeFieldInfoPtr_redrawBellHelpButtonKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_redrawBellHelpSprite;
  private static readonly System.IntPtr NativeFieldInfoPtr_data;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CampaignSaved_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CampaignLoaded_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80551, XrefRangeEnd = 80572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80572, XrefRangeEnd = 80593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80593, XrefRangeEnd = 80622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SceneChanged(Scene scene)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &scene
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80622, XrefRangeEnd = 80633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CampaignSaved()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialSystem.NativeMethodInfoPtr_CampaignSaved_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80633, XrefRangeEnd = 80643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CampaignLoaded()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialSystem.NativeMethodInfoPtr_CampaignLoaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TutorialSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TutorialSystem()
  {
    Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TutorialSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr);
    TutorialSystem.NativeFieldInfoPtr_redrawBellHelpKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, nameof (redrawBellHelpKey));
    TutorialSystem.NativeFieldInfoPtr_redrawBellHelpEmote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, nameof (redrawBellHelpEmote));
    TutorialSystem.NativeFieldInfoPtr_redrawBellHelpButtonKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, nameof (redrawBellHelpButtonKey));
    TutorialSystem.NativeFieldInfoPtr_redrawBellHelpSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, nameof (redrawBellHelpSprite));
    TutorialSystem.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, nameof (data));
    TutorialSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, 100669913);
    TutorialSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, 100669914);
    TutorialSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, 100669915);
    TutorialSystem.NativeMethodInfoPtr_CampaignSaved_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, 100669916);
    TutorialSystem.NativeMethodInfoPtr_CampaignLoaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, 100669917);
    TutorialSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, 100669918);
  }

  public TutorialSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LocalizedString redrawBellHelpKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr_redrawBellHelpKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr_redrawBellHelpKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Prompt.Emote.Type redrawBellHelpEmote
  {
    get
    {
      return *(Prompt.Emote.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr_redrawBellHelpEmote));
    }
    [param: In] set
    {
      *(Prompt.Emote.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr_redrawBellHelpEmote)) = value;
    }
  }

  public unsafe LocalizedString redrawBellHelpButtonKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr_redrawBellHelpButtonKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr_redrawBellHelpButtonKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite redrawBellHelpSprite
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr_redrawBellHelpSprite));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr_redrawBellHelpSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TutorialSystem.Data data
  {
    get
    {
      return *(TutorialSystem.Data*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr_data));
    }
    [param: In] set
    {
      *(TutorialSystem.Data*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialSystem.NativeFieldInfoPtr_data)) = value;
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct Data
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_battleNumber;
    private static readonly System.IntPtr NativeFieldInfoPtr_eventNumber;
    [FieldOffset(0)]
    public int battleNumber;
    [FieldOffset(4)]
    public int eventNumber;

    static Data()
    {
      Il2CppClassPointerStore<TutorialSystem.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialSystem>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialSystem.Data>.NativeClassPtr);
      TutorialSystem.Data.NativeFieldInfoPtr_battleNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.Data>.NativeClassPtr, nameof (battleNumber));
      TutorialSystem.Data.NativeFieldInfoPtr_eventNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSystem.Data>.NativeClassPtr, nameof (eventNumber));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TutorialSystem.Data>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
