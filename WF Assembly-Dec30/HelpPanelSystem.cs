// Decompiled with JetBrains decompiler
// Type: HelpPanelSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.UI;

#nullable disable
public class HelpPanelSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr__instance;
  private static readonly System.IntPtr NativeFieldInfoPtr__rtCamera;
  private static readonly System.IntPtr NativeFieldInfoPtr_title;
  private static readonly System.IntPtr NativeFieldInfoPtr_body;
  private static readonly System.IntPtr NativeFieldInfoPtr_note;
  private static readonly System.IntPtr NativeFieldInfoPtr_image;
  private static readonly System.IntPtr NativeFieldInfoPtr_imageLayout;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttonGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_backButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttonPrefabs;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttonProfileLookup;
  private static readonly System.IntPtr NativeFieldInfoPtr_emote;
  private static readonly System.IntPtr NativeFieldInfoPtr_emoteTypes;
  private static readonly System.IntPtr NativeFieldInfoPtr_popUpSfx;
  private static readonly System.IntPtr NativeFieldInfoPtr_Active;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_instance_Private_Static_get_HelpPanelSystem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_rtCamera_Private_Static_get_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetBackButtonActive_Public_Static_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Static_Void_LocalizedString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetEmote_Public_Static_Void_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddButton_Public_Static_Void_ButtonType_LocalizedString_String_UnityAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetImage_Public_Static_Void_Single_Single_Sprite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public static unsafe HelpPanelSystem instance
  {
    [CallerCount(17), CachedScanResults(RefRangeStart = 60388, RefRangeEnd = 60405, XrefRangeStart = 60373, XrefRangeEnd = 60388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HelpPanelSystem.NativeMethodInfoPtr_get_instance_Private_Static_get_HelpPanelSystem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (HelpPanelSystem) null : new HelpPanelSystem(pointer);
    }
  }

  public static unsafe GameObject rtCamera
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 60439, RefRangeEnd = 60441, XrefRangeStart = 60405, XrefRangeEnd = 60439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HelpPanelSystem.NativeMethodInfoPtr_get_rtCamera_Private_Static_get_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60441, XrefRangeEnd = 60455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HelpPanelSystem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60455, XrefRangeEnd = 60462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HelpPanelSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60462, XrefRangeEnd = 60493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HelpPanelSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 60499, RefRangeEnd = 60503, XrefRangeStart = 60493, XrefRangeEnd = 60499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetBackButtonActive(bool active)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &active
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HelpPanelSystem.NativeMethodInfoPtr_SetBackButtonActive_Public_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 60554, RefRangeEnd = 60558, XrefRangeStart = 60503, XrefRangeEnd = 60554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Show(LocalizedString key)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) key)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HelpPanelSystem.NativeMethodInfoPtr_Show_Public_Static_Void_LocalizedString_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 60578, RefRangeEnd = 60582, XrefRangeStart = 60558, XrefRangeEnd = 60578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetEmote(Prompt.Emote.Type emoteType)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &emoteType
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HelpPanelSystem.NativeMethodInfoPtr_SetEmote_Public_Static_Void_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 60626, RefRangeEnd = 60630, XrefRangeStart = 60582, XrefRangeEnd = 60626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddButton(
    HelpPanelSystem.ButtonType type,
    LocalizedString textKey,
    string hotKey,
    UnityAction onSelect)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &type;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) textKey);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(hotKey);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onSelect);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HelpPanelSystem.NativeMethodInfoPtr_AddButton_Public_Static_Void_ButtonType_LocalizedString_String_UnityAction_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 60641, RefRangeEnd = 60644, XrefRangeStart = 60630, XrefRangeEnd = 60641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetImage(float width, float height, Sprite sprite)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HelpPanelSystem.NativeMethodInfoPtr_SetImage_Public_Static_Void_Single_Single_Sprite_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HelpPanelSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HelpPanelSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static HelpPanelSystem()
  {
    Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (HelpPanelSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr);
    HelpPanelSystem.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, nameof (_instance));
    HelpPanelSystem.NativeFieldInfoPtr__rtCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, nameof (_rtCamera));
    HelpPanelSystem.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, nameof (title));
    HelpPanelSystem.NativeFieldInfoPtr_body = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, nameof (body));
    HelpPanelSystem.NativeFieldInfoPtr_note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, nameof (note));
    HelpPanelSystem.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, nameof (image));
    HelpPanelSystem.NativeFieldInfoPtr_imageLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, nameof (imageLayout));
    HelpPanelSystem.NativeFieldInfoPtr_buttonGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, nameof (buttonGroup));
    HelpPanelSystem.NativeFieldInfoPtr_backButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, nameof (backButton));
    HelpPanelSystem.NativeFieldInfoPtr_buttonPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, nameof (buttonPrefabs));
    HelpPanelSystem.NativeFieldInfoPtr_buttonProfileLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, nameof (buttonProfileLookup));
    HelpPanelSystem.NativeFieldInfoPtr_emote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, nameof (emote));
    HelpPanelSystem.NativeFieldInfoPtr_emoteTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, nameof (emoteTypes));
    HelpPanelSystem.NativeFieldInfoPtr_popUpSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, nameof (popUpSfx));
    HelpPanelSystem.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, nameof (Active));
    HelpPanelSystem.NativeMethodInfoPtr_get_instance_Private_Static_get_HelpPanelSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, 100668230);
    HelpPanelSystem.NativeMethodInfoPtr_get_rtCamera_Private_Static_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, 100668231);
    HelpPanelSystem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, 100668232);
    HelpPanelSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, 100668233);
    HelpPanelSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, 100668234);
    HelpPanelSystem.NativeMethodInfoPtr_SetBackButtonActive_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, 100668235);
    HelpPanelSystem.NativeMethodInfoPtr_Show_Public_Static_Void_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, 100668236);
    HelpPanelSystem.NativeMethodInfoPtr_SetEmote_Public_Static_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, 100668237);
    HelpPanelSystem.NativeMethodInfoPtr_AddButton_Public_Static_Void_ButtonType_LocalizedString_String_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, 100668238);
    HelpPanelSystem.NativeMethodInfoPtr_SetImage_Public_Static_Void_Single_Single_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, 100668239);
    HelpPanelSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, 100668240);
  }

  public HelpPanelSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe HelpPanelSystem _instance
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(HelpPanelSystem.NativeFieldInfoPtr__instance, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (HelpPanelSystem) null : new HelpPanelSystem(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(HelpPanelSystem.NativeFieldInfoPtr__instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe GameObject _rtCamera
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(HelpPanelSystem.NativeFieldInfoPtr__rtCamera, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(HelpPanelSystem.NativeFieldInfoPtr__rtCamera, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text title
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.NativeFieldInfoPtr_title));
      return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.NativeFieldInfoPtr_title), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text body
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.NativeFieldInfoPtr_body));
      return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.NativeFieldInfoPtr_body), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text note
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.NativeFieldInfoPtr_note));
      return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.NativeFieldInfoPtr_note), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ImageSprite image
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.NativeFieldInfoPtr_image));
      return pointer == System.IntPtr.Zero ? (ImageSprite) null : new ImageSprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LayoutElement imageLayout
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.NativeFieldInfoPtr_imageLayout));
      return pointer == System.IntPtr.Zero ? (LayoutElement) null : new LayoutElement(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.NativeFieldInfoPtr_imageLayout), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform buttonGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.NativeFieldInfoPtr_buttonGroup));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.NativeFieldInfoPtr_buttonGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject backButton
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.NativeFieldInfoPtr_backButton));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.NativeFieldInfoPtr_backButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<HelpPanelSystem.ButtonProfile> buttonPrefabs
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.NativeFieldInfoPtr_buttonPrefabs));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<HelpPanelSystem.ButtonProfile>) null : new Il2CppReferenceArray<HelpPanelSystem.ButtonProfile>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.NativeFieldInfoPtr_buttonPrefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<HelpPanelSystem.ButtonType, HelpPanelSystem.ButtonProfile> buttonProfileLookup
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(HelpPanelSystem.NativeFieldInfoPtr_buttonProfileLookup, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<HelpPanelSystem.ButtonType, HelpPanelSystem.ButtonProfile>) null : new Dictionary<HelpPanelSystem.ButtonType, HelpPanelSystem.ButtonProfile>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(HelpPanelSystem.NativeFieldInfoPtr_buttonProfileLookup, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image emote
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.NativeFieldInfoPtr_emote));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.NativeFieldInfoPtr_emote), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Prompt.Emote> emoteTypes
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.NativeFieldInfoPtr_emoteTypes));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Prompt.Emote>) null : new Il2CppReferenceArray<Prompt.Emote>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.NativeFieldInfoPtr_emoteTypes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference popUpSfx
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.NativeFieldInfoPtr_popUpSfx));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.NativeFieldInfoPtr_popUpSfx)) = value;
    }
  }

  public static unsafe bool Active
  {
    get
    {
      bool active;
      IL2CPP.il2cpp_field_static_get_value(HelpPanelSystem.NativeFieldInfoPtr_Active, (void*) &active);
      return active;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(HelpPanelSystem.NativeFieldInfoPtr_Active, (void*) &value);
    }
  }

  [Serializable]
  public sealed class ButtonProfile : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_type;
    private static readonly System.IntPtr NativeFieldInfoPtr_prefab;

    static ButtonProfile()
    {
      Il2CppClassPointerStore<HelpPanelSystem.ButtonProfile>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, nameof (ButtonProfile));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HelpPanelSystem.ButtonProfile>.NativeClassPtr);
      HelpPanelSystem.ButtonProfile.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelSystem.ButtonProfile>.NativeClassPtr, nameof (type));
      HelpPanelSystem.ButtonProfile.NativeFieldInfoPtr_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelSystem.ButtonProfile>.NativeClassPtr, nameof (prefab));
    }

    public ButtonProfile(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ButtonProfile()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HelpPanelSystem.ButtonProfile>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HelpPanelSystem.ButtonProfile>.NativeClassPtr, data));
    }

    public unsafe HelpPanelSystem.ButtonType type
    {
      get
      {
        return *(HelpPanelSystem.ButtonType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.ButtonProfile.NativeFieldInfoPtr_type));
      }
      [param: In] set
      {
        *(HelpPanelSystem.ButtonType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.ButtonProfile.NativeFieldInfoPtr_type)) = value;
      }
    }

    public unsafe GameObject prefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.ButtonProfile.NativeFieldInfoPtr_prefab));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.ButtonProfile.NativeFieldInfoPtr_prefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public enum ButtonType
  {
    Positive,
    Negative,
  }

  [ObfuscatedName("HelpPanelSystem/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__5_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__25_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_rtCamera_b__5_0_Internal_Boolean_Camera_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__AddButton_b__25_0_Internal_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HelpPanelSystem.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HelpPanelSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60361, XrefRangeEnd = 60366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _get_rtCamera_b__5_0(Camera a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HelpPanelSystem.__c.NativeMethodInfoPtr__get_rtCamera_b__5_0_Internal_Boolean_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60366, XrefRangeEnd = 60373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _AddButton_b__25_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HelpPanelSystem.__c.NativeMethodInfoPtr__AddButton_b__25_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c()
    {
      Il2CppClassPointerStore<HelpPanelSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HelpPanelSystem.__c>.NativeClassPtr);
      HelpPanelSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelSystem.__c>.NativeClassPtr, "<>9");
      HelpPanelSystem.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelSystem.__c>.NativeClassPtr, "<>9__5_0");
      HelpPanelSystem.__c.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelSystem.__c>.NativeClassPtr, "<>9__25_0");
      HelpPanelSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpPanelSystem.__c>.NativeClassPtr, 100668243);
      HelpPanelSystem.__c.NativeMethodInfoPtr__get_rtCamera_b__5_0_Internal_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpPanelSystem.__c>.NativeClassPtr, 100668244);
      HelpPanelSystem.__c.NativeMethodInfoPtr__AddButton_b__25_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpPanelSystem.__c>.NativeClassPtr, 100668245);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe HelpPanelSystem.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(HelpPanelSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (HelpPanelSystem.__c) null : new HelpPanelSystem.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HelpPanelSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Camera, bool> __9__5_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(HelpPanelSystem.__c.NativeFieldInfoPtr___9__5_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Camera, bool>) null : new Il2CppSystem.Func<Camera, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HelpPanelSystem.__c.NativeFieldInfoPtr___9__5_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe UnityAction __9__25_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(HelpPanelSystem.__c.NativeFieldInfoPtr___9__25_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (UnityAction) null : new UnityAction(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HelpPanelSystem.__c.NativeFieldInfoPtr___9__25_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("HelpPanelSystem/<>c__DisplayClass24_0")]
  public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_emoteType;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetEmote_b__0_Internal_Boolean_Emote_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass24_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HelpPanelSystem.__c__DisplayClass24_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HelpPanelSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _SetEmote_b__0(Prompt.Emote a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a))
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HelpPanelSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__SetEmote_b__0_Internal_Boolean_Emote_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass24_0()
    {
      Il2CppClassPointerStore<HelpPanelSystem.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HelpPanelSystem>.NativeClassPtr, "<>c__DisplayClass24_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HelpPanelSystem.__c__DisplayClass24_0>.NativeClassPtr);
      HelpPanelSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_emoteType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelSystem.__c__DisplayClass24_0>.NativeClassPtr, nameof (emoteType));
      HelpPanelSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpPanelSystem.__c__DisplayClass24_0>.NativeClassPtr, 100668246);
      HelpPanelSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__SetEmote_b__0_Internal_Boolean_Emote_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpPanelSystem.__c__DisplayClass24_0>.NativeClassPtr, 100668247);
    }

    public __c__DisplayClass24_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Prompt.Emote.Type emoteType
    {
      get
      {
        return *(Prompt.Emote.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_emoteType));
      }
      [param: In] set
      {
        *(Prompt.Emote.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_emoteType)) = value;
      }
    }
  }
}
