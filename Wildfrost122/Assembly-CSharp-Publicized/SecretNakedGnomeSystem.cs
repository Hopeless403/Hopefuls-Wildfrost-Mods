// Decompiled with JetBrains decompiler
// Type: SecretNakedGnomeSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class SecretNakedGnomeSystem : GameSystem
{
  public const string nakedGnomeDataName = "NakedGnome";
  public const string nakedGnomeFriendlyDataName = "NakedGnomeFriendly";
  public static bool nakedGnomeSaved;
  [SerializeField]
  public InspectNewUnitSequence gainNakedGnomeSequencePrefab;
  public static Vector3 startPos = new Vector3(0.0f, 8f, 0.0f);

  public void OnEnable()
  {
    global::Events.OnBattleEnd += new UnityAction(SecretNakedGnomeSystem.BattleEnd);
    global::Events.PostBattle += new UnityAction<CampaignNode>(this.PostBattle);
  }

  public void OnDisable()
  {
    global::Events.OnBattleEnd -= new UnityAction(SecretNakedGnomeSystem.BattleEnd);
    global::Events.PostBattle -= new UnityAction<CampaignNode>(this.PostBattle);
  }

  public static void BattleEnd()
  {
    SecretNakedGnomeSystem.nakedGnomeSaved = (bool) (UnityEngine.Object) Battle.GetCards(References.Battle.enemy).FirstOrDefault<Entity>((Func<Entity, bool>) (a => a.data.name == "NakedGnome"));
  }

  public void PostBattle(CampaignNode campaignNode)
  {
    if (!SecretNakedGnomeSystem.nakedGnomeSaved)
      return;
    ActionQueue.Add((PlayAction) new ActionSequence(this.Sequence()));
    SecretNakedGnomeSystem.nakedGnomeSaved = false;
  }

  public IEnumerator Sequence()
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
