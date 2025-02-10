// Decompiled with JetBrains decompiler
// Type: VersionCompatibility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VersionCompatibility : MonoBehaviour
{
  private static bool versionsGot;
  public static string previousVersion;
  public static string currentVersion;

  private void OnEnable() => global::Events.OnGameStart += new UnityAction(VersionCompatibility.GameStart);

  private void OnDisable() => global::Events.OnGameStart -= new UnityAction(VersionCompatibility.GameStart);

  public static void GetVersions()
  {
    if (VersionCompatibility.versionsGot)
      return;
    VersionCompatibility.currentVersion = Config.data.version;
    VersionCompatibility.previousVersion = SaveSystem.LoadProgressData<string>("version", "0");
  }

  private static void GameStart()
  {
    VersionCompatibility.GetVersions();
    if (VersionCompatibility.currentVersion != VersionCompatibility.previousVersion)
    {
      Debug.Log((object) ("Checking Version Compatibility [" + VersionCompatibility.previousVersion + "] → [" + VersionCompatibility.currentVersion + "]"));
      foreach (VersionCompatibility.Profile profile in new List<VersionCompatibility.Profile>()
      {
        new VersionCompatibility.Profile("Reset Progress", "63+", "0-62", new System.Action(VersionCompatibility.ResetProgress)),
        new VersionCompatibility.Profile("Reset Town Progress", "88+", "0-87", new System.Action(VersionCompatibility.ResetTownProgress)),
        new VersionCompatibility.Profile("Delete Campaign Save", "135+", "0-134", new System.Action(VersionCompatibility.DeleteCampaignSave)),
        new VersionCompatibility.Profile("Reset Progress", "153+", "0-152", new System.Action(VersionCompatibility.DeleteDefaultProfile)),
        new VersionCompatibility.Profile("Create Beta Profile", "175", "0-174", new System.Action(VersionCompatibility.CreateBetaProfile)),
        new VersionCompatibility.Profile("Copy Beta Profile", "177+", "175-176", new System.Action(VersionCompatibility.CopyBetaProfile)),
        new VersionCompatibility.Profile("Copy Beta Profile", "187+", "179-186", new System.Action(VersionCompatibility.CopyBetaProfile))
      })
        profile.Check(VersionCompatibility.currentVersion, VersionCompatibility.previousVersion);
      SaveSystem.SaveProgressData<string>("version", VersionCompatibility.currentVersion);
    }
    ProgressSaveData data = SaveSystem.LoadProgressData<ProgressSaveData>("progress");
    if (data == null)
      return;
    Debug.Log((object) "VersionCompatibility → Converting ProgressSaveData");
    VersionCompatibility.ConvertProgressSaveData(data);
  }

  private static void CreateBetaProfile() => ES3.CopyDirectory(SaveSystem.folderName, SaveSystem.profileFolder + "/Beta", SaveSystem.settings, SaveSystem.settings);

  private static void CopyBetaProfile()
  {
    if (!ES3.DirectoryExists(SaveSystem.profileFolder + "/Beta") || !ES3.FileExists(SaveSystem.profileFolder + "/Beta/Save.sav") || !SaveSystem.gotSaveTimestamp)
      return;
    DateTime timestamp = ES3.GetTimestamp(SaveSystem.profileFolder + "/Beta/Save.sav", SaveSystem.settings);
    if (timestamp > SaveSystem.saveTimestamp)
    {
      Debug.Log((object) string.Format("Beta Save Timestamp: {0}, Default: {1}, Copying Beta Save to Default", (object) timestamp, (object) SaveSystem.saveTimestamp));
      VersionCompatibility.CopyFileFromBetaProfile("Save.sav");
      VersionCompatibility.CopyFileFromBetaProfile("Stats.sav");
      VersionCompatibility.CopyFileFromBetaProfile("Campaign.sav");
      VersionCompatibility.CopyFileFromBetaProfile("CampaignDaily.sav");
      VersionCompatibility.CopyFileFromBetaProfile("CampaignTutorial.sav");
      VersionCompatibility.CopyFileFromBetaProfile("History.sav");
    }
    else
      Debug.Log((object) string.Format("Beta Save Timestamp: {0}, Default: {1}, Default is more recent, deleting Beta profile", (object) timestamp, (object) SaveSystem.saveTimestamp));
    ES3.DeleteDirectory(SaveSystem.profileFolder + "/Beta");
  }

  private static void CopyFileFromBetaProfile(string fileName) => VersionCompatibility.CopyFileData(SaveSystem.profileFolder + "/Beta/" + fileName, SaveSystem.folderName + "/" + fileName, SaveSystem.settings);

  private static void CopyFileData(string fromPath, string toPath, ES3Settings settings)
  {
    if (!ES3.FileExists(fromPath, settings))
      return;
    ES3.SaveRaw(ES3.LoadRawString(fromPath, settings), toPath, settings);
  }

  private static void DeleteDefaultProfile() => SaveSystem.DeleteProfile("Default");

  private static void ResetProgress()
  {
    if (!SaveSystem.ProgressExists())
      return;
    ProgressSaveData progressSaveData = SaveSystem.LoadProgressData<ProgressSaveData>("progress");
    SaveSystem.DeleteProgress();
    if (progressSaveData == null)
      return;
    SaveSystem.SaveProgressData<ProgressSaveData>("progress", progressSaveData);
  }

  private static void ResetTownProgress()
  {
    if (!SaveSystem.ProgressExists())
      return;
    SaveSystem.DeleteProgressData("townProgress");
    SaveSystem.DeleteProgressData("unlocked");
    SaveSystem.DeleteProgressData("townNew");
    SaveSystem.DeleteProgressData("finalBoss");
    SaveSystem.DeleteProgressData("finalBossEnemies");
    SaveSystem.DeleteProgressData("petHutUnlocks");
    SaveSystem.DeleteProgressData("inventorHutUnlocks");
    SaveSystem.DeleteProgressData("hotSpringUnlocks");
    SaveSystem.DeleteProgressData("completedChallenges");
    SaveSystem.DeleteProgressData("challengeProgress");
  }

  private static void ConvertProgressSaveData(ProgressSaveData data)
  {
    SaveSystem.SaveProgressData<int>("nextSeed", data.nextSeed);
    SaveSystem.SaveProgressData<int>("tutorialProgress", data.tutorialProgress);
    SaveSystem.SaveProgressData<bool>("tutorialCharmDone", data.tutorialCharmDone);
    SaveSystem.SaveProgressData<bool>("tutorialInjuryDone", data.tutorialInjuryDone);
    SaveSystem.DeleteProgressData("progress");
  }

  private static void DeleteCampaignSave() => SaveSystem.DeleteCampaign(AddressableLoader.Get<GameMode>("GameMode", "GameModeNormal"));

  private readonly struct Profile
  {
    private readonly string name;
    private readonly int versionFrom;
    private readonly int versionTo;
    private readonly int incompatibleWithFrom;
    private readonly int incompatibleWithTo;
    private readonly System.Action action;

    public Profile(string name, string version, string incompatibleWith, System.Action action)
    {
      this.name = name;
      VersionCompatibility.Profile.ProcessVersionString(version, out this.versionFrom, out this.versionTo);
      VersionCompatibility.Profile.ProcessVersionString(incompatibleWith, out this.incompatibleWithFrom, out this.incompatibleWithTo);
      this.action = action;
    }

    private static void ProcessVersionString(string @in, out int lower, out int higher)
    {
      string[] strArray = @in.Split(new char[1]{ '-' }, StringSplitOptions.RemoveEmptyEntries);
      if (strArray.Length == 2)
      {
        int.TryParse(strArray[0], out lower);
        int.TryParse(strArray[1], out higher);
      }
      else
      {
        int.TryParse(@in.Replace("+", ""), out lower);
        higher = @in.EndsWith("+") ? 99999 : lower;
      }
    }

    private static bool InRange(int x, int a, int b) => a <= x && x <= b;

    public void Check(string currentVersion, string previousVersion)
    {
      int result1;
      int result2;
      if (!int.TryParse(previousVersion, out result1) || !VersionCompatibility.Profile.InRange(result1, this.incompatibleWithFrom, this.incompatibleWithTo) || !int.TryParse(currentVersion, out result2) || !VersionCompatibility.Profile.InRange(result2, this.versionFrom, this.versionTo))
        return;
      Debug.Log((object) ("Version [" + currentVersion + "] incompatible with [" + previousVersion + "] running [" + this.name + "] Script"));
      this.action();
    }
  }
}
