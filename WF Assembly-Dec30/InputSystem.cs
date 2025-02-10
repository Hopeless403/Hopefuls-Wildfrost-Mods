// Decompiled with JetBrains decompiler
// Type: InputSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Rewired;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class InputSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_instance;
  private static readonly IntPtr NativeFieldInfoPtr_holdDirectionStartTime;
  private static readonly IntPtr NativeFieldInfoPtr_holdDirectionFlowTime;
  private static readonly IntPtr NativeFieldInfoPtr_mainPlayer;
  private static readonly IntPtr NativeFieldInfoPtr_enabled;
  private static readonly IntPtr NativeFieldInfoPtr_isLongHeld;
  private static readonly IntPtr NativeFieldInfoPtr_holdDirectionTime;
  private static readonly IntPtr NativeFieldInfoPtr_wasSelectHeldLong;
  private static readonly IntPtr NativeFieldInfoPtr_wasSelectHeldLong2;
  private static readonly IntPtr NativeFieldInfoPtr__MousePosition_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr_AllowDynamicSelectRelease;
  private static readonly IntPtr NativeFieldInfoPtr__reset;
  private static readonly IntPtr NativeMethodInfoPtr_get_Enabled_Public_Static_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_MousePosition_Public_Static_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_MousePosition_Private_Static_set_Void_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_reset_Public_Static_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_reset_Public_Static_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_IsButtonPressed_Public_Static_Boolean_String_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_IsButtonHeld_Public_Static_Boolean_String_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_IsButtonLongHeld_Public_Static_Boolean_String_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_IsButtonReleased_Public_Static_Boolean_String_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_WasButtonPressed_Public_Static_Boolean_String_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_WasButtonReleased_Public_Static_Boolean_String_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_IsSelectPressed_Public_Static_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_IsSelectHeld_Public_Static_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_IsSelectReleased_Public_Static_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_IsDynamicSelectReleased_Public_Static_Boolean_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckLongHold_Public_Static_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetAxisDelta_Public_Static_Single_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public static unsafe bool Enabled
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 61655, RefRangeEnd = 61668, XrefRangeStart = 61650, XrefRangeEnd = 61655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_get_Enabled_Public_Static_get_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public static unsafe Vector3 MousePosition
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61668, XrefRangeEnd = 61672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_get_MousePosition_Public_Static_get_Vector3_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61672, XrefRangeEnd = 61676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_set_MousePosition_Private_Static_set_Void_Vector3_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public static unsafe bool reset
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 61680, RefRangeEnd = 61681, XrefRangeStart = 61676, XrefRangeEnd = 61680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_get_reset_Public_Static_get_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 61685, RefRangeEnd = 61689, XrefRangeStart = 61681, XrefRangeEnd = 61685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_set_reset_Public_Static_set_Void_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61689, XrefRangeEnd = 61704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61704, XrefRangeEnd = 61733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 61737, RefRangeEnd = 61741, XrefRangeStart = 61733, XrefRangeEnd = 61737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Enable()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_Enable_Public_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 61745, RefRangeEnd = 61749, XrefRangeStart = 61741, XrefRangeEnd = 61745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Disable()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_Disable_Public_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 61761, RefRangeEnd = 61772, XrefRangeStart = 61749, XrefRangeEnd = 61761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsButtonPressed(string input, bool positive = true)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(input);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &positive;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_IsButtonPressed_Public_Static_Boolean_String_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 61784, RefRangeEnd = 61792, XrefRangeStart = 61772, XrefRangeEnd = 61784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsButtonHeld(string input, bool positive = true)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(input);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &positive;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_IsButtonHeld_Public_Static_Boolean_String_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 61804, RefRangeEnd = 61808, XrefRangeStart = 61792, XrefRangeEnd = 61804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsButtonLongHeld(string input, bool positive = true)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(input);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &positive;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_IsButtonLongHeld_Public_Static_Boolean_String_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61808, XrefRangeEnd = 61820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsButtonReleased(string input, bool positive = true)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(input);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &positive;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_IsButtonReleased_Public_Static_Boolean_String_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61820, XrefRangeEnd = 61832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool WasButtonPressed(string input, bool positive = true)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(input);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &positive;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_WasButtonPressed_Public_Static_Boolean_String_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61832, XrefRangeEnd = 61840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool WasButtonReleased(string input, bool positive = true)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(input);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &positive;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_WasButtonReleased_Public_Static_Boolean_String_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 61846, RefRangeEnd = 61852, XrefRangeStart = 61840, XrefRangeEnd = 61846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsSelectPressed()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_IsSelectPressed_Public_Static_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 61858, RefRangeEnd = 61861, XrefRangeStart = 61852, XrefRangeEnd = 61858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsSelectHeld()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_IsSelectHeld_Public_Static_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 61878, RefRangeEnd = 61879, XrefRangeStart = 61861, XrefRangeEnd = 61878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsSelectReleased()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_IsSelectReleased_Public_Static_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 61892, RefRangeEnd = 61894, XrefRangeStart = 61879, XrefRangeEnd = 61892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsDynamicSelectReleased(bool allowSelectAgainToRelease)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &allowSelectAgainToRelease
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_IsDynamicSelectReleased_Public_Static_Boolean_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 61942, RefRangeEnd = 61943, XrefRangeStart = 61894, XrefRangeEnd = 61942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CheckLongHold()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_CheckLongHold_Public_Static_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 61947, RefRangeEnd = 61948, XrefRangeStart = 61943, XrefRangeEnd = 61947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GetAxis(string actionName)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(actionName)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 61952, RefRangeEnd = 61953, XrefRangeStart = 61948, XrefRangeEnd = 61952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GetAxisDelta(string actionName)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(actionName)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr_GetAxisDelta_Public_Static_Single_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61953, XrefRangeEnd = 61954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InputSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InputSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static InputSystem()
  {
    Il2CppClassPointerStore<InputSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (InputSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputSystem>.NativeClassPtr);
    InputSystem.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (instance));
    InputSystem.NativeFieldInfoPtr_holdDirectionStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (holdDirectionStartTime));
    InputSystem.NativeFieldInfoPtr_holdDirectionFlowTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (holdDirectionFlowTime));
    InputSystem.NativeFieldInfoPtr_mainPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (mainPlayer));
    InputSystem.NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (enabled));
    InputSystem.NativeFieldInfoPtr_isLongHeld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (isLongHeld));
    InputSystem.NativeFieldInfoPtr_holdDirectionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (holdDirectionTime));
    InputSystem.NativeFieldInfoPtr_wasSelectHeldLong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (wasSelectHeldLong));
    InputSystem.NativeFieldInfoPtr_wasSelectHeldLong2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (wasSelectHeldLong2));
    InputSystem.NativeFieldInfoPtr__MousePosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, "<MousePosition>k__BackingField");
    InputSystem.NativeFieldInfoPtr_AllowDynamicSelectRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (AllowDynamicSelectRelease));
    InputSystem.NativeFieldInfoPtr__reset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, nameof (_reset));
    InputSystem.NativeMethodInfoPtr_get_Enabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100668317);
    InputSystem.NativeMethodInfoPtr_get_MousePosition_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100668318);
    InputSystem.NativeMethodInfoPtr_set_MousePosition_Private_Static_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100668319);
    InputSystem.NativeMethodInfoPtr_get_reset_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100668320);
    InputSystem.NativeMethodInfoPtr_set_reset_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100668321);
    InputSystem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100668322);
    InputSystem.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100668323);
    InputSystem.NativeMethodInfoPtr_Enable_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100668324);
    InputSystem.NativeMethodInfoPtr_Disable_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100668325);
    InputSystem.NativeMethodInfoPtr_IsButtonPressed_Public_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100668326);
    InputSystem.NativeMethodInfoPtr_IsButtonHeld_Public_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100668327);
    InputSystem.NativeMethodInfoPtr_IsButtonLongHeld_Public_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100668328);
    InputSystem.NativeMethodInfoPtr_IsButtonReleased_Public_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100668329);
    InputSystem.NativeMethodInfoPtr_WasButtonPressed_Public_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100668330);
    InputSystem.NativeMethodInfoPtr_WasButtonReleased_Public_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100668331);
    InputSystem.NativeMethodInfoPtr_IsSelectPressed_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100668332);
    InputSystem.NativeMethodInfoPtr_IsSelectHeld_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100668333);
    InputSystem.NativeMethodInfoPtr_IsSelectReleased_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100668334);
    InputSystem.NativeMethodInfoPtr_IsDynamicSelectReleased_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100668335);
    InputSystem.NativeMethodInfoPtr_CheckLongHold_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100668336);
    InputSystem.NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100668337);
    InputSystem.NativeMethodInfoPtr_GetAxisDelta_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100668338);
    InputSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSystem>.NativeClassPtr, 100668339);
  }

  public InputSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe InputSystem instance
  {
    get
    {
      IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(InputSystem.NativeFieldInfoPtr_instance, (void*) &num);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(InputSystem.NativeFieldInfoPtr_instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float holdDirectionStartTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr_holdDirectionStartTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr_holdDirectionStartTime)) = value;
    }
  }

  public unsafe float holdDirectionFlowTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr_holdDirectionFlowTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSystem.NativeFieldInfoPtr_holdDirectionFlowTime)) = value;
    }
  }

  public static unsafe Player mainPlayer
  {
    get
    {
      IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(InputSystem.NativeFieldInfoPtr_mainPlayer, (void*) &num);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Player) null : new Player(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(InputSystem.NativeFieldInfoPtr_mainPlayer, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public new static unsafe bool enabled
  {
    get
    {
      bool enabled;
      IL2CPP.il2cpp_field_static_get_value(InputSystem.NativeFieldInfoPtr_enabled, (void*) &enabled);
      return enabled;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(InputSystem.NativeFieldInfoPtr_enabled, (void*) &value);
    }
  }

  public static unsafe bool isLongHeld
  {
    get
    {
      bool isLongHeld;
      IL2CPP.il2cpp_field_static_get_value(InputSystem.NativeFieldInfoPtr_isLongHeld, (void*) &isLongHeld);
      return isLongHeld;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(InputSystem.NativeFieldInfoPtr_isLongHeld, (void*) &value);
    }
  }

  public static unsafe float holdDirectionTime
  {
    get
    {
      float holdDirectionTime;
      IL2CPP.il2cpp_field_static_get_value(InputSystem.NativeFieldInfoPtr_holdDirectionTime, (void*) &holdDirectionTime);
      return holdDirectionTime;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(InputSystem.NativeFieldInfoPtr_holdDirectionTime, (void*) &value);
    }
  }

  public static unsafe bool wasSelectHeldLong
  {
    get
    {
      bool wasSelectHeldLong;
      IL2CPP.il2cpp_field_static_get_value(InputSystem.NativeFieldInfoPtr_wasSelectHeldLong, (void*) &wasSelectHeldLong);
      return wasSelectHeldLong;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(InputSystem.NativeFieldInfoPtr_wasSelectHeldLong, (void*) &value);
    }
  }

  public static unsafe bool wasSelectHeldLong2
  {
    get
    {
      bool wasSelectHeldLong2;
      IL2CPP.il2cpp_field_static_get_value(InputSystem.NativeFieldInfoPtr_wasSelectHeldLong2, (void*) &wasSelectHeldLong2);
      return wasSelectHeldLong2;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(InputSystem.NativeFieldInfoPtr_wasSelectHeldLong2, (void*) &value);
    }
  }

  public static unsafe Vector3 _MousePosition_k__BackingField
  {
    get
    {
      Vector3 positionKBackingField;
      IL2CPP.il2cpp_field_static_get_value(InputSystem.NativeFieldInfoPtr__MousePosition_k__BackingField, (void*) &positionKBackingField);
      return positionKBackingField;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(InputSystem.NativeFieldInfoPtr__MousePosition_k__BackingField, (void*) &value);
    }
  }

  public static unsafe bool AllowDynamicSelectRelease
  {
    get
    {
      bool dynamicSelectRelease;
      IL2CPP.il2cpp_field_static_get_value(InputSystem.NativeFieldInfoPtr_AllowDynamicSelectRelease, (void*) &dynamicSelectRelease);
      return dynamicSelectRelease;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(InputSystem.NativeFieldInfoPtr_AllowDynamicSelectRelease, (void*) &value);
    }
  }

  public static unsafe int _reset
  {
    get
    {
      int reset;
      IL2CPP.il2cpp_field_static_get_value(InputSystem.NativeFieldInfoPtr__reset, (void*) &reset);
      return reset;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(InputSystem.NativeFieldInfoPtr__reset, (void*) &value);
    }
  }
}
