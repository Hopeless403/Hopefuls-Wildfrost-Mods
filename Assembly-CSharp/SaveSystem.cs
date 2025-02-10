// Decompiled with JetBrains decompiler
// Type: SaveSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Deadpan.Enums.Engine.Components.Modding;
using NaughtyAttributes;
using System;
using System.IO;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Events;

public class SaveSystem : GameSystem
{
  private static SaveSystem instance;
  public bool encode;
  [HideIf("encode")]
  public bool beautify;
  private bool promptSave;
  private bool busy;
  public static readonly string profileFolder = "Profiles";
  public static string folderName = "SaveData";
  private static SaveSystem.Saver progressSaver;
  private static SaveSystem.Saver campaignSaver;
  private static SaveSystem.Saver battleSaver;
  private static SaveSystem.Saver statsSaver;
  private static SaveSystem.Saver historySaver;
  public static ES3Settings settings;
  public static bool gotSaveTimestamp;
  public static DateTime saveTimestamp;

  public static bool Enabled => (UnityEngine.Object) SaveSystem.instance != (UnityEngine.Object) null && SaveSystem.instance.enabled;

  public static string Profile { get; private set; } = "";

  private void OnEnable() => global::Events.InvokeSaveSystemEnabled();

  private void OnDisable() => global::Events.InvokeSaveSystemDisabled();

  private void Awake() => SaveSystem.instance = this;

  private void Start()
  {
    SaveSystem.settings = new ES3Settings(new Enum[1]
    {
      (Enum) ES3.Directory.PersistentDataPath
    })
    {
      encryptionType = ES3.EncryptionType.AES,
      compressionType = ES3.CompressionType.Gzip,
      prettyPrint = false
    };
    SaveSystem.SetProfile(SaveSystem.GetProfile(), false);
    if (ES3.FileExists(SaveSystem.folderName + "/Save.sav"))
    {
      SaveSystem.gotSaveTimestamp = true;
      SaveSystem.saveTimestamp = ES3.GetTimestamp(SaveSystem.folderName + "/Save.sav");
    }
    SaveSystem.progressSaver = new SaveSystem.Saver("Save{0}.sav", SaveSystem.settings);
    SaveSystem.campaignSaver = new SaveSystem.Saver("Campaign{0}.sav", SaveSystem.settings);
    SaveSystem.battleSaver = new SaveSystem.Saver("Battle{0}.sav", SaveSystem.settings);
    SaveSystem.statsSaver = new SaveSystem.Saver("Stats{0}.sav", SaveSystem.settings);
    SaveSystem.historySaver = new SaveSystem.Saver("History{0}.sav", SaveSystem.settings);
    SaveSystem.EncryptSaveData();
    global::Events.OnSaveSystemProfileChanged += new UnityAction(SaveSystem.EncryptSaveData);
    SaveSystem.progressSaver.CheckBackup(SaveSystem.folderName);
    SaveSystem.campaignSaver.CheckBackup(SaveSystem.folderName);
    SaveSystem.campaignSaver.CheckBackup(SaveSystem.folderName, "Demo");
    SaveSystem.campaignSaver.CheckBackup(SaveSystem.folderName, "PressDemo");
    SaveSystem.battleSaver.CheckBackup(SaveSystem.folderName);
    SaveSystem.statsSaver.CheckBackup(SaveSystem.folderName);
    SaveSystem.historySaver.CheckBackup(SaveSystem.folderName);
    foreach (WildfrostMod lastMod in WildfrostMod.GetLastMods())
      lastMod?.ModLoad();
  }

  private void OnDestroy() => global::Events.OnSaveSystemProfileChanged -= new UnityAction(SaveSystem.EncryptSaveData);

  public static void SaveProgressData<T>(string key, T value)
  {
    if (!SaveSystem.Enabled)
      return;
    SaveSystem.progressSaver.SaveValue<T>(key, value, SaveSystem.folderName);
  }

