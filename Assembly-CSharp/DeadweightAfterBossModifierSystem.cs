// Decompiled with JetBrains decompiler
// Type: DeadweightAfterBossModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class DeadweightAfterBossModifierSystem : GameSystem
{
  [SerializeField]
  private string cardDataName = "Deadweight";
  [SerializeField]
  private ChooseNewCardSequence gainCardSequencePrefab;

  private void OnEnable() => global::Events.OnBattleWin += new UnityAction(this.BattleWin);

  private void OnDisable() => global::Events.OnBattleWin -= new UnityAction(this.BattleWin);

  private void BattleWin()
  {
    if (!Campaign.FindCharacterNode(References.Player).type.isBoss)
      return;
    ActionQueue.Add((PlayAction) new ActionSequence(this.GainCardRoutine(AddressableLoader.Get<CardData>("CardData", this.cardDataName))));
  }

  private IEnumerator GainCardRoutine(CardData cardData)
  {
    CardData data = cardData.Clone();
    ChooseNewCardSequence sequence = Object.Instantiate<ChooseNewCardSequence>(this.gainCardSequencePrefab, References.Player.entity.display.transform);
    CardSelector componentInChildren = sequence.GetComponentInChildren<CardSelector>();
    if (componentInChildren != null)
    {
      componentInChildren.character = References.Player;
      componentInChildren.selectEvent.AddListener(new UnityAction<Entity>(global::Events.InvokeEntityChosen));
    }
    sequence.owner = References.Player;
    sequence.cardController.owner = References.Player;
    Card card = CardManager.Get(data, sequence.cardController, References.Player, false, true);
    card.entity.flipper.FlipDownInstant();
    sequence.cardContainer.Add(card.entity);
    yield return (object) card.UpdateData(false);
    card.transform.localPosition = Vector3.down;
    card.entity.wobbler.WobbleRandom();
    sequence.cardContainer.TweenChildPositions();
    global::Events.InvokeEntityOffered(card.entity);
    yield return (object) sequence.Run();
    sequence.gameObject.Destroy();
  }
}
