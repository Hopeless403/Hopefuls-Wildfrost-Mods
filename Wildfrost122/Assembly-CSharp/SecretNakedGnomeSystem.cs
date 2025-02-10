// Decompiled with JetBrains decompiler
// Type: SecretNakedGnomeSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class SecretNakedGnomeSystem : GameSystem
{
  private const string nakedGnomeDataName = "NakedGnome";
  private const string nakedGnomeFriendlyDataName = "NakedGnomeFriendly";
  private static bool nakedGnomeSaved;
  [SerializeField]
  private InspectNewUnitSequence gainNakedGnomeSequencePrefab;
  private static Vector3 startPos = new Vector3(0.0f, 8f, 0.0f);

  private void OnEnable()
  {
    global::Events.OnBattleEnd += new UnityAction(SecretNakedGnomeSystem.BattleEnd);
    global::Events.PostBattle += new UnityAction<CampaignNode>(this.PostBattle);
  }

  private void OnDisable()
  {
    global::Events.OnBattleEnd -= new UnityAction(SecretNakedGnomeSystem.BattleEnd);
    global::Events.PostBattle -= new UnityAction<CampaignNode>(this.PostBattle);
  }

  private static void BattleEnd()
  {
    SecretNakedGnomeSystem.nakedGnomeSaved = (bool) (UnityEngine.Object) Battle.GetCards(References.Battle.enemy).FirstOrDefault<Entity>((Func<Entity, bool>) (a => a.data.name == "NakedGnome"));
  }

  private void PostBattle(CampaignNode campaignNode)
  {
    if (!SecretNakedGnomeSystem.nakedGnomeSaved)
      return;
    ActionQueue.Add((PlayAction) new ActionSequence(this.Sequence()));
    SecretNakedGnomeSystem.nakedGnomeSaved = false;
  }

  private IEnumerator Sequence()
  {
    InspectNewUnitSequence sequence = UnityEngine.Object.Instantiate<InspectNewUnitSequence>(this.gainNakedGnomeSequencePrefab, References.Player.entity.display.transform);
    sequence.cardSelector.character = References.Player;
    sequence.GetComponent<CardSelector>()?.selectEvent.AddListener(new UnityAction<Entity>(global::Events.InvokeEntityChosen));
    Card card = CardManager.Get(AddressableLoader.Get<CardData>("CardData", "NakedGnomeFriendly").Clone(), (CardController) null, References.Player, false, true);
    card.transform.SetParent(sequence.cardHolder);
    card.transform.localPosition = SecretNakedGnomeSystem.startPos;
    yield return (object) card.UpdateData(false);
    sequence.SetUnit(card.entity, false);
    global::Events.InvokeEntityOffered(card.entity);
    yield return (object) sequence.Run();
  }
}
