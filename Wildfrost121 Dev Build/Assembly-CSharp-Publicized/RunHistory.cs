// Decompiled with JetBrains decompiler
// Type: RunHistory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

#nullable disable
public class RunHistory
{
  public string gameModeName;
  public Campaign.Result result;
  public CampaignStats stats;
  public ClassSaveData tribe;
  public InventorySaveData inventory;

  public RunHistory()
  {
  }

  public RunHistory(
    GameMode gameMode,
    Campaign.Result result,
    CampaignStats stats,
    PlayerData playerData)
  {
    this.gameModeName = gameMode.name;
    this.result = result;
    this.stats = stats;
    this.tribe = playerData.classData.Save();
    this.inventory = playerData.inventory.Save();
  }
}
