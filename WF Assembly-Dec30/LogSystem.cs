// Decompiled with JetBrains decompiler
// Type: LogSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class LogSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_backups;
  private static readonly IntPtr NativeFieldInfoPtr_format;
  private static readonly IntPtr NativeFieldInfoPtr_toLog;
  private static readonly IntPtr NativeFieldInfoPtr_logDelay;
  private static readonly IntPtr NativeFieldInfoPtr_logDelayMax;
  private static readonly IntPtr NativeMethodInfoPtr_get_directory_Private_Static_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_path_Private_Static_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Write_Private_Static_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_Log_Private_Static_Void_String_String_LogType_0;
  private static readonly IntPtr NativeMethodInfoPtr_Log_Private_Static_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateBackups_Private_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetFileName_Private_Static_String_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_LogSystemInformation_Private_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public static unsafe string directory
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63455, XrefRangeEnd = 63458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LogSystem.NativeMethodInfoPtr_get_directory_Private_Static_get_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
  }

  public static unsafe string path
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 63467, RefRangeEnd = 63469, XrefRangeStart = 63458, XrefRangeEnd = 63467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LogSystem.NativeMethodInfoPtr_get_path_Private_Static_get_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63469, XrefRangeEnd = 63494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LogSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63494, XrefRangeEnd = 63502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LogSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63502, XrefRangeEnd = 63511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LogSystem.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63511, XrefRangeEnd = 63518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LogSystem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 63532, RefRangeEnd = 63533, XrefRangeStart = 63518, XrefRangeEnd = 63532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Write(string str)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(str)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LogSystem.NativeMethodInfoPtr_Write_Private_Static_Void_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63533, XrefRangeEnd = 63542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Log(string log, string stacktrace, LogType type)
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(log);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(stacktrace);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &type;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LogSystem.NativeMethodInfoPtr_Log_Private_Static_Void_String_String_LogType_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 63559, RefRangeEnd = 63561, XrefRangeStart = 63542, XrefRangeEnd = 63559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Log(string log)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(log)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LogSystem.NativeMethodInfoPtr_Log_Private_Static_Void_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 63598, RefRangeEnd = 63599, XrefRangeStart = 63561, XrefRangeEnd = 63598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreateBackups()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LogSystem.NativeMethodInfoPtr_CreateBackups_Private_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 63609, RefRangeEnd = 63610, XrefRangeStart = 63599, XrefRangeEnd = 63609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetFileName(int backupNumber)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &backupNumber
    };
    IntPtr exc;
    IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LogSystem.NativeMethodInfoPtr_GetFileName_Private_Static_String_Int32_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 63709, RefRangeEnd = 63710, XrefRangeStart = 63610, XrefRangeEnd = 63709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LogSystemInformation()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LogSystem.NativeMethodInfoPtr_LogSystemInformation_Private_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LogSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LogSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LogSystem()
  {
    Il2CppClassPointerStore<LogSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LogSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogSystem>.NativeClassPtr);
    LogSystem.NativeFieldInfoPtr_backups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogSystem>.NativeClassPtr, nameof (backups));
    LogSystem.NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogSystem>.NativeClassPtr, nameof (format));
    LogSystem.NativeFieldInfoPtr_toLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogSystem>.NativeClassPtr, nameof (toLog));
    LogSystem.NativeFieldInfoPtr_logDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogSystem>.NativeClassPtr, nameof (logDelay));
    LogSystem.NativeFieldInfoPtr_logDelayMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogSystem>.NativeClassPtr, nameof (logDelayMax));
    LogSystem.NativeMethodInfoPtr_get_directory_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogSystem>.NativeClassPtr, 100668494);
    LogSystem.NativeMethodInfoPtr_get_path_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogSystem>.NativeClassPtr, 100668495);
    LogSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogSystem>.NativeClassPtr, 100668496);
    LogSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogSystem>.NativeClassPtr, 100668497);
    LogSystem.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogSystem>.NativeClassPtr, 100668498);
    LogSystem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogSystem>.NativeClassPtr, 100668499);
    LogSystem.NativeMethodInfoPtr_Write_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogSystem>.NativeClassPtr, 100668500);
    LogSystem.NativeMethodInfoPtr_Log_Private_Static_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogSystem>.NativeClassPtr, 100668501);
    LogSystem.NativeMethodInfoPtr_Log_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogSystem>.NativeClassPtr, 100668502);
    LogSystem.NativeMethodInfoPtr_CreateBackups_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogSystem>.NativeClassPtr, 100668503);
    LogSystem.NativeMethodInfoPtr_GetFileName_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogSystem>.NativeClassPtr, 100668504);
    LogSystem.NativeMethodInfoPtr_LogSystemInformation_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogSystem>.NativeClassPtr, 100668505);
    LogSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogSystem>.NativeClassPtr, 100668506);
  }

  public LogSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe int backups
  {
    get
    {
      int backups;
      IL2CPP.il2cpp_field_static_get_value(LogSystem.NativeFieldInfoPtr_backups, (void*) &backups);
      return backups;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LogSystem.NativeFieldInfoPtr_backups, (void*) &value);
    }
  }

  public static unsafe string format
  {
    get
    {
      IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(LogSystem.NativeFieldInfoPtr_format, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LogSystem.NativeFieldInfoPtr_format, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string toLog
  {
    get
    {
      IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(LogSystem.NativeFieldInfoPtr_toLog, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LogSystem.NativeFieldInfoPtr_toLog, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe int logDelay
  {
    get
    {
      int logDelay;
      IL2CPP.il2cpp_field_static_get_value(LogSystem.NativeFieldInfoPtr_logDelay, (void*) &logDelay);
      return logDelay;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LogSystem.NativeFieldInfoPtr_logDelay, (void*) &value);
    }
  }

  public static unsafe int logDelayMax
  {
    get
    {
      int logDelayMax;
      IL2CPP.il2cpp_field_static_get_value(LogSystem.NativeFieldInfoPtr_logDelayMax, (void*) &logDelayMax);
      return logDelayMax;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LogSystem.NativeFieldInfoPtr_logDelayMax, (void*) &value);
    }
  }
}
