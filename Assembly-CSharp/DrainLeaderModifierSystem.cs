// Decompiled with JetBrains decompiler
// Type: DrainLeaderModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

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
