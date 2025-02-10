// Decompiled with JetBrains decompiler
// Type: SecretFinalBossSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class SecretFinalBossSystem : GameSystem
{
  [SerializeField]
  private string[] requireInDeck = new string[1]
  {
    "LuminVase"
  };
  [SerializeField]
  private string targetNodeName = "CampaignNodeFinalBoss";

  private void OnEnable() => global::Events.OnBattleEnd += new UnityAction(this.BattleEnd);

  private void OnDisable() => global::Events.OnBattleEnd -= new UnityAction(this.BattleEnd);

  private void BattleEnd()
  {
    this.CheckContinuePastFinalBoss(Campaign.FindCharacterNode(References.Player));
  }

  private void CheckContinuePastFinalBoss(CampaignNode node)
  {
    if (!node.finalNode || !(node.type.name == this.targetNodeName) || !this.PlayerHasRequiredCards())
      return;
    SaveSystem.SaveCampaignData<bool>(Campaign.Data.GameMode, "trueWin", true);
    node.finalNode = false;
  }

  private bool PlayerHasRequiredCards()
  {
    List<string> list = this.requireInDeck.ToList<string>();
    foreach (CardData cardData in References.PlayerData.inventory.deck)
    {
      int index = list.IndexOf(cardData.name);
      if (index >= 0)
      {
        list.RemoveAt(index);
        if (list.Count <= 0)
          break;
      }
    }
    return list.Count <= 0;
  }
}
