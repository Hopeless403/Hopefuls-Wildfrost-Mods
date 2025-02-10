// Decompiled with JetBrains decompiler
// Type: Rewired.Platforms.Switch.NintendoSwitchInputManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Platforms.Switch
{
  public sealed class NintendoSwitchInputManager : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__userData;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IExternalInputManager_Initialize_Private_Virtual_Final_New_Object_Platform_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IExternalInputManager_Deinitialize_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(44)]
    [CachedScanResults(RefRangeStart = 26224, RefRangeEnd = 26268, XrefRangeStart = 26224, XrefRangeEnd = 26268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object Rewired_Utils_Interfaces_IExternalInputManager_Initialize(
      Platform platform,
      Il2CppSystem.Object configVars)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &platform;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) configVars);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IExternalInputManager_Initialize_Private_Virtual_Final_New_Object_Platform_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Rewired_Utils_Interfaces_IExternalInputManager_Deinitialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IExternalInputManager_Deinitialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138185, XrefRangeEnd = 138192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NintendoSwitchInputManager()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NintendoSwitchInputManager()
    {
      Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Platforms.Switch", nameof (NintendoSwitchInputManager));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr);
      NintendoSwitchInputManager.NativeFieldInfoPtr__userData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr, nameof (_userData));
      NintendoSwitchInputManager.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IExternalInputManager_Initialize_Private_Virtual_Final_New_Object_Platform_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr, 100677955);
      NintendoSwitchInputManager.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IExternalInputManager_Deinitialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr, 100677956);
      NintendoSwitchInputManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr, 100677957);
    }

    public NintendoSwitchInputManager(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NintendoSwitchInputManager.UserData _userData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NativeFieldInfoPtr__userData));
        return pointer == System.IntPtr.Zero ? (NintendoSwitchInputManager.UserData) null : new NintendoSwitchInputManager.UserData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NativeFieldInfoPtr__userData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class UserData : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__allowedNpadStyles;
      private static readonly System.IntPtr NativeFieldInfoPtr__joyConGripStyle;
      private static readonly System.IntPtr NativeFieldInfoPtr__adjustIMUsForGripStyle;
      private static readonly System.IntPtr NativeFieldInfoPtr__handheldActivationMode;
      private static readonly System.IntPtr NativeFieldInfoPtr__assignJoysticksByNpadId;
      private static readonly System.IntPtr NativeFieldInfoPtr__useVibrationThread;
      private static readonly System.IntPtr NativeFieldInfoPtr__npadNo1;
      private static readonly System.IntPtr NativeFieldInfoPtr__npadNo2;
      private static readonly System.IntPtr NativeFieldInfoPtr__npadNo3;
      private static readonly System.IntPtr NativeFieldInfoPtr__npadNo4;
      private static readonly System.IntPtr NativeFieldInfoPtr__npadNo5;
      private static readonly System.IntPtr NativeFieldInfoPtr__npadNo6;
      private static readonly System.IntPtr NativeFieldInfoPtr__npadNo7;
      private static readonly System.IntPtr NativeFieldInfoPtr__npadNo8;
      private static readonly System.IntPtr NativeFieldInfoPtr__npadHandheld;
      private static readonly System.IntPtr NativeFieldInfoPtr__debugPad;
      private static readonly System.IntPtr NativeFieldInfoPtr___delegates;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_allowedNpadStyles_Public_get_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_allowedNpadStyles_Public_set_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_joyConGripStyle_Public_get_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_joyConGripStyle_Public_set_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_adjustIMUsForGripStyle_Public_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_adjustIMUsForGripStyle_Public_set_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_handheldActivationMode_Public_get_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_handheldActivationMode_Public_set_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_assignJoysticksByNpadId_Public_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_assignJoysticksByNpadId_Public_set_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_useVibrationThread_Public_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_useVibrationThread_Public_set_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_npadNo1_Private_get_NpadSettings_Internal_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_npadNo2_Private_get_NpadSettings_Internal_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_npadNo3_Private_get_NpadSettings_Internal_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_npadNo4_Private_get_NpadSettings_Internal_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_npadNo5_Private_get_NpadSettings_Internal_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_npadNo6_Private_get_NpadSettings_Internal_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_npadNo7_Private_get_NpadSettings_Internal_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_npadNo8_Private_get_NpadSettings_Internal_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_npadHandheld_Private_get_NpadSettings_Internal_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_debugPad_Public_get_DebugPadSettings_Internal_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_0_Private_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_1_Private_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_2_Private_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_3_Private_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_4_Private_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_5_Private_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_6_Private_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_7_Private_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_8_Private_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_9_Private_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_10_Private_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_11_Private_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_12_Private_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_13_Private_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_14_Private_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_15_Private_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_16_Private_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_17_Private_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_18_Private_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_19_Private_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_20_Private_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__56_21_Private_Void_Boolean_0;

      public unsafe int allowedNpadStyles
      {
        [CallerCount(10), CachedScanResults(RefRangeStart = 137723, RefRangeEnd = 137733, XrefRangeStart = 137723, XrefRangeEnd = 137723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_allowedNpadStyles_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_allowedNpadStyles_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      public unsafe int joyConGripStyle
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_joyConGripStyle_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }
        [CallerCount(9), CachedScanResults(RefRangeStart = 137733, RefRangeEnd = 137742, XrefRangeStart = 137733, XrefRangeEnd = 137733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1]
          {
            (System.IntPtr) &value
          };
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_joyConGripStyle_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      public unsafe bool adjustIMUsForGripStyle
      {
        [CallerCount(2), CachedScanResults(RefRangeStart = 23871, RefRangeEnd = 23873, XrefRangeStart = 23871, XrefRangeEnd = 23873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_adjustIMUsForGripStyle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_adjustIMUsForGripStyle_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      public unsafe int handheldActivationMode
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_handheldActivationMode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }
        [CallerCount(1), CachedScanResults(RefRangeStart = 27305, RefRangeEnd = 27306, XrefRangeStart = 27305, XrefRangeEnd = 27306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1]
          {
            (System.IntPtr) &value
          };
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_handheldActivationMode_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      public unsafe bool assignJoysticksByNpadId
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_assignJoysticksByNpadId_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_assignJoysticksByNpadId_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      public unsafe bool useVibrationThread
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_useVibrationThread_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_useVibrationThread_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo1
      {
        [CallerCount(3), CachedScanResults(RefRangeStart = 35469, RefRangeEnd = 35472, XrefRangeStart = 35469, XrefRangeEnd = 35472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo1_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : new NintendoSwitchInputManager.NpadSettings_Internal(pointer);
        }
      }

      public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo2
      {
        [CallerCount(18), CachedScanResults(RefRangeStart = 40588, RefRangeEnd = 40606, XrefRangeStart = 40588, XrefRangeEnd = 40606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo2_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : new NintendoSwitchInputManager.NpadSettings_Internal(pointer);
        }
      }

      public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo3
      {
        [CallerCount(9), CachedScanResults(RefRangeStart = 40606, RefRangeEnd = 40615, XrefRangeStart = 40606, XrefRangeEnd = 40615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo3_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : new NintendoSwitchInputManager.NpadSettings_Internal(pointer);
        }
      }

      public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo4
      {
        [CallerCount(1), CachedScanResults(RefRangeStart = 51143, RefRangeEnd = 51144, XrefRangeStart = 51143, XrefRangeEnd = 51144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo4_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : new NintendoSwitchInputManager.NpadSettings_Internal(pointer);
        }
      }

      public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo5
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo5_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : new NintendoSwitchInputManager.NpadSettings_Internal(pointer);
        }
      }

      public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo6
      {
        [CallerCount(1), CachedScanResults(RefRangeStart = 136783, RefRangeEnd = 136784, XrefRangeStart = 136783, XrefRangeEnd = 136784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo6_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : new NintendoSwitchInputManager.NpadSettings_Internal(pointer);
        }
      }

      public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo7
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo7_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : new NintendoSwitchInputManager.NpadSettings_Internal(pointer);
        }
      }

      public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadNo8
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo8_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : new NintendoSwitchInputManager.NpadSettings_Internal(pointer);
        }
      }

      public unsafe NintendoSwitchInputManager.NpadSettings_Internal npadHandheld
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadHandheld_Private_get_NpadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : new NintendoSwitchInputManager.NpadSettings_Internal(pointer);
        }
      }

      public unsafe NintendoSwitchInputManager.DebugPadSettings_Internal debugPad
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_debugPad_Public_get_DebugPadSettings_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (NintendoSwitchInputManager.DebugPadSettings_Internal) null : new NintendoSwitchInputManager.DebugPadSettings_Internal(pointer);
        }
      }

      public unsafe Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>> delegates
      {
        [CallerCount(2), CachedScanResults(RefRangeStart = 137974, RefRangeEnd = 137976, XrefRangeStart = 137742, XrefRangeEnd = 137974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>) null : new Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137976, XrefRangeEnd = 137983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue<T>(
        int key,
        out T value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &key;
        System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
        System.IntPtr zero;
        // ISSUE: variable of a reference type
        T& local1;
        if (!typeof (T).IsValueType)
        {
          zero = System.IntPtr.Zero;
          local1 = ref (*(T*) &zero);
        }
        else
          local1 = ref value;
        *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
        System.IntPtr exc;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        if (!typeof (T).IsValueType)
        {
          ref T local2 = ref value;
          System.IntPtr objectPointer = zero;
          // ISSUE: variable of the null type
          __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
          local2 = (T) valueGeneric;
        }
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137983, XrefRangeEnd = 137989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue<T>(
        int key,
        T value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &key;
        System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
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
        *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
        System.IntPtr exc;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 138033, RefRangeEnd = 138034, XrefRangeStart = 137989, XrefRangeEnd = 138033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe UserData()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10)]
      [CachedScanResults(RefRangeStart = 137723, RefRangeEnd = 137733, XrefRangeStart = 137723, XrefRangeEnd = 137733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _get_delegates_b__56_0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_0_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 128449, RefRangeEnd = 128454, XrefRangeStart = 128449, XrefRangeEnd = 128454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _get_delegates_b__56_1(int x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &x
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_1_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe int _get_delegates_b__56_2()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_2_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(9)]
      [CachedScanResults(RefRangeStart = 137733, RefRangeEnd = 137742, XrefRangeStart = 137733, XrefRangeEnd = 137742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _get_delegates_b__56_3(int x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &x
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_3_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 23871, RefRangeEnd = 23873, XrefRangeStart = 23871, XrefRangeEnd = 23873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _get_delegates_b__56_4()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_4_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe void _get_delegates_b__56_5(bool x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &x
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_5_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe int _get_delegates_b__56_6()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_6_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 27305, RefRangeEnd = 27306, XrefRangeStart = 27305, XrefRangeEnd = 27306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _get_delegates_b__56_7(int x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &x
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_7_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe bool _get_delegates_b__56_8()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_8_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe void _get_delegates_b__56_9(bool x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &x
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_9_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 35469, RefRangeEnd = 35472, XrefRangeStart = 35469, XrefRangeEnd = 35472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Il2CppSystem.Object _get_delegates_b__56_10()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_10_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }

      [CallerCount(18)]
      [CachedScanResults(RefRangeStart = 40588, RefRangeEnd = 40606, XrefRangeStart = 40588, XrefRangeEnd = 40606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Il2CppSystem.Object _get_delegates_b__56_11()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_11_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }

      [CallerCount(9)]
      [CachedScanResults(RefRangeStart = 40606, RefRangeEnd = 40615, XrefRangeStart = 40606, XrefRangeEnd = 40615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Il2CppSystem.Object _get_delegates_b__56_12()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_12_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 51143, RefRangeEnd = 51144, XrefRangeStart = 51143, XrefRangeEnd = 51144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Il2CppSystem.Object _get_delegates_b__56_13()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_13_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }

      [CallerCount(0)]
      public unsafe Il2CppSystem.Object _get_delegates_b__56_14()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_14_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 136783, RefRangeEnd = 136784, XrefRangeStart = 136783, XrefRangeEnd = 136784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Il2CppSystem.Object _get_delegates_b__56_15()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_15_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }

      [CallerCount(0)]
      public unsafe Il2CppSystem.Object _get_delegates_b__56_16()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_16_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }

      [CallerCount(0)]
      public unsafe Il2CppSystem.Object _get_delegates_b__56_17()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_17_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }

      [CallerCount(0)]
      public unsafe Il2CppSystem.Object _get_delegates_b__56_18()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_18_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }

      [CallerCount(0)]
      public unsafe Il2CppSystem.Object _get_delegates_b__56_19()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_19_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }

      [CallerCount(0)]
      public unsafe bool _get_delegates_b__56_20()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_20_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe void _get_delegates_b__56_21(bool x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &x
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_21_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static UserData()
      {
        Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr, nameof (UserData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr);
        NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__allowedNpadStyles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_allowedNpadStyles));
        NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__joyConGripStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_joyConGripStyle));
        NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__adjustIMUsForGripStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_adjustIMUsForGripStyle));
        NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__handheldActivationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_handheldActivationMode));
        NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__assignJoysticksByNpadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_assignJoysticksByNpadId));
        NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__useVibrationThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_useVibrationThread));
        NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_npadNo1));
        NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_npadNo2));
        NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_npadNo3));
        NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_npadNo4));
        NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_npadNo5));
        NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_npadNo6));
        NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_npadNo7));
        NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_npadNo8));
        NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadHandheld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_npadHandheld));
        NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__debugPad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (_debugPad));
        NintendoSwitchInputManager.UserData.NativeFieldInfoPtr___delegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, nameof (__delegates));
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_allowedNpadStyles_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677958);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_allowedNpadStyles_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677959);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_joyConGripStyle_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677960);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_joyConGripStyle_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677961);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_adjustIMUsForGripStyle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677962);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_adjustIMUsForGripStyle_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677963);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_handheldActivationMode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677964);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_handheldActivationMode_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677965);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_assignJoysticksByNpadId_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677966);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_assignJoysticksByNpadId_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677967);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_useVibrationThread_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677968);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_set_useVibrationThread_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677969);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo1_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677970);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo2_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677971);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo3_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677972);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo4_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677973);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo5_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677974);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo6_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677975);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo7_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677976);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadNo8_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677977);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_npadHandheld_Private_get_NpadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677978);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_debugPad_Public_get_DebugPadSettings_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677979);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677980);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677981);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677982);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677983);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_0_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677984);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_1_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677985);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_2_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677986);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_3_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677987);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_4_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677988);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_5_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677989);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_6_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677990);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_7_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677991);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_8_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677992);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_9_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677993);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_10_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677994);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_11_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677995);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_12_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677996);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_13_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677997);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_14_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677998);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_15_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100677999);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_16_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100678000);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_17_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100678001);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_18_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100678002);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_19_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100678003);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_20_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100678004);
        NintendoSwitchInputManager.UserData.NativeMethodInfoPtr__get_delegates_b__56_21_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr, 100678005);
      }

      public UserData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int _allowedNpadStyles
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__allowedNpadStyles));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__allowedNpadStyles)) = value;
        }
      }

      public unsafe int _joyConGripStyle
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__joyConGripStyle));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__joyConGripStyle)) = value;
        }
      }

      public unsafe bool _adjustIMUsForGripStyle
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__adjustIMUsForGripStyle));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__adjustIMUsForGripStyle)) = value;
        }
      }

      public unsafe int _handheldActivationMode
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__handheldActivationMode));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__handheldActivationMode)) = value;
        }
      }

      public unsafe bool _assignJoysticksByNpadId
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__assignJoysticksByNpadId));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__assignJoysticksByNpadId)) = value;
        }
      }

      public unsafe bool _useVibrationThread
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__useVibrationThread));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__useVibrationThread)) = value;
        }
      }

      public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo1
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo1));
          return pointer == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : new NintendoSwitchInputManager.NpadSettings_Internal(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo2
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo2));
          return pointer == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : new NintendoSwitchInputManager.NpadSettings_Internal(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo3
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo3));
          return pointer == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : new NintendoSwitchInputManager.NpadSettings_Internal(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo4
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo4));
          return pointer == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : new NintendoSwitchInputManager.NpadSettings_Internal(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo4), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo5
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo5));
          return pointer == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : new NintendoSwitchInputManager.NpadSettings_Internal(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo5), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo6
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo6));
          return pointer == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : new NintendoSwitchInputManager.NpadSettings_Internal(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo6), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo7
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo7));
          return pointer == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : new NintendoSwitchInputManager.NpadSettings_Internal(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo7), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadNo8
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo8));
          return pointer == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : new NintendoSwitchInputManager.NpadSettings_Internal(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadNo8), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NintendoSwitchInputManager.NpadSettings_Internal _npadHandheld
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadHandheld));
          return pointer == System.IntPtr.Zero ? (NintendoSwitchInputManager.NpadSettings_Internal) null : new NintendoSwitchInputManager.NpadSettings_Internal(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__npadHandheld), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NintendoSwitchInputManager.DebugPadSettings_Internal _debugPad
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__debugPad));
          return pointer == System.IntPtr.Zero ? (NintendoSwitchInputManager.DebugPadSettings_Internal) null : new NintendoSwitchInputManager.DebugPadSettings_Internal(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr__debugPad), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>> __delegates
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr___delegates));
          return pointer == System.IntPtr.Zero ? (Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>) null : new Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.UserData.NativeFieldInfoPtr___delegates), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      private sealed class MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0<T>
      {
        internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0, Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))));
      }

      private sealed class MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0<T>
      {
        internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NintendoSwitchInputManager.UserData.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0, Il2CppClassPointerStore<NintendoSwitchInputManager.UserData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))));
      }
    }

    [Serializable]
    public sealed class NpadSettings_Internal : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__isAllowed;
      private static readonly System.IntPtr NativeFieldInfoPtr__rewiredPlayerId;
      private static readonly System.IntPtr NativeFieldInfoPtr__joyConAssignmentMode;
      private static readonly System.IntPtr NativeFieldInfoPtr___delegates;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_isAllowed_Private_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_isAllowed_Private_set_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_rewiredPlayerId_Private_get_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_rewiredPlayerId_Private_set_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_joyConAssignmentMode_Private_get_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_joyConAssignmentMode_Private_set_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__15_0_Private_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__15_1_Private_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__15_2_Private_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__15_3_Private_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__15_4_Private_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__15_5_Private_Void_Int32_0;

      public unsafe bool isAllowed
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_isAllowed_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_set_isAllowed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      public unsafe int rewiredPlayerId
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_rewiredPlayerId_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }
        [CallerCount(9), CachedScanResults(RefRangeStart = 137733, RefRangeEnd = 137742, XrefRangeStart = 137733, XrefRangeEnd = 137742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1]
          {
            (System.IntPtr) &value
          };
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_set_rewiredPlayerId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      public unsafe int joyConAssignmentMode
      {
        [CallerCount(1), CachedScanResults(RefRangeStart = 109870, RefRangeEnd = 109871, XrefRangeStart = 109870, XrefRangeEnd = 109871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_joyConAssignmentMode_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }
        [CallerCount(3), CachedScanResults(RefRangeStart = 138034, RefRangeEnd = 138037, XrefRangeStart = 138034, XrefRangeEnd = 138034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1]
          {
            (System.IntPtr) &value
          };
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_set_joyConAssignmentMode_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138037, XrefRangeEnd = 138038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe NpadSettings_Internal(int playerId)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &playerId
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public unsafe Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>> delegates
      {
        [CallerCount(2), CachedScanResults(RefRangeStart = 138105, RefRangeEnd = 138107, XrefRangeStart = 138038, XrefRangeEnd = 138105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>) null : new Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138107, XrefRangeEnd = 138114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue<T>(
        int key,
        out T value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &key;
        System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
        System.IntPtr zero;
        // ISSUE: variable of a reference type
        T& local1;
        if (!typeof (T).IsValueType)
        {
          zero = System.IntPtr.Zero;
          local1 = ref (*(T*) &zero);
        }
        else
          local1 = ref value;
        *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
        System.IntPtr exc;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        if (!typeof (T).IsValueType)
        {
          ref T local2 = ref value;
          System.IntPtr objectPointer = zero;
          // ISSUE: variable of the null type
          __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
          local2 = (T) valueGeneric;
        }
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138114, XrefRangeEnd = 138120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue<T>(
        int key,
        T value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &key;
        System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
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
        *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
        System.IntPtr exc;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }

      [CallerCount(0)]
      public unsafe bool _get_delegates_b__15_0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe void _get_delegates_b__15_1(bool x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &x
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_1_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe int _get_delegates_b__15_2()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_2_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(9)]
      [CachedScanResults(RefRangeStart = 137733, RefRangeEnd = 137742, XrefRangeStart = 137733, XrefRangeEnd = 137742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _get_delegates_b__15_3(int x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &x
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_3_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 109870, RefRangeEnd = 109871, XrefRangeStart = 109870, XrefRangeEnd = 109871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _get_delegates_b__15_4()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_4_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 138034, RefRangeEnd = 138037, XrefRangeStart = 138034, XrefRangeEnd = 138037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _get_delegates_b__15_5(int x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &x
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_5_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static NpadSettings_Internal()
      {
        Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr, nameof (NpadSettings_Internal));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr);
        NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__isAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, nameof (_isAllowed));
        NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__rewiredPlayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, nameof (_rewiredPlayerId));
        NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__joyConAssignmentMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, nameof (_joyConAssignmentMode));
        NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr___delegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, nameof (__delegates));
        NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_isAllowed_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100678006);
        NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_set_isAllowed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100678007);
        NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_rewiredPlayerId_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100678008);
        NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_set_rewiredPlayerId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100678009);
        NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_joyConAssignmentMode_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100678010);
        NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_set_joyConAssignmentMode_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100678011);
        NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100678012);
        NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100678013);
        NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100678014);
        NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100678015);
        NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100678016);
        NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_1_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100678017);
        NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_2_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100678018);
        NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_3_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100678019);
        NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_4_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100678020);
        NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__15_5_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr, 100678021);
      }

      public NpadSettings_Internal(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe bool _isAllowed
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__isAllowed));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__isAllowed)) = value;
        }
      }

      public unsafe int _rewiredPlayerId
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__rewiredPlayerId));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__rewiredPlayerId)) = value;
        }
      }

      public unsafe int _joyConAssignmentMode
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__joyConAssignmentMode));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr__joyConAssignmentMode)) = value;
        }
      }

      public unsafe Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>> __delegates
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr___delegates));
          return pointer == System.IntPtr.Zero ? (Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>) null : new Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.NpadSettings_Internal.NativeFieldInfoPtr___delegates), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      private sealed class MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0<T>
      {
        internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0, Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))));
      }

      private sealed class MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0<T>
      {
        internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NintendoSwitchInputManager.NpadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0, Il2CppClassPointerStore<NintendoSwitchInputManager.NpadSettings_Internal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))));
      }
    }

    [Serializable]
    public sealed class DebugPadSettings_Internal : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__enabled;
      private static readonly System.IntPtr NativeFieldInfoPtr__rewiredPlayerId;
      private static readonly System.IntPtr NativeFieldInfoPtr___delegates;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_rewiredPlayerId_Private_get_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_rewiredPlayerId_Private_set_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_enabled_Private_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_enabled_Private_set_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__11_0_Private_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__11_1_Private_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__11_2_Private_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_delegates_b__11_3_Private_Void_Int32_0;

      public unsafe int rewiredPlayerId
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_get_rewiredPlayerId_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }
        [CallerCount(9), CachedScanResults(RefRangeStart = 137733, RefRangeEnd = 137742, XrefRangeStart = 137733, XrefRangeEnd = 137742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1]
          {
            (System.IntPtr) &value
          };
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_set_rewiredPlayerId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      public unsafe bool enabled
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_get_enabled_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_set_enabled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138120, XrefRangeEnd = 138121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe DebugPadSettings_Internal(int playerId)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &playerId
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public unsafe Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>> delegates
      {
        [CallerCount(2), CachedScanResults(RefRangeStart = 138170, RefRangeEnd = 138172, XrefRangeStart = 138121, XrefRangeEnd = 138170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>) null : new Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138172, XrefRangeEnd = 138179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue<T>(
        int key,
        out T value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &key;
        System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
        System.IntPtr zero;
        // ISSUE: variable of a reference type
        T& local1;
        if (!typeof (T).IsValueType)
        {
          zero = System.IntPtr.Zero;
          local1 = ref (*(T*) &zero);
        }
        else
          local1 = ref value;
        *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
        System.IntPtr exc;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        if (!typeof (T).IsValueType)
        {
          ref T local2 = ref value;
          System.IntPtr objectPointer = zero;
          // ISSUE: variable of the null type
          __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
          local2 = (T) valueGeneric;
        }
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138179, XrefRangeEnd = 138185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue<T>(
        int key,
        T value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &key;
        System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
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
        *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
        System.IntPtr exc;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }

      [CallerCount(0)]
      public unsafe bool _get_delegates_b__11_0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe void _get_delegates_b__11_1(bool x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &x
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_1_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe int _get_delegates_b__11_2()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_2_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(9)]
      [CachedScanResults(RefRangeStart = 137733, RefRangeEnd = 137742, XrefRangeStart = 137733, XrefRangeEnd = 137742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _get_delegates_b__11_3(int x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &x
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_3_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static DebugPadSettings_Internal()
      {
        Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NintendoSwitchInputManager>.NativeClassPtr, nameof (DebugPadSettings_Internal));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr);
        NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr__enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, nameof (_enabled));
        NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr__rewiredPlayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, nameof (_rewiredPlayerId));
        NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr___delegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, nameof (__delegates));
        NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_get_rewiredPlayerId_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100678022);
        NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_set_rewiredPlayerId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100678023);
        NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_get_enabled_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100678024);
        NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_set_enabled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100678025);
        NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100678026);
        NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_get_delegates_Private_get_Dictionary_2_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100678027);
        NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100678028);
        NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100678029);
        NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100678030);
        NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_1_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100678031);
        NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_2_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100678032);
        NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr__get_delegates_b__11_3_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr, 100678033);
      }

      public DebugPadSettings_Internal(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe bool _enabled
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr__enabled));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr__enabled)) = value;
        }
      }

      public unsafe int _rewiredPlayerId
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr__rewiredPlayerId));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr__rewiredPlayerId)) = value;
        }
      }

      public unsafe Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>> __delegates
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr___delegates));
          return pointer == System.IntPtr.Zero ? (Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>) null : new Dictionary<int, Il2CppReferenceArray<Il2CppSystem.Object>>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeFieldInfoPtr___delegates), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      private sealed class MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0<T>
      {
        internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TryGetValue_Private_Virtual_Final_New_Boolean_Int32_byref_T_0, Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))));
      }

      private sealed class MethodInfoStoreGeneric_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0<T>
      {
        internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NintendoSwitchInputManager.DebugPadSettings_Internal.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IKeyedData_System_Int32__TrySetValue_Private_Virtual_Final_New_Boolean_Int32_T_0, Il2CppClassPointerStore<NintendoSwitchInputManager.DebugPadSettings_Internal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))));
      }
    }
  }
}
