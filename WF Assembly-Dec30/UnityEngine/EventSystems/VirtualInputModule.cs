// Decompiled with JetBrains decompiler
// Type: UnityEngine.EventSystems.VirtualInputModule
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
  public class VirtualInputModule : PointerInputModule
  {
    private static readonly IntPtr NativeFieldInfoPtr_m_PrevActionTime;
    private static readonly IntPtr NativeFieldInfoPtr_m_LastMoveVector;
    private static readonly IntPtr NativeFieldInfoPtr_m_ConsecutiveMoveCount;
    private static readonly IntPtr NativeFieldInfoPtr_m_LastMousePosition;
    private static readonly IntPtr NativeFieldInfoPtr_m_MousePosition;
    private static readonly IntPtr NativeFieldInfoPtr_m_VirtualCursor;
    private static readonly IntPtr NativeFieldInfoPtr__cam;
    private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalAxis;
    private static readonly IntPtr NativeFieldInfoPtr_m_VerticalAxis;
    private static readonly IntPtr NativeFieldInfoPtr_m_SubmitButton;
    private static readonly IntPtr NativeFieldInfoPtr_m_CancelButton;
    private static readonly IntPtr NativeFieldInfoPtr_m_InputActionsPerSecond;
    private static readonly IntPtr NativeFieldInfoPtr_m_RepeatDelay;
    private static readonly IntPtr NativeFieldInfoPtr_m_ForceModuleActive;
    private static readonly IntPtr NativeFieldInfoPtr_oldButtonState;
    private static readonly IntPtr NativeFieldInfoPtr_m_MouseState;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_inputMode_Public_get_InputMode_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_m_canvasCamera_Private_get_Camera_0;
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
    private static readonly IntPtr NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_SendSubmitEventToSelectedObject_Protected_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRawMoveVector_Private_Vector2_0;
    private static readonly IntPtr NativeMethodInfoPtr_SendMoveEventToSelectedObject_Protected_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_ProcessRewiredEvent_Protected_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_SendUpdateEventToSelectedObject_Protected_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_ProcessMousePress_Protected_Void_MouseButtonEventData_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_MouseState_Int32_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142499, XrefRangeEnd = 142524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VirtualInputModule()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe VirtualInputModule.InputMode inputMode
    {
      [CallerCount(44), CachedScanResults(RefRangeStart = 26224, RefRangeEnd = 26268, XrefRangeStart = 26224, XrefRangeEnd = 26268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_get_inputMode_Public_get_InputMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(VirtualInputModule.InputMode*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Camera m_canvasCamera
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_get_m_canvasCamera_Private_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (Camera) null : new Camera(pointer);
      }
    }

    public unsafe bool allowActivationOnMobileDevice
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_get_allowActivationOnMobileDevice_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_set_allowActivationOnMobileDevice_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_get_forceModuleActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_set_forceModuleActive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_get_inputActionsPerSecond_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_set_inputActionsPerSecond_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_get_repeatDelay_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_set_repeatDelay_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_get_horizontalAxis_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_set_horizontalAxis_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_get_verticalAxis_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_set_verticalAxis_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_get_submitButton_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_set_submitButton_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_get_cancelButton_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_set_cancelButton_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142524, XrefRangeEnd = 142525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void UpdateModule()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VirtualInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public override unsafe bool IsModuleSupported()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VirtualInputModule.NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142525, XrefRangeEnd = 142549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool ShouldActivateModule()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VirtualInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142549, XrefRangeEnd = 142558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void ActivateModule()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VirtualInputModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void DeactivateModule()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VirtualInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142558, XrefRangeEnd = 142581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Process()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VirtualInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142581, XrefRangeEnd = 142585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SendSubmitEventToSelectedObject()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_SendSubmitEventToSelectedObject_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142585, XrefRangeEnd = 142607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Vector2 GetRawMoveVector()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_GetRawMoveVector_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 142639, RefRangeEnd = 142640, XrefRangeStart = 142607, XrefRangeEnd = 142639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SendMoveEventToSelectedObject()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_SendMoveEventToSelectedObject_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 142689, RefRangeEnd = 142690, XrefRangeStart = 142640, XrefRangeEnd = 142689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessRewiredEvent()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_ProcessRewiredEvent_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142690, XrefRangeEnd = 142691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessMouseEvent()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 142718, RefRangeEnd = 142720, XrefRangeStart = 142691, XrefRangeEnd = 142718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessMouseEvent(int id)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &id
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142720, XrefRangeEnd = 142734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SendUpdateEventToSelectedObject()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_SendUpdateEventToSelectedObject_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 142859, RefRangeEnd = 142860, XrefRangeStart = 142734, XrefRangeEnd = 142859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessMousePress(PointerInputModule.MouseButtonEventData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VirtualInputModule.NativeMethodInfoPtr_ProcessMousePress_Protected_Void_MouseButtonEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142860, XrefRangeEnd = 142884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe PointerInputModule.MouseState GetMousePointerEventData(int id)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &id
      };
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VirtualInputModule.NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_MouseState_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (PointerInputModule.MouseState) null : new PointerInputModule.MouseState(pointer);
    }

    static VirtualInputModule()
    {
      Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.EventSystems", nameof (VirtualInputModule));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr);
      VirtualInputModule.NativeFieldInfoPtr_m_PrevActionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, nameof (m_PrevActionTime));
      VirtualInputModule.NativeFieldInfoPtr_m_LastMoveVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, nameof (m_LastMoveVector));
      VirtualInputModule.NativeFieldInfoPtr_m_ConsecutiveMoveCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, nameof (m_ConsecutiveMoveCount));
      VirtualInputModule.NativeFieldInfoPtr_m_LastMousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, nameof (m_LastMousePosition));
      VirtualInputModule.NativeFieldInfoPtr_m_MousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, nameof (m_MousePosition));
      VirtualInputModule.NativeFieldInfoPtr_m_VirtualCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, nameof (m_VirtualCursor));
      VirtualInputModule.NativeFieldInfoPtr__cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, nameof (_cam));
      VirtualInputModule.NativeFieldInfoPtr_m_HorizontalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, nameof (m_HorizontalAxis));
      VirtualInputModule.NativeFieldInfoPtr_m_VerticalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, nameof (m_VerticalAxis));
      VirtualInputModule.NativeFieldInfoPtr_m_SubmitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, nameof (m_SubmitButton));
      VirtualInputModule.NativeFieldInfoPtr_m_CancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, nameof (m_CancelButton));
      VirtualInputModule.NativeFieldInfoPtr_m_InputActionsPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, nameof (m_InputActionsPerSecond));
      VirtualInputModule.NativeFieldInfoPtr_m_RepeatDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, nameof (m_RepeatDelay));
      VirtualInputModule.NativeFieldInfoPtr_m_ForceModuleActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, nameof (m_ForceModuleActive));
      VirtualInputModule.NativeFieldInfoPtr_oldButtonState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, nameof (oldButtonState));
      VirtualInputModule.NativeFieldInfoPtr_m_MouseState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, nameof (m_MouseState));
      VirtualInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678427);
      VirtualInputModule.NativeMethodInfoPtr_get_inputMode_Public_get_InputMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678428);
      VirtualInputModule.NativeMethodInfoPtr_get_m_canvasCamera_Private_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678429);
      VirtualInputModule.NativeMethodInfoPtr_get_allowActivationOnMobileDevice_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678430);
      VirtualInputModule.NativeMethodInfoPtr_set_allowActivationOnMobileDevice_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678431);
      VirtualInputModule.NativeMethodInfoPtr_get_forceModuleActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678432);
      VirtualInputModule.NativeMethodInfoPtr_set_forceModuleActive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678433);
      VirtualInputModule.NativeMethodInfoPtr_get_inputActionsPerSecond_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678434);
      VirtualInputModule.NativeMethodInfoPtr_set_inputActionsPerSecond_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678435);
      VirtualInputModule.NativeMethodInfoPtr_get_repeatDelay_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678436);
      VirtualInputModule.NativeMethodInfoPtr_set_repeatDelay_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678437);
      VirtualInputModule.NativeMethodInfoPtr_get_horizontalAxis_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678438);
      VirtualInputModule.NativeMethodInfoPtr_set_horizontalAxis_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678439);
      VirtualInputModule.NativeMethodInfoPtr_get_verticalAxis_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678440);
      VirtualInputModule.NativeMethodInfoPtr_set_verticalAxis_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678441);
      VirtualInputModule.NativeMethodInfoPtr_get_submitButton_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678442);
      VirtualInputModule.NativeMethodInfoPtr_set_submitButton_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678443);
      VirtualInputModule.NativeMethodInfoPtr_get_cancelButton_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678444);
      VirtualInputModule.NativeMethodInfoPtr_set_cancelButton_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678445);
      VirtualInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678446);
      VirtualInputModule.NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678447);
      VirtualInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678448);
      VirtualInputModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678449);
      VirtualInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678450);
      VirtualInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678451);
      VirtualInputModule.NativeMethodInfoPtr_SendSubmitEventToSelectedObject_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678452);
      VirtualInputModule.NativeMethodInfoPtr_GetRawMoveVector_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678453);
      VirtualInputModule.NativeMethodInfoPtr_SendMoveEventToSelectedObject_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678454);
      VirtualInputModule.NativeMethodInfoPtr_ProcessRewiredEvent_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678455);
      VirtualInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678456);
      VirtualInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678457);
      VirtualInputModule.NativeMethodInfoPtr_SendUpdateEventToSelectedObject_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678458);
      VirtualInputModule.NativeMethodInfoPtr_ProcessMousePress_Protected_Void_MouseButtonEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678459);
      VirtualInputModule.NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_MouseState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualInputModule>.NativeClassPtr, 100678460);
    }

    public VirtualInputModule(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float m_PrevActionTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_PrevActionTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_PrevActionTime)) = value;
      }
    }

    public unsafe Vector2 m_LastMoveVector
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_LastMoveVector));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_LastMoveVector)) = value;
      }
    }

    public unsafe int m_ConsecutiveMoveCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_ConsecutiveMoveCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_ConsecutiveMoveCount)) = value;
      }
    }

    public unsafe Vector2 m_LastMousePosition
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_LastMousePosition));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_LastMousePosition)) = value;
      }
    }

    public unsafe Vector2 m_MousePosition
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_MousePosition));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_MousePosition)) = value;
      }
    }

    public unsafe RectTransform m_VirtualCursor
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_VirtualCursor));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_VirtualCursor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Camera _cam
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr__cam));
        return pointer == IntPtr.Zero ? (Camera) null : new Camera(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr__cam), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string m_HorizontalAxis
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_HorizontalAxis)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_HorizontalAxis), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string m_VerticalAxis
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_VerticalAxis)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_VerticalAxis), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string m_SubmitButton
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_SubmitButton)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_SubmitButton), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string m_CancelButton
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_CancelButton)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_CancelButton), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe float m_InputActionsPerSecond
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_InputActionsPerSecond));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_InputActionsPerSecond)) = value;
      }
    }

    public unsafe float m_RepeatDelay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_RepeatDelay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_RepeatDelay)) = value;
      }
    }

    public unsafe bool m_ForceModuleActive
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_ForceModuleActive));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_ForceModuleActive)) = value;
      }
    }

    public unsafe PointerEventData.FramePressState oldButtonState
    {
      get
      {
        return *(PointerEventData.FramePressState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_oldButtonState));
      }
      [param: In] set
      {
        *(PointerEventData.FramePressState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_oldButtonState)) = value;
      }
    }

    public new unsafe PointerInputModule.MouseState m_MouseState
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_MouseState));
        return pointer == IntPtr.Zero ? (PointerInputModule.MouseState) null : new PointerInputModule.MouseState(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VirtualInputModule.NativeFieldInfoPtr_m_MouseState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public enum InputMode
    {
      Mouse,
      Buttons,
    }
  }
}
