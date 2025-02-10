// Decompiled with JetBrains decompiler
// Type: DrainLeaderModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class DrainLeaderModifierSystem : GameSystem
{
  private const int addHealth = -1;

  private void OnEnable() => global::Events.PostBattle += new UnityAction<CampaignNode>(this.PostBattle);

  private void OnDisable() => global::Events.PostBattle -= new UnityAction<CampaignNode>(this.PostBattle);

  private void PostBattle(CampaignNode campaignNode)
  {
    CardData cardData = References.PlayerData.inventory.deck.FirstOrDefault<CardData>((Func<CardData, bool>) (a => a.cardType.miniboss));
    if (!(bool) (UnityEngine.Object) cardData || cardData.hp <= 1)
      return;
    int hp = cardData.hp;
    cardData.hp = Mathf.Max(1, cardData.hp - 1);
    Debug.Log((object) string.Format("[{0}] draining leader health ({1} → {2})", (object) this, (object) hp, (object) cardData.hp));
  }
}
