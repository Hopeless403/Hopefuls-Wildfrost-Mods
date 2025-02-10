// Decompiled with JetBrains decompiler
// Type: CharacterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
[Serializable]
public class CharacterData : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_title;
  private static readonly System.IntPtr NativeFieldInfoPtr_race;
  private static readonly System.IntPtr NativeFieldInfoPtr_gender;
  private static readonly System.IntPtr NativeFieldInfoPtr_headIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_bodyIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_weapon1Index;
  private static readonly System.IntPtr NativeFieldInfoPtr_weapon2Index;
  private static readonly System.IntPtr NativeFieldInfoPtr_eyesIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_mouthIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_noseIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_eyebrowIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_earIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_hairBackIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_hairTopIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_beardIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_markingsIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_clothingColorIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_hairColorIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_eyeColorIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_skinColorIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_markingsColorIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_bodyScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_headScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_eyeScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_eyebrowScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_noseScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_mouthScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_earScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_hairScale;
  private static readonly System.IntPtr NativeMethodInfoPtr_Randomize_Public_Void_CharacterType_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetRandomPrefab_Private_Void_Boolean_CharacterType_String_byref_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetRandomSprite_Private_Void_Boolean_CharacterType_String_byref_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetRandomColorSet_Private_Void_Boolean_CharacterType_String_byref_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetScale_Private_Void_Boolean_CharacterType_String_byref_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 102889, RefRangeEnd = 102890, XrefRangeStart = 102813, XrefRangeEnd = 102889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Randomize(
    CharacterType type,
    bool lockTitle = false,
    bool lockBody = false,
    bool lockHead = false,
    bool lockEyes = false,
    bool lockEyebrows = false,
    bool lockMouth = false,
    bool lockNose = false,
    bool lockEars = false,
    bool lockHair = false,
    bool lockHairBack = false,
    bool lockBeard = false,
    bool lockHairColour = false,
    bool lockEyeColour = false,
    bool lockSkinColour = false,
    bool lockClothingColour = false,
    bool lockWeapon = false,
    bool lockMarkings = false,
    bool lockMarkingsColour = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[19];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &lockTitle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &lockBody;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &lockHead;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &lockEyes;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &lockEyebrows;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &lockMouth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &lockNose;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &lockEars;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &lockHair;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &lockHairBack;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &lockBeard;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = (System.IntPtr) &lockHairColour;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(13) * sizeof (System.IntPtr))) = (System.IntPtr) &lockEyeColour;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(14) * sizeof (System.IntPtr))) = (System.IntPtr) &lockSkinColour;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(15) * sizeof (System.IntPtr))) = (System.IntPtr) &lockClothingColour;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(16) * sizeof (System.IntPtr))) = (System.IntPtr) &lockWeapon;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(17) * sizeof (System.IntPtr))) = (System.IntPtr) &lockMarkings;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(18) * sizeof (System.IntPtr))) = (System.IntPtr) &lockMarkingsColour;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterData.NativeMethodInfoPtr_Randomize_Public_Void_CharacterType_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 102904, RefRangeEnd = 102909, XrefRangeStart = 102890, XrefRangeEnd = 102904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetRandomPrefab(bool locked, CharacterType type, string name, ref int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &locked;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref index;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterData.NativeMethodInfoPtr_SetRandomPrefab_Private_Void_Boolean_CharacterType_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 102923, RefRangeEnd = 102931, XrefRangeStart = 102909, XrefRangeEnd = 102923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetRandomSprite(bool locked, CharacterType type, string name, ref int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &locked;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref index;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterData.NativeMethodInfoPtr_SetRandomSprite_Private_Void_Boolean_CharacterType_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 102945, RefRangeEnd = 102950, XrefRangeStart = 102931, XrefRangeEnd = 102945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetRandomColorSet(
    bool locked,
    CharacterType type,
    string name,
    ref int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &locked;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref index;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterData.NativeMethodInfoPtr_SetRandomColorSet_Private_Void_Boolean_CharacterType_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 102965, RefRangeEnd = 102973, XrefRangeStart = 102950, XrefRangeEnd = 102965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetScale(bool locked, CharacterType type, string name, ref Vector2 scale)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &locked;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref scale;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterData.NativeMethodInfoPtr_SetScale_Private_Void_Boolean_CharacterType_String_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 102990, RefRangeEnd = 102991, XrefRangeStart = 102973, XrefRangeEnd = 102990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CharacterData()
  {
    Il2CppClassPointerStore<CharacterData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CharacterData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterData>.NativeClassPtr);
    CharacterData.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (title));
    CharacterData.NativeFieldInfoPtr_race = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (race));
    CharacterData.NativeFieldInfoPtr_gender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (gender));
    CharacterData.NativeFieldInfoPtr_headIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (headIndex));
    CharacterData.NativeFieldInfoPtr_bodyIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (bodyIndex));
    CharacterData.NativeFieldInfoPtr_weapon1Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (weapon1Index));
    CharacterData.NativeFieldInfoPtr_weapon2Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (weapon2Index));
    CharacterData.NativeFieldInfoPtr_eyesIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (eyesIndex));
    CharacterData.NativeFieldInfoPtr_mouthIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (mouthIndex));
    CharacterData.NativeFieldInfoPtr_noseIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (noseIndex));
    CharacterData.NativeFieldInfoPtr_eyebrowIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (eyebrowIndex));
    CharacterData.NativeFieldInfoPtr_earIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (earIndex));
    CharacterData.NativeFieldInfoPtr_hairBackIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (hairBackIndex));
    CharacterData.NativeFieldInfoPtr_hairTopIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (hairTopIndex));
    CharacterData.NativeFieldInfoPtr_beardIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (beardIndex));
    CharacterData.NativeFieldInfoPtr_markingsIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (markingsIndex));
    CharacterData.NativeFieldInfoPtr_clothingColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (clothingColorIndex));
    CharacterData.NativeFieldInfoPtr_hairColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (hairColorIndex));
    CharacterData.NativeFieldInfoPtr_eyeColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (eyeColorIndex));
    CharacterData.NativeFieldInfoPtr_skinColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (skinColorIndex));
    CharacterData.NativeFieldInfoPtr_markingsColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (markingsColorIndex));
    CharacterData.NativeFieldInfoPtr_bodyScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (bodyScale));
    CharacterData.NativeFieldInfoPtr_headScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (headScale));
    CharacterData.NativeFieldInfoPtr_eyeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (eyeScale));
    CharacterData.NativeFieldInfoPtr_eyebrowScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (eyebrowScale));
    CharacterData.NativeFieldInfoPtr_noseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (noseScale));
    CharacterData.NativeFieldInfoPtr_mouthScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (mouthScale));
    CharacterData.NativeFieldInfoPtr_earScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (earScale));
    CharacterData.NativeFieldInfoPtr_hairScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, nameof (hairScale));
    CharacterData.NativeMethodInfoPtr_Randomize_Public_Void_CharacterType_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, 100672543);
    CharacterData.NativeMethodInfoPtr_SetRandomPrefab_Private_Void_Boolean_CharacterType_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, 100672544);
    CharacterData.NativeMethodInfoPtr_SetRandomSprite_Private_Void_Boolean_CharacterType_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, 100672545);
    CharacterData.NativeMethodInfoPtr_SetRandomColorSet_Private_Void_Boolean_CharacterType_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, 100672546);
    CharacterData.NativeMethodInfoPtr_SetScale_Private_Void_Boolean_CharacterType_String_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, 100672547);
    CharacterData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, 100672548);
  }

  public CharacterData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string title
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_title)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string race
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_race)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_race), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string gender
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_gender)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_gender), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int headIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_headIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_headIndex)) = value;
    }
  }

  public unsafe int bodyIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_bodyIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_bodyIndex)) = value;
    }
  }

  public unsafe int weapon1Index
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_weapon1Index));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_weapon1Index)) = value;
    }
  }

  public unsafe int weapon2Index
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_weapon2Index));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_weapon2Index)) = value;
    }
  }

  public unsafe int eyesIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_eyesIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_eyesIndex)) = value;
    }
  }

  public unsafe int mouthIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_mouthIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_mouthIndex)) = value;
    }
  }

  public unsafe int noseIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_noseIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_noseIndex)) = value;
    }
  }

  public unsafe int eyebrowIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_eyebrowIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_eyebrowIndex)) = value;
    }
  }

  public unsafe int earIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_earIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_earIndex)) = value;
    }
  }

  public unsafe int hairBackIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_hairBackIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_hairBackIndex)) = value;
    }
  }

  public unsafe int hairTopIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_hairTopIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_hairTopIndex)) = value;
    }
  }

  public unsafe int beardIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_beardIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_beardIndex)) = value;
    }
  }

  public unsafe int markingsIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_markingsIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_markingsIndex)) = value;
    }
  }

  public unsafe int clothingColorIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_clothingColorIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_clothingColorIndex)) = value;
    }
  }

  public unsafe int hairColorIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_hairColorIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_hairColorIndex)) = value;
    }
  }

  public unsafe int eyeColorIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_eyeColorIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_eyeColorIndex)) = value;
    }
  }

  public unsafe int skinColorIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_skinColorIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_skinColorIndex)) = value;
    }
  }

  public unsafe int markingsColorIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_markingsColorIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_markingsColorIndex)) = value;
    }
  }

  public unsafe Vector2 bodyScale
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_bodyScale));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_bodyScale)) = value;
    }
  }

  public unsafe Vector2 headScale
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_headScale));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_headScale)) = value;
    }
  }

  public unsafe Vector2 eyeScale
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_eyeScale));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_eyeScale)) = value;
    }
  }

  public unsafe Vector2 eyebrowScale
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_eyebrowScale));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_eyebrowScale)) = value;
    }
  }

  public unsafe Vector2 noseScale
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_noseScale));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_noseScale)) = value;
    }
  }

  public unsafe Vector2 mouthScale
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_mouthScale));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_mouthScale)) = value;
    }
  }

  public unsafe Vector2 earScale
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_earScale));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_earScale)) = value;
    }
  }

  public unsafe Vector2 hairScale
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_hairScale));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.NativeFieldInfoPtr_hairScale)) = value;
    }
  }

  [ObfuscatedName("CharacterData/<>c__DisplayClass30_0")]
  public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetRandomPrefab_b__0_Internal_Boolean_PrefabGroup_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass30_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterData.__c__DisplayClass30_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterData.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _SetRandomPrefab_b__0(CharacterType.PrefabGroup a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterData.__c__DisplayClass30_0.NativeMethodInfoPtr__SetRandomPrefab_b__0_Internal_Boolean_PrefabGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass30_0()
    {
      Il2CppClassPointerStore<CharacterData.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, "<>c__DisplayClass30_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterData.__c__DisplayClass30_0>.NativeClassPtr);
      CharacterData.__c__DisplayClass30_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData.__c__DisplayClass30_0>.NativeClassPtr, nameof (name));
      CharacterData.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterData.__c__DisplayClass30_0>.NativeClassPtr, 100672549);
      CharacterData.__c__DisplayClass30_0.NativeMethodInfoPtr__SetRandomPrefab_b__0_Internal_Boolean_PrefabGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterData.__c__DisplayClass30_0>.NativeClassPtr, 100672550);
    }

    public __c__DisplayClass30_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.__c__DisplayClass30_0.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.__c__DisplayClass30_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  [ObfuscatedName("CharacterData/<>c__DisplayClass31_0")]
  public sealed class __c__DisplayClass31_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetRandomSprite_b__0_Internal_Boolean_SpriteGroup_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass31_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterData.__c__DisplayClass31_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterData.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _SetRandomSprite_b__0(CharacterType.SpriteGroup a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterData.__c__DisplayClass31_0.NativeMethodInfoPtr__SetRandomSprite_b__0_Internal_Boolean_SpriteGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass31_0()
    {
      Il2CppClassPointerStore<CharacterData.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, "<>c__DisplayClass31_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterData.__c__DisplayClass31_0>.NativeClassPtr);
      CharacterData.__c__DisplayClass31_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData.__c__DisplayClass31_0>.NativeClassPtr, nameof (name));
      CharacterData.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterData.__c__DisplayClass31_0>.NativeClassPtr, 100672551);
      CharacterData.__c__DisplayClass31_0.NativeMethodInfoPtr__SetRandomSprite_b__0_Internal_Boolean_SpriteGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterData.__c__DisplayClass31_0>.NativeClassPtr, 100672552);
    }

    public __c__DisplayClass31_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.__c__DisplayClass31_0.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.__c__DisplayClass31_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  [ObfuscatedName("CharacterData/<>c__DisplayClass32_0")]
  public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetRandomColorSet_b__0_Internal_Boolean_ColorSetGroup_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass32_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterData.__c__DisplayClass32_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterData.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _SetRandomColorSet_b__0(CharacterType.ColorSetGroup a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterData.__c__DisplayClass32_0.NativeMethodInfoPtr__SetRandomColorSet_b__0_Internal_Boolean_ColorSetGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass32_0()
    {
      Il2CppClassPointerStore<CharacterData.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, "<>c__DisplayClass32_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterData.__c__DisplayClass32_0>.NativeClassPtr);
      CharacterData.__c__DisplayClass32_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData.__c__DisplayClass32_0>.NativeClassPtr, nameof (name));
      CharacterData.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterData.__c__DisplayClass32_0>.NativeClassPtr, 100672553);
      CharacterData.__c__DisplayClass32_0.NativeMethodInfoPtr__SetRandomColorSet_b__0_Internal_Boolean_ColorSetGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterData.__c__DisplayClass32_0>.NativeClassPtr, 100672554);
    }

    public __c__DisplayClass32_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.__c__DisplayClass32_0.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.__c__DisplayClass32_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  [ObfuscatedName("CharacterData/<>c__DisplayClass33_0")]
  public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetScale_b__0_Internal_Boolean_ScaleRange_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass33_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterData.__c__DisplayClass33_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterData.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _SetScale_b__0(CharacterType.ScaleRange a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterData.__c__DisplayClass33_0.NativeMethodInfoPtr__SetScale_b__0_Internal_Boolean_ScaleRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass33_0()
    {
      Il2CppClassPointerStore<CharacterData.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterData>.NativeClassPtr, "<>c__DisplayClass33_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterData.__c__DisplayClass33_0>.NativeClassPtr);
      CharacterData.__c__DisplayClass33_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterData.__c__DisplayClass33_0>.NativeClassPtr, nameof (name));
      CharacterData.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterData.__c__DisplayClass33_0>.NativeClassPtr, 100672555);
      CharacterData.__c__DisplayClass33_0.NativeMethodInfoPtr__SetScale_b__0_Internal_Boolean_ScaleRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterData.__c__DisplayClass33_0>.NativeClassPtr, 100672556);
    }

    public __c__DisplayClass33_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.__c__DisplayClass33_0.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterData.__c__DisplayClass33_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
