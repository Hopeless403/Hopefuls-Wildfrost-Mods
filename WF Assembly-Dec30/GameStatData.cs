// Decompiled with JetBrains decompiler
// Type: GameStatData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class GameStatData : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_stringKey;
  private static readonly IntPtr NativeFieldInfoPtr_type;
  private static readonly IntPtr NativeFieldInfoPtr_statName;
  private static readonly IntPtr NativeFieldInfoPtr_statKey;
  private static readonly IntPtr NativeFieldInfoPtr_statKeyOver;
  private static readonly IntPtr NativeFieldInfoPtr_defaultValue;
  private static readonly IntPtr NativeFieldInfoPtr_displayOrder;
  private static readonly IntPtr NativeFieldInfoPtr_priority;
  private static readonly IntPtr NativeFieldInfoPtr_par;
  private static readonly IntPtr NativeFieldInfoPtr_priorityAddOverPar;
  private static readonly IntPtr NativeFieldInfoPtr_prioritySubUnderPar;
  private static readonly IntPtr NativeFieldInfoPtr_overwrites;
  private static readonly IntPtr NativeMethodInfoPtr_get_NeedsStatName_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_NeedsKey_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_NeedsDefault_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_NeedsRate_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPriority_Public_Single_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Single_CampaignStats_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetBestValue_Private_Int32_CampaignStats_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetNormalValue_Private_Int32_CampaignStats_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetRateValue_Private_Single_CampaignStats_0;
  private static readonly IntPtr NativeMethodInfoPtr_HasMultipleStatKeys_Private_Static_Boolean_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetStatKeys_Private_Static_IEnumerable_1_String_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetStringValue_Public_String_CampaignStats_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetRandomStringValue_Private_String_CampaignStats_0;
  private static readonly IntPtr NativeMethodInfoPtr_FromSeconds_Private_Static_String_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe bool NeedsStatName
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameStatData.NativeMethodInfoPtr_get_NeedsStatName_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool NeedsKey
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameStatData.NativeMethodInfoPtr_get_NeedsKey_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool NeedsDefault
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameStatData.NativeMethodInfoPtr_get_NeedsDefault_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool NeedsRate
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameStatData.NativeMethodInfoPtr_get_NeedsRate_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 109509, RefRangeEnd = 109511, XrefRangeStart = 109509, XrefRangeEnd = 109509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetPriority(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameStatData.NativeMethodInfoPtr_GetPriority_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 109519, RefRangeEnd = 109523, XrefRangeStart = 109511, XrefRangeEnd = 109519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetValue(CampaignStats stats)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stats)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameStatData.NativeMethodInfoPtr_GetValue_Public_Single_CampaignStats_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 109532, RefRangeEnd = 109533, XrefRangeStart = 109523, XrefRangeEnd = 109532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetBestValue(CampaignStats stats, string statKey)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stats);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(statKey);
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameStatData.NativeMethodInfoPtr_GetBestValue_Private_Int32_CampaignStats_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 109539, RefRangeEnd = 109541, XrefRangeStart = 109533, XrefRangeEnd = 109539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetNormalValue(CampaignStats stats, string statKey)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stats);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(statKey);
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameStatData.NativeMethodInfoPtr_GetNormalValue_Private_Int32_CampaignStats_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109541, XrefRangeEnd = 109543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetRateValue(CampaignStats stats)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stats)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameStatData.NativeMethodInfoPtr_GetRateValue_Private_Single_CampaignStats_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109543, XrefRangeEnd = 109545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool HasMultipleStatKeys(string @in)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(@in)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameStatData.NativeMethodInfoPtr_HasMultipleStatKeys_Private_Static_Boolean_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109545, XrefRangeEnd = 109547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IEnumerable<string> GetStatKeys(string @in)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(@in)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameStatData.NativeMethodInfoPtr_GetStatKeys_Private_Static_IEnumerable_1_String_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (IEnumerable<string>) null : new IEnumerable<string>(pointer);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 109554, RefRangeEnd = 109558, XrefRangeStart = 109547, XrefRangeEnd = 109554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string GetStringValue(CampaignStats stats, float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stats);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr exc;
    IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GameStatData.NativeMethodInfoPtr_GetStringValue_Public_String_CampaignStats_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109558, XrefRangeEnd = 109567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string GetRandomStringValue(CampaignStats stats)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stats)
    };
    IntPtr exc;
    IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GameStatData.NativeMethodInfoPtr_GetRandomStringValue_Private_String_CampaignStats_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109567, XrefRangeEnd = 109584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string FromSeconds(float seconds)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &seconds
    };
    IntPtr exc;
    IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GameStatData.NativeMethodInfoPtr_FromSeconds_Private_Static_String_Single_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109584, XrefRangeEnd = 109585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GameStatData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameStatData>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GameStatData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static GameStatData()
  {
    Il2CppClassPointerStore<GameStatData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (GameStatData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameStatData>.NativeClassPtr);
    GameStatData.NativeFieldInfoPtr_stringKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, nameof (stringKey));
    GameStatData.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, nameof (type));
    GameStatData.NativeFieldInfoPtr_statName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, nameof (statName));
    GameStatData.NativeFieldInfoPtr_statKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, nameof (statKey));
    GameStatData.NativeFieldInfoPtr_statKeyOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, nameof (statKeyOver));
    GameStatData.NativeFieldInfoPtr_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, nameof (defaultValue));
    GameStatData.NativeFieldInfoPtr_displayOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, nameof (displayOrder));
    GameStatData.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, nameof (priority));
    GameStatData.NativeFieldInfoPtr_par = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, nameof (par));
    GameStatData.NativeFieldInfoPtr_priorityAddOverPar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, nameof (priorityAddOverPar));
    GameStatData.NativeFieldInfoPtr_prioritySubUnderPar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, nameof (prioritySubUnderPar));
    GameStatData.NativeFieldInfoPtr_overwrites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, nameof (overwrites));
    GameStatData.NativeMethodInfoPtr_get_NeedsStatName_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, 100673394);
    GameStatData.NativeMethodInfoPtr_get_NeedsKey_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, 100673395);
    GameStatData.NativeMethodInfoPtr_get_NeedsDefault_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, 100673396);
    GameStatData.NativeMethodInfoPtr_get_NeedsRate_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, 100673397);
    GameStatData.NativeMethodInfoPtr_GetPriority_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, 100673398);
    GameStatData.NativeMethodInfoPtr_GetValue_Public_Single_CampaignStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, 100673399);
    GameStatData.NativeMethodInfoPtr_GetBestValue_Private_Int32_CampaignStats_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, 100673400);
    GameStatData.NativeMethodInfoPtr_GetNormalValue_Private_Int32_CampaignStats_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, 100673401);
    GameStatData.NativeMethodInfoPtr_GetRateValue_Private_Single_CampaignStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, 100673402);
    GameStatData.NativeMethodInfoPtr_HasMultipleStatKeys_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, 100673403);
    GameStatData.NativeMethodInfoPtr_GetStatKeys_Private_Static_IEnumerable_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, 100673404);
    GameStatData.NativeMethodInfoPtr_GetStringValue_Public_String_CampaignStats_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, 100673405);
    GameStatData.NativeMethodInfoPtr_GetRandomStringValue_Private_String_CampaignStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, 100673406);
    GameStatData.NativeMethodInfoPtr_FromSeconds_Private_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, 100673407);
    GameStatData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStatData>.NativeClassPtr, 100673408);
  }

  public GameStatData(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LocalizedString stringKey
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_stringKey));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_stringKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameStatData.Type type
  {
    get
    {
      return *(GameStatData.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_type));
    }
    [param: In] set
    {
      *(GameStatData.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_type)) = value;
    }
  }

  public unsafe string statName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_statName)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_statName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string statKey
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_statKey)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_statKey), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string statKeyOver
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_statKeyOver)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_statKeyOver), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int defaultValue
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_defaultValue));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_defaultValue)) = value;
    }
  }

  public unsafe float displayOrder
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_displayOrder));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_displayOrder)) = value;
    }
  }

  public unsafe float priority
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_priority));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_priority)) = value;
    }
  }

  public unsafe float par
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_par));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_par)) = value;
    }
  }

  public unsafe float priorityAddOverPar
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_priorityAddOverPar));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_priorityAddOverPar)) = value;
    }
  }

  public unsafe float prioritySubUnderPar
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_prioritySubUnderPar));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_prioritySubUnderPar)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<GameStatData> overwrites
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_overwrites));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<GameStatData>) null : new Il2CppReferenceArray<GameStatData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameStatData.NativeFieldInfoPtr_overwrites), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum Type
  {
    Normal,
    Best,
    BestAny,
    Count,
    Time,
    RandomKey,
    Rate,
    BestTime,
  }
}
