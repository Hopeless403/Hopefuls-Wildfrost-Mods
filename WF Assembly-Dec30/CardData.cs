// Decompiled with JetBrains decompiler
// Type: CardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class CardData : DataFile
{
  private static readonly System.IntPtr NativeFieldInfoPtr_idCurrent;
  private static readonly System.IntPtr NativeFieldInfoPtr__id_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_titleFallback;
  private static readonly System.IntPtr NativeFieldInfoPtr_forceTitle;
  private static readonly System.IntPtr NativeFieldInfoPtr_desc;
  private static readonly System.IntPtr NativeFieldInfoPtr_titleKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_textKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_textInsert;
  private static readonly System.IntPtr NativeFieldInfoPtr_flavour;
  private static readonly System.IntPtr NativeFieldInfoPtr_flavourKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_value;
  private static readonly System.IntPtr NativeFieldInfoPtr_idleAnimationProfile;
  private static readonly System.IntPtr NativeFieldInfoPtr_greetMessages;
  private static readonly System.IntPtr NativeFieldInfoPtr_bloodProfile;
  private static readonly System.IntPtr NativeFieldInfoPtr_hasAttack;
  private static readonly System.IntPtr NativeFieldInfoPtr_damage;
  private static readonly System.IntPtr NativeFieldInfoPtr_hasHealth;
  private static readonly System.IntPtr NativeFieldInfoPtr_hp;
  private static readonly System.IntPtr NativeFieldInfoPtr_counter;
  private static readonly System.IntPtr NativeFieldInfoPtr_canBeHit;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_attackEffects;
  private static readonly System.IntPtr NativeFieldInfoPtr_mainSprite;
  private static readonly System.IntPtr NativeFieldInfoPtr_backgroundSprite;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardType;
  private static readonly System.IntPtr NativeFieldInfoPtr_playType;
  private static readonly System.IntPtr NativeFieldInfoPtr_needsTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_canPlayOnBoard;
  private static readonly System.IntPtr NativeFieldInfoPtr_canPlayOnHand;
  private static readonly System.IntPtr NativeFieldInfoPtr_canPlayOnFriendly;
  private static readonly System.IntPtr NativeFieldInfoPtr_canPlayOnEnemy;
  private static readonly System.IntPtr NativeFieldInfoPtr_playOnSlot;
  private static readonly System.IntPtr NativeFieldInfoPtr_canShoveToOtherRow;
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultPlayPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_uses;
  private static readonly System.IntPtr NativeFieldInfoPtr_startWithEffects;
  private static readonly System.IntPtr NativeFieldInfoPtr_traits;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetConstraints;
  private static readonly System.IntPtr NativeFieldInfoPtr_effectBonus;
  private static readonly System.IntPtr NativeFieldInfoPtr_effectFactor;
  private static readonly System.IntPtr NativeFieldInfoPtr_injuries;
  private static readonly System.IntPtr NativeFieldInfoPtr_upgrades;
  private static readonly System.IntPtr NativeFieldInfoPtr_random3;
  private static readonly System.IntPtr NativeFieldInfoPtr_charmSlots;
  private static readonly System.IntPtr NativeFieldInfoPtr_tokenSlots;
  private static readonly System.IntPtr NativeFieldInfoPtr_crownSlots;
  private static readonly System.IntPtr NativeFieldInfoPtr_scriptableImagePrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_createScripts;
  private static readonly System.IntPtr NativeFieldInfoPtr_customData;
  private static readonly System.IntPtr NativeFieldInfoPtr__original_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_id_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_id_Private_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetId_Private_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_title_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasCustomText_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomText_Public_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsItem_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DoesShove_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_original_Public_get_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_original_Private_set_Void_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasCrown_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCrown_Public_CardUpgradeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveCrown_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_CardData_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_CardData_Vector3_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_CardData_Vector3_UInt64_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunCreateScripts_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCustomData_Public_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCustomData_Public_Boolean_String_byref_T_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsOffensive_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CardSaveData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe ulong id
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_get_id_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_set_id_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108223, XrefRangeEnd = 108225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetId(ulong value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_SetId_Private_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public unsafe string title
  {
    [CallerCount(34), CachedScanResults(RefRangeStart = 108228, RefRangeEnd = 108262, XrefRangeStart = 108225, XrefRangeEnd = 108228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_get_title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
  }

  public unsafe bool HasCustomText
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 108263, RefRangeEnd = 108267, XrefRangeStart = 108262, XrefRangeEnd = 108263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_get_HasCustomText_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 108289, RefRangeEnd = 108293, XrefRangeStart = 108267, XrefRangeEnd = 108289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string GetCustomText(bool silenced = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &silenced
    };
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_GetCustomText_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  public unsafe bool IsItem
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_get_IsItem_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool DoesShove
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_get_DoesShove_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe CardData original
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_get_original_Public_get_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108293, XrefRangeEnd = 108294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_set_original_Private_set_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe bool HasCrown
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 108299, RefRangeEnd = 108303, XrefRangeStart = 108294, XrefRangeEnd = 108299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_get_HasCrown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 108322, RefRangeEnd = 108327, XrefRangeStart = 108303, XrefRangeEnd = 108322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardUpgradeData GetCrown()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_GetCrown_Public_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CardUpgradeData) null : new CardUpgradeData(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 108329, RefRangeEnd = 108330, XrefRangeStart = 108327, XrefRangeEnd = 108329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveCrown()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_RemoveCrown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(32)]
  [CachedScanResults(RefRangeStart = 108337, RefRangeEnd = 108369, XrefRangeStart = 108330, XrefRangeEnd = 108337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardData Clone(bool runCreateScripts = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &runCreateScripts
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_Clone_Public_CardData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 108372, RefRangeEnd = 108373, XrefRangeStart = 108369, XrefRangeEnd = 108372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardData Clone(Vector3 random3, bool runCreateScripts = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &random3;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &runCreateScripts;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_Clone_Public_CardData_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 108422, RefRangeEnd = 108427, XrefRangeStart = 108373, XrefRangeEnd = 108422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardData Clone(Vector3 random3, ulong id, bool runCreateScripts = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &random3;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &runCreateScripts;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_Clone_Public_CardData_Vector3_UInt64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108427, XrefRangeEnd = 108435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RunCreateScripts()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_RunCreateScripts_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 108446, RefRangeEnd = 108450, XrefRangeStart = 108435, XrefRangeEnd = 108446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetCustomData(string key, Il2CppSystem.Object value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_SetCustomData_Public_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108450, XrefRangeEnd = 108460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGetCustomData<T>(string key, out T value, T defaultValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      zero = System.IntPtr.Zero;
      local1 = ref (*(T*) &zero);
    }
    else
      local1 = ref value;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local2;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local3 = (object) defaultValue;
      if (!(local3 is string))
      {
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local3 as Il2CppObjectBase);
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local2 = ptr == System.IntPtr.Zero ? (T&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (T&) ptr : (T&) IL2CPP.il2cpp_object_unbox(ptr));
      }
      else
      {
        // ISSUE: cast to a reference type
        local2 = (T&) IL2CPP.ManagedStringToIl2Cpp(local3 as string);
      }
    }
    else
      local2 = ref defaultValue;
    *(System.IntPtr*) num2 = (System.IntPtr) ref local2;
    System.IntPtr exc;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(CardData.MethodInfoStoreGeneric_TryGetCustomData_Public_Boolean_String_byref_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    if (!typeof (T).IsValueType)
    {
      ref T local4 = ref value;
      System.IntPtr objectPointer = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
      local4 = (T) valueGeneric;
    }
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 108500, RefRangeEnd = 108501, XrefRangeStart = 108460, XrefRangeEnd = 108500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsOffensive()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_IsOffensive_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 108505, RefRangeEnd = 108507, XrefRangeStart = 108501, XrefRangeEnd = 108505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe CardSaveData Save()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CardSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CardSaveData) null : new CardSaveData(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108507, XrefRangeEnd = 108512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108512, XrefRangeEnd = 108513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardData()
  {
    Il2CppClassPointerStore<CardData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardData>.NativeClassPtr);
    CardData.NativeFieldInfoPtr_idCurrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (idCurrent));
    CardData.NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "<id>k__BackingField");
    CardData.NativeFieldInfoPtr_titleFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (titleFallback));
    CardData.NativeFieldInfoPtr_forceTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (forceTitle));
    CardData.NativeFieldInfoPtr_desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (desc));
    CardData.NativeFieldInfoPtr_titleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (titleKey));
    CardData.NativeFieldInfoPtr_textKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (textKey));
    CardData.NativeFieldInfoPtr_textInsert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (textInsert));
    CardData.NativeFieldInfoPtr_flavour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (flavour));
    CardData.NativeFieldInfoPtr_flavourKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (flavourKey));
    CardData.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (value));
    CardData.NativeFieldInfoPtr_idleAnimationProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (idleAnimationProfile));
    CardData.NativeFieldInfoPtr_greetMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (greetMessages));
    CardData.NativeFieldInfoPtr_bloodProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (bloodProfile));
    CardData.NativeFieldInfoPtr_hasAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (hasAttack));
    CardData.NativeFieldInfoPtr_damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (damage));
    CardData.NativeFieldInfoPtr_hasHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (hasHealth));
    CardData.NativeFieldInfoPtr_hp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (hp));
    CardData.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (counter));
    CardData.NativeFieldInfoPtr_canBeHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (canBeHit));
    CardData.NativeFieldInfoPtr_targetMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (targetMode));
    CardData.NativeFieldInfoPtr_attackEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (attackEffects));
    CardData.NativeFieldInfoPtr_mainSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (mainSprite));
    CardData.NativeFieldInfoPtr_backgroundSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (backgroundSprite));
    CardData.NativeFieldInfoPtr_cardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (cardType));
    CardData.NativeFieldInfoPtr_playType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (playType));
    CardData.NativeFieldInfoPtr_needsTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (needsTarget));
    CardData.NativeFieldInfoPtr_canPlayOnBoard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (canPlayOnBoard));
    CardData.NativeFieldInfoPtr_canPlayOnHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (canPlayOnHand));
    CardData.NativeFieldInfoPtr_canPlayOnFriendly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (canPlayOnFriendly));
    CardData.NativeFieldInfoPtr_canPlayOnEnemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (canPlayOnEnemy));
    CardData.NativeFieldInfoPtr_playOnSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (playOnSlot));
    CardData.NativeFieldInfoPtr_canShoveToOtherRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (canShoveToOtherRow));
    CardData.NativeFieldInfoPtr_defaultPlayPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (defaultPlayPosition));
    CardData.NativeFieldInfoPtr_uses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (uses));
    CardData.NativeFieldInfoPtr_startWithEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (startWithEffects));
    CardData.NativeFieldInfoPtr_traits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (traits));
    CardData.NativeFieldInfoPtr_targetConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (targetConstraints));
    CardData.NativeFieldInfoPtr_effectBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (effectBonus));
    CardData.NativeFieldInfoPtr_effectFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (effectFactor));
    CardData.NativeFieldInfoPtr_injuries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (injuries));
    CardData.NativeFieldInfoPtr_upgrades = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (upgrades));
    CardData.NativeFieldInfoPtr_random3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (random3));
    CardData.NativeFieldInfoPtr_charmSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (charmSlots));
    CardData.NativeFieldInfoPtr_tokenSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (tokenSlots));
    CardData.NativeFieldInfoPtr_crownSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (crownSlots));
    CardData.NativeFieldInfoPtr_scriptableImagePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (scriptableImagePrefab));
    CardData.NativeFieldInfoPtr_createScripts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (createScripts));
    CardData.NativeFieldInfoPtr_customData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (customData));
    CardData.NativeFieldInfoPtr__original_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "<original>k__BackingField");
    CardData.NativeMethodInfoPtr_get_id_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673245);
    CardData.NativeMethodInfoPtr_set_id_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673246);
    CardData.NativeMethodInfoPtr_SetId_Private_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673247);
    CardData.NativeMethodInfoPtr_get_title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673248);
    CardData.NativeMethodInfoPtr_get_HasCustomText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673249);
    CardData.NativeMethodInfoPtr_GetCustomText_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673250);
    CardData.NativeMethodInfoPtr_get_IsItem_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673251);
    CardData.NativeMethodInfoPtr_get_DoesShove_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673252);
    CardData.NativeMethodInfoPtr_get_original_Public_get_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673253);
    CardData.NativeMethodInfoPtr_set_original_Private_set_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673254);
    CardData.NativeMethodInfoPtr_get_HasCrown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673255);
    CardData.NativeMethodInfoPtr_GetCrown_Public_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673256);
    CardData.NativeMethodInfoPtr_RemoveCrown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673257);
    CardData.NativeMethodInfoPtr_Clone_Public_CardData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673258);
    CardData.NativeMethodInfoPtr_Clone_Public_CardData_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673259);
    CardData.NativeMethodInfoPtr_Clone_Public_CardData_Vector3_UInt64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673260);
    CardData.NativeMethodInfoPtr_RunCreateScripts_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673261);
    CardData.NativeMethodInfoPtr_SetCustomData_Public_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673262);
    CardData.NativeMethodInfoPtr_TryGetCustomData_Public_Boolean_String_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673263);
    CardData.NativeMethodInfoPtr_IsOffensive_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673264);
    CardData.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CardSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673265);
    CardData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673266);
    CardData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673267);
  }

  public CardData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe ulong idCurrent
  {
    get
    {
      ulong idCurrent;
      IL2CPP.il2cpp_field_static_get_value(CardData.NativeFieldInfoPtr_idCurrent, (void*) &idCurrent);
      return idCurrent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CardData.NativeFieldInfoPtr_idCurrent, (void*) &value);
    }
  }

  public unsafe ulong _id_k__BackingField
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr__id_k__BackingField));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr__id_k__BackingField)) = value;
    }
  }

  public unsafe string titleFallback
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_titleFallback)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_titleFallback), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string forceTitle
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_forceTitle)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_forceTitle), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string desc
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_desc)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_desc), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe LocalizedString titleKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_titleKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_titleKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString textKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_textKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_textKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string textInsert
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_textInsert)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_textInsert), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string flavour
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_flavour)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_flavour), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe LocalizedString flavourKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_flavourKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_flavourKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int value
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_value));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_value)) = value;
    }
  }

  public unsafe CardAnimationProfile idleAnimationProfile
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_idleAnimationProfile));
      return pointer == System.IntPtr.Zero ? (CardAnimationProfile) null : new CardAnimationProfile(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_idleAnimationProfile), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStringArray greetMessages
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_greetMessages));
      return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_greetMessages), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BloodProfile bloodProfile
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_bloodProfile));
      return pointer == System.IntPtr.Zero ? (BloodProfile) null : new BloodProfile(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_bloodProfile), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool hasAttack
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_hasAttack));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_hasAttack)) = value;
    }
  }

  public unsafe int damage
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_damage));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_damage)) = value;
    }
  }

  public unsafe bool hasHealth
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_hasHealth));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_hasHealth)) = value;
    }
  }

  public unsafe int hp
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_hp));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_hp)) = value;
    }
  }

  public unsafe int counter
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_counter));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_counter)) = value;
    }
  }

  public unsafe bool canBeHit
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canBeHit));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canBeHit)) = value;
    }
  }

  public unsafe TargetMode targetMode
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_targetMode));
      return pointer == System.IntPtr.Zero ? (TargetMode) null : new TargetMode(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_targetMode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardData.StatusEffectStacks> attackEffects
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_attackEffects));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardData.StatusEffectStacks>) null : new Il2CppReferenceArray<CardData.StatusEffectStacks>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_attackEffects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite mainSprite
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_mainSprite));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_mainSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite backgroundSprite
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_backgroundSprite));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_backgroundSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardType cardType
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_cardType));
      return pointer == System.IntPtr.Zero ? (CardType) null : new CardType(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_cardType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Card.PlayType playType
  {
    get
    {
      return *(Card.PlayType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_playType));
    }
    [param: In] set
    {
      *(Card.PlayType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_playType)) = value;
    }
  }

  public unsafe bool needsTarget
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_needsTarget));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_needsTarget)) = value;
    }
  }

  public unsafe bool canPlayOnBoard
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canPlayOnBoard));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canPlayOnBoard)) = value;
    }
  }

  public unsafe bool canPlayOnHand
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canPlayOnHand));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canPlayOnHand)) = value;
    }
  }

  public unsafe bool canPlayOnFriendly
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canPlayOnFriendly));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canPlayOnFriendly)) = value;
    }
  }

  public unsafe bool canPlayOnEnemy
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canPlayOnEnemy));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canPlayOnEnemy)) = value;
    }
  }

  public unsafe bool playOnSlot
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_playOnSlot));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_playOnSlot)) = value;
    }
  }

  public unsafe bool canShoveToOtherRow
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canShoveToOtherRow));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canShoveToOtherRow)) = value;
    }
  }

  public unsafe CardData.PlayPosition defaultPlayPosition
  {
    get
    {
      return *(CardData.PlayPosition*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_defaultPlayPosition));
    }
    [param: In] set
    {
      *(CardData.PlayPosition*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_defaultPlayPosition)) = value;
    }
  }

  public unsafe int uses
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_uses));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_uses)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<CardData.StatusEffectStacks> startWithEffects
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_startWithEffects));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardData.StatusEffectStacks>) null : new Il2CppReferenceArray<CardData.StatusEffectStacks>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_startWithEffects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<CardData.TraitStacks> traits
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_traits));
      return pointer == System.IntPtr.Zero ? (List<CardData.TraitStacks>) null : new List<CardData.TraitStacks>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_traits), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<TargetConstraint> targetConstraints
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_targetConstraints));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<TargetConstraint>) null : new Il2CppReferenceArray<TargetConstraint>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_targetConstraints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int effectBonus
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_effectBonus));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_effectBonus)) = value;
    }
  }

  public unsafe float effectFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_effectFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_effectFactor)) = value;
    }
  }

  public unsafe List<CardData.StatusEffectStacks> injuries
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_injuries));
      return pointer == System.IntPtr.Zero ? (List<CardData.StatusEffectStacks>) null : new List<CardData.StatusEffectStacks>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_injuries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<CardUpgradeData> upgrades
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_upgrades));
      return pointer == System.IntPtr.Zero ? (List<CardUpgradeData>) null : new List<CardUpgradeData>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_upgrades), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 random3
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_random3));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_random3)) = value;
    }
  }

  public unsafe int charmSlots
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_charmSlots));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_charmSlots)) = value;
    }
  }

  public unsafe int tokenSlots
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_tokenSlots));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_tokenSlots)) = value;
    }
  }

  public unsafe int crownSlots
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_crownSlots));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_crownSlots)) = value;
    }
  }

  public unsafe ScriptableCardImage scriptableImagePrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_scriptableImagePrefab));
      return pointer == System.IntPtr.Zero ? (ScriptableCardImage) null : new ScriptableCardImage(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_scriptableImagePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardScript> createScripts
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_createScripts));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardScript>) null : new Il2CppReferenceArray<CardScript>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_createScripts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, Il2CppSystem.Object> customData
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_customData));
      return pointer == System.IntPtr.Zero ? (Dictionary<string, Il2CppSystem.Object>) null : new Dictionary<string, Il2CppSystem.Object>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_customData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardData _original_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr__original_k__BackingField));
      return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr__original_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum PlayPosition
  {
    None,
    Friendly,
    Enemy,
    Hand,
    FriendlyRow,
    EnemyRow,
    Field,
    FriendlySlot,
    EnemySlot,
  }

  [Serializable]
  public class StatusEffectStacks : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_data;
    private static readonly System.IntPtr NativeFieldInfoPtr_count;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_StatusEffectData_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Final_New_StatusEffectSaveData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Stack_Public_Static_Il2CppReferenceArray_1_StatusEffectStacks_IEnumerable_1_StatusEffectStacks_IEnumerable_1_StatusEffectStacks_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_StatusEffectStacks_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StatusEffectStacks()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardData.StatusEffectStacks.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 25868, RefRangeEnd = 25881, XrefRangeStart = 25868, XrefRangeEnd = 25881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StatusEffectStacks(StatusEffectData data, int count)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardData.StatusEffectStacks.NativeMethodInfoPtr__ctor_Public_Void_StatusEffectData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 108137, RefRangeEnd = 108138, XrefRangeStart = 108131, XrefRangeEnd = 108137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe StatusEffectSaveData Save()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardData.StatusEffectStacks.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_StatusEffectSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (StatusEffectSaveData) null : new StatusEffectSaveData(pointer);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 108182, RefRangeEnd = 108192, XrefRangeStart = 108138, XrefRangeEnd = 108182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppReferenceArray<CardData.StatusEffectStacks> Stack(
      IEnumerable<CardData.StatusEffectStacks> currentEffects,
      IEnumerable<CardData.StatusEffectStacks> newEffects)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentEffects);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newEffects);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardData.StatusEffectStacks.NativeMethodInfoPtr_Stack_Public_Static_Il2CppReferenceArray_1_StatusEffectStacks_IEnumerable_1_StatusEffectStacks_IEnumerable_1_StatusEffectStacks_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardData.StatusEffectStacks>) null : new Il2CppReferenceArray<CardData.StatusEffectStacks>(nativeObject);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108192, XrefRangeEnd = 108199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardData.StatusEffectStacks.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 108204, RefRangeEnd = 108208, XrefRangeStart = 108199, XrefRangeEnd = 108204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CardData.StatusEffectStacks Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardData.StatusEffectStacks.NativeMethodInfoPtr_Clone_Public_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardData.StatusEffectStacks) null : new CardData.StatusEffectStacks(pointer);
    }

    static StatusEffectStacks()
    {
      Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (StatusEffectStacks));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr);
      CardData.StatusEffectStacks.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr, nameof (data));
      CardData.StatusEffectStacks.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr, nameof (count));
      CardData.StatusEffectStacks.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr, 100673268);
      CardData.StatusEffectStacks.NativeMethodInfoPtr__ctor_Public_Void_StatusEffectData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr, 100673269);
      CardData.StatusEffectStacks.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_StatusEffectSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr, 100673270);
      CardData.StatusEffectStacks.NativeMethodInfoPtr_Stack_Public_Static_Il2CppReferenceArray_1_StatusEffectStacks_IEnumerable_1_StatusEffectStacks_IEnumerable_1_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr, 100673271);
      CardData.StatusEffectStacks.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr, 100673272);
      CardData.StatusEffectStacks.NativeMethodInfoPtr_Clone_Public_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr, 100673273);
    }

    public StatusEffectStacks(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe StatusEffectData data
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.StatusEffectStacks.NativeFieldInfoPtr_data));
        return pointer == System.IntPtr.Zero ? (StatusEffectData) null : new StatusEffectData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.StatusEffectStacks.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int count
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.StatusEffectStacks.NativeFieldInfoPtr_count));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.StatusEffectStacks.NativeFieldInfoPtr_count)) = value;
      }
    }

    [ObfuscatedName("CardData/StatusEffectStacks/<>c__DisplayClass5_0")]
    public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_e;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Stack_b__0_Internal_Boolean_StatusEffectStacks_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass5_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardData.StatusEffectStacks.__c__DisplayClass5_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CardData.StatusEffectStacks.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108094, XrefRangeEnd = 108131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _Stack_b__0(CardData.StatusEffectStacks a)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
        };
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardData.StatusEffectStacks.__c__DisplayClass5_0.NativeMethodInfoPtr__Stack_b__0_Internal_Boolean_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass5_0()
      {
        Il2CppClassPointerStore<CardData.StatusEffectStacks.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr, "<>c__DisplayClass5_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardData.StatusEffectStacks.__c__DisplayClass5_0>.NativeClassPtr);
        CardData.StatusEffectStacks.__c__DisplayClass5_0.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData.StatusEffectStacks.__c__DisplayClass5_0>.NativeClassPtr, nameof (e));
        CardData.StatusEffectStacks.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.StatusEffectStacks.__c__DisplayClass5_0>.NativeClassPtr, 100673274);
        CardData.StatusEffectStacks.__c__DisplayClass5_0.NativeMethodInfoPtr__Stack_b__0_Internal_Boolean_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.StatusEffectStacks.__c__DisplayClass5_0>.NativeClassPtr, 100673275);
      }

      public __c__DisplayClass5_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe CardData.StatusEffectStacks e
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.StatusEffectStacks.__c__DisplayClass5_0.NativeFieldInfoPtr_e));
          return pointer == System.IntPtr.Zero ? (CardData.StatusEffectStacks) null : new CardData.StatusEffectStacks(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.StatusEffectStacks.__c__DisplayClass5_0.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  [Serializable]
  public class TraitStacks : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_data;
    private static readonly System.IntPtr NativeFieldInfoPtr_count;
    private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Final_New_TraitSaveData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108208, XrefRangeEnd = 108214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe TraitSaveData Save()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardData.TraitStacks.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_TraitSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (TraitSaveData) null : new TraitSaveData(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108214, XrefRangeEnd = 108221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardData.TraitStacks.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TraitStacks()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardData.TraitStacks>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardData.TraitStacks.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TraitStacks()
    {
      Il2CppClassPointerStore<CardData.TraitStacks>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardData>.NativeClassPtr, nameof (TraitStacks));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardData.TraitStacks>.NativeClassPtr);
      CardData.TraitStacks.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData.TraitStacks>.NativeClassPtr, nameof (data));
      CardData.TraitStacks.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData.TraitStacks>.NativeClassPtr, nameof (count));
      CardData.TraitStacks.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_TraitSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.TraitStacks>.NativeClassPtr, 100673276);
      CardData.TraitStacks.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.TraitStacks>.NativeClassPtr, 100673277);
      CardData.TraitStacks.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.TraitStacks>.NativeClassPtr, 100673278);
    }

    public TraitStacks(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TraitData data
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.TraitStacks.NativeFieldInfoPtr_data));
        return pointer == System.IntPtr.Zero ? (TraitData) null : new TraitData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardData.TraitStacks.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int count
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.TraitStacks.NativeFieldInfoPtr_count));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardData.TraitStacks.NativeFieldInfoPtr_count)) = value;
      }
    }
  }

  [ObfuscatedName("CardData/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__69_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__73_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__73_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__77_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__77_1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetCrown_b__69_0_Internal_Boolean_CardUpgradeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Clone_b__73_0_Internal_String_KeyValuePair_2_String_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Clone_b__73_1_Internal_Object_KeyValuePair_2_String_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__IsOffensive_b__77_0_Internal_Boolean_StatusEffectStacks_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__IsOffensive_b__77_1_Internal_Boolean_StatusEffectStacks_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _GetCrown_b__69_0(CardUpgradeData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardData.__c.NativeMethodInfoPtr__GetCrown_b__69_0_Internal_Boolean_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108221, XrefRangeEnd = 108222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _Clone_b__73_0(KeyValuePair<string, Il2CppSystem.Object> entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) entry))
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CardData.__c.NativeMethodInfoPtr__Clone_b__73_0_Internal_String_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108222, XrefRangeEnd = 108223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppSystem.Object _Clone_b__73_1(KeyValuePair<string, Il2CppSystem.Object> entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) entry))
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardData.__c.NativeMethodInfoPtr__Clone_b__73_1_Internal_Object_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(0)]
    public unsafe bool _IsOffensive_b__77_0(CardData.StatusEffectStacks s)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) s)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardData.__c.NativeMethodInfoPtr__IsOffensive_b__77_0_Internal_Boolean_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool _IsOffensive_b__77_1(CardData.StatusEffectStacks s)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) s)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardData.__c.NativeMethodInfoPtr__IsOffensive_b__77_1_Internal_Boolean_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<CardData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardData>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr);
      CardData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, "<>9");
      CardData.__c.NativeFieldInfoPtr___9__69_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, "<>9__69_0");
      CardData.__c.NativeFieldInfoPtr___9__73_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, "<>9__73_0");
      CardData.__c.NativeFieldInfoPtr___9__73_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, "<>9__73_1");
      CardData.__c.NativeFieldInfoPtr___9__77_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, "<>9__77_0");
      CardData.__c.NativeFieldInfoPtr___9__77_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, "<>9__77_1");
      CardData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, 100673280);
      CardData.__c.NativeMethodInfoPtr__GetCrown_b__69_0_Internal_Boolean_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, 100673281);
      CardData.__c.NativeMethodInfoPtr__Clone_b__73_0_Internal_String_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, 100673282);
      CardData.__c.NativeMethodInfoPtr__Clone_b__73_1_Internal_Object_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, 100673283);
      CardData.__c.NativeMethodInfoPtr__IsOffensive_b__77_0_Internal_Boolean_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, 100673284);
      CardData.__c.NativeMethodInfoPtr__IsOffensive_b__77_1_Internal_Boolean_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, 100673285);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe CardData.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CardData.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (CardData.__c) null : new CardData.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CardData.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Predicate<CardUpgradeData> __9__69_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CardData.__c.NativeFieldInfoPtr___9__69_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Predicate<CardUpgradeData>) null : new Il2CppSystem.Predicate<CardUpgradeData>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CardData.__c.NativeFieldInfoPtr___9__69_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<KeyValuePair<string, Il2CppSystem.Object>, string> __9__73_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CardData.__c.NativeFieldInfoPtr___9__73_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair<string, Il2CppSystem.Object>, string>) null : new Il2CppSystem.Func<KeyValuePair<string, Il2CppSystem.Object>, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CardData.__c.NativeFieldInfoPtr___9__73_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<KeyValuePair<string, Il2CppSystem.Object>, Il2CppSystem.Object> __9__73_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CardData.__c.NativeFieldInfoPtr___9__73_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair<string, Il2CppSystem.Object>, Il2CppSystem.Object>) null : new Il2CppSystem.Func<KeyValuePair<string, Il2CppSystem.Object>, Il2CppSystem.Object>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CardData.__c.NativeFieldInfoPtr___9__73_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData.StatusEffectStacks, bool> __9__77_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CardData.__c.NativeFieldInfoPtr___9__77_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData.StatusEffectStacks, bool>) null : new Il2CppSystem.Func<CardData.StatusEffectStacks, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CardData.__c.NativeFieldInfoPtr___9__77_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData.StatusEffectStacks, bool> __9__77_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CardData.__c.NativeFieldInfoPtr___9__77_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData.StatusEffectStacks, bool>) null : new Il2CppSystem.Func<CardData.StatusEffectStacks, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CardData.__c.NativeFieldInfoPtr___9__77_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_TryGetCustomData_Public_Boolean_String_byref_T_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CardData.NativeMethodInfoPtr_TryGetCustomData_Public_Boolean_String_byref_T_T_0, Il2CppClassPointerStore<CardData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
