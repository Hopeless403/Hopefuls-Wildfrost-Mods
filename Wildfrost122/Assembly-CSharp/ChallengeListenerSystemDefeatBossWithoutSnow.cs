// Decompiled with JetBrains decompiler
// Type: ChallengeListenerSystemDefeatBossWithoutSnow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class ChallengeListenerSystemDefeatBossWithoutSnow : ChallengeListenerSystem
{
  private const string effectType = "snow";
  private int nodeId;
  private bool snowApplied;
  private bool isBossBattle;

  private void OnEnable()
  {
    global::Events.OnBattleStart += new UnityAction(this.BattleStart);
    global::Events.OnBattleLoaded += new UnityAction(this.BattleLoaded);
    global::Events.OnBattleSaved += new UnityAction(this.BattleSaved);
    global::Events.OnBattleEnd += new UnityAction(this.BattleEnd);
    global::Events.OnStatusEffectApplied += new UnityAction<StatusEffectApply>(this.StatusApplied);
  }

  private void OnDisable()
  {
    global::Events.OnBattleStart -= new UnityAction(this.BattleStart);
    global::Events.OnBattleLoaded -= new UnityAction(this.BattleLoaded);
    global::Events.OnBattleSaved -= new UnityAction(this.BattleSaved);
    global::Events.OnBattleEnd -= new UnityAction(this.BattleEnd);
    global::Events.OnStatusEffectApplied -= new UnityAction<StatusEffectApply>(this.StatusApplied);
  }

  private void StatusApplied(StatusEffectApply apply)
  {
    if (!this.isBossBattle || this.snowApplied || apply.target.owner.team != References.Battle.enemy.team || !(apply.effectData.type == "snow") || !apply.target.data.cardType.miniboss)
      return;
    this.snowApplied = true;
  }

  private void BattleStart()
  {
    CampaignNode characterNode = Campaign.FindCharacterNode(References.Player);
    this.isBossBattle = characterNode.type.isBattle && characterNode.type.isBoss;
    if (!this.isBossBattle)
      return;
    this.nodeId = characterNode.id;
    this.snowApplied = false;
  }

  private void BattleLoaded()
  {
    CampaignNode characterNode = Campaign.FindCharacterNode(References.Player);
    this.isBossBattle = characterNode.type.isBattle && characterNode.type.isBoss;
    if (!this.isBossBattle)
      return;
    this.nodeId = SaveSystem.LoadCampaignData<int>(Campaign.Data.GameMode, "DefeatBossWithoutSnowNodeId", -1);
    if (this.nodeId != characterNode.id)
      return;
    this.snowApplied = SaveSystem.LoadCampaignData<bool>(Campaign.Data.GameMode, "DefeatBossWithoutSnowSnowApplied", false);
  }

  private void BattleSaved()
  {
    if (!this.isBossBattle || this.nodeId < 0)
      return;
    SaveSystem.SaveCampaignData<int>(Campaign.Data.GameMode, "DefeatBossWithoutSnowNodeId", this.nodeId);
    SaveSystem.SaveCampaignData<bool>(Campaign.Data.GameMode, "DefeatBossWithoutSnowSnowApplied", this.snowApplied);
  }

  private void BattleEnd()
  {
    if (this.isBossBattle && !this.snowApplied && (Object) References.Battle.winner == (Object) References.Player)
      this.Complete();
    this.isBossBattle = false;
    this.snowApplied = false;
    this.nodeId = -1;
  }
}
