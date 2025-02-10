// Decompiled with JetBrains decompiler
// Type: Rewired.Integration.UnityUI.RewiredPointerInputModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Rewired.UI;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace Rewired.Integration.UnityUI
{
  public class RewiredPointerInputModule : BaseInputModule
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_kMouseLeftId;
    private static readonly System.IntPtr NativeFieldInfoPtr_kMouseRightId;
    private static readonly System.IntPtr NativeFieldInfoPtr_kMouseMiddleId;
    private static readonly System.IntPtr NativeFieldInfoPtr_kFakeTouchesId;
    private static readonly System.IntPtr NativeFieldInfoPtr_customButtonsStartingId;
    private static readonly System.IntPtr NativeFieldInfoPtr_customButtonsMaxCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_customButtonsLastId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_MouseInputSourcesList;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerPointerData;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_UserDefaultTouchInputSource;
    private static readonly System.IntPtr NativeFieldInfoPtr___m_DefaultInputSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_MouseState;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultInputSource_Private_get_UnityInputSource_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultMouseInputSource_Private_get_IMouseInputSource_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultTouchInputSource_Protected_get_ITouchInputSource_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsDefaultMouse_Protected_Boolean_IMouseInputSource_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseInputSource_Public_IMouseInputSource_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveMouseInputSource_Public_Void_IMouseInputSource_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddMouseInputSource_Public_Void_IMouseInputSource_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseInputSourceCount_Public_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTouchInputSource_Public_ITouchInputSource_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveTouchInputSource_Public_Void_ITouchInputSource_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddTouchInputSource_Public_Void_ITouchInputSource_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTouchInputSourceCount_Public_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearMouseInputSources_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_isMouseSupported_Protected_Virtual_New_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsDefaultPlayer_Protected_Abstract_Virtual_New_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPointerData_Protected_Boolean_Int32_Int32_Int32_byref_PlayerPointerEventData_Boolean_PointerEventType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreatePointerEventData_Private_PlayerPointerEventData_Int32_Int32_Int32_PointerEventType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemovePointerData_Protected_Void_PlayerPointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTouchPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Touch_byref_Boolean_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLastPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Int32_Boolean_PointerEventType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessMove_Protected_Virtual_New_Void_PlayerPointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessDrag_Protected_Virtual_New_Void_PlayerPointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearSelection_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeselectIfSelectionChanged_Protected_Void_GameObject_BaseEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyFromTo_Protected_Void_PointerEventData_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StateForMouseButton_Protected_FramePressState_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    public unsafe RewiredPointerInputModule.UnityInputSource defaultInputSource
    {
      [CallerCount(6), CachedScanResults(RefRangeStart = 139843, RefRangeEnd = 139849, XrefRangeStart = 139838, XrefRangeEnd = 139843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_get_defaultInputSource_Private_get_UnityInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (RewiredPointerInputModule.UnityInputSource) null : new RewiredPointerInputModule.UnityInputSource(pointer);
      }
    }

    public unsafe IMouseInputSource defaultMouseInputSource
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139849, XrefRangeEnd = 139850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_get_defaultMouseInputSource_Private_get_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IMouseInputSource) null : new IMouseInputSource(pointer);
      }
    }

    public unsafe ITouchInputSource defaultTouchInputSource
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_get_defaultTouchInputSource_Protected_get_ITouchInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ITouchInputSource) null : new ITouchInputSource(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139850, XrefRangeEnd = 139851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsDefaultMouse(IMouseInputSource mouse)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mouse)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_IsDefaultMouse_Protected_Boolean_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 139857, RefRangeEnd = 139869, XrefRangeStart = 139851, XrefRangeEnd = 139857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &playerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mouseIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_GetMouseInputSource_Public_IMouseInputSource_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IMouseInputSource) null : new IMouseInputSource(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139869, XrefRangeEnd = 139880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveMouseInputSource(IMouseInputSource source)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_RemoveMouseInputSource_Public_Void_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 139897, RefRangeEnd = 139899, XrefRangeStart = 139880, XrefRangeEnd = 139897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddMouseInputSource(IMouseInputSource source)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_AddMouseInputSource_Public_Void_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 139904, RefRangeEnd = 139910, XrefRangeStart = 139899, XrefRangeEnd = 139904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetMouseInputSourceCount(int playerId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &playerId
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_GetMouseInputSourceCount_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 139917, RefRangeEnd = 139918, XrefRangeStart = 139910, XrefRangeEnd = 139917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &playerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sourceIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_GetTouchInputSource_Public_ITouchInputSource_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ITouchInputSource) null : new ITouchInputSource(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139918, XrefRangeEnd = 139919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveTouchInputSource(ITouchInputSource source)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_RemoveTouchInputSource_Public_Void_ITouchInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139919, XrefRangeEnd = 139933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddTouchInputSource(ITouchInputSource source)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_AddTouchInputSource_Public_Void_ITouchInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe int GetTouchInputSourceCount(int playerId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &playerId
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_GetTouchInputSourceCount_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139933, XrefRangeEnd = 139935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearMouseInputSources()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_ClearMouseInputSources_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe bool isMouseSupported
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139935, XrefRangeEnd = 139942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RewiredPointerInputModule.NativeMethodInfoPtr_get_isMouseSupported_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    public virtual unsafe bool IsDefaultPlayer(int playerId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &playerId
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RewiredPointerInputModule.NativeMethodInfoPtr_IsDefaultPlayer_Protected_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 139994, RefRangeEnd = 140001, XrefRangeStart = 139942, XrefRangeEnd = 139994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetPointerData(
      int playerId,
      int pointerIndex,
      int pointerTypeId,
      out PlayerPointerEventData data,
      bool create,
      PointerEventType pointerEventType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[6];
      numPtr1[0] = (System.IntPtr) &playerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pointerIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pointerTypeId;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &create;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &pointerEventType;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_GetPointerData_Protected_Boolean_Int32_Int32_Int32_byref_PlayerPointerEventData_Boolean_PointerEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref PlayerPointerEventData local = ref data;
      System.IntPtr pointer = zero;
      PlayerPointerEventData pointerEventData = pointer == System.IntPtr.Zero ? (PlayerPointerEventData) null : new PlayerPointerEventData(pointer);
      local = pointerEventData;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140001, XrefRangeEnd = 140012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlayerPointerEventData CreatePointerEventData(
      int playerId,
      int pointerIndex,
      int pointerTypeId,
      PointerEventType pointerEventType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &playerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pointerIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pointerTypeId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &pointerEventType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_CreatePointerEventData_Private_PlayerPointerEventData_Int32_Int32_Int32_PointerEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (PlayerPointerEventData) null : new PlayerPointerEventData(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 140018, RefRangeEnd = 140019, XrefRangeStart = 140012, XrefRangeEnd = 140018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemovePointerData(PlayerPointerEventData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_RemovePointerData_Protected_Void_PlayerPointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 140036, RefRangeEnd = 140037, XrefRangeStart = 140019, XrefRangeEnd = 140036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlayerPointerEventData GetTouchPointerEventData(
      int playerId,
      int touchDeviceIndex,
      Touch input,
      out bool pressed,
      out bool released)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &playerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &touchDeviceIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref pressed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref released;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_GetTouchPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Touch_byref_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (PlayerPointerEventData) null : new PlayerPointerEventData(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140037, XrefRangeEnd = 140088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe RewiredPointerInputModule.MouseState GetMousePointerEventData(
      int playerId,
      int mouseIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &playerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mouseIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RewiredPointerInputModule.NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (RewiredPointerInputModule.MouseState) null : new RewiredPointerInputModule.MouseState(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140088, XrefRangeEnd = 140110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlayerPointerEventData GetLastPointerEventData(
      int playerId,
      int pointerIndex,
      int pointerTypeId,
      bool ignorePointerTypeId,
      PointerEventType pointerEventType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &playerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pointerIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pointerTypeId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &ignorePointerTypeId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &pointerEventType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_GetLastPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Int32_Boolean_PointerEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (PlayerPointerEventData) null : new PlayerPointerEventData(pointer);
    }

    [CallerCount(0)]
    public static unsafe bool ShouldStartDrag(
      Vector2 pressPos,
      Vector2 currentPos,
      float threshold,
      bool useDragThreshold)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &pressPos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &currentPos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &threshold;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &useDragThreshold;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140110, XrefRangeEnd = 140126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ProcessMove(PlayerPointerEventData pointerEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pointerEvent)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RewiredPointerInputModule.NativeMethodInfoPtr_ProcessMove_Protected_Virtual_New_Void_PlayerPointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140126, XrefRangeEnd = 140167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ProcessDrag(PlayerPointerEventData pointerEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pointerEvent)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RewiredPointerInputModule.NativeMethodInfoPtr_ProcessDrag_Protected_Virtual_New_Void_PlayerPointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140167, XrefRangeEnd = 140185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool IsPointerOverGameObject(int pointerTypeId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &pointerTypeId
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RewiredPointerInputModule.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 140220, RefRangeEnd = 140221, XrefRangeStart = 140185, XrefRangeEnd = 140220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearSelection()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_ClearSelection_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140221, XrefRangeEnd = 140279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RewiredPointerInputModule.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140279, XrefRangeEnd = 140290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeselectIfSelectionChanged(
      GameObject currentOverGo,
      BaseEventData pointerEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentOverGo);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pointerEvent);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_DeselectIfSelectionChanged_Protected_Void_GameObject_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140290, XrefRangeEnd = 140293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CopyFromTo(PointerEventData from, PointerEventData to)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_CopyFromTo_Protected_Void_PointerEventData_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 140302, RefRangeEnd = 140306, XrefRangeStart = 140293, XrefRangeEnd = 140302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PointerEventData.FramePressState StateForMouseButton(
      int playerId,
      int mouseIndex,
      int buttonId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &playerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mouseIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buttonId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_StateForMouseButton_Protected_FramePressState_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PointerEventData.FramePressState*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140306, XrefRangeEnd = 140334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RewiredPointerInputModule()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RewiredPointerInputModule()
    {
      Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Integration.UnityUI", nameof (RewiredPointerInputModule));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr);
      RewiredPointerInputModule.NativeFieldInfoPtr_kMouseLeftId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (kMouseLeftId));
      RewiredPointerInputModule.NativeFieldInfoPtr_kMouseRightId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (kMouseRightId));
      RewiredPointerInputModule.NativeFieldInfoPtr_kMouseMiddleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (kMouseMiddleId));
      RewiredPointerInputModule.NativeFieldInfoPtr_kFakeTouchesId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (kFakeTouchesId));
      RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsStartingId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (customButtonsStartingId));
      RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsMaxCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (customButtonsMaxCount));
      RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsLastId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (customButtonsLastId));
      RewiredPointerInputModule.NativeFieldInfoPtr_m_MouseInputSourcesList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (m_MouseInputSourcesList));
      RewiredPointerInputModule.NativeFieldInfoPtr_m_PlayerPointerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (m_PlayerPointerData));
      RewiredPointerInputModule.NativeFieldInfoPtr_m_UserDefaultTouchInputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (m_UserDefaultTouchInputSource));
      RewiredPointerInputModule.NativeFieldInfoPtr___m_DefaultInputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (__m_DefaultInputSource));
      RewiredPointerInputModule.NativeFieldInfoPtr_m_MouseState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (m_MouseState));
      RewiredPointerInputModule.NativeMethodInfoPtr_get_defaultInputSource_Private_get_UnityInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678196);
      RewiredPointerInputModule.NativeMethodInfoPtr_get_defaultMouseInputSource_Private_get_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678197);
      RewiredPointerInputModule.NativeMethodInfoPtr_get_defaultTouchInputSource_Protected_get_ITouchInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678198);
      RewiredPointerInputModule.NativeMethodInfoPtr_IsDefaultMouse_Protected_Boolean_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678199);
      RewiredPointerInputModule.NativeMethodInfoPtr_GetMouseInputSource_Public_IMouseInputSource_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678200);
      RewiredPointerInputModule.NativeMethodInfoPtr_RemoveMouseInputSource_Public_Void_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678201);
      RewiredPointerInputModule.NativeMethodInfoPtr_AddMouseInputSource_Public_Void_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678202);
      RewiredPointerInputModule.NativeMethodInfoPtr_GetMouseInputSourceCount_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678203);
      RewiredPointerInputModule.NativeMethodInfoPtr_GetTouchInputSource_Public_ITouchInputSource_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678204);
      RewiredPointerInputModule.NativeMethodInfoPtr_RemoveTouchInputSource_Public_Void_ITouchInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678205);
      RewiredPointerInputModule.NativeMethodInfoPtr_AddTouchInputSource_Public_Void_ITouchInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678206);
      RewiredPointerInputModule.NativeMethodInfoPtr_GetTouchInputSourceCount_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678207);
      RewiredPointerInputModule.NativeMethodInfoPtr_ClearMouseInputSources_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678208);
      RewiredPointerInputModule.NativeMethodInfoPtr_get_isMouseSupported_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678209);
      RewiredPointerInputModule.NativeMethodInfoPtr_IsDefaultPlayer_Protected_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678210);
      RewiredPointerInputModule.NativeMethodInfoPtr_GetPointerData_Protected_Boolean_Int32_Int32_Int32_byref_PlayerPointerEventData_Boolean_PointerEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678211);
      RewiredPointerInputModule.NativeMethodInfoPtr_CreatePointerEventData_Private_PlayerPointerEventData_Int32_Int32_Int32_PointerEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678212);
      RewiredPointerInputModule.NativeMethodInfoPtr_RemovePointerData_Protected_Void_PlayerPointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678213);
      RewiredPointerInputModule.NativeMethodInfoPtr_GetTouchPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Touch_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678214);
      RewiredPointerInputModule.NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678215);
      RewiredPointerInputModule.NativeMethodInfoPtr_GetLastPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Int32_Boolean_PointerEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678216);
      RewiredPointerInputModule.NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678217);
      RewiredPointerInputModule.NativeMethodInfoPtr_ProcessMove_Protected_Virtual_New_Void_PlayerPointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678218);
      RewiredPointerInputModule.NativeMethodInfoPtr_ProcessDrag_Protected_Virtual_New_Void_PlayerPointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678219);
      RewiredPointerInputModule.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678220);
      RewiredPointerInputModule.NativeMethodInfoPtr_ClearSelection_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678221);
      RewiredPointerInputModule.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678222);
      RewiredPointerInputModule.NativeMethodInfoPtr_DeselectIfSelectionChanged_Protected_Void_GameObject_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678223);
      RewiredPointerInputModule.NativeMethodInfoPtr_CopyFromTo_Protected_Void_PointerEventData_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678224);
      RewiredPointerInputModule.NativeMethodInfoPtr_StateForMouseButton_Protected_FramePressState_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678225);
      RewiredPointerInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100678226);
    }

    public RewiredPointerInputModule(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int kMouseLeftId
    {
      get
      {
        int kMouseLeftId;
        IL2CPP.il2cpp_field_static_get_value(RewiredPointerInputModule.NativeFieldInfoPtr_kMouseLeftId, (void*) &kMouseLeftId);
        return kMouseLeftId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RewiredPointerInputModule.NativeFieldInfoPtr_kMouseLeftId, (void*) &value);
      }
    }

    public static unsafe int kMouseRightId
    {
      get
      {
        int kMouseRightId;
        IL2CPP.il2cpp_field_static_get_value(RewiredPointerInputModule.NativeFieldInfoPtr_kMouseRightId, (void*) &kMouseRightId);
        return kMouseRightId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RewiredPointerInputModule.NativeFieldInfoPtr_kMouseRightId, (void*) &value);
      }
    }

    public static unsafe int kMouseMiddleId
    {
      get
      {
        int kMouseMiddleId;
        IL2CPP.il2cpp_field_static_get_value(RewiredPointerInputModule.NativeFieldInfoPtr_kMouseMiddleId, (void*) &kMouseMiddleId);
        return kMouseMiddleId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RewiredPointerInputModule.NativeFieldInfoPtr_kMouseMiddleId, (void*) &value);
      }
    }

    public static unsafe int kFakeTouchesId
    {
      get
      {
        int kFakeTouchesId;
        IL2CPP.il2cpp_field_static_get_value(RewiredPointerInputModule.NativeFieldInfoPtr_kFakeTouchesId, (void*) &kFakeTouchesId);
        return kFakeTouchesId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RewiredPointerInputModule.NativeFieldInfoPtr_kFakeTouchesId, (void*) &value);
      }
    }

    public static unsafe int customButtonsStartingId
    {
      get
      {
        int buttonsStartingId;
        IL2CPP.il2cpp_field_static_get_value(RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsStartingId, (void*) &buttonsStartingId);
        return buttonsStartingId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsStartingId, (void*) &value);
      }
    }

    public static unsafe int customButtonsMaxCount
    {
      get
      {
        int customButtonsMaxCount;
        IL2CPP.il2cpp_field_static_get_value(RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsMaxCount, (void*) &customButtonsMaxCount);
        return customButtonsMaxCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsMaxCount, (void*) &value);
      }
    }

    public static unsafe int customButtonsLastId
    {
      get
      {
        int customButtonsLastId;
        IL2CPP.il2cpp_field_static_get_value(RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsLastId, (void*) &customButtonsLastId);
        return customButtonsLastId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsLastId, (void*) &value);
      }
    }

    public unsafe List<IMouseInputSource> m_MouseInputSourcesList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_MouseInputSourcesList));
        return pointer == System.IntPtr.Zero ? (List<IMouseInputSource>) null : new List<IMouseInputSource>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_MouseInputSourcesList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<int, Il2CppReferenceArray<Dictionary<int, PlayerPointerEventData>>> m_PlayerPointerData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_PlayerPointerData));
        return pointer == System.IntPtr.Zero ? (Dictionary<int, Il2CppReferenceArray<Dictionary<int, PlayerPointerEventData>>>) null : new Dictionary<int, Il2CppReferenceArray<Dictionary<int, PlayerPointerEventData>>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_PlayerPointerData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ITouchInputSource m_UserDefaultTouchInputSource
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_UserDefaultTouchInputSource));
        return pointer == System.IntPtr.Zero ? (ITouchInputSource) null : new ITouchInputSource(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_UserDefaultTouchInputSource), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RewiredPointerInputModule.UnityInputSource __m_DefaultInputSource
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr___m_DefaultInputSource));
        return pointer == System.IntPtr.Zero ? (RewiredPointerInputModule.UnityInputSource) null : new RewiredPointerInputModule.UnityInputSource(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr___m_DefaultInputSource), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RewiredPointerInputModule.MouseState m_MouseState
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_MouseState));
        return pointer == System.IntPtr.Zero ? (RewiredPointerInputModule.MouseState) null : new RewiredPointerInputModule.MouseState(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_MouseState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class MouseState : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_m_TrackedButtons;
      private static readonly System.IntPtr NativeMethodInfoPtr_AnyPressesThisFrame_Public_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_AnyReleasesThisFrame_Public_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonState_Public_ButtonState_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetButtonState_Public_Void_Int32_FramePressState_PlayerPointerEventData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139714, XrefRangeEnd = 139719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool AnyPressesThisFrame()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_AnyPressesThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139719, XrefRangeEnd = 139724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool AnyReleasesThisFrame()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_AnyReleasesThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(12)]
      [CachedScanResults(RefRangeStart = 139743, RefRangeEnd = 139755, XrefRangeStart = 139724, XrefRangeEnd = 139743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe RewiredPointerInputModule.ButtonState GetButtonState(int button)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &button
        };
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_GetButtonState_Public_ButtonState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (RewiredPointerInputModule.ButtonState) null : new RewiredPointerInputModule.ButtonState(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139755, XrefRangeEnd = 139758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetButtonState(
        int button,
        PointerEventData.FramePressState stateForMouseButton,
        PlayerPointerEventData data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &button;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &stateForMouseButton;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_SetButtonState_Public_Void_Int32_FramePressState_PlayerPointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139758, XrefRangeEnd = 139767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe MouseState()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static MouseState()
      {
        Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (MouseState));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr);
        RewiredPointerInputModule.MouseState.NativeFieldInfoPtr_m_TrackedButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr, nameof (m_TrackedButtons));
        RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_AnyPressesThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr, 100678227);
        RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_AnyReleasesThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr, 100678228);
        RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_GetButtonState_Public_ButtonState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr, 100678229);
        RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_SetButtonState_Public_Void_Int32_FramePressState_PlayerPointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr, 100678230);
        RewiredPointerInputModule.MouseState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr, 100678231);
      }

      public MouseState(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe List<RewiredPointerInputModule.ButtonState> m_TrackedButtons
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.MouseState.NativeFieldInfoPtr_m_TrackedButtons));
          return pointer == System.IntPtr.Zero ? (List<RewiredPointerInputModule.ButtonState>) null : new List<RewiredPointerInputModule.ButtonState>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.MouseState.NativeFieldInfoPtr_m_TrackedButtons), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public class MouseButtonEventData : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_buttonState;
      private static readonly System.IntPtr NativeFieldInfoPtr_buttonData;
      private static readonly System.IntPtr NativeMethodInfoPtr_PressedThisFrame_Public_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReleasedThisFrame_Public_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 139767, RefRangeEnd = 139769, XrefRangeStart = 139767, XrefRangeEnd = 139767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool PressedThisFrame()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_PressedThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(17)]
      [CachedScanResults(RefRangeStart = 139769, RefRangeEnd = 139786, XrefRangeStart = 139769, XrefRangeEnd = 139769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool ReleasedThisFrame()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_ReleasedThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe MouseButtonEventData()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseButtonEventData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static MouseButtonEventData()
      {
        Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (MouseButtonEventData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr);
        RewiredPointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr, nameof (buttonState));
        RewiredPointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr, nameof (buttonData));
        RewiredPointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_PressedThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr, 100678232);
        RewiredPointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_ReleasedThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr, 100678233);
        RewiredPointerInputModule.MouseButtonEventData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr, 100678234);
      }

      public MouseButtonEventData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe PointerEventData.FramePressState buttonState
      {
        get
        {
          return *(PointerEventData.FramePressState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonState));
        }
        [param: In] set
        {
          *(PointerEventData.FramePressState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonState)) = value;
        }
      }

      public unsafe PlayerPointerEventData buttonData
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonData));
          return pointer == System.IntPtr.Zero ? (PlayerPointerEventData) null : new PlayerPointerEventData(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public class ButtonState : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_m_Button;
      private static readonly System.IntPtr NativeFieldInfoPtr_m_EventData;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_eventData_Public_get_MouseButtonEventData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_eventData_Public_set_Void_MouseButtonEventData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_button_Public_get_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_button_Public_set_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      public unsafe RewiredPointerInputModule.MouseButtonEventData eventData
      {
        [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_get_eventData_Public_get_MouseButtonEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (RewiredPointerInputModule.MouseButtonEventData) null : new RewiredPointerInputModule.MouseButtonEventData(pointer);
        }
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1]
          {
            IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
          };
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_set_eventData_Public_set_Void_MouseButtonEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      public unsafe int button
      {
        [CallerCount(10), CachedScanResults(RefRangeStart = 137723, RefRangeEnd = 137733, XrefRangeStart = 137723, XrefRangeEnd = 137733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_get_button_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }
        [CallerCount(5), CachedScanResults(RefRangeStart = 128449, RefRangeEnd = 128454, XrefRangeStart = 128449, XrefRangeEnd = 128454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1]
          {
            (System.IntPtr) &value
          };
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_set_button_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ButtonState()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ButtonState()
      {
        Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (ButtonState));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr);
        RewiredPointerInputModule.ButtonState.NativeFieldInfoPtr_m_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr, nameof (m_Button));
        RewiredPointerInputModule.ButtonState.NativeFieldInfoPtr_m_EventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr, nameof (m_EventData));
        RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_get_eventData_Public_get_MouseButtonEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr, 100678235);
        RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_set_eventData_Public_set_Void_MouseButtonEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr, 100678236);
        RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_get_button_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr, 100678237);
        RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_set_button_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr, 100678238);
        RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr, 100678239);
      }

      public ButtonState(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int m_Button
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.ButtonState.NativeFieldInfoPtr_m_Button));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.ButtonState.NativeFieldInfoPtr_m_Button)) = value;
        }
      }

      public unsafe RewiredPointerInputModule.MouseButtonEventData m_EventData
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.ButtonState.NativeFieldInfoPtr_m_EventData));
          return pointer == System.IntPtr.Zero ? (RewiredPointerInputModule.MouseButtonEventData) null : new RewiredPointerInputModule.MouseButtonEventData(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.ButtonState.NativeFieldInfoPtr_m_EventData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public sealed class UnityInputSource : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_m_MousePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_m_MousePositionPrev;
      private static readonly System.IntPtr NativeFieldInfoPtr_m_LastUpdatedFrame;
      private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_enabled_Private_Virtual_Final_New_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_locked_Private_Virtual_Final_New_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_buttonCount_Private_Virtual_Final_New_get_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonDown_Private_Virtual_Final_New_Boolean_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonUp_Private_Virtual_Final_New_Boolean_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButton_Private_Virtual_Final_New_Boolean_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPosition_Private_Virtual_Final_New_get_Vector2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPositionDelta_Private_Virtual_Final_New_get_Vector2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_wheelDelta_Private_Virtual_Final_New_get_Vector2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchSupported_Private_Virtual_Final_New_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchCount_Private_Virtual_Final_New_get_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_GetTouch_Private_Virtual_Final_New_Touch_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryUpdate_Private_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      public virtual unsafe int Rewired\u002EUI\u002EIMouseInputSource\u002EplayerId
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139786, XrefRangeEnd = 139789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public virtual unsafe int Rewired\u002EUI\u002EITouchInputSource\u002EplayerId
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public virtual unsafe bool Rewired\u002EUI\u002EIMouseInputSource\u002Eenabled
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139789, XrefRangeEnd = 139792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_enabled_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public virtual unsafe bool Rewired\u002EUI\u002EIMouseInputSource\u002Elocked
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139792, XrefRangeEnd = 139796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_locked_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public virtual unsafe int Rewired\u002EUI\u002EIMouseInputSource\u002EbuttonCount
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139796, XrefRangeEnd = 139799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_buttonCount_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139799, XrefRangeEnd = 139803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Rewired_UI_IMouseInputSource_GetButtonDown(int button)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &button
        };
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonDown_Private_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139803, XrefRangeEnd = 139807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Rewired_UI_IMouseInputSource_GetButtonUp(int button)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &button
        };
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonUp_Private_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139807, XrefRangeEnd = 139811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Rewired_UI_IMouseInputSource_GetButton(int button)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &button
        };
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButton_Private_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      public virtual unsafe Vector2 Rewired\u002EUI\u002EIMouseInputSource\u002EscreenPosition
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139811, XrefRangeEnd = 139815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPosition_Private_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public virtual unsafe Vector2 Rewired\u002EUI\u002EIMouseInputSource\u002EscreenPositionDelta
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139815, XrefRangeEnd = 139818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPositionDelta_Private_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public virtual unsafe Vector2 Rewired\u002EUI\u002EIMouseInputSource\u002EwheelDelta
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139818, XrefRangeEnd = 139822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_wheelDelta_Private_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public virtual unsafe bool Rewired\u002EUI\u002EITouchInputSource\u002EtouchSupported
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139822, XrefRangeEnd = 139826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchSupported_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public virtual unsafe int Rewired\u002EUI\u002EITouchInputSource\u002EtouchCount
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139826, XrefRangeEnd = 139830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchCount_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139830, XrefRangeEnd = 139834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Touch Rewired_UI_ITouchInputSource_GetTouch(int index)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &index
        };
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_GetTouch_Private_Virtual_Final_New_Touch_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Touch*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139834, XrefRangeEnd = 139837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void TryUpdate()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_TryUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139837, XrefRangeEnd = 139838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe UnityInputSource()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static UnityInputSource()
      {
        Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, nameof (UnityInputSource));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr);
        RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_MousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, nameof (m_MousePosition));
        RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_MousePositionPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, nameof (m_MousePositionPrev));
        RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_LastUpdatedFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, nameof (m_LastUpdatedFrame));
        RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100678240);
        RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100678241);
        RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_enabled_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100678242);
        RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_locked_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100678243);
        RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_buttonCount_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100678244);
        RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonDown_Private_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100678245);
        RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonUp_Private_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100678246);
        RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButton_Private_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100678247);
        RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPosition_Private_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100678248);
        RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPositionDelta_Private_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100678249);
        RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_wheelDelta_Private_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100678250);
        RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchSupported_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100678251);
        RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchCount_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100678252);
        RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_GetTouch_Private_Virtual_Final_New_Touch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100678253);
        RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_TryUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100678254);
        RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100678255);
      }

      public UnityInputSource(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Vector2 m_MousePosition
      {
        get
        {
          return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_MousePosition));
        }
        [param: In] set
        {
          *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_MousePosition)) = value;
        }
      }

      public unsafe Vector2 m_MousePositionPrev
      {
        get
        {
          return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_MousePositionPrev));
        }
        [param: In] set
        {
          *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_MousePositionPrev)) = value;
        }
      }

      public unsafe int m_LastUpdatedFrame
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_LastUpdatedFrame));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_LastUpdatedFrame)) = value;
        }
      }
    }
  }
}
