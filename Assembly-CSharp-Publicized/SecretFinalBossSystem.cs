// Decompiled with JetBrains decompiler
// Type: SecretFinalBossSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SecretFinalBossSystem : GameSystem
{
  [SerializeField]
  public string[] requireInDeck = new string[1]
  {
    "LuminVase"
  };
  [SerializeField]
  public string targetNodeName = "CampaignNodeFinalBoss";

  public void OnEnable() => global::Events.OnBattleEnd += new UnityAction(this.BattleEnd);

  public void OnDisable() => global::Events.OnBattleEnd -= new UnityAction(this.BattleEnd);

  public void BattleEnd() => this.CheckContinuePastFinalBoss(Campaign.FindCharacterNode(References.Player));

  public void CheckContinuePastFinalBoss(CampaignNode node)
  {
    if (!node.finalNode || !(node.type.name == this.targetNodeName) || !this.PlayerHasRequiredCards())
      return;
    SaveSystem.SaveCampaignData<bool>(Campaign.Data.GameMode, "trueWin", true);
    node.finalNode = false;
  }

  public bool PlayerHasRequiredCards()
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
