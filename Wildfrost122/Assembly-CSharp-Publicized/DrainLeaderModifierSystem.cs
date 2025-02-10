// Decompiled with JetBrains decompiler
// Type: DrainLeaderModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class DrainLeaderModifierSystem : GameSystem
{
  public const int addHealth = -1;

  public void OnEnable() => global::Events.PostBattle += new UnityAction<CampaignNode>(this.PostBattle);

  public void OnDisable() => global::Events.PostBattle -= new UnityAction<CampaignNode>(this.PostBattle);

  public void PostBattle(CampaignNode campaignNode)
  {
    CardData cardData = References.PlayerData.inventory.deck.FirstOrDefault<CardData>((Func<CardData, bool>) (a => a.cardType.miniboss));
    if (!(bool) (UnityEngine.Object) cardData || cardData.hp <= 1)
      return;
    int hp = cardData.hp;
    cardData.hp = Mathf.Max(1, cardData.hp - 1);
    Debug.Log((object) string.Format("[{0}] draining leader health ({1} → {2})", (object) this, (object) hp, (object) cardData.hp));
  }
}
