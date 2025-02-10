// Decompiled with JetBrains decompiler
// Type: Rewired.Integration.UnityUI.RewiredStandaloneInputModule
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
using UnityEngine.EventSystems;

#nullable disable
namespace Rewired.Integration.UnityUI
{
  public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_ACTION_MOVE_HORIZONTAL;
    private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_ACTION_MOVE_VERTICAL;
    private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_ACTION_SUBMIT;
    private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_ACTION_CANCEL;
    private static readonly System.IntPtr NativeFieldInfoPtr_rewiredInputManager;
    private static readonly System.IntPtr NativeFieldInfoPtr_useAllRewiredGamePlayers;
    private static readonly System.IntPtr NativeFieldInfoPtr_useRewiredSystemPlayer;
    private static readonly System.IntPtr NativeFieldInfoPtr_rewiredPlayerIds;
    private static readonly System.IntPtr NativeFieldInfoPtr_usePlayingPlayersOnly;
    private static readonly System.IntPtr NativeFieldInfoPtr_playerMice;
    private static readonly System.IntPtr NativeFieldInfoPtr_moveOneElementPerAxisPress;
    private static readonly System.IntPtr NativeFieldInfoPtr_setActionsById;
    private static readonly System.IntPtr NativeFieldInfoPtr_horizontalActionId;
    private static readonly System.IntPtr NativeFieldInfoPtr_verticalActionId;
    private static readonly System.IntPtr NativeFieldInfoPtr_submitActionId;
    private static readonly System.IntPtr NativeFieldInfoPtr_cancelActionId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_HorizontalAxis;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_VerticalAxis;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SubmitButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_CancelButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_InputActionsPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_RepeatDelay;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_allowMouseInput;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_allowMouseInputIfTouchSupported;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_allowTouchInput;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_deselectIfBackgroundClicked;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_deselectBeforeSelecting;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ForceModuleActive;
    private static readonly System.IntPtr NativeFieldInfoPtr_playerIds;
    private static readonly System.IntPtr NativeFieldInfoPtr_recompiling;
    private static readonly System.IntPtr NativeFieldInfoPtr_isTouchSupported;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PrevActionTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LastMoveVector;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ConsecutiveMoveCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_HasFocus;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RewiredInputManager_Public_get_InputManager_Base_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RewiredInputManager_Public_set_Void_InputManager_Base_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UseAllRewiredGamePlayers_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UseAllRewiredGamePlayers_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UseRewiredSystemPlayer_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UseRewiredSystemPlayer_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RewiredPlayerIds_Public_get_Il2CppStructArray_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RewiredPlayerIds_Public_set_Void_Il2CppStructArray_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UsePlayingPlayersOnly_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UsePlayingPlayersOnly_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerMice_Public_get_List_1_PlayerMouse_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerMice_Public_set_Void_List_1_PlayerMouse_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MoveOneElementPerAxisPress_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_MoveOneElementPerAxisPress_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_allowMouseInput_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_allowMouseInput_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_allowMouseInputIfTouchSupported_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_allowMouseInputIfTouchSupported_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_allowTouchInput_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_allowTouchInput_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_deselectIfBackgroundClicked_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_deselectIfBackgroundClicked_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_deselectBeforeSelecting_Private_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_deselectBeforeSelecting_Private_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SetActionsById_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SetActionsById_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HorizontalActionId_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_HorizontalActionId_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_VerticalActionId_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_VerticalActionId_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SubmitActionId_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SubmitActionId_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CancelActionId_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CancelActionId_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_isMouseSupported_Protected_Virtual_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_isTouchAllowed_Private_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_allowActivationOnMobileDevice_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_allowActivationOnMobileDevice_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_forceModuleActive_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_forceModuleActive_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_inputActionsPerSecond_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_inputActionsPerSecond_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_repeatDelay_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_repeatDelay_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_horizontalAxis_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_horizontalAxis_Public_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_verticalAxis_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_verticalAxis_Public_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_submitButton_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_submitButton_Public_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_cancelButton_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_cancelButton_Public_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Process_Public_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessTouchEvents_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessTouchPress_Private_Void_PointerEventData_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendSubmitEventToSelectedObject_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRawMoveVector_Private_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendMoveEventToSelectedObject_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckButtonOrKeyMovement_Private_Void_byref_Boolean_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessMouseEvents_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessMouseEvent_Private_Void_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendUpdateEventToSelectedObject_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessMousePress_Private_Void_MouseButtonEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleMouseTouchDeselectionOnSelectionChanged_Private_Void_GameObject_BaseEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldIgnoreEventsOnNoFocus_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsDefaultPlayer_Protected_Virtual_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeRewired_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupRewiredVars_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetUpRewiredPlayerMice_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetUpRewiredActions_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetButton_Private_Boolean_Player_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonDown_Private_Boolean_Player_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNegativeButton_Private_Boolean_Player_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNegativeButtonDown_Private_Boolean_Player_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAxis_Private_Single_Player_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckEditorRecompile_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEditorRecompile_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearRewiredVars_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DidAnyMouseMove_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseButtonDownOnAnyMouse_Private_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnRewiredInitialized_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnRewiredShutDown_Private_Void_0;

