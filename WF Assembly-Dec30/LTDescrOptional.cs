// Decompiled with JetBrains decompiler
// Type: LTDescrOptional
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class LTDescrOptional : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr__toTrans_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__point_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__axis_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__lastVal_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__origRotation_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__path_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__spline_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_animationCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_initFrameCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_color;
  private static readonly System.IntPtr NativeFieldInfoPtr__ltRect_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__onUpdateFloat_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__onUpdateFloatRatio_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__onUpdateFloatObject_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__onUpdateVector2_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__onUpdateVector3_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__onUpdateVector3Object_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__onUpdateColor_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__onUpdateColorObject_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__onComplete_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__onCompleteObject_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__onCompleteParam_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__onUpdateParam_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__onStart_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_toTrans_Public_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_toTrans_Public_set_Void_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_point_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_point_Public_set_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_axis_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_axis_Public_set_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_lastVal_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_lastVal_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_origRotation_Public_get_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_origRotation_Public_set_Void_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_path_Public_get_LTBezierPath_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_path_Public_set_Void_LTBezierPath_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_spline_Public_get_LTSpline_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_spline_Public_set_Void_LTSpline_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ltRect_Public_get_LTRect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ltRect_Public_set_Void_LTRect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_onUpdateFloat_Public_get_Action_1_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_onUpdateFloat_Public_set_Void_Action_1_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_onUpdateFloatRatio_Public_get_Action_2_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_onUpdateFloatRatio_Public_set_Void_Action_2_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_onUpdateFloatObject_Public_get_Action_2_Single_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_onUpdateFloatObject_Public_set_Void_Action_2_Single_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_onUpdateVector2_Public_get_Action_1_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_onUpdateVector2_Public_set_Void_Action_1_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_onUpdateVector3_Public_get_Action_1_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_onUpdateVector3_Public_set_Void_Action_1_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_onUpdateVector3Object_Public_get_Action_2_Vector3_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_onUpdateVector3Object_Public_set_Void_Action_2_Vector3_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_onUpdateColor_Public_get_Action_1_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_onUpdateColor_Public_set_Void_Action_1_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_onUpdateColorObject_Public_get_Action_2_Color_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_onUpdateColorObject_Public_set_Void_Action_2_Color_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_onComplete_Public_get_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_onComplete_Public_set_Void_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_onCompleteObject_Public_get_Action_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_onCompleteObject_Public_set_Void_Action_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_onCompleteParam_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_onCompleteParam_Public_set_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_onUpdateParam_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_onUpdateParam_Public_set_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_onStart_Public_get_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_onStart_Public_set_Void_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_reset_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_callOnUpdate_Public_Void_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe Transform toTrans
  {
    [CallerCount(10), CachedScanResults(RefRangeStart = 20094, RefRangeEnd = 20104, XrefRangeStart = 20094, XrefRangeEnd = 20104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_toTrans_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [CallerCount(21), CachedScanResults(RefRangeStart = 20073, RefRangeEnd = 20094, XrefRangeStart = 20073, XrefRangeEnd = 20094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_toTrans_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe Vector3 point
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_point_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_point_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe Vector3 axis
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_axis_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_axis_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe float lastVal
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_lastVal_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(5), CachedScanResults(RefRangeStart = 136777, RefRangeEnd = 136782, XrefRangeStart = 136777, XrefRangeEnd = 136777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_lastVal_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe Quaternion origRotation
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_origRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_origRotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe LTBezierPath path
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_path_Public_get_LTBezierPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (LTBezierPath) null : new LTBezierPath(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136782, XrefRangeEnd = 136783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_path_Public_set_Void_LTBezierPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe LTSpline spline
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 136783, RefRangeEnd = 136784, XrefRangeStart = 136783, XrefRangeEnd = 136783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_spline_Public_get_LTSpline_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (LTSpline) null : new LTSpline(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136784, XrefRangeEnd = 136785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_spline_Public_set_Void_LTSpline_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe LTRect ltRect
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_ltRect_Public_get_LTRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (LTRect) null : new LTRect(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_ltRect_Public_set_Void_LTRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe Il2CppSystem.Action<float> onUpdateFloat
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onUpdateFloat_Public_get_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<float>) null : new Il2CppSystem.Action<float>(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136785, XrefRangeEnd = 136786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onUpdateFloat_Public_set_Void_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe Il2CppSystem.Action<float, float> onUpdateFloatRatio
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onUpdateFloatRatio_Public_get_Action_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<float, float>) null : new Il2CppSystem.Action<float, float>(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onUpdateFloatRatio_Public_set_Void_Action_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe Il2CppSystem.Action<float, Il2CppSystem.Object> onUpdateFloatObject
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 43117, RefRangeEnd = 43122, XrefRangeStart = 43117, XrefRangeEnd = 43122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onUpdateFloatObject_Public_get_Action_2_Single_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<float, Il2CppSystem.Object>) null : new Il2CppSystem.Action<float, Il2CppSystem.Object>(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136786, XrefRangeEnd = 136787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onUpdateFloatObject_Public_set_Void_Action_2_Single_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe Il2CppSystem.Action<Vector2> onUpdateVector2
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onUpdateVector2_Public_get_Action_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<Vector2>) null : new Il2CppSystem.Action<Vector2>(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136787, XrefRangeEnd = 136788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onUpdateVector2_Public_set_Void_Action_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe Il2CppSystem.Action<Vector3> onUpdateVector3
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onUpdateVector3_Public_get_Action_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<Vector3>) null : new Il2CppSystem.Action<Vector3>(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onUpdateVector3_Public_set_Void_Action_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe Il2CppSystem.Action<Vector3, Il2CppSystem.Object> onUpdateVector3Object
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onUpdateVector3Object_Public_get_Action_2_Vector3_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<Vector3, Il2CppSystem.Object>) null : new Il2CppSystem.Action<Vector3, Il2CppSystem.Object>(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onUpdateVector3Object_Public_set_Void_Action_2_Vector3_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe Il2CppSystem.Action<Color> onUpdateColor
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onUpdateColor_Public_get_Action_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<Color>) null : new Il2CppSystem.Action<Color>(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onUpdateColor_Public_set_Void_Action_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe Il2CppSystem.Action<Color, Il2CppSystem.Object> onUpdateColorObject
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onUpdateColorObject_Public_get_Action_2_Color_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<Color, Il2CppSystem.Object>) null : new Il2CppSystem.Action<Color, Il2CppSystem.Object>(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136788, XrefRangeEnd = 136789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onUpdateColorObject_Public_set_Void_Action_2_Color_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe Il2CppSystem.Action onComplete
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onComplete_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136789, XrefRangeEnd = 136790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onComplete_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe Il2CppSystem.Action<Il2CppSystem.Object> onCompleteObject
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onCompleteObject_Public_get_Action_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<Il2CppSystem.Object>) null : new Il2CppSystem.Action<Il2CppSystem.Object>(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136790, XrefRangeEnd = 136791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onCompleteObject_Public_set_Void_Action_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe Il2CppSystem.Object onCompleteParam
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onCompleteParam_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136791, XrefRangeEnd = 136792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onCompleteParam_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe Il2CppSystem.Object onUpdateParam
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 83193, RefRangeEnd = 83194, XrefRangeStart = 83193, XrefRangeEnd = 83194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onUpdateParam_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136792, XrefRangeEnd = 136793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onUpdateParam_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe Il2CppSystem.Action onStart
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onStart_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136793, XrefRangeEnd = 136794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onStart_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 136808, RefRangeEnd = 136809, XrefRangeStart = 136794, XrefRangeEnd = 136808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 136812, RefRangeEnd = 136813, XrefRangeStart = 136809, XrefRangeEnd = 136812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void callOnUpdate(float val, float ratioPassed)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &val;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ratioPassed;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_callOnUpdate_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1959)]
  [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescrOptional()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LTDescrOptional()
  {
    Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LTDescrOptional));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr);
    LTDescrOptional.NativeFieldInfoPtr__toTrans_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<toTrans>k__BackingField");
    LTDescrOptional.NativeFieldInfoPtr__point_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<point>k__BackingField");
    LTDescrOptional.NativeFieldInfoPtr__axis_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<axis>k__BackingField");
    LTDescrOptional.NativeFieldInfoPtr__lastVal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<lastVal>k__BackingField");
    LTDescrOptional.NativeFieldInfoPtr__origRotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<origRotation>k__BackingField");
    LTDescrOptional.NativeFieldInfoPtr__path_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<path>k__BackingField");
    LTDescrOptional.NativeFieldInfoPtr__spline_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<spline>k__BackingField");
    LTDescrOptional.NativeFieldInfoPtr_animationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, nameof (animationCurve));
    LTDescrOptional.NativeFieldInfoPtr_initFrameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, nameof (initFrameCount));
    LTDescrOptional.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, nameof (color));
    LTDescrOptional.NativeFieldInfoPtr__ltRect_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<ltRect>k__BackingField");
    LTDescrOptional.NativeFieldInfoPtr__onUpdateFloat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateFloat>k__BackingField");
    LTDescrOptional.NativeFieldInfoPtr__onUpdateFloatRatio_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateFloatRatio>k__BackingField");
    LTDescrOptional.NativeFieldInfoPtr__onUpdateFloatObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateFloatObject>k__BackingField");
    LTDescrOptional.NativeFieldInfoPtr__onUpdateVector2_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateVector2>k__BackingField");
    LTDescrOptional.NativeFieldInfoPtr__onUpdateVector3_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateVector3>k__BackingField");
    LTDescrOptional.NativeFieldInfoPtr__onUpdateVector3Object_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateVector3Object>k__BackingField");
    LTDescrOptional.NativeFieldInfoPtr__onUpdateColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateColor>k__BackingField");
    LTDescrOptional.NativeFieldInfoPtr__onUpdateColorObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateColorObject>k__BackingField");
    LTDescrOptional.NativeFieldInfoPtr__onComplete_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onComplete>k__BackingField");
    LTDescrOptional.NativeFieldInfoPtr__onCompleteObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onCompleteObject>k__BackingField");
    LTDescrOptional.NativeFieldInfoPtr__onCompleteParam_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onCompleteParam>k__BackingField");
    LTDescrOptional.NativeFieldInfoPtr__onUpdateParam_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateParam>k__BackingField");
    LTDescrOptional.NativeFieldInfoPtr__onStart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onStart>k__BackingField");
    LTDescrOptional.NativeMethodInfoPtr_get_toTrans_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677368);
    LTDescrOptional.NativeMethodInfoPtr_set_toTrans_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677369);
    LTDescrOptional.NativeMethodInfoPtr_get_point_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677370);
    LTDescrOptional.NativeMethodInfoPtr_set_point_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677371);
    LTDescrOptional.NativeMethodInfoPtr_get_axis_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677372);
    LTDescrOptional.NativeMethodInfoPtr_set_axis_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677373);
    LTDescrOptional.NativeMethodInfoPtr_get_lastVal_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677374);
    LTDescrOptional.NativeMethodInfoPtr_set_lastVal_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677375);
    LTDescrOptional.NativeMethodInfoPtr_get_origRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677376);
    LTDescrOptional.NativeMethodInfoPtr_set_origRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677377);
    LTDescrOptional.NativeMethodInfoPtr_get_path_Public_get_LTBezierPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677378);
    LTDescrOptional.NativeMethodInfoPtr_set_path_Public_set_Void_LTBezierPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677379);
    LTDescrOptional.NativeMethodInfoPtr_get_spline_Public_get_LTSpline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677380);
    LTDescrOptional.NativeMethodInfoPtr_set_spline_Public_set_Void_LTSpline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677381);
    LTDescrOptional.NativeMethodInfoPtr_get_ltRect_Public_get_LTRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677382);
    LTDescrOptional.NativeMethodInfoPtr_set_ltRect_Public_set_Void_LTRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677383);
    LTDescrOptional.NativeMethodInfoPtr_get_onUpdateFloat_Public_get_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677384);
    LTDescrOptional.NativeMethodInfoPtr_set_onUpdateFloat_Public_set_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677385);
    LTDescrOptional.NativeMethodInfoPtr_get_onUpdateFloatRatio_Public_get_Action_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677386);
    LTDescrOptional.NativeMethodInfoPtr_set_onUpdateFloatRatio_Public_set_Void_Action_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677387);
    LTDescrOptional.NativeMethodInfoPtr_get_onUpdateFloatObject_Public_get_Action_2_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677388);
    LTDescrOptional.NativeMethodInfoPtr_set_onUpdateFloatObject_Public_set_Void_Action_2_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677389);
    LTDescrOptional.NativeMethodInfoPtr_get_onUpdateVector2_Public_get_Action_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677390);
    LTDescrOptional.NativeMethodInfoPtr_set_onUpdateVector2_Public_set_Void_Action_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677391);
    LTDescrOptional.NativeMethodInfoPtr_get_onUpdateVector3_Public_get_Action_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677392);
    LTDescrOptional.NativeMethodInfoPtr_set_onUpdateVector3_Public_set_Void_Action_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677393);
    LTDescrOptional.NativeMethodInfoPtr_get_onUpdateVector3Object_Public_get_Action_2_Vector3_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677394);
    LTDescrOptional.NativeMethodInfoPtr_set_onUpdateVector3Object_Public_set_Void_Action_2_Vector3_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677395);
    LTDescrOptional.NativeMethodInfoPtr_get_onUpdateColor_Public_get_Action_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677396);
    LTDescrOptional.NativeMethodInfoPtr_set_onUpdateColor_Public_set_Void_Action_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677397);
    LTDescrOptional.NativeMethodInfoPtr_get_onUpdateColorObject_Public_get_Action_2_Color_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677398);
    LTDescrOptional.NativeMethodInfoPtr_set_onUpdateColorObject_Public_set_Void_Action_2_Color_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677399);
    LTDescrOptional.NativeMethodInfoPtr_get_onComplete_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677400);
    LTDescrOptional.NativeMethodInfoPtr_set_onComplete_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677401);
    LTDescrOptional.NativeMethodInfoPtr_get_onCompleteObject_Public_get_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677402);
    LTDescrOptional.NativeMethodInfoPtr_set_onCompleteObject_Public_set_Void_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677403);
    LTDescrOptional.NativeMethodInfoPtr_get_onCompleteParam_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677404);
    LTDescrOptional.NativeMethodInfoPtr_set_onCompleteParam_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677405);
    LTDescrOptional.NativeMethodInfoPtr_get_onUpdateParam_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677406);
    LTDescrOptional.NativeMethodInfoPtr_set_onUpdateParam_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677407);
    LTDescrOptional.NativeMethodInfoPtr_get_onStart_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677408);
    LTDescrOptional.NativeMethodInfoPtr_set_onStart_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677409);
    LTDescrOptional.NativeMethodInfoPtr_reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677410);
    LTDescrOptional.NativeMethodInfoPtr_callOnUpdate_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677411);
    LTDescrOptional.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100677412);
  }

  public LTDescrOptional(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Transform _toTrans_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__toTrans_k__BackingField));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__toTrans_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 _point_k__BackingField
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__point_k__BackingField));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__point_k__BackingField)) = value;
    }
  }

  public unsafe Vector3 _axis_k__BackingField
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__axis_k__BackingField));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__axis_k__BackingField)) = value;
    }
  }

  public unsafe float _lastVal_k__BackingField
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__lastVal_k__BackingField));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__lastVal_k__BackingField)) = value;
    }
  }

  public unsafe Quaternion _origRotation_k__BackingField
  {
    get
    {
      return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__origRotation_k__BackingField));
    }
    [param: In] set
    {
      *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__origRotation_k__BackingField)) = value;
    }
  }

  public unsafe LTBezierPath _path_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__path_k__BackingField));
      return pointer == System.IntPtr.Zero ? (LTBezierPath) null : new LTBezierPath(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__path_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LTSpline _spline_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__spline_k__BackingField));
      return pointer == System.IntPtr.Zero ? (LTSpline) null : new LTSpline(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__spline_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve animationCurve
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr_animationCurve));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr_animationCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int initFrameCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr_initFrameCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr_initFrameCount)) = value;
    }
  }

  public unsafe Color color
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr_color));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr_color)) = value;
    }
  }

  public unsafe LTRect _ltRect_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__ltRect_k__BackingField));
      return pointer == System.IntPtr.Zero ? (LTRect) null : new LTRect(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__ltRect_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<float> _onUpdateFloat_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateFloat_k__BackingField));
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<float>) null : new Il2CppSystem.Action<float>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateFloat_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<float, float> _onUpdateFloatRatio_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateFloatRatio_k__BackingField));
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<float, float>) null : new Il2CppSystem.Action<float, float>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateFloatRatio_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<float, Il2CppSystem.Object> _onUpdateFloatObject_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateFloatObject_k__BackingField));
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<float, Il2CppSystem.Object>) null : new Il2CppSystem.Action<float, Il2CppSystem.Object>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateFloatObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<Vector2> _onUpdateVector2_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateVector2_k__BackingField));
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<Vector2>) null : new Il2CppSystem.Action<Vector2>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateVector2_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<Vector3> _onUpdateVector3_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateVector3_k__BackingField));
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<Vector3>) null : new Il2CppSystem.Action<Vector3>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateVector3_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<Vector3, Il2CppSystem.Object> _onUpdateVector3Object_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateVector3Object_k__BackingField));
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<Vector3, Il2CppSystem.Object>) null : new Il2CppSystem.Action<Vector3, Il2CppSystem.Object>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateVector3Object_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<Color> _onUpdateColor_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateColor_k__BackingField));
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<Color>) null : new Il2CppSystem.Action<Color>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateColor_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<Color, Il2CppSystem.Object> _onUpdateColorObject_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateColorObject_k__BackingField));
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<Color, Il2CppSystem.Object>) null : new Il2CppSystem.Action<Color, Il2CppSystem.Object>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateColorObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action _onComplete_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onComplete_k__BackingField));
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onComplete_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<Il2CppSystem.Object> _onCompleteObject_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onCompleteObject_k__BackingField));
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<Il2CppSystem.Object>) null : new Il2CppSystem.Action<Il2CppSystem.Object>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onCompleteObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Object _onCompleteParam_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onCompleteParam_k__BackingField));
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onCompleteParam_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Object _onUpdateParam_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateParam_k__BackingField));
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateParam_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action _onStart_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onStart_k__BackingField));
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onStart_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
