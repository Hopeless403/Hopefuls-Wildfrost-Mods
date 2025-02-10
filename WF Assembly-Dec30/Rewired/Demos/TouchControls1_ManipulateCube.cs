// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.TouchControls1_ManipulateCube
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Demos
{
  public class TouchControls1_ManipulateCube : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_rotateSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_moveSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_currentColorIndex;
    private static readonly IntPtr NativeFieldInfoPtr_colors;
    private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnMoveReceivedX_Private_Void_InputActionEventData_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnMoveReceivedY_Private_Void_InputActionEventData_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnRotationReceivedX_Private_Void_InputActionEventData_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnRotationReceivedY_Private_Void_InputActionEventData_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCycleColor_Private_Void_InputActionEventData_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCycleColorReverse_Private_Void_InputActionEventData_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnMoveReceived_Private_Void_Vector2_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnRotationReceived_Private_Void_Vector2_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCycleColor_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCycleColorReverse_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141596, XrefRangeEnd = 141680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141680, XrefRangeEnd = 141728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141728, XrefRangeEnd = 141730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnMoveReceivedX(InputActionEventData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data))
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnMoveReceivedX_Private_Void_InputActionEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141730, XrefRangeEnd = 141732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnMoveReceivedY(InputActionEventData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data))
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnMoveReceivedY_Private_Void_InputActionEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141732, XrefRangeEnd = 141734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnRotationReceivedX(InputActionEventData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data))
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnRotationReceivedX_Private_Void_InputActionEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141734, XrefRangeEnd = 141736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnRotationReceivedY(InputActionEventData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data))
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnRotationReceivedY_Private_Void_InputActionEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141736, XrefRangeEnd = 141741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnCycleColor(InputActionEventData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data))
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnCycleColor_Private_Void_InputActionEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141741, XrefRangeEnd = 141746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnCycleColorReverse(InputActionEventData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data))
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnCycleColorReverse_Private_Void_InputActionEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 141749, RefRangeEnd = 141751, XrefRangeStart = 141746, XrefRangeEnd = 141749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnMoveReceived(Vector2 move)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &move
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnMoveReceived_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 141759, RefRangeEnd = 141761, XrefRangeStart = 141751, XrefRangeEnd = 141759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnRotationReceived(Vector2 rotate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &rotate
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnRotationReceived_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnCycleColor()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnCycleColor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnCycleColorReverse()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnCycleColorReverse_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141761, XrefRangeEnd = 141768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TouchControls1_ManipulateCube()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchControls1_ManipulateCube>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TouchControls1_ManipulateCube.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TouchControls1_ManipulateCube()
    {
      Il2CppClassPointerStore<TouchControls1_ManipulateCube>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", nameof (TouchControls1_ManipulateCube));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchControls1_ManipulateCube>.NativeClassPtr);
      TouchControls1_ManipulateCube.NativeFieldInfoPtr_rotateSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchControls1_ManipulateCube>.NativeClassPtr, nameof (rotateSpeed));
      TouchControls1_ManipulateCube.NativeFieldInfoPtr_moveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchControls1_ManipulateCube>.NativeClassPtr, nameof (moveSpeed));
      TouchControls1_ManipulateCube.NativeFieldInfoPtr_currentColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchControls1_ManipulateCube>.NativeClassPtr, nameof (currentColorIndex));
      TouchControls1_ManipulateCube.NativeFieldInfoPtr_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchControls1_ManipulateCube>.NativeClassPtr, nameof (colors));
      TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControls1_ManipulateCube>.NativeClassPtr, 100678350);
      TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControls1_ManipulateCube>.NativeClassPtr, 100678351);
      TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnMoveReceivedX_Private_Void_InputActionEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControls1_ManipulateCube>.NativeClassPtr, 100678352);
      TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnMoveReceivedY_Private_Void_InputActionEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControls1_ManipulateCube>.NativeClassPtr, 100678353);
      TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnRotationReceivedX_Private_Void_InputActionEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControls1_ManipulateCube>.NativeClassPtr, 100678354);
      TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnRotationReceivedY_Private_Void_InputActionEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControls1_ManipulateCube>.NativeClassPtr, 100678355);
      TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnCycleColor_Private_Void_InputActionEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControls1_ManipulateCube>.NativeClassPtr, 100678356);
      TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnCycleColorReverse_Private_Void_InputActionEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControls1_ManipulateCube>.NativeClassPtr, 100678357);
      TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnMoveReceived_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControls1_ManipulateCube>.NativeClassPtr, 100678358);
      TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnRotationReceived_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControls1_ManipulateCube>.NativeClassPtr, 100678359);
      TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnCycleColor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControls1_ManipulateCube>.NativeClassPtr, 100678360);
      TouchControls1_ManipulateCube.NativeMethodInfoPtr_OnCycleColorReverse_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControls1_ManipulateCube>.NativeClassPtr, 100678361);
      TouchControls1_ManipulateCube.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchControls1_ManipulateCube>.NativeClassPtr, 100678362);
    }

    public TouchControls1_ManipulateCube(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float rotateSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchControls1_ManipulateCube.NativeFieldInfoPtr_rotateSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchControls1_ManipulateCube.NativeFieldInfoPtr_rotateSpeed)) = value;
      }
    }

    public unsafe float moveSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchControls1_ManipulateCube.NativeFieldInfoPtr_moveSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchControls1_ManipulateCube.NativeFieldInfoPtr_moveSpeed)) = value;
      }
    }

    public unsafe int currentColorIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchControls1_ManipulateCube.NativeFieldInfoPtr_currentColorIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchControls1_ManipulateCube.NativeFieldInfoPtr_currentColorIndex)) = value;
      }
    }

    public unsafe Il2CppStructArray<Color> colors
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchControls1_ManipulateCube.NativeFieldInfoPtr_colors));
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<Color>) null : new Il2CppStructArray<Color>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TouchControls1_ManipulateCube.NativeFieldInfoPtr_colors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
