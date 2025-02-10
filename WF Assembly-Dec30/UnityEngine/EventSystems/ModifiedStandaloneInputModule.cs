// Decompiled with JetBrains decompiler
// Type: UnityEngine.EventSystems.ModifiedStandaloneInputModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.EventSystems
{
  public class ModifiedStandaloneInputModule : PointerInputModule
  {
    private static readonly IntPtr NativeFieldInfoPtr_m_PrevActionTime;
    private static readonly IntPtr NativeFieldInfoPtr_m_LastMoveVector;
    private static readonly IntPtr NativeFieldInfoPtr_m_ConsecutiveMoveCount;
    private static readonly IntPtr NativeFieldInfoPtr_m_LastMousePosition;
    private static readonly IntPtr NativeFieldInfoPtr_m_MousePosition;
    private static readonly IntPtr NativeFieldInfoPtr_m_CurrentFocusedGameObject;
    private static readonly IntPtr NativeFieldInfoPtr_m_InputPointerEvent;
    private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalAxis;
    private static readonly IntPtr NativeFieldInfoPtr_m_VerticalAxis;
    private static readonly IntPtr NativeFieldInfoPtr_m_SubmitButton;
    private static readonly IntPtr NativeFieldInfoPtr_m_CancelButton;
    private static readonly IntPtr NativeFieldInfoPtr_m_InputActionsPerSecond;
    private static readonly IntPtr NativeFieldInfoPtr_m_RepeatDelay;
    private static readonly IntPtr NativeFieldInfoPtr_m_ForceModuleActive;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_inputMode_Public_get_InputMode_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_allowActivationOnMobileDevice_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_allowActivationOnMobileDevice_Public_set_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_forceModuleActive_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_forceModuleActive_Public_set_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_inputActionsPerSecond_Public_get_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_inputActionsPerSecond_Public_set_Void_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_repeatDelay_Public_get_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_repeatDelay_Public_set_Void_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_horizontalAxis_Public_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_horizontalAxis_Public_set_Void_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_verticalAxis_Public_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_verticalAxis_Public_set_Void_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_submitButton_Public_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_submitButton_Public_set_Void_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_cancelButton_Public_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_cancelButton_Public_set_Void_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_ShouldIgnoreEventsOnNoFocus_Private_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ReleaseMouse_Private_Void_PointerEventData_GameObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ProcessTouchEvents_Private_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_ProcessTouchPress_Protected_Void_PointerEventData_Boolean_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_SendSubmitEventToSelectedObject_Protected_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRawMoveVector_Private_Vector2_0;
    private static readonly IntPtr NativeMethodInfoPtr_SendMoveEventToSelectedObject_Protected_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ForceAutoSelect_Protected_Virtual_New_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_SendUpdateEventToSelectedObject_Protected_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_ProcessMousePress_Protected_Void_MouseButtonEventData_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetCurrentFocusedGameObject_Protected_GameObject_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142089, XrefRangeEnd = 142106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ModifiedStandaloneInputModule()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe ModifiedStandaloneInputModule.InputMode inputMode
    {
      [CallerCount(44), CachedScanResults(RefRangeStart = 26224, RefRangeEnd = 26268, XrefRangeStart = 26224, XrefRangeEnd = 26268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_get_inputMode_Public_get_InputMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ModifiedStandaloneInputModule.InputMode*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool allowActivationOnMobileDevice
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_get_allowActivationOnMobileDevice_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1]
        {
          (IntPtr) &value
        };
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_set_allowActivationOnMobileDevice_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool forceModuleActive
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_get_forceModuleActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1]
        {
          (IntPtr) &value
        };
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_set_forceModuleActive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float inputActionsPerSecond
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_get_inputActionsPerSecond_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1]
        {
          (IntPtr) &value
        };
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_set_inputActionsPerSecond_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float repeatDelay
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_get_repeatDelay_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1]
        {
          (IntPtr) &value
        };
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_set_repeatDelay_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe string horizontalAxis
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 43117, RefRangeEnd = 43122, XrefRangeStart = 43117, XrefRangeEnd = 43122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_get_horizontalAxis_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(value)
        };
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_set_horizontalAxis_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe string verticalAxis
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_get_verticalAxis_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(value)
        };
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_set_verticalAxis_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe string submitButton
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_get_submitButton_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(value)
        };
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_set_submitButton_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe string cancelButton
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_get_cancelButton_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(value)
        };
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_set_cancelButton_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ShouldIgnoreEventsOnNoFocus()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_ShouldIgnoreEventsOnNoFocus_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142106, XrefRangeEnd = 142117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void UpdateModule()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ModifiedStandaloneInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 142182, RefRangeEnd = 142183, XrefRangeStart = 142117, XrefRangeEnd = 142182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pointerEvent);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentOverGo);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_ReleaseMouse_Private_Void_PointerEventData_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142183, XrefRangeEnd = 142185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool IsModuleSupported()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ModifiedStandaloneInputModule.NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142185, XrefRangeEnd = 142194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool ShouldActivateModule()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ModifiedStandaloneInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142194, XrefRangeEnd = 142209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void ActivateModule()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ModifiedStandaloneInputModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142209, XrefRangeEnd = 142211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void DeactivateModule()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ModifiedStandaloneInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142211, XrefRangeEnd = 142231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Process()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ModifiedStandaloneInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 142241, RefRangeEnd = 142242, XrefRangeStart = 142231, XrefRangeEnd = 142241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ProcessTouchEvents()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_ProcessTouchEvents_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 142353, RefRangeEnd = 142354, XrefRangeStart = 142242, XrefRangeEnd = 142353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessTouchPress(
      PointerEventData pointerEvent,
      bool pressed,
      bool released)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pointerEvent);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &pressed;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &released;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_ProcessTouchPress_Protected_Void_PointerEventData_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 142379, RefRangeEnd = 142380, XrefRangeStart = 142354, XrefRangeEnd = 142379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SendSubmitEventToSelectedObject()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_SendSubmitEventToSelectedObject_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142380, XrefRangeEnd = 142387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Vector2 GetRawMoveVector()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_GetRawMoveVector_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 142399, RefRangeEnd = 142400, XrefRangeStart = 142387, XrefRangeEnd = 142399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SendMoveEventToSelectedObject()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_SendMoveEventToSelectedObject_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142400, XrefRangeEnd = 142401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessMouseEvent()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(126)]
    [CachedScanResults(RefRangeStart = 15285, RefRangeEnd = 15411, XrefRangeStart = 15285, XrefRangeEnd = 15411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool ForceAutoSelect()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ModifiedStandaloneInputModule.NativeMethodInfoPtr_ForceAutoSelect_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 142424, RefRangeEnd = 142426, XrefRangeStart = 142401, XrefRangeEnd = 142424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessMouseEvent(int id)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &id
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142426, XrefRangeEnd = 142440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SendUpdateEventToSelectedObject()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_SendUpdateEventToSelectedObject_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 142496, RefRangeEnd = 142499, XrefRangeStart = 142440, XrefRangeEnd = 142496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessMousePress(PointerInputModule.MouseButtonEventData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_ProcessMousePress_Protected_Void_MouseButtonEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe GameObject GetCurrentFocusedGameObject()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifiedStandaloneInputModule.NativeMethodInfoPtr_GetCurrentFocusedGameObject_Protected_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }

    static ModifiedStandaloneInputModule()
    {
      Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.EventSystems", nameof (ModifiedStandaloneInputModule));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr);
      ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_PrevActionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, nameof (m_PrevActionTime));
      ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_LastMoveVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, nameof (m_LastMoveVector));
      ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_ConsecutiveMoveCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, nameof (m_ConsecutiveMoveCount));
      ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_LastMousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, nameof (m_LastMousePosition));
      ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_MousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, nameof (m_MousePosition));
      ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_CurrentFocusedGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, nameof (m_CurrentFocusedGameObject));
      ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_InputPointerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, nameof (m_InputPointerEvent));
      ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_HorizontalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, nameof (m_HorizontalAxis));
      ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_VerticalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, nameof (m_VerticalAxis));
      ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_SubmitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, nameof (m_SubmitButton));
      ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_CancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, nameof (m_CancelButton));
      ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_InputActionsPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, nameof (m_InputActionsPerSecond));
      ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_RepeatDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, nameof (m_RepeatDelay));
      ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_ForceModuleActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, nameof (m_ForceModuleActive));
      ModifiedStandaloneInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678390);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_get_inputMode_Public_get_InputMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678391);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_get_allowActivationOnMobileDevice_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678392);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_set_allowActivationOnMobileDevice_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678393);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_get_forceModuleActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678394);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_set_forceModuleActive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678395);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_get_inputActionsPerSecond_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678396);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_set_inputActionsPerSecond_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678397);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_get_repeatDelay_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678398);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_set_repeatDelay_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678399);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_get_horizontalAxis_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678400);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_set_horizontalAxis_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678401);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_get_verticalAxis_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678402);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_set_verticalAxis_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678403);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_get_submitButton_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678404);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_set_submitButton_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678405);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_get_cancelButton_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678406);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_set_cancelButton_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678407);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_ShouldIgnoreEventsOnNoFocus_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678408);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678409);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_ReleaseMouse_Private_Void_PointerEventData_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678410);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678411);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678412);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678413);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678414);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678415);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_ProcessTouchEvents_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678416);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_ProcessTouchPress_Protected_Void_PointerEventData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678417);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_SendSubmitEventToSelectedObject_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678418);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_GetRawMoveVector_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678419);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_SendMoveEventToSelectedObject_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678420);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678421);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_ForceAutoSelect_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678422);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678423);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_SendUpdateEventToSelectedObject_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678424);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_ProcessMousePress_Protected_Void_MouseButtonEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678425);
      ModifiedStandaloneInputModule.NativeMethodInfoPtr_GetCurrentFocusedGameObject_Protected_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifiedStandaloneInputModule>.NativeClassPtr, 100678426);
    }

    public ModifiedStandaloneInputModule(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float m_PrevActionTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_PrevActionTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_PrevActionTime)) = value;
      }
    }

    public unsafe Vector2 m_LastMoveVector
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_LastMoveVector));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_LastMoveVector)) = value;
      }
    }

    public unsafe int m_ConsecutiveMoveCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_ConsecutiveMoveCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_ConsecutiveMoveCount)) = value;
      }
    }

    public unsafe Vector2 m_LastMousePosition
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_LastMousePosition));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_LastMousePosition)) = value;
      }
    }

    public unsafe Vector2 m_MousePosition
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_MousePosition));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_MousePosition)) = value;
      }
    }

    public unsafe GameObject m_CurrentFocusedGameObject
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_CurrentFocusedGameObject));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_CurrentFocusedGameObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PointerEventData m_InputPointerEvent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_InputPointerEvent));
        return pointer == IntPtr.Zero ? (PointerEventData) null : new PointerEventData(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_InputPointerEvent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string m_HorizontalAxis
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_HorizontalAxis)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_HorizontalAxis), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string m_VerticalAxis
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_VerticalAxis)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_VerticalAxis), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string m_SubmitButton
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_SubmitButton)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_SubmitButton), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string m_CancelButton
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_CancelButton)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_CancelButton), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe float m_InputActionsPerSecond
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_InputActionsPerSecond));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_InputActionsPerSecond)) = value;
      }
    }

    public unsafe float m_RepeatDelay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_RepeatDelay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_RepeatDelay)) = value;
      }
    }

    public unsafe bool m_ForceModuleActive
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_ForceModuleActive));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifiedStandaloneInputModule.NativeFieldInfoPtr_m_ForceModuleActive)) = value;
      }
    }

    public enum InputMode
    {
      Mouse,
      Buttons,
    }
  }
}
