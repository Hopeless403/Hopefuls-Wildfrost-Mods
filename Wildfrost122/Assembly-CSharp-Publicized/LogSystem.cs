// Decompiled with JetBrains decompiler
// Type: LogSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.IO;
using UnityEngine;

#nullable disable
public class LogSystem : GameSystem
{
  public const int backups = 9;
  public const string format = "[{0}] {1}\n";
  public static string toLog = "";
  public static int logDelay = 0;
  public const int logDelayMax = 10;

  public static string directory => Application.persistentDataPath ?? "";

  public static string path => LogSystem.directory + "/Log.log";

  public void OnEnable()
  {
    if (!System.IO.Directory.Exists(LogSystem.directory))
      System.IO.Directory.CreateDirectory(LogSystem.directory);
    LogSystem.CreateBackups();
    Application.logMessageReceived += new Application.LogCallback(LogSystem.Log);
    LogSystem.LogSystemInformation();
  }

  public void OnDisable()
  {
    Application.logMessageReceived -= new Application.LogCallback(LogSystem.Log);
  }

  public void OnDestroy()
  {
    if (LogSystem.toLog.IsNullOrEmpty())
      return;
    LogSystem.Write(LogSystem.toLog);
  }

  public void Update()
  {
    if (LogSystem.logDelay < 0)
    {
      if (LogSystem.toLog.IsNullOrEmpty())
        return;
      LogSystem.Write(LogSystem.toLog);
      LogSystem.toLog = "";
      LogSystem.logDelay = 10;
    }
    else
      --LogSystem.logDelay;
  }

  public static void Write(string str)
  {
    using (StreamWriter streamWriter = new StreamWriter(LogSystem.path, true))
      streamWriter.Write(str);
  }

  public static void Log(string log, string stacktrace, LogType type)
  {
    if (type == LogType.Error || type == LogType.Exception)
      log = "\n\n" + log + "\n" + stacktrace;
    LogSystem.Log(log);
  }

  public static void Log(string log)
  {
    LogSystem.toLog += string.Format("[{0}] {1}\n", (object) DateTime.Now, (object) log);
  }

  public static void CreateBackups()
  {
    for (int backupNumber = 8; backupNumber >= 0; --backupNumber)
    {
      string fileName1 = LogSystem.GetFileName(backupNumber);
      if (File.Exists(fileName1))
      {
        string fileName2 = LogSystem.GetFileName(backupNumber + 1);
        File.Copy(fileName1, fileName2, true);
        if (backupNumber == 0)
          File.Delete(fileName1);
      }
    }
  }

  public static string GetFileName(int backupNumber)
  {
    return backupNumber <= 0 ? LogSystem.path : string.Format("{0}.{1}", (object) LogSystem.path, (object) backupNumber);
  }

  public static void LogSystemInformation()
  {
    LogSystem.Log("\n" + SystemInfo.deviceModel + string.Format("\n{0} ({1}) [{2}]", (object) SystemInfo.deviceType, (object) SystemInfo.deviceName, (object) SystemInfo.deviceUniqueIdentifier) + "\n" + SystemInfo.operatingSystem + string.Format("\n{0} ({1} Cores, {2}hz)", (object) SystemInfo.processorType, (object) SystemInfo.processorCount, (object) SystemInfo.processorFrequency) + "\n" + SystemInfo.graphicsDeviceVendor + " | " + SystemInfo.graphicsDeviceName + " (" + SystemInfo.graphicsDeviceVersion + ")" + string.Format("\nShader Level: {0}", (object) SystemInfo.graphicsShaderLevel) + string.Format("\nGraphics Memory: {0}", (object) SystemInfo.graphicsMemorySize) + string.Format("\nSystem Memory: {0}", (object) SystemInfo.systemMemorySize));
  }
}