  public static void SaveCampaignData<T>(GameMode gameMode, string key, T value)
  {
    if (!SaveSystem.Enabled)
      return;
    SaveSystem.campaignSaver.SaveValue<T>(key, value, SaveSystem.folderName, gameMode.saveFileName);
  }

  public static void SaveStatsData<T>(string key, T value)
  {
    if (!SaveSystem.Enabled)
      return;
    SaveSystem.statsSaver.SaveValue<T>(key, value, SaveSystem.folderName);
  }

  public static void SaveHistoryData<T>(string key, T value)
  {
    if (!SaveSystem.Enabled)
      return;
    SaveSystem.historySaver.SaveValue<T>(key, value, SaveSystem.folderName);
  }

  public static T LoadProgressData<T>(string key) where T : class => SaveSystem.LoadProgressData<T>(key, default (T));

  public static T LoadCampaignData<T>(GameMode gameMode, string key) where T : class => SaveSystem.LoadCampaignData<T>(gameMode, key, default (T));

  public static T LoadStatsData<T>(string key) where T : class => SaveSystem.LoadStatsData<T>(key, default (T));

  public static T LoadHistoryData<T>(string key) where T : class => SaveSystem.LoadHistoryData<T>(key, default (T));

  public static T LoadProgressData<T>(string key, T defaultValue) => !SaveSystem.Enabled ? defaultValue : SaveSystem.progressSaver.LoadValue<T>(key, SaveSystem.folderName, defaultValue);

  public static T LoadCampaignData<T>(GameMode gameMode, string key, T defaultValue) => !SaveSystem.Enabled ? defaultValue : SaveSystem.campaignSaver.LoadValue<T>(key, SaveSystem.folderName, defaultValue, gameMode.saveFileName);

  public static T LoadStatsData<T>(string key, T defaultValue) => !SaveSystem.Enabled ? defaultValue : SaveSystem.statsSaver.LoadValue<T>(key, SaveSystem.folderName, defaultValue);

  public static T LoadHistoryData<T>(string key, T defaultValue) => !SaveSystem.Enabled ? defaultValue : SaveSystem.historySaver.LoadValue<T>(key, SaveSystem.folderName, defaultValue);

  public static bool ProgressExists() => SaveSystem.Enabled && SaveSystem.progressSaver.FileExists(SaveSystem.folderName);

  public static bool CampaignExists(GameMode gameMode) => SaveSystem.Enabled && SaveSystem.campaignSaver.FileExists(SaveSystem.folderName, gameMode.saveFileName);

  public static bool StatsExists() => SaveSystem.Enabled && SaveSystem.statsSaver.FileExists(SaveSystem.folderName);

  public static bool HistoryExists() => SaveSystem.Enabled && SaveSystem.historySaver.FileExists(SaveSystem.folderName);

  public static bool ProgressDataExists(string key) => SaveSystem.Enabled && SaveSystem.progressSaver.KeyExists(key, SaveSystem.folderName);

  public static bool CampaignDataExists(GameMode gameMode, string key) => SaveSystem.Enabled && SaveSystem.campaignSaver.KeyExists(key, SaveSystem.folderName, gameMode.saveFileName);

  public static bool StatsDataExists(string key) => SaveSystem.Enabled && SaveSystem.statsSaver.KeyExists(key, SaveSystem.folderName);

  public static bool HistoryDataExists(string key) => SaveSystem.Enabled && SaveSystem.historySaver.KeyExists(key, SaveSystem.folderName);

  public static void DeleteProgress()
  {
    if (!SaveSystem.Enabled)
      return;
    SaveSystem.progressSaver.Delete(SaveSystem.folderName);
  }

  public static void DeleteCampaign(GameMode gameMode)
  {
    if (!SaveSystem.Enabled)
      return;
    SaveSystem.campaignSaver.Delete(SaveSystem.folderName, gameMode.saveFileName);
  }

  public static void DeleteProfile(string profileName)
  {
    if (!SaveSystem.Enabled)
      return;
    ES3.DeleteDirectory(SaveSystem.folderName);
  }

