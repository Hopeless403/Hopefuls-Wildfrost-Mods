// Decompiled with JetBrains decompiler
// Type: DrainLeaderAfterBattleSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class DrainLeaderAfterBattleSystem : GameSystem
{
  [SerializeField]
  public int[] modifyAfterBattleTier = new int[1]{ 5 };
  [SerializeField]
  public CardScript modifyScript;
  [SerializeField]
  public bool modifyLeader;
  [SerializeField]
  [HideIf("modifyLeader")]
  public int modifyCardIndex;
  [SerializeField]
  public ModifyCardSequence sequencePrefab;

  public void OnEnable() => global::Events.OnBattleWinPreRewards += new UnityAction(this.BattleWinPreRewards);

  public void OnDisable() => global::Events.OnBattleWinPreRewards -= new UnityAction(this.BattleWinPreRewards);

  public void BattleWinPreRewards()
  {
    if (!this.modifyAfterBattleTier.Contains<int>(Campaign.FindCharacterNode(References.Player).tier))
      return;
    ActionQueue.Add((PlayAction) new ActionSequence(this.ModifyCardRoutine(this.modifyLeader ? References.LeaderData : References.PlayerData.inventory.deck[this.modifyCardIndex])));
  }

  public IEnumerator ModifyCardRoutine(CardData cardToModify)
  {
    ModifyCardSequence sequence = Object.Instantiate<ModifyCardSequence>(this.sequencePrefab, References.Player.entity.display.transform);
    yield return (object) sequence.Run(cardToModify, this.modifyScript);
    sequence.gameObject.Destroy();
  }
}
