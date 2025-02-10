// Decompiled with JetBrains decompiler
// Type: RunHistory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
