// Decompiled with JetBrains decompiler
// Type: TutorialBattleSystem3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class TutorialBattleSystem3 : TutorialBattleSystem
{
  public Entity chosenUnit;

  public override void BattleStart()
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

  public static Entity FindChosenUnit()
  {
    CardData chosenUnitData = References.PlayerData.inventory.deck.OrderByDescending<CardData, int>((Func<CardData, int>) (a => a.hp)).FirstOrDefault<CardData>((Func<CardData, bool>) (a => !a.cardType.miniboss));
    return Battle.GetCards(References.Player).LastOrDefault<Entity>((Func<Entity, bool>) (a => (long) a.data.id == (long) chosenUnitData.id));
  }

  public class PhaseWaitForLeader : TutorialParentSystem.Phase
  {
    public override void OnEnable()
    {
      global::Events.OnEntityMove += new UnityAction<Entity>(this.EntityMove);
    }

    public override void OnDisable()
    {
      global::Events.OnEntityMove -= new UnityAction<Entity>(this.EntityMove);
    }

    public void EntityMove(Entity entity)
    {
      if (!((UnityEngine.Object) entity.owner == (UnityEngine.Object) References.Player) || !entity.data.cardType.miniboss || !Battle.IsOnBoard(entity))
        return;
      this.enabled = false;
    }
  }

  public class PhasePlaceCompanion : TutorialParentSystem.Phase
  {
    public readonly Entity target;

    public PhasePlaceCompanion(Entity target) => this.target = target;

    public override void OnEnable()
    {
      global::Events.OnCheckAction += new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
      global::Events.OnBattleTurnStart += new UnityAction<int>(this.BattleTurnStart);
      Routine routine = new Routine(this.PromptAfter(0.5f));
    }

    public override void OnDisable()
    {
      global::Events.OnCheckAction -= new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
      global::Events.OnBattleTurnStart -= new UnityAction<int>(this.BattleTurnStart);
      PromptSystem.Hide();
    }

    public IEnumerator PromptAfter(float delay)
    {
      TutorialBattleSystem3.PhasePlaceCompanion phasePlaceCompanion = this;
      yield return (object) new WaitForSeconds(delay);
      if (phasePlaceCompanion.enabled)
      {
        PromptSystem.Create(Prompt.Anchor.Left, 0.1f, 2f, 5f);
        PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => MonoBehaviourSingleton<StringReference>.instance.tutorialBattle3_1.GetLocalizedString()));
      }
    }

    public void CheckAction(ref PlayAction action, ref bool allow)
    {
      if (!allow || this.CorrectAction(action) || TutorialParentSystem.Phase.FreeMoveAction(action) || TutorialParentSystem.Phase.InspectAction(action))
        return;
      allow = false;
      PromptSystem.Shake();
    }

    public void BattleTurnStart(int turn) => this.enabled = false;

    public bool CorrectAction(PlayAction action)
    {
      return action is ActionMove actionMove && actionMove.entity.data.name == this.target.data.name && actionMove.toContainers.Length == 1 && Battle.IsOnBoard(actionMove.toContainers[0].Group);
    }
  }
}