  public static void DeleteStats()
  {
    if (!SaveSystem.Enabled)
      return;
    SaveSystem.statsSaver.Delete(SaveSystem.folderName);
  }

  public static void DeleteHistory()
  {
    if (!SaveSystem.Enabled)
      return;
    SaveSystem.historySaver.Delete(SaveSystem.folderName);
  }

  public static void DeleteProgressData(string key)
  {
    if (!SaveSystem.Enabled)
      return;
    SaveSystem.progressSaver.DeleteKey(key, SaveSystem.folderName);
  }

  public static string GetProfile()
  {
    try
    {
      return ES3.Load<string>("profile", "data.sav", "Default");
    }
    catch (Exception ex)
    {
      Debug.LogWarning((object) ex);
      return "Default";
    }
  }

  public static void SetProfile(string name, bool save = true)
  {
    Debug.Log((object) ("Save Profile Set: " + name));
    SaveSystem.Profile = name;
    SaveSystem.folderName = SaveSystem.profileFolder + "/" + name;
    if (SaveSystem.Enabled)
      global::Events.InvokeSaveSystemProfileChanged();
    if (!save)
      return;
    try
    {
      ES3.Save<string>("profile", name, "data.sav");
    }
    catch (Exception ex)
    {
      Debug.LogWarning((object) ex);
      ES3.DeleteFile("data.sav");
      ES3.Save<string>("profile", name, "data.sav");
    }
  }

  private static void EncryptSaveData()
  {
    ES3Settings defaultSettings = ES3Settings.defaultSettings;
    ES3Settings settings = SaveSystem.settings;
    SaveSystem.ConvertSaveFile(SaveSystem.progressSaver, SaveSystem.folderName, "", defaultSettings, settings);
    SaveSystem.ConvertSaveFile(SaveSystem.campaignSaver, SaveSystem.folderName, "", defaultSettings, settings);
    SaveSystem.ConvertSaveFile(SaveSystem.campaignSaver, SaveSystem.folderName, "Demo", defaultSettings, settings);
    SaveSystem.ConvertSaveFile(SaveSystem.statsSaver, SaveSystem.folderName, "", defaultSettings, settings);
  }

  private static void ConvertSaveFile(
    SaveSystem.Saver saver,
    string folder,
    string fileName,
    ES3Settings oldSettings,
    ES3Settings newSettings)
  {
    string str = string.Format(saver.baseFileName, (object) fileName);
    string filePath1 = SaveSystem.folderName + "/" + str;
    try
    {
      ES3.KeyExists("a", filePath1, newSettings);
      Debug.Log((object) ("[" + str + "] save file does not need converting"));
    }
    catch (Exception ex1) when (
    {
      // ISSUE: unable to correctly present filter
      int num;
      switch (ex1)
      {
        case FormatException _:
        case ArgumentException _:
          num = 1;
          break;
        default:
          num = ex1 is CryptographicException ? 1 : 0;
          break;
      }
      if ((uint) num > 0U)
      {
        SuccessfulFiltering;
      }
      else
        throw;
    }
    )
    {
      Debug.LogWarning((object) ex1);
      Debug.LogWarning((object) ("[" + str + "] save file needs converting"));
      try
      {
        string filePath2 = folder + "/" + str;
        ES3.SaveRaw(ES3.LoadRawString(filePath2, oldSettings), filePath2, newSettings);
        Debug.Log((object) ("Successfully converted [" + str + "] to new file format"));
      }
      catch (Exception ex2)
      {
        Debug.LogWarning((object) ex2);
        Debug.LogWarning((object) ("Failed to convert [" + str + "] to new file format"));
      }
    }
  }

  private class Saver
  {
    public readonly string baseFileName;
    private readonly ES3Settings settings;

    public Saver(string baseFileName, ES3Settings settings = null)
    {
      this.baseFileName = baseFileName;
      this.settings = settings ?? ES3Settings.defaultSettings;
    }

