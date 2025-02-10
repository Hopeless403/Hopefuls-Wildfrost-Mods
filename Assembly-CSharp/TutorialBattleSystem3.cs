// Decompiled with JetBrains decompiler
// Type: TutorialBattleSystem3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class TutorialBattleSystem3 : TutorialBattleSystem
{
  private Entity chosenUnit;

  protected override void BattleStart()
  {
    UnityEngine.Object.FindObjectOfType<BattleSaveSystem>()?.Disable();
    this.chosenUnit = TutorialBattleSystem3.FindChosenUnit();
    string[] nextCardNames = new string[6]
    {
      "SnowStick",
      "Sword",
      this.chosenUnit.data.name,
      "SnowStick",
      "PinkberryJuice",
      "Sword"
    };
    References.Player.OrderNextCards(nextCardNames);
    this.phases = new List<TutorialParentSystem.Phase>()
    {
      (TutorialParentSystem.Phase) new TutorialBattleSystem3.PhaseWaitForLeader(),
      (TutorialParentSystem.Phase) new TutorialBattleSystem3.PhasePlaceCompanion(this.chosenUnit)
    };
  }

  private static Entity FindChosenUnit()
  {
    CardData chosenUnitData = References.PlayerData.inventory.deck.OrderByDescending<CardData, int>((Func<CardData, int>) (a => a.hp)).FirstOrDefault<CardData>((Func<CardData, bool>) (a => !a.cardType.miniboss));
    return Battle.GetCards(References.Player).LastOrDefault<Entity>((Func<Entity, bool>) (a => (long) a.data.id == (long) chosenUnitData.id));
  }

  private class PhaseWaitForLeader : TutorialParentSystem.Phase
  {
    protected override void OnEnable() => global::Events.OnEntityMove += new UnityAction<Entity>(this.EntityMove);

    protected override void OnDisable() => global::Events.OnEntityMove -= new UnityAction<Entity>(this.EntityMove);

    private void EntityMove(Entity entity)
    {
      if (!((UnityEngine.Object) entity.owner == (UnityEngine.Object) References.Player) || !entity.data.cardType.miniboss || !Battle.IsOnBoard(entity))
        return;
      this.enabled = false;
    }
  }

  private class PhasePlaceCompanion : TutorialParentSystem.Phase
  {
    private readonly Entity target;

    public PhasePlaceCompanion(Entity target) => this.target = target;

    protected override void OnEnable()
    {
      global::Events.OnCheckAction += new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
      global::Events.OnBattleTurnStart += new UnityAction<int>(this.BattleTurnStart);
      Routine routine = new Routine(this.PromptAfter(0.5f));
    }

    protected override void OnDisable()
    {
      global::Events.OnCheckAction -= new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
      global::Events.OnBattleTurnStart -= new UnityAction<int>(this.BattleTurnStart);
      PromptSystem.Hide();
    }

    private IEnumerator PromptAfter(float delay)
    {
      TutorialBattleSystem3.PhasePlaceCompanion phasePlaceCompanion = this;
      yield return (object) new WaitForSeconds(delay);
      if (phasePlaceCompanion.enabled)
      {
        PromptSystem.Create(Prompt.Anchor.Left, 0.1f, 2f, 5f);
        PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => MonoBehaviourSingleton<StringReference>.instance.tutorialBattle3_1.GetLocalizedString()));
      }
    }

    private void CheckAction(ref PlayAction action, ref bool allow)
    {
      if (!allow || this.CorrectAction(action) || TutorialParentSystem.Phase.FreeMoveAction(action) || TutorialParentSystem.Phase.InspectAction(action))
        return;
      allow = false;
      PromptSystem.Shake();
    }

    private void BattleTurnStart(int turn) => this.enabled = false;

    private bool CorrectAction(PlayAction action) => action is ActionMove actionMove && actionMove.entity.data.name == this.target.data.name && actionMove.toContainers.Length == 1 && Battle.IsOnBoard(actionMove.toContainers[0].Group);
  }
}
