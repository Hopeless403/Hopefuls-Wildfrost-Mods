// Decompiled with JetBrains decompiler
// Type: ErrorHandlerSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
public class ErrorHandlerSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_displayErrors;
  private static readonly IntPtr NativeFieldInfoPtr_errorDisplay;
  private static readonly IntPtr NativeFieldInfoPtr_errorText;
  private static readonly IntPtr NativeFieldInfoPtr_freezeTimeScale;
  private static readonly IntPtr NativeFieldInfoPtr_sfxEvent;
  private static readonly IntPtr NativeFieldInfoPtr_showPersistentMessage;
  private static readonly IntPtr NativeFieldInfoPtr_persistentMessage;
  private static readonly IntPtr NativeFieldInfoPtr_format;
  private static readonly IntPtr NativeFieldInfoPtr_timeScalePre;
  private static readonly IntPtr NativeFieldInfoPtr_errorCount;
  private static readonly IntPtr NativeMethodInfoPtr_get_path_Private_Static_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_HandleLog_Private_Void_String_String_LogType_0;
  private static readonly IntPtr NativeMethodInfoPtr_ShowError_Private_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_HideError_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ExitGame_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ShowPersistentMessage_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_HidePersistentMessage_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public static unsafe string path
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59128, XrefRangeEnd = 59132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ErrorHandlerSystem.NativeMethodInfoPtr_get_path_Private_Static_get_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59132, XrefRangeEnd = 59140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ErrorHandlerSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59140, XrefRangeEnd = 59148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ErrorHandlerSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59148, XrefRangeEnd = 59174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HandleLog(string log, string stacktrace, LogType type)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(log);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(stacktrace);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &type;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ErrorHandlerSystem.NativeMethodInfoPtr_HandleLog_Private_Void_String_String_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59174, XrefRangeEnd = 59182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowError(string text)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(text)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ErrorHandlerSystem.NativeMethodInfoPtr_ShowError_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59182, XrefRangeEnd = 59187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HideError()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ErrorHandlerSystem.NativeMethodInfoPtr_HideError_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59187, XrefRangeEnd = 59191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ExitGame()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ErrorHandlerSystem.NativeMethodInfoPtr_ExitGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59191, XrefRangeEnd = 59193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowPersistentMessage()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ErrorHandlerSystem.NativeMethodInfoPtr_ShowPersistentMessage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59193, XrefRangeEnd = 59195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HidePersistentMessage()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ErrorHandlerSystem.NativeMethodInfoPtr_HidePersistentMessage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59195, XrefRangeEnd = 59196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ErrorHandlerSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ErrorHandlerSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ErrorHandlerSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ErrorHandlerSystem()
  {
    Il2CppClassPointerStore<ErrorHandlerSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ErrorHandlerSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ErrorHandlerSystem>.NativeClassPtr);
    ErrorHandlerSystem.NativeFieldInfoPtr_displayErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorHandlerSystem>.NativeClassPtr, nameof (displayErrors));
    ErrorHandlerSystem.NativeFieldInfoPtr_errorDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorHandlerSystem>.NativeClassPtr, nameof (errorDisplay));
    ErrorHandlerSystem.NativeFieldInfoPtr_errorText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorHandlerSystem>.NativeClassPtr, nameof (errorText));
    ErrorHandlerSystem.NativeFieldInfoPtr_freezeTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorHandlerSystem>.NativeClassPtr, nameof (freezeTimeScale));
    ErrorHandlerSystem.NativeFieldInfoPtr_sfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorHandlerSystem>.NativeClassPtr, nameof (sfxEvent));
    ErrorHandlerSystem.NativeFieldInfoPtr_showPersistentMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorHandlerSystem>.NativeClassPtr, nameof (showPersistentMessage));
    ErrorHandlerSystem.NativeFieldInfoPtr_persistentMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorHandlerSystem>.NativeClassPtr, nameof (persistentMessage));
    ErrorHandlerSystem.NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorHandlerSystem>.NativeClassPtr, nameof (format));
    ErrorHandlerSystem.NativeFieldInfoPtr_timeScalePre = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorHandlerSystem>.NativeClassPtr, nameof (timeScalePre));
    ErrorHandlerSystem.NativeFieldInfoPtr_errorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorHandlerSystem>.NativeClassPtr, nameof (errorCount));
    ErrorHandlerSystem.NativeMethodInfoPtr_get_path_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorHandlerSystem>.NativeClassPtr, 100668140);
    ErrorHandlerSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorHandlerSystem>.NativeClassPtr, 100668141);
    ErrorHandlerSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorHandlerSystem>.NativeClassPtr, 100668142);
    ErrorHandlerSystem.NativeMethodInfoPtr_HandleLog_Private_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorHandlerSystem>.NativeClassPtr, 100668143);
    ErrorHandlerSystem.NativeMethodInfoPtr_ShowError_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorHandlerSystem>.NativeClassPtr, 100668144);
    ErrorHandlerSystem.NativeMethodInfoPtr_HideError_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorHandlerSystem>.NativeClassPtr, 100668145);
    ErrorHandlerSystem.NativeMethodInfoPtr_ExitGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorHandlerSystem>.NativeClassPtr, 100668146);
    ErrorHandlerSystem.NativeMethodInfoPtr_ShowPersistentMessage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorHandlerSystem>.NativeClassPtr, 100668147);
    ErrorHandlerSystem.NativeMethodInfoPtr_HidePersistentMessage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorHandlerSystem>.NativeClassPtr, 100668148);
    ErrorHandlerSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorHandlerSystem>.NativeClassPtr, 100668149);
  }

  public ErrorHandlerSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool displayErrors
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ErrorHandlerSystem.NativeFieldInfoPtr_displayErrors));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ErrorHandlerSystem.NativeFieldInfoPtr_displayErrors)) = value;
    }
  }

  public unsafe GameObject errorDisplay
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ErrorHandlerSystem.NativeFieldInfoPtr_errorDisplay));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ErrorHandlerSystem.NativeFieldInfoPtr_errorDisplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_InputField errorText
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ErrorHandlerSystem.NativeFieldInfoPtr_errorText));
      return pointer == IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ErrorHandlerSystem.NativeFieldInfoPtr_errorText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool freezeTimeScale
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ErrorHandlerSystem.NativeFieldInfoPtr_freezeTimeScale));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ErrorHandlerSystem.NativeFieldInfoPtr_freezeTimeScale)) = value;
    }
  }

  public unsafe EventReference sfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ErrorHandlerSystem.NativeFieldInfoPtr_sfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ErrorHandlerSystem.NativeFieldInfoPtr_sfxEvent)) = value;
    }
  }

  public unsafe bool showPersistentMessage
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ErrorHandlerSystem.NativeFieldInfoPtr_showPersistentMessage));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ErrorHandlerSystem.NativeFieldInfoPtr_showPersistentMessage)) = value;
    }
  }

  public unsafe GameObject persistentMessage
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ErrorHandlerSystem.NativeFieldInfoPtr_persistentMessage));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ErrorHandlerSystem.NativeFieldInfoPtr_persistentMessage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe string format
  {
    get
    {
      IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(ErrorHandlerSystem.NativeFieldInfoPtr_format, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ErrorHandlerSystem.NativeFieldInfoPtr_format, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe float timeScalePre
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ErrorHandlerSystem.NativeFieldInfoPtr_timeScalePre));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ErrorHandlerSystem.NativeFieldInfoPtr_timeScalePre)) = value;
    }
  }

  public static unsafe int errorCount
  {
    get
    {
      int errorCount;
      IL2CPP.il2cpp_field_static_get_value(ErrorHandlerSystem.NativeFieldInfoPtr_errorCount, (void*) &errorCount);
      return errorCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ErrorHandlerSystem.NativeFieldInfoPtr_errorCount, (void*) &value);
    }
  }
}