    public void SaveValue<TValue>(string key, TValue value, string folderName, string fileName = "")
    {
      StopWatch.Start();
      string str = string.Format(this.baseFileName, (object) fileName);
      Debug.Log((object) ("Saving [" + str + "] (" + key + ")..."));
      string filePath = folderName + "/" + str;
      try
      {
        ES3.Save<TValue>(key, value, filePath, this.settings);
      }
      catch (InvalidOperationException ex)
      {
        Debug.LogWarning((object) ex);
      }
      catch (IOException ex)
      {
        Debug.LogWarning((object) ex);
      }
      Debug.Log((object) string.Format("Saving Done! ({0}ms)", (object) StopWatch.Stop()));
    }

    public TValue LoadValue<TValue>(
      string key,
      string folderName,
      TValue defaultValue,
      string fileName = "")
    {
      StopWatch.Start();
      string str = string.Format(this.baseFileName, (object) fileName);
      Debug.Log((object) ("Loading [" + str + "] (" + key + ")..."));
      string filePath = folderName + "/" + str;
      TValue obj = defaultValue;
      try
      {
        obj = ES3.Load<TValue>(key, filePath, defaultValue, this.settings);
      }
      catch (Exception ex1)
      {
        Debug.LogWarning((object) ex1);
        Debug.LogWarning((object) (filePath + " data appears to be corrupt, attempting to restore backup"));
        ES3.RestoreBackup(filePath, this.settings);
        try
        {
          obj = ES3.Load<TValue>(key, filePath, defaultValue, this.settings);
        }
        catch (Exception ex2)
        {
          Debug.LogWarning((object) "Failed to restore backup :( returning default value...");
        }
      }
      Debug.Log((object) string.Format("Loading Done! ({0}ms)", (object) StopWatch.Stop()));
      return obj;
    }

    public bool FileExists(string folderName, string fileName = "")
    {
      string str = string.Format(this.baseFileName, (object) fileName);
      return ES3.FileExists(folderName + "/" + str, this.settings);
    }

    public bool KeyExists(string key, string folderName, string fileName = "")
    {
      string str = string.Format(this.baseFileName, (object) fileName);
      string filePath = folderName + "/" + str;
      try
      {
        return ES3.KeyExists(key, filePath, this.settings);
      }
      catch (Exception ex1)
      {
        Debug.LogWarning((object) ex1);
        Debug.LogWarning((object) (filePath + " data appears to be corrupt, attempting to restore backup"));
        ES3.RestoreBackup(filePath, this.settings);
        try
        {
          return ES3.KeyExists(key, filePath, this.settings);
        }
        catch (Exception ex2)
        {
          Debug.LogWarning((object) "Failed to restore backup :( returning default value...");
          return false;
        }
      }
    }

    public void Delete(string folderName, string fileName = "")
    {
      string str = string.Format(this.baseFileName, (object) fileName);
      ES3.DeleteFile(folderName + "/" + str, this.settings);
    }

    public void DeleteKey(string key, string folderName, string fileName = "")
    {
      string str = string.Format(this.baseFileName, (object) fileName);
      ES3.DeleteKey(key, folderName + "/" + str, this.settings);
    }

    public void CheckBackup(string folderName, string fileName = "")
    {
      string str = string.Format(this.baseFileName, (object) fileName);
      string filePath = folderName + "/" + str;
      Debug.Log((object) ("Checking " + str + " for corrupt data..."));
      try
      {
        ES3.KeyExists("a", filePath, this.settings);
      }
      catch (Exception ex1)
      {
        Debug.LogWarning((object) ex1);
        Debug.LogWarning((object) (filePath + " data appears to be corrupt, attempting to restore backup"));
        ES3.RestoreBackup(filePath, this.settings);
        try
        {
          ES3.KeyExists("a", filePath, this.settings);
          Debug.Log((object) ("Successfully retrieved " + str + " backup"));
        }
        catch (Exception ex2)
        {
          Debug.LogWarning((object) "Failed to restore backup :(");
        }
      }
    }
  }
}