    public unsafe InputManager_Base RewiredInputManager
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_RewiredInputManager_Public_get_InputManager_Base_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (InputManager_Base) null : new InputManager_Base(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_RewiredInputManager_Public_set_Void_InputManager_Base_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool UseAllRewiredGamePlayers
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_UseAllRewiredGamePlayers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140378, XrefRangeEnd = 140379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_UseAllRewiredGamePlayers_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool UseRewiredSystemPlayer
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_UseRewiredSystemPlayer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140379, XrefRangeEnd = 140380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_UseRewiredSystemPlayer_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppStructArray<int> RewiredPlayerIds
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140380, XrefRangeEnd = 140383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_RewiredPlayerIds_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<int>) null : new Il2CppStructArray<int>(nativeObject);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140383, XrefRangeEnd = 140394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_RewiredPlayerIds_Public_set_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool UsePlayingPlayersOnly
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_UsePlayingPlayersOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_UsePlayingPlayersOnly_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe List<Rewired.Components.PlayerMouse> PlayerMice
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140394, XrefRangeEnd = 140400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_PlayerMice_Public_get_List_1_PlayerMouse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<Rewired.Components.PlayerMouse>) null : new List<Rewired.Components.PlayerMouse>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140400, XrefRangeEnd = 140413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_PlayerMice_Public_set_Void_List_1_PlayerMouse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool MoveOneElementPerAxisPress
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_MoveOneElementPerAxisPress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_MoveOneElementPerAxisPress_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool allowMouseInput
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_allowMouseInput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_allowMouseInput_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool allowMouseInputIfTouchSupported
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_allowMouseInputIfTouchSupported_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_allowMouseInputIfTouchSupported_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool allowTouchInput
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_allowTouchInput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_allowTouchInput_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool deselectIfBackgroundClicked
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_deselectIfBackgroundClicked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_deselectIfBackgroundClicked_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool deselectBeforeSelecting
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_deselectBeforeSelecting_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_deselectBeforeSelecting_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool SetActionsById
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_SetActionsById_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140413, XrefRangeEnd = 140414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_SetActionsById_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int HorizontalActionId
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 140414, RefRangeEnd = 140415, XrefRangeStart = 140414, XrefRangeEnd = 140414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_HorizontalActionId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140415, XrefRangeEnd = 140434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_HorizontalActionId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int VerticalActionId
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_VerticalActionId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140434, XrefRangeEnd = 140453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_VerticalActionId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int SubmitActionId
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_SubmitActionId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140453, XrefRangeEnd = 140472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_SubmitActionId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int CancelActionId
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_CancelActionId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140472, XrefRangeEnd = 140491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_CancelActionId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public override unsafe bool isMouseSupported
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140491, XrefRangeEnd = 140498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_isMouseSupported_Protected_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool isTouchAllowed
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_isTouchAllowed_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool allowActivationOnMobileDevice
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_allowActivationOnMobileDevice_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_allowActivationOnMobileDevice_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool forceModuleActive
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_forceModuleActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_forceModuleActive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float inputActionsPerSecond
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_inputActionsPerSecond_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_inputActionsPerSecond_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float repeatDelay
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_repeatDelay_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_repeatDelay_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe string horizontalAxis
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_horizontalAxis_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140498, XrefRangeEnd = 140511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(value)
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_horizontalAxis_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe string verticalAxis
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_verticalAxis_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140511, XrefRangeEnd = 140524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(value)
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_verticalAxis_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe string submitButton
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_submitButton_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140524, XrefRangeEnd = 140537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(value)
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_submitButton_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe string cancelButton
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_get_cancelButton_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140537, XrefRangeEnd = 140550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(value)
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_set_cancelButton_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140550, XrefRangeEnd = 140605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RewiredStandaloneInputModule()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140605, XrefRangeEnd = 140630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140630, XrefRangeEnd = 140646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void UpdateModule()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool IsModuleSupported()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140646, XrefRangeEnd = 140726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool ShouldActivateModule()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140726, XrefRangeEnd = 140733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void ActivateModule()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140733, XrefRangeEnd = 140735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void DeactivateModule()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140735, XrefRangeEnd = 140773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Process()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 140924, RefRangeEnd = 140925, XrefRangeStart = 140773, XrefRangeEnd = 140924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ProcessTouchEvents()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_ProcessTouchEvents_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140925, XrefRangeEnd = 141047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessTouchPress(
      PointerEventData pointerEvent,
      bool pressed,
      bool released)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pointerEvent);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pressed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &released;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_ProcessTouchPress_Private_Void_PointerEventData_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 141068, RefRangeEnd = 141069, XrefRangeStart = 141047, XrefRangeEnd = 141068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SendSubmitEventToSelectedObject()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_SendSubmitEventToSelectedObject_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 141093, RefRangeEnd = 141094, XrefRangeStart = 141069, XrefRangeEnd = 141093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Vector2 GetRawMoveVector()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_GetRawMoveVector_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 141104, RefRangeEnd = 141105, XrefRangeStart = 141094, XrefRangeEnd = 141104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SendMoveEventToSelectedObject()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_SendMoveEventToSelectedObject_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141105, XrefRangeEnd = 141120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckButtonOrKeyMovement(out bool downHorizontal, out bool downVertical)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref downHorizontal;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref downVertical;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_CheckButtonOrKeyMovement_Private_Void_byref_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141120, XrefRangeEnd = 141129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessMouseEvents()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_ProcessMouseEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 141160, RefRangeEnd = 141162, XrefRangeStart = 141129, XrefRangeEnd = 141160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessMouseEvent(int playerId, int pointerIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &playerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pointerIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141162, XrefRangeEnd = 141176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SendUpdateEventToSelectedObject()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_SendUpdateEventToSelectedObject_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 141274, RefRangeEnd = 141278, XrefRangeStart = 141176, XrefRangeEnd = 141274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessMousePress(
      RewiredPointerInputModule.MouseButtonEventData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_ProcessMousePress_Private_Void_MouseButtonEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 141302, RefRangeEnd = 141305, XrefRangeStart = 141278, XrefRangeEnd = 141302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleMouseTouchDeselectionOnSelectionChanged(
      GameObject currentOverGo,
      BaseEventData pointerEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentOverGo);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pointerEvent);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_HandleMouseTouchDeselectionOnSelectionChanged_Private_Void_GameObject_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void OnApplicationFocus(bool hasFocus)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &hasFocus
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 141316, RefRangeEnd = 141319, XrefRangeStart = 141305, XrefRangeEnd = 141316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ShouldIgnoreEventsOnNoFocus()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_ShouldIgnoreEventsOnNoFocus_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141319, XrefRangeEnd = 141343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141343, XrefRangeEnd = 141357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool IsDefaultPlayer(int playerId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &playerId
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_IsDefaultPlayer_Protected_Virtual_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 141397, RefRangeEnd = 141401, XrefRangeStart = 141357, XrefRangeEnd = 141397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitializeRewired()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_InitializeRewired_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 141486, RefRangeEnd = 141492, XrefRangeStart = 141401, XrefRangeEnd = 141486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupRewiredVars()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_SetupRewiredVars_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141492, XrefRangeEnd = 141513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetUpRewiredPlayerMice()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_SetUpRewiredPlayerMice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 141550, RefRangeEnd = 141551, XrefRangeStart = 141513, XrefRangeEnd = 141550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetUpRewiredActions()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_SetUpRewiredActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141551, XrefRangeEnd = 141552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetButton(Player player, int actionId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &actionId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_GetButton_Private_Boolean_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141552, XrefRangeEnd = 141553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetButtonDown(Player player, int actionId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &actionId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_GetButtonDown_Private_Boolean_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141553, XrefRangeEnd = 141554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetNegativeButton(Player player, int actionId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &actionId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_GetNegativeButton_Private_Boolean_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141554, XrefRangeEnd = 141555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetNegativeButtonDown(Player player, int actionId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &actionId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_GetNegativeButtonDown_Private_Boolean_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141555, XrefRangeEnd = 141556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetAxis(Player player, int actionId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &actionId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_GetAxis_Private_Single_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141556, XrefRangeEnd = 141564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckEditorRecompile()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_CheckEditorRecompile_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141564, XrefRangeEnd = 141565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnEditorRecompile()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_OnEditorRecompile_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 141568, RefRangeEnd = 141570, XrefRangeStart = 141565, XrefRangeEnd = 141568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearRewiredVars()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_ClearRewiredVars_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141570, XrefRangeEnd = 141582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool DidAnyMouseMove()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_DidAnyMouseMove_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141582, XrefRangeEnd = 141594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetMouseButtonDownOnAnyMouse(int buttonIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &buttonIndex
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_GetMouseButtonDownOnAnyMouse_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141594, XrefRangeEnd = 141595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnRewiredInitialized()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_OnRewiredInitialized_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141595, XrefRangeEnd = 141596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnRewiredShutDown()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.NativeMethodInfoPtr_OnRewiredShutDown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RewiredStandaloneInputModule()
    {
      Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Integration.UnityUI", nameof (RewiredStandaloneInputModule));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr);
      RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_MOVE_HORIZONTAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (DEFAULT_ACTION_MOVE_HORIZONTAL));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_MOVE_VERTICAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (DEFAULT_ACTION_MOVE_VERTICAL));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_SUBMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (DEFAULT_ACTION_SUBMIT));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_CANCEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (DEFAULT_ACTION_CANCEL));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_rewiredInputManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (rewiredInputManager));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_useAllRewiredGamePlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (useAllRewiredGamePlayers));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_useRewiredSystemPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (useRewiredSystemPlayer));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_rewiredPlayerIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (rewiredPlayerIds));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_usePlayingPlayersOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (usePlayingPlayersOnly));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_playerMice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (playerMice));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_moveOneElementPerAxisPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (moveOneElementPerAxisPress));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_setActionsById = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (setActionsById));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_horizontalActionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (horizontalActionId));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_verticalActionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (verticalActionId));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_submitActionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (submitActionId));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_cancelActionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (cancelActionId));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_m_HorizontalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (m_HorizontalAxis));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_m_VerticalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (m_VerticalAxis));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_m_SubmitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (m_SubmitButton));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_m_CancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (m_CancelButton));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_m_InputActionsPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (m_InputActionsPerSecond));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_m_RepeatDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (m_RepeatDelay));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_m_allowMouseInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (m_allowMouseInput));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_m_allowMouseInputIfTouchSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (m_allowMouseInputIfTouchSupported));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_m_allowTouchInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (m_allowTouchInput));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_m_deselectIfBackgroundClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (m_deselectIfBackgroundClicked));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_m_deselectBeforeSelecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (m_deselectBeforeSelecting));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_m_ForceModuleActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (m_ForceModuleActive));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_playerIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (playerIds));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_recompiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (recompiling));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_isTouchSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (isTouchSupported));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_m_PrevActionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (m_PrevActionTime));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_m_LastMoveVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (m_LastMoveVector));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_m_ConsecutiveMoveCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (m_ConsecutiveMoveCount));
      RewiredStandaloneInputModule.NativeFieldInfoPtr_m_HasFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (m_HasFocus));
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_RewiredInputManager_Public_get_InputManager_Base_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678256);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_RewiredInputManager_Public_set_Void_InputManager_Base_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678257);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_UseAllRewiredGamePlayers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678258);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_UseAllRewiredGamePlayers_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678259);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_UseRewiredSystemPlayer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678260);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_UseRewiredSystemPlayer_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678261);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_RewiredPlayerIds_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678262);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_RewiredPlayerIds_Public_set_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678263);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_UsePlayingPlayersOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678264);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_UsePlayingPlayersOnly_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678265);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_PlayerMice_Public_get_List_1_PlayerMouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678266);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_PlayerMice_Public_set_Void_List_1_PlayerMouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678267);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_MoveOneElementPerAxisPress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678268);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_MoveOneElementPerAxisPress_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678269);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_allowMouseInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678270);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_allowMouseInput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678271);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_allowMouseInputIfTouchSupported_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678272);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_allowMouseInputIfTouchSupported_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678273);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_allowTouchInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678274);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_allowTouchInput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678275);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_deselectIfBackgroundClicked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678276);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_deselectIfBackgroundClicked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678277);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_deselectBeforeSelecting_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678278);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_deselectBeforeSelecting_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678279);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_SetActionsById_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678280);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_SetActionsById_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678281);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_HorizontalActionId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678282);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_HorizontalActionId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678283);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_VerticalActionId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678284);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_VerticalActionId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678285);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_SubmitActionId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678286);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_SubmitActionId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678287);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_CancelActionId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678288);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_CancelActionId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678289);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_isMouseSupported_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678290);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_isTouchAllowed_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678291);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_allowActivationOnMobileDevice_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678292);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_allowActivationOnMobileDevice_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678293);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_forceModuleActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678294);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_forceModuleActive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678295);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_inputActionsPerSecond_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678296);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_inputActionsPerSecond_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678297);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_repeatDelay_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678298);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_repeatDelay_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678299);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_horizontalAxis_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678300);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_horizontalAxis_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678301);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_verticalAxis_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678302);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_verticalAxis_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678303);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_submitButton_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678304);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_submitButton_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678305);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_get_cancelButton_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678306);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_set_cancelButton_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678307);
      RewiredStandaloneInputModule.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678308);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678309);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678310);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678311);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678312);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678313);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678314);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678315);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_ProcessTouchEvents_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678316);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_ProcessTouchPress_Private_Void_PointerEventData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678317);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_SendSubmitEventToSelectedObject_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678318);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_GetRawMoveVector_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678319);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_SendMoveEventToSelectedObject_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678320);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_CheckButtonOrKeyMovement_Private_Void_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678321);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_ProcessMouseEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678322);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678323);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_SendUpdateEventToSelectedObject_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678324);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_ProcessMousePress_Private_Void_MouseButtonEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678325);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_HandleMouseTouchDeselectionOnSelectionChanged_Private_Void_GameObject_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678326);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678327);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_ShouldIgnoreEventsOnNoFocus_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678328);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678329);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_IsDefaultPlayer_Protected_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678330);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_InitializeRewired_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678331);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_SetupRewiredVars_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678332);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_SetUpRewiredPlayerMice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678333);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_SetUpRewiredActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678334);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_GetButton_Private_Boolean_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678335);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_GetButtonDown_Private_Boolean_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678336);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_GetNegativeButton_Private_Boolean_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678337);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_GetNegativeButtonDown_Private_Boolean_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678338);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_GetAxis_Private_Single_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678339);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_CheckEditorRecompile_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678340);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_OnEditorRecompile_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678341);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_ClearRewiredVars_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678342);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_DidAnyMouseMove_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678343);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_GetMouseButtonDownOnAnyMouse_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678344);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_OnRewiredInitialized_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678345);
      RewiredStandaloneInputModule.NativeMethodInfoPtr_OnRewiredShutDown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, 100678346);
    }

    public RewiredStandaloneInputModule(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string DEFAULT_ACTION_MOVE_HORIZONTAL
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_MOVE_HORIZONTAL, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_MOVE_HORIZONTAL, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string DEFAULT_ACTION_MOVE_VERTICAL
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_MOVE_VERTICAL, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_MOVE_VERTICAL, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string DEFAULT_ACTION_SUBMIT
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_SUBMIT, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_SUBMIT, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string DEFAULT_ACTION_CANCEL
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_CANCEL, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RewiredStandaloneInputModule.NativeFieldInfoPtr_DEFAULT_ACTION_CANCEL, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe InputManager_Base rewiredInputManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_rewiredInputManager));
        return pointer == System.IntPtr.Zero ? (InputManager_Base) null : new InputManager_Base(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_rewiredInputManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool useAllRewiredGamePlayers
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_useAllRewiredGamePlayers));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_useAllRewiredGamePlayers)) = value;
      }
    }

    public unsafe bool useRewiredSystemPlayer
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_useRewiredSystemPlayer));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_useRewiredSystemPlayer)) = value;
      }
    }

    public unsafe Il2CppStructArray<int> rewiredPlayerIds
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_rewiredPlayerIds));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<int>) null : new Il2CppStructArray<int>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_rewiredPlayerIds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool usePlayingPlayersOnly
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_usePlayingPlayersOnly));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_usePlayingPlayersOnly)) = value;
      }
    }

    public unsafe List<Rewired.Components.PlayerMouse> playerMice
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_playerMice));
        return pointer == System.IntPtr.Zero ? (List<Rewired.Components.PlayerMouse>) null : new List<Rewired.Components.PlayerMouse>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_playerMice), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool moveOneElementPerAxisPress
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_moveOneElementPerAxisPress));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_moveOneElementPerAxisPress)) = value;
      }
    }

    public unsafe bool setActionsById
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_setActionsById));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_setActionsById)) = value;
      }
    }

    public unsafe int horizontalActionId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_horizontalActionId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_horizontalActionId)) = value;
      }
    }

    public unsafe int verticalActionId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_verticalActionId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_verticalActionId)) = value;
      }
    }

    public unsafe int submitActionId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_submitActionId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_submitActionId)) = value;
      }
    }

    public unsafe int cancelActionId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_cancelActionId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_cancelActionId)) = value;
      }
    }

    public unsafe string m_HorizontalAxis
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_HorizontalAxis)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_HorizontalAxis), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string m_VerticalAxis
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_VerticalAxis)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_VerticalAxis), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string m_SubmitButton
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_SubmitButton)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_SubmitButton), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string m_CancelButton
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_CancelButton)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_CancelButton), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe float m_InputActionsPerSecond
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_InputActionsPerSecond));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_InputActionsPerSecond)) = value;
      }
    }

    public unsafe float m_RepeatDelay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_RepeatDelay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_RepeatDelay)) = value;
      }
    }

    public unsafe bool m_allowMouseInput
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_allowMouseInput));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_allowMouseInput)) = value;
      }
    }

    public unsafe bool m_allowMouseInputIfTouchSupported
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_allowMouseInputIfTouchSupported));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_allowMouseInputIfTouchSupported)) = value;
      }
    }

    public unsafe bool m_allowTouchInput
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_allowTouchInput));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_allowTouchInput)) = value;
      }
    }

    public unsafe bool m_deselectIfBackgroundClicked
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_deselectIfBackgroundClicked));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_deselectIfBackgroundClicked)) = value;
      }
    }

    public unsafe bool m_deselectBeforeSelecting
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_deselectBeforeSelecting));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_deselectBeforeSelecting)) = value;
      }
    }

    public unsafe bool m_ForceModuleActive
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_ForceModuleActive));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_ForceModuleActive)) = value;
      }
    }

    public unsafe Il2CppStructArray<int> playerIds
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_playerIds));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<int>) null : new Il2CppStructArray<int>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_playerIds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool recompiling
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_recompiling));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_recompiling)) = value;
      }
    }

    public unsafe bool isTouchSupported
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_isTouchSupported));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_isTouchSupported)) = value;
      }
    }

    public unsafe double m_PrevActionTime
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_PrevActionTime));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_PrevActionTime)) = value;
      }
    }

    public unsafe Vector2 m_LastMoveVector
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_LastMoveVector));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_LastMoveVector)) = value;
      }
    }

    public unsafe int m_ConsecutiveMoveCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_ConsecutiveMoveCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_ConsecutiveMoveCount)) = value;
      }
    }

    public unsafe bool m_HasFocus
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_HasFocus));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.NativeFieldInfoPtr_m_HasFocus)) = value;
      }
    }

    [Serializable]
    public class PlayerSetting : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_playerId;
      private static readonly System.IntPtr NativeFieldInfoPtr_playerMice;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_PlayerSetting_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_PlayerSetting_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140334, XrefRangeEnd = 140343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PlayerSetting()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredStandaloneInputModule.PlayerSetting>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.PlayerSetting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 140373, RefRangeEnd = 140374, XrefRangeStart = 140343, XrefRangeEnd = 140373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PlayerSetting(RewiredStandaloneInputModule.PlayerSetting other)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredStandaloneInputModule.PlayerSetting>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.PlayerSetting.NativeMethodInfoPtr__ctor_Private_Void_PlayerSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140374, XrefRangeEnd = 140378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe RewiredStandaloneInputModule.PlayerSetting Clone()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredStandaloneInputModule.PlayerSetting.NativeMethodInfoPtr_Clone_Public_PlayerSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (RewiredStandaloneInputModule.PlayerSetting) null : new RewiredStandaloneInputModule.PlayerSetting(pointer);
      }

      static PlayerSetting()
      {
        Il2CppClassPointerStore<RewiredStandaloneInputModule.PlayerSetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredStandaloneInputModule>.NativeClassPtr, nameof (PlayerSetting));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredStandaloneInputModule.PlayerSetting>.NativeClassPtr);
        RewiredStandaloneInputModule.PlayerSetting.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule.PlayerSetting>.NativeClassPtr, nameof (playerId));
        RewiredStandaloneInputModule.PlayerSetting.NativeFieldInfoPtr_playerMice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredStandaloneInputModule.PlayerSetting>.NativeClassPtr, nameof (playerMice));
        RewiredStandaloneInputModule.PlayerSetting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule.PlayerSetting>.NativeClassPtr, 100678347);
        RewiredStandaloneInputModule.PlayerSetting.NativeMethodInfoPtr__ctor_Private_Void_PlayerSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule.PlayerSetting>.NativeClassPtr, 100678348);
        RewiredStandaloneInputModule.PlayerSetting.NativeMethodInfoPtr_Clone_Public_PlayerSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredStandaloneInputModule.PlayerSetting>.NativeClassPtr, 100678349);
      }

      public PlayerSetting(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int playerId
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.PlayerSetting.NativeFieldInfoPtr_playerId));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.PlayerSetting.NativeFieldInfoPtr_playerId)) = value;
        }
      }

      public unsafe List<Rewired.Components.PlayerMouse> playerMice
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.PlayerSetting.NativeFieldInfoPtr_playerMice));
          return pointer == System.IntPtr.Zero ? (List<Rewired.Components.PlayerMouse>) null : new List<Rewired.Components.PlayerMouse>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredStandaloneInputModule.PlayerSetting.NativeFieldInfoPtr_playerMice), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
