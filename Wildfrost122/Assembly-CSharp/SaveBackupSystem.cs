// Decompiled with JetBrains decompiler
// Type: SaveBackupSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class SaveBackupSystem : GameSystem
{
  private const float backupCampaignTimer = 5f;
  private static float backupCampaignCooldown = 5f;

  private void OnEnable()
  {
    global::Events.OnCampaignStart += new UnityAction(SaveBackupSystem.CampaignStart);
    global::Events.OnCampaignSaved += new UnityAction(SaveBackupSystem.CampaignSaved);
  }

  private void OnDisable()
  {
    global::Events.OnCampaignStart -= new UnityAction(SaveBackupSystem.CampaignStart);
    global::Events.OnCampaignSaved -= new UnityAction(SaveBackupSystem.CampaignSaved);
  }

  private void Update()
  {
    if ((double) SaveBackupSystem.backupCampaignCooldown <= 0.0)
      return;
    SaveBackupSystem.backupCampaignCooldown -= Time.unscaledDeltaTime;
  }

  private static void CampaignStart()
  {
    string str = SaveSystem.folderName + "/";
    SaveBackupSystem.Backup(str + "Save.sav");
    SaveBackupSystem.Backup(str + "Stats.sav");
    SaveBackupSystem.Backup(str + "History.sav");
  }

  private static void CampaignSaved()
  {
    if ((double) SaveBackupSystem.backupCampaignCooldown > 0.0 || !(bool) (Object) References.Campaign || !Campaign.Data.GameMode.doSave)
      return;
    SaveBackupSystem.Backup(SaveSystem.folderName + "/" + "Campaign" + Campaign.Data.GameMode.saveFileName + ".sav");
    SaveBackupSystem.backupCampaignCooldown = 5f;
  }

  private static void Backup(string filePath)
  {
    StopWatch.Start();
    ES3.CreateBackup(filePath, SaveSystem.settings);
    Debug.Log((object) string.Format("Backup Created ({0}) ({1} ms)", (object) filePath, (object) StopWatch.Stop()));
  }
}
