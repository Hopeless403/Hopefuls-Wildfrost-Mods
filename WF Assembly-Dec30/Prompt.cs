// Decompiled with JetBrains decompiler
// Type: Prompt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class Prompt : MonoBehaviourRect
{
  private static readonly System.IntPtr NativeFieldInfoPtr_textAsset;
  private static readonly System.IntPtr NativeFieldInfoPtr_layoutElement;
  private static readonly System.IntPtr NativeFieldInfoPtr_textBox;
  private static readonly System.IntPtr NativeFieldInfoPtr_noteSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_noteColorHex;
  private static readonly System.IntPtr NativeFieldInfoPtr_emotes;
  private static readonly System.IntPtr NativeFieldInfoPtr_emoteImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_focusFormat;
  private static readonly System.IntPtr NativeFieldInfoPtr_SetTextAction;
  private static readonly System.IntPtr NativeFieldInfoPtr__active_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_width;
  private static readonly System.IntPtr NativeFieldInfoPtr_emoteType;
  private static readonly System.IntPtr NativeFieldInfoPtr_emotePosition;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_active_Private_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LocaleChanged_Private_Void_Locale_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunSetTextAction_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetAnchor_Public_Void_Anchor_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetAnchor_Public_Void_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetAnchor_Public_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Vector2_Anchor_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetMaxWidth_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessText_Private_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessTag_Private_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetEmote_Public_Void_Type_Position_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetEmotePosition_Public_Void_Position_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetEmotePositionRoutine_Private_IEnumerator_Position_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Ping_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Enable_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Hide_b__36_0_Private_Void_0;

  public unsafe bool active
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr_set_active_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67162, XrefRangeEnd = 67171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67171, XrefRangeEnd = 67180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67180, XrefRangeEnd = 67182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LocaleChanged(UnityEngine.Localization.Locale locale)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) locale)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr_LocaleChanged_Private_Void_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RunSetTextAction()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr_RunSetTextAction_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67182, XrefRangeEnd = 67201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetAnchor(Prompt.Anchor anchor)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &anchor
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr_SetAnchor_Public_Void_Anchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 67208, RefRangeEnd = 67219, XrefRangeStart = 67201, XrefRangeEnd = 67208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetAnchor(float x, float y)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr_SetAnchor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67219, XrefRangeEnd = 67226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetAnchor(Vector2 anchor)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &anchor
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr_SetAnchor_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67226, XrefRangeEnd = 67229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPosition(Vector2 position)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &position
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr_SetPosition_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67229, XrefRangeEnd = 67251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPosition(Vector2 position, Prompt.Anchor anchor)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &anchor;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr_SetPosition_Public_Void_Vector2_Anchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void SetMaxWidth(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr_SetMaxWidth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 67282, RefRangeEnd = 67285, XrefRangeStart = 67251, XrefRangeEnd = 67282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetText(string text)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(text)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr_SetText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67285, XrefRangeEnd = 67293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetText(string text, string note = "")
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(note);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr_SetText_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67293, XrefRangeEnd = 67303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string ProcessText(string input)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(input)
    };
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr_ProcessText_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67303, XrefRangeEnd = 67304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string ProcessTag(string tag)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(tag)
    };
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr_ProcessTag_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 67323, RefRangeEnd = 67325, XrefRangeStart = 67304, XrefRangeEnd = 67323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetEmote(Prompt.Emote.Type emoteType, Prompt.Emote.Position position)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &emoteType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr_SetEmote_Public_Void_Type_Position_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 67333, RefRangeEnd = 67337, XrefRangeStart = 67325, XrefRangeEnd = 67333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetEmotePosition(
    Prompt.Emote.Position position,
    float offsetX = 0.0f,
    float offsetY = 0.0f,
    float forceFlip = 0.0f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &offsetX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &offsetY;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &forceFlip;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr_SetEmotePosition_Public_Void_Position_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67337, XrefRangeEnd = 67342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator SetEmotePositionRoutine(
    Prompt.Emote.Position position,
    float offsetX = 0.0f,
    float offsetY = 0.0f,
    float forceFlip = 0.0f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &offsetX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &offsetY;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &forceFlip;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr_SetEmotePositionRoutine_Private_IEnumerator_Position_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67342, XrefRangeEnd = 67357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Ping()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr_Ping_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67357, XrefRangeEnd = 67379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hide()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67379, XrefRangeEnd = 67382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Enable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr_Enable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67382, XrefRangeEnd = 67391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Prompt()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Prompt>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 42411, RefRangeEnd = 42412, XrefRangeStart = 42411, XrefRangeEnd = 42412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _Hide_b__36_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Prompt.NativeMethodInfoPtr__Hide_b__36_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Prompt()
  {
    Il2CppClassPointerStore<Prompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Prompt));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Prompt>.NativeClassPtr);
    Prompt.NativeFieldInfoPtr_textAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt>.NativeClassPtr, nameof (textAsset));
    Prompt.NativeFieldInfoPtr_layoutElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt>.NativeClassPtr, nameof (layoutElement));
    Prompt.NativeFieldInfoPtr_textBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt>.NativeClassPtr, nameof (textBox));
    Prompt.NativeFieldInfoPtr_noteSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt>.NativeClassPtr, nameof (noteSize));
    Prompt.NativeFieldInfoPtr_noteColorHex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt>.NativeClassPtr, nameof (noteColorHex));
    Prompt.NativeFieldInfoPtr_emotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt>.NativeClassPtr, nameof (emotes));
    Prompt.NativeFieldInfoPtr_emoteImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt>.NativeClassPtr, nameof (emoteImage));
    Prompt.NativeFieldInfoPtr_focusFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt>.NativeClassPtr, nameof (focusFormat));
    Prompt.NativeFieldInfoPtr_SetTextAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt>.NativeClassPtr, nameof (SetTextAction));
    Prompt.NativeFieldInfoPtr__active_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt>.NativeClassPtr, "<active>k__BackingField");
    Prompt.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt>.NativeClassPtr, nameof (width));
    Prompt.NativeFieldInfoPtr_emoteType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt>.NativeClassPtr, nameof (emoteType));
    Prompt.NativeFieldInfoPtr_emotePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt>.NativeClassPtr, nameof (emotePosition));
    Prompt.NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668804);
    Prompt.NativeMethodInfoPtr_set_active_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668805);
    Prompt.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668806);
    Prompt.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668807);
    Prompt.NativeMethodInfoPtr_LocaleChanged_Private_Void_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668808);
    Prompt.NativeMethodInfoPtr_RunSetTextAction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668809);
    Prompt.NativeMethodInfoPtr_SetAnchor_Public_Void_Anchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668810);
    Prompt.NativeMethodInfoPtr_SetAnchor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668811);
    Prompt.NativeMethodInfoPtr_SetAnchor_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668812);
    Prompt.NativeMethodInfoPtr_SetPosition_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668813);
    Prompt.NativeMethodInfoPtr_SetPosition_Public_Void_Vector2_Anchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668814);
    Prompt.NativeMethodInfoPtr_SetMaxWidth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668815);
    Prompt.NativeMethodInfoPtr_SetText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668816);
    Prompt.NativeMethodInfoPtr_SetText_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668817);
    Prompt.NativeMethodInfoPtr_ProcessText_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668818);
    Prompt.NativeMethodInfoPtr_ProcessTag_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668819);
    Prompt.NativeMethodInfoPtr_SetEmote_Public_Void_Type_Position_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668820);
    Prompt.NativeMethodInfoPtr_SetEmotePosition_Public_Void_Position_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668821);
    Prompt.NativeMethodInfoPtr_SetEmotePositionRoutine_Private_IEnumerator_Position_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668822);
    Prompt.NativeMethodInfoPtr_Ping_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668823);
    Prompt.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668824);
    Prompt.NativeMethodInfoPtr_Enable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668825);
    Prompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668826);
    Prompt.NativeMethodInfoPtr__Hide_b__36_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt>.NativeClassPtr, 100668827);
  }

  public Prompt(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe TMP_Text textAsset
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_textAsset));
      return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_textAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LayoutElement layoutElement
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_layoutElement));
      return pointer == System.IntPtr.Zero ? (LayoutElement) null : new LayoutElement(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_layoutElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform textBox
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_textBox));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_textBox), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float noteSize
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_noteSize));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_noteSize)) = value;
    }
  }

  public unsafe string noteColorHex
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_noteColorHex)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_noteColorHex), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Il2CppReferenceArray<Prompt.Emote> emotes
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_emotes));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Prompt.Emote>) null : new Il2CppReferenceArray<Prompt.Emote>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_emotes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image emoteImage
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_emoteImage));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_emoteImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string focusFormat
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_focusFormat)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_focusFormat), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Prompt.GetTextCallback SetTextAction
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_SetTextAction));
      return pointer == System.IntPtr.Zero ? (Prompt.GetTextCallback) null : new Prompt.GetTextCallback(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_SetTextAction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _active_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr__active_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr__active_k__BackingField)) = value;
    }
  }

  public unsafe float width
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_width));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_width)) = value;
    }
  }

  public unsafe Prompt.Emote.Type emoteType
  {
    get
    {
      return *(Prompt.Emote.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_emoteType));
    }
    [param: In] set
    {
      *(Prompt.Emote.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_emoteType)) = value;
    }
  }

  public unsafe Prompt.Emote.Position emotePosition
  {
    get
    {
      return *(Prompt.Emote.Position*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_emotePosition));
    }
    [param: In] set
    {
      *(Prompt.Emote.Position*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt.NativeFieldInfoPtr_emotePosition)) = value;
    }
  }

  public sealed class GetTextCallback : Il2CppSystem.MulticastDelegate
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_String_IAsyncResult_0;

    [CallerCount(136)]
    [CachedScanResults(RefRangeStart = 66997, RefRangeEnd = 67133, XrefRangeStart = 66991, XrefRangeEnd = 66997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GetTextCallback(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Prompt.GetTextCallback>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Prompt.GetTextCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe string Invoke()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Prompt.GetTextCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 67134, RefRangeEnd = 67135, XrefRangeStart = 67133, XrefRangeEnd = 67134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
      Il2CppSystem.AsyncCallback callback,
      Il2CppSystem.Object @object)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Prompt.GetTextCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 67136, RefRangeEnd = 67137, XrefRangeStart = 67135, XrefRangeEnd = 67136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe string EndInvoke(Il2CppSystem.IAsyncResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result)
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Prompt.GetTextCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_String_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static GetTextCallback()
    {
      Il2CppClassPointerStore<Prompt.GetTextCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Prompt>.NativeClassPtr, nameof (GetTextCallback));
      Prompt.GetTextCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt.GetTextCallback>.NativeClassPtr, 100668828);
      Prompt.GetTextCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt.GetTextCallback>.NativeClassPtr, 100668829);
      Prompt.GetTextCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt.GetTextCallback>.NativeClassPtr, 100668830);
      Prompt.GetTextCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_String_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt.GetTextCallback>.NativeClassPtr, 100668831);
    }

    public GetTextCallback(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static implicit operator Prompt.GetTextCallback([In] System.Func<string> obj0)
    {
      return DelegateSupport.ConvertDelegate<Prompt.GetTextCallback>((System.Delegate) obj0);
    }

    public static Prompt.GetTextCallback operator +(
      [In] Prompt.GetTextCallback obj0,
      [In] Prompt.GetTextCallback obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<Prompt.GetTextCallback>();
    }

    public static Prompt.GetTextCallback operator -(
      [In] Prompt.GetTextCallback obj0,
      [In] Prompt.GetTextCallback obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (Prompt.GetTextCallback) @delegate : @delegate.Cast<Prompt.GetTextCallback>();
    }
  }

  public enum Anchor
  {
    Mid,
    Top,
    Left,
    Right,
    Bottom,
    TopLeft,
    TopRight,
    BottomLeft,
    BottomRight,
  }

  [Serializable]
  public sealed class Emote : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_type;
    private static readonly System.IntPtr NativeFieldInfoPtr_sprite;

    static Emote()
    {
      Il2CppClassPointerStore<Prompt.Emote>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Prompt>.NativeClassPtr, nameof (Emote));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Prompt.Emote>.NativeClassPtr);
      Prompt.Emote.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt.Emote>.NativeClassPtr, nameof (type));
      Prompt.Emote.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt.Emote>.NativeClassPtr, nameof (sprite));
    }

    public Emote(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Emote()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Prompt.Emote>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Prompt.Emote>.NativeClassPtr, data));
    }

    public unsafe Prompt.Emote.Type type
    {
      get
      {
        return *(Prompt.Emote.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt.Emote.NativeFieldInfoPtr_type));
      }
      [param: In] set
      {
        *(Prompt.Emote.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt.Emote.NativeFieldInfoPtr_type)) = value;
      }
    }

    public unsafe Sprite sprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt.Emote.NativeFieldInfoPtr_sprite));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Prompt.Emote.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public enum Type
    {
      None,
      Basic,
      Point,
      Scared,
      Talk,
      Explain,
      Sad,
      Happy,
    }

    public enum Position
    {
      Left,
      Right,
      Above,
      Below,
    }
  }

  [ObfuscatedName("Prompt/<>c__DisplayClass32_0")]
  public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_emoteType;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetEmote_b__0_Internal_Boolean_Emote_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass32_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Prompt.__c__DisplayClass32_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Prompt.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _SetEmote_b__0(Prompt.Emote e)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) e))
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Prompt.__c__DisplayClass32_0.NativeMethodInfoPtr__SetEmote_b__0_Internal_Boolean_Emote_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass32_0()
    {
      Il2CppClassPointerStore<Prompt.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Prompt>.NativeClassPtr, "<>c__DisplayClass32_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Prompt.__c__DisplayClass32_0>.NativeClassPtr);
      Prompt.__c__DisplayClass32_0.NativeFieldInfoPtr_emoteType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt.__c__DisplayClass32_0>.NativeClassPtr, nameof (emoteType));
      Prompt.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt.__c__DisplayClass32_0>.NativeClassPtr, 100668832);
      Prompt.__c__DisplayClass32_0.NativeMethodInfoPtr__SetEmote_b__0_Internal_Boolean_Emote_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt.__c__DisplayClass32_0>.NativeClassPtr, 100668833);
    }

    public __c__DisplayClass32_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Prompt.Emote.Type emoteType
    {
      get
      {
        return *(Prompt.Emote.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt.__c__DisplayClass32_0.NativeFieldInfoPtr_emoteType));
      }
      [param: In] set
      {
        *(Prompt.Emote.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt.__c__DisplayClass32_0.NativeFieldInfoPtr_emoteType)) = value;
      }
    }
  }

  [ObfuscatedName("Prompt/<SetEmotePositionRoutine>d__34")]
  public sealed class _SetEmotePositionRoutine_d__34 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_position;
    private static readonly System.IntPtr NativeFieldInfoPtr_offsetX;
    private static readonly System.IntPtr NativeFieldInfoPtr_offsetY;
    private static readonly System.IntPtr NativeFieldInfoPtr_forceFlip;
    private static readonly System.IntPtr NativeFieldInfoPtr__rect_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _SetEmotePositionRoutine_d__34(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Prompt._SetEmotePositionRoutine_d__34>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Prompt._SetEmotePositionRoutine_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Prompt._SetEmotePositionRoutine_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67137, XrefRangeEnd = 67156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Prompt._SetEmotePositionRoutine_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Prompt._SetEmotePositionRoutine_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67156, XrefRangeEnd = 67162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Prompt._SetEmotePositionRoutine_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Prompt._SetEmotePositionRoutine_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _SetEmotePositionRoutine_d__34()
    {
      Il2CppClassPointerStore<Prompt._SetEmotePositionRoutine_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Prompt>.NativeClassPtr, "<SetEmotePositionRoutine>d__34");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Prompt._SetEmotePositionRoutine_d__34>.NativeClassPtr);
      Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt._SetEmotePositionRoutine_d__34>.NativeClassPtr, "<>1__state");
      Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt._SetEmotePositionRoutine_d__34>.NativeClassPtr, "<>2__current");
      Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt._SetEmotePositionRoutine_d__34>.NativeClassPtr, "<>4__this");
      Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt._SetEmotePositionRoutine_d__34>.NativeClassPtr, nameof (position));
      Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr_offsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt._SetEmotePositionRoutine_d__34>.NativeClassPtr, nameof (offsetX));
      Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr_offsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt._SetEmotePositionRoutine_d__34>.NativeClassPtr, nameof (offsetY));
      Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr_forceFlip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt._SetEmotePositionRoutine_d__34>.NativeClassPtr, nameof (forceFlip));
      Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr__rect_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prompt._SetEmotePositionRoutine_d__34>.NativeClassPtr, "<rect>5__2");
      Prompt._SetEmotePositionRoutine_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt._SetEmotePositionRoutine_d__34>.NativeClassPtr, 100668834);
      Prompt._SetEmotePositionRoutine_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt._SetEmotePositionRoutine_d__34>.NativeClassPtr, 100668835);
      Prompt._SetEmotePositionRoutine_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt._SetEmotePositionRoutine_d__34>.NativeClassPtr, 100668836);
      Prompt._SetEmotePositionRoutine_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt._SetEmotePositionRoutine_d__34>.NativeClassPtr, 100668837);
      Prompt._SetEmotePositionRoutine_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt._SetEmotePositionRoutine_d__34>.NativeClassPtr, 100668838);
      Prompt._SetEmotePositionRoutine_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prompt._SetEmotePositionRoutine_d__34>.NativeClassPtr, 100668839);
    }

    public _SetEmotePositionRoutine_d__34(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Prompt __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (Prompt) null : new Prompt(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Prompt.Emote.Position position
    {
      get
      {
        return *(Prompt.Emote.Position*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr_position));
      }
      [param: In] set
      {
        *(Prompt.Emote.Position*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr_position)) = value;
      }
    }

    public unsafe float offsetX
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr_offsetX));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr_offsetX)) = value;
      }
    }

    public unsafe float offsetY
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr_offsetY));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr_offsetY)) = value;
      }
    }

    public unsafe float forceFlip
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr_forceFlip));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr_forceFlip)) = value;
      }
    }

    public unsafe Rect _rect_5__2
    {
      get
      {
        return *(Rect*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr__rect_5__2));
      }
      [param: In] set
      {
        *(Rect*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Prompt._SetEmotePositionRoutine_d__34.NativeFieldInfoPtr__rect_5__2)) = value;
      }
    }
  }
}
