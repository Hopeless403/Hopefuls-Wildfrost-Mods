// Decompiled with JetBrains decompiler
// Type: PromptSystem
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
using UnityEngine.SceneManagement;

#nullable disable
public class PromptSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_instance;
  private static readonly IntPtr NativeFieldInfoPtr_prompt;
  private static readonly IntPtr NativeFieldInfoPtr_popUpSfx;
  private static readonly IntPtr NativeFieldInfoPtr_denySfx;
  private static readonly IntPtr NativeMethodInfoPtr_get_Prompt_Public_Static_get_Prompt_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetSortingLayer_Public_Static_Void_String_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0;
  private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Void_Anchor_Vector2_Single_Type_Position_0;
  private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Void_Anchor_Single_Single_Single_Type_Position_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetTextAction_Public_Static_Void_GetTextCallback_0;
  private static readonly IntPtr NativeMethodInfoPtr_DoCreate_Private_Void_Anchor_Vector2_Single_Type_Position_0;
  private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_DoHide_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Shake_Public_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public static unsafe Prompt Prompt
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 67393, RefRangeEnd = 67397, XrefRangeStart = 67391, XrefRangeEnd = 67393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PromptSystem.NativeMethodInfoPtr_get_Prompt_Public_Static_get_Prompt_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Prompt) null : new Prompt(pointer);
    }
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 67408, RefRangeEnd = 67415, XrefRangeStart = 67397, XrefRangeEnd = 67408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetSortingLayer(string layerName, int sortingOrder)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(layerName);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &sortingOrder;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PromptSystem.NativeMethodInfoPtr_SetSortingLayer_Public_Static_Void_String_Int32_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67415, XrefRangeEnd = 67427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PromptSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67427, XrefRangeEnd = 67435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PromptSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67435, XrefRangeEnd = 67443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SceneChanged(Scene scene)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &scene
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PromptSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 67451, RefRangeEnd = 67452, XrefRangeStart = 67443, XrefRangeEnd = 67451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Create(
    Prompt.Anchor anchor,
    Vector2 anchoredPosition,
    float maxWidth,
    Prompt.Emote.Type emoteType = Prompt.Emote.Type.Basic,
    Prompt.Emote.Position emotePosition = Prompt.Emote.Position.Above)
  {
    IntPtr* numPtr = stackalloc IntPtr[5];
    numPtr[0] = (IntPtr) &anchor;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &anchoredPosition;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &maxWidth;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &emoteType;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &emotePosition;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PromptSystem.NativeMethodInfoPtr_Create_Public_Static_Void_Anchor_Vector2_Single_Type_Position_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(25)]
  [CachedScanResults(RefRangeStart = 67460, RefRangeEnd = 67485, XrefRangeStart = 67452, XrefRangeEnd = 67460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Create(
    Prompt.Anchor anchor,
    float x,
    float y,
    float maxWidth,
    Prompt.Emote.Type emoteType = Prompt.Emote.Type.Basic,
    Prompt.Emote.Position emotePosition = Prompt.Emote.Position.Above)
  {
    IntPtr* numPtr = stackalloc IntPtr[6];
    numPtr[0] = (IntPtr) &anchor;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &x;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &y;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &maxWidth;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &emoteType;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &emotePosition;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PromptSystem.NativeMethodInfoPtr_Create_Public_Static_Void_Anchor_Single_Single_Single_Type_Position_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(25)]
  [CachedScanResults(RefRangeStart = 67493, RefRangeEnd = 67518, XrefRangeStart = 67485, XrefRangeEnd = 67493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetTextAction(Prompt.GetTextCallback action)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PromptSystem.NativeMethodInfoPtr_SetTextAction_Public_Static_Void_GetTextCallback_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 67564, RefRangeEnd = 67566, XrefRangeStart = 67518, XrefRangeEnd = 67564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DoCreate(
    Prompt.Anchor anchor,
    Vector2 anchoredPosition,
    float maxWidth,
    Prompt.Emote.Type emoteType = Prompt.Emote.Type.Basic,
    Prompt.Emote.Position emotePosition = Prompt.Emote.Position.Above)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[5];
    numPtr[0] = (IntPtr) &anchor;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &anchoredPosition;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &maxWidth;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &emoteType;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &emotePosition;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PromptSystem.NativeMethodInfoPtr_DoCreate_Private_Void_Anchor_Vector2_Single_Type_Position_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(40)]
  [CachedScanResults(RefRangeStart = 67573, RefRangeEnd = 67613, XrefRangeStart = 67566, XrefRangeEnd = 67573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Hide()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PromptSystem.NativeMethodInfoPtr_Hide_Public_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 67638, RefRangeEnd = 67639, XrefRangeStart = 67613, XrefRangeEnd = 67638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DoHide()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PromptSystem.NativeMethodInfoPtr_DoHide_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 67660, RefRangeEnd = 67673, XrefRangeStart = 67639, XrefRangeEnd = 67660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Shake()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PromptSystem.NativeMethodInfoPtr_Shake_Public_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PromptSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PromptSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PromptSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static PromptSystem()
  {
    Il2CppClassPointerStore<PromptSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (PromptSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PromptSystem>.NativeClassPtr);
    PromptSystem.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptSystem>.NativeClassPtr, nameof (instance));
    PromptSystem.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptSystem>.NativeClassPtr, nameof (prompt));
    PromptSystem.NativeFieldInfoPtr_popUpSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptSystem>.NativeClassPtr, nameof (popUpSfx));
    PromptSystem.NativeFieldInfoPtr_denySfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptSystem>.NativeClassPtr, nameof (denySfx));
    PromptSystem.NativeMethodInfoPtr_get_Prompt_Public_Static_get_Prompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptSystem>.NativeClassPtr, 100668840);
    PromptSystem.NativeMethodInfoPtr_SetSortingLayer_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptSystem>.NativeClassPtr, 100668841);
    PromptSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptSystem>.NativeClassPtr, 100668842);
    PromptSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptSystem>.NativeClassPtr, 100668843);
    PromptSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptSystem>.NativeClassPtr, 100668844);
    PromptSystem.NativeMethodInfoPtr_Create_Public_Static_Void_Anchor_Vector2_Single_Type_Position_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptSystem>.NativeClassPtr, 100668845);
    PromptSystem.NativeMethodInfoPtr_Create_Public_Static_Void_Anchor_Single_Single_Single_Type_Position_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptSystem>.NativeClassPtr, 100668846);
    PromptSystem.NativeMethodInfoPtr_SetTextAction_Public_Static_Void_GetTextCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptSystem>.NativeClassPtr, 100668847);
    PromptSystem.NativeMethodInfoPtr_DoCreate_Private_Void_Anchor_Vector2_Single_Type_Position_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptSystem>.NativeClassPtr, 100668848);
    PromptSystem.NativeMethodInfoPtr_Hide_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptSystem>.NativeClassPtr, 100668849);
    PromptSystem.NativeMethodInfoPtr_DoHide_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptSystem>.NativeClassPtr, 100668850);
    PromptSystem.NativeMethodInfoPtr_Shake_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptSystem>.NativeClassPtr, 100668851);
    PromptSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptSystem>.NativeClassPtr, 100668852);
  }

  public PromptSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe PromptSystem instance
  {
    get
    {
      IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(PromptSystem.NativeFieldInfoPtr_instance, (void*) &num);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (PromptSystem) null : new PromptSystem(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PromptSystem.NativeFieldInfoPtr_instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Prompt prompt
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromptSystem.NativeFieldInfoPtr_prompt));
      return pointer == IntPtr.Zero ? (Prompt) null : new Prompt(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PromptSystem.NativeFieldInfoPtr_prompt), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference popUpSfx
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromptSystem.NativeFieldInfoPtr_popUpSfx));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromptSystem.NativeFieldInfoPtr_popUpSfx)) = value;
    }
  }

  public unsafe EventReference denySfx
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromptSystem.NativeFieldInfoPtr_denySfx));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromptSystem.NativeFieldInfoPtr_denySfx)) = value;
    }
  }
}
