// Decompiled with JetBrains decompiler
// Type: Rewired.Utils.ExternalTools
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Utils
{
  public class ExternalTools : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__getPlatformInitializerDelegate;
    private static readonly System.IntPtr NativeFieldInfoPtr__isEditorPaused;
    private static readonly System.IntPtr NativeFieldInfoPtr__EditorPausedStateChangedEvent;
    private static readonly System.IntPtr NativeFieldInfoPtr_XboxOneInput_OnGamepadStateChange;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_getPlatformInitializerDelegate_Public_Static_get_Func_1_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_getPlatformInitializerDelegate_Public_Static_set_Void_Func_1_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_isEditorPaused_Public_Virtual_Final_New_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_add_EditorPausedStateChangedEvent_Public_Virtual_Final_New_add_Void_Action_1_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_remove_EditorPausedStateChangedEvent_Public_Virtual_Final_New_rem_Void_Action_1_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPlatformInitializer_Public_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFocusedEditorWindowTitle_Public_Virtual_Final_New_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEditorSceneViewFocused_Public_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LinuxInput_IsJoystickPreconfigured_Public_Virtual_Final_New_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_add_XboxOneInput_OnGamepadStateChange_Public_Virtual_Final_New_add_Void_Action_2_UInt32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_remove_XboxOneInput_OnGamepadStateChange_Public_Virtual_Final_New_rem_Void_Action_2_UInt32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_XboxOneInput_GetUserIdForGamepad_Public_Virtual_Final_New_Int32_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_XboxOneInput_GetControllerId_Public_Virtual_Final_New_UInt64_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_XboxOneInput_IsGamepadActive_Public_Virtual_Final_New_Boolean_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_XboxOneInput_GetControllerType_Public_Virtual_Final_New_String_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_XboxOneInput_GetJoystickId_Public_Virtual_Final_New_UInt32_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_XboxOne_Gamepad_UpdatePlugin_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_XboxOne_Gamepad_SetGamepadVibration_Public_Virtual_Final_New_Boolean_UInt64_Single_Single_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_XboxOne_Gamepad_PulseVibrateMotor_Public_Virtual_Final_New_Void_UInt64_Int32_Single_Single_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDeviceVIDPIDs_Public_Virtual_Final_New_Void_byref_List_1_Int32_byref_List_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAndroidAPILevel_Public_Virtual_Final_New_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WindowsStandalone_ForwardRawInput_Public_Virtual_Final_New_Void_IntPtr_IntPtr_UInt32_IntPtr_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnityUI_Graphic_GetRaycastTarget_Public_Virtual_Final_New_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnityUI_Graphic_SetRaycastTarget_Public_Virtual_Final_New_Void_Object_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UnityInput_IsTouchPressureSupported_Public_Virtual_Final_New_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnityInput_GetTouchPressure_Public_Virtual_Final_New_Single_byref_Touch_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnityInput_GetTouchMaximumPossiblePressure_Public_Virtual_Final_New_Single_byref_Touch_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateControllerTemplate_Public_Virtual_Final_New_IControllerTemplate_Guid_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetControllerTemplateTypes_Public_Virtual_Final_New_Il2CppReferenceArray_1_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetControllerTemplateInterfaceTypes_Public_Virtual_Final_New_Il2CppReferenceArray_1_Type_0;

    public static unsafe Il2CppSystem.Func<Il2CppSystem.Object> getPlatformInitializerDelegate
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138192, XrefRangeEnd = 138194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_get_getPlatformInitializerDelegate_Public_Static_get_Func_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Il2CppSystem.Object>) null : new Il2CppSystem.Func<Il2CppSystem.Object>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138194, XrefRangeEnd = 138198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_set_getPlatformInitializerDelegate_Public_Static_set_Void_Func_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ExternalTools()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Destroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_Destroy_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe bool isEditorPaused
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_get_isEditorPaused_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138198, XrefRangeEnd = 138208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public virtual unsafe void add_EditorPausedStateChangedEvent(Il2CppSystem.Action<bool> value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_add_EditorPausedStateChangedEvent_Public_Virtual_Final_New_add_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138208, XrefRangeEnd = 138218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public virtual unsafe void remove_EditorPausedStateChangedEvent(Il2CppSystem.Action<bool> value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_remove_EditorPausedStateChangedEvent_Public_Virtual_Final_New_rem_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138218, XrefRangeEnd = 138219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object GetPlatformInitializer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_GetPlatformInitializer_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138219, XrefRangeEnd = 138221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe string GetFocusedEditorWindowTitle()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_GetFocusedEditorWindowTitle_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(126)]
    [CachedScanResults(RefRangeStart = 15285, RefRangeEnd = 15411, XrefRangeStart = 15285, XrefRangeEnd = 15411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool IsEditorSceneViewFocused()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_IsEditorSceneViewFocused_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(126)]
    [CachedScanResults(RefRangeStart = 15285, RefRangeEnd = 15411, XrefRangeStart = 15285, XrefRangeEnd = 15411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool LinuxInput_IsJoystickPreconfigured(string name)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(name)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_LinuxInput_IsJoystickPreconfigured_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138221, XrefRangeEnd = 138226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public virtual unsafe void add_XboxOneInput_OnGamepadStateChange(Il2CppSystem.Action<uint, bool> value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_add_XboxOneInput_OnGamepadStateChange_Public_Virtual_Final_New_add_Void_Action_2_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138226, XrefRangeEnd = 138231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public virtual unsafe void remove_XboxOneInput_OnGamepadStateChange(Il2CppSystem.Action<uint, bool> value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_remove_XboxOneInput_OnGamepadStateChange_Public_Virtual_Final_New_rem_Void_Action_2_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(44)]
    [CachedScanResults(RefRangeStart = 26224, RefRangeEnd = 26268, XrefRangeStart = 26224, XrefRangeEnd = 26268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe int XboxOneInput_GetUserIdForGamepad(uint id)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &id
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetUserIdForGamepad_Public_Virtual_Final_New_Int32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(44)]
    [CachedScanResults(RefRangeStart = 26224, RefRangeEnd = 26268, XrefRangeStart = 26224, XrefRangeEnd = 26268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe ulong XboxOneInput_GetControllerId(uint unityJoystickId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &unityJoystickId
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetControllerId_Public_Virtual_Final_New_UInt64_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(126)]
    [CachedScanResults(RefRangeStart = 15285, RefRangeEnd = 15411, XrefRangeStart = 15285, XrefRangeEnd = 15411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool XboxOneInput_IsGamepadActive(uint unityJoystickId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &unityJoystickId
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOneInput_IsGamepadActive_Public_Virtual_Final_New_Boolean_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138231, XrefRangeEnd = 138233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe string XboxOneInput_GetControllerType(ulong xboxControllerId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &xboxControllerId
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetControllerType_Public_Virtual_Final_New_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(44)]
    [CachedScanResults(RefRangeStart = 26224, RefRangeEnd = 26268, XrefRangeStart = 26224, XrefRangeEnd = 26268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe uint XboxOneInput_GetJoystickId(ulong xboxControllerId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &xboxControllerId
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetJoystickId_Public_Virtual_Final_New_UInt32_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void XboxOne_Gamepad_UpdatePlugin()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_UpdatePlugin_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(126)]
    [CachedScanResults(RefRangeStart = 15285, RefRangeEnd = 15411, XrefRangeStart = 15285, XrefRangeEnd = 15411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool XboxOne_Gamepad_SetGamepadVibration(
      ulong xboxOneJoystickId,
      float leftMotor,
      float rightMotor,
      float leftTriggerLevel,
      float rightTriggerLevel)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &xboxOneJoystickId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &leftMotor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rightMotor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &leftTriggerLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rightTriggerLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_SetGamepadVibration_Public_Virtual_Final_New_Boolean_UInt64_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void XboxOne_Gamepad_PulseVibrateMotor(
      ulong xboxOneJoystickId,
      int motorInt,
      float startLevel,
      float endLevel,
      ulong durationMS)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &xboxOneJoystickId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &motorInt;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &startLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &endLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &durationMS;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_PulseVibrateMotor_Public_Virtual_Final_New_Void_UInt64_Int32_Single_Single_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138233, XrefRangeEnd = 138246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero1 = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero1;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero2 = System.IntPtr.Zero;
      System.IntPtr* numPtr4 = &zero2;
      *(System.IntPtr*) num = (System.IntPtr) numPtr4;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_GetDeviceVIDPIDs_Public_Virtual_Final_New_Void_byref_List_1_Int32_byref_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<int> local1 = ref vids;
      System.IntPtr pointer1 = zero1;
      List<> list1 = pointer1 == System.IntPtr.Zero ? (List<>) null : new List<>(pointer1);
      local1 = (List<int>) list1;
      ref List<int> local2 = ref pids;
      System.IntPtr pointer2 = zero2;
      List<> list2 = pointer2 == System.IntPtr.Zero ? (List<>) null : new List<>(pointer2);
      local2 = (List<int>) list2;
    }

    [CallerCount(0)]
    public virtual unsafe int GetAndroidAPILevel()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_GetAndroidAPILevel_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138246, XrefRangeEnd = 138247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void WindowsStandalone_ForwardRawInput(
      System.IntPtr rawInputHeaderIndices,
      System.IntPtr rawInputDataIndices,
      uint indicesCount,
      System.IntPtr rawInputData,
      uint rawInputDataSize)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &rawInputHeaderIndices;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rawInputDataIndices;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &indicesCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &rawInputData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rawInputDataSize;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_WindowsStandalone_ForwardRawInput_Public_Virtual_Final_New_Void_IntPtr_IntPtr_UInt32_IntPtr_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138247, XrefRangeEnd = 138256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool UnityUI_Graphic_GetRaycastTarget(Il2CppSystem.Object graphic)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphic)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_UnityUI_Graphic_GetRaycastTarget_Public_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138256, XrefRangeEnd = 138265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void UnityUI_Graphic_SetRaycastTarget(Il2CppSystem.Object graphic, bool value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphic);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_UnityUI_Graphic_SetRaycastTarget_Public_Virtual_Final_New_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe bool UnityInput_IsTouchPressureSupported
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138265, XrefRangeEnd = 138266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_get_UnityInput_IsTouchPressureSupported_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138266, XrefRangeEnd = 138267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe float UnityInput_GetTouchPressure(ref Touch touch)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) ref touch
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_UnityInput_GetTouchPressure_Public_Virtual_Final_New_Single_byref_Touch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138267, XrefRangeEnd = 138268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) ref touch
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_UnityInput_GetTouchMaximumPossiblePressure_Public_Virtual_Final_New_Single_byref_Touch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138268, XrefRangeEnd = 138272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IControllerTemplate CreateControllerTemplate(
      Il2CppSystem.Guid typeGuid,
      Il2CppSystem.Object payload)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &typeGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) payload);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_CreateControllerTemplate_Public_Virtual_Final_New_IControllerTemplate_Guid_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IControllerTemplate) null : new IControllerTemplate(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138272, XrefRangeEnd = 138280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppReferenceArray<Il2CppSystem.Type> GetControllerTemplateTypes()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_GetControllerTemplateTypes_Public_Virtual_Final_New_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : new Il2CppReferenceArray<Il2CppSystem.Type>(nativeObject);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138280, XrefRangeEnd = 138288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppReferenceArray<Il2CppSystem.Type> GetControllerTemplateInterfaceTypes()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ExternalTools.NativeMethodInfoPtr_GetControllerTemplateInterfaceTypes_Public_Virtual_Final_New_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : new Il2CppReferenceArray<Il2CppSystem.Type>(nativeObject);
    }

    static ExternalTools()
    {
      Il2CppClassPointerStore<ExternalTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Utils", nameof (ExternalTools));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr);
      ExternalTools.NativeFieldInfoPtr__getPlatformInitializerDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, nameof (_getPlatformInitializerDelegate));
      ExternalTools.NativeFieldInfoPtr__isEditorPaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, nameof (_isEditorPaused));
      ExternalTools.NativeFieldInfoPtr__EditorPausedStateChangedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, nameof (_EditorPausedStateChangedEvent));
      ExternalTools.NativeFieldInfoPtr_XboxOneInput_OnGamepadStateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, nameof (XboxOneInput_OnGamepadStateChange));
      ExternalTools.NativeMethodInfoPtr_get_getPlatformInitializerDelegate_Public_Static_get_Func_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678034);
      ExternalTools.NativeMethodInfoPtr_set_getPlatformInitializerDelegate_Public_Static_set_Void_Func_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678035);
      ExternalTools.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678036);
      ExternalTools.NativeMethodInfoPtr_Destroy_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678037);
      ExternalTools.NativeMethodInfoPtr_get_isEditorPaused_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678038);
      ExternalTools.NativeMethodInfoPtr_add_EditorPausedStateChangedEvent_Public_Virtual_Final_New_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678039);
      ExternalTools.NativeMethodInfoPtr_remove_EditorPausedStateChangedEvent_Public_Virtual_Final_New_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678040);
      ExternalTools.NativeMethodInfoPtr_GetPlatformInitializer_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678041);
      ExternalTools.NativeMethodInfoPtr_GetFocusedEditorWindowTitle_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678042);
      ExternalTools.NativeMethodInfoPtr_IsEditorSceneViewFocused_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678043);
      ExternalTools.NativeMethodInfoPtr_LinuxInput_IsJoystickPreconfigured_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678044);
      ExternalTools.NativeMethodInfoPtr_add_XboxOneInput_OnGamepadStateChange_Public_Virtual_Final_New_add_Void_Action_2_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678045);
      ExternalTools.NativeMethodInfoPtr_remove_XboxOneInput_OnGamepadStateChange_Public_Virtual_Final_New_rem_Void_Action_2_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678046);
      ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetUserIdForGamepad_Public_Virtual_Final_New_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678047);
      ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetControllerId_Public_Virtual_Final_New_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678048);
      ExternalTools.NativeMethodInfoPtr_XboxOneInput_IsGamepadActive_Public_Virtual_Final_New_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678049);
      ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetControllerType_Public_Virtual_Final_New_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678050);
      ExternalTools.NativeMethodInfoPtr_XboxOneInput_GetJoystickId_Public_Virtual_Final_New_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678051);
      ExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_UpdatePlugin_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678052);
      ExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_SetGamepadVibration_Public_Virtual_Final_New_Boolean_UInt64_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678053);
      ExternalTools.NativeMethodInfoPtr_XboxOne_Gamepad_PulseVibrateMotor_Public_Virtual_Final_New_Void_UInt64_Int32_Single_Single_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678054);
      ExternalTools.NativeMethodInfoPtr_GetDeviceVIDPIDs_Public_Virtual_Final_New_Void_byref_List_1_Int32_byref_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678055);
      ExternalTools.NativeMethodInfoPtr_GetAndroidAPILevel_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678056);
      ExternalTools.NativeMethodInfoPtr_WindowsStandalone_ForwardRawInput_Public_Virtual_Final_New_Void_IntPtr_IntPtr_UInt32_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678057);
      ExternalTools.NativeMethodInfoPtr_UnityUI_Graphic_GetRaycastTarget_Public_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678058);
      ExternalTools.NativeMethodInfoPtr_UnityUI_Graphic_SetRaycastTarget_Public_Virtual_Final_New_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678059);
      ExternalTools.NativeMethodInfoPtr_get_UnityInput_IsTouchPressureSupported_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678060);
      ExternalTools.NativeMethodInfoPtr_UnityInput_GetTouchPressure_Public_Virtual_Final_New_Single_byref_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678061);
      ExternalTools.NativeMethodInfoPtr_UnityInput_GetTouchMaximumPossiblePressure_Public_Virtual_Final_New_Single_byref_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678062);
      ExternalTools.NativeMethodInfoPtr_CreateControllerTemplate_Public_Virtual_Final_New_IControllerTemplate_Guid_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678063);
      ExternalTools.NativeMethodInfoPtr_GetControllerTemplateTypes_Public_Virtual_Final_New_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678064);
      ExternalTools.NativeMethodInfoPtr_GetControllerTemplateInterfaceTypes_Public_Virtual_Final_New_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalTools>.NativeClassPtr, 100678065);
    }

    public ExternalTools(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Il2CppSystem.Func<Il2CppSystem.Object> _getPlatformInitializerDelegate
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ExternalTools.NativeFieldInfoPtr__getPlatformInitializerDelegate, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Il2CppSystem.Object>) null : new Il2CppSystem.Func<Il2CppSystem.Object>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ExternalTools.NativeFieldInfoPtr__getPlatformInitializerDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _isEditorPaused
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExternalTools.NativeFieldInfoPtr__isEditorPaused));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExternalTools.NativeFieldInfoPtr__isEditorPaused)) = value;
      }
    }

    public unsafe Il2CppSystem.Action<bool> _EditorPausedStateChangedEvent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExternalTools.NativeFieldInfoPtr__EditorPausedStateChangedEvent));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<bool>) null : new Il2CppSystem.Action<bool>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ExternalTools.NativeFieldInfoPtr__EditorPausedStateChangedEvent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<uint, bool> XboxOneInput_OnGamepadStateChange
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExternalTools.NativeFieldInfoPtr_XboxOneInput_OnGamepadStateChange));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<uint, bool>) null : new Il2CppSystem.Action<uint, bool>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ExternalTools.NativeFieldInfoPtr_XboxOneInput_OnGamepadStateChange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
