// Decompiled with JetBrains decompiler
// Type: DrainLeaderAfterBattleSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

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

  private void OnEnable() => global::Events.OnBattleWinPreRewards += new UnityAction(this.BattleWinPreRewards);

  private void OnDisable() => global::Events.OnBattleWinPreRewards -= new UnityAction(this.BattleWinPreRewards);

  private void BattleWinPreRewards()
  {
    if (!this.modifyAfterBattleTier.Contains<int>(Campaign.FindCharacterNode(References.Player).tier))
      return;
    ActionQueue.Add((PlayAction) new ActionSequence(this.ModifyCardRoutine(this.modifyLeader ? References.LeaderData : References.PlayerData.inventory.deck[this.modifyCardIndex])));
  }

  private IEnumerator ModifyCardRoutine(CardData cardToModify)
  {
    ModifyCardSequence sequence = Object.Instantiate<ModifyCardSequence>(this.sequencePrefab, References.Player.entity.display.transform);
    yield return (object) sequence.Run(cardToModify, this.modifyScript);
    sequence.gameObject.Destroy();
  }
}
