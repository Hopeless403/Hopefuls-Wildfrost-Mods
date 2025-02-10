// Decompiled with JetBrains decompiler
// Type: BlockConsumeModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine.Events;

#nullable disable
public class BlockConsumeModifierSystem : GameSystem
{
  public const int toBlockPerBattle = 1;
  public int toBlock;

  public void OnEnable()
  {
    global::Events.OnBattleStart += new UnityAction(this.BattleStart);
    global::Events.OnBattleLoaded += new UnityAction(this.BattleLoaded);
    global::Events.OnActionQueued += new UnityAction<PlayAction>(this.ActionQueued);
  }

  public void OnDisable()
  {
    global::Events.OnBattleStart -= new UnityAction(this.BattleStart);
    global::Events.OnBattleLoaded -= new UnityAction(this.BattleLoaded);
    global::Events.OnActionQueued -= new UnityAction<PlayAction>(this.ActionQueued);
  }

  public void BattleStart()
  {
    this.toBlock = 1;
    this.SaveData();
  }

  public void BattleLoaded() => this.LoadData();

  public void ActionQueued(PlayAction action)
  {
    if (this.toBlock <= 0 || !(action is ActionConsume actionConsume) || actionConsume.blocked)
      return;
    --this.toBlock;
    actionConsume.Block();
    this.SaveData();
  }

  public void SaveData()
  {
    int id = Campaign.FindCharacterNode(References.Battle.player).id;
    SaveSystem.SaveCampaignData<int>(Campaign.Data.GameMode, "BlockConsumeModifierSystemBattleId", id);
    SaveSystem.SaveCampaignData<int>(Campaign.Data.GameMode, "BlockConsumeModifierSystemToBlock", this.toBlock);
  }

  public void LoadData()
  {
    int id = Campaign.FindCharacterNode(References.Battle.player).id;
    if (SaveSystem.LoadCampaignData<int>(Campaign.Data.GameMode, "BlockConsumeModifierSystemBattleId", -1) != id)
      return;
    this.toBlock = SaveSystem.LoadCampaignData<int>(Campaign.Data.GameMode, "BlockConsumeModifierSystemToBlock", 0);
  }
}
