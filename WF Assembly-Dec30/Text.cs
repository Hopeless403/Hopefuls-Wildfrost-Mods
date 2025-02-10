// Decompiled with JetBrains decompiler
// Type: Text
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Localization;

#nullable disable
public static class Text : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_darkProfile;
  private static readonly System.IntPtr NativeFieldInfoPtr_lightProfile;
  private static readonly System.IntPtr NativeMethodInfoPtr_Process_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Process_Public_Static_String_String_ColourProfileHex_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Process_Public_Static_String_String_Int32_Single_ColourProfileHex_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindTag_Public_Static_String_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessTag_Private_Static_String_String_String_Int32_Single_ColourProfileHex_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToKeyword_Public_Static_KeywordData_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetKeywords_Public_Static_HashSet_1_KeywordData_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMentionedCards_Public_Static_HashSet_1_CardData_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEffectText_Public_Static_String_LocalizedString_String_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEffectText_Public_Static_String_IEnumerable_1_LocalizedString_String_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HandleBracketTags_Public_Static_String_String_0;

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 127565, RefRangeEnd = 127570, XrefRangeStart = 127560, XrefRangeEnd = 127565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string Process(string original)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(original)
    };
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_Process_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127570, XrefRangeEnd = 127574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string Process(string original, Text.ColourProfileHex profile)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(original);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) profile));
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_Process_Public_Static_String_String_ColourProfileHex_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 127585, RefRangeEnd = 127589, XrefRangeStart = 127574, XrefRangeEnd = 127585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string Process(
    string original,
    int effectBonus,
    float effectFactor,
    Text.ColourProfileHex profile)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(original);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &effectBonus;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &effectFactor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) profile));
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_Process_Public_Static_String_String_Int32_Single_ColourProfileHex_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 127593, RefRangeEnd = 127597, XrefRangeStart = 127589, XrefRangeEnd = 127593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string FindTag(string text, int startIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startIndex;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_FindTag_Public_Static_String_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 127640, RefRangeEnd = 127641, XrefRangeStart = 127597, XrefRangeEnd = 127640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ProcessTag(
    string text,
    string tag,
    int effectBonus,
    float effectFactor,
    Text.ColourProfileHex profile)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(tag);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &effectBonus;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &effectFactor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) profile));
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_ProcessTag_Private_Static_String_String_String_Int32_Single_ColourProfileHex_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 127696, RefRangeEnd = 127698, XrefRangeStart = 127641, XrefRangeEnd = 127696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe KeywordData ToKeyword(string text)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(text)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_ToKeyword_Public_Static_KeywordData_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (KeywordData) null : new KeywordData(pointer);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 127726, RefRangeEnd = 127730, XrefRangeStart = 127698, XrefRangeEnd = 127726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe HashSet<KeywordData> GetKeywords(string text)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(text)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_GetKeywords_Public_Static_HashSet_1_KeywordData_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (HashSet<KeywordData>) null : new HashSet<KeywordData>(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 127763, RefRangeEnd = 127764, XrefRangeStart = 127730, XrefRangeEnd = 127763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe HashSet<CardData> GetMentionedCards(string text)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(text)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_GetMentionedCards_Public_Static_HashSet_1_CardData_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (HashSet<CardData>) null : new HashSet<CardData>(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 127791, RefRangeEnd = 127794, XrefRangeStart = 127764, XrefRangeEnd = 127791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetEffectText(
    LocalizedString textKey,
    string textInsert,
    int amount,
    bool silenced = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) textKey);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(textInsert);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &silenced;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_GetEffectText_Public_Static_String_LocalizedString_String_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127794, XrefRangeEnd = 127841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetEffectText(
    IEnumerable<LocalizedString> textKeys,
    string textInsert,
    int amount,
    bool silenced = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) textKeys);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(textInsert);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &silenced;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_GetEffectText_Public_Static_String_IEnumerable_1_LocalizedString_String_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 127849, RefRangeEnd = 127850, XrefRangeStart = 127841, XrefRangeEnd = 127849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string HandleBracketTags(string text)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(text)
    };
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Text.NativeMethodInfoPtr_HandleBracketTags_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  static Text()
  {
    Il2CppClassPointerStore<Text>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Text));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Text>.NativeClassPtr);
    Text.NativeFieldInfoPtr_darkProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text>.NativeClassPtr, nameof (darkProfile));
    Text.NativeFieldInfoPtr_lightProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text>.NativeClassPtr, nameof (lightProfile));
    Text.NativeMethodInfoPtr_Process_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100676511);
    Text.NativeMethodInfoPtr_Process_Public_Static_String_String_ColourProfileHex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100676512);
    Text.NativeMethodInfoPtr_Process_Public_Static_String_String_Int32_Single_ColourProfileHex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100676513);
    Text.NativeMethodInfoPtr_FindTag_Public_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100676514);
    Text.NativeMethodInfoPtr_ProcessTag_Private_Static_String_String_String_Int32_Single_ColourProfileHex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100676515);
    Text.NativeMethodInfoPtr_ToKeyword_Public_Static_KeywordData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100676516);
    Text.NativeMethodInfoPtr_GetKeywords_Public_Static_HashSet_1_KeywordData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100676517);
    Text.NativeMethodInfoPtr_GetMentionedCards_Public_Static_HashSet_1_CardData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100676518);
    Text.NativeMethodInfoPtr_GetEffectText_Public_Static_String_LocalizedString_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100676519);
    Text.NativeMethodInfoPtr_GetEffectText_Public_Static_String_IEnumerable_1_LocalizedString_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100676520);
    Text.NativeMethodInfoPtr_HandleBracketTags_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text>.NativeClassPtr, 100676521);
  }

  public Text(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Text.ColourProfileHex darkProfile
  {
    get
    {
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Text.ColourProfileHex>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      IL2CPP.il2cpp_field_static_get_value(Text.NativeFieldInfoPtr_darkProfile, (void*) data);
      return new Text.ColourProfileHex(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Text.ColourProfileHex>.NativeClassPtr, data));
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Text.NativeFieldInfoPtr_darkProfile, (void*) IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value)));
    }
  }

  public static unsafe Text.ColourProfileHex lightProfile
  {
    get
    {
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Text.ColourProfileHex>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      IL2CPP.il2cpp_field_static_get_value(Text.NativeFieldInfoPtr_lightProfile, (void*) data);
      return new Text.ColourProfileHex(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Text.ColourProfileHex>.NativeClassPtr, data));
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Text.NativeFieldInfoPtr_lightProfile, (void*) IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value)));
    }
  }

  [Serializable]
  public sealed class ColourProfileHex : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_textColour;
    private static readonly System.IntPtr NativeFieldInfoPtr_effectColour;
    private static readonly System.IntPtr NativeFieldInfoPtr_effectBuffedColour;
    private static readonly System.IntPtr NativeFieldInfoPtr_effectDebuffedColour;
    private static readonly System.IntPtr NativeFieldInfoPtr_keywordColour;
    private static readonly System.IntPtr NativeFieldInfoPtr_keywordSilencedColour;
    private static readonly System.IntPtr NativeFieldInfoPtr_keywordBuffedColour;
    private static readonly System.IntPtr NativeFieldInfoPtr_keywordDebuffedColour;
    private static readonly System.IntPtr NativeFieldInfoPtr_flavourColour;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_String_String_String_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127551, XrefRangeEnd = 127560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ColourProfileHex(
      string textColour,
      string effectColour,
      string effectBuffedColour,
      string effectDebuffedColour,
      string keywordColour,
      string keywordSilencedColour,
      string keywordBuffedColour,
      string keywordDebuffedColour,
      string flavourColour)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Text.ColourProfileHex>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(textColour);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(effectColour);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(effectBuffedColour);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(effectDebuffedColour);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(keywordColour);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(keywordSilencedColour);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(keywordBuffedColour);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(keywordDebuffedColour);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(flavourColour);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Text.ColourProfileHex.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_String_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ColourProfileHex()
    {
      Il2CppClassPointerStore<Text.ColourProfileHex>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Text>.NativeClassPtr, nameof (ColourProfileHex));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Text.ColourProfileHex>.NativeClassPtr);
      Text.ColourProfileHex.NativeFieldInfoPtr_textColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text.ColourProfileHex>.NativeClassPtr, nameof (textColour));
      Text.ColourProfileHex.NativeFieldInfoPtr_effectColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text.ColourProfileHex>.NativeClassPtr, nameof (effectColour));
      Text.ColourProfileHex.NativeFieldInfoPtr_effectBuffedColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text.ColourProfileHex>.NativeClassPtr, nameof (effectBuffedColour));
      Text.ColourProfileHex.NativeFieldInfoPtr_effectDebuffedColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text.ColourProfileHex>.NativeClassPtr, nameof (effectDebuffedColour));
      Text.ColourProfileHex.NativeFieldInfoPtr_keywordColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text.ColourProfileHex>.NativeClassPtr, nameof (keywordColour));
      Text.ColourProfileHex.NativeFieldInfoPtr_keywordSilencedColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text.ColourProfileHex>.NativeClassPtr, nameof (keywordSilencedColour));
      Text.ColourProfileHex.NativeFieldInfoPtr_keywordBuffedColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text.ColourProfileHex>.NativeClassPtr, nameof (keywordBuffedColour));
      Text.ColourProfileHex.NativeFieldInfoPtr_keywordDebuffedColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text.ColourProfileHex>.NativeClassPtr, nameof (keywordDebuffedColour));
      Text.ColourProfileHex.NativeFieldInfoPtr_flavourColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text.ColourProfileHex>.NativeClassPtr, nameof (flavourColour));
      Text.ColourProfileHex.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text.ColourProfileHex>.NativeClassPtr, 100676523);
    }

    public ColourProfileHex(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ColourProfileHex()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Text.ColourProfileHex>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Text.ColourProfileHex>.NativeClassPtr, data));
    }

    public unsafe string textColour
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Text.ColourProfileHex.NativeFieldInfoPtr_textColour)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Text.ColourProfileHex.NativeFieldInfoPtr_textColour), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string effectColour
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Text.ColourProfileHex.NativeFieldInfoPtr_effectColour)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Text.ColourProfileHex.NativeFieldInfoPtr_effectColour), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string effectBuffedColour
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Text.ColourProfileHex.NativeFieldInfoPtr_effectBuffedColour)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Text.ColourProfileHex.NativeFieldInfoPtr_effectBuffedColour), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string effectDebuffedColour
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Text.ColourProfileHex.NativeFieldInfoPtr_effectDebuffedColour)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Text.ColourProfileHex.NativeFieldInfoPtr_effectDebuffedColour), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string keywordColour
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Text.ColourProfileHex.NativeFieldInfoPtr_keywordColour)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Text.ColourProfileHex.NativeFieldInfoPtr_keywordColour), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string keywordSilencedColour
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Text.ColourProfileHex.NativeFieldInfoPtr_keywordSilencedColour)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Text.ColourProfileHex.NativeFieldInfoPtr_keywordSilencedColour), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string keywordBuffedColour
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Text.ColourProfileHex.NativeFieldInfoPtr_keywordBuffedColour)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Text.ColourProfileHex.NativeFieldInfoPtr_keywordBuffedColour), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string keywordDebuffedColour
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Text.ColourProfileHex.NativeFieldInfoPtr_keywordDebuffedColour)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Text.ColourProfileHex.NativeFieldInfoPtr_keywordDebuffedColour), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string flavourColour
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Text.ColourProfileHex.NativeFieldInfoPtr_flavourColour)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Text.ColourProfileHex.NativeFieldInfoPtr_flavourColour), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
