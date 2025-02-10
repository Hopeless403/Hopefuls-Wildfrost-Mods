// Decompiled with JetBrains decompiler
// Type: CardPopUpPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
public class CardPopUpPanel : Tooltip
{
  private static readonly IntPtr NativeFieldInfoPtr_titleSize;
  private static readonly IntPtr NativeFieldInfoPtr_iconSize;
  private static readonly IntPtr NativeFieldInfoPtr_bodySize;
  private static readonly IntPtr NativeFieldInfoPtr_noteSize;
  private static readonly IntPtr NativeFieldInfoPtr_textElement;
  private static readonly IntPtr NativeFieldInfoPtr_fitter;
  private static readonly IntPtr NativeFieldInfoPtr_defaultTitleColor;
  private static readonly IntPtr NativeFieldInfoPtr_defaultBodyColor;
  private static readonly IntPtr NativeFieldInfoPtr_defaultNoteColor;
  private static readonly IntPtr NativeFieldInfoPtr_titleText;
  private static readonly IntPtr NativeFieldInfoPtr_bodyText;
  private static readonly IntPtr NativeFieldInfoPtr_noteText;
  private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_String_String_String_Color_String_Color_Sprite_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_String_String_String_Color_String_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_String_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_String_Color_String_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_String_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_KeywordData_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetRoutine_Private_Void_String_String_String_Color_String_Color_String_Color_Sprite_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetTitle_Public_Void_String_Color_String_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddToTitle_Public_Void_String_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetBody_Public_Void_String_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddToBody_Public_Void_String_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetNote_Public_Void_String_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddToNote_Public_Void_String_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_BuildTextElement_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe string text
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95674, XrefRangeEnd = 95675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CardPopUpPanel.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95675, XrefRangeEnd = 95678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(
    string iconName,
    string iconTintHex,
    string title,
    Color titleColour,
    string body,
    Color bodyColour,
    Sprite panelSprite,
    Color panelColor)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[8];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(iconName);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(iconTintHex);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(title);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &titleColour;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(body);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &bodyColour;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) panelSprite);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(7) * sizeof (IntPtr))) = (IntPtr) &panelColor;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUpPanel.NativeMethodInfoPtr_Set_Public_Void_String_String_String_Color_String_Color_Sprite_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95678, XrefRangeEnd = 95681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(
    string iconName,
    string iconTintHex,
    string title,
    Color titleColour,
    string body,
    Color bodyColour)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[6];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(iconName);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(iconTintHex);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(title);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &titleColour;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(body);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &bodyColour;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUpPanel.NativeMethodInfoPtr_Set_Public_Void_String_String_String_Color_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 95688, RefRangeEnd = 95689, XrefRangeStart = 95681, XrefRangeEnd = 95688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(string title, string body)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(title);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(body);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUpPanel.NativeMethodInfoPtr_Set_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95689, XrefRangeEnd = 95692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(string title, Color titleColour, string body, Color bodyColour)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(title);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &titleColour;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(body);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &bodyColour;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUpPanel.NativeMethodInfoPtr_Set_Public_Void_String_Color_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95692, XrefRangeEnd = 95695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(string text, Color textColour)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &textColour;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUpPanel.NativeMethodInfoPtr_Set_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 95703, RefRangeEnd = 95704, XrefRangeStart = 95695, XrefRangeEnd = 95703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(KeywordData keyword, string forceBody = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keyword);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(forceBody);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUpPanel.NativeMethodInfoPtr_Set_Public_Void_KeywordData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 95734, RefRangeEnd = 95740, XrefRangeStart = 95704, XrefRangeEnd = 95734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetRoutine(
    string iconName,
    string iconTintHex,
    string title,
    Color titleColour,
    string body,
    Color bodyColour,
    string note,
    Color noteColour,
    Sprite panelSprite,
    Color panelColor)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[10];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(iconName);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(iconTintHex);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(title);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &titleColour;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(body);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &bodyColour;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(note);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(7) * sizeof (IntPtr))) = (IntPtr) &noteColour;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(8) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) panelSprite);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(9) * sizeof (IntPtr))) = (IntPtr) &panelColor;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUpPanel.NativeMethodInfoPtr_SetRoutine_Private_Void_String_String_String_Color_String_Color_String_Color_Sprite_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 95772, RefRangeEnd = 95774, XrefRangeStart = 95740, XrefRangeEnd = 95772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetTitle(
    string title,
    Color titleColour,
    string iconName,
    string iconTintHex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(title);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &titleColour;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(iconName);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(iconTintHex);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUpPanel.NativeMethodInfoPtr_SetTitle_Public_Void_String_Color_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 95793, RefRangeEnd = 95794, XrefRangeStart = 95774, XrefRangeEnd = 95793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddToTitle(string text, bool newline = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &newline;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUpPanel.NativeMethodInfoPtr_AddToTitle_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 95811, RefRangeEnd = 95813, XrefRangeStart = 95794, XrefRangeEnd = 95811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetBody(string body, Color bodyColour)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(body);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &bodyColour;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUpPanel.NativeMethodInfoPtr_SetBody_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95813, XrefRangeEnd = 95830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddToBody(string text, bool newline = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &newline;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUpPanel.NativeMethodInfoPtr_AddToBody_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 95843, RefRangeEnd = 95845, XrefRangeStart = 95830, XrefRangeEnd = 95843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetNote(string note, Color noteColour)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(note);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &noteColour;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUpPanel.NativeMethodInfoPtr_SetNote_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95845, XrefRangeEnd = 95858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddToNote(string text, bool newline = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &newline;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUpPanel.NativeMethodInfoPtr_AddToNote_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 95870, RefRangeEnd = 95871, XrefRangeStart = 95858, XrefRangeEnd = 95870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BuildTextElement()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUpPanel.NativeMethodInfoPtr_BuildTextElement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95871, XrefRangeEnd = 95872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardPopUpPanel()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUpPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardPopUpPanel()
  {
    Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardPopUpPanel));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr);
    CardPopUpPanel.NativeFieldInfoPtr_titleSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, nameof (titleSize));
    CardPopUpPanel.NativeFieldInfoPtr_iconSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, nameof (iconSize));
    CardPopUpPanel.NativeFieldInfoPtr_bodySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, nameof (bodySize));
    CardPopUpPanel.NativeFieldInfoPtr_noteSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, nameof (noteSize));
    CardPopUpPanel.NativeFieldInfoPtr_textElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, nameof (textElement));
    CardPopUpPanel.NativeFieldInfoPtr_fitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, nameof (fitter));
    CardPopUpPanel.NativeFieldInfoPtr_defaultTitleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, nameof (defaultTitleColor));
    CardPopUpPanel.NativeFieldInfoPtr_defaultBodyColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, nameof (defaultBodyColor));
    CardPopUpPanel.NativeFieldInfoPtr_defaultNoteColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, nameof (defaultNoteColor));
    CardPopUpPanel.NativeFieldInfoPtr_titleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, nameof (titleText));
    CardPopUpPanel.NativeFieldInfoPtr_bodyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, nameof (bodyText));
    CardPopUpPanel.NativeFieldInfoPtr_noteText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, nameof (noteText));
    CardPopUpPanel.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, 100671644);
    CardPopUpPanel.NativeMethodInfoPtr_Set_Public_Void_String_String_String_Color_String_Color_Sprite_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, 100671645);
    CardPopUpPanel.NativeMethodInfoPtr_Set_Public_Void_String_String_String_Color_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, 100671646);
    CardPopUpPanel.NativeMethodInfoPtr_Set_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, 100671647);
    CardPopUpPanel.NativeMethodInfoPtr_Set_Public_Void_String_Color_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, 100671648);
    CardPopUpPanel.NativeMethodInfoPtr_Set_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, 100671649);
    CardPopUpPanel.NativeMethodInfoPtr_Set_Public_Void_KeywordData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, 100671650);
    CardPopUpPanel.NativeMethodInfoPtr_SetRoutine_Private_Void_String_String_String_Color_String_Color_String_Color_Sprite_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, 100671651);
    CardPopUpPanel.NativeMethodInfoPtr_SetTitle_Public_Void_String_Color_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, 100671652);
    CardPopUpPanel.NativeMethodInfoPtr_AddToTitle_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, 100671653);
    CardPopUpPanel.NativeMethodInfoPtr_SetBody_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, 100671654);
    CardPopUpPanel.NativeMethodInfoPtr_AddToBody_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, 100671655);
    CardPopUpPanel.NativeMethodInfoPtr_SetNote_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, 100671656);
    CardPopUpPanel.NativeMethodInfoPtr_AddToNote_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, 100671657);
    CardPopUpPanel.NativeMethodInfoPtr_BuildTextElement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, 100671658);
    CardPopUpPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUpPanel>.NativeClassPtr, 100671659);
  }

  public CardPopUpPanel(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float titleSize
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpPanel.NativeFieldInfoPtr_titleSize));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpPanel.NativeFieldInfoPtr_titleSize)) = value;
    }
  }

  public unsafe float iconSize
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpPanel.NativeFieldInfoPtr_iconSize));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpPanel.NativeFieldInfoPtr_iconSize)) = value;
    }
  }

  public unsafe float bodySize
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpPanel.NativeFieldInfoPtr_bodySize));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpPanel.NativeFieldInfoPtr_bodySize)) = value;
    }
  }

  public unsafe float noteSize
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpPanel.NativeFieldInfoPtr_noteSize));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpPanel.NativeFieldInfoPtr_noteSize)) = value;
    }
  }

  public unsafe TextMeshProUGUI textElement
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpPanel.NativeFieldInfoPtr_textElement));
      return pointer == IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpPanel.NativeFieldInfoPtr_textElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Fitter fitter
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpPanel.NativeFieldInfoPtr_fitter));
      return pointer == IntPtr.Zero ? (Fitter) null : new Fitter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpPanel.NativeFieldInfoPtr_fitter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Color defaultTitleColor
  {
    get
    {
      Color defaultTitleColor;
      IL2CPP.il2cpp_field_static_get_value(CardPopUpPanel.NativeFieldInfoPtr_defaultTitleColor, (void*) &defaultTitleColor);
      return defaultTitleColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CardPopUpPanel.NativeFieldInfoPtr_defaultTitleColor, (void*) &value);
    }
  }

  public static unsafe Color defaultBodyColor
  {
    get
    {
      Color defaultBodyColor;
      IL2CPP.il2cpp_field_static_get_value(CardPopUpPanel.NativeFieldInfoPtr_defaultBodyColor, (void*) &defaultBodyColor);
      return defaultBodyColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CardPopUpPanel.NativeFieldInfoPtr_defaultBodyColor, (void*) &value);
    }
  }

  public static unsafe Color defaultNoteColor
  {
    get
    {
      Color defaultNoteColor;
      IL2CPP.il2cpp_field_static_get_value(CardPopUpPanel.NativeFieldInfoPtr_defaultNoteColor, (void*) &defaultNoteColor);
      return defaultNoteColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CardPopUpPanel.NativeFieldInfoPtr_defaultNoteColor, (void*) &value);
    }
  }

  public unsafe string titleText
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpPanel.NativeFieldInfoPtr_titleText)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpPanel.NativeFieldInfoPtr_titleText), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string bodyText
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpPanel.NativeFieldInfoPtr_bodyText)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpPanel.NativeFieldInfoPtr_bodyText), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string noteText
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpPanel.NativeFieldInfoPtr_noteText)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPopUpPanel.NativeFieldInfoPtr_noteText), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
