// Decompiled with JetBrains decompiler
// Type: Rewired.Data.UserDataStore_PlayerPrefs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace Rewired.Data
{
  public class UserDataStore_PlayerPrefs : UserDataStore
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_thisScriptName;
    private static readonly System.IntPtr NativeFieldInfoPtr_logPrefix;
    private static readonly System.IntPtr NativeFieldInfoPtr_editorLoadedMessage;
    private static readonly System.IntPtr NativeFieldInfoPtr_playerPrefsKeySuffix_controllerAssignments;
    private static readonly System.IntPtr NativeFieldInfoPtr_controllerMapPPKeyVersion_original;
    private static readonly System.IntPtr NativeFieldInfoPtr_controllerMapPPKeyVersion_includeDuplicateJoystickIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_controllerMapPPKeyVersion_supportDisconnectedControllers;
    private static readonly System.IntPtr NativeFieldInfoPtr_controllerMapPPKeyVersion_includeFormatVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_controllerMapPPKeyVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_isEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_loadDataOnStart;
    private static readonly System.IntPtr NativeFieldInfoPtr_loadJoystickAssignments;
    private static readonly System.IntPtr NativeFieldInfoPtr_loadKeyboardAssignments;
    private static readonly System.IntPtr NativeFieldInfoPtr_loadMouseAssignments;
    private static readonly System.IntPtr NativeFieldInfoPtr_playerPrefsKeyPrefix;
    private static readonly System.IntPtr NativeFieldInfoPtr_allowImpreciseJoystickAssignmentMatching;
    private static readonly System.IntPtr NativeFieldInfoPtr_deferredJoystickAssignmentLoadPending;
    private static readonly System.IntPtr NativeFieldInfoPtr_wasJoystickEverDetected;
    private static readonly System.IntPtr NativeFieldInfoPtr___allActionIds;
    private static readonly System.IntPtr NativeFieldInfoPtr___allActionIdsString;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IsEnabled_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LoadDataOnStart_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LoadDataOnStart_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LoadJoystickAssignments_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LoadJoystickAssignments_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LoadKeyboardAssignments_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LoadKeyboardAssignments_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LoadMouseAssignments_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LoadMouseAssignments_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerPrefsKeyPrefix_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerPrefsKeyPrefix_Public_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_playerPrefsKey_controllerAssignments_Private_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_loadControllerAssignments_Private_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_allActionIds_Private_get_List_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_allActionIdsString_Private_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveControllerData_Public_Virtual_Void_Int32_ControllerType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveControllerData_Public_Virtual_Void_ControllerType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SavePlayerData_Public_Virtual_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveInputBehavior_Public_Virtual_Void_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadControllerData_Public_Virtual_Void_Int32_ControllerType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadControllerData_Public_Virtual_Void_ControllerType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadPlayerData_Public_Virtual_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadInputBehavior_Public_Virtual_Void_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnControllerConnected_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnControllerPreDisconnect_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnControllerDisconnected_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveControllerMap_Public_Virtual_Void_Int32_ControllerMap_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadControllerMap_Public_Virtual_ControllerMap_Int32_ControllerIdentifier_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadAll_Private_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadPlayerDataNow_Private_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadPlayerDataNow_Private_Int32_Player_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadAllJoystickCalibrationData_Private_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadJoystickCalibrationData_Private_Int32_Joystick_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadJoystickCalibrationData_Private_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadJoystickData_Private_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadControllerDataNow_Private_Int32_Int32_ControllerType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadControllerDataNow_Private_Int32_ControllerType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadControllerMaps_Private_Int32_Int32_ControllerType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadControllerMap_Private_ControllerMap_Player_ControllerIdentifier_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadInputBehaviors_Private_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadInputBehaviorNow_Private_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadInputBehaviorNow_Private_Int32_Player_InputBehavior_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadControllerAssignmentsNow_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadKeyboardAndMouseAssignmentsNow_Private_Boolean_ControllerAssignmentSaveInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadJoystickAssignmentsNow_Private_Boolean_ControllerAssignmentSaveInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadControllerAssignmentData_Private_ControllerAssignmentSaveInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadJoystickAssignmentsDeferred_Private_IEnumerator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveAll_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SavePlayerDataNow_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SavePlayerDataNow_Private_Void_Player_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveAllJoystickCalibrationData_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveJoystickCalibrationData_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveJoystickCalibrationData_Private_Void_Joystick_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveJoystickData_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveControllerDataNow_Private_Void_Int32_ControllerType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveControllerDataNow_Private_Void_ControllerType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveControllerMaps_Private_Void_Player_PlayerSaveData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveControllerMaps_Private_Void_Int32_ControllerType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveControllerMap_Private_Void_Player_ControllerMap_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveInputBehaviors_Private_Void_Player_PlayerSaveData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveInputBehaviorNow_Private_Void_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveInputBehaviorNow_Private_Void_Player_InputBehavior_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveControllerAssignments_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ControllerAssignmentSaveDataExists_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBasePlayerPrefsKey_Private_String_Player_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetControllerMapPlayerPrefsKey_Private_String_Player_ControllerIdentifier_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetControllerMapKnownActionIdsPlayerPrefsKey_Private_String_Player_ControllerIdentifier_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetControllerMapPlayerPrefsKeyCommonSuffix_Private_Static_String_Player_ControllerIdentifier_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetJoystickCalibrationMapPlayerPrefsKey_Private_String_Joystick_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInputBehaviorPlayerPrefsKey_Private_String_Player_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetControllerMapXml_Private_String_Player_ControllerIdentifier_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetControllerMapKnownActionIds_Private_List_1_Int32_Player_ControllerIdentifier_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetJoystickCalibrationMapXml_Private_String_Joystick_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInputBehaviorXml_Private_String_Player_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddDefaultMappingsForNewActions_Private_Void_ControllerIdentifier_ControllerMap_List_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindJoystickPrecise_Private_Joystick_JoystickInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindJoysticksImprecise_Private_Boolean_JoystickInfo_byref_List_1_Joystick_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDuplicateIndex_Private_Static_Int32_Player_ControllerIdentifier_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshLayoutManager_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetControllerMapType_Private_Static_Type_ControllerType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe bool IsEnabled
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 23871, RefRangeEnd = 23873, XrefRangeStart = 23871, XrefRangeEnd = 23873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_IsEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool LoadDataOnStart
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_LoadDataOnStart_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_LoadDataOnStart_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool LoadJoystickAssignments
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_LoadJoystickAssignments_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_LoadJoystickAssignments_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool LoadKeyboardAssignments
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_LoadKeyboardAssignments_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_LoadKeyboardAssignments_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool LoadMouseAssignments
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_LoadMouseAssignments_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_LoadMouseAssignments_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe string PlayerPrefsKeyPrefix
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_PlayerPrefsKeyPrefix_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 54210, RefRangeEnd = 54212, XrefRangeStart = 54210, XrefRangeEnd = 54212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(value)
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_PlayerPrefsKeyPrefix_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe string playerPrefsKey_controllerAssignments
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138328, XrefRangeEnd = 138333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_playerPrefsKey_controllerAssignments_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe bool loadControllerAssignments
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_loadControllerAssignments_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe List<int> allActionIds
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 138357, RefRangeEnd = 138360, XrefRangeStart = 138333, XrefRangeEnd = 138357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_allActionIds_Private_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
      }
    }

    public unsafe string allActionIdsString
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138360, XrefRangeEnd = 138376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_allActionIdsString_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138376, XrefRangeEnd = 138383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Save()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_Save_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138383, XrefRangeEnd = 138394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void SaveControllerData(
      int playerId,
      ControllerType controllerType,
      int controllerId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &playerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerData_Public_Virtual_Void_Int32_ControllerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138394, XrefRangeEnd = 138402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void SaveControllerData(ControllerType controllerType, int controllerId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &controllerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerData_Public_Virtual_Void_ControllerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138402, XrefRangeEnd = 138416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void SavePlayerData(int playerId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &playerId
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SavePlayerData_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138416, XrefRangeEnd = 138431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void SaveInputBehavior(int playerId, int behaviorId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &playerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &behaviorId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveInputBehavior_Public_Virtual_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138431, XrefRangeEnd = 138438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Load()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_Load_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138438, XrefRangeEnd = 138448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void LoadControllerData(
      int playerId,
      ControllerType controllerType,
      int controllerId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &playerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerData_Public_Virtual_Void_Int32_ControllerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138448, XrefRangeEnd = 138455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void LoadControllerData(ControllerType controllerType, int controllerId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &controllerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerData_Public_Virtual_Void_ControllerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138455, XrefRangeEnd = 138468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void LoadPlayerData(int playerId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &playerId
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadPlayerData_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138468, XrefRangeEnd = 138480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void LoadInputBehavior(int playerId, int behaviorId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &playerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &behaviorId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadInputBehavior_Public_Virtual_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138480, XrefRangeEnd = 138486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnInitialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138486, XrefRangeEnd = 138494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnControllerConnected(ControllerStatusChangedEventArgs args)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_OnControllerConnected_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138494, XrefRangeEnd = 138495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_OnControllerPreDisconnect_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138495, XrefRangeEnd = 138496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_OnControllerDisconnected_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138496, XrefRangeEnd = 138502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void SaveControllerMap(int playerId, ControllerMap controllerMap)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &playerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controllerMap);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerMap_Public_Virtual_Void_Int32_ControllerMap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138502, XrefRangeEnd = 138508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe ControllerMap LoadControllerMap(
      int playerId,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &playerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) controllerIdentifier));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &categoryId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &layoutId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerMap_Public_Virtual_ControllerMap_Int32_ControllerIdentifier_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ControllerMap) null : new ControllerMap(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 138525, RefRangeEnd = 138526, XrefRangeStart = 138508, XrefRangeEnd = 138525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int LoadAll()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadAll_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138526, XrefRangeEnd = 138533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int LoadPlayerDataNow(int playerId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &playerId
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadPlayerDataNow_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 138562, RefRangeEnd = 138565, XrefRangeStart = 138533, XrefRangeEnd = 138562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int LoadPlayerDataNow(Player player)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadPlayerDataNow_Private_Int32_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 138587, RefRangeEnd = 138588, XrefRangeStart = 138565, XrefRangeEnd = 138587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int LoadAllJoystickCalibrationData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadAllJoystickCalibrationData_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138588, XrefRangeEnd = 138595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int LoadJoystickCalibrationData(Joystick joystick)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) joystick)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadJoystickCalibrationData_Private_Int32_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 138607, RefRangeEnd = 138612, XrefRangeStart = 138595, XrefRangeEnd = 138607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int LoadJoystickCalibrationData(int joystickId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &joystickId
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadJoystickCalibrationData_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 138632, RefRangeEnd = 138633, XrefRangeStart = 138612, XrefRangeEnd = 138632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int LoadJoystickData(int joystickId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &joystickId
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadJoystickData_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138633, XrefRangeEnd = 138637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int LoadControllerDataNow(
      int playerId,
      ControllerType controllerType,
      int controllerId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &playerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerDataNow_Private_Int32_Int32_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138637, XrefRangeEnd = 138638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int LoadControllerDataNow(ControllerType controllerType, int controllerId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &controllerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerDataNow_Private_Int32_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 138673, RefRangeEnd = 138679, XrefRangeStart = 138638, XrefRangeEnd = 138673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int LoadControllerMaps(
      int playerId,
      ControllerType controllerType,
      int controllerId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &playerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerMaps_Private_Int32_Int32_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 138705, RefRangeEnd = 138707, XrefRangeStart = 138679, XrefRangeEnd = 138705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ControllerMap LoadControllerMap(
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) controllerIdentifier));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &categoryId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &layoutId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerMap_Private_ControllerMap_Player_ControllerIdentifier_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ControllerMap) null : new ControllerMap(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 138727, RefRangeEnd = 138728, XrefRangeStart = 138707, XrefRangeEnd = 138727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int LoadInputBehaviors(int playerId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &playerId
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadInputBehaviors_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138728, XrefRangeEnd = 138738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int LoadInputBehaviorNow(int playerId, int behaviorId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &playerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &behaviorId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadInputBehaviorNow_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 138748, RefRangeEnd = 138751, XrefRangeStart = 138738, XrefRangeEnd = 138748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputBehavior);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadInputBehaviorNow_Private_Int32_Player_InputBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 138755, RefRangeEnd = 138756, XrefRangeStart = 138751, XrefRangeEnd = 138755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool LoadControllerAssignmentsNow()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerAssignmentsNow_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 138762, RefRangeEnd = 138763, XrefRangeStart = 138756, XrefRangeEnd = 138762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool LoadKeyboardAndMouseAssignmentsNow(
      UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadKeyboardAndMouseAssignmentsNow_Private_Boolean_ControllerAssignmentSaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 138921, RefRangeEnd = 138922, XrefRangeStart = 138763, XrefRangeEnd = 138921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool LoadJoystickAssignmentsNow(
      UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadJoystickAssignmentsNow_Private_Boolean_ControllerAssignmentSaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 138945, RefRangeEnd = 138948, XrefRangeStart = 138922, XrefRangeEnd = 138945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo LoadControllerAssignmentData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerAssignmentData_Private_ControllerAssignmentSaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo) null : new UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138948, XrefRangeEnd = 138953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerator LoadJoystickAssignmentsDeferred()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadJoystickAssignmentsDeferred_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 138972, RefRangeEnd = 138973, XrefRangeStart = 138953, XrefRangeEnd = 138972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SaveAll()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveAll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138973, XrefRangeEnd = 138981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SavePlayerDataNow(int playerId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &playerId
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SavePlayerDataNow_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 138997, RefRangeEnd = 139000, XrefRangeStart = 138981, XrefRangeEnd = 138997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SavePlayerDataNow(Player player)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SavePlayerDataNow_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 139018, RefRangeEnd = 139019, XrefRangeStart = 139000, XrefRangeEnd = 139018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SaveAllJoystickCalibrationData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveAllJoystickCalibrationData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 139028, RefRangeEnd = 139033, XrefRangeStart = 139019, XrefRangeEnd = 139028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SaveJoystickCalibrationData(int joystickId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &joystickId
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveJoystickCalibrationData_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139033, XrefRangeEnd = 139037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SaveJoystickCalibrationData(Joystick joystick)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) joystick)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveJoystickCalibrationData_Private_Void_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 139056, RefRangeEnd = 139057, XrefRangeStart = 139037, XrefRangeEnd = 139056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SaveJoystickData(int joystickId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &joystickId
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveJoystickData_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139057, XrefRangeEnd = 139061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SaveControllerDataNow(
      int playerId,
      ControllerType controllerType,
      int controllerId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &playerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerDataNow_Private_Void_Int32_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139061, XrefRangeEnd = 139063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SaveControllerDataNow(ControllerType controllerType, int controllerId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &controllerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerDataNow_Private_Void_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 139083, RefRangeEnd = 139084, XrefRangeStart = 139063, XrefRangeEnd = 139083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SaveControllerMaps(Player player, PlayerSaveData playerSaveData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) playerSaveData));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerMaps_Private_Void_Player_PlayerSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 139094, RefRangeEnd = 139097, XrefRangeStart = 139084, XrefRangeEnd = 139094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SaveControllerMaps(
      int playerId,
      ControllerType controllerType,
      int controllerId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &playerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerMaps_Private_Void_Int32_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 139141, RefRangeEnd = 139144, XrefRangeStart = 139097, XrefRangeEnd = 139141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SaveControllerMap(Player player, ControllerMap controllerMap)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controllerMap);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerMap_Private_Void_Player_ControllerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139144, XrefRangeEnd = 139158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) playerSaveData));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveInputBehaviors_Private_Void_Player_PlayerSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139158, XrefRangeEnd = 139171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SaveInputBehaviorNow(int playerId, int behaviorId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &playerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &behaviorId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveInputBehaviorNow_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139171, XrefRangeEnd = 139174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputBehavior);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveInputBehaviorNow_Private_Void_Player_InputBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 139243, RefRangeEnd = 139247, XrefRangeStart = 139174, XrefRangeEnd = 139243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SaveControllerAssignments()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerAssignments_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139247, XrefRangeEnd = 139260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ControllerAssignmentSaveDataExists()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_ControllerAssignmentSaveDataExists_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139260, XrefRangeEnd = 139265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetBasePlayerPrefsKey(Player player)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player)
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetBasePlayerPrefsKey_Private_String_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 139275, RefRangeEnd = 139277, XrefRangeStart = 139265, XrefRangeEnd = 139275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetControllerMapPlayerPrefsKey(
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId,
      int ppKeyVersion)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) controllerIdentifier));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &categoryId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &layoutId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &ppKeyVersion;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapPlayerPrefsKey_Private_String_Player_ControllerIdentifier_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 139287, RefRangeEnd = 139289, XrefRangeStart = 139277, XrefRangeEnd = 139287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetControllerMapKnownActionIdsPlayerPrefsKey(
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId,
      int ppKeyVersion)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) controllerIdentifier));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &categoryId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &layoutId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &ppKeyVersion;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapKnownActionIdsPlayerPrefsKey_Private_String_Player_ControllerIdentifier_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 139359, RefRangeEnd = 139363, XrefRangeStart = 139289, XrefRangeEnd = 139359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetControllerMapPlayerPrefsKeyCommonSuffix(
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId,
      int ppKeyVersion)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) controllerIdentifier));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &categoryId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &layoutId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &ppKeyVersion;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapPlayerPrefsKeyCommonSuffix_Private_Static_String_Player_ControllerIdentifier_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 139382, RefRangeEnd = 139389, XrefRangeStart = 139363, XrefRangeEnd = 139382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) joystick)
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetJoystickCalibrationMapPlayerPrefsKey_Private_String_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 139400, RefRangeEnd = 139405, XrefRangeStart = 139389, XrefRangeEnd = 139400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inputBehaviorId;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetInputBehaviorPlayerPrefsKey_Private_String_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139405, XrefRangeEnd = 139409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetControllerMapXml(
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) controllerIdentifier));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &categoryId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &layoutId;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapXml_Private_String_Player_ControllerIdentifier_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139409, XrefRangeEnd = 139418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<int> GetControllerMapKnownActionIds(
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) controllerIdentifier));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &categoryId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &layoutId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapKnownActionIds_Private_List_1_Int32_Player_ControllerIdentifier_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139418, XrefRangeEnd = 139423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetJoystickCalibrationMapXml(Joystick joystick)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) joystick)
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetJoystickCalibrationMapXml_Private_String_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139423, XrefRangeEnd = 139428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetInputBehaviorXml(Player player, int id)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetInputBehaviorXml_Private_String_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 139490, RefRangeEnd = 139491, XrefRangeStart = 139428, XrefRangeEnd = 139490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddDefaultMappingsForNewActions(
      ControllerIdentifier controllerIdentifier,
      ControllerMap controllerMap,
      List<int> knownActionIds)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) controllerIdentifier));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controllerMap);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) knownActionIds);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_AddDefaultMappingsForNewActions_Private_Void_ControllerIdentifier_ControllerMap_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 139510, RefRangeEnd = 139511, XrefRangeStart = 139491, XrefRangeEnd = 139510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Joystick FindJoystickPrecise(
      UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) joystickInfo)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_FindJoystickPrecise_Private_Joystick_JoystickInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Joystick) null : new Joystick(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 139542, RefRangeEnd = 139543, XrefRangeStart = 139511, XrefRangeEnd = 139542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryFindJoysticksImprecise(
      UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo,
      out List<Joystick> matches)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) joystickInfo);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_TryFindJoysticksImprecise_Private_Boolean_JoystickInfo_byref_List_1_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<Joystick> local = ref matches;
      System.IntPtr pointer = zero;
      List<> list = pointer == System.IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<Joystick>) list;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 139584, RefRangeEnd = 139585, XrefRangeStart = 139543, XrefRangeEnd = 139584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetDuplicateIndex(
      Player player,
      ControllerIdentifier controllerIdentifier)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) controllerIdentifier));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetDuplicateIndex_Private_Static_Int32_Player_ControllerIdentifier_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 139591, RefRangeEnd = 139595, XrefRangeStart = 139585, XrefRangeEnd = 139591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshLayoutManager(int playerId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &playerId
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_RefreshLayoutManager_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139595, XrefRangeEnd = 139610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppSystem.Type GetControllerMapType(ControllerType controllerType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &controllerType
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapType_Private_Static_Type_ControllerType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Type) null : new Il2CppSystem.Type(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139610, XrefRangeEnd = 139615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UserDataStore_PlayerPrefs()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UserDataStore_PlayerPrefs()
    {
      Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Data", nameof (UserDataStore_PlayerPrefs));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr);
      UserDataStore_PlayerPrefs.NativeFieldInfoPtr_thisScriptName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, nameof (thisScriptName));
      UserDataStore_PlayerPrefs.NativeFieldInfoPtr_logPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, nameof (logPrefix));
      UserDataStore_PlayerPrefs.NativeFieldInfoPtr_editorLoadedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, nameof (editorLoadedMessage));
      UserDataStore_PlayerPrefs.NativeFieldInfoPtr_playerPrefsKeySuffix_controllerAssignments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, nameof (playerPrefsKeySuffix_controllerAssignments));
      UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_original = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, nameof (controllerMapPPKeyVersion_original));
      UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_includeDuplicateJoystickIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, nameof (controllerMapPPKeyVersion_includeDuplicateJoystickIndex));
      UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_supportDisconnectedControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, nameof (controllerMapPPKeyVersion_supportDisconnectedControllers));
      UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_includeFormatVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, nameof (controllerMapPPKeyVersion_includeFormatVersion));
      UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, nameof (controllerMapPPKeyVersion));
      UserDataStore_PlayerPrefs.NativeFieldInfoPtr_isEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, nameof (isEnabled));
      UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadDataOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, nameof (loadDataOnStart));
      UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadJoystickAssignments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, nameof (loadJoystickAssignments));
      UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadKeyboardAssignments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, nameof (loadKeyboardAssignments));
      UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadMouseAssignments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, nameof (loadMouseAssignments));
      UserDataStore_PlayerPrefs.NativeFieldInfoPtr_playerPrefsKeyPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, nameof (playerPrefsKeyPrefix));
      UserDataStore_PlayerPrefs.NativeFieldInfoPtr_allowImpreciseJoystickAssignmentMatching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, nameof (allowImpreciseJoystickAssignmentMatching));
      UserDataStore_PlayerPrefs.NativeFieldInfoPtr_deferredJoystickAssignmentLoadPending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, nameof (deferredJoystickAssignmentLoadPending));
      UserDataStore_PlayerPrefs.NativeFieldInfoPtr_wasJoystickEverDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, nameof (wasJoystickEverDetected));
      UserDataStore_PlayerPrefs.NativeFieldInfoPtr___allActionIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, nameof (__allActionIds));
      UserDataStore_PlayerPrefs.NativeFieldInfoPtr___allActionIdsString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, nameof (__allActionIdsString));
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678066);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_IsEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678067);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_LoadDataOnStart_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678068);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_LoadDataOnStart_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678069);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_LoadJoystickAssignments_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678070);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_LoadJoystickAssignments_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678071);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_LoadKeyboardAssignments_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678072);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_LoadKeyboardAssignments_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678073);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_LoadMouseAssignments_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678074);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_LoadMouseAssignments_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678075);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_PlayerPrefsKeyPrefix_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678076);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_set_PlayerPrefsKeyPrefix_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678077);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_playerPrefsKey_controllerAssignments_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678078);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_loadControllerAssignments_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678079);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_allActionIds_Private_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678080);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_get_allActionIdsString_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678081);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_Save_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678082);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerData_Public_Virtual_Void_Int32_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678083);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerData_Public_Virtual_Void_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678084);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SavePlayerData_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678085);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveInputBehavior_Public_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678086);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_Load_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678087);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerData_Public_Virtual_Void_Int32_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678088);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerData_Public_Virtual_Void_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678089);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadPlayerData_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678090);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadInputBehavior_Public_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678091);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678092);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_OnControllerConnected_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678093);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_OnControllerPreDisconnect_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678094);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_OnControllerDisconnected_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678095);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerMap_Public_Virtual_Void_Int32_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678096);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerMap_Public_Virtual_ControllerMap_Int32_ControllerIdentifier_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678097);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadAll_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678098);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadPlayerDataNow_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678099);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadPlayerDataNow_Private_Int32_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678100);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadAllJoystickCalibrationData_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678101);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadJoystickCalibrationData_Private_Int32_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678102);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadJoystickCalibrationData_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678103);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadJoystickData_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678104);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerDataNow_Private_Int32_Int32_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678105);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerDataNow_Private_Int32_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678106);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerMaps_Private_Int32_Int32_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678107);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerMap_Private_ControllerMap_Player_ControllerIdentifier_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678108);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadInputBehaviors_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678109);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadInputBehaviorNow_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678110);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadInputBehaviorNow_Private_Int32_Player_InputBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678111);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerAssignmentsNow_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678112);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadKeyboardAndMouseAssignmentsNow_Private_Boolean_ControllerAssignmentSaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678113);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadJoystickAssignmentsNow_Private_Boolean_ControllerAssignmentSaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678114);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadControllerAssignmentData_Private_ControllerAssignmentSaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678115);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_LoadJoystickAssignmentsDeferred_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678116);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveAll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678117);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SavePlayerDataNow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678118);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SavePlayerDataNow_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678119);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveAllJoystickCalibrationData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678120);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveJoystickCalibrationData_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678121);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveJoystickCalibrationData_Private_Void_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678122);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveJoystickData_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678123);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerDataNow_Private_Void_Int32_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678124);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerDataNow_Private_Void_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678125);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerMaps_Private_Void_Player_PlayerSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678126);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerMaps_Private_Void_Int32_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678127);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerMap_Private_Void_Player_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678128);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveInputBehaviors_Private_Void_Player_PlayerSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678129);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveInputBehaviorNow_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678130);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveInputBehaviorNow_Private_Void_Player_InputBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678131);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_SaveControllerAssignments_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678132);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_ControllerAssignmentSaveDataExists_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678133);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetBasePlayerPrefsKey_Private_String_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678134);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapPlayerPrefsKey_Private_String_Player_ControllerIdentifier_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678135);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapKnownActionIdsPlayerPrefsKey_Private_String_Player_ControllerIdentifier_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678136);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapPlayerPrefsKeyCommonSuffix_Private_Static_String_Player_ControllerIdentifier_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678137);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetJoystickCalibrationMapPlayerPrefsKey_Private_String_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678138);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetInputBehaviorPlayerPrefsKey_Private_String_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678139);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapXml_Private_String_Player_ControllerIdentifier_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678140);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapKnownActionIds_Private_List_1_Int32_Player_ControllerIdentifier_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678141);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetJoystickCalibrationMapXml_Private_String_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678142);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetInputBehaviorXml_Private_String_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678143);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_AddDefaultMappingsForNewActions_Private_Void_ControllerIdentifier_ControllerMap_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678144);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_FindJoystickPrecise_Private_Joystick_JoystickInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678145);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_TryFindJoysticksImprecise_Private_Boolean_JoystickInfo_byref_List_1_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678146);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetDuplicateIndex_Private_Static_Int32_Player_ControllerIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678147);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_RefreshLayoutManager_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678148);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr_GetControllerMapType_Private_Static_Type_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678149);
      UserDataStore_PlayerPrefs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100678150);
    }

    public UserDataStore_PlayerPrefs(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string thisScriptName
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_thisScriptName, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_thisScriptName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string logPrefix
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_logPrefix, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_logPrefix, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string editorLoadedMessage
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_editorLoadedMessage, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_editorLoadedMessage, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string playerPrefsKeySuffix_controllerAssignments
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_playerPrefsKeySuffix_controllerAssignments, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_playerPrefsKeySuffix_controllerAssignments, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe int controllerMapPPKeyVersion_original
    {
      get
      {
        int keyVersionOriginal;
        IL2CPP.il2cpp_field_static_get_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_original, (void*) &keyVersionOriginal);
        return keyVersionOriginal;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_original, (void*) &value);
      }
    }

    public static unsafe int controllerMapPPKeyVersion_includeDuplicateJoystickIndex
    {
      get
      {
        int duplicateJoystickIndex;
        IL2CPP.il2cpp_field_static_get_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_includeDuplicateJoystickIndex, (void*) &duplicateJoystickIndex);
        return duplicateJoystickIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_includeDuplicateJoystickIndex, (void*) &value);
      }
    }

    public static unsafe int controllerMapPPKeyVersion_supportDisconnectedControllers
    {
      get
      {
        int disconnectedControllers;
        IL2CPP.il2cpp_field_static_get_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_supportDisconnectedControllers, (void*) &disconnectedControllers);
        return disconnectedControllers;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_supportDisconnectedControllers, (void*) &value);
      }
    }

    public static unsafe int controllerMapPPKeyVersion_includeFormatVersion
    {
      get
      {
        int includeFormatVersion;
        IL2CPP.il2cpp_field_static_get_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_includeFormatVersion, (void*) &includeFormatVersion);
        return includeFormatVersion;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion_includeFormatVersion, (void*) &value);
      }
    }

    public static unsafe int controllerMapPPKeyVersion
    {
      get
      {
        int controllerMapPpKeyVersion;
        IL2CPP.il2cpp_field_static_get_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion, (void*) &controllerMapPpKeyVersion);
        return controllerMapPpKeyVersion;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_controllerMapPPKeyVersion, (void*) &value);
      }
    }

    public unsafe bool isEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_isEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_isEnabled)) = value;
      }
    }

    public unsafe bool loadDataOnStart
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadDataOnStart));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadDataOnStart)) = value;
      }
    }

    public unsafe bool loadJoystickAssignments
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadJoystickAssignments));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadJoystickAssignments)) = value;
      }
    }

    public unsafe bool loadKeyboardAssignments
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadKeyboardAssignments));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadKeyboardAssignments)) = value;
      }
    }

    public unsafe bool loadMouseAssignments
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadMouseAssignments));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_loadMouseAssignments)) = value;
      }
    }

    public unsafe string playerPrefsKeyPrefix
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_playerPrefsKeyPrefix)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_playerPrefsKeyPrefix), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool allowImpreciseJoystickAssignmentMatching
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_allowImpreciseJoystickAssignmentMatching));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_allowImpreciseJoystickAssignmentMatching)) = value;
      }
    }

    public unsafe bool deferredJoystickAssignmentLoadPending
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_deferredJoystickAssignmentLoadPending));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_deferredJoystickAssignmentLoadPending)) = value;
      }
    }

    public unsafe bool wasJoystickEverDetected
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_wasJoystickEverDetected));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr_wasJoystickEverDetected)) = value;
      }
    }

    public unsafe List<int> __allActionIds
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr___allActionIds));
        return pointer == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr___allActionIds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string __allActionIdsString
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr___allActionIdsString)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.NativeFieldInfoPtr___allActionIdsString), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public class ControllerAssignmentSaveInfo : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_players;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_playerCount_Public_get_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfPlayer_Public_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ContainsPlayer_Public_Boolean_Int32_0;

      public unsafe int playerCount
      {
        [CallerCount(3), CachedScanResults(RefRangeStart = 138294, RefRangeEnd = 138297, XrefRangeStart = 138294, XrefRangeEnd = 138294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeMethodInfoPtr_get_playerCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ControllerAssignmentSaveInfo()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138297, XrefRangeEnd = 138308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ControllerAssignmentSaveInfo(int playerCount)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &playerCount
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 138310, RefRangeEnd = 138312, XrefRangeStart = 138308, XrefRangeEnd = 138310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int IndexOfPlayer(int playerId)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &playerId
        };
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeMethodInfoPtr_IndexOfPlayer_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138312, XrefRangeEnd = 138314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool ContainsPlayer(int playerId)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &playerId
        };
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeMethodInfoPtr_ContainsPlayer_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static ControllerAssignmentSaveInfo()
      {
        Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, nameof (ControllerAssignmentSaveInfo));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr);
        UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeFieldInfoPtr_players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr, nameof (players));
        UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeMethodInfoPtr_get_playerCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr, 100678151);
        UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr, 100678152);
        UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr, 100678153);
        UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeMethodInfoPtr_IndexOfPlayer_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr, 100678154);
        UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeMethodInfoPtr_ContainsPlayer_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr, 100678155);
      }

      public ControllerAssignmentSaveInfo(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Il2CppReferenceArray<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo> players
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeFieldInfoPtr_players));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>) null : new Il2CppReferenceArray<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.NativeFieldInfoPtr_players), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public class PlayerInfo : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_id;
        private static readonly System.IntPtr NativeFieldInfoPtr_hasKeyboard;
        private static readonly System.IntPtr NativeFieldInfoPtr_hasMouse;
        private static readonly System.IntPtr NativeFieldInfoPtr_joysticks;
        private static readonly System.IntPtr NativeMethodInfoPtr_get_joystickCount_Public_get_Int32_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfJoystick_Public_Int32_Int32_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_ContainsJoystick_Public_Boolean_Int32_0;
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

        public unsafe int joystickCount
        {
          [CallerCount(2), CachedScanResults(RefRangeStart = 138288, RefRangeEnd = 138290, XrefRangeStart = 138288, XrefRangeEnd = 138288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
          {
            IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeMethodInfoPtr_get_joystickCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(int*) IL2CPP.il2cpp_object_unbox(num);
          }
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138290, XrefRangeEnd = 138292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe int IndexOfJoystick(int joystickId)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1]
          {
            (System.IntPtr) &joystickId
          };
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeMethodInfoPtr_IndexOfJoystick_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138292, XrefRangeEnd = 138294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe bool ContainsJoystick(int joystickId)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1]
          {
            (System.IntPtr) &joystickId
          };
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeMethodInfoPtr_ContainsJoystick_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(1959)]
        [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PlayerInfo()
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>.NativeClassPtr))
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static PlayerInfo()
        {
          Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr, nameof (PlayerInfo));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>.NativeClassPtr);
          UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>.NativeClassPtr, nameof (id));
          UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_hasKeyboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>.NativeClassPtr, nameof (hasKeyboard));
          UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_hasMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>.NativeClassPtr, nameof (hasMouse));
          UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_joysticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>.NativeClassPtr, nameof (joysticks));
          UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeMethodInfoPtr_get_joystickCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>.NativeClassPtr, 100678156);
          UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeMethodInfoPtr_IndexOfJoystick_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>.NativeClassPtr, 100678157);
          UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeMethodInfoPtr_ContainsJoystick_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>.NativeClassPtr, 100678158);
          UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo>.NativeClassPtr, 100678159);
        }

        public PlayerInfo(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public unsafe int id
        {
          get
          {
            return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_id));
          }
          [param: In] set
          {
            *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_id)) = value;
          }
        }

        public unsafe bool hasKeyboard
        {
          get
          {
            return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_hasKeyboard));
          }
          [param: In] set
          {
            *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_hasKeyboard)) = value;
          }
        }

        public unsafe bool hasMouse
        {
          get
          {
            return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_hasMouse));
          }
          [param: In] set
          {
            *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_hasMouse)) = value;
          }
        }

        public unsafe Il2CppReferenceArray<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo> joysticks
        {
          get
          {
            System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_joysticks));
            return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo>) null : new Il2CppReferenceArray<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo>(nativeObject);
          }
          [param: In] set
          {
            System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo.NativeFieldInfoPtr_joysticks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }
      }

      public class JoystickInfo : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_instanceGuid;
        private static readonly System.IntPtr NativeFieldInfoPtr_hardwareIdentifier;
        private static readonly System.IntPtr NativeFieldInfoPtr_id;
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

        [CallerCount(1959)]
        [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe JoystickInfo()
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo>.NativeClassPtr))
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static JoystickInfo()
        {
          Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>.NativeClassPtr, nameof (JoystickInfo));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo>.NativeClassPtr);
          UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo.NativeFieldInfoPtr_instanceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo>.NativeClassPtr, nameof (instanceGuid));
          UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo.NativeFieldInfoPtr_hardwareIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo>.NativeClassPtr, nameof (hardwareIdentifier));
          UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo>.NativeClassPtr, nameof (id));
          UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo>.NativeClassPtr, 100678160);
        }

        public JoystickInfo(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public unsafe Il2CppSystem.Guid instanceGuid
        {
          get
          {
            return *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo.NativeFieldInfoPtr_instanceGuid));
          }
          [param: In] set
          {
            *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo.NativeFieldInfoPtr_instanceGuid)) = value;
          }
        }

        public unsafe string hardwareIdentifier
        {
          get
          {
            return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo.NativeFieldInfoPtr_hardwareIdentifier)));
          }
          [param: In] set
          {
            System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo.NativeFieldInfoPtr_hardwareIdentifier), IL2CPP.ManagedStringToIl2Cpp(value));
          }
        }

        public unsafe int id
        {
          get
          {
            return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo.NativeFieldInfoPtr_id));
          }
          [param: In] set
          {
            *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo.NativeFieldInfoPtr_id)) = value;
          }
        }
      }
    }

    public class JoystickAssignmentHistoryInfo : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_joystick;
      private static readonly System.IntPtr NativeFieldInfoPtr_oldJoystickId;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Joystick_Int32_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138314, XrefRangeEnd = 138316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) joystick);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &oldJoystickId;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo.NativeMethodInfoPtr__ctor_Public_Void_Joystick_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static JoystickAssignmentHistoryInfo()
      {
        Il2CppClassPointerStore<UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, nameof (JoystickAssignmentHistoryInfo));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo>.NativeClassPtr);
        UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo.NativeFieldInfoPtr_joystick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo>.NativeClassPtr, nameof (joystick));
        UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo.NativeFieldInfoPtr_oldJoystickId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo>.NativeClassPtr, nameof (oldJoystickId));
        UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo.NativeMethodInfoPtr__ctor_Public_Void_Joystick_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo>.NativeClassPtr, 100678161);
      }

      public JoystickAssignmentHistoryInfo(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Joystick joystick
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo.NativeFieldInfoPtr_joystick));
          return pointer == System.IntPtr.Zero ? (Joystick) null : new Joystick(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo.NativeFieldInfoPtr_joystick), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int oldJoystickId
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo.NativeFieldInfoPtr_oldJoystickId));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo.NativeFieldInfoPtr_oldJoystickId)) = value;
        }
      }
    }

    [ObfuscatedName("Rewired.Data.UserDataStore_PlayerPrefs/<>c__DisplayClass78_0")]
    public sealed class __c__DisplayClass78_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_joystick;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__0_Internal_Boolean_JoystickAssignmentHistoryInfo_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass78_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe bool _LoadJoystickAssignmentsNow_b__0(
        UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
        };
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.__c__DisplayClass78_0.NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__0_Internal_Boolean_JoystickAssignmentHistoryInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass78_0()
      {
        Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "<>c__DisplayClass78_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_0>.NativeClassPtr);
        UserDataStore_PlayerPrefs.__c__DisplayClass78_0.NativeFieldInfoPtr_joystick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_0>.NativeClassPtr, nameof (joystick));
        UserDataStore_PlayerPrefs.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_0>.NativeClassPtr, 100678162);
        UserDataStore_PlayerPrefs.__c__DisplayClass78_0.NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__0_Internal_Boolean_JoystickAssignmentHistoryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_0>.NativeClassPtr, 100678163);
      }

      public __c__DisplayClass78_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Joystick joystick
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.__c__DisplayClass78_0.NativeFieldInfoPtr_joystick));
          return pointer == System.IntPtr.Zero ? (Joystick) null : new Joystick(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.__c__DisplayClass78_0.NativeFieldInfoPtr_joystick), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("Rewired.Data.UserDataStore_PlayerPrefs/<>c__DisplayClass78_1")]
    public sealed class __c__DisplayClass78_1 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_joystickInfo;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__1_Internal_Boolean_JoystickAssignmentHistoryInfo_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass78_1()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_1>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.__c__DisplayClass78_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe bool _LoadJoystickAssignmentsNow_b__1(
        UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
        };
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.__c__DisplayClass78_1.NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__1_Internal_Boolean_JoystickAssignmentHistoryInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass78_1()
      {
        Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "<>c__DisplayClass78_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_1>.NativeClassPtr);
        UserDataStore_PlayerPrefs.__c__DisplayClass78_1.NativeFieldInfoPtr_joystickInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_1>.NativeClassPtr, nameof (joystickInfo));
        UserDataStore_PlayerPrefs.__c__DisplayClass78_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_1>.NativeClassPtr, 100678164);
        UserDataStore_PlayerPrefs.__c__DisplayClass78_1.NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__1_Internal_Boolean_JoystickAssignmentHistoryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_1>.NativeClassPtr, 100678165);
      }

      public __c__DisplayClass78_1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.__c__DisplayClass78_1.NativeFieldInfoPtr_joystickInfo));
          return pointer == System.IntPtr.Zero ? (UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo) null : new UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.__c__DisplayClass78_1.NativeFieldInfoPtr_joystickInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("Rewired.Data.UserDataStore_PlayerPrefs/<>c__DisplayClass78_2")]
    public sealed class __c__DisplayClass78_2 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_match;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__2_Internal_Boolean_JoystickAssignmentHistoryInfo_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass78_2()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_2>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.__c__DisplayClass78_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe bool _LoadJoystickAssignmentsNow_b__2(
        UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
        };
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs.__c__DisplayClass78_2.NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__2_Internal_Boolean_JoystickAssignmentHistoryInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass78_2()
      {
        Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "<>c__DisplayClass78_2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_2>.NativeClassPtr);
        UserDataStore_PlayerPrefs.__c__DisplayClass78_2.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_2>.NativeClassPtr, nameof (match));
        UserDataStore_PlayerPrefs.__c__DisplayClass78_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_2>.NativeClassPtr, 100678166);
        UserDataStore_PlayerPrefs.__c__DisplayClass78_2.NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__2_Internal_Boolean_JoystickAssignmentHistoryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs.__c__DisplayClass78_2>.NativeClassPtr, 100678167);
      }

      public __c__DisplayClass78_2(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Joystick match
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.__c__DisplayClass78_2.NativeFieldInfoPtr_match));
          return pointer == System.IntPtr.Zero ? (Joystick) null : new Joystick(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs.__c__DisplayClass78_2.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("Rewired.Data.UserDataStore_PlayerPrefs/<LoadJoystickAssignmentsDeferred>d__80")]
    public sealed class _LoadJoystickAssignmentsDeferred_d__80 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

      [CallerCount(53)]
      [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe _LoadJoystickAssignmentsDeferred_d__80(int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &_param1
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(12611)]
      [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138316, XrefRangeEnd = 138322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138322, XrefRangeEnd = 138328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      static _LoadJoystickAssignmentsDeferred_d__80()
      {
        Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "<LoadJoystickAssignmentsDeferred>d__80");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr);
        UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, "<>1__state");
        UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, "<>2__current");
        UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, "<>4__this");
        UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, 100678168);
        UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, 100678169);
        UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, 100678170);
        UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, 100678171);
        UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, 100678172);
        UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, 100678173);
      }

      public _LoadJoystickAssignmentsDeferred_d__80(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe Il2CppSystem.Object __2__current
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeFieldInfoPtr___2__current));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe UserDataStore_PlayerPrefs __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (UserDataStore_PlayerPrefs) null : new UserDataStore_PlayerPrefs(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UserDataStore_PlayerPrefs._LoadJoystickAssignmentsDeferred_d__80.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
