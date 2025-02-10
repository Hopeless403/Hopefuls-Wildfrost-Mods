// Decompiled with JetBrains decompiler
// Type: SaveBackupSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class SaveBackupSystem : GameSystem
{
  public const float backupCampaignTimer = 5f;
  public static float backupCampaignCooldown = 5f;

  public void OnEnable()
  {
    global::Events.OnCampaignStart += new UnityAction(SaveBackupSystem.CampaignStart);
    global::Events.OnCampaignSaved += new UnityAction(SaveBackupSystem.CampaignSaved);
  }

  public void OnDisable()
  {
    global::Events.OnCampaignStart -= new UnityAction(SaveBackupSystem.CampaignStart);
    global::Events.OnCampaignSaved -= new UnityAction(SaveBackupSystem.CampaignSaved);
  }

  public void Update()
  {
    if ((double) SaveBackupSystem.backupCampaignCooldown <= 0.0)
      return;
    SaveBackupSystem.backupCampaignCooldown -= Time.unscaledDeltaTime;
  }

  public static void CampaignStart()
  {
    string str = SaveSystem.folderName + "/";
    SaveBackupSystem.Backup(str + "Save.sav");
    SaveBackupSystem.Backup(str + "Stats.sav");
    SaveBackupSystem.Backup(str + "History.sav");
  }

  public static void CampaignSaved()
  {
    if ((double) SaveBackupSystem.backupCampaignCooldown > 0.0 || !(bool) (Object) References.Campaign || !Campaign.Data.GameMode.doSave)
      return;
    SaveBackupSystem.Backup(SaveSystem.folderName + "/" + "Campaign" + Campaign.Data.GameMode.saveFileName + ".sav");
    SaveBackupSystem.backupCampaignCooldown = 5f;
  }

  public static void Backup(string filePath)
  {
    StopWatch.Start();
    ES3.CreateBackup(filePath, SaveSystem.settings);
    Debug.Log((object) string.Format("Backup Created ({0}) ({1} ms)", (object) filePath, (object) StopWatch.Stop()));
  }
}
