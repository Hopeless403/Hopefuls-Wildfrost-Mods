// Decompiled with JetBrains decompiler
// Type: TouchInputModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
public class TouchInputModule : BaseInputModule
{
  private static readonly System.IntPtr NativeFieldInfoPtr_input;
  private static readonly System.IntPtr NativeFieldInfoPtr__MousePosition_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__LastMousePosition_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__MouseMove_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Hover_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Press_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ScrollX_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ScrollY_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_pointer;
  private static readonly System.IntPtr NativeFieldInfoPtr_touching;
  private static readonly System.IntPtr NativeFieldInfoPtr_active;
  private static readonly System.IntPtr NativeFieldInfoPtr_blockScroll;
  private static readonly System.IntPtr NativeFieldInfoPtr_offscreen;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MousePosition_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_MousePosition_Private_set_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LastMousePosition_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LastMousePosition_Private_set_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MouseMove_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_MouseMove_Private_set_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Hover_Public_get_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Hover_Private_set_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Press_Public_get_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Press_Private_set_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ScrollX_Public_Static_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ScrollX_Private_Static_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ScrollY_Public_Static_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ScrollY_Private_Static_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BlockScroll_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnblockScroll_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Process_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ForceUpdate_Private_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CardControllerEnabled_Private_Void_CardController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTouch_Private_Nullable_1_Touch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSimulatedTouch_Private_Touch_Vector2_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PopulateTouchPointerData_Private_Void_Touch_byref_Boolean_byref_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessTouch_Private_Void_Touch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessTouchPress_Private_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessTouchRelease_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessTouchMove_Private_Void_GameObject_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessTouchDrag_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindFirstRaycast_Private_Static_RaycastResult_List_1_RaycastResult_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe Vector2 MousePosition
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_get_MousePosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_set_MousePosition_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe Vector2 LastMousePosition
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_get_LastMousePosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_set_LastMousePosition_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe Vector2 MouseMove
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_get_MouseMove_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_set_MouseMove_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe GameObject Hover
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_get_Hover_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17426, XrefRangeEnd = 17427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_set_Hover_Private_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe GameObject Press
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_get_Press_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17427, XrefRangeEnd = 17428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_set_Press_Private_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public static unsafe float ScrollX
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17428, XrefRangeEnd = 17432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_get_ScrollX_Public_Static_get_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17432, XrefRangeEnd = 17436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_set_ScrollX_Private_Static_set_Void_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public static unsafe float ScrollY
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17436, XrefRangeEnd = 17440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_get_ScrollY_Public_Static_get_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17440, XrefRangeEnd = 17444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_set_ScrollY_Private_Static_set_Void_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17444, XrefRangeEnd = 17469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TouchInputModule.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17469, XrefRangeEnd = 17497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TouchInputModule.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17497, XrefRangeEnd = 17501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void BlockScroll()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_BlockScroll_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 17505, RefRangeEnd = 17506, XrefRangeStart = 17501, XrefRangeEnd = 17505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void UnblockScroll()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_UnblockScroll_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17506, XrefRangeEnd = 17526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Process()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TouchInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void ForceUpdate(bool forceTouch)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &forceTouch
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_ForceUpdate_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17526, XrefRangeEnd = 17528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void UpdateModule()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TouchInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17528, XrefRangeEnd = 17543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CardControllerEnabled(CardController controller)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_CardControllerEnabled_Private_Void_CardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17543, XrefRangeEnd = 17544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppSystem.Nullable<Touch> GetTouch()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_GetTouch_Private_Nullable_1_Touch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return new Il2CppSystem.Nullable<Touch>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17544, XrefRangeEnd = 17556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Touch GetSimulatedTouch(Vector2 position, bool pressed, bool released)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pressed;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &released;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_GetSimulatedTouch_Private_Touch_Vector2_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Touch*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 17575, RefRangeEnd = 17576, XrefRangeStart = 17556, XrefRangeEnd = 17575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PopulateTouchPointerData(Touch touch, out bool pressed, out bool released)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &touch;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref pressed;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref released;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_PopulateTouchPointerData_Private_Void_Touch_byref_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 17603, RefRangeEnd = 17604, XrefRangeStart = 17576, XrefRangeEnd = 17603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessTouch(Touch touch)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &touch
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_ProcessTouch_Private_Void_Touch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 17640, RefRangeEnd = 17641, XrefRangeStart = 17604, XrefRangeEnd = 17640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessTouchPress(GameObject preHover)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) preHover)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_ProcessTouchPress_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17641, XrefRangeEnd = 17687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessTouchRelease()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_ProcessTouchRelease_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 17722, RefRangeEnd = 17723, XrefRangeStart = 17687, XrefRangeEnd = 17722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessTouchMove(GameObject preHover, GameObject hover)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) preHover);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hover);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_ProcessTouchMove_Private_Void_GameObject_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 17746, RefRangeEnd = 17747, XrefRangeStart = 17723, XrefRangeEnd = 17746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessTouchDrag()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_ProcessTouchDrag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
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
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 17761, RefRangeEnd = 17762, XrefRangeStart = 17747, XrefRangeEnd = 17761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new static unsafe RaycastResult FindFirstRaycast(List<RaycastResult> candidates)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) candidates)
    };
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_FindFirstRaycast_Private_Static_RaycastResult_List_1_RaycastResult_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return new RaycastResult(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17762, XrefRangeEnd = 17763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TouchInputModule()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TouchInputModule()
  {
    Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TouchInputModule));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr);
    TouchInputModule.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, nameof (input));
    TouchInputModule.NativeFieldInfoPtr__MousePosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, "<MousePosition>k__BackingField");
    TouchInputModule.NativeFieldInfoPtr__LastMousePosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, "<LastMousePosition>k__BackingField");
    TouchInputModule.NativeFieldInfoPtr__MouseMove_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, "<MouseMove>k__BackingField");
    TouchInputModule.NativeFieldInfoPtr__Hover_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, "<Hover>k__BackingField");
    TouchInputModule.NativeFieldInfoPtr__Press_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, "<Press>k__BackingField");
    TouchInputModule.NativeFieldInfoPtr__ScrollX_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, "<ScrollX>k__BackingField");
    TouchInputModule.NativeFieldInfoPtr__ScrollY_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, "<ScrollY>k__BackingField");
    TouchInputModule.NativeFieldInfoPtr_pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, nameof (pointer));
    TouchInputModule.NativeFieldInfoPtr_touching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, nameof (touching));
    TouchInputModule.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, nameof (active));
    TouchInputModule.NativeFieldInfoPtr_blockScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, nameof (blockScroll));
    TouchInputModule.NativeFieldInfoPtr_offscreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, nameof (offscreen));
    TouchInputModule.NativeMethodInfoPtr_get_MousePosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663479);
    TouchInputModule.NativeMethodInfoPtr_set_MousePosition_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663480);
    TouchInputModule.NativeMethodInfoPtr_get_LastMousePosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663481);
    TouchInputModule.NativeMethodInfoPtr_set_LastMousePosition_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663482);
    TouchInputModule.NativeMethodInfoPtr_get_MouseMove_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663483);
    TouchInputModule.NativeMethodInfoPtr_set_MouseMove_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663484);
    TouchInputModule.NativeMethodInfoPtr_get_Hover_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663485);
    TouchInputModule.NativeMethodInfoPtr_set_Hover_Private_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663486);
    TouchInputModule.NativeMethodInfoPtr_get_Press_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663487);
    TouchInputModule.NativeMethodInfoPtr_set_Press_Private_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663488);
    TouchInputModule.NativeMethodInfoPtr_get_ScrollX_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663489);
    TouchInputModule.NativeMethodInfoPtr_set_ScrollX_Private_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663490);
    TouchInputModule.NativeMethodInfoPtr_get_ScrollY_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663491);
    TouchInputModule.NativeMethodInfoPtr_set_ScrollY_Private_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663492);
    TouchInputModule.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663493);
    TouchInputModule.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663494);
    TouchInputModule.NativeMethodInfoPtr_BlockScroll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663495);
    TouchInputModule.NativeMethodInfoPtr_UnblockScroll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663496);
    TouchInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663497);
    TouchInputModule.NativeMethodInfoPtr_ForceUpdate_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663498);
    TouchInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663499);
    TouchInputModule.NativeMethodInfoPtr_CardControllerEnabled_Private_Void_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663500);
    TouchInputModule.NativeMethodInfoPtr_GetTouch_Private_Nullable_1_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663501);
    TouchInputModule.NativeMethodInfoPtr_GetSimulatedTouch_Private_Touch_Vector2_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663502);
    TouchInputModule.NativeMethodInfoPtr_PopulateTouchPointerData_Private_Void_Touch_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663503);
    TouchInputModule.NativeMethodInfoPtr_ProcessTouch_Private_Void_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663504);
    TouchInputModule.NativeMethodInfoPtr_ProcessTouchPress_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663505);
    TouchInputModule.NativeMethodInfoPtr_ProcessTouchRelease_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663506);
    TouchInputModule.NativeMethodInfoPtr_ProcessTouchMove_Private_Void_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663507);
    TouchInputModule.NativeMethodInfoPtr_ProcessTouchDrag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663508);
    TouchInputModule.NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663509);
    TouchInputModule.NativeMethodInfoPtr_FindFirstRaycast_Private_Static_RaycastResult_List_1_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663510);
    TouchInputModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100663511);
  }

  public TouchInputModule(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public new unsafe BaseInput input
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr_input));
      return pointer == System.IntPtr.Zero ? (BaseInput) null : new BaseInput(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr_input), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 _MousePosition_k__BackingField
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr__MousePosition_k__BackingField));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr__MousePosition_k__BackingField)) = value;
    }
  }

  public unsafe Vector2 _LastMousePosition_k__BackingField
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr__LastMousePosition_k__BackingField));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr__LastMousePosition_k__BackingField)) = value;
    }
  }

  public unsafe Vector2 _MouseMove_k__BackingField
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr__MouseMove_k__BackingField));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr__MouseMove_k__BackingField)) = value;
    }
  }

  public unsafe GameObject _Hover_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr__Hover_k__BackingField));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr__Hover_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject _Press_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr__Press_k__BackingField));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr__Press_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe float _ScrollX_k__BackingField
  {
    get
    {
      float scrollXKBackingField;
      IL2CPP.il2cpp_field_static_get_value(TouchInputModule.NativeFieldInfoPtr__ScrollX_k__BackingField, (void*) &scrollXKBackingField);
      return scrollXKBackingField;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TouchInputModule.NativeFieldInfoPtr__ScrollX_k__BackingField, (void*) &value);
    }
  }

  public static unsafe float _ScrollY_k__BackingField
  {
    get
    {
      float scrollYKBackingField;
      IL2CPP.il2cpp_field_static_get_value(TouchInputModule.NativeFieldInfoPtr__ScrollY_k__BackingField, (void*) &scrollYKBackingField);
      return scrollYKBackingField;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TouchInputModule.NativeFieldInfoPtr__ScrollY_k__BackingField, (void*) &value);
    }
  }

  public unsafe PointerEventData pointer
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr_pointer));
      return pointer == System.IntPtr.Zero ? (PointerEventData) null : new PointerEventData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr_pointer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe bool touching
  {
    get
    {
      bool touching;
      IL2CPP.il2cpp_field_static_get_value(TouchInputModule.NativeFieldInfoPtr_touching, (void*) &touching);
      return touching;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TouchInputModule.NativeFieldInfoPtr_touching, (void*) &value);
    }
  }

  public static unsafe bool active
  {
    get
    {
      bool active;
      IL2CPP.il2cpp_field_static_get_value(TouchInputModule.NativeFieldInfoPtr_active, (void*) &active);
      return active;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TouchInputModule.NativeFieldInfoPtr_active, (void*) &value);
    }
  }

  public static unsafe int blockScroll
  {
    get
    {
      int blockScroll;
      IL2CPP.il2cpp_field_static_get_value(TouchInputModule.NativeFieldInfoPtr_blockScroll, (void*) &blockScroll);
      return blockScroll;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TouchInputModule.NativeFieldInfoPtr_blockScroll, (void*) &value);
    }
  }

  public static unsafe Vector2 offscreen
  {
    get
    {
      Vector2 offscreen;
      IL2CPP.il2cpp_field_static_get_value(TouchInputModule.NativeFieldInfoPtr_offscreen, (void*) &offscreen);
      return offscreen;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TouchInputModule.NativeFieldInfoPtr_offscreen, (void*) &value);
    }
  }
}
