// Decompiled with JetBrains decompiler
// Type: Settings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;

public static class Settings
{
  public static readonly ES3Settings settings = new ES3Settings(new Enum[1]
  {
    (Enum) ES3.Directory.PersistentDataPath
  })
  {
    path = "settings.json",
    encryptionType = ES3.EncryptionType.None,
    compressionType = ES3.CompressionType.None,
    prettyPrint = true
  };

  public static void Save<T>(string key, T value)
  {
    try
    {
      ES3.Save<T>(key, value, Settings.settings);
    }
    catch (FormatException ex1)
    {
      Debug.LogWarning((object) ex1);
      ES3.DeleteFile(Settings.settings);
      try
      {
        ES3.Save<T>(key, value, Settings.settings);
      }
      catch (Exception ex2)
      {
        Debug.LogError((object) string.Format("ES3 Failed to save Settings even after deleting file.\n{0}", (object) ex2));
      }
    }
    Events.InvokeSettingChanged(key, (object) value);
    Debug.Log((object) string.Format("Setting Saved [{0} = {1}]", (object) key, (object) value));
  }

  public static T Load<T>(string key, T defaultValue)
  {
    T obj = defaultValue;
    try
    {
      obj = ES3.Load<T>(key, defaultValue, Settings.settings);
    }
    catch (Exception ex)
    {
      Debug.LogWarning((object) ex);
    }
    Debug.Log((object) string.Format("Setting Loaded [{0} = {1}]", (object) key, (object) obj));
    return obj;
  }

  public static bool Exists(string key)
  {
    try
    {
      return ES3.KeyExists(key, Settings.settings);
    }
    catch (Exception ex)
    {
      Debug.LogWarning((object) ex);
    }
    return false;
  }
}
