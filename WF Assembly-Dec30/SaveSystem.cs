// Decompiled with JetBrains decompiler
// Type: SaveSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
public class SaveSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instance;
  private static readonly System.IntPtr NativeFieldInfoPtr__Profile_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_encode;
  private static readonly System.IntPtr NativeFieldInfoPtr_beautify;
  private static readonly System.IntPtr NativeFieldInfoPtr_promptSave;
  private static readonly System.IntPtr NativeFieldInfoPtr_busy;
  private static readonly System.IntPtr NativeFieldInfoPtr_profileFolder;
  private static readonly System.IntPtr NativeFieldInfoPtr_folderName;
  private static readonly System.IntPtr NativeFieldInfoPtr_progressSaver;
  private static readonly System.IntPtr NativeFieldInfoPtr_campaignSaver;
  private static readonly System.IntPtr NativeFieldInfoPtr_battleSaver;
  private static readonly System.IntPtr NativeFieldInfoPtr_statsSaver;
  private static readonly System.IntPtr NativeFieldInfoPtr_historySaver;
  private static readonly System.IntPtr NativeFieldInfoPtr_settings;
  private static readonly System.IntPtr NativeFieldInfoPtr_gotSaveTimestamp;
  private static readonly System.IntPtr NativeFieldInfoPtr_saveTimestamp;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Enabled_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Profile_Public_Static_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Profile_Private_Static_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SaveProgressData_Public_Static_Void_String_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SaveCampaignData_Public_Static_Void_GameMode_String_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SaveStatsData_Public_Static_Void_String_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SaveHistoryData_Public_Static_Void_String_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadProgressData_Public_Static_T_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadCampaignData_Public_Static_T_GameMode_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadStatsData_Public_Static_T_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadHistoryData_Public_Static_T_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadProgressData_Public_Static_T_String_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadCampaignData_Public_Static_T_GameMode_String_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadStatsData_Public_Static_T_String_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadHistoryData_Public_Static_T_String_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProgressExists_Public_Static_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CampaignExists_Public_Static_Boolean_GameMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StatsExists_Public_Static_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HistoryExists_Public_Static_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProgressDataExists_Public_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CampaignDataExists_Public_Static_Boolean_GameMode_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StatsDataExists_Public_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HistoryDataExists_Public_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeleteProgress_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeleteCampaign_Public_Static_Void_GameMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeleteProfile_Public_Static_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeleteStats_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeleteHistory_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeleteProgressData_Public_Static_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetProfile_Public_Static_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetProfile_Public_Static_Void_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncryptSaveData_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConvertSaveFile_Private_Static_Void_Saver_String_String_ES3Settings_ES3Settings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public static unsafe bool Enabled
  {
    [CallerCount(29), CachedScanResults(RefRangeStart = 69446, RefRangeEnd = 69475, XrefRangeStart = 69438, XrefRangeEnd = 69446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_get_Enabled_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public static unsafe string Profile
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69475, XrefRangeEnd = 69479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_get_Profile_Public_Static_get_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69479, XrefRangeEnd = 69485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_set_Profile_Private_Static_set_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69485, XrefRangeEnd = 69486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69486, XrefRangeEnd = 69487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69487, XrefRangeEnd = 69493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69493, XrefRangeEnd = 69661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69661, XrefRangeEnd = 69669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(23)]
  [CachedScanResults(RefRangeStart = 69678, RefRangeEnd = 69701, XrefRangeStart = 69669, XrefRangeEnd = 69678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SaveProgressData<T>(string key, T value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) value;
      if (!(local2 is string))
      {
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = ptr == System.IntPtr.Zero ? (T&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (T&) ptr : (T&) IL2CPP.il2cpp_object_unbox(ptr));
      }
      else
      {
        // ISSUE: cast to a reference type
        local1 = (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string);
      }
    }
    else
      local1 = ref value;
    *(System.IntPtr*) num = (System.IntPtr) ref local1;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_SaveProgressData_Public_Static_Void_String_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 69708, RefRangeEnd = 69710, XrefRangeStart = 69701, XrefRangeEnd = 69708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SaveCampaignData<T>(GameMode gameMode, string key, T value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameMode);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(key);
    System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) value;
      if (!(local2 is string))
      {
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = ptr == System.IntPtr.Zero ? (T&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (T&) ptr : (T&) IL2CPP.il2cpp_object_unbox(ptr));
      }
      else
      {
        // ISSUE: cast to a reference type
        local1 = (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string);
      }
    }
    else
      local1 = ref value;
    *(System.IntPtr*) num = (System.IntPtr) ref local1;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_SaveCampaignData_Public_Static_Void_GameMode_String_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 69719, RefRangeEnd = 69721, XrefRangeStart = 69710, XrefRangeEnd = 69719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SaveStatsData<T>(string key, T value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) value;
      if (!(local2 is string))
      {
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = ptr == System.IntPtr.Zero ? (T&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (T&) ptr : (T&) IL2CPP.il2cpp_object_unbox(ptr));
      }
      else
      {
        // ISSUE: cast to a reference type
        local1 = (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string);
      }
    }
    else
      local1 = ref value;
    *(System.IntPtr*) num = (System.IntPtr) ref local1;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_SaveStatsData_Public_Static_Void_String_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 69730, RefRangeEnd = 69731, XrefRangeStart = 69721, XrefRangeEnd = 69730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SaveHistoryData<T>(string key, T value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) value;
      if (!(local2 is string))
      {
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = ptr == System.IntPtr.Zero ? (T&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (T&) ptr : (T&) IL2CPP.il2cpp_object_unbox(ptr));
      }
      else
      {
        // ISSUE: cast to a reference type
        local1 = (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string);
      }
    }
    else
      local1 = ref value;
    *(System.IntPtr*) num = (System.IntPtr) ref local1;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_SaveHistoryData_Public_Static_Void_String_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(32)]
  [CachedScanResults(RefRangeStart = 69734, RefRangeEnd = 69766, XrefRangeStart = 69731, XrefRangeEnd = 69734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T LoadProgressData<T>(string key) where T : class
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(key)
    };
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_LoadProgressData_Public_Static_T_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 69777, RefRangeEnd = 69787, XrefRangeStart = 69766, XrefRangeEnd = 69777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T LoadCampaignData<T>(GameMode gameMode, string key) where T : class
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameMode);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(key);
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_LoadCampaignData_Public_Static_T_GameMode_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 69790, RefRangeEnd = 69791, XrefRangeStart = 69787, XrefRangeEnd = 69790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T LoadStatsData<T>(string key) where T : class
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(key)
    };
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_LoadStatsData_Public_Static_T_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 69794, RefRangeEnd = 69797, XrefRangeStart = 69791, XrefRangeEnd = 69794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T LoadHistoryData<T>(string key) where T : class
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(key)
    };
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_LoadHistoryData_Public_Static_T_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(23)]
  [CachedScanResults(RefRangeStart = 69806, RefRangeEnd = 69829, XrefRangeStart = 69797, XrefRangeEnd = 69806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T LoadProgressData<T>(string key, T defaultValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) defaultValue;
      if (!(local2 is string))
      {
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = ptr == System.IntPtr.Zero ? (T&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (T&) ptr : (T&) IL2CPP.il2cpp_object_unbox(ptr));
      }
      else
      {
        // ISSUE: cast to a reference type
        local1 = (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string);
      }
    }
    else
      local1 = ref defaultValue;
    *(System.IntPtr*) num = (System.IntPtr) ref local1;
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_LoadProgressData_Public_Static_T_String_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 69837, RefRangeEnd = 69847, XrefRangeStart = 69829, XrefRangeEnd = 69837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T LoadCampaignData<T>(GameMode gameMode, string key, T defaultValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameMode);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(key);
    System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) defaultValue;
      if (!(local2 is string))
      {
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = ptr == System.IntPtr.Zero ? (T&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (T&) ptr : (T&) IL2CPP.il2cpp_object_unbox(ptr));
      }
      else
      {
        // ISSUE: cast to a reference type
        local1 = (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string);
      }
    }
    else
      local1 = ref defaultValue;
    *(System.IntPtr*) num = (System.IntPtr) ref local1;
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_LoadCampaignData_Public_Static_T_GameMode_String_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69847, XrefRangeEnd = 69856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T LoadStatsData<T>(string key, T defaultValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) defaultValue;
      if (!(local2 is string))
      {
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = ptr == System.IntPtr.Zero ? (T&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (T&) ptr : (T&) IL2CPP.il2cpp_object_unbox(ptr));
      }
      else
      {
        // ISSUE: cast to a reference type
        local1 = (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string);
      }
    }
    else
      local1 = ref defaultValue;
    *(System.IntPtr*) num = (System.IntPtr) ref local1;
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_LoadStatsData_Public_Static_T_String_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69856, XrefRangeEnd = 69865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T LoadHistoryData<T>(string key, T defaultValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) defaultValue;
      if (!(local2 is string))
      {
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = ptr == System.IntPtr.Zero ? (T&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (T&) ptr : (T&) IL2CPP.il2cpp_object_unbox(ptr));
      }
      else
      {
        // ISSUE: cast to a reference type
        local1 = (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string);
      }
    }
    else
      local1 = ref defaultValue;
    *(System.IntPtr*) num = (System.IntPtr) ref local1;
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_LoadHistoryData_Public_Static_T_String_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 69870, RefRangeEnd = 69872, XrefRangeStart = 69865, XrefRangeEnd = 69870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool ProgressExists()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_ProgressExists_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 69876, RefRangeEnd = 69880, XrefRangeStart = 69872, XrefRangeEnd = 69876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CampaignExists(GameMode gameMode)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameMode)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_CampaignExists_Public_Static_Boolean_GameMode_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69880, XrefRangeEnd = 69885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool StatsExists()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_StatsExists_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69885, XrefRangeEnd = 69890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool HistoryExists()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_HistoryExists_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69890, XrefRangeEnd = 69895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool ProgressDataExists(string key)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(key)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_ProgressDataExists_Public_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 69899, RefRangeEnd = 69903, XrefRangeStart = 69895, XrefRangeEnd = 69899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CampaignDataExists(GameMode gameMode, string key)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameMode);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(key);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_CampaignDataExists_Public_Static_Boolean_GameMode_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69903, XrefRangeEnd = 69908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool StatsDataExists(string key)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(key)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_StatsDataExists_Public_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69908, XrefRangeEnd = 69913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool HistoryDataExists(string key)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(key)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_HistoryDataExists_Public_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 69923, RefRangeEnd = 69926, XrefRangeStart = 69913, XrefRangeEnd = 69923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DeleteProgress()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_DeleteProgress_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 69934, RefRangeEnd = 69940, XrefRangeStart = 69926, XrefRangeEnd = 69934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DeleteCampaign(GameMode gameMode)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameMode)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_DeleteCampaign_Public_Static_Void_GameMode_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 69948, RefRangeEnd = 69949, XrefRangeStart = 69940, XrefRangeEnd = 69948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DeleteProfile(string profileName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(profileName)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_DeleteProfile_Public_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69949, XrefRangeEnd = 69959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DeleteStats()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_DeleteStats_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69959, XrefRangeEnd = 69969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DeleteHistory()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_DeleteHistory_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(17)]
  [CachedScanResults(RefRangeStart = 69983, RefRangeEnd = 70000, XrefRangeStart = 69969, XrefRangeEnd = 69983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DeleteProgressData(string key)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(key)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_DeleteProgressData_Public_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 70014, RefRangeEnd = 70015, XrefRangeStart = 70000, XrefRangeEnd = 70014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetProfile()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_GetProfile_Public_Static_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 70057, RefRangeEnd = 70059, XrefRangeStart = 70015, XrefRangeEnd = 70057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetProfile(string name, bool save = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &save;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_SetProfile_Public_Static_Void_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70059, XrefRangeEnd = 70080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EncryptSaveData()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_EncryptSaveData_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 70133, RefRangeEnd = 70141, XrefRangeStart = 70080, XrefRangeEnd = 70133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ConvertSaveFile(
    SaveSystem.Saver saver,
    string folder,
    string fileName,
    ES3Settings oldSettings,
    ES3Settings newSettings)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) saver);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(folder);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fileName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) oldSettings);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newSettings);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_ConvertSaveFile_Private_Static_Void_Saver_String_String_ES3Settings_ES3Settings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SaveSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SaveSystem()
  {
    Il2CppClassPointerStore<SaveSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SaveSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr);
    SaveSystem.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, nameof (instance));
    SaveSystem.NativeFieldInfoPtr__Profile_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, "<Profile>k__BackingField");
    SaveSystem.NativeFieldInfoPtr_encode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, nameof (encode));
    SaveSystem.NativeFieldInfoPtr_beautify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, nameof (beautify));
    SaveSystem.NativeFieldInfoPtr_promptSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, nameof (promptSave));
    SaveSystem.NativeFieldInfoPtr_busy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, nameof (busy));
    SaveSystem.NativeFieldInfoPtr_profileFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, nameof (profileFolder));
    SaveSystem.NativeFieldInfoPtr_folderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, nameof (folderName));
    SaveSystem.NativeFieldInfoPtr_progressSaver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, nameof (progressSaver));
    SaveSystem.NativeFieldInfoPtr_campaignSaver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, nameof (campaignSaver));
    SaveSystem.NativeFieldInfoPtr_battleSaver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, nameof (battleSaver));
    SaveSystem.NativeFieldInfoPtr_statsSaver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, nameof (statsSaver));
    SaveSystem.NativeFieldInfoPtr_historySaver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, nameof (historySaver));
    SaveSystem.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, nameof (settings));
    SaveSystem.NativeFieldInfoPtr_gotSaveTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, nameof (gotSaveTimestamp));
    SaveSystem.NativeFieldInfoPtr_saveTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, nameof (saveTimestamp));
    SaveSystem.NativeMethodInfoPtr_get_Enabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668969);
    SaveSystem.NativeMethodInfoPtr_get_Profile_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668970);
    SaveSystem.NativeMethodInfoPtr_set_Profile_Private_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668971);
    SaveSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668972);
    SaveSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668973);
    SaveSystem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668974);
    SaveSystem.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668975);
    SaveSystem.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668976);
    SaveSystem.NativeMethodInfoPtr_SaveProgressData_Public_Static_Void_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668977);
    SaveSystem.NativeMethodInfoPtr_SaveCampaignData_Public_Static_Void_GameMode_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668978);
    SaveSystem.NativeMethodInfoPtr_SaveStatsData_Public_Static_Void_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668979);
    SaveSystem.NativeMethodInfoPtr_SaveHistoryData_Public_Static_Void_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668980);
    SaveSystem.NativeMethodInfoPtr_LoadProgressData_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668981);
    SaveSystem.NativeMethodInfoPtr_LoadCampaignData_Public_Static_T_GameMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668982);
    SaveSystem.NativeMethodInfoPtr_LoadStatsData_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668983);
    SaveSystem.NativeMethodInfoPtr_LoadHistoryData_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668984);
    SaveSystem.NativeMethodInfoPtr_LoadProgressData_Public_Static_T_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668985);
    SaveSystem.NativeMethodInfoPtr_LoadCampaignData_Public_Static_T_GameMode_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668986);
    SaveSystem.NativeMethodInfoPtr_LoadStatsData_Public_Static_T_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668987);
    SaveSystem.NativeMethodInfoPtr_LoadHistoryData_Public_Static_T_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668988);
    SaveSystem.NativeMethodInfoPtr_ProgressExists_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668989);
    SaveSystem.NativeMethodInfoPtr_CampaignExists_Public_Static_Boolean_GameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668990);
    SaveSystem.NativeMethodInfoPtr_StatsExists_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668991);
    SaveSystem.NativeMethodInfoPtr_HistoryExists_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668992);
    SaveSystem.NativeMethodInfoPtr_ProgressDataExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668993);
    SaveSystem.NativeMethodInfoPtr_CampaignDataExists_Public_Static_Boolean_GameMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668994);
    SaveSystem.NativeMethodInfoPtr_StatsDataExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668995);
    SaveSystem.NativeMethodInfoPtr_HistoryDataExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668996);
    SaveSystem.NativeMethodInfoPtr_DeleteProgress_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668997);
    SaveSystem.NativeMethodInfoPtr_DeleteCampaign_Public_Static_Void_GameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668998);
    SaveSystem.NativeMethodInfoPtr_DeleteProfile_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100668999);
    SaveSystem.NativeMethodInfoPtr_DeleteStats_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669000);
    SaveSystem.NativeMethodInfoPtr_DeleteHistory_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669001);
    SaveSystem.NativeMethodInfoPtr_DeleteProgressData_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669002);
    SaveSystem.NativeMethodInfoPtr_GetProfile_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669003);
    SaveSystem.NativeMethodInfoPtr_SetProfile_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669004);
    SaveSystem.NativeMethodInfoPtr_EncryptSaveData_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669005);
    SaveSystem.NativeMethodInfoPtr_ConvertSaveFile_Private_Static_Void_Saver_String_String_ES3Settings_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669006);
    SaveSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669007);
  }

  public SaveSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe SaveSystem instance
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr_instance, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SaveSystem) null : new SaveSystem(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr_instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe string _Profile_k__BackingField
  {
    get
    {
      System.IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr__Profile_k__BackingField, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr__Profile_k__BackingField, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool encode
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveSystem.NativeFieldInfoPtr_encode));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveSystem.NativeFieldInfoPtr_encode)) = value;
    }
  }

  public unsafe bool beautify
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveSystem.NativeFieldInfoPtr_beautify));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveSystem.NativeFieldInfoPtr_beautify)) = value;
    }
  }

  public unsafe bool promptSave
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveSystem.NativeFieldInfoPtr_promptSave));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveSystem.NativeFieldInfoPtr_promptSave)) = value;
    }
  }

  public unsafe bool busy
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveSystem.NativeFieldInfoPtr_busy));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveSystem.NativeFieldInfoPtr_busy)) = value;
    }
  }

  public static unsafe string profileFolder
  {
    get
    {
      System.IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr_profileFolder, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr_profileFolder, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string folderName
  {
    get
    {
      System.IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr_folderName, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr_folderName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe SaveSystem.Saver progressSaver
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr_progressSaver, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SaveSystem.Saver) null : new SaveSystem.Saver(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr_progressSaver, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe SaveSystem.Saver campaignSaver
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr_campaignSaver, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SaveSystem.Saver) null : new SaveSystem.Saver(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr_campaignSaver, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe SaveSystem.Saver battleSaver
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr_battleSaver, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SaveSystem.Saver) null : new SaveSystem.Saver(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr_battleSaver, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe SaveSystem.Saver statsSaver
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr_statsSaver, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SaveSystem.Saver) null : new SaveSystem.Saver(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr_statsSaver, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe SaveSystem.Saver historySaver
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr_historySaver, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SaveSystem.Saver) null : new SaveSystem.Saver(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr_historySaver, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe ES3Settings settings
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr_settings, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ES3Settings) null : new ES3Settings(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr_settings, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe bool gotSaveTimestamp
  {
    get
    {
      bool gotSaveTimestamp;
      IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr_gotSaveTimestamp, (void*) &gotSaveTimestamp);
      return gotSaveTimestamp;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr_gotSaveTimestamp, (void*) &value);
    }
  }

  public static unsafe Il2CppSystem.DateTime saveTimestamp
  {
    get
    {
      Il2CppSystem.DateTime saveTimestamp;
      IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr_saveTimestamp, (void*) &saveTimestamp);
      return saveTimestamp;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr_saveTimestamp, (void*) &value);
    }
  }

  public class Saver : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_baseFileName;
    private static readonly System.IntPtr NativeFieldInfoPtr_settings;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ES3Settings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveValue_Public_Void_String_TValue_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadValue_Public_TValue_String_String_TValue_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FileExists_Public_Boolean_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_KeyExists_Public_Boolean_String_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Delete_Public_Void_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeleteKey_Public_Void_String_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckBackup_Public_Void_String_String_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69246, XrefRangeEnd = 69253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Saver(string baseFileName, ES3Settings settings = null)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(baseFileName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) settings);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SaveSystem.Saver.NativeMethodInfoPtr__ctor_Public_Void_String_ES3Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69253, XrefRangeEnd = 69299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SaveValue<TValue>(
      string key,
      TValue value,
      string folderName,
      string fileName = "")
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TValue& local1;
      if (!typeof (TValue).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TValue> local2 = (object) value;
        if (!(local2 is string))
        {
          System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
          // ISSUE: cast to a reference type
          // ISSUE: cast to a reference type
          // ISSUE: cast to a reference type
          local1 = ptr == System.IntPtr.Zero ? (TValue&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (TValue&) ptr : (TValue&) IL2CPP.il2cpp_object_unbox(ptr));
        }
        else
        {
          // ISSUE: cast to a reference type
          local1 = (TValue&) IL2CPP.ManagedStringToIl2Cpp(local2 as string);
        }
      }
      else
        local1 = ref value;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(folderName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fileName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SaveSystem.Saver.MethodInfoStoreGeneric_SaveValue_Public_Void_String_TValue_String_String_0<TValue>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69299, XrefRangeEnd = 69354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TValue LoadValue<TValue>(
      string key,
      string folderName,
      TValue defaultValue,
      string fileName = "")
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(folderName);
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TValue& local1;
      if (!typeof (TValue).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TValue> local2 = (object) defaultValue;
        if (!(local2 is string))
        {
          System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
          // ISSUE: cast to a reference type
          // ISSUE: cast to a reference type
          // ISSUE: cast to a reference type
          local1 = ptr == System.IntPtr.Zero ? (TValue&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (TValue&) ptr : (TValue&) IL2CPP.il2cpp_object_unbox(ptr));
        }
        else
        {
          // ISSUE: cast to a reference type
          local1 = (TValue&) IL2CPP.ManagedStringToIl2Cpp(local2 as string);
        }
      }
      else
        local1 = ref defaultValue;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fileName);
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(SaveSystem.Saver.MethodInfoStoreGeneric_LoadValue_Public_TValue_String_String_TValue_String_0<TValue>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<TValue>(objectPointer, false, true);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 69359, RefRangeEnd = 69360, XrefRangeStart = 69354, XrefRangeEnd = 69359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool FileExists(string folderName, string fileName = "")
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(folderName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fileName);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SaveSystem.Saver.NativeMethodInfoPtr_FileExists_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 69379, RefRangeEnd = 69380, XrefRangeStart = 69360, XrefRangeEnd = 69379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool KeyExists(string key, string folderName, string fileName = "")
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(folderName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fileName);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SaveSystem.Saver.NativeMethodInfoPtr_KeyExists_Public_Boolean_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 69385, RefRangeEnd = 69389, XrefRangeStart = 69380, XrefRangeEnd = 69385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Delete(string folderName, string fileName = "")
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(folderName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fileName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SaveSystem.Saver.NativeMethodInfoPtr_Delete_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69389, XrefRangeEnd = 69394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeleteKey(string key, string folderName, string fileName = "")
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(folderName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fileName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SaveSystem.Saver.NativeMethodInfoPtr_DeleteKey_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 69431, RefRangeEnd = 69438, XrefRangeStart = 69394, XrefRangeEnd = 69431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckBackup(string folderName, string fileName = "")
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(folderName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fileName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SaveSystem.Saver.NativeMethodInfoPtr_CheckBackup_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Saver()
    {
      Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, nameof (Saver));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr);
      SaveSystem.Saver.NativeFieldInfoPtr_baseFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr, nameof (baseFileName));
      SaveSystem.Saver.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr, nameof (settings));
      SaveSystem.Saver.NativeMethodInfoPtr__ctor_Public_Void_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr, 100669009);
      SaveSystem.Saver.NativeMethodInfoPtr_SaveValue_Public_Void_String_TValue_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr, 100669010);
      SaveSystem.Saver.NativeMethodInfoPtr_LoadValue_Public_TValue_String_String_TValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr, 100669011);
      SaveSystem.Saver.NativeMethodInfoPtr_FileExists_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr, 100669012);
      SaveSystem.Saver.NativeMethodInfoPtr_KeyExists_Public_Boolean_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr, 100669013);
      SaveSystem.Saver.NativeMethodInfoPtr_Delete_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr, 100669014);
      SaveSystem.Saver.NativeMethodInfoPtr_DeleteKey_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr, 100669015);
      SaveSystem.Saver.NativeMethodInfoPtr_CheckBackup_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr, 100669016);
    }

    public Saver(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string baseFileName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveSystem.Saver.NativeFieldInfoPtr_baseFileName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveSystem.Saver.NativeFieldInfoPtr_baseFileName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe ES3Settings settings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveSystem.Saver.NativeFieldInfoPtr_settings));
        return pointer == System.IntPtr.Zero ? (ES3Settings) null : new ES3Settings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveSystem.Saver.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    private sealed class MethodInfoStoreGeneric_SaveValue_Public_Void_String_TValue_String_String_0<TValue>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.Saver.NativeMethodInfoPtr_SaveValue_Public_Void_String_TValue_String_String_0, Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_LoadValue_Public_TValue_String_String_TValue_String_0<TValue>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.Saver.NativeMethodInfoPtr_LoadValue_Public_TValue_String_String_TValue_String_0, Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
      }))));
    }
  }

  private sealed class MethodInfoStoreGeneric_SaveProgressData_Public_Static_Void_String_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_SaveProgressData_Public_Static_Void_String_T_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SaveCampaignData_Public_Static_Void_GameMode_String_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_SaveCampaignData_Public_Static_Void_GameMode_String_T_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SaveStatsData_Public_Static_Void_String_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_SaveStatsData_Public_Static_Void_String_T_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SaveHistoryData_Public_Static_Void_String_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_SaveHistoryData_Public_Static_Void_String_T_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_LoadProgressData_Public_Static_T_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_LoadProgressData_Public_Static_T_String_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_LoadCampaignData_Public_Static_T_GameMode_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_LoadCampaignData_Public_Static_T_GameMode_String_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_LoadStatsData_Public_Static_T_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_LoadStatsData_Public_Static_T_String_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_LoadHistoryData_Public_Static_T_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_LoadHistoryData_Public_Static_T_String_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_LoadProgressData_Public_Static_T_String_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_LoadProgressData_Public_Static_T_String_T_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_LoadCampaignData_Public_Static_T_GameMode_String_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_LoadCampaignData_Public_Static_T_GameMode_String_T_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_LoadStatsData_Public_Static_T_String_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_LoadStatsData_Public_Static_T_String_T_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_LoadHistoryData_Public_Static_T_String_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_LoadHistoryData_Public_Static_T_String_T_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
