// Decompiled with JetBrains decompiler
// Type: DrainLeaderAfterBattleSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class DrainLeaderAfterBattleSystem : GameSystem
{
  [SerializeField]
  private int[] modifyAfterBattleTier = new int[1]{ 5 };
  [SerializeField]
  private CardScript modifyScript;
  [SerializeField]
  private bool modifyLeader;
  [SerializeField]
  [HideIf("modifyLeader")]
  private int modifyCardIndex;
  [SerializeField]
  private ModifyCardSequence sequencePrefab;

  private void OnEnable()
  {
    global::Events.OnBattleWinPreRewards += new UnityAction(this.BattleWinPreRewards);
  }

  private void OnDisable()
  {
    global::Events.OnBattleWinPreRewards -= new UnityAction(this.BattleWinPreRewards);
  }

  private void BattleWinPreRewards()
  {
    CampaignNodeType type = Campaign.FindCharacterNode(References.Player).type;
    if (!(type is CampaignNodeTypeBattle) || !type.isBoss)
      return;
    CardData highestHealthCard = References.PlayerData.inventory.deck.OrderByDescending<CardData, int>((Func<CardData, int>) (a => a.hp)).FirstOrDefault<CardData>();
    if (!(bool) (UnityEngine.Object) highestHealthCard)
      return;
    CardData cardToModify = References.PlayerData.inventory.deck.Where<CardData>((Func<CardData, bool>) (a => a.hp == highestHealthCard.hp)).InRandomOrder<CardData>().FirstOrDefault<CardData>();
    if (!(bool) (UnityEngine.Object) cardToModify)
      return;
    ActionQueue.Add((PlayAction) new ActionSequence(this.ModifyCardRoutine(cardToModify)));
  }

  private IEnumerator ModifyCardRoutine(CardData cardToModify)
  {
    ModifyCardSequence sequence = UnityEngine.Object.Instantiate<ModifyCardSequence>(this.sequencePrefab, References.Player.entity.display.transform);
    yield return (object) sequence.Run(cardToModify, this.modifyScript);
    sequence.gameObject.Destroy();
  }
}
