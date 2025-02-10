// Decompiled with JetBrains decompiler
// Type: BlockConsumeModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine.Events;

#nullable disable
public class BlockConsumeModifierSystem : GameSystem
{
  private const int toBlockPerBattle = 1;
  private int toBlock;

  private void OnEnable()
  {
    global::Events.OnBattleStart += new UnityAction(this.BattleStart);
    global::Events.OnBattleLoaded += new UnityAction(this.BattleLoaded);
    global::Events.OnActionQueued += new UnityAction<PlayAction>(this.ActionQueued);
  }

  private void OnDisable()
  {
    global::Events.OnBattleStart -= new UnityAction(this.BattleStart);
    global::Events.OnBattleLoaded -= new UnityAction(this.BattleLoaded);
    global::Events.OnActionQueued -= new UnityAction<PlayAction>(this.ActionQueued);
  }

  private void BattleStart()
  {
    this.toBlock = 1;
    this.SaveData();
  }

  private void BattleLoaded() => this.LoadData();

  private void ActionQueued(PlayAction action)
  {
    if (this.toBlock <= 0 || !(action is ActionConsume actionConsume) || actionConsume.blocked)
      return;
    --this.toBlock;
    actionConsume.Block();
    this.SaveData();
  }

  private void SaveData()
  {
    int id = Campaign.FindCharacterNode(References.Battle.player).id;
    SaveSystem.SaveCampaignData<int>(Campaign.Data.GameMode, "BlockConsumeModifierSystemBattleId", id);
    SaveSystem.SaveCampaignData<int>(Campaign.Data.GameMode, "BlockConsumeModifierSystemToBlock", this.toBlock);
  }

  private void LoadData()
  {
    int id = Campaign.FindCharacterNode(References.Battle.player).id;
    if (SaveSystem.LoadCampaignData<int>(Campaign.Data.GameMode, "BlockConsumeModifierSystemBattleId", -1) != id)
      return;
    this.toBlock = SaveSystem.LoadCampaignData<int>(Campaign.Data.GameMode, "BlockConsumeModifierSystemToBlock", 0);
  }
}
