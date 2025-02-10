// Decompiled with JetBrains decompiler
// Type: LogSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.IO;
using UnityEngine;

#nullable disable
public class LogSystem : GameSystem
{
  private const int backups = 9;
  private const string format = "[{0}] {1}\n";
  private static string toLog = "";
  private static int logDelay = 0;
  private const int logDelayMax = 10;

  private static string directory => Application.persistentDataPath ?? "";

  private static string path => LogSystem.directory + "/Log.log";

  private void OnEnable()
  {
    if (!System.IO.Directory.Exists(LogSystem.directory))
      System.IO.Directory.CreateDirectory(LogSystem.directory);
    LogSystem.CreateBackups();
    Application.logMessageReceived += new Application.LogCallback(LogSystem.Log);
    LogSystem.LogSystemInformation();
  }

  private void OnDisable()
  {
    Application.logMessageReceived -= new Application.LogCallback(LogSystem.Log);
  }

  private void OnDestroy()
  {
    if (LogSystem.toLog.IsNullOrEmpty())
      return;
    LogSystem.Write(LogSystem.toLog);
  }

  private void Update()
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

  private static void Write(string str)
  {
    using (StreamWriter streamWriter = new StreamWriter(LogSystem.path, true))
      streamWriter.Write(str);
  }

  private static void Log(string log, string stacktrace, LogType type)
  {
    if (type == LogType.Error || type == LogType.Exception)
      log = "\n\n" + log + "\n" + stacktrace;
    LogSystem.Log(log);
  }

  private static void Log(string log)
  {
    LogSystem.toLog += string.Format("[{0}] {1}\n", (object) DateTime.Now, (object) log);
  }

  private static void CreateBackups()
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

  private static string GetFileName(int backupNumber)
  {
    return backupNumber <= 0 ? LogSystem.path : string.Format("{0}.{1}", (object) LogSystem.path, (object) backupNumber);
  }

  private static void LogSystemInformation()
  {
    LogSystem.Log("\n" + SystemInfo.deviceModel + string.Format("\n{0} ({1}) [{2}]", (object) SystemInfo.deviceType, (object) SystemInfo.deviceName, (object) SystemInfo.deviceUniqueIdentifier) + "\n" + SystemInfo.operatingSystem + string.Format("\n{0} ({1} Cores, {2}hz)", (object) SystemInfo.processorType, (object) SystemInfo.processorCount, (object) SystemInfo.processorFrequency) + "\n" + SystemInfo.graphicsDeviceVendor + " | " + SystemInfo.graphicsDeviceName + " (" + SystemInfo.graphicsDeviceVersion + ")" + string.Format("\nShader Level: {0}", (object) SystemInfo.graphicsShaderLevel) + string.Format("\nGraphics Memory: {0}", (object) SystemInfo.graphicsMemorySize) + string.Format("\nSystem Memory: {0}", (object) SystemInfo.systemMemorySize));
  }
}
